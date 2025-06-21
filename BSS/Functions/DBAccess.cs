using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Data.SqlClient;
using BssBase;
using System.Security;
using System.Threading.Tasks;

namespace BSS
{

    /// <summary>
    /// Database access generics
    /// </summary>
    public static class DBAccess
    {
    
        public static void CheckForDatabaseChanges(Utility.ModifyRegistry.ModifyRegistry RegistryData, bool forceUpdate = false)
        {
            //if (System.Diagnostics.Debugger.IsAttached) return;

            if (RegistryData.Read("VersionBeforeUpdate", 1.ToString()) != RegistryData.Read("Version", Application.ProductVersion) || forceUpdate)
            {
                DialogResult opc;
                opc = MessageBox.Show(
                    Tools.PrevediPoraka("Превземи измени за датабаза"), string.Empty,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                    {
                        con.Open();
                        using (SqlCommand com = new SqlCommand(@"IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name LIKE 'changelog')
                        BEGIN
                            PRINT 'Created changelog'
                        CREATE TABLE[dbo].[changelog](

                            [change_number][int] NOT NULL,

                            [complete_dt][datetime] NULL,

                            [applied_by][varchar](100) NOT NULL,

                            [description][varchar](500) NOT NULL,
                            CONSTRAINT[Pkchangelog] PRIMARY KEY CLUSTERED
                                (

                            [change_number] ASC
                            )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
                            ) ON[PRIMARY]
                        END
                        SELECT * FROM dbo.changelog", con))
                        {
                            com.CommandType = CommandType.Text;

                            DataTable scriptsExecuted = new DataTable();
                            scriptsExecuted.Load(com.ExecuteReader());
                            string path = Application.StartupPath + @"\SQL\";
                            if (System.Diagnostics.Debugger.IsAttached)
                            {
                                path = "D:\\Projects\\GitSpiro\\BSS\\BSSR\\UpdateScripts\\";
                            }
                            foreach (string sqlScriptFile in Directory.GetFiles(path).Where(fileName => fileName.ToLower().EndsWith(".sql")))
                            {
                                FileInfo fileInfo = new FileInfo(sqlScriptFile);
                                if (Regex.IsMatch(fileInfo.Name, "^[0-9]*"))
                                {
                                    int Id = Tools.PrazenStringToInt(fileInfo.Name.Split(' ').First().Trim());
                                    bool alreadyExecuted = false;

                                    if (scriptsExecuted.Rows.Count > 0)
                                    {
                                        alreadyExecuted = scriptsExecuted.AsEnumerable().Any(row => row.Field<Int32>("change_number") == Id);
                                    }

                                    if (!alreadyExecuted)
                                    {
                                        try
                                        {

                                            using (SqlConnection conn = new SqlConnection(BssBase.settings.konekcija))
                                            {
                                                Server db = new Server(new ServerConnection(conn));
                                                string script = File.ReadAllText(sqlScriptFile);
                                                db.ConnectionContext.ExecuteNonQuery(script);
                                            }

                                            com.Parameters.Clear();
                                            com.Parameters.AddWithValue("@Id", Id);
                                            com.Parameters.AddWithValue("@User", "Update");
                                            com.Parameters.AddWithValue("@Description", fileInfo.Name);

                                            com.CommandText =
                                                "INSERT INTO dbo.changelog VALUES (@Id,GETDATE(),@User,@Description); delete from tblUserConfigs";
                                            com.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            Tools.LogExceptionMessageWithScreenShoot(ex, sqlScriptFile + " Throws exception " + ex.Message, true);
                                            MessageBox.Show("Не Успешно завршено");
                                            return;
                                        }
                                    }
                                }
                            }

                            RegistryData.Write("VersionBeforeUpdate", Application.ProductVersion, false);
                            RegistryData.Write("Version", Application.ProductVersion, false);
                            RegistryData.ExportRegistry($@"{settings.BackupNaServerPateka}\{tmpConfigs.databaseName}.reg");
                            MessageBox.Show("Успешно завршено");
                        }
                    }

                    
                    var dbconfigsTable = dbFunctions.ConfigsToDatabase(true);
                    Tools.LogObjectInfo("DB Configs write", dbconfigsTable);

                }
            }
        }

        /// <summary>
        /// Connection string to DB
        /// </summary>
        /// <summary>
        /// Backup a whole database to the specified file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to hold the backup</param>
        /// <param name="DbName"></param>
        public static void BackupDatabase(string backUpFile, string DbName)
        {
            try
            {
                ServerConnection con = new ServerConnection(BssBase.settings.konekcija);
                Server server = new Server(con);
                Backup source = new Backup();
                source.Action = BackupActionType.Database;
                source.Database = DbName;

                BackupDeviceItem destination = new BackupDeviceItem(backUpFile, DeviceType.File);
                source.Devices.Add(destination);
                source.SqlBackup(server);
                con.Disconnect();
                System.Windows.Forms.MessageBox.Show("Done", "Database backup", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (SqlServerManagementException ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        public static void ExecuteRestoreDb(string filePath,string databaseName, ServerConnection connection)
        {
            try
            {
                //Action Type
                Restore sqlRestore = new Restore();

                BackupDeviceItem deviceItem = new BackupDeviceItem(filePath, DeviceType.File);
                sqlRestore.Devices.Add(deviceItem);
                sqlRestore.Database = databaseName;

                Server sqlServer = new Server(connection);

                Database db = sqlServer.Databases[databaseName];
                sqlRestore.Action = RestoreActionType.Database;

                //Create The Restore Database Ldf & Mdf file name
                string restoreFolder = $"C:\\BSS_{DateTime.Now.Year}\\DATA_{DateTime.Now.Year}\\";
                if (!Directory.Exists(restoreFolder)) Directory.CreateDirectory(restoreFolder);
                string dataFileLocation = $"{restoreFolder}\\{databaseName}.mdf";
                string logFileLocation = dataFileLocation.Replace(".mdf", "_Log.ldf");
                db = sqlServer.Databases[databaseName];
                RelocateFile rf = new RelocateFile(databaseName, dataFileLocation);

                using (System.Data.DataTable logicalRestoreFiles = sqlRestore.ReadFileList(sqlServer))
                {
                    sqlRestore.RelocateFiles.Add(new RelocateFile(logicalRestoreFiles.Rows[0][0].ToString(), dataFileLocation));
                    sqlRestore.RelocateFiles.Add(new RelocateFile(logicalRestoreFiles.Rows[1][0].ToString(), logFileLocation));
                }

                sqlRestore.ReplaceDatabase = true;

                sqlRestore.SqlRestore(sqlServer);
                db = sqlServer.Databases[databaseName];
                db.SetOnline();
                sqlServer.Refresh();
                MessageBox.Show("Restored Succefully");
            }
            catch (Exception ex)
            {
                Tools.LogException("Restore failed", ex);
            }
        }

        public static void BackupDatabaseOnServerAsync(string path = "")
        {
            
            Task.Factory.StartNew(() =>
            {

                try
                {

                    string sql = $@"CREATE OR ALTER PROCEDURE  Backup_databases
                                    AS
                                    BEGIN
	
                                    DECLARE @name NVARCHAR(256) -- database name  
                                    DECLARE @path NVARCHAR(512) -- path for backup files  
                                    DECLARE @fileName NVARCHAR(512) -- filename for backup  
                                    DECLARE @fileDate NVARCHAR(40) -- used for file name
 
                                    -- specify database backup directory
                                    SET @path = '{settings.BackupNaServerPateka}'  
 
                                    -- specify filename format
                                    SELECT @fileDate = CONVERT(NVARCHAR(20),GETDATE(),112) 
 
                                    DECLARE db_cursor CURSOR READ_ONLY FOR  
                                    SELECT name 
                                    FROM master.sys.databases 
                                    WHERE name IN ('{BssBase.tmpConfigs.databaseName}')  -- exclude these databases
                                    AND state = 0 -- database is online
                                    AND is_in_standby = 0 -- database is not read only for log shipping
 
                                    OPEN db_cursor   
                                    FETCH NEXT FROM db_cursor INTO @name   
 
                                    WHILE @@FETCH_STATUS = 0   
                                    BEGIN   
                                       SET @fileName = @path + @name + '_' + @fileDate + '.BAK'  
                                       BACKUP DATABASE @name TO DISK = @fileName WITH NOFORMAT, INIT, SKIP, NOREWIND, NOUNLOAD,  STATS = 10 
 
                                       FETCH NEXT FROM db_cursor INTO @name   
                                    END   
 
                                    CLOSE db_cursor   
                                    DEALLOCATE db_cursor
                                    END
                                    

                                   ";

                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand(sql, con))
                        {
                            con.Open();
                            com.ExecuteNonQuery();

                        }
                    }

                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand("exec Backup_databases", con))
                        {
                            con.Open();
                            com.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message);
                    if(!Directory.Exists("C:\\BSS_EXPORT\\BackUpDB\\"))
                    {
                        Directory.CreateDirectory("C:\\BSS_EXPORT\\BackUpDB\\");
                        settings.InitSettings.WriteToRegistry("BackupNaServerPateka", "C:\\BSS_EXPORT\\BackUpDB\\");
                    }
                    else
                    {
                        settings.InitSettings.WriteToRegistry("BackupNaServerPateka", "");
                    }
                    return;
                }
            });
        }

        public static void BackupDatabaseAsync(string fileName = "")
        {
            Task.Factory.StartNew(() =>
            {

                try
                {
                    if (String.IsNullOrEmpty(fileName)) fileName = Application.StartupPath;
                    string sql = string.Format(@"BACKUP DATABASE [{0}] TO  DISK = N'{1}\{0}.bak' WITH NOFORMAT, NOINIT,  NAME = N'{0}>-Full Database Backup', SKIP, STATS = 10;", tmpConfigs.databaseName, fileName);
                    if (File.Exists(string.Format(@"{0}\{1}.bak", fileName, tmpConfigs.databaseName))) File.Delete(string.Format(@"{0}\{1}.bak", fileName, tmpConfigs.databaseName));
                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand(sql, con))
                        {
                            con.Open();
                            com.ExecuteNonQuery();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    settings.InitSettings.WriteToRegistry("BackupNaStartUp", "false");
                }
                catch (Exception ex)
                {
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message);
                   
                    return;
                }
            });
        }
        /// <summary>
        /// Restore a whole database from a backup file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to holding the backup</param>
        public static void RestoreDatabase(string backUpFile)
        {
            var secPassword = new SecureString();
            secPassword.AppendChar('n');
            secPassword.AppendChar('i');
            secPassword.AppendChar('r');
            secPassword.AppendChar('v');
            secPassword.AppendChar('a');
            secPassword.AppendChar('n');
            secPassword.AppendChar('a');

            ServerConnection con = new ServerConnection("(local)","spiro", secPassword);
            
            var databaseName = InputBox.Show(Tools.PrevediPoraka("Име на датабаза"), Tools.PrevediPoraka("Име на датабаза")).Text;
            ExecuteRestoreDb(backUpFile, databaseName, con);
            
        }


    }
}
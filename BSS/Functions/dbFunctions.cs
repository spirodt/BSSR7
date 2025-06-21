using Dapper;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class dbFunctions
{
    public static int getNextId(string tableName)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("SELECT IDENT_CURRENT('" + tableName + "') + 1", con);
        try
        {
            con.Open();
            var rez = Tools.PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
            con.Close();
            return rez;
        }
        catch (Exception ex)
        {
            Tools.PrevediSQLException(ex);

            return -1;
        }
    }

    public static DataTable DbArtikli;


    public static bool DaliSmetkataZaStorniranjeNaFiskalnaESoDenesenDatum(int SmetkaID)
    {
        int Den = DateTime.Now.Day; int mesec = DateTime.Now.Month;
        int godina = DateTime.Now.Year;

        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            try
            {
                using (SqlCommand com = new SqlCommand(@"select * from tblFiskalniSmetki where 
                                                        tblSmetkaID = @SmetkaID and DAY(@day) = DAY(Datum) 
                                                        and Month(@month) = Month(Datum) and YEAR(@year) = YEAR(Datum)", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                    com.Parameters.AddWithValue("@day", Den);
                    com.Parameters.AddWithValue("@month", mesec);
                    com.Parameters.AddWithValue("@year", godina);
                    var rez = com.ExecuteReader();
                    if (rez.HasRows)
                        return true;

                    else return false;
                }
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return false;
            }
        }
    }

    public static bool DaliSmetkataEZatvorena(int SmetkaID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            try
            {
                using (SqlCommand com = new SqlCommand("select ID from tblSmetka where ID = @SmetkaID and Zatvorena = 'true'", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                    var rez = com.ExecuteScalar();
                    if (Equals(null, rez))
                    {
                        return false;
                    }

                    if (Equals(null, DBNull.Value))
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return false;
            }
        }
    }

    public static bool DaliImaFiskalnaIspecateno(int SmetkaID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            try
            {
                using (SqlCommand com = new SqlCommand("select dbo.IznosOdFiskalna(@SmetkaID)", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                    var rez = com.ExecuteScalar();
                    if (Equals(null, rez))
                    {
                        return false;
                    }

                    if (Equals(null, DBNull.Value))
                    {
                        return false;
                    }

                    if (Tools.PrazenStringToDecimal(rez.ToString()) > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return false;
            }
        }
    }

    public static bool DaliImaImaKnizeno(int SmetkaID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            try
            {
                using (SqlCommand com = new SqlCommand("select dbo.IznosOdKnizenjeSmetka(@SmetkaID)", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                    var rez = com.ExecuteScalar();
                    if (Equals(null, rez))
                    {
                        return false;
                    }

                    if (Equals(null, DBNull.Value))
                    {
                        return false;
                    }

                    if (Tools.PrazenStringToDecimal(rez.ToString()) > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return false;
            }
        }
    }

    public static void DeleteAllSettings()
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("delete from tblUserConfigs;", con))
            {
                com.Parameters.Clear();
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Операцијата заврши успешно");
            }
        }
    }

    public static DataTable ConfigsToDatabase(bool writeToDb = false)
    {

        Utility.ModifyRegistry.ModifyRegistry RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
        RegistryData.SubKey = BssBase.settings.RegPath;
        DataTable db = new DataTable();
        db.TableName = "tblClientConfiguracija";
        db.Columns.Add("Setting");
        db.Columns.Add("Value");
        db.Columns.Add("Info");

        string[] names = RegistryData.BaseRegistryKey.OpenSubKey(RegistryData.SubKey)?.GetValueNames();
        Array.Sort<string>(names);
        foreach (string name in names)
        {
            string setting = name;
            string value = RegistryData.Read(name).ToString();
            DataRow row = db.NewRow();
            row["Setting"] = setting;
            row["Value"] = value;
            row["Info"] = Tools.PrevediPoraka(name);
            db.Rows.Add(row);
        }

        if (writeToDb)
        {
            DropAndRecreateConfigs(db);
        }
        return db;
    }
    public static void reWriteConfigsFromDB()
    {
        var RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
        RegistryData.SubKey = BssBase.settings.RegPath;
        using (var connection = new SqlConnection(BssBase.settings.konekcija))
        {
            try
            {
                var sql = "select Setting,[Value]from tblClientConfiguracija Where Setting NOT in ('Server','DatabasePassword','DatabaseUserName')";
                DataTable registriData = new DataTable(); 

                using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        registriData.Load(com.ExecuteReader());
                        
                            foreach (DataRow row in registriData.Rows)
                            {
                                RegistryData.Write(row["Setting"].ToString(), row["Value"].ToString());
                            }
                    }
                }

                MessageBox.Show("Fininshed succesfully");
            }
            catch (Exception ex)
            {
                Tools.LogException("Error writting to registy ", ex);
            }
        }
    }
    public static void DropAndRecreateConfigs(DataTable table)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(BssBase.settings.konekcija))
            {
                connection.Open();

                connection.Execute(@"IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tblClientConfiguracija')
                    BEGIN 
                        DROP TABLE tblClientConfiguracija 
                    END
                        CREATE TABLE tblClientConfiguracija  
                        (
	                        [ID] [int] IDENTITY(1,1) NOT NULL, 
	                        [Setting] Nvarchar(max) NULL, 
	                        [Value] Nvarchar(max) NULL,
	                        [Info] Nvarchar(max) NULL,
                            PRIMARY KEY (ID)
                        )
                    ");
                foreach (DataRow rowvalue in table.Rows)
                {
                    connection.Execute(@"INSERT INTO [dbo].[tblClientConfiguracija] ([Setting]
                                                                                ,[Value]
                                                                                ,[Info] ) VALUES (@Setting,@Value,@Info)", new
                    {
                        Setting = rowvalue["Setting"].ToString(),
                        Value = rowvalue["Value"].ToString(),
                        Info = rowvalue["Info"].ToString(),
                    });
                }

            }
        }
        catch (SqlException sqlExcpetion)
        {
            Tools.PrevediSQLException(sqlExcpetion, "Kreiranje na config");
        }
        catch (Exception ex)
        {
            Tools.LogException("Problem so DropAndRecreateConfigs", ex);
        }
    }

    public static void StornirajKnizenja(int Tip)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("delete from tblKnizenjeM where tipNaKnizenje = @TIP", con))
            {
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@TIP", Tip);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Операцијата заврши успешно");
            }
        }
    }

    public static int getLastId(string tableName)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("SELECT IDENT_CURRENT('" + tableName + "')", con);
        try
        {
            con.Open();
            var rez = Tools.PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
            con.Close();
            return rez;
        }
        catch (Exception ex)
        {
            Tools.PrevediSQLException(ex);
            return -1;
        }
    }
}
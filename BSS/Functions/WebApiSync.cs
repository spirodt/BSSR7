using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BssBase.Functions
{
    public class WebApiSync : IWebApiSync
    {
        private List<String> tablesToBeMergedUpdated;
        private List<String> tablesToInsertedToServer;
        private List<String> TablesToBeChecked;
        private BSSWebApi.Models.BSyncModel _userFromModel;
        private DevExpress.XtraBars.Alerter.AlertControl _alertControl;
        private Form _parentForm;
        private ToolStripProgressBar _progressBar;
            public WebApiSync(ToolStripProgressBar progressBar, DevExpress.XtraBars.Alerter.AlertControl alertControl, Form parentForm)
        {
            _progressBar = progressBar;
            _alertControl = alertControl;
            _parentForm = parentForm;
            tablesToBeMergedUpdated = new List<string>
            {
                "tblArtikal",
                "tblNormativ",
                "tblNormativStavki",
                "tblGrupaNaArtikli",
                "tblPodgrupaID",
                "tblAkcijaNaArtikal",
                "tblPrevodi",
                "tblUsers",
                "tblBanki",
                "tblZiroSmetki",
                "tblPartneri",
                "tblPriem",
                "tblPriemStavki",
                "tblDokumenti",
                "tblDokumentStavki",
                "tblFaktura",
                "tblFakturaStavki"
            };

            tablesToInsertedToServer = new List<string>()
            {
                "tblSmetka",
                "tblNalog",
                "tblNalogStavki",
                "tblSmetkaStavki",
                "tblFiskalniSmetki"

            };
            _userFromModel = new BSSWebApi.Models.BSyncModel();
            _userFromModel.DatabaseName = BssBase.settings.DatabaseNameToSync_API;
            _userFromModel.ServerName = BssBase.settings.ServerNameToSync_API;
        }


        public BSSWebApi.Models.BSyncModel GetUpdatesForTableFromServer(string ids, string tableName)
        {
            _userFromModel.DateTimeOfTheRequest = DateTime.Now;
            var request = new RestRequest("Sync/GetUpdatesForTableFromServer", Method.Search);
            request.RequestFormat = DataFormat.Json;
            _userFromModel.Result = ids;
            _userFromModel.TableName = tableName;
            var json = JsonConvert.SerializeObject(_userFromModel);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

            var result = new RestClient(BssBase.settings.ServerPathToSync_API).Execute(request);

            return JsonConvert.DeserializeObject<BSSWebApi.Models.BSyncModel>(result.Content);
        }

        public BSSWebApi.Models.BSyncModel GetTableWithChangesFrom(DateTime datetime)
        {
            _userFromModel.DateTimeOfTheRequest = DateTime.Now;
            var request = new RestRequest("Sync/GetTablesWithChanges", Method.Search);
            request.RequestFormat = DataFormat.Json;
            _userFromModel.Result = datetime;
            var json = JsonConvert.SerializeObject(_userFromModel);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

            var result = new RestClient(BssBase.settings.ServerPathToSync_API).Execute(request);

            return JsonConvert.DeserializeObject<BSSWebApi.Models.BSyncModel>(result.Content);
        }

        public int SendData(DataSet db)
        {
            _userFromModel.DateTimeOfTheRequest = DateTime.Now;
            var request = new RestRequest("Sync/InsertSmetki", Method.Search);
            request.RequestFormat = DataFormat.Json;
            _userFromModel.DatabaseName = BssBase.settings.DatabaseNameToSync_API;
            _userFromModel.tblSmetka = db.Tables[0];
            _userFromModel.tblNalog = db.Tables[1];
            _userFromModel.tblNalogStavki = db.Tables[2];
            _userFromModel.tblSmetkaStavki = db.Tables[3];
            _userFromModel.tblFiskalniSmetki = db.Tables[4];
            var json = JsonConvert.SerializeObject(_userFromModel);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

            var result = new RestClient(BssBase.settings.ServerPathToSync_API).Execute(request);

            return JsonConvert.DeserializeObject<int>(result.Content);
        }
        public int GetAllDataForInsertFromLocalForSYNC(DateTime dateTime, bool force)

        {

            try { 
                DevExpress.XtraBars.Alerter.AlertInfo startAlert = new DevExpress.XtraBars.Alerter.AlertInfo("Синхронизација ", "Синхронизацијата започна ");

                _alertControl.Show(_parentForm, startAlert);

                _progressBar.Value = 50;
                _progressBar.Maximum = 100;
                DataSet result = null;
                bool writeChanges = false;
                
                do
                {
                    writeChanges = false;
                    
                    var StartDateTime = new DateTime( dateTime.Year, dateTime.Month, dateTime.Day,0,0,0);
                    var EndDateTime = new DateTime( dateTime.Year, dateTime.Month, dateTime.Day,23,59,59);

                    result = Tools.GetChangesFromTables(StartDateTime,EndDateTime);

                    if(result.Tables !=null && result.Tables[0].Rows.Count < 1)
                    {
                        DevExpress.XtraBars.Alerter.AlertInfo endAlert = new DevExpress.XtraBars.Alerter.AlertInfo("Нема нови податоци ", "Синхронизацијата Заврши ");
                        _alertControl.Show(_parentForm, endAlert);
                        _progressBar.Value = 0;
                        _progressBar.Maximum = 100;
                    }

                    if(SendData(result) != -1)
                    {
                        _progressBar.Value = 100;
                        _progressBar.Value = 0;
                        _progressBar.Maximum = 100;
                        writeChanges = true;      
                    }
                        BssBase.settings.LastInsertToServerFrom_API = EndDateTime.ToString();
                        Utility.ModifyRegistry.ModifyRegistry regWrite = new Utility.ModifyRegistry.ModifyRegistry();
                        regWrite.SubKey = BssBase.settings.RegPath;
                        regWrite.Write("LastInsertToServerFrom_API", BssBase.settings.LastInsertToServerFrom_API);

                    dateTime = dateTime.AddDays(1);
                } while (dateTime <= DateTime.Now);
                
                if(writeChanges)
                {
                      //update last updated if everything is succesfull
                
                        DevExpress.XtraBars.Alerter.AlertInfo endAlert = new DevExpress.XtraBars.Alerter.AlertInfo("Синхронизација ", "Синхронизацијата Заврши ");

                        _alertControl.Show(_parentForm, endAlert);
                }

                return result.Tables.Count;
            } catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);
            }
            return 0;
        }
        public int GetAllDataFromServerForSYNC(DateTime dateTime, bool force)

        {
            if (!force)
            {
                var result = GetTableWithChangesFrom(dateTime);
                if (result != null && result.ResultsDataTable != null)
                {
                    TablesToBeChecked = new List<string>();
                    foreach (DataRow item in result.ResultsDataTable.Rows)
                    {
                        if (tablesToBeMergedUpdated.Contains(item["name"].ToString()))
                        {
                            TablesToBeChecked.Add(item["name"].ToString());
                        }
                    }
                    
                    ProcessData(TablesToBeChecked);
                    return TablesToBeChecked.Count;
                }
            }
            else
            {
                ProcessData(tablesToBeMergedUpdated);
                return 0;
            }
            return 0;

        }
        public void ProcessData(List<string> checkTables)
        {
            bool result = false;
            List<bool> rez = new List<bool>();
            _progressBar.Maximum = checkTables.Count;
            _progressBar.Value = 0;
            DevExpress.XtraBars.Alerter.AlertInfo startAlert = new DevExpress.XtraBars.Alerter.AlertInfo("Синхронизација ", "Синхронизацијата започна ");

            _alertControl.Show(_parentForm, startAlert);
            foreach (string table in checkTables)
            {
                try { 
                _progressBar.Value = _progressBar.Value + 1;
                var DataForUpdateLocaly = sendRequestPerTable(table);
                result = CheckForChangesAndUpdateLocal(DataForUpdateLocaly, table);
                rez.Add(result);
                
                DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo("Синхронизација ", "Sync table : " + Environment.NewLine + result.ToString()  + " -> " + table);
                
                _alertControl.Show(_parentForm, info);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Tools.LogException(ex.Message,ex);
                }
            }

            if (checkTables.Count > 0 && !rez.Contains(false))
            {
                System.Windows.Forms.MessageBox.Show("Успешна синхронизација");
                _progressBar.Value = 0;
                _progressBar.Maximum = 100;
                //update last updated if everything is succesfull
                BssBase.settings.LastCheckForUpdateFrom_API = DateTime.Now.ToString();
                Utility.ModifyRegistry.ModifyRegistry regWrite = new Utility.ModifyRegistry.ModifyRegistry();
                regWrite.SubKey = BssBase.settings.RegPath;
                regWrite.Write("LastCheckForUpdateFrom_API", BssBase.settings.LastCheckForUpdateFrom_API);
            }
            else
            {
                _progressBar.Value = _progressBar.Maximum;
                _progressBar.Maximum = 100;
                System.Windows.Forms.MessageBox.Show("Не Успешна синхронизација");
            }
            DevExpress.XtraBars.Alerter.AlertInfo endAlert = new DevExpress.XtraBars.Alerter.AlertInfo("Синхронизација ", "Синхронизацијата Заврши ");

            _alertControl.Show(_parentForm, endAlert);
        }

        public DataTable getDifferentRecords(DataTable FirstDataTable, DataTable SecondDataTable)
        {

            //Create Empty Table 
            DataTable ResultDataTable = new DataTable("ResultDataTable");

            //use a Dataset to make use of a DataRelation object 
            using (DataSet ds = new DataSet())
            {

                //Add tables 
                ds.Tables.AddRange(new DataTable[] { FirstDataTable.Copy(), SecondDataTable.Copy() });

                //Get Columns for DataRelation 
                DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];
                for (int i = 0; i < firstColumns.Length; i++)
                {
                    firstColumns[i] = ds.Tables[0].Columns[i];
                }

                DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
                for (int i = 0; i < secondColumns.Length; i++)
                {
                    secondColumns[i] = ds.Tables[1].Columns[i];
                }

                //Create DataRelation 
                DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
                ds.Relations.Add(r1);

                DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
                ds.Relations.Add(r2);

                //Create columns for return table 
                for (int i = 0; i < FirstDataTable.Columns.Count; i++)
                {
                    ResultDataTable.Columns.Add(FirstDataTable.Columns[i].ColumnName, FirstDataTable.Columns[i].DataType);
                }

                //If FirstDataTable Row not in SecondDataTable, Add to ResultDataTable. 
                ResultDataTable.BeginLoadData();
                foreach (DataRow parentrow in ds.Tables[0].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r1);
                    if (childrows == null || childrows.Length == 0)
                        ResultDataTable.LoadDataRow(parentrow.ItemArray, true);
                }

                //If SecondDataTable Row not in FirstDataTable, Add to ResultDataTable. 
                foreach (DataRow parentrow in ds.Tables[1].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r2);
                    if (childrows == null || childrows.Length == 0)
                        ResultDataTable.LoadDataRow(parentrow.ItemArray, true);
                }
                ResultDataTable.EndLoadData();
            }
            return ResultDataTable;
        }


        public bool CheckForChangesAndUpdateLocal(BSSWebApi.Models.BSyncModel data, string table)
        {
            try
            {
                if (data != null)
                {
                    var dbServer = data.ResultsDataTable;
                    var dbLocal = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(Tools.GetDataversionFromDb(table)));


                    if (dbServer != null && dbLocal != null)
                    {
                        if (dbServer.Columns.Count < 1 || dbServer.Rows.Count < 1)
                        {
                            Tools.LogWriteText("There is no data " + table);
                            return true;
                        }
                        if (dbLocal.Columns.Count < 1 || dbLocal.Rows.Count < 1)
                        {
                            Tools.LogWriteText("empty local table  " + table);
                            var IdsToGetFromDb = string.Join(",", dbServer.Rows.OfType<DataRow>().AsEnumerable().Select(dr => dr.Field<System.Int64>("ID")).ToList().Distinct());
                            var currebtdb = GetUpdatesForTableFromServer(IdsToGetFromDb, table);
                            return Tools.Execute_Sp_For_Merge(table, currebtdb.ResultsDataTable);
                        }
                        else
                        {
                            var differences = getDifferentRecords(dbServer, dbLocal).Rows.OfType<DataRow>().AsEnumerable().Select(dr => dr.Field<System.Int64>("ID")).ToList().Distinct();
                            if (differences.Any())
                            {
                                Tools.LogWriteText("has diffrece " + table);
                                var IdsToGetFromDb = string.Join(",", differences);
                                var currebtdb = GetUpdatesForTableFromServer(IdsToGetFromDb, table);
                                return Tools.Execute_Sp_For_Merge(table, currebtdb.ResultsDataTable);

                            }
                            else
                            {
                                Tools.LogWriteText("No diffrece " + table);
                                return true;
                            }

                        }
                    }
                    else
                    {
                        Tools.LogWriteText("EMPTY !!! " + table);
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);
                Tools.LogWriteText("Crash !!! " + table + Environment.NewLine + ex.Message);
            }
            return false;
        }

        public BSSWebApi.Models.BSyncModel GetValuesFromServerDatabase(string tableName, string ids)
        {
            _userFromModel.DateTimeOfTheRequest = DateTime.Now;
            var request = new RestRequest("Sync/GetChangesForSpecifictable", Method.Search);
            request.RequestFormat = DataFormat.Json;
            _userFromModel.Result = ids;
            //_userFromModel.
            var json = JsonConvert.SerializeObject(_userFromModel);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            var result = new RestClient(BssBase.settings.ServerPathToSync_API).Execute(request);

            return JsonConvert.DeserializeObject<BSSWebApi.Models.BSyncModel>(result.Content);
        }
        public BSSWebApi.Models.BSyncModel sendRequestPerTable(string tableName)
        {
            _userFromModel.DateTimeOfTheRequest = DateTime.Now;
            var request = new RestRequest("Sync/GetChangesForSpecifictable", Method.Search);
            request.RequestFormat = DataFormat.Json;
            _userFromModel.ResultsDataTable = Tools.GetDataversionFromDb(tableName);
            _userFromModel.Result = tableName;
            var json = JsonConvert.SerializeObject(_userFromModel);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            var result = new RestClient(BssBase.settings.ServerPathToSync_API).Execute(request);

            return JsonConvert.DeserializeObject<BSSWebApi.Models.BSyncModel>(result.Content);
        }
        public void GetAllData()
        {
            GetAllDataFromServerForSYNC(Convert.ToDateTime(BssBase.settings.LastCheckForUpdateFrom_API), false);
        }

        public void SendAllData()
        {
            GetAllDataForInsertFromLocalForSYNC(Convert.ToDateTime(BssBase.settings.LastInsertToServerFrom_API), false);
        }

        public void SyncAllData()
        {
            //force sync update
            GetAllDataFromServerForSYNC(Convert.ToDateTime(BssBase.settings.LastCheckForUpdateFrom_API), true);
            //force sync insert
            GetAllDataForInsertFromLocalForSYNC(Convert.ToDateTime(BssBase.settings.LastInsertToServerFrom_API), true);
        }
    }
}

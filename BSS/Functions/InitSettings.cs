using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BssBase
{
    public static partial class settings
    {
        public static string testDelay;

        public static string PrintFolder { get; set; }
        public static bool NovNacinNaKnizenjeDokumenti { get; set; }

        public static void ExportAllSettings(string path = null)
        {
            try
            {
                
                var datatable = dbFunctions.ConfigsToDatabase();
                if (string.IsNullOrEmpty(path))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                    saveFileDialog.ShowDialog();
                    path = saveFileDialog.FileName;
                }
                File.WriteAllText(path, Tools.DataTableToJSONWithJSONNet(datatable));

            }catch(Exception ex)
            {
                Tools.LogException("JsonImport Export", ex);
            }
        }

        public static void ImportDefaultSettingsIntoRegistry(string fileWithConfigs =null, Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
        {
            try
            {
                DataTable db = null; 
                if (string.IsNullOrEmpty(fileWithConfigs))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                    saveFileDialog.ShowDialog();
                    fileWithConfigs = File.ReadAllText(saveFileDialog.FileName);
                }
                db= Tools.DataTableFromJSONWithJSONNet(fileWithConfigs);
                foreach (DataRow dataRow in db.Rows)
                {
                    RegistryData.Write(dataRow["Setting"].ToString(), dataRow["Value"].ToString());
                }

            }
            catch (Exception ex)
            {
                Tools.LogException("JsonImport Failed", ex);
            }
        }

        public static class InitSettings
        {
            public static void WriteToRegistry(string name, string value, Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                if (RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = RegPath;
                    RegistryData.Write(name, value, false);
                    ReloadAllConfigs(RegistryData);
                }
            }

            public static void ReloadAllConfigs(Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                try
                {
                    ReadDataSettingsFromRegistry(RegistryData);
                    ReadUpdateServerSettings(RegistryData);
                    ReadTmpConfigSetingsFromRegistry(RegistryData);
                    ReadMKelnerSettingsFromRegistry(RegistryData);
                }catch (Exception ex)
                {
                    Tools.LogException(ex.Message, ex);
                }
            }
            public static void ReadDataSettingsFromRegistry(Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                if(RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = RegPath;
                }

                ReportPath = string.Format("{0}\\Reports\\", Application.StartupPath);
                PatekaDoLogo = MKelner.Forms.cfg.PatekaDoLogo;
                designMode = true;
                UserAndObjectCheck = RegistryData.Read("UserAndObjectCheck").ToUpper().Contains("TRUE");
                ConnectionTimeOut = RegistryData.Read("ConnectionTimeOut", "60000").ToString();
                LogiranjeNaSessii = RegistryData.Read("LogiranjeNaSessii","false").ToUpper().Contains("TRUE");
                RazlicniBoiNaRedicVoGrid = !string.IsNullOrEmpty(RegistryData.Read("RazlicniBoiNaRedicVoGrid"));
                jazik = "mk";
                UserRole = "ADMIN";
                AktivenTabNaLogin = Tools.PrazenStringToInt(RegistryData.Read("AktivenTabNaLogin", "-1"), -1);
                AktivenObjektDoNaStartZaDokumenti = Tools.PrazenStringToInt(RegistryData.Read("AktivenObjektDoNaStartZaDokumenti", "0"), 0);
                AktivenObjektOdNaStartZaDokumenti = Tools.PrazenStringToInt(RegistryData.Read("AktivenObjektOdNaStartZaDokumenti", "0"), 0);
                fontZaVnesKasa = RegistryData.Read("fontZaVnesKasa");
                SifraKupuvac = RegistryData.Read("SifraKupuvac", "99999");
                PrikaziFormaZaKusur = RegistryData.Read("PrikaziFormaZaKusur", "true").ToUpper().Contains("TRUE");
                PrasajZaZatvoranjeNaSmetkaKasaBrzoPecatenje = RegistryData.Read("PrasajZaZatvoranjeNaSmetkaKasaBrzoPecatenje", "true").ToUpper().Contains("TRUE");
                IskluciPovekjeFormi = RegistryData.Read("IskluciPovekjeFormi", "false").ToUpper().Contains("TRUE");
                PecatiKasaDirektnoFiskalnaISmetka = RegistryData.Read("PecatiKasaDirektnoFiskalnaISmetka", "true").ToUpper().Contains("TRUE");
                ProverkaZaPremalaCena = RegistryData.Read("ProverkaZaPremalaCena", "false").ToUpper().Contains("TRUE");
                PrikaziFormaZaKusurBrzoPecatenje = RegistryData.Read("PrikaziFormaZaKusurBrzoPecatenje", "true").ToUpper().Contains("TRUE");
                TipNaPrograma = RegistryData.Read("TipNaPrograma", "101").ToString();
                RedenBrojNaJazik = RegistryData.Read("RedenBrojNaJazik", "0").ToString();
                MailNaZatvoranjeNaDen = RegistryData.Read("MailNaZatvoranjeNaDen", "0").ToString();
                ProkniziSmetki = RegistryData.Read("ProkniziSmetki", "0").ToString();
                ProkniziDokumenti = RegistryData.Read("ProkniziDokumenti", "false").ToString();
                EnableMail = RegistryData.Read("EnableMail", "1").ToString();
                EnableMailNaSmetka = RegistryData.Read("EnableMailNaSmetka", "1").ToString();
                PecatenjeSoPopust = RegistryData.Read("PecatenjeSoPopust", "false").ToUpper().Contains("TRUE");
                PrikaziModulZaKujna = RegistryData.Read("PrikaziModulZaKujna", "false").ToUpper().Contains("TRUE");
                PrikaziBiranjeNaTipNaSmetka = RegistryData.Read("PrikaziBiranjeNaTipNaSmetka", "true").ToUpper().Contains("TRUE");
                ImeNaMojServer = RegistryData.Read("ImeNaMojServer", "");
                defaultJazik = RegistryData.Read("defaultJazik", "1");
                StartCardReaderd = RegistryData.Read("StartCardReaderd", "false");
                StartCardNFCReader = RegistryData.Read("StartCardNFCReader", "false");
                NeLoadirajPodatociNaStartNaForma = RegistryData.Read("NeLoadirajPodatociNaStartNaForma", "true");
                COMPortZaFiskalna = RegistryData.Read("COMPortZaFiskalna", "1");
                DebugFiskalna = RegistryData.Read("DebugFiskalna", "false").ToUpper().Contains("TRUE");
                ImagesPath = RegistryData.Read("ImagesPath", "");
                PrevediPorakaODResource = RegistryData.Read("PrevediPorakaODResource", "");
                NivelaCijaNaKrajNaDen = RegistryData.Read("NivelaCijaNaKrajNaDen", "false");
                novaSmetkaNaStartNaKelner = RegistryData.Read("novaSmetkaNaStartNaKelner", "false").ToLower().Contains("true");
                ZatvoranjeNaSmetkaOdButton = RegistryData.Read("ZatvoranjeNaSmetkaOdButton", "false").ToLower().Contains("true");
                tipNaHartijaZaPrinter = RegistryData.Read("tipNaHartijaZaPrinter", "");
                BackupNaStartUp = RegistryData.Read("BackupNaStartUp", "true");
                BackupNaServerPateka = RegistryData.Read("BackupNaServerPateka", string.Empty);
                PatekaDoLogo = RegistryData.Read("PatekaDoLogo", string.Empty);
                brojNaDenoviZaValuta = Tools.PrazenStringToInt(RegistryData.Read("brojNaDenoviZaValuta", "7"), 7);
                AdminPcName = RegistryData.Read("AdminPc", "1");
                ExceptionToMail = RegistryData.Read("ExceptionToMail", "false");
                EnableWCFSendOfDocuments = RegistryData.Read("EnableWCFSendOfDocuments", "false").ToString();
                EnableServerAPI_Sinhronizacija = RegistryData.Read("EnableServerAPI_Sinhronizacija", "false").ToUpper().Contains("TRUE");
                LastCheckForUpdateFrom_API = RegistryData.Read("LastCheckForUpdateFrom_API", DateTime.Now.AddDays(-30).ToString());
                LastInsertToServerFrom_API = RegistryData.Read("LastInsertToServerFrom_API", DateTime.Now.AddDays(-30).ToString());
                DatabaseNameToSync_API = RegistryData.Read("DatabaseNameToSync_API", "BSG_PICERIJA");
                ServerNameToSync_API = RegistryData.Read("ServerNameToSync_API", @"(local)\SQL");
                ServerPathToSync_API = RegistryData.Read("ServerPathToSync_API", "http://bssrapi.vlezi.com/BSSWebApi/");
                ServerT = RegistryData.Read("ServerT", "aHR0cHM6Ly9ic2xpY2Vuc2UyMDI0MDQxOTE0NTgyNy5henVyZXdlYnNpdGVzLm5ldC9hcGkvYnNzL2xpYz9QY05hbWU9QHAxJmNsaWVudElkPUBwMiZ0aXBOYVByb2dyYW1hPUBwMw==");
                ServerEnableVnes_API = RegistryData.Read("ServerEnableVnes_API", "true");
                SocketServer = RegistryData.Read("SocketServer", "false");
                ZadolzitelnoIzberiPartner = RegistryData.Read("ZadolzitelnoIzberiPartner", "false").ToUpper().Contains("TRUE");
                PrasajZaZatvoranjeNaSmetka = RegistryData.Read("PrasajZaZatvoranjeNaSmetka", "true").ToUpper().Contains("TRUE");
                PrasajZaFiskalna = RegistryData.Read("PrasajZaFiskalna", "true").ToUpper().Contains("TRUE");
                PecatFiskalnaBrzoPecatenje = RegistryData.Read("PecatFiskalnaBrzoPecatenje", "true").ToUpper().Contains("TRUE");
                PrasajZaFiskalnaBrzoPecatenje = RegistryData.Read("PrasajZaFiskalnaBrzoPecatenje", "true").ToUpper().Contains("TRUE");
                PecatFiskalna = RegistryData.Read("PecatiFiskalna", "false").ToUpper().Contains("TRUE");
                pecatiA4 = RegistryData.Read("pecatiA4", "false").ToUpper().Contains("TRUE");
                OnScreenKeyBoard = RegistryData.Read("PrikaziTastaturaLogin", "0").Contains("1");
                firmaId = Tools.PrazenStringToInt(RegistryData.Read("FirmaID"), 1);
                SearchIndex = RegistryData.Read("SearchIndex", "3");
                TOPONARTIKLISEARCH = RegistryData.Read("TOPONARTIKLISEARCH", "5");
                SearchWhereGroupIndex = RegistryData.Read("SearchWhereGroupIndex", "0");
                eKujna = RegistryData.Read("Kujna", "0");
                KopiiSank = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopiiZaSank", "1"), 1);
                KopiiZakujna = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopiiZaKujna"), 1);
                KopiiZaSmetka = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopiiZaSmetka"), 1);
                KopiiZaSmetkaZaFaktura = Tools.PrazenStringToInt(RegistryData.Read("KopiiZaSmetkaZaFaktura"), 0);
                DisabledUsr = RegistryData.Read("DisabledUsr", "User");
                PrikaziDataBazaIJazik = RegistryData.Read("PrikaziDataBazaIJazik", "true");
                GMailPass = RegistryData.Read("GMailPass", string.Empty);
                GMailUserName = RegistryData.Read("GMailUserName", string.Empty);
                GMailTo = RegistryData.Read("GMailTo", string.Empty);
                GMailFrom = RegistryData.Read("GMailFrom", string.Empty);
                GMailToZaSmetki = RegistryData.Read("GMailToZaSmetki", string.Empty);
                GMailPrikaziPoraka = RegistryData.Read("GMailPrikaziPoraka", "false");
                NovNacinNaKnizenjeDokumenti = RegistryData.Read("NovNacinNaKnizenjeDokumenti", "false").ToUpper().Contains("TRUE");

                BSSMailFrom = RegistryData.Read("BSSMailFrom", Tools.textToBase64("spirodt@bssr.mk"));
                BSSMailTo= RegistryData.Read("BSSMailTo", Tools.textToBase64("spirodt@bssr.mk"));
                BSSMailServer = RegistryData.Read("BSSMailServer", Tools.textToBase64("mail.bssr.mk"));
                BSSMailUserName = RegistryData.Read("BSSMailUserName", Tools.textToBase64("spirodt@bssr.mk"));
                BSSMailPass = RegistryData.Read("BSSMailPass", Tools.textToBase64("Octavarium#123$$"));
                BSSMailPort = RegistryData.Read("BSSMailPort", Tools.textToBase64("587"));
                BSSMailEnableSSL = RegistryData.Read("BSSMailEnableSSL", Tools.textToBase64("true"));
                BSSMailAllowInvalidCert = RegistryData.Read("BSSMailAllowInvalidCert", Tools.textToBase64("true"));
                BSSMailTimeOut = RegistryData.Read("BSSMailTimeOut", Tools.textToBase64("10000000"));

                testDelay = RegistryData.Read("testDelay", "5000");
                PrintFolder = RegistryData.Read("PrintFolder", $@"C:\PrintFiles\");

                ExprotPath = RegistryData.Read("ExprotPath", string.Empty);
                TipNaFiskalna = RegistryData.Read("TipNaFiskalna", string.Empty);
                poleZaBarkod = RegistryData.Read("poleZaBarkod", "Sifra");
                poleZaSifra = RegistryData.Read("poleZaSifra", "Sifra");
                ConnectionTimeOut = RegistryData.Read("ConnectionTimeOut", "60000").ToString();
                DaysToDisplayData = RegistryData.Read("DaysToDisplayData", "7").ToString();
                ComPortForSerialCardReader = RegistryData.Read("ComPortForSerialCardReader", "COM4").ToString();
            }

            public static void ReadUpdateServerSettings(Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                if (RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = RegPath;
                }

                UpdateSettings.currentVersion = RegistryData.Read("currentVersion", string.Empty);
                UpdateSettings.ServerPath = RegistryData.Read("ServerPath", string.Empty);
                UpdateSettings.ProgramDIR = RegistryData.Read("ProgramDIR", string.Empty);
                UpdateSettings.serverVersion = RegistryData.Read("serverVersion", string.Empty);
                UpdateSettings.enableUpdate = RegistryData.Read("enableUpdate", "false").ToLower().Contains("true");
                UpdateSettings.sqlConnectionString = konekcija;
                UpdateSettings.UpdateCode = RegistryData.Read("UpdateCode",Tools.textToBase64("ALL"));
                UpdateSettings.SQlProgramDIR = RegistryData.Read("SQlProgramDIR", string.Empty);
                UpdateSettings.SQLServerPath = RegistryData.Read("SQLServerPath", string.Empty);
                UpdateSettings.SQLUpdateDIR = RegistryData.Read("SQLUpdateDIR", string.Empty);
                UpdateSettings.UpdateDIR = RegistryData.Read("UpdateDIR", string.Empty);
            }

            public static void ReadTmpConfigSetingsFromRegistry(Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                if (RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = RegPath;
                }

                tmpConfigs.VPNNameServer = RegistryData.Read("VPNNameServer", string.Empty);
                tmpConfigs.SmetkaA4DokumentID = RegistryData.Read("SmetkaA4DokumentID", string.Empty);
                tmpConfigs.TipNaDokumentIdPriem = Tools.PrazenStringToInt(RegistryData.Read("TipNaDokumentIdPriem", "4"));
                tmpConfigs.BSMainServiceEndPoint = RegistryData.Read("BSMainServiceEndPoint", "");
                tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi = Tools.PrazenStringToInt(RegistryData.Read("TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi", "2"));
                tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceNeSeKnizi = Tools.PrazenStringToInt(RegistryData.Read("TipNaDokumentIdZaGeneriranjeNaIspratniceNeSeKnizi", "7"));
                tmpConfigs.KodNaPc = RegistryData.Read("KodNaPc", "PC1SPIRO");
            }

            public static void ReadMKelnerSettingsFromRegistry(Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                if (RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = RegPath;
                }

                MKelner.Forms.cfg.brojNaArtikliDisplay = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplay"), MKelner.Forms.cfg.brojNaArtikliDisplay);
                MKelner.Forms.cfg.brojNaArtikliDisplayMalku = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplayMalku"), MKelner.Forms.cfg.brojNaArtikliDisplay);
                MKelner.Forms.cfg.sirinaNaBack = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaBack"), MKelner.Forms.cfg.sirinaNaBack);
                MKelner.Forms.cfg.sirinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaDugminjaGore"), MKelner.Forms.cfg.sirinaNaDugminjaGore);
                MKelner.Forms.cfg.VisinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaDugminjaGore"), MKelner.Forms.cfg.VisinaNaDugminjaGore);
                MKelner.Forms.cfg.BrojNaKopcinjaSmetka = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopcinjaSmetka"), MKelner.Forms.cfg.BrojNaKopcinjaSmetka);
                MKelner.Forms.cfg.brojNaDugminjaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("brojNaDugminjaNaArtikal"), MKelner.Forms.cfg.brojNaDugminjaNaArtikal);
                MKelner.Forms.cfg.SirinaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("SirinaNaArtikal"), MKelner.Forms.cfg.SirinaNaArtikal);
                MKelner.Forms.cfg.VisinaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaArtikal"), MKelner.Forms.cfg.VisinaNaArtikal);
                MKelner.Forms.cfg.FontSizeArtikal = Tools.PrazenStringToInt(RegistryData.Read("FontSizeArtikal"), MKelner.Forms.cfg.FontSizeArtikal);
                MKelner.Forms.cfg.TextAligmentArtikal = Tools.PrazenStringToInt(RegistryData.Read("TextAligmentArtikal"), MKelner.Forms.cfg.TextAligmentArtikal);
                MKelner.Forms.cfg.ImageAligmentArtikal = Tools.PrazenStringToInt(RegistryData.Read("ImageAligmentArtikal"), MKelner.Forms.cfg.ImageAligmentArtikal);
                MKelner.Forms.cfg.FontSizeDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("FontSizeDugminjaGore"), MKelner.Forms.cfg.FontSizeDugminjaGore);
                MKelner.Forms.cfg.TextAligmentDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("TextAligmentDugminjaGore"), MKelner.Forms.cfg.TextAligmentDugminjaGore);
                MKelner.Forms.cfg.ImageAligmentDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("ImageAligmentDugminjaGore"), MKelner.Forms.cfg.ImageAligmentDugminjaGore);
                MKelner.Forms.cfg.PatekaDoLogo = RegistryData.Read("PatekaDoLogo", string.Empty);
                MKelner.Forms.cfg.ArtikalTextColor = RegistryData.Read("ArtikalTextColor", string.Empty);
            }

            public static void SaveRegSettings(string regName, object value, Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
            {
                if (RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = RegPath;
                }
                RegistryData.Write(regName, value);
                ReloadAllConfigs(RegistryData);
            }
        }
    }
}
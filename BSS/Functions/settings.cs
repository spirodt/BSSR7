using System;
using System.ComponentModel;

namespace BssBase
{
    public static partial class settings
    {
        #region settings Properties
        public static string AdminPcName { set; get; }

        public static string poleZaBarkod { set; get; }

        public static string defaultJazik { get; set; }
        public static string poleZaSifra { set; get; }
        public static string tipNaHartijaZaPrinter { set; get; }
        public static string BackupNaStartUp { set; get; }
        public static string BackupNaServerPateka { set; get; }
        public static string NeLoadirajPodatociNaStartNaForma { set; get; }

        public static string ImeNaMojServer { set; get; }

        public static string NivelaCijaNaKrajNaDen { set; get; }

        public static string ExceptionToMail { set; get; }

        public static int AktivenTabNaLogin { set; get; }

        public static int AktivenObjektOdNaStartZaDokumenti { set; get; }
        public static int AktivenObjektDoNaStartZaDokumenti { set; get; }
        public static int brojNaDenoviZaValuta { set; get; }
        public static string SocketServer { set; get; }

        public static string TipNaPrograma { set; get; }

        public static bool PrasajZaFiskalna { set; get; }
        public static bool ZatvoranjeNaSmetkaOdButton { set; get; }
        public static bool PecatFiskalnaBrzoPecatenje { set; get; }
        public static bool PrasajZaFiskalnaBrzoPecatenje { set; get; }

        public static string MailNaZatvoranjeNaDen { set; get; }

        public static string ProkniziSmetki { set; get; }

        public static string ProkniziDokumenti { set; get; }

        public static bool PrikaziBiranjeNaTipNaSmetka { set; get; }

        public static bool PecatFiskalna { set; get; }

        public static bool PecatenjeSoPopust { set; get; }

        public static bool PrikaziModulZaKujna { set; get; }

        public static bool PrikaziFormaZaKusur { set; get; }
        public static bool UserAndObjectCheck { set; get; }
        public static bool PrikaziFormaZaKusurBrzoPecatenje { set; get; }

        public static bool PrasajZaZatvoranjeNaSmetka { set; get; }
        public static bool PrasajZaZatvoranjeNaSmetkaKasaBrzoPecatenje { set; get; }

        public static bool OnScreenKeyBoard { set; get; }

        public static string PatekaDoLogo { set; get; }

        public static int KopiiZaSmetkaZaFaktura { set; get; }

        public static string TipNaFiskalna { set; get; }

        public static string GMailPass { set; get; }

        public static string GMailUserName { set; get; }

        public static string GMailTo { set; get; }

        public static string GMailToZaSmetki { set; get; }

        public static string GMailFrom { set; get; }

        public static string BSSMailServer { set; get; }

        public static string BSSMailPass { set; get; }

        public static string BSSMailUserName { set; get; }

        public static string BSSMailTo { set; get; }

        public static string BSSMailFrom { set; get; }

        public static string BSSMailPort { set; get; }

        public static string BSSMailEnableSSL { set; get; }

        public static string BSSMailAllowInvalidCert { set; get; }
        public static string BSSMailTimeOut { set; get; }

        public static string ExprotPath { set; get; }

        public static string GMailPrikaziPoraka { set; get; }

        public static bool OnScreenKeyNaSveDugminjaBoard { set; get; }

        [DefaultValue(false)]
        public static bool RazlicniBoiNaRedicVoGrid { set; get; }

        public static string FirmaNaziv { set; get; }

        public static string RedenBrojNaJazik { set; get; }

        public static string EnableMail { set; get; }

        public static string EnableMailNaSmetka { set; get; }

        public static string fontZaVnesKasa { set; get; }

        public static int KopiiZakujna { set; get; }

        public static int KopiiZaSmetka { set; get; }
        public static bool pecatiA4 { set; get; }
        public static int KopiiSank { set; get; }

        public static string konekcija { set; get; }
        public static string LastCheckForUpdateFrom_API { set; get; }
        public static string LastInsertToServerFrom_API { set; get; }
        public static string DatabaseNameToSync_API { set; get; }
        public static string ServerNameToSync_API { set; get; }

        public static string ServerPathToSync_API { set; get; }
        public static string ServerT { set; get; }
        public static string ServerEnableVnes_API { set; get; }

        public static string DisabledUsr { set; get; }

        public static string PrikaziDataBazaIJazik { set; get; }

        public static string SifraKupuvac { set; get; }

        public static string PrinterPathDefault { set; get; }

        public static string PrinterSecond { set; get; }

        public static string jazik { set; get; }
        public static string CultureInfoString { set; get; }

        public static string eKujna { set; get; }

        public static string ReportPath { set; get; }

        public static string ImagesPath { set; get; }

        public static string RegPath { set; get; }

        public static string COMPortZaFiskalna { set; get; }

        public static bool DebugFiskalna { set; get; }

        public static bool DebugMode { set; get; } = false;

        [DefaultValue(1)]
        public static int MomentalenObjektID;



        public static bool designMode = false;

        [DefaultValue(false)]
        public static bool ExportToExcell { set; get; }

        public static string ConnectionTimeOut { set; get; }
        public static string EnableWCFSendOfDocuments { set; get; }
        public static DateTime DateTimeOd { set; get; }
        public static string DaysToDisplayData { set; get; }
        public static string ComPortForSerialCardReader { set; get; }
        public static DateTime DateTimeDo { set; get; }

        public static bool novaSmetkaNaStartNaKelner { set; get; }

        public static string StartCardReaderd { set; get; }
        public static string StartCardNFCReader { set; get; }

        [DefaultValue(1)]
        public static int firmaId { set; get; }

        [DefaultValue(1)]
        public static int UserId { set; get; }

        [DefaultValue("ADMIN")]
        public static string UserRole { set; get; }

        public static int UserLevel { set; get; }

        public static string AppPath { set; get; }

        public static string Sesija { set; get; }

        public static string SearchIndex { set; get; }
        public static string TOPONARTIKLISEARCH { set; get; }
        public static string SearchWhereGroupIndex { set; get; }

        public static string PrevediPorakaODResource { set; get; }

        public static string path { set; get; }

        public static bool PecatiKasaDirektnoFiskalnaISmetka { get; set; }
        public static bool IskluciPovekjeFormi { get; set; }
        public static bool ProverkaZaPremalaCena { get; set; }
        public static bool EnableServerAPI_Sinhronizacija { get; set; }

        public static bool NeSortirajKoloni = false;
        public static bool NeSreduajMeni = false;
        public static bool LogiranjeNaSessii = false;

        [DefaultValue(false)]
        public static bool ZadolzitelnoIzberiPartner { get; set; }
        #endregion settings Properties
    }
}
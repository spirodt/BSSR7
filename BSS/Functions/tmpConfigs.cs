namespace BssBase
{
    public static class tmpConfigs
    {
        public class ActiveForms {

            public bool Fakturi { set; get; } = false;
            public bool Priem { set; get; } = false;
            public bool Interni { set; get; } = false;
            public bool Izvodi { set; get; } = false;
            public bool Smetki { set; get; } = false;
        }

        public static ActiveForms MainActiveForms { set; get; }
        public static string LastAssemblyCall { set; get; }

        public static string RFIDCARDNUMBER { set; get; }
        public static string SmetkaA4DokumentID { set; get; }
        public static string NazivNaObjket { set; get; }

        public static bool FinansiiConfigProcitan = false;
        public static bool BssBaseConfigProcitan = false;
        public static bool MMConfigProcitan = false;

        public static string databaseName { set; get; }

        public static string KodNaPc { set; get; }

        public static string ServerName { set; get; }
        public static string VPNNameServer { set; get; }

        public static string BSMainServiceEndPoint { set; get; }

        public static int TipNaDokumentIdPriem { set; get; }

        public static int TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi { set; get; }

        public static int TipNaDokumentIdZaGeneriranjeNaIspratniceNeSeKnizi { set; get; }

        public static string LogiranUserFullName { set; get; }
    }
}
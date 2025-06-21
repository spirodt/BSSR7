namespace BssBase
{
    public static class UpdateSettings
    {
        public static bool enableUpdate { set; get; }

        public static string UpdateCode { set; get; }

        public static string serverVersion { set; get; }

        public static string currentVersion { set; get; }

        public static string ProgramDIR { set; get; }

        public static string UpdateDIR { set; get; }

        public static string ServerPath { set; get; }

        public static string SQlProgramDIR { set; get; }

        public static string SQLUpdateDIR { set; get; }

        public static string SQLServerPath { set; get; }

        public static string sqlConnectionString { set; get; }
    }
}
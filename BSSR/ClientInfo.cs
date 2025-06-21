using System;

namespace BSSR
{
    public class ClientInfo
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string TipNaPrograma { get; set; }

        public string Settings { get; set; }

        public string Message { get; set; }

        public bool? ValidLicence { get; set; }

        public string SendMessageToClientOnNextLogin { get; set; }
    }

}
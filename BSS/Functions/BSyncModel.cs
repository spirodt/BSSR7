using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BSSWebApi.Models
{
    public class BSyncModel
    {
        [JsonProperty(PropertyName = "DatabaseName", Required = Required.Default)]
        public string DatabaseName { get; set; }

        [JsonProperty(PropertyName = "ServerName", Required = Required.Default)]
        public string ServerName { get; set; }

        [JsonProperty(PropertyName = "DateTimeOfTheRequest", Required = Required.Default)]
        public DateTime DateTimeOfTheRequest { get; set; }

        [JsonProperty(PropertyName = "ResultsDataTable", Required = Required.Default)]
        public DataTable ResultsDataTable { get; set; }

        [JsonProperty(PropertyName = "dataVersionFromPc", Required = Required.Default)]
        public List<string> dataVersionFromPc { get; set; }

        [JsonProperty(PropertyName = "Result", Required = Required.Default)]
        public object Result { get; set; }

        [JsonProperty(PropertyName = "TableName", Required = Required.Default)]
        public string TableName { get; set; }

        [JsonProperty(PropertyName = "tblSmetka", Required = Required.Default)]
        public DataTable tblSmetka { get; set; }


        [JsonProperty(PropertyName = "tblNalog", Required = Required.Default)]
        public DataTable tblNalog { get; set; }


        [JsonProperty(PropertyName = "tblNalogStavki", Required = Required.Default)]
        public DataTable tblNalogStavki { get; set; }


        [JsonProperty(PropertyName = "tblSmetkaStavki", Required = Required.Default)]
        public DataTable tblSmetkaStavki { get; set; }


        [JsonProperty(PropertyName = "tblFiskalniSmetki", Required = Required.Default)]
        public DataTable tblFiskalniSmetki { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BSS
{
    public partial class PrintPreview : Form
    {
        public PrintPreview(ReportDocument Report, String ReportName, Dictionary<string, object> parametars = null, DataTable dt = null, DataSet ReportDataSet = null)
        {
            InitializeComponent();
            var jazik = BssBase.settings.jazik;
            if (jazik == "al")
            {
                jazik = "sq";
            }

            var path = String.Format(@"{0}{1}\{2}-{1}.rpt", BssBase.settings.ReportPath, jazik, ReportName);

            if (!File.Exists(path))
            {
                path = String.Format(@"{0}mk\{1}-mk.rpt", BssBase.settings.ReportPath, ReportName);
            }

            Report.Load(path);

            if (!Equals(null, dt))
            {
                Report.SetDataSource(dt);
            }
            else
            {
               Report.SetDataSource(ReportDataSet);
            }

            if (!Equals(null, parametars))
            {
                foreach (KeyValuePair<string, object> parametar in parametars)
                {
                    var Parametar = parametar.Key;
                    try
                    {
                        Report.SetParameterValue(parametar.Key, parametar.Value);
                    }
                    catch (Exception )
                    {
                        MessageBox.Show(Tools.PrevediPoraka("OvojParametarNePostoiZaOvojIzvestaj") + Parametar);
                        return;
                    }
                }
            }

            ReportPreview.ReportSource = Report;
        }

        public PrintPreview()
        {
            InitializeComponent();
        }
    }
}
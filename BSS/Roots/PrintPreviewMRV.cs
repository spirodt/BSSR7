using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BssBase.Forms
{
    public partial class PrintPreviewMRV : Form
    {
        private ReportViewer reportViewer1;
        private DataSet pReportDataset;
        private string pSubReportTableName;

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewMRV));
            reportViewer1 = new ReportViewer();
            SuspendLayout();
            resources.ApplyResources(reportViewer1, "reportViewer1");
            reportViewer1.Name = "reportViewer1";
            resources.ApplyResources(this, "$this");
            Controls.Add(reportViewer1);
            KeyPreview = true;
            Name = "PrintPreviewMRV";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        public PrintPreviewMRV(DataSet ReportDataSet, String ReportName, string TableName, Dictionary<string, object> ReportParametars = null, string datasetName = null, string SubReportName = null, string SubReportTableName = null)
        {
            InitializeComponent();
            var path = settings.ReportPath + settings.jazik + "\\" + ReportName + "-" + settings.jazik + ".rdlc";
            if (!File.Exists(path))
            {
                path = settings.ReportPath + "mk" + "\\" + ReportName + "-" + "mk" + ".rdlc";
            }
            var Report = new StreamReader(path);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.LoadReportDefinition(Report);

            if (string.IsNullOrEmpty(datasetName))
            {
                datasetName = "DataSet1";
            }
            
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(datasetName, ReportDataSet.Tables[TableName]));
            
            if (!string.IsNullOrEmpty(SubReportName) && !string.IsNullOrEmpty(SubReportName))
            {
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                var _assembly = Assembly.GetExecutingAssembly();
                var subReport = new StreamReader(_assembly.GetManifestResourceStream("BssBase.SubReports." + SubReportName + ".rdlc"));
                reportViewer1.LocalReport.LoadSubreportDefinition(SubReportName, subReport);
                pReportDataset = ReportDataSet;
                pReportDataset.DataSetName = datasetName;
                pSubReportTableName = SubReportTableName;
            }

            var parametri = new ReportParameterCollection();
            if (!Equals(null, ReportParametars))
            {
                foreach (KeyValuePair<string, object> parametar in ReportParametars)
                {
                    var param = new ReportParameter();
                    param.Name = parametar.Key;
                    param.Values.Add(parametar.Value.ToString());
                    parametri.Add(param);
                }
                
                reportViewer1.LocalReport.SetParameters(parametri);
            }
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            if (!Equals(null, pReportDataset))
            {
                e.DataSources.Clear();
                e.DataSources.Add(new ReportDataSource(pReportDataset.DataSetName, pReportDataset.Tables[pSubReportTableName]));
            }
        }
    }
}
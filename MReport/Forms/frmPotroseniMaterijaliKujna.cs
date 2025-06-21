using System;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MReport.Forms
{
    public partial class frmPotroseniMaterijaliKujna : frmIzvestaj
    {
        public frmPotroseniMaterijaliKujna()
        {
            InitializeComponent();
        }

        private void frmPotroseniMaterijaliKujna_Load(object sender, EventArgs e)
        {
            DatumDo.DateTime = DateTime.Now;
            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Преглед на потрошени материјали во кујна за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            link.ShowPreview();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (rbtnSite.Checked)
            {
                potroseniMaterijaliVoKujnaZaPeriodTableAdapter.Fill(bSSRDataSet.PotroseniMaterijaliVoKujnaZaPeriod, new DateTime(datumOd.DateTime.Year,
                                                                                                                        datumOd.DateTime.Month,
                                                                                                                        datumOd.DateTime.Day,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local),
                                                                                                                        new DateTime(DatumDo.DateTime.Year,
                                                                                                                        DatumDo.DateTime.Month,
                                                                                                                        DatumDo.DateTime.Day,
                                                                                                                        23,
                                                                                                                        59,
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, false);
            }

            if (rbtnSocuvani.Checked)
            {
                potroseniMaterijaliVoKujnaZaPeriodTableAdapter.Fill(bSSRDataSet.PotroseniMaterijaliVoKujnaZaPeriod, new DateTime(datumOd.DateTime.Year,
                                                                                                                        datumOd.DateTime.Month,
                                                                                                                        datumOd.DateTime.Day,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local),
                                                                                                                        new DateTime(DatumDo.DateTime.Year,
                                                                                                                        DatumDo.DateTime.Month,
                                                                                                                        DatumDo.DateTime.Day,
                                                                                                                        23,
                                                                                                                        59,
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, true);
            }
        }
    }
}
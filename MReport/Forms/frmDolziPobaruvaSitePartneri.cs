using System;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MReport.Forms
{
    public partial class frmDolziPobaruvaSitePartneri : frmIzvestaj
    {
        public frmDolziPobaruvaSitePartneri()
        {
            InitializeComponent();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            pobaruvaDolguvaSitePartneriTableAdapter.Fill(bSSRDataSet.PobaruvaDolguvaSitePartneri, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            00,
                                                                                                                            00,
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                            DatumDo.DateTime.Month,
                                                                                                                            DatumDo.DateTime.Day,
                                                                                                                            23,
                                                                                                                            59,
                                                                                                                            59,
                                                                                                                            DateTimeKind.Local));
            presmetaj();
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Салдо на сите партнери за период од : {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();


            var FmiddleColumn = sumaText;


            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;
            link.ShowPreview();
        }
        string sumaText;
        public void presmetaj()
        {

            
            sumaText = string.Format("Должи: {0} Побарува: {1} " + Environment.NewLine + " Салдо (Д-П): {2}",
                Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaSitePartneri.Compute("SUM(Dolzi)", "").ToString()).ToString("N2"),
                Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaSitePartneri.Compute("SUM(Pobaruva)", "").ToString()).ToString("N2"),
                (Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaSitePartneri.Compute("SUM(Dolzi)", "").ToString()) - Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaSitePartneri.Compute("SUM(Pobaruva)", "").ToString())).ToString("N2"));

            txtSumSaldo.Text = sumaText;
        }
       
    }
}

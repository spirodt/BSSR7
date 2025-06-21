using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MReport.Forms
{
    public partial class frmPlacanjaOdPartner : frmIzvestaj
    {
        public frmPlacanjaOdPartner()
        {
            InitializeComponent();
        }

        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
            validatePartner();
        }

        public bool validatePartner()
        {
            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);
            if (zbxPartner.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    zbxPartner.zoomClear();
                    txtPartner.Clear();
                    zbxPartner.ret1 = info["ID"].ToString();
                    zbxPartner.Value.Text = info["Sifra"].ToString();
                    zbxPartner.Text = info["Naziv"].ToString();
                    txtPartner.Text = info["Naziv"].ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("PartnerotNePostoi"));
                    zbxPartner.zoomClear();
                    txtPartner.Text = string.Empty;
                    return false;
                }
            }
            return false;
        }

        private void zbxPartner_Validated(object sender, EventArgs e)
        {
            validatePartner();
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Салдо на партнер ( {2} ) за период од : {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString(), txtPartner.Text);
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();

            
            var FmiddleColumn = sumaText;


            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;
            link.ShowPreview();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(zbxPartner.ret1))
            {
                MessageBox.Show(Tools.PrevediPoraka("ОдберетеПартнер"));
                return;
            }
            pobaruvaDolguvaPartnerTableAdapter.Fill(bSSRDataSet.PobaruvaDolguvaPartner, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), Tools.PrazenStringToInt(zbxPartner.ret1));
            presmetaj();
        }
        string sumaText;
        public void presmetaj()
        {

            sumaText = string.Format("Должи: {0} Побарува: {1} " + Environment.NewLine + " Салдо (Д-П): {2}", 
                Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaPartner.Compute("SUM(Dolzi)", "").ToString()).ToString("N2"),
                Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaPartner.Compute("SUM(Platil)", "").ToString()).ToString("N2"),
                (Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaPartner.Compute("SUM(Dolzi)", "").ToString()) - Tools.PrazenStringToDecimal(bSSRDataSet.PobaruvaDolguvaPartner.Compute("SUM(Platil)", "").ToString())).ToString("N2"));

            txtSumSaldo.Text = sumaText;
        }
       
    }
}
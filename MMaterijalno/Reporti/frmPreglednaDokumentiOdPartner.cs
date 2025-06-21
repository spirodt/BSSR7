using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MMaterijalno.Reporti
{
    public partial class FrmPreglednaDokumentiOdPartner : frmIzvestaj
    {
        public FrmPreglednaDokumentiOdPartner()
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


            var FmiddleColumn = string.Empty;


            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;
            link.ShowPreview();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            getPregeledNaNabavkiPoPartnerIPlakjanjaTableAdapter.FillByPartnerID(
                _BSSR_2_0DataSet.getPregeledNaNabavkiPoPartnerIPlakjanja, Tools.PrazenStringToInt(zbxPartner.ret1), new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            0,
                                                                                                                            0,
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                            DatumDo.DateTime.Month,
                                                                                                                            DatumDo.DateTime.Day,
                                                                                                                            23,
                                                                                                                            59,
                                                                                                                            59,
                                                                                                                            DateTimeKind.Local));
        }

        private void FrmPreglednaDokumentiOdPartner_Load(object sender, EventArgs e)
        {
           
            datumOd.DateTime =  new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DatumDo.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        }
    }
}

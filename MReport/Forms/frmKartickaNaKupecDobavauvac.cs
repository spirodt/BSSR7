using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmKartickaNaKupecDobavauvac : frmIzvestaj
    {
        public frmKartickaNaKupecDobavauvac()
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

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            int tipNaVlez = 0;

            if (radioButton1.Checked == true) tipNaVlez = 0;
            if (radioButton2.Checked == true) tipNaVlez = 2;
            if (radioButton3.Checked == true) tipNaVlez = 1;
            if (!string.IsNullOrEmpty(zbxPartner.ret1))
                kartickaNaKupuvacDobavuvacTableAdapter.Fill(bSSRDataSet.KartickaNaKupuvacDobavuvac, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, tipNaVlez, Tools.PrazenStringToInt(zbxPartner.ret1));
            else
            {
                MessageBox.Show(Tools.PrevediPoraka("Одберете партнер"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Издадени фактури според партнер ( {2} ) за период од : {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString(), txtPartner.Text);
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();

            string Sumi = string.Empty;

            for (int i = 0; i < gridView1.VisibleColumns.Count; ++i)
            {
                GridColumn column = gridView1.VisibleColumns[i];
                if (column.SummaryItem != null)
                {
                    if (column.SummaryItem.SummaryType == DevExpress.Data.SummaryItemType.Sum)
                    {
                        GridSummaryItem s = column.SummaryItem;
                        Sumi += column.Caption + " : " + Convert.ToDecimal(s.SummaryValue.ToString()).ToString("N2") + "  ";
                    }
                }
            }

            var FmiddleColumn = Sumi;


            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;
            link.ShowPreview();
        }

        private void frmKartickaNaKupecDobavauvac_Load(object sender, EventArgs e)
        {
            DatumDo.DateTime = DateTime.Now;
            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }
    }
}
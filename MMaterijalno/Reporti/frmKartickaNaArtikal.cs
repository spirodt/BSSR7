using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MMaterijalno.Reporti
{
    public partial class frmKartickaNaArtikal : frmIzvestaj
    {
        public frmKartickaNaArtikal()
        {
            InitializeComponent();
        }

        public void ValidateArtikal()
        {
            var info = Tools.NajdiInfoZaSifraArtikal(txtArtikalSearch.Text);
            if (txtArtikalSearch.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    txtArtikalNaziv.Clear();
                    txtArtikalSearch.ret1 = info["ID"].ToString();
                    txtArtikalSearch.Text = info["Sifra"].ToString();
                    txtArtikalNaziv.Text = info["Naziv"].ToString();
                    txtArtikalSearch.ret4 = info["Normativ"].ToString();
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("ArtiklotNePostoi"));
                    txtArtikalNaziv.Text = string.Empty;
                }
            }
        }

        private void txtArtikalSearch_DataRead()
        {
            txtArtikalSearch.Text = txtArtikalSearch.ret3;
            ValidateArtikal();
        }

        private void btnSearchArtikal_Click(object sender, EventArgs e)
        {
            txtArtikalSearch.OpenEditSearch();
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Картичка на артикал {0} \n од: {1}  до: {2} ", txtArtikalNaziv.Text, datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArtikalSearch.ret1))
            {
                MessageBox.Show("Мора да одберете артикал ");
                return;
            }
            viewKnzienjaMTableAdapter.FillKartickaNaArtikal(materijalnoDataSet.viewKnzienjaM, Tools.PrazenStringToInt(txtArtikalSearch.ret1), new DateTime(datumOd.DateTime.Year,
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
        }

        private void txtArtikalSearch_Validated(object sender, EventArgs e)
        {
            ValidateArtikal();
        }

        private void frmKartickaNaArtikal_Load(object sender, EventArgs e)
        {
            DatumDo.DateTime = DateTime.Now;
            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }
    }
}
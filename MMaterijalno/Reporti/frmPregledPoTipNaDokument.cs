using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;

namespace MMaterijalno.Forms
{
    public partial class frmPregledPoTipNaDokument : frmIzvestaj
    {
        public frmPregledPoTipNaDokument()
        {
            InitializeComponent();
            cmbTipNaDokument.LoadItems(@"Select -1 as ID, '' as Vrednost
            UNION ALL
            select ID, Naziv + ' - ' + CAST(Interen as nvarchar(4)) as Vrednost from tblTipNaDokument");
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
            var middleColumn = String.Format("Преглед на артикли од документ од: {0}  до: {1} за тип на документ {2} ", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString(), cmbTipNaDokument.Text);
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

        private void frmPregledPoTipNaDokument_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BSSR_2_0DataSet.viewDokumentiStavki' table. You can move, or remove it, as needed.
           

        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            DateTime DatOD = new DateTime(datumOd.DateTime.Year,
                                                                datumOd.DateTime.Month,
                                                                datumOd.DateTime.Day,
                                                                00,
                                                                00,
                                                                00,
                                                                DateTimeKind.Local);
            DateTime DatDO = new DateTime(DatumDo.DateTime.Year,
                                                                DatumDo.DateTime.Month,
                                                                DatumDo.DateTime.Day,
                                                                23,
                                                                59,
                                                                59,
                                                                DateTimeKind.Local);

            //sve
            if (Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()) == -1 && string.IsNullOrEmpty(txtArtikalSearch.ret1))
            {
                viewDokumentiStavkiTableAdapter.FillBy(_BSSR_2_0DataSet.viewDokumentiStavki, DatOD, DatDO);
            }

            //Datum Artikal i tip
            if (Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()) != -1 && !string.IsNullOrEmpty(txtArtikalSearch.ret1))
            {
                viewDokumentiStavkiTableAdapter.FillBy1(_BSSR_2_0DataSet.viewDokumentiStavki, DatOD, DatDO, int.Parse(txtArtikalSearch.ret1), Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()));
            }

            
            //Datum i artikal
            if (Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()) == -1 && !string.IsNullOrEmpty(txtArtikalSearch.ret1))
            {
                viewDokumentiStavkiTableAdapter.FillByArtikal(_BSSR_2_0DataSet.viewDokumentiStavki, DatOD, DatDO, int.Parse(txtArtikalSearch.ret1));
            }

            //Datum i tip
            if (Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()) != -1 && string.IsNullOrEmpty(txtArtikalSearch.ret1))
            {
                viewDokumentiStavkiTableAdapter.FillByTipNaDokumentID(_BSSR_2_0DataSet.viewDokumentiStavki, DatOD, DatDO, Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()));
            }


            
        }
    }
}

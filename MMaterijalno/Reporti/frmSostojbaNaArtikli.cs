using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MMaterijalno.Reporti
{
    public partial class frmSostojbaNaArtikli : frmIzvestaj
    {
        public frmSostojbaNaArtikli()
        {
            InitializeComponent();
        }

        private void frmSostojbaNaArtikli_Load(object sender, EventArgs e)
        {
            DatumDo.DateTime = DateTime.Now;
            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
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
            var middleColumn = String.Format("Состојба на артикли од: {0}  до: {1} ", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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
                if (rbtnSite.Checked)
                {
                    if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                    {
                        viewZalihaTableAdapter.FillByDatumOdDO(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
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
                    else
                    {
                        viewZalihaTableAdapter.FillByDatumOdDO(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
                                                                                                                                datumOd.DateTime.Month,
                                                                                                                                datumOd.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                                Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                                00,
                                                                                                                                DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                                DatumDo.DateTime.Month,
                                                                                                                                DatumDo.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                                                Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                                                59,
                                                                                                                                DateTimeKind.Local));
                    }
                }
                if (rbtnSocuvani.Checked)
                {
                    if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                    {
                        viewZalihaTableAdapter.FillByDatumOdDoAndFiskalNa(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                                DateTimeKind.Local), 2);
                    }
                    else
                    {
                        viewZalihaTableAdapter.FillByDatumOdDoAndFiskalNa(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
                                                                                                                                datumOd.DateTime.Month,
                                                                                                                                datumOd.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                                Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                                00,
                                                                                                                                DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                                DatumDo.DateTime.Month,
                                                                                                                                DatumDo.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                                                Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                                                59,
                                                                                                                                DateTimeKind.Local), 2);
                    }
                }

                if (rbtnNesocuvani.Checked)
                {
                    if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                    {
                        viewZalihaTableAdapter.FillByDatumOdDoAndFiskalNa(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                                DateTimeKind.Local), 1);
                    }
                    else
                    {
                        viewZalihaTableAdapter.FillByDatumOdDoAndFiskalNa(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
                                                                                                                                datumOd.DateTime.Month,
                                                                                                                                datumOd.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                                Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                                00,
                                                                                                                                DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                                DatumDo.DateTime.Month,
                                                                                                                                DatumDo.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                                                Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                                                59,
                                                                                                                                DateTimeKind.Local), 1);
                    }
                }
            }
            else
            {
                if (rbtnSite.Checked)
                {
                    if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                    {
                        viewZalihaTableAdapter.FillByDatumAndArtikalID(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                                DateTimeKind.Local), Tools.PrazenStringToInt(txtArtikalSearch.ret1));
                    }
                    else
                    {
                        viewZalihaTableAdapter.FillByDatumAndArtikalID(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                            DatumDo.DateTime.Month,
                                                                                                                            DatumDo.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                                            Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                                            59,
                                                                                                                            DateTimeKind.Local), Tools.PrazenStringToInt(txtArtikalSearch.ret1));
                    }
                        
                }

                if (rbtnSocuvani.Checked)
                {
                    if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                    {

                        viewZalihaTableAdapter.FillByDatumAndArtikalidAndFIskalna(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                                DateTimeKind.Local), Tools.PrazenStringToInt(txtArtikalSearch.ret1), 2);
                    }
                    else
                    {
                        viewZalihaTableAdapter.FillByDatumAndArtikalidAndFIskalna(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
                                                                                                        datumOd.DateTime.Month,
                                                                                                        datumOd.DateTime.Day,
                                                                                                        Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                        Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                        00,
                                                                                                        DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                        DatumDo.DateTime.Month,
                                                                                                        DatumDo.DateTime.Day,
                                                                                                        Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                        Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                        59,
                                                                                                        DateTimeKind.Local), Tools.PrazenStringToInt(txtArtikalSearch.ret1), 2);

                    }
                }

                if (rbtnNesocuvani.Checked)
                {
                    if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                    {
                        viewZalihaTableAdapter.FillByDatumAndArtikalidAndFIskalna(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                                DateTimeKind.Local), Tools.PrazenStringToInt(txtArtikalSearch.ret1), 1);
                    }
                    else
                    {
                        viewZalihaTableAdapter.FillByDatumAndArtikalidAndFIskalna(materijalnoDataSet.viewZaliha, new DateTime(datumOd.DateTime.Year,
                                                                                                                                datumOd.DateTime.Month,
                                                                                                                                datumOd.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                                Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                                00,
                                                                                                                                DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                                DatumDo.DateTime.Month,
                                                                                                                                DatumDo.DateTime.Day,
                                                                                                                                Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                                                Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                                                59,
                                                                                                                                DateTimeKind.Local), Tools.PrazenStringToInt(txtArtikalSearch.ret1), 1);
                    }
                }
            }
        }

        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArtikalSearch.ret1))
                viewZalihaBindingSource.Filter = " tblArtikalID =" + txtArtikalSearch.ret1;
            else
            {
                viewZalihaBindingSource.Filter = string.Empty;
            }
            if(rbtnSite.Checked)
            viewZalihaTableAdapter.Fill(materijalnoDataSet.viewZaliha);
            
            if (rbtnSocuvani.Checked)
                viewZalihaTableAdapter.FillByFiskalNa(materijalnoDataSet.viewZaliha,2);

            if (rbtnNesocuvani.Checked)
                viewZalihaTableAdapter.FillByFiskalNa(materijalnoDataSet.viewZaliha, 1);
        }

        private void txtArtikalSearch_Leave(object sender, EventArgs e)
        {
            if (txtArtikalSearch.IsTextEmpty())
            {
                txtArtikalNaziv.Text = string.Empty;
                txtArtikalSearch.ret1 = string.Empty;
            }
            else
            {
                ValidateArtikal();
            }
        }
    }
}
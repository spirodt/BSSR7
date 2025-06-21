using System;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmPregledNaNalozi : frmIzvestaj
    {
        public frmPregledNaNalozi()
        {
            InitializeComponent();
        }

        private void frmPregledNaNalozi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bSSRDataSet.DetalenPregledNaSmetka' table. You can move, or remove it, as needed.
       
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = string.Empty;

            middleColumn = String.Format("Преглед на Нарачки за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            const string rightColumn = "Date: [Date Printed]";

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

            if (rbtnSite.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    detalenPregledNaSmetkaTableAdapter.FillBySite(bSSRDataSet.DetalenPregledNaSmetka, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local));
                }
                else
                {
                    detalenPregledNaSmetkaTableAdapter.FillBySite(bSSRDataSet.DetalenPregledNaSmetka, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local),
                                                                                                                            new DateTime(DatumDo.DateTime.Year,
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
                    detalenPregledNaSmetkaTableAdapter.FillByFiskalNa(bSSRDataSet.DetalenPregledNaSmetka, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), 2);
                }
                else
                {
                    detalenPregledNaSmetkaTableAdapter.FillByFiskalNa(bSSRDataSet.DetalenPregledNaSmetka, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local),
                                                                                                                            new DateTime(DatumDo.DateTime.Year,
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
                    detalenPregledNaSmetkaTableAdapter.FillByFiskalNa(bSSRDataSet.DetalenPregledNaSmetka, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), 1);
                }
                else
                {
                    detalenPregledNaSmetkaTableAdapter.FillByFiskalNa(bSSRDataSet.DetalenPregledNaSmetka, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtMin.Text, 0),
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local),
                                                                                                                            new DateTime(DatumDo.DateTime.Year,
                                                                                                                            DatumDo.DateTime.Month,
                                                                                                                            DatumDo.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtCas2.Text, 23),
                                                                                                                            Tools.PrazenStringToInt(txtMin2.Text, 59),
                                                                                                                            59,
                                                                                                                            DateTimeKind.Local), 1);
                }
            }

        }
    }
}
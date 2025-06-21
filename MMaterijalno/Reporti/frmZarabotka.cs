using System;
using BssBase.Roots;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;



namespace MMaterijalno.Reporti
{
    public partial class frmZarabotka : frmIzvestaj
    {
        public frmZarabotka()
        {
            InitializeComponent();
            DnevenIzvestaj = false;
            btnPotvrdi1.Visible = false;
            datumOd.Visible = false;
            DatumDo.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtCas2.Visible = false;
            txtMin2.Visible = false;
            txtMin.Visible = false;
            txtSaat.Visible = false;
            bsslabel1.Visible = false;
            bsslabel2.Visible = false;
            bsslabel3.Visible = false;
            bsslabel4.Visible = false;
            
        }

        private bool DnevenIzvestaj = false;

        public frmZarabotka(bool dneven)
        {
            InitializeComponent();
            DnevenIzvestaj = true;
            btnPotvrdi1.Visible = true;
            datumOd.Visible = true;
            DatumDo.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("заработка по артикли ");
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
                    if (column.SummaryItem.SummaryType == DevExpress.Data.SummaryItemType.Sum) {
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

        private void frmZarabotka_Load(object sender, EventArgs e)
        {
            
            
           // SrediSize(gridView1);
            // TODO: This line of code loads data into the 'materijalnoDataSet.viewZarabotkaPoArtikal' table. You can move, or remove it, as needed.
            if (!DnevenIzvestaj)
                viewZarabotkaPoArtikalTableAdapter.Fill(materijalnoDataSet.viewZarabotkaPoArtikal);
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (DnevenIzvestaj)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    viewZarabotkaPoArtikalTableAdapter.FillByDatum(materijalnoDataSet.viewZarabotkaPoArtikal, new DateTime(datumOd.DateTime.Year,
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
                    viewZarabotkaPoArtikalTableAdapter.FillByDatum(materijalnoDataSet.viewZarabotkaPoArtikal, new DateTime(datumOd.DateTime.Year,
                                                                                                                       datumOd.DateTime.Month,
                                                                                                                       datumOd.DateTime.Day,
                                                                                                                       Tools.PrazenStringToInt(txtSaat.Text, 00),
                                                                                                                       Tools.PrazenStringToInt(txtMin.Text, 00),
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
            else
            {
                viewZarabotkaPoArtikalTableAdapter.Fill(materijalnoDataSet.viewZarabotkaPoArtikal);
            }
        }
    }
}
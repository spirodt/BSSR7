using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmPregledNaNaloziPoObjekt : frmIzvestaj
    {
        public frmPregledNaNaloziPoObjekt()
        {
            InitializeComponent();
        }

        private void frmPregledNaNalozi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bSSRDataSet.DetalenPregledNaSmetka' table. You can move, or remove it, as needed.
            cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");
            if (BssBase.settings.AktivenObjektOdNaStartZaDokumenti != 0)
            {
                btnPrikaci1.Visible = true;
            }
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
            if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
            {
                detalenPregledNaSmetkaTableAdapter.FillByDatumAndObjekt(bSSRDataSet.DetalenPregledNaSmetka,
                    new DateTime(datumOd.DateTime.Year,
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
                        DateTimeKind.Local), Tools.PrazenStringToInt(cmbObjekt.SelectedValue.ToString(), 1));
            }
            else
            {
                detalenPregledNaSmetkaTableAdapter.FillByDatumAndObjekt(bSSRDataSet.DetalenPregledNaSmetka,
                    new DateTime(datumOd.DateTime.Year,
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
                        DateTimeKind.Local), Tools.PrazenStringToInt(cmbObjekt.SelectedValue.ToString(), 1));
            }

        }

        private void btnPrikaci1_Click(object sender, EventArgs e)
        {
            var list = string.Join(",",bSSRDataSet.DetalenPregledNaSmetka.AsEnumerable()
                .Select(r => r.Field<int>("SmetkaID").ToString()).Distinct().ToArray());

            BssBase.Roots.frmDatumOdDo frmDatum = new BssBase.Roots.frmDatumOdDo("Датум за сметки");
            DialogResult rez = frmDatum.ShowDialog();
            if (rez == DialogResult.OK)
            {
                if (Equals(null, frmDatum.datumOD)) return;
                
                using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand(
                        @"UPDATE dbo.tblSmetka 
                        SET DatumPocetok = @datum, DatumKraj = @datum 
                        WHERE ID IN ( "+ list +" );"+
                        @"UPDATE dbo.tblNalog 
                        SET DatumPocetok = @datum, DatumKraj = @datum 
                        WHERE SmetkaID IN ( "+ list +" );", con))
                    {
                        con.Open();
                        com.Parameters.AddWithValue("@datum", frmDatum.datumOD.Value.ToShortDateString());
                        com.ExecuteNonQuery();
                        MessageBox.Show("Успешно упдејтирано");
                        btnPotvrdi1.PerformClick();
                    }
                }
            }
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmPregledNaIzmenetiSmetki : frmIzvestaj
    {
        public frmPregledNaIzmenetiSmetki()
        {
            InitializeComponent();
            gridView1.Appearance.Row.Font = new Font(gridView1.Appearance.Row.Font.FontFamily, 15);
        }

        private void frmPregledNaIzmenetiSmetki_Load(object sender, EventArgs e)
        {
            DatumDo.DateTime = DateTime.Now;
            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #] ";
            var middleColumn = String.Format("Преглед на изменети сметки за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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
            if (rbtnPocetok.Checked == true)
                izmenetiSmetkiTableAdapter.FillByDatumNaPocetok(bSSRDataSet.IzmenetiSmetki, new DateTime(datumOd.DateTime.Year,
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
            if (rbtnIzmena.Checked == true)
                izmenetiSmetkiTableAdapter.FillByDatumNaIzmena(bSSRDataSet.IzmenetiSmetki, new DateTime(datumOd.DateTime.Year,
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (!Equals(izmenetiSmetkiBindingSource.Current, null))
            {
                int smetkaIDIzmeneta = Tools.PrazenStringToInt(((DataRowView)izmenetiSmetkiBindingSource.Current)["tblSmetkaIzmenetaID"].ToString());
                int SmetkaID = Tools.PrazenStringToInt(((DataRowView)izmenetiSmetkiBindingSource.Current)["ID"].ToString());
                viewArtikliVoSmetkaTableAdapter.FillByID(bSSRDataSet.viewArtikliVoSmetka, smetkaIDIzmeneta);
                viewArtikliVoSmetkaIzmenetaTableAdapter.FillByID(bSSRDataSet.viewArtikliVoSmetkaIzmeneta, SmetkaID);
                
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            string fileName1 = "ListaSoIzmenetiSmetki_" + DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString() + ".pdf";
            string fileName2 = "MomentalenIzgledNaSmetka_" + DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString() + ".pdf";
            string fileName3 = "PrethodnaSostojba_" + DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString() + ".pdf";

            gridControl1.ExportToPdf(Tools.setExportPath(fileName1, true));
            gridControl2.ExportToPdf(Tools.setExportPath(fileName2, true));
            gridControl3.ExportToPdf(Tools.setExportPath(fileName3, true));
            string fileName = Tools.setExportPath(fileName1) + ";" + Tools.setExportPath(fileName2) + ";" + Tools.setExportPath(fileName3);
            string subject = Text + " -  " + DateTime.Now.ToString();
            string MailText = String.Format("Преглед на изменети сметки за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            Tools.SendMailDefault(Tools.setExportPath(fileName), subject, MailText);
        }
    }
}
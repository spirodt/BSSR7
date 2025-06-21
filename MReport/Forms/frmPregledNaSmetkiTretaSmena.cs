using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using System.IO;
using BssBase;
using System.Text;

namespace MReport.Forms
{
    public partial class frmPregledNaSmetkiTretaSmena : frmIzvestaj
    {
        public frmPregledNaSmetkiTretaSmena()
        {
            InitializeComponent();
            gridView1.Appearance.Row.Font = new Font(gridView1.Appearance.Row.Font.FontFamily, 15);
        }


        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Преглед на Сметки за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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

        private void BtnPotvrdi1_Click(object sender, EventArgs e)
        {
            izvestajCementaraTretaSmenaTableAdapter.Fill(
                bSSRDataSet.IzvestajCementaraTretaSmena,
                new DateTime(datumOd.DateTime.Year,
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
                                DateTimeKind.Local),2,7); //Hardcoded for now 
        }
         public StringBuilder Createreport()
        {
            var sb = new StringBuilder();
            
            foreach (var row in bSSRDataSet.IzvestajCementaraTretaSmena)
            {
                sb.AppendLine(row.Result.ToString().Trim());
            }
            return sb;
        }
        private void PratiMail(int rowCount)
        {
            if (!string.IsNullOrEmpty(settings.GMailToZaSmetki) && settings.EnableMail == "1")
            {
                if (rowCount > 0)
                {
                    StreamWriter wr = new StreamWriter(Tools.setExportPath(DateTime.Today.Month + "_Izvestaj.txt", true));
                    wr.Write(Createreport());
                    wr.Close();
                    Tools.SendMailCementara(Tools.setExportPath(DateTime.Today.Month + "_IzvestajTretaSmena.txt"), "Извештај ","Во прилог се наоѓа фајлот", true, settings.GMailFrom,
                        settings.GMailToZaSmetki);
                }

            }
        }
        private void BtnPrikaci1_Click(object sender, EventArgs e)
        {
            PratiMail(bSSRDataSet.IzvestajCementaraTretaSmena.Count);
        }
    }
}
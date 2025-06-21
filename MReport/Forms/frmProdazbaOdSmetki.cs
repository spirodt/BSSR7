using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;

namespace MReport.Forms
{
    public partial class frmProdazbaOdSmetki : frmIzvestaj
    {
        private void ChangeTimeout(Component component, int timeout)
        {
            if (!component.GetType().Name.Contains("TableAdapter"))
            {
                return;
            }

            PropertyInfo adapterProp = component.GetType().GetProperty("CommandCollection", BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.Instance);
            if (adapterProp == null)
            {
                return;
            }

            SqlCommand[] command = adapterProp.GetValue(component, null) as SqlCommand[];

            if (command == null)
            {
                return;
            }

            command[0].CommandTimeout = timeout;
        }

        public frmProdazbaOdSmetki()
        {
            InitializeComponent();
            ChangeTimeout(prodazbaOdSmetkiTableAdapter, 0);
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
            {
                prodazbaOdSmetkiTableAdapter.Fill(bSSRDataSet.ProdazbaOdSmetki, new DateTime(datumOd.DateTime.Year,
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
                prodazbaOdSmetkiTableAdapter.Fill(bSSRDataSet.ProdazbaOdSmetki, new DateTime(datumOd.DateTime.Year,
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
            label4.Text =  GenerateTextForSUM();
            Cursor.Current = Cursors.Default;
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Преглед на продажба од сметки за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();
            string FmiddleColumn = GenerateTextForSUM();

            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;

            link.ShowPreview();
        }

        private string GenerateTextForSUM()
        {
            string Sumi = string.Empty;

            for (int i = 0; i < gridProdazbaODSmetki.VisibleColumns.Count; ++i)
            {
                GridColumn column = gridProdazbaODSmetki.VisibleColumns[i];
                if (column.SummaryItem != null)
                {
                    if (column.SummaryItem.SummaryType == DevExpress.Data.SummaryItemType.Sum)
                    {
                        GridSummaryItem s = column.SummaryItem;
                        Sumi += column.Caption + " : " + Convert.ToDecimal(s.SummaryValue.ToString()).ToString("N2") + "  ";
                    }
                }
            }
            Sumi += Environment.NewLine;
            Sumi += DDV_ProcentString();
            var FmiddleColumn = Sumi;
            return FmiddleColumn;
        }

        public string DDV_ProcentString()
        {
            string DDV5 = Tools.PrazenStringToDecimal(bSSRDataSet.ProdazbaOdSmetki.Compute("SUM(PresmetanDDV)", "DDVProcent = 5.00").ToString()).ToString("N2");
            string DDV18 = Tools.PrazenStringToDecimal(bSSRDataSet.ProdazbaOdSmetki.Compute("SUM(PresmetanDDV)", "DDVProcent = 18.00").ToString()).ToString("N2");
            return string.Format("ДДВ 5% {0:0.##}", DDV5) + Environment.NewLine + string.Format("ДДВ 18% {0:0.##}", DDV18);

        }
        private void frmProdazbaOdSmetki_Load(object sender, EventArgs e)
        {

        }
    }
}
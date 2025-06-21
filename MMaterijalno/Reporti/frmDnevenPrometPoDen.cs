using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MMaterijalno.Reporti
{
    public partial class frmDnevenPrometPoDen : frmIzvestaj
    {
        public frmDnevenPrometPoDen()
        {
            InitializeComponent();
            ChangeTimeout(dnevenPrometPoDenTableAdapter, 3600);
        }
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
        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dnevenPrometPoDenTableAdapter.Fill(materijalnoDataSet.DnevenPrometPoDen, new DateTime(datumOd.DateTime.Year,
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
            var middleColumn = String.Format("Дневен промет по ден од {0} до {1} ", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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
    }
}
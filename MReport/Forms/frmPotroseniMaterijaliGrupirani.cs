using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;

namespace MReport.Forms
{
    public partial class frmPotroseniMaterijaliGrupirani : frmIzvestaj
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

        public frmPotroseniMaterijaliGrupirani()
        {
            InitializeComponent();
            ChangeTimeout(potroseniMaterijaliZaPeriodGrupiraniTableAdapter, 0);
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (rbtnSite.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    potroseniMaterijaliZaPeriodGrupiraniTableAdapter.Fill(bSSRDataSet.PotroseniMaterijaliZaPeriodGrupirani, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, false);
                }
                else
                {
                    potroseniMaterijaliZaPeriodGrupiraniTableAdapter.Fill(bSSRDataSet.PotroseniMaterijaliZaPeriodGrupirani, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, false);
                }
            }

            if (rbtnSocuvani.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    potroseniMaterijaliZaPeriodGrupiraniTableAdapter.Fill(bSSRDataSet.PotroseniMaterijaliZaPeriodGrupirani, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, true);
                }
                else
                {
                    potroseniMaterijaliZaPeriodGrupiraniTableAdapter.Fill(bSSRDataSet.PotroseniMaterijaliZaPeriodGrupirani, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                            DateTimeKind.Local), BssBase.settings.firmaId, BssBase.settings.MomentalenObjektID, true);
                }
            }
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
            var middleColumn = String.Format("Преглед на потрошени материјали за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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
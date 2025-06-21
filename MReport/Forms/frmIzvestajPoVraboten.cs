using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using BssBase;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmIzvestajPoVraboten : frmIzvestaj
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
        public int FiskalNaNeFiskkalNaSite;
        public frmIzvestajPoVraboten()
        {
            InitializeComponent();
            ChangeTimeout(izvestajPoKonobariBindingSource, 0);
            if (!string.IsNullOrEmpty(BssBase.settings.DisabledUsr))
            {
                izvestajPoKonobariBindingSource.Filter = "Vraboten <> '" + BssBase.settings.DisabledUsr + "'";
            }
         
        }

        private void GridView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.Landscape = false;
            pb.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.BPlus;
            pb.PageSettings.LeftMargin = 500;
            

        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Преглед на промет по вработен за период од: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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

            Cursor.Current = Cursors.WaitCursor;
            if (rbtnPocetok.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    izvestajPoKonobariTableAdapter.Fill(bSSRDataSet.IzvestajPoKonobari, new DateTime(datumOd.DateTime.Year,
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
                    izvestajPoKonobariTableAdapter.Fill(bSSRDataSet.IzvestajPoKonobari, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtminuta.Text),
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                            DatumDo.DateTime.Month,
                                                                                                                            DatumDo.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtCas2.Text,0),
                                                                                                                            Tools.PrazenStringToInt(txtMin2.Text, 0),
                                                                                                                            59,
                                                                                                                            DateTimeKind.Local));
                }
            }

            if (rbtnKraj.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    izvestajPoKonobariTableAdapter.FillByDatumKraj(bSSRDataSet.IzvestajPoKonobari, new DateTime(datumOd.DateTime.Year,
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
                    izvestajPoKonobariTableAdapter.FillByDatumKraj(bSSRDataSet.IzvestajPoKonobari, new DateTime(datumOd.DateTime.Year,
                                                                                                                            datumOd.DateTime.Month,
                                                                                                                            datumOd.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtminuta.Text, 0),
                                                                                                                            00,
                                                                                                                            DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                            DatumDo.DateTime.Month,
                                                                                                                            DatumDo.DateTime.Day,
                                                                                                                            Tools.PrazenStringToInt(txtCas2.Text, 0),
                                                                                                                            Tools.PrazenStringToInt(txtMin2.Text, 0),
                                                                                                                            59,
                                                                                                                            DateTimeKind.Local));
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void izvestajPoKonobariBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
        }

        private void frmIzvestajPoVraboten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (!string.IsNullOrEmpty(izvestajPoKonobariBindingSource.Filter))
                {
                    izvestajPoKonobariBindingSource.Filter = "";
                    btnPotvrdi1.PerformClick();
                }
                else
                {
                    if (!string.IsNullOrEmpty(BssBase.settings.DisabledUsr))
                    {
                        izvestajPoKonobariBindingSource.Filter = "Vraboten <> '" + BssBase.settings.DisabledUsr + "'";
                    }
                    btnPotvrdi1.PerformClick();
                }
            }
        }

        private void btnPecati2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(settings.PrinterPathDefault))
            {
                
                    using (var izv = new Reports.IzvestajPoVrabotenSkraten())
                    {
                        izv.SetDataSource(bSSRDataSet);
                        izv.PrintOptions.PrinterName = settings.PrinterPathDefault;
                        
                        izv.SetParameterValue("DatumOd", new DateTime(datumOd.DateTime.Year,
                            datumOd.DateTime.Month,
                            datumOd.DateTime.Day,
                            Tools.PrazenStringToInt(txtSaat.Text, 0),
                            Tools.PrazenStringToInt(txtminuta.Text, 0),
                            00,
                            DateTimeKind.Local).ToString(CultureInfo.InvariantCulture));
                        izv.SetParameterValue("DatumDo",  new DateTime(DatumDo.DateTime.Year,
                            DatumDo.DateTime.Month,
                            DatumDo.DateTime.Day,
                            Tools.PrazenStringToInt(txtCas2.Text, 0),
                            Tools.PrazenStringToInt(txtMin2.Text, 0),
                            59,
                            DateTimeKind.Local).ToString(CultureInfo.InvariantCulture));
                        izv.PrintToPrinter(1, false, 0, 0);
                        
                        
                        
                    }
                    
                }
            Cursor.Current = Cursors.Default;
        }
    }
}
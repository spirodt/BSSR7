using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmPregledNaSmetki : frmIzvestaj
    {
        public frmPregledNaSmetki()
        {
            InitializeComponent();
            gridView1.Appearance.Row.Font = new Font(gridView1.Appearance.Row.Font.FontFamily, 15);
        }

        private void frmPregledNaSmetki_Load(object sender, EventArgs e)
        {
            tblUsersTableAdapter.FillByAktivni(bSSRDataSet.tblUsers);
            if (!string.IsNullOrEmpty(BssBase.settings.DisabledUsr))
            {
                izvestajSmetkiBindingSource.Filter = "FullName <> '" + BssBase.settings.DisabledUsr + "'";
            }
            //izvestajSmetkiTableAdapter.FillByAll(bSSRDataSet.IzvestajSmetki);
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

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (rbtnPocetok.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    izvestajSmetkiTableAdapter.FillByUserID(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                        DateTimeKind.Local), Convert.ToInt32(tblUserscmbBase.SelectedValue));
                }
                else
                {
                    izvestajSmetkiTableAdapter.FillByUserID(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
                                                                                                                        datumOd.DateTime.Month,
                                                                                                                        datumOd.DateTime.Day,
                                                                                                                        Tools.PrazenStringToInt(txtSaat.Text,0),
                                                                                                                        Tools.PrazenStringToInt(txtminuta.Text, 0),
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                        DatumDo.DateTime.Month,
                                                                                                                        DatumDo.DateTime.Day,
                                                                                                                        Tools.PrazenStringToInt(txtCas2.Text, 0),
                                                                                                                        Tools.PrazenStringToInt(txtMin2.Text,0),
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local), Convert.ToInt32(tblUserscmbBase.SelectedValue));
                }
            }

            if (rbtnKraj.Checked)
            {
                if (txtSaat.Text == "0" && txtMin.Text == "0" && txtCas2.Text == "0" && txtMin2.Text == "0")
                {
                    izvestajSmetkiTableAdapter.FillByUserIDKraj(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                        DateTimeKind.Local), Convert.ToInt32(tblUserscmbBase.SelectedValue));
                }
                else
                {
                    izvestajSmetkiTableAdapter.FillByUserIDKraj(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
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
                                                                                                                        DateTimeKind.Local), Convert.ToInt32(tblUserscmbBase.SelectedValue));
                }
            }
        }

        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            if (rbtnPocetok.Checked)
            {
                if (txtminuta.Text == 0.ToString() && txtSaat.Text == 0.ToString())
                {
                    izvestajSmetkiTableAdapter.FillbyDatum(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
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
                    izvestajSmetkiTableAdapter.FillbyDatum(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
                                                                                                                        datumOd.DateTime.Month,
                                                                                                                        datumOd.DateTime.Day,
                                                                                                                        Tools.PrazenStringToInt(txtSaat.Text,0),
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
            if (rbtnKraj.Checked)
            {
                if (txtminuta.Text == 0.ToString() && txtSaat.Text == 0.ToString())
                {
                    izvestajSmetkiTableAdapter.FillByDatumKraj(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
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
                    izvestajSmetkiTableAdapter.FillByDatumKraj(bSSRDataSet.IzvestajSmetki, new DateTime(datumOd.DateTime.Year,
                                                                                                                        datumOd.DateTime.Month,
                                                                                                                        datumOd.DateTime.Day,
                                                                                                                        Tools.PrazenStringToInt(txtSaat.Text,0),
                                                                                                                        Tools.PrazenStringToInt(txtminuta.Text,0),
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                                                                                                                        DatumDo.DateTime.Month,
                                                                                                                        DatumDo.DateTime.Day,
                                                                                                                        Tools.PrazenStringToInt(txtCas2.Text,0),
                                                                                                                        Tools.PrazenStringToInt(txtMin2.Text,0),
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local));
                }
            }
        }

        private void izvestajSmetkiBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
        }

        private void frmPregledNaSmetki_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmPregledNaSmetki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (!string.IsNullOrEmpty(izvestajSmetkiBindingSource.Filter))
                {
                    izvestajSmetkiBindingSource.Filter = "";
                    btnPotvrdi2.PerformClick();
                }
                else
                {
                    if (!string.IsNullOrEmpty(BssBase.settings.DisabledUsr))
                    {
                        izvestajSmetkiBindingSource.Filter = "FullName <> '" + BssBase.settings.DisabledUsr + "'";
                    }
                    btnPotvrdi2.PerformClick();
                }
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Equals(izvestajSmetkiBindingSource.Current, null)) { return; }
            if (e.KeyCode == Keys.F3)
            {
                int smetkaID = Tools.PrazenStringToInt(((DataRowView)izvestajSmetkiBindingSource.Current)["ID"].ToString());
                string vraboten = ((DataRowView)izvestajSmetkiBindingSource.Current)["FullName"].ToString();
                var asm = System.Reflection.Assembly.Load("MFakturi");
                var t = asm.CreateInstance("MFakturi.Forms.frmKasa").GetType();
                dynamic frm = (Form)Activator.CreateInstance(t);
                frm.PratiNaPrinterSmetkaA4_Vraboten(smetkaID, vraboten);
                frm.Close();
                frm.Dispose();
            }
        }
    }
}
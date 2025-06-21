using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MMaterijalno.Reporti
{
    public partial class frmPregledNaSmetkiPoPresmetkovnaEdinica : frmIzvestaj
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

        public frmPregledNaSmetkiPoPresmetkovnaEdinica()
        {
            InitializeComponent();
            ChangeTimeout(smetkiIznosDDVPoPresmetkovnaEdinicaBindingSource, 0);
            var db = Tools.najdiMinMaxOdPregledNaSmetki();
            if (db != null)
            {
                txtPresMin.Text = db["MinPresmetkovna"].ToString();
                txtPresMax.Text = db["MaxPresmetkovna"].ToString();
             
            }
        }
   

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Салдо на пресметковна единица ( {2} ) за период од : {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString(), string.Format("{0}{1}",txtPresMin.Text, txtPresMax.Text));
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();
            string FmiddleColumn = GenerateTextForSUM();

            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;
            link.ShowPreview();
        }

        public string DDV_ProcentString()
        {
            string DDV5 = Tools.PrazenStringToDecimal(materijalnoDataSet.SmetkiIznosDDVPoPresmetkovnaEdinica.Compute("SUM(PresmetanDDV)", "DDVProcent = 5.00").ToString()).ToString("N2");
            string DDV18 = Tools.PrazenStringToDecimal(materijalnoDataSet.SmetkiIznosDDVPoPresmetkovnaEdinica.Compute("SUM(PresmetanDDV)", "DDVProcent = 18.00").ToString()).ToString("N2");
            string Iznos = Tools.PrazenStringToDecimal(materijalnoDataSet.SmetkiIznosDDVPoPresmetkovnaEdinica.Compute("SUM(Iznos)", "").ToString()).ToString("N2");
            string IznosBez = Tools.PrazenStringToDecimal(materijalnoDataSet.SmetkiIznosDDVPoPresmetkovnaEdinica.Compute("SUM(IznosBezDDV)", "").ToString()).ToString("N2");
            return string.Format("ДДВ 5% {0:0.##}", DDV5) + Environment.NewLine + string.Format("ДДВ 18% {0:0.##}", DDV18) + Environment.NewLine + string.Format("Износ {0:0.##}", Iznos) + Environment.NewLine + string.Format("Износ дез ДДВ {0:0.##}",IznosBez);

        }

        private string GenerateTextForSUM()
        {
            string Sumi = string.Empty;

            //for (int i = 0; i < gridControl1.VisibleColumns.Count; ++i)
            //{
            //    GridColumn column = gridControl1.VisibleColumns[i];
            //    if (column.SummaryItem != null)
            //    {
            //        if (column.SummaryItem.SummaryType == DevExpress.Data.SummaryItemType.Sum)
            //        {
            //            GridSummaryItem s = column.SummaryItem;
            //            Sumi += column.Caption + " : " + Convert.ToDecimal(s.SummaryValue.ToString()).ToString("N2") + "  ";
            //        }
            //    }
            //}
            //Sumi += Environment.NewLine;
            Sumi += DDV_ProcentString();
            var FmiddleColumn = Sumi;
            return FmiddleColumn;
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            smetkiIznosDDVPoPresmetkovnaEdinicaTableAdapter.Fill(materijalnoDataSet.SmetkiIznosDDVPoPresmetkovnaEdinica, new DateTime(datumOd.DateTime.Year,
                    datumOd.DateTime.Month,
                    datumOd.DateTime.Day,
                    0,
                    0,
                    00,
                    DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                    DatumDo.DateTime.Month,
                    DatumDo.DateTime.Day,
                    23,
                    59,
                    59,
                    DateTimeKind.Local),txtPresMin.Text,txtPresMax.Text);
            label4.Text = GenerateTextForSUM();
            Cursor.Current = Cursors.Default;
        }

        private void frmPregledNaSmetkiPoPartner_Load(object sender, EventArgs e)
        {

            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DatumDo.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        }
    }
}

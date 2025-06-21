using System;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;

namespace MReport.Forms
{
    public partial class frmPregledNaPlacanjePoDokument : frmIzvestaj
    {
        public frmPregledNaPlacanjePoDokument()
        {
            InitializeComponent();
        }
        public int mesec { get; set; }
        public int godina { get; set; }

        public int tipNaDokument { get; set; }
        public frmPregledNaPlacanjePoDokument(int godina , int mesec , int tipNaDokument )
        {
            InitializeComponent();
            this.Load -= frmPregledNaPlacanjePoDokument_Load;
            this.Load += frmPregledNaPlacanjePoDokument_LoadNadvor;
            this.godina = godina;
            this.mesec = mesec;
            this.tipNaDokument = tipNaDokument;
        }
        private void btnPecati1_Click(object sender, EventArgs e)
        {
            if (this.bSSRDataSet.DokumentiIzvodiPartner.Rows.Count > 0)
            {
                PrintableComponentLink link = PrintGridSettings();

                link.ShowPreview();
            }
        }



        private PrintableComponentLink PrintGridSettings(dynamic grdControl = null)
        {
            var info = Tools.NajdiInfoZaFirma(1);
           string NazivNaFirma = info.Table.Rows[0]["ImeNaFirma"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Adresa"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Grad"].ToString();

            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            if (grdControl is null)
            {
                link.Component = gridControl1;
            }
            else
            {
                link.Component = grdControl;
            }
            link.Landscape = true;
            var sumColumn = "Преостанато за плаќање : " + this.bSSRDataSet.DokumentiIzvodiPartner.Compute("SUM(PlatenoZaDokument)", "") + " ден.";

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Преглед на  документи по партнер за период  : {0}  до: {1}", datumOd.DateTime.ToString("dd.MM.yyyy"), DatumDo.DateTime.ToString("dd.MM.yyyy"));
            string rightColumn = "Датум: " + DateTime.Now.ToString("dd.MM.yyyy") + Environment.NewLine + Environment.NewLine + sumColumn;

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            phf.Footer.Content.Clear();

            var FmiddleColumn = NazivNaFirma;
           
            phf.Footer.Content.AddRange(new string[] { FmiddleColumn , sumColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;

            return link;
        }
        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            this.dokumentiIzvodiPartnerTableAdapter.Fill(this.bSSRDataSet.DokumentiIzvodiPartner,Convert.ToInt32(rbtnSite.Checked), datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
        }

        private void frmPregledNaPlacanjePoDokument_LoadNadvor(object sender, EventArgs e)
        {
            datumOd.DateTime =
                new DateTime(godina,mesec, 1);
            DatumDo.DateTime =
                new DateTime(godina, mesec, DateTime.DaysInMonth(godina, mesec));
            this.dokumentiIzvodiPartnerTableAdapter.Fill(this.bSSRDataSet.DokumentiIzvodiPartner, 0, datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            ColumnView view = gridView1;
            view.ActiveFilter.Add(view.Columns["DocNaziv"], new ColumnFilterInfo($"[DocNaziv] LIKE '%{tipNaDokument}-%'", ""));
        }

        private void frmPregledNaPlacanjePoDokument_Load(object sender, EventArgs e)
        {
            datumOd.DateTime = 
                new DateTime(DateTime.Now.Year, 1, 1);
            DatumDo.DateTime = 
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
    }
}
﻿using System;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MReport.Forms
{
    public partial class frmIzvestajZaPerdiodFakturi : frmIzvestaj
    {
        public frmIzvestajZaPerdiodFakturi()
        {
            InitializeComponent();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            viewFakturiTableAdapter.FillByPeriod(bSSRDataSet.viewFakturi, new DateTime(datumOd.DateTime.Year,
                                                                                                                        datumOd.DateTime.Month,
                                                                                                                        datumOd.DateTime.Day,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local).ToShortDateString(), new DateTime(DatumDo.DateTime.Year,
                                                                                                                        DatumDo.DateTime.Month,
                                                                                                                        DatumDo.DateTime.Day,
                                                                                                                        23,
                                                                                                                        59,
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local).ToShortDateString());
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Издадени фактури за период од : {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
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

        private void frmIzvestajZaPerdiodFakturi_Load(object sender, EventArgs e)
        {
            DatumDo.DateTime = DateTime.Now;
            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }
    }
}
using System;
using BssBase.Roots;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using BssBase;
using System.Data;

namespace MReport.Forms
{
    public partial class frmPregledNaGodisnoSaldo : frmIzvestaj
    {
        public frmPregledNaGodisnoSaldo()
        {
            InitializeComponent();
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            if (this.bSSRDataSet.GodisnoSaldoNaPartneri.Rows.Count > 0 && cmbTipNaDokument.SelectedIndex != -1)
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
           

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            
            string middleColumn = "Преглед на годишно салдо на партнери според " + cmbTipNaDokument.Text;
            if (settings.TipNaPrograma == "10KulaB")
            {
                if(cmbTipNaDokument.SelectedIndex == 0)
                {
                    middleColumn = $"Преглед на годишно салдо на наплата за Одржување";
                }
                if (cmbTipNaDokument.SelectedIndex == 1)
                {
                    middleColumn = $"Преглед на годишно салдо на наплата за Климатизација";
                }
                
            }
            string rightColumn = "Датум: " + DateTime.Now.ToString("dd.MM.yyyy") + Environment.NewLine;

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            phf.Footer.Content.Clear();

            var FmiddleColumn = NazivNaFirma;
           
            phf.Footer.Content.AddRange(new string[] { FmiddleColumn  });
            phf.Footer.LineAlignment = BrickAlignment.None;

            return link;
        }
        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipNaDokument.SelectedIndex == -1)
                {
                    MessageBox.Show("Мора да изберете тип на документ");
                    return;
                }

                this.godisnoSaldoNaPartneriTableAdapter.Fill(this.bSSRDataSet.GodisnoSaldoNaPartneri, cmbTipNaDokument.SelectedValue.toInt(), txtPartnerFilter.Text);
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex, "Грешка при вчитување на податоците");
            }
        }

        private void frmPregledNaGodisnoSaldo_Load(object sender, EventArgs e)
        {
            cmbTipNaDokument.LoadItems("select ID, Naziv as Vrednost from tblTipNaDokument");
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            // Assuming you have a GridView named gridView1
            var selectedRow = gridView1.GetFocusedRow();

            // If you need to get the data row
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            // Example of accessing a specific column value
            if (dataRow != null && cmbTipNaDokument.SelectedIndex != -1)
            {
                var godina = dataRow["Godina"].toInt();
                var mesec = dataRow["Mesec"].toInt();

                int tipNaDokument = cmbTipNaDokument.SelectedValue.toInt();
                if (tipNaDokument == 2)
                {
                    mesec = mesec + 1;
                }

                frmPregledNaPlacanjePoDokument frm = new frmPregledNaPlacanjePoDokument(godina, mesec, tipNaDokument);
                frm.ShowDialog();
                // Do something with the value
            }

        }
    }
}
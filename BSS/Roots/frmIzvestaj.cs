using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.Utils;

namespace BssBase.Roots
{
    public partial class frmIzvestaj : Form
    {
        public frmIzvestaj()
        {
            InitializeComponent();
        }

        public void DisableEmailButton()
        {
            пратиГоМоменталниотИзвештајПоМаилToolStripMenuItem.Enabled = false;
        }

        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void пратиГоМоменталниотИзвештајПоМаилToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString() + ".pdf";
            dynamic grid = Controls.Find("gridControl1", true).FirstOrDefault();
            dynamic datumOd = Controls.Find("datumOd", true).FirstOrDefault();
            dynamic DatumDo = Controls.Find("DatumDo", true).FirstOrDefault();

            grid.ExportToPdf(Tools.setExportPath(fileName, true));
            string subject = Text + " - " + DateTime.Now.ToString();

            string MailText = String.Format(Text + " Датум: {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            Tools.SendMailDefault(Tools.setExportPath(fileName), subject, MailText);
        }

        public void FontGolemi(DevGrid gridv, bool zgolemi)
        {
            var grview = (DevExpress.XtraGrid.Views.Grid.GridView)gridv.Views[0];
            grview.ColumnPanelRowHeight = 40;
            if (zgolemi)
                grview.Appearance.Row.Font = new System.Drawing.Font(grview.Appearance.Row.Font.FontFamily, grview.Appearance.Row.Font.Size + 2);
            else
                grview.Appearance.Row.Font = new System.Drawing.Font(grview.Appearance.Row.Font.FontFamily, grview.Appearance.Row.Font.Size - 2);


        }

        public void SetFontSizeForGrid(DevGrid gridv, int fontSize)
        {
            var grview = (DevExpress.XtraGrid.Views.Grid.GridView)gridv.Views[0];
            grview.ColumnPanelRowHeight = 40;
            grview.Appearance.Row.Font = new System.Drawing.Font(grview.Appearance.Row.Font.FontFamily, fontSize);

        }

        public void SrediSize(DevGrid gridv)
        {
            var grview = (DevExpress.XtraGrid.Views.Grid.GridView)gridv.Views[0];
            grview.ColumnPanelRowHeight = 40;

            grview.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap;
            grview.AppearancePrint.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap;

            grview.Appearance.FooterPanel.TextOptions.WordWrap = WordWrap.NoWrap;

            grview.AppearancePrint.FooterPanel.TextOptions.WordWrap = WordWrap.Wrap;
            grview.AppearancePrint.FooterPanel.TextOptions.HAlignment = HorzAlignment.Center;
            grview.AppearancePrint.FooterPanel.Font = new System.Drawing.Font(Font.FontFamily, 14, System.Drawing.FontStyle.Bold);

            grview.ActiveFilter.Clear();
        }


        private void frmIzvestaj_Load(object sender, EventArgs e)
        {
            dynamic datumOd = Controls.Find("datumOd", true).FirstOrDefault();
            dynamic DatumDo = Controls.Find("DatumDo", true).FirstOrDefault();


            if (Equals(null, datumOd)) return;
            datumOd.DateTime = DateTime.Now;
            if (Equals(null, DatumDo)) return;
            DatumDo.DateTime = DateTime.Now;
            if (BssBase.settings.TipNaPrograma == "10KulaB")
            {
                if (Equals(null, datumOd))
                {
                    return;
                }
                else
                {
                    var datumFirst = Convert.ToDateTime(Tools.NajdiPrvRekordUtabela("Datum", "tblDokumenti"));
                    datumOd.DateTime = new  DateTime(datumFirst.Year,datumFirst.Month,1);
                }
                if (Equals(null, DatumDo)) return;
                DatumDo.DateTime = DateTime.Now;
            }
            if (settings.TipNaPrograma == "250" || settings.TipNaPrograma == "Documents789")
            {
                пратиГоМоменталниотИзвештајПоМаилToolStripMenuItem.Visible = false;
            }

            dynamic grid = Controls.Find("gridControl1", true).FirstOrDefault();

            SrediSize((DevGrid)grid);

        }

        private void ресетирајToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void зголемиФонтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dynamic grid = Controls.Find("gridControl1", true).FirstOrDefault();
            FontGolemi(grid, true);
        }

        private void намалиФонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic grid = Controls.Find("gridControl1", true).FirstOrDefault();
            FontGolemi(grid, false);
        }
    }
}
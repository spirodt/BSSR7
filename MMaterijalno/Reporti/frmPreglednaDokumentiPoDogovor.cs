using System;
using System.Windows.Forms;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MMaterijalno.Reporti
{
    public partial class frmPreglednaDokumentiPoDogovor : frmIzvestaj
    {
        public frmPreglednaDokumentiPoDogovor()
        {
            InitializeComponent();
            
        }



        private void btnPecati1_Click(object sender, EventArgs e)
        {
            if (cmbDogovor.SelectedValue != null && cmbDokumenti.SelectedIndex != -1)
            {
                var link = new PrintableComponentLink(new PrintingSystem());
                var phf = link.PageHeaderFooter as PageHeaderFooter;
                link.Component = gridControl1;
                link.Landscape = true;

                phf.Header.Content.Clear();
                const string leftColumn = "Страни: [Page # of Pages #]";
                var middleColumn = String.Format("Дадени артикли во документ број {0} {2} според договор со : {1}", cmbDokumenti.Text, cmbDogovor.Text, Environment.NewLine);
                const string rightColumn = "Датум: [Date Printed]";

                phf.Header.Content.AddRange(new string[] { middleColumn, Environment.NewLine });
                phf.Header.LineAlignment = BrickAlignment.Center;

                phf.Footer.Content.Clear();


                var FmiddleColumn = string.Empty;


                phf.Footer.Content.AddRange(new string[] { leftColumn, FmiddleColumn, rightColumn });
                phf.Footer.LineAlignment = BrickAlignment.None;
                link.ShowPreview();
            }
        }

       

        private void FrmPreglednaDokumentiOdPartner_Load(object sender, EventArgs e)
        {
         
            cmbDogovor.LoadItems("select ID, Naziv as Vrednost from tblDogovori");
            cmbDogovor.SelectedIndex = -1;
            cmbDogovor.SelectedIndexChanged += cmbDogovor_SelectedIndexChanged; 
            cmbDokumenti.SelectedIndexChanged += cmbDokumenti_SelectedIndexChanged; 
        }

        private void cmbDokumenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cmbDogovor.SelectedValue != null && cmbDokumenti.SelectedIndex != -1)
            {
                this.viewDokumentiStavkiTableAdapter.FillBy(this.materijalnoDataSet.viewDokumentiStavki, Tools.PrazenStringToInt(cmbDokumenti.SelectedValue.ToString()));
            }
        }

        private void cmbDogovor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDokumenti.LoadItems("select ID, ('(' + CAST(Broj as nvarchar) +') - ' + BrojNaDokument + ' - ' + CAST(Datum as nvarchar)) as Vrednost from tblDokumenti where tblDogovoriID = " + cmbDogovor.SelectedValue);
        }
    }
}

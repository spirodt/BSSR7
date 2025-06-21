using System;
using System.Data;
using System.Windows.Forms;
using BssBase;
using DevExpress.XtraPrinting;

namespace MMaterijalno.Forms
{
    public partial class frmVnesNaPlacanjaZaPartner : frmBigEdit
    {
        public frmVnesNaPlacanjaZaPartner()
        {
            InitializeComponent();
            datumNaUplataDateTimePicker.Value = DateTime.Now;
            btnOk.Visible = false;
        }

        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
            validatePartner();
        }

        public bool validatePartner()
        {
            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);
            if (zbxPartner.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    zbxPartner.zoomClear();
                    txtPartner.Clear();
                    zbxPartner.ret1 = info["ID"].ToString();
                    zbxPartner.Value.Text = info["Sifra"].ToString();
                    zbxPartner.Text = info["Naziv"].ToString();
                    txtPartner.Text = info["Naziv"].ToString();
                    if (!string.IsNullOrEmpty(zbxPartner.ret1))
                    {
                        tblPlacanjaOdPartnerBindingSource.Filter = "tblPartnerID =" + zbxPartner.ret1;
                        tblPlacanjaOdPartnerTableAdapter.Fill(materijalnoDataSet.tblPlacanjaOdPartner);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("PartnerotNePostoi"));
                    zbxPartner.zoomClear();
                    txtPartner.Text = string.Empty;
                    return false;
                }
            }
            return false;
        }

        private void zbxPartner_Validated(object sender, EventArgs e)
        {
            validatePartner();
        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTab.SelectedTab == tabPage1)
            {
                pobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter.Fill(materijalnoDataSet.PobaruvaDolguvaPartnerOdPocetokDoKraj, Tools.PrazenStringToInt(zbxPartner.ret1));
            }
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zbxPartner.ret1) && iznosTextBox.PrazenStringToDecimal_dec() != 0)
            {
                Tools.insertirajPlacanjeVoTabela(Tools.PrazenStringToInt(zbxPartner.ret1), iznosTextBox.PrazenStringToDecimal_dec(), datumNaUplataDateTimePicker.Value, dokumentBrojTextBox.Text, izvodBrojTextBox.Text, zabeleskaTextBox.Text, radioButton1.Checked);
                tblPlacanjaOdPartnerTableAdapter.Fill(materijalnoDataSet.tblPlacanjaOdPartner);
            }
        }

        private void btnPonisti1_Click(object sender, EventArgs e)
        {
            if (Equals(tblPlacanjaOdPartnerBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)tblPlacanjaOdPartnerBindingSource.Current)["ID"].ToString());
                Tools.IzbrisiStavkaPlacanje(stavkaID);
                tblPlacanjaOdPartnerBindingSource.Filter = "tblPartnerID =" + zbxPartner.ret1;
                tblPlacanjaOdPartnerTableAdapter.Fill(materijalnoDataSet.tblPlacanjaOdPartner);
            }
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = devGrid1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Салдо од партнер ");
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            link.ShowPreview();
        }

        private void btnPecati2_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = viewFakturiStavkiDevGrid;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format("Сите плаќања од партнер ");
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            link.ShowPreview();
        }

        private void frmVnesNaPlacanjaZaPartner_Load(object sender, EventArgs e)
        {
            gridView1.ActiveFilter.Clear();
        }
    }
}
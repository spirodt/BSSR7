using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BSS;

namespace MFakturi
{
    public partial class frmFaktura : Form
    {
        public frmFaktura()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            dtShowDataOD.Value = BssBase.settings.DateTimeOd;
            dtShowDataDO.Value = BssBase.settings.DateTimeDo;

            if (BssBase.settings.NeLoadirajPodatociNaStartNaForma == "false")
                viewFakturiTableAdapter.Fill(fakturiDataSet.viewFakturi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void frmFaktura_Load(object sender, EventArgs e)
        {
            
            if (BssBase.settings.TipNaPrograma == "987")
            {
                btnPecati.Visible = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Forms.frmObrabotkaNaFaktura faktura = new Forms.frmObrabotkaNaFaktura();
            faktura.ShowDialog();
            viewFakturiTableAdapter.Fill(fakturiDataSet.viewFakturi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void bтнОтвори_Click(object sender, EventArgs e)
        {
            if (!Equals(null, viewFakturiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewFakturiBindingSource.Current)["ID"].ToString());
                Forms.frmObrabotkaNaFaktura faktura = new Forms.frmObrabotkaNaFaktura(id);
                int knizeno = Tools.PrazenStringToInt(((DataRowView)viewFakturiBindingSource.Current)["Knizeno"].ToString());
                if (knizeno == 1)
                {
                    faktura.SetFormReadOnly();
                }

                faktura.ShowDialog();
                viewFakturiTableAdapter.Fill(fakturiDataSet.viewFakturi, dtShowDataOD.Value, dtShowDataDO.Value);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            viewFakturiTableAdapter.Fill(fakturiDataSet.viewFakturi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void viewFakturiGridBig_dataSaveAll()
        {
            viewFakturiBindingSource.EndEdit();
            viewFakturiTableAdapter.Update(fakturiDataSet.viewFakturi);
        }

        private void viewFakturiGridBig_DataInsert()
        {
            viewFakturiTableAdapter.Fill(fakturiDataSet.viewFakturi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            viewFakturiGridBig.izbrisi();
        }

        public void Pecati()
        {
            if (!Equals(null, viewFakturiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewFakturiBindingSource.Current)["ID"].ToString());
                int Partnerid = Tools.PrazenStringToInt(((DataRowView)viewFakturiBindingSource.Current)["tblPartnerID"].ToString());

                tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);
                tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri, Partnerid);
                viewFakturiTableAdapter.FillBy(fakturiDataSet.viewFakturi, id);
                viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, id);

                try
                {
                    if (BssBase.settings.TipNaPrograma == "987")
                    {
                        using (var smetka = new Forms.Reporti.frmFaktura987())
                        {
                            smetka.SetDataSource(fakturiDataSet);
                            PrintPreview prev = new PrintPreview();
                            smetka.SetParameterValue("Faktura", "Фактура");
                            smetka.SetParameterValue("User", BssBase.tmpConfigs.LogiranUserFullName);
                            smetka.SetParameterValue("Napomena", File.ReadAllText("Napomena.txt", Encoding.UTF8));
                            prev.ReportPreview.ReportSource = smetka;
                            prev.Show();
                            smetka.Dispose();
                        }
                    }
                    else
                    {
                        
                        using (var smetka = new Forms.Reporti.frmFaktura())
                        {
                            smetka.SetDataSource(fakturiDataSet);
                            PrintPreview prev = new PrintPreview();
                            smetka.SetParameterValue("Faktura", "Фактура");
                            smetka.SetParameterValue("User", BssBase.tmpConfigs.LogiranUserFullName);
                            smetka.SetParameterValue("Napomena", File.ReadAllText("Napomena.txt", Encoding.UTF8));
                            prev.ReportPreview.ReportSource = smetka;
                            prev.Show();
                            smetka.Dispose();
                        }
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                }
            }
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            Pecati();
        }

        private void frmFaktura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            if (e.KeyCode == Keys.F2)
            {
                bтнОтвори.PerformClick();
            }

            if (e.KeyCode == Keys.F3)
            {
                btnPecati.PerformClick();
            }

            if (e.KeyCode == Keys.F4)
            {
                toolStripButton2.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                toolStripButton1.PerformClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                bindingNavigatorDeleteItem.PerformClick();
            }
        }

        private void viewFakturiGridBig_DoubleClick(object sender, EventArgs e)
        {
            bтнОтвори.PerformClick();
        }

        private void btnPrikaziSporedFiltri_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void btnPrikaziSe_Click(object sender, EventArgs e)
        {
            viewFakturiTableAdapter.FillByAll(fakturiDataSet.viewFakturi);
        }
    }
}
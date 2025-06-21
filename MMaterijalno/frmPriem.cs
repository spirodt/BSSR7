using System;
using System.Data;
using System.Windows.Forms;
using BSS;

namespace MMaterijalno
{
    public partial class frmPriem : Form
    {
        public frmPriem()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            dtShowDataOD.Value =  BssBase.settings.DateTimeOd;
            dtShowDataDO.Value = BssBase.settings.DateTimeDo;

            if (BssBase.settings.NeLoadirajPodatociNaStartNaForma == "false")
                viewPriemiTableAdapter.Fill(materijalnoDataSet.viewPriemi, dtShowDataOD.Value, dtShowDataDO.Value);
            viewPriemiNavigator.BindingSource = viewPriemiBindingSource;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            viewPriemiGridBig.Osvezi();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            viewPriemiGridBig.izbrisi();
        }

        private void viewPriemiGridBig_DataInsert()
        {
            viewPriemiTableAdapter.Fill(materijalnoDataSet.viewPriemi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void viewPriemiGridBig_dataSaveAll()
        {
            viewPriemiBindingSource.EndEdit();
            viewPriemiTableAdapter.Update(materijalnoDataSet.viewPriemi);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Forms.frmObrabotkaNaPriem priem = new Forms.frmObrabotkaNaPriem();
            priem.ShowDialog();
            viewPriemiTableAdapter.Fill(materijalnoDataSet.viewPriemi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void bтнОтвори_Click(object sender, EventArgs e)
        {
            if (!Equals(null, viewPriemiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewPriemiBindingSource.Current)["ID"].ToString());
                Forms.frmObrabotkaNaPriem priem = new Forms.frmObrabotkaNaPriem(id);
                int knizeno = Tools.PrazenStringToInt(((DataRowView)viewPriemiBindingSource.Current)["Knizeno"].ToString());
                if (knizeno == 1)
                {
                    priem.SetFormReadOnly();
                }
                priem.ShowDialog();
                viewPriemiTableAdapter.Fill(materijalnoDataSet.viewPriemi, dtShowDataOD.Value, dtShowDataDO.Value);
            }
        }

        public void Pecati(int PriemID)
        {
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            viewPriemiTableAdapter.FillBy(materijalnoDataSet.viewPriemi, PriemID);
            viewPriemStavkiTableAdapter.FillBy(materijalnoDataSet.viewPriemStavki, PriemID);

            try
            {
                using (var smetka = new Reporti.Priem())
                {
                    smetka.SetDataSource(materijalnoDataSet);
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Tools.PrevediPoraka("Проблем со печатарот !!!"), "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.PrevediSQLException(ex);
            }
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            if (!Equals(null, viewPriemiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewPriemiBindingSource.Current)["ID"].ToString());
                Pecati(id);
            }
            viewPriemiTableAdapter.Fill(materijalnoDataSet.viewPriemi, dtShowDataOD.Value, dtShowDataDO.Value);
        }


        private void frmPriem_Load(object sender, EventArgs e)
        {
           

        }

        private void frmPriem_KeyDown(object sender, KeyEventArgs e)
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

        private void viewPriemiGridBig_DoubleClick(object sender, EventArgs e)
        {
            bтнОтвори.PerformClick();
        }

        private void btnPrikaziSporedFiltri_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void btnPrikaziSe_Click(object sender, EventArgs e)
        {
            viewPriemiTableAdapter.FillByAll(materijalnoDataSet.viewPriemi);
        }
    }
}
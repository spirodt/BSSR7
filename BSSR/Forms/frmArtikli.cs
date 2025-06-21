using System;
using System.Data.SqlClient;
using BssBase;

//BSSR.Forms.frmArtikli
namespace BSSR.Forms
{
    public partial class frmArtikli : frmBigShow
    {
        public frmArtikli()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                viewArtikliTableAdapter.Fill(bSSSDataset.viewArtikli);
            //asdasdasd
        }

        public frmArtikli(bool prikaziPotvrdi, bool ReadOnly)
        {
            InitializeComponent();
            btnOk.Visible = false;
            viewArtikliTableAdapter.Fill(bSSSDataset.viewArtikli);
            if (ReadOnly)
            {
                Meni.Enabled = false;
            }
            btnOk.Visible = prikaziPotvrdi;
        }

        public frmArtikli(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            viewArtikliTableAdapter.Fill(bSSSDataset.viewArtikli);
            AcceptButton = null;
            viewArtikliGridBig.Select();
            //if ( !string.IsNullOrEmpty( filter ) ) {
            //    viewArtikliBindingSource.Filter = filter;
            //}
            //srediIminjaNaGrid();
        }

        private void tblArtikalgrdBase_DataInsert()
        {
            viewArtikliTableAdapter.Fill(bSSSDataset.viewArtikli);
        }

        private void tblArtikalgrdBase_dataSaveAll()
        {
            try
            {
                viewArtikliBindingSource.EndEdit();
                viewArtikliTableAdapter.Update(bSSSDataset.viewArtikli);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblArtikalgrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }

        private void viewArtikliGridBig_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter || e.KeyCode == System.Windows.Forms.Keys.Return)
            {
                if (zoom)
                    btnOk.PerformClick();
            }

            if (e.KeyCode == System.Windows.Forms.Keys.Down)
            {
                viewArtikliGridBig.Focus();
            }
        }
    }
}
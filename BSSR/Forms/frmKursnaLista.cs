using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmKursnaLista : frmBigShow
    {
        public frmKursnaLista()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblKursnaListaTableAdapter.Fill(bSSSDataset.tblKursnaLista);
        }

        public frmKursnaLista(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblKursnaListaTableAdapter.Fill(bSSSDataset.tblKursnaLista);
            AcceptButton = btnOk;
            tblKursnaListaGridBig.Select();
            SrediIminjaNaGrid();
        }

        private void tblKursnaListagrdBase_DataInsert()
        {
            tblKursnaListaTableAdapter.Fill(bSSSDataset.tblKursnaLista);
        }

        private void tblKursnaListagrdBase_dataSaveAll()
        {
            try
            {
                tblKursnaListaBindingSource.EndEdit();
                tblKursnaListaTableAdapter.Update(bSSSDataset.tblKursnaLista);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblKursnaListagrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }

        private void frmKursnaLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bSSSDataset.tblValuti' table. You can move, or remove it, as needed.
            tblValutiTableAdapter.Fill(bSSSDataset.tblValuti);
        }
    }
}
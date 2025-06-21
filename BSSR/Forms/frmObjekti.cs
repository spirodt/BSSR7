using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmObjekti : frmBigShow
    {
        public frmObjekti()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblObjektiTableAdapter.Fill(bSSSDataset.tblObjekti);
        }

        public frmObjekti(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblObjektiTableAdapter.Fill(bSSSDataset.tblObjekti);
            AcceptButton = btnOk;
            tblObjektiGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblObjektiBindingSource.Find("Naziv", filter);
                tblObjektiBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblObjektigrdBase_DataInsert()
        {
            tblObjektiTableAdapter.Fill(bSSSDataset.tblObjekti);
        }

        private void tblObjektigrdBase_dataSaveAll()
        {
            try
            {
                tblObjektiBindingSource.EndEdit();
                tblObjektiTableAdapter.Update(bSSSDataset.tblObjekti);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblObjektigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmFirmi : frmBigShow
    {
        public frmFirmi()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblFirmaTableAdapter.Fill(bSSSDataset.tblFirma);
        }

        public frmFirmi(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblFirmaTableAdapter.Fill(bSSSDataset.tblFirma);
            AcceptButton = btnOk;
            tblFirmaGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblFirmaBindingSource.Find("Naziv", filter);
                tblFirmaBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblFirmagrdBase_DataInsert()
        {
            tblFirmaTableAdapter.Fill(bSSSDataset.tblFirma);
        }

        private void tblFirmagrdBase_dataSaveAll()
        {
            try
            {
                tblFirmaBindingSource.EndEdit();
                tblFirmaTableAdapter.Update(bSSSDataset.tblFirma);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblFirmagrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
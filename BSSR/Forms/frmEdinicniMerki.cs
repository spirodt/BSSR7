using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmEdinicniMerki : frmBigShow
    {
        public frmEdinicniMerki()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblEdinecniMerkiTableAdapter.Fill(bSSSDataset.tblEdinecniMerki);
        }

        public frmEdinicniMerki(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblEdinecniMerkiTableAdapter.Fill(bSSSDataset.tblEdinecniMerki);
            AcceptButton = btnOk;
            tblEdinecniMerkiGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblEdinecniMerkiBindingSource.Find("Naziv", filter);
                tblEdinecniMerkiBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblEdinecniMerkigrdBase_DataInsert()
        {
            tblEdinecniMerkiTableAdapter.Fill(bSSSDataset.tblEdinecniMerki);
        }

        private void tblEdinecniMerkigrdBase_dataSaveAll()
        {
            try
            {
                tblEdinecniMerkiBindingSource.EndEdit();
                tblEdinecniMerkiTableAdapter.Update(bSSSDataset.tblEdinecniMerki);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblEdinecniMerkigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
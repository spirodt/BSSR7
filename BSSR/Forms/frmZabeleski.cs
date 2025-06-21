using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmZabeleski : frmBigShow
    {
        public frmZabeleski()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblZabeleshkiTableAdapter.Fill(bSSSDataset.tblZabeleshki);
        }

        public frmZabeleski(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblZabeleshkiTableAdapter.Fill(bSSSDataset.tblZabeleshki);
            AcceptButton = btnOk;
            tblZabeleshkiGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblZabeleshkiBindingSource.Find("Opis", filter);
                tblZabeleshkiBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblZabeleshkigrdBase_DataInsert()
        {
            tblZabeleshkiTableAdapter.Fill(bSSSDataset.tblZabeleshki);
        }

        private void tblZabeleshkigrdBase_dataSaveAll()
        {
            try
            {
                tblZabeleshkiBindingSource.EndEdit();
                tblZabeleshkiTableAdapter.Update(bSSSDataset.tblZabeleshki);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblZabeleshkigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
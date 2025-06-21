using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmValuti : frmBigShow
    {
        public frmValuti()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblValutiTableAdapter.Fill(bSSSDataset.tblValuti);
        }

        public frmValuti(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblValutiTableAdapter.Fill(bSSSDataset.tblValuti);
            AcceptButton = btnOk;
            tblValutiGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblValutiBindingSource.Find("Opis", filter);
                tblValutiBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblValutigrdBase_DataInsert()
        {
            tblValutiTableAdapter.Fill(bSSSDataset.tblValuti);
        }

        private void tblValutigrdBase_dataSaveAll()
        {
            try
            {
                tblValutiBindingSource.EndEdit();
                tblValutiTableAdapter.Update(bSSSDataset.tblValuti);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblValutigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
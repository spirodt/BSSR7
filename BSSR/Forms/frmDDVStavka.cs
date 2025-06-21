using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmDDVStavka : frmBigShow
    {
        public frmDDVStavka()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblDDVStavkaTableAdapter.Fill(bSSSDataset.tblDDVStavka);
        }

        public frmDDVStavka(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblDDVStavkaTableAdapter.Fill(bSSSDataset.tblDDVStavka);
            AcceptButton = btnOk;
            tblDDVStavkaGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblDDVStavkaBindingSource.Find("Naziv", filter);
                tblDDVStavkaBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblDDVStavkagrdBase_DataInsert()
        {
            tblDDVStavkaTableAdapter.Fill(bSSSDataset.tblDDVStavka);
        }

        private void tblDDVStavkagrdBase_dataSaveAll()
        {
            try
            {
                tblDDVStavkaBindingSource.EndEdit();
                tblDDVStavkaTableAdapter.Update(bSSSDataset.tblDDVStavka);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblDDVStavkagrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
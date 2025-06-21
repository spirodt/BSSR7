using System;
using System.Data.SqlClient;
using BssBase;

namespace MFakturi.Forms
{
    public partial class frmBanki : frmBigShow
    {
        public frmBanki()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblBankiTableAdapter.Fill(fakturiDataSet.tblBanki);
        }

        public frmBanki(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblBankiTableAdapter.Fill(fakturiDataSet.tblBanki);
            AcceptButton = btnOk;
            tblBankiGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblBankiBindingSource.Find("Naziv", filter);
                tblBankiBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblBankigrdBase_DataInsert()
        {
            tblBankiTableAdapter.Fill(fakturiDataSet.tblBanki);
        }

        private void tblBankigrdBase_dataSaveAll()
        {
            try
            {
                tblBankiBindingSource.EndEdit();
                tblBankiTableAdapter.Update(fakturiDataSet.tblBanki);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblBankigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmKorisnici : frmBigShow
    {
        public frmKorisnici()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblUsersTableAdapter.Fill(bSSSDataset.tblUsers);
            this.tblUsersBindingSource.Filter = "Status <> 1 OR Status is null";
        }

        public frmKorisnici(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblUsersTableAdapter.Fill(bSSSDataset.tblUsers);
            AcceptButton = btnOk;
            tblUsersGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblUsersBindingSource.Find("FullName", filter);
                tblUsersBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        public frmKorisnici(string filter, bool readOnly)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblUsersTableAdapter.Fill(bSSSDataset.tblUsers);
            AcceptButton = btnOk;
            tblUsersGridBig.Select();
            if (readOnly)
            {
                Meni.Enabled = false;
            }
            SrediIminjaNaGrid();
        }

        private void tblUsersgrdBase_DataInsert()
        {
            tblUsersTableAdapter.Fill(bSSSDataset.tblUsers);
        }

        private void tblUsersgrdBase_dataSaveAll()
        {
            try
            {
                tblUsersBindingSource.EndEdit();
                tblUsersTableAdapter.Update(bSSSDataset.tblUsers);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblUsersgrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
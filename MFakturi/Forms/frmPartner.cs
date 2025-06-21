using System;
using System.Data.SqlClient;
using BssBase;

namespace MFakturi.Forms
{
    public partial class frmPartner : frmBigShow
    {
        public frmPartner()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblPartneriTableAdapter.Fill(fakturiDataSet.tblPartneri);
        }


        public frmPartner(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblPartneriTableAdapter.Fill(fakturiDataSet.tblPartneri);
            AcceptButton = btnOk;
            tblPartneriGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblPartneriBindingSource.Find("Naziv", filter);
                tblPartneriBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblPartnerigrdBase_DataInsert()
        {
            tblPartneriTableAdapter.Fill(fakturiDataSet.tblPartneri);
        }

        private void tblPartnerigrdBase_dataSaveAll()
        {
            try
            {
                tblPartneriBindingSource.EndEdit();
                tblPartneriTableAdapter.Update(fakturiDataSet.tblPartneri);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblPartnerigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
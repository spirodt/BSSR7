using System;
using System.Data.SqlClient;
using BssBase;

namespace MFakturi.Forms
{
    public partial class frmZiroSmetki : frmBigShow
    {
        public frmZiroSmetki()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                viewZiroSmetkeTableAdapter.Fill(fakturiDataSet.viewZiroSmetke);
            btnBlokiraj.Visible = false;
        }

        public frmZiroSmetki(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            viewZiroSmetkeTableAdapter.Fill(fakturiDataSet.viewZiroSmetke);
            AcceptButton = btnOk;
            viewZiroSmetkeGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = viewZiroSmetkeBindingSource.Find("Partner", filter);
                viewZiroSmetkeBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
            btnBlokiraj.Visible = false;
        }

        private void viewZiroSmetkegrdBase_DataInsert()
        {
            viewZiroSmetkeTableAdapter.Fill(fakturiDataSet.viewZiroSmetke);
        }

        private void viewZiroSmetkegrdBase_dataSaveAll()
        {
            try
            {
                viewZiroSmetkeBindingSource.EndEdit();
                viewZiroSmetkeTableAdapter.Update(fakturiDataSet.viewZiroSmetke);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void viewZiroSmetkegrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
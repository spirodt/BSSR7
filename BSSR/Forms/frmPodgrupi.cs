using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmPodgrupi : frmBigShow
    {
        public frmPodgrupi()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
            {
                tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
                tblPodgrupaIDTableAdapter.Fill(bSSSDataset.tblPodgrupaID);
            }
        }

        public frmPodgrupi(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
            tblPodgrupaIDTableAdapter.Fill(bSSSDataset.tblPodgrupaID);
            AcceptButton = btnOk;
            tblPodgrupaIDGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblPodgrupaIDBindingSource.Find("Naziv", filter);
                tblPodgrupaIDBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblPodgrupaIDgrdBase_DataInsert()
        {
            tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
            tblPodgrupaIDTableAdapter.Fill(bSSSDataset.tblPodgrupaID);
        }

        private void tblPodgrupaIDgrdBase_dataSaveAll()
        {
            try
            {
                tblPodgrupaIDBindingSource.EndEdit();
                tblPodgrupaIDTableAdapter.Update(bSSSDataset.tblPodgrupaID);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblPodgrupaIDgrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }

      
    }
}
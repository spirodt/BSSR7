using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmGrupaArtikli : frmBigShow
    {
        public frmGrupaArtikli()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
        }

        public frmGrupaArtikli(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
            AcceptButton = btnOk;
            tblGrupaNaArtikliGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblGrupaNaArtikliBindingSource.Find("Naziv", filter);
                tblGrupaNaArtikliBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblGrupaNaArtikligrdBase_DataInsert()
        {
            tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
        }

        private void tblGrupaNaArtikligrdBase_dataSaveAll()
        {
            try
            {
                tblGrupaNaArtikliBindingSource.EndEdit();
                tblGrupaNaArtikliTableAdapter.Update(bSSSDataset.tblGrupaNaArtikli);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblGrupaNaArtikligrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
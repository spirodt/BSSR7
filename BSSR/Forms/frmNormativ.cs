using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmNormativ : frmBigShow
    {
        public frmNormativ()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblNormativTableAdapter.Fill(bSSSDataset.tblNormativ);
        }

        public frmNormativ(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblNormativTableAdapter.Fill(bSSSDataset.tblNormativ);
            AcceptButton = btnOk;
            tblNormativGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblNormativBindingSource.Find("Naziv", filter);
                tblNormativBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblNormativgrdBase_DataInsert()
        {
            tblNormativTableAdapter.Fill(bSSSDataset.tblNormativ);
        }

        private void tblNormativgrdBase_dataSaveAll()
        {
            try
            {
                tblNormativBindingSource.EndEdit();
                tblNormativTableAdapter.Update(bSSSDataset.tblNormativ);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblNormativgrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }

        private void frmNormativ_Load(object sender, EventArgs e)
        {
            tblDDVStavkaTableAdapter.Fill(bSSSDataset.tblDDVStavka);
            tblPodgrupaIDTableAdapter.Fill(bSSSDataset.tblPodgrupaID);
        }
    }
}
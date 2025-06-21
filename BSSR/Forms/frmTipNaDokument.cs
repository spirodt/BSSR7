using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmTipNaDokument : frmBigShow
    {
        public frmTipNaDokument()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblTipNaDokumentTableAdapter.Fill(bSSSDataset.tblTipNaDokument);
        }

        public frmTipNaDokument(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblTipNaDokumentTableAdapter.Fill(bSSSDataset.tblTipNaDokument);
            AcceptButton = btnOk;
            tblTipNaDokumentGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblTipNaDokumentBindingSource.Find("Naziv", filter);
                tblTipNaDokumentBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void tblTipNaDokumentgrdBase_DataInsert()
        {
            tblTipNaDokumentTableAdapter.Fill(bSSSDataset.tblTipNaDokument);
        }

        private void tblTipNaDokumentgrdBase_dataSaveAll()
        {
            try
            {
                tblTipNaDokumentBindingSource.EndEdit();
                tblTipNaDokumentTableAdapter.Update(bSSSDataset.tblTipNaDokument);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblTipNaDokumentgrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}
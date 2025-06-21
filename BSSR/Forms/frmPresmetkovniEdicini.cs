using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmPresmetkovniEdicini : frmBigShow
    {
        public frmPresmetkovniEdicini()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                tblPresmetkovniEdiniciTableAdapter.Fill(bSSSDataset.tblPresmetkovniEdinici);
        }

        public frmPresmetkovniEdicini(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            tblPresmetkovniEdiniciTableAdapter.Fill(bSSSDataset.tblPresmetkovniEdinici);
            AcceptButton = btnOk;
            tblPresmetkovniEdiniciGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblPresmetkovniEdiniciBindingSource.Find("Naziv", filter);
                tblPresmetkovniEdiniciBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        private void PresmetkovniEdicinigrdBase_DataInsert()
        {
            tblPresmetkovniEdiniciTableAdapter.Fill(bSSSDataset.tblPresmetkovniEdinici);
        }

        private void PresmetkovniEdicinigrdBase_dataSaveAll()
        {
            try
            {
                tblPresmetkovniEdiniciBindingSource.EndEdit();
                tblPresmetkovniEdiniciTableAdapter.Update(bSSSDataset.tblPresmetkovniEdinici);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void PresmetkovniEdicinigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}

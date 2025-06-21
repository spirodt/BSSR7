using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmPresmetkovniEdiciniEdit : frmBigEdit
    {
        public frmPresmetkovniEdiciniEdit()
            : base()
        {
            InitializeComponent();
        }

        // private int ID;

        public frmPresmetkovniEdiciniEdit(int selectedId)
            : base()
        {
            InitializeComponent();
            
            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblPresmetkovniEdiniciEdit_Load(object sender, EventArgs e)
        {
            tblPresmetkovniEdiniciTableAdapter.Fill(bSSSDataset.tblPresmetkovniEdinici);
            if (FormIsEdit)
            {
                tblPresmetkovniEdiniciBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblPresmetkovniEdiniciBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblPresmetkovniEdinici.Columns, bSSSDataset.tblPresmetkovniEdinici.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblPresmetkovniEdiniciBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblPresmetkovniEdiniciBindingSource.EndEdit();
                    tblPresmetkovniEdiniciTableAdapter.Update(bSSSDataset.tblPresmetkovniEdinici);
                    NeZatvoraj = false;
                    Close();
                }
                catch (Exception ex)
                {
                    if (ex is SqlException)
                    {
                        Tools.PrevediSQLException((SqlException)ex);
                    }
                    else
                    {
                        Tools.PrevediSQLException(ex);
                    }
                    NeZatvoraj = true;
                }
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace MFakturi.Forms
{
    public partial class frmBankiEdit : frmBigEdit
    {
        public frmBankiEdit()
            : base()
        {
            InitializeComponent();
        }

       // private int ID;

        public frmBankiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblBankiEdit_Load(object sender, EventArgs e)
        {
            tblBankiTableAdapter.Fill(fakturiDataSet.tblBanki);
            if (FormIsEdit)
            {
                tblBankiBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblBankiBindingNavigator.Visible = false;

            sredi_Dolzina(fakturiDataSet.tblBanki.Columns, fakturiDataSet.tblBanki.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    Validate();
                    ((DataRowView)tblBankiBindingSource.Current)["FirmaID"] = settings.firmaId;
                    tblBankiBindingSource.EndEdit();
                    tblBankiTableAdapter.Update(fakturiDataSet.tblBanki);
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
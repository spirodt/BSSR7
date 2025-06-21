using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmObjektiEdit : frmBigEdit
    {
        public frmObjektiEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmObjektiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblObjektiEdit_Load(object sender, EventArgs e)
        {
            tblObjektiTableAdapter.Fill(bSSSDataset.tblObjekti);
            if (FormIsEdit)
            {
                tblObjektiBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblObjektiBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblObjekti.Columns, bSSSDataset.tblObjekti.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblObjektiBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblObjektiBindingSource.EndEdit();
                    tblObjektiTableAdapter.Update(bSSSDataset.tblObjekti);
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
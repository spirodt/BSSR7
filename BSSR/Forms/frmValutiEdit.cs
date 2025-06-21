using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmValutiEdit : frmBigEdit
    {
        public frmValutiEdit()
            : base()
        {
            InitializeComponent();
        }

     //   private int ID;

        public frmValutiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblValutiEdit_Load(object sender, EventArgs e)
        {
            tblValutiTableAdapter.Fill(bSSSDataset.tblValuti);
            if (FormIsEdit)
            {
                tblValutiBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblValutiBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblValuti.Columns, bSSSDataset.tblValuti.TableName, settings.konekcija, false);
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
                    tblValutiBindingSource.EndEdit();
                    tblValutiTableAdapter.Update(bSSSDataset.tblValuti);
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
using System;
using System.Data.SqlClient;
using BssBase;
//BSSR.Forms.frmZabeleskiEdit
namespace BSSR.Forms
{
    public partial class frmZabeleskiEdit : frmBigEdit
    {
        public frmZabeleskiEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmZabeleskiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblZabeleshkiEdit_Load(object sender, EventArgs e)
        {
            tblZabeleshkiTableAdapter.Fill(bSSSDataset.tblZabeleshki);
            if (FormIsEdit)
            {
                tblZabeleshkiBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblZabeleshkiBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblZabeleshki.Columns, bSSSDataset.tblZabeleshki.TableName, settings.konekcija, false);
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
                    tblZabeleshkiBindingSource.EndEdit();
                    tblZabeleshkiTableAdapter.Update(bSSSDataset.tblZabeleshki);
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
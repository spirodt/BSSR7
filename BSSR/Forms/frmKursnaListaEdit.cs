using System;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmKursnaListaEdit : frmBigEdit
    {
        public frmKursnaListaEdit()
            : base()
        {
            InitializeComponent();
        }

       // private int ID;

        public frmKursnaListaEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblKursnaListaIDEdit_Load(object sender, EventArgs e)
        {
            tblValutiTableAdapter.Fill(bSSSDataset.tblValuti);
            tblKursnaListaTableAdapter.Fill(bSSSDataset.tblKursnaLista);
            if (FormIsEdit)
            {
                tblKursnaListaBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblKursnaListaBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblKursnaLista.Columns, bSSSDataset.tblKursnaLista.TableName, settings.konekcija, false);
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
                    tblKursnaListaBindingSource.EndEdit();
                    tblKursnaListaTableAdapter.Update(bSSSDataset.tblKursnaLista);
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
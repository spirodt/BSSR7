using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmDDVStavkaEdit : frmBigEdit
    {
        public frmDDVStavkaEdit()
            : base()
        {
            InitializeComponent();
        }

       // private int ID;

        public frmDDVStavkaEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblDDVStavkaEdit_Load(object sender, EventArgs e)
        {
            tblDDVStavkaTableAdapter.Fill(bSSSDataset.tblDDVStavka);
            if (FormIsEdit)
            {
                tblDDVStavkaBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblDDVStavkaBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblDDVStavka.Columns, bSSSDataset.tblDDVStavka.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblDDVStavkaBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblDDVStavkaBindingSource.EndEdit();
                    tblDDVStavkaTableAdapter.Update(bSSSDataset.tblDDVStavka);
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
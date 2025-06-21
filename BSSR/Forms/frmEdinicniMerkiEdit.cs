using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmEdinicniMerkiEdit : frmBigEdit
    {
        public frmEdinicniMerkiEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmEdinicniMerkiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblEdinecniMerkiEdit_Load(object sender, EventArgs e)
        {
            tblEdinecniMerkiTableAdapter.Fill(bSSSDataset.tblEdinecniMerki);
            if (FormIsEdit)
            {
                tblEdinecniMerkiBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblEdinecniMerkiBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblEdinecniMerki.Columns, bSSSDataset.tblEdinecniMerki.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblEdinecniMerkiBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblEdinecniMerkiBindingSource.EndEdit();
                    tblEdinecniMerkiTableAdapter.Update(bSSSDataset.tblEdinecniMerki);
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
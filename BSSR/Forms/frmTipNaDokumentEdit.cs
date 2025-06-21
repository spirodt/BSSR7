using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmTipNaDokumentEdit : frmBigEdit
    {
        public frmTipNaDokumentEdit()
            : base()
        {
            InitializeComponent();
        }

     //   private int ID;

        public frmTipNaDokumentEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmTipNaDokumentEdit_Load(object sender, EventArgs e)
        {
            tblTipNaDokumentTableAdapter.Fill(bSSSDataset.tblTipNaDokument);
            if (FormIsEdit)
            {
                tblTipNaDokumentBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblTipNaDokumentBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblTipNaDokument.Columns, bSSSDataset.tblTipNaDokument.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
            if (!FormIsEdit)
            {
                seKniziCheckBox.Checked = true;
                seKniziCheckBox.CheckState = CheckState.Checked;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblTipNaDokumentBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblTipNaDokumentBindingSource.EndEdit();
                    tblTipNaDokumentTableAdapter.Update(bSSSDataset.tblTipNaDokument);
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
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message);
                    NeZatvoraj = true;
                }
            }
        }
    }
}
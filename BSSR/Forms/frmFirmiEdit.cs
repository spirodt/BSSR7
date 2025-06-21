using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmFirmiEdit : frmBigEdit
    {
        public frmFirmiEdit()
            : base()
        {
            InitializeComponent();
        }

     //   private int ID;

        public frmFirmiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblFirmaEdit_Load(object sender, EventArgs e)
        {
            tblFirmaTableAdapter.Fill(bSSSDataset.tblFirma);
            if (FormIsEdit)
            {
                tblFirmaBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
                btnPrikaci1.Visible = true;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
                btnPrikaci1.Visible = false;
            }

            tblFirmaBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblFirma.Columns, bSSSDataset.tblFirma.TableName, settings.konekcija, false);
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
                    tblFirmaBindingSource.EndEdit();
                    tblFirmaTableAdapter.Update(bSSSDataset.tblFirma);
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

        private void btnPrikaci1_Click(object sender, EventArgs e)
        {
            frmUploadNaSlika upload = new frmUploadNaSlika();
            upload.Id = ((DataRowView)tblFirmaBindingSource.Current)["ID"].ToString();
            upload.PrimaryKey = "ID";
            upload.UpdateTable = "tblFirma";
            upload.ShowDialog();
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmKorisniciEdit : frmBigEdit
    {
        public frmKorisniciEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmKorisniciEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblUsersEdit_Load(object sender, EventArgs e)
        {
            tblUsersTableAdapter.Fill(bSSSDataset.tblUsers);
            cmbObjekt.LoadItems("select -1 as ID , '' as Vrednost UNION select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");

            if (FormIsEdit)
            {
                tblUsersBindingSource.Filter = String.Format(" {0}={1}", PrimaryKey, ID);
                passwordtxtBase.PasswordChar = '*';
                if(ID != BssBase.settings.UserId)
                {
                    passwordtxtBase.Enabled = false;
                }
                if (9 != BssBase.settings.UserLevel)
                {
                    cmbObjekt.Enabled = false;
                    nivoNaAdministracijaComboBox.Enabled = false;
                }
                if (((DataRowView)tblUsersBindingSource.Current)["NivoNaAdministracija"].ToString() == "9")
                {
                    nivoNaAdministracijaComboBox.SelectedIndex = 5;
                }
                else
                {
                    nivoNaAdministracijaComboBox.SelectedIndex = Tools.PrazenStringToInt(((DataRowView)tblUsersBindingSource.Current)["NivoNaAdministracija"].ToString());
                }
                if(cmbObjekt.SelectedValue != null)
                {
                    cmbObjekt.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblUsersBindingSource.Current)["tblObjektId"].ToString())); 
                }
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblUsersBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblUsers.Columns, bSSSDataset.tblUsers.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblUsersBindingSource.Current)["FirmaID"] = settings.firmaId;

                    if(cmbObjekt.SelectedValue != null) {
                        ((DataRowView)tblUsersBindingSource.Current)["tblObjektId"] = cmbObjekt.SelectedValue;
                    }
                    
                    if (nivoNaAdministracijaComboBox.SelectedIndex != -1)
                    {
                        if (nivoNaAdministracijaComboBox.SelectedIndex == 5)
                        {
                            ((DataRowView)tblUsersBindingSource.Current)["NivoNaAdministracija"] = 9;
                        }
                        else
                        {
                            ((DataRowView)tblUsersBindingSource.Current)["NivoNaAdministracija"] = nivoNaAdministracijaComboBox.SelectedIndex;
                        }
                    }
                    Validate();
                    tblUsersBindingSource.EndEdit();
                    tblUsersTableAdapter.Update(bSSSDataset.tblUsers);
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
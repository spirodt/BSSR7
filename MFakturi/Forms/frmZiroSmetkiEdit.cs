using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BssBase;

namespace MFakturi.Forms
{
    public partial class frmZiroSmetkiEdit : frmBigEdit
    {
        public frmZiroSmetkiEdit()
            : base()
        {
            InitializeComponent();
        }

       // private int ID;

        public frmZiroSmetkiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblZiroSmetkiEdit_Load(object sender, EventArgs e)
        {
            tblZiroSmetkiTableAdapter.Fill(fakturiDataSet.tblZiroSmetki);
            tblBankiTableAdapter.Fill(fakturiDataSet.tblBanki);
            if (FormIsEdit)
            {
                tblZiroSmetkiBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
                string partner = ((DataRowView)tblZiroSmetkiBindingSource.Current)["tblPartnerID"].ToString();
                if (!string.IsNullOrEmpty(partner))
                {
                    zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(Tools.PrazenStringToInt(partner))["Sifra"].ToString();
                    validatePartner();
                }
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblZiroSmetkiBindingNavigator.Visible = false;

            sredi_Dolzina(fakturiDataSet.tblZiroSmetki.Columns, fakturiDataSet.tblZiroSmetki.TableName, settings.konekcija, false);
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

                    ((DataRowView)tblZiroSmetkiBindingSource.Current)["FirmaID"] = settings.firmaId;

                    if (!string.IsNullOrEmpty(zbxPartner.ret1))
                        ((DataRowView)tblZiroSmetkiBindingSource.Current)["tblPartnerID"] = Tools.PrazenStringToInt(zbxPartner.ret1);
                    tblZiroSmetkiBindingSource.EndEdit();
                    tblZiroSmetkiTableAdapter.Update(fakturiDataSet.tblZiroSmetki);
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

        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
        }

        public bool validatePartner()
        {
            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);
            if (zbxPartner.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    zbxPartner.zoomClear();
                    txtPartner.Clear();
                    zbxPartner.ret1 = info["ID"].ToString();
                    zbxPartner.Value.Text = info["Sifra"].ToString();
                    zbxPartner.Text = info["Naziv"].ToString();
                    txtPartner.Text = info["Naziv"].ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("PartnerotNePostoi"));
                    zbxPartner.zoomClear();
                    txtPartner.Text = string.Empty;
                    return false;
                }
            }
            return false;
        }

        private void zbxPartner_Validated(object sender, EventArgs e)
        {
            validatePartner();
        }
    }
}
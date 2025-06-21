using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmPodgrupiEdit : frmBigEdit
    {
        public frmPodgrupiEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmPodgrupiEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblPodgrupaIDEdit_Load(object sender, EventArgs e)
        {
            tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
            tblPodgrupaIDTableAdapter.Fill(bSSSDataset.tblPodgrupaID);
            if (FormIsEdit)
            {
                tblPodgrupaIDBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblPodgrupaIDBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblPodgrupaID.Columns, bSSSDataset.tblPodgrupaID.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    if (Zafaktura.Checked)
                    {
                        ((DataRowView)tblPodgrupaIDBindingSource.Current)["Status"] = 4;
                    }
                    else
                    {
                        ((DataRowView)tblPodgrupaIDBindingSource.Current)["Status"] = DBNull.Value;
                    }

                    ((DataRowView)tblPodgrupaIDBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblPodgrupaIDBindingSource.EndEdit();
                    tblPodgrupaIDTableAdapter.Update(bSSSDataset.tblPodgrupaID);
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
            List<string> lista = new List<string>();
            lista.Add("Image");
            frmUploadNaSlika upload = new frmUploadNaSlika(lista, true);
            upload.Id = ((DataRowView)tblPodgrupaIDBindingSource.Current)["ID"].ToString();
            upload.PrimaryKey = "ID";
            upload.UpdateTable = "tblPodgrupaID";
            upload.ShowDialog();
            ((DataRowView)tblPodgrupaIDBindingSource.Current)["Image"] = upload.patekaDo;
            DialogResult = System.Windows.Forms.DialogResult.None;
        }
    }
}
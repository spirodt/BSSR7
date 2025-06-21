using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmGrupaArtikliEdit : frmBigEdit
    {
        public frmGrupaArtikliEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmGrupaArtikliEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblGrupaNaArtikliEdit_Load(object sender, EventArgs e)
        {
            tblGrupaNaArtikliTableAdapter.Fill(bSSSDataset.tblGrupaNaArtikli);
            if (FormIsEdit)
            {
                tblGrupaNaArtikliBindingSource.Filter = " " + PrimaryKey + " =" + ID;
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblGrupaNaArtikliBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblGrupaNaArtikli.Columns, bSSSDataset.tblGrupaNaArtikli.TableName, settings.konekcija, false);
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
                        ((DataRowView)tblGrupaNaArtikliBindingSource.Current)["Status"] = 4;
                    }
                    else
                    {
                        ((DataRowView)tblGrupaNaArtikliBindingSource.Current)["Status"] = DBNull.Value;
                    }

                    ((DataRowView)tblGrupaNaArtikliBindingSource.Current)["FirmaID"] = settings.firmaId;
                    Validate();
                    tblGrupaNaArtikliBindingSource.EndEdit();
                    tblGrupaNaArtikliTableAdapter.Update(bSSSDataset.tblGrupaNaArtikli);
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
            upload.Id = ((DataRowView)tblGrupaNaArtikliBindingSource.Current)["ID"].ToString();
            upload.PrimaryKey = "ID";
            upload.UpdateTable = "tblGrupaNaArtikli";
            upload.ShowDialog();
            ((DataRowView)tblGrupaNaArtikliBindingSource.Current)["Image"] = upload.patekaDo;
            DialogResult = System.Windows.Forms.DialogResult.None;
        }
    }
}
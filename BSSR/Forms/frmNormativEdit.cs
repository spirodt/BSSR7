using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmNormativEdit : frmBigEdit
    {
        public frmNormativEdit()
            : base()
        {
            InitializeComponent();
        }

      //  private int ID;

        public frmNormativEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        private void frmtblNormativEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bSSSDataset.tblNormativiSodriznaIznos' table. You can move, or remove it, as needed.
            tblDDVStavkaIDcmbBase.LoadItems("select ID,  Naziv  as Vrednost from tblDDVStavka");
            settings.NeSortirajKoloni = true;
            tblArtikalTableAdapter.Fill(bSSSDataset.tblArtikal);
            tblNormativStavkiTableAdapter.Fill(bSSSDataset.tblNormativStavki);
            tblPodgrupaIDTableAdapter.Fill(bSSSDataset.tblPodgrupaID);
            tblNormativTableAdapter.Fill(bSSSDataset.tblNormativ);

            if (FormIsEdit)
            {
                tblNormativBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
                tblNormativiSodriznaIznosTableAdapter.FillBy(bSSSDataset.tblNormativiSodriznaIznos, ID);
                tblDDVStavkaIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblNormativBindingSource.Current)["tblDDVStavkaID"].ToString()));
                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("select GrupaID from tblPodgrupaID Where ID = @ID", con))
                    {
                        try
                        {
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("@ID", Tools.PrazenStringToInt(((DataRowView)tblNormativBindingSource.Current)["PodgrupaID"].ToString()));

                            con.Open();
                            var rez = Tools.PrazenStringToInt(com.ExecuteScalar().ToString());
                            con.Close();
                            cmbGrupa.LoadItems("select -1 as ID , '' as Vrednost UNION SELECT ID, Sifra + ' - '+ Naziv as Vrednost from tblGrupaNaArtikli");
                            cmbGrupa.SelectirajItem(rez);
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            NeZatvoraj = true;
                            return;
                        }
                    }
                }
                podgrupaIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblNormativBindingSource.Current)["PodgrupaID"].ToString()));
            }
            else
            {
                cmbGrupa.LoadItems("select -1 as ID , '' as Vrednost UNION SELECT ID, Sifra + ' - '+ Naziv as Vrednost from tblGrupaNaArtikli");
                bindingNavigatorAddNewItem.PerformClick();
            }

            tblNormativBindingNavigator.Visible = false;
            grdBase1.AutoResizeColumns();
            sredi_Dolzina(bSSSDataset.tblNormativ.Columns, bSSSDataset.tblNormativ.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
        }

        private void Socuvaj()
        {
            ((DataRowView)tblNormativBindingSource.Current)["FirmaID"] = settings.firmaId;
            ((DataRowView)tblNormativBindingSource.Current)["tblDDVStavkaID"] = Tools.NullToDB(tblDDVStavkaIDcmbBase.SelectedValue);
            Validate();
            tblNormativBindingSource.EndEdit();
            tblNormativiSodriznaIznosBindingSource.EndEdit();
            tblNormativTableAdapter.Update(bSSSDataset.tblNormativ);
            NeZatvoraj = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    ((DataRowView)tblNormativBindingSource.Current)["tblDDVStavkaID"] = Tools.NullToDB(tblDDVStavkaIDcmbBase.SelectedValue);
                    Socuvaj();
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

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTab.SelectedTab == tabNormativStavka)
            {
                if (!FormIsEdit)
                {
                    Oznaci_Zadolzitelni();
                    if (validacija())
                    {
                        try
                        {
                            Socuvaj();
                            bindingNavigatorMoveLastItem.PerformClick();
                            ID = Tools.PrazenStringToInt(((DataRowView)tblNormativBindingSource.Current)["ID"].ToString());
                            tblNormativiSodriznaIznosTableAdapter.FillBy(bSSSDataset.tblNormativiSodriznaIznos, ID);
                            groupBoxBase1.Text = ID.ToString();
                            btnVnesi1.Focus();
                        }
                        catch (Exception ex)
                        {
                            MainTab.SelectedTab = tabVnes;
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
                    else
                    {
                        MainTab.SelectedTab = tabVnes;
                    }
                }
                else
                {
                    btnVnesi1.Focus();
                }
            }
        }

        private void btnVnesi1_Click(object sender, EventArgs e)
        {
            var normativ = new frmNormativEditStavka(ID);
            normativ.ShowDialog();
            tblArtikalTableAdapter.Fill(bSSSDataset.tblArtikal);
            tblNormativStavkiTableAdapter.Fill(bSSSDataset.tblNormativStavki);
            tblNormativiSodriznaIznosTableAdapter.FillBy(bSSSDataset.tblNormativiSodriznaIznos, ID);
            NeZatvoraj = true;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("delete from tblNormativStavki Where ID = @ID", con))
                    {
                        try
                        {
                            com.Parameters.Clear();
                            var idStavka = -1;
                            idStavka = Tools.PrazenStringToInt(((DataRowView)tblNormativiSodriznaIznosBindingSource.Current)["ID"].ToString());
                            if (idStavka != -1)
                            {
                                com.Parameters.AddWithValue("@ID", idStavka);
                                con.Open();
                                com.ExecuteNonQuery();
                                con.Close();
                            }
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
            tblNormativStavkiTableAdapter.Fill(bSSSDataset.tblNormativStavki);
            tblNormativiSodriznaIznosTableAdapter.FillBy(bSSSDataset.tblNormativiSodriznaIznos, ID);
            NeZatvoraj = true;
        }

        private void tabNormativStavka_Enter(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("select COUNT(*) broj from tblNalogStavki where tblNomativID = @NormativID", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@NormativID", ID);
                        con.Open();
                        var rez = Tools.PrazenStringToInt(com.ExecuteScalar().ToString());
                        if (rez > 0)
                        {
                            //btnIzbrisi.Enabled = false;
                        }
                        con.Close();
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
                        return;
                    }
                }
            }
        }

        private void cmbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrupa.SelectedItem != null)
            {
                if (cmbGrupa.SelectedIndex != 0)
                {
                    podgrupaIDcmbBase.LoadItems("select ID, Naziv as Vrednost from tblPodgrupaID Where GrupaID=" + cmbGrupa.SelectedValue.ToString());
                }
                else
                {
                    podgrupaIDcmbBase.LoadItems("select ID, Naziv as Vrednost from tblPodgrupaID ");
                }
            }
        }

        private void btnPrikaci1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Image");
            frmUploadNaSlika upload = new frmUploadNaSlika(lista, true);
            upload.Id = ((DataRowView)tblNormativBindingSource.Current)["ID"].ToString();
            upload.PrimaryKey = "ID";
            upload.UpdateTable = "tblNormativ";
            upload.ShowDialog();
            ((DataRowView)tblNormativBindingSource.Current)["Image"] = upload.patekaDo;
            DialogResult = DialogResult.None;
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void tblNormativiSodriznaIznosBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (grdBase1.RowCount > 0)
            {
                lblSum.Text = Tools.PrazenStringToDecimal(bSSSDataset.tblNormativiSodriznaIznos.Compute("SUM(Iznos)", "").ToString()).ToString();
            }
        }

        private void frmNormativEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (grdBase1.RowCount > 0 && MainTab.SelectedTab == tabNormativStavka)
                {
                    if (!Equals(tblNormativiSodriznaIznosBindingSource.Current, null))
                    {
                        string row = ((DataRowView)tblNormativiSodriznaIznosBindingSource.Current)["ID"].ToString();
                        if (!string.IsNullOrEmpty(row))
                        {
                            decimal value = Tools.PrazenStringToDecimal_dec(InputBox.Show("Внесете вредност за избраниот норматив", false, true).Text);
                            using (SqlConnection con = new SqlConnection(settings.konekcija))
                            {
                                using (SqlCommand com = new SqlCommand("update tblNormativStavki set Kolicina = @kolicina where ID = @ID", con))
                                {
                                    com.Parameters.Clear();
                                    com.Parameters.AddWithValue("ID", row);
                                    com.Parameters.AddWithValue("@kolicina", value);
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    con.Close();
                                    tblNormativiSodriznaIznosTableAdapter.FillBy(bSSSDataset.tblNormativiSodriznaIznos, ID);
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.F10 && FormIsEdit)
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да креирате копија од овој норматив ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand("KopirajNormativ", con))
                        {
                            try
                            {
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("@NormativID", ID);
                                con.Open();
                                com.CommandType = CommandType.StoredProcedure;
                                com.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Успешно копирано");
                                NeZatvoraj = false;
                                Close();
                            }
                            catch (SqlException ex)
                            {
                                Tools.PrevediSQLException(ex);
                            }
                        }
                    }
                }
            }
        }
    }
}
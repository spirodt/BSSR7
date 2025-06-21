using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using BssBase;
using static BSSR.BSSSDataset;

namespace BSSR.Forms
{
    public partial class frmArtikliEdit : frmBigEdit
    {
        public frmArtikliEdit()
            : base()
        {
            InitializeComponent();

            if (settings.UserLevel == 6 && settings.TipNaPrograma == "8")
            {
                SetFormReadOnly();
            }

            ChangeTimeout(tblArtikalTableAdapter, 1800);
        }

        private void ChangeTimeout(Component component, int timeout)
        {
            if (!component.GetType().Name.Contains("TableAdapter"))
            {
                return;
            }

            PropertyInfo adapterProp = component.GetType().GetProperty("CommandCollection", BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.Instance);
            if (adapterProp == null)
            {
                return;
            }

            SqlCommand[] command = adapterProp.GetValue(component, null) as SqlCommand[];

            if (command == null)
            {
                return;
            }

            command[0].CommandTimeout = timeout;
        }

       // private int ID;

        public frmArtikliEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
            if (settings.UserLevel == 6 && settings.TipNaPrograma == "8")
            {
                SetFormReadOnly();
            }
            if(settings.UserLevel == 0)
            {
                SetFormReadOnly();
            }
            ChangeTimeout(tblArtikalTableAdapter, 1800);
        }

        public void insertirajStavkiVoCombox()
        {
            cmbGrupa.LoadItems("select -1 as ID , '' as Vrednost UNION SELECT ID, Sifra + ' - '+ Naziv as Vrednost from tblGrupaNaArtikli");
            tblDDVStavkaIDcmbBase.LoadItems("select ID,  Naziv  as Vrednost from tblDDVStavka");
            tblEdinecniMerkiIDcmbBase.LoadItems("select ID, Naziv as Vrednost from tblEdinecniMerki");
            cmbProdaznaMerka.LoadItems("select ID, Naziv as Vrednost from tblEdinecniMerki");
            podgrupaIDcmbBase.LoadItems("select ID, Naziv as Vrednost from tblPodgrupaID");
        }

        public void loadirajInfoNaEdit()
        {
            if (!Equals(null, tblArtikalBindingSource.Current))
            {
                tblDDVStavkaIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblArtikalBindingSource.Current)["tblDDVStavkaID"].ToString()));
                tblEdinecniMerkiIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblArtikalBindingSource.Current)["tblEdinecniMerkiID"].ToString()));
                cmbProdaznaMerka.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblArtikalBindingSource.Current)["EDMIzlez"].ToString()));
                podgrupaIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblArtikalBindingSource.Current)["PodgrupaID"].ToString()));
                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("select GrupaID from tblPodgrupaID Where ID = @ID", con))
                    {
                        try
                        {
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("@ID", Tools.PrazenStringToInt(((DataRowView)tblArtikalBindingSource.Current)["PodgrupaID"].ToString()));

                            con.Open();
                            var rez = Tools.PrazenStringToInt(com.ExecuteScalar().ToString());
                            con.Close();
                            cmbGrupa.SelectirajItem(rez);
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            NeZatvoraj = true;
                        }
                    }
                }

                podgrupaIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(((DataRowView)tblArtikalBindingSource.Current)["PodgrupaID"].ToString()));
            }
        }

        private void frmtblArtikalEdit_Load(object sender, EventArgs e)
        {
            btnVnesi1.DialogResult = DialogResult.None;
            btnPonisti1.DialogResult = DialogResult.None;
            btnPotvrdi1.DialogResult = DialogResult.None;
            // TODO: This line of code loads data into the 'bSSSDataset.tblAkcijaNaArtikal' table. You can move, or remove it, as needed.
            
            if (settings.TipNaPrograma == "10" || settings.TipNaPrograma == "10M")
            {
                Zafaktura.Visible = false;
                chkNormativ.Visible = false;
                redenBroj.Visible = false;
                altNaziv2.Visible = false;
                groupVnes.Controls.OfType<Label>().Where(c => c.Name == "LblNazivALT2").First().Visible = false;
                groupVnes.Controls.OfType<Label>().Where(c => c.Name == "label8").First().Visible = false;
            }

            if (settings.TipNaPrograma == "987")
            {
                Zafaktura.Visible = false;
                chkNormativ.Visible = false;
                redenBroj.Visible = false;
                altNaziv2.Visible = false;
                barkod1.Visible = false;
                barkod2.Visible = false;
                groupVnes.Controls.OfType<Label>().Where(c => c.Name == "label6").First().Visible = false;
                groupVnes.Controls.OfType<Label>().Where(c => c.Name == "label7").First().Visible = false;
                groupVnes.Controls.OfType<Label>().Where(c => c.Name == "LblNazivALT2").First().Visible = false;
                groupVnes.Controls.OfType<Label>().Where(c => c.Name == "label8").First().Visible = false;
            }

            tblArtikalTableAdapter.Fill(bSSSDataset.tblArtikal);
            insertirajStavkiVoCombox();

            if (FormIsEdit)
            {
                tblArtikalBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
                loadirajInfoNaEdit();
                chkNormativ.Visible = false;
                Zafaktura.Visible = false;
                tblAkcijaNaArtikalTableAdapter.FillBy(bSSSDataset.tblAkcijaNaArtikal,ID);
            }
            else
            {
                MainTab.TabPages.Remove(tabAkcija);
                bindingNavigatorAddNewItem.PerformClick();
                btnPrikaci1.Visible = false;
                txtKolicina.Text = 1.ToString();
                txtMinKolicinaNaZaliha.Text = 1.ToString();
                redenBroj.Text = 999999.ToString();
                denoviZaGarancijaTextBox.Text = 365.ToString();
            }

            tblArtikalBindingNavigator.Visible = false;

            sredi_Dolzina(bSSSDataset.tblArtikal.Columns, bSSSDataset.tblArtikal.TableName, settings.konekcija, false);

            
            Oznaci_Zadolzitelni();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    if (chkNormativ.Checked)
                    {
                        ((DataRowView)tblArtikalBindingSource.Current)["Status"] = 3;
                    }

                    if (Zafaktura.Checked)
                    {
                        ((DataRowView)tblArtikalBindingSource.Current)["Status"] = 4;
                    }

                    ((DataRowView)tblArtikalBindingSource.Current)["FirmaID"] = settings.firmaId;
                    ((DataRowView)tblArtikalBindingSource.Current)["tblDDVStavkaID"] = Tools.NullToDB(tblDDVStavkaIDcmbBase.SelectedValue);
                    ((DataRowView)tblArtikalBindingSource.Current)["PodgrupaID"] = Tools.NullToDB(podgrupaIDcmbBase.SelectedValue);
                    ((DataRowView)tblArtikalBindingSource.Current)["tblEdinecniMerkiID"] = Tools.NullToDB(tblEdinecniMerkiIDcmbBase.SelectedValue);
                    ((DataRowView)tblArtikalBindingSource.Current)["EDMIzlez"] = Tools.NullToDB(cmbProdaznaMerka.SelectedValue);
                    //DataRow rowforSave = ( (DataRowView)tblArtikalBindingSource.Current).Row;
                    
                    //var dict = rowforSave.Table.Columns
                    //    .Cast<DataColumn>()
                    //    .ToDictionary(c => c.ColumnName, c => rowforSave[c]);

                    //SaveDataToServer(dict);

                    Validate();
                    tblArtikalBindingSource.EndEdit();
                    tblArtikalTableAdapter.Update(bSSSDataset.tblArtikal);
                    
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

        private void nazivtxtBase_Leave(object sender, EventArgs e)
        {
            if (!FormIsEdit)
            {
                altNazivtxtBase.Text = Tools.ConvertToLatinica(nazivtxtBase.Text);
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

        private void tblDDVStavkaIDcmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnPrikaci1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Image");
            frmUploadNaSlika upload = new frmUploadNaSlika(lista, true);
            upload.Id = ((DataRowView)tblArtikalBindingSource.Current)["ID"].ToString();
            upload.PrimaryKey = "ID";
            upload.UpdateTable = "tblArtikal";
            upload.ShowDialog();
            ((DataRowView)tblArtikalBindingSource.Current)["Image"] = upload.patekaDo;
            DialogResult = DialogResult.None;
        }

        private void frmArtikliEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10 && FormIsEdit)
            {
                DialogResult opc;
                opc = MessageBox.Show("Дали сте сигурни дека сакате да креирате копија од овој артикал ", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand("KopirajArtikal", con))
                        {
                            try
                            {
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("@ArtikalID", ID);
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

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Дали сте сигурни дека сакате да ја додаете оваа акција ", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand(@"INSERT INTO tblAkcijaNaArtikal (DatumPocetok ,DatumKraj,tblArtikalID,AkciskaCena,Rabat)
                            values( @DatumPocetok ,@DatumKraj,@tblArtikalID,@AkciskaCena,@Rabat)", con))
                    {
                        try
                        {


                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("@tblArtikalID", ID);
                            com.Parameters.AddWithValue("@DatumPocetok", dtPickerBase1.Value);
                            com.Parameters.AddWithValue("@DatumKraj", dtPickerBase2.Value);
                            com.Parameters.AddWithValue("@AkciskaCena", txtAkciskaCena.PrazenStringToDecimal_dec());
                            com.Parameters.AddWithValue("@Rabat",Tools.PrazenStringToDecimal_dec(txtRabat.Text));
                            con.Open();
                            com.ExecuteNonQuery();

                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                        }
                    }
                }
            }
            tblAkcijaNaArtikalTableAdapter.FillBy(bSSSDataset.tblAkcijaNaArtikal, ID);
            groupBoxBase2.Visible = false;
        }

        private void btnVnesi1_Click(object sender, EventArgs e)
        {
            
            groupBoxBase2.Visible = true;
        }

        private void btnPonisti1_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Дали сте сигурни дека сакате да ја избришете оваа акција ", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand("delete from tblAkcijaNaArtikal where tblArtikalID = @ArtikalID and ID=@ID", con))
                    {
                        try
                            
                        {
                            var IDBroj = ((DataRowView)tblAkcijaNaArtikalBindingSource.Current)["ID"];
                            if (!Equals(null, IDBroj))
                            {
                                int idAkcija = Tools.PrazenStringToInt(IDBroj.ToString());
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("@ArtikalID", ID);
                                com.Parameters.AddWithValue("@ID", idAkcija);
                                con.Open();
                                com.ExecuteNonQuery();
                                tblAkcijaNaArtikalTableAdapter.FillBy(bSSSDataset.tblAkcijaNaArtikal, ID);
                            }
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                        }
                    }
                }
            }
        }

  

        private void txtBase1_Leave(object sender, EventArgs e)
        {
            decimal rabat = ((100 * (prodaznaCenaTextBox.PrazenStringToDecimal_dec() - txtAkciskaCena.PrazenStringToDecimal_dec())) / prodaznaCenaTextBox.PrazenStringToDecimal_dec());
            txtRabat.Text = rabat.ToString("N2");

        }

        private void sifratxtBase_Leave(object sender, EventArgs e)
        {
            if(!FormIsEdit)
            {
                if(sifratxtBase.Text.Length > 5)
                {
                    barkod1.Text = sifratxtBase.Text;
                }
                sifratxtBase.Text = sifratxtBase.Text.PadLeft(15, '0');
                var artikal = Tools.NajdiInfoZaSifraArtikal(sifratxtBase.Text);
                if(artikal != null)
                {
                    MessageBox.Show("Artiklot postoi vo starata baza i e prefrlren vo novata pobarajte go so edit");
                }
            }
        }
    }
}
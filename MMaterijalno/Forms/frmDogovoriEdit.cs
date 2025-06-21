using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BssBase;
using DevExpress.Data.Helpers;

namespace MMaterijalno.Forms
{
    //MMaterijalno.Forms.frmDogovoriEdit
    public partial class frmDogovoriEdit : frmBigEdit
    {
        int tblPartnerID = -1;
        public frmDogovoriEdit()
           : base()
        {
            InitializeComponent();


        }
        public void validateZbxArtikal()
        {
            var info = Tools.NajdiInfoZaSifraArtikal_artikli(zbxBase1.Value.Text);
            if (zbxBase1.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    zbxBase1.zoomClear();
                    txtNaziv.Clear();
                    zbxBase1.ret1 = info["ID"].ToString();
                    zbxBase1.Value.Text = info["Sifra"].ToString();
                    txtNaziv.Text = info["Naziv"].ToString();
                    zbxBase1.ret5 = info["KolicinaT"].ToString();
                    txtKolicina.Focus();
                    txtKolicina.Select();
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("ArtiklotNePostoi"));
                    zbxBase1.zoomClear();
                    txtNaziv.Text = string.Empty;
                }
            }
        }

        public frmDogovoriEdit(int selectedId)
           : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;


        }

        private void tblDogovoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDogovoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materijalnoDataSet);

        }


        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
            validatePartner();
        }

        public bool validatePartner()
        {
            if(this.ID2 != 0)
            {
                zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(this.ID2)["Sifra"].ToString();
            }

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

        private void zbxBase1_DataRead()
        {
            zbxBase1.Value.Text = zbxBase1.ret2;
            validateZbxArtikal();
        }

        private void zbxBase1_Validated(object sender, EventArgs e)
        {
            validateZbxArtikal();
        }

        private void frmDogovoriEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materijalnoDataSet.tblDogovoriInfo' table. You can move, or remove it, as needed.
            


            this.tblDogovoriTableAdapter.Fill(this.materijalnoDataSet.tblDogovori);
           

            if (FormIsEdit)
            {
                tblDogovoriBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
                if (this.ID2 != 0)
                {
                    tblPartnerID = this.ID2;
                }
                else
                {
                    tblPartnerID = ((DataRowView)tblDogovoriBindingSource.Current)["tblPartnerId"].toInt();
                }

                if (tblPartnerID != 0 && tblPartnerID != -1)
                {
                    zbxPartner.Visible = false;
                    var partnerInfo = Tools.NajdiInfoZaIDPartner(tblPartnerID);
                    txtPartner.Text = partnerInfo["Naziv"].ToString();
                    zbxPartner.Value.Text = partnerInfo["Sifra"].ToString();
                }
               
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
                zbxPartner.Visible = true;
                if (tblPartnerID != -1 || this.ID2 != 0)
                {
                    ((DataRowView)tblDogovoriBindingSource.Current)["tblPartnerId"] = this.ID2;
                    validatePartner();
                }
            }

            this.tblDogovoriInfoTableAdapter.Fill(this.materijalnoDataSet.tblDogovoriInfo, ((DataRowView)tblDogovoriBindingSource.Current)["ID"].toInt());

            sredi_Dolzina(materijalnoDataSet.tblDogovori.Columns, materijalnoDataSet.tblDogovori.TableName, settings.konekcija, false);


            Oznaci_Zadolzitelni();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (Socuvaj())
            {
                NeZatvoraj = false;
                Close();
            }
        }

        private bool Socuvaj()
        {
            if (validacija() && validatePartner())
            {
                try
                {
                    Validate();
                    tblPartnerID = Tools.PrazenStringToInt(zbxPartner.ret1);
                    ((DataRowView)tblDogovoriBindingSource.Current)["tblPartnerId"] = tblPartnerID;
                    tblDogovoriBindingSource.EndEdit();
                    tblDogovoriTableAdapter.Update(this.materijalnoDataSet.tblDogovori);
                    return true;
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
            return false;
        }
        bool meniAdded = false;
        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Socuvaj())
            {

                if (!meniAdded)
                {
                    tblDogovoriInfoGridBig.ContextMenuStrip.Items.Add("Избриши", null, new EventHandler(Delete));
                    meniAdded = true;
                }
                presmetajKolicini();
            }
            else { 
                MainTab.SelectedIndex = 0;
            }
        }

        public void presmetajKolicini()
        {
            decimal sumKolicina = this.materijalnoDataSet.tblDogovoriInfo.Compute("SUM(Kolicina)", "").ToString().toDecimal();
            decimal sumDadenaKolcina = this.materijalnoDataSet.tblDogovoriInfo.Compute("SUM(DadenaKolicina)", "").ToString().toDecimal();
            decimal sumPreostanataKolicina = sumKolicina - sumDadenaKolcina;

            txtSumKolicina.Text = sumKolicina.ToString("N2");
            txtSumDadena.Text = sumDadenaKolcina.ToString("N2");
            txtPreostanata.Text = sumPreostanataKolicina.ToString("N2");
            if(sumPreostanataKolicina < 0)
            {
                txtPreostanata.BackColor = Color.Red;
            } else
            {
                txtPreostanata.BackColor = Color.Green;
            }


        }

        private void Delete(object sender, EventArgs e)
        {
           
            int selectedId = tblDogovoriInfoGridBig.CurrentRow.Cells["tblArtikalID"].Value.toInt();
            if (selectedId != 0)
            {
                try
                {
                   Tools.DeleteStavkaOdDogovor(selectedId);
                    this.tblDogovoriInfoTableAdapter.Fill(this.materijalnoDataSet.tblDogovoriInfo, ((DataRowView)tblDogovoriBindingSource.Current)["ID"].toInt());
                    presmetajKolicini();
                }
                catch (Exception ex)
                {
                    Tools.LogExceptionMessageWithScreenShoot(ex, "Brisenje na stavka vo dogovor");
                }
            }
        }

        private void btnVnesi1_Click(object sender, EventArgs e)
        {
            try
            {
                int dogovorID = ((DataRowView)tblDogovoriBindingSource.Current)["ID"].toInt();
                decimal kolicina = Tools.PrazenStringToDecimal_dec(txtKolicina.Text);
                decimal cena = Tools.PrazenStringToDecimal_dec(txtCena.Text);
                int artikalID = Tools.PrazenStringToInt(zbxBase1.ret1);
                if (artikalID != -1 && kolicina > 0 && cena > 0)
                {
                    Tools.InsertirajStavkiVoDogovor(dogovorID, artikalID, kolicina, cena);
                    this.tblDogovoriInfoTableAdapter.Fill(this.materijalnoDataSet.tblDogovoriInfo, dogovorID);
                }
                presmetajKolicini();
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex, "Vnes na artikli vo dogovor");
            }
        }
    }
}

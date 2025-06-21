using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BSS;
using BssBase;
using Excel = Microsoft.Office.Interop.Excel;
namespace MFakturi.Forms
{
    public partial class frmObrabotkaNaFaktura : frmBigEdit
    {
        private int BankaID = -1;
        private int FakturaID = -1;
        private String txtNaslovNaDokument = "Фактура број:";
        public override void SetFormReadOnly()
        {
            

            foreach (Control control in xtraTabPage1.Controls)
            {

                if (control is txtBase) { control.Enabled = false; }
                if (control is TextBox) { control.Enabled = false; }
                if (control is DataGrid) { control.Enabled = false; }
                if (control is ComboBox) { control.Enabled = false; }
                if (control is DateTimePicker) { control.Enabled = false; }
                if (control is BssBase.Elements.btnPotvrdi) { control.Enabled = false; }
                if (control is BssBase.Elements.btnPonisti) { control.Enabled = false; }
                if (control is zbxBase) { control.Enabled = false; }

            }

            foreach (Control control in xtraTabPage2.Controls)
            {

                if (control is txtBase) { control.Enabled = false; }
                if (control is TextBox) { control.Enabled = false; }
                if (control is DataGrid) { control.Enabled = false; }
                if (control is ComboBox) { control.Enabled = false; }
                if (control is DateTimePicker) { control.Enabled = false; }
                if (control is BssBase.Elements.btnPotvrdi) { control.Enabled = false; }
                if (control is BssBase.Elements.btnPonisti) { control.Enabled = false; }
                if (control is zbxBase) { control.Enabled = false; }

            }


            btnSocuvajStavka.Enabled = false;
            btnSocuvajZaglavje.Enabled = false;
            btnIzbrisiStavka.Enabled = false;
        }
        public frmObrabotkaNaFaktura(int _fakturaID)
        {
            InitializeComponent();
            FakturaID = _fakturaID;
            btnPecati.Enabled = true;
            FormIsEdit = true;
            tblFakturaTableAdapter.FillByID(fakturiDataSet.tblFaktura, FakturaID);
            string partner = ((DataRowView)tblFakturaBindingSource.Current)["tblPartnerID"].ToString();
            if (!string.IsNullOrEmpty(partner))
            {
                zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(Tools.PrazenStringToInt(partner))["Sifra"].ToString();
                validatePartner();
            }
            string ziro = ((DataRowView)tblFakturaBindingSource.Current)["tblZiroSmetkaID"].ToString();
            if (!string.IsNullOrEmpty(ziro))
                tblZiroSmetkaIDcmbBase.SelectirajItem(Tools.PrazenStringToInt(ziro));
            if (tblZiroSmetkaIDcmbBase.SelectedIndex != -1)
                BankaID = Tools.NajdiBankaZaZiroSmetkaID(Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString()));
            viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);
        }

        public bool odSmetka;
        public int SMetka;

        public frmObrabotkaNaFaktura(int SmetkaID, bool fromSmetka)
        {
            InitializeComponent();
            odSmetka = fromSmetka;
            SMetka = SmetkaID;
            brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblFaktura").ToString();
            datumDateTimePicker.Value = DateTime.Now;
            valutaDateTimePicker.Value = datumDateTimePicker.Value.AddDays(settings.brojNaDenoviZaValuta);
            xtraTabPage2.PageEnabled = false;
            btnSocuvajZaglavje.Enabled = false;
            btnPecati.Enabled = false;
        }

        private bool Profaktura = true;

        public frmObrabotkaNaFaktura(int SmetkaID, bool fromSmetka, int PartnerID, bool proFaktura)
        {
            InitializeComponent();
            odSmetka = fromSmetka;
            SMetka = SmetkaID;
            brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblFaktura").ToString();
            datumDateTimePicker.Value = DateTime.Now;
            valutaDateTimePicker.Value = datumDateTimePicker.Value.AddDays(settings.brojNaDenoviZaValuta);
            xtraTabPage2.PageEnabled = false;
            btnSocuvajZaglavje.Enabled = false;
            btnPecati.Enabled = false;
            butnProfaktura.Enabled = false;
            if (PartnerID != -1)
            {
                zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(PartnerID)["Sifra"].ToString();
                validatePartner();
            }
            if (proFaktura)
            {
                if(Profaktura == true)
                txtNaslovNaDokument = "Про-фактура број:";
            }
        }

        public frmObrabotkaNaFaktura()
        {
            InitializeComponent();
            brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblFaktura").ToString();
            datumDateTimePicker.Value = DateTime.Now;
            valutaDateTimePicker.Value = datumDateTimePicker.Value.AddDays(7);
        }

        private void frmObrabotkaNaFaktura_Load(object sender, EventArgs e)
        {
            zbxPartner.Value.MaxLength = 5;
            txtArtikalSearch.MaxLength = 13;
            btnOk.DialogResult = DialogResult.None;
            if (File.Exists("ZabelskaFaktura.txt"))
            {
                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(File.ReadAllLines("ZabelskaFaktura.txt", Encoding.ASCII));
                zabeleskaTextBox.Multiline = false;
                zabeleskaTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                zabeleskaTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                zabeleskaTextBox.AutoCompleteCustomSource = autoComplete;
            }
            if (settings.TipNaPrograma == "987")
            {
                //butnIspratnica.Visible = false;
                listaNaIspratniciTextBox.Visible = true;
                listaNaIspratniciLabel.Visible = true;
            }
        }

        private void zbxBase1_DataRead()
        {
            txtArtikalSearch.Text = txtArtikalSearch.ret4;
            ValidateArtikal();
        }

        public void ValidateArtikal()
        {
            var info = Tools.NajdiInfoZaSifraArtikal(txtArtikalSearch.Text);
            if (txtArtikalSearch.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    txtArtikalNaziv.Clear();
                    txtArtikalSearch.ret1 = info["ID"].ToString();
                    txtArtikalSearch.Text = info["Sifra"].ToString();
                    txtArtikalNaziv.Text = info["Naziv"].ToString();
                    txtDDV.Text = info["DDVStapka"].ToString();
                    txtEDM.Text = info["EDM"].ToString();
                    txtcena.Text = info["ProdaznaCena"].ToString();

                    txtSoDDV.Text = Math.Round(Tools.PoslednaCenaZaArtikalODPartner(Tools.PrazenStringToInt(info["ID"].ToString(), 0), Tools.PrazenStringToInt(zbxPartner.ret1)), 4).ToString("N2"); 
                    
                    txtArtikalSearch.ret4 = info["Normativ"].ToString();
                    kolicinatxtBase.Text = 1.ToString();
                    iznostxtBase.Text = Math.Round(Tools.PrazenStringToDecimal(txtcena.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text), 4).ToString("N2");
                    Presmetaj();
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("ArtiklotNePostoi"));

                    txtArtikalNaziv.Text = string.Empty;
                }
            }
        }

        private void zbxBase1_Validated(object sender, EventArgs e)
        {
            ValidateArtikal();
        }

        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
            validatePartner();
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
                    tblZiroSmetkaIDcmbBase.LoadItems("select ID, ZiroSmetka as Vrednost from tblZiroSmetki where tblPartnerID = " + zbxPartner.ret1);
                    tblZiroSmetkaIDcmbBase.Focus();

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

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (FakturaID == -1)
            {
                e.Cancel = true;
                MessageBox.Show(Tools.PrevediPoraka("Заглавјето не е правилно пополнето "), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        public bool Validacija_faktura()
        {
            if (string.IsNullOrEmpty(brojTextBox.Text) || brojTextBox.Text == "0")
            {
                return false;
            }
            if (String.IsNullOrEmpty(zbxPartner.ret1))
            {
                zbxPartner.Focus();
                return false;
            }

            return true;
        }

        public void UpdateZaglavje()
        {
            if (tblZiroSmetkaIDcmbBase.SelectedIndex != -1)
                BankaID = Tools.NajdiBankaZaZiroSmetkaID(Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString()));
            else
            {
                BankaID = -1;
            }
            int ziroSmetka = -1;
            if (!Equals(tblZiroSmetkaIDcmbBase.SelectedValue, null))
            {
                ziroSmetka = Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString());
            }

            Tools.UpdateFaktura(FakturaID, Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), ziroSmetka, BankaID, valutaDateTimePicker.Value, listaNaIspratniciTextBox.Text, zabeleskaTextBox.Text);
        }

        private void btnSocuvajZaglavje_Click(object sender, EventArgs e)
        {
            if (tblZiroSmetkaIDcmbBase.SelectedIndex != -1)
                BankaID = Tools.NajdiBankaZaZiroSmetkaID(Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString()));
            else
            {
                BankaID = -1;
            }
            int ziroSmetka = -1;
            if (!Equals(tblZiroSmetkaIDcmbBase.SelectedValue, null))
            {
                ziroSmetka = Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString());
            }

            if (Validacija_faktura())
            {
                if (FakturaID == -1 || FormIsEdit)
                {
                    if (!FormIsEdit)
                        FakturaID = Tools.KreirajFaktura(Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), ziroSmetka, BankaID, valutaDateTimePicker.Value, listaNaIspratniciTextBox.Text, zabeleskaTextBox.Text);
                    else
                    {
                        Tools.UpdateFaktura(FakturaID, Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), ziroSmetka, BankaID, valutaDateTimePicker.Value, listaNaIspratniciTextBox.Text, zabeleskaTextBox.Text);
                    }
                    if (FakturaID != -1)
                    {
                        btnPecati.Enabled = true;
                        xtraTabControl1.SelectedTabPage = xtraTabPage2;
                    }
                }
            }
            else
            {
                MessageBox.Show("Заглвјето не е правилно пополнето !!! ");
                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }
        }

        public bool validacijaStavka()
        {
            if (string.IsNullOrEmpty(txtArtikalSearch.ret1))
            {
                txtArtikalSearch.Focus();
                return false;
            }

            if (kolicinatxtBase.IsTextEmpty())
            {
                kolicinatxtBase.Focus();
                return false;
            }

            if (iznostxtBase.IsTextEmpty() || (iznostxtBase.PrazenStringToDecimal_dec() == Tools.PrazenStringToDecimal_dec("0")))
            {
                iznostxtBase.Focus();
                return false;
            }
            return true;
        }

        private void btnSocuvajStavka_Click(object sender, EventArgs e)
        {
            if (validacijaStavka())
            {
                bool normativ = false;
                if (string.IsNullOrEmpty(txtArtikalSearch.ret4))
                {
                    normativ = false;
                }
                else
                {
                    if (txtArtikalSearch.ret4.ToUpper().Contains("TRUE"))
                    {
                        normativ = true;
                    }
                }
                Tools.InsertirajStavkaVoFaktura(FakturaID, Tools.PrazenStringToInt(txtArtikalSearch.ret1), decimal.Parse(kolicinatxtBase.Text), decimal.Parse(iznostxtBase.Text), normativ, rabat1txtBase.PrazenStringToDecimal_dec(), 0, 0);
                viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);
                txtArtikalSearch.ret1 = string.Empty;
                txtArtikalSearch.Text = string.Empty;
                txtArtikalNaziv.Text = string.Empty;
                txtcena.Text = 0.ToString("N2");
                txtCenaBezDDV.Text = 0.ToString("N2");
                txtSoDDV.Text = 0.ToString("N2");
                txtCenaBezDDV.Text = 0.ToString("N2");
                kolicinatxtBase.Text = 1.ToString();
                rabat1txtBase.Text = 0.ToString("N2");
                txtBase1.Text = 0.ToString("N2");
                iznostxtBase.Text = 0.ToString("N2");
                txtArtikalSearch.Focus();
            }
        }

        public void Presmetaj()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtArtikalSearch.ret1)) { 
                decimal PreporacanaCena = Tools.PrazenStringToDecimal_dec(txtcena.Text);
                decimal CenaBezDDV = Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text);
                decimal CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
                decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
                decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text);
                decimal cenaSoRabat = 0;


                decimal KonecnaCena = 0;


                if (CenaBezDDV == 0 && CenaSoDDV == 0)
                    KonecnaCena = PreporacanaCena;
                else
                {
                    if (CenaSoDDV != 0)
                    {
                        KonecnaCena = CenaSoDDV;
                        txtCenaBezDDV.Text = Math.Round(CenaSoDDV / (1 + (DDVStapka / 100)), 4).ToString("N2");
                        CenaBezDDV = Math.Round(Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text), 4);
                            //txtCenaBezDDV.Text = Math.Round(CenaSoDDV / (1 + (DDVStapka / 100)), MidpointRounding.AwayFromZero).ToString("N2");
                            //CenaBezDDV = Math.Round(Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text), MidpointRounding.AwayFromZero);
                        }

                    if (CenaBezDDV != 0)
                    {
                        KonecnaCena = Math.Round(CenaBezDDV + ((CenaBezDDV / 100) * DDVStapka));
                            //KonecnaCena = Math.Round(CenaBezDDV + ((CenaBezDDV / 100) * DDVStapka), MidpointRounding.AwayFromZero);
                            txtSoDDV.Text = KonecnaCena.ToString("N2");
                        CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
                    }

                }

                if (rabat != 0)
                {
                    
                    cenaSoRabat = Math.Round( ( KonecnaCena - ((KonecnaCena / 100) * rabat)));
                    txtBase1.Text = (cenaSoRabat).ToString("N2");
                    rabat1txtBase.Text = rabat.ToString("N2");

                        //rabat = ((100 * (PreporacanaCena - KonecnaCena)) / PreporacanaCena);
                        //cenaSoRabat = CenaSoDDV;

                        txtBase1.Text = (cenaSoRabat).ToString("N2");
                    rabat1txtBase.Text = rabat.ToString("N2");
                }

                else 
                {
                    rabat = 0;
                    cenaSoRabat = KonecnaCena;
                    txtBase1.Text = (cenaSoRabat).ToString("N2");
                    rabat1txtBase.Text = rabat.ToString("N2");
                }

                iznostxtBase.Text = Math.Round(Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString("N2");

            }
            }
            catch (Exception )
            {
                MessageBox.Show("Настана проблем, артиклот е погрешно внесен или не е исправен","" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            
        }

        public void PresmetajSoDDV()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtArtikalSearch.ret1))
                {
                    decimal CenaBezDDV = Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text);
                    decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
                    decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text);
                    decimal PreporacanaCena = Tools.PrazenStringToDecimal_dec(txtcena.Text);
                    decimal KonecnaCena = 0;
                    decimal cenaSoRabat = 0;

                    KonecnaCena = Math.Round(CenaBezDDV + ((CenaBezDDV / 100) * DDVStapka), 4);
                    txtSoDDV.Text = KonecnaCena.ToString("N2");

                    if (rabat != 0)
                    {
                        cenaSoRabat = Math.Round((KonecnaCena - ((KonecnaCena / 100) * rabat)), 4);
                        txtBase1.Text = (cenaSoRabat).ToString("N2");
                        rabat1txtBase.Text = rabat.ToString("N2");
                    }

                    else
                    {
                        rabat = 0;
                        cenaSoRabat = KonecnaCena;
                        txtBase1.Text = (cenaSoRabat).ToString("N2");
                        rabat1txtBase.Text = rabat.ToString("N2");
                    }

                    iznostxtBase.Text = Math.Round(Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text), 4).ToString("N2");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Настана проблем, артиклот е погрешно внесен или не е исправен", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PresmetajBezDDV()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtArtikalSearch.ret1))
                {
                    decimal CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
                    decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
                    decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text);
                    decimal PreporacanaCena = Tools.PrazenStringToDecimal_dec(txtcena.Text);
                    decimal KonecnaCena = 0;
                    decimal cenaSoRabat = 0;

                    KonecnaCena = CenaSoDDV;
                    txtCenaBezDDV.Text = Math.Round(CenaSoDDV / (1 + (DDVStapka / 100)), 4).ToString("N2");
                    

                    if (rabat != 0)
                    {
                        cenaSoRabat = Math.Round((KonecnaCena - ((KonecnaCena / 100) * rabat)), 4);
                        txtBase1.Text = (cenaSoRabat).ToString("N2");
                        rabat1txtBase.Text = rabat.ToString("N2");
                    }

                    else
                    {
                        rabat = 0;
                        cenaSoRabat = KonecnaCena;
                        txtBase1.Text = (cenaSoRabat).ToString("N2");
                        rabat1txtBase.Text = rabat.ToString("N2");
                    }

                    iznostxtBase.Text = Math.Round(Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text), 4).ToString("N2");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Настана проблем, артиклот е погрешно внесен или не е исправен", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PresmetajRabat()
        {
            decimal cenaSoRabat = 0;
            decimal KonecnaCena = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
            decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text);
            cenaSoRabat = Math.Round((KonecnaCena - ((KonecnaCena / 100) * rabat)), 4);
            txtBase1.Text = (cenaSoRabat).ToString("N2");
            rabat1txtBase.Text = rabat.ToString("N2");

            iznostxtBase.Text = Math.Round(Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text), 4).ToString("N2");
        }


        private void kolicinatxtBase_Leave(object sender, EventArgs e)
        {
            //Presmetaj();
            iznostxtBase.Text = Math.Round(Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text), 4).ToString("N2");
            txtSoDDV.Focus();
            
        }

        private void btnIzbrisiStavka_Click(object sender, EventArgs e)
        {
            if (Equals(viewFakturiStavkiBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)viewFakturiStavkiBindingSource.Current)["ID"].ToString());
                Tools.IzbrisiStavkaOdFaktura(FakturaID, stavkaID);
                viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);
            }
        }

        public bool KreirajSmetka()
        {
            if (tblZiroSmetkaIDcmbBase.SelectedIndex != -1)
                BankaID = Tools.NajdiBankaZaZiroSmetkaID(Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString()));
            else
            {
                BankaID = -1;
            }
            int ziroSmetka = -1;
            if (!Equals(tblZiroSmetkaIDcmbBase.SelectedValue, null))
            {
                ziroSmetka = Tools.PrazenStringToInt(tblZiroSmetkaIDcmbBase.SelectedValue.ToString());
            }
            if (Validacija_faktura() && FakturaID == -1)
            {
                FakturaID = Tools.KreirajFaktura(Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), ziroSmetka, BankaID, valutaDateTimePicker.Value, listaNaIspratniciTextBox.Text, zabeleskaTextBox.Text);
                if (FakturaID != -1)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(settings.konekcija))
                        {
                            using (SqlCommand com = new SqlCommand("exec StavkiVoSmetka @ID", con))
                            {
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("ID", SMetka);
                                con.Open();
                                SqlDataReader reader = com.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        bool normativ = false;
                                        int tip = Tools.PrazenStringToInt(reader["Tip"].ToString());
                                        if (tip == 1)
                                        {
                                            normativ = true;
                                        }
                                        Tools.InsertirajStavkaVoFaktura(FakturaID, Tools.PrazenStringToInt(reader["Artikal"].ToString()), decimal.Parse(reader["Kolicina"].ToString()), decimal.Parse(reader["Iznos"].ToString()), normativ, Tools.PrazenStringToDecimal_dec(reader["Rabat"].ToString()));
                                    }
                                    reader.Close();
                                    
                                        com.Parameters.Clear();
                                        com.CommandText = "delete from tblNalog where SmetkaID = " + SMetka + "; Delete from tblSmetka where ID = " + SMetka;
                                    com.ExecuteNonQuery();  
                                    
                                }
                                con.Close();
                                return true;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пополнете ги сите полиња");
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (odSmetka)
            {
                btnOk.DialogResult = DialogResult.None;
                DialogResult opc;
                opc = MessageBox.Show("Дали сакате да ја завршите и отпечатите фактурата ? ", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    if (KreirajSmetka())
                    {
                        Pecati();
                        if (settings.ProkniziDokumenti == "1")
                        {
                            if (!Tools.DaliPostoiZapis("tblKnizenjeM", "tblFakturaID", FakturaID.ToString(),false))
                            {
                                opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniFakturataKjeBideProknizena"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (opc == DialogResult.Yes)
                                {
                                    Tools.ProkniziFaktura(FakturaID);
                                    //this.Close();
                                }
                            }
                        }

                        Close();
                    }
                }
            }
            else
            {
                Close();
            }
        }

        public bool Pecati()
        {
            if (string.IsNullOrEmpty(listaNaIspratniciTextBox.Text))
            {
                listaNaIspratniciTextBox.Text = brojTextBox.Text;
            }
            UpdateZaglavje();

            tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);
            tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri, Tools.PrazenStringToInt(zbxPartner.ret1));
            viewFakturiTableAdapter.FillBy(fakturiDataSet.viewFakturi, FakturaID);
            viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);

            try
            {

                if (settings.TipNaPrograma == "987")
                {
                  

                    using (var smetka = new Reporti.frmFaktura987())
                    {
                        smetka.SetDataSource(fakturiDataSet);
                        PrintPreview prev = new PrintPreview();
                        
                        smetka.SetParameterValue("Faktura", txtNaslovNaDokument);

                        
                        if (File.Exists("Napomena.txt"))
                        smetka.SetParameterValue("Napomena", File.ReadAllText("Napomena.txt", Encoding.ASCII));
                        else
                            smetka.SetParameterValue("Napomena", " ");

                        prev.ReportPreview.ReportSource = smetka;
                        prev.ShowDialog();
                        smetka.Dispose();
                        butnIspratnica.PerformClick();
                        return true;    
                    }
                    
                    
                }
                else
                    using (var smetka = new Reporti.frmFaktura())
                    {
                        smetka.SetDataSource(fakturiDataSet);
                        PrintPreview prev = new PrintPreview();
                        if (Tools.PrazenStringToDecimal_dec(fakturiDataSet.viewFakturiStavki.Compute("SUM(DDV)", "").ToString()) != 0)
                        {
                            if (File.Exists("Napomena.txt"))
                                smetka.SetParameterValue("napomena", File.ReadAllText("Napomena.txt", Encoding.ASCII));
                            else
                                smetka.SetParameterValue("napomena", " ");
                        }
                        else
                        {
                            if (File.Exists("NapomenaBezDDV.txt"))
                                smetka.SetParameterValue("napomena", File.ReadAllText("NapomenaBezDDV.txt", Encoding.ASCII));
                            else if (File.Exists("Napomena.txt"))
                            {
                                File.Copy("Napomena.txt","NapomenaBezDDV.txt");
                                smetka.SetParameterValue("napomena", File.ReadAllText("Napomena.txt", Encoding.ASCII));
                            }
                            else
                                smetka.SetParameterValue("napomena", " ");
                        }

                        smetka.SetParameterValue("Faktura", txtNaslovNaDokument);
                        smetka.SetParameterValue("user", tmpConfigs.LogiranUserFullName);
                       
                        prev.ReportPreview.ReportSource = smetka;
                        prev.ShowDialog();
                        smetka.Dispose();
                        return true;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return false;
            }
        }

        public void PecatiIspratnicaSoBarkodi()
        {
       

            try
            {
                using (var smetka = new Reporti.frmIspratnicaBarkod())
                {
                    smetka.SetDataSource(fakturiDataSet);
                    PrintPreview prev = new PrintPreview();
                    smetka.SetParameterValue("Faktura", txtNaslovNaDokument);
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();
                    smetka.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        public void PecatiIspratnica()
        {
            tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);
            tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri, Tools.PrazenStringToInt(zbxPartner.ret1));
            viewFakturiTableAdapter.FillBy(fakturiDataSet.viewFakturi, FakturaID);
            viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);

            try
            {
                using (var smetka = new Reporti.frmIspratnica())
                {
                    smetka.SetDataSource(fakturiDataSet);
                    PrintPreview prev = new PrintPreview();
                    smetka.SetParameterValue("Faktura", txtNaslovNaDokument);
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();
                    smetka.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            if (odSmetka)
            {
                btnOk.DialogResult = DialogResult.None;
                DialogResult opc;
                opc = MessageBox.Show("Дали сакате да ја завршите и отпечатите фактурата ? ", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    if (KreirajSmetka())
                    {
                        txtNaslovNaDokument = "Фактура број:";
                        if (Pecati())
                        {
                            if (settings.ProkniziDokumenti == "1")
                            {
                                if (!Tools.DaliPostoiZapis("tblKnizenjeM", "tblFakturaID", FakturaID.ToString(),false))
                                {
                                    opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniFakturataKjeBideProknizena"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (opc == DialogResult.Yes)
                                    {
                                        Tools.ProkniziFaktura(FakturaID);
                                        //this.Close();
                                    }
                                }
                            }
                        }

                        Close();
                    }
                }
            }
            else
            {
                txtNaslovNaDokument = "Фактура број:";
                
                    if (settings.ProkniziDokumenti == "1")
                    {
                        if (!Tools.DaliPostoiZapis("tblKnizenjeM", "tblFakturaID", FakturaID.ToString(),false))
                        {
                            DialogResult opc;
                            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniFakturataKjeBideProknizena"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (opc == DialogResult.Yes)
                            {
                                Tools.ProkniziFaktura(FakturaID);
                                //this.Close();
                            }
                        }
                    }
                    Pecati();
                
            }
        }

        private void txtArtikalSearch_Leave(object sender, EventArgs e)
        {
            ValidateArtikal();
        }

        private void txtArtikalSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateArtikal();
            }
            if (txtArtikalSearch.Text.Length < 1)
                if (e.KeyCode == Keys.Space)
                {
                    txtArtikalSearch.Text = string.Empty;
                    txtArtikalSearch.OpenEditSearch();
                    kolicinatxtBase.Select();
                    kolicinatxtBase.Focus();
                }
        }

        private void btnSearchArtikal_Click(object sender, EventArgs e)
        {
            txtArtikalSearch.OpenEditSearch();
        }

        private void txtArtikalSearch_DataRead()
        {
            txtArtikalSearch.Text = txtArtikalSearch.ret3;
            ValidateArtikal();
        }

        private void rabat1txtBase_Leave(object sender, EventArgs e)
        {
            //Presmetaj();
            PresmetajRabat();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!odSmetka)
                Profaktura = true;
            txtNaslovNaDokument = "Про-фактура број:";
            Pecati();
        }

        private void butnIspratnica_Click(object sender, EventArgs e)
        {
            if (settings.TipNaPrograma == "987")
            {
                if (!odSmetka)
                    Profaktura = true;
                txtNaslovNaDokument = "Испратница број:";
                listaNaIspratniciTextBox.Text = brojTextBox.Text;
                
                UpdateZaglavje();
                PecatiIspratnica();
            }
            else
            {
                if (listaNaIspratniciTextBox.Text.Trim().Length == 0)
                {
                    if (!odSmetka)
                        Profaktura = true;
                    txtNaslovNaDokument = "Испратница број:";
                    PecatiIspratnica();
                }
                else
                {
                    MessageBox.Show("Фактура е составена од повеќе испратници ");
                }
            }
        }

        private void viewFakturiStavkiBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (viewFakturiStavkiBindingSource.Count > 0 && listaNaIspratniciTextBox.IsTextEmpty())
            {
                listaNaIspratniciTextBox.Enabled = false;
            }
            else
            {
                listaNaIspratniciTextBox.Enabled = true;
            }
        }

        public bool GenerirajStavkiOdListaSoIspratnici(string listaSoIspratnici)
        {
            //za svaki broj u listata na ispratnici
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                try
                {
                    con.Open();

                    var table = Tools.StavkiOdListaNaDokumenti(listaSoIspratnici.Replace(";", ","));
                    if (table != null)
                    {
                        using (SqlCommand com = new SqlCommand("delete from tblFakturaStavki where tblFakturaID = @FakuraID", con))
                        {
                            com.Parameters.AddWithValue("@FakuraID", FakturaID);
                            com.ExecuteNonQuery();
                        }
                        
                        foreach (DataRow item in table.Rows)
                        {
                            bool normativ = false;
                            if (item["isNormativ"].ToString() == "1")
                            {
                                normativ = true;
                            }
                            Tools.InsertirajStavkaVoFaktura(FakturaID, Tools.PrazenStringToInt(item["ArtikalID"].ToString()), Tools.PrazenStringToDecimal_dec(item["Kolicina"].ToString()), Tools.PrazenStringToDecimal_dec(item["Iznos"].ToString()), normativ, Tools.PrazenStringToDecimal_dec(item["Rabat1"].ToString()));
                        }
                    }
                    con.Close();
                    return true;
                }
                catch (SqlException )
                {
                    return false;
                    
                }
            }
            
        }

        public void prikaziIspratnici()
        {
            btnSocuvajZaglavje.PerformClick();
            if (FakturaID != -1)
            {
                string listaBefore = listaNaIspratniciTextBox.Text.Trim();

                Dictionary<String, int> listaSoIspratnice = new Dictionary<string, int>();

                if (!string.IsNullOrEmpty(listaNaIspratniciTextBox.Text))
                {
                    foreach (string item in listaNaIspratniciTextBox.Text.Split(';'))
                    {
                        listaSoIspratnice.Add(item, 1);
                    }
                }

                DataTable db = new DataTable();
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand("select ID, Broj, TipNaDokument,NazivPartner, IznosSoDDV from viewDokumenti where TipDokumentID = 2 and tblPartnerID =" + zbxPartner.ret1, con))
                    {
                        con.Open();
                        db.Load(com.ExecuteReader());
                        con.Close();
                    }
                }

                BssBase.Elements.SelectBox box = new BssBase.Elements.SelectBox(db, listaSoIspratnice);
                DialogResult rez = box.ShowDialog();
                if (rez == DialogResult.OK && !string.IsNullOrEmpty(box.result))
                {
                    if (GenerirajStavkiOdListaSoIspratnici(box.result))
                    {
                        listaNaIspratniciTextBox.Text = box.result;
                        UpdateZaglavje();
                        viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);
                    }
                }
                box.Dispose();
            }
        }

        private void listaNaIspratniciTextBox_DoubleClick(object sender, EventArgs e)
        {
            prikaziIspratnici();
        }

        private void listaNaIspratniciTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                prikaziIspratnici();
            }
        }

        private void rabat1txtBase_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.R)
            //{
            //    var rbvalue = sender as txtBase;
            //    txtBase tIznos = iznostxtBase;

            //    decimal sumaZaNaplata = tools.PrazenStringToDecimal_dec(tIznos.Text);
            //    string iznos = string.Format(" Цена: {0:C}", sumaZaNaplata);

            //    InputBoxResult opc = BssBase.InputBox.ShowProcent(iznos, true, sumaZaNaplata, false, true, 15.25F, false);
            //    if (opc.ReturnCode == System.Windows.Forms.DialogResult.OK)
            //    {
            //        rbvalue.Text = opc.RabatOut.ToString();
            //    }
            //}

            //if (e.KeyCode == Keys.C)
            //{
            //    var rbvalue = sender as txtBase;
            //    txtBase tIznos = iznostxtBase;

            //    decimal sumaZaNaplata = tools.PrazenStringToDecimal_dec(txtcena.Text);
            //    string iznos = string.Format(" Цена: {0:C}", sumaZaNaplata);

            //    InputBoxResult opc = BssBase.InputBox.ShowProcentCena(iznos, true, sumaZaNaplata, false, true, 15.25F, false);
            //    if (opc.ReturnCode == System.Windows.Forms.DialogResult.OK)
            //    {
            //        rbvalue.Text = opc.RabatOut.ToString();
            //    }
            //}

        }

        private void txtSoDDV_Leave(object sender, EventArgs e)
        {
            if (txtSoDDV.PrazenStringToDecimal_dec() != 0 || txtCenaBezDDV.PrazenStringToDecimal_dec() != 0)
            {
                if (txtSoDDV.PrazenStringToDecimal_dec() != 0)
                    //Presmetaj();
                    PresmetajBezDDV();
                else
                    txtCenaBezDDV.Focus();
            }
            else
            {
                //Presmetaj();
                PresmetajBezDDV();
            }
        }

        private void txtCenaBezDDV_Leave(object sender, EventArgs e)
        {
            if (txtSoDDV.PrazenStringToDecimal_dec() != 0 || txtCenaBezDDV.PrazenStringToDecimal_dec() != 0)
            {
                if (txtCenaBezDDV.PrazenStringToDecimal_dec() != 0)
                    //Presmetaj();
                    PresmetajSoDDV();
                else
                    txtSoDDV.Focus();
            }
            else
            {
                PresmetajSoDDV();
                //Presmetaj();
            }
        }

        public static void WriteDataTable(DataTable sourceTable, TextWriter writer, bool includeHeaders)
        {
            if (includeHeaders)
            {
                IEnumerable<String> headerValues = sourceTable.Columns.OfType<DataColumn>()
                    .Select(column => QuoteValue(column.ColumnName));
                    

                writer.WriteLine(String.Join("  ", headerValues));
            }

            IEnumerable<String> items = null;

            foreach (DataRow row in sourceTable.Rows)
            {
                items = row.ItemArray.Select(o => QuoteValue(o.ToString()));
                writer.WriteLine(String.Join("  ", items));
            }

            writer.Flush();
        }

        private static string QuoteValue(string value)
        {
            return String.Concat("\"",
                value.Replace("\"", "\"\""), "\"");
        }


        public static void ExportToExcel(DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = (Excel._Worksheet) excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                    
                }

                Excel.Range rangeStyles = workSheet.get_Range("B:B");

                
                
                rangeStyles.Columns.AutoFit();
                rangeStyles.NumberFormat = "@";

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                        
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    

    private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);
                tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri,
                    Tools.PrazenStringToInt(zbxPartner.ret1));
                viewFakturiTableAdapter.FillBy(fakturiDataSet.viewFakturi, FakturaID);
                viewFakturiStavkiTableAdapter.FillBy(fakturiDataSet.viewFakturiStavki, FakturaID);

                if (fakturiDataSet.viewFakturiStavki.Rows.Count > 0)
                {
                    
                    DataTable db = new DataTable();
                    db.Columns.Add("Artikal                !", typeof(string));
                    db.Columns.Add("Barkod                 !", typeof(string));
                    db.Columns.Add("Cena                   !",typeof(decimal));

                    foreach (DataRow row in fakturiDataSet.viewFakturiStavki.Rows)
                    {
                        DataRow tRow = db.NewRow();
                        tRow[0] = row["Artikal"];
                        tRow[1] = row["Barkod"];
                        tRow[2] = row["ProdaznaCenaSoDDVIRabat"];

                        db.Rows.Add(tRow);
                    }
                    ExportToExcel(db);

                    DialogResult opc;
                    opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате да печатите "), string.Empty,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {

                        if (!odSmetka)
                            Profaktura = true;
                        txtNaslovNaDokument = "Испратница број:";
                        PecatiIspratnicaSoBarkodi();
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }

            //fakturiDataSet.tblFakturaStavki

         
        }

        private void txtSoDDV_Leave_1(object sender, EventArgs e)
        {
            //Presmetaj();
            PresmetajBezDDV();
        }
    }
}
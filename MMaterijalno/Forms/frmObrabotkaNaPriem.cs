using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BSS;
using BssBase;
using System.Data.SqlClient;

namespace MMaterijalno.Forms
{
    public partial class frmObrabotkaNaPriem : frmBigEdit
    {
        private int PriemID = -1;

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
            foreach (Control control in xtraTabPage3.Controls)
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
            btnPLT.Enabled = true;
        }

        public frmObrabotkaNaPriem(int _PriemID)
        {
            InitializeComponent();
            PriemID = _PriemID;
            btnPecati.Enabled = true;
            FormIsEdit = true;
            tblPriemTableAdapter.FillBy(materijalnoDataSet.tblPriem, PriemID);
            string partner = ((DataRowView)tblPriemBindingSource.Current)["tblPartnerID"].ToString();
            if (!string.IsNullOrEmpty(partner))
            {
                zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(Tools.PrazenStringToInt(partner))["Sifra"].ToString();
                validatePartner();
            }
            viewPriemStavkiTableAdapter.FillBy(materijalnoDataSet.viewPriemStavki, PriemID);
        }

        public frmObrabotkaNaPriem()
        {
            InitializeComponent();
            brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("PriemBroj", "tblPriem").ToString();
            datumDateTimePicker.Value = DateTime.Now;
        }

        private void frmObrabotkaNaFaktura_Load(object sender, EventArgs e)
        {
            gridView1.ActiveFilter.Clear();
            
            tblPriemStavkiTableAdapter.Fill(materijalnoDataSet.tblPriemStavki);
            viewPriemiTableAdapter.FillBy(materijalnoDataSet.viewPriemi, -1);
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);



            zbxPartner.Value.MaxLength = 20;
            txtArtikalSearch.MaxLength = 20;
            btnOk.DialogResult = DialogResult.None;
            cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");
            cmbObjekt.SelectirajItem(settings.MomentalenObjektID);

            if (settings.TipNaPrograma == "988Kasa") {
                rabat2txtBase.Visible = false;
                rabat2Label.Visible = false;
                rabat3txtBase.Visible = false;
                rabat3Label.Visible = false;
                txtcenaBezDDV.Visible = false;
                label1.Visible = false;
                txtcenaBezDDV.Enabled = false;
                txtCenaSoDDVVnes.Enabled = true;
            }
        }

        private void zbxBase1_DataRead()
        {
            txtArtikalSearch.Text = txtArtikalSearch.ret4;
            ValidateArtikal();
        }
        decimal prethodnanabavnacena, kolicinanazaliha, marza = 0;
        public void ValidateArtikal()
        {
            var info = Tools.NajdiInfoZaSifraArtikal(txtArtikalSearch.Text);
            if (txtArtikalSearch.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    string infozaartikal = string.Empty;
                    txtArtikalNaziv.Clear();
                    txtArtikalSearch.ret1 = info["ID"].ToString();
                    txtArtikalSearch.Text = info["Sifra"].ToString();
                    txtArtikalNaziv.Text = info["Naziv"].ToString();
                    txtDDV.Text = info["DDVStapka"].ToString();
                    txtEDM.Text = info["EDM"].ToString();
                    txtArtikalSearch.ret5 = info["ProdaznaCena"].ToString();
                    txtcenaBezDDV.Text = 0.ToString();
                    txtCenaSoDDV.Text = 0.ToString();
                    txtBase1.Text = 0.ToString();
                    rabat1txtBase.Text = 0.ToString();
                    rabat2txtBase.Text = 0.ToString();
                    rabat3txtBase.Text = 0.ToString();
                    txtArtikalSearch.ret4 = info["Normativ"].ToString();
                    kolicinatxtBase.Text = 1.ToString("N2");
                    
                    prethodnanabavnacena = Tools.NajdiPoslednaNabavnaCenaZaArtikalID(txtArtikalSearch.ret1);
                    kolicinanazaliha = Tools.NajdiZalihaZaArtikalID(txtArtikalSearch.ret1);
                    txtProdaznaCenaNaArtikal.Text = txtArtikalSearch.ret5;
                    marza = 0;
                    infozaartikal = string.Format(@"Претходна Набавна Цена: {0} Количина на залиха: {1} Маржа: {2} ", prethodnanabavnacena.ToString("N2"), kolicinanazaliha.ToString("N2"), marza.ToString("N2"));
                    lblInfo.Text = infozaartikal;
                    kolicinatxtBase.Select();
                    kolicinatxtBase.Focus();
                    //txtCenaSoDDV.Text = ( tools.PrazenStringToDecimal( txtCenaSoDDV.Text ) * tools.PrazenStringToDecimal( kolicinatxtBase.Text ) ).ToString();
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("ArtiklotNePostoi"));
                    txtArtikalNaziv.Text = string.Empty;
                    txtEDM.Text = string.Empty;
                    txtDDV.Text = string.Empty;
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
            if (PriemID == -1)
            {
                e.Cancel = true;
                MessageBox.Show(Tools.PrevediPoraka("Заглавјето не е правилно пополнето "), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public bool Validacija_Priem()
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

        private void btnSocuvajZaglavje_Click(object sender, EventArgs e)
        {
            if (Validacija_Priem())
            {
                if (PriemID == -1 || FormIsEdit)
                {
                    if (!FormIsEdit)
                        PriemID = Tools.KreirajPriem(Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), FalturaDatumDateTimePicker.Value, txtFRIBroj.Text, Tools.PrazenStringToInt(txtValuta.Text, 0), Tools.PrazenStringToInt(txtKalkulacijaBroj.Text, 0), txtZabeleska.Text, DatumNaDospeanost.Value, datumNaKreiranja.Value, Tools.PrazenStringToDecimal_dec(txtKontrolnaSuma.Text));
                    else
                    {
                        Tools.UpdatePriem(PriemID, Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), FalturaDatumDateTimePicker.Value, txtFRIBroj.Text, Tools.PrazenStringToInt(txtValuta.Text, 0), Tools.PrazenStringToInt(txtKalkulacijaBroj.Text, 0), txtZabeleska.Text, DatumNaDospeanost.Value, datumNaKreiranja.Value, Tools.PrazenStringToDecimal_dec(txtKontrolnaSuma.Text));
                    }
                    if (PriemID != -1)
                    {
                        btnPecati.Enabled = true;
                        xtraTabControl1.SelectedTabPage = xtraTabPage2;
                    }
                    else
                    {
                        btnPecati.Enabled = false;
                        xtraTabControl1.SelectedTabPage = xtraTabPage1;
                    }
                }
            }
            else
            {
                btnPecati.Enabled = false;
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

            return true;
        }

        private void btnSocuvajStavka_Click(object sender, EventArgs e)
        {
            if (validacijaStavka())
            {
                //bool normativ = false;
                //if (string.IsNullOrEmpty(txtArtikalSearch.ret4))
                //{
                //    normativ = false;
                //}
                //else
                //{
                //    if (txtArtikalSearch.ret4.ToUpper().Contains("TRUE"))
                //    {
                //        normativ = true;
                //    }
                //}

                Tools.InsertirajStavkaVoPriem(PriemID, Tools.PrazenStringToInt(txtArtikalSearch.ret1), decimal.Parse(kolicinatxtBase.Text), decimal.Parse(txtcenaBezDDV.Text), decimal.Parse(txtCenaSoDDV.Text), Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text), Tools.PrazenStringToDecimal_dec(rabat2txtBase.Text), Tools.PrazenStringToDecimal_dec(rabat3txtBase.Text));

                viewPriemStavkiTableAdapter.FillBy(materijalnoDataSet.viewPriemStavki, PriemID);
                txtArtikalSearch.Text = string.Empty;
                txtcenaBezDDV.Text = 0.ToString();
                txtCenaSoDDV.Text = 0.ToString();
                txtBase1.Text = 0.ToString();
                rabat1txtBase.Text = 0.ToString();
                rabat2txtBase.Text = 0.ToString();
                rabat3txtBase.Text = 0.ToString();

                txtArtikalSearch.ret1 = string.Empty;
                txtArtikalSearch.Focus();
                txtSum.Text = Math.Round(Tools.PrazenStringToDecimal_dec(materijalnoDataSet.viewPriemStavki.Compute("SUM(IznosSoDDV)", "").ToString()), 0).ToString("N2");

                txtArtikalNaziv.Text = string.Empty;
                txtEDM.Text = string.Empty;
                txtDDV.Text = string.Empty;
            }
        }

        private void kolicinatxtBase_Leave(object sender, EventArgs e)
        {
            if (txtcenaBezDDV.Visible == true)
            {
                txtcenaBezDDV.Enabled = true;
                txtCenaSoDDV.Enabled = false;
                txtcenaBezDDV.Select();
                txtcenaBezDDV.Focus();
            }
            else {
                txtCenaSoDDVVnes.Enabled = true;
                txtCenaSoDDVVnes.Text = prethodnanabavnacena.ToString("N2");
                txtCenaSoDDVVnes.Select();
                txtCenaSoDDVVnes.Focus();
            }
                
            
        }

        private void btnIzbrisiStavka_Click(object sender, EventArgs e)
        {
            if (Equals(viewPriemStavkiBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)viewPriemStavkiBindingSource.Current)["ID"].ToString());
                Tools.IzbrisiStavkaOdPriem(PriemID, stavkaID);
                viewPriemStavkiTableAdapter.FillBy(materijalnoDataSet.viewPriemStavki, PriemID);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Tools.PrazenStringToDecimal_dec(txtKontrolnaSuma.Text) != 0)
            {
                if (Tools.PrazenStringToDecimal_dec(txtKontrolnaSuma.Text) != Tools.PrazenStringToDecimal_dec(materijalnoDataSet.viewPriemStavki.Compute("SUM(IznosSoDDV)", "").ToString()))
                {
                    DialogResult opc;
                    opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        Tools.UpdatePriem(PriemID, Tools.PrazenStringToInt(brojTextBox.Text), datumDateTimePicker.Value, Tools.PrazenStringToInt(zbxPartner.ret1), FalturaDatumDateTimePicker.Value, txtFRIBroj.Text, Tools.PrazenStringToInt(txtValuta.Text, 0), Tools.PrazenStringToInt(txtKalkulacijaBroj.Text, 0), txtZabeleska.Text, DatumNaDospeanost.Value, datumNaKreiranja.Value, Tools.PrazenStringToDecimal_dec(txtKontrolnaSuma.Text));
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        public void Pecati()
        {
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            viewPriemiTableAdapter.FillBy(materijalnoDataSet.viewPriemi, PriemID);
            viewPriemStavkiTableAdapter.FillBy(materijalnoDataSet.viewPriemStavki, PriemID);

            try
            {
                using (var smetka = new Reporti.Priem())
                {
                    smetka.SetDataSource(materijalnoDataSet);
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();
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
            
            if (settings.ProkniziDokumenti == "1")
            {
                DialogResult opc;
                if (!Tools.DaliPostoiZapis("tblKnizenjeM", "tblPriemID", PriemID.ToString(),false))
                {
                    opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniPriemotKjeBideProknizen"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        Tools.ProkniziPriem(PriemID);
                        Close();
                    }
                }
                else
                {
                    btnPLT.Enabled = true;
                }
            }
            Pecati();
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
            txtArtikalSearch.OpenEditSearch("Normativ = 'false'");
            kolicinatxtBase.Focus();
        }

        private void txtArtikalSearch_DataRead()
        {
            txtArtikalSearch.Text = txtArtikalSearch.ret3;
            ValidateArtikal();
        }

        public void Presmetaj()
        {
            try
            {
                decimal cenaSoRabat = 0;
                //bez DDV
                if (txtcenaBezDDV.Enabled == true && txtCenaSoDDVVnes.Enabled == false)
                {
                    decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text) + Tools.PrazenStringToDecimal_dec(rabat2txtBase.Text) + Tools.PrazenStringToDecimal_dec(rabat3txtBase.Text);
                    cenaSoRabat = Tools.PrazenStringToDecimal_dec(txtcenaBezDDV.Text) - (Tools.PrazenStringToDecimal_dec(txtcenaBezDDV.Text) / 100 * rabat);
                    txtBase1.Text = (cenaSoRabat).ToString("N2");
                    txtCenaSoDDV.Text = ((Tools.PrazenStringToDecimal_dec(txtBase1.Text) / 100) * Tools.PrazenStringToDecimal_dec(txtDDV.Text) + cenaSoRabat).ToString("N2");
                }
                //SO DDV
                if (txtcenaBezDDV.Enabled == false && txtCenaSoDDVVnes.Enabled == true)
                {
                    decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text) + Tools.PrazenStringToDecimal_dec(rabat2txtBase.Text) + Tools.PrazenStringToDecimal_dec(rabat3txtBase.Text);
                    cenaSoRabat = Tools.PrazenStringToDecimal_dec(txtCenaSoDDVVnes.Text) - (Tools.PrazenStringToDecimal_dec(txtCenaSoDDVVnes.Text) / 100 * rabat);
                    txtBase1.Text = (cenaSoRabat).ToString("N2");

                    txtCenaSoDDV.Text = txtBase1.Text;

                    txtcenaBezDDV.Text = (txtCenaSoDDVVnes.PrazenStringToDecimal_dec() / (1 + Tools.PrazenStringToDecimal_dec(txtDDV.Text) / 100)).ToString("N2");
                }

                marza = ((Tools.PrazenStringToDecimal_dec(txtArtikalSearch.ret5) - cenaSoRabat) / cenaSoRabat) * 100;
                lblInfo.Text = string.Format(@"Претходна Набавна Цена: {0} Количина на залиха: {1} Маржа: {2} ", prethodnanabavnacena.ToString("N2"), kolicinanazaliha.ToString("N2"), marza.ToString("N2"));

            }catch (Exception)
            {

            }

        }

        private void txtcenaBezDDV_Leave(object sender, EventArgs e)
        {
            if (txtcenaBezDDV.PrazenStringToDecimal_dec() != 0)
            {
                rabat1txtBase.Focus();

                txtCenaSoDDVVnes.Enabled = false;
                txtcenaBezDDV.Enabled = true;
                txtCenaSoDDVVnes.Text = 0.ToString("N2");

                Presmetaj();
                txtCenaSoDDVVnes.Text = txtCenaSoDDV.Text;
            }
            else
            {
                txtCenaSoDDVVnes.Enabled = true;
                txtcenaBezDDV.Enabled = false;

                //txtCenaSoDDVVnes.Text = 0.ToString("N2");

                txtCenaSoDDVVnes.Focus();
            }
        }

        private void rabat1txtBase_Leave(object sender, EventArgs e)
        {
            Presmetaj();
            btnSocuvajStavka.Focus();
        }

        private void rabat2txtBase_Leave(object sender, EventArgs e)
        {
            Presmetaj();
        }

        private void rabat3txtBase_Leave(object sender, EventArgs e)
        {
            Presmetaj();
        }

        private void tblPriemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
        }

        private void tblPriemStavkiBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            txtSum.Text = Math.Round(Tools.PrazenStringToDecimal_dec(materijalnoDataSet.viewPriemStavki.Compute("SUM(IznosSoDDV)", "").ToString()), 0).ToString("N2");
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.TabIndex == 2)
            {
                txtArtikalSearch.Select();
                txtArtikalSearch.Focus();

            }
        }

        private void txtProdaznaCenaNaArtikal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProdaznaCenaNaArtikal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var amount = 0;
                
                var rez = InputBox.Show("Внесете продажна цена за одбраниот артикал", false, true);
                amount = Tools.PrazenStringToInt(rez.Text);
                

                if (!string.IsNullOrEmpty(rez.Text))
                {
                    if(rez.ReturnCode == DialogResult.OK)
                    {
                        using (SqlConnection con = new SqlConnection(settings.konekcija))
                        {
                            using (SqlCommand com = new SqlCommand("UPDATE  dbo.tblArtikal SET ProdaznaCena = @ProdaznaCena  WHERE ID = @ID", con))
                            {
                                con.Open();
                                com.Parameters.AddWithValue("@ProdaznaCena", rez.Text);
                                com.Parameters.AddWithValue("@ID", txtArtikalSearch.ret1);
                                com.ExecuteScalar();
                                txtArtikalSearch.Select();
                                txtArtikalSearch.Focus();
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Tools.PrevediPoraka("Настана грешка , сумата не одговара или има проблем со фискалната"));
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void txtCenaSoDDVVnes_Leave(object sender, EventArgs e)
        {
            if (txtCenaSoDDVVnes.PrazenStringToDecimal_dec() != 0)
            {
                Presmetaj();
                rabat1txtBase.Focus();
                txtCenaSoDDV.Enabled = false;

                txtcenaBezDDV.Enabled = false;
                txtCenaSoDDVVnes.Enabled = true;
            }
            else
            {
                txtCenaSoDDVVnes.Enabled = false;
                txtcenaBezDDV.Enabled = true;
                txtcenaBezDDV.Text = 0.ToString("N2");
                txtcenaBezDDV.Select();
                txtcenaBezDDV.Focus();
            }
        }

        private void btnPLT_Click(object sender, EventArgs e)
        {
            pLTobrazecTableAdapter.FillByPriemID(materijalnoDataSet.PLTobrazec, PriemID);
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            
            
            try
            {
                using (var smetka = new Reporti.PLTZaPriem())
                {
                    smetka.SetDataSource(materijalnoDataSet);
                    smetka.SetParameterValue("Partner", txtPartner.Text);
                    smetka.SetParameterValue("DDVSUMA5PRINABAVKA", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([DDV pri nabavka])","[Stapka na DDV propis] = 5").ToString()).ToString("N2"));
                    smetka.SetParameterValue("DDVSUMA18PRINABAVKA", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([DDV pri nabavka])","[Stapka na DDV propis] = 18").ToString()).ToString("N2"));
                    smetka.SetParameterValue("DDVSUMA5PVkupnoDDVProdazna", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([VkupnoDDV prodazna vrednost])","[Stapka na DDV propis] = 5").ToString()).ToString("N2"));
                    smetka.SetParameterValue("DDVSUMA18VkupnoDDVProdazna", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([VkupnoDDV prodazna vrednost])","[Stapka na DDV propis] = 18").ToString()).ToString("N2"));
                    
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BSS;
using BssBase;

using DevExpress.DocumentServices.ServiceModel.DataContracts;

using MMaterijalno.MaterijalnoDataSetTableAdapters;
using static Tools;

namespace MMaterijalno.Forms
{
    public partial class frmObrabotkaNaInterniDokumenti : frmBigEdit
    {
        private int dokumentID = -1;
        private bool odSmetka = false;
        private int SMetka;
        
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
            btnPLT.Enabled = true;
            //btnDogovori.Enabled = false;
        }

        public void PratiDokument()
        {
            string ServerName = cmbDoObjekt.Text;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniDekaSakateDaGoIspratiteDokumentot"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                if (cmbDoObjekt.SelectedIndex == -1) return;



                if (!Equals(null, viewDokumentiBindingSource.Current))
                {

                    int TipNaDokument = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString());
                    string TipNaDokumentStr = ((DataRowView)viewDokumentiBindingSource.Current)["TipNaDokument"].ToString();
                    int id = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["ID"].ToString());
                    string Broj = ((DataRowView)viewDokumentiBindingSource.Current)["Broj"].ToString();

                    tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
                    viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, id);
                    string brojNaPriem = ((DataRowView)viewDokumentiBindingSource.Current)["ID"].ToString();
                    int knizeno = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["Knizeno"].ToString());

                    if (!(materijalnoDataSet.viewDokumenti.Select("ID = " + id.ToString()).Count() > 0))
                    {
                        MessageBox.Show("Документот е празен !!!");
                        return;
                    }

                    if (!(materijalnoDataSet.viewDokumentiStavki.Select("tblDokumentID = " + id.ToString()).Count() > 0))
                    {
                        MessageBox.Show("Документот е празен !!!");
                        return;
                    }


                    if (knizeno == 1)
                    {
                        MessageBox.Show("Документот е веќе книжен !!!");
                        return;
                    }

                    if (TipNaDokument != 3)
                    {
                        MessageBox.Show("Овој тип на документ не се испраќа електронски ");
                        return;
                    }


                    DataSet ds = new DataSet("DokumentiDataset");
                    ds.Tables.Add(materijalnoDataSet.viewDokumenti.Select("ID = " + id.ToString()).CopyToDataTable());
                    ds.Tables[0].TableName = "viewDokumenti";


                    ds.Tables.Add(materijalnoDataSet.viewDokumentiStavki.Select("tblDokumentID = " + id.ToString()).CopyToDataTable());
                    ds.Tables[1].TableName = "viewDokumentiStavki";
                    ds.Relations.Add(new DataRelation("viewDokumenti_viewDokumentiStavki", ds.Tables["viewDokumenti"].Columns["ID"], ds.Tables["viewDokumentiStavki"].Columns["tblDokumentID"]));
                    ds.AcceptChanges();
                    string fileName = @"ElektronskoPracanje\Prateni\" + TipNaDokumentStr + "_" + id.ToString() + " Broj_" + Broj + ".xml";
                    if (File.Exists(fileName))
                        File.Delete(fileName);
                    ds.WriteXml(fileName, XmlWriteMode.WriteSchema);

                    string xml = File.ReadAllText(fileName);
                    Functions.SrvFcuntions s = new Functions.SrvFcuntions();
                    if (s.PratiKomanda(ServerName, 8100, "docPresnocnica:" + xml, fileName, DateTime.Now))
                    {
                        using (SqlConnection con = new SqlConnection(settings.konekcija))
                        {
                            string sql = "AkcijaVrzDokument";
                            using (SqlCommand com = new SqlCommand(sql, con))
                            {
                                con.Open();
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("@DokumentID", id);
                                com.Parameters.AddWithValue("@PratenOD", settings.ImeNaMojServer);
                                com.Parameters.AddWithValue("@PratenDO", ServerName);
                                com.Parameters.AddWithValue("@PratenPrimen", 1);
                                com.Parameters.AddWithValue("@TipNaDokumentStr", TipNaDokumentStr);
                                com.Parameters.AddWithValue("@TipNaVnes", 1);
                                com.Parameters.AddWithValue("@DokumentValue", xml);

                                com.CommandType = CommandType.StoredProcedure;
                                com.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        string OldFileName = fileName;
                        fileName = fileName.Replace(@"\Prateni\", @"\Neuspesni\" + @"\" + ServerName + @"\");
                        FileInfo f = new FileInfo(fileName);
                        if (!f.Directory.Exists)
                        {
                            f.Directory.Create();
                        }

                        if (File.Exists(fileName))
                            File.Delete(fileName);

                        File.Copy(OldFileName, fileName);
                        MessageBox.Show("Документот не е испратен, сочуван за праќање кога конекцијата ќе биде возможна ");
                    }



                }
            }
        }

        public frmObrabotkaNaInterniDokumenti(int SmetkaID, bool fromSmetka)
        {
            InitializeComponent();

            odSmetka = fromSmetka;
            SMetka = SmetkaID;
            datumDateTimePicker.Value = DateTime.Now;
            var dateValuta = DateTime.Now.AddMonths(1);
            dtValuta.Value = new DateTime(DateTime.Now.Year, dateValuta.Month, 1).AddDays(-1);
            dtPeriod.Value = DateTime.Now;
            xtraTabPage2.PageEnabled = false;
            btnSocuvajZaglavje.Enabled = false;
            btnPecati.Enabled = false;
            cmbTipNaDokument.LoadItems("select ID, Naziv + ' - ' + CAST(Interen as nvarchar(4)) as Vrednost from tblTipNaDokument");
            cmbOdObjekt.LoadItems("select ID, Naziv as Vrednost from tblObjekti");
            cmbDoObjekt.LoadItems("select ID, Naziv as Vrednost from tblObjekti");

            

            if (cmbTipNaDokument.Items.Count > 0)
            {
                if (cmbTipNaDokument.SelectedIndex != -1)
                {
                    cmbDoObjekt.Enabled = cmbTipNaDokument.Text.Contains(" - 0");
                    zbxPartner.Enabled = cmbTipNaDokument.Text.ToString().Contains(" - 1");
                    brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + cmbTipNaDokument.SelectedValue).ToString();
                }
            }
        }

        public frmObrabotkaNaInterniDokumenti(int _dokumentID)
        {
            InitializeComponent();

            cmbTipNaDokument.LoadItems("select ID, Naziv + ' - ' + CAST(Interen as nvarchar(4)) as Vrednost from tblTipNaDokument");
            
            if (cmbTipNaDokument.Items.Count > 0)
            {
                if (cmbTipNaDokument.SelectedIndex != -1)
                {
                    cmbDoObjekt.Enabled = cmbTipNaDokument.Text.Contains(" - 0");
                    zbxPartner.Enabled = cmbTipNaDokument.Text.ToString().Contains(" - 1");
                    brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + cmbTipNaDokument.SelectedValue).ToString();
                }
            }

            cmbOdObjekt.LoadItems("select ID, Naziv as Vrednost from tblObjekti");
            cmbDoObjekt.LoadItems("select ID, Naziv as Vrednost from tblObjekti");

            dokumentID = _dokumentID;
            btnPecati.Enabled = true;
            FormIsEdit = true;
            var DokumentInfo = Tools.NajdiInfoZaDokument(dokumentID);
            if (!Equals(DokumentInfo, null))
            {
                cmbTipNaDokument.SelectirajItem(Tools.PrazenStringToInt(DokumentInfo["TipNaDokument"].ToString()));
                cmbOdObjekt.SelectirajItem(Tools.PrazenStringToInt(DokumentInfo["OdObjektID"].ToString()));
                cmbDoObjekt.SelectirajItem(Tools.PrazenStringToInt(DokumentInfo["DoObjektID"].ToString()));
                zabeleskatxtBase.Text = DokumentInfo["Zabeleska"].ToString();
                brojTextBox.Text = DokumentInfo["Broj"].ToString();
                txtBrojNaDokumentFra.Text = DokumentInfo["BrojNaDokument"].ToString();
                string partner = DokumentInfo["tblPartnerID"].ToString();
                if (!string.IsNullOrEmpty(partner))
                {
                    zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(Tools.PrazenStringToInt(partner))["Sifra"].ToString();
                    validatePartner();
                }
                var datum = DokumentInfo["Datum"].ToString();
                if (datum is null) datum = DateTime.Now.ToString();
                datumDateTimePicker.Value = Convert.ToDateTime(datum);

                var datumValuta = DokumentInfo["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                dtValuta.Value = Convert.ToDateTime(datumValuta);

                var datumPeriod = DokumentInfo["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                dtPeriod.Value = Convert.ToDateTime(datumPeriod);

                viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);
            }
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
                    this.tblPartneriTableAdapter.FillBy(this.materijalnoDataSet.tblPartneri,zbxPartner.ret1.toInt());

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

        public frmObrabotkaNaInterniDokumenti()
        {
            InitializeComponent();

            cmbTipNaDokument.LoadItems("select ID, Naziv + ' - ' + CAST(Interen as nvarchar(4)) as Vrednost from tblTipNaDokument");
            cmbOdObjekt.LoadItems("select ID, Naziv as Vrednost from tblObjekti");
            cmbDoObjekt.LoadItems("select ID, Naziv as Vrednost from tblObjekti");

            if (cmbTipNaDokument.Items.Count > 0)
            {
                if (cmbTipNaDokument.SelectedIndex != -1)
                {
                    cmbDoObjekt.Enabled = cmbTipNaDokument.Text.Contains(" - 0");
                    zbxPartner.Enabled = cmbTipNaDokument.Text.ToString().Contains(" - 1");
                    brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + cmbTipNaDokument.SelectedValue).ToString();
                }
            }
        }

        private void kolicinatxtBase_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmObrabotkaNaInterniDokumenti_Load(object sender, EventArgs e)
        {

            gridView1.ActiveFilter.Clear();
            if (settings.TipNaPrograma == "Documents789")
            {
                chkDopolnitenoInoInfo.Checked = true;
                txtNotesText.Text = "LOT:";
                btnDogovori.Visible = true;
            }
             tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            
            if(chkDopolnitenoInoInfo.Checked)
            {
                txtNotesText.Visible = true;
                txtNotesNumber.Visible = true;
            }

            if (FormIsEdit)
            {
                cmbTipNaDokument.Enabled = false;

                viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);
                
            }
            else
            {
                datumDateTimePicker.Value = DateTime.Now;
                if (cmbTipNaDokument.Items.Count > 0)
                {
                    cmbTipNaDokument.SelectedIndex = 0;
                    if (cmbTipNaDokument.SelectedIndex != -1)
                    {
                        cmbDoObjekt.Enabled = cmbTipNaDokument.Text.Contains(" - 0");
                        zbxPartner.Enabled = cmbTipNaDokument.Text.ToString().Contains(" - 1");
                        brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + cmbTipNaDokument.SelectedValue).ToString();

                        SetActiveObjectOnOpen();
                    }
                }
                
            }

            if (ReadOnlyForm == true)
            {
                btnPecati.Enabled = true;
                viewDokumentiStavkigrd.Enabled = true;
            }
            if(settings.TipNaPrograma == "988Kasa")
            {

            }
            
        
        }

        private void rabat1Label_Click(object sender, EventArgs e)
        {
        }

        public bool Validacija_dokumenti()
        {
            if (string.IsNullOrEmpty(brojTextBox.Text) || brojTextBox.Text == "0")
            {
                return false;
            }
            if (cmbTipNaDokument.SelectedIndex == -1)
                return false;
            if (cmbOdObjekt.SelectedIndex == -1)
                return false;
            if (cmbDoObjekt.SelectedIndex == -1)
                return false;
            if (zbxPartner.Enabled == true && string.IsNullOrEmpty(zbxPartner.ret1))
                return false;

            return true;
        }

        
        private void btnSocuvajZaglavje_Click(object sender, EventArgs e)
        {
            SocuvajZaglavjeDokumenti();
        }

        private void SocuvajZaglavjeDokumenti()
        {
            if (Validacija_dokumenti())
            {
                SaveDocumentHeader();
                if (dokumentID != -1)
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
            else
            {
                btnPecati.Enabled = false;
                MessageBox.Show("Пополнете ги сите податоци во заглавјето !!!");
                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }

        }

        private void SaveDocumentHeader()
        {
            if (dokumentID == -1 || FormIsEdit)
            {
                var SifraZaPartner = string.Empty;
                if (!string.IsNullOrEmpty(zbxPartner.ret1))
                {
                    SifraZaPartner = Tools.NajdiInfoZaIDPartner(zbxPartner.ret1.toInt())["Sifra"].ToString();
                }
                if (!FormIsEdit)
                    dokumentID = Tools.KreirajDokument(brojTextBox.PrazenStringToInt(), datumDateTimePicker.Value,
                        Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()),
                        Tools.PrazenStringToInt(cmbOdObjekt.SelectedValue.ToString()),
                        Tools.PrazenStringToInt(cmbDoObjekt.SelectedValue.ToString()), zabeleskatxtBase.Text,
                        zbxPartner.ret1, txtBrojNaDokumentFra.Text,
                        dtValuta.Value,
                        dtPeriod.Value,
                        SifraZaPartner);
                else
                {
                    updateZaglavje();
                }

               
            }
        }

        private void updateZaglavje()
        {
            Tools.UpateDokument(dokumentID, brojTextBox.PrazenStringToInt(), datumDateTimePicker.Value,
                Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString()),
                Tools.PrazenStringToInt(cmbOdObjekt.SelectedValue.ToString()),
                Tools.PrazenStringToInt(cmbDoObjekt.SelectedValue.ToString()), zabeleskatxtBase.Text,
                zbxPartner.ret1, txtBrojNaDokumentFra.Text,
                dtValuta.Value,dtPeriod.Value);
        }

        private void cmbTipNaDokument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipNaDokument.Items.Count > 0)
            {
                if (cmbTipNaDokument.SelectedIndex != -1)
                {
                    cmbDoObjekt.Enabled = cmbTipNaDokument.Text.Contains(" - 0");
                    zbxPartner.Enabled = cmbTipNaDokument.Text.ToString().Contains(" - 1");
                    brojTextBox.Text = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + cmbTipNaDokument.SelectedValue).ToString();
                    if(cmbTipNaDokument.Enabled) SetActiveObjectOnOpen();
                }
            }
        }

        private void SetActiveObjectOnOpen()
        {
            try
            {
                if (BssBase.settings.AktivenObjektDoNaStartZaDokumenti != 0)
                {
                    if (cmbDoObjekt.Items.Count > 0)
                    {
                        cmbDoObjekt.SelectedIndex = BssBase.settings.AktivenObjektDoNaStartZaDokumenti;
                    }
                }

                if (BssBase.settings.AktivenObjektOdNaStartZaDokumenti != 0)
                {
                    if (cmbOdObjekt.Items.Count > 0)
                    {
                        cmbOdObjekt.SelectedIndex = BssBase.settings.AktivenObjektOdNaStartZaDokumenti;
                    }
                }
            }
            catch (Exception ex)
            {
                settings.InitSettings.WriteToRegistry("AktivenObjektDoNaStartZaDokumenti", settings.MomentalenObjektID.ToString());
                settings.InitSettings.WriteToRegistry("AktivenObjektOdNaStartZaDokumenti", settings.MomentalenObjektID.ToString());
                BssBase.settings.AktivenObjektDoNaStartZaDokumenti = settings.MomentalenObjektID;
                BssBase.settings.AktivenObjektOdNaStartZaDokumenti = settings.MomentalenObjektID;
                Tools.LogExceptionMessageWithScreenShoot(ex, "SetActiveObjectOnOpen");
            }
        }

        private void txtArtikalSearch_Leave(object sender, EventArgs e)
        {
            ValidateArtikal();
        }
        string infozaartikal = "";
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

                    iznostxtBase.Text = 0.ToString();
                    txtBase1.Text = 0.ToString();
                    rabat1txtBase.Text = 0.ToString();
                    txtArtikalSearch.ret5 = info["ProdaznaCena"].ToString();
                    txtArtikalSearch.ret4 = info["Normativ"].ToString();
                    kolicinatxtBase.Text = 1.ToString("N2");
                    txtcena.Text = 0.ToString("N2");
                    iznostxtBase.Text = txtcena.Text;
                    if (TipNaKnizenjeDoc >= 3)
                    {
                        //
                        prethodnanabavnacena = Tools.NajdiPoslednaNabavnaCenaOdDokumentiZaArtikalID(txtArtikalSearch.ret1, (int)cmbTipNaDokument.SelectedValue);
                        kolicinanazaliha = Tools.NajdiZalihaZaArtikalID(txtArtikalSearch.ret1);
                        txtcena.Text = txtArtikalSearch.ret5;
                        txtSoDDV.Text = prethodnanabavnacena.ToString("N2");
                        marza = 0;
                        infozaartikal = string.Format(@"Претходна Набавна Цена: {0} Количина на залиха: {1} Маржа: {2} ", prethodnanabavnacena.ToString("N2"), kolicinanazaliha.ToString("N2"), marza.ToString("N2"));
                        lblInfo.Text = infozaartikal;
                        kolicinatxtBase.Select();
                        kolicinatxtBase.Focus();
                        //
                    }
                    else
                    {
                        txtSoDDV.Text = Tools.PoslednaCenaZaArtikalODPartner(Tools.PrazenStringToInt(info["ID"].ToString(), 0), Tools.PrazenStringToInt(zbxPartner.ret1)).ToString("N2");
                        txtcena.Text = Tools.PrazenStringToDecimal_dec(info["ProdaznaCena"].ToString()).ToString("N2");
                        Presmetaj();
                    }
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

        decimal prethodnanabavnacena, kolicinanazaliha, marza = 0;
        private void kolicinatxtBase_Leave(object sender, EventArgs e)
        {
            txtSoDDV.Text = prethodnanabavnacena.ToString("N2");
            txtSoDDV.Focus();
            rabat1txtBase.Text = 0.ToString("N2");
            Presmetaj();
       
            string infozaartikal = string.Format(@"Претходна Набавна Цена: {0} Количина на залиха: {1} Маржа: {2} ", prethodnanabavnacena.ToString("N2"), kolicinanazaliha.ToString("N2"), marza.ToString("N2"));
            lblInfo.Text = infozaartikal;
            rabat1txtBase.ReadOnly = false;
            

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
                decimal PreporacanaCena = Tools.PrazenStringToDecimal_dec(txtcena.Text);
                decimal CenaBezDDV = Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text);
                decimal CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
                decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
                decimal cenaSoRabat = 0;

                if( settings.TipNaPrograma == "Documents789")
                {

                    decimal KonecnaCena = 0;


                    if (CenaBezDDV == 0 && CenaSoDDV == 0)
                    {
                        KonecnaCena = PreporacanaCena;
                        txtSoDDV.Text = KonecnaCena.ToString("N2");
                        txtCenaBezDDV.Text = (KonecnaCena / (1 + (DDVStapka / 100))).ToString("N2");
                    }
                        
                    else
                    {
                        if (CenaSoDDV != 0)
                        {
                            KonecnaCena = CenaSoDDV;
                            txtCenaBezDDV.Text = (CenaSoDDV / (1 + (DDVStapka / 100))).ToString("N2");

                        }

                        if (CenaBezDDV != 0)
                        {
                            KonecnaCena = Math.Round((CenaBezDDV + ((CenaBezDDV / 100) * DDVStapka)));
                            txtSoDDV.Text = KonecnaCena.ToString("N2");
                        }

                    }

                    decimal rabat = ((100 * (PreporacanaCena - KonecnaCena)) / PreporacanaCena);


                    cenaSoRabat = PreporacanaCena - ((PreporacanaCena / 100) * rabat);

                    txtBase1.Text = (cenaSoRabat).ToString("N2");

                    iznostxtBase.Text = (Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString();

                    rabat1txtBase.Text = rabat.ToString("N2");
                   
                    return;
                }


                if (TipNaKnizenjeDoc < 3)
                {
                    if (!String.IsNullOrEmpty(txtArtikalSearch.ret1))
                    {

                        decimal KonecnaCena = 0;


                        if (CenaBezDDV == 0 && CenaSoDDV == 0)
                            KonecnaCena = PreporacanaCena;
                        else
                        {
                            if (CenaSoDDV != 0)
                            {
                                KonecnaCena = CenaSoDDV;
                                txtCenaBezDDV.Text = (CenaSoDDV / (1 + (DDVStapka / 100))).ToString("N2");

                            }

                            if (CenaBezDDV != 0)
                            {
                                KonecnaCena = Math.Round((CenaBezDDV + ((CenaBezDDV / 100) * DDVStapka)));
                                txtSoDDV.Text = KonecnaCena.ToString("N2");
                            }

                        }

                        decimal rabat = ((100 * (PreporacanaCena - KonecnaCena)) / PreporacanaCena);


                         cenaSoRabat = PreporacanaCena - ((PreporacanaCena / 100) * rabat);

                        txtBase1.Text = (cenaSoRabat).ToString("N2");

                        iznostxtBase.Text = (Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString();

                        rabat1txtBase.Text = rabat.ToString("N2");
                    }

                    marza = ((Tools.PrazenStringToDecimal_dec(txtArtikalSearch.ret5) - cenaSoRabat) / cenaSoRabat) * 100;
                    lblInfo.Text =
                        $@"Претходна Набавна Цена: {
                            prethodnanabavnacena:N2} Количина на залиха: {kolicinanazaliha:N2} Маржа: {marza:N2} ";
                } else
                {
                    decimal rabat = rabat1txtBase.PrazenStringToDecimal_dec();


                    cenaSoRabat = txtSoDDV.PrazenStringToDecimal_dec() - ((txtSoDDV.PrazenStringToDecimal_dec() / 100) * rabat);

                    txtBase1.Text = (cenaSoRabat).ToString("N2");

                    iznostxtBase.Text = (Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString();

                    rabat1txtBase.Text = rabat.ToString("N2");

                    marza = ((Tools.PrazenStringToDecimal_dec(txtArtikalSearch.ret5) - cenaSoRabat) / cenaSoRabat) * 100;
                    lblInfo.Text =
                        $@"Претходна Набавна Цена: {
                            prethodnanabavnacena:N2} Количина на залиха: {kolicinanazaliha:N2} Маржа: {marza:N2} ";

                }

             

            }
            catch (Exception )
            {
               // MessageBox.Show("Настана проблем, артиклот е погрешно внесен или не е исправен", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void PresmetajSporedCenaSoDDV()
        {
            decimal PreporacanaCena = Tools.PrazenStringToDecimal_dec(txtcena.Text);
            decimal CenaBezDDV = Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text);
            decimal CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
            decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
            decimal KonecnaCena = 0;

            if (CenaSoDDV != 0)
            {
                KonecnaCena = CenaSoDDV;
                txtCenaBezDDV.Text = (CenaSoDDV / (1 + (DDVStapka / 100))).ToString("N2");
                txtBase1.Text = (KonecnaCena).ToString("N2");
                iznostxtBase.Text = (Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString();
                rabat1txtBase.Focus();
            }
            else {
                txtCenaBezDDV.Focus();
            }
        }

        public void PresmetajSporedCenaBezDDV()
        {
            decimal PreporacanaCena = Tools.PrazenStringToDecimal_dec(txtcena.Text);
            decimal CenaBezDDV = Tools.PrazenStringToDecimal_dec(txtCenaBezDDV.Text);
            decimal CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
            decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
            decimal KonecnaCena = 0;

            if (CenaBezDDV != 0)
            {
                KonecnaCena = (CenaBezDDV * (1 + (DDVStapka / 100)));
                txtSoDDV.Text = (KonecnaCena).ToString("N2");
                txtBase1.Text = (KonecnaCena).ToString("N2");
                iznostxtBase.Text = (Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString();
                rabat1txtBase.Focus();
            }
            else
            {
                txtSoDDV.Focus();
            }
        }

        public void PresmetajCenaSoRabat()
        {
            decimal CenaSoDDV = Tools.PrazenStringToDecimal_dec(txtSoDDV.Text);
            decimal rabat = Tools.PrazenStringToDecimal_dec(rabat1txtBase.Text);
            decimal DDVStapka = Tools.PrazenStringToDecimal_dec(txtDDV.Text);
            decimal KonecnaCena = 0;
            KonecnaCena = CenaSoDDV - (CenaSoDDV * (rabat/100));

            //txtCenaBezDDV.Text = (CenaSoDDV / (1 + (DDVStapka / 100))).ToString("N2");
            //txtSoDDV.Text = (KonecnaCena).ToString("N2");
            txtBase1.Text = (KonecnaCena).ToString("N2");
            iznostxtBase.Text = (Tools.PrazenStringToDecimal(txtBase1.Text) * Tools.PrazenStringToDecimal(kolicinatxtBase.Text)).ToString();


        }

        //public void Presmetaj()
        //{
            
        //        decimal rabat = tools.PrazenStringToDecimal_dec(rabat1txtBase.Text);
        //        decimal Kolicina = kolicinatxtBase.PrazenStringToDecimal_dec();
        //        decimal cenaSoRabat = tools.PrazenStringToDecimal_dec(txtCenaSoDDVVnes.Text) - (tools.PrazenStringToDecimal_dec(txtCenaSoDDVVnes.Text) / 100 * rabat);
        //        txtBase1.Text = (cenaSoRabat).ToString("N2");

        //        txtIznos.Text = (cenaSoRabat * Kolicina).ToString("N2");
            
            
        //}

        private void txtCenaSoDDVVnes_Leave(object sender, EventArgs e)
        {
            Presmetaj();
            
        }

        private void rabat1txtBase_Leave(object sender, EventArgs e)
        {
            Presmetaj();
        }

        private void btnIzbrisiStavka_Click(object sender, EventArgs e)
        {
            if (Equals(viewDokumentiStavkiBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)viewDokumentiStavkiBindingSource.Current)["ID"].ToString());
                Tools.IzbrisiStavkaOdDokument(dokumentID, stavkaID);
                viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);
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
                var stavkaID = Tools.InsertirajStavkaVoDokumenti(dokumentID, Tools.PrazenStringToInt(txtArtikalSearch.ret1), kolicinatxtBase.PrazenStringToDecimal_dec(), txtSoDDV.PrazenStringToDecimal_dec(), iznostxtBase.PrazenStringToDecimal_dec(), normativ, rabat1txtBase.PrazenStringToDecimal_dec());

                if(stavkaID != -1 && chkDopolnitenoInoInfo.Checked)
                {
                    Tools.InsertirajtblDokumentiStavkiDetailsInfo(dokumentID, stavkaID, txtNotesText.Text, txtNotesNumber.Text);

                    txtNotesNumber.Clear();
                }
                viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);
                txtArtikalSearch.Text = string.Empty;
                iznostxtBase.Text = 0.ToString("N2");
                txtBase1.Text = 0.ToString("N2");
                rabat1txtBase.Text = 0.ToString("N2");
                txtcena.Text = 0.ToString("N2");
                txtSoDDV.Text = 0.ToString("N2");
                txtCenaBezDDV.Text = 0.ToString("N2");
                
                txtArtikalSearch.ret1 = string.Empty;
                txtArtikalSearch.Focus();
            }
        }

        private static decimal zaostanatDolg(string sifra)
        {
            var tabelaDolg = Tools.DolgZaPartner(sifra);
            if (tabelaDolg == null) return 0;
            return Convert.ToDecimal(tabelaDolg.Rows[0]["ZaostanatDolg"].ToString());
        }

        private static decimal zaostanatDolgHvac(string sifra)
        {
            var tabelaDolg = Tools.DolgZaPartnerHvac(sifra);
            if (tabelaDolg == null) return 0;
            return Convert.ToDecimal(tabelaDolg.Rows[0]["ZaostanatDolg"].ToString());
        }

        private void KulaBPrintHvac(string partnerSifra, bool prikaziForma, bool print)
        {
            int godina = Convert.ToDateTime(((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString()).Year;

            general_data_mesecTableAdapter.Fill(materijalnoDataSet.General_data_mesec, godina);
            tblDokumentiDetailsInfoTableAdapter.FillBy(this.materijalnoDataSet.tblDokumentiDetailsInfo, dokumentID);
            tblDokumentiDetailsInfoHvacTableAdapter.FillBy(this.materijalnoDataSet.tblDokumentiDetailsInfoHvac, dokumentID);
            

            using (var report = new Reporti.KulaBHvac())
            {
                var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();
                
                string imeNaFaktura = "ФАКТУРА ЗА HVAC";
                
                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string token = ((DataRowView)viewDokumentiBindingSource.Current)["UniqueIdPlacanje"].ToString();
                string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                string Adresa = info["Adresa"].ToString();

                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }
                var invoiceDate = Convert.ToDateTime(datumPeriod);
                general_data_mesecTableAdapter.FillBy(materijalnoDataSet.General_data_mesec, Convert.ToInt32(invoiceDate.Month.ToString()),godina);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", imeNaFaktura);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("ZaostanatDolg", zaostanatDolgHvac(partnerSifra));
                report.SetParameterValue("TekovenFond", 0);
                report.SetParameterValue("RezervenFond", 0);
                report.SetParameterValue("token", token);
                report.SetParameterValue("DatumNaValuta", datumValuta);
                report.SetParameterValue("UrlToken", $"https://payment.zgrada.sk");

                if (prikaziForma)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);

                    if (print)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        private void PrintDokument(string partnerSifra, bool prikaziForma, bool print)
        {
            using (var report = new Reporti.Dokument())
            {
                var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();
                string imeNaFaktura = "ФАКТУРА";
             

                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string token = ((DataRowView)viewDokumentiBindingSource.Current)["UniqueIdPlacanje"].ToString();
                string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                string Adresa = info["Adresa"].ToString();

                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }
                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", imeNaFaktura);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("ZaostanatDolg", zaostanatDolg(partnerSifra));
                report.SetParameterValue("TekovenFond", 0);
                report.SetParameterValue("RezervenFond", 0);
                report.SetParameterValue("token", token);
                report.SetParameterValue("DatumNaValuta", datumValuta);
                report.SetParameterValue("UrlToken", $"https://payment.zgrada.sk");

                if (prikaziForma)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);
                    if (print)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        private void KulaBPrint(string partnerSifra, bool prikaziForma, bool print)
        {
            using (var report = new Reporti.KulaB())
            {
                var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();
                string imeNaFaktura = "ФАКТУРА ЗА ОДРЖУВАЊЕ";
                if (TipNaDokument == "2")
                {
                    imeNaFaktura = "ФАКТУРА ЗА ХВАЦ";
                }
                
                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string token = ((DataRowView)viewDokumentiBindingSource.Current)["UniqueIdPlacanje"].ToString();
                string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                string Adresa = info["Adresa"].ToString();
                
                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }
                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", imeNaFaktura);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("ZaostanatDolg", zaostanatDolg(partnerSifra));
                report.SetParameterValue("TekovenFond", 0);
                string fond = Tools.TekovenFond().Rows[0]["TekovenFond"].ToString();
                report.SetParameterValue("RezervenFond", fond);
                report.SetParameterValue("token", token);
                report.SetParameterValue("DatumNaValuta", datumValuta);
                report.SetParameterValue("UrlToken", $"https://payment.zgrada.sk");

                if (prikaziForma)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);
                    if (print)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        private void PecatiDocuments789(string TipNaDokument, tblFirmaTableAdapter tblFirmaTableAdapter,
            viewDokumentiTableAdapter viewDokumentiTableAdapter,
            viewDokumentiStavkiTableAdapter viewDokumentiStavkiTableAdapter, string partnerSifra, bool showPrintDialog = true, bool printInsteadOfExport = true)
        {


            validatePartner();
            if (TipNaDokument == "ПЛТ Предатница")
            {
                pLTobrazecTableAdapter.FillByDokumentID(materijalnoDataSet.PLTobrazec, dokumentID);
                using (var smetka = new Reporti.PLTZaPriem())
                {
                    smetka.SetDataSource(materijalnoDataSet);
                    smetka.SetParameterValue("Partner", txtPartner.Text);
                    smetka.SetParameterValue("DDVSUMA5PRINABAVKA", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([DDV pri nabavka])", "[Stapka na DDV propis] = 5").ToString()).ToString("N2"));
                    smetka.SetParameterValue("DDVSUMA18PRINABAVKA", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([DDV pri nabavka])", "[Stapka na DDV propis] = 18").ToString()).ToString("N2"));
                    smetka.SetParameterValue("DDVSUMA5PVkupnoDDVProdazna", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([VkupnoDDV prodazna vrednost])", "[Stapka na DDV propis] = 5").ToString()).ToString("N2"));
                    smetka.SetParameterValue("DDVSUMA18VkupnoDDVProdazna", Tools.PrazenStringToDecimal(materijalnoDataSet.PLTobrazec.Compute("SUM([VkupnoDDV prodazna vrednost])", "[Stapka na DDV propis] = 18").ToString()).ToString("N2"));

                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();

                }
            }

            if (TipNaDokument == "Предатница")
            {

                using (var report = new Reporti.Predatnica())
                {

                    report.SetDataSource(materijalnoDataSet);

                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                    report.Dispose();
                    return;
                }
            }

            if (TipNaDokument == "Преносница")
            {
                using (var report = new Reporti.Predatnica())
                {

                    report.SetDataSource(materijalnoDataSet);

                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                    report.Dispose();
                    return;
                }
            }

            if (TipNaDokument == "Сметка")
            {
                using (var report = new Reporti.Smetka())
                {
                    var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                    report.SetDataSource(materijalnoDataSet);
                    string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                    string Adresa = info["Adresa"].ToString();
                    string Telefon = info["Telefoni"].ToString();

                    if (string.IsNullOrEmpty(Adresa))
                    {
                        report.SetParameterValue("AdresaPartner", " ");
                    }
                    else
                    {
                        report.SetParameterValue("AdresaPartner", Adresa);
                    }

                    if (string.IsNullOrEmpty(partner))
                    {
                        report.SetParameterValue("PartnerObjekt", " ");
                    }
                    else
                    {
                        report.SetParameterValue("PartnerObjekt", partner);
                    }


                    if (string.IsNullOrEmpty(Telefon))
                    {
                        report.SetParameterValue("Telefon", " ");
                    }
                    else
                    {
                        report.SetParameterValue("Telefon", Telefon);
                    }



                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                    report.Dispose();
                    return;
                }
            }

            if (TipNaDokument == "Требовање")
            {
                using (var report = new Reporti.Trebovanje())
                {
                    var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                    report.SetDataSource(materijalnoDataSet);
                    string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                    string Adresa = info["Adresa"].ToString();
                    string Telefon = info["Telefoni"].ToString();

                    if (string.IsNullOrEmpty(Adresa))
                    {
                        report.SetParameterValue("AdresaPartner", " ");
                    }
                    else
                    {
                        report.SetParameterValue("AdresaPartner", Adresa);
                    }

                    if (string.IsNullOrEmpty(partner))
                    {
                        report.SetParameterValue("PartnerObjekt", " ");
                    }
                    else
                    {
                        report.SetParameterValue("PartnerObjekt", partner);
                    }


                    if (string.IsNullOrEmpty(Telefon))
                    {
                        report.SetParameterValue("Telefon", " ");
                    }
                    else
                    {
                        report.SetParameterValue("Telefon", Telefon);
                    }



                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                    report.Dispose();
                    return;
                }
            }

            if (TipNaDokument == "Реверс"
                || TipNaDokument == "Нарачка/Испратница"
                || TipNaDokument == "Повратница од партнер"
                || TipNaDokument == "Фактурирани Испратници")
            {
                using (var report = new Reporti.Revers())
                {
                    var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                    report.SetDataSource(materijalnoDataSet);
                    string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                    string Adresa = info["Adresa"].ToString();
                    string Telefon = info["Telefoni"].ToString();

                    if (string.IsNullOrEmpty(Adresa))
                    {
                        report.SetParameterValue("AdresaPartner", " ");
                    }
                    else
                    {
                        report.SetParameterValue("AdresaPartner", Adresa);
                    }

                    if (string.IsNullOrEmpty(partner))
                    {
                        report.SetParameterValue("PartnerObjekt", " ");
                    }
                    else
                    {
                        report.SetParameterValue("PartnerObjekt", partner);
                    }


                    if (string.IsNullOrEmpty(Telefon))
                    {
                        report.SetParameterValue("Telefon", " ");
                    }
                    else
                    {
                        report.SetParameterValue("Telefon", Telefon);
                    }



                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                    report.Dispose();
                    return;
                }
            }

            if (TipNaDokument == "Документ")
            {
                using (var report = new Reporti.DefaultDokument())
                {
                    report.SetDataSource(materijalnoDataSet);
                    string partner = string.Format("{0} / {1}", ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"], ((DataRowView)viewDokumentiBindingSource.Current)["ObejektDO"]);

                    report.SetParameterValue("PartnerObjekt", partner);
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                    report.Dispose();
                }
            }
            if (TipNaDokument == "Фактура - ЕВРА")
            {
                PecatiDocuments_789_Euro(partnerSifra, showPrintDialog, printInsteadOfExport);
                return;
            }

            if (TipNaDokument.Contains("Фактура"))
            {
                PecatiDocuments_789Faktura(partnerSifra, showPrintDialog, printInsteadOfExport);
                return;
            }
            PecatiDocuments_789(partnerSifra, showPrintDialog, printInsteadOfExport);
        }
        private void PecatiDocuments_789_Euro(string partnerSifra, bool showPrintDialog, bool printInsteadOfExport)
        {
            using (var report = new Reporti.DocumentsALL_EN())
            {
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipNaDokument"].ToString();
                string NaslovNaDokument = Tools.ReportFileNameNaReportOdTipNaDokument(Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString()));

                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string partner = string.Empty;
                string Adresa = string.Empty;

                var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                if (info != null)
                {
                    partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                    Adresa = info["Adresa"]?.ToString();
                }

                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }
                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", NaslovNaDokument);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("DatumNaValuta", datumValuta);

                if (showPrintDialog)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);
                    if (printInsteadOfExport)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        private void PecatiDocuments_789Faktura(string partnerSifra, bool showPrintDialog, bool printInsteadOfExport)
        {
            using (var report = new Reporti.DocumentsFaktura())
            {

                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipNaDokument"].ToString();
                string NaslovNaDokument = Tools.ReportFileNameNaReportOdTipNaDokument(Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString()));

                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string partner = string.Empty;
                string Adresa = string.Empty;

                var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                if (info != null)
                {
                    partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                    Adresa = info["Adresa"]?.ToString();
                }

                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }
                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", NaslovNaDokument);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("DatumNaValuta", datumValuta);

                if (showPrintDialog)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);
                    if (printInsteadOfExport)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        private void PecatiDocuments_789(string partnerSifra, bool showPrintDialog, bool printInsteadOfExport)
        {
            using (var report = new Reporti.Documents())
            {
                
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipNaDokument"].ToString();
                string NaslovNaDokument = Tools.ReportFileNameNaReportOdTipNaDokument(Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString()));

                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string partner = string.Empty;
                string Adresa = string.Empty;

                var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                if (info != null)
                {
                     partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                     Adresa = info["Adresa"]?.ToString();
                }

                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }
                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", NaslovNaDokument);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("DatumNaValuta", datumValuta);

                if (showPrintDialog)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);
                    if (printInsteadOfExport)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        public void Pecati()
        {
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            viewDokumentiTableAdapter.FillBy(materijalnoDataSet.viewDokumenti, dokumentID);
            viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);

            string partnerSifra = "";
            if (string.IsNullOrEmpty(partnerSifra))
            {
                partnerSifra = ((DataRowView)viewDokumentiBindingSource.Current)["SifraPartner"].ToString();
            }
           

            try
            {
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipNadokument"].ToString();
                string TipNaDokumentID = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();

                if (settings.TipNaPrograma == "Documents789")
                {
                    PecatiDocuments789(TipNaDokument, tblFirmaTableAdapter, viewDokumentiTableAdapter, viewDokumentiStavkiTableAdapter, partnerSifra);
                    return;
                }

                if (TipNaDokumentID == "1" && (settings.TipNaPrograma == "10KulaB"))
                {
                    KulaBPrint(partnerSifra, true, true);
                    return;
                }

                if (TipNaDokumentID == "2" && (settings.TipNaPrograma == "10KulaB"))
                {
                    KulaBPrintHvac(partnerSifra,true,true);
                    return;
                }

                if ((TipNaDokumentID == "3" || TipNaDokumentID == "9" && settings.TipNaPrograma != "88") && (settings.TipNaPrograma == "10KulaB"))
                {
                    PrintDokument(partnerSifra, true, true);
                    return;
                }


                if (TipNaDokument == "Фактура" && settings.TipNaPrograma == "987")
                {
                    using (var report = new Reporti.SmetkaFaktura())
                    {
                        var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                        report.SetDataSource(materijalnoDataSet);
                        string partner = ((DataRowView) viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                        string Adresa = info["Adresa"].ToString();
                        string Telefon = info["Telefoni"].ToString();

                        if (string.IsNullOrEmpty(Adresa))
                        {
                            report.SetParameterValue("AdresaPartner", " ");
                        }
                        else
                        {
                            report.SetParameterValue("AdresaPartner", Adresa);
                        }

                        if (string.IsNullOrEmpty(partner))
                        {
                            report.SetParameterValue("PartnerObjekt", " ");
                        }
                        else
                        {
                            report.SetParameterValue("PartnerObjekt", partner);
                        }


                        if (string.IsNullOrEmpty(Telefon))
                        {
                            report.SetParameterValue("Telefon", " ");
                        }
                        else
                        {
                            report.SetParameterValue("Telefon", Telefon);
                        }

                        report.SetParameterValue("User", tmpConfigs.LogiranUserFullName);

                        PrintPreview prev = new PrintPreview();
                        prev.ReportPreview.ReportSource = report;

                        prev.ShowDialog();
                        report.Dispose();
                        return;
                    }
                }

                if (TipNaDokument == "Реверс" || TipNaDokument == "Нарачка/Испратница" || TipNaDokument == "Повратница од партнер" || TipNaDokument == "Фактурирани Испратници" && settings.TipNaPrograma == "987")
                {
                    using (var report = new Reporti.Revers())
                    {
                        var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                        report.SetDataSource(materijalnoDataSet);
                        string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                        string Adresa = info["Adresa"].ToString();
                        string Telefon = info["Telefoni"].ToString();

                        if (string.IsNullOrEmpty(Adresa))
                        {
                            report.SetParameterValue("AdresaPartner", " ");
                        }
                        else
                        {
                            report.SetParameterValue("AdresaPartner", Adresa);
                        }

                        if (string.IsNullOrEmpty(partner))
                        {
                            report.SetParameterValue("PartnerObjekt", " ");
                        }
                        else
                        {
                            report.SetParameterValue("PartnerObjekt", partner);
                        }


                        if (string.IsNullOrEmpty(Telefon))
                        {
                            report.SetParameterValue("Telefon", " ");
                        }
                        else
                        {
                            report.SetParameterValue("Telefon", Telefon);
                        }
                       

                        
                        PrintPreview prev = new PrintPreview();
                        prev.ReportPreview.ReportSource = report;

                        prev.ShowDialog();
                        report.Dispose();
                        return;
                    }
                }
                else
                {
                    if (TipNaDokument == "Предатница")
                    {
                        
                        using (var report = new Reporti.Predatnica())
                        {
                            
                            report.SetDataSource(materijalnoDataSet);
                            
                            PrintPreview prev = new PrintPreview();
                            prev.ReportPreview.ReportSource = report;

                            prev.ShowDialog();
                            report.Dispose();
                            return;
                        }
                    }

                    if (TipNaDokument == "ПЛТ Предатница")
                    {
                        pLTobrazecTableAdapter.FillByDokumentID(materijalnoDataSet.PLTobrazec, dokumentID);
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


                    if (TipNaDokument == "Преносница")
                    {
                        using (var report = new Reporti.Predatnica())
                        {

                            report.SetDataSource(materijalnoDataSet);

                            PrintPreview prev = new PrintPreview();
                            prev.ReportPreview.ReportSource = report;

                            prev.ShowDialog();
                            report.Dispose();
                            return;
                        }
                    }


                    if (TipNaDokument == "Требовање")
                    {
                        using (var report = new Reporti.Trebovanje())
                        {
                            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                            report.SetDataSource(materijalnoDataSet);
                            string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                            string Adresa = info["Adresa"].ToString();
                            string Telefon = info["Telefoni"].ToString();

                            if (string.IsNullOrEmpty(Adresa))
                            {
                                report.SetParameterValue("AdresaPartner", " ");
                            }
                            else
                            {
                                report.SetParameterValue("AdresaPartner", Adresa);
                            }

                            if (string.IsNullOrEmpty(partner))
                            {
                                report.SetParameterValue("PartnerObjekt", " ");
                            }
                            else
                            {
                                report.SetParameterValue("PartnerObjekt", partner);
                            }


                            if (string.IsNullOrEmpty(Telefon))
                            {
                                report.SetParameterValue("Telefon", " ");
                            }
                            else
                            {
                                report.SetParameterValue("Telefon", Telefon);
                            }



                            PrintPreview prev = new PrintPreview();
                            prev.ReportPreview.ReportSource = report;

                            prev.ShowDialog();
                            report.Dispose();
                            return;
                        }
                    }

                    if (TipNaDokument == "Сметка" && settings.TipNaPrograma == "987")
                    {
                        using (var report = new Reporti.Smetka())
                        {
                            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

                            report.SetDataSource(materijalnoDataSet);
                            string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                            string Adresa = info["Adresa"].ToString();
                            string Telefon = info["Telefoni"].ToString();

                            if (string.IsNullOrEmpty(Adresa))
                            {
                                report.SetParameterValue("AdresaPartner", " ");
                            }
                            else
                            {
                                report.SetParameterValue("AdresaPartner", Adresa);
                            }

                            if (string.IsNullOrEmpty(partner))
                            {
                                report.SetParameterValue("PartnerObjekt", " ");
                            }
                            else
                            {
                                report.SetParameterValue("PartnerObjekt", partner);
                            }


                            if (string.IsNullOrEmpty(Telefon))
                            {
                                report.SetParameterValue("Telefon", " ");
                            }
                            else
                            {
                                report.SetParameterValue("Telefon", Telefon);
                            }



                            PrintPreview prev = new PrintPreview();
                            prev.ReportPreview.ReportSource = report;

                            prev.ShowDialog();
                            report.Dispose();
                            return;
                        }
                    }
                    else
                    {
                        using (var report = new Reporti.DefaultDokument())
                        {
                            report.SetDataSource(materijalnoDataSet);
                            string partner = string.Format("{0} / {1}", ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"], ((DataRowView)viewDokumentiBindingSource.Current)["ObejektDO"]);

                            report.SetParameterValue("PartnerObjekt", partner);
                            PrintPreview prev = new PrintPreview();
                            prev.ReportPreview.ReportSource = report;

                            prev.ShowDialog();
                            report.Dispose();
                        }
                    }
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
                if (!Tools.DaliPostoiZapis("tblKnizenjeM", "tblDokumentID", dokumentID.ToString(), false))
                {
                    opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniDokumentotKjeBideProknizen"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        Tools.ProkniziDokument(dokumentID);
                        Close();
                    }
                }
            }
            Pecati();
        }

        public bool KreirajSmetka(int tipNaDOkument)
        {
            if (Validacija_dokumenti() && dokumentID == -1)
            {
                
                dokumentID = Tools.KreirajDokument(brojTextBox.PrazenStringToInt(), datumDateTimePicker.Value, tipNaDOkument, Tools.PrazenStringToInt(cmbOdObjekt.SelectedValue.ToString()), Tools.PrazenStringToInt(cmbDoObjekt.SelectedValue.ToString()), zabeleskatxtBase.Text, zbxPartner.ret1, txtBrojNaDokumentFra.Text,
                    dtValuta.Value,dtPeriod.Value);
                if (dokumentID != -1)
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
                                        int artikalID = Tools.PrazenStringToInt(reader["ArtikalID"].ToString());
                                        decimal prosecnaNabavnaCena = Tools.NajdiProsecnaNabavnaCenaZaArtikalID(artikalID);
                                        if (tipNaDOkument == 3)
                                            Tools.InsertirajStavkaVoDokumenti(dokumentID, artikalID, decimal.Parse(reader["Kolicina"].ToString()), prosecnaNabavnaCena, decimal.Parse(reader["Iznos"].ToString()), normativ, Tools.PrazenStringToDecimal_dec(reader["Rabat"].ToString()));
                                        else
                                        {
                                            Tools.InsertirajStavkaVoDokumenti(dokumentID, artikalID, decimal.Parse(reader["Kolicina"].ToString()), decimal.Parse(reader["CenaSoRabatIddv"].ToString()), decimal.Parse(reader["Iznos"].ToString()), normativ, Tools.PrazenStringToDecimal_dec(reader["Rabat"].ToString()));
                                        }
                                    }
                                    reader.Close();
                                    com.CommandText = "Delete from tblSmetka where ID = " + SMetka;
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
                opc = MessageBox.Show("Дали сакате да ја завршите и отпечатите документот ? ", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    int tipNaDOkument = Tools.PrazenStringToInt(cmbTipNaDokument.SelectedValue.ToString());
                    if (KreirajSmetka(tipNaDOkument))
                    {
                        Pecati();
                        if (settings.ProkniziDokumenti == "1")
                        {
                            if (!Tools.DaliPostoiZapis("tblKnizenjeM", "tblDokumentID", dokumentID.ToString(), false))
                            {
                                opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniDokumentotKjeBideProknizen"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (opc == DialogResult.Yes)
                                {

                                    Tools.ProkniziDokument(dokumentID);
                                    //this.Close();
                                }
                            }

                            if (settings.TipNaPrograma == "88")
                            {
                                if (tipNaDOkument == 3)
                                    PratiDokument();
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

        

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (dokumentID == -1)
            {
                e.Cancel = true;
                MessageBox.Show(Tools.PrevediPoraka("Заглавјето не е правилно пополнето "), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void rabat1txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcena_Leave(object sender, EventArgs e)
        {
            Presmetaj();
        }

        private void txtSoDDV_Leave(object sender, EventArgs e)
        {
            if (TipNaKnizenjeDoc < 3)
            {
                PresmetajSporedCenaSoDDV();
                //if (txtSoDDV.PrazenStringToDecimal_dec() != 0 || txtCenaBezDDV.PrazenStringToDecimal_dec() != 0)
                //{
                //    if (txtSoDDV.PrazenStringToDecimal_dec() != 0)
                //        Presmetaj();
                //    else
                //        txtCenaBezDDV.Focus();

                //    rabat1txtBase.Select();
                //    rabat1txtBase.Focus();
                //}
                //else
                //{
                //    Presmetaj();
                //    rabat1txtBase.Select();
                //    rabat1txtBase.Focus();
                //}
            } else
            {
                Presmetaj();
                rabat1txtBase.Select();
                rabat1txtBase.Focus();
            }

            string infozaartikal = string.Format(@"Претходна Набавна Цена: {0} Количина на залиха: {1} Маржа: {2} ", prethodnanabavnacena.ToString("N2"), kolicinanazaliha.ToString("N2"), marza.ToString("N2"));
            lblInfo.Text = infozaartikal;

        }

        private void txtCenaBezDDV_Leave(object sender, EventArgs e)
        {
            //Pojma nemam zosto ovde ne se proverue dali e 3 ili ne - treba da se proveri
            if (TipNaKnizenjeDoc < 3)
            {
                PresmetajSporedCenaBezDDV();
            }


            //if (txtSoDDV.PrazenStringToDecimal_dec() != 0 || txtCenaBezDDV.PrazenStringToDecimal_dec() != 0)
            //{
            //    if (txtCenaBezDDV.PrazenStringToDecimal_dec() != 0)
            //        Presmetaj();
            //    else
            //        txtSoDDV.Focus();
            //}
            //else
            //{
            //    Presmetaj();
            //}
        }

        int TipNaKnizenjeDoc = 0;

        private void rabat1txtBase_Leave_1(object sender, EventArgs e)
        {
            if (TipNaKnizenjeDoc >= 3)
            {
                Presmetaj();
            }
            else
            {
                PresmetajCenaSoRabat();
            }

            btnSocuvajStavka.Focus();
        }

        private void viewDokumentiStavkigrd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Multiply )
            {
                if (!Equals(null, viewDokumentiStavkiBindingSource.Current))
                {
                    int artikal = Tools.PrazenStringToInt(((DataRowView)viewDokumentiStavkiBindingSource.Current)["ArtikalID"].ToString());
                    decimal rabat = Tools.PrazenStringToDecimal_dec(((DataRowView)viewDokumentiStavkiBindingSource.Current)["Rabat1"].ToString());
                    decimal MomentalnaKolicna = Tools.PrazenStringToDecimal_dec(((DataRowView)viewDokumentiStavkiBindingSource.Current)["Kolicina"].ToString());
                    decimal MomentalnabavnaCena = Tools.PrazenStringToDecimal_dec(((DataRowView)viewDokumentiStavkiBindingSource.Current)["Cena"].ToString());

                    var NovaKolicina = InputBox.Show("Количина: ","Промена на внесена количина на артикал ",MomentalnaKolicna, true);
                    decimal decNovaKolicina = Tools.PrazenStringToDecimal_dec(NovaKolicina.Text);

                    var NovaNabavnaCena = InputBox.Show("Набавна цена: ","Промена на набавна цена ",MomentalnabavnaCena, true);
                    decimal decNovaNabavnaCena = Tools.PrazenStringToDecimal_dec(NovaNabavnaCena.Text);

                    if (NovaKolicina.ReturnCode == DialogResult.OK)
                    {
                        int stavkaID = Tools.PrazenStringToInt(((DataRowView)viewDokumentiStavkiBindingSource.Current)["ID"].ToString());
                        Tools.IzbrisiStavkaOdDokument(dokumentID, stavkaID);
                        
  
                        Tools.InsertirajStavkaVoDokumenti(dokumentID, artikal, decNovaKolicina, decNovaNabavnaCena,
                            decNovaKolicina * decNovaNabavnaCena, false, rabat);

                        viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);
                    }
                }
            }
        }

        private void btnPLT_Click(object sender, EventArgs e)
        {
            pLTobrazecTableAdapter.FillByDokumentID(materijalnoDataSet.PLTobrazec, dokumentID);
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

        private void txtBase1_Leave(object sender, EventArgs e)
        {
            btnSocuvajStavka.Focus();
        }

        private void btnDogovori_Click(object sender, EventArgs e)
        {
            if (Validacija_dokumenti())
            {
                SaveDocumentHeader();
                if (string.IsNullOrEmpty(zbxPartner.ret1))
                {
                    MessageBox.Show("Изберете партнер");
                    return;
                }
                frmDogovori frmDogovori = new frmDogovori(Tools.PrazenStringToInt(zbxPartner.ret1));
                frmDogovori.zoom = true;
                frmDogovori.Text = "Договори за партнер";
                frmDogovori.ShowDialog();
                if (!Equals(null, frmDogovori.dr)) {
                    int dogovorID = Tools.PrazenStringToInt(frmDogovori.dr.Cells["ID"].Value.ToString());
                    string zabeleska = string.Empty;
                    
                    zabeleska = $"{frmDogovori.dr.Cells["BrojNaDogovor"]?.Value?.ToString()} {frmDogovori.dr.Cells["BrojNaTender"]?.Value?.ToString()} {Environment.NewLine} {frmDogovori.dr.Cells["Zabeleska"]?.Value?.ToString()}";
                   
                    zabeleskatxtBase.Text += zabeleska; 
                    UpdateDogovorIdZaDokument(dokumentID, dogovorID);
                    zabeleskatxtBase.Text = zabeleska;
                    MessageBox.Show("Договорот е зачуван за овој партнер");
                    btnSocuvajZaglavje.PerformClick();
                } else
                {
                    MessageBox.Show("Нема избрано договор за овој партнер");
                }
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            var doc = Tools.NajdiInfoZaDokumentTipNaKnizenje(dokumentID);

            TipNaKnizenjeDoc  = Tools.PrazenStringToInt(doc["TipNaKnizenje"].ToString());

            if(TipNaKnizenjeDoc < 3)
            {
                btnPLT.Visible = false;
            }

            if (TipNaKnizenjeDoc >= 3)
            {
                label1.Text = "Цена на артикал :";
                label2.Text = "Набавна цена со ДДВ:";
                label3.Visible = false;
                label3.Enabled = false;
                txtCenaBezDDV.Enabled = false;
                txtCenaBezDDV.Visible = false;
                rabat1txtBase.ReadOnly = false;
                btnPLT.Visible = true;
            }
            if(TipNaKnizenjeDoc == -1 && txtBrojNaDokumentFra.IsTextEmpty())
            {
            DataTable db = new DataTable();

                if (doc["Naziv"].ToString().Contains("Повратница"))
                {
                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand("select * from viewDokumentiZaPlakjanje where TipNaDokument = 3 and tblPartnerID =" + zbxPartner.ret1, con))
                        {
                            con.Open();
                            db.Load(com.ExecuteReader());
                            con.Close();
                        }
                    }

                    BssBase.Elements.SelectBox box = new BssBase.Elements.SelectBox(db, "DOKUMENTI", -1);
                    DialogResult rez = box.ShowDialog();

                    if (rez == DialogResult.OK)
                    {
                        foreach (DataRow item in box.DbREsult.Rows)
                        {

                            txtBrojNaDokumentFra.Text = item[2].ToString();
                            updateZaglavje();
                        }
                    }
                }
                
            }

           
        }

        private void txtcena_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var amount = 0;

            var rez = InputBox.Show("Внесете продажна цена за одбраниот артикал", false, true);
            amount = Tools.PrazenStringToInt(rez.Text);


            if (!string.IsNullOrEmpty(rez.Text))
            {
                if (rez.ReturnCode == DialogResult.OK)
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
    }
}
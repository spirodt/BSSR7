using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSS;
using BssBase;
using ComPortRFidReader;
using DevExpress.Internal.WinApi;
using uFR;

//MFakturi.Forms.frmKasa
namespace MFakturi.Forms
{

    public partial class frmKasa : Form
    {
        private Utility.ModifyRegistry.ModifyRegistry RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
        private bool FormIsEdit;
        private int SmetkaID;
        private String UserName;
        private String BrojNaSmetka;
        private String DatumNaSmetka;
        public ReadRFidCard cardReader;




        public frmKasa(int smetkaID, string brojNaSmetka, string userName, string Datum, string zabeleska)
        {


            RegistryData.SubKey = settings.RegPath;
            InitializeComponent();
            SmetkaID = smetkaID;
            UserName = userName;
            BrojNaSmetka = brojNaSmetka;
            DatumNaSmetka = Datum;
            NaloziZaSmetka(SmetkaID, false);
            txtDatumNaSmetka.Text = "Датум на сметка: " + Datum;
            txtVraboten.Text = "Вработен: " + userName;
            txtSmetkaBroj.Text = "Сметка број: " + brojNaSmetka;
            txtZabeleska.Text = zabeleska;

            FormIsEdit = true;


        }

        private void CardReader_ReceeivedCardNumberEvent(string cardNumber, System.IO.Ports.SerialDataReceivedEventArgs eventArgs)
        {
            Invoke(new MethodInvoker(delegate
            {
                try
                {

                    if (!string.IsNullOrEmpty(cardNumber.Trim()))
                    {
                        zbxPartner.Value.Text = cardNumber;
                        validatePartner();
                        if (!string.IsNullOrEmpty(zbxPartner.ret1))
                        {
                            int partnerID = Tools.PrazenStringToInt(zbxPartner.ret1);
                            SocuvajPartner(partnerID, SmetkaID);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Tools.RaiseException(ex, false, "Проблем со партнерот од картичка");
                }
            }));

        }
        Timer tmrCardReading;

        public void StartReader()
        {
            if (settings.TipNaPrograma.Contains("988KasaPartner") && settings.StartCardReaderd.Contains("true"))
            {
                try
                {
                    if (!settings.StartCardNFCReader.ToLower().Contains("true"))
                    {
                        cardReader = new ReadRFidCard(settings.ComPortForSerialCardReader);
                        cardReader.InitComPort();
                        cardReader.ReceeivedCardNumberEvent += CardReader_ReceeivedCardNumberEvent;
                    }
                    else
                    {
                        tmrCardReading = new Timer();
                        tmrCardReading.Interval = 1000;
                        if (StartNfcReader())
                        {
                            tmrCardReading.Tick += TmrCardReading_Tick;
                            tmrCardReading.Start();
                        };


                    }
                }
                catch (Exception ex)
                {
                    Tools.RaiseException(ex, true, "Читачот неможе да се отвори ");
                }
            }
        }

        string statusText = string.Empty;
        string statusTextError = string.Empty;
        string cardValue = string.Empty;
        private string ProcessData(byte[] data)
        {
            byte[] array = new byte[2048];
            array[0] = data[7];
            array[1] = data[8];
            return ((array[0] << 8) | array[1]).ToString();
        }

        public string GetSifraForHex(string hexstring)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand($"select  top 1 Sifra from  tblPartneri where Notes like '{hexstring}%' order by ID desc", con))
                {
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@p", hexstring);
                    con.Open();
                    var result = com.ExecuteScalar();
                    if (result == null || result.ToString() == string.Empty)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return result.ToString();
                    }
                }
            }
        }

        
        private void TmrCardReading_Tick(object sender, EventArgs e)
        {
            try
            {
                byte sak = 0, uid_size = 0;
                byte[] uid = new byte[6];

                DL_STATUS status = 0;

                status = uFCoder.GetCardIdEx(out sak, uid, out uid_size);

                string cardUidString = BitConverter.ToString(uid).Replace("-", "").Replace(":", "").Replace("0x", "");


                txtNfCReaderStatus.Text = cardUidString;


                if (cardValue != cardUidString)
                {
                    if (cardUidString.Trim() != "000000000000")
                    {
                        zbxPartner.ret1 = string.Empty;
                        zbxPartner.Value.Text = GetSifraForHex(cardUidString);
                        validatePartner();
                        cardValue = cardUidString;

                        if (!string.IsNullOrEmpty(zbxPartner.ret1))
                        {
                            int partnerID = Tools.PrazenStringToInt(zbxPartner.ret1);
                            SocuvajPartner(partnerID, SmetkaID);
                            txtNfCReaderStatus.BackColor = Color.Green;
                            uFCoder.ReaderUISignal(1, 1);
                        }
                        else
                        {
                            uFCoder.ReaderUISignal(2, 5);
                            txtNfCReaderStatus.BackColor = Color.Firebrick;
                            txtNfCReaderStatus.Click += TxtNfCReaderStatus_Click;
                        }
                    }
                    else if (cardUidString.ToLower().Trim().Equals("0"))
                    {
                        txtNfCReaderStatus.Text = "NFC Нема картичка";
                        txtNfCReaderStatus.BackColor = Color.Gray;

                        uFCoder.ReaderUISignal(2, 1);
                    }
                }

            }
            catch (Exception ex)
            {
                Tools.RaiseException(ex, true, statusText);
            }
        }

        private void TxtNfCReaderStatus_Click(object sender, EventArgs e)
        {
            frmPartneriEdit frmPartneriEdit = new frmPartneriEdit(txtNfCReaderStatus.Text);
            frmPartneriEdit.ShowDialog();
            txtNfCReaderStatus.Click += TxtNfCReaderStatus_Click;
        }

        private bool StartNfcReader()
        {
            DL_STATUS status = 0;

            status = uFCoder.ReaderOpen();

            if (status > 0)
            {
                statusText = "Нема NFC Читач - Грешка со конекција";
                statusTextError = "Error: " + uFCoder.status2str((uFR.DL_STATUS)status);
                txtNfCReaderStatus.Text = statusTextError;
                txtNfCReaderStatus.BackColor = Color.Red;
                uFCoder.ReaderUISignal(2, 5);
                return false;
            }
            else
            {

                statusText = "Успешно пронајден читач ";

                txtNfCReaderStatus.Text = "NFC Читач спремен";
                txtNfCReaderStatus.BackColor = Color.Green;

                return true;
            }
        }

        public void CloseRader()
        {
            if (settings.TipNaPrograma.Contains("988KasaPartner") && settings.StartCardReaderd.Contains("true"))
            {
                try
                {
                    if (!settings.StartCardNFCReader.ToLower().Contains("true"))
                    {
                        cardReader.CloseComPort();
                        cardReader.ReceeivedCardNumberEvent -= CardReader_ReceeivedCardNumberEvent;
                    }
                    else
                    {
                        tmrCardReading.Stop();
                        uFCoder.ReaderUISignal(1, 0);
                        uFCoder.ReaderClose();
                    }
                }
                catch (Exception ex)
                {
                    Tools.RaiseException(ex, true, "Читачот неможе да се затвори");
                }
            }

        }

        public frmKasa()
        {
            InitializeComponent();

            SmetkaID = -1;
            SmetkaID = KreirajSmetka();
            NaloziZaSmetka(SmetkaID, true);
            txtDatumNaSmetka.Text = "Датум на сметка: " + DatumNaSmetka;
            txtVraboten.Text = "Вработен: " + UserName;
            txtSmetkaBroj.Text = "Сметка број: " + BrojNaSmetka;
            txtZabeleska.Text = string.Empty;
            FormIsEdit = false;


        }

        public int KreirajNovNalog(int SmetkaID, int TipNaNalog)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"INSERT INTO tblNalog (Broj,Zabeleska,FirmaID,Smena_ID,TipNaNalog,SmetkaID)
                                                         VALUES ((Select dbo.NaredeBrojNaNalog()),@Zabeleska,@FirmaID,@Smena_ID,@TipNaNalog,@SmetkaID) Select @@IDENTITY", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@Zabeleska", string.Empty);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        com.Parameters.AddWithValue("@Smena_ID", settings.UserId);
                        com.Parameters.AddWithValue("@TipNaNalog", TipNaNalog);
                        com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                        con.Open();
                        var rez = com.ExecuteScalar();
                        if (!Equals(null, rez))
                        {
                            NalogIDZaInsert = Tools.PrazenStringToInt(rez.ToString());
                            return NalogIDZaInsert;
                        }
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
            return -1;
        }

        public int KreirajSmetka()
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"INSERT INTO tblSmetka (Broj,tblUserID,Smena_ID,FirmaID,ObjektID)
						VALUES ((Select dbo.NaredeBrojNaSmetka()),@tblUserID,@Smena_ID,@FirmaID,@ObjektID) Select @@IDENTITY", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@tblUserID", settings.UserId);
                        com.Parameters.AddWithValue("@Smena_ID", settings.UserId);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        com.Parameters.AddWithValue("@ObjektID", settings.MomentalenObjektID);
                        con.Open();
                        var rez = com.ExecuteScalar().ToString();
                        if (!Equals(rez, null))
                        {
                            SmetkaID = Tools.PrazenStringToInt(rez.ToString());
                            NalogIDZaInsert = KreirajNovNalog(SmetkaID, 0);
                            BrojNaSmetka = Tools.NajdiInfoZaSmetka(SmetkaID)["Broj"].ToString();
                            DatumNaSmetka = Tools.NajdiInfoZaSmetka(SmetkaID)["DatumPocetok"].ToString();
                            txtZabeleska.Text = Tools.NajdiInfoZaSmetka(SmetkaID)["Zabeleska"].ToString();
                            UserName = tmpConfigs.LogiranUserFullName;

                            zbxPartner.Value.Text = settings.SifraKupuvac;
                            validatePartner();

                            return SmetkaID;
                        }


                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return -1;
                    }
                }
            }
            return -1;
        }



        public void KreirajNovaSmetkaOdKasa()
        {
            SmetkaID = -1;
            SmetkaID = KreirajSmetka();
            NaloziZaSmetka(SmetkaID, true);
            txtDatumNaSmetka.Text = "Датум на сметка: " + DatumNaSmetka;
            txtVraboten.Text = "Вработен: " + UserName;
            txtSmetkaBroj.Text = "Сметка број: " + BrojNaSmetka;
            txtZabeleska.Text = string.Empty;
            FormIsEdit = false;
            zbxPartner.Text = string.Empty;
            zbxPartner.ret1 = string.Empty;
            zbxPartner.Value.Text = string.Empty;
        }
        private int NalogIDZaInsert;

        public DataTable NaloziZaSmetka(int SmetkaID, bool kreirajNov = true)
        {
            if (fakturiDataSet.Tables.Contains("Nalozi"))
            {
                fakturiDataSet.Tables.Remove("Nalozi");
            }
            var artikli = new DataTable("Nalozi");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"exec Nalozi " + SmetkaID, con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ID", SmetkaID);
                        fakturiDataSet.Tables.Add("Nalozi");
                        con.Open();
                        fakturiDataSet.Tables["Nalozi"].Load(com.ExecuteReader(CommandBehavior.SingleRow));
                        con.Close();
                        var bs = new BindingSource(fakturiDataSet, "Nalozi");
                        bs.MoveLast();

                        if (!Equals(bs.Current, null))
                        {
                            var nalogID = Tools.PrazenStringToInt(((DataRowView)bs.Current)["ID"].ToString());
                            NalogIDZaInsert = nalogID;
                            stavkiVoNalogKasaTableAdapter.Fill(fakturiDataSet.StavkiVoNalogKasa, NalogIDZaInsert);
                        }

                        if (fakturiDataSet.Tables["Nalozi"].Select("Status = 0").Count() == 0 && kreirajNov)
                        {
                            KreirajNovNalog(SmetkaID, 0);
                        }

                        return artikli;
                    }
                    catch (SqlException ex)
                    {
                        Tools.RaiseException(ex);
                        return null;
                    }

                }
            }
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);

            string patekaDoLogo = settings.PatekaDoLogo;
            if (!string.IsNullOrEmpty(patekaDoLogo))
            {
                if (File.Exists(patekaDoLogo))
                    pictureBox1.Load(patekaDoLogo);
                else
                    pictureBox1.Visible = false;
            } else
            {
                pictureBox1.Visible = false;
            }


            if (!FormIsEdit)
            {
                zbxPartner.Value.Text = settings.SifraKupuvac;
                validatePartner();
                if (settings.TipNaPrograma != "988Kasa" && settings.TipNaPrograma != "10" && settings.TipNaPrograma != "10M")
                {
                    btnNovZapis.PerformClick();
                }
                if (settings.TipNaPrograma == "10M")
                {
                    btnNovZapis.PerformClick();
                }
            }
            else
            {
                //Get Partner From Smetka
                int partner = Tools.NajdiPartnerIDZaSmetka(SmetkaID);

                if (partner != -1 && partner != 0)
                {
                    zbxPartner.Value.Text = Tools.NajdiInfoZaIDPartner(partner)["Sifra"].ToString();
                    validatePartner();
                }
                else
                {
                    zbxPartner.Value.Text = settings.SifraKupuvac;
                    validatePartner();
                }
            }
            if (settings.TipNaPrograma.Contains("988Kasa"))
            {
                btnGarancija.Visible = false;
                btnpecatiIzatvoribrzo.Visible = false;
                //  tabControl1.Visible = false;
            }
            PresmetajLabeli();

            //Cementara da ne moze da se smeni partner
            if (settings.ZadolzitelnoIzberiPartner == true)
            {
                zbxPartner.Enabled = false;
            }
        }

        private void btnNovZapis_Click(object sender, EventArgs e)
        {
            viewArtikliVoSmetkaGridBig.NovVnes();
        }

        private void IzbrisiSeODSmetka(int smetka)
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblNalogStavki where tblNalogID = (select top 1 ID from tblNalog where SmetkaID = @id order by ID desc); delete from tblSmetkaStavki where tblSmetkaID = @id", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@id", smetka);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
        }

        private void IzbrisiCelosnoSmetka(int smetka)
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblNalog where SmetkaID=@id;delete from tblSmetka where ID = @smetka; delete from tblSmetkaStavki where tblSmetkaID = @smetka", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@smetka", smetka);
                        com.Parameters.AddWithValue("@id", smetka);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
        }

        private void btnZatvoriTop_Click(object sender, EventArgs e)
        {
            if (viewArtikliVoSmetkaGridBig.Rows.Count > 0)
            {
                ZapisiZabeleska();
                DialogResult opc = DialogResult.Yes;
                if (settings.TipNaPrograma.Contains("988Kasa") && settings.TipNaPrograma != "10" && settings.TipNaPrograma != "10M")
                {
                    opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да ја напуштите сметката ?  \n Сметката ќе остане отворена затоа што веќе имате внесено артикли во неа !!! "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                        Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {

                DialogResult opc = DialogResult.Yes;

                if (settings.TipNaPrograma.Contains("988Kasa") && settings.TipNaPrograma != "10" && settings.TipNaPrograma != "10M")
                {
                    opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да ја поништите сметката ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        IzbrisiCelosnoSmetka(SmetkaID);
                        Close();
                    }
                }
                else
                {
                    IzbrisiCelosnoSmetka(SmetkaID);
                    Close();
                }
            }
        }

        public void IzbrisiCelosnoArtikal(int artikalID)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("delete from tblNalogStavki where tblNalogID = @NalogID AND tblArtikalID=@ArtikalID", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@NalogID", NalogIDZaInsert);
                        com.Parameters.AddWithValue("@ArtikalID", artikalID);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        NaloziZaSmetka(SmetkaID, false);
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
        }

        private void viewArtikliVoSmetkaGridBig_SaveInsertDataFromGrid(DataTable db)
        {
            var info = Tools.NajdiInfoZaSifraArtikal(db.Rows[0]["Sifra"].ToString());
            if (Equals(null, info))
                return;
            int artikalID = Tools.PrazenStringToInt(info["ID"].ToString());

            bool normativ = false;
            if (info["Normativ"].ToString().ToUpper() == "true".ToUpper())
            {
                normativ = true;
            }

            decimal rabat = Tools.PrazenStringToDecimal_dec(db.Rows[0]["Rabat"].ToString());
            decimal Kolicina = Tools.PrazenStringToDecimal_dec(db.Rows[0]["Kolicina"].ToString());

            dodadiArtikalVoNalog(artikalID, normativ, rabat, Kolicina);

            DialogResult opc = DialogResult.Yes;
            if (!settings.TipNaPrograma.Contains("988Kasa") && settings.TipNaPrograma != "10")
                opc = MessageBox.Show("Додади нова ставка ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                if (!settings.TipNaPrograma.Contains("988Kasa") && settings.TipNaPrograma != "10")
                {
                    btnNovZapis.PerformClick();
                }
                else
                {
                    if (settings.TipNaPrograma.Contains("988KasaPartner"))
                    {
                        btnNovZapis.PerformClick();
                    }
                    else
                    {
                        viewArtikliVoSmetkaGridBig.PonistiVnes();
                    }

                }
            }
            else
            {
                viewArtikliVoSmetkaGridBig.PonistiVnes();
            }
            NaloziZaSmetka(SmetkaID);
            viewArtikliVoSmetkaGridBig.gotoLastInsertedRow("Naziv", db.Rows[0]["Naziv"].ToString());
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (!Equals(null, stavkiVoNalogKasaBindingSource.Current))
            {
                DialogResult opc = DialogResult.No;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да избришете ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    int artikalID = Tools.PrazenStringToInt(((DataRowView)stavkiVoNalogKasaBindingSource.Current)["ArtikalID"].ToString());
                    IzbrisiCelosnoArtikal(artikalID);
                }
            }
        }

        public void pecatiFakturaA4(int SmetkaID, int partner)
        {
            DialogResult opc = DialogResult.No;
            var asm = System.Reflection.Assembly.Load("MFakturi");
            var t = asm.CreateInstance("MFakturi.Forms.frmObrabotkaNaFaktura", true).GetType();
            var frm = (Form)Activator.CreateInstance(t, new object[] { SmetkaID, true, partner, false });
            opc = frm.ShowDialog();
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            DialogResult opc = DialogResult.No;
            opc = MessageBox.Show(Tools.PrevediPoraka("Доколку сакате да испечатите про-фактура притиснете YES, во спротивно за фактура притиснете NO ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool ProFaktura = (DialogResult.Yes == opc);
            var asm = System.Reflection.Assembly.Load("MFakturi");
            var t = asm.CreateInstance("MFakturi.Forms.frmObrabotkaNaFaktura", true).GetType();
            int partner = -1;
            if (!string.IsNullOrEmpty(zbxPartner.ret1))
            {
                partner = Tools.PrazenStringToInt(zbxPartner.ret1, -1);
            }
            var frm = (Form)Activator.CreateInstance(t, new object[] { SmetkaID, true, partner, ProFaktura });
            frm.ShowDialog();
            btnNovaSmetka.PerformClick();
        }


        public static void ZatvoriSocuvanaFiskalna(int smetkaID)
        {
            try
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    decimal Iznos = 0;
                    var ArtikliZaFiskalna = new DataTable("ArtikliZaFiskalna");

                    using (SqlConnection artikliCon = new SqlConnection(settings.konekcija))
                    {
                        artikliCon.Open();
                        using (var Smetki = new SqlCommand("select * from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID", artikliCon))
                        {
                            Smetki.Parameters.Clear();
                            Smetki.Parameters.AddWithValue("@SmetkaID", smetkaID);
                            //Smetki.Parameters.AddWithValue("@SoPopust", 0);
                            //Smetki.Parameters.AddWithValue("@Popust", 0);
                            ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                        }

                        foreach (DataRow Produkt in ArtikliZaFiskalna.Rows)
                        {
                            Iznos += Tools.PrazenStringToDecimal_dec(Produkt["Kolicina"].ToString()) * Tools.PrazenStringToDecimal_dec(Produkt["CenaSoRabatIddv"].ToString());
                        }
                        using (var com = new SqlCommand(@"INSERT INTO tblFiskalniSmetki (Broj ,Datum ,Iznos,Stornirana,tblSmetkaID,FirmaID)
						    values((Select dbo.NaredenBrojNaFiskalna()) ,getDate() ,@Iznos,'false',@tblSmetkaID,@FirmaID) ", artikliCon))
                        {
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("@Iznos", Iznos);
                            com.Parameters.AddWithValue("@tblSmetkaID", smetkaID);
                            com.Parameters.AddWithValue("@FirmaID", settings.firmaId);

                            com.ExecuteNonQuery();
                            artikliCon.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
            }
        }

        public static void zatvoriSmetka(int SmetkaID)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                        com.Parameters.AddWithValue("@SoPopust", 0);
                        com.Parameters.AddWithValue("@Popust", 0);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        public void IspecatiIZatvoriSmetkaSoSveFiskalna(bool popust, decimal ProcentNaPopust)
        {
            int ImaPopust = 0;
            bool VoGotovo = true;
            DialogResult opc = DialogResult.Yes;
            if (settings.PrasajZaZatvoranjeNaSmetka == true)
                opc = MessageBox.Show(Tools.PrevediPoraka("Сметката и нарачката ќе бидат затворени , Дали сакате да ја завршите сметката и да отпечатите фискална сметка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                if (settings.PrikaziFormaZaKusur)
            {
                decimal sumaZaNaplata = Tools.PrazenStringToDecimal_dec(fakturiDataSet.Tables["StavkiVoNalogKasa"].Compute("SUM(Iznos)", string.Empty).ToString());
                if (popust)
                {
                    sumaZaNaplata = sumaZaNaplata - Math.Round(sumaZaNaplata * ProcentNaPopust / 100);
                    ImaPopust = 1;
                }

                string iznos = string.Format(" Вкупно за наплата: {0:C}", sumaZaNaplata);

                var rez = InputBox.ShowFormaZaKusur(iznos, true, sumaZaNaplata, false, true, 18.25F, true);
                if (rez.ReturnCode == DialogResult.OK)
                {
                    opc = DialogResult.Yes;
                    VoGotovo = rez.DefaulOptionSelected;
                }
                else
                {
                    opc = DialogResult.No;
                }
            }

            if (opc == DialogResult.Yes)
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                    {
                        try
                        {

                            var ArtikliZaFiskalna = new DataTable("ArtikliZaFiskalna");
                            using (var Smetki = new SqlCommand("select * from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID", con))
                            {
                                Smetki.Parameters.Clear();
                                Smetki.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                                con.Open();
                                ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                                con.Close();
                            }


                            if (PratiNaPrinter(tmpConfigs.LogiranUserFullName, BrojNaSmetka, settings.PecatiKasaDirektnoFiskalnaISmetka, settings.KopiiZaSmetka))
                            {
                                if (PecatiFiskalna(ArtikliZaFiskalna, VoGotovo))
                                {
                                    com.Parameters.Clear();
                                    com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                                    com.Parameters.AddWithValue("@SoPopust", ImaPopust);
                                    com.Parameters.AddWithValue("@Popust", ProcentNaPopust);
                                    com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    con.Close();
                                }
                                else
                                {
                                    opc = MessageBox.Show("Настана проблем со печатењето на фискална сметка, Сметката не е затворена !!!!", "ГРЕШКА !!!!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
                                }
                                int rowC = viewArtikliVoSmetkaGridBig.Rows.Count;
                                PratiMail(rowC);

                                btnNovaSmetka.PerformClick();
                            }
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true, "", "frmKasa.cs", 668, false);
                            return;
                        }
                    }
                }

                if (opc == DialogResult.Retry)
                {
                    toolStripMenuItem1.PerformClick();
                }
            }
        }

        public void IspecatiIZatvoriSmetkaSoSveFiskalnaBezPrasanja(bool popust, decimal ProcentNaPopust)
        {
            int ImaPopust = 0;

            DialogResult opc = DialogResult.Yes;

            if (settings.PrasajZaZatvoranjeNaSmetkaKasaBrzoPecatenje == true)
                opc = MessageBox.Show(Tools.PrevediPoraka("Сметката и нарачката ќе бидат затворени , Дали сакате да отпечатите сметка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            bool pecatiNaPrinter = (opc == DialogResult.Yes);

            if (settings.PrikaziFormaZaKusurBrzoPecatenje)
            {
                decimal sumaZaNaplata = Tools.PrazenStringToDecimal_dec(fakturiDataSet.Tables["StavkiVoNalogKasa"].Compute("SUM(Iznos)", string.Empty).ToString());
                if (popust)
                {
                    sumaZaNaplata = sumaZaNaplata - Math.Round(sumaZaNaplata * ProcentNaPopust / 100);
                    ImaPopust = 1;
                }

                string iznos = string.Format(" Вкупно за наплата: {0:C}", sumaZaNaplata);

                opc = InputBox.Show(iznos, true, sumaZaNaplata, false, true, 18.25F, true).ReturnCode;
                if (opc == DialogResult.OK)
                {
                    opc = DialogResult.Yes;
                }
                else
                {
                    opc = DialogResult.No;
                }
            }
            else
            {
                opc = DialogResult.Yes;
            }

            if (opc == DialogResult.Yes)
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                    {
                        try
                        {
                            var ArtikliZaFiskalna = new DataTable("ArtikliZaFiskalna");
                            using (var Smetki = new SqlCommand("select * from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID", con))
                            {
                                Smetki.Parameters.Clear();
                                Smetki.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                                con.Open();
                                ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                                con.Close();
                            }
                            if (pecatiNaPrinter)
                            {
                                pecatiNaPrinter = PratiNaPrinter(tmpConfigs.LogiranUserFullName, BrojNaSmetka, true, settings.KopiiSank);
                            }


                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                            com.Parameters.AddWithValue("@SoPopust", ImaPopust);
                            com.Parameters.AddWithValue("@Popust", ProcentNaPopust);
                            com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();

                            btnNovaSmetka.PerformClick();

                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            return;
                        }
                    }
                }

            }
        }
        public bool PecatiFiskalna(DataTable artikliZaFiskalna, bool voGotovo)
        {
            if (settings.PecatFiskalna == false)
            {
                return true;
            }



            if (settings.PrasajZaFiskalna == true)
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сакате да ја сочувате сметката ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                }
                else
                {
                    return true;
                }
            }

            if (Equals(null, artikliZaFiskalna))
            {
                return false;
            }

            if (artikliZaFiskalna.Rows.Count < 0)
            {
                return false;
            }
            var rezultat = false;
            try
            {
                var fiskalna = new FiscalCash(BrojNaSmetka);
                fiskalna.InitInterface();
                fiskalna.ArtikliZaNaFiskalna(false, artikliZaFiskalna);

                fiskalna.IssueBill(voGotovo);

                rezultat = true;
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return false;
            }
            try
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    decimal Iznos = 0;
                    foreach (DataRow Produkt in artikliZaFiskalna.Rows)
                    {
                        Iznos += Tools.PrazenStringToDecimal_dec(Produkt["Kolicina"].ToString()) * Tools.PrazenStringToDecimal_dec(Produkt["CenaSoRabatIddv"].ToString());
                    }
                    using (var com = new SqlCommand(@"INSERT INTO tblFiskalniSmetki (Broj ,Datum ,Iznos,Stornirana,tblSmetkaID,FirmaID)
						values((Select dbo.NaredenBrojNaFiskalna()) ,getDate() ,@Iznos,'false',@tblSmetkaID,@FirmaID) ", con))
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@Iznos", Iznos);
                        com.Parameters.AddWithValue("@tblSmetkaID", SmetkaID);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                rezultat = true;
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return false;
            }
            return rezultat;
        }

        private void PratiMail(int rowCount)
        {
            if (!string.IsNullOrEmpty(settings.GMailToZaSmetki) && settings.EnableMail == "1" && settings.EnableMailNaSmetka == "1")
            {
                if (rowCount > 0)
                {
                    string fileName = BrojNaSmetka + " - " + DateTime.Now.Month.ToString() + ".csv";
                    string subject = "Испечатена сметка број: " + BrojNaSmetka;
                    string text = "Датум : " + DateTime.Now.ToString(CultureInfo.InvariantCulture) +
                                  "\n Вкупен износ : " + lblSUm.Text;
                    StreamWriter wr = new StreamWriter(Tools.setExportPath(fileName, true));
                    wr.Write(viewArtikliVoSmetkaGridBig.ExportToCSV().ToString());
                    wr.Close();
                    Tools.SendMailDefault(Tools.setExportPath(fileName), subject, text, false, settings.GMailFrom,
                        settings.GMailToZaSmetki);
                }

            }
        }
        private void фискалнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            if (settings.PrasajZaZatvoranjeNaSmetka == true)
            {
                opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сакате да испечатите сметка "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                opc = DialogResult.Yes;
            }

            if (opc == DialogResult.Yes)
            {
                if (settings.ZadolzitelnoIzberiPartner == true)
                {
                    zbxPartner.Enabled = false;
                    if (zbxPartner.Value.Text == "99999" || string.IsNullOrEmpty(zbxPartner.Value.Text))
                    {
                        MessageBox.Show(Tools.PrevediPoraka(" Невалиден Партнер, скенирајте картичка "), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                NaloziZaSmetka(SmetkaID, false);

                IspecatiIZatvoriSmetkaSoSveFiskalna(false, 0);


            }
        }

        public void ZatvoriSmetka()
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                        com.Parameters.AddWithValue("@SoPopust", 0);
                        com.Parameters.AddWithValue("@Popust", 0);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        public bool PratiNaPrinterSmetkaA4_Vraboten(int SmetkaID, string vraboten)
        {
            using (var smetka = new Reporti.Smetka())
            {
                var smetkaRow = Tools.NajdiInfoZaSmetka(SmetkaID);
                if (Equals(null, smetkaRow)) return false;

                int partNerID = Tools.NajdiPartnerIDZaSmetka(SmetkaID);

                if (partNerID == -1)
                {
                    partNerID = Tools.PrazenStringToInt(Tools.NajdiInfoZaSifraPartner(settings.SifraKupuvac)["ID"].ToString());
                }

                tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri, partNerID);
                tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);
                viewArtikliVoSmetkaKASATableAdapter.Fill(fakturiDataSet.viewArtikliVoSmetkaKASA, SmetkaID);
                smetka.SetDataSource(fakturiDataSet);
                PrintPreview prev = new PrintPreview();
                smetka.SetParameterValue("SmetkaBroj", smetkaRow["Broj"]);
                smetka.SetParameterValue("UserName", vraboten);
                smetka.SetParameterValue("Datum", Convert.ToDateTime(smetkaRow["DatumPocetok"].ToString()).ToShortDateString());
                prev.ReportPreview.ReportSource = smetka;
                prev.ShowDialog();
                smetka.Dispose();
                return true;
            }
        }

        public bool PratiNaPrinterSmetkaA4(string usrName, string brojNaSmetka, int SmetkaID, int partNerID)
        {
            using (var smetka = new Reporti.Smetka())
            {
                SocuvajPartner(SmetkaID, partNerID);
                tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri, partNerID);
                tblFirmaTableAdapter.Fill(fakturiDataSet.tblFirma);
                viewArtikliVoSmetkaKASATableAdapter.Fill(fakturiDataSet.viewArtikliVoSmetkaKASA, SmetkaID);
                smetka.SetDataSource(fakturiDataSet);
                PrintPreview prev = new PrintPreview();
                smetka.SetParameterValue("SmetkaBroj", brojNaSmetka);
                smetka.SetParameterValue("UserName", usrName);
                smetka.SetParameterValue("Datum", DatumNaSmetka);
                prev.ReportPreview.ReportSource = smetka;
                prev.ShowDialog();
                smetka.Dispose();
                return true;
            }
        }

        private bool PratiNaPrinter(string usrName, string brojNaSmetka, bool pecatiDirektno, int kopiiZaSmetka)
        {
            try
            {
                ZapisiZabeleska();
                if (settings.pecatiA4 == true)
                {
                    if (kopiiZaSmetka > 0)
                    {

                        for (int i = 0; i < kopiiZaSmetka; i++)
                        {
                            using (var smetka = new Reporti.Smetka())
                            {
                                viewArtikliVoSmetkaKASATableAdapter.Fill(fakturiDataSet.viewArtikliVoSmetkaKASA, SmetkaID);
                                smetka.SetDataSource(fakturiDataSet);
                                PrintPreview prev = new PrintPreview();
                                smetka.SetParameterValue("SmetkaBroj", brojNaSmetka);
                                smetka.SetParameterValue("UserName", usrName);
                                smetka.SetParameterValue("Datum", DatumNaSmetka);
                                prev.ReportPreview.ReportSource = smetka;
                                if (!pecatiDirektno)
                                    prev.ShowDialog();
                                else smetka.PrintToPrinter(1, false, 1, 1);
                                smetka.Dispose();

                            }
                        }
                    }
                    return true;
                }
                else
                {
                    if (kopiiZaSmetka > 0)
                    {

                        for (int i = 0; i < kopiiZaSmetka; i++)
                        {
                            using (var smetka = new Reporti.SmetkaPrint())
                            {
                                viewArtikliVoSmetkaKASATableAdapter.Fill(fakturiDataSet.viewArtikliVoSmetkaKASA, SmetkaID);
                                smetka.SetDataSource(fakturiDataSet);
                                string infoZaPartner = txtPartner.Text;

                                PrintPreview prev = new PrintPreview();
                                smetka.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                smetka.SetParameterValue("partnerInfo", infoZaPartner);
                                smetka.SetParameterValue("vraboten", tmpConfigs.LogiranUserFullName);
                                prev.ReportPreview.ReportSource = smetka;
                                if (!pecatiDirektno)
                                    prev.ShowDialog();
                                else smetka.PrintToPrinter(1, false, 1, 1);
                                smetka.Dispose();
                            }
                        }
                    }

                    return true;
                }

            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool validatePartner()
        {
            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);

            if (zbxPartner.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    cardValue = string.Empty;
                    zbxPartner.zoomClear();
                    txtPartner.Clear();
                    zbxPartner.ret1 = info["ID"].ToString();
                    zbxPartner.Value.Text = info["Sifra"].ToString();
                    zbxPartner.Text = info["Naziv"].ToString();
                    txtPartner.Text = info["Naziv"] + @" ( " + info["Sifra"] + @" ) " + (info["EDB"] != null ? info["EDB"] : "");
                    tblPartneriTableAdapter.FillBy(fakturiDataSet.tblPartneri, Tools.PrazenStringToInt(zbxPartner.ret1));
                    return true;
                }
                else
                {
                    if (zbxPartner.Value.Text != "99999")
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

        public void SocuvajPartner(int partnerID, int smetkaID)
        {
            if (partnerID != -1)
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand("update tblSmetka set tblPartnerID = @partID where ID = @ID", con))
                    {
                        con.Open();
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ID", smetkaID);
                        com.Parameters.AddWithValue("@partID", zbxPartner.ret1);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
        }

        private void ZapisiZabeleska()
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("update tblSmetka set Zabeleska = @txt where ID = @ID", con))
                {
                    con.Open();
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", SmetkaID);
                    com.Parameters.AddWithValue("@txt", txtZabeleska.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
            validatePartner();
            if (!string.IsNullOrEmpty(zbxPartner.ret1))
            {
                int partnerID = Tools.PrazenStringToInt(zbxPartner.ret1);
                SocuvajPartner(partnerID, SmetkaID);
            }
        }

        private bool PratiNaPrinterGarantenLis(string UsrName, string BrojNaSmetka, string ArtikalNaziv, string Sifra, String DatumNaSmetka, int ArtikalID)
        {
            try
            {
                string uslov = File.ReadAllText("garancija.txt");
                int garancija = Tools.PrazenStringToInt(Tools.NajdiInfoZaSifraArtikal_artikli(Sifra)["DenoviZaGarancija"].ToString());
                string garancijaS = InputBox.Show("Денови за гаранација: ", "Внесете колку дена важи гаранцијата", garancija, true).Text;

                using (var GarantenList = new Reporti.GrList())
                {
                    GarantenList.SetDataSource(fakturiDataSet);
                    PrintPreview prev = new PrintPreview();
                    GarantenList.SetParameterValue("SmetkaBroj", BrojNaSmetka);
                    GarantenList.SetParameterValue("UserName", UsrName);
                    GarantenList.SetParameterValue("datum", DatumNaSmetka);
                    GarantenList.SetParameterValue("Garancija", garancijaS);
                    GarantenList.SetParameterValue("uslov", uslov);
                    prev.ReportPreview.ReportSource = GarantenList;
                    prev.ShowDialog();
                    GarantenList.Dispose();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                Tools.RaiseException(ex, true, "Проблем со печатарот !!!");
                return false;
            }
        }



        public void PresmetajLabeli()
        {
            brojNaArtikli.Text = "Број на Артикли: " + stavkiVoNalogKasaBindingSource.Count.ToString();
            txtIznosBezDDV.Text = "Износ без ДДВ: " + Tools.PrazenStringToDecimal_dec(fakturiDataSet.StavkiVoNalogKasa.Compute("SUM(IznosBezDDV)", "").ToString()).ToString("N2");
            txtIznosSoRabat.Text = "Износ на рабат: " + Tools.PrazenStringToDecimal_dec(fakturiDataSet.StavkiVoNalogKasa.Compute("SUM(Rabat)", "").ToString()).ToString("N2");
            txtPresmetanDDV.Text = "Пресметан ДДВ: " + Tools.PrazenStringToDecimal_dec(fakturiDataSet.StavkiVoNalogKasa.Compute("SUM(PresmetanDDV)", "").ToString()).ToString("N2");
            lblSUm.Text = Tools.PrazenStringToDecimal_dec(fakturiDataSet.StavkiVoNalogKasa.Compute("SUM(IZNOS)", "").ToString()).ToString("N2").Replace(",", ".");
        }

        private void stavkiVoNalogKasaBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            PresmetajLabeli();
        }


        string barcode = "";

        private void FrmKasa_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {

                e.Handled = true;
                //
                if (e.KeyCode.ToString().Contains("D") || e.KeyCode.ToString().Contains("Return"))
                {
                    var VnesGrid = viewArtikliVoSmetkaGridBig.Parent.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                    if (VnesGrid == null || VnesGrid.Visible == false)
                    {
                        barcode += e.KeyCode.ToString();
                        string formatiranbarcode = barcode.Replace("D", "").Replace("Return", "");
                        if (e.KeyCode == Keys.Enter && formatiranbarcode.Length >= 7)
                        {
                            using (txtBase b = new txtBase())
                            {
                                decimal kolicinaZaBarkod = 1;

                                b.Text = formatiranbarcode;
                                if (ValidateArtikal(b))
                                {
                                    string VagaBarkod = formatiranbarcode;
                                    string kolicinaVaga = string.Empty;

                                    VagaBarkod = formatiranbarcode.PadLeft(15, '0');
                                    if (VagaBarkod.StartsWith("00022"))
                                    {
                                        VagaBarkod = VagaBarkod.Substring(4, 5);
                                        kolicinaVaga = formatiranbarcode.Substring(6, 6);
                                        VagaBarkod = VagaBarkod.PadLeft(15, '0');
                                        b.Text = VagaBarkod;
                                        kolicinaZaBarkod = Tools.PrazenStringToDecimal_dec(kolicinaVaga) / 10000;


                                    }

                                    var info = Tools.NajdiInfoZaSifraArtikal(b.Text);
                                    string NazivNaArtikal = info["Naziv"].ToString();
                                    bool normativ = false;
                                    if (info["Normativ"].ToString().ToUpper() == "true".ToUpper())
                                    {
                                        normativ = true;
                                    }

                                    if (tgolemo.Checked)
                                    {
                                        dodadiArtikalVoNalog(Tools.PrazenStringToInt(info["ID"].ToString()), normativ, RabatZaCenaNaGolemo(Tools.PrazenStringToInt(info["ID"].ToString()), Tools.PrazenStringToDecimal_dec(info["ProdaznaCena"].ToString())), kolicinaZaBarkod);
                                    }
                                    else
                                    {
                                        dodadiArtikalVoNalog(Tools.PrazenStringToInt(info["ID"].ToString()), normativ, 0, kolicinaZaBarkod);
                                    }

                                    NaloziZaSmetka(SmetkaID);
                                    kolicinaZaBarkod = 1;
                                    viewArtikliVoSmetkaGridBig.gotoLastInsertedRow("Naziv", NazivNaArtikal);
                                }
                            }

                            barcode = string.Empty;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неправилен баркод, обидете се повторно");
                e.Handled = true;
                barcode = string.Empty;
                btnNovZapis.PerformClick();

            }
        }


        decimal ProdCenaNaArtikal = 0;
        int ArtikalIdZaVnes = 0;

        public bool ValidateArtikal(txtBase txtArtikalSearch)
        {

            var info = Tools.NajdiInfoZaSifraArtikal(txtArtikalSearch.Text);

            if (!Equals(info, null))
            {
                txtArtikalSearch.ret1 = info["ID"].ToString();
                txtArtikalSearch.ret2 = info["Sifra"].ToString();
                txtArtikalSearch.ret3 = info["Naziv"].ToString();
                txtArtikalSearch.ret4 = info["ProdaznaCena"].ToString();
                txtArtikalSearch.ret5 = info["DDVStapka"].ToString();
                txtArtikalSearch.ret6 = info["AltSifra"].ToString();
                ProdCenaNaArtikal = Tools.PrazenStringToDecimal_dec(info["ProdaznaCena"].ToString());
                ArtikalIdZaVnes = Tools.PrazenStringToInt(info["ID"].ToString());
                return true;
            }
            else
            {
                if (!txtArtikalSearch.IsTextEmpty())
                {
                    txtArtikalSearch.Text = string.Empty;
                    txtArtikalSearch.OpenEditSearch();
                    ValidateArtikal(txtArtikalSearch);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private Panel viewArtikliVoSmetkaGridBig_OnInsertDataShown(FlowLayoutPanel DataPanel)
        {
            FlowLayoutPanel DataControl = DataPanel;
            int VkupenWidthBezNaziv = 0;
            int NazivWidth = 0;

            foreach (txtBase item in DataPanel.Controls.OfType<txtBase>())
            {
                if (item.Name != "Naziv")
                    VkupenWidthBezNaziv += item.Width;

                if (item.Name == "Naziv")
                    NazivWidth = item.Width;
            }
            VkupenWidthBezNaziv = VkupenWidthBezNaziv - 5;

            if (NazivWidth > 150)
            {
                NazivWidth = DataPanel.Width - VkupenWidthBezNaziv;
                NazivWidth = NazivWidth - 80;
            }
            else
            {
                NazivWidth = 450;
            }

            txtBase Sifra = DataPanel.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra").FirstOrDefault();
            if (Sifra != null)
            {
                Sifra.Text = "";
                Sifra.formToOpen = "BSSR.Forms.frmPrebaruvanjeNaArtikliDev";
                Sifra.AssemblyStr = "BSSR";
                Sifra.ColumnName1 = "ID";
                Sifra.ColumnName2 = "Sifra";
                Sifra.ColumnName3 = "Naziv";
                Sifra.ColumnName4 = "ProdaznaCena";
                Sifra.ColumnName5 = "DDVStapka";
                Sifra.KeyDown += Sifra_KeyDown;
                Sifra.ReadODTextSoObjektEvent += Sifra_ReadODTextSoObjektEvent;
                Sifra.Validating += Sifra_Validating;

                txtBase Naziv = DataPanel.Controls.OfType<txtBase>().Where(c => c.Name == "Naziv").FirstOrDefault();
                Naziv.BackColor = Color.White;
                Naziv.ForeColor = Color.Black;
                Naziv.Size = new Size(NazivWidth, Naziv.Height);

                txtBase Kolicina = DataPanel.Controls.OfType<txtBase>().Where(c => c.Name == "Kolicina").FirstOrDefault();

                Kolicina.Leave += Kolicina_Leave;

                txtBase Rabat = DataPanel.Controls.OfType<txtBase>().Where(c => c.Name == "Rabat").FirstOrDefault();
                Rabat.Tag = Sifra.ret1;
                Rabat.Leave += Rabat_Leave;
                Rabat.KeyDown += Rabat_KeyDown;
            }
            return DataControl;
        }

        public decimal RabatZaCenaNaGolemo(int id, decimal regularnaCena)
        {

            decimal vnesenaSuma = Tools.ProdaznaCenaNaGolemo(id);
            decimal presmetanRabat = 0;
            //proveri ova
            if (vnesenaSuma > 0)
            {
                presmetanRabat = 100 - ((100 * vnesenaSuma) / regularnaCena);
            }

            return presmetanRabat;
        }

        private void Rabat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                var rbvalue = sender as txtBase;
                txtBase tIznos = rbvalue.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "ProdaznaCena").FirstOrDefault();
                int idRabat = rbvalue.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra").FirstOrDefault().ret1.toInt();
                decimal sumaZaNaplata = Tools.PrazenStringToDecimal_dec(tIznos.Text);
                string iznos = string.Format(" Цена: {0:C}", sumaZaNaplata);

                InputBoxResult opc = InputBox.ShowProcentRabat(iznos, true, sumaZaNaplata, false, true, 15.25F, false,idArtikal:idRabat);
                
                if (opc.ReturnCode == DialogResult.OK)
                {
                    rbvalue.Text = opc.RabatOut.ToString();
                }
            }

            if (e.KeyCode == Keys.C)
            {
                var rbvalue = sender as txtBase;
                txtBase tIznos = rbvalue.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "ProdaznaCena").FirstOrDefault();
                int idRabat = rbvalue.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra").FirstOrDefault().ret1.toInt();

                decimal sumaZaNaplata = Tools.PrazenStringToDecimal_dec(tIznos.Text);
                string iznos = string.Format(" Цена: {0:C}", sumaZaNaplata);

                InputBoxResult opc = InputBox.ShowProcentVnesCena(iznos, true, sumaZaNaplata, false, true, 15.25F, false, idArtikal: idRabat);
                if (opc.ReturnCode == DialogResult.OK)
                {
                    rbvalue.Text = opc.RabatOut.ToString();
                }
            }
        }

        private void Rabat_Leave(object sender, EventArgs e)
        {
            txtBase Rabat = sender as txtBase;
            FlowLayoutPanel panel = Rabat.Parent as FlowLayoutPanel;
            txtBase Naziv = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Naziv").FirstOrDefault();
            txtBase Sifra = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra").FirstOrDefault();
            txtBase Kolicina = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Kolicina").FirstOrDefault();
            Kalkuliraj(Sifra, Naziv, Tools.PrazenStringToDecimal_dec(Kolicina.Text), Tools.PrazenStringToDecimal_dec(Rabat.Text));
            txtBase CenaSoRabat = panel.Controls.OfType<txtBase>().Where(c => c.Name == CenaSoRabatIddv.Name).FirstOrDefault();
            if (CenaSoRabat.PrazenStringToDecimal_dec() > 0)
            {
                if (settings.ProverkaZaPremalaCena == true)
                {
                    if (CenaSoRabat.PrazenStringToDecimal_dec() < Tools.NajdiProsecnaNabavnaCenaZaArtikalID(Tools.PrazenStringToInt(Sifra.ret1)))
                    {
                        MessageBox.Show(Tools.PrevediPoraka("RabatPregolem"), "ВНИМАНИЕ !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Rabat.Focus();
                        Rabat.Select();
                    }
                }
            }
        }

        private void Kolicina_Leave(object sender, EventArgs e)
        {
            txtBase Kolicina = sender as txtBase;
            FlowLayoutPanel panel = Kolicina.Parent as FlowLayoutPanel;

            if (Kolicina.Text.Length <= 8)
            {

                txtBase Naziv = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Naziv").FirstOrDefault();
                txtBase Sifra = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra").FirstOrDefault();
                txtBase Rabat = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Rabat").FirstOrDefault();
                if (tgolemo.Checked)
                {
                    Rabat.Text = RabatZaCenaNaGolemo(ArtikalIdZaVnes, ProdCenaNaArtikal).ToString("N2");
                }
                Kalkuliraj(Sifra, Naziv, Tools.PrazenStringToDecimal_dec(Kolicina.Text), Tools.PrazenStringToDecimal_dec(Rabat.Text));
            }
            else
            {
                string textBarkod = Kolicina.Text;

                btnNovZapis.PerformClick();
                txtBase Sifra = panel.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra").FirstOrDefault();
                Sifra.Text = textBarkod;

            }
        }

        private void Sifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                viewArtikliVoSmetkaGridBig.PonistiVnes();
            }
            if (e.KeyCode == Keys.Space)
            {
                ((txtBase)sender).Text = string.Empty;
                ((txtBase)sender).OpenEditSearch();
            }
        }

        private void Sifra_ReadODTextSoObjektEvent(txtBase text)
        {
            text.Text = string.Empty;
            text.Text = text.ret2;
            ValidateArtikal(text);
        }

        public void Kalkuliraj(txtBase sifra, txtBase Naziv, decimal KolicinaD = 1, decimal RabatD = 0)
        {
            decimal ProdaznaCenaD = 0, DDVStapkaD = 0, CenaSoRabatD = 0, CenaBezDDVD = 0, PresmetanDDVD = 0, IznosD = 0, IznosBezDDVD = 0;

            txtBase Sifra2 = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Sifra2").FirstOrDefault();
            if (!Equals(Sifra2, null))
            {
                Sifra2.Text = sifra.ret6;
                Sifra2.TabStop = false;
                Sifra2.Enabled = false;
            }

            txtBase Kolicina = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Kolicina").FirstOrDefault();
            if (!Equals(Kolicina, null))
            {
                Kolicina.C_OnlyNumbers = true;
                Kolicina.Text = KolicinaD.ToString("N2");
            }

            txtBase Rabat = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Rabat").FirstOrDefault();
            if (!Equals(Rabat, null))
            {
                Rabat.Text = RabatD.ToString("N2");
            }

            txtBase ProdaznaCena = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "ProdaznaCena").FirstOrDefault();
            if (!Equals(ProdaznaCena, null))
            {
                ProdaznaCena.C_OnlyNumbers = true;
                ProdaznaCena.Text = sifra.ret4;
                ProdaznaCenaD = Tools.PrazenStringToDecimal_dec(sifra.ret4);
                ProdaznaCena.ReadOnly = true;
                ProdaznaCena.TabStop = false;
                ProdaznaCena.Enabled = false;
            }

            txtBase DDVStapka = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "DDVProcent").FirstOrDefault();
            if (!Equals(DDVStapka, null))
            {
                DDVStapka.C_OnlyNumbers = true;
                DDVStapka.Text = sifra.ret5;
                DDVStapkaD = Tools.PrazenStringToDecimal_dec(sifra.ret5);
                DDVStapka.ReadOnly = true;
                DDVStapka.TabStop = false;
                DDVStapka.Enabled = false;
            }

            txtBase CenaSoRabatIddv = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "CenaSoRabatIddv").FirstOrDefault();
            if (!Equals(CenaSoRabatIddv, null))
            {
                CenaSoRabatIddv.C_OnlyNumbers = true;
                CenaSoRabatD = (ProdaznaCenaD - (ProdaznaCenaD / 100) * RabatD);
                CenaSoRabatIddv.Text = CenaSoRabatD.ToString("N2");
                CenaSoRabatIddv.ReadOnly = true;
                CenaSoRabatIddv.TabStop = false;
                CenaSoRabatIddv.Enabled = false;
            }

            txtBase CenaBezDDV = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "CenaBezDDV").FirstOrDefault();
            if (!Equals(CenaBezDDV, null))
            {
                CenaBezDDVD = CenaSoRabatD / (1 + DDVStapkaD / 100);
                CenaBezDDV.Text = CenaBezDDVD.ToString("N2");
                CenaBezDDV.ReadOnly = true;
                CenaBezDDV.TabStop = false;
                CenaBezDDV.Enabled = false;
            }

            txtBase PresmetanDDV = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "PresmetanDDV").FirstOrDefault();
            if (!Equals(PresmetanDDV, null))
            {
                PresmetanDDVD = (CenaSoRabatD - CenaBezDDVD);
                PresmetanDDV.Text = PresmetanDDVD.ToString("N2");
                PresmetanDDV.ReadOnly = true;
                PresmetanDDV.TabStop = false;
                PresmetanDDV.Enabled = false;
            }

            txtBase IznosBezDDV = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "IznosBezDDV").FirstOrDefault();
            if (!Equals(IznosBezDDV, null))
            {
                IznosBezDDVD = (KolicinaD * CenaBezDDVD);
                IznosBezDDV.Text = IznosBezDDVD.ToString("N2");
                IznosBezDDV.ReadOnly = true;
                IznosBezDDV.TabStop = false;
                IznosBezDDV.Enabled = false;
            }

            txtBase Iznos = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Iznos").FirstOrDefault();
            if (!Equals(Iznos, null))
            {
                IznosD = (KolicinaD * CenaSoRabatD);
                Iznos.Text = IznosD.ToString("N2");
                Iznos.ReadOnly = true;
                Iznos.TabStop = false;
                Iznos.Enabled = false;
            }
        }

        public void dodadiArtikalVoNalog(int artikalID, bool normativ, decimal rabat, decimal Kol)
        {
            Task.Factory.StartNew(() =>
            {
                if (rabat <= 0)
                {
                    decimal RabatODAkcija = 0;

                    var rowSelected = Tools.ListaSoArtikliNaAkcija.Select("tblArtikalID=" + artikalID).FirstOrDefault();
                    if (rowSelected != null)
                    {
                        string rabatStr = rowSelected["Rabat"].ToString();
                        RabatODAkcija = Tools.PrazenStringToDecimal_dec(rabatStr);
                        rabat = RabatODAkcija;
                    }
                }
                using (var con = new SqlConnection(settings.konekcija))
                {
                    var sqlCom = string.Empty;
                    if (normativ)
                    {
                        sqlCom = "INSERT INTO tblNalogStavki (tblNalogID ,tblNomativID ,Kolicina, Rabat1) Values(@tblNalogID ,@tblArtikalID ,@Kolicina,@Rabat1)";
                    }
                    else
                    {
                        sqlCom = "INSERT INTO tblNalogStavki (tblNalogID ,tblArtikalID ,Kolicina, Rabat1) Values(@tblNalogID ,@tblArtikalID ,@Kolicina,@Rabat1)";
                    }
                    using (var com = new SqlCommand(sqlCom, con))
                    {
                        try
                        {
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("@tblNalogID", NalogIDZaInsert);
                            com.Parameters.AddWithValue("@tblArtikalID", artikalID);
                            com.Parameters.AddWithValue("@Kolicina", Kol);
                            com.Parameters.AddWithValue("@Rabat1", rabat);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            return;
                        }
                    }
                }
            });

            NaloziZaSmetka(SmetkaID, false);
        }

        private void Sifra_Validating(object sender, CancelEventArgs e)
        {
            txtBase sifra = sender as txtBase;
            if (sifra.Parent.Visible == false)
            {
                return;
            }

            if (ValidateArtikal(sifra))
            {
                txtBase Naziv = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Naziv").FirstOrDefault();
                txtBase Kolicina = sifra.Parent.Controls.OfType<txtBase>().Where(c => c.Name == "Kolicina").FirstOrDefault();
                if (!Equals(Naziv, null))
                {
                    Naziv.Text = sifra.ret3;
                    Naziv.ReadOnly = true;
                    Naziv.TabStop = false;
                    Naziv.Enabled = false;
                }

                Kalkuliraj(sifra, Naziv);
                Kolicina.Focus();
                Kolicina.Select();
            }
            else
            {
                e.Cancel = true;
            }
        }


        private void zbxPartner_Validated(object sender, CancelEventArgs e)
        {
            validatePartner();
        }

        private void btnPecatiIZatvori_Click(object sender, EventArgs e)
        {
            NaloziZaSmetka(SmetkaID, false);
            IspecatiIZatvoriSmetkaSoSveFiskalnaBezPrasanja(false, 0);
        }

        private void btnGarancija_Click(object sender, EventArgs e)
        {
            if (Equals(null, stavkiVoNalogKasaBindingSource.Current))
            {
                return;
            }
            int artikalID = Tools.PrazenStringToInt(((DataRowView)stavkiVoNalogKasaBindingSource.Current)["ArtikalID"].ToString());

            string ArtikalNaziv = ((DataRowView)stavkiVoNalogKasaBindingSource.Current)["Naziv"].ToString();
            string ArtikalSifra = ((DataRowView)stavkiVoNalogKasaBindingSource.Current)["Sifra"].ToString();

            DialogResult opc = DialogResult.No;
            opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека да испечатите гарантен лист за \n Артиклот: " + ArtikalNaziv), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
                PratiNaPrinterGarantenLis(tmpConfigs.LogiranUserFullName, BrojNaSmetka, ArtikalNaziv, ArtikalSifra, DatumNaSmetka, artikalID);
        }



        private void btnNovaSmetka_Click(object sender, EventArgs e)
        {
            KreirajNovaSmetkaOdKasa();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tMalo.Checked = true;
            tgolemo.Checked = false;
        }

        private void tgolemo_Click(object sender, EventArgs e)
        {
            tMalo.Checked = false;
            tgolemo.Checked = true;
        }

        private void frmKasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M && e.Shift)
            {

                barcode = string.Empty;
                if (tMalo.Checked == true) tgolemo.PerformClick();
                else
                if (tgolemo.Checked == true) tMalo.PerformClick();
                e.SuppressKeyPress = false;

            }
            if (e.KeyCode == Keys.Escape)
            {
                viewArtikliVoSmetkaGridBig.PonistiVnes();
            }
        }

        private void btnIzbrisiSe_Click(object sender, EventArgs e)
        {
            DialogResult opc = DialogResult.Yes;
            opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да избришете ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (opc == DialogResult.Yes)
            {
                IzbrisiSeODSmetka(SmetkaID);
                NaloziZaSmetka(SmetkaID, false);
            }

        }

        private void viewArtikliVoSmetkaGridBig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                viewArtikliVoSmetkaGridBig.PonistiVnes();
            }
            if (e.KeyCode == Keys.Down)
            {
                bindingNavigatorMoveNextItem.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                bindingNavigatorMovePreviousItem.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                if (!Equals(null, stavkiVoNalogKasaBindingSource.Current))
                {
                    int artikal = Tools.PrazenStringToInt(((DataRowView)stavkiVoNalogKasaBindingSource.Current)["ArtikalID"].ToString());
                    int nalog = Tools.PrazenStringToInt(((DataRowView)stavkiVoNalogKasaBindingSource.Current)["NalogID"].ToString());
                    decimal rabat = Tools.PrazenStringToDecimal_dec(((DataRowView)stavkiVoNalogKasaBindingSource.Current)["Rabat"].ToString());
                    decimal MomentalnaKolicna = Tools.PrazenStringToDecimal_dec(((DataRowView)stavkiVoNalogKasaBindingSource.Current)["Kolicina"].ToString());
                    var NovaKolicina = InputBox.Show("Количина: ", "Промена на внесена количина на артикал ", MomentalnaKolicna, true);

                    if (NovaKolicina.ReturnCode == DialogResult.OK)
                    {
                        IzbrisiCelosnoArtikal(artikal);
                        dodadiArtikalVoNalog(artikal, false, rabat, Tools.PrazenStringToDecimal_dec(NovaKolicina.Text));
                        NaloziZaSmetka(SmetkaID, false);

                    }
                }
            }
            if (e.KeyCode == Keys.K && e.Shift == true)
            {
                btnKalkulator.PerformClick();
            }

            if (e.KeyCode == Keys.Subtract && e.Shift == true)
            {
                DialogResult opc = DialogResult.Yes;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да сторнирате ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (opc == DialogResult.Yes)
                {
                    Tools.KreirajDokumentOdSmetka(SmetkaID, BssBase.tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi);

                    IzbrisiSeODSmetka(SmetkaID);
                    NaloziZaSmetka(SmetkaID, false);
                }
            }
            e.SuppressKeyPress = true;
        }

        private void btnKalkulator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
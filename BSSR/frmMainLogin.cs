using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using AsyncClientServerLib.Message;
using AsyncClientServerLib.Server;

using BSS;

using BssBase;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using SocketServerLib.SocketHandler;

namespace BSSR
{
    public partial class frmMainLogin : Form
    {
        private string[] Databases;
        private string[] Server;
        public String GlavnaFormConnectionString = string.Empty;

        private Utility.ModifyRegistry.ModifyRegistry RegistryData;

        private SqlConnection LoginConnection;
        private SqlCommand LoginCommand;

        public void SetirajKonekcija(string DatabaseUserName, string DatabasePassword, string server = null, string databaseName = null)
        {
            if (!(DatabaseUserName.Equals("N/A") && !DatabasePassword.Equals("N/A")) || ((string.IsNullOrEmpty(DatabasePassword) && string.IsNullOrEmpty(DatabaseUserName))))
            {
                GlavnaFormConnectionString = string.Format(@"TrustServerCertificate=True;Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3};Timeout={4};", server == null ? cmbServer.Text : server, databaseName == null ? txtBaza.Text : databaseName, base64ToText(DatabaseUserName), base64ToText(DatabasePassword), settings.ConnectionTimeOut);
            }
            else
            {
                GlavnaFormConnectionString = String.Format(@"TrustServerCertificate=True;Persist Security Info=True;Data Source={0};Initial Catalog={1};Timeout={2};", server == null ? cmbServer.Text : server, databaseName == null ? txtBaza.Text : databaseName, BssBase.settings.ConnectionTimeOut);
            }
            BssBase.tmpConfigs.databaseName = txtBaza.Text;
            BssBase.tmpConfigs.ServerName = cmbServer.Text;
            BssBase.settings.DebugMode = false;


            BssBase.settings.FirmaNaziv = RegistryData.Read("ImeNaFirma");
            BssBase.settings.PrinterPathDefault = RegistryData.Read("DefaultPrinter");
            BssBase.settings.PrinterSecond = RegistryData.Read("PrinterZaKujna");

            Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
            MReport.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

            MKelner.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
            MFakturi.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
            MMaterijalno.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

            Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

            BssBase.settings.konekcija = GlavnaFormConnectionString;
            BssBase.settings.DebugMode = System.Diagnostics.Debugger.IsAttached;
            if (BssBase.tmpConfigs.databaseName.StartsWith("BSG_") || BssBase.tmpConfigs.databaseName.ToLower().Contains("garden"))
            {
                Application.Exit();
            }

        }
        public void ProveriKonekcijaSoDatabaza(string connection)
        {
            bool isConnectionFine = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand com = new SqlCommand("Select ID from tblFirma", con))
                {
                    con.Open();
                    var result = com.ExecuteScalar().ToString();
                    if (string.IsNullOrEmpty(result)) isConnectionFine = false;

                    isConnectionFine = true;
                }

            }
            catch (SqlException sqlException)
            {
                Tools.PrevediSQLException(sqlException, "Pogresna konekcija so databaza");
                isConnectionFine = false;
            }
            finally
            {
                if (isConnectionFine == false)
                {
                    Tools.RaiseException(new Exception("Nema pristap do glavnata tabela"), true, "Pogresna konfiguracija");
                    Environment.Exit(Environment.ExitCode);
                }
            }

        }

        private bool loading = false;
        private string regName = string.Empty;
        private int regFirma = 1;
        public frmMainLogin(string registriAcces, int firma = 1)
        {
            regName = registriAcces;
            regFirma = firma;
            ReloadForm(registriAcces, firma);
        }

        private void ReloadForm(string registriAcces, int firma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();

            BssBase.settings.firmaId = firma;
            BssBase.settings.RegPath = "SOFTWARE\\" + registriAcces.ToUpper();
            RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData.SubKey = BssBase.settings.RegPath;
            loading = true;
            InitializeComponent();


            if (RegistryData.Read("IMENAFIRMA").ToString() == "N/A" || registriAcces == "NewSetup")
            {
                tabControlBase1.TabPages.Remove(tabPage1);
                tabControlBase1.TabPages.Remove(tabPage2);
                tabControlBase1.TabPages.Remove(tabPage3);
                btnOk.Enabled = false;
                UserName.Enabled = false;
                Password.Enabled = false;

                return;

            }
            else
            {
                tabControlBase1.TabPages.Remove(tabPage4);
            }

            ReloadConfigsAndUi(RegistryData);
        }

        private void ReloadConfigsAndUi(Utility.ModifyRegistry.ModifyRegistry regData = null)
        {
            RegistryData = regData;
            ServerStarted = false;

            BssBase.settings.InitSettings.ReloadAllConfigs(regData);

            UpdateGUIForLogin();

            SetirajDenojZaPrikazNaPodatociSporedDatum();

            var DatabaseUserName = regData.Read("DatabaseUserName");
            var DatabasePassword = regData.Read("DatabasePassword");
            SetirajKonekcija(DatabaseUserName, DatabasePassword);
            ProveriKonekcijaSoDatabaza(BssBase.settings.konekcija);

            cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");
            int idObjekt = Tools.PrazenStringToInt(regData.Read("tblObjektiID"), 1);
            cmbObjekt.SelectirajItem(idObjekt);
            BssBase.settings.MomentalenObjektID = idObjekt;
            cmbObjekt.Enabled = BssBase.settings.UserAndObjectCheck;

            MKelner.Forms.cfg.Slike = new MKelner.Forms.ImageHelper();
            NapolniScreenSoKorisnici();

            Password.Select();
            Password.Focus();


            BssBase.UpdateSettings.currentVersion = ProductVersion;
            regData.Write("currentVersion", BssBase.UpdateSettings.currentVersion);
            loading = false;

            if (!UpdateSettings.enableUpdate)
            {
                tabControlBase1.TabPages.Remove(tabPage3);
            }
        }

        private void UpdateGUIForLogin()
        {
            UserName.Text = RegistryData.Read("LastUser");
            Databases = RegistryData.Read("Database").ToString().Split(';');
            Server = RegistryData.Read("Server").ToString().Split(';');


            Text = $"[{RegistryData.SubKey}] BSSR © 2012 - 2025 Верзија 7.0 {Application.ProductVersion}";
            txtBaza.Items.Clear();
            cmbServer.Items.Clear();
            foreach (var item in Databases)
            {
                txtBaza.Items.Add(item);
                txtBaza.SelectedIndex = 0;
            }

            if (txtBaza.Items.Count == 1)
            {
                txtBaza.Enabled = false;
            }
            else txtBaza.Enabled = true;

            foreach (var item in Server)
            {
                cmbServer.Items.Add(item);
                cmbServer.SelectedIndex = 0;
            }

            if (cmbServer.Items.Count == 1)
            {
                cmbServer.Enabled = false;
            }
            else
            {
                cmbServer.Enabled = true;
            }
            txtJazik.SelectedIndex = 0;
            if (settings.TipNaPrograma == "Documents789")
            {
                txtJazik.Enabled = false;
            }

            if (!String.IsNullOrEmpty(MKelner.Forms.cfg.PatekaDoLogo) && !MKelner.Forms.cfg.PatekaDoLogo.Contains("N/A"))
            {
                if (File.Exists(MKelner.Forms.cfg.PatekaDoLogo))
                {
                    pictureBox1.Load(MKelner.Forms.cfg.PatekaDoLogo);
                    flKorisnici.BackgroundImage = Image.FromFile(MKelner.Forms.cfg.PatekaDoLogo);
                    flKorisnici.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private static void SetirajDenojZaPrikazNaPodatociSporedDatum()
        {

            try
            {
                if (DateTime.Now.Day > Tools.PrazenStringToInt(BssBase.settings.DaysToDisplayData))
                {
                    BssBase.settings.DateTimeOd = Convert.ToDateTime(string.Format("{0}-{1}-{2} 00:00:00",
                        DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day - Tools.PrazenStringToInt(BssBase.settings.DaysToDisplayData)));
                }
                else
                {
                    if (DateTime.Now.Month != 1)
                    {
                        BssBase.settings.DateTimeOd = Convert.ToDateTime(string.Format("{0}-{1}-{2} 00:00:00",
                            DateTime.Now.Year, DateTime.Now.Month - 1,
                            30 - Tools.PrazenStringToInt(BssBase.settings.DaysToDisplayData)));
                    }
                    else
                    {
                        BssBase.settings.DateTimeOd = Convert.ToDateTime(string.Format("{0}-{1}-{2} 00:00:00",
                            DateTime.Now.Year, DateTime.Now.Month,
                            30 - Tools.PrazenStringToInt(BssBase.settings.DaysToDisplayData)));
                    }
                }

                BssBase.settings.DateTimeDo = Convert.ToDateTime(string.Format("{0}-{1}-{2} 23:59:59",
                    DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            }
            catch (Exception ex)
            {
                BssBase.settings.DateTimeDo = DateTime.Now;
                BssBase.settings.DateTimeOd = DateTime.Now;
                Tools.LogException(ex.Message, ex);
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public void NapolniListaSoArtikliNaAkcija()
        {
            Tools.ListaSoArtikliNaAkcija = new DataTable();
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(" select * from tblAkcijaNaArtikal where CAST(@Datum as DATE) Between DatumPocetok and DatumKraj order by ID  desc", con))
                {
                    con.Open();
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Datum", DateTime.Now);
                    Tools.ListaSoArtikliNaAkcija.Load(com.ExecuteReader());

                }

            }
        }

        private  void btnOk_Click(object sender, EventArgs e)
        {
            dbFunctions.DbArtikli = null;
            var DatabaseUserName = RegistryData.Read("DatabaseUserName");
            var DatabasePassword = RegistryData.Read("DatabasePassword");
            SetirajKonekcija(DatabaseUserName, DatabasePassword);

            ProveriKonekcijaSoDatabaza(BssBase.settings.konekcija);

            BSS.DBAccess.CheckForDatabaseChanges(RegistryData);

            // cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");

            BssBase.settings.MomentalenObjektID = Tools.PrazenStringToInt(cmbObjekt.SelectedValue.ToString());
            BssBase.tmpConfigs.NazivNaObjket = cmbObjekt.Text;
            cmbObjekt.Enabled = BssBase.settings.UserAndObjectCheck;
            NapolniListaSoArtikliNaAkcija();
            BssBase.settings.CultureInfoString = "mk-MK";


            if (txtJazik.SelectedIndex == 0)
            {
                BssBase.settings.jazik = "mk";
                BssBase.settings.CultureInfoString = "mk-MK";

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
                Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();

            }

            if (txtJazik.SelectedIndex == 1)
            {
                BssBase.settings.jazik = "mk";
                BssBase.settings.CultureInfoString = "mk-MK";

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
                Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();

            }

            if (txtJazik.SelectedIndex == 2)
            {
                BssBase.settings.jazik = "mk";
                BssBase.settings.CultureInfoString = "mk-MK";

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
                Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            }
            
            

            try
            {
                LoginConnection = new SqlConnection(BssBase.settings.konekcija);
                var ValidationPass = true;

                foreach (Control control in GroupLogin.Controls.OfType<txtBase>())
                {
                    if (control is BssBase.txtBase)
                    {
                        if (control.BackColor == Color.Tomato || control.BackColor == Color.Red)
                        {
                            control.Focus();
                            ValidationPass = false;
                            break;
                        }
                    }
                }

                if (UserName.IsTextEmpty() || Password.IsTextEmpty())
                {
                    ValidationPass = false;
                }
                if (ValidationPass)
                {
                    string sql =
                        "SELECT * FROM tblUsers WHERE ((UserName=@User AND Password=@Pass) OR  (UserName=@User2 AND Password=@Pass2)) AND (Status is null OR Status = 0 )";

                    if (BssBase.settings.UserAndObjectCheck)
                    {
                        sql =
                            "SELECT * FROM tblUsers WHERE ((UserName=@User AND Password=@Pass) OR  (UserName=@User2 AND Password=@Pass2)) AND (tblObjektId = @objektID OR tblObjektId is null)";
                    }
                    LoginCommand = new SqlCommand(sql, LoginConnection);
                    LoginCommand.Parameters.AddWithValue("@User", UserName.Text);
                    LoginCommand.Parameters.AddWithValue("@Pass", Password.Text);
                    LoginCommand.Parameters.AddWithValue("@User2", Tools.ConvertToLatinica(UserName.Text));
                    LoginCommand.Parameters.AddWithValue("@Pass2", Tools.ConvertToLatinica(Password.Text));
                    if (BssBase.settings.UserAndObjectCheck)
                    {
                        LoginCommand.Parameters.AddWithValue("@objektID", BssBase.settings.MomentalenObjektID);
                    }

                    LoginConnection.Open();

                    var LoginChecker = LoginCommand.ExecuteReader();
                    var user = string.Empty;
                    var User_Id = -1;
                    var UserFullName = string.Empty;
                    var UserLevel = -1;
                    if (!Equals(null, cmbObjekt.SelectedValue))
                    {
                        BssBase.settings.MomentalenObjektID = Tools.PrazenStringToInt(cmbObjekt.SelectedValue.ToString(), 1);
                    }

                    if (LoginChecker.HasRows)
                    {
                        LoginChecker.Read();
                        int status = Tools.PrazenStringToInt(LoginChecker["Status"].ToString(), 0);
                        User_Id = Tools.PrazenStringToInt(LoginChecker["Id"].ToString());
                        user = LoginChecker["Username"].ToString();
                        UserLevel = Tools.PrazenStringToInt(LoginChecker["NivoNaAdministracija"].ToString());
                        UserFullName = LoginChecker["FullName"].ToString();
                        BssBase.tmpConfigs.LogiranUserFullName = UserFullName;
                        BssBase.settings.UserRole = "ADMIN";
                        BssBase.settings.UserId = User_Id;
                        LoginConnection.Close();

                        Hide();
                        if (status == 9)
                        {
                            BssBase.settings.PrasajZaFiskalna = false;
                            BssBase.settings.PecatFiskalna = false;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(RegistryData.Read("PrasajZaFiskalna", "true")))
                            {
                                BssBase.settings.PrasajZaFiskalna = false;
                            }
                            else
                            {
                                BssBase.settings.PrasajZaFiskalna = RegistryData.Read("PrasajZaFiskalna").ToUpper().Contains("TRUE");
                            }

                            if (string.IsNullOrEmpty(RegistryData.Read("PecatiFiskalna", "true")))
                            {
                                BssBase.settings.PecatFiskalna = false;
                            }
                            else
                            {
                                BssBase.settings.PecatFiskalna = RegistryData.Read("PecatiFiskalna").ToUpper().Contains("TRUE");
                            }
                        }

                        if (!UserName.Text.Trim().ToLower().Equals("spiro") && !BssBase.settings.DebugMode)
                            RegistryData.Write("LastUser", UserName.Text);



                        SetirajPrivilegiiNaKorisnik(UserFullName, UserLevel);
                       
                    }
                    else
                    {
                        LoginConnection.Close();
                        if (!BssBase.settings.UserAndObjectCheck)
                            MessageBox.Show(Tools.PrevediPoraka("Погрешни податоци"));
                        else
                        {
                            MessageBox.Show(Tools.PrevediPoraka("Погрешни Податоци или немате пристап до овој објект"));
                        }
                        UserName.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Show();
                Tools.PrevediSQLException(ex);
                return;
            }
        }

    
        private void SetirajPrivilegiiNaKorisnik(string UserFullName, int UserLevel)
        {
            BssBase.settings.UserLevel = UserLevel;


            switch (UserLevel)
            {
                case 6:
                case 9:
                    using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                    {
                        BssBase.settings.Sesija = sesija.Sesija;
                        if (RegistryData.Read("PrikaziTastaturaSettings").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        var GlavnaForma = new Forms.frmSettings(GlavnaFormConnectionString, BssBase.settings.UserId, UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                        GlavnaForma.ShowDialog();
                        Show();
                        if (RegistryData.Read("PrikaziTastaturaLogin").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        Password.Text = string.Empty;
                        Show();
                        sesija.StopSession();

                    }
                    break;

                case 2:
                    using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                    {
                        timer1.Enabled = false;
                        // var GlavnaForma = new MNetCaffe.frmControl();
                        //GlavnaForma.ShowDialog();
                        timer1.Enabled = true;
                        Show();
                        sesija.StopSession();
                    }
                    break;

                case 1:
                case 3:
                    using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                    {
                        BssBase.settings.Sesija = sesija.Sesija;
                        var GlavnaForma = new MKelner.Forms.frmKelner(UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                        GlavnaForma.ShowDialog();
                        Show();
                        if (RegistryData.Read("PrikaziTastaturaLogin").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        Password.Text = string.Empty;
                        sesija.StopSession();
                    }
                    break;

                case 4:
                    using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                    {
                        BssBase.settings.Sesija = sesija.Sesija;
                        if (RegistryData.Read("PrikaziTastaturaSettings").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        var GlavnaForma = new Forms.frmSettings(GlavnaFormConnectionString, BssBase.settings.UserId, UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                        GlavnaForma.ShowDialog();
                        Show();
                        if (RegistryData.Read("PrikaziTastaturaLogin").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        Password.Text = string.Empty;

                        sesija.StopSession();
                    }
                    break;

                case 250:
                    using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                    {
                        BssBase.settings.Sesija = sesija.Sesija;

                        if (RegistryData.Read("PrikaziTastaturaSettings").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }

                        var GlavnaForma = new MKelner.Forms.frmKelner(UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                        GlavnaForma.ShowDialog();

                        Show();

                        if (RegistryData.Read("PrikaziTastaturaLogin").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }

                        Password.Text = string.Empty;

                        sesija.StopSession();
                    }
                    break;

                case 0:
                    using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                    {
                        BssBase.settings.Sesija = sesija.Sesija;
                        if (RegistryData.Read("PrikaziTastaturaSettings").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        var GlavnaForma = new MKelner.Forms.frmKelner(UserFullName, UserLevel, true) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                        GlavnaForma.ShowDialog();
                        Show();
                        if (RegistryData.Read("PrikaziTastaturaLogin").Contains("1"))
                        {
                            BssBase.settings.OnScreenKeyBoard = true;
                        }
                        else
                        {
                            BssBase.settings.OnScreenKeyBoard = false;
                        }
                        Password.Text = string.Empty;

                        sesija.StopSession();
                    }
                    break;
                default:
                    MessageBox.Show(Tools.PrevediPoraka("Погрешни сетиран корисник"));
                    break;
            }

            if (UserName.Text.Trim().ToLower().Equals("spiro") && !BssBase.settings.DebugMode)
            {
                UserName.Text = RegistryData.Read("LastUser");
            }
        }

        private string textToBase64(string sAscii)
        {
            var encoding = new System.Text.ASCIIEncoding();
            var bytes = encoding.GetBytes(sAscii);
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }

        private string base64ToText(string sbase64)
        {
            var bytes = Convert.FromBase64String(sbase64);
            var encoding = new System.Text.ASCIIEncoding();
            return encoding.GetString(bytes, 0, bytes.Length);
        }

        private void frmMainLogin_Load(object sender, EventArgs e)
        {

            this.Focus();
            Password.Focus();
            if (Tools.NajdiInfoZaFirma(1)["txIDFirma"].ToString().Equals("514285_P"))
            {
                MessageBox.Show("Имате заостанат долг ве молиме да го подмирите што е можно поскоро или да го побарате девелоперот");
            }

            if (Tools.NajdiInfoZaFirma(1)["txIDFirma"].ToString().Equals("514285_X"))
            {
                MessageBox.Show("Вашата лиценца за користење на апликцијата истече, ве молиме контактирајте  го девелоперот ");
                Application.Exit();
            }

            Password.PasswordChar = '*';

            if (BssBase.settings.PrikaziDataBazaIJazik == "false")
            {
                cmbObjekt.Visible = false;
                txtJazik.Visible = false;
                txtBaza.Visible = false;
                bsslabel3.Visible = false;
                bsslabel4.Visible = false;
                bsslabel5.Visible = false;
            }
            else
            {
                cmbObjekt.Visible = true;
                txtJazik.Visible = true;
                txtBaza.Visible = true;
                bsslabel3.Visible = true;
                bsslabel4.Visible = true;
                bsslabel5.Visible = true;
                txtJazik.SelectedIndex = Tools.PrazenStringToInt(BssBase.settings.defaultJazik);
            }
            if (BssBase.settings.SocketServer == "true")
            {
                StartServer();
            }
            if (BssBase.settings.TipNaPrograma == "8889")
            {
                timer1.Enabled = true;
            }
            if (BssBase.settings.AktivenTabNaLogin != -1)
            {
                tabControlBase1.SelectedTab = tabControlBase1.TabPages[BssBase.settings.AktivenTabNaLogin];
            }
            else
            {
                tabControlBase1.TabPages.Remove(tabPage2);
            }
            if (BssBase.settings.TipNaPrograma == "10KulaB")
            {
                tabControlBase1.TabPages.Remove(tabPage2);
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMainLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.D && e.Control && e.Shift)
            {

                BssBase.Forms.frmSql sql = new BssBase.Forms.frmSql();
                sql.Text = BssBase.settings.konekcija;
                sql.ShowDialog();
            }
            if (e.Control && e.Alt && e.KeyCode == Keys.End)
            {
                tabControlBase1.TabPages.Add(tabPage4);
                tabControlBase1.TabPages.Remove(tabPage1);
                tabControlBase1.TabPages.Remove(tabPage2);
                tabControlBase1.TabPages.Remove(tabPage3);
                btnOk.Enabled = false;
                UserName.Enabled = false;
                Password.Enabled = false;
            }
            if (e.KeyCode == Keys.F12)
            {
                bsslabel3.Visible = !bsslabel3.Visible;
                cmbObjekt.Visible = !cmbObjekt.Visible;
            }
            if (e.KeyCode == Keys.F10)
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да ги превземете новите подесувања ?"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    string DatabaseUserName, DatabasePassword, dbName;
                    DatabasePassword = "nirvana";
                    DatabaseUserName = "spiro";
                    dbName = "BSSRC";
                    GlavnaFormConnectionString = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}; TrustServerCertificate=True", RegistryData.Read("Server"), dbName, DatabaseUserName, DatabasePassword);
                    BssBase.settings.konekcija = GlavnaFormConnectionString;
                    Text = "BSSR © 2012 - Верзија  C" + Application.ProductVersion;
                    Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    MReport.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

                    MKelner.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    MFakturi.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    MMaterijalno.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    BssBase.settings.PrasajZaFiskalna = false;
                    BssBase.settings.PecatFiskalna = false;
                    Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

                    BssBase.settings.konekcija = GlavnaFormConnectionString;
                }
                else
                {
                    //BssBase.settings.OnScreenKeyBoard = true;
                    var DatabaseUserName = RegistryData.Read("DatabaseUserName");
                    var DatabasePassword = RegistryData.Read("DatabasePassword");
                    Databases = RegistryData.Read("Database").ToString().Split(';');
                    Text = "BSSR © 2012 - Верзија " + Application.ProductVersion;
                    GlavnaFormConnectionString = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", RegistryData.Read("Server"), Databases.First(), base64ToText(DatabaseUserName), base64ToText(DatabasePassword));
                    BssBase.settings.konekcija = GlavnaFormConnectionString;
                    Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    MReport.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

                    MKelner.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    MFakturi.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    MMaterijalno.Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    if (string.IsNullOrEmpty(RegistryData.Read("PrasajZaFiskalna", "true")))
                    {
                        BssBase.settings.PrasajZaFiskalna = false;
                    }
                    else
                    {
                        BssBase.settings.PrasajZaFiskalna = RegistryData.Read("PrasajZaFiskalna").ToUpper().Contains("TRUE");
                    }

                    if (string.IsNullOrEmpty(RegistryData.Read("PecatiFiskalna", "true")))
                    {
                        BssBase.settings.PecatFiskalna = false;
                    }
                    else
                    {
                        BssBase.settings.PecatFiskalna = RegistryData.Read("PecatiFiskalna").ToUpper().Contains("TRUE");
                    }
                    Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;
                    Text = "BSSR © 2012 - Верзија  " + Application.ProductVersion;
                    BssBase.settings.konekcija = GlavnaFormConnectionString;
                }
            }
        }

        private void txtBaza_Leave(object sender, EventArgs e)
        {
        }

        private void txtBaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBaza.SelectedIndex != -1 && loading == false)
            {
                var DatabaseUserName = RegistryData.Read("DatabaseUserName");
                var DatabasePassword = RegistryData.Read("DatabasePassword");
                SetirajKonekcija(DatabaseUserName, DatabasePassword);
                cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");

                int idObjekt = Tools.PrazenStringToInt(RegistryData.Read("tblObjektiID"), 1);
                cmbObjekt.SelectirajItem(idObjekt);
                BssBase.settings.MomentalenObjektID = idObjekt;
                cmbObjekt.Enabled = BssBase.settings.UserAndObjectCheck;
                Password.Focus();
            }

            Password.Focus();
        }

        private BasicSocketServer server = null;
        private Guid serverGuid = Guid.Empty;
        public bool ServerStarted = false;
        public void StartServer()
        {
            if (ServerStarted) return;
            try
            {
                serverGuid = Guid.NewGuid();
                server = new BasicSocketServer();
                server.ReceiveMessageEvent += new ReceiveMessageDelegate(server_ReceiveMessageEvent);
                server.ConnectionEvent += new SocketConnectionDelegate(server_ConnectionEvent);
                server.CloseConnectionEvent += new SocketConnectionDelegate(server_CloseConnectionEvent);
                server.Init(new IPEndPoint(IPAddress.Any, 8100));
                server.StartUp();
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Tools.RaiseException(ex, true, "Серверот е веќе отворен нова конекција неможе да се воспостави, проверете дали имате уклучено две апликации");
            }
            catch (Exception ex)
            {
                Tools.RaiseException(ex);
            }
            ServerStarted = true;
        }

        private void server_CloseConnectionEvent(AbstractTcpSocketClientHandler handler)
        {
            // MessageBox.Show(string.Format("A client is disconnected from the server"), "Socket Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void server_ConnectionEvent(AbstractTcpSocketClientHandler handler)
        {
            DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("", "Клиентот се конектираше");
            alertControl1.Show(ActiveForm);
        }

        private void server_ReceiveMessageEvent(AbstractTcpSocketClientHandler handler, SocketServerLib.Message.AbstractMessage message)
        {
            BasicMessage receivedMessage = (BasicMessage)message;
            byte[] buffer = receivedMessage.GetBuffer();
            string s = System.Text.Encoding.Unicode.GetString(buffer);
            try
            {
                if (s.StartsWith("docPresnocnica:"))
                {
                    s = s.Replace("docPresnocnica:", "");
                    Functions.SrvFcuntions.ObrabotiKomanda(s, "Преносница");
                    MessageBox.Show("Добивте нов прием по електронски пат, одете во обработка на податоци - > Електронски прием на документи ", "Преносница ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }

            if (s.StartsWith("PobarajDokument:"))
            {
                Functions.SrvFcuntions.PrepratiNeprateni(s, BssBase.tmpConfigs.VPNNameServer);

                return;
            }
            if (s.StartsWith("M:"))
            {
                s = s.Replace("M:", "");
                MessageBox.Show(s.ToString());
                return;
            }

            if (s.StartsWith("C:"))
            {
                s = s.Replace("C:", "");
                Functions.SrvFcuntions.ObrabotiKomanda(s);
                return;
            }

            if (s.StartsWith("D:"))
            {
                s = s.Replace("D:", "");
                Functions.SrvFcuntions.ObrabotiKomanda(s);
                return;
            }
        }

        public void StopServer()
        {
            server.Shutdown();
            server.Dispose();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (server != null)
            {
                server.Dispose();
            }
            base.OnClosed(e);
        }

        private void frmMainLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BssBase.settings.SocketServer == "true")
            {
                timer1.Enabled = false;
                StopServer();

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("select * from tblNetworkPC where Status <> 20 and FirmaID = @Firma", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Firma", BssBase.settings.firmaId);
                    DataTable db = new DataTable();
                    con.Open();
                    db.Load(com.ExecuteReader());

                    foreach (DataRow item in db.Rows)
                    {
                        var StartDateTime = item["StartTime"];
                        var EndDateTime = item["EndTime"];

                        DateTime End = DateTime.MinValue;
                        DateTime start = DateTime.MinValue;

                        if (EndDateTime != DBNull.Value)
                            End = Convert.ToDateTime(EndDateTime);

                        if (StartDateTime != DBNull.Value)
                            start = Convert.ToDateTime(StartDateTime);

                        if (start != DateTime.MinValue)
                        {
                            if (End != DateTime.MinValue)
                            {
                                //MNetCaffe.Computer p = new MNetCaffe.Computer(item["PCName"].ToString(), item["HostName"].ToString(), item["IPAddres"].ToString(), Tools.PrazenStringToInt(item["Number"].ToString()),
                                // Tools.PrazenStringToInt(item["ID"].ToString()), Tools.PrazenStringToInt(item["tblArtikalID"].ToString()), item["R_UserName"].ToString(), item["R_PassWord"].ToString(), item["ClientPassword"].ToString(), MNetCaffe.DeviceType.Computer);

                                //if (p.EndDate > DateTime.Now)
                                //{
                                //    p.End();
                                //}

                            }
                        }


                    }
                }
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

            var DatabaseUserName = RegistryData.Read("DatabaseUserName");
            var DatabasePassword = RegistryData.Read("DatabasePassword");
            SetirajKonekcija(DatabaseUserName, DatabasePassword);
            ProveriKonekcijaSoDatabaza(BssBase.settings.konekcija);
            cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");

            int idObjekt = Tools.PrazenStringToInt(RegistryData.Read("tblObjektiID"), 1);
            cmbObjekt.SelectirajItem(idObjekt);
            BssBase.settings.MomentalenObjektID = idObjekt;
            cmbObjekt.Enabled = BssBase.settings.UserAndObjectCheck;



        }

        private void NapolniScreenSoKorisnici()
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql =
                    "select ID,UserName,FullName from tblUsers where NivoNaAdministracija < 8 and Status <> 1 or Status is null and FirmaID = @FirmaID";

                if (BssBase.settings.UserAndObjectCheck)
                {
                    sql =
                        "select ID,UserName,FullName from tblUsers where (NivoNaAdministracija < 8 and Status <> 1 or Status is null and FirmaID = @FirmaID) AND (tblObjektId = @objektID OR tblObjektId is null)";
                }


                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("FirmaID", BssBase.settings.firmaId);
                    if (BssBase.settings.UserAndObjectCheck)
                    {
                        com.Parameters.AddWithValue("objektID", BssBase.settings.MomentalenObjektID);
                    }

                    DataTable users = new DataTable();
                    users.Load(com.ExecuteReader());
                    int sizeW = 180;
                    int sizeH = 80;

                    if (users.Rows.Count > 16)
                    {
                        sizeW = 150;
                        sizeH = 70;
                    }
                    flKorisnici.Controls.Clear();
                    foreach (DataRow user in users.Rows)
                    {
                        Button btnUser = new Button();
                        btnUser.Name = user["ID"].ToString();
                        btnUser.Text = user["UserName"].ToString() + Environment.NewLine + Environment.NewLine +
                                       user["FullName"].ToString();
                        btnUser.Tag = user["UserName"].ToString();
                        btnUser.Size = new Size(sizeW, sizeH);
                        btnUser.ImageAlign = ContentAlignment.TopRight;
                        btnUser.TextAlign = ContentAlignment.MiddleLeft;
                        btnUser.Image = Properties.Resources.korisnici;
                        btnUser.BackColor = Color.Beige;
                        btnUser.FlatStyle = FlatStyle.Flat;
                        btnUser.TabStop = false;
                        btnUser.Click += btnUser_Click;
                        flKorisnici.Controls.Add(btnUser);
                    }
                }
            }
        }

        void btnUser_Click(object sender, EventArgs e)
        {

            UserName.Text = ((Button)sender).Tag.ToString();
            Password.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = false;
            
            Tools.UpdateSoftware(RegistryData);
        }

       

        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            BSS.DBAccess.CheckForDatabaseChanges(RegistryData, true);
        }

        private void frmMainLogin_Shown(object sender, EventArgs e)
        {
            if (!UserName.IsTextEmpty())
            {
                Password.Focus();
            }
            else
            {
                UserName.Focus();
            }
        }

        private void frmMainLogin_Activated(object sender, EventArgs e)
        {
            if (!UserName.IsTextEmpty())
            {
                Password.Focus();
            }
            else
            {
                UserName.Focus();
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (Password.IsTextEmpty()) Password.Focus();

        }

        private void излеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BssBase.settings.RegPath = $"SOFTWARE\\{txtRegistry.Text}";
            var RegistryData2 = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData2.SubKey = BssBase.settings.RegPath;
            settings.InitSettings.ReloadAllConfigs(RegistryData2);
            MessageBox.Show($"Користи {BssBase.settings.RegPath}");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BssBase.Forms.frmSql sql = new BssBase.Forms.frmSql();
            sql.Text = BssBase.settings.konekcija;
            sql.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            var rez = dlg.ShowDialog();
            if (rez == DialogResult.OK)
            {
                string fileName = string.Empty;
                fileName = dlg.SelectedPath;
                DBAccess.BackupDatabaseAsync(fileName);
                MessageBox.Show("Done");

            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "BSSR Backup files (*.BAK)|*.bak|All files (*.*)|*.*";
            fileDialog.ShowDialog();
            if (File.Exists(fileDialog.FileName))
            {
                DBAccess.RestoreDatabase(fileDialog.FileName);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            dbFunctions.reWriteConfigsFromDB();
            settings.InitSettings.ReloadAllConfigs();
            MessageBox.Show(Tools.PrevediPoraka("VcituvanjeNaSetinziteUspesno"));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BssBase.settings.RegPath = $"SOFTWARE\\{txtRegistry.Text}";
            var RegistryData2 = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData2.SubKey = BssBase.settings.RegPath;

            settings.ImportDefaultSettingsIntoRegistry(BssBase.Properties.Resources.BSSSettings, RegistryData2);
            settings.InitSettings.ReloadAllConfigs(RegistryData2);
            MessageBox.Show("Успешно креирање");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BssBase.settings.RegPath = $"SOFTWARE\\{txtRegistry.Text}";
            var RegistryData2 = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData2.SubKey = BssBase.settings.RegPath;

            var DatabaseUserName = RegistryData2.Read("DatabaseUserName");
            var DatabasePassword = RegistryData2.Read("DatabasePassword");
            var databaseName = RegistryData2.Read("Database").Split(';').FirstOrDefault();
            var Server = RegistryData2.Read("Server").Split(';').FirstOrDefault();

            bool tryConnect = true;
            bool inputConnectionParametars = false;

            while (tryConnect)
            {

                if (inputConnectionParametars)
                {
                    Server = InputBox.Show("Database Server").Text;
                    DatabaseUserName = InputBox.Show("Database Username").Text;
                    DatabasePassword = InputBox.Show("Database Password", true).Text;
                    databaseName = InputBox.Show("Database").Text;
                }
                try
                {
                    SetirajKonekcija(Tools.textToBase64(DatabaseUserName), Tools.textToBase64(DatabasePassword), Server, databaseName);
                    ProveriKonekcijaSoDatabaza(BssBase.settings.konekcija);
                    inputConnectionParametars = false;
                    tryConnect = false;
                    //Write
                    RegistryData2.Write("Server", Server);
                    RegistryData2.Write("Database", databaseName);
                    RegistryData2.Write("DatabaseUserName", Tools.textToBase64(DatabaseUserName));
                    RegistryData2.Write("DatabasePassword", Tools.textToBase64(DatabasePassword));
                    settings.InitSettings.ReloadAllConfigs(RegistryData2);
                }
                catch (Exception ex)
                {
                    tryConnect = true;
                    inputConnectionParametars = true;
                    Tools.LogException("Wrong server configuration", ex);
                }

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BssBase.settings.RegPath = $"SOFTWARE\\{txtRegistry.Text}";
            var RegistryData2 = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData2.SubKey = BssBase.settings.RegPath;
            tabControlBase1.TabPages.Remove(tabPage4);
            tabControlBase1.TabPages.Add(tabPage1);
            tabControlBase1.TabPages.Add(tabPage2);
            tabControlBase1.TabPages.Add(tabPage3);
            btnOk.Enabled = true;
            UserName.Enabled = true;
            Password.Enabled = true;
            ReloadConfigsAndUi(RegistryData2);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            BssBase.settings.RegPath = $"SOFTWARE\\{txtRegistry.Text}";
            var RegistryData2 = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData2.SubKey = BssBase.settings.RegPath;
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            string exportPath = $"{dlg.SelectedPath}\\{txtRegistry.Text}_{DateTime.Now.Year}_{DateTime.Now.Month}";
            string jsonConfig = exportPath + "\\settings.json";
            if (!Directory.Exists(exportPath)) Directory.CreateDirectory(exportPath);
            settings.ExportAllSettings(jsonConfig);
            tmpConfigs.databaseName = RegistryData2.Read("Database").Split(';').FirstOrDefault();
            DBAccess.BackupDatabaseAsync(exportPath);
            MessageBox.Show("Export finished");
        }

        private void импортНаРегистриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BssBase.settings.RegPath = $"SOFTWARE\\{txtRegistry.Text}";
            var RegistryData2 = new Utility.ModifyRegistry.ModifyRegistry();
            RegistryData2.SubKey = BssBase.settings.RegPath;

            settings.ImportDefaultSettingsIntoRegistry(null, RegistryData2);
            settings.InitSettings.ReloadAllConfigs(RegistryData2);
            MessageBox.Show("Успешно креирање");
        }

        private void tabControlBase1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
            //RegistryData.SubKey = BssBase.settings.RegPath;
            //ReloadConfigsAndUi(RegistryData);

        }

        private void cmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBaza.SelectedIndex != -1 && loading == false)
            {
                var DatabaseUserName = RegistryData.Read("DatabaseUserName");
                var DatabasePassword = RegistryData.Read("DatabasePassword");
                SetirajKonekcija(DatabaseUserName, DatabasePassword);
                cmbObjekt.LoadItems("select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti");

                int idObjekt = Tools.PrazenStringToInt(RegistryData.Read("tblObjektiID"), 1);
                cmbObjekt.SelectirajItem(idObjekt);
                BssBase.settings.MomentalenObjektID = idObjekt;
                cmbObjekt.Enabled = BssBase.settings.UserAndObjectCheck;
                Password.Focus();
            }
        }

        private void refreshSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadForm(regName, regFirma);
        }

        private void newRegLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regName = InputBox.Show(Tools.PrevediPoraka("Име на Регистри"), Tools.PrevediPoraka("Име на Регистри")).Text;
            ReloadForm(regName, regFirma);
        }
    }
}
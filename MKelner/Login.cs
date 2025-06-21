using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MKelner
{
    public partial class Login : Form
    {
        private string[] Databases;
        public string GlavnaFormConnectionString = string.Empty;

        private Utility.ModifyRegistry.ModifyRegistry RegistryData = new Utility.ModifyRegistry.ModifyRegistry();

        private SqlConnection LoginConnection;
        private SqlCommand LoginCommand;

        public string UserName = "spiro";

        public Login(int firma = -1)
        {
            RegistryData.SubKey = BssBase.settings.RegPath;
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            BssBase.settings.designMode = true;
            //BssBase.settings.OnScreenKeyBoard = true;
            var DatabaseUserName = RegistryData.Read("DatabaseUserName");
            var DatabasePassword = RegistryData.Read("DatabasePassword");
            BssBase.settings.LogiranjeNaSessii = true;
            UserName = RegistryData.Read("LastUser");
            Databases = RegistryData.Read("Database").ToString().Split(';');
            Text = "BSSR © 2012 - 2021 Верзија " + Application.ProductVersion;
            GlavnaFormConnectionString = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", RegistryData.Read("Server"), Databases.First(), base64ToText(DatabaseUserName), base64ToText(DatabasePassword));

            BssBase.settings.FirmaNaziv = RegistryData.Read("ImeNaFirma");
            BssBase.settings.PrinterPathDefault = RegistryData.Read("DefaultPrinter");
            BssBase.settings.PrinterSecond = RegistryData.Read("PrinterZaKujna");

            Properties.Settings.Default["BSSRConnectionString"] = GlavnaFormConnectionString;

            BssBase.settings.konekcija = GlavnaFormConnectionString;
            BssBase.settings.RazlicniBoiNaRedicVoGrid = true;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            BssBase.settings.jazik = "mk";
            BssBase.settings.UserRole = "ADMIN";

            Forms.cfg.brojNaArtikliDisplay = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplay"), Forms.cfg.brojNaArtikliDisplay);
            Forms.cfg.sirinaNaBack = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaBack"), Forms.cfg.sirinaNaBack);
            Forms.cfg.sirinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaDugminjaGore"), Forms.cfg.sirinaNaDugminjaGore);
            Forms.cfg.VisinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaDugminjaGore"), Forms.cfg.VisinaNaDugminjaGore);
            Forms.cfg.BrojNaKopcinjaSmetka = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopcinjaSmetka"), Forms.cfg.BrojNaKopcinjaSmetka);

            if (string.IsNullOrEmpty(RegistryData.Read("PrasajZaFiskalna", "true")))
            {
                BssBase.settings.PrasajZaFiskalna = false;
            }
            else
            {
                BssBase.settings.PrasajZaFiskalna = RegistryData.Read("PrasajZaFiskalna").ToUpper().Contains("TRUE");
            }
            if (RegistryData.Read("PrikaziTastaturaLogin").Contains("1"))
            {
                BssBase.settings.OnScreenKeyBoard = true;
            }
            else
            {
                BssBase.settings.OnScreenKeyBoard = false;
            }
            if (firma == -1)
            {
                BssBase.settings.firmaId = Tools.PrazenStringToInt(RegistryData.Read("FirmaID"), 1);
            }
            Password.Select();
            Password.Focus();

            if (!string.IsNullOrEmpty(RegistryData.Read("Kujna", "0")))
            {
                BssBase.settings.eKujna = RegistryData.Read("Kujna");
            }

            if (!string.IsNullOrEmpty(RegistryData.Read("BrojNaKopiiZaSank", "1")))
            {
                BssBase.settings.KopiiSank = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopiiZaSank"));
            }

            if (!string.IsNullOrEmpty(RegistryData.Read("BrojNaKopiiZaKujna", "2")))
            {
                BssBase.settings.KopiiZakujna = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopiiZaKujna"));
            }

            if (!string.IsNullOrEmpty(RegistryData.Read("BrojNaKopiiZaSmetka", "1")))
            {
                BssBase.settings.KopiiZaSmetka = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopiiZaSmetka"));
            }

            BssBase.settings.ReportPath = String.Format("{0}\\Reports\\", Application.StartupPath);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoginConnection = new SqlConnection(GlavnaFormConnectionString);
            var ValidationPass = true;

            foreach (Control control in GroupLogin.Controls)
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

            if (Password.IsTextEmpty())
            {
                ValidationPass = false;
            }
            if (ValidationPass)
            {
                LoginCommand = new SqlCommand("SELECT * FROM tblUsers WHERE (UserName=@User AND Password=@Pass) OR  (UserName=@User2 AND Password=@Pass2) ", LoginConnection);
                LoginCommand.Parameters.AddWithValue("@User", UserName);
                LoginCommand.Parameters.AddWithValue("@Pass", Password.Text);
                LoginCommand.Parameters.AddWithValue("@User2", Tools.ConvertToLatinica(UserName));
                LoginCommand.Parameters.AddWithValue("@Pass2", Tools.ConvertToLatinica(Password.Text));
                LoginConnection.Open();

                var LoginChecker = LoginCommand.ExecuteReader();
                var user = string.Empty;
                var User_Id = -1;
                var UserFullName = string.Empty;
                var UserLevel = -1;

                if (LoginChecker.HasRows)
                {
                    LoginChecker.Read();

                    User_Id = Tools.PrazenStringToInt(LoginChecker["Id"].ToString());
                    user = LoginChecker["Username"].ToString();
                    UserLevel = Tools.PrazenStringToInt(LoginChecker["NivoNaAdministracija"].ToString());
                    UserFullName = LoginChecker["FullName"].ToString();
                    BssBase.settings.UserRole = "ADMIN";
                    BssBase.settings.UserId = User_Id;
                    LoginConnection.Close();

                    Hide();
                    RegistryData.Write("LastUser", UserName);

                    switch (UserLevel)
                    {
                        case 1:
                        case 3:
                            using (var sesija = new Sessions(BssBase.settings.UserId, BssBase.settings.UserId, BssBase.settings.konekcija))
                            {
                                BssBase.settings.Sesija = sesija.Sesija;
                                var GlavnaForma = new Forms.frmKelner(UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
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
                                //cmbObjekt.LoadItems( "select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti" );
                                sesija.StopSession();
                            }
                            break;

                        default:
                            MessageBox.Show(Tools.PrevediPoraka("Погрешни податоци"));
                            break;
                    }
                }
                else
                {
                    LoginConnection.Close();
                    MessageBox.Show(Tools.PrevediPoraka("Погрешни податоци"));

                    return;
                }
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
            Password.PasswordChar = '*';
            //cmbObjekt.LoadItems( "select ID, Sifra + ' - ' + Naziv as Vrednost from tblObjekti" );
            Password.Focus();
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
        }
    }
}
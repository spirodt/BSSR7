using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MKelner
{
    public partial class frmMainLogin : Form
    {
        public String GlavnaFormConnectionString = string.Empty;
        public String GlavnaFormConnectionStringENTITY = string.Empty;
        public bool LoginOk;
        public int SelectedUserId = -1;
        public int SelectedUserLevel = -1;
        private SqlConnection LoginConnection;
        private SqlCommand LoginCommand;

        public frmMainLogin(int firma = -1)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            LoginOk = false;

            BSSRDataSet db = new BSSRDataSet();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoginConnection = new SqlConnection(BssBase.settings.konekcija);
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

            if (UserName.IsTextEmpty() || Password.IsTextEmpty())
            {
                ValidationPass = false;
            }
            if (ValidationPass)
            {
                LoginCommand = new SqlCommand("SELECT * FROM tblUsers WHERE (UserName=@User AND Password=@Pass) OR  (UserName=@User2 AND Password=@Pass2) ", LoginConnection);
                LoginCommand.Parameters.AddWithValue("@User", UserName.Text);
                LoginCommand.Parameters.AddWithValue("@Pass", Password.Text);
                LoginCommand.Parameters.AddWithValue("@User2", Tools.ConvertToLatinica(UserName.Text));
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
                    if (UserLevel == 9)
                    {
                        LoginOk = true;
                        SelectedUserLevel = UserLevel;
                        SelectedUserId = User_Id;
                    }
                    else
                    {
                        LoginOk = false;
                        MessageBox.Show(Tools.PrevediPoraka("Погрешни податоци"));
                    }
                    Close();
                }
                else
                {
                    LoginConnection.Close();
                    MessageBox.Show(Tools.PrevediPoraka("Погрешни податоци"));
                    UserName.Focus();
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

            if (UserName.Text.Length > 1)
            {
                Password.Focus();
            }
            else
            {
                UserName.Focus();
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
        }
    }
}
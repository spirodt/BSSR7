using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data;

namespace BssBase
{
    /// <summary>
    /// Summary description for InputBox.
    /// </summary>
    public class InputBox
    {
        private static Form frmInputDialog;
        private static Label lblPrompt;
        private static Button btnOK;
        private static Button btnCancel;

        public static txtBase txtInput;

        public static bool Paasword { set; get; }

        public InputBox()
        {
        }

        private static string _formCaption = string.Empty;
        private static string _formPrompt = string.Empty;
        private static InputBoxResult _outputResponse = new InputBoxResult();
        private static string _defaultValue = string.Empty;
        private static int _xPos = -1;
        private static int _yPos = -1;
        public static decimal Rabat;
        public static decimal Minuti;

        private static void InitializeComponent()
        {
            frmInputDialog = new Form();
            lblPrompt = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            txtInput = new txtBase();
            frmInputDialog.CancelButton = btnCancel;
            frmInputDialog.AcceptButton = btnOK;
            txtInput.AcceptsReturn = false;
            frmInputDialog.SuspendLayout();
            lblPrompt.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            lblPrompt.BackColor = SystemColors.Control;
            lblPrompt.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            lblPrompt.Location = new Point(12, 9);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(502, 282);
            lblPrompt.TabIndex = 3;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Location = new Point(450, 8);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(128, 128);
            btnOK.TabIndex = 1;
            btnOK.Text = "&OK";
            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(450, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 128);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.Click += new EventHandler(btnCancel_Click);
            txtInput.Location = new Point(8, 290);
            txtInput.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(579, 50);
            txtInput.TabIndex = 0;
            txtInput.Text = string.Empty;
            frmInputDialog.AutoScaleBaseSize = new Size(5, 13);
            frmInputDialog.ClientSize = new Size(598, 328);
            frmInputDialog.Controls.Add(txtInput);
            frmInputDialog.Controls.Add(btnCancel);
            frmInputDialog.Controls.Add(btnOK);
            frmInputDialog.Controls.Add(lblPrompt);
            frmInputDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmInputDialog.MaximizeBox = false;
            frmInputDialog.MinimizeBox = false;
            frmInputDialog.Name = "frmInputDialog";
            frmInputDialog.ResumeLayout(false);
        }

        private static void LoadFormZaPrintHvacTekovno()
        {
            GroupBox FiskalnaBox = new GroupBox();
            FiskalnaBox.Text = Tools.PrevediPoraka("Тип на фактура");
            FiskalnaBox.Name = "chFiskalna";
            RadioButton voGotovo = new RadioButton();
            voGotovo.Name = "voGotovo";
            voGotovo.Text = Tools.PrevediPoraka("Тековно одржување");
            voGotovo.Checked = true;
            voGotovo.Dock = DockStyle.Top;

            RadioButton soKarticka = new RadioButton();
            soKarticka.Name = "soKarticka";
            soKarticka.Text = Tools.PrevediPoraka("HVAC Фактура");
            soKarticka.Dock = DockStyle.Top;
            FiskalnaBox.Controls.Add(voGotovo);
            FiskalnaBox.Controls.Add(soKarticka);
            frmInputDialog.Controls.Add(FiskalnaBox);
            FiskalnaBox.BringToFront();
            lblPrompt.Dock = DockStyle.Top;
            txtInput.Dock = DockStyle.Bottom;
            OutputResponse.ReturnCode = DialogResult.Ignore;
            OutputResponse.Text = string.Empty;
            FiskalnaBox.Location = new Point(txtInput.Location.X + 10, txtInput.Location.Y - 110);
            txtInput.Text = string.Empty;
            lblPrompt.Text = _formPrompt;
            frmInputDialog.Text = _formCaption;

            var workingRectangle = Screen.PrimaryScreen.WorkingArea;

            if ((_xPos >= 0 && _xPos < workingRectangle.Width - 100) && (_yPos >= 0 && _yPos < workingRectangle.Height - 100))
            {
                frmInputDialog.StartPosition = FormStartPosition.Manual;
                frmInputDialog.Location = new Point(_xPos, _yPos);
            }
            else
            {
                frmInputDialog.StartPosition = FormStartPosition.CenterScreen;
            }
            var PrompText = lblPrompt.Text;

            var n = 0;
            var Index = 0;
            while (PrompText.IndexOf("\n", Index) > -1)
            {
                Index = PrompText.IndexOf("\n", Index) + 1;
                n++;
            }

            if (n == 0)
            {
                n = 1;
            }
            var Txt = txtInput.Location;
            Txt.Y = Txt.Y + (n * 4);
            txtInput.Location = Txt;
            var form = frmInputDialog.Size;
            form.Height = form.Height + (n * 4);
            frmInputDialog.Size = form;

            txtInput.SelectionStart = 0;
            txtInput.SelectionLength = txtInput.Text.Length;
            txtInput.Focus();
        }

        private static void LoadFormZaPrint()
        {
            GroupBox FiskalnaBox = new GroupBox();
            FiskalnaBox.Text = Tools.PrevediPoraka("Начин на принтање");
            FiskalnaBox.Name = "chFiskalna";
            RadioButton voGotovo = new RadioButton();
            voGotovo.Name = "voGotovo";
            voGotovo.Text = Tools.PrevediPoraka("Експортирај");
            voGotovo.Checked = true;
            voGotovo.Dock = DockStyle.Top;

            RadioButton soKarticka = new RadioButton();
            soKarticka.Name = "soKarticka";
            soKarticka.Text = Tools.PrevediPoraka("Прати на принтер");
            soKarticka.Dock = DockStyle.Top;
            FiskalnaBox.Controls.Add(voGotovo);
            FiskalnaBox.Controls.Add(soKarticka);
            frmInputDialog.Controls.Add(FiskalnaBox);
            FiskalnaBox.BringToFront();
            lblPrompt.Dock = DockStyle.Top;
            txtInput.Dock = DockStyle.Bottom;
            OutputResponse.ReturnCode = DialogResult.Ignore;
            OutputResponse.Text = string.Empty;
            FiskalnaBox.Location = new Point(txtInput.Location.X + 10, txtInput.Location.Y - 110);
            txtInput.Text = string.Empty;
            lblPrompt.Text = _formPrompt;
            frmInputDialog.Text = _formCaption;

            var workingRectangle = Screen.PrimaryScreen.WorkingArea;

            if ((_xPos >= 0 && _xPos < workingRectangle.Width - 100) && (_yPos >= 0 && _yPos < workingRectangle.Height - 100))
            {
                frmInputDialog.StartPosition = FormStartPosition.Manual;
                frmInputDialog.Location = new Point(_xPos, _yPos);
            }
            else
            {
                frmInputDialog.StartPosition = FormStartPosition.CenterScreen;
            }
            var PrompText = lblPrompt.Text;

            var n = 0;
            var Index = 0;
            while (PrompText.IndexOf("\n", Index) > -1)
            {
                Index = PrompText.IndexOf("\n", Index) + 1;
                n++;
            }

            if (n == 0)
            {
                n = 1;
            }
            var Txt = txtInput.Location;
            Txt.Y = Txt.Y + (n * 4);
            txtInput.Location = Txt;
            var form = frmInputDialog.Size;
            form.Height = form.Height + (n * 4);
            frmInputDialog.Size = form;

            txtInput.SelectionStart = 0;
            txtInput.SelectionLength = txtInput.Text.Length;
            txtInput.Focus();
        }
        private static void LoadFormZaMailOrPrint()
        {
            GroupBox FiskalnaBox = new GroupBox();
            FiskalnaBox.Text = Tools.PrevediPoraka("Начин на испраќање");
            FiskalnaBox.Name = "chFiskalna";
            RadioButton voGotovo = new RadioButton();
            voGotovo.Name = "voGotovo";
            voGotovo.Text = Tools.PrevediPoraka("Прати на маил");
            voGotovo.Checked = true;
            voGotovo.Dock = DockStyle.Top;

            RadioButton soKarticka = new RadioButton();
            soKarticka.Name = "soKarticka";
            soKarticka.Text = Tools.PrevediPoraka("Прати на принтер");
            soKarticka.Dock = DockStyle.Top;
            FiskalnaBox.Controls.Add(voGotovo);
            FiskalnaBox.Controls.Add(soKarticka);
            frmInputDialog.Controls.Add(FiskalnaBox);
            FiskalnaBox.BringToFront();
            lblPrompt.Dock = DockStyle.Top;
            txtInput.Dock = DockStyle.Bottom;
            OutputResponse.ReturnCode = DialogResult.Ignore;
            OutputResponse.Text = string.Empty;
            FiskalnaBox.Location = new Point(txtInput.Location.X + 10, txtInput.Location.Y - 110);
            txtInput.Text = string.Empty;
            lblPrompt.Text = _formPrompt;
            frmInputDialog.Text = _formCaption;

            var workingRectangle = Screen.PrimaryScreen.WorkingArea;

            if ((_xPos >= 0 && _xPos < workingRectangle.Width - 100) && (_yPos >= 0 && _yPos < workingRectangle.Height - 100))
            {
                frmInputDialog.StartPosition = FormStartPosition.Manual;
                frmInputDialog.Location = new Point(_xPos, _yPos);
            }
            else
            {
                frmInputDialog.StartPosition = FormStartPosition.CenterScreen;
            }
            var PrompText = lblPrompt.Text;

            var n = 0;
            var Index = 0;
            while (PrompText.IndexOf("\n", Index) > -1)
            {
                Index = PrompText.IndexOf("\n", Index) + 1;
                n++;
            }

            if (n == 0)
            {
                n = 1;
            }
            var Txt = txtInput.Location;
            Txt.Y = Txt.Y + (n * 4);
            txtInput.Location = Txt;
            var form = frmInputDialog.Size;
            form.Height = form.Height + (n * 4);
            frmInputDialog.Size = form;

            txtInput.SelectionStart = 0;
            txtInput.SelectionLength = txtInput.Text.Length;
            txtInput.Focus();
        }
        private static void LoadFormZaKusurIFiskalna()
        {
            GroupBox FiskalnaBox = new GroupBox();
           FiskalnaBox.Text  = Tools.PrevediPoraka("Тип на плаќање");
            FiskalnaBox.Name = "chFiskalna";
            RadioButton voGotovo = new RadioButton();
            voGotovo.Name = "voGotovo";
            voGotovo.Text = Tools.PrevediPoraka("Во готово");
            voGotovo.Checked = true;
            voGotovo.Dock = DockStyle.Top;

            RadioButton soKarticka = new RadioButton();
            soKarticka.Name = "soKarticka";
            soKarticka.Text = Tools.PrevediPoraka("Со Картичка");
            soKarticka.Dock = DockStyle.Top;
            FiskalnaBox.Controls.Add(voGotovo);
            FiskalnaBox.Controls.Add(soKarticka);
            frmInputDialog.Controls.Add(FiskalnaBox);
            FiskalnaBox.BringToFront();
            lblPrompt.Dock = DockStyle.Top;
            txtInput.Dock =  DockStyle.Bottom;
            OutputResponse.ReturnCode = DialogResult.Ignore;
            OutputResponse.Text = string.Empty;
            FiskalnaBox.Location = new Point(txtInput.Location.X +10, txtInput.Location.Y - 110);
            txtInput.Text = string.Empty;
            lblPrompt.Text = _formPrompt;
            frmInputDialog.Text = _formCaption;

            var workingRectangle = Screen.PrimaryScreen.WorkingArea;

            if ((_xPos >= 0 && _xPos < workingRectangle.Width - 100) && (_yPos >= 0 && _yPos < workingRectangle.Height - 100))
            {
                frmInputDialog.StartPosition = FormStartPosition.Manual;
                frmInputDialog.Location = new Point(_xPos, _yPos);
            }
            else
            {
                frmInputDialog.StartPosition = FormStartPosition.CenterScreen;
            }
            var PrompText = lblPrompt.Text;
            
            var n = 0;
            var Index = 0;
            while (PrompText.IndexOf("\n", Index) > -1)
            {
                Index = PrompText.IndexOf("\n", Index) + 1;
                n++;
            }

            if (n == 0)
            {
                n = 1;
            }
            var Txt = txtInput.Location;
            Txt.Y = Txt.Y + (n * 4);
            txtInput.Location = Txt;
            var form = frmInputDialog.Size;
            form.Height = form.Height + (n * 4);
            frmInputDialog.Size = form;

            txtInput.SelectionStart = 0;
            txtInput.SelectionLength = txtInput.Text.Length;
            txtInput.Focus();
        }
        private static void LoadForm()
        {
            OutputResponse.ReturnCode = DialogResult.Ignore;
            OutputResponse.Text = string.Empty;

            txtInput.Text = _defaultValue;
            lblPrompt.Text = _formPrompt;
            frmInputDialog.Text = _formCaption;

            var workingRectangle = Screen.PrimaryScreen.WorkingArea;

            if ((_xPos >= 0 && _xPos < workingRectangle.Width - 100) && (_yPos >= 0 && _yPos < workingRectangle.Height - 100))
            {
                frmInputDialog.StartPosition = FormStartPosition.Manual;
                frmInputDialog.Location = new Point(_xPos, _yPos);
            }
            else
            {
                frmInputDialog.StartPosition = FormStartPosition.CenterScreen;
            }
            var PrompText = lblPrompt.Text;

            var n = 0;
            var Index = 0;
            while (PrompText.IndexOf("\n", Index) > -1)
            {
                Index = PrompText.IndexOf("\n", Index) + 1;
                n++;
            }

            if (n == 0)
            {
                n = 1;
            }
            var Txt = txtInput.Location;
            Txt.Y = Txt.Y + (n * 4);
            txtInput.Location = Txt;
            var form = frmInputDialog.Size;
            form.Height = form.Height + (n * 4);
            frmInputDialog.Size = form;

            txtInput.SelectionStart = 0;
            txtInput.SelectionLength = txtInput.Text.Length;
            txtInput.Focus();
        }

        private static void btnOK_Click(object sender, EventArgs e)
        {
            OutputResponse.ReturnCode = DialogResult.OK;
            OutputResponse.Text = txtInput.Text;
            OutputResponse.RabatOut = Rabat;
            OutputResponse.MinutiOut = Minuti;
            if(frmInputDialog.Controls.OfType<GroupBox>().Any())
            {
                var voGotovoRadioButton = frmInputDialog.Controls.OfType<GroupBox>().FirstOrDefault().Controls.OfType<RadioButton>().Where(x=>x.Checked == true).FirstOrDefault();
                OutputResponse.DefaulOptionSelected = voGotovoRadioButton?.Name == "voGotovo";
            }
            frmInputDialog.Dispose();
        }

        private static void btnCancel_Click(object sender, EventArgs e)
        {
            OutputResponse.ReturnCode = DialogResult.Cancel;
            OutputResponse.Text = string.Empty;
            frmInputDialog.Dispose();
        }
        
        public static InputBoxResult Show(string Prompt, bool password = false, bool numbersOnly = false)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }
            if (numbersOnly)
                txtInput.C_OnlyNumbers = true;

            FormPrompt = Prompt;

            LoadForm();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static decimal sumZaNaplataODVnes = 0;

        public static InputBoxResult ShowProcentCena(string Prompt, bool RacunajNaInput, decimal sumaZaNaplata, bool password = false, bool numbersOnly = false, float fontsize = 12.25F, bool PrikaziTastatura = false)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }

            if (numbersOnly)
            {
                txtInput.C_OnlyNumbers = true;
                txtInput.PrikaziMalKeyBoard = true;
                txtInput.MaxLength = 10;
            }

            txtInput.prikaziKeyBoard = PrikaziTastatura;
            FormPrompt = Prompt;
            lblPrompt.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            LoadForm();
            sumZaNaplataODVnes = sumaZaNaplata;
            if (RacunajNaInput)
            {
                txtInput.TextChanged += txtInputMinuti_TextChanged;
            }
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult ShowMinuti(string defaultMinuti , string Prompt, bool RacunajNaInput, decimal sumaZaNaplata, bool password = false, bool numbersOnly = false, float fontsize = 12.25F, bool PrikaziTastatura = false)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }

            if (numbersOnly)
            {
                txtInput.C_OnlyNumbers = true;
                txtInput.PrikaziMalKeyBoard = true;
                txtInput.MaxLength = 10;
            }

            txtInput.prikaziKeyBoard = PrikaziTastatura;
            FormPrompt = Prompt;
            lblPrompt.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            LoadForm();
            sumZaNaplataODVnes = sumaZaNaplata;
            if (RacunajNaInput)
            {
                txtInput.TextChanged += txtInputMinuti_TextChanged;
            }
            txtInput.Text = defaultMinuti;
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }
        public static InputBoxResult ShowProcentVnesCena(string Prompt, bool RacunajNaInput, decimal sumaZaNaplata, bool password = false, bool numbersOnly = false, float fontsize = 12.25F, bool PrikaziTastatura = false, int idArtikal = 0)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }

            if (numbersOnly)
            {
                txtInput.C_OnlyNumbers = true;
                txtInput.PrikaziMalKeyBoard = true;
                txtInput.MaxLength = 10;
            }

            txtInput.prikaziKeyBoard = PrikaziTastatura;
            FormPrompt = Prompt;
            lblPrompt.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            LoadForm();
            frmInputDialog.Text = "Пресметка на рабат со внес на цена";
            sumZaNaplataODVnes = sumaZaNaplata;
            if (idArtikal != -1)
            {
                var infoArtikal = Tools.GetListaSoArtikli().AsEnumerable().FirstOrDefault(x => x["Id"].toInt() == idArtikal.toInt());
                if (infoArtikal != null)
                {
                    decimal info = infoArtikal["CenaNaGolemo"].ToString().toDecimal();
                    cenaNaGolemo = info;
                }
            }
            if (RacunajNaInput)
            {
                txtInput.TextChanged += txtInputProcentCena_TextChanged;
            }
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        static decimal cenaNaGolemo = -1;
        public static InputBoxResult ShowProcentRabat(string Prompt, bool RacunajNaInput, decimal sumaZaNaplata, bool password = false, bool numbersOnly = false, float fontsize = 12.25F, bool PrikaziTastatura = false, int idArtikal = -1)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }

            if (numbersOnly)
            {
                txtInput.C_OnlyNumbers = true;
                txtInput.PrikaziMalKeyBoard = true;
                txtInput.MaxLength = 10;
            }

            txtInput.prikaziKeyBoard = PrikaziTastatura;
            FormPrompt = Prompt;
            cenaNaGolemo = -1;
            if (idArtikal != -1)
            {
                var infoArtikal = Tools.GetListaSoArtikli().AsEnumerable().FirstOrDefault(x=>x["Id"].toInt() == idArtikal.toInt());
                if (infoArtikal != null)
                {
                    decimal info = infoArtikal["CenaNaGolemo"].ToString().toDecimal();
                    cenaNaGolemo = info;
                }
            }
            lblPrompt.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            LoadForm();
            frmInputDialog.Text = "Пресметка на рабат со внес износ за намалување";
            sumZaNaplataODVnes = sumaZaNaplata;
            if (RacunajNaInput)
            {
                txtInput.TextChanged += txtInputProcent_TextChanged;
            }
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        private static void txtInputProcentCena_TextChanged(object sender, EventArgs e)
        {
            if (sumZaNaplataODVnes > 0)
            {
                decimal vnesenaSuma = Tools.PrazenStringToDecimal_dec(txtInput.Text);

                string popust = string.Empty;
                popust = string.Format("Регуларна цена: {0:C} " + Environment.NewLine, sumZaNaplataODVnes);
                popust += $"Дозволена минамална цена: {cenaNaGolemo:C} {Environment.NewLine} {Environment.NewLine}";
                
                if (vnesenaSuma > 0)
                {
                    Rabat = ((100 * (sumZaNaplataODVnes - vnesenaSuma)) / sumZaNaplataODVnes);
                    popust += string.Format("Внесена цена : {0:C} \n", vnesenaSuma);
                    popust += string.Format($"Рабат: {Rabat} {Environment.NewLine}");
                    if(vnesenaSuma < cenaNaGolemo)
                    {
                        popust += $"{Environment.NewLine} {Environment.NewLine} Цената е под дозволената !!";
                        lblPrompt.ForeColor = Color.Red;
                    }else { lblPrompt.ForeColor = Color.Black; }
                }
                
                lblPrompt.Text = popust;
            }
        }

        private static void txtInputProcent_TextChanged(object sender, EventArgs e)
        {
            if (sumZaNaplataODVnes > 0)
            {
                decimal vnesenaSuma = Tools.PrazenStringToDecimal_dec(txtInput.Text);

                string popust = string.Empty;
                popust = string.Format($"Износ на ставка: {sumZaNaplataODVnes:C} {Environment.NewLine}", sumZaNaplataODVnes);
                popust += $"Дозволена минамална цена {cenaNaGolemo:C} {Environment.NewLine} {Environment.NewLine}";

                if (vnesenaSuma > 0)
                {
                    popust += string.Format("Попуст: {0:C} \n", vnesenaSuma);
                    popust += string.Format($"Износ со попуст: {(sumZaNaplataODVnes - vnesenaSuma):C} {Environment.NewLine}");
                }
                if ((sumZaNaplataODVnes - vnesenaSuma) < cenaNaGolemo)
                {
                    popust += $"{Environment.NewLine} {Environment.NewLine} Цената е под дозволената !!";
                    lblPrompt.ForeColor = Color.Red;
                }
                else { lblPrompt.ForeColor = Color.Black; }

                Rabat = ((100 * vnesenaSuma) / sumZaNaplataODVnes);
                lblPrompt.Text = popust;
            }
        }

        private static void txtInputMinuti_TextChanged(object sender, EventArgs e)
        {
            if (sumZaNaplataODVnes > 0)
            {
                decimal vnesenoVreme = Tools.PrazenStringToDecimal_dec(txtInput.Text);

                string popust = string.Empty;
                popust = string.Format("Цена по минута: {0:C} \n", sumZaNaplataODVnes);
                if (sumZaNaplataODVnes > 0)
                {
                    popust += string.Format("За наплата: {0:C} \n", sumZaNaplataODVnes * vnesenoVreme);
                    popust += string.Format("Минути за играње: {0:00} ", vnesenoVreme );
                }
                Minuti = vnesenoVreme;
                lblPrompt.Text = popust;
            }
        }

         public static InputBoxResult ShowFormaZaKusur(string Prompt,
             bool RacunajNaInput, decimal sumaZaNaplata,
             bool password = false, bool numbersOnly = false, 
             float fontsize = 12.25F, bool PrikaziTastatura = false)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }

            if (numbersOnly)
            {
                txtInput.C_OnlyNumbers = true;
                txtInput.PrikaziMalKeyBoard = true;
                txtInput.MaxLength = 10;
            }

            txtInput.prikaziKeyBoard = PrikaziTastatura;
            FormPrompt = Prompt;
            lblPrompt.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            LoadFormZaKusurIFiskalna();
            sumZaNaplataODVnes = sumaZaNaplata;
            if (RacunajNaInput)
            {
                txtInput.TextChanged += txtInput_Racunaj_TextChanged;
            }
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult Show(string Prompt, bool RacunajNaInput, decimal sumaZaNaplata, bool password = false, bool numbersOnly = false, float fontsize = 12.25F, bool PrikaziTastatura = false)
        {
            Paasword = password;

            InitializeComponent();
            if (Paasword)
            {
                txtInput.PasswordChar = '*';
            }

            if (numbersOnly)
            {
                txtInput.C_OnlyNumbers = true;
                txtInput.PrikaziMalKeyBoard = true;
                txtInput.MaxLength = 10;
            }

            txtInput.prikaziKeyBoard = PrikaziTastatura;
            FormPrompt = Prompt;
            lblPrompt.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            LoadForm();
            sumZaNaplataODVnes = sumaZaNaplata;
            if (RacunajNaInput)
            {
                txtInput.TextChanged += txtInput_Racunaj_TextChanged;
            }
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        private static void txtInput_Racunaj_TextChanged(object sender, EventArgs e)
        {
            if (sumZaNaplataODVnes > 0)
            {
                decimal vnesenaSuma = Tools.PrazenStringToDecimal_dec(txtInput.Text);
                string Kusur = string.Empty;
                Kusur = string.Format("Вкупно за наплата: {0:C} \n", sumZaNaplataODVnes);
                if (vnesenaSuma > 0)
                {
                    Kusur += string.Format("Внес: {0:C} \n", vnesenaSuma);
                    Kusur += string.Format("За враќање: {0:C} ", vnesenaSuma - sumZaNaplataODVnes);
                }
                lblPrompt.Text = Kusur;
            }
        }

        public static InputBoxResult Show(string Prompt, string Title)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;

            LoadForm();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult ShowPrintExport(string Prompt, string Title)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;

            LoadFormZaPrint();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult ShowPrintFakturaHvac(string Prompt, string Title)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;

            LoadFormZaPrintHvacTekovno();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult ShowMailOrPrint(string Prompt, string Title, bool inputEnabled = true)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;

            LoadFormZaMailOrPrint();
            DisableInput(inputEnabled);
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static void DisableInput(bool inputEnabled)
        {
            txtInput.Enabled = inputEnabled;
        }

        static int timerValue;
        public static InputBoxResult ShowFiskalna(string Prompt, string Title, string Default, bool pecatiDaIline)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;
            DefaultValue = Default;
            
            LoadForm();
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            timerValue = 0;
            t.Start();
            frmInputDialog.ShowDialog();
            t.Enabled = false;
            return OutputResponse;
        }

        static void t_Tick(object sender, EventArgs e)
        {
            timerValue += 1;
            frmInputDialog.Text = frmInputDialog.Text + "  " + timerValue.ToString();
            if(timerValue > 30) {
                frmInputDialog.Close();
                ((Timer)sender).Enabled = false;
                OutputResponse.ReturnCode = DialogResult.Cancel;
            }
            
        }


        public static InputBoxResult Show(string Prompt, string Title, string Default, bool showInput)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;
            DefaultValue = Default;
            txtInput.Visible = showInput;
            LoadForm();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult Show(string Prompt, string Title, string Default)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;
            DefaultValue = Default;

            LoadForm();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult Show(string Prompt, string Title, decimal Default, bool numbersOnly)
        {
            InitializeComponent();

            FormCaption = Title;
            FormPrompt = Prompt;
            DefaultValue = Default.ToString();
            if (numbersOnly)
                txtInput.C_OnlyNumbers = true;

            LoadForm();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        public static InputBoxResult Show(string Prompt, string Title, string Default, int XPos, int YPos)
        {
            InitializeComponent();
            FormCaption = Title;
            FormPrompt = Prompt;
            DefaultValue = Default;
            XPosition = XPos;
            YPosition = YPos;

            LoadForm();
            frmInputDialog.ShowDialog();
            return OutputResponse;
        }

        private static string FormCaption
        {
            set => _formCaption = value;
        }

        private static string FormPrompt
        {
            set => _formPrompt = value;
        }

        private static InputBoxResult OutputResponse
        {
            get => _outputResponse;
            set => _outputResponse = value;
        }

        private static string DefaultValue
        {
            set => _defaultValue = value;
        }

        private static int XPosition
        {
            set
            {
                if (value >= 0)
                {
                    _xPos = value;
                }
            }
        }

        private static int YPosition
        {
            set
            {
                if (value >= 0)
                {
                    _yPos = value;
                }
            }
        }
    }
}
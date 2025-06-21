using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BssBase
{
    public class txtBase : TextBox
    {
        [DefaultValue(false)]
        public bool prikaziKeyBoard { set; get; }

        [DefaultValue(false)]
        public bool PrikaziMalKeyBoard { set; get; }

        public int PrazenStringToInt()
        {
            return Tools.PrazenStringToInt(Text, 0);
        }

        public decimal PrazenStringToDecimal_dec()
        {
            return Tools.PrazenStringToDecimal_dec(Text);
        }

        public void prikaziKeyboard(bool numpad = false)
        {
            Text = string.Empty;
            var keyboad = new Form();

            if (numpad)
            {
                System.Reflection.Assembly asm;
                asm = System.Reflection.Assembly.Load("SHANUPADUC");
                var t = asm.GetType("SHANUPADUC.KeyBoard");

                dynamic tast = (UserControl)Activator.CreateInstance(t, true);
                
                keyboad.WindowState = FormWindowState.Normal;
                keyboad.StartPosition = FormStartPosition.CenterScreen;
                // keyboad.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

                tast.HIDEPANEL();
                tast.AutoSize = true;
                tast.Dock = DockStyle.Fill;
                keyboad.Controls.Add(tast);
                keyboad.Size = new Size(250, 400);
                tast.Size = new Size(240, 390);
                keyboad.ShowDialog();
                Text = tast.keypaReturnVal;
                keyboad.Dispose();
            }
            else
            {
                System.Reflection.Assembly asm;
                asm = System.Reflection.Assembly.Load("SHANUPADUC");
                var t = asm.GetType("SHANUPADUC.KeyBoard");

                dynamic tast = (UserControl)Activator.CreateInstance(t, true);

                keyboad.Dock = DockStyle.Fill;
                keyboad.AutoSize = true;
                keyboad.Controls.Add(tast);
                if (PasswordChar == '\0')
                {
                    keyboad.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                }
                else
                {
                    keyboad.FormBorderStyle = FormBorderStyle.None;
                }
                var izlezi = new Button();
                izlezi.DialogResult = DialogResult.OK;
                izlezi.Click += new EventHandler(izlezi_Click);
                keyboad.Size = new Size(992, 377);
                keyboad.KeyDown += new KeyEventHandler(keyboad_KeyDown);
                keyboad.Controls.Add(izlezi);
                keyboad.StartPosition = FormStartPosition.CenterScreen;
                keyboad.ShowDialog();
                Text = tast.keypaReturnVal;
                Text = Text.Replace(",", ".");
                keyboad.Dispose();
            }
        }

        private void keyboad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ((Button)sender).FindForm().Close();
            }
        }

        private void izlezi_Click(object sender, EventArgs e)
        {
            ((Button)sender).FindForm().Close();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (settings.OnScreenKeyNaSveDugminjaBoard)
            {
                prikaziKeyboard(PrikaziMalKeyBoard);
            }

            if (prikaziKeyBoard || settings.OnScreenKeyBoard)
            {
                prikaziKeyboard(PrikaziMalKeyBoard);
            }
        }

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            if (ReadOnly == true)
            {
                BackColor = Color.LemonChiffon;
                ForeColor = Color.Blue;
            }
            else
            {
                BackColor = Color.Empty;
                ForeColor = Color.Empty;
            }
            base.OnReadOnlyChanged(e);
        }

        public bool daliCetiri { set; get; }

        public bool SelektrijaNaFokus { set; get; }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (SelektrijaNaFokus)
            {
                SelectAll();
            }
            base.OnMouseClick(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (!ReadOnly && BackColor != Color.Red)
            {
                BackColor = Color.LightGreen;
            }
            if (SelektrijaNaFokus)
            {
                SelectAll();
            }
            base.OnGotFocus(e);
        }

        public bool ImaNestoSmeneto = false;

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (this.ContainsFocus)
            {

                if (e.Delta < 0)
                    this.Font = new Font(this.Font.FontFamily, this.Font.Size - 1);
                else
                    this.Font = new Font(this.Font.FontFamily, this.Font.Size + 1);
            }
            base.OnMouseWheel(e);
        }
        protected override void OnCreateControl()
        {
            this.ScrollBars = ScrollBars.Both;
            
            base.OnCreateControl();
        }
        protected override void OnEnter(EventArgs e)
        {
            if (C_FillWithZeros)
            {
                Text = Text.PadLeft(MaxLength, '0');
            }
            if (C_OnlyNumbers == true)
            {
                SelectAll();
            }

            if (MakedonskiJazik)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[Tools.PrazenStringToInt(settings.RedenBrojNaJazik, -1)];
            }
            ImaNestoSmeneto = true;
            base.OnEnter(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (C_FillWithZeros)
            {
                Text = Text.PadLeft(MaxLength, '0');
            }

            if (IsTextEmpty() && C_ShowRedOnLeaveIfEmpty == true)
            {
                if (!ReadOnly)
                {
                    BackColor = Color.Red;
                }
            }
            else
            {
                if (!ReadOnly)
                {
                    BackColor = Color.Empty;
                }
            }

            base.OnLostFocus(e);
        }

        public string formToOpen { set; get; }

        [EditorBrowsable(EditorBrowsableState.Always),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        Bindable(true)]
        public string AssemblyStr { set; get; }

        public string ColumnName1 { set; get; }

        public string ColumnName2 { set; get; }

        public string ColumnName3 { set; get; }

        public string ColumnName4 { set; get; }

        public string ColumnName5 { set; get; }

        public string ColumnName6 { set; get; }

        public string ColumnName7 { set; get; }

        public string ret1 = string.Empty;
        public string ret2 = string.Empty;
        public string ret3 = string.Empty;
        public string ret4 = string.Empty;
        public string ret5 = string.Empty;
        public string ret6 = string.Empty;
        public string ret7 = string.Empty;

        public int MinLength { set; get; }

        public delegate void ReadODTxtSoObjekt(txtBase text);

        public delegate void doneLoading();

        public event doneLoading DataRead;

        public event ReadODTxtSoObjekt ReadODTextSoObjektEvent;

        public bool read;

        public bool PopulateOtherFields { set; get; }

        public bool IsTextEmpty(String txt)
        {
            return string.IsNullOrEmpty(txt);
        }

        [EditorBrowsable(EditorBrowsableState.Always),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public void OpenForm()
        {
            if (string.IsNullOrEmpty(AssemblyStr) && string.IsNullOrEmpty(formToOpen))
            {
                return;
            }
            if (AssemblyStr.Length > 1 && formToOpen.Length > 1)
            {
                var asm = System.Reflection.Assembly.Load(AssemblyStr);
                var t = asm.GetType(formToOpen); // CreateInstance( , true ).GetType();

                var frm = (frmShow)Activator.CreateInstance(t, new object[] { true });
                if (Equals(frm, null))
                    return;
                frm.AcceptButton = frm.btnOk;
                frm.btnOk.Focus();
                DataGridViewRow dtr;
                frm.ShowDialog();
                dtr = frm.dr;

                if (frm.PrifatiKlik == true)
                {
                    if (PopulateOtherFields)
                    {
                        try
                        {
                            if (!IsTextEmpty(ColumnName1))
                            {
                                ret1 = dtr.Cells[ColumnName1].Value.ToString();
                            }

                            if (!IsTextEmpty(ColumnName2))
                            {
                                ret2 = dtr.Cells[ColumnName2].Value.ToString();
                            }
                            if (!IsTextEmpty(ColumnName3))
                            {
                                ret3 = dtr.Cells[ColumnName3].Value.ToString();
                            }
                            if (!IsTextEmpty(ColumnName4))
                            {
                                ret4 = dtr.Cells[ColumnName4].Value.ToString();
                            }
                            if (!IsTextEmpty(ColumnName5))
                            {
                                ret5 = dtr.Cells[ColumnName5].Value.ToString();
                            }
                            if (!IsTextEmpty(ColumnName6))
                            {
                                ret6 = dtr.Cells[ColumnName6].Value.ToString();
                            }
                            if (!IsTextEmpty(ColumnName7))
                            {
                                ret7 = dtr.Cells[ColumnName7].Value.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Tools.PrevediPoraka(ex.ToString()));
                        }
                        DataRead.Invoke();
                    }
                    read = true;
                }
                frm.Dispose();
            }
        }

        private string filter;

        public bool KoristiFilterNaDatasource { set; get; }

        public void OpenEditSearch_old(string Filter = "")
        {
            read = false;
            if (Equals(null, AssemblyStr))
            {
                return;
            }
            if (!string.IsNullOrEmpty(Filter))
            {
                filter = Filter;
            }
            var asm = System.Reflection.Assembly.Load(AssemblyStr);
            var t = asm.GetType(formToOpen); // CreateInstance( , true ).GetType();
            var frm = (frmBigEdit)Activator.CreateInstance(t, new object[] { filter });

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow dtr;
                dtr = frm.groupVnes.Controls.OfType<grdBase>().ToList().ElementAt(0).CurrentRow;

                try
                {
                    if (!IsTextEmpty(ColumnName1))
                    {
                        ret1 = dtr.Cells[ColumnName1].Value.ToString();
                    }

                    if (!IsTextEmpty(ColumnName2))
                    {
                        ret2 = dtr.Cells[ColumnName2].Value.ToString();
                    }
                    if (!IsTextEmpty(ColumnName3))
                    {
                        ret3 = dtr.Cells[ColumnName3].Value.ToString();
                    }
                    if (!IsTextEmpty(ColumnName4))
                    {
                        ret4 = dtr.Cells[ColumnName4].Value.ToString();
                    }
                    if (!IsTextEmpty(ColumnName5))
                    {
                        ret5 = dtr.Cells[ColumnName5].Value.ToString();
                    }
                    if (!IsTextEmpty(ColumnName6))
                    {
                        ret6 = dtr.Cells[ColumnName6].Value.ToString();
                    }
                    if (!IsTextEmpty(ColumnName7))
                    {
                        ret7 = dtr.Cells[ColumnName7].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (!Equals(null, DataRead))
                    DataRead.Invoke();

                read = true;
            }

            Text = string.Empty;

            if (!Equals(null, ReadODTextSoObjektEvent))
                ReadODTextSoObjektEvent.Invoke(this);

            frm.Dispose();
        }

        public void OpenEditSearch(string Filter = "")
        {
            read = false;
            if (Equals(null, AssemblyStr))
            {
                return;
            }
            if (!string.IsNullOrEmpty(Filter))
            {
                filter = Filter;
            }
            var asm = System.Reflection.Assembly.Load(AssemblyStr);
            var t = asm.GetType(formToOpen); // CreateInstance( , true ).GetType();
            var frm = (frmBigEdit)Activator.CreateInstance(t, new object[] { filter });

            if (frm.ShowDialog() == DialogResult.OK)
            {

                DataRow dtr = frm.DtRow;

                if (dtr != null)
                {

                    try
                    {
                        if (!IsTextEmpty(ColumnName1))
                        {
                            ret1 = dtr[ColumnName1].ToString();
                        }

                        if (!IsTextEmpty(ColumnName2))
                        {
                            ret2 = dtr[ColumnName2].ToString();
                        }
                        if (!IsTextEmpty(ColumnName3))
                        {
                            ret3 = dtr[ColumnName3].ToString();
                        }
                        if (!IsTextEmpty(ColumnName4))
                        {
                            ret4 = dtr[ColumnName4].ToString();
                        }
                        if (!IsTextEmpty(ColumnName5))
                        {
                            ret5 = dtr[ColumnName5].ToString();
                        }
                        if (!IsTextEmpty(ColumnName6))
                        {
                            ret6 = dtr[ColumnName6].ToString();
                        }
                        if (!IsTextEmpty(ColumnName7))
                        {
                            ret7 = dtr[ColumnName7].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    if (!Equals(null, DataRead))
                        DataRead.Invoke();

                    read = true;
                }

                Text = string.Empty;

                if (!Equals(null, ReadODTextSoObjektEvent))
                    ReadODTextSoObjektEvent.Invoke(this);

                frm.Dispose();
            }
        }
        public bool IsTextEmpty()
        {
            return string.IsNullOrEmpty(Text);
        }

        public bool C_OnlyNumbers { get; set; }

        [DefaultValue(false)]
        public bool C_Decimal { get; set; }

        public bool C_ShowRedOnLeaveIfEmpty { get; set; }

        public bool C_FillWithZeros { get; set; }

        public bool C_RegEx { get; set; }

        public bool MakedonskiJazik { get; set; }

        public string regularExpression { get; set; }

        private bool NumberEntered;

        public string Format { set; get; }

        private bool CheckIfNumericKey(Keys K, bool isDecimalPoint)
        {
            if (K == Keys.Back)
            {
                return true;
            }
            else
            {
                if (K == Keys.OemPeriod || K == Keys.Decimal || K == Keys.OemMinus || K == Keys.Subtract)
                {
                    return isDecimalPoint ? false : true;
                }
                else
                {
                    if ((K >= Keys.D0) && (K <= Keys.D9))
                    {
                        return true;
                    }
                    else
                    {
                        if ((K >= Keys.NumPad0) && (K <= Keys.NumPad9))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (C_Decimal && C_OnlyNumbers)
            {
                if (IsTextEmpty() || Text == "0")
                {
                    Text = "0";
                    Text = formatTextDecimal();
                    SelectAll();
                }
            }

            base.OnTextChanged(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            Text = formatTextDecimal();
            base.OnLayout(levent);
        }

        public string formatTextDecimal()
        {
            if (C_Decimal && C_OnlyNumbers)
            {
                if (IsTextEmpty())
                {
                    Text = "0";
                }
                if (string.IsNullOrEmpty(Format))
                {
                    return Tools.PrazenStringToDecimal(Text).ToString("N2");
                }
                else
                {
                    return Tools.PrazenStringToDecimal(Text).ToString(Format);
                }
            }
            return Text;
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            Text = formatTextDecimal();
            base.OnValidating(e);
        }

        public bool iscistiGreenNaLeave { set; get; }

        protected override void OnLeave(EventArgs e)
        {
            if (IsTextEmpty() && C_ShowRedOnLeaveIfEmpty == true)
            {
                if (!ReadOnly)
                {
                    BackColor = Color.Red;
                }
            }
            else
            {
                if (!ReadOnly)
                {
                    BackColor = Color.Empty;
                }
            }

            if (TextLength < MinLength)
            {
                BackColor = Color.Red;
            }

            if (C_RegEx == true && regularExpression.Length > 1)
            {
                if (!Regex.IsMatch(Text, regularExpression))
                {
                    BackColor = Color.Red;
                }
            }

            base.OnLeave(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!ReadOnly)
            {
                if (!iscistiGreenNaLeave)
                    BackColor = Color.LightGreen;
                else
                {
                    BackColor = Color.Empty;
                }
            }
            if (C_OnlyNumbers == true)
            {
                if (NumberEntered == false)
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F5)
            {
                NumberEntered = CheckIfNumericKey(e.KeyCode, false);
                base.OnKeyDown(e);
            }
            else
            {
                OpenForm();
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            TextChanged += new EventHandler(txtBase_TextChanged);
            ResumeLayout(false);
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
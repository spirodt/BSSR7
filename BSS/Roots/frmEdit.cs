using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BssBase
{
    public partial class frmEdit : frmEditTop
    {
        protected bool FormIsEdit = false;
        public int ID, ID1, ID2, ID3, ID4, ID5 = 0;

        public string MainConnection { set; get; }

        public string UpdateTable { set; get; }

        public string FilterString { set; get; }

        public string PrimaryKey { set; get; }

        public bool ReadOnlyForm { set; get; }

        public bool EscNeJaGasiFormata { set; get; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (ReadOnlyForm)
            {
                SetFormReadOnly();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (EscNeJaGasiFormata && keyData == Keys.Escape)
            {
                if (FindFocusedControl() is frmShow)
                {
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        public Control FindFocusedControl()
        {
            return FindFocusedControl(this);
        }

        public static Control FindFocusedControl(Control container)
        {
            foreach (Control childControl in container.Controls)
            {
                if (childControl.Focused)
                {
                    return childControl;
                }
            }

            foreach (Control childControl in container.Controls)
            {
                var maybeFocusedControl = FindFocusedControl(childControl);
                if (maybeFocusedControl != null)
                {
                    return maybeFocusedControl;
                }
            }

            return null;
        }

        public void SetFormReadOnly()
        {
            Control.ControlCollection Elements = null;
            groupVnes.Enabled = false;
            foreach (TabPage tab in MainTab.TabPages)
            {
                foreach (GroupBox groupbox in tab.Controls.OfType<GroupBox>())
                {
                    Elements = groupbox.Controls;

                    foreach (TextBox c in Controls.OfType<TextBox>())
                    {
                        c.ReadOnly = true;
                    }

                    foreach (txtBase c in Controls.OfType<txtBase>())
                    {
                        c.ReadOnly = true;
                    }

                    foreach (ComboBox c in Controls.OfType<ComboBox>())
                    {
                        c.Enabled = false;
                    }

                    foreach (DataGrid c in Controls.OfType<DataGrid>())
                    {
                        c.ReadOnly = true;
                    }

                    foreach (MenuStrip c in Controls.OfType<MenuStrip>())
                    {
                        c.Enabled = false;
                    }

                    foreach (GroupBox c in Controls.OfType<GroupBox>())
                    {
                        foreach (Control con in Elements)
                        {
                            con.Enabled = false;
                        }
                    }
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            if (!designMode)
            {
                if (FormIsEdit)
                {
                    Text = Text + " - " + Tools.PrevediPoraka("EditForma");
                    Tools.WriteLog(Text);
                }
                else
                {
                    Text = Text + " - " + Tools.PrevediPoraka("VnesForma");
                    Tools.WriteLog(Text);
                }
            }
            base.OnShown(e);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        private bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);

        public frmEdit()
        {
            InitializeComponent();
            PrimaryKey = "Id";
            FormIsEdit = false;
        }

        public frmEdit(int selectedId)
        {
            InitializeComponent();
            PrimaryKey = "Id";
            FormIsEdit = true;
        }

        protected bool NeZatvoraj = false;

        public void PrikaziGreskaDole(string Text)
        {
            errorProviderDole.SetIconAlignment(DisplayError, ErrorIconAlignment.TopLeft);
            errorProviderDole.SetError(DisplayError, Text);
            DisplayError.Visible = true;
            DisplayError.Text = Text;
        }

        public virtual void zatvori()
        {
            if (!ProveriZaValidirani())
            {
                Close();
            }
            else
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniImaIzmeni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (opc == DialogResult.Yes)
                {
                    NeZatvoraj = false;
                    Close();
                }
                else
                {
                    NeZatvoraj = true;
                }
            }
        }

        public void btnZatvori_Click(object sender, EventArgs e)
        {
            zatvori();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();
            NeZatvoraj = false;
        }

        public void Sredi_MaksimalnaDolzinaVoSiteTabovi(DataColumnCollection Columns, string tableName, string SqlConnectionString)
        {
            sredi_Dolzina(Columns, tableName, SqlConnectionString);
        }

        public virtual void VcitajDefaultVrednosti(string tableName, GroupBox group = null)
        {
            if (group == null)
            {
                group = groupVnes;
            }
            var sql = @"Select A.name, A.DefaultValue, (select isNull(I.CHARACTER_MAXIMUM_LENGTH,0) + isNull(I.NUMERIC_PRECISION,0)) as Dolzina, I.DATA_TYPE as Tip, I.IS_NULLABLE as AllowNulls
						 from (SELECT object_definition(default_object_id) as DefaultValue, name FROM  sys.columns
						 WHERE  object_id = object_id(@tblName)  )as A
						 left outer join INFORMATION_SCHEMA.COLUMNS I on I.COLUMN_NAME = A.name AND I.TABLE_NAME = @tblName
                          ";
            using (var con = new SqlConnection(settings.konekcija))
            {
                SqlDataReader reader;
                using (var com = new SqlCommand(sql, con))
                {
                    try
                    {
                        con.Open();
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@tblName", tableName);
                        reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                foreach (txtBase box in group.Controls.OfType<txtBase>())
                                {
                                    if (box.Name.ToUpper().StartsWith(reader["name"].ToString().ToUpper()))
                                    {
                                        if (!Equals(box, null))
                                        {
                                            var maxLen = Tools.PrazenStringToInt(reader["Dolzina"].ToString(), -1);
                                            if (maxLen > 0)
                                            {
                                                box.MaxLength = maxLen;
                                            }
                                            if (!FormIsEdit)
                                            {
                                                box.Text = reader["DefaultValue"].ToString().Replace("(", string.Empty).Replace(")", string.Empty).Replace("N'", string.Empty).Replace("'", string.Empty);
                                            }
                                            if (reader["AllowNulls"].ToString().ToUpper() == "No".ToUpper())
                                            {
                                                box.C_ShowRedOnLeaveIfEmpty = true;
                                            }

                                            if (reader["Tip"].ToString().ToUpper() == "decimal".ToUpper())
                                            {
                                                if (!FormIsEdit)
                                                {
                                                    if ((box.IsTextEmpty()))
                                                    {
                                                        box.Text = "0";
                                                    }
                                                }

                                                box.C_ShowRedOnLeaveIfEmpty = true;
                                                box.C_Decimal = true;
                                                box.C_OnlyNumbers = true;
                                            }

                                            if (reader["Tip"].ToString().ToUpper() == "int".ToUpper())
                                            {
                                                if (!FormIsEdit)
                                                {
                                                    if ((box.IsTextEmpty()))
                                                    {
                                                        box.Text = "0";
                                                    }
                                                }

                                                box.C_ShowRedOnLeaveIfEmpty = true;
                                                box.C_OnlyNumbers = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        public virtual void sredi_Dolzina(DataColumnCollection Columns, string tableName, string SqlConnectionString, bool srediSize = true)
        {
            foreach (TabPage tab in MainTab.TabPages)
            {
                foreach (GroupBox groupBox in tab.Controls.OfType<GroupBox>())
                {
                    VcitajDefaultVrednosti(tableName, groupBox);
                    if (srediSize)
                    {
                        foreach (txtBase control in groupBox.Controls.OfType<txtBase>())
                        {
                            if (control.Multiline == false)
                            {
                                control.MinimumSize = new Size(25, 25);
                                control.MaximumSize = new Size(350, 25);

                                if (((txtBase)control).Name.ToUpper().StartsWith("Sifra".ToUpper()))
                                {
                                    control.C_OnlyNumbers = true;
                                    control.C_ShowRedOnLeaveIfEmpty = true;
                                }

                                if (((txtBase)control).MaxLength < 25)
                                {
                                    control.Size = new Size(control.MaxLength * 10, control.Size.Height);
                                }
                                else
                                {
                                    control.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left))));
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual bool validacija()
        {
            var imaCrveni = false;
            foreach (Control control in groupVnes.Controls)
            {
                if (control is TextBox)
                {
                    if (control.BackColor == Color.Tomato || control.BackColor == Color.Red)
                    {
                        control.Focus();
                        NeZatvoraj = true;
                        imaCrveni = true;
                    }
                }
            }

            return !imaCrveni;
        }

        public bool ProveriZaValidirani()
        {
            foreach (TabPage tab in MainTab.TabPages)
            {
                foreach (GroupBox groupBox in tab.Controls.OfType<GroupBox>())
                {
                    foreach (txtBase ctrl in groupBox.Controls.OfType<txtBase>())
                    {
                        if (ctrl.ImaNestoSmeneto == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public virtual void Oznaci_ZadolzitelniVoSekojTab()
        {
            foreach (TabPage tab in MainTab.TabPages)
            {
                foreach (GroupBox groupVnes in tab.Controls.OfType<GroupBox>())
                {
                    Oznaci_Zadolzitelni(groupVnes);
                }
            }
        }

        private void frmEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                CancelButton.PerformClick();
            }
            if(e.KeyCode == Keys.F10)
            {
                AcceptButton.PerformClick();
            }
        }

        public virtual void Oznaci_Zadolzitelni(GroupBox groupbox = null)
        {
            if (Equals(null, groupbox))
            {
                groupbox = groupVnes;
            }
            foreach (txtBase control in groupbox.Controls.OfType<txtBase>())
            {
                if (control.IsTextEmpty() && control.C_ShowRedOnLeaveIfEmpty)
                {
                    control.BackColor = Color.Red;
                }
                else
                {
                    control.BackColor = Color.Empty;
                }
            }

            groupbox.SelectNextControl(groupVnes, true, true, true, true);
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if (!FormIsEdit)
            {
                Oznaci_Zadolzitelni();
            }
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NeZatvoraj)
            {
                e.Cancel = true;
            }
        }

        public void IzbrisiGreskaDole()
        {
            errorProviderDole.SetError(DisplayError, string.Empty);
            DisplayError.Text = string.Empty;
            DisplayError.Visible = false;
        }

        private void DisplayError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IzbrisiGreskaDole();
        }
    }
}
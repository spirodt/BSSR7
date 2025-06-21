using System;
using System.Linq;
using System.Windows.Forms;

namespace BssBase
{
    public partial class zbxBase : UserControl
    {
        public zbxBase()
        {
            InitializeComponent();
        }

        protected override void OnValidated(EventArgs e)
        {
            if (Value.Text.Length > 0)
            {
                base.OnValidated(e);
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnCreateControl()
        {
            if (showRedIfEmpty == true)
            {
                Value.C_ShowRedOnLeaveIfEmpty = true;
            }
            else
            {
                Value.C_ShowRedOnLeaveIfEmpty = false;
            }
            base.OnCreateControl();
        }

        public void zoomClear()
        {
            ret1 = string.Empty;
            ret2 = string.Empty;
            ret3 = string.Empty;
            ret4 = string.Empty;
            ret5 = string.Empty;
            ret6 = string.Empty;
            ret7 = string.Empty;
            ResetText();
            Value.Text = string.Empty;
            filter = string.Empty;
        }

        public bool showRedIfEmpty { set; get; }

        public string formToOpen { set; get; }

        public string GridFromForm { set; get; }

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
        public string filter = string.Empty;

        public bool KoristiFilterNaDatasource { set; get; }

        public string filterDataSource { set; get; }

        public bool IsTextEmpty(String txt)
        {
            return string.IsNullOrEmpty(txt);
        }

        public delegate void doneLoading();

        public event doneLoading DataRead;

        public bool read;

        public new string Text { set; get; }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                OpenForm();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void OpenForm()
        {
            read = false;
            if (Equals(null, AssemblyStr))
            {
                return;
            }
            var asm = System.Reflection.Assembly.Load(AssemblyStr);
            var t = asm.GetType(formToOpen); // CreateInstance( , true ).GetType();
            if (string.IsNullOrEmpty(filter) && KoristiFilterNaDatasource)
            {
                filter = Value.Text;
            }
            var frm = (frmBigShow)Activator.CreateInstance(t, new object[] { filter });
            if (KoristiFilterNaDatasource)
            {
                frm.Load += new EventHandler(frm_Load);
            }

            frm.ShowDialog();

            var dtr = frm.MainPanel.Controls.OfType<grdBase>().ToList().ElementAt(0).CurrentRow;

            if (!Equals(null, dtr))
            {
                if (frm.PrifatiKlik == true)
                {
                    Value.Text = dtr.Cells[ColumnName1].Value.ToString();

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
                    read = true;
                    if (!Equals(null, DataRead))
                    {
                        DataRead.Invoke();
                    }
                }
            }
            frm.Dispose();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            var forma = ((frmBigShow)sender);
            foreach (grdBase grid in forma.MainPanel.Controls.OfType<grdBase>())
            {
                if (string.IsNullOrEmpty(forma.GlavenFilter))
                {
                    forma.GlavenFilter = filterDataSource;
                }
                else
                {
                    forma.GlavenFilter = forma.GlavenFilter + " AND " + filterDataSource;
                }
                ((BindingSource)grid.BindingSource()).Filter = forma.GlavenFilter;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void Value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                OpenForm();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.OemBackslash)
            {
                zoomClear();
            }
        }

        public delegate void Izmena();

        public bool ovozmoziIzmena { get; set; }

        public event Izmena izmenaNaTekst;

        private void Value_TextChanged(object sender, EventArgs e)
        {
            if (ovozmoziIzmena)
            {
                if (!Equals(null, DataRead))
                {
                    izmenaNaTekst.Invoke();
                }
            }
        }

        private void zbxBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                OpenForm();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.OemBackslash)
            {
                zoomClear();
            }
        }
    }
}
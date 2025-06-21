using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using static System.String;

namespace BssBase
{
    public class DevGrid : GridControl
    {
        
        private readonly bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        private int _row = -1;
        public int ID1, ID2, ID3, ID4, ID5 = 0;
        public DataTable DefaultVrednostiZaGrid;
        private string SaveName = Empty;

        public string PrimaryKey { set; get; }

        public bool reportCenter { set; get; }

        public string UpdateTable { set; get; }

        public string AssemblyToLoad { set; get; }

        public bool prikaziMeniSoExportiranja = true;
       

        public string ReportName { set; get; }

        public string EditForm { set; get; }

        public string FilterForm { set; get; }


        public delegate void dataInsertEnd();

        public delegate void dataSave();

        public event dataInsertEnd DataInsert;
     

        public event dataSave dataSaveAll;

        public int curRow()
        {
            return _row;
        }

        public int SelectedIdFromTable()
        {
            using (var mainGridView1 = MainView as GridView)
            {
                if (mainGridView1 == null || !mainGridView1.GetSelectedRows().Any() ||
                    IsNullOrEmpty(PrimaryKey)) return -1;
                _row = mainGridView1.GetSelectedRows().First();
                return Tools.PrazenStringToInt(mainGridView1.GetDataRow(_row)[PrimaryKey].ToString());

            }
        }

        public bool IsFirstRowSelected()
        {
            return MainView is GridView curGrid && curGrid.GetFocusedDataSourceRowIndex() == 0;
        }
        private void SelektirajGiSite_Click(object sender, EventArgs e)
        {
            StiklirajGISite();
        }

        public virtual void obrabotigiSelektiraniteStavki()
        {
        }

        private void OznaciSelectirani_Click(object sender, EventArgs e)
        {
        }

        public void SetirajStikliranje(int displayIndex = 0)
        {
            var menu = ContextMenuStrip;
            using (var OznaciSelectirani = new ToolStripMenuItem(Tools.PrevediPoraka("OznacigiSelektiranite")) {Name = "OznaciSelectirani"})
            {
                OznaciSelectirani.Click += new EventHandler(OznaciSelectirani_Click);
                menu.Items.Add(OznaciSelectirani);
            }

            using (var SelektirajGiSite = new ToolStripMenuItem(Tools.PrevediPoraka("SelektirajGiSite")) {Name = "SelektirajGiSite"})
            {
                SelektirajGiSite.Click += new EventHandler(SelektirajGiSite_Click);
                menu.Items.Add(SelektirajGiSite);
            }

            using (var ProkniziSelektirani = new ToolStripMenuItem(Tools.PrevediPoraka("ObrabotiSelektirani")))
            {
                ProkniziSelektirani.Name = "ProkniziSelektirani";
                ProkniziSelektirani.Click += new EventHandler(ObrabotiSelektirani_Click);
                menu.Items.Add(ProkniziSelektirani);
            }

            ContextMenuStrip = menu;
            using (var chk = new DataGridViewCheckBoxColumn(false))
            {
                chk.Name = "STIKLIRANO";
                chk.HeaderText = " ";
                chk.DataPropertyName = "STIKLIRANO";
                chk.DisplayIndex = displayIndex;
                chk.Visible = true;
                chk.MinimumWidth = 25;
                chk.Width = 25;
                chk.TrueValue = true;
                chk.ValueType = typeof(bool);
                chk.DefaultCellStyle.NullValue = false;
            }

        }

        public void StiklirajGISite()
        {
        }

        private void ObrabotiSelektirani_Click(object sender, EventArgs e)
        {
            obrabotigiSelektiraniteStavki();
        }
        
        public void zameniMeni(ContextMenuStrip menu)
        {
            this.ContextMenuStrip = menu;
        }
        
        protected void Excel_Click(object sender, EventArgs e)
        {
            using (var fileDlg = new SaveFileDialog() { Filter = "Excel Files | *.xls", DefaultExt = "xls" })
            {
                var result = fileDlg.ShowDialog();
                if (result == DialogResult.Cancel) return;
                var filePath = fileDlg.FileName;
                ExportToXls(filePath);
            }
        }

        
        private void SetColumnOrder(string Savename)
        {
            foreach (DevExpress.XtraGrid.Views.Base.BaseView item in ViewCollection)
            {
                Savename = Savename + item.Name;
                var obd = Tools.getUserConfig(Savename);
                if (IsNullOrEmpty(obd))
                {
                    return;
                }
                var doc = new XmlDocument();
                doc.LoadXml(obd);
                doc.Save("tmpx.xml");

                item.RestoreLayoutFromXml("tmpx.xml", DevExpress.Utils.OptionsLayoutBase.FullLayout);
                File.Delete("tmpx.xml");
                
            }
        }

        private void SaveColumnOrder(string Savename)
        {
            foreach (DevExpress.XtraGrid.Views.Base.BaseView item in ViewCollection)
            {
                Savename = Savename + item.Name;
                item.SaveLayoutToXml(Savename, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                Tools.WriteUserConfig(Savename, File.ReadAllText(Savename));
                File.Delete(Application.StartupPath + "\\" + Savename); 

            }
        }
        
        public void Osvezi()
        {
            DataInsert?.Invoke();
        }
        
        
        public void blokiraj()
        {
            var mainGridView1 = MainView as GridView;

            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                var crow = curRow();
                if (!Equals(((BindingSource)DataSource).Current, null))
                {
                    crow = ((BindingSource)DataSource).Position;
                }

                var opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    var value = Tools.PrazenStringToInt(mainGridView1.GetRowCellValue(curRow(), "Status").ToString());
                    if (value == 0)
                    {
                        mainGridView1.SetRowCellValue(curRow(), "Status", 1);
                    }
                    else
                    {
                        mainGridView1.SetRowCellValue(curRow(), "Status", 0);
                    }
                    if (!Equals(null, dataSaveAll))
                    {
                        try
                        {
                            dataSaveAll.Invoke();
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                        }
                    }
                    if (!Equals(null, DataInsert))
                    {
                        DataInsert.Invoke();
                    }
                    ((BindingSource)DataSource).Position = crow;
                }
            }
        }

        public void Edit()
        {
            var row = curRow();

            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                row = ((BindingSource)DataSource).Position;
            }
            try
            {
                if (!IsNullOrEmpty(EditForm))
                {
                    if (EditForm.Length > 1)
                    {
                        try
                        {
                            System.Reflection.Assembly asm;
                            if (IsNullOrEmpty(AssemblyToLoad))
                            {
                                asm = System.Reflection.Assembly.Load(EditForm.Split('.').First());
                            }
                            else
                            {
                                asm = System.Reflection.Assembly.Load(AssemblyToLoad);
                            }
                            if (asm != null)
                            {
                                if (SelectedIdFromTable() != -1)
                                {
                                    var t = asm.CreateInstance(EditForm, true).GetType();
                                    var act = FindForm();

                                    var frm = (frmBigEdit)Activator.CreateInstance(t, new object[] { SelectedIdFromTable() });

                                    frm.ReadOnlyForm = ReadOnlyForm();
                                    frm.ID = SelectedIdFromTable();
                                    frm.ID1 = ID1;
                                    frm.ID2 = ID2;
                                    frm.ID3 = ID3;
                                    frm.ID4 = ID5;
                                    frm.Text = act.Text;
                                    if (!IsNullOrEmpty(Parent.Text))
                                    {
                                        frm.Text += " - " + Parent.Text;
                                    }

                                    if (frm.proveriPrivilegii(t.Name))
                                    {
                                        frm.ShowDialog();
                                    }
                                    if (!Equals(null, DataInsert))
                                    {
                                        DataInsert.Invoke();
                                    }
                                    ((BindingSource)DataSource).Position = row;

                                    frm.Dispose();
                                }
                            }
                        }
                        catch (NullReferenceException )
                        {
                            MessageBox.Show(Tools.PrevediPoraka("NemaEditForma"), Tools.PrevediPoraka("Greska!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.LogWriteText("FUNCKCIJA Edit");
                Tools.LogWriteText(ex.Message);
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        public void izbrisi()
        {
            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                var row = ((BindingSource)DataSource).Position;
                var opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    if (!Equals(((BindingSource)DataSource).Current, null))
                    {
                        ((BindingSource)DataSource).RemoveCurrent();
                    }
                    if (!Equals(null, dataSaveAll))
                    {
                        try
                        {
                            dataSaveAll.Invoke();
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                        }
                    }

                    if (!Equals(null, DataInsert))
                    {
                        DataInsert.Invoke();
                    }
                    ((BindingSource)DataSource).Position = row + 1;
                }
                else
                {
                    ((BindingSource)DataSource).Position = row;
                }
            }
        }

        public void Insert()
        {
            var gridView1 = MainView as GridView;
            try
            {
                if (!IsNullOrEmpty(EditForm))
                {
                    if (EditForm.Length > 1)
                    {
                        try
                        {
                            System.Reflection.Assembly asm;
                            if (IsNullOrEmpty(AssemblyToLoad))
                            {
                                asm = System.Reflection.Assembly.Load(EditForm.Split('.').First());
                            }
                            else
                            {
                                asm = System.Reflection.Assembly.Load(AssemblyToLoad);
                            }
                            if (asm != null)
                            {
                                var t = asm.CreateInstance(EditForm, true).GetType();
                                var act = FindForm();
                                var frm = (frmBigEdit)Activator.CreateInstance(t, true);
                                frm.ID1 = ID1;
                                frm.ID2 = ID2;
                                frm.ID3 = ID3;
                                frm.ID4 = ID5;
                                frm.Text = act.Text;
                                if (!IsNullOrEmpty(Parent.Text))
                                {
                                    frm.Text += " - " + Parent.Text;
                                }
                                DialogResult result;
                                if (frm.proveriPrivilegii(t.Name))
                                {
                                    result = frm.ShowDialog();

                                    if (!Equals(null, DataInsert))
                                    {
                                        DataInsert.Invoke();
                                    }
                                    var row = 0;
                                    if (!Equals(((BindingSource)DataSource).Current, null))
                                    {
                                        row = gridView1.GetSelectedRows().First();
                                        ((BindingSource)DataSource).Position = row;
                                    }
                                }

                                frm.Dispose();
                            }
                        }
                        catch (NullReferenceException )
                        {
                            MessageBox.Show(Tools.PrevediPoraka("NemaEditForma"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.LogWriteText("FUNCKCIJA ");
                Tools.LogWriteText(ex.Message);
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        public bool ReadOnlyForm()
        {
            using (var maingridView1 = MainView as GridView)
            {
                if (maingridView1 != null && maingridView1.GetSelectedRows().Any() && !IsNullOrEmpty(PrimaryKey))
                {
                    _row = maingridView1.GetSelectedRows().First();
                    var status = Tools.PrazenStringToInt(maingridView1.GetDataRow(_row)["Status"].ToString());
                    if (status == 0)
                    {
                        return false;
                    }

                    if (status == 1)
                    {
                        return true;
                    }

                    return false;
                }

                return false;
            }
        }

        public string Filter()
        {
            try
            {
                if (!IsNullOrEmpty(FilterForm))
                {
                    if (FilterForm.Length > 0)
                    {
                        Assembly asm = Assembly.Load(IsNullOrEmpty(AssemblyToLoad) ? EditForm.Split('.').First() : AssemblyToLoad);
                        if (asm != null)
                        {
                            var filter = "*";
                            var t = asm.CreateInstance(FilterForm, true)?.GetType();
                            if (t != null)
                            {
                                var frm = (frmBigEdit)Activator.CreateInstance(t, true);
                                frm.ShowDialog();
                                filter = frm.FilterString;
                                DataInsert?.Invoke();
                                frm.Dispose();
                            }

                            return filter;
                        }
                    }
                }
                return Empty;
            }
            catch (Exception ex)
            {
                Tools.LogWriteText("FUNCKCIJA ");
                Tools.LogWriteText(ex.Message);
                Tools.PrevediSQLException(ex);
                return "*";
            }
            
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (settings.designMode)
            {
                if (!designMode)
                {
                    SaveColumnOrder(SaveName);
                }
            }
            base.OnLostFocus(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (settings.designMode)
            {
                string saveNamed;

                if (FindForm() != null)
                {
                    saveNamed = $"{FindForm()?.Name}.{Name}.{Environment.MachineName}";
                }
                else
                {
                    saveNamed = $"frmBezParent_.{Name}.{Environment.MachineName}";
                }
                if (!designMode)
                {
                    SetColumnOrder(saveNamed);
                }
            }
        }
        protected bool NewMenu = false;
        public void AddItemToMenu(ToolStripItem item)
        {
            NewMenu = true;
            CreateMenu();
            this.ContextMenuStrip.Items.Add(item);
        }
        public void AddItemsToMenu(List<ToolStripMenuItem> items)
        {
            NewMenu = true;
            CreateMenu();
            this.ContextMenuStrip.Items.AddRange(items.ToArray());
        }
        protected override void OnLoaded()
        {
            base.OnLoaded();
            

        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            if (null != FindForm())
            {
                SaveName = FindForm() != null ? $"{FindForm().Name}.{Name}.{Environment.MachineName}" : $"frmBezParent_.{Name}.{Environment.MachineName}";
            }
            if (!NewMenu)
            {
                CreateMenu();
            }
        }

        public void CreateMenu()
        {
            var menu = new ContextMenuStrip();

            var fontPlus = new ToolStripMenuItem(Tools.PrevediPoraka("Зголеми фонт +"));
            if (!designMode)
            {
                using (var print = new ToolStripMenuItem(Tools.PrevediPoraka("PrintGridText")))
                {
                    print.Click += print_Click;
                    print.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    print.Image = Properties.Resources.printer;
                    menu.Items.Add(print);
                }

                fontPlus.Click += fontPlus_Click;
                fontPlus.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                // fontPlus.Image = BssBase.Properties.Resources.printer;
                menu.Items.Add(fontPlus);

                using (var fontMinus = new ToolStripMenuItem(Tools.PrevediPoraka("Намали фонт -")))
                {
                    fontMinus.Click += FontMinus_Click;
                    fontMinus.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    //FontMinus.Image = BssBase.Properties.Resources.d;
                    menu.Items.Add(fontMinus);
                }

                this.ContextMenuStrip = menu;
            }
        }

        void FontMinus_Click(object sender, EventArgs e)
        {
            var grview = (GridView)Views[0];
            grview.Appearance.Row.Font = new System.Drawing.Font(grview.Appearance.Row.Font.FontFamily, grview.Appearance.Row.Font.Size - 1);
                            
        }

        void fontPlus_Click(object sender, EventArgs e)
        {
            var grview = (GridView)Views[0];
            grview.Appearance.Row.Font = new System.Drawing.Font(grview.Appearance.Row.Font.FontFamily, grview.Appearance.Row.Font.Size + 1);
            
        }

        private void print_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = this;
            link.Landscape = true;

            phf?.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = FindForm().Text;
            const string rightColumn = "Датум: [Date Printed]";

            phf?.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            if (phf != null)
            {
                phf.Header.LineAlignment = BrickAlignment.Near;
                phf.Footer.Content.Clear();
            }


            link.ShowPreview();
        }
        
        protected virtual void OnDataInsert()
        {
            DataInsert?.Invoke();
        }
    }
}
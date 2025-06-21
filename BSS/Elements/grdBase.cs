using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using BssBase.Classes;

namespace BssBase
{
    [Description("Nasa kontrola")]
    [ToolboxBitmap(typeof(DataGridView))]
    public class grdBase : DataGridView
    {
        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        public string SQLCommandQuery { set; get; }

        public grdBase()
        {
            if (settings.RazlicniBoiNaRedicVoGrid)
            {
                var altering = new DataGridViewCellStyle();
                altering.BackColor = Color.AliceBlue;
                AlternatingRowsDefaultCellStyle = altering;
            }
            if (!string.IsNullOrEmpty(SQLCommandQuery))
            {
                NapolniGrid();
            }
        }

        public void NapolniGrid()
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                var dt = new DataTable();
                try
                {
                    using (var com = new SqlCommand(SQLCommandQuery, con))
                    {
                        con.Open();
                        dt.Load(com.ExecuteReader());
                        con.Close();
                        DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    Tools.PrevediSQLException(ex);
                    return;
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        public bool PrikaziStatusBar { set; get; }

        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        public bool PrikaziDialogZaGreskaNaDataErrorEvent { set; get; }

        protected override void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e)
        {
            base.OnDataError(PrikaziDialogZaGreskaNaDataErrorEvent, e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }

        protected override void OnNewRowNeeded(DataGridViewRowEventArgs e)
        {
            e.Row.ToString();
            base.OnNewRowNeeded(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //if ( !txtSearch.Visible ) {
            //    e.Handled = false;
            //}
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                try
                {
                    if (FindForm() is frmBigEdit)
                    {
                        ((frmBigEdit)FindForm()).btnOk.PerformClick();
                        return;
                    }
                    if (FindForm() is frmBigShow)
                    {
                        if (((frmBigShow)FindForm()).zoom == true)
                        {
                            //base.OnKeyDown(e);
                            ((frmBigShow)FindForm()).btnOk.PerformClick();
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(EditForm))
                    {
                        if (!EditiranjeVoGrid)
                        {
                            Edit();
                        }
                        else
                        {
                            base.OnKeyDown(e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Tools.LogWriteText("FUNCKCIJA OnKeyDown_Grid");
                    Tools.LogWriteText(ex.Message);
                    base.OnKeyDown(e);
                }
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        /// <summary>
        /// asd
        /// </summary>
        public class KolonaBssBaseTXT : DataGridViewColumn
        {
            [EditorBrowsable(EditorBrowsableState.Always),
            Localizable(true),
            DefaultValue(true)]
            public bool SamoBrojke { set; get; }

            public bool NeSmeeDaBidePrazna { set; get; }

            public KolonaBssBaseTXT()
                : base(new KolonaBssBaseTXTCell())
            {
            }

            public override object Clone()
            {
                var that = (KolonaBssBaseTXT)base.Clone();
                that.SamoBrojke = SamoBrojke;
                that.NeSmeeDaBidePrazna = NeSmeeDaBidePrazna;
                return that;
            }

            public override DataGridViewCell CellTemplate
            {
                get => base.CellTemplate;
                set
                {
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(KolonaBssBaseTXT)))
                    {
                        throw new InvalidCastException("It should be a KolonaBssBaseTXT Cell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class KolonaBssBaseTXTCell : DataGridViewTextBoxCell
        {
            public bool validated = false;

            public override Type ValueType => typeof(KolonaBssBaseTXTCell);

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
                        return !isDecimalPoint;
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

            protected override void OnKeyDown(KeyEventArgs e, int rowIndex)
            {
                base.OnKeyDown(e, rowIndex);
            }

            protected override void OnKeyPress(KeyPressEventArgs e, int rowIndex)
            {
                base.OnKeyPress(e, rowIndex);
            }
        }

        public class KolonaBoolSoTekst : DataGridViewColumn
        {
            [EditorBrowsable(EditorBrowsableState.Always),
            Localizable(true),
            DefaultValue("Da")]
            public string TextZaTrue { set; get; }

            [EditorBrowsable(EditorBrowsableState.Always),
            Localizable(false),
            DefaultValue(false)]
            public bool ZemiPrevodOdBaza { set; get; }

            [EditorBrowsable(EditorBrowsableState.Always),
            Localizable(true),
            DefaultValue("Ne")]
            public string TextZaFalse { set; get; }

            public KolonaBoolSoTekst()
                : base(new KolonaBoolSoTekstCell())
            {
            }

            public override object Clone()
            {
                var that = (KolonaBoolSoTekst)base.Clone();
                that.TextZaFalse = TextZaFalse;
                that.TextZaTrue = TextZaTrue;
                that.ZemiPrevodOdBaza = ZemiPrevodOdBaza;
                return that;
            }

            public override DataGridViewCell CellTemplate
            {
                get => base.CellTemplate;
                set
                {
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(KolonaBoolSoTekst)))
                    {
                        throw new InvalidCastException("It should be a MyDataGridCell Cell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class KolonaBoolSoTekstCell : DataGridViewTextBoxCell
        {
            public override Type ValueType => typeof(DataGridViewTextBoxCell);

            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (value.ToString().ToUpper() == "true".ToUpper())
                {
                    if (!((KolonaBoolSoTekst)OwningColumn).ZemiPrevodOdBaza)
                    {
                        value = ((KolonaBoolSoTekst)OwningColumn).TextZaTrue;
                        formattedValue = ((KolonaBoolSoTekst)OwningColumn).TextZaTrue;
                    }
                    else
                    {
                        value = Tools.PrevediPoraka(((KolonaBoolSoTekst)OwningColumn).TextZaTrue);
                        formattedValue = Tools.PrevediPoraka(((KolonaBoolSoTekst)OwningColumn).TextZaTrue);
                    }
                }

                if (value.ToString().ToUpper() == "false".ToUpper())
                {
                    if (!((KolonaBoolSoTekst)OwningColumn).ZemiPrevodOdBaza)
                    {
                        value = ((KolonaBoolSoTekst)OwningColumn).TextZaFalse;
                        formattedValue = ((KolonaBoolSoTekst)OwningColumn).TextZaFalse;
                    }
                    else
                    {
                        value = Tools.PrevediPoraka(((KolonaBoolSoTekst)OwningColumn).TextZaFalse);
                        formattedValue = Tools.PrevediPoraka(((KolonaBoolSoTekst)OwningColumn).TextZaFalse);
                    }
                }

                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
        }

        private bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        private int row = -1;
        private int column = -1;
        public int ID1, ID2, ID3, ID4, ID5 = 0;

        public string PrimaryKey { set; get; }

        public bool reportCenter { set; get; }

        public string UpdateTable { set; get; }

        public string EditForm { set; get; }

        public string AssemblyToLoad { set; get; }

        public bool prikaziMeniSoExportiranja = true;

        public string ReportName { set; get; }

        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        public bool EditiranjeVoGrid { set; get; }

        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        public bool DodadiBrisenjeNaStavkaVoMeni { set; get; }

        public PrintDocument MyPrintDocument;
        private string SaveName = string.Empty;
        public DataGridViewPrinter MyDataGridViewPrinter;

        public string FilterForm { set; get; }

        public delegate void dataInsertEnd();

        public delegate void dataSave();

        /// <summary>
        /// obrabotka na redovi so check box
        ///
        /// </summary>
        public void SetirajStikliranje(int displayIndex = 0)
        {
            var menu = ContextMenuStrip;

            if (menu == null)
            {
                menu = new ContextMenuStrip();
            }
            var OznaciSelectirani = new ToolStripMenuItem(Tools.PrevediPoraka("OznacigiSelektiranite"));
            OznaciSelectirani.Name = "OznaciSelectirani";
            OznaciSelectirani.Click += new EventHandler(OznaciSelectirani_Click);
            menu.Items.Add(OznaciSelectirani);

            var SelektirajGiSite = new ToolStripMenuItem(Tools.PrevediPoraka("SelektirajGiSite"));
            SelektirajGiSite.Name = "SelektirajGiSite";
            SelektirajGiSite.Click += new EventHandler(SelektirajGiSite_Click);
            menu.Items.Add(SelektirajGiSite);

            var ProkniziSelektirani = new ToolStripMenuItem(Tools.PrevediPoraka("ObrabotiSelektirani"));
            ProkniziSelektirani.Name = "ProkniziSelektirani";
            ProkniziSelektirani.Click += new EventHandler(ObrabotiSelektirani_Click);
            menu.Items.Add(ProkniziSelektirani);
            ContextMenuStrip = menu;

            if (!Columns.Contains("STIKLIRANO"))
            {
                var chk = new DataGridViewCheckBoxColumn(false);
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
                Columns.Insert(0, chk);
                CellClick += new DataGridViewCellEventHandler(grdBase_CellClickStikliranje);
                ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(grdBase_ColumnHeaderMouseClickStikiranje);
                foreach (DataGridViewRow item in Rows)
                {
                    item.Cells["STIKLIRANO"].Value = false;
                }
            }
        }

        private void grdBase_ColumnHeaderMouseClickStikiranje(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow item in Rows)
                {
                    var value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    item.Cells["STIKLIRANO"].Value = !value;
                }
            }
        }

        private void grdBase_CellClickStikliranje(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var value = Equals(this[e.ColumnIndex, e.RowIndex].Value, null) ? false : (bool)(this["STIKLIRANO", e.RowIndex].Value);
                this[e.ColumnIndex, e.RowIndex].Value = !value;
            }
        }

        public virtual void obrabotigiSelektiraniteStavki()
        {
        }

        private void ObrabotiSelektirani_Click(object sender, EventArgs e)
        {
            obrabotigiSelektiraniteStavki();
        }

        public void StiklirajGISite()
        {
            foreach (DataGridViewRow item in Rows)
            {
                item.Cells["STIKLIRANO"].Value = true;
            }
        }

        private void SelektirajGiSite_Click(object sender, EventArgs e)
        {
            StiklirajGISite();
        }

        private void OznaciSelectirani_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in SelectedRows)
            {
                var value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);
                item.Cells["STIKLIRANO"].Value = !value;
            }
        }

        private bool SetupThePrinting()
        {
            var MyPrintDialog = new PrintDialog();

            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = true;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = true;
            MyPrintDialog.PrintToFile = true;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            MyPrintDocument = new PrintDocument();
            MyPrintDocument.PrintPage += new PrintPageEventHandler(MyPrintDocument_PrintPage);
            if (settings.designMode)
            {
                if (designMode)
                {
                    MyPrintDocument.DocumentName = "Преглед од табела";
                }
                else
                {
                    MyPrintDocument.DocumentName = Tools.PrevediPoraka("reportOdGridName");
                }
            }
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            if (Columns.Count > 5)
            {
                MyPrintDocument.DefaultPageSettings.Landscape = true;
            }
            MyDataGridViewPrinter = new DataGridViewPrinter(this, MyPrintDocument, true, true, ReportName, new Font("Tahoma", 22, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        public event dataInsertEnd DataInsert;

        public event dataSave dataSaveAll;

        public DataGridViewRow getRow()
        {
            return CurrentRow;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (Columns[e.ColumnIndex].Name.Contains("ID"))
            {
                return;
            }
            if (!Equals(e.Value, null) && string.IsNullOrEmpty(e.CellStyle.Format))
            {
                if (e.RowIndex != NewRowIndex)
                {
                    if (e.FormattingApplied == false)
                    {
                        if (e.Value.GetType().ToString() == "System.Int32")
                        {
                            e.CellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("mk-MK");
                            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            e.CellStyle.Format = "N2";
                        }

                        if (e.Value.GetType().ToString() == "System.Decimal")
                        {
                            e.CellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("mk-MK");
                            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            e.CellStyle.Format = "N2";
                        }

                        if (e.Value.GetType().ToString() == "System.DateTime")
                        {
                            if (string.IsNullOrEmpty(e.CellStyle.Format))
                            {
                                e.CellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("mk-MK");
                                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                e.CellStyle.Format = "d";
                            }
                            else
                            {
                                e.CellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("mk-MK");
                                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            }
                        }
                    }
                }
                base.OnCellFormatting(e);
            }
        }

        private bool prikaziBlokiraj = false;

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        public int SelectedIdFromTable()
        {
            if (CurrentCell != null && CurrentRow != null)
            {
                if (!string.IsNullOrEmpty(PrimaryKey))
                {
                    return Convert.ToInt32(base[PrimaryKey, curRow()].Value.ToString());
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        public int curRow()
        {
            return row;
        }

        public int curColum()
        {
            return column;
        }

        protected override void OnColumnNameChanged(DataGridViewColumnEventArgs e)
        {
            base.OnColumnNameChanged(e);
        }

        public void MyPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
            {
                e.HasMorePages = true;
            }
        }

        protected void Excel_Click(object sender, EventArgs e)
        {
            if (settings.ExportToExcell)
            {
                ExportToExcelBase.ExportGridToExcel(this);
            }
        }

        protected void Konfiguracija_Click(object sender, EventArgs e)
        {
            if (!Equals(null, CurrentCell.OwningColumn))
            {
                var config = new Forms.frmGridConfig(CurrentCell.OwningColumn);
                var dlg = config.ShowDialog();
                config.Dispose();
                if (dlg == DialogResult.OK)
                {
                    SaveColumnOrder(SaveName);
                }
            }
        }

        protected void konfiguracijaNaKoloni_Click(object sender, EventArgs e)
        {
            var lista = new Dictionary<string, bool>();
            for (var i = 0; i < Columns.Count; i++)
            {
                lista.Add(String.Format("{0}: - {1}", Columns[i].Index, Columns[i].HeaderText), Columns[i].Visible);
            }

            var config = new Forms.frmGridConfigKolone(lista);
            var dlg = config.ShowDialog();
            if (!Equals(null, config.ListaVrati))
            {
                lista = config.ListaVrati;
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        var index = Convert.ToInt32(item.Key.Split(':').First());
                        Columns[index].Visible = item.Value;
                    }
                }
            }
            config.Dispose();
            if (dlg == DialogResult.OK)
            {
                SaveColumnOrder(SaveName);
            }
        }

        protected void print_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                var print = new Forms.printGrid(MyPrintDocument);
                print.ShowDialog();
                print.Dispose();
                MyPrintDocument.Dispose();
            }
        }

        public void SrediMeni()
        {
            if (settings.NeSreduajMeni == true)
            {
                return;
            }
            if (!string.IsNullOrEmpty(EditForm))
            {
                SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                EditMode = DataGridViewEditMode.EditProgrammatically;
                ((frmBigShow)FindForm()).btnEditirajZapis.Visible = true;
                ((frmBigShow)FindForm()).btnNovZapis.Visible = true;
            }
            else
            {
                ((frmBigShow)FindForm()).btnEditirajZapis.Visible = false;
                ((frmBigShow)FindForm()).btnNovZapis.Visible = false;
            }

            if (!string.IsNullOrEmpty(FilterForm))
            {
                ((frmBigShow)FindForm()).btnFilter.Visible = true;
            }
            else
            {
                ((frmBigShow)FindForm()).btnFilter.Visible = false;
            }
            if (Columns.Contains("Status"))
            {
                prikaziBlokiraj = true;
            }

            if (prikaziBlokiraj)
            {
                ((frmBigShow)FindForm()).btnBlokiraj.Visible = true;
            }
            else
            {
                ((frmBigShow)FindForm()).btnBlokiraj.Visible = false;
            }

            if (Tools.proveriPrivilegii("ADMIN"))
            {
                ((frmBigShow)FindForm()).btnIzbrisi.Visible = true;
            }
            else
            {
                ((frmBigShow)FindForm()).btnIzbrisi.Visible = false;
            }

            if (((frmBigShow)FindForm()).zoom == true)
            {
                ((frmBigShow)FindForm()).btnOk.Visible = true;
            }
            else
            {
                ((frmBigShow)FindForm()).btnOk.Visible = false;
            }
        }

        protected override void OnColumnHeaderMouseDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            var config = new Forms.frmGridConfig(Columns[e.ColumnIndex]);
            config.ShowDialog();
            config.Dispose();
            base.OnColumnHeaderMouseDoubleClick(e);
        }

        public void zameniMeni(ContextMenuStrip menu)
        {
            ContextMenuStrip = menu;
        }

        public ContextMenuStrip getMenu()
        {
            return ContextMenuStrip;
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (settings.designMode)
            {
                if (!designMode)
                {
                    if (!Equals(null, FindForm()))
                    {
                        if (!Equals(FindForm(), null))
                        {
                            SaveName = String.Format("{0}.{1}.{2}", FindForm().Name, Name,Environment.MachineName);
                        }
                        else
                        {
                            SaveName = String.Format("frmBezParent_.{0}.{1}", Name, Environment.MachineName);
                        }

                        if (FindForm() is frmShow || FindForm() is frmBigShow)
                        {
                            SrediMeni();
                        }

                        if (prikaziMeniSoExportiranja)
                        {
                            var menu = new ContextMenuStrip();
                            var MeniText = "Print";

                            if (!designMode)
                            {
                                if (DodadiBrisenjeNaStavkaVoMeni)
                                {
                                    var izbriSiStavka = new ToolStripMenuItem(Tools.PrevediPoraka("IzbrisiStavka"));
                                    izbriSiStavka.Click += new EventHandler(izbriSiStavka_Click);
                                    menu.Items.Add(izbriSiStavka);
                                }
                            }
                            if (!designMode)
                            {
                                MeniText = Tools.PrevediPoraka("Prebaruvanje");
                                var prebaraj = new ToolStripMenuItem(MeniText);
                                prebaraj.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                prebaraj.Image = Properties.Resources._001_38;

                                var Prebaruvaj = new ToolStripMenuItem(Tools.PrevediPoraka("Prebaruvaj"));
                                Prebaruvaj.Click += new EventHandler(Prebaruvaj_Click);
                                Prebaruvaj.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                Prebaruvaj.Image = Properties.Resources._001_38;
                                prebaraj.DropDownItems.Add(Prebaruvaj);
                                var Resetiraj = new ToolStripMenuItem(Tools.PrevediPoraka("ResetirajPrebaruvanje"));
                                Resetiraj.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                Resetiraj.Image = Properties.Resources.undo1;
                                prebaraj.DropDownItems.Add(Resetiraj);
                                Resetiraj.Click += new EventHandler(Resetiraj_Click);
                                menu.Items.Add(prebaraj);
                                var separator = new ToolStripSeparator();
                                separator.Size = new Size(separator.Size.Width, separator.Size.Height + 5);
                                menu.Items.Add(separator);

                                var print = new ToolStripMenuItem(Tools.PrevediPoraka("PrintGridText"));
                                print.Click += new EventHandler(print_Click);
                                print.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                print.Image = Properties.Resources.printer;
                                menu.Items.Add(print);
                            }
                            

                            if (!designMode)
                            {
                                MeniText = Tools.PrevediPoraka("ExcelOdGrid");
                                var Excel = new ToolStripMenuItem(MeniText);
                                Excel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                Excel.Image = Properties.Resources.Preview_Docment;
                                Excel.Click += new EventHandler(Excel_Click);
                                menu.Items.Add(Excel);
                                var separator2 = new ToolStripSeparator();
                                separator2.Size = new Size(separator2.Size.Width, separator2.Size.Height + 5);
                                menu.Items.Add(separator2);
                                MeniText = Tools.PrevediPoraka("Konfiguracija");
                                var Konfiguracija = new ToolStripMenuItem(MeniText);
                                Konfiguracija.Click += new EventHandler(Konfiguracija_Click);
                                Konfiguracija.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                Konfiguracija.Image = Properties.Resources.XAML_file;
                                menu.Items.Add(Konfiguracija);

                                MeniText = Tools.PrevediPoraka("konfiguracijaNaKoloni");
                                var konfiguracijaNaKoloni = new ToolStripMenuItem(MeniText);
                                konfiguracijaNaKoloni.Click += new EventHandler(konfiguracijaNaKoloni_Click);
                                konfiguracijaNaKoloni.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                konfiguracijaNaKoloni.Image = Properties.Resources.XAML_file;
                                menu.Items.Add(konfiguracijaNaKoloni);

                                MeniText = Tools.PrevediPoraka("SrediDolzinaPodrediKoloni");
                                var PodrediKOloni = new ToolStripMenuItem(MeniText);
                                PodrediKOloni.Click += new EventHandler(PodrediKOloni_Click);
                                PodrediKOloni.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                PodrediKOloni.Image = Properties.Resources.EditTableHS;
                                menu.Items.Add(PodrediKOloni);

                                ContextMenuStrip = menu;
                            }
                        }
                    }
                }
            }
        }

        private void PodrediKOloni_Click(object sender, EventArgs e)
        {
            AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void searchGrid(TextBox txtBaraj)
        {
            var filter = string.Empty;
            if (string.IsNullOrEmpty(txtBaraj.Text))
            {
                return;
            }
            ((BindingSource)BindingSource()).Filter = string.Empty;
            Osvezi();
            foreach (DataGridViewCell cell in Rows[0].Cells)
            {
                var ColumnName = cell.OwningColumn.DataPropertyName.ToUpper();
                if (cell.Visible == true && !ColumnName.Contains("Id".ToUpper()) && !ColumnName.Contains("Status".ToUpper()) && cell.OwningColumn.CellType.Name == "DataGridViewTextBoxCell")
                {
                    if (cell.ValueType.ToString() == "System.String")
                    {
                        filter += String.Format("{0} LIKE '{1}' OR ", ColumnName, txtBaraj.Text);
                    }
                    else
                    {
                        if (cell.ValueType.ToString() == "System.Int32")
                        {
                            var number = txtBaraj.Text.Replace("*", string.Empty);
                            int broj;
                            var res = int.TryParse(number, out broj);
                            if (res == true)
                            {
                                filter += ColumnName + " = '" + broj.ToString() + "' OR ";
                            }
                        }
                    }
                }
            }
            if (filter.Length > 3)
            {
                filter = filter.Remove(filter.Length - 3, 3);
            }
            if (txtBaraj.Text.Length > 0 && filter != string.Empty)
            {
                try
                {
                    ((BindingSource)BindingSource()).Filter = filter;
                }
                catch (Exception ex)
                {
                    Tools.LogWriteText("FUNCKCIJA search_mdbrowse()");
                    Tools.LogWriteText(ex.Message);
                    MessageBox.Show(Tools.PrevediPoraka("nepralvilenFilter"), Tools.PrevediPoraka("Greska!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Resetiraj_Click(object sender, EventArgs e)
        {
            ((BindingSource)BindingSource()).Filter = string.Empty;
            Osvezi();
            txtSearch.Visible = false;
        }

        private void Prebaruvaj_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            txtSearch.Focus();
            searchGrid(txtSearch);
        }

        private void izbriSiStavka_Click(object sender, EventArgs e)
        {
            izbrisi();
        }

        private TextBox txtSearch;

        protected override void OnCreateControl()
        {
            txtSearch = new TextBox();
            txtSearch.Visible = false;
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.ForeColor = Color.DarkBlue;
            txtSearch.Font = new Font(txtSearch.Font.FontFamily, 11);
            txtSearch.BackColor = Color.LightGreen;
            txtSearch.AcceptsReturn = true;
            txtSearch.Leave += new EventHandler(txtSearch_Leave);
            Controls.Add(txtSearch);
            base.OnCreateControl();
            AllowUserToOrderColumns = true;
            if (settings.designMode)
            {
                string saveNamed;
                if (!Equals(FindForm(), null))
                {
                    saveNamed = String.Format("{0}.{1}.{2}", FindForm().Name, Name, Environment.MachineName);
                }
                else
                {
                    saveNamed = String.Format("frmBezParent_.{0}.{1}", Name, Environment.MachineName);
                }

                if (!designMode)
                {
                    srediIminjaNaGrid();
                    SetColumnOrder(saveNamed);
                }
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            searchGrid(txtSearch);
        }

        public void srediIminjaNaGrid()
        {
            for (var i = 0; i < Columns.Count; i++)
            {
                Columns[0].Name = Columns[0].DataPropertyName;
                if ((Columns[0].DataPropertyName.ToUpper().Contains("ID".ToUpper()) || Columns[0].DataPropertyName.ToUpper().Contains("Status".ToUpper())))
                {
                    Columns[0].Visible = false;
                }
            }
        }

        public string getBindingSourceName()
        {
            return ((BindingSource)DataSource).DataMember.ToString();
        }

        public bool ReadOnlyForm()
        {
            if (Equals(((BindingSource)DataSource).Current, null))
            {
                return false;
            }
            else
            {
                if (!Columns.Contains("Status"))
                {
                    return false;
                }
                if (CurrentRow.Cells["Status"].Value.ToString() == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public object getParentForm()
        {
            return FindForm();
        }

        public void Edit()
        {
            var row = 0;
            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                row = ((BindingSource)DataSource).Position;
            }
            try
            {
                if (!string.IsNullOrEmpty(EditForm))
                {
                    if (EditForm.Length > 1)
                    {
                        try
                        {
                            System.Reflection.Assembly asm;
                            if (string.IsNullOrEmpty(AssemblyToLoad))
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
                                    var t = asm.GetType(EditForm);
                                    var act = FindForm();

                                    var frm = (frmBigEdit)Activator.CreateInstance(t, new object[] { SelectedIdFromTable() });
                                    frm.ReadOnlyForm = ReadOnlyForm();
                                    frm.StartPosition = FormStartPosition.CenterScreen;
                                    frm.KeyDown += Frm_KeyDown;
                                    frm.ID = SelectedIdFromTable();
                                    frm.ID1 = ID1;
                                    frm.ID2 = ID2;
                                    frm.ID3 = ID3;
                                    frm.ID4 = ID5;
                                    frm.Text = act.Text;
                                    if (!string.IsNullOrEmpty(Parent.Text))
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

        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                ((frmBigEdit)sender).btnZatvori.PerformClick();
            }

            if (e.KeyCode == Keys.F12)
            {
                ((frmBigEdit)sender).btnOk.PerformClick();
            }
        }

        public void Osvezi()
        {
            if (!Equals(null, DataInsert))
            {
                DataInsert.Invoke();
            }
        }

        public void blokiraj()
        {
            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                var row = 0;
                if (!Equals(((BindingSource)DataSource).Current, null))
                {
                    row = ((BindingSource)DataSource).Position;
                }

                foreach (DataGridViewCell cell in CurrentRow.Cells)
                {
                    if (cell.OwningColumn.DataPropertyName == "Status")
                    {
                        DialogResult opc;
                        opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opc == DialogResult.Yes)
                        {
                            if (Equals(CurrentRow.Cells[cell.OwningColumn.Name].Value, DBNull.Value))
                            {
                                CurrentRow.Cells[cell.OwningColumn.Name].Value = 1;
                            }
                            else
                            {
                                if (Convert.ToInt32(CurrentRow.Cells[cell.OwningColumn.Name].Value.ToString()) == 1)
                                {
                                    CurrentRow.Cells[cell.OwningColumn.Name].Value = DBNull.Value;
                                }
                                else
                                {
                                    if (Convert.ToInt32(CurrentRow.Cells[cell.OwningColumn.Name].Value.ToString()) == 0)
                                    {
                                        CurrentRow.Cells[cell.OwningColumn.Name].Value = 1;
                                    }
                                }
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
                            ((BindingSource)DataSource).Position = row;
                        }
                    }
                }
            }
        }

        public void izbrisi()
        {
            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                var row = ((BindingSource)DataSource).Position;
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        public object BindingSource()
        {
            return (BindingSource)DataSource;
        }

        public void gotoLastInsertedRow(String Kolona, string searchValue)
        {
            int rowIndex = -1;

            DataGridViewRow row = Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[Kolona].Value.ToString().Equals(searchValue))
                .FirstOrDefault();
            rowIndex = row.Index;

            Rows[rowIndex].Selected = true;
        }

        public void gotoLastRow()
        {
            var row = 0;
            if (!Equals(((BindingSource)DataSource).Current, null))
            {
                row = Rows.GetLastRow(DataGridViewElementStates.Displayed);
                ((BindingSource)DataSource).Position = row;
            }
        }

        public void Insert()
        {
            try
            {
                if (!string.IsNullOrEmpty(EditForm))
                {
                    if (EditForm.Length > 1)
                    {
                        try
                        {
                            System.Reflection.Assembly asm;
                            if (string.IsNullOrEmpty(AssemblyToLoad))
                            {
                                asm = System.Reflection.Assembly.Load(EditForm.Split('.').First());
                            }
                            else
                            {
                                asm = System.Reflection.Assembly.Load(AssemblyToLoad);
                            }
                            if (asm != null)
                            {
                                var t = asm.GetType(EditForm);
                                var act = FindForm();
                                var frm = (frmBigEdit)Activator.CreateInstance(t, true);
                                frm.StartPosition = FormStartPosition.CenterScreen;
                                frm.ID1 = ID1;
                                frm.ID2 = ID2;
                                frm.ID3 = ID3;
                                frm.ID4 = ID5;
                                frm.Text = act.Text;
                                frm.KeyDown += Frm_KeyDown;
                                if (!string.IsNullOrEmpty(Parent.Text))
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
                                        row = Rows.GetLastRow(DataGridViewElementStates.Displayed);
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

        public string Filter()
        {
            try
            {
                if (!string.IsNullOrEmpty(FilterForm))
                {
                    if (FilterForm.Length > 0)
                    {
                        System.Reflection.Assembly asm;
                        if (string.IsNullOrEmpty(AssemblyToLoad))
                        {
                            asm = System.Reflection.Assembly.Load(EditForm.Split('.').First());
                        }
                        else
                        {
                            asm = System.Reflection.Assembly.Load(AssemblyToLoad);
                        }
                        if (asm != null)
                        {
                            var filter = "*";
                            var t = asm.CreateInstance(FilterForm.ToString(), true).GetType();
                            var frm = (frmBigEdit)Activator.CreateInstance(t, true);
                            frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.ShowDialog();
                            filter = frm.FilterString;
                            if (!Equals(null, DataInsert))
                            {
                                DataInsert.Invoke();
                            }
                            frm.Dispose();
                            return filter;
                        }
                    }
                }
                {
                    var type = this.Parent.GetType();
                    dynamic form = this.FindForm(); 
                    form.btnPrebaraj.PerformClick();

                }
                return string.Empty;
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

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.DataPropertyName == "Status")
                    {
                        if (Equals(row.Cells[cell.OwningColumn.Name].Value, null))
                        {
                            return;
                        }
                        if (row.Cells[cell.OwningColumn.Name].Value.ToString() == "1")
                        {
                            row.DefaultCellStyle.ForeColor = Color.Red;
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                            row.DefaultCellStyle.SelectionForeColor = Color.Red;
                        }

                        if (row.Cells[cell.OwningColumn.Name].Value.ToString() == "3")
                        {
                            row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionForeColor = Color.Red;
                        }

                        if (row.Cells[cell.OwningColumn.Name].Value.ToString() == "2")
                        {
                            row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionForeColor = Color.Red;
                        }

                        if (row.Cells[cell.OwningColumn.Name].Value.ToString() == "5")
                        {
                            row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionForeColor = Color.Red;
                        }
                    }
                }
            }

            base.OnDataBindingComplete(e);
        }

        private void SetColumnOrder(string LoadName)
        {
            if (!settings.NeSortirajKoloni)
            {
                if (AllowUserToOrderColumns)
                {
                    var obd = Tools.getUserConfig(LoadName);
                    var db = new DataSet();
                    if (string.IsNullOrEmpty(obd))
                    {
                        return;
                    }
                    var r = XmlReader.Create(new StringReader(obd));
                    db.ReadXml(r, XmlReadMode.Auto);
                    if (!Equals(db, null))
                    {
                        if (db.Tables.Count < 0)
                        {
                            return;
                        }
                        if (db.Tables[0].Rows.Count < 0)
                        {
                            return;
                        }
                        var columnOrder = new List<ColumnOrderItem>();

                        foreach (DataRow row in db.Tables[0].Rows)
                        {
                            var ColItem = new ColumnOrderItem();

                            ColItem.ColumnIndex = Convert.ToInt32(row["ColumnIndex"].ToString());

                            ColItem.DisplayIndex = Convert.ToInt32(row["DisplayIndex"].ToString());

                            ColItem.Visible = Convert.ToBoolean(row["Visible"].ToString());

                            ColItem.Width = Convert.ToInt32(row["Width"].ToString());

                            ColItem.BackColor = Color.FromArgb(Convert.ToInt32(row["BackColor"].ToString()));

                            ColItem.ForeColor = Color.FromArgb(Convert.ToInt32(row["ForeColor"].ToString()));

                            ColItem.SelectionBakcColor = Color.FromArgb(Convert.ToInt32(row["SelectionBakcColor"].ToString()));

                            ColItem.SelectionForeColor = Color.FromArgb(Convert.ToInt32(row["SelectionForeColor"].ToString()));

                            columnOrder.Add(ColItem);
                        }

                        if (columnOrder != null)
                        {
                            try
                            {
                                var sorted = columnOrder.OrderBy(i => i.DisplayIndex);
                                foreach (var item in sorted)
                                {
                                    Columns[item.ColumnIndex].DisplayIndex = item.DisplayIndex;

                                    Columns[item.ColumnIndex].Visible = item.Visible;

                                    Columns[item.ColumnIndex].Width = item.Width;

                                    if (item.BackColor != Color.FromArgb(0))
                                    {
                                        Columns[item.ColumnIndex].DefaultCellStyle.BackColor = item.BackColor;
                                    }
                                    if (item.ForeColor != Color.FromArgb(0))
                                    {
                                        Columns[item.ColumnIndex].DefaultCellStyle.ForeColor = item.ForeColor;
                                    }
                                    if (item.SelectionForeColor != Color.FromArgb(0))
                                    {
                                        Columns[item.ColumnIndex].DefaultCellStyle.SelectionForeColor = item.SelectionForeColor;
                                    }
                                    if (item.SelectionBakcColor != Color.FromArgb(0))
                                    {
                                        Columns[item.ColumnIndex].DefaultCellStyle.SelectionBackColor = item.SelectionBakcColor;
                                    }
                                }
                            }
                            catch (Exception )
                            {
                                Tools.removeUserConfig(LoadName);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void SaveColumnOrder(string SaveName)
        {
            
            if (!settings.NeSortirajKoloni)
            {
                if (AllowUserToOrderColumns)
                {
                    var columnOrder = new List<ColumnOrderItem>();
                    var columns = Columns;
                    var db = new DataSet(Name);
                    var tbl = new DataTable("tblKoloni");
                    tbl.Columns.Add("ColumnIndex", Type.GetType("System.String"));
                    tbl.Columns.Add("DisplayIndex", Type.GetType("System.String"));
                    tbl.Columns.Add("Visible", Type.GetType("System.String"));
                    tbl.Columns.Add("Width", Type.GetType("System.String"));
                    tbl.Columns.Add("BackColor", Type.GetType("System.Int32"));
                    tbl.Columns.Add("ForeColor", Type.GetType("System.Int32"));
                    tbl.Columns.Add("SelectionBakcColor", Type.GetType("System.Int32"));
                    tbl.Columns.Add("SelectionForeColor", Type.GetType("System.Int32"));
                    db.Tables.Add(tbl);

                    for (var i = 0; i < columns.Count; i++)
                    {
                        var row = db.Tables[0].NewRow();

                        columnOrder.Add(new ColumnOrderItem
                        {
                            ColumnIndex = i,
                            DisplayIndex = columns[i].DisplayIndex,
                            Visible = columns[i].Visible,
                            Width = columns[i].Width,
                            BackColor = columns[i].DefaultCellStyle.BackColor,
                            ForeColor = columns[i].DefaultCellStyle.ForeColor,
                            SelectionBakcColor = columns[i].DefaultCellStyle.SelectionBackColor,
                            SelectionForeColor = columns[i].DefaultCellStyle.ForeColor
                        });

                        row["ColumnIndex"] = i;
                        row["DisplayIndex"] = columns[i].DisplayIndex;
                        row["Visible"] = columns[i].Visible;
                        row["Width"] = columns[i].Width;
                        row["BackColor"] = columns[i].DefaultCellStyle.BackColor.ToArgb();
                        row["ForeColor"] = columns[i].DefaultCellStyle.ForeColor.ToArgb();
                        row["SelectionBakcColor"] = columns[i].DefaultCellStyle.SelectionBackColor.ToArgb();
                        row["SelectionForeColor"] = columns[i].DefaultCellStyle.SelectionForeColor.ToArgb();

                        db.Tables[0].Rows.Add(row);
                    }

                    var wr = new StringWriter();

                    db.WriteXml(wr, XmlWriteMode.WriteSchema);
                    var text = wr.ToString();
                    if (!Equals(null, columnOrder))
                    {
                        Tools.WriteUserConfig(SaveName, text);
                    }
                }
            }
        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            if (CurrentCell != null && CurrentRow != null)
            {
                column = CurrentCell.ColumnIndex;
                row = CurrentRow.Index;
            }
            base.OnSelectionChanged(e);
        }
    }
}
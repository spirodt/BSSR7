namespace MReport.Forms {
	partial class frmObrabotkaNaSmetki {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObrabotkaNaSmetki));
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.tblSmetkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSmetkaTableAdapter = new MReport.BSSRDataSetTableAdapters.tblSmetkaTableAdapter();
            this.tableAdapterManager = new MReport.BSSRDataSetTableAdapters.TableAdapterManager();
            this.tblNalogTableAdapter = new MReport.BSSRDataSetTableAdapters.tblNalogTableAdapter();
            this.tblSmetkaStavkiTableAdapter = new MReport.BSSRDataSetTableAdapters.tblSmetkaStavkiTableAdapter();
            this.tblSmetkaStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblNalogStavkiDevGrid = new BssBase.DevGrid();
            this.stavkiVoNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaSoRabatIddv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVProcent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresmetanDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.бришиСметкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бришиНалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бришиАртикалОдНалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.направиФактураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пратиНаДругКорисникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.печатиНоваФискалнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сторнирајФискалнаЗаСметкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblNalogDevGrid = new BssBase.DevGrid();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBroj1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumPocetok1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumKraj1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZavrsen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipNaNalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.txtSumFiskalni = new BssBase.Elements.Bsslabel();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.txtSumNalozi = new BssBase.Elements.Bsslabel();
            this.txtSumSmetki = new BssBase.Elements.Bsslabel();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.txtBase1 = new BssBase.txtBase();
            this.btnPrikazi = new BssBase.Elements.btnOtvori();
            this.stavkiVoNalogTableAdapter = new MReport.BSSRDataSetTableAdapters.StavkiVoNalogTableAdapter();
            this.stavkiZaFiskalNaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkiZaFiskalNaTableAdapter = new MReport.BSSRDataSetTableAdapters.StavkiZaFiskalNaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSmetkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSmetkaStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNalogBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNalogStavkiDevGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkiVoNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNalogDevGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkiZaFiskalNaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bSSRDataSet
            // 
            this.bSSRDataSet.DataSetName = "BSSRDataSet";
            this.bSSRDataSet.EnforceConstraints = false;
            this.bSSRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSmetkaBindingSource
            // 
            this.tblSmetkaBindingSource.DataMember = "tblSmetka";
            this.tblSmetkaBindingSource.DataSource = this.bSSRDataSet;
            // 
            // tblSmetkaTableAdapter
            // 
            this.tblSmetkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblConfigTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = this.tblNalogTableAdapter;
            this.tableAdapterManager.tblNarackiTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiIzmenetaTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = this.tblSmetkaStavkiTableAdapter;
            this.tableAdapterManager.tblSmetkaTableAdapter = this.tblSmetkaTableAdapter;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MReport.BSSRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblNalogTableAdapter
            // 
            this.tblNalogTableAdapter.ClearBeforeFill = true;
            // 
            // tblSmetkaStavkiTableAdapter
            // 
            this.tblSmetkaStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tblSmetkaStavkiBindingSource
            // 
            this.tblSmetkaStavkiBindingSource.DataMember = "FK_tblSmetkaStavki_tblSmetka";
            this.tblSmetkaStavkiBindingSource.DataSource = this.tblSmetkaBindingSource;
            this.tblSmetkaStavkiBindingSource.CurrentChanged += new System.EventHandler(this.tblSmetkaStavkiBindingSource_CurrentChanged);
            // 
            // tblNalogBindingSource
            // 
            this.tblNalogBindingSource.DataMember = "tblNalog";
            this.tblNalogBindingSource.DataSource = this.bSSRDataSet;
            this.tblNalogBindingSource.CurrentChanged += new System.EventHandler(this.tblNalogBindingSource_CurrentChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tblNalogStavkiDevGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tblNalogDevGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxBase1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tblNalogStavkiDevGrid
            // 
            this.tblNalogStavkiDevGrid.AssemblyToLoad = null;
            this.tblNalogStavkiDevGrid.DataSource = this.stavkiVoNalogBindingSource;
            this.tblNalogStavkiDevGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNalogStavkiDevGrid.EditForm = null;
            this.tblNalogStavkiDevGrid.FilterForm = null;
            this.tblNalogStavkiDevGrid.Location = new System.Drawing.Point(462, 276);
            this.tblNalogStavkiDevGrid.MainView = this.gridView4;
            this.tblNalogStavkiDevGrid.Name = "tblNalogStavkiDevGrid";
            this.tblNalogStavkiDevGrid.PrimaryKey = null;
            this.tblNalogStavkiDevGrid.reportCenter = false;
            this.tblNalogStavkiDevGrid.ReportName = null;
            this.tblNalogStavkiDevGrid.Size = new System.Drawing.Size(453, 267);
            this.tblNalogStavkiDevGrid.TabIndex = 1;
            this.tblNalogStavkiDevGrid.UpdateTable = null;
            this.tblNalogStavkiDevGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // stavkiVoNalogBindingSource
            // 
            this.stavkiVoNalogBindingSource.DataMember = "StavkiVoNalog";
            this.stavkiVoNalogBindingSource.DataSource = this.bSSRDataSet;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSifra,
            this.colNaziv,
            this.colKolicina,
            this.colProdaznaCena,
            this.colCenaBezDDV,
            this.colIznosBezDDV,
            this.colTip,
            this.colIznos,
            this.colCenaSoRabatIddv,
            this.colDanok,
            this.colDDVProcent,
            this.colPresmetanDDV,
            this.colRabat,
            this.colSifra2});
            this.gridView4.GridControl = this.tblNalogStavkiDevGrid;
            this.gridView4.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", this.colIznos, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kolicina", null, "")});
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowFooter = true;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив ";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.OptionsColumn.ReadOnly = true;
            this.colNaziv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 0;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.OptionsColumn.ReadOnly = true;
            this.colKolicina.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 1;
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            this.colProdaznaCena.OptionsColumn.ReadOnly = true;
            this.colProdaznaCena.Visible = true;
            this.colProdaznaCena.VisibleIndex = 3;
            // 
            // colCenaBezDDV
            // 
            this.colCenaBezDDV.Caption = "Цена без ДДВ";
            this.colCenaBezDDV.FieldName = "CenaBezDDV";
            this.colCenaBezDDV.Name = "colCenaBezDDV";
            // 
            // colIznosBezDDV
            // 
            this.colIznosBezDDV.Caption = "Износ без ДДВ";
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.Visible = true;
            this.colIznosBezDDV.VisibleIndex = 7;
            // 
            // colTip
            // 
            this.colTip.Caption = "Тип на артикал";
            this.colTip.FieldName = "Tip";
            this.colTip.Name = "colTip";
            this.colTip.OptionsColumn.ReadOnly = true;
            this.colTip.Visible = true;
            this.colTip.VisibleIndex = 4;
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.OptionsColumn.ReadOnly = true;
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 9;
            // 
            // colCenaSoRabatIddv
            // 
            this.colCenaSoRabatIddv.Caption = "Цена со рабат и ДДВ";
            this.colCenaSoRabatIddv.FieldName = "CenaSoRabatIddv";
            this.colCenaSoRabatIddv.Name = "colCenaSoRabatIddv";
            this.colCenaSoRabatIddv.Visible = true;
            this.colCenaSoRabatIddv.VisibleIndex = 5;
            // 
            // colDanok
            // 
            this.colDanok.Caption = "ДДВ";
            this.colDanok.FieldName = "Danok";
            this.colDanok.Name = "colDanok";
            this.colDanok.Visible = true;
            this.colDanok.VisibleIndex = 6;
            // 
            // colDDVProcent
            // 
            this.colDDVProcent.CustomizationCaption = "ДДВ Процент";
            this.colDDVProcent.FieldName = "DDVProcent";
            this.colDDVProcent.Name = "colDDVProcent";
            // 
            // colPresmetanDDV
            // 
            this.colPresmetanDDV.Caption = "Пресметан ДДВ";
            this.colPresmetanDDV.FieldName = "PresmetanDDV";
            this.colPresmetanDDV.Name = "colPresmetanDDV";
            this.colPresmetanDDV.Visible = true;
            this.colPresmetanDDV.VisibleIndex = 8;
            // 
            // colRabat
            // 
            this.colRabat.Caption = "Рабат %";
            this.colRabat.FieldName = "Rabat";
            this.colRabat.Name = "colRabat";
            this.colRabat.Visible = true;
            this.colRabat.VisibleIndex = 2;
            // 
            // colSifra2
            // 
            this.colSifra2.Caption = "Шифра 2";
            this.colSifra2.FieldName = "Sifra2";
            this.colSifra2.Name = "colSifra2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.бришиСметкаToolStripMenuItem,
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem,
            this.бришиНалогToolStripMenuItem,
            this.бришиАртикалОдНалогToolStripMenuItem,
            this.toolStripMenuItem2,
            this.направиФактураToolStripMenuItem,
            this.пратиНаДругКорисникToolStripMenuItem,
            this.toolStripMenuItem3,
            this.печатиНоваФискалнаToolStripMenuItem,
            this.сторнирајФискалнаЗаСметкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(265, 273);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(194, 273);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem1.Image = global::MReport.Properties.Resources.fiskalna;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 32);
            this.toolStripMenuItem1.Text = "Отвори сметка";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // бришиСметкаToolStripMenuItem
            // 
            this.бришиСметкаToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.бришиСметкаToolStripMenuItem.Image = global::MReport.Properties.Resources._001_02;
            this.бришиСметкаToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.бришиСметкаToolStripMenuItem.Name = "бришиСметкаToolStripMenuItem";
            this.бришиСметкаToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.бришиСметкаToolStripMenuItem.Text = "Бриши сметка";
            this.бришиСметкаToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.бришиСметкаToolStripMenuItem.Click += new System.EventHandler(this.бришиСметкаToolStripMenuItem_Click);
            // 
            // сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem
            // 
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem.Image = global::MReport.Properties.Resources._001_02;
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem.Name = "сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem";
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem.Text = "Сторнирај сметка";
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem.Visible = false;
            this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem.Click += new System.EventHandler(this.сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem_Click);
            // 
            // бришиНалогToolStripMenuItem
            // 
            this.бришиНалогToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.бришиНалогToolStripMenuItem.Image = global::MReport.Properties.Resources._001_02;
            this.бришиНалогToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.бришиНалогToolStripMenuItem.Name = "бришиНалогToolStripMenuItem";
            this.бришиНалогToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.бришиНалогToolStripMenuItem.Text = "Бриши налог";
            this.бришиНалогToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.бришиНалогToolStripMenuItem.Visible = false;
            this.бришиНалогToolStripMenuItem.Click += new System.EventHandler(this.бришиНалогToolStripMenuItem_Click);
            // 
            // бришиАртикалОдНалогToolStripMenuItem
            // 
            this.бришиАртикалОдНалогToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.бришиАртикалОдНалогToolStripMenuItem.Image = global::MReport.Properties.Resources._001_02;
            this.бришиАртикалОдНалогToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.бришиАртикалОдНалогToolStripMenuItem.Name = "бришиАртикалОдНалогToolStripMenuItem";
            this.бришиАртикалОдНалогToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.бришиАртикалОдНалогToolStripMenuItem.Text = "Бриши артикал ";
            this.бришиАртикалОдНалогToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.бришиАртикалОдНалогToolStripMenuItem.Visible = false;
            this.бришиАртикалОдНалогToolStripMenuItem.Click += new System.EventHandler(this.бришиАртикалОдНалогToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 19);
            this.toolStripMenuItem2.Text = "_____________";
            // 
            // направиФактураToolStripMenuItem
            // 
            this.направиФактураToolStripMenuItem.Image = global::MReport.Properties.Resources.fiskalna;
            this.направиФактураToolStripMenuItem.Name = "направиФактураToolStripMenuItem";
            this.направиФактураToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.направиФактураToolStripMenuItem.Text = "Креирај фактура";
            this.направиФактураToolStripMenuItem.Click += new System.EventHandler(this.направиФактураToolStripMenuItem_Click);
            // 
            // пратиНаДругКорисникToolStripMenuItem
            // 
            this.пратиНаДругКорисникToolStripMenuItem.Image = global::MReport.Properties.Resources.add_to2;
            this.пратиНаДругКорисникToolStripMenuItem.Name = "пратиНаДругКорисникToolStripMenuItem";
            this.пратиНаДругКорисникToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.пратиНаДругКорисникToolStripMenuItem.Text = "Прати на друг корисник";
            this.пратиНаДругКорисникToolStripMenuItem.Click += new System.EventHandler(this.пратиНаДругКорисникToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 19);
            this.toolStripMenuItem3.Text = "_____________";
            // 
            // печатиНоваФискалнаToolStripMenuItem
            // 
            this.печатиНоваФискалнаToolStripMenuItem.Name = "печатиНоваФискалнаToolStripMenuItem";
            this.печатиНоваФискалнаToolStripMenuItem.Size = new System.Drawing.Size(181, 19);
            this.печатиНоваФискалнаToolStripMenuItem.Text = "Печати нова фискална";
            this.печатиНоваФискалнаToolStripMenuItem.Click += new System.EventHandler(this.ПечатиНоваФискалнаToolStripMenuItem_Click);
            // 
            // сторнирајФискалнаЗаСметкаToolStripMenuItem
            // 
            this.сторнирајФискалнаЗаСметкаToolStripMenuItem.Name = "сторнирајФискалнаЗаСметкаToolStripMenuItem";
            this.сторнирајФискалнаЗаСметкаToolStripMenuItem.Size = new System.Drawing.Size(181, 19);
            this.сторнирајФискалнаЗаСметкаToolStripMenuItem.Text = "Сторнирај фискална за сметка";
            this.сторнирајФискалнаЗаСметкаToolStripMenuItem.Click += new System.EventHandler(this.СторнирајФискалнаЗаСметкаToolStripMenuItem_Click);
            // 
            // tblNalogDevGrid
            // 
            this.tblNalogDevGrid.AssemblyToLoad = null;
            this.tblNalogDevGrid.DataSource = this.tblNalogBindingSource;
            this.tblNalogDevGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNalogDevGrid.EditForm = null;
            this.tblNalogDevGrid.FilterForm = null;
            this.tblNalogDevGrid.Location = new System.Drawing.Point(462, 4);
            this.tblNalogDevGrid.MainView = this.gridView3;
            this.tblNalogDevGrid.Name = "tblNalogDevGrid";
            this.tblNalogDevGrid.PrimaryKey = null;
            this.tblNalogDevGrid.reportCenter = false;
            this.tblNalogDevGrid.ReportName = null;
            this.tblNalogDevGrid.Size = new System.Drawing.Size(453, 266);
            this.tblNalogDevGrid.TabIndex = 0;
            this.tblNalogDevGrid.UpdateTable = null;
            this.tblNalogDevGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colBroj1,
            this.colDatumPocetok1,
            this.colDatumKraj1,
            this.colZavrsen,
            this.colTipNaNalog});
            this.gridView3.GridControl = this.tblNalogDevGrid;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowFooter = true;
            // 
            // colID1
            // 
            this.colID1.Caption = "Реден број";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            // 
            // colBroj1
            // 
            this.colBroj1.Caption = "Број на нарачка";
            this.colBroj1.FieldName = "Broj";
            this.colBroj1.Name = "colBroj1";
            this.colBroj1.Visible = true;
            this.colBroj1.VisibleIndex = 0;
            // 
            // colDatumPocetok1
            // 
            this.colDatumPocetok1.Caption = "Датум на почеток";
            this.colDatumPocetok1.DisplayFormat.FormatString = "g";
            this.colDatumPocetok1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDatumPocetok1.FieldName = "DatumPocetok";
            this.colDatumPocetok1.Name = "colDatumPocetok1";
            this.colDatumPocetok1.Visible = true;
            this.colDatumPocetok1.VisibleIndex = 1;
            // 
            // colDatumKraj1
            // 
            this.colDatumKraj1.Caption = "Датум на крај";
            this.colDatumKraj1.DisplayFormat.FormatString = "g";
            this.colDatumKraj1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDatumKraj1.FieldName = "DatumKraj";
            this.colDatumKraj1.Name = "colDatumKraj1";
            this.colDatumKraj1.Visible = true;
            this.colDatumKraj1.VisibleIndex = 2;
            // 
            // colZavrsen
            // 
            this.colZavrsen.Caption = "Завршен";
            this.colZavrsen.FieldName = "Zavrsen";
            this.colZavrsen.Name = "colZavrsen";
            this.colZavrsen.Visible = true;
            this.colZavrsen.VisibleIndex = 3;
            // 
            // colTipNaNalog
            // 
            this.colTipNaNalog.Caption = "Тип на налог";
            this.colTipNaNalog.FieldName = "TipNaNalog";
            this.colTipNaNalog.Name = "colTipNaNalog";
            this.colTipNaNalog.Visible = true;
            this.colTipNaNalog.VisibleIndex = 4;
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxBase1.Controls.Add(this.txtSumFiskalni);
            this.groupBoxBase1.Controls.Add(this.bsslabel5);
            this.groupBoxBase1.Controls.Add(this.bsslabel3);
            this.groupBoxBase1.Controls.Add(this.txtSumNalozi);
            this.groupBoxBase1.Controls.Add(this.txtSumSmetki);
            this.groupBoxBase1.Controls.Add(this.bsslabel2);
            this.groupBoxBase1.Controls.Add(this.bsslabel1);
            this.groupBoxBase1.Controls.Add(this.txtBase1);
            this.groupBoxBase1.Controls.Add(this.btnPrikazi);
            this.groupBoxBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase1.Location = new System.Drawing.Point(3, 4);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(453, 266);
            this.groupBoxBase1.TabIndex = 11;
            this.groupBoxBase1.TabStop = false;
            // 
            // txtSumFiskalni
            // 
            this.txtSumFiskalni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSumFiskalni.AutoSize = true;
            this.txtSumFiskalni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumFiskalni.Location = new System.Drawing.Point(326, 161);
            this.txtSumFiskalni.Name = "txtSumFiskalni";
            this.txtSumFiskalni.Size = new System.Drawing.Size(26, 29);
            this.txtSumFiskalni.TabIndex = 8;
            this.txtSumFiskalni.Text = "0";
            // 
            // bsslabel5
            // 
            this.bsslabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel5.Location = new System.Drawing.Point(6, 161);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(314, 29);
            this.bsslabel5.TabIndex = 7;
            this.bsslabel5.Text = "Вкупна сума од фискална:";
            // 
            // bsslabel3
            // 
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel3.Location = new System.Drawing.Point(9, 13);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(189, 29);
            this.bsslabel3.TabIndex = 6;
            this.bsslabel3.Text = "Број на сметка:";
            // 
            // txtSumNalozi
            // 
            this.txtSumNalozi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSumNalozi.AutoSize = true;
            this.txtSumNalozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumNalozi.Location = new System.Drawing.Point(296, 132);
            this.txtSumNalozi.Name = "txtSumNalozi";
            this.txtSumNalozi.Size = new System.Drawing.Size(26, 29);
            this.txtSumNalozi.TabIndex = 5;
            this.txtSumNalozi.Text = "0";
            // 
            // txtSumSmetki
            // 
            this.txtSumSmetki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSumSmetki.AutoSize = true;
            this.txtSumSmetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumSmetki.Location = new System.Drawing.Point(296, 103);
            this.txtSumSmetki.Name = "txtSumSmetki";
            this.txtSumSmetki.Size = new System.Drawing.Size(26, 29);
            this.txtSumSmetki.TabIndex = 4;
            this.txtSumSmetki.Text = "0";
            // 
            // bsslabel2
            // 
            this.bsslabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel2.Location = new System.Drawing.Point(6, 132);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(286, 29);
            this.bsslabel2.TabIndex = 3;
            this.bsslabel2.Text = "Вкупна сума од налози:";
            // 
            // bsslabel1
            // 
            this.bsslabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel1.Location = new System.Drawing.Point(6, 103);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(284, 29);
            this.bsslabel1.TabIndex = 2;
            this.bsslabel1.Text = "Вкупна сума од сметки:";
            // 
            // txtBase1
            // 
            this.txtBase1.AssemblyStr = null;
            this.txtBase1.C_FillWithZeros = false;
            this.txtBase1.C_OnlyNumbers = true;
            this.txtBase1.C_RegEx = false;
            this.txtBase1.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBase1.ColumnName1 = null;
            this.txtBase1.ColumnName2 = null;
            this.txtBase1.ColumnName3 = null;
            this.txtBase1.ColumnName4 = null;
            this.txtBase1.ColumnName5 = null;
            this.txtBase1.ColumnName6 = null;
            this.txtBase1.ColumnName7 = null;
            this.txtBase1.daliCetiri = false;
            this.txtBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBase1.Format = null;
            this.txtBase1.formToOpen = null;
            this.txtBase1.iscistiGreenNaLeave = false;
            this.txtBase1.KoristiFilterNaDatasource = false;
            this.txtBase1.Location = new System.Drawing.Point(204, 11);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(99, 35);
            this.txtBase1.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrikazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrikazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.Image")));
            this.btnPrikazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikazi.Location = new System.Drawing.Point(309, 10);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(138, 36);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Најди сметка";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // stavkiVoNalogTableAdapter
            // 
            this.stavkiVoNalogTableAdapter.ClearBeforeFill = true;
            // 
            // stavkiZaFiskalNaBindingSource
            // 
            this.stavkiZaFiskalNaBindingSource.DataMember = "StavkiZaFiskalNa";
            this.stavkiZaFiskalNaBindingSource.DataSource = this.bSSRDataSet;
            // 
            // stavkiZaFiskalNaTableAdapter
            // 
            this.stavkiZaFiskalNaTableAdapter.ClearBeforeFill = true;
            // 
            // frmObrabotkaNaSmetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(918, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmObrabotkaNaSmetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка на сметки";
            this.Load += new System.EventHandler(this.frmObrabotkaNaSmetki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSmetkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSmetkaStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNalogBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNalogStavkiDevGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkiVoNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNalogDevGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkiZaFiskalNaBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private BSSRDataSet bSSRDataSet;
		private System.Windows.Forms.BindingSource tblSmetkaBindingSource;
		private BSSRDataSetTableAdapters.tblSmetkaTableAdapter tblSmetkaTableAdapter;
		private BSSRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private BSSRDataSetTableAdapters.tblSmetkaStavkiTableAdapter tblSmetkaStavkiTableAdapter;
		private System.Windows.Forms.BindingSource tblSmetkaStavkiBindingSource;
		private BSSRDataSetTableAdapters.tblNalogTableAdapter tblNalogTableAdapter;
		private System.Windows.Forms.BindingSource tblNalogBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BssBase.DevGrid tblNalogStavkiDevGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private System.Windows.Forms.BindingSource stavkiVoNalogBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
		private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
		private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
		private DevExpress.XtraGrid.Columns.GridColumn colTip;
		private BSSRDataSetTableAdapters.StavkiVoNalogTableAdapter stavkiVoNalogTableAdapter;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem бришиСметкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem бришиНалогToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem бришиАртикалОдНалогToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private BssBase.DevGrid tblNalogDevGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn colID1;
		private DevExpress.XtraGrid.Columns.GridColumn colBroj1;
		private DevExpress.XtraGrid.Columns.GridColumn colDatumPocetok1;
		private DevExpress.XtraGrid.Columns.GridColumn colDatumKraj1;
		private DevExpress.XtraGrid.Columns.GridColumn colZavrsen;
		private DevExpress.XtraGrid.Columns.GridColumn colTipNaNalog;
		private BssBase.groupBoxBase groupBoxBase1;
		private BssBase.txtBase txtBase1;
		private BssBase.Elements.btnOtvori btnPrikazi;
		private BssBase.Elements.Bsslabel txtSumNalozi;
		private BssBase.Elements.Bsslabel txtSumSmetki;
		private BssBase.Elements.Bsslabel bsslabel2;
		private BssBase.Elements.Bsslabel bsslabel1;
		private System.Windows.Forms.BindingSource stavkiZaFiskalNaBindingSource;
		private BSSRDataSetTableAdapters.StavkiZaFiskalNaTableAdapter stavkiZaFiskalNaTableAdapter;
		private BssBase.Elements.Bsslabel bsslabel3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem направиФактураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem;
        private BssBase.Elements.Bsslabel txtSumFiskalni;
        private BssBase.Elements.Bsslabel bsslabel5;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaSoRabatIddv;
        private DevExpress.XtraGrid.Columns.GridColumn colDanok;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVProcent;
        private DevExpress.XtraGrid.Columns.GridColumn colPresmetanDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra2;
        private System.Windows.Forms.ToolStripMenuItem пратиНаДругКорисникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem печатиНоваФискалнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сторнирајФискалнаЗаСметкаToolStripMenuItem;
    }
}
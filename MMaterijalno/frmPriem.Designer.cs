namespace MMaterijalno {
	partial class frmPriem {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPriem));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colKnizeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaDospeanost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewPriemiNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.viewPriemiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.bтнОтвори = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.viewPriemiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewPriemiTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter();
            this.viewPriemStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPriemStavkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewPriemStavkiTableAdapter();
            this.viewPriemiGridBig = new BssBase.DevGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriemBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriemDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDobavuvac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIspratnicaFakturaBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIspratnicaFakturaDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVkupenIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaKreiranjeNaPriem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosSoDDVZaokruzeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtShowDataOD = new BssBase.Elements.dtPickerBase();
            this.dtShowDataDO = new BssBase.Elements.dtPickerBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.btnPrikaziSporedFiltri = new System.Windows.Forms.Button();
            this.btnPrikaziSe = new System.Windows.Forms.Button();
            this.grFiltriSys = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiNavigator)).BeginInit();
            this.viewPriemiNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grFiltriSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // colKnizeno
            // 
            resources.ApplyResources(this.colKnizeno, "colKnizeno");
            this.colKnizeno.FieldName = "Knizeno";
            this.colKnizeno.Name = "colKnizeno";
            // 
            // colDatumNaDospeanost
            // 
            resources.ApplyResources(this.colDatumNaDospeanost, "colDatumNaDospeanost");
            this.colDatumNaDospeanost.FieldName = "DatumNaDospeanost";
            this.colDatumNaDospeanost.Name = "colDatumNaDospeanost";
            // 
            // viewPriemiNavigator
            // 
            this.viewPriemiNavigator.AddNewItem = null;
            resources.ApplyResources(this.viewPriemiNavigator, "viewPriemiNavigator");
            this.viewPriemiNavigator.BindingSource = this.viewPriemiBindingSource;
            this.viewPriemiNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewPriemiNavigator.CountItemFormat = "оf {0}";
            this.viewPriemiNavigator.DeleteItem = null;
            this.viewPriemiNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.viewPriemiNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.viewPriemiNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewPriemiNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewPriemiNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewPriemiNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewPriemiNavigator.Name = "viewPriemiNavigator";
            this.viewPriemiNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // viewPriemiBindingSource
            // 
            this.viewPriemiBindingSource.DataMember = "viewPriemi";
            this.viewPriemiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.bтнОтвори);
            this.groupBoxBase1.Controls.Add(this.btnPecati);
            resources.ApplyResources(this.groupBoxBase1, "groupBoxBase1");
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.TabStop = false;
            // 
            // bтнОтвори
            // 
            this.bтнОтвори.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.bтнОтвори, "bтнОтвори");
            this.bтнОтвори.Image = global::MMaterijalno.Properties.Resources.edit;
            this.bтнОтвори.Name = "bтнОтвори";
            this.bтнОтвори.UseVisualStyleBackColor = false;
            this.bтнОтвори.Click += new System.EventHandler(this.bтнОтвори_Click);
            // 
            // btnPecati
            // 
            resources.ApplyResources(this.btnPecati, "btnPecati");
            this.btnPecati.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecati.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // viewPriemiTableAdapter
            // 
            this.viewPriemiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPlacanjaOdPartnerTableAdapter = null;
            this.tableAdapterManager.tblPriemStavkiTableAdapter = null;
            this.tableAdapterManager.tblPriemTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewDokumentiStavkiTableAdapter = null;
            this.tableAdapterManager.viewDokumentiTableAdapter = null;
            this.tableAdapterManager.viewIzvodiTableAdapter = null;
            this.tableAdapterManager.viewPriemiTableAdapter = null;
            this.tableAdapterManager.viewPriemStavkiTableAdapter = null;
            this.tableAdapterManager.vPriemiKnizenjeTableAdapter = null;
            this.tableAdapterManager.vSmetkaKnizenjeTableAdapter = null;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            this.tblFirmaBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // viewPriemStavkiBindingSource
            // 
            this.viewPriemStavkiBindingSource.DataMember = "viewPriemStavki";
            this.viewPriemStavkiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // viewPriemStavkiTableAdapter
            // 
            this.viewPriemStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // viewPriemiGridBig
            // 
            resources.ApplyResources(this.viewPriemiGridBig, "viewPriemiGridBig");
            this.viewPriemiGridBig.AssemblyToLoad = null;
            this.viewPriemiGridBig.DataSource = this.viewPriemiBindingSource;
            this.viewPriemiGridBig.EditForm = null;
            this.viewPriemiGridBig.FilterForm = null;
            this.viewPriemiGridBig.MainView = this.gridView1;
            this.viewPriemiGridBig.Name = "viewPriemiGridBig";
            this.viewPriemiGridBig.PrimaryKey = null;
            this.viewPriemiGridBig.reportCenter = false;
            this.viewPriemiGridBig.ReportName = null;
            this.viewPriemiGridBig.TabStop = false;
            this.viewPriemiGridBig.UpdateTable = null;
            this.viewPriemiGridBig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.viewPriemiGridBig.DataInsert += new BssBase.DevGrid.dataInsertEnd(this.viewPriemiGridBig_DataInsert);
            this.viewPriemiGridBig.dataSaveAll += new BssBase.DevGrid.dataSave(this.viewPriemiGridBig_dataSaveAll);
            this.viewPriemiGridBig.DoubleClick += new System.EventHandler(this.viewPriemiGridBig_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPriemBroj,
            this.colPriemDatum,
            this.colUserFullName,
            this.colDobavuvac,
            this.colDDVIznos,
            this.colIznosBezDDV,
            this.colIznosSoDDV,
            this.colIspratnicaFakturaBroj,
            this.colIspratnicaFakturaDatum,
            this.colVkupenIznos,
            this.colDatumNaDospeanost,
            this.colDatumNaKreiranjeNaPriem,
            this.colIznosSoDDVZaokruzeno,
            this.colDDVIznos18,
            this.colDDVIznos5,
            this.colKnizeno,
            this.colSifraPartner});
            styleFormatCondition1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor")));
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colKnizeno;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "1";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.viewPriemiGridBig;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colPriemBroj
            // 
            resources.ApplyResources(this.colPriemBroj, "colPriemBroj");
            this.colPriemBroj.FieldName = "PriemBroj";
            this.colPriemBroj.Name = "colPriemBroj";
            this.colPriemBroj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colPriemBroj.Summary"))), resources.GetString("colPriemBroj.Summary1"), resources.GetString("colPriemBroj.Summary2"))});
            // 
            // colPriemDatum
            // 
            resources.ApplyResources(this.colPriemDatum, "colPriemDatum");
            this.colPriemDatum.FieldName = "PriemDatum";
            this.colPriemDatum.Name = "colPriemDatum";
            // 
            // colUserFullName
            // 
            resources.ApplyResources(this.colUserFullName, "colUserFullName");
            this.colUserFullName.FieldName = "UserFullName";
            this.colUserFullName.Name = "colUserFullName";
            // 
            // colDobavuvac
            // 
            resources.ApplyResources(this.colDobavuvac, "colDobavuvac");
            this.colDobavuvac.FieldName = "Dobavuvac";
            this.colDobavuvac.Name = "colDobavuvac";
            // 
            // colDDVIznos
            // 
            resources.ApplyResources(this.colDDVIznos, "colDDVIznos");
            this.colDDVIznos.FieldName = "DDVIznos";
            this.colDDVIznos.Name = "colDDVIznos";
            this.colDDVIznos.OptionsColumn.ReadOnly = true;
            this.colDDVIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colDDVIznos.Summary"))), resources.GetString("colDDVIznos.Summary1"), resources.GetString("colDDVIznos.Summary2"))});
            // 
            // colIznosBezDDV
            // 
            resources.ApplyResources(this.colIznosBezDDV, "colIznosBezDDV");
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.OptionsColumn.ReadOnly = true;
            this.colIznosBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colIznosBezDDV.Summary"))), resources.GetString("colIznosBezDDV.Summary1"), resources.GetString("colIznosBezDDV.Summary2"))});
            // 
            // colIznosSoDDV
            // 
            resources.ApplyResources(this.colIznosSoDDV, "colIznosSoDDV");
            this.colIznosSoDDV.FieldName = "IznosSoDDV";
            this.colIznosSoDDV.Name = "colIznosSoDDV";
            this.colIznosSoDDV.OptionsColumn.ReadOnly = true;
            this.colIznosSoDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colIznosSoDDV.Summary"))), resources.GetString("colIznosSoDDV.Summary1"), resources.GetString("colIznosSoDDV.Summary2"))});
            // 
            // colIspratnicaFakturaBroj
            // 
            resources.ApplyResources(this.colIspratnicaFakturaBroj, "colIspratnicaFakturaBroj");
            this.colIspratnicaFakturaBroj.FieldName = "IspratnicaFakturaBroj";
            this.colIspratnicaFakturaBroj.Name = "colIspratnicaFakturaBroj";
            // 
            // colIspratnicaFakturaDatum
            // 
            resources.ApplyResources(this.colIspratnicaFakturaDatum, "colIspratnicaFakturaDatum");
            this.colIspratnicaFakturaDatum.FieldName = "IspratnicaFakturaDatum";
            this.colIspratnicaFakturaDatum.Name = "colIspratnicaFakturaDatum";
            // 
            // colVkupenIznos
            // 
            resources.ApplyResources(this.colVkupenIznos, "colVkupenIznos");
            this.colVkupenIznos.FieldName = "VkupenIznos";
            this.colVkupenIznos.Name = "colVkupenIznos";
            this.colVkupenIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colVkupenIznos.Summary"))), resources.GetString("colVkupenIznos.Summary1"), resources.GetString("colVkupenIznos.Summary2"))});
            // 
            // colDatumNaKreiranjeNaPriem
            // 
            resources.ApplyResources(this.colDatumNaKreiranjeNaPriem, "colDatumNaKreiranjeNaPriem");
            this.colDatumNaKreiranjeNaPriem.FieldName = "DatumNaKreiranjeNaPriem";
            this.colDatumNaKreiranjeNaPriem.Name = "colDatumNaKreiranjeNaPriem";
            // 
            // colIznosSoDDVZaokruzeno
            // 
            resources.ApplyResources(this.colIznosSoDDVZaokruzeno, "colIznosSoDDVZaokruzeno");
            this.colIznosSoDDVZaokruzeno.FieldName = "IznosSoDDVZaokruzeno";
            this.colIznosSoDDVZaokruzeno.Name = "colIznosSoDDVZaokruzeno";
            this.colIznosSoDDVZaokruzeno.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colIznosSoDDVZaokruzeno.Summary"))), resources.GetString("colIznosSoDDVZaokruzeno.Summary1"), resources.GetString("colIznosSoDDVZaokruzeno.Summary2"))});
            // 
            // colDDVIznos18
            // 
            resources.ApplyResources(this.colDDVIznos18, "colDDVIznos18");
            this.colDDVIznos18.FieldName = "DDVIznos18";
            this.colDDVIznos18.Name = "colDDVIznos18";
            // 
            // colDDVIznos5
            // 
            resources.ApplyResources(this.colDDVIznos5, "colDDVIznos5");
            this.colDDVIznos5.FieldName = "DDVIznos5";
            this.colDDVIznos5.Name = "colDDVIznos5";
            // 
            // colSifraPartner
            // 
            resources.ApplyResources(this.colSifraPartner, "colSifraPartner");
            this.colSifraPartner.FieldName = "SifraPartner";
            this.colSifraPartner.Name = "colSifraPartner";
            // 
            // dtShowDataOD
            // 
            resources.ApplyResources(this.dtShowDataOD, "dtShowDataOD");
            this.dtShowDataOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShowDataOD.Name = "dtShowDataOD";
            // 
            // dtShowDataDO
            // 
            resources.ApplyResources(this.dtShowDataDO, "dtShowDataDO");
            this.dtShowDataDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShowDataDO.Name = "dtShowDataDO";
            // 
            // bsslabel1
            // 
            resources.ApplyResources(this.bsslabel1, "bsslabel1");
            this.bsslabel1.Name = "bsslabel1";
            // 
            // bsslabel2
            // 
            resources.ApplyResources(this.bsslabel2, "bsslabel2");
            this.bsslabel2.Name = "bsslabel2";
            // 
            // btnPrikaziSporedFiltri
            // 
            this.btnPrikaziSporedFiltri.Image = global::MMaterijalno.Properties.Resources._001_38;
            resources.ApplyResources(this.btnPrikaziSporedFiltri, "btnPrikaziSporedFiltri");
            this.btnPrikaziSporedFiltri.Name = "btnPrikaziSporedFiltri";
            this.btnPrikaziSporedFiltri.UseVisualStyleBackColor = true;
            this.btnPrikaziSporedFiltri.Click += new System.EventHandler(this.btnPrikaziSporedFiltri_Click);
            // 
            // btnPrikaziSe
            // 
            resources.ApplyResources(this.btnPrikaziSe, "btnPrikaziSe");
            this.btnPrikaziSe.Image = global::MMaterijalno.Properties.Resources._001_38;
            this.btnPrikaziSe.Name = "btnPrikaziSe";
            this.btnPrikaziSe.UseVisualStyleBackColor = true;
            this.btnPrikaziSe.Click += new System.EventHandler(this.btnPrikaziSe_Click);
            // 
            // grFiltriSys
            // 
            resources.ApplyResources(this.grFiltriSys, "grFiltriSys");
            this.grFiltriSys.Controls.Add(this.btnPrikaziSe);
            this.grFiltriSys.Controls.Add(this.dtShowDataOD);
            this.grFiltriSys.Controls.Add(this.btnPrikaziSporedFiltri);
            this.grFiltriSys.Controls.Add(this.dtShowDataDO);
            this.grFiltriSys.Controls.Add(this.bsslabel2);
            this.grFiltriSys.Controls.Add(this.bsslabel1);
            this.grFiltriSys.Name = "grFiltriSys";
            this.grFiltriSys.TabStop = false;
            // 
            // frmPriem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grFiltriSys);
            this.Controls.Add(this.viewPriemiGridBig);
            this.Controls.Add(this.groupBoxBase1);
            this.Controls.Add(this.viewPriemiNavigator);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmPriem";
            this.Load += new System.EventHandler(this.frmPriem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPriem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiNavigator)).EndInit();
            this.viewPriemiNavigator.ResumeLayout(false);
            this.viewPriemiNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grFiltriSys.ResumeLayout(false);
            this.grFiltriSys.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingNavigator viewPriemiNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private BssBase.groupBoxBase groupBoxBase1;
		private System.Windows.Forms.Button bтнОтвори;
		private System.Windows.Forms.Button btnPecati;
		private MaterijalnoDataSet materijalnoDataSet;
		private System.Windows.Forms.BindingSource viewPriemiBindingSource;
		private MaterijalnoDataSetTableAdapters.viewPriemiTableAdapter viewPriemiTableAdapter;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		//private System.Windows.Forms.DataGridViewTextBoxColumn partner;
		//private System.Windows.Forms.DataGridViewTextBoxColumn IspratnicaBroj;
       // private System.Windows.Forms.DataGridViewTextBoxColumn FakturaBroj;
		private System.Windows.Forms.BindingSource tblFirmaBindingSource;
		private MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
		private System.Windows.Forms.BindingSource viewPriemStavkiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewPriemStavkiTableAdapter viewPriemStavkiTableAdapter;
        private BssBase.DevGrid viewPriemiGridBig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPriemBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colPriemDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colUserFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDobavuvac;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosSoDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIspratnicaFakturaBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colIspratnicaFakturaDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colVkupenIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaDospeanost;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaKreiranjeNaPriem;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosSoDDVZaokruzeno;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos18;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos5;
        private DevExpress.XtraGrid.Columns.GridColumn colKnizeno;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraPartner;
        private BssBase.Elements.dtPickerBase dtShowDataOD;
        private BssBase.Elements.dtPickerBase dtShowDataDO;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.Elements.Bsslabel bsslabel2;
        private System.Windows.Forms.Button btnPrikaziSporedFiltri;
        private System.Windows.Forms.Button btnPrikaziSe;
        private System.Windows.Forms.GroupBox grFiltriSys;
    }
}


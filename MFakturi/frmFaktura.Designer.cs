namespace MFakturi {
	partial class frmFaktura {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaktura));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colKnizeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fakturiDataSet = new MFakturi.FakturiDataSet();
            this.viewFakturiBindingSource = new System.Windows.Forms.BindingSource();
            this.viewFakturiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewFakturiTableAdapter();
            this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
            this.viewFakturiBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.bтнОтвори = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource();
            this.tblPartneriTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblPartneriTableAdapter();
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource();
            this.tblFirmaTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblFirmaTableAdapter();
            this.viewFakturiStavkiBindingSource = new System.Windows.Forms.BindingSource();
            this.viewFakturiStavkiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewFakturiStavkiTableAdapter();
            this.viewFakturiGridBig = new BssBase.DevGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFakturiranDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojNaFakturaSporedPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grFiltriSys = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSe = new System.Windows.Forms.Button();
            this.dtShowDataOD = new BssBase.Elements.dtPickerBase();
            this.btnPrikaziSporedFiltri = new System.Windows.Forms.Button();
            this.dtShowDataDO = new BssBase.Elements.dtPickerBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiBindingNavigator)).BeginInit();
            this.viewFakturiBindingNavigator.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiGridBig)).BeginInit();
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
            // fakturiDataSet
            // 
            this.fakturiDataSet.DataSetName = "FakturiDataSet";
            this.fakturiDataSet.EnforceConstraints = false;
            this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewFakturiBindingSource
            // 
            this.viewFakturiBindingSource.DataMember = "viewFakturi";
            this.viewFakturiBindingSource.DataSource = this.fakturiDataSet;
            // 
            // viewFakturiTableAdapter
            // 
            this.viewFakturiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblBankiTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaStavkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = null;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblZiroSmetkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliVoSmetkaTableAdapter = null;
            this.tableAdapterManager.viewFakturiStavkiTableAdapter = null;
            this.tableAdapterManager.viewFakturiTableAdapter = null;
            this.tableAdapterManager.viewZiroSmetkeTableAdapter = null;
            // 
            // viewFakturiBindingNavigator
            // 
            this.viewFakturiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            resources.ApplyResources(this.viewFakturiBindingNavigator, "viewFakturiBindingNavigator");
            this.viewFakturiBindingNavigator.BindingSource = this.viewFakturiBindingSource;
            this.viewFakturiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewFakturiBindingNavigator.CountItemFormat = "од {0}";
            this.viewFakturiBindingNavigator.DeleteItem = null;
            this.viewFakturiBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.viewFakturiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.viewFakturiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewFakturiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewFakturiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewFakturiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewFakturiBindingNavigator.Name = "viewFakturiBindingNavigator";
            this.viewFakturiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.bтнОтвори.Image = global::MFakturi.Properties.Resources.edit;
            this.bтнОтвори.Name = "bтнОтвори";
            this.bтнОтвори.UseVisualStyleBackColor = false;
            this.bтнОтвори.Click += new System.EventHandler(this.bтнОтвори_Click);
            // 
            // btnPecati
            // 
            resources.ApplyResources(this.btnPecati, "btnPecati");
            this.btnPecati.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecati.Image = global::MFakturi.Properties.Resources.pecati;
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // tblPartneriBindingSource
            // 
            this.tblPartneriBindingSource.DataMember = "tblPartneri";
            this.tblPartneriBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tblPartneriTableAdapter
            // 
            this.tblPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            this.tblFirmaBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // viewFakturiStavkiBindingSource
            // 
            this.viewFakturiStavkiBindingSource.DataMember = "viewFakturiStavki";
            this.viewFakturiStavkiBindingSource.DataSource = this.fakturiDataSet;
            // 
            // viewFakturiStavkiTableAdapter
            // 
            this.viewFakturiStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // viewFakturiGridBig
            // 
            resources.ApplyResources(this.viewFakturiGridBig, "viewFakturiGridBig");
            this.viewFakturiGridBig.AssemblyToLoad = null;
            this.viewFakturiGridBig.DataSource = this.viewFakturiBindingSource;
            this.viewFakturiGridBig.EditForm = null;
            this.viewFakturiGridBig.FilterForm = null;
            this.viewFakturiGridBig.MainView = this.gridView1;
            this.viewFakturiGridBig.Name = "viewFakturiGridBig";
            this.viewFakturiGridBig.PrimaryKey = null;
            this.viewFakturiGridBig.reportCenter = false;
            this.viewFakturiGridBig.ReportName = null;
            this.viewFakturiGridBig.TabStop = false;
            this.viewFakturiGridBig.UpdateTable = null;
            this.viewFakturiGridBig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.viewFakturiGridBig.DataInsert += new BssBase.DevGrid.dataInsertEnd(this.viewFakturiGridBig_DataInsert);
            this.viewFakturiGridBig.dataSaveAll += new BssBase.DevGrid.dataSave(this.viewFakturiGridBig_dataSaveAll);
            this.viewFakturiGridBig.DoubleClick += new System.EventHandler(this.viewFakturiGridBig_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colBroj,
            this.colPartner,
            this.colDatum,
            this.colFakturiranDDV,
            this.colIznosBezDDV,
            this.colIznos,
            this.colKnizeno,
            this.colSifraPartner,
            this.colBrojNaFakturaSporedPartner});
            styleFormatCondition1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor")));
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colKnizeno;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.viewFakturiGridBig;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3")),
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary4"))), resources.GetString("gridView1.GroupSummary5"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary6"))), resources.GetString("gridView1.GroupSummary7")),
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary8"))), resources.GetString("gridView1.GroupSummary9"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary10"))), resources.GetString("gridView1.GroupSummary11"))});
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
            // colBroj
            // 
            resources.ApplyResources(this.colBroj, "colBroj");
            this.colBroj.FieldName = "Broj";
            this.colBroj.Name = "colBroj";
            // 
            // colPartner
            // 
            resources.ApplyResources(this.colPartner, "colPartner");
            this.colPartner.FieldName = "Partner";
            this.colPartner.Name = "colPartner";
            this.colPartner.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colPartner.Summary"))), resources.GetString("colPartner.Summary1"), resources.GetString("colPartner.Summary2"))});
            // 
            // colDatum
            // 
            resources.ApplyResources(this.colDatum, "colDatum");
            this.colDatum.FieldName = "Datum";
            this.colDatum.Name = "colDatum";
            // 
            // colFakturiranDDV
            // 
            resources.ApplyResources(this.colFakturiranDDV, "colFakturiranDDV");
            this.colFakturiranDDV.FieldName = "FakturiranDDV";
            this.colFakturiranDDV.Name = "colFakturiranDDV";
            // 
            // colIznosBezDDV
            // 
            resources.ApplyResources(this.colIznosBezDDV, "colIznosBezDDV");
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colIznosBezDDV.Summary"))), resources.GetString("colIznosBezDDV.Summary1"), resources.GetString("colIznosBezDDV.Summary2"))});
            // 
            // colIznos
            // 
            resources.ApplyResources(this.colIznos, "colIznos");
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colIznos.Summary"))), resources.GetString("colIznos.Summary1"), resources.GetString("colIznos.Summary2"))});
            // 
            // colSifraPartner
            // 
            resources.ApplyResources(this.colSifraPartner, "colSifraPartner");
            this.colSifraPartner.FieldName = "SifraPartner";
            this.colSifraPartner.Name = "colSifraPartner";
            // 
            // colBrojNaFakturaSporedPartner
            // 
            resources.ApplyResources(this.colBrojNaFakturaSporedPartner, "colBrojNaFakturaSporedPartner");
            this.colBrojNaFakturaSporedPartner.FieldName = "BrojNaFakturaSporedPartner";
            this.colBrojNaFakturaSporedPartner.Name = "colBrojNaFakturaSporedPartner";
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
            // btnPrikaziSe
            // 
            resources.ApplyResources(this.btnPrikaziSe, "btnPrikaziSe");
            this.btnPrikaziSe.Image = global::MFakturi.Properties.Resources._001_38;
            this.btnPrikaziSe.Name = "btnPrikaziSe";
            this.btnPrikaziSe.UseVisualStyleBackColor = true;
            this.btnPrikaziSe.Click += new System.EventHandler(this.btnPrikaziSe_Click);
            // 
            // dtShowDataOD
            // 
            resources.ApplyResources(this.dtShowDataOD, "dtShowDataOD");
            this.dtShowDataOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShowDataOD.Name = "dtShowDataOD";
            // 
            // btnPrikaziSporedFiltri
            // 
            this.btnPrikaziSporedFiltri.Image = global::MFakturi.Properties.Resources._001_38;
            resources.ApplyResources(this.btnPrikaziSporedFiltri, "btnPrikaziSporedFiltri");
            this.btnPrikaziSporedFiltri.Name = "btnPrikaziSporedFiltri";
            this.btnPrikaziSporedFiltri.UseVisualStyleBackColor = true;
            this.btnPrikaziSporedFiltri.Click += new System.EventHandler(this.btnPrikaziSporedFiltri_Click);
            // 
            // dtShowDataDO
            // 
            resources.ApplyResources(this.dtShowDataDO, "dtShowDataDO");
            this.dtShowDataDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShowDataDO.Name = "dtShowDataDO";
            // 
            // bsslabel2
            // 
            resources.ApplyResources(this.bsslabel2, "bsslabel2");
            this.bsslabel2.Name = "bsslabel2";
            // 
            // bsslabel1
            // 
            resources.ApplyResources(this.bsslabel1, "bsslabel1");
            this.bsslabel1.Name = "bsslabel1";
            // 
            // frmFaktura
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grFiltriSys);
            this.Controls.Add(this.viewFakturiGridBig);
            this.Controls.Add(this.viewFakturiBindingNavigator);
            this.Controls.Add(this.groupBoxBase1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmFaktura";
            this.Load += new System.EventHandler(this.frmFaktura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFaktura_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiBindingNavigator)).EndInit();
            this.viewFakturiBindingNavigator.ResumeLayout(false);
            this.viewFakturiBindingNavigator.PerformLayout();
            this.groupBoxBase1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grFiltriSys.ResumeLayout(false);
            this.grFiltriSys.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private BssBase.groupBoxBase groupBoxBase1;
		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource viewFakturiBindingSource;
		private FakturiDataSetTableAdapters.viewFakturiTableAdapter viewFakturiTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator viewFakturiBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.Button btnPecati;
		private System.Windows.Forms.Button bтнОтвори;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.BindingSource tblPartneriBindingSource;
		private FakturiDataSetTableAdapters.tblPartneriTableAdapter tblPartneriTableAdapter;
		private System.Windows.Forms.BindingSource tblFirmaBindingSource;
		private FakturiDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
		private System.Windows.Forms.BindingSource viewFakturiStavkiBindingSource;
		private FakturiDataSetTableAdapters.viewFakturiStavkiTableAdapter viewFakturiStavkiTableAdapter;
        private BssBase.DevGrid viewFakturiGridBig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colFakturiranDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colKnizeno;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaFakturaSporedPartner;
        private System.Windows.Forms.GroupBox grFiltriSys;
        private System.Windows.Forms.Button btnPrikaziSe;
        private BssBase.Elements.dtPickerBase dtShowDataOD;
        private System.Windows.Forms.Button btnPrikaziSporedFiltri;
        private BssBase.Elements.dtPickerBase dtShowDataDO;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.Elements.Bsslabel bsslabel1;
    }
}


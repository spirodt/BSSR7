namespace MMaterijalno.Forms
{
    partial class frmInterniDokumenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterniDokumenti));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colKnizeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewPriemiNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.viewDokumentiGridBig = new BssBase.DevGrid();
            this.viewDokumentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipDokumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZabeleska = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObejektDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjektOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoObjektID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdObjektID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazivPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaValuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueIdPlacanje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.btnOtvori2 = new BssBase.Elements.btnOtvori();
            this.buttonPechatiDokumentiDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServer = new BssBase.cmbBase();
            this.btnOtvori1 = new BssBase.Elements.btnOtvori();
            this.bтнОтвори = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.viewDokumentiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewDokumentiTableAdapter();
            this.tblFirmaTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter();
            this.viewDokumentiStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewDokumentiStavkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewDokumentiStavkiTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.grFiltriSys = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSe = new System.Windows.Forms.Button();
            this.dtShowDataOD = new BssBase.Elements.dtPickerBase();
            this.btnPrikaziSporedFiltri = new System.Windows.Forms.Button();
            this.dtShowDataDO = new BssBase.Elements.dtPickerBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.general_data_mesecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_data_mesecTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.General_data_mesecTableAdapter();
            this.tblDokumentiDetailsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDokumentiDetailsInfoTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoTableAdapter();
            this.tblDokumentiDetailsInfoHvacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDokumentiDetailsInfoHvacTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoHvacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiNavigator)).BeginInit();
            this.viewPriemiNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkiBindingSource)).BeginInit();
            this.grFiltriSys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_data_mesecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoHvacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colKnizeno
            // 
            resources.ApplyResources(this.colKnizeno, "colKnizeno");
            this.colKnizeno.FieldName = "Knizeno";
            this.colKnizeno.Name = "colKnizeno";
            // 
            // viewPriemiNavigator
            // 
            this.viewPriemiNavigator.AddNewItem = null;
            resources.ApplyResources(this.viewPriemiNavigator, "viewPriemiNavigator");
            this.viewPriemiNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewPriemiNavigator.CountItemFormat = "оf {0}";
            this.viewPriemiNavigator.DeleteItem = null;
            this.viewPriemiNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.viewPriemiNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // viewDokumentiGridBig
            // 
            resources.ApplyResources(this.viewDokumentiGridBig, "viewDokumentiGridBig");
            this.viewDokumentiGridBig.AssemblyToLoad = null;
            this.viewDokumentiGridBig.DataSource = this.viewDokumentiBindingSource;
            this.viewDokumentiGridBig.EditForm = null;
            this.viewDokumentiGridBig.FilterForm = null;
            gridLevelNode1.RelationName = "Level1";
            this.viewDokumentiGridBig.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.viewDokumentiGridBig.MainView = this.gridView1;
            this.viewDokumentiGridBig.Name = "viewDokumentiGridBig";
            this.viewDokumentiGridBig.PrimaryKey = null;
            this.viewDokumentiGridBig.reportCenter = false;
            this.viewDokumentiGridBig.ReportName = null;
            this.viewDokumentiGridBig.TabStop = false;
            this.viewDokumentiGridBig.UpdateTable = null;
            this.viewDokumentiGridBig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.viewDokumentiGridBig.DataInsert += new BssBase.DevGrid.dataInsertEnd(this.viewDokumentiGridBig_DataInsert);
            this.viewDokumentiGridBig.dataSaveAll += new BssBase.DevGrid.dataSave(this.viewDokumentiGridBig_dataSaveAll);
            this.viewDokumentiGridBig.DoubleClick += new System.EventHandler(this.viewDokumentiGridBig_DoubleClick);
            // 
            // viewDokumentiBindingSource
            // 
            this.viewDokumentiBindingSource.DataMember = "viewDokumenti";
            this.viewDokumentiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTipDokumentID,
            this.colTipNaDokument,
            this.colDatum,
            this.colZabeleska,
            this.colObejektDO,
            this.colObjektOD,
            this.colUserName,
            this.colDoObjektID,
            this.colOdObjektID,
            this.colDDVIznos,
            this.colDDVIznos18,
            this.colDDVIznos5,
            this.colIznosBezDDV,
            this.colIznosSoDDV,
            this.colNazivPartner,
            this.colKnizeno,
            this.colBroj,
            this.colSifraPartner,
            this.colBrojNaDokument,
            this.colDatumNaValuta,
            this.colUniqueIdPlacanje});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colKnizeno;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "1";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.viewDokumentiGridBig;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
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
            // colTipDokumentID
            // 
            resources.ApplyResources(this.colTipDokumentID, "colTipDokumentID");
            this.colTipDokumentID.FieldName = "TipDokumentID";
            this.colTipDokumentID.Name = "colTipDokumentID";
            // 
            // colTipNaDokument
            // 
            resources.ApplyResources(this.colTipNaDokument, "colTipNaDokument");
            this.colTipNaDokument.FieldName = "TipNaDokument";
            this.colTipNaDokument.Name = "colTipNaDokument";
            // 
            // colDatum
            // 
            resources.ApplyResources(this.colDatum, "colDatum");
            this.colDatum.FieldName = "Datum";
            this.colDatum.Name = "colDatum";
            this.colDatum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colDatum.Summary"))), resources.GetString("colDatum.Summary1"), resources.GetString("colDatum.Summary2"))});
            // 
            // colZabeleska
            // 
            resources.ApplyResources(this.colZabeleska, "colZabeleska");
            this.colZabeleska.FieldName = "Zabeleska";
            this.colZabeleska.Name = "colZabeleska";
            // 
            // colObejektDO
            // 
            resources.ApplyResources(this.colObejektDO, "colObejektDO");
            this.colObejektDO.FieldName = "ObejektDO";
            this.colObejektDO.Name = "colObejektDO";
            // 
            // colObjektOD
            // 
            resources.ApplyResources(this.colObjektOD, "colObjektOD");
            this.colObjektOD.FieldName = "ObjektOD";
            this.colObjektOD.Name = "colObjektOD";
            // 
            // colUserName
            // 
            resources.ApplyResources(this.colUserName, "colUserName");
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            // 
            // colDoObjektID
            // 
            resources.ApplyResources(this.colDoObjektID, "colDoObjektID");
            this.colDoObjektID.FieldName = "DoObjektID";
            this.colDoObjektID.Name = "colDoObjektID";
            // 
            // colOdObjektID
            // 
            resources.ApplyResources(this.colOdObjektID, "colOdObjektID");
            this.colOdObjektID.FieldName = "OdObjektID";
            this.colOdObjektID.Name = "colOdObjektID";
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
            // colDDVIznos18
            // 
            resources.ApplyResources(this.colDDVIznos18, "colDDVIznos18");
            this.colDDVIznos18.FieldName = "DDVIznos18";
            this.colDDVIznos18.Name = "colDDVIznos18";
            this.colDDVIznos18.OptionsColumn.ReadOnly = true;
            this.colDDVIznos18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colDDVIznos18.Summary"))), resources.GetString("colDDVIznos18.Summary1"), resources.GetString("colDDVIznos18.Summary2"))});
            // 
            // colDDVIznos5
            // 
            resources.ApplyResources(this.colDDVIznos5, "colDDVIznos5");
            this.colDDVIznos5.FieldName = "DDVIznos5";
            this.colDDVIznos5.Name = "colDDVIznos5";
            this.colDDVIznos5.OptionsColumn.ReadOnly = true;
            this.colDDVIznos5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colDDVIznos5.Summary"))), resources.GetString("colDDVIznos5.Summary1"), resources.GetString("colDDVIznos5.Summary2"))});
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
            // colNazivPartner
            // 
            resources.ApplyResources(this.colNazivPartner, "colNazivPartner");
            this.colNazivPartner.FieldName = "NazivPartner";
            this.colNazivPartner.Name = "colNazivPartner";
            // 
            // colBroj
            // 
            resources.ApplyResources(this.colBroj, "colBroj");
            this.colBroj.FieldName = "Broj";
            this.colBroj.Name = "colBroj";
            // 
            // colSifraPartner
            // 
            resources.ApplyResources(this.colSifraPartner, "colSifraPartner");
            this.colSifraPartner.FieldName = "SifraPartner";
            this.colSifraPartner.Name = "colSifraPartner";
            // 
            // colBrojNaDokument
            // 
            resources.ApplyResources(this.colBrojNaDokument, "colBrojNaDokument");
            this.colBrojNaDokument.FieldName = "BrojNaDokument";
            this.colBrojNaDokument.Name = "colBrojNaDokument";
            // 
            // colDatumNaValuta
            // 
            resources.ApplyResources(this.colDatumNaValuta, "colDatumNaValuta");
            this.colDatumNaValuta.FieldName = "DatumNaValuta";
            this.colDatumNaValuta.Name = "colDatumNaValuta";
            // 
            // colUniqueIdPlacanje
            // 
            resources.ApplyResources(this.colUniqueIdPlacanje, "colUniqueIdPlacanje");
            this.colUniqueIdPlacanje.FieldName = "UniqueIdPlacanje";
            this.colUniqueIdPlacanje.Name = "colUniqueIdPlacanje";
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.btnOtvori2);
            this.groupBoxBase1.Controls.Add(this.buttonPechatiDokumentiDo);
            this.groupBoxBase1.Controls.Add(this.label1);
            this.groupBoxBase1.Controls.Add(this.cmbServer);
            this.groupBoxBase1.Controls.Add(this.btnOtvori1);
            this.groupBoxBase1.Controls.Add(this.bтнОтвори);
            this.groupBoxBase1.Controls.Add(this.btnPecati);
            resources.ApplyResources(this.groupBoxBase1, "groupBoxBase1");
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.TabStop = false;
            // 
            // btnOtvori2
            // 
            resources.ApplyResources(this.btnOtvori2, "btnOtvori2");
            this.btnOtvori2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOtvori2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtvori2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOtvori2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOtvori2.Name = "btnOtvori2";
            this.btnOtvori2.UseVisualStyleBackColor = false;
            this.btnOtvori2.Click += new System.EventHandler(this.btnOtvori2_Click);
            // 
            // buttonPechatiDokumentiDo
            // 
            resources.ApplyResources(this.buttonPechatiDokumentiDo, "buttonPechatiDokumentiDo");
            this.buttonPechatiDokumentiDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPechatiDokumentiDo.Image = global::MMaterijalno.Properties.Resources.printer;
            this.buttonPechatiDokumentiDo.Name = "buttonPechatiDokumentiDo";
            this.buttonPechatiDokumentiDo.UseVisualStyleBackColor = false;
            this.buttonPechatiDokumentiDo.Click += new System.EventHandler(this.buttonPechatiDokumentiDo_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbServer
            // 
            resources.ApplyResources(this.cmbServer, "cmbServer");
            this.cmbServer.C_OnlyNumbers = false;
            this.cmbServer.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbServer.CurrentText = null;
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.DtTableName = null;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.value = null;
            // 
            // btnOtvori1
            // 
            resources.ApplyResources(this.btnOtvori1, "btnOtvori1");
            this.btnOtvori1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOtvori1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtvori1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOtvori1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOtvori1.Name = "btnOtvori1";
            this.btnOtvori1.UseVisualStyleBackColor = false;
            this.btnOtvori1.Click += new System.EventHandler(this.btnOtvori1_Click);
            // 
            // bтнОтвори
            // 
            this.bтнОтвори.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.bтнОтвори, "bтнОтвори");
            this.bтнОтвори.Image = global::MMaterijalno.Properties.Resources.edit;
            this.bтнОтвори.Name = "bтнОтвори";
            this.bтнОтвори.UseVisualStyleBackColor = false;
            this.bтнОтвори.Click += new System.EventHandler(this.bтнОтвори_Click_1);
            // 
            // btnPecati
            // 
            resources.ApplyResources(this.btnPecati, "btnPecati");
            this.btnPecati.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecati.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click_1);
            // 
            // viewDokumentiTableAdapter
            // 
            this.viewDokumentiTableAdapter.ClearBeforeFill = true;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // viewDokumentiStavkiBindingSource
            // 
            this.viewDokumentiStavkiBindingSource.DataMember = "viewDokumentiStavki";
            this.viewDokumentiStavkiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // viewDokumentiStavkiTableAdapter
            // 
            this.viewDokumentiStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.General_data_mesecTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoHvacTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = this.tblFirmaTableAdapter;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = null;
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
            // grFiltriSys
            // 
            this.grFiltriSys.Controls.Add(this.btnPrikaziSe);
            this.grFiltriSys.Controls.Add(this.dtShowDataOD);
            this.grFiltriSys.Controls.Add(this.btnPrikaziSporedFiltri);
            this.grFiltriSys.Controls.Add(this.dtShowDataDO);
            this.grFiltriSys.Controls.Add(this.bsslabel2);
            this.grFiltriSys.Controls.Add(this.bsslabel1);
            resources.ApplyResources(this.grFiltriSys, "grFiltriSys");
            this.grFiltriSys.Name = "grFiltriSys";
            this.grFiltriSys.TabStop = false;
            // 
            // btnPrikaziSe
            // 
            this.btnPrikaziSe.Image = global::MMaterijalno.Properties.Resources._001_38;
            resources.ApplyResources(this.btnPrikaziSe, "btnPrikaziSe");
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
            this.btnPrikaziSporedFiltri.Image = global::MMaterijalno.Properties.Resources._001_38;
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
            // general_data_mesecBindingSource
            // 
            this.general_data_mesecBindingSource.DataMember = "General_data_mesec";
            this.general_data_mesecBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // general_data_mesecTableAdapter
            // 
            this.general_data_mesecTableAdapter.ClearBeforeFill = true;
            // 
            // tblDokumentiDetailsInfoBindingSource
            // 
            this.tblDokumentiDetailsInfoBindingSource.DataMember = "tblDokumentiDetailsInfo";
            this.tblDokumentiDetailsInfoBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblDokumentiDetailsInfoTableAdapter
            // 
            this.tblDokumentiDetailsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tblDokumentiDetailsInfoHvacBindingSource
            // 
            this.tblDokumentiDetailsInfoHvacBindingSource.DataMember = "tblDokumentiDetailsInfoHvac";
            this.tblDokumentiDetailsInfoHvacBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblDokumentiDetailsInfoHvacTableAdapter
            // 
            this.tblDokumentiDetailsInfoHvacTableAdapter.ClearBeforeFill = true;
            // 
            // frmInterniDokumenti
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grFiltriSys);
            this.Controls.Add(this.groupBoxBase1);
            this.Controls.Add(this.viewDokumentiGridBig);
            this.Controls.Add(this.viewPriemiNavigator);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmInterniDokumenti";
            this.Load += new System.EventHandler(this.frmInterniDokumenti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInterniDokumenti_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiNavigator)).EndInit();
            this.viewPriemiNavigator.ResumeLayout(false);
            this.viewPriemiNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkiBindingSource)).EndInit();
            this.grFiltriSys.ResumeLayout(false);
            this.grFiltriSys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_data_mesecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoHvacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator viewPriemiNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private BssBase.DevGrid viewDokumentiGridBig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.Button bтнОтвори;
        private System.Windows.Forms.Button btnPecati;
        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource viewDokumentiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewDokumentiTableAdapter viewDokumentiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTipDokumentID;
        private DevExpress.XtraGrid.Columns.GridColumn colTipNaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colZabeleska;
        private DevExpress.XtraGrid.Columns.GridColumn colObejektDO;
        private DevExpress.XtraGrid.Columns.GridColumn colObjektOD;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDoObjektID;
        private DevExpress.XtraGrid.Columns.GridColumn colOdObjektID;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos18;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos5;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosSoDDV;
        private MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
        private System.Windows.Forms.BindingSource viewDokumentiStavkiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewDokumentiStavkiTableAdapter viewDokumentiStavkiTableAdapter;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colNazivPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colKnizeno;
        private BssBase.Elements.btnOtvori btnOtvori1;
        private BssBase.cmbBase cmbServer;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraPartner;
        private System.Windows.Forms.Button buttonPechatiDokumentiDo;
        private BssBase.Elements.btnOtvori btnOtvori2;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaDokument;
        private System.Windows.Forms.GroupBox grFiltriSys;
        private System.Windows.Forms.Button btnPrikaziSe;
        private BssBase.Elements.dtPickerBase dtShowDataOD;
        private System.Windows.Forms.Button btnPrikaziSporedFiltri;
        private BssBase.Elements.dtPickerBase dtShowDataDO;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.Elements.Bsslabel bsslabel1;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaValuta;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueIdPlacanje;
        private System.Windows.Forms.BindingSource general_data_mesecBindingSource;
        private MaterijalnoDataSetTableAdapters.General_data_mesecTableAdapter general_data_mesecTableAdapter;
        private System.Windows.Forms.BindingSource tblDokumentiDetailsInfoBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoTableAdapter tblDokumentiDetailsInfoTableAdapter;
        private System.Windows.Forms.BindingSource tblDokumentiDetailsInfoHvacBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoHvacTableAdapter tblDokumentiDetailsInfoHvacTableAdapter;
    }
}
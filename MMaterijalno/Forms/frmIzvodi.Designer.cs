namespace MMaterijalno.Forms
{
    partial class frmIzvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvodi));
            this.viewDokumentiGridBig = new BssBase.DevGrid();
            this.viewIzvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojNaIzvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaIzvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmetka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZabeleska = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazivPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDolzi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPobaruva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewIzvodiNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnPecati = new System.Windows.Forms.Button();
            this.bтнОтвори = new System.Windows.Forms.Button();
            this.viewIzvodiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewIzvodiTableAdapter();
            this.grFiltriSys = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSe = new System.Windows.Forms.Button();
            this.dtShowDataOD = new BssBase.Elements.dtPickerBase();
            this.btnPrikaziSporedFiltri = new System.Windows.Forms.Button();
            this.dtShowDataDO = new BssBase.Elements.dtPickerBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.colBrojNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiNavigator)).BeginInit();
            this.viewIzvodiNavigator.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            this.grFiltriSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewDokumentiGridBig
            // 
            this.viewDokumentiGridBig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDokumentiGridBig.AssemblyToLoad = null;
            this.viewDokumentiGridBig.DataSource = this.viewIzvodiBindingSource;
            this.viewDokumentiGridBig.EditForm = null;
            this.viewDokumentiGridBig.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDokumentiGridBig.FilterForm = null;
            this.viewDokumentiGridBig.Location = new System.Drawing.Point(0, 222);
            this.viewDokumentiGridBig.MainView = this.gridView1;
            this.viewDokumentiGridBig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDokumentiGridBig.Name = "viewDokumentiGridBig";
            this.viewDokumentiGridBig.PrimaryKey = null;
            this.viewDokumentiGridBig.reportCenter = false;
            this.viewDokumentiGridBig.ReportName = null;
            this.viewDokumentiGridBig.Size = new System.Drawing.Size(1648, 595);
            this.viewDokumentiGridBig.TabIndex = 7;
            this.viewDokumentiGridBig.TabStop = false;
            this.viewDokumentiGridBig.UpdateTable = null;
            this.viewDokumentiGridBig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.viewDokumentiGridBig.DataInsert += new BssBase.DevGrid.dataInsertEnd(this.viewDokumentiGridBig_DataInsert);
            this.viewDokumentiGridBig.dataSaveAll += new BssBase.DevGrid.dataSave(this.viewDokumentiGridBig_dataSaveAll);
            this.viewDokumentiGridBig.DoubleClick += new System.EventHandler(this.viewDokumentiGridBig_DoubleClick);
            // 
            // viewIzvodiBindingSource
            // 
            this.viewIzvodiBindingSource.DataMember = "viewIzvodi";
            this.viewIzvodiBindingSource.DataSource = this.materijalnoDataSet;
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
            this.colBrojNaIzvod,
            this.colDatumNaIzvod,
            this.colSmetka,
            this.colZabeleska,
            this.colSifraPartner,
            this.colNazivPartner,
            this.colDolzi,
            this.colPobaruva,
            this.colBrojNaDokument});
            this.gridView1.DetailHeight = 538;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.viewDokumentiGridBig;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pobaruva", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dolzi", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "BrojNaIzvod", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "DatumNaIzvod", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSmetka, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBrojNaIzvod, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colBrojNaIzvod
            // 
            this.colBrojNaIzvod.Caption = "Број на извод";
            this.colBrojNaIzvod.FieldName = "BrojNaIzvod";
            this.colBrojNaIzvod.MinWidth = 30;
            this.colBrojNaIzvod.Name = "colBrojNaIzvod";
            this.colBrojNaIzvod.Visible = true;
            this.colBrojNaIzvod.VisibleIndex = 1;
            this.colBrojNaIzvod.Width = 112;
            // 
            // colDatumNaIzvod
            // 
            this.colDatumNaIzvod.Caption = "Датум на извод";
            this.colDatumNaIzvod.FieldName = "DatumNaIzvod";
            this.colDatumNaIzvod.MinWidth = 30;
            this.colDatumNaIzvod.Name = "colDatumNaIzvod";
            this.colDatumNaIzvod.Visible = true;
            this.colDatumNaIzvod.VisibleIndex = 0;
            this.colDatumNaIzvod.Width = 112;
            // 
            // colSmetka
            // 
            this.colSmetka.Caption = "Сметка";
            this.colSmetka.FieldName = "Smetka";
            this.colSmetka.MinWidth = 30;
            this.colSmetka.Name = "colSmetka";
            this.colSmetka.Width = 112;
            // 
            // colZabeleska
            // 
            this.colZabeleska.Caption = "Забелешка";
            this.colZabeleska.FieldName = "Zabeleska";
            this.colZabeleska.MinWidth = 30;
            this.colZabeleska.Name = "colZabeleska";
            this.colZabeleska.Visible = true;
            this.colZabeleska.VisibleIndex = 3;
            this.colZabeleska.Width = 112;
            // 
            // colSifraPartner
            // 
            this.colSifraPartner.Caption = "Шифра партнер";
            this.colSifraPartner.FieldName = "SifraPartner";
            this.colSifraPartner.MinWidth = 30;
            this.colSifraPartner.Name = "colSifraPartner";
            this.colSifraPartner.Visible = true;
            this.colSifraPartner.VisibleIndex = 1;
            this.colSifraPartner.Width = 112;
            // 
            // colNazivPartner
            // 
            this.colNazivPartner.Caption = "Назив Партнер";
            this.colNazivPartner.FieldName = "NazivPartner";
            this.colNazivPartner.MinWidth = 30;
            this.colNazivPartner.Name = "colNazivPartner";
            this.colNazivPartner.Visible = true;
            this.colNazivPartner.VisibleIndex = 2;
            this.colNazivPartner.Width = 112;
            // 
            // colDolzi
            // 
            this.colDolzi.Caption = "Должи ";
            this.colDolzi.FieldName = "Dolzi";
            this.colDolzi.MinWidth = 30;
            this.colDolzi.Name = "colDolzi";
            this.colDolzi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dolzi", "{0:0.##}")});
            this.colDolzi.Visible = true;
            this.colDolzi.VisibleIndex = 5;
            this.colDolzi.Width = 112;
            // 
            // colPobaruva
            // 
            this.colPobaruva.Caption = "Побарува";
            this.colPobaruva.FieldName = "Pobaruva";
            this.colPobaruva.MinWidth = 30;
            this.colPobaruva.Name = "colPobaruva";
            this.colPobaruva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pobaruva", "{0:0.##}")});
            this.colPobaruva.Visible = true;
            this.colPobaruva.VisibleIndex = 6;
            this.colPobaruva.Width = 112;
            // 
            // viewIzvodiNavigator
            // 
            this.viewIzvodiNavigator.AddNewItem = null;
            this.viewIzvodiNavigator.AutoSize = false;
            this.viewIzvodiNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewIzvodiNavigator.CountItemFormat = "оf {0}";
            this.viewIzvodiNavigator.DeleteItem = null;
            this.viewIzvodiNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewIzvodiNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.viewIzvodiNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.viewIzvodiNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.viewIzvodiNavigator.Location = new System.Drawing.Point(0, 0);
            this.viewIzvodiNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewIzvodiNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewIzvodiNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewIzvodiNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewIzvodiNavigator.Name = "viewIzvodiNavigator";
            this.viewIzvodiNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.viewIzvodiNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viewIzvodiNavigator.Size = new System.Drawing.Size(1648, 122);
            this.viewIzvodiNavigator.TabIndex = 6;
            this.viewIzvodiNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 117);
            this.bindingNavigatorCountItem.Text = "оf {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(68, 117);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 117);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 122);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 122);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 117);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(68, 117);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 122);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(293, 117);
            this.bindingNavigatorAddNewItem.Text = "Додади нов извод";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(266, 117);
            this.bindingNavigatorDeleteItem.Text = "Избриши извод";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(177, 117);
            this.toolStripButton1.Text = "Освежи";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(135, 117);
            this.toolStripButton2.Text = "Излез";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase1.Controls.Add(this.btnPecati);
            this.groupBoxBase1.Controls.Add(this.bтнОтвори);
            this.groupBoxBase1.Location = new System.Drawing.Point(0, 826);
            this.groupBoxBase1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBase1.Size = new System.Drawing.Size(1648, 158);
            this.groupBoxBase1.TabIndex = 8;
            this.groupBoxBase1.TabStop = false;
            this.groupBoxBase1.Text = "Опции";
            // 
            // btnPecati
            // 
            this.btnPecati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPecati.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPecati.Image = ((System.Drawing.Image)(resources.GetObject("btnPecati.Image")));
            this.btnPecati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPecati.Location = new System.Drawing.Point(1281, 25);
            this.btnPecati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(350, 122);
            this.btnPecati.TabIndex = 3;
            this.btnPecati.Text = "Печати  одбрани изводи";
            this.btnPecati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // bтнОтвори
            // 
            this.bтнОтвори.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bтнОтвори.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bтнОтвори.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bтнОтвори.Image = ((System.Drawing.Image)(resources.GetObject("bтнОтвори.Image")));
            this.bтнОтвори.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bтнОтвори.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bтнОтвори.Location = new System.Drawing.Point(9, 25);
            this.bтнОтвори.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bтнОтвори.Name = "bтнОтвори";
            this.bтнОтвори.Size = new System.Drawing.Size(339, 122);
            this.bтнОтвори.TabIndex = 2;
            this.bтнОтвори.Text = "Отвори одбран извод";
            this.bтнОтвори.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bтнОтвори.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bтнОтвори.UseVisualStyleBackColor = false;
            this.bтнОтвори.Click += new System.EventHandler(this.bтнОтвори_Click_1);
            // 
            // viewIzvodiTableAdapter
            // 
            this.viewIzvodiTableAdapter.ClearBeforeFill = true;
            // 
            // grFiltriSys
            // 
            this.grFiltriSys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grFiltriSys.Controls.Add(this.btnPrikaziSe);
            this.grFiltriSys.Controls.Add(this.dtShowDataOD);
            this.grFiltriSys.Controls.Add(this.btnPrikaziSporedFiltri);
            this.grFiltriSys.Controls.Add(this.dtShowDataDO);
            this.grFiltriSys.Controls.Add(this.bsslabel2);
            this.grFiltriSys.Controls.Add(this.bsslabel1);
            this.grFiltriSys.Location = new System.Drawing.Point(0, 131);
            this.grFiltriSys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grFiltriSys.Name = "grFiltriSys";
            this.grFiltriSys.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grFiltriSys.Size = new System.Drawing.Size(1648, 82);
            this.grFiltriSys.TabIndex = 13;
            this.grFiltriSys.TabStop = false;
            this.grFiltriSys.Text = "Филтри";
            // 
            // btnPrikaziSe
            // 
            this.btnPrikaziSe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrikaziSe.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikaziSe.Image")));
            this.btnPrikaziSe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrikaziSe.Location = new System.Drawing.Point(1430, 28);
            this.btnPrikaziSe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikaziSe.Name = "btnPrikaziSe";
            this.btnPrikaziSe.Size = new System.Drawing.Size(210, 40);
            this.btnPrikaziSe.TabIndex = 10;
            this.btnPrikaziSe.Text = "Прикажи ги сите";
            this.btnPrikaziSe.UseVisualStyleBackColor = true;
            this.btnPrikaziSe.Click += new System.EventHandler(this.btnPrikaziSe_Click);
            // 
            // dtShowDataOD
            // 
            this.dtShowDataOD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtShowDataOD.CustomFormat = "yyyy-MM-dd";
            this.dtShowDataOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtShowDataOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShowDataOD.Location = new System.Drawing.Point(75, 29);
            this.dtShowDataOD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtShowDataOD.Name = "dtShowDataOD";
            this.dtShowDataOD.Size = new System.Drawing.Size(238, 35);
            this.dtShowDataOD.TabIndex = 5;
            // 
            // btnPrikaziSporedFiltri
            // 
            this.btnPrikaziSporedFiltri.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikaziSporedFiltri.Image")));
            this.btnPrikaziSporedFiltri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSporedFiltri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrikaziSporedFiltri.Location = new System.Drawing.Point(654, 29);
            this.btnPrikaziSporedFiltri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikaziSporedFiltri.Name = "btnPrikaziSporedFiltri";
            this.btnPrikaziSporedFiltri.Size = new System.Drawing.Size(192, 40);
            this.btnPrikaziSporedFiltri.TabIndex = 9;
            this.btnPrikaziSporedFiltri.Text = "Прикажи";
            this.btnPrikaziSporedFiltri.UseVisualStyleBackColor = true;
            this.btnPrikaziSporedFiltri.Click += new System.EventHandler(this.btnPrikaziSporedFiltri_Click);
            // 
            // dtShowDataDO
            // 
            this.dtShowDataDO.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtShowDataDO.CustomFormat = "yyyy-MM-dd";
            this.dtShowDataDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtShowDataDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShowDataDO.Location = new System.Drawing.Point(404, 29);
            this.dtShowDataDO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtShowDataDO.Name = "dtShowDataDO";
            this.dtShowDataDO.Size = new System.Drawing.Size(238, 35);
            this.dtShowDataDO.TabIndex = 6;
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bsslabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bsslabel2.Location = new System.Drawing.Point(324, 37);
            this.bsslabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(54, 29);
            this.bsslabel2.TabIndex = 8;
            this.bsslabel2.Text = "ДО:";
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bsslabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bsslabel1.Location = new System.Drawing.Point(10, 37);
            this.bsslabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(54, 29);
            this.bsslabel1.TabIndex = 7;
            this.bsslabel1.Text = "ОД:";
            // 
            // colBrojNaDokument
            // 
            this.colBrojNaDokument.Caption = "Број на документ";
            this.colBrojNaDokument.FieldName = "BrojNaDokument";
            this.colBrojNaDokument.MinWidth = 30;
            this.colBrojNaDokument.Name = "colBrojNaDokument";
            this.colBrojNaDokument.Visible = true;
            this.colBrojNaDokument.VisibleIndex = 4;
            this.colBrojNaDokument.Width = 112;
            // 
            // frmIzvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 985);
            this.Controls.Add(this.grFiltriSys);
            this.Controls.Add(this.groupBoxBase1);
            this.Controls.Add(this.viewDokumentiGridBig);
            this.Controls.Add(this.viewIzvodiNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIzvodi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изводи";
            this.Load += new System.EventHandler(this.frmIzvodi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInterniDokumenti_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiNavigator)).EndInit();
            this.viewIzvodiNavigator.ResumeLayout(false);
            this.viewIzvodiNavigator.PerformLayout();
            this.groupBoxBase1.ResumeLayout(false);
            this.grFiltriSys.ResumeLayout(false);
            this.grFiltriSys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BssBase.DevGrid viewDokumentiGridBig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingNavigator viewIzvodiNavigator;
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
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.Button bтнОтвори;
        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource viewIzvodiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewIzvodiTableAdapter viewIzvodiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaIzvod;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaIzvod;
        private DevExpress.XtraGrid.Columns.GridColumn colSmetka;
        private DevExpress.XtraGrid.Columns.GridColumn colZabeleska;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colNazivPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colDolzi;
        private DevExpress.XtraGrid.Columns.GridColumn colPobaruva;
        private System.Windows.Forms.GroupBox grFiltriSys;
        private System.Windows.Forms.Button btnPrikaziSe;
        private BssBase.Elements.dtPickerBase dtShowDataOD;
        private System.Windows.Forms.Button btnPrikaziSporedFiltri;
        private BssBase.Elements.dtPickerBase dtShowDataDO;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.Elements.Bsslabel bsslabel1;
        private System.Windows.Forms.Button btnPecati;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaDokument;
    }
}
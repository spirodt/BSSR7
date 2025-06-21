namespace MFakturi.Forms {
	partial class frmObrabotkaNaFaktura {
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
            System.Windows.Forms.Label tblZiroSmetkaIDLabel;
            System.Windows.Forms.Label valutaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label brojLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label iznosLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label rabat1Label;
            System.Windows.Forms.Label zabeleskaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObrabotkaNaFaktura));
            this.listaNaIspratniciLabel = new System.Windows.Forms.Label();
            this.fakturiDataSet = new MFakturi.FakturiDataSet();
            this.viewFakturiStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFakturiStavkiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewFakturiStavkiTableAdapter();
            this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
            this.viewFakturiStavkiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewFakturiStavkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.viewFakturiStavkiDevGrid = new BssBase.DevGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblFakturaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblArtikalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltSifa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCenaSoDDVIRabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tblFakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFakturaTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblFakturaTableAdapter();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.zabeleskaTextBox = new BssBase.txtBase();
            this.listaNaIspratniciTextBox = new BssBase.txtBase();
            this.butnIspratnica = new System.Windows.Forms.Button();
            this.butnProfaktura = new System.Windows.Forms.Button();
            this.brojTextBox = new BssBase.txtBase();
            this.btnSocuvajZaglavje = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.tblZiroSmetkaIDcmbBase = new BssBase.cmbBase();
            this.txtPartner = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.zbxPartner = new BssBase.zbxBase();
            this.valutaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCenaBezDDV = new BssBase.txtBase();
            this.txtSoDDV = new BssBase.txtBase();
            this.txtBase1 = new BssBase.txtBase();
            this.rabat1txtBase = new BssBase.txtBase();
            this.tblFakturaStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchArtikal = new System.Windows.Forms.Button();
            this.txtArtikalSearch = new BssBase.txtBase();
            this.txtcena = new BssBase.txtBase();
            this.btnIzbrisiStavka = new System.Windows.Forms.Button();
            this.btnSocuvajStavka = new System.Windows.Forms.Button();
            this.txtDDV = new BssBase.txtBase();
            this.txtEDM = new BssBase.txtBase();
            this.txtArtikalNaziv = new BssBase.txtBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.iznostxtBase = new BssBase.txtBase();
            this.kolicinatxtBase = new BssBase.txtBase();
            this.tblFakturaStavkiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblFakturaStavkiTableAdapter();
            this.viewFakturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFakturiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewFakturiTableAdapter();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPartneriTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblPartneriTableAdapter();
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblFirmaTableAdapter();
            tblZiroSmetkaIDLabel = new System.Windows.Forms.Label();
            valutaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            brojLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            iznosLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            rabat1Label = new System.Windows.Forms.Label();
            zabeleskaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiBindingNavigator)).BeginInit();
            this.viewFakturiStavkiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFakturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFakturaStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainTab.Size = new System.Drawing.Size(1052, 544);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Margin = new System.Windows.Forms.Padding(4);
            this.tabVnes.Size = new System.Drawing.Size(1044, 518);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.xtraTabControl1);
            this.groupVnes.Controls.Add(this.viewFakturiStavkiDevGrid);
            this.groupVnes.Margin = new System.Windows.Forms.Padding(4);
            this.groupVnes.Padding = new System.Windows.Forms.Padding(4);
            this.groupVnes.Size = new System.Drawing.Size(1041, 515);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 543);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.PanelFooter.Size = new System.Drawing.Size(1056, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 1);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.MinimumSize = new System.Drawing.Size(176, 47);
            this.btnZatvori.Size = new System.Drawing.Size(176, 47);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(861, 1);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.MinimumSize = new System.Drawing.Size(176, 47);
            this.btnOk.Size = new System.Drawing.Size(176, 47);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tblZiroSmetkaIDLabel
            // 
            tblZiroSmetkaIDLabel.AutoSize = true;
            tblZiroSmetkaIDLabel.Location = new System.Drawing.Point(404, 105);
            tblZiroSmetkaIDLabel.Name = "tblZiroSmetkaIDLabel";
            tblZiroSmetkaIDLabel.Size = new System.Drawing.Size(170, 29);
            tblZiroSmetkaIDLabel.TabIndex = 21;
            tblZiroSmetkaIDLabel.Text = "Жиро сметка:";
            // 
            // valutaLabel
            // 
            valutaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            valutaLabel.AutoSize = true;
            valutaLabel.Location = new System.Drawing.Point(750, 10);
            valutaLabel.Name = "valutaLabel";
            valutaLabel.Size = new System.Drawing.Size(99, 29);
            valutaLabel.TabIndex = 16;
            valutaLabel.Text = "Валута:";
            // 
            // datumLabel
            // 
            datumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(332, 10);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(222, 29);
            datumLabel.TabIndex = 14;
            datumLabel.Text = "Датум на фактура:";
            // 
            // brojLabel
            // 
            brojLabel.AutoSize = true;
            brojLabel.Location = new System.Drawing.Point(3, 10);
            brojLabel.Name = "brojLabel";
            brojLabel.Size = new System.Drawing.Size(68, 29);
            brojLabel.TabIndex = 12;
            brojLabel.Text = "Број:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(5, 53);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(118, 26);
            kolicinaLabel.TabIndex = 0;
            kolicinaLabel.Text = "Количина:";
            // 
            // iznosLabel
            // 
            iznosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iznosLabel.AutoSize = true;
            iznosLabel.Location = new System.Drawing.Point(751, 173);
            iznosLabel.Name = "iznosLabel";
            iznosLabel.Size = new System.Drawing.Size(80, 26);
            iznosLabel.TabIndex = 2;
            iznosLabel.Text = "Износ:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(662, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 26);
            label1.TabIndex = 13;
            label1.Text = "Препорачана Цена:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(2, 173);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(164, 26);
            label7.TabIndex = 29;
            label7.Text = "Цена со рабат:";
            // 
            // rabat1Label
            // 
            rabat1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rabat1Label.AutoSize = true;
            rabat1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            rabat1Label.Location = new System.Drawing.Point(458, 173);
            rabat1Label.Name = "rabat1Label";
            rabat1Label.Size = new System.Drawing.Size(80, 26);
            rabat1Label.TabIndex = 26;
            rabat1Label.Text = "Рабат:";
            // 
            // zabeleskaLabel
            // 
            zabeleskaLabel.AutoSize = true;
            zabeleskaLabel.Location = new System.Drawing.Point(11, 148);
            zabeleskaLabel.Name = "zabeleskaLabel";
            zabeleskaLabel.Size = new System.Drawing.Size(149, 29);
            zabeleskaLabel.TabIndex = 26;
            zabeleskaLabel.Text = "Забелешка:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(572, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(302, 26);
            label2.TabIndex = 31;
            label2.Text = "Продажна Цена ( Со ДДВ ) :";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(569, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(305, 26);
            label3.TabIndex = 33;
            label3.Text = "Продажна Цена ( Без ДДВ ):";
            // 
            // listaNaIspratniciLabel
            // 
            this.listaNaIspratniciLabel.AutoSize = true;
            this.listaNaIspratniciLabel.Location = new System.Drawing.Point(3, 103);
            this.listaNaIspratniciLabel.Name = "listaNaIspratniciLabel";
            this.listaNaIspratniciLabel.Size = new System.Drawing.Size(163, 29);
            this.listaNaIspratniciLabel.TabIndex = 25;
            this.listaNaIspratniciLabel.Text = "Испратници:";
            // 
            // fakturiDataSet
            // 
            this.fakturiDataSet.DataSetName = "FakturiDataSet";
            this.fakturiDataSet.EnforceConstraints = false;
            this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewFakturiStavkiBindingSource
            // 
            this.viewFakturiStavkiBindingSource.DataMember = "viewFakturiStavki";
            this.viewFakturiStavkiBindingSource.DataSource = this.fakturiDataSet;
            this.viewFakturiStavkiBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.viewFakturiStavkiBindingSource_ListChanged);
            // 
            // viewFakturiStavkiTableAdapter
            // 
            this.viewFakturiStavkiTableAdapter.ClearBeforeFill = true;
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
            // viewFakturiStavkiBindingNavigator
            // 
            this.viewFakturiStavkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.viewFakturiStavkiBindingNavigator.BindingSource = this.viewFakturiStavkiBindingSource;
            this.viewFakturiStavkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewFakturiStavkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.viewFakturiStavkiBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewFakturiStavkiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewFakturiStavkiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.viewFakturiStavkiBindingNavigatorSaveItem});
            this.viewFakturiStavkiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.viewFakturiStavkiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewFakturiStavkiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewFakturiStavkiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewFakturiStavkiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewFakturiStavkiBindingNavigator.Name = "viewFakturiStavkiBindingNavigator";
            this.viewFakturiStavkiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viewFakturiStavkiBindingNavigator.Size = new System.Drawing.Size(933, 25);
            this.viewFakturiStavkiBindingNavigator.TabIndex = 6;
            this.viewFakturiStavkiBindingNavigator.Text = "bindingNavigator1";
            this.viewFakturiStavkiBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // viewFakturiStavkiBindingNavigatorSaveItem
            // 
            this.viewFakturiStavkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewFakturiStavkiBindingNavigatorSaveItem.Enabled = false;
            this.viewFakturiStavkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("viewFakturiStavkiBindingNavigatorSaveItem.Image")));
            this.viewFakturiStavkiBindingNavigatorSaveItem.Name = "viewFakturiStavkiBindingNavigatorSaveItem";
            this.viewFakturiStavkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 22);
            this.viewFakturiStavkiBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // viewFakturiStavkiDevGrid
            // 
            this.viewFakturiStavkiDevGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFakturiStavkiDevGrid.AssemblyToLoad = null;
            this.viewFakturiStavkiDevGrid.DataSource = this.viewFakturiStavkiBindingSource;
            this.viewFakturiStavkiDevGrid.EditForm = null;
            this.viewFakturiStavkiDevGrid.FilterForm = null;
            this.viewFakturiStavkiDevGrid.Location = new System.Drawing.Point(6, 339);
            this.viewFakturiStavkiDevGrid.MainView = this.gridView1;
            this.viewFakturiStavkiDevGrid.Name = "viewFakturiStavkiDevGrid";
            this.viewFakturiStavkiDevGrid.PrimaryKey = null;
            this.viewFakturiStavkiDevGrid.reportCenter = false;
            this.viewFakturiStavkiDevGrid.ReportName = null;
            this.viewFakturiStavkiDevGrid.Size = new System.Drawing.Size(1025, 176);
            this.viewFakturiStavkiDevGrid.TabIndex = 0;
            this.viewFakturiStavkiDevGrid.UpdateTable = null;
            this.viewFakturiStavkiDevGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.coltblFakturaID,
            this.colBroj,
            this.coltblArtikalID,
            this.colArtikal,
            this.colProdaznaCena,
            this.colDDV,
            this.colEDM,
            this.colKolicina,
            this.colIznos,
            this.colIznosBezDDV,
            this.colDDVIznos,
            this.colRabat1,
            this.colRabat2,
            this.colRabat3,
            this.colAltSifa,
            this.colSifra,
            this.colProdaznaCenaSoDDVIRabat,
            this.colCenaSoDDV});
            this.gridView1.GridControl = this.viewFakturiStavkiDevGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
              // 
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Artikal", "", 0)});
            // 
            // coltblFakturaID
            // 
            this.coltblFakturaID.Caption = "Реден број на фактура";
            this.coltblFakturaID.FieldName = "tblFakturaID";
            this.coltblFakturaID.Name = "coltblFakturaID";
            // 
            // colBroj
            // 
            this.colBroj.Caption = "Број на фактура";
            this.colBroj.FieldName = "Broj";
            this.colBroj.Name = "colBroj";
            // 
            // coltblArtikalID
            // 
            this.coltblArtikalID.Caption = "Реден број на артикал";
            this.coltblArtikalID.FieldName = "tblArtikalID";
            this.coltblArtikalID.Name = "coltblArtikalID";
            // 
            // colArtikal
            // 
            this.colArtikal.Caption = "Артикал";
            this.colArtikal.FieldName = "Artikal";
            this.colArtikal.Name = "colArtikal";
            this.colArtikal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Artikal", "{0}")});
            this.colArtikal.Visible = true;
            this.colArtikal.VisibleIndex = 2;
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Продажна цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            // 
            // colDDV
            // 
            this.colDDV.Caption = "ДДВ";
            this.colDDV.FieldName = "DDV";
            this.colDDV.Name = "colDDV";
            this.colDDV.Visible = true;
            this.colDDV.VisibleIndex = 4;
            // 
            // colEDM
            // 
            this.colEDM.Caption = "Единечна мерка";
            this.colEDM.FieldName = "EDM";
            this.colEDM.Name = "colEDM";
            this.colEDM.Visible = true;
            this.colEDM.VisibleIndex = 6;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kolicina", "", 0)});
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 8;
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "", 0D)});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 10;
            // 
            // colIznosBezDDV
            // 
            this.colIznosBezDDV.Caption = "Изсно без ДДВ";
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.Visible = true;
            this.colIznosBezDDV.VisibleIndex = 9;
            // 
            // colDDVIznos
            // 
            this.colDDVIznos.Caption = "Фактуриран ДДВ";
            this.colDDVIznos.FieldName = "DDVIznos";
            this.colDDVIznos.Name = "colDDVIznos";
            this.colDDVIznos.Visible = true;
            this.colDDVIznos.VisibleIndex = 7;
            // 
            // colRabat1
            // 
            this.colRabat1.Caption = "Рабат1";
            this.colRabat1.FieldName = "Rabat1";
            this.colRabat1.Name = "colRabat1";
            this.colRabat1.Visible = true;
            this.colRabat1.VisibleIndex = 5;
            // 
            // colRabat2
            // 
            this.colRabat2.Caption = "Рабат2";
            this.colRabat2.FieldName = "Rabat2";
            this.colRabat2.Name = "colRabat2";
            // 
            // colRabat3
            // 
            this.colRabat3.Caption = "Рабат3";
            this.colRabat3.FieldName = "Rabat3";
            this.colRabat3.Name = "colRabat3";
            // 
            // colAltSifa
            // 
            this.colAltSifa.Caption = "Алт.Шифра";
            this.colAltSifa.FieldName = "AltSifa";
            this.colAltSifa.Name = "colAltSifa";
            this.colAltSifa.Visible = true;
            this.colAltSifa.VisibleIndex = 1;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 0;
            // 
            // colProdaznaCenaSoDDVIRabat
            // 
            this.colProdaznaCenaSoDDVIRabat.Caption = "Продажна цена со ДДВ и рабат";
            this.colProdaznaCenaSoDDVIRabat.FieldName = "ProdaznaCenaSoDDVIRabat";
            this.colProdaznaCenaSoDDVIRabat.Name = "colProdaznaCenaSoDDVIRabat";
            this.colProdaznaCenaSoDDVIRabat.Visible = true;
            this.colProdaznaCenaSoDDVIRabat.VisibleIndex = 3;
            // 
            // colCenaSoDDV
            // 
            this.colCenaSoDDV.Caption = "Цена со ДДВ";
            this.colCenaSoDDV.FieldName = "CenaSoDDV";
            this.colCenaSoDDV.Name = "colCenaSoDDV";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1056, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Size = new System.Drawing.Size(1056, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1056, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
            // 
            // tblFakturaBindingSource
            // 
            this.tblFakturaBindingSource.DataMember = "tblFaktura";
            this.tblFakturaBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tblFakturaTableAdapter
            // 
            this.tblFakturaTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 20);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1031, 318);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.button1);
            this.xtraTabPage1.Controls.Add(zabeleskaLabel);
            this.xtraTabPage1.Controls.Add(this.zabeleskaTextBox);
            this.xtraTabPage1.Controls.Add(this.listaNaIspratniciLabel);
            this.xtraTabPage1.Controls.Add(this.listaNaIspratniciTextBox);
            this.xtraTabPage1.Controls.Add(this.butnIspratnica);
            this.xtraTabPage1.Controls.Add(this.butnProfaktura);
            this.xtraTabPage1.Controls.Add(datumLabel);
            this.xtraTabPage1.Controls.Add(this.brojTextBox);
            this.xtraTabPage1.Controls.Add(this.btnSocuvajZaglavje);
            this.xtraTabPage1.Controls.Add(this.btnPecati);
            this.xtraTabPage1.Controls.Add(tblZiroSmetkaIDLabel);
            this.xtraTabPage1.Controls.Add(this.tblZiroSmetkaIDcmbBase);
            this.xtraTabPage1.Controls.Add(this.txtPartner);
            this.xtraTabPage1.Controls.Add(this.bsslabel1);
            this.xtraTabPage1.Controls.Add(this.zbxPartner);
            this.xtraTabPage1.Controls.Add(valutaLabel);
            this.xtraTabPage1.Controls.Add(this.valutaDateTimePicker);
            this.xtraTabPage1.Controls.Add(this.datumDateTimePicker);
            this.xtraTabPage1.Controls.Add(brojLabel);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1025, 290);
            this.xtraTabPage1.Text = "Заглавје на фактурата";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::MFakturi.Properties.Resources.pecati;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(235, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 79);
            this.button1.TabIndex = 27;
            this.button1.Text = "Печати Баркоди";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // zabeleskaTextBox
            // 
            this.zabeleskaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zabeleskaTextBox.AssemblyStr = null;
            this.zabeleskaTextBox.C_FillWithZeros = false;
            this.zabeleskaTextBox.C_OnlyNumbers = false;
            this.zabeleskaTextBox.C_RegEx = false;
            this.zabeleskaTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.zabeleskaTextBox.ColumnName1 = null;
            this.zabeleskaTextBox.ColumnName2 = null;
            this.zabeleskaTextBox.ColumnName3 = null;
            this.zabeleskaTextBox.ColumnName4 = null;
            this.zabeleskaTextBox.ColumnName5 = null;
            this.zabeleskaTextBox.ColumnName6 = null;
            this.zabeleskaTextBox.ColumnName7 = null;
            this.zabeleskaTextBox.daliCetiri = false;
            this.zabeleskaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFakturaBindingSource, "Zabeleska", true));
            this.zabeleskaTextBox.Format = null;
            this.zabeleskaTextBox.formToOpen = null;
            this.zabeleskaTextBox.iscistiGreenNaLeave = false;
            this.zabeleskaTextBox.KoristiFilterNaDatasource = false;
            this.zabeleskaTextBox.Location = new System.Drawing.Point(166, 145);
            this.zabeleskaTextBox.MakedonskiJazik = false;
            this.zabeleskaTextBox.MinLength = 0;
            this.zabeleskaTextBox.Multiline = true;
            this.zabeleskaTextBox.Name = "zabeleskaTextBox";
            this.zabeleskaTextBox.PopulateOtherFields = false;
            this.zabeleskaTextBox.regularExpression = null;
            this.zabeleskaTextBox.SelektrijaNaFokus = false;
            this.zabeleskaTextBox.Size = new System.Drawing.Size(847, 56);
            this.zabeleskaTextBox.TabIndex = 6;
            // 
            // listaNaIspratniciTextBox
            // 
            this.listaNaIspratniciTextBox.AssemblyStr = null;
            this.listaNaIspratniciTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.listaNaIspratniciTextBox.C_FillWithZeros = false;
            this.listaNaIspratniciTextBox.C_OnlyNumbers = false;
            this.listaNaIspratniciTextBox.C_RegEx = false;
            this.listaNaIspratniciTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.listaNaIspratniciTextBox.ColumnName1 = null;
            this.listaNaIspratniciTextBox.ColumnName2 = null;
            this.listaNaIspratniciTextBox.ColumnName3 = null;
            this.listaNaIspratniciTextBox.ColumnName4 = null;
            this.listaNaIspratniciTextBox.ColumnName5 = null;
            this.listaNaIspratniciTextBox.ColumnName6 = null;
            this.listaNaIspratniciTextBox.ColumnName7 = null;
            this.listaNaIspratniciTextBox.daliCetiri = false;
            this.listaNaIspratniciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFakturaBindingSource, "ListaNaIspratnici", true));
            this.listaNaIspratniciTextBox.ForeColor = System.Drawing.Color.Blue;
            this.listaNaIspratniciTextBox.Format = null;
            this.listaNaIspratniciTextBox.formToOpen = null;
            this.listaNaIspratniciTextBox.iscistiGreenNaLeave = false;
            this.listaNaIspratniciTextBox.KoristiFilterNaDatasource = false;
            this.listaNaIspratniciTextBox.Location = new System.Drawing.Point(166, 99);
            this.listaNaIspratniciTextBox.MakedonskiJazik = false;
            this.listaNaIspratniciTextBox.MinLength = 0;
            this.listaNaIspratniciTextBox.Name = "listaNaIspratniciTextBox";
            this.listaNaIspratniciTextBox.PopulateOtherFields = false;
            this.listaNaIspratniciTextBox.ReadOnly = true;
            this.listaNaIspratniciTextBox.regularExpression = null;
            this.listaNaIspratniciTextBox.SelektrijaNaFokus = false;
            this.listaNaIspratniciTextBox.Size = new System.Drawing.Size(229, 35);
            this.listaNaIspratniciTextBox.TabIndex = 5;
            this.listaNaIspratniciTextBox.DoubleClick += new System.EventHandler(this.listaNaIspratniciTextBox_DoubleClick);
            this.listaNaIspratniciTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listaNaIspratniciTextBox_KeyDown);
            // 
            // butnIspratnica
            // 
            this.butnIspratnica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butnIspratnica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butnIspratnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnIspratnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butnIspratnica.Image = global::MFakturi.Properties.Resources.pecati;
            this.butnIspratnica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butnIspratnica.Location = new System.Drawing.Point(434, 207);
            this.butnIspratnica.Name = "butnIspratnica";
            this.butnIspratnica.Size = new System.Drawing.Size(203, 79);
            this.butnIspratnica.TabIndex = 25;
            this.butnIspratnica.Text = "Печати  Испратница";
            this.butnIspratnica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butnIspratnica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butnIspratnica.UseVisualStyleBackColor = false;
            this.butnIspratnica.Click += new System.EventHandler(this.butnIspratnica_Click);
            // 
            // butnProfaktura
            // 
            this.butnProfaktura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butnProfaktura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butnProfaktura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnProfaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butnProfaktura.Image = global::MFakturi.Properties.Resources.pecati;
            this.butnProfaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butnProfaktura.Location = new System.Drawing.Point(643, 207);
            this.butnProfaktura.Name = "butnProfaktura";
            this.butnProfaktura.Size = new System.Drawing.Size(190, 79);
            this.butnProfaktura.TabIndex = 24;
            this.butnProfaktura.Text = "Печати  про-фактура";
            this.butnProfaktura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butnProfaktura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butnProfaktura.UseVisualStyleBackColor = false;
            this.butnProfaktura.Click += new System.EventHandler(this.button1_Click);
            // 
            // brojTextBox
            // 
            this.brojTextBox.AssemblyStr = null;
            this.brojTextBox.C_FillWithZeros = false;
            this.brojTextBox.C_OnlyNumbers = true;
            this.brojTextBox.C_RegEx = false;
            this.brojTextBox.C_ShowRedOnLeaveIfEmpty = true;
            this.brojTextBox.ColumnName1 = null;
            this.brojTextBox.ColumnName2 = null;
            this.brojTextBox.ColumnName3 = null;
            this.brojTextBox.ColumnName4 = null;
            this.brojTextBox.ColumnName5 = null;
            this.brojTextBox.ColumnName6 = null;
            this.brojTextBox.ColumnName7 = null;
            this.brojTextBox.daliCetiri = false;
            this.brojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFakturaBindingSource, "Broj", true));
            this.brojTextBox.Format = null;
            this.brojTextBox.formToOpen = null;
            this.brojTextBox.iscistiGreenNaLeave = false;
            this.brojTextBox.KoristiFilterNaDatasource = false;
            this.brojTextBox.Location = new System.Drawing.Point(74, 10);
            this.brojTextBox.MakedonskiJazik = false;
            this.brojTextBox.MinLength = 0;
            this.brojTextBox.Name = "brojTextBox";
            this.brojTextBox.PopulateOtherFields = false;
            this.brojTextBox.regularExpression = null;
            this.brojTextBox.SelektrijaNaFokus = false;
            this.brojTextBox.Size = new System.Drawing.Size(100, 35);
            this.brojTextBox.TabIndex = 0;
            // 
            // btnSocuvajZaglavje
            // 
            this.btnSocuvajZaglavje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSocuvajZaglavje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocuvajZaglavje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSocuvajZaglavje.Image = global::MFakturi.Properties.Resources.accept;
            this.btnSocuvajZaglavje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajZaglavje.Location = new System.Drawing.Point(8, 207);
            this.btnSocuvajZaglavje.Name = "btnSocuvajZaglavje";
            this.btnSocuvajZaglavje.Size = new System.Drawing.Size(221, 79);
            this.btnSocuvajZaglavje.TabIndex = 7;
            this.btnSocuvajZaglavje.Text = "Сочувај заглавје";
            this.btnSocuvajZaglavje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocuvajZaglavje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSocuvajZaglavje.UseVisualStyleBackColor = false;
            this.btnSocuvajZaglavje.Click += new System.EventHandler(this.btnSocuvajZaglavje_Click);
            // 
            // btnPecati
            // 
            this.btnPecati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPecati.BackColor = System.Drawing.Color.LightCoral;
            this.btnPecati.Enabled = false;
            this.btnPecati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPecati.Image = global::MFakturi.Properties.Resources.pecati;
            this.btnPecati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati.Location = new System.Drawing.Point(839, 207);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(174, 79);
            this.btnPecati.TabIndex = 23;
            this.btnPecati.Text = "Печати фактура и прокнижи ";
            this.btnPecati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // tblZiroSmetkaIDcmbBase
            // 
            this.tblZiroSmetkaIDcmbBase.C_OnlyNumbers = false;
            this.tblZiroSmetkaIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.tblZiroSmetkaIDcmbBase.CurrentText = null;
            this.tblZiroSmetkaIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tblZiroSmetkaIDcmbBase.DtTableName = null;
            this.tblZiroSmetkaIDcmbBase.FormattingEnabled = true;
            this.tblZiroSmetkaIDcmbBase.Location = new System.Drawing.Point(580, 102);
            this.tblZiroSmetkaIDcmbBase.Name = "tblZiroSmetkaIDcmbBase";
            this.tblZiroSmetkaIDcmbBase.Size = new System.Drawing.Size(310, 37);
            this.tblZiroSmetkaIDcmbBase.TabIndex = 4;
            this.tblZiroSmetkaIDcmbBase.value = null;
            // 
            // txtPartner
            // 
            this.txtPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartner.AssemblyStr = null;
            this.txtPartner.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPartner.C_FillWithZeros = false;
            this.txtPartner.C_OnlyNumbers = false;
            this.txtPartner.C_RegEx = false;
            this.txtPartner.C_ShowRedOnLeaveIfEmpty = false;
            this.txtPartner.ColumnName1 = null;
            this.txtPartner.ColumnName2 = null;
            this.txtPartner.ColumnName3 = null;
            this.txtPartner.ColumnName4 = null;
            this.txtPartner.ColumnName5 = null;
            this.txtPartner.ColumnName6 = null;
            this.txtPartner.ColumnName7 = null;
            this.txtPartner.daliCetiri = false;
            this.txtPartner.ForeColor = System.Drawing.Color.Blue;
            this.txtPartner.Format = null;
            this.txtPartner.formToOpen = null;
            this.txtPartner.iscistiGreenNaLeave = false;
            this.txtPartner.KoristiFilterNaDatasource = false;
            this.txtPartner.Location = new System.Drawing.Point(331, 54);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(682, 41);
            this.txtPartner.TabIndex = 19;
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(3, 54);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(118, 29);
            this.bsslabel1.TabIndex = 20;
            this.bsslabel1.Text = "Партнер:";
            // 
            // zbxPartner
            // 
            this.zbxPartner.AssemblyStr = "MFakturi";
            this.zbxPartner.AutoSize = true;
            this.zbxPartner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zbxPartner.ColumnName1 = "ID";
            this.zbxPartner.ColumnName2 = "Naziv";
            this.zbxPartner.ColumnName3 = "SIFRA";
            this.zbxPartner.ColumnName4 = "ADRESA";
            this.zbxPartner.ColumnName5 = "TELEFONI";
            this.zbxPartner.ColumnName6 = null;
            this.zbxPartner.ColumnName7 = null;
            this.zbxPartner.filterDataSource = "Tip = 2 OR Tip = -1";
            this.zbxPartner.formToOpen = "MFakturi.Forms.frmPartner";
            this.zbxPartner.GridFromForm = null;
            this.zbxPartner.KoristiFilterNaDatasource = true;
            this.zbxPartner.Location = new System.Drawing.Point(127, 40);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(123, 55);
            this.zbxPartner.TabIndex = 3;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validated += new System.EventHandler(this.zbxPartner_Validated);
            // 
            // valutaDateTimePicker
            // 
            this.valutaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valutaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblFakturaBindingSource, "Valuta", true));
            this.valutaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.valutaDateTimePicker.Location = new System.Drawing.Point(855, 10);
            this.valutaDateTimePicker.Name = "valutaDateTimePicker";
            this.valutaDateTimePicker.Size = new System.Drawing.Size(158, 35);
            this.valutaDateTimePicker.TabIndex = 2;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblFakturaBindingSource, "Datum", true));
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(560, 10);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(158, 35);
            this.datumDateTimePicker.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(label3);
            this.xtraTabPage2.Controls.Add(this.txtCenaBezDDV);
            this.xtraTabPage2.Controls.Add(label2);
            this.xtraTabPage2.Controls.Add(this.txtSoDDV);
            this.xtraTabPage2.Controls.Add(label7);
            this.xtraTabPage2.Controls.Add(this.txtBase1);
            this.xtraTabPage2.Controls.Add(rabat1Label);
            this.xtraTabPage2.Controls.Add(this.rabat1txtBase);
            this.xtraTabPage2.Controls.Add(this.btnSearchArtikal);
            this.xtraTabPage2.Controls.Add(this.txtArtikalSearch);
            this.xtraTabPage2.Controls.Add(label1);
            this.xtraTabPage2.Controls.Add(this.txtcena);
            this.xtraTabPage2.Controls.Add(this.btnIzbrisiStavka);
            this.xtraTabPage2.Controls.Add(this.btnSocuvajStavka);
            this.xtraTabPage2.Controls.Add(this.txtDDV);
            this.xtraTabPage2.Controls.Add(this.txtEDM);
            this.xtraTabPage2.Controls.Add(this.txtArtikalNaziv);
            this.xtraTabPage2.Controls.Add(this.bsslabel2);
            this.xtraTabPage2.Controls.Add(iznosLabel);
            this.xtraTabPage2.Controls.Add(this.iznostxtBase);
            this.xtraTabPage2.Controls.Add(kolicinaLabel);
            this.xtraTabPage2.Controls.Add(this.kolicinatxtBase);
            this.xtraTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1025, 290);
            this.xtraTabPage2.Text = "Внес на ставки";
            // 
            // txtCenaBezDDV
            // 
            this.txtCenaBezDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCenaBezDDV.AssemblyStr = null;
            this.txtCenaBezDDV.C_FillWithZeros = false;
            this.txtCenaBezDDV.C_OnlyNumbers = true;
            this.txtCenaBezDDV.C_RegEx = false;
            this.txtCenaBezDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtCenaBezDDV.ColumnName1 = null;
            this.txtCenaBezDDV.ColumnName2 = null;
            this.txtCenaBezDDV.ColumnName3 = null;
            this.txtCenaBezDDV.ColumnName4 = null;
            this.txtCenaBezDDV.ColumnName5 = null;
            this.txtCenaBezDDV.ColumnName6 = null;
            this.txtCenaBezDDV.ColumnName7 = null;
            this.txtCenaBezDDV.daliCetiri = false;
            this.txtCenaBezDDV.Format = null;
            this.txtCenaBezDDV.formToOpen = null;
            this.txtCenaBezDDV.iscistiGreenNaLeave = false;
            this.txtCenaBezDDV.KoristiFilterNaDatasource = false;
            this.txtCenaBezDDV.Location = new System.Drawing.Point(880, 132);
            this.txtCenaBezDDV.MakedonskiJazik = false;
            this.txtCenaBezDDV.MinLength = 0;
            this.txtCenaBezDDV.Multiline = true;
            this.txtCenaBezDDV.Name = "txtCenaBezDDV";
            this.txtCenaBezDDV.PopulateOtherFields = false;
            this.txtCenaBezDDV.regularExpression = null;
            this.txtCenaBezDDV.SelektrijaNaFokus = false;
            this.txtCenaBezDDV.Size = new System.Drawing.Size(140, 35);
            this.txtCenaBezDDV.TabIndex = 3;
            this.txtCenaBezDDV.TabStop = false;
            this.txtCenaBezDDV.Tag = "";
            this.txtCenaBezDDV.Text = "0,0";
            // 
            // txtSoDDV
            // 
            this.txtSoDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDDV.AssemblyStr = null;
            this.txtSoDDV.C_FillWithZeros = false;
            this.txtSoDDV.C_OnlyNumbers = true;
            this.txtSoDDV.C_RegEx = false;
            this.txtSoDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSoDDV.ColumnName1 = null;
            this.txtSoDDV.ColumnName2 = null;
            this.txtSoDDV.ColumnName3 = null;
            this.txtSoDDV.ColumnName4 = null;
            this.txtSoDDV.ColumnName5 = null;
            this.txtSoDDV.ColumnName6 = null;
            this.txtSoDDV.ColumnName7 = null;
            this.txtSoDDV.daliCetiri = false;
            this.txtSoDDV.Format = null;
            this.txtSoDDV.formToOpen = null;
            this.txtSoDDV.iscistiGreenNaLeave = false;
            this.txtSoDDV.KoristiFilterNaDatasource = false;
            this.txtSoDDV.Location = new System.Drawing.Point(880, 91);
            this.txtSoDDV.MakedonskiJazik = false;
            this.txtSoDDV.MinLength = 0;
            this.txtSoDDV.Multiline = true;
            this.txtSoDDV.Name = "txtSoDDV";
            this.txtSoDDV.PopulateOtherFields = false;
            this.txtSoDDV.regularExpression = null;
            this.txtSoDDV.SelektrijaNaFokus = false;
            this.txtSoDDV.Size = new System.Drawing.Size(140, 35);
            this.txtSoDDV.TabIndex = 2;
            this.txtSoDDV.TabStop = false;
            this.txtSoDDV.Tag = "";
            this.txtSoDDV.Text = "0,0";
            this.txtSoDDV.Leave += new System.EventHandler(this.txtSoDDV_Leave_1);
            // 
            // txtBase1
            // 
            this.txtBase1.AssemblyStr = null;
            this.txtBase1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBase1.C_FillWithZeros = false;
            this.txtBase1.C_OnlyNumbers = false;
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
            this.txtBase1.ForeColor = System.Drawing.Color.Blue;
            this.txtBase1.Format = null;
            this.txtBase1.formToOpen = null;
            this.txtBase1.iscistiGreenNaLeave = false;
            this.txtBase1.KoristiFilterNaDatasource = false;
            this.txtBase1.Location = new System.Drawing.Point(169, 167);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Multiline = true;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.ReadOnly = true;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(160, 35);
            this.txtBase1.TabIndex = 25;
            this.txtBase1.TabStop = false;
            // 
            // rabat1txtBase
            // 
            this.rabat1txtBase.AcceptsTab = true;
            this.rabat1txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat1txtBase.AssemblyStr = null;
            this.rabat1txtBase.C_Decimal = true;
            this.rabat1txtBase.C_FillWithZeros = false;
            this.rabat1txtBase.C_OnlyNumbers = true;
            this.rabat1txtBase.C_RegEx = false;
            this.rabat1txtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.rabat1txtBase.ColumnName1 = null;
            this.rabat1txtBase.ColumnName2 = null;
            this.rabat1txtBase.ColumnName3 = null;
            this.rabat1txtBase.ColumnName4 = null;
            this.rabat1txtBase.ColumnName5 = null;
            this.rabat1txtBase.ColumnName6 = null;
            this.rabat1txtBase.ColumnName7 = null;
            this.rabat1txtBase.daliCetiri = false;
            this.rabat1txtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFakturaStavkiBindingSource, "Rabat1", true));
            this.rabat1txtBase.Format = null;
            this.rabat1txtBase.formToOpen = null;
            this.rabat1txtBase.iscistiGreenNaLeave = false;
            this.rabat1txtBase.KoristiFilterNaDatasource = false;
            this.rabat1txtBase.Location = new System.Drawing.Point(544, 170);
            this.rabat1txtBase.MakedonskiJazik = false;
            this.rabat1txtBase.MinLength = 0;
            this.rabat1txtBase.Name = "rabat1txtBase";
            this.rabat1txtBase.PopulateOtherFields = false;
            this.rabat1txtBase.regularExpression = null;
            this.rabat1txtBase.SelektrijaNaFokus = false;
            this.rabat1txtBase.Size = new System.Drawing.Size(121, 32);
            this.rabat1txtBase.TabIndex = 3;
            this.rabat1txtBase.Text = "0,00";
            this.rabat1txtBase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rabat1txtBase_KeyDown);
            this.rabat1txtBase.Leave += new System.EventHandler(this.rabat1txtBase_Leave);
            // 
            // tblFakturaStavkiBindingSource
            // 
            this.tblFakturaStavkiBindingSource.DataMember = "tblFakturaStavki";
            this.tblFakturaStavkiBindingSource.DataSource = this.fakturiDataSet;
            // 
            // btnSearchArtikal
            // 
            this.btnSearchArtikal.Location = new System.Drawing.Point(372, 9);
            this.btnSearchArtikal.Name = "btnSearchArtikal";
            this.btnSearchArtikal.Size = new System.Drawing.Size(43, 35);
            this.btnSearchArtikal.TabIndex = 1;
            this.btnSearchArtikal.Text = "...";
            this.btnSearchArtikal.UseVisualStyleBackColor = true;
            this.btnSearchArtikal.Click += new System.EventHandler(this.btnSearchArtikal_Click);
            // 
            // txtArtikalSearch
            // 
            this.txtArtikalSearch.AssemblyStr = "BSSR";
            this.txtArtikalSearch.C_FillWithZeros = false;
            this.txtArtikalSearch.C_OnlyNumbers = false;
            this.txtArtikalSearch.C_RegEx = false;
            this.txtArtikalSearch.C_ShowRedOnLeaveIfEmpty = false;
            this.txtArtikalSearch.ColumnName1 = "ID";
            this.txtArtikalSearch.ColumnName2 = "Naziv";
            this.txtArtikalSearch.ColumnName3 = "SIFRA";
            this.txtArtikalSearch.ColumnName4 = "Normativ";
            this.txtArtikalSearch.ColumnName5 = null;
            this.txtArtikalSearch.ColumnName6 = null;
            this.txtArtikalSearch.ColumnName7 = null;
            this.txtArtikalSearch.daliCetiri = false;
            this.txtArtikalSearch.Format = null;
            this.txtArtikalSearch.formToOpen = "BSSR.Forms.frmPrebaruvanjeNaArtikliDev";
            this.txtArtikalSearch.iscistiGreenNaLeave = false;
            this.txtArtikalSearch.KoristiFilterNaDatasource = false;
            this.txtArtikalSearch.Location = new System.Drawing.Point(119, 9);
            this.txtArtikalSearch.MakedonskiJazik = false;
            this.txtArtikalSearch.MaxLength = 13;
            this.txtArtikalSearch.MinLength = 0;
            this.txtArtikalSearch.Name = "txtArtikalSearch";
            this.txtArtikalSearch.PopulateOtherFields = false;
            this.txtArtikalSearch.regularExpression = null;
            this.txtArtikalSearch.SelektrijaNaFokus = false;
            this.txtArtikalSearch.Size = new System.Drawing.Size(247, 32);
            this.txtArtikalSearch.TabIndex = 0;
            this.txtArtikalSearch.DataRead += new BssBase.txtBase.doneLoading(this.txtArtikalSearch_DataRead);
            this.txtArtikalSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArtikalSearch_KeyDown);
            this.txtArtikalSearch.Leave += new System.EventHandler(this.txtArtikalSearch_Leave);
            // 
            // txtcena
            // 
            this.txtcena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcena.AssemblyStr = null;
            this.txtcena.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtcena.C_FillWithZeros = false;
            this.txtcena.C_OnlyNumbers = false;
            this.txtcena.C_RegEx = false;
            this.txtcena.C_ShowRedOnLeaveIfEmpty = false;
            this.txtcena.ColumnName1 = null;
            this.txtcena.ColumnName2 = null;
            this.txtcena.ColumnName3 = null;
            this.txtcena.ColumnName4 = null;
            this.txtcena.ColumnName5 = null;
            this.txtcena.ColumnName6 = null;
            this.txtcena.ColumnName7 = null;
            this.txtcena.daliCetiri = false;
            this.txtcena.ForeColor = System.Drawing.Color.Blue;
            this.txtcena.Format = null;
            this.txtcena.formToOpen = null;
            this.txtcena.iscistiGreenNaLeave = false;
            this.txtcena.KoristiFilterNaDatasource = false;
            this.txtcena.Location = new System.Drawing.Point(880, 50);
            this.txtcena.MakedonskiJazik = false;
            this.txtcena.MinLength = 0;
            this.txtcena.Multiline = true;
            this.txtcena.Name = "txtcena";
            this.txtcena.PopulateOtherFields = false;
            this.txtcena.ReadOnly = true;
            this.txtcena.regularExpression = null;
            this.txtcena.SelektrijaNaFokus = false;
            this.txtcena.Size = new System.Drawing.Size(140, 35);
            this.txtcena.TabIndex = 2;
            this.txtcena.TabStop = false;
            // 
            // btnIzbrisiStavka
            // 
            this.btnIzbrisiStavka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzbrisiStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzbrisiStavka.Image = global::MFakturi.Properties.Resources.delete;
            this.btnIzbrisiStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzbrisiStavka.Location = new System.Drawing.Point(6, 208);
            this.btnIzbrisiStavka.Name = "btnIzbrisiStavka";
            this.btnIzbrisiStavka.Size = new System.Drawing.Size(226, 79);
            this.btnIzbrisiStavka.TabIndex = 5;
            this.btnIzbrisiStavka.Text = "Избриши ставка";
            this.btnIzbrisiStavka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzbrisiStavka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzbrisiStavka.UseVisualStyleBackColor = false;
            this.btnIzbrisiStavka.Click += new System.EventHandler(this.btnIzbrisiStavka_Click);
            // 
            // btnSocuvajStavka
            // 
            this.btnSocuvajStavka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSocuvajStavka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSocuvajStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocuvajStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSocuvajStavka.Image = global::MFakturi.Properties.Resources.add_1_icon__1_;
            this.btnSocuvajStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajStavka.Location = new System.Drawing.Point(796, 208);
            this.btnSocuvajStavka.Name = "btnSocuvajStavka";
            this.btnSocuvajStavka.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajStavka.TabIndex = 4;
            this.btnSocuvajStavka.Text = "Сочувај ставка";
            this.btnSocuvajStavka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocuvajStavka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSocuvajStavka.UseVisualStyleBackColor = false;
            this.btnSocuvajStavka.Click += new System.EventHandler(this.btnSocuvajStavka_Click);
            // 
            // txtDDV
            // 
            this.txtDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDDV.AssemblyStr = null;
            this.txtDDV.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDDV.C_FillWithZeros = false;
            this.txtDDV.C_OnlyNumbers = false;
            this.txtDDV.C_RegEx = false;
            this.txtDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtDDV.ColumnName1 = null;
            this.txtDDV.ColumnName2 = null;
            this.txtDDV.ColumnName3 = null;
            this.txtDDV.ColumnName4 = null;
            this.txtDDV.ColumnName5 = null;
            this.txtDDV.ColumnName6 = null;
            this.txtDDV.ColumnName7 = null;
            this.txtDDV.daliCetiri = false;
            this.txtDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDDV.ForeColor = System.Drawing.Color.Blue;
            this.txtDDV.Format = null;
            this.txtDDV.formToOpen = null;
            this.txtDDV.iscistiGreenNaLeave = false;
            this.txtDDV.KoristiFilterNaDatasource = false;
            this.txtDDV.Location = new System.Drawing.Point(942, 9);
            this.txtDDV.MakedonskiJazik = false;
            this.txtDDV.MinLength = 0;
            this.txtDDV.Multiline = true;
            this.txtDDV.Name = "txtDDV";
            this.txtDDV.PopulateOtherFields = false;
            this.txtDDV.ReadOnly = true;
            this.txtDDV.regularExpression = null;
            this.txtDDV.SelektrijaNaFokus = false;
            this.txtDDV.Size = new System.Drawing.Size(78, 35);
            this.txtDDV.TabIndex = 9;
            this.txtDDV.TabStop = false;
            // 
            // txtEDM
            // 
            this.txtEDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEDM.AssemblyStr = null;
            this.txtEDM.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEDM.C_FillWithZeros = false;
            this.txtEDM.C_OnlyNumbers = false;
            this.txtEDM.C_RegEx = false;
            this.txtEDM.C_ShowRedOnLeaveIfEmpty = false;
            this.txtEDM.ColumnName1 = null;
            this.txtEDM.ColumnName2 = null;
            this.txtEDM.ColumnName3 = null;
            this.txtEDM.ColumnName4 = null;
            this.txtEDM.ColumnName5 = null;
            this.txtEDM.ColumnName6 = null;
            this.txtEDM.ColumnName7 = null;
            this.txtEDM.daliCetiri = false;
            this.txtEDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEDM.ForeColor = System.Drawing.Color.Blue;
            this.txtEDM.Format = null;
            this.txtEDM.formToOpen = null;
            this.txtEDM.iscistiGreenNaLeave = false;
            this.txtEDM.KoristiFilterNaDatasource = false;
            this.txtEDM.Location = new System.Drawing.Point(860, 9);
            this.txtEDM.MakedonskiJazik = false;
            this.txtEDM.MinLength = 0;
            this.txtEDM.Multiline = true;
            this.txtEDM.Name = "txtEDM";
            this.txtEDM.PopulateOtherFields = false;
            this.txtEDM.ReadOnly = true;
            this.txtEDM.regularExpression = null;
            this.txtEDM.SelektrijaNaFokus = false;
            this.txtEDM.Size = new System.Drawing.Size(76, 35);
            this.txtEDM.TabIndex = 8;
            this.txtEDM.TabStop = false;
            // 
            // txtArtikalNaziv
            // 
            this.txtArtikalNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtikalNaziv.AssemblyStr = null;
            this.txtArtikalNaziv.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtArtikalNaziv.C_FillWithZeros = false;
            this.txtArtikalNaziv.C_OnlyNumbers = false;
            this.txtArtikalNaziv.C_RegEx = false;
            this.txtArtikalNaziv.C_ShowRedOnLeaveIfEmpty = false;
            this.txtArtikalNaziv.ColumnName1 = null;
            this.txtArtikalNaziv.ColumnName2 = null;
            this.txtArtikalNaziv.ColumnName3 = null;
            this.txtArtikalNaziv.ColumnName4 = null;
            this.txtArtikalNaziv.ColumnName5 = null;
            this.txtArtikalNaziv.ColumnName6 = null;
            this.txtArtikalNaziv.ColumnName7 = null;
            this.txtArtikalNaziv.daliCetiri = false;
            this.txtArtikalNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArtikalNaziv.ForeColor = System.Drawing.Color.Blue;
            this.txtArtikalNaziv.Format = null;
            this.txtArtikalNaziv.formToOpen = null;
            this.txtArtikalNaziv.iscistiGreenNaLeave = false;
            this.txtArtikalNaziv.KoristiFilterNaDatasource = false;
            this.txtArtikalNaziv.Location = new System.Drawing.Point(421, 9);
            this.txtArtikalNaziv.MakedonskiJazik = false;
            this.txtArtikalNaziv.MinLength = 0;
            this.txtArtikalNaziv.Multiline = true;
            this.txtArtikalNaziv.Name = "txtArtikalNaziv";
            this.txtArtikalNaziv.PopulateOtherFields = false;
            this.txtArtikalNaziv.ReadOnly = true;
            this.txtArtikalNaziv.regularExpression = null;
            this.txtArtikalNaziv.SelektrijaNaFokus = false;
            this.txtArtikalNaziv.Size = new System.Drawing.Size(433, 35);
            this.txtArtikalNaziv.TabIndex = 6;
            this.txtArtikalNaziv.TabStop = false;
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(7, 9);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(103, 26);
            this.bsslabel2.TabIndex = 5;
            this.bsslabel2.Text = "Артикал:";
            // 
            // iznostxtBase
            // 
            this.iznostxtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iznostxtBase.AssemblyStr = null;
            this.iznostxtBase.BackColor = System.Drawing.Color.LemonChiffon;
            this.iznostxtBase.C_FillWithZeros = false;
            this.iznostxtBase.C_OnlyNumbers = true;
            this.iznostxtBase.C_RegEx = false;
            this.iznostxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.iznostxtBase.ColumnName1 = null;
            this.iznostxtBase.ColumnName2 = null;
            this.iznostxtBase.ColumnName3 = null;
            this.iznostxtBase.ColumnName4 = null;
            this.iznostxtBase.ColumnName5 = null;
            this.iznostxtBase.ColumnName6 = null;
            this.iznostxtBase.ColumnName7 = null;
            this.iznostxtBase.daliCetiri = false;
            this.iznostxtBase.ForeColor = System.Drawing.Color.Blue;
            this.iznostxtBase.Format = null;
            this.iznostxtBase.formToOpen = null;
            this.iznostxtBase.iscistiGreenNaLeave = false;
            this.iznostxtBase.KoristiFilterNaDatasource = false;
            this.iznostxtBase.Location = new System.Drawing.Point(837, 170);
            this.iznostxtBase.MakedonskiJazik = false;
            this.iznostxtBase.MinLength = 0;
            this.iznostxtBase.Name = "iznostxtBase";
            this.iznostxtBase.PopulateOtherFields = false;
            this.iznostxtBase.ReadOnly = true;
            this.iznostxtBase.regularExpression = null;
            this.iznostxtBase.SelektrijaNaFokus = false;
            this.iznostxtBase.Size = new System.Drawing.Size(185, 32);
            this.iznostxtBase.TabIndex = 4;
            this.iznostxtBase.TabStop = false;
            // 
            // kolicinatxtBase
            // 
            this.kolicinatxtBase.AssemblyStr = null;
            this.kolicinatxtBase.C_FillWithZeros = false;
            this.kolicinatxtBase.C_OnlyNumbers = true;
            this.kolicinatxtBase.C_RegEx = false;
            this.kolicinatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.kolicinatxtBase.ColumnName1 = null;
            this.kolicinatxtBase.ColumnName2 = null;
            this.kolicinatxtBase.ColumnName3 = null;
            this.kolicinatxtBase.ColumnName4 = null;
            this.kolicinatxtBase.ColumnName5 = null;
            this.kolicinatxtBase.ColumnName6 = null;
            this.kolicinatxtBase.ColumnName7 = null;
            this.kolicinatxtBase.daliCetiri = false;
            this.kolicinatxtBase.Format = null;
            this.kolicinatxtBase.formToOpen = null;
            this.kolicinatxtBase.iscistiGreenNaLeave = false;
            this.kolicinatxtBase.KoristiFilterNaDatasource = false;
            this.kolicinatxtBase.Location = new System.Drawing.Point(124, 50);
            this.kolicinatxtBase.MakedonskiJazik = false;
            this.kolicinatxtBase.MinLength = 0;
            this.kolicinatxtBase.Name = "kolicinatxtBase";
            this.kolicinatxtBase.PopulateOtherFields = false;
            this.kolicinatxtBase.regularExpression = null;
            this.kolicinatxtBase.SelektrijaNaFokus = false;
            this.kolicinatxtBase.Size = new System.Drawing.Size(78, 32);
            this.kolicinatxtBase.TabIndex = 1;
            this.kolicinatxtBase.Leave += new System.EventHandler(this.kolicinatxtBase_Leave);
            // 
            // tblFakturaStavkiTableAdapter
            // 
            this.tblFakturaStavkiTableAdapter.ClearBeforeFill = true;
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
            // frmObrabotkaNaFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 612);
            this.Controls.Add(this.viewFakturiStavkiBindingNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(827, 319);
            this.Name = "frmObrabotkaNaFaktura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фактура ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmObrabotkaNaFaktura_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.viewFakturiStavkiBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiBindingNavigator)).EndInit();
            this.viewFakturiStavkiBindingNavigator.ResumeLayout(false);
            this.viewFakturiStavkiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFakturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFakturaStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource viewFakturiStavkiBindingSource;
		private FakturiDataSetTableAdapters.viewFakturiStavkiTableAdapter viewFakturiStavkiTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator viewFakturiStavkiBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton viewFakturiStavkiBindingNavigatorSaveItem;
		private  BssBase.DevGrid viewFakturiStavkiDevGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn coltblFakturaID;
		private DevExpress.XtraGrid.Columns.GridColumn colBroj;
		private DevExpress.XtraGrid.Columns.GridColumn coltblArtikalID;
		private DevExpress.XtraGrid.Columns.GridColumn colArtikal;
		private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
		private DevExpress.XtraGrid.Columns.GridColumn colDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colEDM;
		private DevExpress.XtraGrid.Columns.GridColumn colIznos;
		private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private System.Windows.Forms.BindingSource tblFakturaBindingSource;
		private FakturiDataSetTableAdapters.tblFakturaTableAdapter tblFakturaTableAdapter;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private BssBase.cmbBase tblZiroSmetkaIDcmbBase;
		private BssBase.txtBase txtPartner;
		private BssBase.Elements.Bsslabel bsslabel1;
		private System.Windows.Forms.DateTimePicker valutaDateTimePicker;
		private System.Windows.Forms.DateTimePicker datumDateTimePicker;
		private BssBase.txtBase brojTextBox;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private System.Windows.Forms.Button btnSocuvajZaglavje;
		private System.Windows.Forms.Button btnPecati;
		private System.Windows.Forms.BindingSource tblFakturaStavkiBindingSource;
		private FakturiDataSetTableAdapters.tblFakturaStavkiTableAdapter tblFakturaStavkiTableAdapter;
		private BssBase.txtBase iznostxtBase;
		private BssBase.txtBase kolicinatxtBase;
		private System.Windows.Forms.Button btnSocuvajStavka;
		private BssBase.txtBase txtDDV;
		private BssBase.txtBase txtEDM;
		private BssBase.txtBase txtArtikalNaziv;
		private BssBase.Elements.Bsslabel bsslabel2;
		private System.Windows.Forms.Button btnIzbrisiStavka;
		private BssBase.txtBase txtcena;
		private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos;
		private BssBase.zbxBase zbxPartner;
		private System.Windows.Forms.Button btnSearchArtikal;
		private BssBase.txtBase txtArtikalSearch;
		private System.Windows.Forms.BindingSource viewFakturiBindingSource;
		private FakturiDataSetTableAdapters.viewFakturiTableAdapter viewFakturiTableAdapter;
		private System.Windows.Forms.BindingSource tblPartneriBindingSource;
		private FakturiDataSetTableAdapters.tblPartneriTableAdapter tblPartneriTableAdapter;
		private System.Windows.Forms.BindingSource tblFirmaBindingSource;
		private FakturiDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
        private BssBase.txtBase txtBase1;
        private BssBase.txtBase rabat1txtBase;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat1;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat2;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat3;
        private System.Windows.Forms.Button butnProfaktura;
        private System.Windows.Forms.Button butnIspratnica;
        private BssBase.txtBase zabeleskaTextBox;
        private BssBase.txtBase listaNaIspratniciTextBox;
        private System.Windows.Forms.Label listaNaIspratniciLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colAltSifa;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCenaSoDDVIRabat;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaSoDDV;
        private BssBase.txtBase txtCenaBezDDV;
        private BssBase.txtBase txtSoDDV;
        private System.Windows.Forms.Button button1;
    }
}
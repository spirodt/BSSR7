namespace MMaterijalno.Forms {
	partial class frmObrabotkaNaPriem {
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
            System.Windows.Forms.Label valutaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label brojLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label rabat1Label;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.label1 = new System.Windows.Forms.Label();
            this.rabat2Label = new System.Windows.Forms.Label();
            this.rabat3Label = new System.Windows.Forms.Label();
            this.viewFakturiStavkiDevGrid = new BssBase.DevGrid();
            this.viewPriemStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriemBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVStapka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabavnaCenaBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabavnaCenaSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaVrednostSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPLT = new System.Windows.Forms.Button();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.cmbObjekt = new BssBase.cmbBase();
            this.txtKalkulacijaBroj = new BssBase.txtBase();
            this.tblPriemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFRIBroj = new BssBase.txtBase();
            this.txtValuta = new BssBase.txtBase();
            this.brojTextBox = new BssBase.txtBase();
            this.btnSocuvajZaglavje = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.txtPartner = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.zbxPartner = new BssBase.zbxBase();
            this.FalturaDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtKontrolnaSuma = new BssBase.txtBase();
            this.datumNaKreiranja = new System.Windows.Forms.DateTimePicker();
            this.txtZabeleska = new BssBase.txtBase();
            this.DatumNaDospeanost = new System.Windows.Forms.DateTimePicker();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtProdaznaCenaNaArtikal = new BssBase.txtBase();
            this.lblInfo = new BssBase.Elements.Bsslabel();
            this.txtCenaSoDDVVnes = new BssBase.txtBase();
            this.txtBase1 = new BssBase.txtBase();
            this.rabat3txtBase = new BssBase.txtBase();
            this.tblPriemStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabat2txtBase = new BssBase.txtBase();
            this.rabat1txtBase = new BssBase.txtBase();
            this.txtCenaSoDDV = new BssBase.txtBase();
            this.btnSearchArtikal = new System.Windows.Forms.Button();
            this.txtArtikalSearch = new BssBase.txtBase();
            this.txtcenaBezDDV = new BssBase.txtBase();
            this.btnIzbrisiStavka = new System.Windows.Forms.Button();
            this.btnSocuvajStavka = new System.Windows.Forms.Button();
            this.txtDDV = new BssBase.txtBase();
            this.txtEDM = new BssBase.txtBase();
            this.txtArtikalNaziv = new BssBase.txtBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.kolicinatxtBase = new BssBase.txtBase();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPriemTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblPriemTableAdapter();
            this.viewPriemStavkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewPriemStavkiTableAdapter();
            this.tblFirmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.viewPriemiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewPriemiTableAdapter();
            this.viewPriemiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPriemStavkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblPriemStavkiTableAdapter();
            this.txtSum = new BssBase.txtBase();
            this.pLTobrazecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLTobrazecTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.PLTobrazecTableAdapter();
            valutaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            brojLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            rabat1Label = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriemBindingSource)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriemStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLTobrazecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainTab.Size = new System.Drawing.Size(945, 544);
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Margin = new System.Windows.Forms.Padding(4);
            this.tabVnes.Size = new System.Drawing.Size(937, 518);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.xtraTabControl1);
            this.groupVnes.Controls.Add(this.viewFakturiStavkiDevGrid);
            this.groupVnes.Margin = new System.Windows.Forms.Padding(4);
            this.groupVnes.Padding = new System.Windows.Forms.Padding(4);
            this.groupVnes.Size = new System.Drawing.Size(934, 515);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.txtSum);
            this.PanelFooter.Location = new System.Drawing.Point(0, 543);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.PanelFooter.Size = new System.Drawing.Size(949, 69);
            this.PanelFooter.Controls.SetChildIndex(this.btnZatvori, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnOk, 0);
            this.PanelFooter.Controls.SetChildIndex(this.txtSum, 0);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 5);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.MinimumSize = new System.Drawing.Size(176, 47);
            this.btnZatvori.Size = new System.Drawing.Size(176, 47);
            this.btnZatvori.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(754, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.MinimumSize = new System.Drawing.Size(176, 47);
            this.btnOk.Size = new System.Drawing.Size(176, 47);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // valutaLabel
            // 
            valutaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            valutaLabel.AutoSize = true;
            valutaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valutaLabel.Location = new System.Drawing.Point(777, 66);
            valutaLabel.Name = "valutaLabel";
            valutaLabel.Size = new System.Drawing.Size(68, 20);
            valutaLabel.TabIndex = 16;
            valutaLabel.Text = "Валута:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            datumLabel.Location = new System.Drawing.Point(171, 17);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(134, 20);
            datumLabel.TabIndex = 14;
            datumLabel.Text = "Датум на прием:";
            // 
            // brojLabel
            // 
            brojLabel.AutoSize = true;
            brojLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            brojLabel.Location = new System.Drawing.Point(3, 17);
            brojLabel.Name = "brojLabel";
            brojLabel.Size = new System.Drawing.Size(45, 20);
            brojLabel.TabIndex = 12;
            brojLabel.Text = "Број:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            kolicinaLabel.Location = new System.Drawing.Point(6, 58);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(118, 26);
            kolicinaLabel.TabIndex = 0;
            kolicinaLabel.Text = "Количина:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(426, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 20);
            label2.TabIndex = 25;
            label2.Text = "Датум на документ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(480, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 20);
            label3.TabIndex = 27;
            label3.Text = "Ф-ра/И-ца број:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label4.Location = new System.Drawing.Point(4, 59);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 20);
            label4.TabIndex = 29;
            label4.Text = "Калкулација број:";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(589, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(157, 29);
            label6.TabIndex = 15;
            label6.Text = "Цена со ддв:";
            // 
            // rabat1Label
            // 
            rabat1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rabat1Label.AutoSize = true;
            rabat1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            rabat1Label.Location = new System.Drawing.Point(578, 58);
            rabat1Label.Name = "rabat1Label";
            rabat1Label.Size = new System.Drawing.Size(98, 26);
            rabat1Label.TabIndex = 15;
            rabat1Label.Text = "Рабат 1:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 142);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(182, 29);
            label7.TabIndex = 21;
            label7.Text = "Цена со рабат:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label8.Location = new System.Drawing.Point(13, 23);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(177, 20);
            label8.TabIndex = 16;
            label8.Text = "Датум на доспеаност:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label5.Location = new System.Drawing.Point(13, 67);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 20);
            label5.TabIndex = 33;
            label5.Text = "Забелешка:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label9.Location = new System.Drawing.Point(376, 23);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(163, 20);
            label9.TabIndex = 35;
            label9.Text = "Датум на креирање:";
            // 
            // label10
            // 
            label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label10.Location = new System.Drawing.Point(387, 183);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(306, 26);
            label10.TabIndex = 37;
            label10.Text = "Контролна сума на приемот:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(210, 55);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(157, 29);
            label11.TabIndex = 23;
            label11.Text = "Цена со ддв:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Цена без ддв:";
            // 
            // rabat2Label
            // 
            this.rabat2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat2Label.AutoSize = true;
            this.rabat2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rabat2Label.Location = new System.Drawing.Point(746, 58);
            this.rabat2Label.Name = "rabat2Label";
            this.rabat2Label.Size = new System.Drawing.Size(98, 26);
            this.rabat2Label.TabIndex = 16;
            this.rabat2Label.Text = "Рабат 2:";
            // 
            // rabat3Label
            // 
            this.rabat3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat3Label.AutoSize = true;
            this.rabat3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rabat3Label.Location = new System.Drawing.Point(746, 105);
            this.rabat3Label.Name = "rabat3Label";
            this.rabat3Label.Size = new System.Drawing.Size(98, 26);
            this.rabat3Label.TabIndex = 18;
            this.rabat3Label.Text = "Рабат 3:";
            // 
            // viewFakturiStavkiDevGrid
            // 
            this.viewFakturiStavkiDevGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFakturiStavkiDevGrid.AssemblyToLoad = null;
            this.viewFakturiStavkiDevGrid.DataSource = this.viewPriemStavkiBindingSource;
            this.viewFakturiStavkiDevGrid.EditForm = null;
            this.viewFakturiStavkiDevGrid.FilterForm = null;
            this.viewFakturiStavkiDevGrid.Location = new System.Drawing.Point(5, 325);
            this.viewFakturiStavkiDevGrid.MainView = this.gridView1;
            this.viewFakturiStavkiDevGrid.Name = "viewFakturiStavkiDevGrid";
            this.viewFakturiStavkiDevGrid.PrimaryKey = null;
            this.viewFakturiStavkiDevGrid.reportCenter = false;
            this.viewFakturiStavkiDevGrid.ReportName = null;
            this.viewFakturiStavkiDevGrid.Size = new System.Drawing.Size(923, 189);
            this.viewFakturiStavkiDevGrid.TabIndex = 1;
            this.viewFakturiStavkiDevGrid.TabStop = false;
            this.viewFakturiStavkiDevGrid.UpdateTable = null;
            this.viewFakturiStavkiDevGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewPriemStavkiBindingSource
            // 
            this.viewPriemStavkiBindingSource.DataMember = "viewPriemStavki";
            this.viewPriemStavkiBindingSource.DataSource = this.materijalnoDataSet;
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
            this.colPriemBroj,
            this.colArtikal,
            this.colKolicina,
            this.colEDM,
            this.colRabat1,
            this.colRabat2,
            this.colRabat3,
            this.colDDVStapka,
            this.colNabavnaCenaBezDDV,
            this.colNabavnaCenaSoDDV,
            this.colDDV,
            this.colIznosBezDDV,
            this.colIznosSoDDV,
            this.colProdaznaVrednostSoDDV,
            this.colAltSifra});
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{0}")});
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 68;
            // 
            // colPriemBroj
            // 
            this.colPriemBroj.Caption = "Прием број";
            this.colPriemBroj.FieldName = "PriemBroj";
            this.colPriemBroj.Name = "colPriemBroj";
            this.colPriemBroj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            // 
            // colArtikal
            // 
            this.colArtikal.Caption = "Артикал";
            this.colArtikal.FieldName = "Artikal";
            this.colArtikal.Name = "colArtikal";
            this.colArtikal.Visible = true;
            this.colArtikal.VisibleIndex = 2;
            this.colArtikal.Width = 407;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 3;
            this.colKolicina.Width = 71;
            // 
            // colEDM
            // 
            this.colEDM.Caption = "Единечна мерка";
            this.colEDM.FieldName = "EDM";
            this.colEDM.Name = "colEDM";
            this.colEDM.Visible = true;
            this.colEDM.VisibleIndex = 7;
            this.colEDM.Width = 50;
            // 
            // colRabat1
            // 
            this.colRabat1.Caption = "Рабат 1";
            this.colRabat1.FieldName = "Rabat1";
            this.colRabat1.Name = "colRabat1";
            this.colRabat1.Visible = true;
            this.colRabat1.VisibleIndex = 4;
            this.colRabat1.Width = 71;
            // 
            // colRabat2
            // 
            this.colRabat2.Caption = "Рабат 2";
            this.colRabat2.FieldName = "Rabat2";
            this.colRabat2.Name = "colRabat2";
            // 
            // colRabat3
            // 
            this.colRabat3.Caption = "Рабат 3";
            this.colRabat3.FieldName = "Rabat3";
            this.colRabat3.Name = "colRabat3";
            // 
            // colDDVStapka
            // 
            this.colDDVStapka.Caption = "ДДВ Стапка";
            this.colDDVStapka.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDDVStapka.FieldName = "DDVStapka";
            this.colDDVStapka.Name = "colDDVStapka";
            this.colDDVStapka.Visible = true;
            this.colDDVStapka.VisibleIndex = 8;
            this.colDDVStapka.Width = 67;
            // 
            // colNabavnaCenaBezDDV
            // 
            this.colNabavnaCenaBezDDV.Caption = "Набавна цена без ДДВ";
            this.colNabavnaCenaBezDDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNabavnaCenaBezDDV.FieldName = "NabavnaCenaBezDDV";
            this.colNabavnaCenaBezDDV.Name = "colNabavnaCenaBezDDV";
            this.colNabavnaCenaBezDDV.Visible = true;
            this.colNabavnaCenaBezDDV.VisibleIndex = 5;
            this.colNabavnaCenaBezDDV.Width = 71;
            // 
            // colNabavnaCenaSoDDV
            // 
            this.colNabavnaCenaSoDDV.Caption = "Набавна цена со ДДВ";
            this.colNabavnaCenaSoDDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNabavnaCenaSoDDV.FieldName = "NabavnaCenaSoDDV";
            this.colNabavnaCenaSoDDV.Name = "colNabavnaCenaSoDDV";
            this.colNabavnaCenaSoDDV.Visible = true;
            this.colNabavnaCenaSoDDV.VisibleIndex = 6;
            this.colNabavnaCenaSoDDV.Width = 71;
            // 
            // colDDV
            // 
            this.colDDV.Caption = "Пресметан ДДВ";
            this.colDDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDDV.FieldName = "DDV";
            this.colDDV.Name = "colDDV";
            this.colDDV.OptionsColumn.ReadOnly = true;
            this.colDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDDV.Visible = true;
            this.colDDV.VisibleIndex = 9;
            this.colDDV.Width = 93;
            // 
            // colIznosBezDDV
            // 
            this.colIznosBezDDV.Caption = "Износ без ДДВ";
            this.colIznosBezDDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.OptionsColumn.ReadOnly = true;
            this.colIznosBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIznosBezDDV.Visible = true;
            this.colIznosBezDDV.VisibleIndex = 10;
            this.colIznosBezDDV.Width = 60;
            // 
            // colIznosSoDDV
            // 
            this.colIznosSoDDV.Caption = "Износ со ДДВ";
            this.colIznosSoDDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIznosSoDDV.FieldName = "IznosSoDDV";
            this.colIznosSoDDV.Name = "colIznosSoDDV";
            this.colIznosSoDDV.OptionsColumn.ReadOnly = true;
            this.colIznosSoDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIznosSoDDV.Visible = true;
            this.colIznosSoDDV.VisibleIndex = 11;
            this.colIznosSoDDV.Width = 119;
            // 
            // colProdaznaVrednostSoDDV
            // 
            this.colProdaznaVrednostSoDDV.Caption = "Продажна вредност со ДДВ";
            this.colProdaznaVrednostSoDDV.FieldName = "ProdaznaVrednostSoDDV";
            this.colProdaznaVrednostSoDDV.Name = "colProdaznaVrednostSoDDV";
            // 
            // colAltSifra
            // 
            this.colAltSifra.Caption = "Алт.Шифра";
            this.colAltSifra.FieldName = "AltSifra";
            this.colAltSifra.Name = "colAltSifra";
            this.colAltSifra.Visible = true;
            this.colAltSifra.VisibleIndex = 1;
            this.colAltSifra.Width = 130;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 20);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(924, 299);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.btnPLT);
            this.xtraTabPage1.Controls.Add(this.bsslabel3);
            this.xtraTabPage1.Controls.Add(this.cmbObjekt);
            this.xtraTabPage1.Controls.Add(this.txtKalkulacijaBroj);
            this.xtraTabPage1.Controls.Add(label4);
            this.xtraTabPage1.Controls.Add(this.txtFRIBroj);
            this.xtraTabPage1.Controls.Add(label3);
            this.xtraTabPage1.Controls.Add(label2);
            this.xtraTabPage1.Controls.Add(this.txtValuta);
            this.xtraTabPage1.Controls.Add(datumLabel);
            this.xtraTabPage1.Controls.Add(this.brojTextBox);
            this.xtraTabPage1.Controls.Add(this.btnSocuvajZaglavje);
            this.xtraTabPage1.Controls.Add(this.btnPecati);
            this.xtraTabPage1.Controls.Add(this.txtPartner);
            this.xtraTabPage1.Controls.Add(this.bsslabel1);
            this.xtraTabPage1.Controls.Add(this.zbxPartner);
            this.xtraTabPage1.Controls.Add(valutaLabel);
            this.xtraTabPage1.Controls.Add(this.FalturaDatumDateTimePicker);
            this.xtraTabPage1.Controls.Add(this.datumDateTimePicker);
            this.xtraTabPage1.Controls.Add(brojLabel);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(918, 271);
            this.xtraTabPage1.Text = "Заглавје на приемот";
            // 
            // btnPLT
            // 
            this.btnPLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPLT.BackColor = System.Drawing.Color.LightCoral;
            this.btnPLT.Enabled = false;
            this.btnPLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPLT.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPLT.Location = new System.Drawing.Point(484, 189);
            this.btnPLT.Name = "btnPLT";
            this.btnPLT.Size = new System.Drawing.Size(140, 79);
            this.btnPLT.TabIndex = 32;
            this.btnPLT.Text = "ПЛТ";
            this.btnPLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPLT.UseVisualStyleBackColor = false;
            this.btnPLT.Click += new System.EventHandler(this.btnPLT_Click);
            // 
            // bsslabel3
            // 
            this.bsslabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Enabled = false;
            this.bsslabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel3.Location = new System.Drawing.Point(544, 112);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(59, 18);
            this.bsslabel3.TabIndex = 31;
            this.bsslabel3.Text = "Објект:";
            // 
            // cmbObjekt
            // 
            this.cmbObjekt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbObjekt.C_OnlyNumbers = false;
            this.cmbObjekt.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbObjekt.CurrentText = null;
            this.cmbObjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjekt.DtTableName = null;
            this.cmbObjekt.Enabled = false;
            this.cmbObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbObjekt.FormattingEnabled = true;
            this.cmbObjekt.Location = new System.Drawing.Point(609, 109);
            this.cmbObjekt.Name = "cmbObjekt";
            this.cmbObjekt.Size = new System.Drawing.Size(297, 26);
            this.cmbObjekt.TabIndex = 30;
            this.cmbObjekt.value = null;
            // 
            // txtKalkulacijaBroj
            // 
            this.txtKalkulacijaBroj.AssemblyStr = null;
            this.txtKalkulacijaBroj.C_FillWithZeros = false;
            this.txtKalkulacijaBroj.C_OnlyNumbers = true;
            this.txtKalkulacijaBroj.C_RegEx = false;
            this.txtKalkulacijaBroj.C_ShowRedOnLeaveIfEmpty = false;
            this.txtKalkulacijaBroj.ColumnName1 = null;
            this.txtKalkulacijaBroj.ColumnName2 = null;
            this.txtKalkulacijaBroj.ColumnName3 = null;
            this.txtKalkulacijaBroj.ColumnName4 = null;
            this.txtKalkulacijaBroj.ColumnName5 = null;
            this.txtKalkulacijaBroj.ColumnName6 = null;
            this.txtKalkulacijaBroj.ColumnName7 = null;
            this.txtKalkulacijaBroj.daliCetiri = false;
            this.txtKalkulacijaBroj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemBindingSource, "KalkulacijaBroj", true));
            this.txtKalkulacijaBroj.Format = null;
            this.txtKalkulacijaBroj.formToOpen = null;
            this.txtKalkulacijaBroj.iscistiGreenNaLeave = false;
            this.txtKalkulacijaBroj.KoristiFilterNaDatasource = false;
            this.txtKalkulacijaBroj.Location = new System.Drawing.Point(142, 54);
            this.txtKalkulacijaBroj.MakedonskiJazik = false;
            this.txtKalkulacijaBroj.MinLength = 0;
            this.txtKalkulacijaBroj.Name = "txtKalkulacijaBroj";
            this.txtKalkulacijaBroj.PopulateOtherFields = false;
            this.txtKalkulacijaBroj.regularExpression = null;
            this.txtKalkulacijaBroj.SelektrijaNaFokus = false;
            this.txtKalkulacijaBroj.Size = new System.Drawing.Size(278, 35);
            this.txtKalkulacijaBroj.TabIndex = 4;
            // 
            // tblPriemBindingSource
            // 
            this.tblPriemBindingSource.DataMember = "tblPriem";
            this.tblPriemBindingSource.DataSource = this.materijalnoDataSet;
            this.tblPriemBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.tblPriemBindingSource_ListChanged);
            // 
            // txtFRIBroj
            // 
            this.txtFRIBroj.AssemblyStr = null;
            this.txtFRIBroj.C_FillWithZeros = false;
            this.txtFRIBroj.C_OnlyNumbers = false;
            this.txtFRIBroj.C_RegEx = false;
            this.txtFRIBroj.C_ShowRedOnLeaveIfEmpty = false;
            this.txtFRIBroj.ColumnName1 = null;
            this.txtFRIBroj.ColumnName2 = null;
            this.txtFRIBroj.ColumnName3 = null;
            this.txtFRIBroj.ColumnName4 = null;
            this.txtFRIBroj.ColumnName5 = null;
            this.txtFRIBroj.ColumnName6 = null;
            this.txtFRIBroj.ColumnName7 = null;
            this.txtFRIBroj.daliCetiri = false;
            this.txtFRIBroj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemBindingSource, "IspratnicaFakturaBroj", true));
            this.txtFRIBroj.Format = null;
            this.txtFRIBroj.formToOpen = null;
            this.txtFRIBroj.iscistiGreenNaLeave = false;
            this.txtFRIBroj.KoristiFilterNaDatasource = false;
            this.txtFRIBroj.Location = new System.Drawing.Point(609, 9);
            this.txtFRIBroj.MakedonskiJazik = false;
            this.txtFRIBroj.MinLength = 0;
            this.txtFRIBroj.Name = "txtFRIBroj";
            this.txtFRIBroj.PopulateOtherFields = false;
            this.txtFRIBroj.regularExpression = null;
            this.txtFRIBroj.SelektrijaNaFokus = false;
            this.txtFRIBroj.Size = new System.Drawing.Size(297, 35);
            this.txtFRIBroj.TabIndex = 2;
            // 
            // txtValuta
            // 
            this.txtValuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValuta.AssemblyStr = null;
            this.txtValuta.C_FillWithZeros = false;
            this.txtValuta.C_OnlyNumbers = true;
            this.txtValuta.C_RegEx = false;
            this.txtValuta.C_ShowRedOnLeaveIfEmpty = false;
            this.txtValuta.ColumnName1 = null;
            this.txtValuta.ColumnName2 = null;
            this.txtValuta.ColumnName3 = null;
            this.txtValuta.ColumnName4 = null;
            this.txtValuta.ColumnName5 = null;
            this.txtValuta.ColumnName6 = null;
            this.txtValuta.ColumnName7 = null;
            this.txtValuta.daliCetiri = false;
            this.txtValuta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemBindingSource, "ValutaDenovi", true));
            this.txtValuta.Format = null;
            this.txtValuta.formToOpen = null;
            this.txtValuta.iscistiGreenNaLeave = false;
            this.txtValuta.KoristiFilterNaDatasource = false;
            this.txtValuta.Location = new System.Drawing.Point(851, 58);
            this.txtValuta.MakedonskiJazik = false;
            this.txtValuta.MinLength = 0;
            this.txtValuta.Name = "txtValuta";
            this.txtValuta.PopulateOtherFields = false;
            this.txtValuta.regularExpression = null;
            this.txtValuta.SelektrijaNaFokus = false;
            this.txtValuta.Size = new System.Drawing.Size(55, 35);
            this.txtValuta.TabIndex = 3;
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
            this.brojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemBindingSource, "PriemBroj", true));
            this.brojTextBox.Format = null;
            this.brojTextBox.formToOpen = null;
            this.brojTextBox.iscistiGreenNaLeave = false;
            this.brojTextBox.KoristiFilterNaDatasource = false;
            this.brojTextBox.Location = new System.Drawing.Point(45, 10);
            this.brojTextBox.MakedonskiJazik = false;
            this.brojTextBox.MinLength = 0;
            this.brojTextBox.Name = "brojTextBox";
            this.brojTextBox.PopulateOtherFields = false;
            this.brojTextBox.regularExpression = null;
            this.brojTextBox.SelektrijaNaFokus = false;
            this.brojTextBox.Size = new System.Drawing.Size(124, 35);
            this.brojTextBox.TabIndex = 0;
            // 
            // btnSocuvajZaglavje
            // 
            this.btnSocuvajZaglavje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSocuvajZaglavje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocuvajZaglavje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSocuvajZaglavje.Image = global::MMaterijalno.Properties.Resources.accept;
            this.btnSocuvajZaglavje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajZaglavje.Location = new System.Drawing.Point(8, 189);
            this.btnSocuvajZaglavje.Name = "btnSocuvajZaglavje";
            this.btnSocuvajZaglavje.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajZaglavje.TabIndex = 8;
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
            this.btnPecati.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPecati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati.Location = new System.Drawing.Point(631, 189);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(275, 79);
            this.btnPecati.TabIndex = 23;
            this.btnPecati.Text = "Печати и прокнижи";
            this.btnPecati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // txtPartner
            // 
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
            this.txtPartner.Location = new System.Drawing.Point(8, 147);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(898, 38);
            this.txtPartner.TabIndex = 19;
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bsslabel1.Location = new System.Drawing.Point(3, 109);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(79, 20);
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
            this.zbxPartner.ColumnName4 = "";
            this.zbxPartner.ColumnName5 = null;
            this.zbxPartner.ColumnName6 = null;
            this.zbxPartner.ColumnName7 = null;
            this.zbxPartner.filterDataSource = "Tip = 1 OR Tip = -1";
            this.zbxPartner.formToOpen = "MFakturi.Forms.frmPartner";
            this.zbxPartner.GridFromForm = null;
            this.zbxPartner.KoristiFilterNaDatasource = true;
            this.zbxPartner.Location = new System.Drawing.Point(89, 92);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(449, 55);
            this.zbxPartner.TabIndex = 6;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validated += new System.EventHandler(this.zbxPartner_Validated);
            // 
            // FalturaDatumDateTimePicker
            // 
            this.FalturaDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPriemBindingSource, "IspratnicaFakturaDatum", true));
            this.FalturaDatumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FalturaDatumDateTimePicker.Location = new System.Drawing.Point(595, 57);
            this.FalturaDatumDateTimePicker.Name = "FalturaDatumDateTimePicker";
            this.FalturaDatumDateTimePicker.Size = new System.Drawing.Size(158, 35);
            this.FalturaDatumDateTimePicker.TabIndex = 5;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPriemBindingSource, "PriemDatum", true));
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(308, 10);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(158, 35);
            this.datumDateTimePicker.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(label10);
            this.xtraTabPage3.Controls.Add(this.txtKontrolnaSuma);
            this.xtraTabPage3.Controls.Add(label9);
            this.xtraTabPage3.Controls.Add(this.datumNaKreiranja);
            this.xtraTabPage3.Controls.Add(this.txtZabeleska);
            this.xtraTabPage3.Controls.Add(label5);
            this.xtraTabPage3.Controls.Add(label8);
            this.xtraTabPage3.Controls.Add(this.DatumNaDospeanost);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(918, 271);
            this.xtraTabPage3.Text = "Дополнителни податоци";
            // 
            // txtKontrolnaSuma
            // 
            this.txtKontrolnaSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKontrolnaSuma.AssemblyStr = null;
            this.txtKontrolnaSuma.C_Decimal = true;
            this.txtKontrolnaSuma.C_FillWithZeros = false;
            this.txtKontrolnaSuma.C_OnlyNumbers = true;
            this.txtKontrolnaSuma.C_RegEx = false;
            this.txtKontrolnaSuma.C_ShowRedOnLeaveIfEmpty = false;
            this.txtKontrolnaSuma.ColumnName1 = null;
            this.txtKontrolnaSuma.ColumnName2 = null;
            this.txtKontrolnaSuma.ColumnName3 = null;
            this.txtKontrolnaSuma.ColumnName4 = null;
            this.txtKontrolnaSuma.ColumnName5 = null;
            this.txtKontrolnaSuma.ColumnName6 = null;
            this.txtKontrolnaSuma.ColumnName7 = null;
            this.txtKontrolnaSuma.daliCetiri = false;
            this.txtKontrolnaSuma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemBindingSource, "VkupenIznos", true));
            this.txtKontrolnaSuma.Format = null;
            this.txtKontrolnaSuma.formToOpen = null;
            this.txtKontrolnaSuma.iscistiGreenNaLeave = false;
            this.txtKontrolnaSuma.KoristiFilterNaDatasource = false;
            this.txtKontrolnaSuma.Location = new System.Drawing.Point(699, 177);
            this.txtKontrolnaSuma.MakedonskiJazik = false;
            this.txtKontrolnaSuma.MinLength = 0;
            this.txtKontrolnaSuma.Name = "txtKontrolnaSuma";
            this.txtKontrolnaSuma.PopulateOtherFields = false;
            this.txtKontrolnaSuma.regularExpression = null;
            this.txtKontrolnaSuma.SelektrijaNaFokus = false;
            this.txtKontrolnaSuma.Size = new System.Drawing.Size(203, 35);
            this.txtKontrolnaSuma.TabIndex = 36;
            this.txtKontrolnaSuma.Text = "0,00";
            // 
            // datumNaKreiranja
            // 
            this.datumNaKreiranja.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPriemBindingSource, "PriemDatum", true));
            this.datumNaKreiranja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumNaKreiranja.Location = new System.Drawing.Point(547, 14);
            this.datumNaKreiranja.Name = "datumNaKreiranja";
            this.datumNaKreiranja.Size = new System.Drawing.Size(158, 35);
            this.datumNaKreiranja.TabIndex = 34;
            // 
            // txtZabeleska
            // 
            this.txtZabeleska.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZabeleska.AssemblyStr = null;
            this.txtZabeleska.C_FillWithZeros = false;
            this.txtZabeleska.C_OnlyNumbers = false;
            this.txtZabeleska.C_RegEx = false;
            this.txtZabeleska.C_ShowRedOnLeaveIfEmpty = false;
            this.txtZabeleska.ColumnName1 = null;
            this.txtZabeleska.ColumnName2 = null;
            this.txtZabeleska.ColumnName3 = null;
            this.txtZabeleska.ColumnName4 = null;
            this.txtZabeleska.ColumnName5 = null;
            this.txtZabeleska.ColumnName6 = null;
            this.txtZabeleska.ColumnName7 = null;
            this.txtZabeleska.daliCetiri = false;
            this.txtZabeleska.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemBindingSource, "Zabeleska", true));
            this.txtZabeleska.Format = null;
            this.txtZabeleska.formToOpen = null;
            this.txtZabeleska.iscistiGreenNaLeave = false;
            this.txtZabeleska.KoristiFilterNaDatasource = false;
            this.txtZabeleska.Location = new System.Drawing.Point(119, 67);
            this.txtZabeleska.MakedonskiJazik = false;
            this.txtZabeleska.MinLength = 0;
            this.txtZabeleska.Multiline = true;
            this.txtZabeleska.Name = "txtZabeleska";
            this.txtZabeleska.PopulateOtherFields = false;
            this.txtZabeleska.regularExpression = null;
            this.txtZabeleska.SelektrijaNaFokus = false;
            this.txtZabeleska.Size = new System.Drawing.Size(783, 104);
            this.txtZabeleska.TabIndex = 32;
            // 
            // DatumNaDospeanost
            // 
            this.DatumNaDospeanost.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPriemBindingSource, "PriemDatum", true));
            this.DatumNaDospeanost.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumNaDospeanost.Location = new System.Drawing.Point(196, 14);
            this.DatumNaDospeanost.Name = "DatumNaDospeanost";
            this.DatumNaDospeanost.Size = new System.Drawing.Size(158, 35);
            this.DatumNaDospeanost.TabIndex = 15;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.txtProdaznaCenaNaArtikal);
            this.xtraTabPage2.Controls.Add(this.lblInfo);
            this.xtraTabPage2.Controls.Add(label11);
            this.xtraTabPage2.Controls.Add(this.txtCenaSoDDVVnes);
            this.xtraTabPage2.Controls.Add(label7);
            this.xtraTabPage2.Controls.Add(this.txtBase1);
            this.xtraTabPage2.Controls.Add(this.rabat3Label);
            this.xtraTabPage2.Controls.Add(this.rabat3txtBase);
            this.xtraTabPage2.Controls.Add(this.rabat2Label);
            this.xtraTabPage2.Controls.Add(this.rabat2txtBase);
            this.xtraTabPage2.Controls.Add(rabat1Label);
            this.xtraTabPage2.Controls.Add(this.rabat1txtBase);
            this.xtraTabPage2.Controls.Add(label6);
            this.xtraTabPage2.Controls.Add(this.txtCenaSoDDV);
            this.xtraTabPage2.Controls.Add(this.btnSearchArtikal);
            this.xtraTabPage2.Controls.Add(this.txtArtikalSearch);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.txtcenaBezDDV);
            this.xtraTabPage2.Controls.Add(this.btnIzbrisiStavka);
            this.xtraTabPage2.Controls.Add(this.btnSocuvajStavka);
            this.xtraTabPage2.Controls.Add(this.txtDDV);
            this.xtraTabPage2.Controls.Add(this.txtEDM);
            this.xtraTabPage2.Controls.Add(this.txtArtikalNaziv);
            this.xtraTabPage2.Controls.Add(this.bsslabel2);
            this.xtraTabPage2.Controls.Add(kolicinaLabel);
            this.xtraTabPage2.Controls.Add(this.kolicinatxtBase);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(918, 271);
            this.xtraTabPage2.Text = "Внес на ставки";
            // 
            // txtProdaznaCenaNaArtikal
            // 
            this.txtProdaznaCenaNaArtikal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdaznaCenaNaArtikal.AssemblyStr = null;
            this.txtProdaznaCenaNaArtikal.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtProdaznaCenaNaArtikal.C_FillWithZeros = false;
            this.txtProdaznaCenaNaArtikal.C_OnlyNumbers = false;
            this.txtProdaznaCenaNaArtikal.C_RegEx = false;
            this.txtProdaznaCenaNaArtikal.C_ShowRedOnLeaveIfEmpty = false;
            this.txtProdaznaCenaNaArtikal.ColumnName1 = null;
            this.txtProdaznaCenaNaArtikal.ColumnName2 = null;
            this.txtProdaznaCenaNaArtikal.ColumnName3 = null;
            this.txtProdaznaCenaNaArtikal.ColumnName4 = null;
            this.txtProdaznaCenaNaArtikal.ColumnName5 = null;
            this.txtProdaznaCenaNaArtikal.ColumnName6 = null;
            this.txtProdaznaCenaNaArtikal.ColumnName7 = null;
            this.txtProdaznaCenaNaArtikal.daliCetiri = false;
            this.txtProdaznaCenaNaArtikal.ForeColor = System.Drawing.Color.Blue;
            this.txtProdaznaCenaNaArtikal.Format = null;
            this.txtProdaznaCenaNaArtikal.formToOpen = null;
            this.txtProdaznaCenaNaArtikal.iscistiGreenNaLeave = false;
            this.txtProdaznaCenaNaArtikal.KoristiFilterNaDatasource = false;
            this.txtProdaznaCenaNaArtikal.Location = new System.Drawing.Point(805, 9);
            this.txtProdaznaCenaNaArtikal.MakedonskiJazik = false;
            this.txtProdaznaCenaNaArtikal.MinLength = 0;
            this.txtProdaznaCenaNaArtikal.Multiline = true;
            this.txtProdaznaCenaNaArtikal.Name = "txtProdaznaCenaNaArtikal";
            this.txtProdaznaCenaNaArtikal.PopulateOtherFields = false;
            this.txtProdaznaCenaNaArtikal.ReadOnly = true;
            this.txtProdaznaCenaNaArtikal.regularExpression = null;
            this.txtProdaznaCenaNaArtikal.SelektrijaNaFokus = false;
            this.txtProdaznaCenaNaArtikal.Size = new System.Drawing.Size(107, 35);
            this.txtProdaznaCenaNaArtikal.TabIndex = 25;
            this.txtProdaznaCenaNaArtikal.TabStop = false;
            this.txtProdaznaCenaNaArtikal.TextChanged += new System.EventHandler(this.txtProdaznaCenaNaArtikal_TextChanged);
            this.txtProdaznaCenaNaArtikal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtProdaznaCenaNaArtikal_MouseDoubleClick);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(238, 182);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(75, 17);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Артикал:";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // txtCenaSoDDVVnes
            // 
            this.txtCenaSoDDVVnes.AssemblyStr = null;
            this.txtCenaSoDDVVnes.C_FillWithZeros = false;
            this.txtCenaSoDDVVnes.C_OnlyNumbers = false;
            this.txtCenaSoDDVVnes.C_RegEx = false;
            this.txtCenaSoDDVVnes.C_ShowRedOnLeaveIfEmpty = false;
            this.txtCenaSoDDVVnes.ColumnName1 = null;
            this.txtCenaSoDDVVnes.ColumnName2 = null;
            this.txtCenaSoDDVVnes.ColumnName3 = null;
            this.txtCenaSoDDVVnes.ColumnName4 = null;
            this.txtCenaSoDDVVnes.ColumnName5 = null;
            this.txtCenaSoDDVVnes.ColumnName6 = null;
            this.txtCenaSoDDVVnes.ColumnName7 = null;
            this.txtCenaSoDDVVnes.daliCetiri = false;
            this.txtCenaSoDDVVnes.Format = null;
            this.txtCenaSoDDVVnes.formToOpen = null;
            this.txtCenaSoDDVVnes.iscistiGreenNaLeave = false;
            this.txtCenaSoDDVVnes.KoristiFilterNaDatasource = false;
            this.txtCenaSoDDVVnes.Location = new System.Drawing.Point(373, 53);
            this.txtCenaSoDDVVnes.MakedonskiJazik = false;
            this.txtCenaSoDDVVnes.MinLength = 0;
            this.txtCenaSoDDVVnes.Multiline = true;
            this.txtCenaSoDDVVnes.Name = "txtCenaSoDDVVnes";
            this.txtCenaSoDDVVnes.PopulateOtherFields = false;
            this.txtCenaSoDDVVnes.regularExpression = null;
            this.txtCenaSoDDVVnes.SelektrijaNaFokus = false;
            this.txtCenaSoDDVVnes.Size = new System.Drawing.Size(192, 35);
            this.txtCenaSoDDVVnes.TabIndex = 5;
            this.txtCenaSoDDVVnes.TabStop = false;
            this.txtCenaSoDDVVnes.Leave += new System.EventHandler(this.txtCenaSoDDVVnes_Leave);
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
            this.txtBase1.Location = new System.Drawing.Point(195, 139);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Multiline = true;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.ReadOnly = true;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(160, 35);
            this.txtBase1.TabIndex = 10;
            this.txtBase1.TabStop = false;
            // 
            // rabat3txtBase
            // 
            this.rabat3txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat3txtBase.AssemblyStr = null;
            this.rabat3txtBase.C_Decimal = true;
            this.rabat3txtBase.C_FillWithZeros = false;
            this.rabat3txtBase.C_OnlyNumbers = true;
            this.rabat3txtBase.C_RegEx = false;
            this.rabat3txtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.rabat3txtBase.ColumnName1 = null;
            this.rabat3txtBase.ColumnName2 = null;
            this.rabat3txtBase.ColumnName3 = null;
            this.rabat3txtBase.ColumnName4 = null;
            this.rabat3txtBase.ColumnName5 = null;
            this.rabat3txtBase.ColumnName6 = null;
            this.rabat3txtBase.ColumnName7 = null;
            this.rabat3txtBase.daliCetiri = false;
            this.rabat3txtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemStavkiBindingSource, "Rabat3", true));
            this.rabat3txtBase.Format = null;
            this.rabat3txtBase.formToOpen = null;
            this.rabat3txtBase.iscistiGreenNaLeave = false;
            this.rabat3txtBase.KoristiFilterNaDatasource = false;
            this.rabat3txtBase.Location = new System.Drawing.Point(848, 100);
            this.rabat3txtBase.MakedonskiJazik = false;
            this.rabat3txtBase.MinLength = 0;
            this.rabat3txtBase.Name = "rabat3txtBase";
            this.rabat3txtBase.PopulateOtherFields = false;
            this.rabat3txtBase.regularExpression = null;
            this.rabat3txtBase.SelektrijaNaFokus = false;
            this.rabat3txtBase.Size = new System.Drawing.Size(64, 35);
            this.rabat3txtBase.TabIndex = 9;
            this.rabat3txtBase.Text = "0,00";
            this.rabat3txtBase.Leave += new System.EventHandler(this.rabat3txtBase_Leave);
            // 
            // tblPriemStavkiBindingSource
            // 
            this.tblPriemStavkiBindingSource.DataMember = "tblPriemStavki";
            this.tblPriemStavkiBindingSource.DataSource = this.materijalnoDataSet;
            this.tblPriemStavkiBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.tblPriemStavkiBindingSource_ListChanged);
            // 
            // rabat2txtBase
            // 
            this.rabat2txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat2txtBase.AssemblyStr = null;
            this.rabat2txtBase.C_Decimal = true;
            this.rabat2txtBase.C_FillWithZeros = false;
            this.rabat2txtBase.C_OnlyNumbers = true;
            this.rabat2txtBase.C_RegEx = false;
            this.rabat2txtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.rabat2txtBase.ColumnName1 = null;
            this.rabat2txtBase.ColumnName2 = null;
            this.rabat2txtBase.ColumnName3 = null;
            this.rabat2txtBase.ColumnName4 = null;
            this.rabat2txtBase.ColumnName5 = null;
            this.rabat2txtBase.ColumnName6 = null;
            this.rabat2txtBase.ColumnName7 = null;
            this.rabat2txtBase.daliCetiri = false;
            this.rabat2txtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemStavkiBindingSource, "Rabat2", true));
            this.rabat2txtBase.Format = null;
            this.rabat2txtBase.formToOpen = null;
            this.rabat2txtBase.iscistiGreenNaLeave = false;
            this.rabat2txtBase.KoristiFilterNaDatasource = false;
            this.rabat2txtBase.Location = new System.Drawing.Point(848, 53);
            this.rabat2txtBase.MakedonskiJazik = false;
            this.rabat2txtBase.MinLength = 0;
            this.rabat2txtBase.Name = "rabat2txtBase";
            this.rabat2txtBase.PopulateOtherFields = false;
            this.rabat2txtBase.regularExpression = null;
            this.rabat2txtBase.SelektrijaNaFokus = false;
            this.rabat2txtBase.Size = new System.Drawing.Size(64, 35);
            this.rabat2txtBase.TabIndex = 8;
            this.rabat2txtBase.Text = "0,00";
            this.rabat2txtBase.Leave += new System.EventHandler(this.rabat2txtBase_Leave);
            // 
            // rabat1txtBase
            // 
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
            this.rabat1txtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPriemStavkiBindingSource, "Rabat1", true));
            this.rabat1txtBase.Format = null;
            this.rabat1txtBase.formToOpen = null;
            this.rabat1txtBase.iscistiGreenNaLeave = false;
            this.rabat1txtBase.KoristiFilterNaDatasource = false;
            this.rabat1txtBase.Location = new System.Drawing.Point(680, 53);
            this.rabat1txtBase.MakedonskiJazik = false;
            this.rabat1txtBase.MinLength = 0;
            this.rabat1txtBase.Name = "rabat1txtBase";
            this.rabat1txtBase.PopulateOtherFields = false;
            this.rabat1txtBase.regularExpression = null;
            this.rabat1txtBase.SelektrijaNaFokus = false;
            this.rabat1txtBase.Size = new System.Drawing.Size(60, 35);
            this.rabat1txtBase.TabIndex = 7;
            this.rabat1txtBase.Text = "0,00";
            this.rabat1txtBase.Leave += new System.EventHandler(this.rabat1txtBase_Leave);
            // 
            // txtCenaSoDDV
            // 
            this.txtCenaSoDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCenaSoDDV.AssemblyStr = null;
            this.txtCenaSoDDV.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCenaSoDDV.C_FillWithZeros = false;
            this.txtCenaSoDDV.C_OnlyNumbers = false;
            this.txtCenaSoDDV.C_RegEx = false;
            this.txtCenaSoDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtCenaSoDDV.ColumnName1 = null;
            this.txtCenaSoDDV.ColumnName2 = null;
            this.txtCenaSoDDV.ColumnName3 = null;
            this.txtCenaSoDDV.ColumnName4 = null;
            this.txtCenaSoDDV.ColumnName5 = null;
            this.txtCenaSoDDV.ColumnName6 = null;
            this.txtCenaSoDDV.ColumnName7 = null;
            this.txtCenaSoDDV.daliCetiri = false;
            this.txtCenaSoDDV.ForeColor = System.Drawing.Color.Blue;
            this.txtCenaSoDDV.Format = null;
            this.txtCenaSoDDV.formToOpen = null;
            this.txtCenaSoDDV.iscistiGreenNaLeave = false;
            this.txtCenaSoDDV.KoristiFilterNaDatasource = false;
            this.txtCenaSoDDV.Location = new System.Drawing.Point(752, 142);
            this.txtCenaSoDDV.MakedonskiJazik = false;
            this.txtCenaSoDDV.MinLength = 0;
            this.txtCenaSoDDV.Multiline = true;
            this.txtCenaSoDDV.Name = "txtCenaSoDDV";
            this.txtCenaSoDDV.PopulateOtherFields = false;
            this.txtCenaSoDDV.ReadOnly = true;
            this.txtCenaSoDDV.regularExpression = null;
            this.txtCenaSoDDV.SelektrijaNaFokus = false;
            this.txtCenaSoDDV.Size = new System.Drawing.Size(160, 35);
            this.txtCenaSoDDV.TabIndex = 11;
            this.txtCenaSoDDV.TabStop = false;
            // 
            // btnSearchArtikal
            // 
            this.btnSearchArtikal.Location = new System.Drawing.Point(361, 9);
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
            this.txtArtikalSearch.ColumnName5 = "ProdaznaCena";
            this.txtArtikalSearch.ColumnName6 = null;
            this.txtArtikalSearch.ColumnName7 = null;
            this.txtArtikalSearch.daliCetiri = false;
            this.txtArtikalSearch.Format = null;
            this.txtArtikalSearch.formToOpen = "BSSR.Forms.frmPrebaruvanjeNaArtikliDev";
            this.txtArtikalSearch.iscistiGreenNaLeave = false;
            this.txtArtikalSearch.KoristiFilterNaDatasource = false;
            this.txtArtikalSearch.Location = new System.Drawing.Point(124, 9);
            this.txtArtikalSearch.MakedonskiJazik = false;
            this.txtArtikalSearch.MaxLength = 25;
            this.txtArtikalSearch.MinLength = 0;
            this.txtArtikalSearch.Name = "txtArtikalSearch";
            this.txtArtikalSearch.PopulateOtherFields = false;
            this.txtArtikalSearch.regularExpression = null;
            this.txtArtikalSearch.SelektrijaNaFokus = false;
            this.txtArtikalSearch.Size = new System.Drawing.Size(231, 35);
            this.txtArtikalSearch.TabIndex = 0;
            this.txtArtikalSearch.DataRead += new BssBase.txtBase.doneLoading(this.txtArtikalSearch_DataRead);
            this.txtArtikalSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArtikalSearch_KeyDown);
            this.txtArtikalSearch.Leave += new System.EventHandler(this.txtArtikalSearch_Leave);
            // 
            // txtcenaBezDDV
            // 
            this.txtcenaBezDDV.AssemblyStr = null;
            this.txtcenaBezDDV.C_FillWithZeros = false;
            this.txtcenaBezDDV.C_OnlyNumbers = false;
            this.txtcenaBezDDV.C_RegEx = false;
            this.txtcenaBezDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtcenaBezDDV.ColumnName1 = null;
            this.txtcenaBezDDV.ColumnName2 = null;
            this.txtcenaBezDDV.ColumnName3 = null;
            this.txtcenaBezDDV.ColumnName4 = null;
            this.txtcenaBezDDV.ColumnName5 = null;
            this.txtcenaBezDDV.ColumnName6 = null;
            this.txtcenaBezDDV.ColumnName7 = null;
            this.txtcenaBezDDV.daliCetiri = false;
            this.txtcenaBezDDV.Format = null;
            this.txtcenaBezDDV.formToOpen = null;
            this.txtcenaBezDDV.iscistiGreenNaLeave = false;
            this.txtcenaBezDDV.KoristiFilterNaDatasource = false;
            this.txtcenaBezDDV.Location = new System.Drawing.Point(373, 100);
            this.txtcenaBezDDV.MakedonskiJazik = false;
            this.txtcenaBezDDV.MinLength = 0;
            this.txtcenaBezDDV.Multiline = true;
            this.txtcenaBezDDV.Name = "txtcenaBezDDV";
            this.txtcenaBezDDV.PopulateOtherFields = false;
            this.txtcenaBezDDV.regularExpression = null;
            this.txtcenaBezDDV.SelektrijaNaFokus = false;
            this.txtcenaBezDDV.Size = new System.Drawing.Size(192, 35);
            this.txtcenaBezDDV.TabIndex = 6;
            this.txtcenaBezDDV.TabStop = false;
            this.txtcenaBezDDV.Leave += new System.EventHandler(this.txtcenaBezDDV_Leave);
            // 
            // btnIzbrisiStavka
            // 
            this.btnIzbrisiStavka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzbrisiStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzbrisiStavka.Image = global::MMaterijalno.Properties.Resources.delete;
            this.btnIzbrisiStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzbrisiStavka.Location = new System.Drawing.Point(6, 183);
            this.btnIzbrisiStavka.Name = "btnIzbrisiStavka";
            this.btnIzbrisiStavka.Size = new System.Drawing.Size(226, 79);
            this.btnIzbrisiStavka.TabIndex = 11;
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
            this.btnSocuvajStavka.Image = global::MMaterijalno.Properties.Resources.add_1_icon__1_;
            this.btnSocuvajStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajStavka.Location = new System.Drawing.Point(689, 183);
            this.btnSocuvajStavka.Name = "btnSocuvajStavka";
            this.btnSocuvajStavka.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajStavka.TabIndex = 7;
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
            this.txtDDV.ForeColor = System.Drawing.Color.Blue;
            this.txtDDV.Format = null;
            this.txtDDV.formToOpen = null;
            this.txtDDV.iscistiGreenNaLeave = false;
            this.txtDDV.KoristiFilterNaDatasource = false;
            this.txtDDV.Location = new System.Drawing.Point(705, 9);
            this.txtDDV.MakedonskiJazik = false;
            this.txtDDV.MinLength = 0;
            this.txtDDV.Multiline = true;
            this.txtDDV.Name = "txtDDV";
            this.txtDDV.PopulateOtherFields = false;
            this.txtDDV.ReadOnly = true;
            this.txtDDV.regularExpression = null;
            this.txtDDV.SelektrijaNaFokus = false;
            this.txtDDV.Size = new System.Drawing.Size(94, 35);
            this.txtDDV.TabIndex = 3;
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
            this.txtEDM.ForeColor = System.Drawing.Color.Blue;
            this.txtEDM.Format = null;
            this.txtEDM.formToOpen = null;
            this.txtEDM.iscistiGreenNaLeave = false;
            this.txtEDM.KoristiFilterNaDatasource = false;
            this.txtEDM.Location = new System.Drawing.Point(611, 9);
            this.txtEDM.MakedonskiJazik = false;
            this.txtEDM.MinLength = 0;
            this.txtEDM.Multiline = true;
            this.txtEDM.Name = "txtEDM";
            this.txtEDM.PopulateOtherFields = false;
            this.txtEDM.ReadOnly = true;
            this.txtEDM.regularExpression = null;
            this.txtEDM.SelektrijaNaFokus = false;
            this.txtEDM.Size = new System.Drawing.Size(88, 35);
            this.txtEDM.TabIndex = 2;
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
            this.txtArtikalNaziv.ForeColor = System.Drawing.Color.Blue;
            this.txtArtikalNaziv.Format = null;
            this.txtArtikalNaziv.formToOpen = null;
            this.txtArtikalNaziv.iscistiGreenNaLeave = false;
            this.txtArtikalNaziv.KoristiFilterNaDatasource = false;
            this.txtArtikalNaziv.Location = new System.Drawing.Point(406, 9);
            this.txtArtikalNaziv.MakedonskiJazik = false;
            this.txtArtikalNaziv.MinLength = 0;
            this.txtArtikalNaziv.Multiline = true;
            this.txtArtikalNaziv.Name = "txtArtikalNaziv";
            this.txtArtikalNaziv.PopulateOtherFields = false;
            this.txtArtikalNaziv.ReadOnly = true;
            this.txtArtikalNaziv.regularExpression = null;
            this.txtArtikalNaziv.SelektrijaNaFokus = false;
            this.txtArtikalNaziv.Size = new System.Drawing.Size(199, 35);
            this.txtArtikalNaziv.TabIndex = 1;
            this.txtArtikalNaziv.TabStop = false;
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(7, 9);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(115, 29);
            this.bsslabel2.TabIndex = 5;
            this.bsslabel2.Text = "Артикал:";
            // 
            // kolicinatxtBase
            // 
            this.kolicinatxtBase.AssemblyStr = null;
            this.kolicinatxtBase.C_Decimal = true;
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
            this.kolicinatxtBase.Location = new System.Drawing.Point(124, 53);
            this.kolicinatxtBase.MakedonskiJazik = false;
            this.kolicinatxtBase.MinLength = 0;
            this.kolicinatxtBase.Name = "kolicinatxtBase";
            this.kolicinatxtBase.PopulateOtherFields = false;
            this.kolicinatxtBase.regularExpression = null;
            this.kolicinatxtBase.SelektrijaNaFokus = false;
            this.kolicinatxtBase.Size = new System.Drawing.Size(65, 35);
            this.kolicinatxtBase.TabIndex = 4;
            this.kolicinatxtBase.Text = "0,00";
            this.kolicinatxtBase.Leave += new System.EventHandler(this.kolicinatxtBase_Leave);
            // 
            // tblPartneriBindingSource
            // 
            this.tblPartneriBindingSource.DataMember = "tblPartneri";
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            // 
            // tblPriemTableAdapter
            // 
            this.tblPriemTableAdapter.ClearBeforeFill = true;
            // 
            // viewPriemStavkiTableAdapter
            // 
            this.viewPriemStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tblFirmaBindingSource1
            // 
            this.tblFirmaBindingSource1.DataMember = "tblFirma";
            this.tblFirmaBindingSource1.DataSource = this.materijalnoDataSet;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = this.tblFirmaTableAdapter;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPlacanjaOdPartnerTableAdapter = null;
            this.tableAdapterManager.tblPriemStavkiTableAdapter = null;
            this.tableAdapterManager.tblPriemTableAdapter = this.tblPriemTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewDokumentiStavkiTableAdapter = null;
            this.tableAdapterManager.viewDokumentiTableAdapter = null;
            this.tableAdapterManager.viewIzvodiTableAdapter = null;
            this.tableAdapterManager.viewPriemiTableAdapter = this.viewPriemiTableAdapter;
            this.tableAdapterManager.viewPriemStavkiTableAdapter = this.viewPriemStavkiTableAdapter;
            this.tableAdapterManager.vPriemiKnizenjeTableAdapter = null;
            this.tableAdapterManager.vSmetkaKnizenjeTableAdapter = null;
            // 
            // viewPriemiTableAdapter
            // 
            this.viewPriemiTableAdapter.ClearBeforeFill = true;
            // 
            // viewPriemiBindingSource
            // 
            this.viewPriemiBindingSource.DataMember = "viewPriemi";
            this.viewPriemiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblPriemStavkiTableAdapter
            // 
            this.tblPriemStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.AssemblyStr = null;
            this.txtSum.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSum.C_FillWithZeros = false;
            this.txtSum.C_OnlyNumbers = false;
            this.txtSum.C_RegEx = false;
            this.txtSum.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSum.ColumnName1 = null;
            this.txtSum.ColumnName2 = null;
            this.txtSum.ColumnName3 = null;
            this.txtSum.ColumnName4 = null;
            this.txtSum.ColumnName5 = null;
            this.txtSum.ColumnName6 = null;
            this.txtSum.ColumnName7 = null;
            this.txtSum.daliCetiri = false;
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSum.ForeColor = System.Drawing.Color.Blue;
            this.txtSum.Format = null;
            this.txtSum.formToOpen = null;
            this.txtSum.iscistiGreenNaLeave = false;
            this.txtSum.KoristiFilterNaDatasource = false;
            this.txtSum.Location = new System.Drawing.Point(442, 6);
            this.txtSum.MakedonskiJazik = false;
            this.txtSum.MinLength = 0;
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.PopulateOtherFields = false;
            this.txtSum.ReadOnly = true;
            this.txtSum.regularExpression = null;
            this.txtSum.SelektrijaNaFokus = false;
            this.txtSum.Size = new System.Drawing.Size(295, 50);
            this.txtSum.TabIndex = 6;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pLTobrazecBindingSource
            // 
            this.pLTobrazecBindingSource.DataMember = "PLTobrazec";
            this.pLTobrazecBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // pLTobrazecTableAdapter
            // 
            this.pLTobrazecTableAdapter.ClearBeforeFill = true;
            // 
            // frmObrabotkaNaPriem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 612);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(827, 318);
            this.Name = "frmObrabotkaNaPriem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прием";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmObrabotkaNaFaktura_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.PanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriemBindingSource)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriemStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPriemiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLTobrazecBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		
		private  BssBase.DevGrid viewFakturiStavkiDevGrid;
		
		
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private BssBase.txtBase txtPartner;
		private BssBase.Elements.Bsslabel bsslabel1;
		private System.Windows.Forms.DateTimePicker FalturaDatumDateTimePicker;
		private System.Windows.Forms.DateTimePicker datumDateTimePicker;
		private BssBase.txtBase brojTextBox;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private System.Windows.Forms.Button btnSocuvajZaglavje;
		private System.Windows.Forms.Button btnPecati;
		private BssBase.txtBase kolicinatxtBase;
		private System.Windows.Forms.Button btnSocuvajStavka;
		private BssBase.txtBase txtDDV;
		private BssBase.txtBase txtEDM;
		private BssBase.txtBase txtArtikalNaziv;
		private BssBase.Elements.Bsslabel bsslabel2;
		private System.Windows.Forms.Button btnIzbrisiStavka;
		private BssBase.txtBase txtcenaBezDDV;
		
		private BssBase.zbxBase zbxPartner;
		private System.Windows.Forms.Button btnSearchArtikal;
		private BssBase.txtBase txtArtikalSearch;
		
		private System.Windows.Forms.BindingSource tblPartneriBindingSource;
		
		private System.Windows.Forms.BindingSource tblFirmaBindingSource;
		
		private MaterijalnoDataSet materijalnoDataSet;
		private System.Windows.Forms.BindingSource tblPriemBindingSource;
		private MaterijalnoDataSetTableAdapters.tblPriemTableAdapter tblPriemTableAdapter;
		private MaterijalnoDataSetTableAdapters.viewPriemStavkiTableAdapter viewPriemStavkiTableAdapter;
		private System.Windows.Forms.BindingSource viewPriemStavkiBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private BssBase.txtBase txtFRIBroj;
		private BssBase.txtBase txtValuta;
        private BssBase.txtBase txtKalkulacijaBroj;
		private BssBase.txtBase txtCenaSoDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPriemBroj;
		private DevExpress.XtraGrid.Columns.GridColumn colArtikal;
		private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
		private DevExpress.XtraGrid.Columns.GridColumn colEDM;
		private DevExpress.XtraGrid.Columns.GridColumn colDDVStapka;
		private DevExpress.XtraGrid.Columns.GridColumn colNabavnaCenaBezDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colNabavnaCenaSoDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
		private DevExpress.XtraGrid.Columns.GridColumn colIznosSoDDV;
		private System.Windows.Forms.BindingSource tblFirmaBindingSource1;
		private MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
		private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private MaterijalnoDataSetTableAdapters.viewPriemiTableAdapter viewPriemiTableAdapter;
		private System.Windows.Forms.BindingSource viewPriemiBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat1;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat2;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat3;
        private System.Windows.Forms.BindingSource tblPriemStavkiBindingSource;
        private MaterijalnoDataSetTableAdapters.tblPriemStavkiTableAdapter tblPriemStavkiTableAdapter;
        private BssBase.txtBase rabat3txtBase;
        private BssBase.txtBase rabat2txtBase;
        private BssBase.txtBase rabat1txtBase;
        private BssBase.txtBase txtBase1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.DateTimePicker DatumNaDospeanost;
        private BssBase.txtBase txtKontrolnaSuma;
        private System.Windows.Forms.DateTimePicker datumNaKreiranja;
        private BssBase.txtBase txtZabeleska;
        private BssBase.txtBase txtSum;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.cmbBase cmbObjekt;
        private BssBase.txtBase txtCenaSoDDVVnes;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaVrednostSoDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colAltSifra;
        private System.Windows.Forms.Button btnPLT;
        private System.Windows.Forms.BindingSource pLTobrazecBindingSource;
        private MaterijalnoDataSetTableAdapters.PLTobrazecTableAdapter pLTobrazecTableAdapter;
        private System.Windows.Forms.Label rabat3Label;
        private System.Windows.Forms.Label rabat2Label;
        private System.Windows.Forms.Label label1;
        private BssBase.Elements.Bsslabel lblInfo;
        private BssBase.txtBase txtProdaznaCenaNaArtikal;
    }
}
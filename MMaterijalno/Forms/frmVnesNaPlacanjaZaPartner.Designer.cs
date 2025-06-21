namespace MMaterijalno.Forms
{
    partial class frmVnesNaPlacanjaZaPartner
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
            System.Windows.Forms.Label datumNaUplataLabel;
            System.Windows.Forms.Label dokumentBrojLabel;
            System.Windows.Forms.Label izvodBrojLabel;
            System.Windows.Forms.Label zabeleskaLabel;
            System.Windows.Forms.Label iznosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVnesNaPlacanjaZaPartner));
            this.viewFakturiStavkiDevGrid = new BssBase.DevGrid();
            this.tblPlacanjaOdPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblPartnerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaUplata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDokumentBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIzvodBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZabeleska = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblPlacanjaOdPartnerTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblPlacanjaOdPartnerTableAdapter();
            this.txtPartner = new BssBase.txtBase();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.zbxPartner = new BssBase.zbxBase();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.btnPecati2 = new BssBase.Elements.btnPecati();
            this.btnPonisti1 = new BssBase.Elements.btnPonisti();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.iznosTextBox = new BssBase.txtBase();
            this.zabeleskaTextBox = new BssBase.txtBase();
            this.izvodBrojTextBox = new BssBase.txtBase();
            this.dokumentBrojTextBox = new BssBase.txtBase();
            this.datumNaUplataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.devGrid1 = new BssBase.DevGrid();
            this.pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDolzi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlatil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.PobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter();
            datumNaUplataLabel = new System.Windows.Forms.Label();
            dokumentBrojLabel = new System.Windows.Forms.Label();
            izvodBrojLabel = new System.Windows.Forms.Label();
            zabeleskaLabel = new System.Windows.Forms.Label();
            iznosLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlacanjaOdPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Size = new System.Drawing.Size(938, 614);
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            this.MainTab.Controls.SetChildIndex(this.tabPage1, 0);
            this.MainTab.Controls.SetChildIndex(this.tabVnes, 0);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(930, 588);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.txtPartner);
            this.groupVnes.Controls.Add(this.bsslabel5);
            this.groupVnes.Controls.Add(this.zbxPartner);
            this.groupVnes.Controls.Add(this.viewFakturiStavkiDevGrid);
            this.groupVnes.Controls.Add(this.groupBoxBase1);
            this.groupVnes.Size = new System.Drawing.Size(927, 585);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 613);
            this.PanelFooter.Size = new System.Drawing.Size(942, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 2);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(743, 4);
            // 
            // datumNaUplataLabel
            // 
            datumNaUplataLabel.AutoSize = true;
            datumNaUplataLabel.Location = new System.Drawing.Point(7, 28);
            datumNaUplataLabel.Name = "datumNaUplataLabel";
            datumNaUplataLabel.Size = new System.Drawing.Size(89, 29);
            datumNaUplataLabel.TabIndex = 0;
            datumNaUplataLabel.Text = "Датум:";
            // 
            // dokumentBrojLabel
            // 
            dokumentBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dokumentBrojLabel.AutoSize = true;
            dokumentBrojLabel.Location = new System.Drawing.Point(483, 69);
            dokumentBrojLabel.Name = "dokumentBrojLabel";
            dokumentBrojLabel.Size = new System.Drawing.Size(185, 29);
            dokumentBrojLabel.TabIndex = 2;
            dokumentBrojLabel.Text = "Документ број:";
            // 
            // izvodBrojLabel
            // 
            izvodBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            izvodBrojLabel.AutoSize = true;
            izvodBrojLabel.Location = new System.Drawing.Point(523, 27);
            izvodBrojLabel.Name = "izvodBrojLabel";
            izvodBrojLabel.Size = new System.Drawing.Size(145, 29);
            izvodBrojLabel.TabIndex = 4;
            izvodBrojLabel.Text = "Извод број:";
            // 
            // zabeleskaLabel
            // 
            zabeleskaLabel.AutoSize = true;
            zabeleskaLabel.Location = new System.Drawing.Point(16, 148);
            zabeleskaLabel.Name = "zabeleskaLabel";
            zabeleskaLabel.Size = new System.Drawing.Size(149, 29);
            zabeleskaLabel.TabIndex = 6;
            zabeleskaLabel.Text = "Забелешка:";
            // 
            // iznosLabel
            // 
            iznosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iznosLabel.AutoSize = true;
            iznosLabel.Location = new System.Drawing.Point(577, 107);
            iznosLabel.Name = "iznosLabel";
            iznosLabel.Size = new System.Drawing.Size(91, 29);
            iznosLabel.TabIndex = 8;
            iznosLabel.Text = "Износ:";
            // 
            // viewFakturiStavkiDevGrid
            // 
            this.viewFakturiStavkiDevGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFakturiStavkiDevGrid.AssemblyToLoad = null;
            this.viewFakturiStavkiDevGrid.DataSource = this.tblPlacanjaOdPartnerBindingSource;
            this.viewFakturiStavkiDevGrid.EditForm = null;
            this.viewFakturiStavkiDevGrid.FilterForm = null;
            this.viewFakturiStavkiDevGrid.Location = new System.Drawing.Point(1, 332);
            this.viewFakturiStavkiDevGrid.MainView = this.gridView1;
            this.viewFakturiStavkiDevGrid.Name = "viewFakturiStavkiDevGrid";
            this.viewFakturiStavkiDevGrid.PrimaryKey = null;
            this.viewFakturiStavkiDevGrid.reportCenter = false;
            this.viewFakturiStavkiDevGrid.ReportName = null;
            this.viewFakturiStavkiDevGrid.Size = new System.Drawing.Size(920, 247);
            this.viewFakturiStavkiDevGrid.TabIndex = 1;
            this.viewFakturiStavkiDevGrid.TabStop = false;
            this.viewFakturiStavkiDevGrid.UpdateTable = null;
            this.viewFakturiStavkiDevGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblPlacanjaOdPartnerBindingSource
            // 
            this.tblPlacanjaOdPartnerBindingSource.DataMember = "tblPlacanjaOdPartner";
            this.tblPlacanjaOdPartnerBindingSource.DataSource = this.materijalnoDataSetBindingSource;
            // 
            // materijalnoDataSetBindingSource
            // 
            this.materijalnoDataSetBindingSource.DataSource = this.materijalnoDataSet;
            this.materijalnoDataSetBindingSource.Position = 0;
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
            this.coltblPartnerID,
            this.colIznos,
            this.colDatumNaUplata,
            this.colDokumentBroj,
            this.colIzvodBroj,
            this.colZabeleska});
            this.gridView1.GridControl = this.viewFakturiStavkiDevGrid;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
              // 
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // coltblPartnerID
            // 
            this.coltblPartnerID.Caption = "Реден број на партнер";
            this.coltblPartnerID.FieldName = "tblPartnerID";
            this.coltblPartnerID.Name = "coltblPartnerID";
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "{0:0.##}")});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 4;
            this.colIznos.Width = 410;
            // 
            // colDatumNaUplata
            // 
            this.colDatumNaUplata.Caption = "Датум ";
            this.colDatumNaUplata.FieldName = "DatumNaUplata";
            this.colDatumNaUplata.Name = "colDatumNaUplata";
            this.colDatumNaUplata.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DatumNaUplata", "{0}")});
            this.colDatumNaUplata.Visible = true;
            this.colDatumNaUplata.VisibleIndex = 0;
            this.colDatumNaUplata.Width = 132;
            // 
            // colDokumentBroj
            // 
            this.colDokumentBroj.Caption = "Документ број";
            this.colDokumentBroj.FieldName = "DokumentBroj";
            this.colDokumentBroj.Name = "colDokumentBroj";
            this.colDokumentBroj.Visible = true;
            this.colDokumentBroj.VisibleIndex = 1;
            this.colDokumentBroj.Width = 148;
            // 
            // colIzvodBroj
            // 
            this.colIzvodBroj.Caption = "Извод број";
            this.colIzvodBroj.FieldName = "IzvodBroj";
            this.colIzvodBroj.Name = "colIzvodBroj";
            this.colIzvodBroj.Visible = true;
            this.colIzvodBroj.VisibleIndex = 2;
            this.colIzvodBroj.Width = 190;
            // 
            // colZabeleska
            // 
            this.colZabeleska.Caption = "Забелешка";
            this.colZabeleska.FieldName = "Zabeleska";
            this.colZabeleska.Name = "colZabeleska";
            this.colZabeleska.Visible = true;
            this.colZabeleska.VisibleIndex = 3;
            this.colZabeleska.Width = 398;
            // 
            // tblPlacanjaOdPartnerTableAdapter
            // 
            this.tblPlacanjaOdPartnerTableAdapter.ClearBeforeFill = true;
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
            this.txtPartner.Location = new System.Drawing.Point(332, 37);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(589, 39);
            this.txtPartner.TabIndex = 26;
            // 
            // bsslabel5
            // 
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Location = new System.Drawing.Point(0, 40);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(118, 29);
            this.bsslabel5.TabIndex = 25;
            this.bsslabel5.Text = "Партнер:";
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
            this.zbxPartner.filterDataSource = null;
            this.zbxPartner.formToOpen = "MFakturi.Forms.frmPartner";
            this.zbxPartner.GridFromForm = null;
            this.zbxPartner.KoristiFilterNaDatasource = false;
            this.zbxPartner.Location = new System.Drawing.Point(124, 21);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(198, 55);
            this.zbxPartner.TabIndex = 0;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validated += new System.EventHandler(this.zbxPartner_Validated);
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase1.Controls.Add(this.btnPecati2);
            this.groupBoxBase1.Controls.Add(this.btnPonisti1);
            this.groupBoxBase1.Controls.Add(this.btnPotvrdi1);
            this.groupBoxBase1.Controls.Add(this.groupBox1);
            this.groupBoxBase1.Controls.Add(iznosLabel);
            this.groupBoxBase1.Controls.Add(this.iznosTextBox);
            this.groupBoxBase1.Controls.Add(zabeleskaLabel);
            this.groupBoxBase1.Controls.Add(this.zabeleskaTextBox);
            this.groupBoxBase1.Controls.Add(izvodBrojLabel);
            this.groupBoxBase1.Controls.Add(this.izvodBrojTextBox);
            this.groupBoxBase1.Controls.Add(dokumentBrojLabel);
            this.groupBoxBase1.Controls.Add(this.dokumentBrojTextBox);
            this.groupBoxBase1.Controls.Add(datumNaUplataLabel);
            this.groupBoxBase1.Controls.Add(this.datumNaUplataDateTimePicker);
            this.groupBoxBase1.Location = new System.Drawing.Point(7, 81);
            this.groupBoxBase1.MinimumSize = new System.Drawing.Size(914, 240);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(914, 240);
            this.groupBoxBase1.TabIndex = 27;
            this.groupBoxBase1.TabStop = false;
            // 
            // btnPecati2
            // 
            this.btnPecati2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecati2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPecati2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPecati2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPecati2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecati2.Image = ((System.Drawing.Image)(resources.GetObject("btnPecati2.Image")));
            this.btnPecati2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati2.Location = new System.Drawing.Point(249, 194);
            this.btnPecati2.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati2.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati2.Name = "btnPecati2";
            this.btnPecati2.Size = new System.Drawing.Size(132, 38);
            this.btnPecati2.TabIndex = 7;
            this.btnPecati2.Text = "Печати";
            this.btnPecati2.UseVisualStyleBackColor = false;
            this.btnPecati2.Click += new System.EventHandler(this.btnPecati2_Click);
            // 
            // btnPonisti1
            // 
            this.btnPonisti1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPonisti1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPonisti1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPonisti1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPonisti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonisti1.Image = ((System.Drawing.Image)(resources.GetObject("btnPonisti1.Image")));
            this.btnPonisti1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonisti1.Location = new System.Drawing.Point(9, 194);
            this.btnPonisti1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPonisti1.Name = "btnPonisti1";
            this.btnPonisti1.Size = new System.Drawing.Size(234, 38);
            this.btnPonisti1.TabIndex = 8;
            this.btnPonisti1.Text = "Избриши";
            this.btnPonisti1.UseVisualStyleBackColor = false;
            this.btnPonisti1.Click += new System.EventHandler(this.btnPonisti1_Click);
            // 
            // btnPotvrdi1
            // 
            this.btnPotvrdi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi1.Image = global::MMaterijalno.Properties.Resources.edit;
            this.btnPotvrdi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi1.Location = new System.Drawing.Point(677, 194);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(234, 38);
            this.btnPotvrdi1.TabIndex = 6;
            this.btnPotvrdi1.Text = "Внеси";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 33);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Исплата";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Наплата";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iznosTextBox.AssemblyStr = null;
            this.iznosTextBox.C_Decimal = true;
            this.iznosTextBox.C_FillWithZeros = false;
            this.iznosTextBox.C_OnlyNumbers = true;
            this.iznosTextBox.C_RegEx = false;
            this.iznosTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.iznosTextBox.ColumnName1 = null;
            this.iznosTextBox.ColumnName2 = null;
            this.iznosTextBox.ColumnName3 = null;
            this.iznosTextBox.ColumnName4 = null;
            this.iznosTextBox.ColumnName5 = null;
            this.iznosTextBox.ColumnName6 = null;
            this.iznosTextBox.ColumnName7 = null;
            this.iznosTextBox.daliCetiri = false;
            this.iznosTextBox.Format = null;
            this.iznosTextBox.formToOpen = null;
            this.iznosTextBox.iscistiGreenNaLeave = false;
            this.iznosTextBox.KoristiFilterNaDatasource = false;
            this.iznosTextBox.Location = new System.Drawing.Point(674, 101);
            this.iznosTextBox.MakedonskiJazik = false;
            this.iznosTextBox.MinLength = 0;
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.PopulateOtherFields = false;
            this.iznosTextBox.regularExpression = null;
            this.iznosTextBox.SelektrijaNaFokus = false;
            this.iznosTextBox.Size = new System.Drawing.Size(234, 35);
            this.iznosTextBox.TabIndex = 3;
            this.iznosTextBox.Text = "0,00";
            this.iznosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.zabeleskaTextBox.Format = null;
            this.zabeleskaTextBox.formToOpen = null;
            this.zabeleskaTextBox.iscistiGreenNaLeave = false;
            this.zabeleskaTextBox.KoristiFilterNaDatasource = false;
            this.zabeleskaTextBox.Location = new System.Drawing.Point(171, 145);
            this.zabeleskaTextBox.MakedonskiJazik = false;
            this.zabeleskaTextBox.MinLength = 0;
            this.zabeleskaTextBox.Multiline = true;
            this.zabeleskaTextBox.Name = "zabeleskaTextBox";
            this.zabeleskaTextBox.PopulateOtherFields = false;
            this.zabeleskaTextBox.regularExpression = null;
            this.zabeleskaTextBox.SelektrijaNaFokus = false;
            this.zabeleskaTextBox.Size = new System.Drawing.Size(737, 43);
            this.zabeleskaTextBox.TabIndex = 5;
            // 
            // izvodBrojTextBox
            // 
            this.izvodBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.izvodBrojTextBox.AssemblyStr = null;
            this.izvodBrojTextBox.C_FillWithZeros = false;
            this.izvodBrojTextBox.C_OnlyNumbers = false;
            this.izvodBrojTextBox.C_RegEx = false;
            this.izvodBrojTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.izvodBrojTextBox.ColumnName1 = null;
            this.izvodBrojTextBox.ColumnName2 = null;
            this.izvodBrojTextBox.ColumnName3 = null;
            this.izvodBrojTextBox.ColumnName4 = null;
            this.izvodBrojTextBox.ColumnName5 = null;
            this.izvodBrojTextBox.ColumnName6 = null;
            this.izvodBrojTextBox.ColumnName7 = null;
            this.izvodBrojTextBox.daliCetiri = false;
            this.izvodBrojTextBox.Format = null;
            this.izvodBrojTextBox.formToOpen = null;
            this.izvodBrojTextBox.iscistiGreenNaLeave = false;
            this.izvodBrojTextBox.KoristiFilterNaDatasource = false;
            this.izvodBrojTextBox.Location = new System.Drawing.Point(674, 22);
            this.izvodBrojTextBox.MakedonskiJazik = false;
            this.izvodBrojTextBox.MinLength = 0;
            this.izvodBrojTextBox.Name = "izvodBrojTextBox";
            this.izvodBrojTextBox.PopulateOtherFields = false;
            this.izvodBrojTextBox.regularExpression = null;
            this.izvodBrojTextBox.SelektrijaNaFokus = false;
            this.izvodBrojTextBox.Size = new System.Drawing.Size(234, 35);
            this.izvodBrojTextBox.TabIndex = 1;
            // 
            // dokumentBrojTextBox
            // 
            this.dokumentBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dokumentBrojTextBox.AssemblyStr = null;
            this.dokumentBrojTextBox.C_FillWithZeros = false;
            this.dokumentBrojTextBox.C_OnlyNumbers = false;
            this.dokumentBrojTextBox.C_RegEx = false;
            this.dokumentBrojTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.dokumentBrojTextBox.ColumnName1 = null;
            this.dokumentBrojTextBox.ColumnName2 = null;
            this.dokumentBrojTextBox.ColumnName3 = null;
            this.dokumentBrojTextBox.ColumnName4 = null;
            this.dokumentBrojTextBox.ColumnName5 = null;
            this.dokumentBrojTextBox.ColumnName6 = null;
            this.dokumentBrojTextBox.ColumnName7 = null;
            this.dokumentBrojTextBox.daliCetiri = false;
            this.dokumentBrojTextBox.Format = null;
            this.dokumentBrojTextBox.formToOpen = null;
            this.dokumentBrojTextBox.iscistiGreenNaLeave = false;
            this.dokumentBrojTextBox.KoristiFilterNaDatasource = false;
            this.dokumentBrojTextBox.Location = new System.Drawing.Point(674, 63);
            this.dokumentBrojTextBox.MakedonskiJazik = false;
            this.dokumentBrojTextBox.MinLength = 0;
            this.dokumentBrojTextBox.Name = "dokumentBrojTextBox";
            this.dokumentBrojTextBox.PopulateOtherFields = false;
            this.dokumentBrojTextBox.regularExpression = null;
            this.dokumentBrojTextBox.SelektrijaNaFokus = false;
            this.dokumentBrojTextBox.Size = new System.Drawing.Size(234, 35);
            this.dokumentBrojTextBox.TabIndex = 2;
            // 
            // datumNaUplataDateTimePicker
            // 
            this.datumNaUplataDateTimePicker.Location = new System.Drawing.Point(102, 28);
            this.datumNaUplataDateTimePicker.Name = "datumNaUplataDateTimePicker";
            this.datumNaUplataDateTimePicker.Size = new System.Drawing.Size(404, 35);
            this.datumNaUplataDateTimePicker.TabIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPlacanjaOdPartnerTableAdapter = this.tblPlacanjaOdPartnerTableAdapter;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPecati1);
            this.tabPage1.Controls.Add(this.devGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 588);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Салдо на партнер";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPecati1
            // 
            this.btnPecati1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecati1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPecati1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPecati1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPecati1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecati1.Image = ((System.Drawing.Image)(resources.GetObject("btnPecati1.Image")));
            this.btnPecati1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati1.Location = new System.Drawing.Point(8, 6);
            this.btnPecati1.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.Name = "btnPecati1";
            this.btnPecati1.Size = new System.Drawing.Size(132, 38);
            this.btnPecati1.TabIndex = 4;
            this.btnPecati1.Text = "Печати";
            this.btnPecati1.UseVisualStyleBackColor = false;
            this.btnPecati1.Click += new System.EventHandler(this.btnPecati1_Click);
            // 
            // devGrid1
            // 
            this.devGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devGrid1.AssemblyToLoad = null;
            this.devGrid1.DataSource = this.pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource;
            this.devGrid1.EditForm = null;
            this.devGrid1.FilterForm = null;
            this.devGrid1.Location = new System.Drawing.Point(3, 52);
            this.devGrid1.MainView = this.gridView2;
            this.devGrid1.Name = "devGrid1";
            this.devGrid1.PrimaryKey = null;
            this.devGrid1.reportCenter = false;
            this.devGrid1.ReportName = null;
            this.devGrid1.Size = new System.Drawing.Size(0, 0);
            this.devGrid1.TabIndex = 3;
            this.devGrid1.TabStop = false;
            this.devGrid1.UpdateTable = null;
            this.devGrid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource
            // 
            this.pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource.DataMember = "PobaruvaDolguvaPartnerOdPocetokDoKraj";
            this.pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource.DataSource = this.materijalnoDataSetBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colSifra,
            this.colNaziv,
            this.colDolzi,
            this.colPlatil});
            this.gridView2.GridControl = this.devGrid1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colID1
            // 
            this.colID1.Caption = "Реден број";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Sifra", "{0}")});
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 0;
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 1;
            // 
            // colDolzi
            // 
            this.colDolzi.Caption = "Должи";
            this.colDolzi.FieldName = "Dolzi";
            this.colDolzi.Name = "colDolzi";
            this.colDolzi.OptionsColumn.ReadOnly = true;
            this.colDolzi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dolzi", "{0:0.##}")});
            this.colDolzi.Visible = true;
            this.colDolzi.VisibleIndex = 2;
            // 
            // colPlatil
            // 
            this.colPlatil.Caption = "Побарува";
            this.colPlatil.FieldName = "Platil";
            this.colPlatil.Name = "colPlatil";
            this.colPlatil.OptionsColumn.ReadOnly = true;
            this.colPlatil.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Platil", "{0:0.##}")});
            this.colPlatil.Visible = true;
            this.colPlatil.VisibleIndex = 3;
            // 
            // pobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter
            // 
            this.pobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter.ClearBeforeFill = true;
            // 
            // frmVnesNaPlacanjaZaPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 682);
            this.Name = "frmVnesNaPlacanjaZaPartner";
            this.Text = "Внес на плаќања од партнер";
            this.Load += new System.EventHandler(this.frmVnesNaPlacanjaZaPartner_Load);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlacanjaOdPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BssBase.DevGrid viewFakturiStavkiDevGrid;
        private System.Windows.Forms.BindingSource materijalnoDataSetBindingSource;
        private MaterijalnoDataSet materijalnoDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tblPlacanjaOdPartnerBindingSource;
        private MaterijalnoDataSetTableAdapters.tblPlacanjaOdPartnerTableAdapter tblPlacanjaOdPartnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn coltblPartnerID;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaUplata;
        private DevExpress.XtraGrid.Columns.GridColumn colDokumentBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colIzvodBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colZabeleska;
        private BssBase.txtBase txtPartner;
        private BssBase.Elements.Bsslabel bsslabel5;
        private BssBase.zbxBase zbxPartner;
        private BssBase.groupBoxBase groupBoxBase1;
        private BssBase.txtBase iznosTextBox;
        private BssBase.txtBase zabeleskaTextBox;
        private BssBase.txtBase izvodBrojTextBox;
        private BssBase.txtBase dokumentBrojTextBox;
        private System.Windows.Forms.DateTimePicker datumNaUplataDateTimePicker;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPonisti btnPonisti1;
        private System.Windows.Forms.TabPage tabPage1;
        private BssBase.DevGrid devGrid1;
        private System.Windows.Forms.BindingSource pobaruvaDolguvaPartnerOdPocetokDoKrajBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colDolzi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlatil;
        private MaterijalnoDataSetTableAdapters.PobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter pobaruvaDolguvaPartnerOdPocetokDoKrajTableAdapter;
        private BssBase.Elements.btnPecati btnPecati1;
        private BssBase.Elements.btnPecati btnPecati2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
namespace MReport.Forms {
    partial class frmProdazbaOdSmetki
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdazbaOdSmetki));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.txtMin2 = new BssBase.txtBase();
            this.bsslabel4 = new BssBase.Elements.Bsslabel();
            this.txtCas2 = new BssBase.txtBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.txtMin = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.txtSaat = new BssBase.txtBase();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.gridControl1 = new BssBase.DevGrid();
            this.prodazbaOdSmetkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridProdazbaODSmetki = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArtikal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVProcent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresemetanDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2ProdazbaOdSmetki = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prodazbaOdSmetkiTableAdapter = new MReport.BSSRDataSetTableAdapters.ProdazbaOdSmetkiTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazbaOdSmetkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdazbaODSmetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2ProdazbaOdSmetki)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bsslabel3);
            this.groupBox1.Controls.Add(this.txtMin2);
            this.groupBox1.Controls.Add(this.bsslabel4);
            this.groupBox1.Controls.Add(this.txtCas2);
            this.groupBox1.Controls.Add(this.bsslabel2);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.bsslabel1);
            this.groupBox1.Controls.Add(this.txtSaat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DatumDo);
            this.groupBox1.Controls.Add(this.datumOd);
            this.groupBox1.Controls.Add(this.btnPotvrdi1);
            this.groupBox1.Controls.Add(this.btnPecati1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 134);
            this.label4.TabIndex = 35;
            this.label4.Text = "СУМА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-81, -155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "label3";
            // 
            // bsslabel3
            // 
            this.bsslabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Location = new System.Drawing.Point(725, 213);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(44, 13);
            this.bsslabel3.TabIndex = 33;
            this.bsslabel3.Text = "Минута";
            // 
            // txtMin2
            // 
            this.txtMin2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMin2.AssemblyStr = null;
            this.txtMin2.C_FillWithZeros = false;
            this.txtMin2.C_OnlyNumbers = true;
            this.txtMin2.C_RegEx = false;
            this.txtMin2.C_ShowRedOnLeaveIfEmpty = true;
            this.txtMin2.ColumnName1 = null;
            this.txtMin2.ColumnName2 = null;
            this.txtMin2.ColumnName3 = null;
            this.txtMin2.ColumnName4 = null;
            this.txtMin2.ColumnName5 = null;
            this.txtMin2.ColumnName6 = null;
            this.txtMin2.ColumnName7 = null;
            this.txtMin2.daliCetiri = false;
            this.txtMin2.Format = null;
            this.txtMin2.formToOpen = null;
            this.txtMin2.iscistiGreenNaLeave = false;
            this.txtMin2.KoristiFilterNaDatasource = false;
            this.txtMin2.Location = new System.Drawing.Point(775, 211);
            this.txtMin2.MakedonskiJazik = false;
            this.txtMin2.MaxLength = 2;
            this.txtMin2.MinLength = 0;
            this.txtMin2.Name = "txtMin2";
            this.txtMin2.PopulateOtherFields = false;
            this.txtMin2.regularExpression = null;
            this.txtMin2.SelektrijaNaFokus = false;
            this.txtMin2.Size = new System.Drawing.Size(25, 20);
            this.txtMin2.TabIndex = 32;
            this.txtMin2.Text = "0";
            // 
            // bsslabel4
            // 
            this.bsslabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Location = new System.Drawing.Point(656, 213);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(27, 13);
            this.bsslabel4.TabIndex = 31;
            this.bsslabel4.Text = "Час";
            // 
            // txtCas2
            // 
            this.txtCas2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCas2.AssemblyStr = null;
            this.txtCas2.C_FillWithZeros = false;
            this.txtCas2.C_OnlyNumbers = true;
            this.txtCas2.C_RegEx = false;
            this.txtCas2.C_ShowRedOnLeaveIfEmpty = true;
            this.txtCas2.ColumnName1 = null;
            this.txtCas2.ColumnName2 = null;
            this.txtCas2.ColumnName3 = null;
            this.txtCas2.ColumnName4 = null;
            this.txtCas2.ColumnName5 = null;
            this.txtCas2.ColumnName6 = null;
            this.txtCas2.ColumnName7 = null;
            this.txtCas2.daliCetiri = false;
            this.txtCas2.Format = null;
            this.txtCas2.formToOpen = null;
            this.txtCas2.iscistiGreenNaLeave = false;
            this.txtCas2.KoristiFilterNaDatasource = false;
            this.txtCas2.Location = new System.Drawing.Point(689, 211);
            this.txtCas2.MakedonskiJazik = false;
            this.txtCas2.MaxLength = 2;
            this.txtCas2.MinLength = 0;
            this.txtCas2.Name = "txtCas2";
            this.txtCas2.PopulateOtherFields = false;
            this.txtCas2.regularExpression = null;
            this.txtCas2.SelektrijaNaFokus = false;
            this.txtCas2.Size = new System.Drawing.Size(29, 20);
            this.txtCas2.TabIndex = 30;
            this.txtCas2.Text = "0";
            // 
            // bsslabel2
            // 
            this.bsslabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(510, 213);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(44, 13);
            this.bsslabel2.TabIndex = 29;
            this.bsslabel2.Text = "Минута";
            // 
            // txtMin
            // 
            this.txtMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMin.AssemblyStr = null;
            this.txtMin.C_FillWithZeros = false;
            this.txtMin.C_OnlyNumbers = true;
            this.txtMin.C_RegEx = false;
            this.txtMin.C_ShowRedOnLeaveIfEmpty = true;
            this.txtMin.ColumnName1 = null;
            this.txtMin.ColumnName2 = null;
            this.txtMin.ColumnName3 = null;
            this.txtMin.ColumnName4 = null;
            this.txtMin.ColumnName5 = null;
            this.txtMin.ColumnName6 = null;
            this.txtMin.ColumnName7 = null;
            this.txtMin.daliCetiri = false;
            this.txtMin.Format = null;
            this.txtMin.formToOpen = null;
            this.txtMin.iscistiGreenNaLeave = false;
            this.txtMin.KoristiFilterNaDatasource = false;
            this.txtMin.Location = new System.Drawing.Point(560, 211);
            this.txtMin.MakedonskiJazik = false;
            this.txtMin.MaxLength = 2;
            this.txtMin.MinLength = 0;
            this.txtMin.Name = "txtMin";
            this.txtMin.PopulateOtherFields = false;
            this.txtMin.regularExpression = null;
            this.txtMin.SelektrijaNaFokus = false;
            this.txtMin.Size = new System.Drawing.Size(25, 20);
            this.txtMin.TabIndex = 28;
            this.txtMin.Text = "0";
            // 
            // bsslabel1
            // 
            this.bsslabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(441, 213);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(27, 13);
            this.bsslabel1.TabIndex = 27;
            this.bsslabel1.Text = "Час";
            // 
            // txtSaat
            // 
            this.txtSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaat.AssemblyStr = null;
            this.txtSaat.C_FillWithZeros = false;
            this.txtSaat.C_OnlyNumbers = true;
            this.txtSaat.C_RegEx = false;
            this.txtSaat.C_ShowRedOnLeaveIfEmpty = true;
            this.txtSaat.ColumnName1 = null;
            this.txtSaat.ColumnName2 = null;
            this.txtSaat.ColumnName3 = null;
            this.txtSaat.ColumnName4 = null;
            this.txtSaat.ColumnName5 = null;
            this.txtSaat.ColumnName6 = null;
            this.txtSaat.ColumnName7 = null;
            this.txtSaat.daliCetiri = false;
            this.txtSaat.Format = null;
            this.txtSaat.formToOpen = null;
            this.txtSaat.iscistiGreenNaLeave = false;
            this.txtSaat.KoristiFilterNaDatasource = false;
            this.txtSaat.Location = new System.Drawing.Point(474, 211);
            this.txtSaat.MakedonskiJazik = false;
            this.txtSaat.MaxLength = 2;
            this.txtSaat.MinLength = 0;
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.PopulateOtherFields = false;
            this.txtSaat.regularExpression = null;
            this.txtSaat.SelektrijaNaFokus = false;
            this.txtSaat.Size = new System.Drawing.Size(29, 20);
            this.txtSaat.TabIndex = 26;
            this.txtSaat.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датум на почеток до :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Датум на почеток од :";
            // 
            // DatumDo
            // 
            this.DatumDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatumDo.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.DatumDo.HotDate = null;
            this.DatumDo.Location = new System.Drawing.Point(658, 35);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.CellPadding = new System.Windows.Forms.Padding(2);
            this.DatumDo.Size = new System.Drawing.Size(208, 175);
            this.DatumDo.TabIndex = 3;
            // 
            // datumOd
            // 
            this.datumOd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumOd.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.datumOd.HotDate = null;
            this.datumOd.Location = new System.Drawing.Point(444, 35);
            this.datumOd.Name = "datumOd";
            this.datumOd.CellPadding = new System.Windows.Forms.Padding(2);
            this.datumOd.Size = new System.Drawing.Size(208, 175);
            this.datumOd.TabIndex = 2;
            // 
            // btnPotvrdi1
            // 
            this.btnPotvrdi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi1.Image = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi1.Image")));
            this.btnPotvrdi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi1.Location = new System.Drawing.Point(306, 172);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.TabIndex = 1;
            this.btnPotvrdi1.Text = "Прикажи";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
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
            this.btnPecati1.Location = new System.Drawing.Point(6, 172);
            this.btnPecati1.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.Name = "btnPecati1";
            this.btnPecati1.Size = new System.Drawing.Size(132, 38);
            this.btnPecati1.TabIndex = 0;
            this.btnPecati1.Text = "Печати";
            this.btnPecati1.UseVisualStyleBackColor = false;
            this.btnPecati1.Click += new System.EventHandler(this.btnPecati1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.AssemblyToLoad = null;
            this.gridControl1.DataSource = this.prodazbaOdSmetkiBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(6, 264);
            this.gridControl1.MainView = this.gridProdazbaODSmetki;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(866, 323);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProdazbaODSmetki,
            this.gridView2ProdazbaOdSmetki});
            // 
            // prodazbaOdSmetkiBindingSource
            // 
            this.prodazbaOdSmetkiBindingSource.DataMember = "ProdazbaOdSmetki";
            this.prodazbaOdSmetkiBindingSource.DataSource = this.bSSRDataSet;
            // 
            // bSSRDataSet
            // 
            this.bSSRDataSet.DataSetName = "BSSRDataSet";
            this.bSSRDataSet.EnforceConstraints = false;
            this.bSSRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridProdazbaODSmetki
            // 
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.Empty.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridProdazbaODSmetki.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridProdazbaODSmetki.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridProdazbaODSmetki.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridProdazbaODSmetki.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridProdazbaODSmetki.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridProdazbaODSmetki.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.OddRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridProdazbaODSmetki.Appearance.OddRow.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridProdazbaODSmetki.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridProdazbaODSmetki.Appearance.Preview.Options.UseFont = true;
            this.gridProdazbaODSmetki.Appearance.Preview.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridProdazbaODSmetki.Appearance.Row.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.Row.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridProdazbaODSmetki.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridProdazbaODSmetki.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridProdazbaODSmetki.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridProdazbaODSmetki.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridProdazbaODSmetki.Appearance.VertLine.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArtikal,
            this.colSifra,
            this.colNaziv,
            this.colKolicina,
            this.colProdaznaCena,
            this.colCenaBezDDV,
            this.colDDVProcent,
            this.colIznosBezDDV,
            this.colIznos,
            this.colPresemetanDDV});
            this.gridProdazbaODSmetki.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            this.gridProdazbaODSmetki.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridProdazbaODSmetki.GridControl = this.gridControl1;
            this.gridProdazbaODSmetki.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridProdazbaODSmetki.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Artikal", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", null, "Вкупен Износ {0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IznosBezDDV", null, "Вкупен износ без ДДВ {0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PresmetanDDV", null, "Вкупно ДДВ {0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "DDVProcent", null, "")});
            this.gridProdazbaODSmetki.Name = "gridProdazbaODSmetki";
            this.gridProdazbaODSmetki.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridProdazbaODSmetki.OptionsBehavior.Editable = false;
            this.gridProdazbaODSmetki.OptionsDetail.AllowZoomDetail = false;
            this.gridProdazbaODSmetki.OptionsDetail.AutoZoomDetail = true;
            this.gridProdazbaODSmetki.OptionsDetail.EnableDetailToolTip = true;
            this.gridProdazbaODSmetki.OptionsDetail.ShowDetailTabs = false;
            this.gridProdazbaODSmetki.OptionsPrint.ExpandAllDetails = true;
            this.gridProdazbaODSmetki.OptionsPrint.PrintDetails = true;
            this.gridProdazbaODSmetki.OptionsPrint.PrintFilterInfo = true;
            this.gridProdazbaODSmetki.OptionsPrint.UsePrintStyles = false;
            this.gridProdazbaODSmetki.OptionsView.EnableAppearanceEvenRow = true;
            this.gridProdazbaODSmetki.OptionsView.EnableAppearanceOddRow = true;
            this.gridProdazbaODSmetki.OptionsView.RowAutoHeight = true;
            this.gridProdazbaODSmetki.OptionsView.ShowAutoFilterRow = true;
            this.gridProdazbaODSmetki.OptionsView.ShowFooter = true;
            this.gridProdazbaODSmetki.PaintStyleName = "Office2003";
            // 
            // colArtikal
            // 
            this.colArtikal.Caption = "Артикал";
            this.colArtikal.FieldName = "Artikal";
            this.colArtikal.Name = "colArtikal";
            this.colArtikal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Artikal", "{0}")});
            this.colArtikal.Visible = true;
            this.colArtikal.VisibleIndex = 0;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 1;
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 2;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 3;
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Продажна цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            this.colProdaznaCena.Visible = true;
            this.colProdaznaCena.VisibleIndex = 6;
            // 
            // colCenaBezDDV
            // 
            this.colCenaBezDDV.Caption = "Цена без ДДВ";
            this.colCenaBezDDV.FieldName = "CenaBezDDV";
            this.colCenaBezDDV.Name = "colCenaBezDDV";
            this.colCenaBezDDV.OptionsColumn.ReadOnly = true;
            this.colCenaBezDDV.Visible = true;
            this.colCenaBezDDV.VisibleIndex = 4;
            // 
            // colDDVProcent
            // 
            this.colDDVProcent.Caption = "ДДВ Стапка";
            this.colDDVProcent.FieldName = "DDVProcent";
            this.colDDVProcent.Name = "colDDVProcent";
            this.colDDVProcent.Visible = true;
            this.colDDVProcent.VisibleIndex = 5;
            // 
            // colIznosBezDDV
            // 
            this.colIznosBezDDV.Caption = "Износ без ДДВ";
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.OptionsColumn.ReadOnly = true;
            this.colIznosBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IznosBezDDV", "{0:0.##}")});
            this.colIznosBezDDV.Visible = true;
            this.colIznosBezDDV.VisibleIndex = 8;
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "{0:0.##}")});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 9;
            // 
            // colPresemetanDDV
            // 
            this.colPresemetanDDV.Caption = "Пресметан ДДВ";
            this.colPresemetanDDV.FieldName = "PresmetanDDV";
            this.colPresemetanDDV.Name = "colPresemetanDDV";
            this.colPresemetanDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PresmetanDDV", "{0:0.##}")});
            this.colPresemetanDDV.Visible = true;
            this.colPresemetanDDV.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Broj";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // gridView2ProdazbaOdSmetki
            // 
            this.gridView2ProdazbaOdSmetki.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2ProdazbaOdSmetki.GridControl = this.gridControl1;
            this.gridView2ProdazbaOdSmetki.Name = "gridView2ProdazbaOdSmetki";
            this.gridView2ProdazbaOdSmetki.OptionsBehavior.Editable = false;
            this.gridView2ProdazbaOdSmetki.OptionsPrint.PrintGroupFooter = false;
            this.gridView2ProdazbaOdSmetki.OptionsPrint.PrintHorzLines = false;
            this.gridView2ProdazbaOdSmetki.OptionsPrint.PrintVertLines = false;
            this.gridView2ProdazbaOdSmetki.OptionsPrint.UsePrintStyles = false;
            this.gridView2ProdazbaOdSmetki.OptionsView.RowAutoHeight = true;
            this.gridView2ProdazbaOdSmetki.OptionsView.ShowFooter = true;
            this.gridView2ProdazbaOdSmetki.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Количина";
            this.gridColumn3.FieldName = "Kolicina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Цена";
            this.gridColumn4.FieldName = "Cena";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // prodazbaOdSmetkiTableAdapter
            // 
            this.prodazbaOdSmetkiTableAdapter.ClearBeforeFill = true;
            // 
            // frmProdazbaOdSmetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 587);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdazbaOdSmetki";
            this.Text = "Продажба од сметки";
            this.Load += new System.EventHandler(this.frmProdazbaOdSmetki_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazbaOdSmetkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdazbaODSmetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2ProdazbaOdSmetki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraScheduler.DateNavigator DatumDo;
		private DevExpress.XtraScheduler.DateNavigator datumOd;
		private BssBase.Elements.btnPotvrdi btnPotvrdi1;
		private BssBase.Elements.btnPecati btnPecati1;
		private BssBase.DevGrid gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridProdazbaODSmetki;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2ProdazbaOdSmetki;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private BSSRDataSet bSSRDataSet;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.txtBase txtMin2;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.txtBase txtCas2;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.txtBase txtMin;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.txtBase txtSaat;
        private System.Windows.Forms.BindingSource prodazbaOdSmetkiBindingSource;
        private BSSRDataSetTableAdapters.ProdazbaOdSmetkiTableAdapter prodazbaOdSmetkiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colArtikal;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVProcent;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colPresemetanDDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
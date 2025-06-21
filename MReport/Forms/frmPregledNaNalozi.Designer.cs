namespace MReport.Forms {
	partial class frmPregledNaNalozi {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNaNalozi));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.label2 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.rbtnNesocuvani = new System.Windows.Forms.RadioButton();
            this.rbtnSocuvani = new System.Windows.Forms.RadioButton();
            this.rbtnSite = new System.Windows.Forms.RadioButton();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.txtMin2 = new BssBase.txtBase();
            this.bsslabel4 = new BssBase.Elements.Bsslabel();
            this.txtCas2 = new BssBase.txtBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.txtMin = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.txtSaat = new BssBase.txtBase();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new BssBase.DevGrid();
            this.detalenPregledNaSmetkaBindingSource = new System.Windows.Forms.BindingSource();
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaSoRabatIddv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumPocetok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumKraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMkProizvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresmetanDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmetkaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNalogID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiskalna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVProcent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZabeleska = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detalenPregledNaSmetkaTableAdapter = new MReport.BSSRDataSetTableAdapters.DetalenPregledNaSmetkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalenPregledNaSmetkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датум на почеток до :";
            // 
            // DatumDo
            // 
            this.DatumDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatumDo.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.DatumDo.HotDate = null;
            this.DatumDo.Location = new System.Drawing.Point(583, 32);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.CellPadding = new System.Windows.Forms.Padding(2);
            this.DatumDo.Size = new System.Drawing.Size(208, 175);
            this.DatumDo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Датум на почеток од :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBoxBase1);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.rbtnNesocuvani);
            this.groupBoxBase1.Controls.Add(this.rbtnSocuvani);
            this.groupBoxBase1.Controls.Add(this.rbtnSite);
            this.groupBoxBase1.Location = new System.Drawing.Point(5, 32);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(346, 56);
            this.groupBoxBase1.TabIndex = 32;
            this.groupBoxBase1.TabStop = false;
            this.groupBoxBase1.Text = "Сметки";
            // 
            // rbtnNesocuvani
            // 
            this.rbtnNesocuvani.AutoSize = true;
            this.rbtnNesocuvani.Location = new System.Drawing.Point(255, 22);
            this.rbtnNesocuvani.Name = "rbtnNesocuvani";
            this.rbtnNesocuvani.Size = new System.Drawing.Size(85, 17);
            this.rbtnNesocuvani.TabIndex = 2;
            this.rbtnNesocuvani.Text = "Несочувани";
            this.rbtnNesocuvani.UseVisualStyleBackColor = true;
            // 
            // rbtnSocuvani
            // 
            this.rbtnSocuvani.AutoSize = true;
            this.rbtnSocuvani.Location = new System.Drawing.Point(130, 22);
            this.rbtnSocuvani.Name = "rbtnSocuvani";
            this.rbtnSocuvani.Size = new System.Drawing.Size(72, 17);
            this.rbtnSocuvani.TabIndex = 1;
            this.rbtnSocuvani.Text = "Сочувани";
            this.rbtnSocuvani.UseVisualStyleBackColor = true;
            // 
            // rbtnSite
            // 
            this.rbtnSite.AutoSize = true;
            this.rbtnSite.Checked = true;
            this.rbtnSite.Location = new System.Drawing.Point(6, 22);
            this.rbtnSite.Name = "rbtnSite";
            this.rbtnSite.Size = new System.Drawing.Size(49, 17);
            this.rbtnSite.TabIndex = 0;
            this.rbtnSite.TabStop = true;
            this.rbtnSite.Text = "Сите";
            this.rbtnSite.UseVisualStyleBackColor = true;
            // 
            // bsslabel3
            // 
            this.bsslabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Location = new System.Drawing.Point(650, 210);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(44, 13);
            this.bsslabel3.TabIndex = 31;
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
            this.txtMin2.Location = new System.Drawing.Point(700, 208);
            this.txtMin2.MakedonskiJazik = false;
            this.txtMin2.MaxLength = 2;
            this.txtMin2.MinLength = 0;
            this.txtMin2.Name = "txtMin2";
            this.txtMin2.PopulateOtherFields = false;
            this.txtMin2.regularExpression = null;
            this.txtMin2.SelektrijaNaFokus = false;
            this.txtMin2.Size = new System.Drawing.Size(25, 20);
            this.txtMin2.TabIndex = 30;
            this.txtMin2.Text = "0";
            // 
            // bsslabel4
            // 
            this.bsslabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Location = new System.Drawing.Point(581, 210);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(27, 13);
            this.bsslabel4.TabIndex = 29;
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
            this.txtCas2.Location = new System.Drawing.Point(614, 208);
            this.txtCas2.MakedonskiJazik = false;
            this.txtCas2.MaxLength = 2;
            this.txtCas2.MinLength = 0;
            this.txtCas2.Name = "txtCas2";
            this.txtCas2.PopulateOtherFields = false;
            this.txtCas2.regularExpression = null;
            this.txtCas2.SelektrijaNaFokus = false;
            this.txtCas2.Size = new System.Drawing.Size(29, 20);
            this.txtCas2.TabIndex = 28;
            this.txtCas2.Text = "0";
            // 
            // bsslabel2
            // 
            this.bsslabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(435, 210);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(44, 13);
            this.bsslabel2.TabIndex = 27;
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
            this.txtMin.Location = new System.Drawing.Point(485, 208);
            this.txtMin.MakedonskiJazik = false;
            this.txtMin.MaxLength = 2;
            this.txtMin.MinLength = 0;
            this.txtMin.Name = "txtMin";
            this.txtMin.PopulateOtherFields = false;
            this.txtMin.regularExpression = null;
            this.txtMin.SelektrijaNaFokus = false;
            this.txtMin.Size = new System.Drawing.Size(25, 20);
            this.txtMin.TabIndex = 26;
            this.txtMin.Text = "0";
            // 
            // bsslabel1
            // 
            this.bsslabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(366, 210);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(27, 13);
            this.bsslabel1.TabIndex = 25;
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
            this.txtSaat.Location = new System.Drawing.Point(399, 208);
            this.txtSaat.MakedonskiJazik = false;
            this.txtSaat.MaxLength = 2;
            this.txtSaat.MinLength = 0;
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.PopulateOtherFields = false;
            this.txtSaat.regularExpression = null;
            this.txtSaat.SelektrijaNaFokus = false;
            this.txtSaat.Size = new System.Drawing.Size(29, 20);
            this.txtSaat.TabIndex = 24;
            this.txtSaat.Text = "0";
            // 
            // datumOd
            // 
            this.datumOd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumOd.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.datumOd.HotDate = null;
            this.datumOd.Location = new System.Drawing.Point(369, 32);
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(231, 169);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(7, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 289);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.AssemblyToLoad = null;
            this.gridControl1.DataSource = this.detalenPregledNaSmetkaBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(-2, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(801, 274);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // detalenPregledNaSmetkaBindingSource
            // 
            this.detalenPregledNaSmetkaBindingSource.DataMember = "DetalenPregledNaSmetka";
            this.detalenPregledNaSmetkaBindingSource.DataSource = this.bSSRDataSet;
            // 
            // bSSRDataSet
            // 
            this.bSSRDataSet.DataSetName = "BSSRDataSet";
            this.bSSRDataSet.EnforceConstraints = false;
            this.bSSRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBroj,
            this.colCenaSoRabatIddv,
            this.colDatumPocetok,
            this.colDatumKraj,
            this.colIznos,
            this.colIznosBezDDV,
            this.colMkProizvod,
            this.colKolicina,
            this.colPresmetanDDV,
            this.colNaziv,
            this.colSifra,
            this.colSifra2,
            this.colSmetkaID,
            this.colNalogID,
            this.colRabat,
            this.colFiskalna,
            this.colArtikalID,
            this.colDanok,
            this.colDDVProcent,
            this.colProdaznaCena,
            this.colTip,
            this.colZabeleska,
            this.colCenaBezDDV});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", null, "Износ {0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kolicina", null, "Количина {0:0.##}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.AutoZoomDetail = true;
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.UsePrintStyles = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // colBroj
            // 
            this.colBroj.Caption = "Број на сметка";
            this.colBroj.FieldName = "Broj";
            this.colBroj.Name = "colBroj";
            this.colBroj.Visible = true;
            this.colBroj.VisibleIndex = 1;
            // 
            // colCenaSoRabatIddv
            // 
            this.colCenaSoRabatIddv.Caption = "Цена со рабат и ДДВ";
            this.colCenaSoRabatIddv.FieldName = "CenaSoRabatIddv";
            this.colCenaSoRabatIddv.Name = "colCenaSoRabatIddv";
            this.colCenaSoRabatIddv.Visible = true;
            this.colCenaSoRabatIddv.VisibleIndex = 5;
            // 
            // colDatumPocetok
            // 
            this.colDatumPocetok.Caption = "Датум на почеток";
            this.colDatumPocetok.FieldName = "DatumPocetok";
            this.colDatumPocetok.Name = "colDatumPocetok";
            this.colDatumPocetok.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DatumPocetok", "{0}")});
            this.colDatumPocetok.Visible = true;
            this.colDatumPocetok.VisibleIndex = 2;
            // 
            // colDatumKraj
            // 
            this.colDatumKraj.Caption = "Датум на крај";
            this.colDatumKraj.FieldName = "DatumKraj";
            this.colDatumKraj.Name = "colDatumKraj";
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "{0:0.##}")});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 10;
            // 
            // colIznosBezDDV
            // 
            this.colIznosBezDDV.Caption = "Износ без ДДВ";
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            // 
            // colMkProizvod
            // 
            this.colMkProizvod.Caption = "Македонски производ";
            this.colMkProizvod.FieldName = "MkProizvod";
            this.colMkProizvod.Name = "colMkProizvod";
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kolicina", "{0:0.##}")});
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 8;
            // 
            // colPresmetanDDV
            // 
            this.colPresmetanDDV.Caption = "Пресметан ДДВ";
            this.colPresmetanDDV.FieldName = "PresmetanDDV";
            this.colPresmetanDDV.Name = "colPresmetanDDV";
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив на артикал";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 3;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра на артикал";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 0;
            // 
            // colSifra2
            // 
            this.colSifra2.Caption = "Алт.Шифра на артикал";
            this.colSifra2.FieldName = "Sifra2";
            this.colSifra2.Name = "colSifra2";
            // 
            // colSmetkaID
            // 
            this.colSmetkaID.Caption = "Реден број на сметка";
            this.colSmetkaID.FieldName = "SmetkaID";
            this.colSmetkaID.Name = "colSmetkaID";
            // 
            // colNalogID
            // 
            this.colNalogID.Caption = "Реден број на налог";
            this.colNalogID.FieldName = "NalogID";
            this.colNalogID.Name = "colNalogID";
            // 
            // colRabat
            // 
            this.colRabat.Caption = "Рабат";
            this.colRabat.FieldName = "Rabat";
            this.colRabat.Name = "colRabat";
            this.colRabat.Visible = true;
            this.colRabat.VisibleIndex = 4;
            // 
            // colFiskalna
            // 
            this.colFiskalna.Caption = "Сочувана";
            this.colFiskalna.FieldName = "Fiskalna";
            this.colFiskalna.Name = "colFiskalna";
            // 
            // colArtikalID
            // 
            this.colArtikalID.Caption = "Реден број на артикал";
            this.colArtikalID.FieldName = "ArtikalID";
            this.colArtikalID.Name = "colArtikalID";
            // 
            // colDanok
            // 
            this.colDanok.Caption = "Данок";
            this.colDanok.FieldName = "Danok";
            this.colDanok.Name = "colDanok";
            // 
            // colDDVProcent
            // 
            this.colDDVProcent.Caption = "ДДВ Процент";
            this.colDDVProcent.FieldName = "DDVProcent";
            this.colDDVProcent.Name = "colDDVProcent";
            this.colDDVProcent.Visible = true;
            this.colDDVProcent.VisibleIndex = 6;
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Продажна Цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            this.colProdaznaCena.Visible = true;
            this.colProdaznaCena.VisibleIndex = 7;
            // 
            // colTip
            // 
            this.colTip.Caption = "Тип";
            this.colTip.FieldName = "Tip";
            this.colTip.Name = "colTip";
            // 
            // colZabeleska
            // 
            this.colZabeleska.Caption = "Забелешка";
            this.colZabeleska.FieldName = "Zabeleska";
            this.colZabeleska.Name = "colZabeleska";
            // 
            // colCenaBezDDV
            // 
            this.colCenaBezDDV.Caption = "Цена без ДДВ";
            this.colCenaBezDDV.FieldName = "CenaBezDDV";
            this.colCenaBezDDV.Name = "colCenaBezDDV";
            this.colCenaBezDDV.Visible = true;
            this.colCenaBezDDV.VisibleIndex = 9;
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsPrint.PrintGroupFooter = false;
            this.gridView2.OptionsPrint.PrintHorzLines = false;
            this.gridView2.OptionsPrint.PrintVertLines = false;
            this.gridView2.OptionsPrint.UsePrintStyles = false;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // detalenPregledNaSmetkaTableAdapter
            // 
            this.detalenPregledNaSmetkaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledNaNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPregledNaNalozi";
            this.Text = "Преглед на нарачки";
            this.Load += new System.EventHandler(this.frmPregledNaNalozi_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalenPregledNaSmetkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private DevExpress.XtraScheduler.DateNavigator DatumDo;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private DevExpress.XtraScheduler.DateNavigator datumOd;
		private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPecati btnPecati1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BssBase.DevGrid gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private BSSRDataSet bSSRDataSet;
        private System.Windows.Forms.BindingSource detalenPregledNaSmetkaBindingSource;
        private BSSRDataSetTableAdapters.DetalenPregledNaSmetkaTableAdapter detalenPregledNaSmetkaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaSoRabatIddv;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumPocetok;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumKraj;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colMkProizvod;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colPresmetanDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra2;
        private DevExpress.XtraGrid.Columns.GridColumn colSmetkaID;
        private DevExpress.XtraGrid.Columns.GridColumn colNalogID;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.txtBase txtMin2;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.txtBase txtCas2;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.txtBase txtMin;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.txtBase txtSaat;
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.RadioButton rbtnNesocuvani;
        private System.Windows.Forms.RadioButton rbtnSocuvani;
        private System.Windows.Forms.RadioButton rbtnSite;
        private DevExpress.XtraGrid.Columns.GridColumn colFiskalna;
        private DevExpress.XtraGrid.Columns.GridColumn colArtikalID;
        private DevExpress.XtraGrid.Columns.GridColumn colDanok;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVProcent;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
        private DevExpress.XtraGrid.Columns.GridColumn colTip;
        private DevExpress.XtraGrid.Columns.GridColumn colZabeleska;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaBezDDV;
    }
}
namespace MReport.Forms {
	partial class frmPregledNaPlacanjePoDokument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNaPlacanjePoDokument));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.label2 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.rbtnNeplateni = new System.Windows.Forms.RadioButton();
            this.rbtnSite = new System.Windows.Forms.RadioButton();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new BssBase.DevGrid();
            this.dokumentiIzvodiPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlatenoZaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreostanatoZaPlacanje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dokumentiIzvodiPartnerTableAdapter = new MReport.BSSRDataSetTableAdapters.DokumentiIzvodiPartnerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo.CalendarTimeProperties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd.CalendarTimeProperties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentiIzvodiPartnerBindingSource)).BeginInit();
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
            this.DatumDo.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatumDo.CellPadding = new System.Windows.Forms.Padding(2);
            this.DatumDo.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.DatumDo.EditValue = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.DatumDo.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.DatumDo.Location = new System.Drawing.Point(583, 32);
            this.DatumDo.Name = "DatumDo";
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
            this.groupBoxBase1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase1.Controls.Add(this.rbtnNeplateni);
            this.groupBoxBase1.Controls.Add(this.rbtnSite);
            this.groupBoxBase1.Location = new System.Drawing.Point(208, 32);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(155, 39);
            this.groupBoxBase1.TabIndex = 32;
            this.groupBoxBase1.TabStop = false;
            this.groupBoxBase1.Text = "Плаќања од Документи";
            // 
            // rbtnNeplateni
            // 
            this.rbtnNeplateni.AutoSize = true;
            this.rbtnNeplateni.Checked = true;
            this.rbtnNeplateni.Location = new System.Drawing.Point(61, 19);
            this.rbtnNeplateni.Name = "rbtnNeplateni";
            this.rbtnNeplateni.Size = new System.Drawing.Size(83, 17);
            this.rbtnNeplateni.TabIndex = 2;
            this.rbtnNeplateni.TabStop = true;
            this.rbtnNeplateni.Text = "Не платени";
            this.rbtnNeplateni.UseVisualStyleBackColor = true;
            // 
            // rbtnSite
            // 
            this.rbtnSite.AutoSize = true;
            this.rbtnSite.Location = new System.Drawing.Point(6, 19);
            this.rbtnSite.Name = "rbtnSite";
            this.rbtnSite.Size = new System.Drawing.Size(49, 17);
            this.rbtnSite.TabIndex = 0;
            this.rbtnSite.Text = "Сите";
            this.rbtnSite.UseVisualStyleBackColor = true;
            // 
            // datumOd
            // 
            this.datumOd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumOd.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datumOd.CellPadding = new System.Windows.Forms.Padding(2);
            this.datumOd.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.datumOd.EditValue = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.datumOd.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.datumOd.Location = new System.Drawing.Point(369, 32);
            this.datumOd.Name = "datumOd";
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
            this.gridControl1.DataSource = this.dokumentiIzvodiPartnerBindingSource;
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
            // dokumentiIzvodiPartnerBindingSource
            // 
            this.dokumentiIzvodiPartnerBindingSource.DataMember = "DokumentiIzvodiPartner";
            this.dokumentiIzvodiPartnerBindingSource.DataSource = this.bSSRDataSet;
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
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.colSifra,
            this.colNaziv,
            this.colDatum,
            this.colDocNaziv,
            this.colIznosNaDokument,
            this.colPlatenoZaDokument,
            this.colPreostanatoZaPlacanje});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IznosNaDokument", this.colIznosNaDokument, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlatenoZaDokument", this.colPlatenoZaDokument, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PreostanatoZaPlacanje", this.colPreostanatoZaPlacanje, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "DocNaziv", this.colDocNaziv, "")});
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
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSifra, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Партнер / Стан";
            this.colSifra.DisplayFormat.FormatString = "d";
            this.colSifra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 1;
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив ";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            // 
            // colDatum
            // 
            this.colDatum.Caption = "Датум";
            this.colDatum.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colDatum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDatum.FieldName = "Datum";
            this.colDatum.Name = "colDatum";
            this.colDatum.Visible = true;
            this.colDatum.VisibleIndex = 0;
            // 
            // colDocNaziv
            // 
            this.colDocNaziv.Caption = "Документ";
            this.colDocNaziv.FieldName = "DocNaziv";
            this.colDocNaziv.Name = "colDocNaziv";
            this.colDocNaziv.Visible = true;
            this.colDocNaziv.VisibleIndex = 1;
            // 
            // colIznosNaDokument
            // 
            this.colIznosNaDokument.Caption = "Износ на документ";
            this.colIznosNaDokument.FieldName = "IznosNaDokument";
            this.colIznosNaDokument.Name = "colIznosNaDokument";
            this.colIznosNaDokument.Visible = true;
            this.colIznosNaDokument.VisibleIndex = 2;
            // 
            // colPlatenoZaDokument
            // 
            this.colPlatenoZaDokument.Caption = "Платено за документ";
            this.colPlatenoZaDokument.FieldName = "PlatenoZaDokument";
            this.colPlatenoZaDokument.Name = "colPlatenoZaDokument";
            this.colPlatenoZaDokument.Visible = true;
            this.colPlatenoZaDokument.VisibleIndex = 3;
            // 
            // colPreostanatoZaPlacanje
            // 
            this.colPreostanatoZaPlacanje.Caption = "Преостанато за плаќање";
            this.colPreostanatoZaPlacanje.FieldName = "PreostanatoZaPlacanje";
            this.colPreostanatoZaPlacanje.Name = "colPreostanatoZaPlacanje";
            this.colPreostanatoZaPlacanje.Visible = true;
            this.colPreostanatoZaPlacanje.VisibleIndex = 4;
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
            // dokumentiIzvodiPartnerTableAdapter
            // 
            this.dokumentiIzvodiPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledNaPlacanjePoDokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPregledNaPlacanjePoDokument";
            this.Text = "Преглед Плаќања На Партнер По Документ";
            this.Load += new System.EventHandler(this.frmPregledNaPlacanjePoDokument_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentiIzvodiPartnerBindingSource)).EndInit();
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
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.RadioButton rbtnNeplateni;
        private System.Windows.Forms.RadioButton rbtnSite;
        private System.Windows.Forms.BindingSource dokumentiIzvodiPartnerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosNaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colPlatenoZaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colPreostanatoZaPlacanje;
        private BSSRDataSetTableAdapters.DokumentiIzvodiPartnerTableAdapter dokumentiIzvodiPartnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
    }
}
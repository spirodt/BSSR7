﻿namespace MReport.Forms {
	partial class frmPotroseniMaterijali {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPotroseniMaterijali));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.gridControl1 = new BssBase.DevGrid();
            this.potroseniMaterijaliZaPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblArtikalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicinaIzlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicinaPoMerkaIzlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdinecnaMerkaIzlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaPocetok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaKnizenje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabavnaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipNaKnizenje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabavenIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.potroseniMaterijaliZaPeriodTableAdapter = new MReport.BSSRDataSetTableAdapters.PotroseniMaterijaliZaPeriodTableAdapter();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potroseniMaterijaliZaPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bsslabel3);
            this.groupBox1.Controls.Add(this.txtMin2);
            this.groupBox1.Controls.Add(this.bsslabel4);
            this.groupBox1.Controls.Add(this.txtCas2);
            this.groupBox1.Controls.Add(this.bsslabel2);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.bsslabel1);
            this.groupBox1.Controls.Add(this.txtSaat);
            this.groupBox1.Controls.Add(this.groupBoxBase1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DatumDo);
            this.groupBox1.Controls.Add(this.datumOd);
            this.groupBox1.Controls.Add(this.btnPotvrdi1);
            this.groupBox1.Controls.Add(this.btnPecati1);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датум на почеток до :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 17);
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
            this.DatumDo.Location = new System.Drawing.Point(585, 35);
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
            this.datumOd.Location = new System.Drawing.Point(371, 35);
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(233, 172);
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
            this.gridControl1.DataSource = this.potroseniMaterijaliZaPeriodBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(6, 251);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(801, 319);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // potroseniMaterijaliZaPeriodBindingSource
            // 
            this.potroseniMaterijaliZaPeriodBindingSource.DataMember = "PotroseniMaterijaliZaPeriod";
            this.potroseniMaterijaliZaPeriodBindingSource.DataSource = this.bSSRDataSet;
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
            this.colID,
            this.colNaziv,
            this.coltblArtikalID,
            this.colKolicinaIzlez,
            this.colKolicinaPoMerkaIzlez,
            this.colEdinecnaMerkaIzlez,
            this.colDatumNaPocetok,
            this.colDatumNaKnizenje,
            this.colNabavnaCena,
            this.colIznosBezDDV,
            this.colIznosDDV,
            this.colIznosSoDDV,
            this.coltipNaKnizenje,
            this.colNabavenIznosBezDDV});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Artikal", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", null, "")});
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
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив на артикал";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Naziv", "{0}")});
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 0;
            // 
            // coltblArtikalID
            // 
            this.coltblArtikalID.Caption = "Реден број на артикал";
            this.coltblArtikalID.FieldName = "tblArtikalID";
            this.coltblArtikalID.Name = "coltblArtikalID";
            // 
            // colKolicinaIzlez
            // 
            this.colKolicinaIzlez.Caption = "Количина излез";
            this.colKolicinaIzlez.FieldName = "KolicinaIzlez";
            this.colKolicinaIzlez.Name = "colKolicinaIzlez";
            this.colKolicinaIzlez.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KolicinaIzlez", "{0:0.##}")});
            this.colKolicinaIzlez.Visible = true;
            this.colKolicinaIzlez.VisibleIndex = 1;
            // 
            // colKolicinaPoMerkaIzlez
            // 
            this.colKolicinaPoMerkaIzlez.Caption = "Количина по мерка излез";
            this.colKolicinaPoMerkaIzlez.FieldName = "KolicinaPoMerkaIzlez";
            this.colKolicinaPoMerkaIzlez.Name = "colKolicinaPoMerkaIzlez";
            this.colKolicinaPoMerkaIzlez.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KolicinaPoMerkaIzlez", "{0:0.##}")});
            // 
            // colEdinecnaMerkaIzlez
            // 
            this.colEdinecnaMerkaIzlez.Caption = "Единечна мерка излез";
            this.colEdinecnaMerkaIzlez.FieldName = "EdinecnaMerkaIzlez";
            this.colEdinecnaMerkaIzlez.Name = "colEdinecnaMerkaIzlez";
            this.colEdinecnaMerkaIzlez.Visible = true;
            this.colEdinecnaMerkaIzlez.VisibleIndex = 2;
            // 
            // colDatumNaPocetok
            // 
            this.colDatumNaPocetok.Caption = "Датум на почеток";
            this.colDatumNaPocetok.FieldName = "DatumNaPocetok";
            this.colDatumNaPocetok.Name = "colDatumNaPocetok";
            // 
            // colDatumNaKnizenje
            // 
            this.colDatumNaKnizenje.Caption = "Датум на книжење";
            this.colDatumNaKnizenje.FieldName = "DatumNaKnizenje";
            this.colDatumNaKnizenje.Name = "colDatumNaKnizenje";
            // 
            // colNabavnaCena
            // 
            this.colNabavnaCena.Caption = "Набавна цена";
            this.colNabavnaCena.FieldName = "NabavnaCena";
            this.colNabavnaCena.Name = "colNabavnaCena";
            this.colNabavnaCena.Visible = true;
            this.colNabavnaCena.VisibleIndex = 3;
            // 
            // colIznosBezDDV
            // 
            this.colIznosBezDDV.Caption = "Износ без ДДВ";
            this.colIznosBezDDV.FieldName = "IznosBezDDV";
            this.colIznosBezDDV.Name = "colIznosBezDDV";
            this.colIznosBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IznosBezDDV", "{0:0.##}")});
            // 
            // colIznosDDV
            // 
            this.colIznosDDV.Caption = "Износ  ДДВ";
            this.colIznosDDV.FieldName = "IznosDDV";
            this.colIznosDDV.Name = "colIznosDDV";
            // 
            // colIznosSoDDV
            // 
            this.colIznosSoDDV.Caption = "Износ со ДДВ";
            this.colIznosSoDDV.FieldName = "IznosSoDDV";
            this.colIznosSoDDV.Name = "colIznosSoDDV";
            // 
            // coltipNaKnizenje
            // 
            this.coltipNaKnizenje.Caption = "Тип на книжење";
            this.coltipNaKnizenje.FieldName = "tipNaKnizenje";
            this.coltipNaKnizenje.Name = "coltipNaKnizenje";
            // 
            // colNabavenIznosBezDDV
            // 
            this.colNabavenIznosBezDDV.Caption = "Износ";
            this.colNabavenIznosBezDDV.FieldName = "NabavenIznosBezDDV";
            this.colNabavenIznosBezDDV.Name = "colNabavenIznosBezDDV";
            this.colNabavenIznosBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NabavenIznosBezDDV", "{0:0.##}")});
            this.colNabavenIznosBezDDV.Visible = true;
            this.colNabavenIznosBezDDV.VisibleIndex = 4;
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
            // potroseniMaterijaliZaPeriodTableAdapter
            // 
            this.potroseniMaterijaliZaPeriodTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.rbtnNesocuvani);
            this.groupBoxBase1.Controls.Add(this.rbtnSocuvani);
            this.groupBoxBase1.Controls.Add(this.rbtnSite);
            this.groupBoxBase1.Location = new System.Drawing.Point(4, 7);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(346, 56);
            this.groupBoxBase1.TabIndex = 25;
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
            this.bsslabel3.Location = new System.Drawing.Point(652, 213);
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
            this.txtMin2.Location = new System.Drawing.Point(702, 211);
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
            this.bsslabel4.Location = new System.Drawing.Point(583, 213);
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
            this.txtCas2.Location = new System.Drawing.Point(616, 211);
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
            this.bsslabel2.Location = new System.Drawing.Point(437, 213);
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
            this.txtMin.Location = new System.Drawing.Point(487, 211);
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
            this.bsslabel1.Location = new System.Drawing.Point(368, 213);
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
            this.txtSaat.Location = new System.Drawing.Point(401, 211);
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
            // frmPotroseniMaterijali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 570);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPotroseniMaterijali";
            this.Text = "Потрошени материјали";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potroseniMaterijaliZaPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
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
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private System.Windows.Forms.BindingSource potroseniMaterijaliZaPeriodBindingSource;
        private BSSRDataSet bSSRDataSet;
		private BSSRDataSetTableAdapters.PotroseniMaterijaliZaPeriodTableAdapter potroseniMaterijaliZaPeriodTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn coltblArtikalID;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicinaIzlez;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicinaPoMerkaIzlez;
        private DevExpress.XtraGrid.Columns.GridColumn colEdinecnaMerkaIzlez;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaPocetok;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaKnizenje;
        private DevExpress.XtraGrid.Columns.GridColumn colNabavnaCena;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosSoDDV;
        private DevExpress.XtraGrid.Columns.GridColumn coltipNaKnizenje;
        private DevExpress.XtraGrid.Columns.GridColumn colNabavenIznosBezDDV;
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.RadioButton rbtnNesocuvani;
        private System.Windows.Forms.RadioButton rbtnSocuvani;
        private System.Windows.Forms.RadioButton rbtnSite;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.txtBase txtMin2;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.txtBase txtCas2;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.txtBase txtMin;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.txtBase txtSaat;
    }
}
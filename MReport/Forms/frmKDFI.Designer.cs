namespace MReport.Forms
{
    partial class frmKDFI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKDFI));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.gridControl1 = new BssBase.DevGrid();
            this.dnevenPrometKDFIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRbr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMKDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMKDDVIznos0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMKDDVIznos18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMKDDVIznos5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMKIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dnevenPrometKDFITableAdapter = new MReport.BSSRDataSetTableAdapters.DnevenPrometKDFITableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevenPrometKDFIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DatumDo);
            this.groupBox1.Controls.Add(this.datumOd);
            this.groupBox1.Controls.Add(this.btnPotvrdi1);
            this.groupBox1.Controls.Add(this.btnPecati1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датум на почеток до :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 17);
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
            this.DatumDo.Location = new System.Drawing.Point(576, 35);
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
            this.datumOd.Location = new System.Drawing.Point(362, 35);
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(224, 172);
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
            this.gridControl1.DataSource = this.dnevenPrometKDFIBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(-2, 261);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(801, 335);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dnevenPrometKDFIBindingSource
            // 
            this.dnevenPrometKDFIBindingSource.DataMember = "DnevenPrometKDFI";
            this.dnevenPrometKDFIBindingSource.DataSource = this.bSSRDataSet;
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
            this.colRbr,
            this.colDen,
            this.colIznos,
            this.colIznos0,
            this.colIznos5,
            this.colIznos18,
            this.colDDVIznos,
            this.colDDVIznos0,
            this.colDDVIznos5,
            this.colDDVIznos18,
            this.colMKDDVIznos,
            this.colMKDDVIznos0,
            this.colMKDDVIznos18,
            this.colMKDDVIznos5,
            this.colMKIznos});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
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
            // colRbr
            // 
            this.colRbr.Caption = "Реден број";
            this.colRbr.FieldName = "Rbr";
            this.colRbr.Name = "colRbr";
            this.colRbr.OptionsColumn.ReadOnly = true;
            this.colRbr.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Rbr", "{0}")});
            this.colRbr.Visible = true;
            this.colRbr.VisibleIndex = 0;
            // 
            // colDen
            // 
            this.colDen.Caption = "Датум";
            this.colDen.FieldName = "Den";
            this.colDen.Name = "colDen";
            this.colDen.Visible = true;
            this.colDen.VisibleIndex = 1;
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Вкупен промет во тековниот ден";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.OptionsColumn.ReadOnly = true;
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "{0:0.##}")});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 10;
            // 
            // colIznos0
            // 
            this.colIznos0.Caption = "Вкупен промет 0%";
            this.colIznos0.FieldName = "Iznos0";
            this.colIznos0.Name = "colIznos0";
            this.colIznos0.OptionsColumn.ReadOnly = true;
            this.colIznos0.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos0", "{0:0.##}")});
            this.colIznos0.Visible = true;
            this.colIznos0.VisibleIndex = 7;
            // 
            // colIznos5
            // 
            this.colIznos5.Caption = "Вкупен промет 5%";
            this.colIznos5.FieldName = "Iznos5";
            this.colIznos5.Name = "colIznos5";
            this.colIznos5.OptionsColumn.ReadOnly = true;
            this.colIznos5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos5", "{0:0.##}")});
            this.colIznos5.Visible = true;
            this.colIznos5.VisibleIndex = 8;
            // 
            // colIznos18
            // 
            this.colIznos18.Caption = "Вкупен промет 18%";
            this.colIznos18.FieldName = "Iznos18";
            this.colIznos18.Name = "colIznos18";
            this.colIznos18.OptionsColumn.ReadOnly = true;
            this.colIznos18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos18", "{0:0.##}")});
            this.colIznos18.Visible = true;
            this.colIznos18.VisibleIndex = 9;
            // 
            // colDDVIznos
            // 
            this.colDDVIznos.Caption = "Вкупен износ на ДДВ во тековниот ден";
            this.colDDVIznos.FieldName = "DDVIznos";
            this.colDDVIznos.Name = "colDDVIznos";
            this.colDDVIznos.OptionsColumn.ReadOnly = true;
            this.colDDVIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DDVIznos", "{0:0.##}")});
            this.colDDVIznos.Visible = true;
            this.colDDVIznos.VisibleIndex = 14;
            // 
            // colDDVIznos0
            // 
            this.colDDVIznos0.Caption = "ДДВ Износ 0%";
            this.colDDVIznos0.FieldName = "DDVIznos0";
            this.colDDVIznos0.Name = "colDDVIznos0";
            this.colDDVIznos0.OptionsColumn.ReadOnly = true;
            this.colDDVIznos0.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DDVIznos0", "{0:0.##}")});
            this.colDDVIznos0.Visible = true;
            this.colDDVIznos0.VisibleIndex = 11;
            // 
            // colDDVIznos5
            // 
            this.colDDVIznos5.Caption = "ДДВ Износ 5%";
            this.colDDVIznos5.FieldName = "DDVIznos5";
            this.colDDVIznos5.Name = "colDDVIznos5";
            this.colDDVIznos5.OptionsColumn.ReadOnly = true;
            this.colDDVIznos5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DDVIznos5", "{0:0.##}")});
            this.colDDVIznos5.Visible = true;
            this.colDDVIznos5.VisibleIndex = 12;
            // 
            // colDDVIznos18
            // 
            this.colDDVIznos18.Caption = "ДДВ Износ 18%";
            this.colDDVIznos18.FieldName = "DDVIznos18";
            this.colDDVIznos18.Name = "colDDVIznos18";
            this.colDDVIznos18.OptionsColumn.ReadOnly = true;
            this.colDDVIznos18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DDVIznos18", "{0:0.##}")});
            this.colDDVIznos18.Visible = true;
            this.colDDVIznos18.VisibleIndex = 13;
            // 
            // colMKDDVIznos
            // 
            this.colMKDDVIznos.Caption = "Вкупен износ на данок од МК производи";
            this.colMKDDVIznos.FieldName = "MKDDVIznos";
            this.colMKDDVIznos.Name = "colMKDDVIznos";
            this.colMKDDVIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MKDDVIznos", "{0:0.##}")});
            this.colMKDDVIznos.Visible = true;
            this.colMKDDVIznos.VisibleIndex = 6;
            // 
            // colMKDDVIznos0
            // 
            this.colMKDDVIznos0.Caption = "ДДВ Износ 0% од МК Производи";
            this.colMKDDVIznos0.FieldName = "MKDDVIznos0";
            this.colMKDDVIznos0.Name = "colMKDDVIznos0";
            this.colMKDDVIznos0.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MKDDVIznos0", "{0:0.##}")});
            this.colMKDDVIznos0.Visible = true;
            this.colMKDDVIznos0.VisibleIndex = 3;
            // 
            // colMKDDVIznos18
            // 
            this.colMKDDVIznos18.Caption = "ДДВ Износ 18% од МК Производи";
            this.colMKDDVIznos18.FieldName = "MKDDVIznos18";
            this.colMKDDVIznos18.Name = "colMKDDVIznos18";
            this.colMKDDVIznos18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MKDDVIznos18", "{0:0.##}")});
            this.colMKDDVIznos18.Visible = true;
            this.colMKDDVIznos18.VisibleIndex = 5;
            // 
            // colMKDDVIznos5
            // 
            this.colMKDDVIznos5.Caption = "ДДВ Износ 5% од МК Производи";
            this.colMKDDVIznos5.FieldName = "MKDDVIznos5";
            this.colMKDDVIznos5.Name = "colMKDDVIznos5";
            this.colMKDDVIznos5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MKDDVIznos5", "{0:0.##}")});
            this.colMKDDVIznos5.Visible = true;
            this.colMKDDVIznos5.VisibleIndex = 4;
            // 
            // colMKIznos
            // 
            this.colMKIznos.Caption = "Вкупен промет од МК производи";
            this.colMKIznos.FieldName = "MKIznos";
            this.colMKIznos.Name = "colMKIznos";
            this.colMKIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MKIznos", "{0:0.##}")});
            this.colMKIznos.Visible = true;
            this.colMKIznos.VisibleIndex = 2;
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
            // dnevenPrometKDFITableAdapter
            // 
            this.dnevenPrometKDFITableAdapter.ClearBeforeFill = true;
            // 
            // frmKDFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 601);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKDFI";
            this.Text = "frmKDFI";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevenPrometKDFIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private System.Windows.Forms.BindingSource dnevenPrometKDFIBindingSource;
        private BSSRDataSet bSSRDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colRbr;
        private DevExpress.XtraGrid.Columns.GridColumn colDen;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos0;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos5;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos18;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos0;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos5;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos18;
        private BSSRDataSetTableAdapters.DnevenPrometKDFITableAdapter dnevenPrometKDFITableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMKDDVIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colMKDDVIznos0;
        private DevExpress.XtraGrid.Columns.GridColumn colMKDDVIznos18;
        private DevExpress.XtraGrid.Columns.GridColumn colMKDDVIznos5;
        private DevExpress.XtraGrid.Columns.GridColumn colMKIznos;
    }
}
namespace MMaterijalno.Reporti
{
    partial class frmPregledNaSiteSmetkiGrupirani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNaSiteSmetkiGrupirani));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.gridControl1 = new BssBase.DevGrid();
            this.pregledNaSiteSmetkiBindingSource = new System.Windows.Forms.BindingSource();
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPresmetkovnaEdinica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumPocetok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezultat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPresMin = new BssBase.txtBase();
            this.txtPresMax = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.bsslabel4 = new BssBase.Elements.Bsslabel();
            this.txtMaticenMax = new BssBase.txtBase();
            this.txtMaticenMin = new BssBase.txtBase();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.bsslabel6 = new BssBase.Elements.Bsslabel();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.pregledNaSiteSmetkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.PregledNaSiteSmetkiTableAdapter();
            this.btnPotvrdi2 = new BssBase.Elements.btnPotvrdi();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNaSiteSmetkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Износ";
            this.gridColumn8.FieldName = "Iznos";
            this.gridColumn8.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "{0:0.##}", ((short)(0)))});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Датум на почеток до :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Датум на почеток од :";
            // 
            // DatumDo
            // 
            this.DatumDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatumDo.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.DatumDo.HotDate = null;
            this.DatumDo.Location = new System.Drawing.Point(720, 44);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.CellPadding = new System.Windows.Forms.Padding(2);
            this.DatumDo.Size = new System.Drawing.Size(208, 175);
            this.DatumDo.TabIndex = 37;
            // 
            // datumOd
            // 
            this.datumOd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumOd.DateTime = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            this.datumOd.HotDate = null;
            this.datumOd.Location = new System.Drawing.Point(506, 44);
            this.datumOd.Name = "datumOd";
            this.datumOd.CellPadding = new System.Windows.Forms.Padding(2);
            this.datumOd.Size = new System.Drawing.Size(208, 175);
            this.datumOd.TabIndex = 36;
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(368, 181);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.TabIndex = 35;
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
            this.btnPecati1.Location = new System.Drawing.Point(0, 181);
            this.btnPecati1.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.Name = "btnPecati1";
            this.btnPecati1.Size = new System.Drawing.Size(132, 38);
            this.btnPecati1.TabIndex = 34;
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
            this.gridControl1.DataSource = this.pregledNaSiteSmetkiBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(0, 252);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(940, 381);
            this.gridControl1.TabIndex = 40;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.cardView1});
            // 
            // pregledNaSiteSmetkiBindingSource
            // 
            this.pregledNaSiteSmetkiBindingSource.DataMember = "PregledNaSiteSmetki";
            this.pregledNaSiteSmetkiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colPresmetkovnaEdinica,
            this.colPartner,
            this.colIznos,
            this.colEDB,
            this.colDatumPocetok,
            this.colRezultat});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", null, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "EDB", null, "{0:0.##}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // colPresmetkovnaEdinica
            // 
            this.colPresmetkovnaEdinica.Caption = "Пресметковна единица";
            this.colPresmetkovnaEdinica.FieldName = "PresmetkovnaEdinica";
            this.colPresmetkovnaEdinica.Name = "colPresmetkovnaEdinica";
            this.colPresmetkovnaEdinica.Visible = true;
            this.colPresmetkovnaEdinica.VisibleIndex = 1;
            // 
            // colPartner
            // 
            this.colPartner.Caption = "Партнер";
            this.colPartner.FieldName = "Partner";
            this.colPartner.Name = "colPartner";
            this.colPartner.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Partner", "{0}")});
            this.colPartner.Visible = true;
            this.colPartner.VisibleIndex = 0;
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", "{0:0.##}")});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 3;
            // 
            // colEDB
            // 
            this.colEDB.Caption = "ЕДВ";
            this.colEDB.FieldName = "EDB";
            this.colEDB.Name = "colEDB";
            this.colEDB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EDB", "{0}")});
            this.colEDB.Visible = true;
            this.colEDB.VisibleIndex = 2;
            // 
            // colDatumPocetok
            // 
            this.colDatumPocetok.Caption = "Датум";
            this.colDatumPocetok.FieldName = "DatumPocetok";
            this.colDatumPocetok.Name = "colDatumPocetok";
            // 
            // colRezultat
            // 
            this.colRezultat.Caption = "Резултат";
            this.colRezultat.FieldName = "Rezultat";
            this.colRezultat.Name = "colRezultat";
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
            // cardView1
            // 
            this.cardView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.cardView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.cardView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cardView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.cardView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.cardView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.cardView1.FocusedCardTopFieldIndex = 0;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.gridColumn8;
            this.cardView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.GroupCount = 1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsPrint.PrintFilterInfo = true;
            this.cardView1.OptionsPrint.UsePrintStyles = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Вработен";
            this.gridColumn7.FieldName = "FullName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // txtPresMin
            // 
            this.txtPresMin.AssemblyStr = null;
            this.txtPresMin.C_FillWithZeros = false;
            this.txtPresMin.C_OnlyNumbers = false;
            this.txtPresMin.C_RegEx = false;
            this.txtPresMin.C_ShowRedOnLeaveIfEmpty = false;
            this.txtPresMin.ColumnName1 = null;
            this.txtPresMin.ColumnName2 = null;
            this.txtPresMin.ColumnName3 = null;
            this.txtPresMin.ColumnName4 = null;
            this.txtPresMin.ColumnName5 = null;
            this.txtPresMin.ColumnName6 = null;
            this.txtPresMin.ColumnName7 = null;
            this.txtPresMin.daliCetiri = false;
            this.txtPresMin.Format = null;
            this.txtPresMin.formToOpen = null;
            this.txtPresMin.iscistiGreenNaLeave = false;
            this.txtPresMin.KoristiFilterNaDatasource = false;
            this.txtPresMin.Location = new System.Drawing.Point(45, 34);
            this.txtPresMin.MakedonskiJazik = false;
            this.txtPresMin.MinLength = 0;
            this.txtPresMin.Name = "txtPresMin";
            this.txtPresMin.PopulateOtherFields = false;
            this.txtPresMin.regularExpression = null;
            this.txtPresMin.SelektrijaNaFokus = false;
            this.txtPresMin.Size = new System.Drawing.Size(100, 20);
            this.txtPresMin.TabIndex = 41;
            // 
            // txtPresMax
            // 
            this.txtPresMax.AssemblyStr = null;
            this.txtPresMax.C_FillWithZeros = false;
            this.txtPresMax.C_OnlyNumbers = false;
            this.txtPresMax.C_RegEx = false;
            this.txtPresMax.C_ShowRedOnLeaveIfEmpty = false;
            this.txtPresMax.ColumnName1 = null;
            this.txtPresMax.ColumnName2 = null;
            this.txtPresMax.ColumnName3 = null;
            this.txtPresMax.ColumnName4 = null;
            this.txtPresMax.ColumnName5 = null;
            this.txtPresMax.ColumnName6 = null;
            this.txtPresMax.ColumnName7 = null;
            this.txtPresMax.daliCetiri = false;
            this.txtPresMax.Format = null;
            this.txtPresMax.formToOpen = null;
            this.txtPresMax.iscistiGreenNaLeave = false;
            this.txtPresMax.KoristiFilterNaDatasource = false;
            this.txtPresMax.Location = new System.Drawing.Point(194, 34);
            this.txtPresMax.MakedonskiJazik = false;
            this.txtPresMax.MinLength = 0;
            this.txtPresMax.Name = "txtPresMax";
            this.txtPresMax.PopulateOtherFields = false;
            this.txtPresMax.regularExpression = null;
            this.txtPresMax.SelektrijaNaFokus = false;
            this.txtPresMax.Size = new System.Drawing.Size(100, 20);
            this.txtPresMax.TabIndex = 42;
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(15, 37);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(24, 13);
            this.bsslabel1.TabIndex = 43;
            this.bsslabel1.Text = "Од:";
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(15, 92);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(24, 13);
            this.bsslabel2.TabIndex = 44;
            this.bsslabel2.Text = "Од:";
            // 
            // bsslabel3
            // 
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Location = new System.Drawing.Point(163, 95);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(25, 13);
            this.bsslabel3.TabIndex = 45;
            this.bsslabel3.Text = "До:";
            // 
            // bsslabel4
            // 
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Location = new System.Drawing.Point(163, 37);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(25, 13);
            this.bsslabel4.TabIndex = 46;
            this.bsslabel4.Text = "До:";
            // 
            // txtMaticenMax
            // 
            this.txtMaticenMax.AssemblyStr = null;
            this.txtMaticenMax.C_FillWithZeros = false;
            this.txtMaticenMax.C_OnlyNumbers = false;
            this.txtMaticenMax.C_RegEx = false;
            this.txtMaticenMax.C_ShowRedOnLeaveIfEmpty = false;
            this.txtMaticenMax.ColumnName1 = null;
            this.txtMaticenMax.ColumnName2 = null;
            this.txtMaticenMax.ColumnName3 = null;
            this.txtMaticenMax.ColumnName4 = null;
            this.txtMaticenMax.ColumnName5 = null;
            this.txtMaticenMax.ColumnName6 = null;
            this.txtMaticenMax.ColumnName7 = null;
            this.txtMaticenMax.daliCetiri = false;
            this.txtMaticenMax.Format = null;
            this.txtMaticenMax.formToOpen = null;
            this.txtMaticenMax.iscistiGreenNaLeave = false;
            this.txtMaticenMax.KoristiFilterNaDatasource = false;
            this.txtMaticenMax.Location = new System.Drawing.Point(194, 88);
            this.txtMaticenMax.MakedonskiJazik = false;
            this.txtMaticenMax.MinLength = 0;
            this.txtMaticenMax.Name = "txtMaticenMax";
            this.txtMaticenMax.PopulateOtherFields = false;
            this.txtMaticenMax.regularExpression = null;
            this.txtMaticenMax.SelektrijaNaFokus = false;
            this.txtMaticenMax.Size = new System.Drawing.Size(100, 20);
            this.txtMaticenMax.TabIndex = 48;
            // 
            // txtMaticenMin
            // 
            this.txtMaticenMin.AssemblyStr = null;
            this.txtMaticenMin.C_FillWithZeros = false;
            this.txtMaticenMin.C_OnlyNumbers = false;
            this.txtMaticenMin.C_RegEx = false;
            this.txtMaticenMin.C_ShowRedOnLeaveIfEmpty = false;
            this.txtMaticenMin.ColumnName1 = null;
            this.txtMaticenMin.ColumnName2 = null;
            this.txtMaticenMin.ColumnName3 = null;
            this.txtMaticenMin.ColumnName4 = null;
            this.txtMaticenMin.ColumnName5 = null;
            this.txtMaticenMin.ColumnName6 = null;
            this.txtMaticenMin.ColumnName7 = null;
            this.txtMaticenMin.daliCetiri = false;
            this.txtMaticenMin.Format = null;
            this.txtMaticenMin.formToOpen = null;
            this.txtMaticenMin.iscistiGreenNaLeave = false;
            this.txtMaticenMin.KoristiFilterNaDatasource = false;
            this.txtMaticenMin.Location = new System.Drawing.Point(45, 88);
            this.txtMaticenMin.MakedonskiJazik = false;
            this.txtMaticenMin.MinLength = 0;
            this.txtMaticenMin.Name = "txtMaticenMin";
            this.txtMaticenMin.PopulateOtherFields = false;
            this.txtMaticenMin.regularExpression = null;
            this.txtMaticenMin.SelektrijaNaFokus = false;
            this.txtMaticenMin.Size = new System.Drawing.Size(100, 20);
            this.txtMaticenMin.TabIndex = 47;
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.bsslabel6);
            this.groupBoxBase1.Controls.Add(this.bsslabel5);
            this.groupBoxBase1.Controls.Add(this.txtMaticenMax);
            this.groupBoxBase1.Controls.Add(this.txtPresMin);
            this.groupBoxBase1.Controls.Add(this.txtMaticenMin);
            this.groupBoxBase1.Controls.Add(this.txtPresMax);
            this.groupBoxBase1.Controls.Add(this.bsslabel4);
            this.groupBoxBase1.Controls.Add(this.bsslabel1);
            this.groupBoxBase1.Controls.Add(this.bsslabel3);
            this.groupBoxBase1.Controls.Add(this.bsslabel2);
            this.groupBoxBase1.Location = new System.Drawing.Point(12, 29);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(308, 131);
            this.groupBoxBase1.TabIndex = 49;
            this.groupBoxBase1.TabStop = false;
            // 
            // bsslabel6
            // 
            this.bsslabel6.AutoSize = true;
            this.bsslabel6.Location = new System.Drawing.Point(6, 68);
            this.bsslabel6.Name = "bsslabel6";
            this.bsslabel6.Size = new System.Drawing.Size(73, 13);
            this.bsslabel6.TabIndex = 50;
            this.bsslabel6.Text = "Матичен број";
            // 
            // bsslabel5
            // 
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Location = new System.Drawing.Point(6, 16);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(127, 13);
            this.bsslabel5.TabIndex = 49;
            this.bsslabel5.Text = "Пресметковна единица";
            // 
            // pregledNaSiteSmetkiTableAdapter
            // 
            this.pregledNaSiteSmetkiTableAdapter.ClearBeforeFill = true;
            // 
            // btnPotvrdi2
            // 
            this.btnPotvrdi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi2.Image = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi2.Image")));
            this.btnPotvrdi2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi2.Location = new System.Drawing.Point(146, 181);
            this.btnPotvrdi2.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi2.Name = "btnPotvrdi2";
            this.btnPotvrdi2.Size = new System.Drawing.Size(216, 38);
            this.btnPotvrdi2.TabIndex = 50;
            this.btnPotvrdi2.Text = "Прикажи само трета смена";
            this.btnPotvrdi2.UseVisualStyleBackColor = false;
            this.btnPotvrdi2.Click += new System.EventHandler(this.btnPotvrdi2_Click);
            // 
            // frmPregledNaSiteSmetkiGrupirani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 633);
            this.Controls.Add(this.btnPotvrdi2);
            this.Controls.Add(this.groupBoxBase1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.btnPotvrdi1);
            this.Controls.Add(this.btnPecati1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPregledNaSiteSmetkiGrupirani";
            this.Text = "Преглед на сметки по пресметковна единица Групирани";
            this.Load += new System.EventHandler(this.frmPregledNaSmetkiPoPartner_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.btnPecati1, 0);
            this.Controls.SetChildIndex(this.btnPotvrdi1, 0);
            this.Controls.SetChildIndex(this.datumOd, 0);
            this.Controls.SetChildIndex(this.DatumDo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupBoxBase1, 0);
            this.Controls.SetChildIndex(this.btnPotvrdi2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNaSiteSmetkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraScheduler.DateNavigator DatumDo;
        private DevExpress.XtraScheduler.DateNavigator datumOd;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPecati btnPecati1;
        private BssBase.DevGrid gridControl1;
        private MaterijalnoDataSet materijalnoDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private BssBase.txtBase txtPresMin;
        private BssBase.txtBase txtPresMax;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.txtBase txtMaticenMax;
        private BssBase.txtBase txtMaticenMin;
        private BssBase.groupBoxBase groupBoxBase1;
        private BssBase.Elements.Bsslabel bsslabel6;
        private BssBase.Elements.Bsslabel bsslabel5;
        private System.Windows.Forms.BindingSource pregledNaSiteSmetkiBindingSource;
        private MaterijalnoDataSetTableAdapters.PregledNaSiteSmetkiTableAdapter pregledNaSiteSmetkiTableAdapter;
        private BssBase.Elements.btnPotvrdi btnPotvrdi2;
        private DevExpress.XtraGrid.Columns.GridColumn colPresmetkovnaEdinica;
        private DevExpress.XtraGrid.Columns.GridColumn colPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colEDB;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumPocetok;
        private DevExpress.XtraGrid.Columns.GridColumn colRezultat;
    }
}
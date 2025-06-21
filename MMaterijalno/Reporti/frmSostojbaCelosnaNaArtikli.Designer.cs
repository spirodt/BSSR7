namespace MMaterijalno.Reporti
{
    partial class frmSostojbaCelosnaNaArtikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSostojbaCelosnaNaArtikli));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.gridControl1 = new BssBase.DevGrid();
            this.viewZalihaCelosnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltblArtikalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdinecnaMerkaVlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdinecnaMerkaIzlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIzdadenaKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicinaIzlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicinaVlez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicinaZaliha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaKnizenje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltSifraArtikal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreostanataKolicinaNaZaliha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewZalihaCelosnaTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewZalihaCelosnaTableAdapter();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZalihaCelosnaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPotvrdi1);
            this.groupBox1.Controls.Add(this.btnPecati1);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(836, 19);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.TabIndex = 1;
            this.btnPotvrdi1.Text = "Прикажи";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Visible = false;
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
            this.btnPecati1.Location = new System.Drawing.Point(6, 19);
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
            this.gridControl1.DataSource = this.viewZalihaCelosnaBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(2, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(976, 546);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // viewZalihaCelosnaBindingSource
            // 
            this.viewZalihaCelosnaBindingSource.DataMember = "viewZalihaCelosna";
            this.viewZalihaCelosnaBindingSource.DataSource = this.materijalnoDataSet;
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
            this.coltblArtikalID,
            this.colNaziv,
            this.colProdaznaCena,
            this.colEdinecnaMerkaVlez,
            this.colEdinecnaMerkaIzlez,
            this.colIzdadenaKolicina,
            this.colKolicinaIzlez,
            this.colKolicinaVlez,
            this.colKolicinaZaliha,
            this.colDatumNaKnizenje,
            this.colPartner,
            this.colAltSifraArtikal,
            this.colPreostanataKolicinaNaZaliha,
            this.colSifra});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IznosSoDDV", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IznosBezDDV", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "DDVIznos", null, "")});
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // coltblArtikalID
            // 
            this.coltblArtikalID.Caption = "Реден број на артикал";
            this.coltblArtikalID.FieldName = "tblArtikalID";
            this.coltblArtikalID.Name = "coltblArtikalID";
            this.coltblArtikalID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Називна артикал";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Naziv", "{0}")});
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 2;
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Продажна цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            this.colProdaznaCena.Visible = true;
            this.colProdaznaCena.VisibleIndex = 3;
            // 
            // colEdinecnaMerkaVlez
            // 
            this.colEdinecnaMerkaVlez.Caption = "Единечна мерка влез";
            this.colEdinecnaMerkaVlez.FieldName = "EdinecnaMerkaVlez";
            this.colEdinecnaMerkaVlez.Name = "colEdinecnaMerkaVlez";
            this.colEdinecnaMerkaVlez.Visible = true;
            this.colEdinecnaMerkaVlez.VisibleIndex = 7;
            // 
            // colEdinecnaMerkaIzlez
            // 
            this.colEdinecnaMerkaIzlez.Caption = "Единечна мерка излез";
            this.colEdinecnaMerkaIzlez.FieldName = "EdinecnaMerkaIzlez";
            this.colEdinecnaMerkaIzlez.Name = "colEdinecnaMerkaIzlez";
            this.colEdinecnaMerkaIzlez.Visible = true;
            this.colEdinecnaMerkaIzlez.VisibleIndex = 9;
            // 
            // colIzdadenaKolicina
            // 
            this.colIzdadenaKolicina.Caption = "Издадена количина";
            this.colIzdadenaKolicina.FieldName = "IzdadenaKolicina";
            this.colIzdadenaKolicina.Name = "colIzdadenaKolicina";
            this.colIzdadenaKolicina.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IzdadenaKolicina", "{0:0.##}")});
            this.colIzdadenaKolicina.Visible = true;
            this.colIzdadenaKolicina.VisibleIndex = 8;
            // 
            // colKolicinaIzlez
            // 
            this.colKolicinaIzlez.Caption = "Количина Излез";
            this.colKolicinaIzlez.FieldName = "KolicinaIzlez";
            this.colKolicinaIzlez.Name = "colKolicinaIzlez";
            this.colKolicinaIzlez.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KolicinaIzlez", "Излез={0:0.##}")});
            this.colKolicinaIzlez.Visible = true;
            this.colKolicinaIzlez.VisibleIndex = 5;
            // 
            // colKolicinaVlez
            // 
            this.colKolicinaVlez.Caption = "Количина влез";
            this.colKolicinaVlez.FieldName = "KolicinaVlez";
            this.colKolicinaVlez.Name = "colKolicinaVlez";
            this.colKolicinaVlez.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KolicinaVlez", "Влез={0:0.##}")});
            this.colKolicinaVlez.Visible = true;
            this.colKolicinaVlez.VisibleIndex = 4;
            // 
            // colKolicinaZaliha
            // 
            this.colKolicinaZaliha.Caption = "Количина на залиха";
            this.colKolicinaZaliha.FieldName = "KolicinaZaliha";
            this.colKolicinaZaliha.Name = "colKolicinaZaliha";
            this.colKolicinaZaliha.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KolicinaZaliha", "Залиха={0:0.##}")});
            this.colKolicinaZaliha.Visible = true;
            this.colKolicinaZaliha.VisibleIndex = 6;
            // 
            // colDatumNaKnizenje
            // 
            this.colDatumNaKnizenje.Caption = "Датум на книжење";
            this.colDatumNaKnizenje.FieldName = "DatumNaKnizenje";
            this.colDatumNaKnizenje.Name = "colDatumNaKnizenje";
            this.colDatumNaKnizenje.OptionsColumn.ReadOnly = true;
            // 
            // colPartner
            // 
            this.colPartner.Caption = "Партнер";
            this.colPartner.FieldName = "Partner";
            this.colPartner.Name = "colPartner";
            this.colPartner.Visible = true;
            this.colPartner.VisibleIndex = 1;
            // 
            // colAltSifraArtikal
            // 
            this.colAltSifraArtikal.Caption = "Алт.Шифра";
            this.colAltSifraArtikal.FieldName = "AltSifraArtikal";
            this.colAltSifraArtikal.Name = "colAltSifraArtikal";
            // 
            // colPreostanataKolicinaNaZaliha
            // 
            this.colPreostanataKolicinaNaZaliha.Caption = "Преостаната количина на залиха";
            this.colPreostanataKolicinaNaZaliha.FieldName = "PreostanataKolicinaNaZaliha";
            this.colPreostanataKolicinaNaZaliha.Name = "colPreostanataKolicinaNaZaliha";
            this.colPreostanataKolicinaNaZaliha.Visible = true;
            this.colPreostanataKolicinaNaZaliha.VisibleIndex = 10;
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
            // viewZalihaCelosnaTableAdapter
            // 
            this.viewZalihaCelosnaTableAdapter.ClearBeforeFill = true;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 0;
            // 
            // frmSostojbaCelosnaNaArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSostojbaCelosnaNaArtikli";
            this.Text = "Залиха на артикал";
            this.Load += new System.EventHandler(this.frmSostojbaCelosnaNaArtikli_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZalihaCelosnaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPecati btnPecati1;
        private BssBase.DevGrid gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource viewZalihaCelosnaBindingSource;
        private MaterijalnoDataSetTableAdapters.viewZalihaCelosnaTableAdapter viewZalihaCelosnaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coltblArtikalID;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
        private DevExpress.XtraGrid.Columns.GridColumn colEdinecnaMerkaVlez;
        private DevExpress.XtraGrid.Columns.GridColumn colEdinecnaMerkaIzlez;
        private DevExpress.XtraGrid.Columns.GridColumn colIzdadenaKolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicinaIzlez;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicinaVlez;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicinaZaliha;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaKnizenje;
        private DevExpress.XtraGrid.Columns.GridColumn colPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colAltSifraArtikal;
        private DevExpress.XtraGrid.Columns.GridColumn colPreostanataKolicinaNaZaliha;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
    }
}
namespace MReport.Forms
{
    partial class frmListaNaDolznici
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaNaDolznici));
            this.colTipNaDostava = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVkupnoDolzi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new BssBase.DevGrid();
            this.saldoPoDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVkupnoPlateno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALDO_Dolzi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALDO_Plateno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALDO_SVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZabeleski = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatumDo = new DevExpress.XtraScheduler.DateNavigator();
            this.datumOd = new DevExpress.XtraScheduler.DateNavigator();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPecati1 = new BssBase.Elements.btnPecati();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPotvrdi5 = new BssBase.Elements.btnPotvrdi();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchText = new BssBase.txtBase();
            this.btnPotvrdi4 = new BssBase.Elements.btnPotvrdi();
            this.btnPotvrdi3 = new BssBase.Elements.btnPotvrdi();
            this.btnPotvrdi2 = new BssBase.Elements.btnPotvrdi();
            this.txtInfo = new System.Windows.Forms.Label();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.zbxPartner = new BssBase.zbxBase();
            this.saldoPoDokumentTableAdapter = new MReport.BSSRDataSetTableAdapters.SaldoPoDokumentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoPoDokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd.CalendarTimeProperties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTipNaDostava
            // 
            this.colTipNaDostava.Caption = "Достава";
            this.colTipNaDostava.FieldName = "TipNaDostava";
            this.colTipNaDostava.Name = "colTipNaDostava";
            this.colTipNaDostava.OptionsColumn.AllowEdit = false;
            this.colTipNaDostava.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTipNaDostava.OptionsColumn.AllowMove = false;
            this.colTipNaDostava.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipNaDostava.Width = 77;
            // 
            // colVkupnoDolzi
            // 
            this.colVkupnoDolzi.Caption = "Вкупно должи";
            this.colVkupnoDolzi.FieldName = "VkupnoDolzi";
            this.colVkupnoDolzi.Name = "colVkupnoDolzi";
            this.colVkupnoDolzi.OptionsColumn.AllowEdit = false;
            this.colVkupnoDolzi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVkupnoDolzi.OptionsColumn.AllowMove = false;
            this.colVkupnoDolzi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVkupnoDolzi.Visible = true;
            this.colVkupnoDolzi.VisibleIndex = 2;
            this.colVkupnoDolzi.Width = 232;
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
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Вработен";
            this.gridColumn7.FieldName = "FullName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.AssemblyToLoad = null;
            this.gridControl1.DataSource = this.saldoPoDokumentBindingSource;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(0, 220);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1030, 262);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1,
            this.gridView2});
            // 
            // saldoPoDokumentBindingSource
            // 
            this.saldoPoDokumentBindingSource.DataMember = "SaldoPoDokument";
            this.saldoPoDokumentBindingSource.DataSource = this.bSSRDataSet;
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
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Transparent;
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
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
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
            this.colSifra,
            this.colNaziv,
            this.colVkupnoDolzi,
            this.colVkupnoPlateno,
            this.colSaldo,
            this.colTipNaDostava,
            this.colSALDO_Dolzi,
            this.colSALDO_Plateno,
            this.colSALDO_SVE,
            this.colZabeleski});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colTipNaDostava;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "-";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colVkupnoDolzi;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "Износ";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SALDO_Dolzi", null, "Должи:  {0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SALDO_Plateno", null, "Платено: {0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SALDO_SVE", null, "Салдо: {0:0.##}")});
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
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSifra, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsColumn.AllowMove = false;
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Партнер / Кат-Стан број:";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSifra.OptionsColumn.AllowMove = false;
            this.colSifra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 1;
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.MinWidth = 110;
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.OptionsColumn.AllowEdit = false;
            this.colNaziv.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNaziv.OptionsColumn.AllowMove = false;
            this.colNaziv.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 0;
            this.colNaziv.Width = 693;
            // 
            // colVkupnoPlateno
            // 
            this.colVkupnoPlateno.Caption = "Вкупно платено";
            this.colVkupnoPlateno.FieldName = "VkupnoPlateno";
            this.colVkupnoPlateno.Name = "colVkupnoPlateno";
            this.colVkupnoPlateno.OptionsColumn.AllowEdit = false;
            this.colVkupnoPlateno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVkupnoPlateno.OptionsColumn.AllowMove = false;
            this.colVkupnoPlateno.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVkupnoPlateno.Visible = true;
            this.colVkupnoPlateno.VisibleIndex = 3;
            this.colVkupnoPlateno.Width = 232;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Салдо";
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSaldo.OptionsColumn.AllowMove = false;
            this.colSaldo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 4;
            this.colSaldo.Width = 241;
            // 
            // colSALDO_Dolzi
            // 
            this.colSALDO_Dolzi.FieldName = "SALDO_Dolzi";
            this.colSALDO_Dolzi.Name = "colSALDO_Dolzi";
            this.colSALDO_Dolzi.OptionsColumn.AllowEdit = false;
            this.colSALDO_Dolzi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSALDO_Dolzi.OptionsColumn.AllowMove = false;
            this.colSALDO_Dolzi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSALDO_Dolzi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, DevExpress.Data.SummaryMode.Mixed, "SALDO_Dolzi", "{0:0.##}")});
            // 
            // colSALDO_Plateno
            // 
            this.colSALDO_Plateno.FieldName = "SALDO_Plateno";
            this.colSALDO_Plateno.Name = "colSALDO_Plateno";
            this.colSALDO_Plateno.OptionsColumn.AllowEdit = false;
            this.colSALDO_Plateno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSALDO_Plateno.OptionsColumn.AllowMove = false;
            this.colSALDO_Plateno.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSALDO_Plateno.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, DevExpress.Data.SummaryMode.Mixed, "SALDO_Plateno", "{0:0.##}")});
            // 
            // colSALDO_SVE
            // 
            this.colSALDO_SVE.FieldName = "SALDO_SVE";
            this.colSALDO_SVE.Name = "colSALDO_SVE";
            this.colSALDO_SVE.OptionsColumn.AllowEdit = false;
            this.colSALDO_SVE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSALDO_SVE.OptionsColumn.AllowMove = false;
            this.colSALDO_SVE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSALDO_SVE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, DevExpress.Data.SummaryMode.Mixed, "SALDO_SVE", "{0:0.##}")});
            // 
            // colZabeleski
            // 
            this.colZabeleski.Caption = "Забелешки";
            this.colZabeleski.FieldName = "Zabeleski";
            this.colZabeleski.Name = "colZabeleski";
            this.colZabeleski.OptionsColumn.AllowEdit = false;
            this.colZabeleski.Visible = true;
            this.colZabeleski.VisibleIndex = 1;
            this.colZabeleski.Width = 225;
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
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.gridColumn8;
            this.cardView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsPrint.PrintFilterInfo = true;
            this.cardView1.OptionsPrint.UsePrintStyles = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датум на почеток до :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Датум на почеток од :";
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
            this.DatumDo.Location = new System.Drawing.Point(855, 55);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.Size = new System.Drawing.Size(208, 175);
            this.DatumDo.TabIndex = 3;
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
            this.datumOd.Location = new System.Drawing.Point(641, 55);
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(503, 192);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.TabIndex = 1;
            this.btnPotvrdi1.Text = "Прикажи се";
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
            this.btnPecati1.Location = new System.Drawing.Point(45, 192);
            this.btnPecati1.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.Name = "btnPecati1";
            this.btnPecati1.Size = new System.Drawing.Size(132, 38);
            this.btnPecati1.TabIndex = 0;
            this.btnPecati1.Text = "Печати";
            this.btnPecati1.UseVisualStyleBackColor = false;
            this.btnPecati1.Click += new System.EventHandler(this.btnPecati1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPotvrdi5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchText);
            this.groupBox1.Controls.Add(this.btnPotvrdi4);
            this.groupBox1.Controls.Add(this.btnPotvrdi3);
            this.groupBox1.Controls.Add(this.btnPotvrdi2);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.bsslabel5);
            this.groupBox1.Controls.Add(this.zbxPartner);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DatumDo);
            this.groupBox1.Controls.Add(this.datumOd);
            this.groupBox1.Controls.Add(this.btnPotvrdi1);
            this.groupBox1.Controls.Add(this.btnPecati1);
            this.groupBox1.Location = new System.Drawing.Point(-39, -43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 257);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnPotvrdi5
            // 
            this.btnPotvrdi5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi5.Image = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi5.Image")));
            this.btnPotvrdi5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi5.Location = new System.Drawing.Point(447, 48);
            this.btnPotvrdi5.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi5.Name = "btnPotvrdi5";
            this.btnPotvrdi5.Size = new System.Drawing.Size(188, 38);
            this.btnPotvrdi5.TabIndex = 29;
            this.btnPotvrdi5.Text = "Должници по документ";
            this.btnPotvrdi5.UseVisualStyleBackColor = false;
            this.btnPotvrdi5.Click += new System.EventHandler(this.btnPotvrdi5_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Филтер по назив";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.AssemblyStr = null;
            this.txtSearchText.C_FillWithZeros = false;
            this.txtSearchText.C_OnlyNumbers = false;
            this.txtSearchText.C_RegEx = false;
            this.txtSearchText.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSearchText.ColumnName1 = null;
            this.txtSearchText.ColumnName2 = null;
            this.txtSearchText.ColumnName3 = null;
            this.txtSearchText.ColumnName4 = null;
            this.txtSearchText.ColumnName5 = null;
            this.txtSearchText.ColumnName6 = null;
            this.txtSearchText.ColumnName7 = null;
            this.txtSearchText.daliCetiri = false;
            this.txtSearchText.Format = null;
            this.txtSearchText.formToOpen = null;
            this.txtSearchText.iscistiGreenNaLeave = false;
            this.txtSearchText.KoristiFilterNaDatasource = false;
            this.txtSearchText.Location = new System.Drawing.Point(186, 210);
            this.txtSearchText.MakedonskiJazik = false;
            this.txtSearchText.MinLength = 0;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.PopulateOtherFields = false;
            this.txtSearchText.regularExpression = null;
            this.txtSearchText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchText.SelektrijaNaFokus = false;
            this.txtSearchText.Size = new System.Drawing.Size(176, 20);
            this.txtSearchText.TabIndex = 27;
            // 
            // btnPotvrdi4
            // 
            this.btnPotvrdi4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi4.Image = global::MReport.Properties.Resources._001_12;
            this.btnPotvrdi4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi4.Location = new System.Drawing.Point(447, 136);
            this.btnPotvrdi4.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi4.Name = "btnPotvrdi4";
            this.btnPotvrdi4.Size = new System.Drawing.Size(188, 38);
            this.btnPotvrdi4.TabIndex = 26;
            this.btnPotvrdi4.Text = "Известување за должници";
            this.btnPotvrdi4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPotvrdi4.UseVisualStyleBackColor = false;
            this.btnPotvrdi4.Click += new System.EventHandler(this.btnPotvrdi4_Click);
            // 
            // btnPotvrdi3
            // 
            this.btnPotvrdi3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi3.Image = global::MReport.Properties.Resources._001_12;
            this.btnPotvrdi3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi3.Location = new System.Drawing.Point(447, 92);
            this.btnPotvrdi3.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi3.Name = "btnPotvrdi3";
            this.btnPotvrdi3.Size = new System.Drawing.Size(188, 38);
            this.btnPotvrdi3.TabIndex = 25;
            this.btnPotvrdi3.Text = "Картичка на партнери";
            this.btnPotvrdi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPotvrdi3.UseVisualStyleBackColor = false;
            this.btnPotvrdi3.Click += new System.EventHandler(this.btnPotvrdi3_Click);
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
            this.btnPotvrdi2.Location = new System.Drawing.Point(368, 192);
            this.btnPotvrdi2.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi2.Name = "btnPotvrdi2";
            this.btnPotvrdi2.Size = new System.Drawing.Size(132, 38);
            this.btnPotvrdi2.TabIndex = 24;
            this.btnPotvrdi2.Text = "Прикажи само должници";
            this.btnPotvrdi2.UseVisualStyleBackColor = false;
            this.btnPotvrdi2.Click += new System.EventHandler(this.btnPotvrdi2_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInfo.Location = new System.Drawing.Point(40, 55);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(390, 119);
            this.txtInfo.TabIndex = 23;
            this.txtInfo.Click += new System.EventHandler(this.txtInfo_Click);
            // 
            // bsslabel5
            // 
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Location = new System.Drawing.Point(7, 27);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(53, 13);
            this.bsslabel5.TabIndex = 22;
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
            this.zbxPartner.Location = new System.Drawing.Point(77, 20);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(198, 26);
            this.zbxPartner.TabIndex = 21;
            // 
            // saldoPoDokumentTableAdapter
            // 
            this.saldoPoDokumentTableAdapter.ClearBeforeFill = true;
            // 
            // frmListaNaDolznici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmListaNaDolznici";
            this.Text = "Листа на плаќања и документи";
            this.Load += new System.EventHandler(this.frmListaNaDolznici_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoPoDokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BssBase.DevGrid gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraScheduler.DateNavigator DatumDo;
        private DevExpress.XtraScheduler.DateNavigator datumOd;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPecati btnPecati1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BssBase.Elements.Bsslabel bsslabel5;
        private BssBase.zbxBase zbxPartner;
        private BSSRDataSet bSSRDataSet;
        private System.Windows.Forms.BindingSource saldoPoDokumentBindingSource;
        private BSSRDataSetTableAdapters.SaldoPoDokumentTableAdapter saldoPoDokumentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colVkupnoDolzi;
        private DevExpress.XtraGrid.Columns.GridColumn colVkupnoPlateno;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipNaDostava;
        private DevExpress.XtraGrid.Columns.GridColumn colSALDO_Dolzi;
        private DevExpress.XtraGrid.Columns.GridColumn colSALDO_Plateno;
        private DevExpress.XtraGrid.Columns.GridColumn colSALDO_SVE;
        private System.Windows.Forms.Label txtInfo;
        private BssBase.Elements.btnPotvrdi btnPotvrdi2;
        private BssBase.Elements.btnPotvrdi btnPotvrdi3;
        private BssBase.Elements.btnPotvrdi btnPotvrdi4;
        private BssBase.txtBase txtSearchText;
        private System.Windows.Forms.Label label3;
        private BssBase.Elements.btnPotvrdi btnPotvrdi5;
        private DevExpress.XtraGrid.Columns.GridColumn colZabeleski;
    }
}
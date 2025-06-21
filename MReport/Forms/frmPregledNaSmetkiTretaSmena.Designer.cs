namespace MReport.Forms
{
    partial class frmPregledNaSmetkiTretaSmena
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNaSmetkiTretaSmena));
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtminuta = new BssBase.txtBase();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new MReport.BSSRDataSetTableAdapters.TableAdapterManager();
            this.gridControl1 = new BssBase.DevGrid();
            this.izvestajCementaraTretaSmenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSRDataSet = new MReport.BSSRDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaticen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.izvestajCementaraTretaSmenaTableAdapter = new MReport.BSSRDataSetTableAdapters.IzvestajCementaraTretaSmenaTableAdapter();
            this.btnPrikaci1 = new BssBase.Elements.btnPrikaci();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvestajCementaraTretaSmenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Износ";
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.OptionsColumn.ReadOnly = true;
            this.colIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPrikaci1);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bsslabel3
            // 
            this.bsslabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Location = new System.Drawing.Point(654, 213);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(44, 13);
            this.bsslabel3.TabIndex = 15;
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
            this.txtMin2.Location = new System.Drawing.Point(704, 211);
            this.txtMin2.MakedonskiJazik = false;
            this.txtMin2.MaxLength = 2;
            this.txtMin2.MinLength = 0;
            this.txtMin2.Name = "txtMin2";
            this.txtMin2.PopulateOtherFields = false;
            this.txtMin2.regularExpression = null;
            this.txtMin2.SelektrijaNaFokus = false;
            this.txtMin2.Size = new System.Drawing.Size(25, 20);
            this.txtMin2.TabIndex = 14;
            this.txtMin2.Text = "0";
            // 
            // bsslabel4
            // 
            this.bsslabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Location = new System.Drawing.Point(585, 213);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(27, 13);
            this.bsslabel4.TabIndex = 13;
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
            this.txtCas2.Location = new System.Drawing.Point(618, 211);
            this.txtCas2.MakedonskiJazik = false;
            this.txtCas2.MaxLength = 2;
            this.txtCas2.MinLength = 0;
            this.txtCas2.Name = "txtCas2";
            this.txtCas2.PopulateOtherFields = false;
            this.txtCas2.regularExpression = null;
            this.txtCas2.SelektrijaNaFokus = false;
            this.txtCas2.Size = new System.Drawing.Size(29, 20);
            this.txtCas2.TabIndex = 12;
            this.txtCas2.Text = "0";
            // 
            // bsslabel2
            // 
            this.bsslabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(439, 213);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(44, 13);
            this.bsslabel2.TabIndex = 11;
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
            this.txtMin.Location = new System.Drawing.Point(489, 211);
            this.txtMin.MakedonskiJazik = false;
            this.txtMin.MaxLength = 2;
            this.txtMin.MinLength = 0;
            this.txtMin.Name = "txtMin";
            this.txtMin.PopulateOtherFields = false;
            this.txtMin.regularExpression = null;
            this.txtMin.SelektrijaNaFokus = false;
            this.txtMin.Size = new System.Drawing.Size(25, 20);
            this.txtMin.TabIndex = 10;
            this.txtMin.Text = "0";
            // 
            // bsslabel1
            // 
            this.bsslabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(370, 213);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(27, 13);
            this.bsslabel1.TabIndex = 9;
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
            this.txtSaat.Location = new System.Drawing.Point(403, 211);
            this.txtSaat.MakedonskiJazik = false;
            this.txtSaat.MaxLength = 2;
            this.txtSaat.MinLength = 0;
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.PopulateOtherFields = false;
            this.txtSaat.regularExpression = null;
            this.txtSaat.SelektrijaNaFokus = false;
            this.txtSaat.Size = new System.Drawing.Size(29, 20);
            this.txtSaat.TabIndex = 8;
            this.txtSaat.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датум на почеток до :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 10);
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
            this.DatumDo.Location = new System.Drawing.Point(583, 35);
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
            this.datumOd.Location = new System.Drawing.Point(369, 35);
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(213, 178);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(150, 38);
            this.btnPotvrdi1.TabIndex = 1;
            this.btnPotvrdi1.Text = "Прикажи";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.BtnPotvrdi1_Click);
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
            this.btnPecati1.Location = new System.Drawing.Point(12, 178);
            this.btnPecati1.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati1.Name = "btnPecati1";
            this.btnPecati1.Size = new System.Drawing.Size(132, 38);
            this.btnPecati1.TabIndex = 0;
            this.btnPecati1.Text = "Печати";
            this.btnPecati1.UseVisualStyleBackColor = false;
            this.btnPecati1.Click += new System.EventHandler(this.btnPecati1_Click);
            // 
            // txtminuta
            // 
            this.txtminuta.AssemblyStr = null;
            this.txtminuta.C_FillWithZeros = false;
            this.txtminuta.C_OnlyNumbers = true;
            this.txtminuta.C_RegEx = false;
            this.txtminuta.C_ShowRedOnLeaveIfEmpty = false;
            this.txtminuta.ColumnName1 = null;
            this.txtminuta.ColumnName2 = null;
            this.txtminuta.ColumnName3 = null;
            this.txtminuta.ColumnName4 = null;
            this.txtminuta.ColumnName5 = null;
            this.txtminuta.ColumnName6 = null;
            this.txtminuta.ColumnName7 = null;
            this.txtminuta.daliCetiri = false;
            this.txtminuta.Format = null;
            this.txtminuta.formToOpen = null;
            this.txtminuta.iscistiGreenNaLeave = false;
            this.txtminuta.KoristiFilterNaDatasource = false;
            this.txtminuta.Location = new System.Drawing.Point(692, 215);
            this.txtminuta.MakedonskiJazik = false;
            this.txtminuta.MinLength = 0;
            this.txtminuta.Name = "txtminuta";
            this.txtminuta.PopulateOtherFields = false;
            this.txtminuta.regularExpression = null;
            this.txtminuta.SelektrijaNaFokus = false;
            this.txtminuta.Size = new System.Drawing.Size(100, 20);
            this.txtminuta.TabIndex = 10;
            this.txtminuta.Text = "0";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Објект";
            this.gridColumn11.FieldName = "Naziv";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Затворена";
            this.gridColumn10.FieldName = "Zatvorena";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Смена";
            this.gridColumn9.FieldName = "Smena_ID";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Датум на крај";
            this.gridColumn6.FieldName = "DatumKraj";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Датум на почеток";
            this.gridColumn5.FieldName = "DatumPocetok";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Број на сметка";
            this.gridColumn2.FieldName = "Broj";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Broj", "{0}")});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Реден број";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblConfigTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = null;
            this.tableAdapterManager.tblNarackiTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiIzmenetaTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MReport.BSSRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControl1
            // 
            this.gridControl1.AssemblyToLoad = null;
            this.gridControl1.DataSource = this.izvestajCementaraTretaSmenaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EditForm = null;
            this.gridControl1.FilterForm = null;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.PrimaryKey = null;
            this.gridControl1.reportCenter = false;
            this.gridControl1.ReportName = null;
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(791, 251);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UpdateTable = null;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1,
            this.gridView2});
            // 
            // izvestajCementaraTretaSmenaBindingSource
            // 
            this.izvestajCementaraTretaSmenaBindingSource.DataMember = "IzvestajCementaraTretaSmena";
            this.izvestajCementaraTretaSmenaBindingSource.DataSource = this.bSSRDataSet;
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
            this.colMaticen,
            this.colDatum,
            this.colIznos,
            this.colResult});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.colIznos;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Повлечи колона тука за да групираш по неа";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Broj", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iznos", this.colIznos, "")});
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
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // colMaticen
            // 
            this.colMaticen.Caption = "Матичен";
            this.colMaticen.FieldName = "Maticen";
            this.colMaticen.Name = "colMaticen";
            this.colMaticen.OptionsColumn.ReadOnly = true;
            this.colMaticen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Maticen", "{0}")});
            this.colMaticen.Visible = true;
            this.colMaticen.VisibleIndex = 0;
            // 
            // colDatum
            // 
            this.colDatum.Caption = "Датум";
            this.colDatum.FieldName = "Datum";
            this.colDatum.Name = "colDatum";
            this.colDatum.OptionsColumn.ReadOnly = true;
            this.colDatum.Visible = true;
            this.colDatum.VisibleIndex = 1;
            // 
            // colResult
            // 
            this.colResult.Caption = "Резултат";
            this.colResult.FieldName = "Result";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.ReadOnly = true;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 3;
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
            this.cardView1.FocusedCardTopFieldIndex = 0;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Column = this.gridColumn8;
            this.cardView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
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
            // gridView2
            // 
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(7, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // izvestajCementaraTretaSmenaTableAdapter
            // 
            this.izvestajCementaraTretaSmenaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrikaci1
            // 
            this.btnPrikaci1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaci1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrikaci1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrikaci1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaci1.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikaci1.Image")));
            this.btnPrikaci1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaci1.Location = new System.Drawing.Point(213, 35);
            this.btnPrikaci1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPrikaci1.Name = "btnPrikaci1";
            this.btnPrikaci1.Size = new System.Drawing.Size(154, 38);
            this.btnPrikaci1.TabIndex = 52;
            this.btnPrikaci1.Text = "Прати по маил";
            this.btnPrikaci1.UseVisualStyleBackColor = false;
            this.btnPrikaci1.Click += new System.EventHandler(this.BtnPrikaci1_Click);
            // 
            // frmPregledNaSmetkiTretaSmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledNaSmetkiTretaSmena";
            this.Text = "Преглед на сметки Трета смена";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatumDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvestajCementaraTretaSmenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BssBase.Elements.btnPecati btnPecati1;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraScheduler.DateNavigator DatumDo;
        private DevExpress.XtraScheduler.DateNavigator datumOd;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.txtBase txtMin;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.txtBase txtSaat;
        private BssBase.txtBase txtminuta;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.txtBase txtMin2;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.txtBase txtCas2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private BSSRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.DevGrid gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private BSSRDataSet bSSRDataSet;
        private System.Windows.Forms.BindingSource izvestajCementaraTretaSmenaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaticen;
        private DevExpress.XtraGrid.Columns.GridColumn colDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private BSSRDataSetTableAdapters.IzvestajCementaraTretaSmenaTableAdapter izvestajCementaraTretaSmenaTableAdapter;
        private BssBase.Elements.btnPrikaci btnPrikaci1;
    }
}
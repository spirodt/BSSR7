namespace BSSR.Forms
{
    partial class frmNarackiVnes
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
            System.Windows.Forms.Label narackaBrojLabel;
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label datumNaNarackaLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label kontaktLabel;
            System.Windows.Forms.Label odObjektLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarackiVnes));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblNarackiBindingSource = new System.Windows.Forms.BindingSource();
            this.tblNarackiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblNarackiTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.narackaBrojtxtBase = new BssBase.txtBase();
            this.opistxtBase = new BssBase.txtBase();
            this.datumNaNarackaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imetxtBase = new BssBase.txtBase();
            this.kontakttxtBase = new BssBase.txtBase();
            this.odObjekttxtBase = new BssBase.txtBase();
            this.viewFakturiStavkiDevGrid = new BssBase.DevGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarackaBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaNaracka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKontakt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdObjekt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZavrsena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPecati2 = new BssBase.Elements.btnPecati();
            this.btnPonisti1 = new BssBase.Elements.btnPonisti();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPotvrdi2 = new BssBase.Elements.btnPotvrdi();
            narackaBrojLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            datumNaNarackaLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            odObjektLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNarackiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Location = new System.Drawing.Point(6, 3);
            this.MainTab.Size = new System.Drawing.Size(933, 538);
            // 
            // tabVnes
            // 
            this.tabVnes.Size = new System.Drawing.Size(925, 512);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.btnPotvrdi2);
            this.groupVnes.Controls.Add(this.btnPecati2);
            this.groupVnes.Controls.Add(this.btnPonisti1);
            this.groupVnes.Controls.Add(this.btnPotvrdi1);
            this.groupVnes.Controls.Add(this.viewFakturiStavkiDevGrid);
            this.groupVnes.Controls.Add(this.datumNaNarackaDateTimePicker);
            this.groupVnes.Controls.Add(datumNaNarackaLabel);
            this.groupVnes.Controls.Add(opisLabel);
            this.groupVnes.Controls.Add(odObjektLabel);
            this.groupVnes.Controls.Add(this.opistxtBase);
            this.groupVnes.Controls.Add(this.kontakttxtBase);
            this.groupVnes.Controls.Add(this.odObjekttxtBase);
            this.groupVnes.Controls.Add(kontaktLabel);
            this.groupVnes.Controls.Add(imeLabel);
            this.groupVnes.Controls.Add(this.narackaBrojtxtBase);
            this.groupVnes.Controls.Add(this.imetxtBase);
            this.groupVnes.Controls.Add(narackaBrojLabel);
            this.groupVnes.Size = new System.Drawing.Size(918, 501);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(6, 540);
            this.PanelFooter.Size = new System.Drawing.Size(933, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 4);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(734, 4);
            // 
            // narackaBrojLabel
            // 
            narackaBrojLabel.AutoSize = true;
            narackaBrojLabel.Location = new System.Drawing.Point(1, 28);
            narackaBrojLabel.Name = "narackaBrojLabel";
            narackaBrojLabel.Size = new System.Drawing.Size(169, 29);
            narackaBrojLabel.TabIndex = 1;
            narackaBrojLabel.Text = "Нарачка број:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(6, 124);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(80, 29);
            opisLabel.TabIndex = 3;
            opisLabel.Text = "Опис:";
            // 
            // datumNaNarackaLabel
            // 
            datumNaNarackaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            datumNaNarackaLabel.AutoSize = true;
            datumNaNarackaLabel.Location = new System.Drawing.Point(489, 32);
            datumNaNarackaLabel.Name = "datumNaNarackaLabel";
            datumNaNarackaLabel.Size = new System.Drawing.Size(89, 29);
            datumNaNarackaLabel.TabIndex = 5;
            datumNaNarackaLabel.Text = "Датум:";
            // 
            // imeLabel
            // 
            imeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(509, 81);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(69, 29);
            imeLabel.TabIndex = 7;
            imeLabel.Text = "Име:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            kontaktLabel.AutoSize = true;
            kontaktLabel.Location = new System.Drawing.Point(465, 123);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(113, 29);
            kontaktLabel.TabIndex = 9;
            kontaktLabel.Text = "Контакт:";
            // 
            // odObjektLabel
            // 
            odObjektLabel.AutoSize = true;
            odObjektLabel.Location = new System.Drawing.Point(6, 81);
            odObjektLabel.Name = "odObjektLabel";
            odObjektLabel.Size = new System.Drawing.Size(130, 29);
            odObjektLabel.TabIndex = 11;
            odObjektLabel.Text = "Од објект:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNarackiBindingSource
            // 
            this.tblNarackiBindingSource.DataMember = "tblNaracki";
            this.tblNarackiBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblNarackiTableAdapter
            // 
            this.tblNarackiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblConfigTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
            this.tableAdapterManager.tblFormiTableAdapter = null;
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
            this.tableAdapterManager.tblKursnaListaTableAdapter = null;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = null;
            this.tableAdapterManager.tblNarackiTableAdapter = this.tblNarackiTableAdapter;
            this.tableAdapterManager.tblNormativiSodriznaIznosTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblTipNaDokumentTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // narackaBrojtxtBase
            // 
            this.narackaBrojtxtBase.AssemblyStr = null;
            this.narackaBrojtxtBase.C_FillWithZeros = false;
            this.narackaBrojtxtBase.C_OnlyNumbers = false;
            this.narackaBrojtxtBase.C_RegEx = false;
            this.narackaBrojtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.narackaBrojtxtBase.ColumnName1 = null;
            this.narackaBrojtxtBase.ColumnName2 = null;
            this.narackaBrojtxtBase.ColumnName3 = null;
            this.narackaBrojtxtBase.ColumnName4 = null;
            this.narackaBrojtxtBase.ColumnName5 = null;
            this.narackaBrojtxtBase.ColumnName6 = null;
            this.narackaBrojtxtBase.ColumnName7 = null;
            this.narackaBrojtxtBase.daliCetiri = false;
            this.narackaBrojtxtBase.Format = null;
            this.narackaBrojtxtBase.formToOpen = null;
            this.narackaBrojtxtBase.iscistiGreenNaLeave = false;
            this.narackaBrojtxtBase.KoristiFilterNaDatasource = false;
            this.narackaBrojtxtBase.Location = new System.Drawing.Point(175, 29);
            this.narackaBrojtxtBase.MakedonskiJazik = false;
            this.narackaBrojtxtBase.MinLength = 0;
            this.narackaBrojtxtBase.Name = "narackaBrojtxtBase";
            this.narackaBrojtxtBase.PopulateOtherFields = false;
            this.narackaBrojtxtBase.regularExpression = null;
            this.narackaBrojtxtBase.SelektrijaNaFokus = false;
            this.narackaBrojtxtBase.Size = new System.Drawing.Size(177, 35);
            this.narackaBrojtxtBase.TabIndex = 0;
            // 
            // opistxtBase
            // 
            this.opistxtBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opistxtBase.AssemblyStr = null;
            this.opistxtBase.C_FillWithZeros = false;
            this.opistxtBase.C_OnlyNumbers = false;
            this.opistxtBase.C_RegEx = false;
            this.opistxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.opistxtBase.ColumnName1 = null;
            this.opistxtBase.ColumnName2 = null;
            this.opistxtBase.ColumnName3 = null;
            this.opistxtBase.ColumnName4 = null;
            this.opistxtBase.ColumnName5 = null;
            this.opistxtBase.ColumnName6 = null;
            this.opistxtBase.ColumnName7 = null;
            this.opistxtBase.daliCetiri = false;
            this.opistxtBase.Format = null;
            this.opistxtBase.formToOpen = null;
            this.opistxtBase.iscistiGreenNaLeave = false;
            this.opistxtBase.KoristiFilterNaDatasource = false;
            this.opistxtBase.Location = new System.Drawing.Point(11, 161);
            this.opistxtBase.MakedonskiJazik = false;
            this.opistxtBase.MinLength = 0;
            this.opistxtBase.Multiline = true;
            this.opistxtBase.Name = "opistxtBase";
            this.opistxtBase.PopulateOtherFields = false;
            this.opistxtBase.regularExpression = null;
            this.opistxtBase.SelektrijaNaFokus = false;
            this.opistxtBase.Size = new System.Drawing.Size(900, 36);
            this.opistxtBase.TabIndex = 5;
            // 
            // datumNaNarackaDateTimePicker
            // 
            this.datumNaNarackaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumNaNarackaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblNarackiBindingSource, "DatumNaNaracka", true));
            this.datumNaNarackaDateTimePicker.Location = new System.Drawing.Point(584, 29);
            this.datumNaNarackaDateTimePicker.Name = "datumNaNarackaDateTimePicker";
            this.datumNaNarackaDateTimePicker.Size = new System.Drawing.Size(324, 35);
            this.datumNaNarackaDateTimePicker.TabIndex = 1;
            // 
            // imetxtBase
            // 
            this.imetxtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imetxtBase.AssemblyStr = null;
            this.imetxtBase.C_FillWithZeros = false;
            this.imetxtBase.C_OnlyNumbers = false;
            this.imetxtBase.C_RegEx = false;
            this.imetxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.imetxtBase.ColumnName1 = null;
            this.imetxtBase.ColumnName2 = null;
            this.imetxtBase.ColumnName3 = null;
            this.imetxtBase.ColumnName4 = null;
            this.imetxtBase.ColumnName5 = null;
            this.imetxtBase.ColumnName6 = null;
            this.imetxtBase.ColumnName7 = null;
            this.imetxtBase.daliCetiri = false;
            this.imetxtBase.Format = null;
            this.imetxtBase.formToOpen = null;
            this.imetxtBase.iscistiGreenNaLeave = false;
            this.imetxtBase.KoristiFilterNaDatasource = false;
            this.imetxtBase.Location = new System.Drawing.Point(584, 78);
            this.imetxtBase.MakedonskiJazik = false;
            this.imetxtBase.MinLength = 0;
            this.imetxtBase.Name = "imetxtBase";
            this.imetxtBase.PopulateOtherFields = false;
            this.imetxtBase.regularExpression = null;
            this.imetxtBase.SelektrijaNaFokus = false;
            this.imetxtBase.Size = new System.Drawing.Size(324, 35);
            this.imetxtBase.TabIndex = 3;
            // 
            // kontakttxtBase
            // 
            this.kontakttxtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kontakttxtBase.AssemblyStr = null;
            this.kontakttxtBase.C_FillWithZeros = false;
            this.kontakttxtBase.C_OnlyNumbers = false;
            this.kontakttxtBase.C_RegEx = false;
            this.kontakttxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.kontakttxtBase.ColumnName1 = null;
            this.kontakttxtBase.ColumnName2 = null;
            this.kontakttxtBase.ColumnName3 = null;
            this.kontakttxtBase.ColumnName4 = null;
            this.kontakttxtBase.ColumnName5 = null;
            this.kontakttxtBase.ColumnName6 = null;
            this.kontakttxtBase.ColumnName7 = null;
            this.kontakttxtBase.daliCetiri = false;
            this.kontakttxtBase.Format = null;
            this.kontakttxtBase.formToOpen = null;
            this.kontakttxtBase.iscistiGreenNaLeave = false;
            this.kontakttxtBase.KoristiFilterNaDatasource = false;
            this.kontakttxtBase.Location = new System.Drawing.Point(584, 120);
            this.kontakttxtBase.MakedonskiJazik = false;
            this.kontakttxtBase.MinLength = 0;
            this.kontakttxtBase.Name = "kontakttxtBase";
            this.kontakttxtBase.PopulateOtherFields = false;
            this.kontakttxtBase.regularExpression = null;
            this.kontakttxtBase.SelektrijaNaFokus = false;
            this.kontakttxtBase.Size = new System.Drawing.Size(324, 35);
            this.kontakttxtBase.TabIndex = 4;
            // 
            // odObjekttxtBase
            // 
            this.odObjekttxtBase.AssemblyStr = null;
            this.odObjekttxtBase.C_FillWithZeros = false;
            this.odObjekttxtBase.C_OnlyNumbers = false;
            this.odObjekttxtBase.C_RegEx = false;
            this.odObjekttxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.odObjekttxtBase.ColumnName1 = null;
            this.odObjekttxtBase.ColumnName2 = null;
            this.odObjekttxtBase.ColumnName3 = null;
            this.odObjekttxtBase.ColumnName4 = null;
            this.odObjekttxtBase.ColumnName5 = null;
            this.odObjekttxtBase.ColumnName6 = null;
            this.odObjekttxtBase.ColumnName7 = null;
            this.odObjekttxtBase.daliCetiri = false;
            this.odObjekttxtBase.Format = null;
            this.odObjekttxtBase.formToOpen = null;
            this.odObjekttxtBase.iscistiGreenNaLeave = false;
            this.odObjekttxtBase.KoristiFilterNaDatasource = false;
            this.odObjekttxtBase.Location = new System.Drawing.Point(141, 78);
            this.odObjekttxtBase.MakedonskiJazik = false;
            this.odObjekttxtBase.MinLength = 0;
            this.odObjekttxtBase.Name = "odObjekttxtBase";
            this.odObjekttxtBase.PopulateOtherFields = false;
            this.odObjekttxtBase.regularExpression = null;
            this.odObjekttxtBase.SelektrijaNaFokus = false;
            this.odObjekttxtBase.Size = new System.Drawing.Size(340, 35);
            this.odObjekttxtBase.TabIndex = 2;
            // 
            // viewFakturiStavkiDevGrid
            // 
            this.viewFakturiStavkiDevGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFakturiStavkiDevGrid.AssemblyToLoad = null;
            this.viewFakturiStavkiDevGrid.DataSource = this.tblNarackiBindingSource;
            this.viewFakturiStavkiDevGrid.EditForm = null;
            this.viewFakturiStavkiDevGrid.FilterForm = null;
            this.viewFakturiStavkiDevGrid.Location = new System.Drawing.Point(11, 250);
            this.viewFakturiStavkiDevGrid.MainView = this.gridView1;
            this.viewFakturiStavkiDevGrid.Name = "viewFakturiStavkiDevGrid";
            this.viewFakturiStavkiDevGrid.PrimaryKey = null;
            this.viewFakturiStavkiDevGrid.reportCenter = false;
            this.viewFakturiStavkiDevGrid.ReportName = null;
            this.viewFakturiStavkiDevGrid.Size = new System.Drawing.Size(898, 247);
            this.viewFakturiStavkiDevGrid.TabIndex = 6;
            this.viewFakturiStavkiDevGrid.TabStop = false;
            this.viewFakturiStavkiDevGrid.UpdateTable = null;
            this.viewFakturiStavkiDevGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNarackaBroj,
            this.colOpis,
            this.colDatumNaNaracka,
            this.colIme,
            this.colKontakt,
            this.colOdObjekt,
            this.colZavrsena});
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colNarackaBroj
            // 
            this.colNarackaBroj.Caption = "Нарачка";
            this.colNarackaBroj.FieldName = "NarackaBroj";
            this.colNarackaBroj.Name = "colNarackaBroj";
            this.colNarackaBroj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NarackaBroj", "{0}")});
            this.colNarackaBroj.Visible = true;
            this.colNarackaBroj.VisibleIndex = 0;
            // 
            // colOpis
            // 
            this.colOpis.Caption = "Опис";
            this.colOpis.FieldName = "Opis";
            this.colOpis.Name = "colOpis";
            this.colOpis.Visible = true;
            this.colOpis.VisibleIndex = 1;
            // 
            // colDatumNaNaracka
            // 
            this.colDatumNaNaracka.Caption = "Датум на нарачка";
            this.colDatumNaNaracka.FieldName = "DatumNaNaracka";
            this.colDatumNaNaracka.Name = "colDatumNaNaracka";
            this.colDatumNaNaracka.Visible = true;
            this.colDatumNaNaracka.VisibleIndex = 2;
            // 
            // colIme
            // 
            this.colIme.Caption = "Име";
            this.colIme.FieldName = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.Visible = true;
            this.colIme.VisibleIndex = 3;
            // 
            // colKontakt
            // 
            this.colKontakt.Caption = "Контакт";
            this.colKontakt.FieldName = "Kontakt";
            this.colKontakt.Name = "colKontakt";
            this.colKontakt.Visible = true;
            this.colKontakt.VisibleIndex = 4;
            // 
            // colOdObjekt
            // 
            this.colOdObjekt.Caption = "Од објект";
            this.colOdObjekt.FieldName = "OdObjekt";
            this.colOdObjekt.Name = "colOdObjekt";
            // 
            // colZavrsena
            // 
            this.colZavrsena.Caption = "Завршена";
            this.colZavrsena.FieldName = "Zavrsena";
            this.colZavrsena.Name = "colZavrsena";
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
            this.btnPecati2.Location = new System.Drawing.Point(190, 206);
            this.btnPecati2.MaximumSize = new System.Drawing.Size(132, 38);
            this.btnPecati2.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPecati2.Name = "btnPecati2";
            this.btnPecati2.Size = new System.Drawing.Size(132, 38);
            this.btnPecati2.TabIndex = 14;
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
            this.btnPonisti1.Location = new System.Drawing.Point(11, 206);
            this.btnPonisti1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPonisti1.Name = "btnPonisti1";
            this.btnPonisti1.Size = new System.Drawing.Size(170, 38);
            this.btnPonisti1.TabIndex = 13;
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
            this.btnPotvrdi1.Image = global::BSSR.Properties.Resources._001_01;
            this.btnPotvrdi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi1.Location = new System.Drawing.Point(679, 206);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(234, 38);
            this.btnPotvrdi1.TabIndex = 12;
            this.btnPotvrdi1.Text = "Внеси";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
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
            this.btnPotvrdi2.Location = new System.Drawing.Point(389, 206);
            this.btnPotvrdi2.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi2.Name = "btnPotvrdi2";
            this.btnPotvrdi2.Size = new System.Drawing.Size(284, 38);
            this.btnPotvrdi2.TabIndex = 15;
            this.btnPotvrdi2.Text = "Потврди завршена";
            this.btnPotvrdi2.UseVisualStyleBackColor = false;
            this.btnPotvrdi2.Click += new System.EventHandler(this.btnPotvrdi2_Click);
            // 
            // frmNarackiVnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 609);
            this.Name = "frmNarackiVnes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внес на нарачка";
            this.Load += new System.EventHandler(this.frmNarackiVnes_Load);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNarackiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFakturiStavkiDevGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblNarackiBindingSource;
        private BSSSDatasetTableAdapters.tblNarackiTableAdapter tblNarackiTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.txtBase narackaBrojtxtBase;
        private BssBase.txtBase opistxtBase;
        private System.Windows.Forms.DateTimePicker datumNaNarackaDateTimePicker;
        private BssBase.txtBase imetxtBase;
        private BssBase.txtBase kontakttxtBase;
        private BssBase.txtBase odObjekttxtBase;
        private BssBase.DevGrid viewFakturiStavkiDevGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNarackaBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colOpis;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaNaracka;
        private DevExpress.XtraGrid.Columns.GridColumn colIme;
        private DevExpress.XtraGrid.Columns.GridColumn colKontakt;
        private DevExpress.XtraGrid.Columns.GridColumn colOdObjekt;
        private DevExpress.XtraGrid.Columns.GridColumn colZavrsena;
        private BssBase.Elements.btnPotvrdi btnPotvrdi2;
        private BssBase.Elements.btnPecati btnPecati2;
        private BssBase.Elements.btnPonisti btnPonisti1;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
    }
}
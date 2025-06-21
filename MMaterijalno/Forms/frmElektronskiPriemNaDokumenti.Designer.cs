namespace MMaterijalno.Forms
{
    partial class frmElektronskiPriemNaDokumenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElektronskiPriemNaDokumenti));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnЗапиши = new BssBase.Elements.btnPotvrdi();
            this.viewDokumentiStavkigrd = new BssBase.DevGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblDokumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipNadokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArikalNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormativNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormativID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVStapka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdinecnaMerka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaSoRabatIddv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipNaDokumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazivNaProdukt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.txBroj = new BssBase.Elements.Bsslabel();
            this.txtIznos = new BssBase.Elements.Bsslabel();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.txtTip = new BssBase.Elements.Bsslabel();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.txtObjekt = new BssBase.Elements.Bsslabel();
            this.bsslabel7 = new BssBase.Elements.Bsslabel();
            this.bsslabel8 = new BssBase.Elements.Bsslabel();
            this.txtDoObjekt = new BssBase.Elements.Bsslabel();
            this.bsslabel10 = new BssBase.Elements.Bsslabel();
            this.txtDatum = new BssBase.Elements.Bsslabel();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.cmbServer = new BssBase.cmbBase();
            this.btnPLT = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkigrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // btnЗапиши
            // 
            this.btnЗапиши.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnЗапиши.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnЗапиши.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnЗапиши.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnЗапиши.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnЗапиши.Image = ((System.Drawing.Image)(resources.GetObject("btnЗапиши.Image")));
            this.btnЗапиши.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnЗапиши.Location = new System.Drawing.Point(549, 244);
            this.btnЗапиши.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnЗапиши.Name = "btnЗапиши";
            this.btnЗапиши.Size = new System.Drawing.Size(132, 38);
            this.btnЗапиши.TabIndex = 4;
            this.btnЗапиши.Text = "Запиши";
            this.btnЗапиши.UseVisualStyleBackColor = false;
            this.btnЗапиши.Click += new System.EventHandler(this.btnЗапиши_Click);
            // 
            // viewDokumentiStavkigrd
            // 
            this.viewDokumentiStavkigrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDokumentiStavkigrd.AssemblyToLoad = null;
            this.viewDokumentiStavkigrd.EditForm = null;
            this.viewDokumentiStavkigrd.FilterForm = null;
            this.viewDokumentiStavkigrd.Location = new System.Drawing.Point(1, 288);
            this.viewDokumentiStavkigrd.MainView = this.gridView1;
            this.viewDokumentiStavkigrd.Name = "viewDokumentiStavkigrd";
            this.viewDokumentiStavkigrd.PrimaryKey = null;
            this.viewDokumentiStavkigrd.reportCenter = false;
            this.viewDokumentiStavkigrd.ReportName = null;
            this.viewDokumentiStavkigrd.Size = new System.Drawing.Size(940, 318);
            this.viewDokumentiStavkigrd.TabIndex = 5;
            this.viewDokumentiStavkigrd.UpdateTable = null;
            this.viewDokumentiStavkigrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.coltblDokumentID,
            this.colBrojNaDokument,
            this.colTipNadokument,
            this.colArikalNaziv,
            this.colArtikalID,
            this.colNormativNaziv,
            this.colNormativID,
            this.colDDVStapka,
            this.colEdinecnaMerka,
            this.colDDVIznos,
            this.colIznosBezDDV,
            this.colCenaSoRabatIddv,
            this.colKolicina,
            this.colCena,
            this.colRabat1,
            this.colIznos,
            this.colTipNaDokumentID,
            this.colNazivNaProdukt});
            this.gridView1.GridControl = this.viewDokumentiStavkigrd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "Реден број ";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // coltblDokumentID
            // 
            this.coltblDokumentID.Caption = "Реден број на документ";
            this.coltblDokumentID.FieldName = "tblDokumentID";
            this.coltblDokumentID.Name = "coltblDokumentID";
            // 
            // colBrojNaDokument
            // 
            this.colBrojNaDokument.Caption = "Број на документ";
            this.colBrojNaDokument.FieldName = "BrojNaDokument";
            this.colBrojNaDokument.Name = "colBrojNaDokument";
            this.colBrojNaDokument.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BrojNaDokument", "{0}")});
            // 
            // colTipNadokument
            // 
            this.colTipNadokument.Caption = "Тип на документ";
            this.colTipNadokument.FieldName = "TipNadokument";
            this.colTipNadokument.Name = "colTipNadokument";
            // 
            // colArikalNaziv
            // 
            this.colArikalNaziv.Caption = "Артикал назив";
            this.colArikalNaziv.FieldName = "ArikalNaziv";
            this.colArikalNaziv.Name = "colArikalNaziv";
            // 
            // colArtikalID
            // 
            this.colArtikalID.Caption = "Реден број на артикал";
            this.colArtikalID.FieldName = "ArtikalID";
            this.colArtikalID.Name = "colArtikalID";
            // 
            // colNormativNaziv
            // 
            this.colNormativNaziv.Caption = "Норматив назив";
            this.colNormativNaziv.FieldName = "NormativNaziv";
            this.colNormativNaziv.Name = "colNormativNaziv";
            // 
            // colNormativID
            // 
            this.colNormativID.Caption = "Реден број на Норматив";
            this.colNormativID.FieldName = "NormativID";
            this.colNormativID.Name = "colNormativID";
            // 
            // colDDVStapka
            // 
            this.colDDVStapka.Caption = "ДДВ Стапка";
            this.colDDVStapka.FieldName = "DDVStapka";
            this.colDDVStapka.Name = "colDDVStapka";
            this.colDDVStapka.OptionsColumn.ReadOnly = true;
            this.colDDVStapka.Visible = true;
            this.colDDVStapka.VisibleIndex = 6;
            this.colDDVStapka.Width = 115;
            // 
            // colEdinecnaMerka
            // 
            this.colEdinecnaMerka.Caption = "ЕДМ";
            this.colEdinecnaMerka.FieldName = "EdinecnaMerka";
            this.colEdinecnaMerka.Name = "colEdinecnaMerka";
            this.colEdinecnaMerka.OptionsColumn.ReadOnly = true;
            this.colEdinecnaMerka.Visible = true;
            this.colEdinecnaMerka.VisibleIndex = 1;
            this.colEdinecnaMerka.Width = 115;
            // 
            // colDDVIznos
            // 
            this.colDDVIznos.Caption = "ДДВ Износ";
            this.colDDVIznos.FieldName = "DDVIznos";
            this.colDDVIznos.Name = "colDDVIznos";
            this.colDDVIznos.OptionsColumn.ReadOnly = true;
            this.colDDVIznos.Visible = true;
            this.colDDVIznos.VisibleIndex = 8;
            this.colDDVIznos.Width = 115;
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
            this.colIznosBezDDV.VisibleIndex = 7;
            this.colIznosBezDDV.Width = 115;
            // 
            // colCenaSoRabatIddv
            // 
            this.colCenaSoRabatIddv.Caption = "Цена со рабат и ДДВ";
            this.colCenaSoRabatIddv.FieldName = "CenaSoRabatIddv";
            this.colCenaSoRabatIddv.Name = "colCenaSoRabatIddv";
            this.colCenaSoRabatIddv.OptionsColumn.ReadOnly = true;
            this.colCenaSoRabatIddv.Visible = true;
            this.colCenaSoRabatIddv.VisibleIndex = 4;
            this.colCenaSoRabatIddv.Width = 115;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 2;
            this.colKolicina.Width = 115;
            // 
            // colCena
            // 
            this.colCena.Caption = "Цена";
            this.colCena.FieldName = "Cena";
            this.colCena.Name = "colCena";
            this.colCena.Visible = true;
            this.colCena.VisibleIndex = 3;
            this.colCena.Width = 115;
            // 
            // colRabat1
            // 
            this.colRabat1.Caption = "Рабат";
            this.colRabat1.FieldName = "Rabat1";
            this.colRabat1.Name = "colRabat1";
            this.colRabat1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rabat1", "{0:0.##}")});
            this.colRabat1.Visible = true;
            this.colRabat1.VisibleIndex = 5;
            this.colRabat1.Width = 115;
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
            this.colIznos.Width = 121;
            // 
            // colTipNaDokumentID
            // 
            this.colTipNaDokumentID.Caption = "Реден број на тип на докумен";
            this.colTipNaDokumentID.FieldName = "TipNaDokumentID";
            this.colTipNaDokumentID.Name = "colTipNaDokumentID";
            // 
            // colNazivNaProdukt
            // 
            this.colNazivNaProdukt.Caption = "Назив на Артикал";
            this.colNazivNaProdukt.FieldName = "NazivNaProdukt";
            this.colNazivNaProdukt.Name = "colNazivNaProdukt";
            this.colNazivNaProdukt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NazivNaProdukt", "{0}")});
            this.colNazivNaProdukt.Visible = true;
            this.colNazivNaProdukt.VisibleIndex = 0;
            this.colNazivNaProdukt.Width = 271;
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel1.Location = new System.Drawing.Point(328, 21);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(114, 13);
            this.bsslabel1.TabIndex = 6;
            this.bsslabel1.Text = "Број на документ:";
            // 
            // txBroj
            // 
            this.txBroj.AutoSize = true;
            this.txBroj.Location = new System.Drawing.Point(450, 19);
            this.txBroj.Name = "txBroj";
            this.txBroj.Size = new System.Drawing.Size(10, 13);
            this.txBroj.TabIndex = 7;
            this.txBroj.Text = "-";
            // 
            // txtIznos
            // 
            this.txtIznos.AutoSize = true;
            this.txtIznos.Location = new System.Drawing.Point(450, 46);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(10, 13);
            this.txtIznos.TabIndex = 9;
            this.txtIznos.Text = "-";
            // 
            // bsslabel3
            // 
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel3.Location = new System.Drawing.Point(328, 48);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(98, 13);
            this.bsslabel3.TabIndex = 8;
            this.bsslabel3.Text = "Износ со ДДВ:";
            // 
            // txtTip
            // 
            this.txtTip.AutoSize = true;
            this.txtTip.Location = new System.Drawing.Point(450, 72);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(10, 13);
            this.txtTip.TabIndex = 11;
            this.txtTip.Text = "-";
            // 
            // bsslabel5
            // 
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel5.Location = new System.Drawing.Point(328, 75);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(111, 13);
            this.bsslabel5.TabIndex = 10;
            this.bsslabel5.Text = "Тип на документ:";
            // 
            // txtObjekt
            // 
            this.txtObjekt.AutoSize = true;
            this.txtObjekt.Location = new System.Drawing.Point(450, 100);
            this.txtObjekt.Name = "txtObjekt";
            this.txtObjekt.Size = new System.Drawing.Size(10, 13);
            this.txtObjekt.TabIndex = 13;
            this.txtObjekt.Text = "-";
            // 
            // bsslabel7
            // 
            this.bsslabel7.AutoSize = true;
            this.bsslabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel7.Location = new System.Drawing.Point(328, 102);
            this.bsslabel7.Name = "bsslabel7";
            this.bsslabel7.Size = new System.Drawing.Size(68, 13);
            this.bsslabel7.TabIndex = 12;
            this.bsslabel7.Text = "Од објект:";
            // 
            // bsslabel8
            // 
            this.bsslabel8.AutoSize = true;
            this.bsslabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel8.Location = new System.Drawing.Point(328, 129);
            this.bsslabel8.Name = "bsslabel8";
            this.bsslabel8.Size = new System.Drawing.Size(69, 13);
            this.bsslabel8.TabIndex = 14;
            this.bsslabel8.Text = "До објект:";
            // 
            // txtDoObjekt
            // 
            this.txtDoObjekt.AutoSize = true;
            this.txtDoObjekt.Location = new System.Drawing.Point(450, 123);
            this.txtDoObjekt.Name = "txtDoObjekt";
            this.txtDoObjekt.Size = new System.Drawing.Size(10, 13);
            this.txtDoObjekt.TabIndex = 15;
            this.txtDoObjekt.Text = "-";
            // 
            // bsslabel10
            // 
            this.bsslabel10.AutoSize = true;
            this.bsslabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel10.Location = new System.Drawing.Point(328, 156);
            this.bsslabel10.Name = "bsslabel10";
            this.bsslabel10.Size = new System.Drawing.Size(49, 13);
            this.bsslabel10.TabIndex = 16;
            this.bsslabel10.Text = "Датум:";
            // 
            // txtDatum
            // 
            this.txtDatum.AutoSize = true;
            this.txtDatum.Location = new System.Drawing.Point(450, 156);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(10, 13);
            this.txtDatum.TabIndex = 17;
            this.txtDatum.Text = "-";
            // 
            // btnPotvrdi1
            // 
            this.btnPotvrdi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi1.Image = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi1.Image")));
            this.btnPotvrdi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi1.Location = new System.Drawing.Point(317, 244);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(226, 38);
            this.btnPotvrdi1.TabIndex = 18;
            this.btnPotvrdi1.Text = "Превземи неуспешно пратени документи";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbServer.C_OnlyNumbers = false;
            this.cmbServer.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbServer.CurrentText = null;
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.DtTableName = null;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(317, 217);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(226, 21);
            this.cmbServer.TabIndex = 19;
            this.cmbServer.value = null;
            // 
            // btnPLT
            // 
            this.btnPLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPLT.BackColor = System.Drawing.Color.LightCoral;
            this.btnPLT.Enabled = false;
            this.btnPLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPLT.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPLT.Location = new System.Drawing.Point(714, 89);
            this.btnPLT.Name = "btnPLT";
            this.btnPLT.Size = new System.Drawing.Size(215, 79);
            this.btnPLT.TabIndex = 33;
            this.btnPLT.Text = "ПЛТ";
            this.btnPLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPLT.UseVisualStyleBackColor = false;
            this.btnPLT.Click += new System.EventHandler(this.btnPLT_Click);
            // 
            // btnPecati
            // 
            this.btnPecati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPecati.BackColor = System.Drawing.Color.LightCoral;
            this.btnPecati.Enabled = false;
            this.btnPecati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPecati.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPecati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati.Location = new System.Drawing.Point(714, 4);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(215, 79);
            this.btnPecati.TabIndex = 34;
            this.btnPecati.Text = "Предатница";
            this.btnPecati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // frmElektronskiPriemNaDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 608);
            this.Controls.Add(this.btnPecati);
            this.Controls.Add(this.btnPLT);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.btnPotvrdi1);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.bsslabel10);
            this.Controls.Add(this.txtDoObjekt);
            this.Controls.Add(this.bsslabel8);
            this.Controls.Add(this.txtObjekt);
            this.Controls.Add(this.bsslabel7);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.bsslabel5);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.bsslabel3);
            this.Controls.Add(this.txBroj);
            this.Controls.Add(this.bsslabel1);
            this.Controls.Add(this.viewDokumentiStavkigrd);
            this.Controls.Add(this.btnЗапиши);
            this.Controls.Add(this.listView1);
            this.Name = "frmElektronskiPriemNaDokumenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.frmElektronskiPriemNaDokumenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkigrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private BssBase.Elements.btnPotvrdi btnЗапиши;
        private BssBase.DevGrid viewDokumentiStavkigrd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn coltblDokumentID;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colTipNadokument;
        private DevExpress.XtraGrid.Columns.GridColumn colArikalNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colArtikalID;
        private DevExpress.XtraGrid.Columns.GridColumn colNormativNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colNormativID;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVStapka;
        private DevExpress.XtraGrid.Columns.GridColumn colEdinecnaMerka;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaSoRabatIddv;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colCena;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat1;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colTipNaDokumentID;
        private DevExpress.XtraGrid.Columns.GridColumn colNazivNaProdukt;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.Elements.Bsslabel txBroj;
        private BssBase.Elements.Bsslabel txtIznos;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.Elements.Bsslabel txtTip;
        private BssBase.Elements.Bsslabel bsslabel5;
        private BssBase.Elements.Bsslabel txtObjekt;
        private BssBase.Elements.Bsslabel bsslabel7;
        private BssBase.Elements.Bsslabel bsslabel8;
        private BssBase.Elements.Bsslabel txtDoObjekt;
        private BssBase.Elements.Bsslabel bsslabel10;
        private BssBase.Elements.Bsslabel txtDatum;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.cmbBase cmbServer;
        private System.Windows.Forms.Button btnPLT;
        private System.Windows.Forms.Button btnPecati;
    }
}
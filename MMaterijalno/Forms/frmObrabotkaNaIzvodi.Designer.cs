namespace MMaterijalno.Forms
{
    partial class frmObrabotkaNaIzvodi
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label brojNaIzvodLabel;
            System.Windows.Forms.Label zabeleskaLabel;
            System.Windows.Forms.Label smetkaLabel;
            System.Windows.Forms.Label datumNaIzvodLabel;
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPecati = new System.Windows.Forms.Button();
            this.datumNaIzvodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.smetkatxtBase = new BssBase.txtBase();
            this.zabeleskatxtBase = new BssBase.txtBase();
            this.brojNaIzvodtxtBase = new BssBase.txtBase();
            this.btnSocuvajZaglavje = new System.Windows.Forms.Button();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtPartner = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.zbxPartner = new BssBase.zbxBase();
            this.txtPobaruva = new BssBase.txtBase();
            this.txtDolzi = new BssBase.txtBase();
            this.btnIzbrisiStavka = new System.Windows.Forms.Button();
            this.btnSocuvajStavka = new System.Windows.Forms.Button();
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.viewDokumentiStavkigrd = new BssBase.DevGrid();
            this.viewIzvodiStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblIzvodiID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojNaIzvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaIzvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartnerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDolzi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPobaruva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazivPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewIzvodiStavkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewIzvodiStavkiTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.viewIzvodiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewIzvodiTableAdapter();
            this.viewIzvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            brojNaIzvodLabel = new System.Windows.Forms.Label();
            zabeleskaLabel = new System.Windows.Forms.Label();
            smetkaLabel = new System.Windows.Forms.Label();
            datumNaIzvodLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkigrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainTab.Size = new System.Drawing.Size(929, 544);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Margin = new System.Windows.Forms.Padding(4);
            this.tabVnes.Size = new System.Drawing.Size(921, 518);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.viewDokumentiStavkigrd);
            this.groupVnes.Controls.Add(this.xtraTabControl1);
            this.groupVnes.Location = new System.Drawing.Point(3, -5);
            this.groupVnes.Margin = new System.Windows.Forms.Padding(4);
            this.groupVnes.Padding = new System.Windows.Forms.Padding(4);
            this.groupVnes.Size = new System.Drawing.Size(918, 523);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 543);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.PanelFooter.Size = new System.Drawing.Size(933, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 2);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.MinimumSize = new System.Drawing.Size(176, 47);
            this.btnZatvori.Size = new System.Drawing.Size(176, 47);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(732, 2);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.MinimumSize = new System.Drawing.Size(176, 47);
            this.btnOk.Size = new System.Drawing.Size(176, 47);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(659, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 13);
            label3.TabIndex = 60;
            label3.Text = "Побарува:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(677, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 59;
            label2.Text = "Должи :";
            // 
            // brojNaIzvodLabel
            // 
            brojNaIzvodLabel.AutoSize = true;
            brojNaIzvodLabel.Location = new System.Drawing.Point(11, 9);
            brojNaIzvodLabel.Name = "brojNaIzvodLabel";
            brojNaIzvodLabel.Size = new System.Drawing.Size(80, 13);
            brojNaIzvodLabel.TabIndex = 7;
            brojNaIzvodLabel.Text = "Број на извод:";
            // 
            // zabeleskaLabel
            // 
            zabeleskaLabel.AutoSize = true;
            zabeleskaLabel.Location = new System.Drawing.Point(11, 92);
            zabeleskaLabel.Name = "zabeleskaLabel";
            zabeleskaLabel.Size = new System.Drawing.Size(67, 13);
            zabeleskaLabel.TabIndex = 8;
            zabeleskaLabel.Text = "Забелешка:";
            // 
            // smetkaLabel
            // 
            smetkaLabel.AutoSize = true;
            smetkaLabel.Location = new System.Drawing.Point(11, 51);
            smetkaLabel.Name = "smetkaLabel";
            smetkaLabel.Size = new System.Drawing.Size(48, 13);
            smetkaLabel.TabIndex = 9;
            smetkaLabel.Text = "Сметка:";
            // 
            // datumNaIzvodLabel
            // 
            datumNaIzvodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            datumNaIzvodLabel.AutoSize = true;
            datumNaIzvodLabel.Location = new System.Drawing.Point(437, 7);
            datumNaIzvodLabel.Name = "datumNaIzvodLabel";
            datumNaIzvodLabel.Size = new System.Drawing.Size(91, 13);
            datumNaIzvodLabel.TabIndex = 10;
            datumNaIzvodLabel.Text = "Датум на извод:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 20);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(916, 245);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.btnPecati);
            this.xtraTabPage1.Controls.Add(datumNaIzvodLabel);
            this.xtraTabPage1.Controls.Add(this.datumNaIzvodDateTimePicker);
            this.xtraTabPage1.Controls.Add(smetkaLabel);
            this.xtraTabPage1.Controls.Add(this.smetkatxtBase);
            this.xtraTabPage1.Controls.Add(zabeleskaLabel);
            this.xtraTabPage1.Controls.Add(this.zabeleskatxtBase);
            this.xtraTabPage1.Controls.Add(brojNaIzvodLabel);
            this.xtraTabPage1.Controls.Add(this.brojNaIzvodtxtBase);
            this.xtraTabPage1.Controls.Add(this.btnSocuvajZaglavje);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(914, 220);
            this.xtraTabPage1.Text = "Заглавје на извод";
            // 
            // btnPecati
            // 
            this.btnPecati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPecati.BackColor = System.Drawing.Color.Transparent;
            this.btnPecati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPecati.Image = global::MMaterijalno.Properties.Resources.pecati;
            this.btnPecati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecati.Location = new System.Drawing.Point(737, 136);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(174, 79);
            this.btnPecati.TabIndex = 24;
            this.btnPecati.Text = "Печати";
            this.btnPecati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // datumNaIzvodDateTimePicker
            // 
            this.datumNaIzvodDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumNaIzvodDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.datumNaIzvodDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumNaIzvodDateTimePicker.Location = new System.Drawing.Point(641, 9);
            this.datumNaIzvodDateTimePicker.Name = "datumNaIzvodDateTimePicker";
            this.datumNaIzvodDateTimePicker.Size = new System.Drawing.Size(146, 29);
            this.datumNaIzvodDateTimePicker.TabIndex = 1;
            // 
            // smetkatxtBase
            // 
            this.smetkatxtBase.AssemblyStr = null;
            this.smetkatxtBase.C_FillWithZeros = false;
            this.smetkatxtBase.C_OnlyNumbers = false;
            this.smetkatxtBase.C_RegEx = false;
            this.smetkatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.smetkatxtBase.ColumnName1 = null;
            this.smetkatxtBase.ColumnName2 = null;
            this.smetkatxtBase.ColumnName3 = null;
            this.smetkatxtBase.ColumnName4 = null;
            this.smetkatxtBase.ColumnName5 = null;
            this.smetkatxtBase.ColumnName6 = null;
            this.smetkatxtBase.ColumnName7 = null;
            this.smetkatxtBase.daliCetiri = false;
            this.smetkatxtBase.Format = null;
            this.smetkatxtBase.formToOpen = null;
            this.smetkatxtBase.iscistiGreenNaLeave = false;
            this.smetkatxtBase.KoristiFilterNaDatasource = false;
            this.smetkatxtBase.Location = new System.Drawing.Point(194, 51);
            this.smetkatxtBase.MakedonskiJazik = false;
            this.smetkatxtBase.MinLength = 0;
            this.smetkatxtBase.Name = "smetkatxtBase";
            this.smetkatxtBase.PopulateOtherFields = false;
            this.smetkatxtBase.regularExpression = null;
            this.smetkatxtBase.SelektrijaNaFokus = false;
            this.smetkatxtBase.Size = new System.Drawing.Size(433, 21);
            this.smetkatxtBase.TabIndex = 2;
            // 
            // zabeleskatxtBase
            // 
            this.zabeleskatxtBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zabeleskatxtBase.AssemblyStr = null;
            this.zabeleskatxtBase.C_FillWithZeros = false;
            this.zabeleskatxtBase.C_OnlyNumbers = false;
            this.zabeleskatxtBase.C_RegEx = false;
            this.zabeleskatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.zabeleskatxtBase.ColumnName1 = null;
            this.zabeleskatxtBase.ColumnName2 = null;
            this.zabeleskatxtBase.ColumnName3 = null;
            this.zabeleskatxtBase.ColumnName4 = null;
            this.zabeleskatxtBase.ColumnName5 = null;
            this.zabeleskatxtBase.ColumnName6 = null;
            this.zabeleskatxtBase.ColumnName7 = null;
            this.zabeleskatxtBase.daliCetiri = false;
            this.zabeleskatxtBase.Format = null;
            this.zabeleskatxtBase.formToOpen = null;
            this.zabeleskatxtBase.iscistiGreenNaLeave = false;
            this.zabeleskatxtBase.KoristiFilterNaDatasource = false;
            this.zabeleskatxtBase.Location = new System.Drawing.Point(194, 92);
            this.zabeleskatxtBase.MakedonskiJazik = false;
            this.zabeleskatxtBase.MinLength = 0;
            this.zabeleskatxtBase.Multiline = true;
            this.zabeleskatxtBase.Name = "zabeleskatxtBase";
            this.zabeleskatxtBase.PopulateOtherFields = false;
            this.zabeleskatxtBase.regularExpression = null;
            this.zabeleskatxtBase.SelektrijaNaFokus = false;
            this.zabeleskatxtBase.Size = new System.Drawing.Size(437, 35);
            this.zabeleskatxtBase.TabIndex = 3;
            // 
            // brojNaIzvodtxtBase
            // 
            this.brojNaIzvodtxtBase.AssemblyStr = null;
            this.brojNaIzvodtxtBase.C_FillWithZeros = false;
            this.brojNaIzvodtxtBase.C_OnlyNumbers = false;
            this.brojNaIzvodtxtBase.C_RegEx = false;
            this.brojNaIzvodtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.brojNaIzvodtxtBase.ColumnName1 = null;
            this.brojNaIzvodtxtBase.ColumnName2 = null;
            this.brojNaIzvodtxtBase.ColumnName3 = null;
            this.brojNaIzvodtxtBase.ColumnName4 = null;
            this.brojNaIzvodtxtBase.ColumnName5 = null;
            this.brojNaIzvodtxtBase.ColumnName6 = null;
            this.brojNaIzvodtxtBase.ColumnName7 = null;
            this.brojNaIzvodtxtBase.daliCetiri = false;
            this.brojNaIzvodtxtBase.Format = null;
            this.brojNaIzvodtxtBase.formToOpen = null;
            this.brojNaIzvodtxtBase.iscistiGreenNaLeave = false;
            this.brojNaIzvodtxtBase.KoristiFilterNaDatasource = false;
            this.brojNaIzvodtxtBase.Location = new System.Drawing.Point(194, 9);
            this.brojNaIzvodtxtBase.MakedonskiJazik = false;
            this.brojNaIzvodtxtBase.MinLength = 0;
            this.brojNaIzvodtxtBase.Name = "brojNaIzvodtxtBase";
            this.brojNaIzvodtxtBase.PopulateOtherFields = false;
            this.brojNaIzvodtxtBase.regularExpression = null;
            this.brojNaIzvodtxtBase.SelektrijaNaFokus = false;
            this.brojNaIzvodtxtBase.Size = new System.Drawing.Size(233, 21);
            this.brojNaIzvodtxtBase.TabIndex = 0;
            // 
            // btnSocuvajZaglavje
            // 
            this.btnSocuvajZaglavje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSocuvajZaglavje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocuvajZaglavje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSocuvajZaglavje.Image = global::MMaterijalno.Properties.Resources.accept;
            this.btnSocuvajZaglavje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajZaglavje.Location = new System.Drawing.Point(16, 133);
            this.btnSocuvajZaglavje.Name = "btnSocuvajZaglavje";
            this.btnSocuvajZaglavje.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajZaglavje.TabIndex = 4;
            this.btnSocuvajZaglavje.Text = "Сочувај заглавје";
            this.btnSocuvajZaglavje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocuvajZaglavje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSocuvajZaglavje.UseVisualStyleBackColor = false;
            this.btnSocuvajZaglavje.Click += new System.EventHandler(this.btnSocuvajZaglavje_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtPartner);
            this.xtraTabPage2.Controls.Add(this.bsslabel1);
            this.xtraTabPage2.Controls.Add(this.zbxPartner);
            this.xtraTabPage2.Controls.Add(label3);
            this.xtraTabPage2.Controls.Add(this.txtPobaruva);
            this.xtraTabPage2.Controls.Add(label2);
            this.xtraTabPage2.Controls.Add(this.txtDolzi);
            this.xtraTabPage2.Controls.Add(this.btnIzbrisiStavka);
            this.xtraTabPage2.Controls.Add(this.btnSocuvajStavka);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(914, 220);
            this.xtraTabPage2.Text = "Внес на ставки во извод";
            // 
            // txtPartner
            // 
            this.txtPartner.AssemblyStr = null;
            this.txtPartner.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPartner.C_FillWithZeros = false;
            this.txtPartner.C_OnlyNumbers = false;
            this.txtPartner.C_RegEx = false;
            this.txtPartner.C_ShowRedOnLeaveIfEmpty = false;
            this.txtPartner.ColumnName1 = null;
            this.txtPartner.ColumnName2 = null;
            this.txtPartner.ColumnName3 = null;
            this.txtPartner.ColumnName4 = null;
            this.txtPartner.ColumnName5 = null;
            this.txtPartner.ColumnName6 = null;
            this.txtPartner.ColumnName7 = null;
            this.txtPartner.daliCetiri = false;
            this.txtPartner.ForeColor = System.Drawing.Color.Blue;
            this.txtPartner.Format = null;
            this.txtPartner.formToOpen = null;
            this.txtPartner.iscistiGreenNaLeave = false;
            this.txtPartner.KoristiFilterNaDatasource = false;
            this.txtPartner.Location = new System.Drawing.Point(240, 10);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(663, 31);
            this.txtPartner.TabIndex = 62;
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bsslabel1.Location = new System.Drawing.Point(6, 13);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(79, 20);
            this.bsslabel1.TabIndex = 63;
            this.bsslabel1.Text = "Партнер:";
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
            this.zbxPartner.Location = new System.Drawing.Point(91, 3);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(123, 28);
            this.zbxPartner.TabIndex = 0;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validated += new System.EventHandler(this.zbxPartner_Validated);
            // 
            // txtPobaruva
            // 
            this.txtPobaruva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPobaruva.AssemblyStr = null;
            this.txtPobaruva.C_FillWithZeros = false;
            this.txtPobaruva.C_OnlyNumbers = true;
            this.txtPobaruva.C_RegEx = false;
            this.txtPobaruva.C_ShowRedOnLeaveIfEmpty = false;
            this.txtPobaruva.ColumnName1 = null;
            this.txtPobaruva.ColumnName2 = null;
            this.txtPobaruva.ColumnName3 = null;
            this.txtPobaruva.ColumnName4 = null;
            this.txtPobaruva.ColumnName5 = null;
            this.txtPobaruva.ColumnName6 = null;
            this.txtPobaruva.ColumnName7 = null;
            this.txtPobaruva.daliCetiri = false;
            this.txtPobaruva.Format = null;
            this.txtPobaruva.formToOpen = null;
            this.txtPobaruva.iscistiGreenNaLeave = false;
            this.txtPobaruva.KoristiFilterNaDatasource = false;
            this.txtPobaruva.Location = new System.Drawing.Point(751, 77);
            this.txtPobaruva.MakedonskiJazik = false;
            this.txtPobaruva.MinLength = 0;
            this.txtPobaruva.Multiline = true;
            this.txtPobaruva.Name = "txtPobaruva";
            this.txtPobaruva.PopulateOtherFields = false;
            this.txtPobaruva.regularExpression = null;
            this.txtPobaruva.SelektrijaNaFokus = false;
            this.txtPobaruva.Size = new System.Drawing.Size(156, 26);
            this.txtPobaruva.TabIndex = 2;
            this.txtPobaruva.TabStop = false;
            this.txtPobaruva.Tag = "";
            this.txtPobaruva.Text = "0,0";
            // 
            // txtDolzi
            // 
            this.txtDolzi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDolzi.AssemblyStr = null;
            this.txtDolzi.C_FillWithZeros = false;
            this.txtDolzi.C_OnlyNumbers = true;
            this.txtDolzi.C_RegEx = false;
            this.txtDolzi.C_ShowRedOnLeaveIfEmpty = false;
            this.txtDolzi.ColumnName1 = null;
            this.txtDolzi.ColumnName2 = null;
            this.txtDolzi.ColumnName3 = null;
            this.txtDolzi.ColumnName4 = null;
            this.txtDolzi.ColumnName5 = null;
            this.txtDolzi.ColumnName6 = null;
            this.txtDolzi.ColumnName7 = null;
            this.txtDolzi.daliCetiri = false;
            this.txtDolzi.Format = null;
            this.txtDolzi.formToOpen = null;
            this.txtDolzi.iscistiGreenNaLeave = false;
            this.txtDolzi.KoristiFilterNaDatasource = false;
            this.txtDolzi.Location = new System.Drawing.Point(751, 46);
            this.txtDolzi.MakedonskiJazik = false;
            this.txtDolzi.MinLength = 0;
            this.txtDolzi.Multiline = true;
            this.txtDolzi.Name = "txtDolzi";
            this.txtDolzi.PopulateOtherFields = false;
            this.txtDolzi.regularExpression = null;
            this.txtDolzi.SelektrijaNaFokus = false;
            this.txtDolzi.Size = new System.Drawing.Size(156, 25);
            this.txtDolzi.TabIndex = 1;
            this.txtDolzi.TabStop = false;
            this.txtDolzi.Tag = "";
            this.txtDolzi.Text = "0,0";
            // 
            // btnIzbrisiStavka
            // 
            this.btnIzbrisiStavka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzbrisiStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzbrisiStavka.Image = global::MMaterijalno.Properties.Resources.delete;
            this.btnIzbrisiStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzbrisiStavka.Location = new System.Drawing.Point(8, 127);
            this.btnIzbrisiStavka.Name = "btnIzbrisiStavka";
            this.btnIzbrisiStavka.Size = new System.Drawing.Size(226, 79);
            this.btnIzbrisiStavka.TabIndex = 4;
            this.btnIzbrisiStavka.Text = "Избриши ставка";
            this.btnIzbrisiStavka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzbrisiStavka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzbrisiStavka.UseVisualStyleBackColor = false;
            this.btnIzbrisiStavka.Click += new System.EventHandler(this.btnIzbrisiStavka_Click);
            // 
            // btnSocuvajStavka
            // 
            this.btnSocuvajStavka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSocuvajStavka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSocuvajStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocuvajStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSocuvajStavka.Image = global::MMaterijalno.Properties.Resources.add_1_icon__1_;
            this.btnSocuvajStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajStavka.Location = new System.Drawing.Point(681, 127);
            this.btnSocuvajStavka.Name = "btnSocuvajStavka";
            this.btnSocuvajStavka.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajStavka.TabIndex = 3;
            this.btnSocuvajStavka.Text = "Внеси плаќање";
            this.btnSocuvajStavka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocuvajStavka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSocuvajStavka.UseVisualStyleBackColor = false;
            this.btnSocuvajStavka.Click += new System.EventHandler(this.btnSocuvajStavka_Click);
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDokumentiStavkigrd
            // 
            this.viewDokumentiStavkigrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDokumentiStavkigrd.AssemblyToLoad = null;
            this.viewDokumentiStavkigrd.DataSource = this.viewIzvodiStavkiBindingSource;
            this.viewDokumentiStavkigrd.EditForm = null;
            this.viewDokumentiStavkigrd.FilterForm = null;
            this.viewDokumentiStavkigrd.Location = new System.Drawing.Point(5, 271);
            this.viewDokumentiStavkigrd.MainView = this.gridView1;
            this.viewDokumentiStavkigrd.Name = "viewDokumentiStavkigrd";
            this.viewDokumentiStavkigrd.PrimaryKey = null;
            this.viewDokumentiStavkigrd.reportCenter = false;
            this.viewDokumentiStavkigrd.ReportName = null;
            this.viewDokumentiStavkigrd.Size = new System.Drawing.Size(910, 246);
            this.viewDokumentiStavkigrd.TabIndex = 1;
            this.viewDokumentiStavkigrd.UpdateTable = null;
            this.viewDokumentiStavkigrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewIzvodiStavkiBindingSource
            // 
            this.viewIzvodiStavkiBindingSource.DataMember = "viewIzvodiStavki";
            this.viewIzvodiStavkiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.coltblIzvodiID,
            this.colBrojNaIzvod,
            this.colDatumNaIzvod,
            this.colPartnerID,
            this.colDolzi,
            this.colPobaruva,
            this.colIznosDokument,
            this.colTipNaDokument,
            this.colBrojNaDokument,
            this.colSifraPartner,
            this.colNazivPartner});
            this.gridView1.GridControl = this.viewDokumentiStavkigrd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // coltblIzvodiID
            // 
            this.coltblIzvodiID.Caption = "Реден број извод";
            this.coltblIzvodiID.FieldName = "tblIzvodiID";
            this.coltblIzvodiID.Name = "coltblIzvodiID";
            // 
            // colBrojNaIzvod
            // 
            this.colBrojNaIzvod.Caption = "Број на извод";
            this.colBrojNaIzvod.FieldName = "BrojNaIzvod";
            this.colBrojNaIzvod.Name = "colBrojNaIzvod";
            // 
            // colDatumNaIzvod
            // 
            this.colDatumNaIzvod.Caption = "Датум на извод";
            this.colDatumNaIzvod.FieldName = "DatumNaIzvod";
            this.colDatumNaIzvod.Name = "colDatumNaIzvod";
            // 
            // colPartnerID
            // 
            this.colPartnerID.Caption = "Реден број на Партнер";
            this.colPartnerID.FieldName = "PartnerID";
            this.colPartnerID.Name = "colPartnerID";
            // 
            // colDolzi
            // 
            this.colDolzi.Caption = "Должи";
            this.colDolzi.FieldName = "Dolzi";
            this.colDolzi.Name = "colDolzi";
            this.colDolzi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dolzi", "{0:0.##}")});
            this.colDolzi.Visible = true;
            this.colDolzi.VisibleIndex = 5;
            // 
            // colPobaruva
            // 
            this.colPobaruva.Caption = "Побарува";
            this.colPobaruva.FieldName = "Pobaruva";
            this.colPobaruva.Name = "colPobaruva";
            this.colPobaruva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pobaruva", "{0:0.##}")});
            this.colPobaruva.Visible = true;
            this.colPobaruva.VisibleIndex = 6;
            // 
            // colIznosDokument
            // 
            this.colIznosDokument.Caption = "Износ на Документ";
            this.colIznosDokument.FieldName = "IznosDokument";
            this.colIznosDokument.Name = "colIznosDokument";
            this.colIznosDokument.OptionsColumn.ReadOnly = true;
            this.colIznosDokument.Visible = true;
            this.colIznosDokument.VisibleIndex = 3;
            // 
            // colTipNaDokument
            // 
            this.colTipNaDokument.Caption = "Тип на документ";
            this.colTipNaDokument.FieldName = "TipNaDokument";
            this.colTipNaDokument.Name = "colTipNaDokument";
            this.colTipNaDokument.Visible = true;
            this.colTipNaDokument.VisibleIndex = 4;
            // 
            // colBrojNaDokument
            // 
            this.colBrojNaDokument.Caption = "Број на документ";
            this.colBrojNaDokument.FieldName = "BrojNaDokument";
            this.colBrojNaDokument.Name = "colBrojNaDokument";
            this.colBrojNaDokument.Visible = true;
            this.colBrojNaDokument.VisibleIndex = 2;
            // 
            // colSifraPartner
            // 
            this.colSifraPartner.Caption = "Шифра партнер";
            this.colSifraPartner.FieldName = "SifraPartner";
            this.colSifraPartner.Name = "colSifraPartner";
            this.colSifraPartner.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SifraPartner", "{0}")});
            this.colSifraPartner.Visible = true;
            this.colSifraPartner.VisibleIndex = 0;
            // 
            // colNazivPartner
            // 
            this.colNazivPartner.Caption = "Назив партнер";
            this.colNazivPartner.FieldName = "NazivPartner";
            this.colNazivPartner.Name = "colNazivPartner";
            this.colNazivPartner.Visible = true;
            this.colNazivPartner.VisibleIndex = 1;
            // 
            // viewIzvodiStavkiTableAdapter
            // 
            this.viewIzvodiStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.General_data_mesecTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoHvacTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPlacanjaOdPartnerTableAdapter = null;
            this.tableAdapterManager.tblPriemStavkiTableAdapter = null;
            this.tableAdapterManager.tblPriemTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewDokumentiStavkiTableAdapter = null;
            this.tableAdapterManager.viewDokumentiTableAdapter = null;
            this.tableAdapterManager.viewIzvodiTableAdapter = this.viewIzvodiTableAdapter;
            this.tableAdapterManager.viewPriemiTableAdapter = null;
            this.tableAdapterManager.viewPriemStavkiTableAdapter = null;
            this.tableAdapterManager.vPriemiKnizenjeTableAdapter = null;
            this.tableAdapterManager.vSmetkaKnizenjeTableAdapter = null;
            // 
            // viewIzvodiTableAdapter
            // 
            this.viewIzvodiTableAdapter.ClearBeforeFill = true;
            // 
            // viewIzvodiBindingSource
            // 
            this.viewIzvodiBindingSource.DataMember = "viewIzvodi";
            this.viewIzvodiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // frmObrabotkaNaIzvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 612);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(827, 319);
            this.Name = "frmObrabotkaNaIzvodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изводи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmObrabotkaNaIzvodi_Load);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkigrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewIzvodiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Button btnSocuvajZaglavje;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BssBase.txtBase txtPobaruva;
        private BssBase.txtBase txtDolzi;
        private System.Windows.Forms.Button btnIzbrisiStavka;
        private System.Windows.Forms.Button btnSocuvajStavka;
        private BssBase.DevGrid viewDokumentiStavkigrd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource viewIzvodiStavkiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewIzvodiStavkiTableAdapter viewIzvodiStavkiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn coltblIzvodiID;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaIzvod;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaIzvod;
        private DevExpress.XtraGrid.Columns.GridColumn colPartnerID;
        private DevExpress.XtraGrid.Columns.GridColumn colDolzi;
        private DevExpress.XtraGrid.Columns.GridColumn colPobaruva;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colTipNaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojNaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colNazivPartner;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterijalnoDataSetTableAdapters.viewIzvodiTableAdapter viewIzvodiTableAdapter;
        private System.Windows.Forms.BindingSource viewIzvodiBindingSource;
        private System.Windows.Forms.DateTimePicker datumNaIzvodDateTimePicker;
        private BssBase.txtBase smetkatxtBase;
        private BssBase.txtBase zabeleskatxtBase;
        private BssBase.txtBase brojNaIzvodtxtBase;
        private BssBase.txtBase txtPartner;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.zbxBase zbxPartner;
        private System.Windows.Forms.Button btnPecati;
    }
}
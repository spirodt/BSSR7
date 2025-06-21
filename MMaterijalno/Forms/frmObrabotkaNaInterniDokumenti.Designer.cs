namespace MMaterijalno.Forms
{
    partial class frmObrabotkaNaInterniDokumenti
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label zabeleskaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label brojLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rabat1Label = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnDogovori = new System.Windows.Forms.Button();
            this.dtPeriod = new System.Windows.Forms.DateTimePicker();
            this.viewDokumentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.dtValuta = new System.Windows.Forms.DateTimePicker();
            this.btnPLT = new System.Windows.Forms.Button();
            this.txtBrojNaDokumentFra = new BssBase.txtBase();
            this.txtPartner = new BssBase.txtBase();
            this.zbxPartner = new BssBase.zbxBase();
            this.brojTextBox = new BssBase.txtBase();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zabeleskatxtBase = new BssBase.txtBase();
            this.bsslabel4 = new BssBase.Elements.Bsslabel();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.cmbDoObjekt = new BssBase.cmbBase();
            this.cmbOdObjekt = new BssBase.cmbBase();
            this.cmbTipNaDokument = new BssBase.cmbBase();
            this.btnSocuvajZaglavje = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtNotesNumber = new BssBase.txtBase();
            this.txtNotesText = new BssBase.txtBase();
            this.chkDopolnitenoInoInfo = new System.Windows.Forms.CheckBox();
            this.lblInfo = new BssBase.Elements.Bsslabel();
            this.txtCenaBezDDV = new BssBase.txtBase();
            this.txtSoDDV = new BssBase.txtBase();
            this.rabat1txtBase = new BssBase.txtBase();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcena = new BssBase.txtBase();
            this.txtBase1 = new BssBase.txtBase();
            this.iznostxtBase = new BssBase.txtBase();
            this.btnSearchArtikal = new System.Windows.Forms.Button();
            this.txtArtikalSearch = new BssBase.txtBase();
            this.txtDDV = new BssBase.txtBase();
            this.txtEDM = new BssBase.txtBase();
            this.txtArtikalNaziv = new BssBase.txtBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.kolicinatxtBase = new BssBase.txtBase();
            this.btnIzbrisiStavka = new System.Windows.Forms.Button();
            this.btnSocuvajStavka = new System.Windows.Forms.Button();
            this.viewDokumentiStavkigrd = new BssBase.DevGrid();
            this.viewDokumentiStavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.colAltSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProsecnaNabavnaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProsecnaNabavnaCenaBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NabavnaVrednostBezDDVIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenaBezDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumNaDokument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotesBroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotesText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaVrednostSoDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewDokumentiStavkiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewDokumentiStavkiTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter();
            this.viewDokumentiTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.viewDokumentiTableAdapter();
            this.pLTobrazecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLTobrazecTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.PLTobrazecTableAdapter();
            this.general_data_mesecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_data_mesecTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.General_data_mesecTableAdapter();
            this.tblDokumentiDetailsInfoHvacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDokumentiDetailsInfoHvacTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoHvacTableAdapter();
            this.tblDokumentiDetailsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDokumentiDetailsInfoTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoTableAdapter();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPartneriTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblPartneriTableAdapter();
            label7 = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            zabeleskaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            brojLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkigrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLTobrazecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_data_mesecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoHvacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(929, 544);
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(921, 518);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.viewDokumentiStavkigrd);
            this.groupVnes.Controls.Add(this.xtraTabControl1);
            this.groupVnes.Size = new System.Drawing.Size(918, 515);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 543);
            this.PanelFooter.Size = new System.Drawing.Size(933, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 2);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(734, 4);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 150);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(84, 13);
            label7.TabIndex = 52;
            label7.Text = "Цена со рабат:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            kolicinaLabel.Location = new System.Drawing.Point(4, 45);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(87, 20);
            kolicinaLabel.TabIndex = 32;
            kolicinaLabel.Text = "Количина:";
            // 
            // zabeleskaLabel
            // 
            zabeleskaLabel.AutoSize = true;
            zabeleskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            zabeleskaLabel.Location = new System.Drawing.Point(488, 49);
            zabeleskaLabel.Name = "zabeleskaLabel";
            zabeleskaLabel.Size = new System.Drawing.Size(114, 24);
            zabeleskaLabel.TabIndex = 31;
            zabeleskaLabel.Text = "Забелешка:";
            // 
            // datumLabel
            // 
            datumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            datumLabel.Location = new System.Drawing.Point(694, 9);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(71, 24);
            datumLabel.TabIndex = 32;
            datumLabel.Text = "Датум:";
            // 
            // brojLabel
            // 
            brojLabel.AutoSize = true;
            brojLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            brojLabel.Location = new System.Drawing.Point(0, 44);
            brojLabel.Name = "brojLabel";
            brojLabel.Size = new System.Drawing.Size(68, 29);
            brojLabel.TabIndex = 35;
            brojLabel.Text = "Број:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label4.Location = new System.Drawing.Point(4, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(154, 24);
            label4.TabIndex = 39;
            label4.Text = "Ф-ра \\ Док број :";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label8.Location = new System.Drawing.Point(369, 118);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(162, 24);
            label8.TabIndex = 44;
            label8.Text = "Датум на валута:";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label9.Location = new System.Drawing.Point(679, 118);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 24);
            label9.TabIndex = 46;
            label9.Text = "Период:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Износ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Продажна Цена ( Без ДДВ ):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Продажна Цена ( Со ДДВ ) :";
            // 
            // rabat1Label
            // 
            this.rabat1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat1Label.AutoSize = true;
            this.rabat1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rabat1Label.Location = new System.Drawing.Point(683, 109);
            this.rabat1Label.Name = "rabat1Label";
            this.rabat1Label.Size = new System.Drawing.Size(59, 20);
            this.rabat1Label.TabIndex = 58;
            this.rabat1Label.Text = "Рабат:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 19);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(912, 302);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.btnDogovori);
            this.xtraTabPage1.Controls.Add(label9);
            this.xtraTabPage1.Controls.Add(this.dtPeriod);
            this.xtraTabPage1.Controls.Add(label8);
            this.xtraTabPage1.Controls.Add(this.dtValuta);
            this.xtraTabPage1.Controls.Add(this.btnPLT);
            this.xtraTabPage1.Controls.Add(label4);
            this.xtraTabPage1.Controls.Add(this.txtBrojNaDokumentFra);
            this.xtraTabPage1.Controls.Add(this.txtPartner);
            this.xtraTabPage1.Controls.Add(this.zbxPartner);
            this.xtraTabPage1.Controls.Add(this.brojTextBox);
            this.xtraTabPage1.Controls.Add(brojLabel);
            this.xtraTabPage1.Controls.Add(datumLabel);
            this.xtraTabPage1.Controls.Add(this.datumDateTimePicker);
            this.xtraTabPage1.Controls.Add(zabeleskaLabel);
            this.xtraTabPage1.Controls.Add(this.zabeleskatxtBase);
            this.xtraTabPage1.Controls.Add(this.bsslabel4);
            this.xtraTabPage1.Controls.Add(this.bsslabel3);
            this.xtraTabPage1.Controls.Add(this.bsslabel1);
            this.xtraTabPage1.Controls.Add(this.cmbDoObjekt);
            this.xtraTabPage1.Controls.Add(this.cmbOdObjekt);
            this.xtraTabPage1.Controls.Add(this.cmbTipNaDokument);
            this.xtraTabPage1.Controls.Add(this.btnSocuvajZaglavje);
            this.xtraTabPage1.Controls.Add(this.btnPecati);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(910, 277);
            this.xtraTabPage1.Text = "Заглавје на документот";
            // 
            // btnDogovori
            // 
            this.btnDogovori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDogovori.BackColor = System.Drawing.Color.LightBlue;
            this.btnDogovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogovori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDogovori.Image = global::MMaterijalno.Properties.Resources.add_1_icon__1_;
            this.btnDogovori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDogovori.Location = new System.Drawing.Point(291, 181);
            this.btnDogovori.Name = "btnDogovori";
            this.btnDogovori.Size = new System.Drawing.Size(159, 79);
            this.btnDogovori.TabIndex = 47;
            this.btnDogovori.Text = "Договор";
            this.btnDogovori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDogovori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDogovori.UseVisualStyleBackColor = false;
            this.btnDogovori.Visible = false;
            this.btnDogovori.Click += new System.EventHandler(this.btnDogovori_Click);
            // 
            // dtPeriod
            // 
            this.dtPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewDokumentiBindingSource, "DatumPeriod", true));
            this.dtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriod.Location = new System.Drawing.Point(769, 118);
            this.dtPeriod.Name = "dtPeriod";
            this.dtPeriod.Size = new System.Drawing.Size(136, 29);
            this.dtPeriod.TabIndex = 45;
            // 
            // viewDokumentiBindingSource
            // 
            this.viewDokumentiBindingSource.DataMember = "viewDokumenti";
            this.viewDokumentiBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtValuta
            // 
            this.dtValuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValuta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewDokumentiBindingSource, "DatumNaValuta", true));
            this.dtValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtValuta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtValuta.Location = new System.Drawing.Point(537, 118);
            this.dtValuta.Name = "dtValuta";
            this.dtValuta.Size = new System.Drawing.Size(136, 29);
            this.dtValuta.TabIndex = 43;
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
            this.btnPLT.Location = new System.Drawing.Point(456, 181);
            this.btnPLT.Name = "btnPLT";
            this.btnPLT.Size = new System.Drawing.Size(140, 79);
            this.btnPLT.TabIndex = 40;
            this.btnPLT.Text = "ПЛТ";
            this.btnPLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPLT.UseVisualStyleBackColor = false;
            this.btnPLT.Click += new System.EventHandler(this.btnPLT_Click);
            // 
            // txtBrojNaDokumentFra
            // 
            this.txtBrojNaDokumentFra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrojNaDokumentFra.AssemblyStr = null;
            this.txtBrojNaDokumentFra.C_FillWithZeros = false;
            this.txtBrojNaDokumentFra.C_OnlyNumbers = false;
            this.txtBrojNaDokumentFra.C_RegEx = false;
            this.txtBrojNaDokumentFra.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBrojNaDokumentFra.ColumnName1 = null;
            this.txtBrojNaDokumentFra.ColumnName2 = null;
            this.txtBrojNaDokumentFra.ColumnName3 = null;
            this.txtBrojNaDokumentFra.ColumnName4 = null;
            this.txtBrojNaDokumentFra.ColumnName5 = null;
            this.txtBrojNaDokumentFra.ColumnName6 = null;
            this.txtBrojNaDokumentFra.ColumnName7 = null;
            this.txtBrojNaDokumentFra.daliCetiri = false;
            this.txtBrojNaDokumentFra.Format = null;
            this.txtBrojNaDokumentFra.formToOpen = null;
            this.txtBrojNaDokumentFra.iscistiGreenNaLeave = false;
            this.txtBrojNaDokumentFra.KoristiFilterNaDatasource = false;
            this.txtBrojNaDokumentFra.Location = new System.Drawing.Point(164, 110);
            this.txtBrojNaDokumentFra.MakedonskiJazik = false;
            this.txtBrojNaDokumentFra.MinLength = 0;
            this.txtBrojNaDokumentFra.Multiline = true;
            this.txtBrojNaDokumentFra.Name = "txtBrojNaDokumentFra";
            this.txtBrojNaDokumentFra.PopulateOtherFields = false;
            this.txtBrojNaDokumentFra.regularExpression = null;
            this.txtBrojNaDokumentFra.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBrojNaDokumentFra.SelektrijaNaFokus = false;
            this.txtBrojNaDokumentFra.Size = new System.Drawing.Size(175, 28);
            this.txtBrojNaDokumentFra.TabIndex = 38;
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
            this.txtPartner.Location = new System.Drawing.Point(157, 83);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(439, 24);
            this.txtPartner.TabIndex = 37;
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
            this.zbxPartner.filterDataSource = "Tip = 2 OR Tip = -1";
            this.zbxPartner.formToOpen = "MFakturi.Forms.frmPartner";
            this.zbxPartner.GridFromForm = null;
            this.zbxPartner.KoristiFilterNaDatasource = true;
            this.zbxPartner.Location = new System.Drawing.Point(5, 79);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(146, 28);
            this.zbxPartner.TabIndex = 6;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validated += new System.EventHandler(this.zbxPartner_Validated);
            // 
            // brojTextBox
            // 
            this.brojTextBox.AssemblyStr = null;
            this.brojTextBox.C_FillWithZeros = false;
            this.brojTextBox.C_OnlyNumbers = true;
            this.brojTextBox.C_RegEx = false;
            this.brojTextBox.C_ShowRedOnLeaveIfEmpty = true;
            this.brojTextBox.ColumnName1 = null;
            this.brojTextBox.ColumnName2 = null;
            this.brojTextBox.ColumnName3 = null;
            this.brojTextBox.ColumnName4 = null;
            this.brojTextBox.ColumnName5 = null;
            this.brojTextBox.ColumnName6 = null;
            this.brojTextBox.ColumnName7 = null;
            this.brojTextBox.daliCetiri = false;
            this.brojTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.brojTextBox.Format = null;
            this.brojTextBox.formToOpen = null;
            this.brojTextBox.iscistiGreenNaLeave = false;
            this.brojTextBox.KoristiFilterNaDatasource = false;
            this.brojTextBox.Location = new System.Drawing.Point(67, 44);
            this.brojTextBox.MakedonskiJazik = false;
            this.brojTextBox.MinLength = 0;
            this.brojTextBox.Name = "brojTextBox";
            this.brojTextBox.PopulateOtherFields = false;
            this.brojTextBox.regularExpression = null;
            this.brojTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.brojTextBox.SelektrijaNaFokus = false;
            this.brojTextBox.Size = new System.Drawing.Size(84, 29);
            this.brojTextBox.TabIndex = 3;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewDokumentiBindingSource, "Datum", true));
            this.datumDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(771, 9);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(136, 29);
            this.datumDateTimePicker.TabIndex = 2;
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
            this.zabeleskatxtBase.Location = new System.Drawing.Point(606, 49);
            this.zabeleskatxtBase.MakedonskiJazik = false;
            this.zabeleskatxtBase.MinLength = 0;
            this.zabeleskatxtBase.Multiline = true;
            this.zabeleskatxtBase.Name = "zabeleskatxtBase";
            this.zabeleskatxtBase.PopulateOtherFields = false;
            this.zabeleskatxtBase.regularExpression = null;
            this.zabeleskatxtBase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.zabeleskatxtBase.SelektrijaNaFokus = false;
            this.zabeleskatxtBase.Size = new System.Drawing.Size(300, 58);
            this.zabeleskatxtBase.TabIndex = 5;
            // 
            // bsslabel4
            // 
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bsslabel4.Location = new System.Drawing.Point(158, 48);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(101, 24);
            this.bsslabel4.TabIndex = 31;
            this.bsslabel4.Text = "До обејкт:";
            // 
            // bsslabel3
            // 
            this.bsslabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bsslabel3.Location = new System.Drawing.Point(367, 9);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(103, 24);
            this.bsslabel3.TabIndex = 30;
            this.bsslabel3.Text = "Од објект:";
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bsslabel1.Location = new System.Drawing.Point(1, 11);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(103, 24);
            this.bsslabel1.TabIndex = 29;
            this.bsslabel1.Text = "Документ:";
            // 
            // cmbDoObjekt
            // 
            this.cmbDoObjekt.C_OnlyNumbers = false;
            this.cmbDoObjekt.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbDoObjekt.CurrentText = null;
            this.cmbDoObjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoObjekt.DtTableName = null;
            this.cmbDoObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbDoObjekt.FormattingEnabled = true;
            this.cmbDoObjekt.Location = new System.Drawing.Point(261, 45);
            this.cmbDoObjekt.Name = "cmbDoObjekt";
            this.cmbDoObjekt.Size = new System.Drawing.Size(177, 32);
            this.cmbDoObjekt.TabIndex = 4;
            this.cmbDoObjekt.value = null;
            // 
            // cmbOdObjekt
            // 
            this.cmbOdObjekt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOdObjekt.C_OnlyNumbers = false;
            this.cmbOdObjekt.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbOdObjekt.CurrentText = null;
            this.cmbOdObjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdObjekt.DtTableName = null;
            this.cmbOdObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbOdObjekt.FormattingEnabled = true;
            this.cmbOdObjekt.Location = new System.Drawing.Point(476, 6);
            this.cmbOdObjekt.Name = "cmbOdObjekt";
            this.cmbOdObjekt.Size = new System.Drawing.Size(214, 32);
            this.cmbOdObjekt.TabIndex = 1;
            this.cmbOdObjekt.value = null;
            // 
            // cmbTipNaDokument
            // 
            this.cmbTipNaDokument.C_OnlyNumbers = false;
            this.cmbTipNaDokument.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbTipNaDokument.CurrentText = null;
            this.cmbTipNaDokument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipNaDokument.DtTableName = null;
            this.cmbTipNaDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTipNaDokument.FormattingEnabled = true;
            this.cmbTipNaDokument.Location = new System.Drawing.Point(104, 6);
            this.cmbTipNaDokument.Name = "cmbTipNaDokument";
            this.cmbTipNaDokument.Size = new System.Drawing.Size(253, 28);
            this.cmbTipNaDokument.TabIndex = 0;
            this.cmbTipNaDokument.value = null;
            this.cmbTipNaDokument.SelectedIndexChanged += new System.EventHandler(this.cmbTipNaDokument_SelectedIndexChanged);
            // 
            // btnSocuvajZaglavje
            // 
            this.btnSocuvajZaglavje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSocuvajZaglavje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocuvajZaglavje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSocuvajZaglavje.Image = global::MMaterijalno.Properties.Resources.accept;
            this.btnSocuvajZaglavje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocuvajZaglavje.Location = new System.Drawing.Point(4, 181);
            this.btnSocuvajZaglavje.Name = "btnSocuvajZaglavje";
            this.btnSocuvajZaglavje.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajZaglavje.TabIndex = 7;
            this.btnSocuvajZaglavje.Text = "Сочувај заглавје";
            this.btnSocuvajZaglavje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocuvajZaglavje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSocuvajZaglavje.UseVisualStyleBackColor = false;
            this.btnSocuvajZaglavje.Click += new System.EventHandler(this.btnSocuvajZaglavje_Click);
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
            this.btnPecati.Location = new System.Drawing.Point(610, 181);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(295, 79);
            this.btnPecati.TabIndex = 8;
            this.btnPecati.Text = "Печати и прокнижи";
            this.btnPecati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecati.UseVisualStyleBackColor = false;
            this.btnPecati.Click += new System.EventHandler(this.btnPecati_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtNotesNumber);
            this.xtraTabPage2.Controls.Add(this.txtNotesText);
            this.xtraTabPage2.Controls.Add(this.chkDopolnitenoInoInfo);
            this.xtraTabPage2.Controls.Add(this.lblInfo);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.txtCenaBezDDV);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.txtSoDDV);
            this.xtraTabPage2.Controls.Add(this.rabat1Label);
            this.xtraTabPage2.Controls.Add(this.rabat1txtBase);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.txtcena);
            this.xtraTabPage2.Controls.Add(label7);
            this.xtraTabPage2.Controls.Add(this.txtBase1);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.iznostxtBase);
            this.xtraTabPage2.Controls.Add(this.btnSearchArtikal);
            this.xtraTabPage2.Controls.Add(this.txtArtikalSearch);
            this.xtraTabPage2.Controls.Add(this.txtDDV);
            this.xtraTabPage2.Controls.Add(this.txtEDM);
            this.xtraTabPage2.Controls.Add(this.txtArtikalNaziv);
            this.xtraTabPage2.Controls.Add(this.bsslabel2);
            this.xtraTabPage2.Controls.Add(kolicinaLabel);
            this.xtraTabPage2.Controls.Add(this.kolicinatxtBase);
            this.xtraTabPage2.Controls.Add(this.btnIzbrisiStavka);
            this.xtraTabPage2.Controls.Add(this.btnSocuvajStavka);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(910, 277);
            this.xtraTabPage2.Text = "Внес на ставки";
            // 
            // txtNotesNumber
            // 
            this.txtNotesNumber.AssemblyStr = null;
            this.txtNotesNumber.C_FillWithZeros = false;
            this.txtNotesNumber.C_OnlyNumbers = false;
            this.txtNotesNumber.C_RegEx = false;
            this.txtNotesNumber.C_ShowRedOnLeaveIfEmpty = false;
            this.txtNotesNumber.ColumnName1 = null;
            this.txtNotesNumber.ColumnName2 = null;
            this.txtNotesNumber.ColumnName3 = null;
            this.txtNotesNumber.ColumnName4 = null;
            this.txtNotesNumber.ColumnName5 = null;
            this.txtNotesNumber.ColumnName6 = null;
            this.txtNotesNumber.ColumnName7 = null;
            this.txtNotesNumber.daliCetiri = false;
            this.txtNotesNumber.Format = null;
            this.txtNotesNumber.formToOpen = null;
            this.txtNotesNumber.iscistiGreenNaLeave = false;
            this.txtNotesNumber.KoristiFilterNaDatasource = false;
            this.txtNotesNumber.Location = new System.Drawing.Point(253, 71);
            this.txtNotesNumber.MakedonskiJazik = false;
            this.txtNotesNumber.MinLength = 0;
            this.txtNotesNumber.Name = "txtNotesNumber";
            this.txtNotesNumber.PopulateOtherFields = false;
            this.txtNotesNumber.regularExpression = null;
            this.txtNotesNumber.SelektrijaNaFokus = false;
            this.txtNotesNumber.Size = new System.Drawing.Size(231, 21);
            this.txtNotesNumber.TabIndex = 64;
            this.txtNotesNumber.Visible = false;
            // 
            // txtNotesText
            // 
            this.txtNotesText.AssemblyStr = null;
            this.txtNotesText.AutoCompleteCustomSource.AddRange(new string[] {
            "LOT:",
            "INFO:",
            "SERIAL:",
            "BARCODE:",
            "CODE:"});
            this.txtNotesText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNotesText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNotesText.C_FillWithZeros = false;
            this.txtNotesText.C_OnlyNumbers = false;
            this.txtNotesText.C_RegEx = false;
            this.txtNotesText.C_ShowRedOnLeaveIfEmpty = false;
            this.txtNotesText.ColumnName1 = null;
            this.txtNotesText.ColumnName2 = null;
            this.txtNotesText.ColumnName3 = null;
            this.txtNotesText.ColumnName4 = null;
            this.txtNotesText.ColumnName5 = null;
            this.txtNotesText.ColumnName6 = null;
            this.txtNotesText.ColumnName7 = null;
            this.txtNotesText.daliCetiri = false;
            this.txtNotesText.Format = null;
            this.txtNotesText.formToOpen = null;
            this.txtNotesText.iscistiGreenNaLeave = false;
            this.txtNotesText.KoristiFilterNaDatasource = false;
            this.txtNotesText.Location = new System.Drawing.Point(16, 71);
            this.txtNotesText.MakedonskiJazik = false;
            this.txtNotesText.MinLength = 0;
            this.txtNotesText.Name = "txtNotesText";
            this.txtNotesText.PopulateOtherFields = false;
            this.txtNotesText.regularExpression = null;
            this.txtNotesText.SelektrijaNaFokus = false;
            this.txtNotesText.Size = new System.Drawing.Size(231, 21);
            this.txtNotesText.TabIndex = 63;
            this.txtNotesText.Visible = false;
            // 
            // chkDopolnitenoInoInfo
            // 
            this.chkDopolnitenoInoInfo.AutoSize = true;
            this.chkDopolnitenoInoInfo.Location = new System.Drawing.Point(188, 46);
            this.chkDopolnitenoInoInfo.Name = "chkDopolnitenoInoInfo";
            this.chkDopolnitenoInoInfo.Size = new System.Drawing.Size(163, 17);
            this.chkDopolnitenoInoInfo.TabIndex = 62;
            this.chkDopolnitenoInoInfo.Text = "Внес на дополнитено инфо";
            this.chkDopolnitenoInoInfo.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(242, 191);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(75, 17);
            this.lblInfo.TabIndex = 61;
            this.lblInfo.Text = "Артикал:";
            // 
            // txtCenaBezDDV
            // 
            this.txtCenaBezDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCenaBezDDV.AssemblyStr = null;
            this.txtCenaBezDDV.C_FillWithZeros = false;
            this.txtCenaBezDDV.C_OnlyNumbers = true;
            this.txtCenaBezDDV.C_RegEx = false;
            this.txtCenaBezDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtCenaBezDDV.ColumnName1 = null;
            this.txtCenaBezDDV.ColumnName2 = null;
            this.txtCenaBezDDV.ColumnName3 = null;
            this.txtCenaBezDDV.ColumnName4 = null;
            this.txtCenaBezDDV.ColumnName5 = null;
            this.txtCenaBezDDV.ColumnName6 = null;
            this.txtCenaBezDDV.ColumnName7 = null;
            this.txtCenaBezDDV.daliCetiri = false;
            this.txtCenaBezDDV.Format = null;
            this.txtCenaBezDDV.formToOpen = null;
            this.txtCenaBezDDV.iscistiGreenNaLeave = false;
            this.txtCenaBezDDV.KoristiFilterNaDatasource = false;
            this.txtCenaBezDDV.Location = new System.Drawing.Point(748, 75);
            this.txtCenaBezDDV.MakedonskiJazik = false;
            this.txtCenaBezDDV.MinLength = 0;
            this.txtCenaBezDDV.Multiline = true;
            this.txtCenaBezDDV.Name = "txtCenaBezDDV";
            this.txtCenaBezDDV.PopulateOtherFields = false;
            this.txtCenaBezDDV.regularExpression = null;
            this.txtCenaBezDDV.SelektrijaNaFokus = false;
            this.txtCenaBezDDV.Size = new System.Drawing.Size(156, 26);
            this.txtCenaBezDDV.TabIndex = 3;
            this.txtCenaBezDDV.TabStop = false;
            this.txtCenaBezDDV.Tag = "";
            this.txtCenaBezDDV.Text = "0,0";
            this.txtCenaBezDDV.Leave += new System.EventHandler(this.txtCenaBezDDV_Leave);
            // 
            // txtSoDDV
            // 
            this.txtSoDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDDV.AssemblyStr = null;
            this.txtSoDDV.C_FillWithZeros = false;
            this.txtSoDDV.C_OnlyNumbers = true;
            this.txtSoDDV.C_RegEx = false;
            this.txtSoDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSoDDV.ColumnName1 = null;
            this.txtSoDDV.ColumnName2 = null;
            this.txtSoDDV.ColumnName3 = null;
            this.txtSoDDV.ColumnName4 = null;
            this.txtSoDDV.ColumnName5 = null;
            this.txtSoDDV.ColumnName6 = null;
            this.txtSoDDV.ColumnName7 = null;
            this.txtSoDDV.daliCetiri = false;
            this.txtSoDDV.Format = null;
            this.txtSoDDV.formToOpen = null;
            this.txtSoDDV.iscistiGreenNaLeave = false;
            this.txtSoDDV.KoristiFilterNaDatasource = false;
            this.txtSoDDV.Location = new System.Drawing.Point(748, 42);
            this.txtSoDDV.MakedonskiJazik = false;
            this.txtSoDDV.MinLength = 0;
            this.txtSoDDV.Multiline = true;
            this.txtSoDDV.Name = "txtSoDDV";
            this.txtSoDDV.PopulateOtherFields = false;
            this.txtSoDDV.regularExpression = null;
            this.txtSoDDV.SelektrijaNaFokus = false;
            this.txtSoDDV.Size = new System.Drawing.Size(156, 25);
            this.txtSoDDV.TabIndex = 2;
            this.txtSoDDV.TabStop = false;
            this.txtSoDDV.Tag = "";
            this.txtSoDDV.Text = "0,0";
            this.txtSoDDV.Leave += new System.EventHandler(this.txtSoDDV_Leave);
            // 
            // rabat1txtBase
            // 
            this.rabat1txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabat1txtBase.AssemblyStr = null;
            this.rabat1txtBase.BackColor = System.Drawing.Color.LemonChiffon;
            this.rabat1txtBase.C_Decimal = true;
            this.rabat1txtBase.C_FillWithZeros = false;
            this.rabat1txtBase.C_OnlyNumbers = true;
            this.rabat1txtBase.C_RegEx = false;
            this.rabat1txtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.rabat1txtBase.ColumnName1 = null;
            this.rabat1txtBase.ColumnName2 = null;
            this.rabat1txtBase.ColumnName3 = null;
            this.rabat1txtBase.ColumnName4 = null;
            this.rabat1txtBase.ColumnName5 = null;
            this.rabat1txtBase.ColumnName6 = null;
            this.rabat1txtBase.ColumnName7 = null;
            this.rabat1txtBase.daliCetiri = false;
            this.rabat1txtBase.ForeColor = System.Drawing.Color.Blue;
            this.rabat1txtBase.Format = null;
            this.rabat1txtBase.formToOpen = null;
            this.rabat1txtBase.iscistiGreenNaLeave = false;
            this.rabat1txtBase.KoristiFilterNaDatasource = false;
            this.rabat1txtBase.Location = new System.Drawing.Point(748, 103);
            this.rabat1txtBase.MakedonskiJazik = false;
            this.rabat1txtBase.MinLength = 0;
            this.rabat1txtBase.Name = "rabat1txtBase";
            this.rabat1txtBase.PopulateOtherFields = false;
            this.rabat1txtBase.ReadOnly = true;
            this.rabat1txtBase.regularExpression = null;
            this.rabat1txtBase.SelektrijaNaFokus = false;
            this.rabat1txtBase.Size = new System.Drawing.Size(156, 21);
            this.rabat1txtBase.TabIndex = 56;
            this.rabat1txtBase.TabStop = false;
            this.rabat1txtBase.Text = "0.00";
            this.rabat1txtBase.TextChanged += new System.EventHandler(this.rabat1txtBase_TextChanged);
            this.rabat1txtBase.Leave += new System.EventHandler(this.rabat1txtBase_Leave_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Препорачана Цена:";
            // 
            // txtcena
            // 
            this.txtcena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcena.AssemblyStr = null;
            this.txtcena.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtcena.C_FillWithZeros = false;
            this.txtcena.C_OnlyNumbers = false;
            this.txtcena.C_RegEx = false;
            this.txtcena.C_ShowRedOnLeaveIfEmpty = false;
            this.txtcena.ColumnName1 = null;
            this.txtcena.ColumnName2 = null;
            this.txtcena.ColumnName3 = null;
            this.txtcena.ColumnName4 = null;
            this.txtcena.ColumnName5 = null;
            this.txtcena.ColumnName6 = null;
            this.txtcena.ColumnName7 = null;
            this.txtcena.daliCetiri = false;
            this.txtcena.ForeColor = System.Drawing.Color.Blue;
            this.txtcena.Format = null;
            this.txtcena.formToOpen = null;
            this.txtcena.iscistiGreenNaLeave = false;
            this.txtcena.KoristiFilterNaDatasource = false;
            this.txtcena.Location = new System.Drawing.Point(820, 9);
            this.txtcena.MakedonskiJazik = false;
            this.txtcena.MinLength = 0;
            this.txtcena.Multiline = true;
            this.txtcena.Name = "txtcena";
            this.txtcena.PopulateOtherFields = false;
            this.txtcena.ReadOnly = true;
            this.txtcena.regularExpression = null;
            this.txtcena.SelektrijaNaFokus = false;
            this.txtcena.Size = new System.Drawing.Size(84, 26);
            this.txtcena.TabIndex = 54;
            this.txtcena.TabStop = false;
            this.txtcena.Leave += new System.EventHandler(this.txtcena_Leave);
            this.txtcena.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtcena_MouseDoubleClick);
            // 
            // txtBase1
            // 
            this.txtBase1.AcceptsReturn = true;
            this.txtBase1.AssemblyStr = null;
            this.txtBase1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBase1.C_FillWithZeros = false;
            this.txtBase1.C_OnlyNumbers = false;
            this.txtBase1.C_RegEx = false;
            this.txtBase1.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBase1.ColumnName1 = null;
            this.txtBase1.ColumnName2 = null;
            this.txtBase1.ColumnName3 = null;
            this.txtBase1.ColumnName4 = null;
            this.txtBase1.ColumnName5 = null;
            this.txtBase1.ColumnName6 = null;
            this.txtBase1.ColumnName7 = null;
            this.txtBase1.daliCetiri = false;
            this.txtBase1.ForeColor = System.Drawing.Color.Blue;
            this.txtBase1.Format = null;
            this.txtBase1.formToOpen = null;
            this.txtBase1.iscistiGreenNaLeave = false;
            this.txtBase1.KoristiFilterNaDatasource = false;
            this.txtBase1.Location = new System.Drawing.Point(137, 142);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Multiline = true;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.ReadOnly = true;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(160, 35);
            this.txtBase1.TabIndex = 4;
            this.txtBase1.TabStop = false;
            this.txtBase1.Leave += new System.EventHandler(this.txtBase1_Leave);
            // 
            // iznostxtBase
            // 
            this.iznostxtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iznostxtBase.AssemblyStr = null;
            this.iznostxtBase.BackColor = System.Drawing.Color.LemonChiffon;
            this.iznostxtBase.C_FillWithZeros = false;
            this.iznostxtBase.C_OnlyNumbers = false;
            this.iznostxtBase.C_RegEx = false;
            this.iznostxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.iznostxtBase.ColumnName1 = null;
            this.iznostxtBase.ColumnName2 = null;
            this.iznostxtBase.ColumnName3 = null;
            this.iznostxtBase.ColumnName4 = null;
            this.iznostxtBase.ColumnName5 = null;
            this.iznostxtBase.ColumnName6 = null;
            this.iznostxtBase.ColumnName7 = null;
            this.iznostxtBase.daliCetiri = false;
            this.iznostxtBase.ForeColor = System.Drawing.Color.Blue;
            this.iznostxtBase.Format = null;
            this.iznostxtBase.formToOpen = null;
            this.iznostxtBase.iscistiGreenNaLeave = false;
            this.iznostxtBase.KoristiFilterNaDatasource = false;
            this.iznostxtBase.Location = new System.Drawing.Point(749, 158);
            this.iznostxtBase.MakedonskiJazik = false;
            this.iznostxtBase.MinLength = 0;
            this.iznostxtBase.Multiline = true;
            this.iznostxtBase.Name = "iznostxtBase";
            this.iznostxtBase.PopulateOtherFields = false;
            this.iznostxtBase.ReadOnly = true;
            this.iznostxtBase.regularExpression = null;
            this.iznostxtBase.SelektrijaNaFokus = false;
            this.iznostxtBase.Size = new System.Drawing.Size(157, 24);
            this.iznostxtBase.TabIndex = 44;
            this.iznostxtBase.TabStop = false;
            // 
            // btnSearchArtikal
            // 
            this.btnSearchArtikal.Location = new System.Drawing.Point(248, 5);
            this.btnSearchArtikal.Name = "btnSearchArtikal";
            this.btnSearchArtikal.Size = new System.Drawing.Size(43, 26);
            this.btnSearchArtikal.TabIndex = 1;
            this.btnSearchArtikal.Text = "...";
            this.btnSearchArtikal.UseVisualStyleBackColor = true;
            this.btnSearchArtikal.Click += new System.EventHandler(this.btnSearchArtikal_Click);
            // 
            // txtArtikalSearch
            // 
            this.txtArtikalSearch.AssemblyStr = "BSSR";
            this.txtArtikalSearch.C_FillWithZeros = false;
            this.txtArtikalSearch.C_OnlyNumbers = false;
            this.txtArtikalSearch.C_RegEx = false;
            this.txtArtikalSearch.C_ShowRedOnLeaveIfEmpty = false;
            this.txtArtikalSearch.ColumnName1 = "ID";
            this.txtArtikalSearch.ColumnName2 = "Naziv";
            this.txtArtikalSearch.ColumnName3 = "SIFRA";
            this.txtArtikalSearch.ColumnName4 = "Normativ";
            this.txtArtikalSearch.ColumnName5 = "ProdaznaCena";
            this.txtArtikalSearch.ColumnName6 = null;
            this.txtArtikalSearch.ColumnName7 = null;
            this.txtArtikalSearch.daliCetiri = false;
            this.txtArtikalSearch.Format = null;
            this.txtArtikalSearch.formToOpen = "BSSR.Forms.frmPrebaruvanjeNaArtikliDev";
            this.txtArtikalSearch.iscistiGreenNaLeave = false;
            this.txtArtikalSearch.KoristiFilterNaDatasource = false;
            this.txtArtikalSearch.Location = new System.Drawing.Point(82, 6);
            this.txtArtikalSearch.MakedonskiJazik = false;
            this.txtArtikalSearch.MaxLength = 13;
            this.txtArtikalSearch.MinLength = 0;
            this.txtArtikalSearch.Name = "txtArtikalSearch";
            this.txtArtikalSearch.PopulateOtherFields = false;
            this.txtArtikalSearch.regularExpression = null;
            this.txtArtikalSearch.SelektrijaNaFokus = false;
            this.txtArtikalSearch.Size = new System.Drawing.Size(160, 21);
            this.txtArtikalSearch.TabIndex = 0;
            this.txtArtikalSearch.DataRead += new BssBase.txtBase.doneLoading(this.txtArtikalSearch_DataRead);
            this.txtArtikalSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArtikalSearch_KeyDown);
            this.txtArtikalSearch.Leave += new System.EventHandler(this.txtArtikalSearch_Leave);
            // 
            // txtDDV
            // 
            this.txtDDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDDV.AssemblyStr = null;
            this.txtDDV.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDDV.C_FillWithZeros = false;
            this.txtDDV.C_OnlyNumbers = false;
            this.txtDDV.C_RegEx = false;
            this.txtDDV.C_ShowRedOnLeaveIfEmpty = false;
            this.txtDDV.ColumnName1 = null;
            this.txtDDV.ColumnName2 = null;
            this.txtDDV.ColumnName3 = null;
            this.txtDDV.ColumnName4 = null;
            this.txtDDV.ColumnName5 = null;
            this.txtDDV.ColumnName6 = null;
            this.txtDDV.ColumnName7 = null;
            this.txtDDV.daliCetiri = false;
            this.txtDDV.ForeColor = System.Drawing.Color.Blue;
            this.txtDDV.Format = null;
            this.txtDDV.formToOpen = null;
            this.txtDDV.iscistiGreenNaLeave = false;
            this.txtDDV.KoristiFilterNaDatasource = false;
            this.txtDDV.Location = new System.Drawing.Point(559, 6);
            this.txtDDV.MakedonskiJazik = false;
            this.txtDDV.MinLength = 0;
            this.txtDDV.Multiline = true;
            this.txtDDV.Name = "txtDDV";
            this.txtDDV.PopulateOtherFields = false;
            this.txtDDV.ReadOnly = true;
            this.txtDDV.regularExpression = null;
            this.txtDDV.SelektrijaNaFokus = false;
            this.txtDDV.Size = new System.Drawing.Size(91, 26);
            this.txtDDV.TabIndex = 46;
            this.txtDDV.TabStop = false;
            // 
            // txtEDM
            // 
            this.txtEDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEDM.AssemblyStr = null;
            this.txtEDM.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEDM.C_FillWithZeros = false;
            this.txtEDM.C_OnlyNumbers = false;
            this.txtEDM.C_RegEx = false;
            this.txtEDM.C_ShowRedOnLeaveIfEmpty = false;
            this.txtEDM.ColumnName1 = null;
            this.txtEDM.ColumnName2 = null;
            this.txtEDM.ColumnName3 = null;
            this.txtEDM.ColumnName4 = null;
            this.txtEDM.ColumnName5 = null;
            this.txtEDM.ColumnName6 = null;
            this.txtEDM.ColumnName7 = null;
            this.txtEDM.daliCetiri = false;
            this.txtEDM.ForeColor = System.Drawing.Color.Blue;
            this.txtEDM.Format = null;
            this.txtEDM.formToOpen = null;
            this.txtEDM.iscistiGreenNaLeave = false;
            this.txtEDM.KoristiFilterNaDatasource = false;
            this.txtEDM.Location = new System.Drawing.Point(465, 6);
            this.txtEDM.MakedonskiJazik = false;
            this.txtEDM.MinLength = 0;
            this.txtEDM.Multiline = true;
            this.txtEDM.Name = "txtEDM";
            this.txtEDM.PopulateOtherFields = false;
            this.txtEDM.ReadOnly = true;
            this.txtEDM.regularExpression = null;
            this.txtEDM.SelektrijaNaFokus = false;
            this.txtEDM.Size = new System.Drawing.Size(88, 26);
            this.txtEDM.TabIndex = 45;
            this.txtEDM.TabStop = false;
            // 
            // txtArtikalNaziv
            // 
            this.txtArtikalNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtikalNaziv.AssemblyStr = null;
            this.txtArtikalNaziv.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtArtikalNaziv.C_FillWithZeros = false;
            this.txtArtikalNaziv.C_OnlyNumbers = false;
            this.txtArtikalNaziv.C_RegEx = false;
            this.txtArtikalNaziv.C_ShowRedOnLeaveIfEmpty = false;
            this.txtArtikalNaziv.ColumnName1 = null;
            this.txtArtikalNaziv.ColumnName2 = null;
            this.txtArtikalNaziv.ColumnName3 = null;
            this.txtArtikalNaziv.ColumnName4 = null;
            this.txtArtikalNaziv.ColumnName5 = null;
            this.txtArtikalNaziv.ColumnName6 = null;
            this.txtArtikalNaziv.ColumnName7 = null;
            this.txtArtikalNaziv.daliCetiri = false;
            this.txtArtikalNaziv.ForeColor = System.Drawing.Color.Blue;
            this.txtArtikalNaziv.Format = null;
            this.txtArtikalNaziv.formToOpen = null;
            this.txtArtikalNaziv.iscistiGreenNaLeave = false;
            this.txtArtikalNaziv.KoristiFilterNaDatasource = false;
            this.txtArtikalNaziv.Location = new System.Drawing.Point(297, 6);
            this.txtArtikalNaziv.MakedonskiJazik = false;
            this.txtArtikalNaziv.MinLength = 0;
            this.txtArtikalNaziv.Multiline = true;
            this.txtArtikalNaziv.Name = "txtArtikalNaziv";
            this.txtArtikalNaziv.PopulateOtherFields = false;
            this.txtArtikalNaziv.ReadOnly = true;
            this.txtArtikalNaziv.regularExpression = null;
            this.txtArtikalNaziv.SelektrijaNaFokus = false;
            this.txtArtikalNaziv.Size = new System.Drawing.Size(162, 26);
            this.txtArtikalNaziv.TabIndex = 42;
            this.txtArtikalNaziv.TabStop = false;
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(2, 6);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(54, 13);
            this.bsslabel2.TabIndex = 39;
            this.bsslabel2.Text = "Артикал:";
            // 
            // kolicinatxtBase
            // 
            this.kolicinatxtBase.AssemblyStr = null;
            this.kolicinatxtBase.C_Decimal = true;
            this.kolicinatxtBase.C_FillWithZeros = false;
            this.kolicinatxtBase.C_OnlyNumbers = true;
            this.kolicinatxtBase.C_RegEx = false;
            this.kolicinatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.kolicinatxtBase.ColumnName1 = null;
            this.kolicinatxtBase.ColumnName2 = null;
            this.kolicinatxtBase.ColumnName3 = null;
            this.kolicinatxtBase.ColumnName4 = null;
            this.kolicinatxtBase.ColumnName5 = null;
            this.kolicinatxtBase.ColumnName6 = null;
            this.kolicinatxtBase.ColumnName7 = null;
            this.kolicinatxtBase.daliCetiri = false;
            this.kolicinatxtBase.Format = null;
            this.kolicinatxtBase.formToOpen = null;
            this.kolicinatxtBase.iscistiGreenNaLeave = false;
            this.kolicinatxtBase.KoristiFilterNaDatasource = false;
            this.kolicinatxtBase.Location = new System.Drawing.Point(96, 43);
            this.kolicinatxtBase.MakedonskiJazik = false;
            this.kolicinatxtBase.MinLength = 0;
            this.kolicinatxtBase.Name = "kolicinatxtBase";
            this.kolicinatxtBase.PopulateOtherFields = false;
            this.kolicinatxtBase.regularExpression = null;
            this.kolicinatxtBase.SelektrijaNaFokus = false;
            this.kolicinatxtBase.Size = new System.Drawing.Size(83, 21);
            this.kolicinatxtBase.TabIndex = 1;
            this.kolicinatxtBase.Text = "0.00";
            this.kolicinatxtBase.TextChanged += new System.EventHandler(this.kolicinatxtBase_TextChanged);
            this.kolicinatxtBase.Leave += new System.EventHandler(this.kolicinatxtBase_Leave);
            // 
            // btnIzbrisiStavka
            // 
            this.btnIzbrisiStavka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzbrisiStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzbrisiStavka.Image = global::MMaterijalno.Properties.Resources.delete;
            this.btnIzbrisiStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzbrisiStavka.Location = new System.Drawing.Point(4, 190);
            this.btnIzbrisiStavka.Name = "btnIzbrisiStavka";
            this.btnIzbrisiStavka.Size = new System.Drawing.Size(226, 79);
            this.btnIzbrisiStavka.TabIndex = 6;
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
            this.btnSocuvajStavka.Location = new System.Drawing.Point(679, 188);
            this.btnSocuvajStavka.Name = "btnSocuvajStavka";
            this.btnSocuvajStavka.Size = new System.Drawing.Size(226, 79);
            this.btnSocuvajStavka.TabIndex = 5;
            this.btnSocuvajStavka.Text = "Сочувај ставка";
            this.btnSocuvajStavka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocuvajStavka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSocuvajStavka.UseVisualStyleBackColor = true;
            this.btnSocuvajStavka.Click += new System.EventHandler(this.btnSocuvajStavka_Click);
            // 
            // viewDokumentiStavkigrd
            // 
            this.viewDokumentiStavkigrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDokumentiStavkigrd.AssemblyToLoad = null;
            this.viewDokumentiStavkigrd.DataSource = this.viewDokumentiStavkiBindingSource;
            this.viewDokumentiStavkigrd.EditForm = null;
            this.viewDokumentiStavkigrd.FilterForm = null;
            this.viewDokumentiStavkigrd.Location = new System.Drawing.Point(4, 322);
            this.viewDokumentiStavkigrd.MainView = this.gridView1;
            this.viewDokumentiStavkigrd.Name = "viewDokumentiStavkigrd";
            this.viewDokumentiStavkigrd.PrimaryKey = null;
            this.viewDokumentiStavkigrd.reportCenter = false;
            this.viewDokumentiStavkigrd.ReportName = null;
            this.viewDokumentiStavkigrd.Size = new System.Drawing.Size(906, 190);
            this.viewDokumentiStavkigrd.TabIndex = 0;
            this.viewDokumentiStavkigrd.UpdateTable = null;
            this.viewDokumentiStavkigrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.viewDokumentiStavkigrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDokumentiStavkigrd_KeyDown);
            // 
            // viewDokumentiStavkiBindingSource
            // 
            this.viewDokumentiStavkiBindingSource.DataMember = "viewDokumentiStavki";
            this.viewDokumentiStavkiBindingSource.DataSource = this.materijalnoDataSet;
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
            this.colNazivNaProdukt,
            this.colAltSifra,
            this.ProsecnaNabavnaCena,
            this.ProsecnaNabavnaCenaBezDDV,
            this.NabavnaVrednostBezDDVIznos,
            this.colCenaBezDDV,
            this.colDatumNaDokument,
            this.colNotesBroj,
            this.colNotesText,
            this.colProdaznaCena,
            this.colProdaznaVrednostSoDDV});
            this.gridView1.GridControl = this.viewDokumentiStavkigrd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
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
            this.colDDVStapka.Width = 115;
            // 
            // colEdinecnaMerka
            // 
            this.colEdinecnaMerka.Caption = "ЕДМ";
            this.colEdinecnaMerka.FieldName = "EdinecnaMerka";
            this.colEdinecnaMerka.Name = "colEdinecnaMerka";
            this.colEdinecnaMerka.OptionsColumn.ReadOnly = true;
            this.colEdinecnaMerka.Visible = true;
            this.colEdinecnaMerka.VisibleIndex = 4;
            this.colEdinecnaMerka.Width = 115;
            // 
            // colDDVIznos
            // 
            this.colDDVIznos.Caption = "ДДВ Износ";
            this.colDDVIznos.FieldName = "DDVIznos";
            this.colDDVIznos.Name = "colDDVIznos";
            this.colDDVIznos.OptionsColumn.ReadOnly = true;
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
            this.colIznosBezDDV.Width = 115;
            // 
            // colCenaSoRabatIddv
            // 
            this.colCenaSoRabatIddv.Caption = "Цена со рабат и ДДВ";
            this.colCenaSoRabatIddv.FieldName = "CenaSoRabatIddv";
            this.colCenaSoRabatIddv.Name = "colCenaSoRabatIddv";
            this.colCenaSoRabatIddv.OptionsColumn.ReadOnly = true;
            this.colCenaSoRabatIddv.Width = 115;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Количина";
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 5;
            this.colKolicina.Width = 115;
            // 
            // colCena
            // 
            this.colCena.Caption = "Цена";
            this.colCena.FieldName = "Cena";
            this.colCena.Name = "colCena";
            this.colCena.Width = 115;
            // 
            // colRabat1
            // 
            this.colRabat1.Caption = "Рабат";
            this.colRabat1.FieldName = "Rabat1";
            this.colRabat1.Name = "colRabat1";
            this.colRabat1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rabat1", "{0:0.##}")});
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
            this.colIznos.VisibleIndex = 8;
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
            this.colNazivNaProdukt.VisibleIndex = 1;
            this.colNazivNaProdukt.Width = 271;
            // 
            // colAltSifra
            // 
            this.colAltSifra.Caption = "Алт.Шифра";
            this.colAltSifra.FieldName = "AltSifra";
            this.colAltSifra.Name = "colAltSifra";
            this.colAltSifra.Visible = true;
            this.colAltSifra.VisibleIndex = 0;
            // 
            // ProsecnaNabavnaCena
            // 
            this.ProsecnaNabavnaCena.Caption = "Просечна набавна цена ";
            this.ProsecnaNabavnaCena.FieldName = "ProsecnaNabavnaCena";
            this.ProsecnaNabavnaCena.Name = "ProsecnaNabavnaCena";
            this.ProsecnaNabavnaCena.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProsecnaNabavnaCena", "{0:0.##}")});
            // 
            // ProsecnaNabavnaCenaBezDDV
            // 
            this.ProsecnaNabavnaCenaBezDDV.Caption = "Просечна набавна цена без ДДВ";
            this.ProsecnaNabavnaCenaBezDDV.FieldName = "ProsecnaNabavnaCenaBezDDV";
            this.ProsecnaNabavnaCenaBezDDV.Name = "ProsecnaNabavnaCenaBezDDV";
            this.ProsecnaNabavnaCenaBezDDV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProsecnaNabavnaCenaBezDDV", "{0:0.##}")});
            // 
            // NabavnaVrednostBezDDVIznos
            // 
            this.NabavnaVrednostBezDDVIznos.Caption = "Набавна вредност без ДДВ";
            this.NabavnaVrednostBezDDVIznos.FieldName = "NabavnaVrednostBezDDVIznos";
            this.NabavnaVrednostBezDDVIznos.Name = "NabavnaVrednostBezDDVIznos";
            this.NabavnaVrednostBezDDVIznos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NabavnaVrednostBezDDVIznos", "{0:0.##}")});
            // 
            // colCenaBezDDV
            // 
            this.colCenaBezDDV.Caption = "Цена без ДДВ";
            this.colCenaBezDDV.FieldName = "CenaBezDDV";
            this.colCenaBezDDV.Name = "colCenaBezDDV";
            this.colCenaBezDDV.Visible = true;
            this.colCenaBezDDV.VisibleIndex = 6;
            // 
            // colDatumNaDokument
            // 
            this.colDatumNaDokument.Caption = "Датум на документ";
            this.colDatumNaDokument.FieldName = "DatumNaDokument";
            this.colDatumNaDokument.Name = "colDatumNaDokument";
            // 
            // colNotesBroj
            // 
            this.colNotesBroj.Caption = "Инфо број";
            this.colNotesBroj.FieldName = "NotesBroj";
            this.colNotesBroj.Name = "colNotesBroj";
            this.colNotesBroj.Visible = true;
            this.colNotesBroj.VisibleIndex = 3;
            // 
            // colNotesText
            // 
            this.colNotesText.Caption = "Инфо Текст";
            this.colNotesText.FieldName = "NotesText";
            this.colNotesText.Name = "colNotesText";
            this.colNotesText.Visible = true;
            this.colNotesText.VisibleIndex = 2;
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Продажна цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            this.colProdaznaCena.Visible = true;
            this.colProdaznaCena.VisibleIndex = 7;
            // 
            // colProdaznaVrednostSoDDV
            // 
            this.colProdaznaVrednostSoDDV.Caption = "Продажна вредност со ДДВ";
            this.colProdaznaVrednostSoDDV.FieldName = "ProdaznaVrednostSoDDV";
            this.colProdaznaVrednostSoDDV.Name = "colProdaznaVrednostSoDDV";
            // 
            // viewDokumentiStavkiTableAdapter
            // 
            this.viewDokumentiStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.General_data_mesecTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDogovoriTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoHvacTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = null;
            this.tableAdapterManager.tblPlacanjaOdPartnerTableAdapter = null;
            this.tableAdapterManager.tblPriemStavkiTableAdapter = null;
            this.tableAdapterManager.tblPriemTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewDokumentiStavkiTableAdapter = null;
            this.tableAdapterManager.viewDokumentiTableAdapter = null;
            this.tableAdapterManager.viewIzvodiTableAdapter = null;
            this.tableAdapterManager.viewPriemiTableAdapter = null;
            this.tableAdapterManager.viewPriemStavkiTableAdapter = null;
            this.tableAdapterManager.vPriemiKnizenjeTableAdapter = null;
            this.tableAdapterManager.vSmetkaKnizenjeTableAdapter = null;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            this.tblFirmaBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // viewDokumentiTableAdapter
            // 
            this.viewDokumentiTableAdapter.ClearBeforeFill = true;
            // 
            // pLTobrazecBindingSource
            // 
            this.pLTobrazecBindingSource.DataMember = "PLTobrazec";
            this.pLTobrazecBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // pLTobrazecTableAdapter
            // 
            this.pLTobrazecTableAdapter.ClearBeforeFill = true;
            // 
            // general_data_mesecBindingSource
            // 
            this.general_data_mesecBindingSource.DataMember = "General_data_mesec";
            this.general_data_mesecBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // general_data_mesecTableAdapter
            // 
            this.general_data_mesecTableAdapter.ClearBeforeFill = true;
            // 
            // tblDokumentiDetailsInfoHvacBindingSource
            // 
            this.tblDokumentiDetailsInfoHvacBindingSource.DataMember = "tblDokumentiDetailsInfoHvac";
            this.tblDokumentiDetailsInfoHvacBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblDokumentiDetailsInfoHvacTableAdapter
            // 
            this.tblDokumentiDetailsInfoHvacTableAdapter.ClearBeforeFill = true;
            // 
            // tblDokumentiDetailsInfoBindingSource
            // 
            this.tblDokumentiDetailsInfoBindingSource.DataMember = "tblDokumentiDetailsInfo";
            this.tblDokumentiDetailsInfoBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblDokumentiDetailsInfoTableAdapter
            // 
            this.tblDokumentiDetailsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tblPartneriBindingSource
            // 
            this.tblPartneriBindingSource.DataMember = "tblPartneri";
            this.tblPartneriBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblPartneriTableAdapter
            // 
            this.tblPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // frmObrabotkaNaInterniDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 612);
            this.Name = "frmObrabotkaNaInterniDokumenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка на интерни документи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmObrabotkaNaInterniDokumenti_Load);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkigrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDokumentiStavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLTobrazecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_data_mesecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoHvacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiDetailsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BssBase.DevGrid viewDokumentiStavkigrd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnIzbrisiStavka;
        private System.Windows.Forms.Button btnSocuvajStavka;
        private BssBase.txtBase txtBase1;
        private BssBase.txtBase iznostxtBase;
        private System.Windows.Forms.Button btnSearchArtikal;
        private BssBase.txtBase txtArtikalSearch;
        private BssBase.txtBase txtDDV;
        private BssBase.txtBase txtEDM;
        private BssBase.txtBase txtArtikalNaziv;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.txtBase kolicinatxtBase;
        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource viewDokumentiStavkiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewDokumentiStavkiTableAdapter viewDokumentiStavkiTableAdapter;
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
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BssBase.txtBase brojTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private BssBase.txtBase zabeleskatxtBase;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.cmbBase cmbDoObjekt;
        private BssBase.cmbBase cmbOdObjekt;
        private BssBase.cmbBase cmbTipNaDokument;
        private System.Windows.Forms.Button btnSocuvajZaglavje;
        private System.Windows.Forms.Button btnPecati;
        private BssBase.txtBase txtPartner;
        private BssBase.zbxBase zbxPartner;
        private System.Windows.Forms.BindingSource tblFirmaBindingSource;
        private MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
        private System.Windows.Forms.BindingSource viewDokumentiBindingSource;
        private MaterijalnoDataSetTableAdapters.viewDokumentiTableAdapter viewDokumentiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAltSifra;
        private BssBase.txtBase txtCenaBezDDV;
        private BssBase.txtBase txtSoDDV;
        private BssBase.txtBase rabat1txtBase;
        private BssBase.txtBase txtcena;
        private DevExpress.XtraGrid.Columns.GridColumn ProsecnaNabavnaCena;
        private DevExpress.XtraGrid.Columns.GridColumn ProsecnaNabavnaCenaBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn NabavnaVrednostBezDDVIznos;
        private System.Windows.Forms.BindingSource pLTobrazecBindingSource;
        private MaterijalnoDataSetTableAdapters.PLTobrazecTableAdapter pLTobrazecTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rabat1Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private BssBase.Elements.Bsslabel lblInfo;
        private BssBase.txtBase txtBrojNaDokumentFra;
        private System.Windows.Forms.Button btnPLT;
        private System.Windows.Forms.DateTimePicker dtPeriod;
        private System.Windows.Forms.DateTimePicker dtValuta;
        private System.Windows.Forms.BindingSource general_data_mesecBindingSource;
        private MaterijalnoDataSetTableAdapters.General_data_mesecTableAdapter general_data_mesecTableAdapter;
        private System.Windows.Forms.BindingSource tblDokumentiDetailsInfoHvacBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoHvacTableAdapter tblDokumentiDetailsInfoHvacTableAdapter;
        private System.Windows.Forms.BindingSource tblDokumentiDetailsInfoBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDokumentiDetailsInfoTableAdapter tblDokumentiDetailsInfoTableAdapter;
        private System.Windows.Forms.BindingSource tblPartneriBindingSource;
        private MaterijalnoDataSetTableAdapters.tblPartneriTableAdapter tblPartneriTableAdapter;
        private System.Windows.Forms.CheckBox chkDopolnitenoInoInfo;
        private BssBase.txtBase txtNotesNumber;
        private BssBase.txtBase txtNotesText;
        private DevExpress.XtraGrid.Columns.GridColumn colCenaBezDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumNaDokument;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesBroj;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesText;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaVrednostSoDDV;
        private System.Windows.Forms.Button btnDogovori;
    }
}
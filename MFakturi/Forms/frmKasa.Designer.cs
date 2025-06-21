namespace MFakturi.Forms
{
    partial class frmKasa
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
            if (disposing && (cardReader != null))
            {
                
                cardReader.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Meni = new System.Windows.Forms.MenuStrip();
            this.btnNovZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovaSmetka = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGarancija = new System.Windows.Forms.ToolStripMenuItem();
            this.btnpecatiIzatvoribrzo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzbrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzbrisiSe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZatvoriTop = new System.Windows.Forms.ToolStripMenuItem();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.stavkiVoNalogKasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakturiDataSet = new MFakturi.FakturiDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtVraboten = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSmetkaBroj = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtDatumNaSmetka = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tMalo = new System.Windows.Forms.ToolStripButton();
            this.tgolemo = new System.Windows.Forms.ToolStripButton();
            this.btnKalkulator = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.brojNaArtikli = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtIznosBezDDV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPresmetanDDV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtIznosSoRabat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxBase2 = new BssBase.groupBoxBase();
            this.viewArtikliVoSmetkaGridBig = new BssBase.GridBig();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdaznaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaSoRabatIddv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaBezDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresmetanDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDVProcent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosBezDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPartner = new System.Windows.Forms.TabPage();
            this.groupBoxBase3 = new BssBase.groupBoxBase();
            this.txtNfCReaderStatus = new BssBase.txtBase();
            this.txtPartner = new BssBase.txtBase();
            this.btnPecatiFaktura = new System.Windows.Forms.Button();
            this.zbxPartner = new BssBase.zbxBase();
            this.tabZabeleska = new System.Windows.Forms.TabPage();
            this.txtZabeleska = new BssBase.txtBase();
            this.lblSUm = new System.Windows.Forms.Label();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
            this.stavkiVoNalogKasaTableAdapter = new MFakturi.FakturiDataSetTableAdapters.StavkiVoNalogKasaTableAdapter();
            this.tblFirmaTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblFirmaTableAdapter();
            this.tblPartneriTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblPartneriTableAdapter();
            this.viewArtikliVoSmetkaTableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewArtikliVoSmetkaTableAdapter();
            this.viewArtikliVoSmetkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewArtikliVoSmetkaKASATableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewArtikliVoSmetkaKASATableAdapter();
            this.Meni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkiVoNalogKasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxBase2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliVoSmetkaGridBig)).BeginInit();
            this.groupBoxBase1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPartner.SuspendLayout();
            this.groupBoxBase3.SuspendLayout();
            this.tabZabeleska.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliVoSmetkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Meni
            // 
            this.Meni.AllowMerge = false;
            this.Meni.BackColor = System.Drawing.Color.Beige;
            this.Meni.Dock = System.Windows.Forms.DockStyle.None;
            this.Meni.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Meni.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Meni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Meni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovZapis,
            this.btnNovaSmetka,
            this.btnGarancija,
            this.btnpecatiIzatvoribrzo,
            this.btnIzbrisi,
            this.btnIzbrisiSe,
            this.toolStripMenuItem1,
            this.btnZatvoriTop});
            this.Meni.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Meni.Location = new System.Drawing.Point(0, 32);
            this.Meni.Name = "Meni";
            this.Meni.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Meni.ShowItemToolTips = true;
            this.Meni.Size = new System.Drawing.Size(831, 95);
            this.Meni.TabIndex = 2;
            // 
            // btnNovZapis
            // 
            this.btnNovZapis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNovZapis.Image = ((System.Drawing.Image)(resources.GetObject("btnNovZapis.Image")));
            this.btnNovZapis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovZapis.Name = "btnNovZapis";
            this.btnNovZapis.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnNovZapis.Size = new System.Drawing.Size(84, 91);
            this.btnNovZapis.Text = "Внес (F1)";
            this.btnNovZapis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovZapis.ToolTipText = "Додавање на нов запис";
            this.btnNovZapis.Click += new System.EventHandler(this.btnNovZapis_Click);
            // 
            // btnNovaSmetka
            // 
            this.btnNovaSmetka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNovaSmetka.Image = global::MFakturi.Properties.Resources.edit;
            this.btnNovaSmetka.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovaSmetka.Name = "btnNovaSmetka";
            this.btnNovaSmetka.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.btnNovaSmetka.Size = new System.Drawing.Size(114, 91);
            this.btnNovaSmetka.Text = "Новa сметка  (F2)";
            this.btnNovaSmetka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovaSmetka.ToolTipText = "Додавање на нов запис";
            this.btnNovaSmetka.Click += new System.EventHandler(this.btnNovaSmetka_Click);
            // 
            // btnGarancija
            // 
            this.btnGarancija.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGarancija.Image = global::MFakturi.Properties.Resources.pecati;
            this.btnGarancija.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGarancija.Name = "btnGarancija";
            this.btnGarancija.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.btnGarancija.Size = new System.Drawing.Size(126, 91);
            this.btnGarancija.Text = "Гарантен лист ( F3 )";
            this.btnGarancija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGarancija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGarancija.Click += new System.EventHandler(this.btnGarancija_Click);
            // 
            // btnpecatiIzatvoribrzo
            // 
            this.btnpecatiIzatvoribrzo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpecatiIzatvoribrzo.Image = global::MFakturi.Properties.Resources.pecati;
            this.btnpecatiIzatvoribrzo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnpecatiIzatvoribrzo.Name = "btnpecatiIzatvoribrzo";
            this.btnpecatiIzatvoribrzo.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.btnpecatiIzatvoribrzo.Size = new System.Drawing.Size(144, 91);
            this.btnpecatiIzatvoribrzo.Text = "Печати и затвори ( F5 )";
            this.btnpecatiIzatvoribrzo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnpecatiIzatvoribrzo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpecatiIzatvoribrzo.Click += new System.EventHandler(this.btnPecatiIZatvori_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzbrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbrisi.Image")));
            this.btnIzbrisi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.btnIzbrisi.Size = new System.Drawing.Size(95, 91);
            this.btnIzbrisi.Text = "Избриши (F6)";
            this.btnIzbrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzbrisi.ToolTipText = "Бришење на записот";
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnIzbrisiSe
            // 
            this.btnIzbrisiSe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzbrisiSe.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbrisiSe.Image")));
            this.btnIzbrisiSe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIzbrisiSe.Name = "btnIzbrisiSe";
            this.btnIzbrisiSe.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.btnIzbrisiSe.Size = new System.Drawing.Size(87, 91);
            this.btnIzbrisiSe.Text = "Избриши се";
            this.btnIzbrisiSe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzbrisiSe.ToolTipText = "Бришење на записот";
            this.btnIzbrisiSe.Click += new System.EventHandler(this.btnIzbrisiSe_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Image = global::MFakturi.Properties.Resources.fiskalna;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 91);
            this.toolStripMenuItem1.Text = "Сметка ( F10 )";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.фискалнаToolStripMenuItem_Click);
            // 
            // btnZatvoriTop
            // 
            this.btnZatvoriTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZatvoriTop.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvoriTop.Image")));
            this.btnZatvoriTop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZatvoriTop.Name = "btnZatvoriTop";
            this.btnZatvoriTop.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.btnZatvoriTop.Size = new System.Drawing.Size(84, 91);
            this.btnZatvoriTop.Text = "Излез (F4)";
            this.btnZatvoriTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZatvoriTop.Click += new System.EventHandler(this.btnZatvoriTop_Click);
            // 
            // Navigator
            // 
            this.Navigator.AddNewItem = null;
            this.Navigator.BackColor = System.Drawing.Color.Beige;
            this.Navigator.BindingSource = this.stavkiVoNalogKasaBindingSource;
            this.Navigator.CountItem = this.bindingNavigatorCountItem;
            this.Navigator.CountItemFormat = "од {0}";
            this.Navigator.DeleteItem = null;
            this.Navigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Navigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Navigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.txtVraboten,
            this.toolStripSeparator1,
            this.txtSmetkaBroj,
            this.toolStripSeparator3,
            this.txtDatumNaSmetka,
            this.toolStripSeparator2,
            this.tMalo,
            this.tgolemo,
            this.btnKalkulator});
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.bindingNavigatorPositionItem;
            this.Navigator.Size = new System.Drawing.Size(1208, 27);
            this.Navigator.TabIndex = 1;
            // 
            // stavkiVoNalogKasaBindingSource
            // 
            this.stavkiVoNalogKasaBindingSource.DataMember = "StavkiVoNalogKasa";
            this.stavkiVoNalogKasaBindingSource.DataSource = this.fakturiDataSet;
            this.stavkiVoNalogKasaBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.stavkiVoNalogKasaBindingSource_ListChanged);
            // 
            // fakturiDataSet
            // 
            this.fakturiDataSet.DataSetName = "FakturiDataSet";
            this.fakturiDataSet.EnforceConstraints = false;
            this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "од {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Вкупен број на записи";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Почеток";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Претходен запис";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Моментална позиција";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Следен запис";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Крај";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // txtVraboten
            // 
            this.txtVraboten.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtVraboten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtVraboten.Name = "txtVraboten";
            this.txtVraboten.Size = new System.Drawing.Size(93, 24);
            this.txtVraboten.Text = "Вработен :";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // txtSmetkaBroj
            // 
            this.txtSmetkaBroj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSmetkaBroj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtSmetkaBroj.Name = "txtSmetkaBroj";
            this.txtSmetkaBroj.Size = new System.Drawing.Size(113, 24);
            this.txtSmetkaBroj.Text = "Сметка број :";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // txtDatumNaSmetka
            // 
            this.txtDatumNaSmetka.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtDatumNaSmetka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtDatumNaSmetka.Name = "txtDatumNaSmetka";
            this.txtDatumNaSmetka.Size = new System.Drawing.Size(148, 24);
            this.txtDatumNaSmetka.Text = "Датум на сметка :";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tMalo
            // 
            this.tMalo.Checked = true;
            this.tMalo.CheckOnClick = true;
            this.tMalo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tMalo.Image = global::MFakturi.Properties.Resources.smetka;
            this.tMalo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tMalo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.tMalo.Name = "tMalo";
            this.tMalo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tMalo.Size = new System.Drawing.Size(62, 24);
            this.tMalo.Text = "Мало";
            this.tMalo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tMalo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tgolemo
            // 
            this.tgolemo.Image = ((System.Drawing.Image)(resources.GetObject("tgolemo.Image")));
            this.tgolemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tgolemo.Name = "tgolemo";
            this.tgolemo.Size = new System.Drawing.Size(73, 24);
            this.tgolemo.Text = "Големо";
            this.tgolemo.Click += new System.EventHandler(this.tgolemo_Click);
            // 
            // btnKalkulator
            // 
            this.btnKalkulator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKalkulator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKalkulator.Image = global::MFakturi.Properties.Resources.kasa;
            this.btnKalkulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(117, 24);
            this.btnKalkulator.Text = "Калкулатор";
            this.btnKalkulator.Click += new System.EventHandler(this.btnKalkulator_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel8,
            this.brojNaArtikli,
            this.toolStripStatusLabel6,
            this.txtIznosBezDDV,
            this.toolStripStatusLabel5,
            this.txtPresmetanDDV,
            this.toolStripStatusLabel1,
            this.txtIznosSoRabat,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1208, 33);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(16, 28);
            this.toolStripStatusLabel8.Text = " | ";
            // 
            // brojNaArtikli
            // 
            this.brojNaArtikli.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.brojNaArtikli.Name = "brojNaArtikli";
            this.brojNaArtikli.Size = new System.Drawing.Size(179, 28);
            this.brojNaArtikli.Text = "Број на Артикли:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 28);
            this.toolStripStatusLabel6.Text = " | ";
            // 
            // txtIznosBezDDV
            // 
            this.txtIznosBezDDV.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtIznosBezDDV.Name = "txtIznosBezDDV";
            this.txtIznosBezDDV.Size = new System.Drawing.Size(167, 28);
            this.txtIznosBezDDV.Text = "Износ без ДДВ:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(16, 28);
            this.toolStripStatusLabel5.Text = " | ";
            // 
            // txtPresmetanDDV
            // 
            this.txtPresmetanDDV.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtPresmetanDDV.Name = "txtPresmetanDDV";
            this.txtPresmetanDDV.Size = new System.Drawing.Size(175, 28);
            this.txtPresmetanDDV.Text = "Пресметан ДДВ:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 28);
            this.toolStripStatusLabel1.Text = " | ";
            // 
            // txtIznosSoRabat
            // 
            this.txtIznosSoRabat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtIznosSoRabat.Name = "txtIznosSoRabat";
            this.txtIznosSoRabat.Size = new System.Drawing.Size(166, 28);
            this.txtIznosSoRabat.Text = "Износ со рабат:";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(16, 28);
            this.toolStripStatusLabel7.Text = " | ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MFakturi.Properties.Resources.logo2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(978, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxBase2
            // 
            this.groupBoxBase2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase2.Controls.Add(this.viewArtikliVoSmetkaGridBig);
            this.groupBoxBase2.Location = new System.Drawing.Point(3, 136);
            this.groupBoxBase2.Name = "groupBoxBase2";
            this.groupBoxBase2.Size = new System.Drawing.Size(1200, 321);
            this.groupBoxBase2.TabIndex = 0;
            this.groupBoxBase2.TabStop = false;
            // 
            // viewArtikliVoSmetkaGridBig
            // 
            this.viewArtikliVoSmetkaGridBig.AllowUserToAddRows = false;
            this.viewArtikliVoSmetkaGridBig.AllowUserToDeleteRows = false;
            this.viewArtikliVoSmetkaGridBig.AllowUserToOrderColumns = true;
            this.viewArtikliVoSmetkaGridBig.AssemblyToLoad = null;
            this.viewArtikliVoSmetkaGridBig.AutoGenerateColumns = false;
            this.viewArtikliVoSmetkaGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewArtikliVoSmetkaGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sifra,
            this.Sifra2,
            this.Naziv,
            this.ProdaznaCena,
            this.Kolicina,
            this.Rabat,
            this.CenaSoRabatIddv,
            this.CenaBezDDV,
            this.PresmetanDDV,
            this.DDVProcent,
            this.IznosBezDDV,
            this.Iznos,
            this.ArtikalID});
            this.viewArtikliVoSmetkaGridBig.DataSource = this.stavkiVoNalogKasaBindingSource;
            this.viewArtikliVoSmetkaGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewArtikliVoSmetkaGridBig.EditForm = null;
            this.viewArtikliVoSmetkaGridBig.FilterForm = null;
            this.viewArtikliVoSmetkaGridBig.HidenColumns = new string[] {
        ""};
            this.viewArtikliVoSmetkaGridBig.KreirajPredefiniraniPolinja = true;
            this.viewArtikliVoSmetkaGridBig.Location = new System.Drawing.Point(3, 16);
            this.viewArtikliVoSmetkaGridBig.MultiSelect = false;
            this.viewArtikliVoSmetkaGridBig.Name = "viewArtikliVoSmetkaGridBig";
            this.viewArtikliVoSmetkaGridBig.PrikaziKoloniZaVnes = true;
            this.viewArtikliVoSmetkaGridBig.PrimaryKey = "ID";
            this.viewArtikliVoSmetkaGridBig.ReadOnlyColumns = new string[0];
            this.viewArtikliVoSmetkaGridBig.reportCenter = false;
            this.viewArtikliVoSmetkaGridBig.ReportName = null;
            this.viewArtikliVoSmetkaGridBig.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewArtikliVoSmetkaGridBig.RowTemplate.Height = 36;
            this.viewArtikliVoSmetkaGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewArtikliVoSmetkaGridBig.Size = new System.Drawing.Size(1194, 302);
            this.viewArtikliVoSmetkaGridBig.SQLCommandQuery = null;
            this.viewArtikliVoSmetkaGridBig.TabIndex = 0;
            this.viewArtikliVoSmetkaGridBig.UpdateTable = null;
            this.viewArtikliVoSmetkaGridBig.SaveInsertDataFromGrid += new BssBase.GridBig.SaveInsertData(this.viewArtikliVoSmetkaGridBig_SaveInsertDataFromGrid);
            this.viewArtikliVoSmetkaGridBig.OnInsertDataShown += new BssBase.GridBig.onInsertDataFromGridShown(this.viewArtikliVoSmetkaGridBig_OnInsertDataShown);
            this.viewArtikliVoSmetkaGridBig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewArtikliVoSmetkaGridBig_KeyDown);
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sifra.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sifra.HeaderText = "Шифра";
            this.Sifra.MinimumWidth = 200;
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            this.Sifra.Width = 200;
            // 
            // Sifra2
            // 
            this.Sifra2.DataPropertyName = "Sifra2";
            this.Sifra2.HeaderText = "Шифра 2";
            this.Sifra2.Name = "Sifra2";
            this.Sifra2.ReadOnly = true;
            this.Sifra2.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Артикал";
            this.Naziv.MinimumWidth = 300;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // ProdaznaCena
            // 
            this.ProdaznaCena.DataPropertyName = "ProdaznaCena";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.ProdaznaCena.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdaznaCena.HeaderText = "Продажна цена";
            this.ProdaznaCena.Name = "ProdaznaCena";
            this.ProdaznaCena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.Kolicina.DefaultCellStyle = dataGridViewCellStyle3;
            this.Kolicina.HeaderText = "Количина";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Rabat
            // 
            this.Rabat.DataPropertyName = "Rabat";
            this.Rabat.HeaderText = "Рабат";
            this.Rabat.Name = "Rabat";
            this.Rabat.ReadOnly = true;
            // 
            // CenaSoRabatIddv
            // 
            this.CenaSoRabatIddv.DataPropertyName = "CenaSoRabatIddv";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            this.CenaSoRabatIddv.DefaultCellStyle = dataGridViewCellStyle4;
            this.CenaSoRabatIddv.HeaderText = "Цена со рабат";
            this.CenaSoRabatIddv.Name = "CenaSoRabatIddv";
            this.CenaSoRabatIddv.ReadOnly = true;
            // 
            // CenaBezDDV
            // 
            this.CenaBezDDV.DataPropertyName = "CenaBezDDV";
            this.CenaBezDDV.HeaderText = "Цена без ДДВ";
            this.CenaBezDDV.Name = "CenaBezDDV";
            this.CenaBezDDV.ReadOnly = true;
            this.CenaBezDDV.Visible = false;
            // 
            // PresmetanDDV
            // 
            this.PresmetanDDV.DataPropertyName = "PresmetanDDV";
            this.PresmetanDDV.HeaderText = "Пресметан ДДВ";
            this.PresmetanDDV.Name = "PresmetanDDV";
            this.PresmetanDDV.ReadOnly = true;
            this.PresmetanDDV.Visible = false;
            // 
            // DDVProcent
            // 
            this.DDVProcent.DataPropertyName = "DDVProcent";
            this.DDVProcent.HeaderText = "ДДВ";
            this.DDVProcent.Name = "DDVProcent";
            // 
            // IznosBezDDV
            // 
            this.IznosBezDDV.DataPropertyName = "IznosBezDDV";
            this.IznosBezDDV.HeaderText = "Износ без ДДВ";
            this.IznosBezDDV.Name = "IznosBezDDV";
            this.IznosBezDDV.ReadOnly = true;
            this.IznosBezDDV.Visible = false;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.Iznos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Iznos.HeaderText = "Износ";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // ArtikalID
            // 
            this.ArtikalID.DataPropertyName = "ArtikalID";
            this.ArtikalID.HeaderText = "Реден број артикал";
            this.ArtikalID.Name = "ArtikalID";
            this.ArtikalID.ReadOnly = true;
            this.ArtikalID.Visible = false;
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase1.BackColor = System.Drawing.Color.Beige;
            this.groupBoxBase1.Controls.Add(this.tabControl1);
            this.groupBoxBase1.Controls.Add(this.lblSUm);
            this.groupBoxBase1.Location = new System.Drawing.Point(3, 460);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(1201, 201);
            this.groupBoxBase1.TabIndex = 3;
            this.groupBoxBase1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPartner);
            this.tabControl1.Controls.Add(this.tabZabeleska);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 183);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPartner
            // 
            this.tabPartner.Controls.Add(this.groupBoxBase3);
            this.tabPartner.Location = new System.Drawing.Point(4, 22);
            this.tabPartner.Name = "tabPartner";
            this.tabPartner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPartner.Size = new System.Drawing.Size(409, 157);
            this.tabPartner.TabIndex = 0;
            this.tabPartner.Text = "Купувач ( Деловен партнер )";
            this.tabPartner.UseVisualStyleBackColor = true;
            // 
            // groupBoxBase3
            // 
            this.groupBoxBase3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBase3.Controls.Add(this.txtNfCReaderStatus);
            this.groupBoxBase3.Controls.Add(this.txtPartner);
            this.groupBoxBase3.Controls.Add(this.btnPecatiFaktura);
            this.groupBoxBase3.Controls.Add(this.zbxPartner);
            this.groupBoxBase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase3.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBase3.Name = "groupBoxBase3";
            this.groupBoxBase3.Size = new System.Drawing.Size(403, 151);
            this.groupBoxBase3.TabIndex = 0;
            this.groupBoxBase3.TabStop = false;
            // 
            // txtNfCReaderStatus
            // 
            this.txtNfCReaderStatus.AssemblyStr = null;
            this.txtNfCReaderStatus.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNfCReaderStatus.C_FillWithZeros = false;
            this.txtNfCReaderStatus.C_OnlyNumbers = false;
            this.txtNfCReaderStatus.C_RegEx = false;
            this.txtNfCReaderStatus.C_ShowRedOnLeaveIfEmpty = false;
            this.txtNfCReaderStatus.ColumnName1 = null;
            this.txtNfCReaderStatus.ColumnName2 = null;
            this.txtNfCReaderStatus.ColumnName3 = null;
            this.txtNfCReaderStatus.ColumnName4 = null;
            this.txtNfCReaderStatus.ColumnName5 = null;
            this.txtNfCReaderStatus.ColumnName6 = null;
            this.txtNfCReaderStatus.ColumnName7 = null;
            this.txtNfCReaderStatus.daliCetiri = false;
            this.txtNfCReaderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNfCReaderStatus.ForeColor = System.Drawing.Color.Blue;
            this.txtNfCReaderStatus.Format = null;
            this.txtNfCReaderStatus.formToOpen = null;
            this.txtNfCReaderStatus.iscistiGreenNaLeave = false;
            this.txtNfCReaderStatus.KoristiFilterNaDatasource = false;
            this.txtNfCReaderStatus.Location = new System.Drawing.Point(218, 93);
            this.txtNfCReaderStatus.MakedonskiJazik = false;
            this.txtNfCReaderStatus.MinLength = 0;
            this.txtNfCReaderStatus.Multiline = true;
            this.txtNfCReaderStatus.Name = "txtNfCReaderStatus";
            this.txtNfCReaderStatus.PopulateOtherFields = false;
            this.txtNfCReaderStatus.ReadOnly = true;
            this.txtNfCReaderStatus.regularExpression = null;
            this.txtNfCReaderStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNfCReaderStatus.SelektrijaNaFokus = false;
            this.txtNfCReaderStatus.Size = new System.Drawing.Size(179, 41);
            this.txtNfCReaderStatus.TabIndex = 24;
            // 
            // txtPartner
            // 
            this.txtPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPartner.ForeColor = System.Drawing.Color.Blue;
            this.txtPartner.Format = null;
            this.txtPartner.formToOpen = null;
            this.txtPartner.iscistiGreenNaLeave = false;
            this.txtPartner.KoristiFilterNaDatasource = false;
            this.txtPartner.Location = new System.Drawing.Point(8, 42);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(389, 45);
            this.txtPartner.TabIndex = 23;
            // 
            // btnPecatiFaktura
            // 
            this.btnPecatiFaktura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPecatiFaktura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecatiFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPecatiFaktura.Image = global::MFakturi.Properties.Resources.fakturiranje;
            this.btnPecatiFaktura.Location = new System.Drawing.Point(8, 93);
            this.btnPecatiFaktura.Name = "btnPecatiFaktura";
            this.btnPecatiFaktura.Size = new System.Drawing.Size(206, 41);
            this.btnPecatiFaktura.TabIndex = 2;
            this.btnPecatiFaktura.Text = "Печати Фактура";
            this.btnPecatiFaktura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecatiFaktura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPecatiFaktura.UseVisualStyleBackColor = false;
            this.btnPecatiFaktura.Click += new System.EventHandler(this.btnPecati_Click);
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
            this.zbxPartner.filterDataSource = "Tip = 0 OR Tip = -1";
            this.zbxPartner.formToOpen = "MFakturi.Forms.frmPartner";
            this.zbxPartner.GridFromForm = null;
            this.zbxPartner.KoristiFilterNaDatasource = true;
            this.zbxPartner.Location = new System.Drawing.Point(8, 10);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(389, 26);
            this.zbxPartner.TabIndex = 21;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validating += new System.ComponentModel.CancelEventHandler(this.zbxPartner_Validated);
            // 
            // tabZabeleska
            // 
            this.tabZabeleska.Controls.Add(this.txtZabeleska);
            this.tabZabeleska.Location = new System.Drawing.Point(4, 22);
            this.tabZabeleska.Name = "tabZabeleska";
            this.tabZabeleska.Padding = new System.Windows.Forms.Padding(3);
            this.tabZabeleska.Size = new System.Drawing.Size(409, 157);
            this.tabZabeleska.TabIndex = 1;
            this.tabZabeleska.Text = "Забелешки";
            this.tabZabeleska.UseVisualStyleBackColor = true;
            // 
            // txtZabeleska
            // 
            this.txtZabeleska.AssemblyStr = null;
            this.txtZabeleska.C_FillWithZeros = false;
            this.txtZabeleska.C_OnlyNumbers = false;
            this.txtZabeleska.C_RegEx = false;
            this.txtZabeleska.C_ShowRedOnLeaveIfEmpty = false;
            this.txtZabeleska.ColumnName1 = null;
            this.txtZabeleska.ColumnName2 = null;
            this.txtZabeleska.ColumnName3 = null;
            this.txtZabeleska.ColumnName4 = null;
            this.txtZabeleska.ColumnName5 = null;
            this.txtZabeleska.ColumnName6 = null;
            this.txtZabeleska.ColumnName7 = null;
            this.txtZabeleska.daliCetiri = false;
            this.txtZabeleska.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZabeleska.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtZabeleska.Format = null;
            this.txtZabeleska.formToOpen = null;
            this.txtZabeleska.iscistiGreenNaLeave = false;
            this.txtZabeleska.KoristiFilterNaDatasource = false;
            this.txtZabeleska.Location = new System.Drawing.Point(3, 3);
            this.txtZabeleska.MakedonskiJazik = false;
            this.txtZabeleska.MinLength = 0;
            this.txtZabeleska.Multiline = true;
            this.txtZabeleska.Name = "txtZabeleska";
            this.txtZabeleska.PopulateOtherFields = false;
            this.txtZabeleska.regularExpression = null;
            this.txtZabeleska.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtZabeleska.SelektrijaNaFokus = false;
            this.txtZabeleska.Size = new System.Drawing.Size(403, 151);
            this.txtZabeleska.TabIndex = 0;
            // 
            // lblSUm
            // 
            this.lblSUm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUm.Location = new System.Drawing.Point(417, 37);
            this.lblSUm.Name = "lblSUm";
            this.lblSUm.Size = new System.Drawing.Size(768, 157);
            this.lblSUm.TabIndex = 0;
            this.lblSUm.Text = "0,00";
            this.lblSUm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tblPartneriBindingSource
            // 
            this.tblPartneriBindingSource.DataMember = "tblPartneri";
            this.tblPartneriBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            this.tblFirmaBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblBankiTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaStavkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = null;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblZiroSmetkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliVoSmetkaTableAdapter = null;
            this.tableAdapterManager.viewFakturiStavkiTableAdapter = null;
            this.tableAdapterManager.viewFakturiTableAdapter = null;
            this.tableAdapterManager.viewZiroSmetkeTableAdapter = null;
            // 
            // stavkiVoNalogKasaTableAdapter
            // 
            this.stavkiVoNalogKasaTableAdapter.ClearBeforeFill = true;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // tblPartneriTableAdapter
            // 
            this.tblPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // viewArtikliVoSmetkaTableAdapter
            // 
            this.viewArtikliVoSmetkaTableAdapter.ClearBeforeFill = true;
            // 
            // viewArtikliVoSmetkaBindingSource
            // 
            this.viewArtikliVoSmetkaBindingSource.DataMember = "viewArtikliVoSmetka";
            this.viewArtikliVoSmetkaBindingSource.DataSource = this.fakturiDataSet;
            // 
            // viewArtikliVoSmetkaKASATableAdapter
            // 
            this.viewArtikliVoSmetkaKASATableAdapter.ClearBeforeFill = true;
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1208, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Meni);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxBase2);
            this.Controls.Add(this.groupBoxBase1);
            this.Controls.Add(this.Navigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKasa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKasa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasa_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmKasa_KeyUp);
            this.Meni.ResumeLayout(false);
            this.Meni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkiVoNalogKasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxBase2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliVoSmetkaGridBig)).EndInit();
            this.groupBoxBase1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPartner.ResumeLayout(false);
            this.groupBoxBase3.ResumeLayout(false);
            this.groupBoxBase3.PerformLayout();
            this.tabZabeleska.ResumeLayout(false);
            this.tabZabeleska.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliVoSmetkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private BssBase.groupBoxBase groupBoxBase1;
        public System.Windows.Forms.MenuStrip Meni;
        public System.Windows.Forms.ToolStripMenuItem btnNovZapis;
        public System.Windows.Forms.ToolStripMenuItem btnIzbrisi;
        public System.Windows.Forms.ToolStripMenuItem btnZatvoriTop;
        public System.Windows.Forms.BindingNavigator Navigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private FakturiDataSet fakturiDataSet;
        private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig viewArtikliVoSmetkaGridBig;
        private BssBase.groupBoxBase groupBoxBase2;
        private System.Windows.Forms.ToolStripMenuItem btnpecatiIzatvoribrzo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSUm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPecatiFaktura;
        private System.Windows.Forms.BindingSource stavkiVoNalogKasaBindingSource;
        private FakturiDataSetTableAdapters.StavkiVoNalogKasaTableAdapter stavkiVoNalogKasaTableAdapter;
        private System.Windows.Forms.BindingSource tblFirmaBindingSource;
        private FakturiDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
        private System.Windows.Forms.BindingSource tblPartneriBindingSource;
        private FakturiDataSetTableAdapters.tblPartneriTableAdapter tblPartneriTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel brojNaArtikli;
        private System.Windows.Forms.ToolStripStatusLabel txtIznosBezDDV;
        private System.Windows.Forms.ToolStripStatusLabel txtPresmetanDDV;
        private System.Windows.Forms.ToolStripStatusLabel txtIznosSoRabat;
        private System.Windows.Forms.BindingSource viewArtikliVoSmetkaBindingSource;
        private FakturiDataSetTableAdapters.viewArtikliVoSmetkaTableAdapter viewArtikliVoSmetkaTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPartner;
        private System.Windows.Forms.TabPage tabZabeleska;
        private BssBase.groupBoxBase groupBoxBase3;
        private BssBase.txtBase txtZabeleska;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private BssBase.zbxBase zbxPartner;
        private BssBase.txtBase txtPartner;
        private System.Windows.Forms.ToolStripLabel txtVraboten;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtSmetkaBroj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel txtDatumNaSmetka;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private FakturiDataSetTableAdapters.viewArtikliVoSmetkaKASATableAdapter viewArtikliVoSmetkaKASATableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btnGarancija;
        public System.Windows.Forms.ToolStripMenuItem btnNovaSmetka;
        private System.Windows.Forms.ToolStripButton tMalo;
        private System.Windows.Forms.ToolStripButton tgolemo;
        public System.Windows.Forms.ToolStripMenuItem btnIzbrisiSe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdaznaCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rabat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaSoRabatIddv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaBezDDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresmetanDDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDVProcent;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosBezDDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalID;
        private System.Windows.Forms.ToolStripButton btnKalkulator;
        private BssBase.txtBase txtNfCReaderStatus;
    }
}
using System.Windows.Forms;

namespace MMaterijalno.Forms
{
    partial class frmKnizenje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKnizenje));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPriemi = new System.Windows.Forms.TabPage();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.btnSelektirajPriemi = new System.Windows.Forms.Button();
            this.btnProkniziPriemi = new BssBase.Elements.btnPotvrdi();
            this.vPriemiKnizenjegrdBase = new BssBase.grdBase();
            this.tabFakturi = new System.Windows.Forms.TabPage();
            this.groupBoxBase2 = new BssBase.groupBoxBase();
            this.vFakturiKnzienogrdBase = new BssBase.grdBase();
            this.btnSelektirajFakturi = new System.Windows.Forms.Button();
            this.btnProkniziFakturi = new BssBase.Elements.btnPotvrdi();
            this.btnProkniziSmetki = new BssBase.Elements.btnPotvrdi();
            this.vSmetkaKnizenjegrdBase = new BssBase.grdBase();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zabeleska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiteSmetki = new System.Windows.Forms.Button();
            this.tabInterni = new System.Windows.Forms.TabPage();
            this.groupBoxBase3 = new BssBase.groupBoxBase();
            this.vDokumentiGrd = new BssBase.grdBase();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProkniziInterni = new BssBase.Elements.btnPotvrdi();
            this.datum = new BssBase.Elements.dtPickerBase();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BrojNaDokument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDVIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPriem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriemBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dobavuvac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriemDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkulacijaBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPriemiKnizenjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.IDFaktura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vFakturiKnzienoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipNaDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivPartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosBezDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosSoDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipNaKnizenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDokumentiKnizenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zatvorena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vSmetkaKnizenjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSmetkaKnizenjeTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.vSmetkaKnizenjeTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.vPriemiKnizenjeTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.vPriemiKnizenjeTableAdapter();
            this.vFakturiKnzienoTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.vFakturiKnzienoTableAdapter();
            this.vDokumentiKnizenoTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.vDokumentiKnizenoTableAdapter();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.tabPriemi.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vPriemiKnizenjegrdBase)).BeginInit();
            this.tabFakturi.SuspendLayout();
            this.groupBoxBase2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vFakturiKnzienogrdBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSmetkaKnizenjegrdBase)).BeginInit();
            this.tabInterni.SuspendLayout();
            this.groupBoxBase3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDokumentiGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vPriemiKnizenjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFakturiKnzienoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDokumentiKnizenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSmetkaKnizenjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabPriemi);
            this.MainTab.Controls.Add(this.tabFakturi);
            this.MainTab.Controls.Add(this.tabInterni);
            this.MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTab.Location = new System.Drawing.Point(0, 64);
            this.MainTab.Size = new System.Drawing.Size(1361, 594);
            this.MainTab.Controls.SetChildIndex(this.tabInterni, 0);
            this.MainTab.Controls.SetChildIndex(this.tabFakturi, 0);
            this.MainTab.Controls.SetChildIndex(this.tabPriemi, 0);
            this.MainTab.Controls.SetChildIndex(this.tabVnes, 0);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Location = new System.Drawing.Point(4, 24);
            this.tabVnes.Size = new System.Drawing.Size(1353, 566);
            this.tabVnes.Text = "Сметки";
            // 
            // groupVnes
            // 
            this.groupVnes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVnes.Controls.Add(this.btnSiteSmetki);
            this.groupVnes.Controls.Add(this.vSmetkaKnizenjegrdBase);
            this.groupVnes.Controls.Add(this.btnProkniziSmetki);
            this.groupVnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupVnes.Location = new System.Drawing.Point(0, 0);
            this.groupVnes.Size = new System.Drawing.Size(1353, 566);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 664);
            this.PanelFooter.Size = new System.Drawing.Size(1365, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 1);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(1170, 1);
            this.btnOk.Visible = false;
            // 
            // tabPriemi
            // 
            this.tabPriemi.Controls.Add(this.groupBoxBase1);
            this.tabPriemi.Location = new System.Drawing.Point(4, 24);
            this.tabPriemi.Name = "tabPriemi";
            this.tabPriemi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPriemi.Size = new System.Drawing.Size(1353, 566);
            this.tabPriemi.TabIndex = 1;
            this.tabPriemi.Text = "Приеми";
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.btnSelektirajPriemi);
            this.groupBoxBase1.Controls.Add(this.btnProkniziPriemi);
            this.groupBoxBase1.Controls.Add(this.vPriemiKnizenjegrdBase);
            this.groupBoxBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBase1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(1347, 560);
            this.groupBoxBase1.TabIndex = 0;
            this.groupBoxBase1.TabStop = false;
            // 
            // btnSelektirajPriemi
            // 
            this.btnSelektirajPriemi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelektirajPriemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelektirajPriemi.Location = new System.Drawing.Point(5, 500);
            this.btnSelektirajPriemi.Name = "btnSelektirajPriemi";
            this.btnSelektirajPriemi.Size = new System.Drawing.Size(279, 54);
            this.btnSelektirajPriemi.TabIndex = 4;
            this.btnSelektirajPriemi.Text = "Селектирај ги сите";
            this.btnSelektirajPriemi.UseVisualStyleBackColor = true;
            this.btnSelektirajPriemi.Click += new System.EventHandler(this.btnSelektirajPriemi_Click);
            // 
            // btnProkniziPriemi
            // 
            this.btnProkniziPriemi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProkniziPriemi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProkniziPriemi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProkniziPriemi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProkniziPriemi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProkniziPriemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProkniziPriemi.Image = ((System.Drawing.Image)(resources.GetObject("btnProkniziPriemi.Image")));
            this.btnProkniziPriemi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProkniziPriemi.Location = new System.Drawing.Point(1037, 500);
            this.btnProkniziPriemi.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnProkniziPriemi.Name = "btnProkniziPriemi";
            this.btnProkniziPriemi.Size = new System.Drawing.Size(304, 54);
            this.btnProkniziPriemi.TabIndex = 3;
            this.btnProkniziPriemi.Text = "Прокнижи приеми";
            this.btnProkniziPriemi.UseVisualStyleBackColor = false;
            this.btnProkniziPriemi.Click += new System.EventHandler(this.btnProkniziPriemi_Click);
            // 
            // vPriemiKnizenjegrdBase
            // 
            this.vPriemiKnizenjegrdBase.AllowUserToAddRows = false;
            this.vPriemiKnizenjegrdBase.AllowUserToDeleteRows = false;
            this.vPriemiKnizenjegrdBase.AllowUserToOrderColumns = true;
            this.vPriemiKnizenjegrdBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vPriemiKnizenjegrdBase.AssemblyToLoad = null;
            this.vPriemiKnizenjegrdBase.AutoGenerateColumns = false;
            this.vPriemiKnizenjegrdBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vPriemiKnizenjegrdBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPriem,
            this.PriemBroj,
            this.Dobavuvac,
            this.PriemDatum,
            this.KalkulacijaBroj,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.vPriemiKnizenjegrdBase.DataSource = this.vPriemiKnizenjeBindingSource;
            this.vPriemiKnizenjegrdBase.EditForm = null;
            this.vPriemiKnizenjegrdBase.FilterForm = null;
            this.vPriemiKnizenjegrdBase.Location = new System.Drawing.Point(2, 14);
            this.vPriemiKnizenjegrdBase.Name = "vPriemiKnizenjegrdBase";
            this.vPriemiKnizenjegrdBase.PrimaryKey = null;
            this.vPriemiKnizenjegrdBase.ReadOnly = true;
            this.vPriemiKnizenjegrdBase.reportCenter = false;
            this.vPriemiKnizenjegrdBase.ReportName = null;
            this.vPriemiKnizenjegrdBase.Size = new System.Drawing.Size(1343, 468);
            this.vPriemiKnizenjegrdBase.SQLCommandQuery = null;
            this.vPriemiKnizenjegrdBase.TabIndex = 0;
            this.vPriemiKnizenjegrdBase.UpdateTable = null;
            // 
            // tabFakturi
            // 
            this.tabFakturi.Controls.Add(this.groupBoxBase2);
            this.tabFakturi.Location = new System.Drawing.Point(4, 24);
            this.tabFakturi.Name = "tabFakturi";
            this.tabFakturi.Padding = new System.Windows.Forms.Padding(3);
            this.tabFakturi.Size = new System.Drawing.Size(1353, 566);
            this.tabFakturi.TabIndex = 2;
            this.tabFakturi.Text = "Фактури";
            this.tabFakturi.UseVisualStyleBackColor = true;
            // 
            // groupBoxBase2
            // 
            this.groupBoxBase2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBase2.Controls.Add(this.vFakturiKnzienogrdBase);
            this.groupBoxBase2.Controls.Add(this.btnSelektirajFakturi);
            this.groupBoxBase2.Controls.Add(this.btnProkniziFakturi);
            this.groupBoxBase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBase2.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBase2.Name = "groupBoxBase2";
            this.groupBoxBase2.Size = new System.Drawing.Size(1347, 560);
            this.groupBoxBase2.TabIndex = 0;
            this.groupBoxBase2.TabStop = false;
            // 
            // vFakturiKnzienogrdBase
            // 
            this.vFakturiKnzienogrdBase.AllowUserToAddRows = false;
            this.vFakturiKnzienogrdBase.AllowUserToDeleteRows = false;
            this.vFakturiKnzienogrdBase.AllowUserToOrderColumns = true;
            this.vFakturiKnzienogrdBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vFakturiKnzienogrdBase.AssemblyToLoad = null;
            this.vFakturiKnzienogrdBase.AutoGenerateColumns = false;
            this.vFakturiKnzienogrdBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vFakturiKnzienogrdBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFaktura,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn12});
            this.vFakturiKnzienogrdBase.DataSource = this.vFakturiKnzienoBindingSource;
            this.vFakturiKnzienogrdBase.EditForm = null;
            this.vFakturiKnzienogrdBase.FilterForm = null;
            this.vFakturiKnzienogrdBase.Location = new System.Drawing.Point(6, 20);
            this.vFakturiKnzienogrdBase.Name = "vFakturiKnzienogrdBase";
            this.vFakturiKnzienogrdBase.PrimaryKey = null;
            this.vFakturiKnzienogrdBase.ReadOnly = true;
            this.vFakturiKnzienogrdBase.reportCenter = false;
            this.vFakturiKnzienogrdBase.ReportName = null;
            this.vFakturiKnzienogrdBase.Size = new System.Drawing.Size(1334, 470);
            this.vFakturiKnzienogrdBase.SQLCommandQuery = null;
            this.vFakturiKnzienogrdBase.TabIndex = 6;
            this.vFakturiKnzienogrdBase.UpdateTable = null;
            // 
            // btnSelektirajFakturi
            // 
            this.btnSelektirajFakturi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelektirajFakturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelektirajFakturi.Location = new System.Drawing.Point(5, 500);
            this.btnSelektirajFakturi.Name = "btnSelektirajFakturi";
            this.btnSelektirajFakturi.Size = new System.Drawing.Size(279, 54);
            this.btnSelektirajFakturi.TabIndex = 6;
            this.btnSelektirajFakturi.Text = "Селектирај ги сите";
            this.btnSelektirajFakturi.UseVisualStyleBackColor = true;
            this.btnSelektirajFakturi.Click += new System.EventHandler(this.btnSelektirajFakturi_Click);
            // 
            // btnProkniziFakturi
            // 
            this.btnProkniziFakturi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProkniziFakturi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProkniziFakturi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProkniziFakturi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProkniziFakturi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProkniziFakturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProkniziFakturi.Image = ((System.Drawing.Image)(resources.GetObject("btnProkniziFakturi.Image")));
            this.btnProkniziFakturi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProkniziFakturi.Location = new System.Drawing.Point(1035, 503);
            this.btnProkniziFakturi.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnProkniziFakturi.Name = "btnProkniziFakturi";
            this.btnProkniziFakturi.Size = new System.Drawing.Size(305, 54);
            this.btnProkniziFakturi.TabIndex = 5;
            this.btnProkniziFakturi.Text = "Прокнижи фактури";
            this.btnProkniziFakturi.UseVisualStyleBackColor = false;
            this.btnProkniziFakturi.Click += new System.EventHandler(this.btnProkniziFakturi_Click);
            // 
            // btnProkniziSmetki
            // 
            this.btnProkniziSmetki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProkniziSmetki.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProkniziSmetki.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProkniziSmetki.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProkniziSmetki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProkniziSmetki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProkniziSmetki.Image = ((System.Drawing.Image)(resources.GetObject("btnProkniziSmetki.Image")));
            this.btnProkniziSmetki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProkniziSmetki.Location = new System.Drawing.Point(1045, 506);
            this.btnProkniziSmetki.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnProkniziSmetki.Name = "btnProkniziSmetki";
            this.btnProkniziSmetki.Size = new System.Drawing.Size(302, 54);
            this.btnProkniziSmetki.TabIndex = 1;
            this.btnProkniziSmetki.Text = "Прокнижи сметки";
            this.btnProkniziSmetki.UseVisualStyleBackColor = false;
            this.btnProkniziSmetki.Click += new System.EventHandler(this.btnProkniziSmetki_Click);
            // 
            // vSmetkaKnizenjegrdBase
            // 
            this.vSmetkaKnizenjegrdBase.AllowUserToAddRows = false;
            this.vSmetkaKnizenjegrdBase.AllowUserToDeleteRows = false;
            this.vSmetkaKnizenjegrdBase.AllowUserToOrderColumns = true;
            this.vSmetkaKnizenjegrdBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vSmetkaKnizenjegrdBase.AssemblyToLoad = null;
            this.vSmetkaKnizenjegrdBase.AutoGenerateColumns = false;
            this.vSmetkaKnizenjegrdBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vSmetkaKnizenjegrdBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Broj,
            this.DatumPocetok,
            this.DatumKraj,
            this.Iznos,
            this.Zabeleska,
            this.Zatvorena});
            this.vSmetkaKnizenjegrdBase.DataSource = this.vSmetkaKnizenjeBindingSource;
            this.vSmetkaKnizenjegrdBase.EditForm = null;
            this.vSmetkaKnizenjegrdBase.FilterForm = null;
            this.vSmetkaKnizenjegrdBase.Location = new System.Drawing.Point(6, 19);
            this.vSmetkaKnizenjegrdBase.Name = "vSmetkaKnizenjegrdBase";
            this.vSmetkaKnizenjegrdBase.PrimaryKey = null;
            this.vSmetkaKnizenjegrdBase.ReadOnly = true;
            this.vSmetkaKnizenjegrdBase.reportCenter = false;
            this.vSmetkaKnizenjegrdBase.ReportName = null;
            this.vSmetkaKnizenjegrdBase.Size = new System.Drawing.Size(1344, 470);
            this.vSmetkaKnizenjegrdBase.SQLCommandQuery = null;
            this.vSmetkaKnizenjegrdBase.TabIndex = 1;
            this.vSmetkaKnizenjegrdBase.UpdateTable = null;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Износ";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // Zabeleska
            // 
            this.Zabeleska.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zabeleska.DataPropertyName = "Zabeleska";
            this.Zabeleska.HeaderText = "Забелешка";
            this.Zabeleska.Name = "Zabeleska";
            this.Zabeleska.ReadOnly = true;
            // 
            // btnSiteSmetki
            // 
            this.btnSiteSmetki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiteSmetki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiteSmetki.Location = new System.Drawing.Point(5, 506);
            this.btnSiteSmetki.Name = "btnSiteSmetki";
            this.btnSiteSmetki.Size = new System.Drawing.Size(279, 54);
            this.btnSiteSmetki.TabIndex = 2;
            this.btnSiteSmetki.Text = "Селектирај ги сите";
            this.btnSiteSmetki.UseVisualStyleBackColor = true;
            this.btnSiteSmetki.Click += new System.EventHandler(this.btnSiteSmetki_Click);
            // 
            // tabInterni
            // 
            this.tabInterni.Controls.Add(this.groupBoxBase3);
            this.tabInterni.Location = new System.Drawing.Point(4, 24);
            this.tabInterni.Name = "tabInterni";
            this.tabInterni.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterni.Size = new System.Drawing.Size(1353, 566);
            this.tabInterni.TabIndex = 3;
            this.tabInterni.Text = "Интерни документи";
            this.tabInterni.UseVisualStyleBackColor = true;
            // 
            // groupBoxBase3
            // 
            this.groupBoxBase3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBase3.Controls.Add(this.vDokumentiGrd);
            this.groupBoxBase3.Controls.Add(this.button1);
            this.groupBoxBase3.Controls.Add(this.btnProkniziInterni);
            this.groupBoxBase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBase3.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBase3.Name = "groupBoxBase3";
            this.groupBoxBase3.Size = new System.Drawing.Size(1347, 560);
            this.groupBoxBase3.TabIndex = 1;
            this.groupBoxBase3.TabStop = false;
            // 
            // vDokumentiGrd
            // 
            this.vDokumentiGrd.AllowUserToAddRows = false;
            this.vDokumentiGrd.AllowUserToDeleteRows = false;
            this.vDokumentiGrd.AllowUserToOrderColumns = true;
            this.vDokumentiGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vDokumentiGrd.AssemblyToLoad = null;
            this.vDokumentiGrd.AutoGenerateColumns = false;
            this.vDokumentiGrd.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.vDokumentiGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vDokumentiGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDD,
            this.tipNaDokumentDataGridViewTextBoxColumn,
            this.BrojNaDokument,
            this.nazivPartnerDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosBezDDVDataGridViewTextBoxColumn,
            this.DDVIznos,
            this.iznosSoDDVDataGridViewTextBoxColumn,
            this.tipNaKnizenjeDataGridViewTextBoxColumn});
            this.vDokumentiGrd.DataSource = this.vDokumentiKnizenoBindingSource;
            this.vDokumentiGrd.EditForm = null;
            this.vDokumentiGrd.FilterForm = null;
            this.vDokumentiGrd.Location = new System.Drawing.Point(6, 20);
            this.vDokumentiGrd.Name = "vDokumentiGrd";
            this.vDokumentiGrd.PrimaryKey = null;
            this.vDokumentiGrd.ReadOnly = true;
            this.vDokumentiGrd.reportCenter = false;
            this.vDokumentiGrd.ReportName = null;
            this.vDokumentiGrd.Size = new System.Drawing.Size(1334, 476);
            this.vDokumentiGrd.SQLCommandQuery = null;
            this.vDokumentiGrd.TabIndex = 6;
            this.vDokumentiGrd.UpdateTable = null;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Селектирај ги сите";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProkniziInterni
            // 
            this.btnProkniziInterni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProkniziInterni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProkniziInterni.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProkniziInterni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProkniziInterni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProkniziInterni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProkniziInterni.Image = ((System.Drawing.Image)(resources.GetObject("btnProkniziInterni.Image")));
            this.btnProkniziInterni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProkniziInterni.Location = new System.Drawing.Point(1018, 502);
            this.btnProkniziInterni.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnProkniziInterni.Name = "btnProkniziInterni";
            this.btnProkniziInterni.Size = new System.Drawing.Size(322, 54);
            this.btnProkniziInterni.TabIndex = 5;
            this.btnProkniziInterni.Text = "Прокнижи документи";
            this.btnProkniziInterni.UseVisualStyleBackColor = false;
            this.btnProkniziInterni.Click += new System.EventHandler(this.btnPotvrdi1_Click);
            // 
            // datum
            // 
            this.datum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum.Location = new System.Drawing.Point(7, 22);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(230, 31);
            this.datum.TabIndex = 6;
            this.datum.ValueChanged += new System.EventHandler(this.datum_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.datum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1355, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1074, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Прикажи ги сите";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BrojNaDokument
            // 
            this.BrojNaDokument.DataPropertyName = "BrojNaDokument";
            this.BrojNaDokument.HeaderText = "Број на документ";
            this.BrojNaDokument.Name = "BrojNaDokument";
            this.BrojNaDokument.ReadOnly = true;
            // 
            // DDVIznos
            // 
            this.DDVIznos.DataPropertyName = "DDVIznos";
            this.DDVIznos.HeaderText = "Износ ДДВ";
            this.DDVIznos.Name = "DDVIznos";
            this.DDVIznos.ReadOnly = true;
            // 
            // IDPriem
            // 
            this.IDPriem.DataPropertyName = "ID";
            this.IDPriem.HeaderText = "Реден број";
            this.IDPriem.Name = "IDPriem";
            this.IDPriem.ReadOnly = true;
            // 
            // PriemBroj
            // 
            this.PriemBroj.DataPropertyName = "PriemBroj";
            this.PriemBroj.HeaderText = "Број на прием";
            this.PriemBroj.Name = "PriemBroj";
            this.PriemBroj.ReadOnly = true;
            // 
            // Dobavuvac
            // 
            this.Dobavuvac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dobavuvac.DataPropertyName = "Dobavuvac";
            this.Dobavuvac.HeaderText = "Добавувач";
            this.Dobavuvac.Name = "Dobavuvac";
            this.Dobavuvac.ReadOnly = true;
            // 
            // PriemDatum
            // 
            this.PriemDatum.DataPropertyName = "PriemDatum";
            this.PriemDatum.HeaderText = "Датум на прием";
            this.PriemDatum.Name = "PriemDatum";
            this.PriemDatum.ReadOnly = true;
            // 
            // KalkulacijaBroj
            // 
            this.KalkulacijaBroj.DataPropertyName = "KalkulacijaBroj";
            this.KalkulacijaBroj.HeaderText = "Калкулација број";
            this.KalkulacijaBroj.Name = "KalkulacijaBroj";
            this.KalkulacijaBroj.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DDVIznos";
            this.dataGridViewTextBoxColumn13.HeaderText = "ДДВ Износ";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "IznosBezDDV";
            this.dataGridViewTextBoxColumn14.HeaderText = "Износ без ДДВ";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IznosSoDDV";
            this.dataGridViewTextBoxColumn15.HeaderText = "Износ со ДДВ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // vPriemiKnizenjeBindingSource
            // 
            this.vPriemiKnizenjeBindingSource.DataMember = "vPriemiKnizenje";
            this.vPriemiKnizenjeBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IDFaktura
            // 
            this.IDFaktura.DataPropertyName = "ID";
            this.IDFaktura.HeaderText = "Реден број";
            this.IDFaktura.Name = "IDFaktura";
            this.IDFaktura.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Broj";
            this.dataGridViewTextBoxColumn5.HeaderText = "Број на фактура";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Partner";
            this.dataGridViewTextBoxColumn8.HeaderText = "Партнер";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Датум на фактура";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Valuta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Валута";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FakturiranDDV";
            this.dataGridViewTextBoxColumn11.HeaderText = "Износ ДДВ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IznosBezDDV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Износ без ДДВ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Iznos";
            this.dataGridViewTextBoxColumn12.HeaderText = "Износ со ДДВ";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // vFakturiKnzienoBindingSource
            // 
            this.vFakturiKnzienoBindingSource.DataMember = "vFakturiKnzieno";
            this.vFakturiKnzienoBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // IDD
            // 
            this.IDD.DataPropertyName = "ID";
            dataGridViewCellStyle1.Format = "N0";
            this.IDD.DefaultCellStyle = dataGridViewCellStyle1;
            this.IDD.HeaderText = "Реден број";
            this.IDD.Name = "IDD";
            this.IDD.ReadOnly = true;
            // 
            // tipNaDokumentDataGridViewTextBoxColumn
            // 
            this.tipNaDokumentDataGridViewTextBoxColumn.DataPropertyName = "TipNaDokument";
            this.tipNaDokumentDataGridViewTextBoxColumn.HeaderText = "Тип на документ";
            this.tipNaDokumentDataGridViewTextBoxColumn.Name = "tipNaDokumentDataGridViewTextBoxColumn";
            this.tipNaDokumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivPartnerDataGridViewTextBoxColumn
            // 
            this.nazivPartnerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivPartnerDataGridViewTextBoxColumn.DataPropertyName = "NazivPartner";
            this.nazivPartnerDataGridViewTextBoxColumn.HeaderText = "Назив на партнер";
            this.nazivPartnerDataGridViewTextBoxColumn.Name = "nazivPartnerDataGridViewTextBoxColumn";
            this.nazivPartnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Датум";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosBezDDVDataGridViewTextBoxColumn
            // 
            this.iznosBezDDVDataGridViewTextBoxColumn.DataPropertyName = "IznosBezDDV";
            this.iznosBezDDVDataGridViewTextBoxColumn.HeaderText = "Износ без ДДВ";
            this.iznosBezDDVDataGridViewTextBoxColumn.Name = "iznosBezDDVDataGridViewTextBoxColumn";
            this.iznosBezDDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosSoDDVDataGridViewTextBoxColumn
            // 
            this.iznosSoDDVDataGridViewTextBoxColumn.DataPropertyName = "IznosSoDDV";
            this.iznosSoDDVDataGridViewTextBoxColumn.HeaderText = "Износ со ДДВ";
            this.iznosSoDDVDataGridViewTextBoxColumn.Name = "iznosSoDDVDataGridViewTextBoxColumn";
            this.iznosSoDDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipNaKnizenjeDataGridViewTextBoxColumn
            // 
            this.tipNaKnizenjeDataGridViewTextBoxColumn.DataPropertyName = "TipNaKnizenje";
            this.tipNaKnizenjeDataGridViewTextBoxColumn.HeaderText = "Тип на книжење";
            this.tipNaKnizenjeDataGridViewTextBoxColumn.Name = "tipNaKnizenjeDataGridViewTextBoxColumn";
            this.tipNaKnizenjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDokumentiKnizenoBindingSource
            // 
            this.vDokumentiKnizenoBindingSource.DataMember = "vDokumentiKnizeno";
            this.vDokumentiKnizenoBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "Реден број";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Broj
            // 
            this.Broj.DataPropertyName = "Broj";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Broj.DefaultCellStyle = dataGridViewCellStyle3;
            this.Broj.HeaderText = "Сметка Број";
            this.Broj.Name = "Broj";
            this.Broj.ReadOnly = true;
            // 
            // DatumPocetok
            // 
            this.DatumPocetok.DataPropertyName = "DatumPocetok";
            this.DatumPocetok.HeaderText = "Датум на почеток";
            this.DatumPocetok.Name = "DatumPocetok";
            this.DatumPocetok.ReadOnly = true;
            // 
            // DatumKraj
            // 
            this.DatumKraj.DataPropertyName = "DatumKraj";
            this.DatumKraj.HeaderText = "Датум на крај";
            this.DatumKraj.Name = "DatumKraj";
            this.DatumKraj.ReadOnly = true;
            // 
            // Zatvorena
            // 
            this.Zatvorena.DataPropertyName = "Zatvorena";
            this.Zatvorena.HeaderText = "Затворена";
            this.Zatvorena.Name = "Zatvorena";
            this.Zatvorena.ReadOnly = true;
            // 
            // vSmetkaKnizenjeBindingSource
            // 
            this.vSmetkaKnizenjeBindingSource.DataMember = "vSmetkaKnizenje";
            this.vSmetkaKnizenjeBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // vSmetkaKnizenjeTableAdapter
            // 
            this.vSmetkaKnizenjeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.viewIzvodiTableAdapter = null;
            this.tableAdapterManager.viewPriemiTableAdapter = null;
            this.tableAdapterManager.viewPriemStavkiTableAdapter = null;
            this.tableAdapterManager.vPriemiKnizenjeTableAdapter = null;
            this.tableAdapterManager.vSmetkaKnizenjeTableAdapter = this.vSmetkaKnizenjeTableAdapter;
            // 
            // vPriemiKnizenjeTableAdapter
            // 
            this.vPriemiKnizenjeTableAdapter.ClearBeforeFill = true;
            // 
            // vFakturiKnzienoTableAdapter
            // 
            this.vFakturiKnzienoTableAdapter.ClearBeforeFill = true;
            // 
            // vDokumentiKnizenoTableAdapter
            // 
            this.vDokumentiKnizenoTableAdapter.ClearBeforeFill = true;
            // 
            // frmKnizenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 733);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKnizenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжење";
            this.Load += new System.EventHandler(this.frmKnizenje_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.tabPriemi.ResumeLayout(false);
            this.groupBoxBase1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vPriemiKnizenjegrdBase)).EndInit();
            this.tabFakturi.ResumeLayout(false);
            this.groupBoxBase2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vFakturiKnzienogrdBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSmetkaKnizenjegrdBase)).EndInit();
            this.tabInterni.ResumeLayout(false);
            this.groupBoxBase3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vDokumentiGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vPriemiKnizenjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFakturiKnzienoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDokumentiKnizenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSmetkaKnizenjeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPriemi;
        private System.Windows.Forms.TabPage tabFakturi;
        private BssBase.groupBoxBase groupBoxBase1;
        private BssBase.groupBoxBase groupBoxBase2;
        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource vSmetkaKnizenjeBindingSource;
        private MaterijalnoDataSetTableAdapters.vSmetkaKnizenjeTableAdapter vSmetkaKnizenjeTableAdapter;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.Elements.btnPotvrdi btnProkniziSmetki;
        private BssBase.grdBase vSmetkaKnizenjegrdBase;
        private System.Windows.Forms.Button btnSiteSmetki;
        private System.Windows.Forms.BindingSource vPriemiKnizenjeBindingSource;
        private MaterijalnoDataSetTableAdapters.vPriemiKnizenjeTableAdapter vPriemiKnizenjeTableAdapter;
        private System.Windows.Forms.Button btnSelektirajPriemi;
        private BssBase.Elements.btnPotvrdi btnProkniziPriemi;
        private BssBase.grdBase vPriemiKnizenjegrdBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPriem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriemBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dobavuvac;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriemDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkulacijaBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource vFakturiKnzienoBindingSource;
        private MaterijalnoDataSetTableAdapters.vFakturiKnzienoTableAdapter vFakturiKnzienoTableAdapter;
        private System.Windows.Forms.Button btnSelektirajFakturi;
        private BssBase.Elements.btnPotvrdi btnProkniziFakturi;
        private BssBase.grdBase vFakturiKnzienogrdBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFaktura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetok;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zabeleska;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zatvorena;
        private System.Windows.Forms.TabPage tabInterni;
        private BssBase.groupBoxBase groupBoxBase3;
        private BssBase.grdBase vDokumentiGrd;
        private System.Windows.Forms.Button button1;
        private BssBase.Elements.btnPotvrdi btnProkniziInterni;
        private System.Windows.Forms.BindingSource vDokumentiKnizenoBindingSource;
        private MaterijalnoDataSetTableAdapters.vDokumentiKnizenoTableAdapter vDokumentiKnizenoTableAdapter;
        private BssBase.Elements.dtPickerBase datum;
        private GroupBox groupBox1;
        private Button button2;
        private DataGridViewTextBoxColumn IDD;
        private DataGridViewTextBoxColumn tipNaDokumentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BrojNaDokument;
        private DataGridViewTextBoxColumn nazivPartnerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iznosBezDDVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DDVIznos;
        private DataGridViewTextBoxColumn iznosSoDDVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipNaKnizenjeDataGridViewTextBoxColumn;

        public DataGridViewTextBoxColumn ID6
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
    }
}
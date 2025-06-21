namespace BSSR {
	partial class frmMainLogin {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
                
			}

		    if (disposing && (server != null))
		    {
		        server.Dispose();

            }
            
            base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Alerter.AlertButton alertButton3 = new DevExpress.XtraBars.Alerter.AlertButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainLogin));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tabControlBase1 = new BssBase.Elements.tabControlBase();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GroupLogin = new BssBase.groupBoxBase();
            this.bsslabel6 = new BssBase.Elements.Bsslabel();
            this.cmbServer = new BssBase.cmbBase();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.txtBaza = new BssBase.cmbBase();
            this.bsslabel4 = new BssBase.Elements.Bsslabel();
            this.txtJazik = new BssBase.cmbBase();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.cmbObjekt = new BssBase.cmbBase();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flKorisnici = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExport = new BssBase.Elements.btnPotvrdi();
            this.btnReload = new BssBase.Elements.btnPotvrdi();
            this.txtRegistry = new BssBase.txtBase();
            this.label1Setup = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.импортНаРегистриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.излеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOk = new BssBase.Elements.btnPotvrdi();
            this.Password = new BssBase.txtBase();
            this.UserName = new BssBase.txtBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.ReloadSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRegLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlBase1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.ReloadSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            // 
            // alertControl1
            // 
            this.alertControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertControl1.AppearanceCaption.Options.UseFont = true;
            this.alertControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertControl1.AppearanceText.Options.UseFont = true;
            this.alertControl1.AutoHeight = true;
            alertButton3.Name = "Отвори ја листата";
            this.alertControl1.Buttons.Add(alertButton3);
            this.alertControl1.ControlBoxPosition = DevExpress.XtraBars.Alerter.AlertFormControlBoxPosition.Right;
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            // 
            // tabControlBase1
            // 
            this.tabControlBase1.Controls.Add(this.tabPage1);
            this.tabControlBase1.Controls.Add(this.tabPage2);
            this.tabControlBase1.Controls.Add(this.tabPage3);
            this.tabControlBase1.Controls.Add(this.tabPage4);
            this.tabControlBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tabControlBase1.Location = new System.Drawing.Point(0, 0);
            this.tabControlBase1.Name = "tabControlBase1";
            this.tabControlBase1.SelectedIndex = 0;
            this.tabControlBase1.Size = new System.Drawing.Size(880, 456);
            this.tabControlBase1.TabIndex = 0;
            this.tabControlBase1.TabStop = false;
            this.tabControlBase1.SelectedIndexChanged += new System.EventHandler(this.tabControlBase1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupLogin);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Логирање";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupLogin
            // 
            this.GroupLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.GroupLogin.Controls.Add(this.bsslabel6);
            this.GroupLogin.Controls.Add(this.cmbServer);
            this.GroupLogin.Controls.Add(this.bsslabel5);
            this.GroupLogin.Controls.Add(this.txtBaza);
            this.GroupLogin.Controls.Add(this.bsslabel4);
            this.GroupLogin.Controls.Add(this.txtJazik);
            this.GroupLogin.Controls.Add(this.pictureBox1);
            this.GroupLogin.Controls.Add(this.bsslabel3);
            this.GroupLogin.Controls.Add(this.cmbObjekt);
            this.GroupLogin.Controls.Add(this.btnClose);
            this.GroupLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLogin.Location = new System.Drawing.Point(3, 3);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(866, 408);
            this.GroupLogin.TabIndex = 1;
            this.GroupLogin.TabStop = false;
            // 
            // bsslabel6
            // 
            this.bsslabel6.AutoSize = true;
            this.bsslabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel6.Location = new System.Drawing.Point(23, 336);
            this.bsslabel6.Name = "bsslabel6";
            this.bsslabel6.Size = new System.Drawing.Size(63, 18);
            this.bsslabel6.TabIndex = 14;
            this.bsslabel6.Text = "Сервер:";
            // 
            // cmbServer
            // 
            this.cmbServer.C_OnlyNumbers = false;
            this.cmbServer.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbServer.CurrentText = null;
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.DtTableName = null;
            this.cmbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(92, 334);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(297, 26);
            this.cmbServer.TabIndex = 3;
            this.cmbServer.value = null;
            this.cmbServer.SelectedIndexChanged += new System.EventHandler(this.cmbServer_SelectedIndexChanged);
            // 
            // bsslabel5
            // 
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel5.Location = new System.Drawing.Point(9, 368);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(80, 18);
            this.bsslabel5.TabIndex = 12;
            this.bsslabel5.Text = "Датабаза:";
            // 
            // txtBaza
            // 
            this.txtBaza.C_OnlyNumbers = false;
            this.txtBaza.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBaza.CurrentText = null;
            this.txtBaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBaza.DtTableName = null;
            this.txtBaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBaza.FormattingEnabled = true;
            this.txtBaza.Location = new System.Drawing.Point(92, 366);
            this.txtBaza.Name = "txtBaza";
            this.txtBaza.Size = new System.Drawing.Size(297, 26);
            this.txtBaza.TabIndex = 4;
            this.txtBaza.value = null;
            this.txtBaza.SelectedIndexChanged += new System.EventHandler(this.txtBaza_SelectedIndexChanged);
            this.txtBaza.Leave += new System.EventHandler(this.txtBaza_Leave);
            // 
            // bsslabel4
            // 
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel4.Location = new System.Drawing.Point(505, 338);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(52, 18);
            this.bsslabel4.TabIndex = 10;
            this.bsslabel4.Text = "Јазик:";
            // 
            // txtJazik
            // 
            this.txtJazik.C_OnlyNumbers = false;
            this.txtJazik.C_ShowRedOnLeaveIfEmpty = false;
            this.txtJazik.CurrentText = null;
            this.txtJazik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtJazik.DtTableName = null;
            this.txtJazik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtJazik.FormattingEnabled = true;
            this.txtJazik.Items.AddRange(new object[] {
            "Macedonian - MK",
            "English - US",
            "Albanian - AL"});
            this.txtJazik.Location = new System.Drawing.Point(563, 335);
            this.txtJazik.Name = "txtJazik";
            this.txtJazik.Size = new System.Drawing.Size(297, 26);
            this.txtJazik.TabIndex = 5;
            this.txtJazik.value = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.ReloadSettings;
            this.pictureBox1.Image = global::BSSR.Properties.Resources.bss_bmg_logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bsslabel3
            // 
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsslabel3.Location = new System.Drawing.Point(498, 368);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(59, 18);
            this.bsslabel3.TabIndex = 6;
            this.bsslabel3.Text = "Објект:";
            this.bsslabel3.Visible = false;
            // 
            // cmbObjekt
            // 
            this.cmbObjekt.C_OnlyNumbers = false;
            this.cmbObjekt.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbObjekt.CurrentText = null;
            this.cmbObjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjekt.DtTableName = null;
            this.cmbObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbObjekt.FormattingEnabled = true;
            this.cmbObjekt.Location = new System.Drawing.Point(563, 365);
            this.cmbObjekt.Name = "cmbObjekt";
            this.cmbObjekt.Size = new System.Drawing.Size(297, 26);
            this.cmbObjekt.TabIndex = 6;
            this.cmbObjekt.value = null;
            this.cmbObjekt.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(431, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Излез";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flKorisnici);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Листа на корисници";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // flKorisnici
            // 
            this.flKorisnici.BackColor = System.Drawing.Color.Transparent;
            this.flKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flKorisnici.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flKorisnici.Location = new System.Drawing.Point(3, 3);
            this.flKorisnici.Name = "flKorisnici";
            this.flKorisnici.Size = new System.Drawing.Size(866, 408);
            this.flKorisnici.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdateDatabase);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(872, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Превземи нова верзија";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Image = global::BSSR.Properties.Resources._001_11;
            this.btnUpdateDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDatabase.Location = new System.Drawing.Point(6, 236);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(858, 170);
            this.btnUpdateDatabase.TabIndex = 1;
            this.btnUpdateDatabase.TabStop = false;
            this.btnUpdateDatabase.Text = "Промени датабаза";
            this.btnUpdateDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateDatabase.UseVisualStyleBackColor = true;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::BSSR.Properties.Resources.bssIcon;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(6, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(858, 170);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Превземи нова верзија";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnExport);
            this.tabPage4.Controls.Add(this.btnReload);
            this.tabPage4.Controls.Add(this.txtRegistry);
            this.tabPage4.Controls.Add(this.label1Setup);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(872, 414);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Нов сетап";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(17, 322);
            this.btnExport.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(220, 47);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export All APP";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(191, 6);
            this.btnReload.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(220, 47);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "ОK";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtRegistry
            // 
            this.txtRegistry.AssemblyStr = null;
            this.txtRegistry.C_FillWithZeros = false;
            this.txtRegistry.C_OnlyNumbers = false;
            this.txtRegistry.C_RegEx = false;
            this.txtRegistry.C_ShowRedOnLeaveIfEmpty = false;
            this.txtRegistry.ColumnName1 = null;
            this.txtRegistry.ColumnName2 = null;
            this.txtRegistry.ColumnName3 = null;
            this.txtRegistry.ColumnName4 = null;
            this.txtRegistry.ColumnName5 = null;
            this.txtRegistry.ColumnName6 = null;
            this.txtRegistry.ColumnName7 = null;
            this.txtRegistry.daliCetiri = false;
            this.txtRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.txtRegistry.Format = null;
            this.txtRegistry.formToOpen = null;
            this.txtRegistry.iscistiGreenNaLeave = false;
            this.txtRegistry.KoristiFilterNaDatasource = false;
            this.txtRegistry.Location = new System.Drawing.Point(17, 6);
            this.txtRegistry.MakedonskiJazik = false;
            this.txtRegistry.MinLength = 0;
            this.txtRegistry.Name = "txtRegistry";
            this.txtRegistry.PopulateOtherFields = false;
            this.txtRegistry.regularExpression = null;
            this.txtRegistry.SelektrijaNaFokus = false;
            this.txtRegistry.Size = new System.Drawing.Size(168, 47);
            this.txtRegistry.TabIndex = 2;
            this.txtRegistry.Text = "BSSR5";
            // 
            // label1Setup
            // 
            this.label1Setup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Setup.BackColor = System.Drawing.Color.Red;
            this.label1Setup.ContextMenuStrip = this.contextMenuStrip1;
            this.label1Setup.Location = new System.Drawing.Point(12, 65);
            this.label1Setup.Name = "label1Setup";
            this.label1Setup.Size = new System.Drawing.Size(837, 239);
            this.label1Setup.TabIndex = 0;
            this.label1Setup.Text = "Реинсталација ";
            this.label1Setup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.импортНаРегистриToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem10,
            this.излеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(312, 214);
            this.contextMenuStrip1.Text = "Конфигурација";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem1.Text = "1. Креирање на регистри";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem2.Text = "2. Иницијализација на датабаза";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem3.Text = "3. Релоад на конфигурација и крај на сетап";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(308, 6);
            // 
            // импортНаРегистриToolStripMenuItem
            // 
            this.импортНаРегистриToolStripMenuItem.Name = "импортНаРегистриToolStripMenuItem";
            this.импортНаРегистриToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.импортНаРегистриToolStripMenuItem.Text = "Импорт на регистри";
            this.импортНаРегистриToolStripMenuItem.Click += new System.EventHandler(this.импортНаРегистриToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem5.Text = "SQL Execution";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem6.Text = "Backup database";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem7.Text = "Restore database";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(311, 22);
            this.toolStripMenuItem8.Text = "Restore configs from database";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(308, 6);
            // 
            // излеToolStripMenuItem
            // 
            this.излеToolStripMenuItem.Name = "излеToolStripMenuItem";
            this.излеToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.излеToolStripMenuItem.Text = "Излез";
            this.излеToolStripMenuItem.Click += new System.EventHandler(this.излеToolStripMenuItem_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(4, 587);
            this.btnOk.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(872, 80);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ОK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Password
            // 
            this.Password.AssemblyStr = null;
            this.Password.C_FillWithZeros = false;
            this.Password.C_OnlyNumbers = false;
            this.Password.C_RegEx = false;
            this.Password.C_ShowRedOnLeaveIfEmpty = false;
            this.Password.ColumnName1 = null;
            this.Password.ColumnName2 = null;
            this.Password.ColumnName3 = null;
            this.Password.ColumnName4 = null;
            this.Password.ColumnName5 = null;
            this.Password.ColumnName6 = null;
            this.Password.ColumnName7 = null;
            this.Password.daliCetiri = false;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Password.Format = null;
            this.Password.formToOpen = null;
            this.Password.iscistiGreenNaLeave = false;
            this.Password.KoristiFilterNaDatasource = false;
            this.Password.Location = new System.Drawing.Point(154, 527);
            this.Password.MakedonskiJazik = false;
            this.Password.MinLength = 0;
            this.Password.Name = "Password";
            this.Password.PopulateOtherFields = false;
            this.Password.regularExpression = null;
            this.Password.SelektrijaNaFokus = false;
            this.Password.Size = new System.Drawing.Size(699, 47);
            this.Password.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AssemblyStr = null;
            this.UserName.C_FillWithZeros = false;
            this.UserName.C_OnlyNumbers = false;
            this.UserName.C_RegEx = false;
            this.UserName.C_ShowRedOnLeaveIfEmpty = false;
            this.UserName.ColumnName1 = null;
            this.UserName.ColumnName2 = null;
            this.UserName.ColumnName3 = null;
            this.UserName.ColumnName4 = null;
            this.UserName.ColumnName5 = null;
            this.UserName.ColumnName6 = null;
            this.UserName.ColumnName7 = null;
            this.UserName.daliCetiri = false;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.UserName.Format = null;
            this.UserName.formToOpen = null;
            this.UserName.iscistiGreenNaLeave = false;
            this.UserName.KoristiFilterNaDatasource = false;
            this.UserName.Location = new System.Drawing.Point(154, 462);
            this.UserName.MakedonskiJazik = false;
            this.UserName.MinLength = 0;
            this.UserName.Name = "UserName";
            this.UserName.PopulateOtherFields = false;
            this.UserName.regularExpression = null;
            this.UserName.SelektrijaNaFokus = false;
            this.UserName.Size = new System.Drawing.Size(699, 47);
            this.UserName.TabIndex = 1;
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bsslabel1.Location = new System.Drawing.Point(16, 474);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(132, 29);
            this.bsslabel1.TabIndex = 4;
            this.bsslabel1.Text = "Корисник:";
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bsslabel2.Location = new System.Drawing.Point(32, 538);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(116, 29);
            this.bsslabel2.TabIndex = 5;
            this.bsslabel2.Text = "Лозинка:";
            // 
            // ReloadSettings
            // 
            this.ReloadSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshSettingsToolStripMenuItem,
            this.newRegLoadToolStripMenuItem});
            this.ReloadSettings.Name = "ReloadSettings";
            this.ReloadSettings.Size = new System.Drawing.Size(181, 70);
            // 
            // refreshSettingsToolStripMenuItem
            // 
            this.refreshSettingsToolStripMenuItem.Name = "refreshSettingsToolStripMenuItem";
            this.refreshSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshSettingsToolStripMenuItem.Text = "Refresh Settings";
            this.refreshSettingsToolStripMenuItem.Click += new System.EventHandler(this.refreshSettingsToolStripMenuItem_Click);
            // 
            // newRegLoadToolStripMenuItem
            // 
            this.newRegLoadToolStripMenuItem.Name = "newRegLoadToolStripMenuItem";
            this.newRegLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newRegLoadToolStripMenuItem.Text = "New RegLoad";
            this.newRegLoadToolStripMenuItem.Click += new System.EventHandler(this.newRegLoadToolStripMenuItem_Click);
            // 
            // frmMainLogin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(880, 679);
            this.Controls.Add(this.tabControlBase1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.bsslabel1);
            this.Controls.Add(this.bsslabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Најава";
            this.Activated += new System.EventHandler(this.frmMainLogin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmMainLogin_Load);
            this.Shown += new System.EventHandler(this.frmMainLogin_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainLogin_KeyDown);
            this.tabControlBase1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ReloadSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private BssBase.Elements.tabControlBase tabControlBase1;
        private System.Windows.Forms.TabPage tabPage1;
        private BssBase.groupBoxBase GroupLogin;
        private BssBase.Elements.Bsslabel bsslabel6;
        private BssBase.cmbBase cmbServer;
        private BssBase.Elements.Bsslabel bsslabel5;
        private BssBase.cmbBase txtBaza;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.cmbBase txtJazik;
        private BssBase.Elements.btnPotvrdi btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.cmbBase cmbObjekt;
        private BssBase.txtBase UserName;
        private BssBase.txtBase Password;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.FlowLayoutPanel flKorisnici;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1Setup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem излеToolStripMenuItem;
        private BssBase.txtBase txtRegistry;
        private BssBase.Elements.btnPotvrdi btnReload;
        private BssBase.Elements.btnPotvrdi btnExport;
        private System.Windows.Forms.ToolStripMenuItem импортНаРегистриToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ReloadSettings;
        private System.Windows.Forms.ToolStripMenuItem refreshSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRegLoadToolStripMenuItem;
    }
}


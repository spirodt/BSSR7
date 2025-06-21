namespace MFakturi.Forms {
	partial class frmPartneriEdit {
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
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label telefoniLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label eDBLabel;
            System.Windows.Forms.Label mestoLabel;
            System.Windows.Forms.Label tipLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label defaultKolicinaLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label brojNaStanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartneriEdit));
            this.fakturiDataSet = new MFakturi.FakturiDataSet();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPartneriTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblPartneriTableAdapter();
            this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
            this.tblPartneriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPartneriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sifratxtBase = new BssBase.txtBase();
            this.nazivtxtBase = new BssBase.txtBase();
            this.adresatxtBase = new BssBase.txtBase();
            this.telefonitxtBase = new BssBase.txtBase();
            this.emailtxtBase = new BssBase.txtBase();
            this.eDBtxtBase = new BssBase.txtBase();
            this.mestotxtBase = new BssBase.txtBase();
            this.tipcmbBase = new BssBase.cmbBase();
            this.cmbBase1 = new BssBase.cmbBase();
            this.tblPresmetkovniEdiniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPresmetkovniEdiniciTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblPresmetkovniEdiniciTableAdapter();
            this.TipNaDostava = new BssBase.cmbBase();
            this.notesTextBox = new BssBase.txtBase();
            this.brojNaStanTextBox = new BssBase.txtBase();
            this.defaultKolicinaTxt = new BssBase.txtBase();
            this.btnVnesiKarticka = new BssBase.Elements.btnVnesi();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            telefoniLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            eDBLabel = new System.Windows.Forms.Label();
            mestoLabel = new System.Windows.Forms.Label();
            tipLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            defaultKolicinaLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            brojNaStanLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingNavigator)).BeginInit();
            this.tblPartneriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPresmetkovniEdiniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Location = new System.Drawing.Point(0, 6);
            this.MainTab.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MainTab.Size = new System.Drawing.Size(1208, 780);
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Location = new System.Drawing.Point(4, 25);
            this.tabVnes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabVnes.Size = new System.Drawing.Size(1200, 751);
            // 
            // groupVnes
            // 
            this.groupVnes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupVnes.Controls.Add(this.btnVnesiKarticka);
            this.groupVnes.Controls.Add(this.defaultKolicinaTxt);
            this.groupVnes.Controls.Add(brojNaStanLabel);
            this.groupVnes.Controls.Add(this.brojNaStanTextBox);
            this.groupVnes.Controls.Add(notesLabel);
            this.groupVnes.Controls.Add(this.notesTextBox);
            this.groupVnes.Controls.Add(defaultKolicinaLabel);
            this.groupVnes.Controls.Add(label2);
            this.groupVnes.Controls.Add(this.TipNaDostava);
            this.groupVnes.Controls.Add(label1);
            this.groupVnes.Controls.Add(this.cmbBase1);
            this.groupVnes.Controls.Add(tipLabel);
            this.groupVnes.Controls.Add(this.tipcmbBase);
            this.groupVnes.Controls.Add(mestoLabel);
            this.groupVnes.Controls.Add(this.mestotxtBase);
            this.groupVnes.Controls.Add(eDBLabel);
            this.groupVnes.Controls.Add(this.eDBtxtBase);
            this.groupVnes.Controls.Add(emailLabel);
            this.groupVnes.Controls.Add(this.emailtxtBase);
            this.groupVnes.Controls.Add(telefoniLabel);
            this.groupVnes.Controls.Add(this.telefonitxtBase);
            this.groupVnes.Controls.Add(adresaLabel);
            this.groupVnes.Controls.Add(this.adresatxtBase);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(sifraLabel);
            this.groupVnes.Controls.Add(this.sifratxtBase);
            this.groupVnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupVnes.Location = new System.Drawing.Point(0, 0);
            this.groupVnes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupVnes.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupVnes.Size = new System.Drawing.Size(1200, 751);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 785);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PanelFooter.Size = new System.Drawing.Size(1207, 84);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(8, 1);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnZatvori.MinimumSize = new System.Drawing.Size(264, 71);
            this.btnZatvori.Size = new System.Drawing.Size(264, 71);
            this.btnZatvori.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(948, 1);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOk.MinimumSize = new System.Drawing.Size(264, 71);
            this.btnOk.Size = new System.Drawing.Size(264, 71);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.Location = new System.Drawing.Point(4, 37);
            sifraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(134, 36);
            sifraLabel.TabIndex = 0;
            sifraLabel.Text = "Шифра:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(4, 92);
            nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(112, 36);
            nazivLabel.TabIndex = 2;
            nazivLabel.Text = "Назив:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(4, 192);
            adresaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(129, 36);
            adresaLabel.TabIndex = 4;
            adresaLabel.Text = "Адреса:";
            // 
            // telefoniLabel
            // 
            telefoniLabel.AutoSize = true;
            telefoniLabel.Location = new System.Drawing.Point(4, 287);
            telefoniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoniLabel.Name = "telefoniLabel";
            telefoniLabel.Size = new System.Drawing.Size(172, 36);
            telefoniLabel.TabIndex = 6;
            telefoniLabel.Text = "Телефони:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(4, 337);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(106, 36);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "E-mail:";
            // 
            // eDBLabel
            // 
            eDBLabel.AutoSize = true;
            eDBLabel.Location = new System.Drawing.Point(521, 37);
            eDBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eDBLabel.Name = "eDBLabel";
            eDBLabel.Size = new System.Drawing.Size(88, 36);
            eDBLabel.TabIndex = 10;
            eDBLabel.Text = "ЕДБ:";
            // 
            // mestoLabel
            // 
            mestoLabel.AutoSize = true;
            mestoLabel.Location = new System.Drawing.Point(493, 393);
            mestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mestoLabel.Name = "mestoLabel";
            mestoLabel.Size = new System.Drawing.Size(111, 36);
            mestoLabel.TabIndex = 12;
            mestoLabel.Text = "Место:";
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.Location = new System.Drawing.Point(4, 393);
            tipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new System.Drawing.Size(75, 36);
            tipLabel.TabIndex = 14;
            tipLabel.Text = "Тип:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 446);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(373, 36);
            label1.TabIndex = 16;
            label1.Text = "Пресметковна единица :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 502);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(282, 36);
            label2.TabIndex = 18;
            label2.Text = "Начин на достава:";
            // 
            // defaultKolicinaLabel
            // 
            defaultKolicinaLabel.AutoSize = true;
            defaultKolicinaLabel.Location = new System.Drawing.Point(4, 558);
            defaultKolicinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            defaultKolicinaLabel.Name = "defaultKolicinaLabel";
            defaultKolicinaLabel.Size = new System.Drawing.Size(157, 36);
            defaultKolicinaLabel.TabIndex = 24;
            defaultKolicinaLabel.Text = "Количина";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(4, 625);
            notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(108, 36);
            notesLabel.TabIndex = 25;
            notesLabel.Text = "Инфо:";
            // 
            // brojNaStanLabel
            // 
            brojNaStanLabel.AutoSize = true;
            brojNaStanLabel.Location = new System.Drawing.Point(352, 558);
            brojNaStanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            brojNaStanLabel.Name = "brojNaStanLabel";
            brojNaStanLabel.Size = new System.Drawing.Size(178, 36);
            brojNaStanLabel.TabIndex = 26;
            brojNaStanLabel.Text = "Реден број:";
            // 
            // fakturiDataSet
            // 
            this.fakturiDataSet.DataSetName = "FakturiDataSet";
            this.fakturiDataSet.EnforceConstraints = false;
            this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPartneriBindingSource
            // 
            this.tblPartneriBindingSource.DataMember = "tblPartneri";
            this.tblPartneriBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tblPartneriTableAdapter
            // 
            this.tblPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblBankiTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaStavkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = this.tblPartneriTableAdapter;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblZiroSmetkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliVoSmetkaTableAdapter = null;
            this.tableAdapterManager.viewFakturiStavkiTableAdapter = null;
            this.tableAdapterManager.viewFakturiTableAdapter = null;
            this.tableAdapterManager.viewZiroSmetkeTableAdapter = null;
            // 
            // tblPartneriBindingNavigator
            // 
            this.tblPartneriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPartneriBindingNavigator.BindingSource = this.tblPartneriBindingSource;
            this.tblPartneriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPartneriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPartneriBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPartneriBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblPartneriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblPartneriBindingNavigatorSaveItem});
            this.tblPartneriBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPartneriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPartneriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPartneriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPartneriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPartneriBindingNavigator.Name = "tblPartneriBindingNavigator";
            this.tblPartneriBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tblPartneriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPartneriBindingNavigator.Size = new System.Drawing.Size(888, 31);
            this.tblPartneriBindingNavigator.TabIndex = 6;
            this.tblPartneriBindingNavigator.Text = "bindingNavigator1";
            this.tblPartneriBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tblPartneriBindingNavigatorSaveItem
            // 
            this.tblPartneriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPartneriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPartneriBindingNavigatorSaveItem.Image")));
            this.tblPartneriBindingNavigatorSaveItem.Name = "tblPartneriBindingNavigatorSaveItem";
            this.tblPartneriBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.tblPartneriBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // sifratxtBase
            // 
            this.sifratxtBase.AssemblyStr = null;
            this.sifratxtBase.C_FillWithZeros = false;
            this.sifratxtBase.C_OnlyNumbers = false;
            this.sifratxtBase.C_RegEx = false;
            this.sifratxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.sifratxtBase.ColumnName1 = null;
            this.sifratxtBase.ColumnName2 = null;
            this.sifratxtBase.ColumnName3 = null;
            this.sifratxtBase.ColumnName4 = null;
            this.sifratxtBase.ColumnName5 = null;
            this.sifratxtBase.ColumnName6 = null;
            this.sifratxtBase.ColumnName7 = null;
            this.sifratxtBase.daliCetiri = false;
            this.sifratxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Sifra", true));
            this.sifratxtBase.Format = null;
            this.sifratxtBase.formToOpen = null;
            this.sifratxtBase.iscistiGreenNaLeave = false;
            this.sifratxtBase.KoristiFilterNaDatasource = false;
            this.sifratxtBase.Location = new System.Drawing.Point(143, 33);
            this.sifratxtBase.MakedonskiJazik = false;
            this.sifratxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifratxtBase.MinLength = 0;
            this.sifratxtBase.Name = "sifratxtBase";
            this.sifratxtBase.PopulateOtherFields = false;
            this.sifratxtBase.regularExpression = null;
            this.sifratxtBase.SelektrijaNaFokus = false;
            this.sifratxtBase.Size = new System.Drawing.Size(376, 41);
            this.sifratxtBase.TabIndex = 0;
            // 
            // nazivtxtBase
            // 
            this.nazivtxtBase.AssemblyStr = null;
            this.nazivtxtBase.C_FillWithZeros = false;
            this.nazivtxtBase.C_OnlyNumbers = false;
            this.nazivtxtBase.C_RegEx = false;
            this.nazivtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.nazivtxtBase.ColumnName1 = null;
            this.nazivtxtBase.ColumnName2 = null;
            this.nazivtxtBase.ColumnName3 = null;
            this.nazivtxtBase.ColumnName4 = null;
            this.nazivtxtBase.ColumnName5 = null;
            this.nazivtxtBase.ColumnName6 = null;
            this.nazivtxtBase.ColumnName7 = null;
            this.nazivtxtBase.daliCetiri = false;
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.iscistiGreenNaLeave = false;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(143, 92);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Multiline = true;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(1044, 91);
            this.nazivtxtBase.TabIndex = 2;
            // 
            // adresatxtBase
            // 
            this.adresatxtBase.AssemblyStr = null;
            this.adresatxtBase.C_FillWithZeros = false;
            this.adresatxtBase.C_OnlyNumbers = false;
            this.adresatxtBase.C_RegEx = false;
            this.adresatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.adresatxtBase.ColumnName1 = null;
            this.adresatxtBase.ColumnName2 = null;
            this.adresatxtBase.ColumnName3 = null;
            this.adresatxtBase.ColumnName4 = null;
            this.adresatxtBase.ColumnName5 = null;
            this.adresatxtBase.ColumnName6 = null;
            this.adresatxtBase.ColumnName7 = null;
            this.adresatxtBase.daliCetiri = false;
            this.adresatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Adresa", true));
            this.adresatxtBase.Format = null;
            this.adresatxtBase.formToOpen = null;
            this.adresatxtBase.iscistiGreenNaLeave = false;
            this.adresatxtBase.KoristiFilterNaDatasource = false;
            this.adresatxtBase.Location = new System.Drawing.Point(143, 192);
            this.adresatxtBase.MakedonskiJazik = false;
            this.adresatxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adresatxtBase.MinLength = 0;
            this.adresatxtBase.Multiline = true;
            this.adresatxtBase.Name = "adresatxtBase";
            this.adresatxtBase.PopulateOtherFields = false;
            this.adresatxtBase.regularExpression = null;
            this.adresatxtBase.SelektrijaNaFokus = false;
            this.adresatxtBase.Size = new System.Drawing.Size(1044, 86);
            this.adresatxtBase.TabIndex = 3;
            // 
            // telefonitxtBase
            // 
            this.telefonitxtBase.AssemblyStr = null;
            this.telefonitxtBase.C_FillWithZeros = false;
            this.telefonitxtBase.C_OnlyNumbers = false;
            this.telefonitxtBase.C_RegEx = false;
            this.telefonitxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.telefonitxtBase.ColumnName1 = null;
            this.telefonitxtBase.ColumnName2 = null;
            this.telefonitxtBase.ColumnName3 = null;
            this.telefonitxtBase.ColumnName4 = null;
            this.telefonitxtBase.ColumnName5 = null;
            this.telefonitxtBase.ColumnName6 = null;
            this.telefonitxtBase.ColumnName7 = null;
            this.telefonitxtBase.daliCetiri = false;
            this.telefonitxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Telefoni", true));
            this.telefonitxtBase.Format = null;
            this.telefonitxtBase.formToOpen = null;
            this.telefonitxtBase.iscistiGreenNaLeave = false;
            this.telefonitxtBase.KoristiFilterNaDatasource = false;
            this.telefonitxtBase.Location = new System.Drawing.Point(207, 287);
            this.telefonitxtBase.MakedonskiJazik = false;
            this.telefonitxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefonitxtBase.MinLength = 0;
            this.telefonitxtBase.Name = "telefonitxtBase";
            this.telefonitxtBase.PopulateOtherFields = false;
            this.telefonitxtBase.regularExpression = null;
            this.telefonitxtBase.SelektrijaNaFokus = false;
            this.telefonitxtBase.Size = new System.Drawing.Size(980, 41);
            this.telefonitxtBase.TabIndex = 4;
            // 
            // emailtxtBase
            // 
            this.emailtxtBase.AssemblyStr = null;
            this.emailtxtBase.C_FillWithZeros = false;
            this.emailtxtBase.C_OnlyNumbers = false;
            this.emailtxtBase.C_RegEx = false;
            this.emailtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.emailtxtBase.ColumnName1 = null;
            this.emailtxtBase.ColumnName2 = null;
            this.emailtxtBase.ColumnName3 = null;
            this.emailtxtBase.ColumnName4 = null;
            this.emailtxtBase.ColumnName5 = null;
            this.emailtxtBase.ColumnName6 = null;
            this.emailtxtBase.ColumnName7 = null;
            this.emailtxtBase.daliCetiri = false;
            this.emailtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Email", true));
            this.emailtxtBase.Format = null;
            this.emailtxtBase.formToOpen = null;
            this.emailtxtBase.iscistiGreenNaLeave = false;
            this.emailtxtBase.KoristiFilterNaDatasource = false;
            this.emailtxtBase.Location = new System.Drawing.Point(143, 337);
            this.emailtxtBase.MakedonskiJazik = false;
            this.emailtxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailtxtBase.MinLength = 0;
            this.emailtxtBase.Name = "emailtxtBase";
            this.emailtxtBase.PopulateOtherFields = false;
            this.emailtxtBase.regularExpression = null;
            this.emailtxtBase.SelektrijaNaFokus = false;
            this.emailtxtBase.Size = new System.Drawing.Size(1044, 41);
            this.emailtxtBase.TabIndex = 5;
            // 
            // eDBtxtBase
            // 
            this.eDBtxtBase.AssemblyStr = null;
            this.eDBtxtBase.C_FillWithZeros = false;
            this.eDBtxtBase.C_OnlyNumbers = false;
            this.eDBtxtBase.C_RegEx = false;
            this.eDBtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.eDBtxtBase.ColumnName1 = null;
            this.eDBtxtBase.ColumnName2 = null;
            this.eDBtxtBase.ColumnName3 = null;
            this.eDBtxtBase.ColumnName4 = null;
            this.eDBtxtBase.ColumnName5 = null;
            this.eDBtxtBase.ColumnName6 = null;
            this.eDBtxtBase.ColumnName7 = null;
            this.eDBtxtBase.daliCetiri = false;
            this.eDBtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "EDB", true));
            this.eDBtxtBase.Format = null;
            this.eDBtxtBase.formToOpen = null;
            this.eDBtxtBase.iscistiGreenNaLeave = false;
            this.eDBtxtBase.KoristiFilterNaDatasource = false;
            this.eDBtxtBase.Location = new System.Drawing.Point(615, 33);
            this.eDBtxtBase.MakedonskiJazik = false;
            this.eDBtxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eDBtxtBase.MinLength = 0;
            this.eDBtxtBase.Name = "eDBtxtBase";
            this.eDBtxtBase.PopulateOtherFields = false;
            this.eDBtxtBase.regularExpression = null;
            this.eDBtxtBase.SelektrijaNaFokus = false;
            this.eDBtxtBase.Size = new System.Drawing.Size(572, 41);
            this.eDBtxtBase.TabIndex = 1;
            // 
            // mestotxtBase
            // 
            this.mestotxtBase.AssemblyStr = null;
            this.mestotxtBase.C_FillWithZeros = false;
            this.mestotxtBase.C_OnlyNumbers = false;
            this.mestotxtBase.C_RegEx = false;
            this.mestotxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.mestotxtBase.ColumnName1 = null;
            this.mestotxtBase.ColumnName2 = null;
            this.mestotxtBase.ColumnName3 = null;
            this.mestotxtBase.ColumnName4 = null;
            this.mestotxtBase.ColumnName5 = null;
            this.mestotxtBase.ColumnName6 = null;
            this.mestotxtBase.ColumnName7 = null;
            this.mestotxtBase.daliCetiri = false;
            this.mestotxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Mesto", true));
            this.mestotxtBase.Format = null;
            this.mestotxtBase.formToOpen = null;
            this.mestotxtBase.iscistiGreenNaLeave = false;
            this.mestotxtBase.KoristiFilterNaDatasource = false;
            this.mestotxtBase.Location = new System.Drawing.Point(615, 388);
            this.mestotxtBase.MakedonskiJazik = false;
            this.mestotxtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mestotxtBase.MinLength = 0;
            this.mestotxtBase.Name = "mestotxtBase";
            this.mestotxtBase.PopulateOtherFields = false;
            this.mestotxtBase.regularExpression = null;
            this.mestotxtBase.SelektrijaNaFokus = false;
            this.mestotxtBase.Size = new System.Drawing.Size(572, 41);
            this.mestotxtBase.TabIndex = 7;
            // 
            // tipcmbBase
            // 
            this.tipcmbBase.C_OnlyNumbers = false;
            this.tipcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.tipcmbBase.CurrentText = null;
            this.tipcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipcmbBase.DtTableName = null;
            this.tipcmbBase.FormattingEnabled = true;
            this.tipcmbBase.Items.AddRange(new object[] {
            "Купувач",
            "Добавувач",
            "Фактура/Документ",
            "Генериран"});
            this.tipcmbBase.Location = new System.Drawing.Point(99, 389);
            this.tipcmbBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipcmbBase.Name = "tipcmbBase";
            this.tipcmbBase.Size = new System.Drawing.Size(388, 44);
            this.tipcmbBase.TabIndex = 6;
            this.tipcmbBase.value = null;
            // 
            // cmbBase1
            // 
            this.cmbBase1.C_OnlyNumbers = false;
            this.cmbBase1.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbBase1.CurrentText = null;
            this.cmbBase1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblPartneriBindingSource, "tblPresmetkovnaEdinicaID", true));
            this.cmbBase1.DataSource = this.tblPresmetkovniEdiniciBindingSource;
            this.cmbBase1.DisplayMember = "Naziv";
            this.cmbBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase1.DtTableName = null;
            this.cmbBase1.FormattingEnabled = true;
            this.cmbBase1.Location = new System.Drawing.Point(435, 446);
            this.cmbBase1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBase1.Name = "cmbBase1";
            this.cmbBase1.Size = new System.Drawing.Size(752, 44);
            this.cmbBase1.TabIndex = 8;
            this.cmbBase1.value = null;
            this.cmbBase1.ValueMember = "ID";
            // 
            // tblPresmetkovniEdiniciBindingSource
            // 
            this.tblPresmetkovniEdiniciBindingSource.DataMember = "tblPresmetkovniEdinici";
            this.tblPresmetkovniEdiniciBindingSource.DataSource = this.fakturiDataSet;
            // 
            // tblPresmetkovniEdiniciTableAdapter
            // 
            this.tblPresmetkovniEdiniciTableAdapter.ClearBeforeFill = true;
            // 
            // TipNaDostava
            // 
            this.TipNaDostava.C_OnlyNumbers = false;
            this.TipNaDostava.C_ShowRedOnLeaveIfEmpty = false;
            this.TipNaDostava.CurrentText = null;
            this.TipNaDostava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipNaDostava.DtTableName = null;
            this.TipNaDostava.FormattingEnabled = true;
            this.TipNaDostava.Items.AddRange(new object[] {
            "Xартиена форма",
            "Eлектонска форма ( маил )",
            "Xартиена и Eлектронска форма",
            "Нема достава"});
            this.TipNaDostava.Location = new System.Drawing.Point(331, 498);
            this.TipNaDostava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TipNaDostava.Name = "TipNaDostava";
            this.TipNaDostava.Size = new System.Drawing.Size(856, 44);
            this.TipNaDostava.TabIndex = 9;
            this.TipNaDostava.value = null;
            // 
            // notesTextBox
            // 
            this.notesTextBox.AssemblyStr = null;
            this.notesTextBox.C_FillWithZeros = false;
            this.notesTextBox.C_OnlyNumbers = false;
            this.notesTextBox.C_RegEx = false;
            this.notesTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.notesTextBox.ColumnName1 = null;
            this.notesTextBox.ColumnName2 = null;
            this.notesTextBox.ColumnName3 = null;
            this.notesTextBox.ColumnName4 = null;
            this.notesTextBox.ColumnName5 = null;
            this.notesTextBox.ColumnName6 = null;
            this.notesTextBox.ColumnName7 = null;
            this.notesTextBox.daliCetiri = false;
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "Notes", true));
            this.notesTextBox.Format = null;
            this.notesTextBox.formToOpen = null;
            this.notesTextBox.iscistiGreenNaLeave = false;
            this.notesTextBox.KoristiFilterNaDatasource = false;
            this.notesTextBox.Location = new System.Drawing.Point(143, 622);
            this.notesTextBox.MakedonskiJazik = false;
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notesTextBox.MinLength = 0;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.PopulateOtherFields = false;
            this.notesTextBox.regularExpression = null;
            this.notesTextBox.SelektrijaNaFokus = false;
            this.notesTextBox.Size = new System.Drawing.Size(1044, 117);
            this.notesTextBox.TabIndex = 12;
            // 
            // brojNaStanTextBox
            // 
            this.brojNaStanTextBox.AssemblyStr = null;
            this.brojNaStanTextBox.C_FillWithZeros = false;
            this.brojNaStanTextBox.C_OnlyNumbers = true;
            this.brojNaStanTextBox.C_RegEx = false;
            this.brojNaStanTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.brojNaStanTextBox.ColumnName1 = null;
            this.brojNaStanTextBox.ColumnName2 = null;
            this.brojNaStanTextBox.ColumnName3 = null;
            this.brojNaStanTextBox.ColumnName4 = null;
            this.brojNaStanTextBox.ColumnName5 = null;
            this.brojNaStanTextBox.ColumnName6 = null;
            this.brojNaStanTextBox.ColumnName7 = null;
            this.brojNaStanTextBox.daliCetiri = false;
            this.brojNaStanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "BrojNaStan", true));
            this.brojNaStanTextBox.Format = null;
            this.brojNaStanTextBox.formToOpen = null;
            this.brojNaStanTextBox.iscistiGreenNaLeave = false;
            this.brojNaStanTextBox.KoristiFilterNaDatasource = false;
            this.brojNaStanTextBox.Location = new System.Drawing.Point(565, 558);
            this.brojNaStanTextBox.MakedonskiJazik = false;
            this.brojNaStanTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brojNaStanTextBox.MinLength = 0;
            this.brojNaStanTextBox.Name = "brojNaStanTextBox";
            this.brojNaStanTextBox.PopulateOtherFields = false;
            this.brojNaStanTextBox.regularExpression = null;
            this.brojNaStanTextBox.SelektrijaNaFokus = false;
            this.brojNaStanTextBox.Size = new System.Drawing.Size(132, 41);
            this.brojNaStanTextBox.TabIndex = 11;
            // 
            // defaultKolicinaTxt
            // 
            this.defaultKolicinaTxt.AssemblyStr = null;
            this.defaultKolicinaTxt.C_Decimal = true;
            this.defaultKolicinaTxt.C_FillWithZeros = false;
            this.defaultKolicinaTxt.C_OnlyNumbers = true;
            this.defaultKolicinaTxt.C_RegEx = false;
            this.defaultKolicinaTxt.C_ShowRedOnLeaveIfEmpty = false;
            this.defaultKolicinaTxt.ColumnName1 = null;
            this.defaultKolicinaTxt.ColumnName2 = null;
            this.defaultKolicinaTxt.ColumnName3 = null;
            this.defaultKolicinaTxt.ColumnName4 = null;
            this.defaultKolicinaTxt.ColumnName5 = null;
            this.defaultKolicinaTxt.ColumnName6 = null;
            this.defaultKolicinaTxt.ColumnName7 = null;
            this.defaultKolicinaTxt.daliCetiri = false;
            this.defaultKolicinaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPartneriBindingSource, "DefaultKolicina", true));
            this.defaultKolicinaTxt.Format = null;
            this.defaultKolicinaTxt.formToOpen = null;
            this.defaultKolicinaTxt.iscistiGreenNaLeave = false;
            this.defaultKolicinaTxt.KoristiFilterNaDatasource = false;
            this.defaultKolicinaTxt.Location = new System.Drawing.Point(185, 558);
            this.defaultKolicinaTxt.MakedonskiJazik = false;
            this.defaultKolicinaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.defaultKolicinaTxt.MinLength = 0;
            this.defaultKolicinaTxt.Name = "defaultKolicinaTxt";
            this.defaultKolicinaTxt.PopulateOtherFields = false;
            this.defaultKolicinaTxt.regularExpression = null;
            this.defaultKolicinaTxt.SelektrijaNaFokus = false;
            this.defaultKolicinaTxt.Size = new System.Drawing.Size(132, 41);
            this.defaultKolicinaTxt.TabIndex = 10;
            this.defaultKolicinaTxt.Text = "0,00";
            // 
            // btnVnesiKarticka
            // 
            this.btnVnesiKarticka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVnesiKarticka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVnesiKarticka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVnesiKarticka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVnesiKarticka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVnesiKarticka.Image = ((System.Drawing.Image)(resources.GetObject("btnVnesiKarticka.Image")));
            this.btnVnesiKarticka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVnesiKarticka.Location = new System.Drawing.Point(800, 552);
            this.btnVnesiKarticka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVnesiKarticka.MinimumSize = new System.Drawing.Size(117, 31);
            this.btnVnesiKarticka.Name = "btnVnesiKarticka";
            this.btnVnesiKarticka.Size = new System.Drawing.Size(391, 50);
            this.btnVnesiKarticka.TabIndex = 27;
            this.btnVnesiKarticka.Text = "Прочитај картичка";
            this.btnVnesiKarticka.UseVisualStyleBackColor = false;
            this.btnVnesiKarticka.Visible = false;
            this.btnVnesiKarticka.Click += new System.EventHandler(this.btnVnesiKarticka_Click);
            // 
            // frmPartneriEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 870);
            this.Controls.Add(this.tblPartneriBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MinimumSize = new System.Drawing.Size(1226, 456);
            this.Name = "frmPartneriEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblPartneriEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblPartneriBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingNavigator)).EndInit();
            this.tblPartneriBindingNavigator.ResumeLayout(false);
            this.tblPartneriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPresmetkovniEdiniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource tblPartneriBindingSource;
		private FakturiDataSetTableAdapters.tblPartneriTableAdapter tblPartneriTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblPartneriBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton tblPartneriBindingNavigatorSaveItem;
		private BssBase.txtBase sifratxtBase;
		private BssBase.cmbBase tipcmbBase;
		private BssBase.txtBase mestotxtBase;
		private BssBase.txtBase eDBtxtBase;
		private BssBase.txtBase emailtxtBase;
		private BssBase.txtBase telefonitxtBase;
		private BssBase.txtBase adresatxtBase;
		private BssBase.txtBase nazivtxtBase;
        private BssBase.cmbBase cmbBase1;
        private System.Windows.Forms.BindingSource tblPresmetkovniEdiniciBindingSource;
        private FakturiDataSetTableAdapters.tblPresmetkovniEdiniciTableAdapter tblPresmetkovniEdiniciTableAdapter;
        private BssBase.cmbBase TipNaDostava;
        private BssBase.txtBase notesTextBox;
        private BssBase.txtBase brojNaStanTextBox;
        private BssBase.txtBase defaultKolicinaTxt;
        private BssBase.Elements.btnVnesi btnVnesiKarticka;
    }
}
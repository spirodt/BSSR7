namespace BSSR.Forms {
	partial class frmKorisniciEdit {
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label nivoNaAdministracijaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKorisniciEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblUsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblUsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userNametxtBase = new BssBase.txtBase();
            this.passwordtxtBase = new BssBase.txtBase();
            this.fullNametxtBase = new BssBase.txtBase();
            this.nivoNaAdministracijaComboBox = new System.Windows.Forms.ComboBox();
            this.bsslabel3 = new BssBase.Elements.Bsslabel();
            this.cmbObjekt = new BssBase.cmbBase();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            nivoNaAdministracijaLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingNavigator)).BeginInit();
            this.tblUsersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(644, 282);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(636, 256);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.bsslabel3);
            this.groupVnes.Controls.Add(this.cmbObjekt);
            this.groupVnes.Controls.Add(this.nivoNaAdministracijaComboBox);
            this.groupVnes.Controls.Add(userNameLabel);
            this.groupVnes.Controls.Add(this.userNametxtBase);
            this.groupVnes.Controls.Add(passwordLabel);
            this.groupVnes.Controls.Add(this.passwordtxtBase);
            this.groupVnes.Controls.Add(fullNameLabel);
            this.groupVnes.Controls.Add(this.fullNametxtBase);
            this.groupVnes.Controls.Add(nivoNaAdministracijaLabel);
            this.groupVnes.Size = new System.Drawing.Size(633, 253);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 281);
            this.PanelFooter.Size = new System.Drawing.Size(648, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 5);
            this.btnZatvori.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(457, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(110, 34);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(213, 29);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Корисничко име:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(207, 75);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(116, 29);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Лозинка:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(254, 116);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(69, 29);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Име:";
            // 
            // nivoNaAdministracijaLabel
            // 
            nivoNaAdministracijaLabel.AutoSize = true;
            nivoNaAdministracijaLabel.Location = new System.Drawing.Point(15, 156);
            nivoNaAdministracijaLabel.Name = "nivoNaAdministracijaLabel";
            nivoNaAdministracijaLabel.Size = new System.Drawing.Size(308, 29);
            nivoNaAdministracijaLabel.TabIndex = 8;
            nivoNaAdministracijaLabel.Text = "Ниво на администрација:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAkcijaNaArtikalTableAdapter = null;
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
            this.tableAdapterManager.tblNarackiTableAdapter = null;
            this.tableAdapterManager.tblNormativiSodriznaIznosTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblTipNaDokumentTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.tblZabeleshkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblUsersBindingNavigator
            // 
            this.tblUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblUsersBindingNavigator.BindingSource = this.tblUsersBindingSource;
            this.tblUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblUsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblUsersBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblUsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblUsersBindingNavigatorSaveItem});
            this.tblUsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblUsersBindingNavigator.Name = "tblUsersBindingNavigator";
            this.tblUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblUsersBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblUsersBindingNavigator.TabIndex = 6;
            this.tblUsersBindingNavigator.Text = "bindingNavigator1";
            this.tblUsersBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblUsersBindingNavigatorSaveItem
            // 
            this.tblUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblUsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblUsersBindingNavigatorSaveItem.Image")));
            this.tblUsersBindingNavigatorSaveItem.Name = "tblUsersBindingNavigatorSaveItem";
            this.tblUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblUsersBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // userNametxtBase
            // 
            this.userNametxtBase.AssemblyStr = null;
            this.userNametxtBase.C_FillWithZeros = false;
            this.userNametxtBase.C_OnlyNumbers = false;
            this.userNametxtBase.C_RegEx = false;
            this.userNametxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.userNametxtBase.ColumnName1 = null;
            this.userNametxtBase.ColumnName2 = null;
            this.userNametxtBase.ColumnName3 = null;
            this.userNametxtBase.ColumnName4 = null;
            this.userNametxtBase.ColumnName5 = null;
            this.userNametxtBase.ColumnName6 = null;
            this.userNametxtBase.ColumnName7 = null;
            this.userNametxtBase.daliCetiri = false;
            this.userNametxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "UserName", true));
            this.userNametxtBase.Format = null;
            this.userNametxtBase.formToOpen = null;
            this.userNametxtBase.iscistiGreenNaLeave = false;
            this.userNametxtBase.KoristiFilterNaDatasource = false;
            this.userNametxtBase.Location = new System.Drawing.Point(331, 34);
            this.userNametxtBase.MakedonskiJazik = false;
            this.userNametxtBase.MinLength = 0;
            this.userNametxtBase.Name = "userNametxtBase";
            this.userNametxtBase.PopulateOtherFields = false;
            this.userNametxtBase.regularExpression = null;
            this.userNametxtBase.SelektrijaNaFokus = false;
            this.userNametxtBase.Size = new System.Drawing.Size(295, 35);
            this.userNametxtBase.TabIndex = 0;
            // 
            // passwordtxtBase
            // 
            this.passwordtxtBase.AssemblyStr = null;
            this.passwordtxtBase.C_FillWithZeros = false;
            this.passwordtxtBase.C_OnlyNumbers = false;
            this.passwordtxtBase.C_RegEx = false;
            this.passwordtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.passwordtxtBase.ColumnName1 = null;
            this.passwordtxtBase.ColumnName2 = null;
            this.passwordtxtBase.ColumnName3 = null;
            this.passwordtxtBase.ColumnName4 = null;
            this.passwordtxtBase.ColumnName5 = null;
            this.passwordtxtBase.ColumnName6 = null;
            this.passwordtxtBase.ColumnName7 = null;
            this.passwordtxtBase.daliCetiri = false;
            this.passwordtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Password", true));
            this.passwordtxtBase.Format = null;
            this.passwordtxtBase.formToOpen = null;
            this.passwordtxtBase.iscistiGreenNaLeave = false;
            this.passwordtxtBase.KoristiFilterNaDatasource = false;
            this.passwordtxtBase.Location = new System.Drawing.Point(331, 75);
            this.passwordtxtBase.MakedonskiJazik = false;
            this.passwordtxtBase.MinLength = 0;
            this.passwordtxtBase.Name = "passwordtxtBase";
            this.passwordtxtBase.PopulateOtherFields = false;
            this.passwordtxtBase.regularExpression = null;
            this.passwordtxtBase.SelektrijaNaFokus = false;
            this.passwordtxtBase.Size = new System.Drawing.Size(295, 35);
            this.passwordtxtBase.TabIndex = 1;
            // 
            // fullNametxtBase
            // 
            this.fullNametxtBase.AssemblyStr = null;
            this.fullNametxtBase.C_FillWithZeros = false;
            this.fullNametxtBase.C_OnlyNumbers = false;
            this.fullNametxtBase.C_RegEx = false;
            this.fullNametxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.fullNametxtBase.ColumnName1 = null;
            this.fullNametxtBase.ColumnName2 = null;
            this.fullNametxtBase.ColumnName3 = null;
            this.fullNametxtBase.ColumnName4 = null;
            this.fullNametxtBase.ColumnName5 = null;
            this.fullNametxtBase.ColumnName6 = null;
            this.fullNametxtBase.ColumnName7 = null;
            this.fullNametxtBase.daliCetiri = false;
            this.fullNametxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "FullName", true));
            this.fullNametxtBase.Format = null;
            this.fullNametxtBase.formToOpen = null;
            this.fullNametxtBase.iscistiGreenNaLeave = false;
            this.fullNametxtBase.KoristiFilterNaDatasource = false;
            this.fullNametxtBase.Location = new System.Drawing.Point(331, 116);
            this.fullNametxtBase.MakedonskiJazik = false;
            this.fullNametxtBase.MinLength = 0;
            this.fullNametxtBase.Name = "fullNametxtBase";
            this.fullNametxtBase.PopulateOtherFields = false;
            this.fullNametxtBase.regularExpression = null;
            this.fullNametxtBase.SelektrijaNaFokus = false;
            this.fullNametxtBase.Size = new System.Drawing.Size(295, 35);
            this.fullNametxtBase.TabIndex = 2;
            // 
            // nivoNaAdministracijaComboBox
            // 
            this.nivoNaAdministracijaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivoNaAdministracijaComboBox.FormattingEnabled = true;
            this.nivoNaAdministracijaComboBox.Items.AddRange(new object[] {
            "1 -  Каса",
            "2 -  Ресторан левел 1",
            "3 -  Интернет кафе (deleted)",
            "4 -  Ресторан Контролор ",
            "6 -  Администратор ",
            "7 -  Супер Администратор",
            "8 - Каса Левел 2"});
            this.nivoNaAdministracijaComboBox.Location = new System.Drawing.Point(331, 156);
            this.nivoNaAdministracijaComboBox.Name = "nivoNaAdministracijaComboBox";
            this.nivoNaAdministracijaComboBox.Size = new System.Drawing.Size(295, 37);
            this.nivoNaAdministracijaComboBox.TabIndex = 3;
            // 
            // bsslabel3
            // 
            this.bsslabel3.AutoSize = true;
            this.bsslabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bsslabel3.Location = new System.Drawing.Point(227, 204);
            this.bsslabel3.Name = "bsslabel3";
            this.bsslabel3.Size = new System.Drawing.Size(96, 29);
            this.bsslabel3.TabIndex = 9;
            this.bsslabel3.Text = "Објект:";
            // 
            // cmbObjekt
            // 
            this.cmbObjekt.C_OnlyNumbers = false;
            this.cmbObjekt.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbObjekt.CurrentText = null;
            this.cmbObjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjekt.DtTableName = null;
            this.cmbObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbObjekt.FormattingEnabled = true;
            this.cmbObjekt.Location = new System.Drawing.Point(329, 199);
            this.cmbObjekt.Name = "cmbObjekt";
            this.cmbObjekt.Size = new System.Drawing.Size(297, 37);
            this.cmbObjekt.TabIndex = 10;
            this.cmbObjekt.value = null;
            // 
            // frmKorisniciEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 350);
            this.Controls.Add(this.tblUsersBindingNavigator);
            this.Name = "frmKorisniciEdit";
            this.Text = "Додади/Измени корисник";
            this.Load += new System.EventHandler(this.frmtblUsersEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblUsersBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingNavigator)).EndInit();
            this.tblUsersBindingNavigator.ResumeLayout(false);
            this.tblUsersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblUsersBindingSource;
		private BSSSDatasetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblUsersBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblUsersBindingNavigatorSaveItem;
		private BssBase.txtBase userNametxtBase;
		private BssBase.txtBase passwordtxtBase;
		private BssBase.txtBase fullNametxtBase;
		private System.Windows.Forms.ComboBox nivoNaAdministracijaComboBox;
        private BssBase.Elements.Bsslabel bsslabel3;
        private BssBase.cmbBase cmbObjekt;
    }
}
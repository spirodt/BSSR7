namespace BSSR.Forms {
	partial class frmFirmiEdit {
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
            System.Windows.Forms.Label imeNaFirmaLabel;
            System.Windows.Forms.Label danocenBrojLabel;
            System.Windows.Forms.Label bankaDeponentLabel;
            System.Windows.Forms.Label gradLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label postenskiBrojLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label faksLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label maticenBrojLabel;
            System.Windows.Forms.Label ziroSmetkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmiEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblFirmaTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblFirmaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblFirmaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imeNaFirmatxtBase = new BssBase.txtBase();
            this.danocenBrojtxtBase = new BssBase.txtBase();
            this.bankaDeponenttxtBase = new BssBase.txtBase();
            this.gradtxtBase = new BssBase.txtBase();
            this.adresatxtBase = new BssBase.txtBase();
            this.postenskiBrojtxtBase = new BssBase.txtBase();
            this.telefontxtBase = new BssBase.txtBase();
            this.fakstxtBase = new BssBase.txtBase();
            this.eMailtxtBase = new BssBase.txtBase();
            this.maticenBrojtxtBase = new BssBase.txtBase();
            this.ziroSmetkatxtBase = new BssBase.txtBase();
            this.btnPrikaci1 = new BssBase.Elements.btnPrikaci();
            imeNaFirmaLabel = new System.Windows.Forms.Label();
            danocenBrojLabel = new System.Windows.Forms.Label();
            bankaDeponentLabel = new System.Windows.Forms.Label();
            gradLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            postenskiBrojLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            faksLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            maticenBrojLabel = new System.Windows.Forms.Label();
            ziroSmetkaLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingNavigator)).BeginInit();
            this.tblFirmaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(816, 515);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(808, 489);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(ziroSmetkaLabel);
            this.groupVnes.Controls.Add(this.ziroSmetkatxtBase);
            this.groupVnes.Controls.Add(imeNaFirmaLabel);
            this.groupVnes.Controls.Add(this.imeNaFirmatxtBase);
            this.groupVnes.Controls.Add(danocenBrojLabel);
            this.groupVnes.Controls.Add(this.danocenBrojtxtBase);
            this.groupVnes.Controls.Add(bankaDeponentLabel);
            this.groupVnes.Controls.Add(this.bankaDeponenttxtBase);
            this.groupVnes.Controls.Add(gradLabel);
            this.groupVnes.Controls.Add(this.gradtxtBase);
            this.groupVnes.Controls.Add(adresaLabel);
            this.groupVnes.Controls.Add(this.adresatxtBase);
            this.groupVnes.Controls.Add(postenskiBrojLabel);
            this.groupVnes.Controls.Add(this.postenskiBrojtxtBase);
            this.groupVnes.Controls.Add(telefonLabel);
            this.groupVnes.Controls.Add(this.telefontxtBase);
            this.groupVnes.Controls.Add(faksLabel);
            this.groupVnes.Controls.Add(this.fakstxtBase);
            this.groupVnes.Controls.Add(eMailLabel);
            this.groupVnes.Controls.Add(this.eMailtxtBase);
            this.groupVnes.Controls.Add(maticenBrojLabel);
            this.groupVnes.Controls.Add(this.maticenBrojtxtBase);
            this.groupVnes.Size = new System.Drawing.Size(805, 486);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.btnPrikaci1);
            this.PanelFooter.Location = new System.Drawing.Point(0, 514);
            this.PanelFooter.Size = new System.Drawing.Size(820, 69);
            this.PanelFooter.Controls.SetChildIndex(this.btnZatvori, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnOk, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnPrikaci1, 0);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 5);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(629, 5);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // imeNaFirmaLabel
            // 
            imeNaFirmaLabel.AutoSize = true;
            imeNaFirmaLabel.Location = new System.Drawing.Point(26, 31);
            imeNaFirmaLabel.Name = "imeNaFirmaLabel";
            imeNaFirmaLabel.Size = new System.Drawing.Size(187, 29);
            imeNaFirmaLabel.TabIndex = 0;
            imeNaFirmaLabel.Text = "Име на фирма:";
            // 
            // danocenBrojLabel
            // 
            danocenBrojLabel.AutoSize = true;
            danocenBrojLabel.Location = new System.Drawing.Point(39, 72);
            danocenBrojLabel.Name = "danocenBrojLabel";
            danocenBrojLabel.Size = new System.Drawing.Size(174, 29);
            danocenBrojLabel.TabIndex = 2;
            danocenBrojLabel.Text = "Даночен број:";
            // 
            // bankaDeponentLabel
            // 
            bankaDeponentLabel.AutoSize = true;
            bankaDeponentLabel.Location = new System.Drawing.Point(7, 113);
            bankaDeponentLabel.Name = "bankaDeponentLabel";
            bankaDeponentLabel.Size = new System.Drawing.Size(206, 29);
            bankaDeponentLabel.TabIndex = 4;
            bankaDeponentLabel.Text = "Банка депонент:";
            // 
            // gradLabel
            // 
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(139, 154);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(74, 29);
            gradLabel.TabIndex = 6;
            gradLabel.Text = "Град:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(112, 195);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(101, 29);
            adresaLabel.TabIndex = 8;
            adresaLabel.Text = "Адреса:";
            // 
            // postenskiBrojLabel
            // 
            postenskiBrojLabel.AutoSize = true;
            postenskiBrojLabel.Location = new System.Drawing.Point(9, 236);
            postenskiBrojLabel.Name = "postenskiBrojLabel";
            postenskiBrojLabel.Size = new System.Drawing.Size(204, 29);
            postenskiBrojLabel.TabIndex = 10;
            postenskiBrojLabel.Text = "Поштенски број:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(88, 277);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(125, 29);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Телефон:";
            // 
            // faksLabel
            // 
            faksLabel.AutoSize = true;
            faksLabel.Location = new System.Drawing.Point(137, 318);
            faksLabel.Name = "faksLabel";
            faksLabel.Size = new System.Drawing.Size(76, 29);
            faksLabel.TabIndex = 14;
            faksLabel.Text = "Факс:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(107, 359);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(106, 29);
            eMailLabel.TabIndex = 16;
            eMailLabel.Text = "Е-Маил:";
            // 
            // maticenBrojLabel
            // 
            maticenBrojLabel.AutoSize = true;
            maticenBrojLabel.Location = new System.Drawing.Point(37, 400);
            maticenBrojLabel.Name = "maticenBrojLabel";
            maticenBrojLabel.Size = new System.Drawing.Size(176, 29);
            maticenBrojLabel.TabIndex = 18;
            maticenBrojLabel.Text = "Матичен број:";
            // 
            // ziroSmetkaLabel
            // 
            ziroSmetkaLabel.AutoSize = true;
            ziroSmetkaLabel.Location = new System.Drawing.Point(43, 441);
            ziroSmetkaLabel.Name = "ziroSmetkaLabel";
            ziroSmetkaLabel.Size = new System.Drawing.Size(170, 29);
            ziroSmetkaLabel.TabIndex = 20;
            ziroSmetkaLabel.Text = "Жиро сметка:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            this.tblFirmaBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblFirmaTableAdapter = this.tblFirmaTableAdapter;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
            this.tableAdapterManager.tblFormiTableAdapter = null;
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblFirmaBindingNavigator
            // 
            this.tblFirmaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblFirmaBindingNavigator.BindingSource = this.tblFirmaBindingSource;
            this.tblFirmaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFirmaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFirmaBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblFirmaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblFirmaBindingNavigatorSaveItem});
            this.tblFirmaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFirmaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFirmaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFirmaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFirmaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFirmaBindingNavigator.Name = "tblFirmaBindingNavigator";
            this.tblFirmaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFirmaBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblFirmaBindingNavigator.TabIndex = 6;
            this.tblFirmaBindingNavigator.Text = "bindingNavigator1";
            this.tblFirmaBindingNavigator.Visible = false;
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
            // tblFirmaBindingNavigatorSaveItem
            // 
            this.tblFirmaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFirmaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFirmaBindingNavigatorSaveItem.Image")));
            this.tblFirmaBindingNavigatorSaveItem.Name = "tblFirmaBindingNavigatorSaveItem";
            this.tblFirmaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblFirmaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // imeNaFirmatxtBase
            // 
            this.imeNaFirmatxtBase.AssemblyStr = null;
            this.imeNaFirmatxtBase.C_FillWithZeros = false;
            this.imeNaFirmatxtBase.C_OnlyNumbers = false;
            this.imeNaFirmatxtBase.C_RegEx = false;
            this.imeNaFirmatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.imeNaFirmatxtBase.ColumnName1 = null;
            this.imeNaFirmatxtBase.ColumnName2 = null;
            this.imeNaFirmatxtBase.ColumnName3 = null;
            this.imeNaFirmatxtBase.ColumnName4 = null;
            this.imeNaFirmatxtBase.ColumnName5 = null;
            this.imeNaFirmatxtBase.ColumnName6 = null;
            this.imeNaFirmatxtBase.ColumnName7 = null;
            this.imeNaFirmatxtBase.daliCetiri = false;
            this.imeNaFirmatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "ImeNaFirma", true));
            this.imeNaFirmatxtBase.Format = null;
            this.imeNaFirmatxtBase.formToOpen = null;
            this.imeNaFirmatxtBase.KoristiFilterNaDatasource = false;
            this.imeNaFirmatxtBase.Location = new System.Drawing.Point(219, 28);
            this.imeNaFirmatxtBase.MakedonskiJazik = false;
            this.imeNaFirmatxtBase.MinLength = 0;
            this.imeNaFirmatxtBase.Name = "imeNaFirmatxtBase";
            this.imeNaFirmatxtBase.PopulateOtherFields = false;
            this.imeNaFirmatxtBase.prikaziKeyBoard = false;
            this.imeNaFirmatxtBase.regularExpression = null;
            this.imeNaFirmatxtBase.SelektrijaNaFokus = false;
            this.imeNaFirmatxtBase.Size = new System.Drawing.Size(568, 35);
            this.imeNaFirmatxtBase.TabIndex = 1;
            // 
            // danocenBrojtxtBase
            // 
            this.danocenBrojtxtBase.AssemblyStr = null;
            this.danocenBrojtxtBase.C_FillWithZeros = false;
            this.danocenBrojtxtBase.C_OnlyNumbers = false;
            this.danocenBrojtxtBase.C_RegEx = false;
            this.danocenBrojtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.danocenBrojtxtBase.ColumnName1 = null;
            this.danocenBrojtxtBase.ColumnName2 = null;
            this.danocenBrojtxtBase.ColumnName3 = null;
            this.danocenBrojtxtBase.ColumnName4 = null;
            this.danocenBrojtxtBase.ColumnName5 = null;
            this.danocenBrojtxtBase.ColumnName6 = null;
            this.danocenBrojtxtBase.ColumnName7 = null;
            this.danocenBrojtxtBase.daliCetiri = false;
            this.danocenBrojtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "DanocenBroj", true));
            this.danocenBrojtxtBase.Format = null;
            this.danocenBrojtxtBase.formToOpen = null;
            this.danocenBrojtxtBase.KoristiFilterNaDatasource = false;
            this.danocenBrojtxtBase.Location = new System.Drawing.Point(219, 69);
            this.danocenBrojtxtBase.MakedonskiJazik = false;
            this.danocenBrojtxtBase.MinLength = 0;
            this.danocenBrojtxtBase.Name = "danocenBrojtxtBase";
            this.danocenBrojtxtBase.PopulateOtherFields = false;
            this.danocenBrojtxtBase.prikaziKeyBoard = false;
            this.danocenBrojtxtBase.regularExpression = null;
            this.danocenBrojtxtBase.SelektrijaNaFokus = false;
            this.danocenBrojtxtBase.Size = new System.Drawing.Size(568, 35);
            this.danocenBrojtxtBase.TabIndex = 3;
            // 
            // bankaDeponenttxtBase
            // 
            this.bankaDeponenttxtBase.AssemblyStr = null;
            this.bankaDeponenttxtBase.C_FillWithZeros = false;
            this.bankaDeponenttxtBase.C_OnlyNumbers = false;
            this.bankaDeponenttxtBase.C_RegEx = false;
            this.bankaDeponenttxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.bankaDeponenttxtBase.ColumnName1 = null;
            this.bankaDeponenttxtBase.ColumnName2 = null;
            this.bankaDeponenttxtBase.ColumnName3 = null;
            this.bankaDeponenttxtBase.ColumnName4 = null;
            this.bankaDeponenttxtBase.ColumnName5 = null;
            this.bankaDeponenttxtBase.ColumnName6 = null;
            this.bankaDeponenttxtBase.ColumnName7 = null;
            this.bankaDeponenttxtBase.daliCetiri = false;
            this.bankaDeponenttxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "BankaDeponent", true));
            this.bankaDeponenttxtBase.Format = null;
            this.bankaDeponenttxtBase.formToOpen = null;
            this.bankaDeponenttxtBase.KoristiFilterNaDatasource = false;
            this.bankaDeponenttxtBase.Location = new System.Drawing.Point(219, 110);
            this.bankaDeponenttxtBase.MakedonskiJazik = false;
            this.bankaDeponenttxtBase.MinLength = 0;
            this.bankaDeponenttxtBase.Name = "bankaDeponenttxtBase";
            this.bankaDeponenttxtBase.PopulateOtherFields = false;
            this.bankaDeponenttxtBase.prikaziKeyBoard = false;
            this.bankaDeponenttxtBase.regularExpression = null;
            this.bankaDeponenttxtBase.SelektrijaNaFokus = false;
            this.bankaDeponenttxtBase.Size = new System.Drawing.Size(568, 35);
            this.bankaDeponenttxtBase.TabIndex = 5;
            // 
            // gradtxtBase
            // 
            this.gradtxtBase.AssemblyStr = null;
            this.gradtxtBase.C_FillWithZeros = false;
            this.gradtxtBase.C_OnlyNumbers = false;
            this.gradtxtBase.C_RegEx = false;
            this.gradtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.gradtxtBase.ColumnName1 = null;
            this.gradtxtBase.ColumnName2 = null;
            this.gradtxtBase.ColumnName3 = null;
            this.gradtxtBase.ColumnName4 = null;
            this.gradtxtBase.ColumnName5 = null;
            this.gradtxtBase.ColumnName6 = null;
            this.gradtxtBase.ColumnName7 = null;
            this.gradtxtBase.daliCetiri = false;
            this.gradtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "Grad", true));
            this.gradtxtBase.Format = null;
            this.gradtxtBase.formToOpen = null;
            this.gradtxtBase.KoristiFilterNaDatasource = false;
            this.gradtxtBase.Location = new System.Drawing.Point(219, 151);
            this.gradtxtBase.MakedonskiJazik = false;
            this.gradtxtBase.MinLength = 0;
            this.gradtxtBase.Name = "gradtxtBase";
            this.gradtxtBase.PopulateOtherFields = false;
            this.gradtxtBase.prikaziKeyBoard = false;
            this.gradtxtBase.regularExpression = null;
            this.gradtxtBase.SelektrijaNaFokus = false;
            this.gradtxtBase.Size = new System.Drawing.Size(568, 35);
            this.gradtxtBase.TabIndex = 7;
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
            this.adresatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "Adresa", true));
            this.adresatxtBase.Format = null;
            this.adresatxtBase.formToOpen = null;
            this.adresatxtBase.KoristiFilterNaDatasource = false;
            this.adresatxtBase.Location = new System.Drawing.Point(219, 192);
            this.adresatxtBase.MakedonskiJazik = false;
            this.adresatxtBase.MinLength = 0;
            this.adresatxtBase.Name = "adresatxtBase";
            this.adresatxtBase.PopulateOtherFields = false;
            this.adresatxtBase.prikaziKeyBoard = false;
            this.adresatxtBase.regularExpression = null;
            this.adresatxtBase.SelektrijaNaFokus = false;
            this.adresatxtBase.Size = new System.Drawing.Size(568, 35);
            this.adresatxtBase.TabIndex = 9;
            // 
            // postenskiBrojtxtBase
            // 
            this.postenskiBrojtxtBase.AssemblyStr = null;
            this.postenskiBrojtxtBase.C_FillWithZeros = false;
            this.postenskiBrojtxtBase.C_OnlyNumbers = false;
            this.postenskiBrojtxtBase.C_RegEx = false;
            this.postenskiBrojtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.postenskiBrojtxtBase.ColumnName1 = null;
            this.postenskiBrojtxtBase.ColumnName2 = null;
            this.postenskiBrojtxtBase.ColumnName3 = null;
            this.postenskiBrojtxtBase.ColumnName4 = null;
            this.postenskiBrojtxtBase.ColumnName5 = null;
            this.postenskiBrojtxtBase.ColumnName6 = null;
            this.postenskiBrojtxtBase.ColumnName7 = null;
            this.postenskiBrojtxtBase.daliCetiri = false;
            this.postenskiBrojtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "PostenskiBroj", true));
            this.postenskiBrojtxtBase.Format = null;
            this.postenskiBrojtxtBase.formToOpen = null;
            this.postenskiBrojtxtBase.KoristiFilterNaDatasource = false;
            this.postenskiBrojtxtBase.Location = new System.Drawing.Point(219, 233);
            this.postenskiBrojtxtBase.MakedonskiJazik = false;
            this.postenskiBrojtxtBase.MinLength = 0;
            this.postenskiBrojtxtBase.Name = "postenskiBrojtxtBase";
            this.postenskiBrojtxtBase.PopulateOtherFields = false;
            this.postenskiBrojtxtBase.prikaziKeyBoard = false;
            this.postenskiBrojtxtBase.regularExpression = null;
            this.postenskiBrojtxtBase.SelektrijaNaFokus = false;
            this.postenskiBrojtxtBase.Size = new System.Drawing.Size(568, 35);
            this.postenskiBrojtxtBase.TabIndex = 11;
            // 
            // telefontxtBase
            // 
            this.telefontxtBase.AssemblyStr = null;
            this.telefontxtBase.C_FillWithZeros = false;
            this.telefontxtBase.C_OnlyNumbers = false;
            this.telefontxtBase.C_RegEx = false;
            this.telefontxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.telefontxtBase.ColumnName1 = null;
            this.telefontxtBase.ColumnName2 = null;
            this.telefontxtBase.ColumnName3 = null;
            this.telefontxtBase.ColumnName4 = null;
            this.telefontxtBase.ColumnName5 = null;
            this.telefontxtBase.ColumnName6 = null;
            this.telefontxtBase.ColumnName7 = null;
            this.telefontxtBase.daliCetiri = false;
            this.telefontxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "Telefon", true));
            this.telefontxtBase.Format = null;
            this.telefontxtBase.formToOpen = null;
            this.telefontxtBase.KoristiFilterNaDatasource = false;
            this.telefontxtBase.Location = new System.Drawing.Point(219, 274);
            this.telefontxtBase.MakedonskiJazik = false;
            this.telefontxtBase.MinLength = 0;
            this.telefontxtBase.Name = "telefontxtBase";
            this.telefontxtBase.PopulateOtherFields = false;
            this.telefontxtBase.prikaziKeyBoard = false;
            this.telefontxtBase.regularExpression = null;
            this.telefontxtBase.SelektrijaNaFokus = false;
            this.telefontxtBase.Size = new System.Drawing.Size(568, 35);
            this.telefontxtBase.TabIndex = 13;
            // 
            // fakstxtBase
            // 
            this.fakstxtBase.AssemblyStr = null;
            this.fakstxtBase.C_FillWithZeros = false;
            this.fakstxtBase.C_OnlyNumbers = false;
            this.fakstxtBase.C_RegEx = false;
            this.fakstxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.fakstxtBase.ColumnName1 = null;
            this.fakstxtBase.ColumnName2 = null;
            this.fakstxtBase.ColumnName3 = null;
            this.fakstxtBase.ColumnName4 = null;
            this.fakstxtBase.ColumnName5 = null;
            this.fakstxtBase.ColumnName6 = null;
            this.fakstxtBase.ColumnName7 = null;
            this.fakstxtBase.daliCetiri = false;
            this.fakstxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "Faks", true));
            this.fakstxtBase.Format = null;
            this.fakstxtBase.formToOpen = null;
            this.fakstxtBase.KoristiFilterNaDatasource = false;
            this.fakstxtBase.Location = new System.Drawing.Point(219, 315);
            this.fakstxtBase.MakedonskiJazik = false;
            this.fakstxtBase.MinLength = 0;
            this.fakstxtBase.Name = "fakstxtBase";
            this.fakstxtBase.PopulateOtherFields = false;
            this.fakstxtBase.prikaziKeyBoard = false;
            this.fakstxtBase.regularExpression = null;
            this.fakstxtBase.SelektrijaNaFokus = false;
            this.fakstxtBase.Size = new System.Drawing.Size(568, 35);
            this.fakstxtBase.TabIndex = 15;
            // 
            // eMailtxtBase
            // 
            this.eMailtxtBase.AssemblyStr = null;
            this.eMailtxtBase.C_FillWithZeros = false;
            this.eMailtxtBase.C_OnlyNumbers = false;
            this.eMailtxtBase.C_RegEx = false;
            this.eMailtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.eMailtxtBase.ColumnName1 = null;
            this.eMailtxtBase.ColumnName2 = null;
            this.eMailtxtBase.ColumnName3 = null;
            this.eMailtxtBase.ColumnName4 = null;
            this.eMailtxtBase.ColumnName5 = null;
            this.eMailtxtBase.ColumnName6 = null;
            this.eMailtxtBase.ColumnName7 = null;
            this.eMailtxtBase.daliCetiri = false;
            this.eMailtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "EMail", true));
            this.eMailtxtBase.Format = null;
            this.eMailtxtBase.formToOpen = null;
            this.eMailtxtBase.KoristiFilterNaDatasource = false;
            this.eMailtxtBase.Location = new System.Drawing.Point(219, 356);
            this.eMailtxtBase.MakedonskiJazik = false;
            this.eMailtxtBase.MinLength = 0;
            this.eMailtxtBase.Name = "eMailtxtBase";
            this.eMailtxtBase.PopulateOtherFields = false;
            this.eMailtxtBase.prikaziKeyBoard = false;
            this.eMailtxtBase.regularExpression = null;
            this.eMailtxtBase.SelektrijaNaFokus = false;
            this.eMailtxtBase.Size = new System.Drawing.Size(568, 35);
            this.eMailtxtBase.TabIndex = 17;
            // 
            // maticenBrojtxtBase
            // 
            this.maticenBrojtxtBase.AssemblyStr = null;
            this.maticenBrojtxtBase.C_FillWithZeros = false;
            this.maticenBrojtxtBase.C_OnlyNumbers = false;
            this.maticenBrojtxtBase.C_RegEx = false;
            this.maticenBrojtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.maticenBrojtxtBase.ColumnName1 = null;
            this.maticenBrojtxtBase.ColumnName2 = null;
            this.maticenBrojtxtBase.ColumnName3 = null;
            this.maticenBrojtxtBase.ColumnName4 = null;
            this.maticenBrojtxtBase.ColumnName5 = null;
            this.maticenBrojtxtBase.ColumnName6 = null;
            this.maticenBrojtxtBase.ColumnName7 = null;
            this.maticenBrojtxtBase.daliCetiri = false;
            this.maticenBrojtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "MaticenBroj", true));
            this.maticenBrojtxtBase.Format = null;
            this.maticenBrojtxtBase.formToOpen = null;
            this.maticenBrojtxtBase.KoristiFilterNaDatasource = false;
            this.maticenBrojtxtBase.Location = new System.Drawing.Point(219, 397);
            this.maticenBrojtxtBase.MakedonskiJazik = false;
            this.maticenBrojtxtBase.MinLength = 0;
            this.maticenBrojtxtBase.Name = "maticenBrojtxtBase";
            this.maticenBrojtxtBase.PopulateOtherFields = false;
            this.maticenBrojtxtBase.prikaziKeyBoard = false;
            this.maticenBrojtxtBase.regularExpression = null;
            this.maticenBrojtxtBase.SelektrijaNaFokus = false;
            this.maticenBrojtxtBase.Size = new System.Drawing.Size(568, 35);
            this.maticenBrojtxtBase.TabIndex = 19;
            // 
            // ziroSmetkatxtBase
            // 
            this.ziroSmetkatxtBase.AssemblyStr = null;
            this.ziroSmetkatxtBase.C_FillWithZeros = false;
            this.ziroSmetkatxtBase.C_OnlyNumbers = false;
            this.ziroSmetkatxtBase.C_RegEx = false;
            this.ziroSmetkatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.ziroSmetkatxtBase.ColumnName1 = null;
            this.ziroSmetkatxtBase.ColumnName2 = null;
            this.ziroSmetkatxtBase.ColumnName3 = null;
            this.ziroSmetkatxtBase.ColumnName4 = null;
            this.ziroSmetkatxtBase.ColumnName5 = null;
            this.ziroSmetkatxtBase.ColumnName6 = null;
            this.ziroSmetkatxtBase.ColumnName7 = null;
            this.ziroSmetkatxtBase.daliCetiri = false;
            this.ziroSmetkatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFirmaBindingSource, "ZiroSmetka", true));
            this.ziroSmetkatxtBase.Format = null;
            this.ziroSmetkatxtBase.formToOpen = null;
            this.ziroSmetkatxtBase.KoristiFilterNaDatasource = false;
            this.ziroSmetkatxtBase.Location = new System.Drawing.Point(219, 438);
            this.ziroSmetkatxtBase.MakedonskiJazik = false;
            this.ziroSmetkatxtBase.MinLength = 0;
            this.ziroSmetkatxtBase.Name = "ziroSmetkatxtBase";
            this.ziroSmetkatxtBase.PopulateOtherFields = false;
            this.ziroSmetkatxtBase.prikaziKeyBoard = false;
            this.ziroSmetkatxtBase.regularExpression = null;
            this.ziroSmetkatxtBase.SelektrijaNaFokus = false;
            this.ziroSmetkatxtBase.Size = new System.Drawing.Size(571, 35);
            this.ziroSmetkatxtBase.TabIndex = 21;
            // 
            // btnPrikaci1
            // 
            this.btnPrikaci1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrikaci1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaci1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrikaci1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrikaci1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaci1.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikaci1.Image")));
            this.btnPrikaci1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaci1.Location = new System.Drawing.Point(430, 6);
            this.btnPrikaci1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPrikaci1.Name = "btnPrikaci1";
            this.btnPrikaci1.Size = new System.Drawing.Size(193, 58);
            this.btnPrikaci1.TabIndex = 8;
            this.btnPrikaci1.Text = "Прикачи слика";
            this.btnPrikaci1.UseVisualStyleBackColor = false;
            this.btnPrikaci1.Click += new System.EventHandler(this.btnPrikaci1_Click);
            // 
            // frmFirmiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.tblFirmaBindingNavigator);
            this.Name = "frmFirmiEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblFirmaEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblFirmaBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingNavigator)).EndInit();
            this.tblFirmaBindingNavigator.ResumeLayout(false);
            this.tblFirmaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblFirmaBindingSource;
		private BSSSDatasetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblFirmaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblFirmaBindingNavigatorSaveItem;
		private BssBase.txtBase imeNaFirmatxtBase;
		private BssBase.txtBase danocenBrojtxtBase;
		private BssBase.txtBase bankaDeponenttxtBase;
		private BssBase.txtBase gradtxtBase;
		private BssBase.txtBase adresatxtBase;
		private BssBase.txtBase postenskiBrojtxtBase;
		private BssBase.txtBase telefontxtBase;
		private BssBase.txtBase fakstxtBase;
		private BssBase.txtBase eMailtxtBase;
		private BssBase.txtBase maticenBrojtxtBase;
		private BssBase.txtBase ziroSmetkatxtBase;
		private BssBase.Elements.btnPrikaci btnPrikaci1;
	}
}
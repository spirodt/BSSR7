using System.Windows.Forms;

namespace BSSR.Forms {
	partial class frmNormativEdit {
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
            System.Windows.Forms.Label klucniZboroviLabel;
            System.Windows.Forms.Label podgrupaIDLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label redenBrojLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNormativEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblNormativBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNormativTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblNormativTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblNormativiSodriznaIznosTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblNormativiSodriznaIznosTableAdapter();
            this.tblNormativBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblNormativBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sifratxtBase = new BssBase.txtBase();
            this.nazivtxtBase = new BssBase.txtBase();
            this.klucniZborovitxtBase = new BssBase.txtBase();
            this.podgrupaIDcmbBase = new BssBase.cmbBase();
            this.tblPodgrupaIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPodgrupaIDTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter();
            this.tabNormativStavka = new System.Windows.Forms.TabPage();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.lblSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzbrisi = new BssBase.Elements.btnPonisti();
            this.btnVnesi1 = new BssBase.Elements.btnVnesi();
            this.grdBase1 = new BssBase.grdBase();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblArtikalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavnaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdaznaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNormativiSodriznaIznosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblArtikalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNormativStavkiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblNormativStavkiTableAdapter();
            this.tblArtikalTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblArtikalTableAdapter();
            this.cenatxtBase = new BssBase.txtBase();
            this.tblDDVStavkaIDcmbBase = new BssBase.cmbBase();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrupa = new BssBase.cmbBase();
            this.redenBrojTextBox = new System.Windows.Forms.TextBox();
            this.txtBase1 = new BssBase.txtBase();
            this.txtBase2 = new BssBase.txtBase();
            this.btnPrikaci1 = new BssBase.Elements.btnPrikaci();
            this.sePacatiNaSankCheckBox = new System.Windows.Forms.CheckBox();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            klucniZboroviLabel = new System.Windows.Forms.Label();
            podgrupaIDLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            redenBrojLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormativBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormativBindingNavigator)).BeginInit();
            this.tblNormativBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodgrupaIDBindingSource)).BeginInit();
            this.tabNormativStavka.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormativiSodriznaIznosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtikalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabNormativStavka);
            this.MainTab.Size = new System.Drawing.Size(835, 390);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            this.MainTab.Controls.SetChildIndex(this.tabNormativStavka, 0);
            this.MainTab.Controls.SetChildIndex(this.tabVnes, 0);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(827, 364);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.sePacatiNaSankCheckBox);
            this.groupVnes.Controls.Add(label4);
            this.groupVnes.Controls.Add(this.txtBase2);
            this.groupVnes.Controls.Add(label3);
            this.groupVnes.Controls.Add(this.txtBase1);
            this.groupVnes.Controls.Add(redenBrojLabel);
            this.groupVnes.Controls.Add(this.redenBrojTextBox);
            this.groupVnes.Controls.Add(label2);
            this.groupVnes.Controls.Add(this.cmbGrupa);
            this.groupVnes.Controls.Add(this.label1);
            this.groupVnes.Controls.Add(this.tblDDVStavkaIDcmbBase);
            this.groupVnes.Controls.Add(cenaLabel);
            this.groupVnes.Controls.Add(this.cenatxtBase);
            this.groupVnes.Controls.Add(podgrupaIDLabel);
            this.groupVnes.Controls.Add(this.podgrupaIDcmbBase);
            this.groupVnes.Controls.Add(klucniZboroviLabel);
            this.groupVnes.Controls.Add(this.klucniZborovitxtBase);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(sifraLabel);
            this.groupVnes.Controls.Add(this.sifratxtBase);
            this.groupVnes.Size = new System.Drawing.Size(824, 361);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.btnPrikaci1);
            this.PanelFooter.Location = new System.Drawing.Point(0, 389);
            this.PanelFooter.Size = new System.Drawing.Size(839, 69);
            this.PanelFooter.Controls.SetChildIndex(this.btnZatvori, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnOk, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnPrikaci1, 0);
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
            this.btnOk.Location = new System.Drawing.Point(648, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.Location = new System.Drawing.Point(57, 20);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(99, 29);
            sifraLabel.TabIndex = 0;
            sifraLabel.Text = "Шифра:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(66, 108);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 2;
            nazivLabel.Text = "Назив:";
            // 
            // klucniZboroviLabel
            // 
            klucniZboroviLabel.AutoSize = true;
            klucniZboroviLabel.Location = new System.Drawing.Point(289, 22);
            klucniZboroviLabel.Name = "klucniZboroviLabel";
            klucniZboroviLabel.Size = new System.Drawing.Size(208, 29);
            klucniZboroviLabel.TabIndex = 4;
            klucniZboroviLabel.Text = "Клучни зборови:";
            // 
            // podgrupaIDLabel
            // 
            podgrupaIDLabel.AutoSize = true;
            podgrupaIDLabel.Location = new System.Drawing.Point(26, 266);
            podgrupaIDLabel.Name = "podgrupaIDLabel";
            podgrupaIDLabel.Size = new System.Drawing.Size(128, 29);
            podgrupaIDLabel.TabIndex = 6;
            podgrupaIDLabel.Text = "Подгрупа:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(485, 309);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(78, 29);
            cenaLabel.TabIndex = 8;
            cenaLabel.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(68, 220);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 29);
            label2.TabIndex = 13;
            label2.Text = "Група:";
            // 
            // redenBrojLabel
            // 
            redenBrojLabel.AutoSize = true;
            redenBrojLabel.Location = new System.Drawing.Point(10, 64);
            redenBrojLabel.Name = "redenBrojLabel";
            redenBrojLabel.Size = new System.Drawing.Size(146, 29);
            redenBrojLabel.TabIndex = 14;
            redenBrojLabel.Text = "Реден број:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 29);
            label3.TabIndex = 16;
            label3.Text = "Алт назив2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 145);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(149, 29);
            label4.TabIndex = 18;
            label4.Text = "Алт назив1:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNormativBindingSource
            // 
            this.tblNormativBindingSource.DataMember = "tblNormativ";
            this.tblNormativBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblNormativTableAdapter
            // 
            this.tblNormativTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblNormativiSodriznaIznosTableAdapter = this.tblNormativiSodriznaIznosTableAdapter;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = this.tblNormativTableAdapter;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblTipNaDokumentTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.tblZabeleshkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblNormativiSodriznaIznosTableAdapter
            // 
            this.tblNormativiSodriznaIznosTableAdapter.ClearBeforeFill = true;
            // 
            // tblNormativBindingNavigator
            // 
            this.tblNormativBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblNormativBindingNavigator.BindingSource = this.tblNormativBindingSource;
            this.tblNormativBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblNormativBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblNormativBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblNormativBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblNormativBindingNavigatorSaveItem});
            this.tblNormativBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblNormativBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblNormativBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblNormativBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblNormativBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblNormativBindingNavigator.Name = "tblNormativBindingNavigator";
            this.tblNormativBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblNormativBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.tblNormativBindingNavigator.TabIndex = 6;
            this.tblNormativBindingNavigator.Text = "bindingNavigator1";
            this.tblNormativBindingNavigator.Visible = false;
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
            // tblNormativBindingNavigatorSaveItem
            // 
            this.tblNormativBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblNormativBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblNormativBindingNavigatorSaveItem.Image")));
            this.tblNormativBindingNavigatorSaveItem.Name = "tblNormativBindingNavigatorSaveItem";
            this.tblNormativBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblNormativBindingNavigatorSaveItem.Text = "Save Data";
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
            this.sifratxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "Sifra", true));
            this.sifratxtBase.Format = null;
            this.sifratxtBase.formToOpen = null;
            this.sifratxtBase.iscistiGreenNaLeave = false;
            this.sifratxtBase.KoristiFilterNaDatasource = false;
            this.sifratxtBase.Location = new System.Drawing.Point(160, 20);
            this.sifratxtBase.MakedonskiJazik = false;
            this.sifratxtBase.MinLength = 0;
            this.sifratxtBase.Name = "sifratxtBase";
            this.sifratxtBase.PopulateOtherFields = false;
            this.sifratxtBase.regularExpression = null;
            this.sifratxtBase.SelektrijaNaFokus = false;
            this.sifratxtBase.Size = new System.Drawing.Size(105, 35);
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "Naziv", true));
            this.nazivtxtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.iscistiGreenNaLeave = false;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(160, 106);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(658, 31);
            this.nazivtxtBase.TabIndex = 3;
            // 
            // klucniZborovitxtBase
            // 
            this.klucniZborovitxtBase.AssemblyStr = null;
            this.klucniZborovitxtBase.C_FillWithZeros = false;
            this.klucniZborovitxtBase.C_OnlyNumbers = false;
            this.klucniZborovitxtBase.C_RegEx = false;
            this.klucniZborovitxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.klucniZborovitxtBase.ColumnName1 = null;
            this.klucniZborovitxtBase.ColumnName2 = null;
            this.klucniZborovitxtBase.ColumnName3 = null;
            this.klucniZborovitxtBase.ColumnName4 = null;
            this.klucniZborovitxtBase.ColumnName5 = null;
            this.klucniZborovitxtBase.ColumnName6 = null;
            this.klucniZborovitxtBase.ColumnName7 = null;
            this.klucniZborovitxtBase.daliCetiri = false;
            this.klucniZborovitxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "KlucniZborovi", true));
            this.klucniZborovitxtBase.Format = null;
            this.klucniZborovitxtBase.formToOpen = null;
            this.klucniZborovitxtBase.iscistiGreenNaLeave = false;
            this.klucniZborovitxtBase.KoristiFilterNaDatasource = false;
            this.klucniZborovitxtBase.Location = new System.Drawing.Point(501, 22);
            this.klucniZborovitxtBase.MakedonskiJazik = false;
            this.klucniZborovitxtBase.MinLength = 0;
            this.klucniZborovitxtBase.Multiline = true;
            this.klucniZborovitxtBase.Name = "klucniZborovitxtBase";
            this.klucniZborovitxtBase.PopulateOtherFields = false;
            this.klucniZborovitxtBase.regularExpression = null;
            this.klucniZborovitxtBase.SelektrijaNaFokus = false;
            this.klucniZborovitxtBase.Size = new System.Drawing.Size(317, 76);
            this.klucniZborovitxtBase.TabIndex = 1;
            // 
            // podgrupaIDcmbBase
            // 
            this.podgrupaIDcmbBase.C_OnlyNumbers = false;
            this.podgrupaIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.podgrupaIDcmbBase.CurrentText = null;
            this.podgrupaIDcmbBase.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblNormativBindingSource, "PodgrupaID", true));
            this.podgrupaIDcmbBase.DataSource = this.tblPodgrupaIDBindingSource;
            this.podgrupaIDcmbBase.DisplayMember = "Naziv";
            this.podgrupaIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.podgrupaIDcmbBase.DtTableName = null;
            this.podgrupaIDcmbBase.FormattingEnabled = true;
            this.podgrupaIDcmbBase.Location = new System.Drawing.Point(160, 263);
            this.podgrupaIDcmbBase.Name = "podgrupaIDcmbBase";
            this.podgrupaIDcmbBase.Size = new System.Drawing.Size(658, 37);
            this.podgrupaIDcmbBase.TabIndex = 7;
            this.podgrupaIDcmbBase.value = null;
            this.podgrupaIDcmbBase.ValueMember = "ID";
            // 
            // tblPodgrupaIDBindingSource
            // 
            this.tblPodgrupaIDBindingSource.DataMember = "tblPodgrupaID";
            this.tblPodgrupaIDBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblPodgrupaIDTableAdapter
            // 
            this.tblPodgrupaIDTableAdapter.ClearBeforeFill = true;
            // 
            // tabNormativStavka
            // 
            this.tabNormativStavka.Controls.Add(this.groupBoxBase1);
            this.tabNormativStavka.Location = new System.Drawing.Point(4, 22);
            this.tabNormativStavka.Name = "tabNormativStavka";
            this.tabNormativStavka.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormativStavka.Size = new System.Drawing.Size(827, 364);
            this.tabNormativStavka.TabIndex = 1;
            this.tabNormativStavka.Text = "Ставки во нормативи";
            this.tabNormativStavka.UseVisualStyleBackColor = true;
            this.tabNormativStavka.Enter += new System.EventHandler(this.tabNormativStavka_Enter);
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBase1.Controls.Add(this.lblSum);
            this.groupBoxBase1.Controls.Add(this.label5);
            this.groupBoxBase1.Controls.Add(this.btnIzbrisi);
            this.groupBoxBase1.Controls.Add(this.btnVnesi1);
            this.groupBoxBase1.Controls.Add(this.grdBase1);
            this.groupBoxBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(821, 358);
            this.groupBoxBase1.TabIndex = 0;
            this.groupBoxBase1.TabStop = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(672, 27);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(143, 20);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Вкупна вредност:";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSum.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(522, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Вкупна вредност:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzbrisi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIzbrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIzbrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbrisi.Image")));
            this.btnIzbrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzbrisi.Location = new System.Drawing.Point(190, 19);
            this.btnIzbrisi.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(147, 38);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Избриши артикал";
            this.btnIzbrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnVnesi1
            // 
            this.btnVnesi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVnesi1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVnesi1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVnesi1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVnesi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVnesi1.Image = ((System.Drawing.Image)(resources.GetObject("btnVnesi1.Image")));
            this.btnVnesi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVnesi1.Location = new System.Drawing.Point(6, 19);
            this.btnVnesi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnVnesi1.Name = "btnVnesi1";
            this.btnVnesi1.Size = new System.Drawing.Size(175, 38);
            this.btnVnesi1.TabIndex = 1;
            this.btnVnesi1.Text = "Внеси нов артикал";
            this.btnVnesi1.UseVisualStyleBackColor = false;
            this.btnVnesi1.Click += new System.EventHandler(this.btnVnesi1_Click);
            // 
            // grdBase1
            // 
            this.grdBase1.AllowUserToAddRows = false;
            this.grdBase1.AllowUserToDeleteRows = false;
            this.grdBase1.AllowUserToOrderColumns = true;
            this.grdBase1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdBase1.AssemblyToLoad = null;
            this.grdBase1.AutoGenerateColumns = false;
            this.grdBase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBase1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.tblArtikalID,
            this.Naziv,
            this.kolicinaDataGridViewTextBoxColumn,
            this.AltNaziv,
            this.NabavnaCena,
            this.Iznos,
            this.ProdaznaCena});
            this.grdBase1.DataSource = this.tblNormativiSodriznaIznosBindingSource;
            this.grdBase1.EditForm = null;
            this.grdBase1.EditiranjeVoGrid = true;
            this.grdBase1.FilterForm = null;
            this.grdBase1.Location = new System.Drawing.Point(6, 63);
            this.grdBase1.Name = "grdBase1";
            this.grdBase1.PrimaryKey = null;
            this.grdBase1.reportCenter = false;
            this.grdBase1.ReportName = null;
            this.grdBase1.Size = new System.Drawing.Size(812, 289);
            this.grdBase1.SQLCommandQuery = null;
            this.grdBase1.TabIndex = 0;
            this.grdBase1.UpdateTable = null;
            // 
            // ID1
            // 
            this.ID1.DataPropertyName = "ID";
            this.ID1.HeaderText = "Реден број";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // tblArtikalID
            // 
            this.tblArtikalID.DataPropertyName = "tblArtikalID";
            this.tblArtikalID.HeaderText = "Реден број артикал";
            this.tblArtikalID.Name = "tblArtikalID";
            this.tblArtikalID.ReadOnly = true;
            this.tblArtikalID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Назив на Артикал";
            this.Naziv.MinimumWidth = 100;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.kolicinaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Количина";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AltNaziv
            // 
            this.AltNaziv.DataPropertyName = "AltNaziv";
            this.AltNaziv.HeaderText = "Алт. Назив";
            this.AltNaziv.Name = "AltNaziv";
            this.AltNaziv.ReadOnly = true;
            this.AltNaziv.Visible = false;
            // 
            // NabavnaCena
            // 
            this.NabavnaCena.DataPropertyName = "NabavnaCena";
            this.NabavnaCena.HeaderText = "Набавна цена";
            this.NabavnaCena.Name = "NabavnaCena";
            this.NabavnaCena.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Вредност на норматив";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // ProdaznaCena
            // 
            this.ProdaznaCena.DataPropertyName = "ProdaznaCena";
            this.ProdaznaCena.HeaderText = "Продажна цена";
            this.ProdaznaCena.Name = "ProdaznaCena";
            this.ProdaznaCena.ReadOnly = true;
            this.ProdaznaCena.Visible = false;
            // 
            // tblNormativiSodriznaIznosBindingSource
            // 
            this.tblNormativiSodriznaIznosBindingSource.DataMember = "tblNormativiSodriznaIznos";
            this.tblNormativiSodriznaIznosBindingSource.DataSource = this.bSSSDataset;
            this.tblNormativiSodriznaIznosBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.tblNormativiSodriznaIznosBindingSource_ListChanged);
            // 
            // tblArtikalBindingSource
            // 
            this.tblArtikalBindingSource.DataMember = "tblArtikal";
            this.tblArtikalBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblNormativStavkiTableAdapter
            // 
            this.tblNormativStavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tblArtikalTableAdapter
            // 
            this.tblArtikalTableAdapter.ClearBeforeFill = true;
            // 
            // cenatxtBase
            // 
            this.cenatxtBase.AssemblyStr = null;
            this.cenatxtBase.C_FillWithZeros = false;
            this.cenatxtBase.C_OnlyNumbers = false;
            this.cenatxtBase.C_RegEx = false;
            this.cenatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.cenatxtBase.ColumnName1 = null;
            this.cenatxtBase.ColumnName2 = null;
            this.cenatxtBase.ColumnName3 = null;
            this.cenatxtBase.ColumnName4 = null;
            this.cenatxtBase.ColumnName5 = null;
            this.cenatxtBase.ColumnName6 = null;
            this.cenatxtBase.ColumnName7 = null;
            this.cenatxtBase.daliCetiri = false;
            this.cenatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "Cena", true));
            this.cenatxtBase.Format = null;
            this.cenatxtBase.formToOpen = null;
            this.cenatxtBase.iscistiGreenNaLeave = false;
            this.cenatxtBase.KoristiFilterNaDatasource = false;
            this.cenatxtBase.Location = new System.Drawing.Point(567, 306);
            this.cenatxtBase.MakedonskiJazik = false;
            this.cenatxtBase.MinLength = 0;
            this.cenatxtBase.Name = "cenatxtBase";
            this.cenatxtBase.PopulateOtherFields = false;
            this.cenatxtBase.regularExpression = null;
            this.cenatxtBase.SelektrijaNaFokus = false;
            this.cenatxtBase.Size = new System.Drawing.Size(251, 35);
            this.cenatxtBase.TabIndex = 9;
            // 
            // tblDDVStavkaIDcmbBase
            // 
            this.tblDDVStavkaIDcmbBase.C_OnlyNumbers = false;
            this.tblDDVStavkaIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.tblDDVStavkaIDcmbBase.CurrentText = null;
            this.tblDDVStavkaIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tblDDVStavkaIDcmbBase.DtTableName = null;
            this.tblDDVStavkaIDcmbBase.FormattingEnabled = true;
            this.tblDDVStavkaIDcmbBase.Location = new System.Drawing.Point(160, 306);
            this.tblDDVStavkaIDcmbBase.Name = "tblDDVStavkaIDcmbBase";
            this.tblDDVStavkaIDcmbBase.Size = new System.Drawing.Size(232, 37);
            this.tblDDVStavkaIDcmbBase.TabIndex = 8;
            this.tblDDVStavkaIDcmbBase.value = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "ДДВ:";
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.C_OnlyNumbers = false;
            this.cmbGrupa.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbGrupa.CurrentText = null;
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.DtTableName = null;
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(160, 220);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(658, 37);
            this.cmbGrupa.TabIndex = 6;
            this.cmbGrupa.value = null;
            this.cmbGrupa.SelectedIndexChanged += new System.EventHandler(this.cmbGrupa_SelectedIndexChanged);
            // 
            // redenBrojTextBox
            // 
            this.redenBrojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "RedenBroj", true));
            this.redenBrojTextBox.Location = new System.Drawing.Point(160, 63);
            this.redenBrojTextBox.Name = "redenBrojTextBox";
            this.redenBrojTextBox.Size = new System.Drawing.Size(100, 35);
            this.redenBrojTextBox.TabIndex = 2;
            // 
            // txtBase1
            // 
            this.txtBase1.AssemblyStr = null;
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
            this.txtBase1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "AltNaziv2", true));
            this.txtBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBase1.Format = null;
            this.txtBase1.formToOpen = null;
            this.txtBase1.iscistiGreenNaLeave = false;
            this.txtBase1.KoristiFilterNaDatasource = false;
            this.txtBase1.Location = new System.Drawing.Point(160, 180);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(658, 31);
            this.txtBase1.TabIndex = 5;
            // 
            // txtBase2
            // 
            this.txtBase2.AssemblyStr = null;
            this.txtBase2.C_FillWithZeros = false;
            this.txtBase2.C_OnlyNumbers = false;
            this.txtBase2.C_RegEx = false;
            this.txtBase2.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBase2.ColumnName1 = null;
            this.txtBase2.ColumnName2 = null;
            this.txtBase2.ColumnName3 = null;
            this.txtBase2.ColumnName4 = null;
            this.txtBase2.ColumnName5 = null;
            this.txtBase2.ColumnName6 = null;
            this.txtBase2.ColumnName7 = null;
            this.txtBase2.daliCetiri = false;
            this.txtBase2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNormativBindingSource, "AltNaziv", true));
            this.txtBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBase2.Format = null;
            this.txtBase2.formToOpen = null;
            this.txtBase2.iscistiGreenNaLeave = false;
            this.txtBase2.KoristiFilterNaDatasource = false;
            this.txtBase2.Location = new System.Drawing.Point(160, 143);
            this.txtBase2.MakedonskiJazik = false;
            this.txtBase2.MinLength = 0;
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.PopulateOtherFields = false;
            this.txtBase2.regularExpression = null;
            this.txtBase2.SelektrijaNaFokus = false;
            this.txtBase2.Size = new System.Drawing.Size(658, 31);
            this.txtBase2.TabIndex = 4;
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
            this.btnPrikaci1.Location = new System.Drawing.Point(461, 6);
            this.btnPrikaci1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPrikaci1.Name = "btnPrikaci1";
            this.btnPrikaci1.Size = new System.Drawing.Size(181, 54);
            this.btnPrikaci1.TabIndex = 10;
            this.btnPrikaci1.Text = "Прикачи слика";
            this.btnPrikaci1.UseVisualStyleBackColor = false;
            this.btnPrikaci1.Click += new System.EventHandler(this.btnPrikaci1_Click);
            // 
            // sePacatiNaSankCheckBox
            // 
            this.sePacatiNaSankCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblNormativBindingSource, "SePacatiNaSank", true));
            this.sePacatiNaSankCheckBox.Location = new System.Drawing.Point(266, 64);
            this.sePacatiNaSankCheckBox.Name = "sePacatiNaSankCheckBox";
            this.sePacatiNaSankCheckBox.Size = new System.Drawing.Size(229, 34);
            this.sePacatiNaSankCheckBox.TabIndex = 21;
            this.sePacatiNaSankCheckBox.Text = "Печати на шанк";
            this.sePacatiNaSankCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmNormativEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 458);
            this.Controls.Add(this.tblNormativBindingNavigator);
            this.Name = "frmNormativEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblNormativEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNormativEdit_KeyDown);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblNormativBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormativBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormativBindingNavigator)).EndInit();
            this.tblNormativBindingNavigator.ResumeLayout(false);
            this.tblNormativBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodgrupaIDBindingSource)).EndInit();
            this.tabNormativStavka.ResumeLayout(false);
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormativiSodriznaIznosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtikalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblNormativBindingSource;
		private BSSSDatasetTableAdapters.tblNormativTableAdapter tblNormativTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblNormativBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblNormativBindingNavigatorSaveItem;
		private BssBase.txtBase sifratxtBase;
		private BssBase.txtBase klucniZborovitxtBase;
		private BssBase.txtBase nazivtxtBase;
		private BssBase.cmbBase podgrupaIDcmbBase;
		private System.Windows.Forms.BindingSource tblPodgrupaIDBindingSource;
		private BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter tblPodgrupaIDTableAdapter;
		private System.Windows.Forms.TabPage tabNormativStavka;
		private BssBase.groupBoxBase groupBoxBase1;
		private BssBase.grdBase grdBase1;
		private BssBase.Elements.btnPonisti btnIzbrisi;
        private BssBase.Elements.btnVnesi btnVnesi1;
		private BSSSDatasetTableAdapters.tblNormativStavkiTableAdapter tblNormativStavkiTableAdapter;
		private System.Windows.Forms.BindingSource tblArtikalBindingSource;
		private BSSSDatasetTableAdapters.tblArtikalTableAdapter tblArtikalTableAdapter;
		private BssBase.txtBase cenatxtBase;
		private System.Windows.Forms.Label label1;
        private BssBase.cmbBase tblDDVStavkaIDcmbBase;
        private BssBase.cmbBase cmbGrupa;
        private BssBase.txtBase txtBase2;
        private BssBase.txtBase txtBase1;
        private System.Windows.Forms.TextBox redenBrojTextBox;
        private BssBase.Elements.btnPrikaci btnPrikaci1;
        private System.Windows.Forms.BindingSource tblNormativiSodriznaIznosBindingSource;
        private BSSSDatasetTableAdapters.tblNormativiSodriznaIznosTableAdapter tblNormativiSodriznaIznosTableAdapter;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label5;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblArtikalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavnaCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdaznaCena;
        private CheckBox sePacatiNaSankCheckBox;

        public DataGridViewTextBoxColumn ID11
        {
            get
            {
                return ID1;
            }

            set
            {
                ID1 = value;
            }
        }
    }
}
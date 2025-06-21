using System.Windows.Forms;

namespace BSSR.Forms
{
	partial class frmArtikliEdit
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
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label tblDDVStavkaIDLabel;
            System.Windows.Forms.Label podgrupaIDLabel;
            System.Windows.Forms.Label tblEdinecniMerkiIDLabel;
            System.Windows.Forms.Label altNazivLabel;
            System.Windows.Forms.Label altSifraLabel;
            System.Windows.Forms.Label klucniZboroviLabel;
            System.Windows.Forms.Label nabavnaCenaLabel;
            System.Windows.Forms.Label prodaznaCenaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label LblNazivALT2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label denoviZaGarancijaLabel;
            System.Windows.Forms.Label domasenProizvodLabel;
            System.Windows.Forms.Label cenaNaGolemoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtikliEdit));
            this.tblArtikalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblArtikalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSSDataset = new BSSR.BSSSDataset();
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
            this.tblArtikalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sifratxtBase = new BssBase.txtBase();
            this.nazivtxtBase = new BssBase.txtBase();
            this.tblDDVStavkaIDcmbBase = new BssBase.cmbBase();
            this.podgrupaIDcmbBase = new BssBase.cmbBase();
            this.tblEdinecniMerkiIDcmbBase = new BssBase.cmbBase();
            this.altNazivtxtBase = new BssBase.txtBase();
            this.altSifratxtBase = new BssBase.txtBase();
            this.klucniZborovitxtBase = new BssBase.txtBase();
            this.nabavnaCenaTextBox = new BssBase.txtBase();
            this.prodaznaCenaTextBox = new BssBase.txtBase();
            this.cmbGrupa = new BssBase.cmbBase();
            this.chkNormativ = new System.Windows.Forms.CheckBox();
            this.Zafaktura = new System.Windows.Forms.CheckBox();
            this.cmbProdaznaMerka = new BssBase.cmbBase();
            this.txtKolicina = new BssBase.txtBase();
            this.tblArtikalTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblArtikalTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.txtMinKolicinaNaZaliha = new BssBase.txtBase();
            this.altNaziv2 = new BssBase.txtBase();
            this.barkod1 = new BssBase.txtBase();
            this.barkod2 = new BssBase.txtBase();
            this.redenBroj = new BssBase.txtBase();
            this.btnPrikaci1 = new BssBase.Elements.btnPrikaci();
            this.denoviZaGarancijaTextBox = new System.Windows.Forms.TextBox();
            this.domasenProizvodCheckBox = new System.Windows.Forms.CheckBox();
            this.tabAkcija = new System.Windows.Forms.TabPage();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.groupBoxBase2 = new BssBase.groupBoxBase();
            this.bsslabel5 = new BssBase.Elements.Bsslabel();
            this.bsslabel4 = new BssBase.Elements.Bsslabel();
            this.txtRabat = new BssBase.Elements.Bsslabel();
            this.txtAkciskaCena = new BssBase.txtBase();
            this.bsslabel2 = new BssBase.Elements.Bsslabel();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.dtPickerBase2 = new BssBase.Elements.dtPickerBase();
            this.dtPickerBase1 = new BssBase.Elements.dtPickerBase();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnPonisti1 = new BssBase.Elements.btnPonisti();
            this.btnVnesi1 = new BssBase.Elements.btnVnesi();
            this.tblAkcijaNaArtikalGridBig = new BssBase.GridBig();
            this.ID12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAkcijaNaArtikalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAkcijaNaArtikalTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblAkcijaNaArtikalTableAdapter();
            this.cenaNaGolemotxtBase = new BssBase.txtBase();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            tblDDVStavkaIDLabel = new System.Windows.Forms.Label();
            podgrupaIDLabel = new System.Windows.Forms.Label();
            tblEdinecniMerkiIDLabel = new System.Windows.Forms.Label();
            altNazivLabel = new System.Windows.Forms.Label();
            altSifraLabel = new System.Windows.Forms.Label();
            klucniZboroviLabel = new System.Windows.Forms.Label();
            nabavnaCenaLabel = new System.Windows.Forms.Label();
            prodaznaCenaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            LblNazivALT2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            denoviZaGarancijaLabel = new System.Windows.Forms.Label();
            domasenProizvodLabel = new System.Windows.Forms.Label();
            cenaNaGolemoLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtikalBindingNavigator)).BeginInit();
            this.tblArtikalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtikalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            this.tabAkcija.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            this.groupBoxBase2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAkcijaNaArtikalGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAkcijaNaArtikalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabAkcija);
            this.MainTab.Size = new System.Drawing.Size(1135, 656);
            this.MainTab.TabIndex = 0;
            this.MainTab.Controls.SetChildIndex(this.tabAkcija, 0);
            this.MainTab.Controls.SetChildIndex(this.tabVnes, 0);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(1127, 630);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.cenaNaGolemotxtBase);
            this.groupVnes.Controls.Add(domasenProizvodLabel);
            this.groupVnes.Controls.Add(this.domasenProizvodCheckBox);
            this.groupVnes.Controls.Add(denoviZaGarancijaLabel);
            this.groupVnes.Controls.Add(this.denoviZaGarancijaTextBox);
            this.groupVnes.Controls.Add(this.sifratxtBase);
            this.groupVnes.Controls.Add(this.altSifratxtBase);
            this.groupVnes.Controls.Add(label8);
            this.groupVnes.Controls.Add(this.redenBroj);
            this.groupVnes.Controls.Add(label7);
            this.groupVnes.Controls.Add(this.barkod2);
            this.groupVnes.Controls.Add(label6);
            this.groupVnes.Controls.Add(this.barkod1);
            this.groupVnes.Controls.Add(LblNazivALT2);
            this.groupVnes.Controls.Add(this.altNaziv2);
            this.groupVnes.Controls.Add(label4);
            this.groupVnes.Controls.Add(this.txtMinKolicinaNaZaliha);
            this.groupVnes.Controls.Add(label3);
            this.groupVnes.Controls.Add(this.txtKolicina);
            this.groupVnes.Controls.Add(label2);
            this.groupVnes.Controls.Add(this.cmbProdaznaMerka);
            this.groupVnes.Controls.Add(this.Zafaktura);
            this.groupVnes.Controls.Add(this.chkNormativ);
            this.groupVnes.Controls.Add(label1);
            this.groupVnes.Controls.Add(this.cmbGrupa);
            this.groupVnes.Controls.Add(sifraLabel);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(tblDDVStavkaIDLabel);
            this.groupVnes.Controls.Add(this.tblDDVStavkaIDcmbBase);
            this.groupVnes.Controls.Add(podgrupaIDLabel);
            this.groupVnes.Controls.Add(this.podgrupaIDcmbBase);
            this.groupVnes.Controls.Add(tblEdinecniMerkiIDLabel);
            this.groupVnes.Controls.Add(this.tblEdinecniMerkiIDcmbBase);
            this.groupVnes.Controls.Add(altNazivLabel);
            this.groupVnes.Controls.Add(this.altNazivtxtBase);
            this.groupVnes.Controls.Add(altSifraLabel);
            this.groupVnes.Controls.Add(klucniZboroviLabel);
            this.groupVnes.Controls.Add(this.klucniZborovitxtBase);
            this.groupVnes.Controls.Add(this.nabavnaCenaTextBox);
            this.groupVnes.Controls.Add(this.prodaznaCenaTextBox);
            this.groupVnes.Controls.Add(cenaNaGolemoLabel);
            this.groupVnes.Controls.Add(nabavnaCenaLabel);
            this.groupVnes.Controls.Add(prodaznaCenaLabel);
            this.groupVnes.Size = new System.Drawing.Size(1124, 627);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.btnPrikaci1);
            this.PanelFooter.Location = new System.Drawing.Point(0, 655);
            this.PanelFooter.Size = new System.Drawing.Size(1139, 69);
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
            this.btnOk.Location = new System.Drawing.Point(948, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // sifraLabel
            // 
            sifraLabel.Location = new System.Drawing.Point(3, 23);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(99, 29);
            sifraLabel.TabIndex = 0;
            sifraLabel.Text = "Шифра:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(67, 97);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 2;
            nazivLabel.Text = "Назив:";
            // 
            // tblDDVStavkaIDLabel
            // 
            tblDDVStavkaIDLabel.AutoSize = true;
            tblDDVStavkaIDLabel.Location = new System.Drawing.Point(57, 334);
            tblDDVStavkaIDLabel.Name = "tblDDVStavkaIDLabel";
            tblDDVStavkaIDLabel.Size = new System.Drawing.Size(155, 29);
            tblDDVStavkaIDLabel.TabIndex = 4;
            tblDDVStavkaIDLabel.Text = "ДДВ Стапка:";
            // 
            // podgrupaIDLabel
            // 
            podgrupaIDLabel.AutoSize = true;
            podgrupaIDLabel.Location = new System.Drawing.Point(84, 458);
            podgrupaIDLabel.Name = "podgrupaIDLabel";
            podgrupaIDLabel.Size = new System.Drawing.Size(128, 29);
            podgrupaIDLabel.TabIndex = 6;
            podgrupaIDLabel.Text = "Подгрупа:";
            // 
            // tblEdinecniMerkiIDLabel
            // 
            tblEdinecniMerkiIDLabel.AutoSize = true;
            tblEdinecniMerkiIDLabel.Location = new System.Drawing.Point(495, 329);
            tblEdinecniMerkiIDLabel.Name = "tblEdinecniMerkiIDLabel";
            tblEdinecniMerkiIDLabel.Size = new System.Drawing.Size(199, 29);
            tblEdinecniMerkiIDLabel.TabIndex = 8;
            tblEdinecniMerkiIDLabel.Text = "Единица мерка:";
            // 
            // altNazivLabel
            // 
            altNazivLabel.AutoSize = true;
            altNazivLabel.Location = new System.Drawing.Point(13, 159);
            altNazivLabel.Name = "altNazivLabel";
            altNazivLabel.Size = new System.Drawing.Size(144, 29);
            altNazivLabel.TabIndex = 10;
            altNazivLabel.Text = "Алт. Назив:";
            // 
            // altSifraLabel
            // 
            altSifraLabel.AutoSize = true;
            altSifraLabel.Location = new System.Drawing.Point(482, 23);
            altSifraLabel.Name = "altSifraLabel";
            altSifraLabel.Size = new System.Drawing.Size(153, 29);
            altSifraLabel.TabIndex = 12;
            altSifraLabel.Text = "Алт. Шифра:";
            // 
            // klucniZboroviLabel
            // 
            klucniZboroviLabel.AutoSize = true;
            klucniZboroviLabel.Location = new System.Drawing.Point(4, 280);
            klucniZboroviLabel.Name = "klucniZboroviLabel";
            klucniZboroviLabel.Size = new System.Drawing.Size(208, 29);
            klucniZboroviLabel.TabIndex = 14;
            klucniZboroviLabel.Text = "Клучни зборови:";
            // 
            // nabavnaCenaLabel
            // 
            nabavnaCenaLabel.AutoSize = true;
            nabavnaCenaLabel.Location = new System.Drawing.Point(4, 584);
            nabavnaCenaLabel.Name = "nabavnaCenaLabel";
            nabavnaCenaLabel.Size = new System.Drawing.Size(179, 29);
            nabavnaCenaLabel.TabIndex = 16;
            nabavnaCenaLabel.Text = "Планска цена:";
            // 
            // prodaznaCenaLabel
            // 
            prodaznaCenaLabel.AutoSize = true;
            prodaznaCenaLabel.Location = new System.Drawing.Point(725, 584);
            prodaznaCenaLabel.Name = "prodaznaCenaLabel";
            prodaznaCenaLabel.Size = new System.Drawing.Size(200, 29);
            prodaznaCenaLabel.TabIndex = 18;
            prodaznaCenaLabel.Text = "Продажна цена:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(126, 421);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 29);
            label1.TabIndex = 20;
            label1.Text = "Група:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(-2, 372);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(214, 29);
            label2.TabIndex = 24;
            label2.Text = "Продажна мерка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(552, 372);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(142, 29);
            label3.TabIndex = 26;
            label3.Text = "Количина :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(585, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(397, 29);
            label4.TabIndex = 28;
            label4.Text = "Минимална количина на залиха:";
            // 
            // LblNazivALT2
            // 
            LblNazivALT2.AutoSize = true;
            LblNazivALT2.Location = new System.Drawing.Point(0, 221);
            LblNazivALT2.Name = "LblNazivALT2";
            LblNazivALT2.Size = new System.Drawing.Size(157, 29);
            LblNazivALT2.TabIndex = 30;
            LblNazivALT2.Text = "Алт. Назив2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(481, 499);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 29);
            label6.TabIndex = 32;
            label6.Text = "Баркод1:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(481, 540);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(114, 29);
            label7.TabIndex = 34;
            label7.Text = "Баркод2:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(11, 60);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(146, 29);
            label8.TabIndex = 35;
            label8.Text = "Реден број:";
            // 
            // denoviZaGarancijaLabel
            // 
            denoviZaGarancijaLabel.AutoSize = true;
            denoviZaGarancijaLabel.Location = new System.Drawing.Point(1, 502);
            denoviZaGarancijaLabel.Name = "denoviZaGarancijaLabel";
            denoviZaGarancijaLabel.Size = new System.Drawing.Size(346, 29);
            denoviZaGarancijaLabel.TabIndex = 38;
            denoviZaGarancijaLabel.Text = "Број на денови за гаранција:";
            // 
            // domasenProizvodLabel
            // 
            domasenProizvodLabel.AutoSize = true;
            domasenProizvodLabel.Location = new System.Drawing.Point(1, 540);
            domasenProizvodLabel.Name = "domasenProizvodLabel";
            domasenProizvodLabel.Size = new System.Drawing.Size(278, 29);
            domasenProizvodLabel.TabIndex = 40;
            domasenProizvodLabel.Text = "Македонски производ:";
            // 
            // cenaNaGolemoLabel
            // 
            cenaNaGolemoLabel.AutoSize = true;
            cenaNaGolemoLabel.Location = new System.Drawing.Point(353, 584);
            cenaNaGolemoLabel.Name = "cenaNaGolemoLabel";
            cenaNaGolemoLabel.Size = new System.Drawing.Size(204, 29);
            cenaNaGolemoLabel.TabIndex = 42;
            cenaNaGolemoLabel.Text = "Цена на големо:";
            // 
            // tblArtikalBindingNavigator
            // 
            this.tblArtikalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblArtikalBindingNavigator.BindingSource = this.tblArtikalBindingSource;
            this.tblArtikalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblArtikalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblArtikalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblArtikalBindingNavigatorSaveItem});
            this.tblArtikalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblArtikalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblArtikalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblArtikalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblArtikalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblArtikalBindingNavigator.Name = "tblArtikalBindingNavigator";
            this.tblArtikalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblArtikalBindingNavigator.Size = new System.Drawing.Size(773, 25);
            this.tblArtikalBindingNavigator.TabIndex = 6;
            this.tblArtikalBindingNavigator.Text = "bindingNavigator1";
            this.tblArtikalBindingNavigator.Visible = false;
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
            // tblArtikalBindingSource
            // 
            this.tblArtikalBindingSource.DataMember = "tblArtikal";
            this.tblArtikalBindingSource.DataSource = this.bSSSDataset;
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblArtikalBindingNavigatorSaveItem
            // 
            this.tblArtikalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblArtikalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblArtikalBindingNavigatorSaveItem.Image")));
            this.tblArtikalBindingNavigatorSaveItem.Name = "tblArtikalBindingNavigatorSaveItem";
            this.tblArtikalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblArtikalBindingNavigatorSaveItem.Text = "Save Data";
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
            this.sifratxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "Sifra", true));
            this.sifratxtBase.Format = null;
            this.sifratxtBase.formToOpen = null;
            this.sifratxtBase.iscistiGreenNaLeave = false;
            this.sifratxtBase.KoristiFilterNaDatasource = false;
            this.sifratxtBase.Location = new System.Drawing.Point(99, 17);
            this.sifratxtBase.MakedonskiJazik = false;
            this.sifratxtBase.MinLength = 0;
            this.sifratxtBase.Name = "sifratxtBase";
            this.sifratxtBase.PopulateOtherFields = false;
            this.sifratxtBase.regularExpression = null;
            this.sifratxtBase.SelektrijaNaFokus = false;
            this.sifratxtBase.Size = new System.Drawing.Size(377, 35);
            this.sifratxtBase.TabIndex = 0;
            this.sifratxtBase.Leave += new System.EventHandler(this.sifratxtBase_Leave);
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "Naziv", true));
            this.nazivtxtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.iscistiGreenNaLeave = false;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(163, 97);
            this.nazivtxtBase.MakedonskiJazik = true;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Multiline = true;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(957, 56);
            this.nazivtxtBase.TabIndex = 3;
            this.nazivtxtBase.Leave += new System.EventHandler(this.nazivtxtBase_Leave);
            // 
            // tblDDVStavkaIDcmbBase
            // 
            this.tblDDVStavkaIDcmbBase.C_OnlyNumbers = false;
            this.tblDDVStavkaIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.tblDDVStavkaIDcmbBase.CurrentText = null;
            this.tblDDVStavkaIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tblDDVStavkaIDcmbBase.DtTableName = null;
            this.tblDDVStavkaIDcmbBase.FormattingEnabled = true;
            this.tblDDVStavkaIDcmbBase.Location = new System.Drawing.Point(220, 326);
            this.tblDDVStavkaIDcmbBase.Name = "tblDDVStavkaIDcmbBase";
            this.tblDDVStavkaIDcmbBase.Size = new System.Drawing.Size(256, 37);
            this.tblDDVStavkaIDcmbBase.TabIndex = 5;
            this.tblDDVStavkaIDcmbBase.value = null;
            this.tblDDVStavkaIDcmbBase.SelectedIndexChanged += new System.EventHandler(this.tblDDVStavkaIDcmbBase_SelectedIndexChanged);
            // 
            // podgrupaIDcmbBase
            // 
            this.podgrupaIDcmbBase.C_OnlyNumbers = false;
            this.podgrupaIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.podgrupaIDcmbBase.CurrentText = null;
            this.podgrupaIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.podgrupaIDcmbBase.DtTableName = null;
            this.podgrupaIDcmbBase.FormattingEnabled = true;
            this.podgrupaIDcmbBase.Location = new System.Drawing.Point(220, 455);
            this.podgrupaIDcmbBase.Name = "podgrupaIDcmbBase";
            this.podgrupaIDcmbBase.Size = new System.Drawing.Size(899, 37);
            this.podgrupaIDcmbBase.TabIndex = 10;
            this.podgrupaIDcmbBase.value = null;
            // 
            // tblEdinecniMerkiIDcmbBase
            // 
            this.tblEdinecniMerkiIDcmbBase.C_OnlyNumbers = false;
            this.tblEdinecniMerkiIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
            this.tblEdinecniMerkiIDcmbBase.CurrentText = null;
            this.tblEdinecniMerkiIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tblEdinecniMerkiIDcmbBase.DtTableName = null;
            this.tblEdinecniMerkiIDcmbBase.FormattingEnabled = true;
            this.tblEdinecniMerkiIDcmbBase.Location = new System.Drawing.Point(700, 326);
            this.tblEdinecniMerkiIDcmbBase.Name = "tblEdinecniMerkiIDcmbBase";
            this.tblEdinecniMerkiIDcmbBase.Size = new System.Drawing.Size(419, 37);
            this.tblEdinecniMerkiIDcmbBase.TabIndex = 6;
            this.tblEdinecniMerkiIDcmbBase.value = null;
            // 
            // altNazivtxtBase
            // 
            this.altNazivtxtBase.AssemblyStr = null;
            this.altNazivtxtBase.C_FillWithZeros = false;
            this.altNazivtxtBase.C_OnlyNumbers = false;
            this.altNazivtxtBase.C_RegEx = false;
            this.altNazivtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.altNazivtxtBase.ColumnName1 = null;
            this.altNazivtxtBase.ColumnName2 = null;
            this.altNazivtxtBase.ColumnName3 = null;
            this.altNazivtxtBase.ColumnName4 = null;
            this.altNazivtxtBase.ColumnName5 = null;
            this.altNazivtxtBase.ColumnName6 = null;
            this.altNazivtxtBase.ColumnName7 = null;
            this.altNazivtxtBase.daliCetiri = false;
            this.altNazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "AltNaziv", true));
            this.altNazivtxtBase.Format = null;
            this.altNazivtxtBase.formToOpen = null;
            this.altNazivtxtBase.iscistiGreenNaLeave = false;
            this.altNazivtxtBase.KoristiFilterNaDatasource = false;
            this.altNazivtxtBase.Location = new System.Drawing.Point(162, 159);
            this.altNazivtxtBase.MakedonskiJazik = false;
            this.altNazivtxtBase.MinLength = 0;
            this.altNazivtxtBase.Multiline = true;
            this.altNazivtxtBase.Name = "altNazivtxtBase";
            this.altNazivtxtBase.PopulateOtherFields = false;
            this.altNazivtxtBase.regularExpression = null;
            this.altNazivtxtBase.SelektrijaNaFokus = false;
            this.altNazivtxtBase.Size = new System.Drawing.Size(957, 56);
            this.altNazivtxtBase.TabIndex = 7;
            // 
            // altSifratxtBase
            // 
            this.altSifratxtBase.AssemblyStr = null;
            this.altSifratxtBase.C_FillWithZeros = false;
            this.altSifratxtBase.C_OnlyNumbers = false;
            this.altSifratxtBase.C_RegEx = false;
            this.altSifratxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.altSifratxtBase.ColumnName1 = null;
            this.altSifratxtBase.ColumnName2 = null;
            this.altSifratxtBase.ColumnName3 = null;
            this.altSifratxtBase.ColumnName4 = null;
            this.altSifratxtBase.ColumnName5 = null;
            this.altSifratxtBase.ColumnName6 = null;
            this.altSifratxtBase.ColumnName7 = null;
            this.altSifratxtBase.daliCetiri = false;
            this.altSifratxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "AltSifra", true));
            this.altSifratxtBase.Format = null;
            this.altSifratxtBase.formToOpen = null;
            this.altSifratxtBase.iscistiGreenNaLeave = false;
            this.altSifratxtBase.KoristiFilterNaDatasource = false;
            this.altSifratxtBase.Location = new System.Drawing.Point(629, 17);
            this.altSifratxtBase.MakedonskiJazik = false;
            this.altSifratxtBase.MinLength = 0;
            this.altSifratxtBase.Name = "altSifratxtBase";
            this.altSifratxtBase.PopulateOtherFields = false;
            this.altSifratxtBase.regularExpression = null;
            this.altSifratxtBase.SelektrijaNaFokus = false;
            this.altSifratxtBase.Size = new System.Drawing.Size(182, 35);
            this.altSifratxtBase.TabIndex = 1;
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
            this.klucniZborovitxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "KlucniZborovi", true));
            this.klucniZborovitxtBase.Format = null;
            this.klucniZborovitxtBase.formToOpen = null;
            this.klucniZborovitxtBase.iscistiGreenNaLeave = false;
            this.klucniZborovitxtBase.KoristiFilterNaDatasource = false;
            this.klucniZborovitxtBase.Location = new System.Drawing.Point(220, 280);
            this.klucniZborovitxtBase.MakedonskiJazik = false;
            this.klucniZborovitxtBase.MinLength = 0;
            this.klucniZborovitxtBase.Multiline = true;
            this.klucniZborovitxtBase.Name = "klucniZborovitxtBase";
            this.klucniZborovitxtBase.PopulateOtherFields = false;
            this.klucniZborovitxtBase.regularExpression = null;
            this.klucniZborovitxtBase.SelektrijaNaFokus = false;
            this.klucniZborovitxtBase.Size = new System.Drawing.Size(900, 36);
            this.klucniZborovitxtBase.TabIndex = 4;
            // 
            // nabavnaCenaTextBox
            // 
            this.nabavnaCenaTextBox.AssemblyStr = null;
            this.nabavnaCenaTextBox.C_FillWithZeros = false;
            this.nabavnaCenaTextBox.C_OnlyNumbers = false;
            this.nabavnaCenaTextBox.C_RegEx = false;
            this.nabavnaCenaTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.nabavnaCenaTextBox.ColumnName1 = null;
            this.nabavnaCenaTextBox.ColumnName2 = null;
            this.nabavnaCenaTextBox.ColumnName3 = null;
            this.nabavnaCenaTextBox.ColumnName4 = null;
            this.nabavnaCenaTextBox.ColumnName5 = null;
            this.nabavnaCenaTextBox.ColumnName6 = null;
            this.nabavnaCenaTextBox.ColumnName7 = null;
            this.nabavnaCenaTextBox.daliCetiri = false;
            this.nabavnaCenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "NabavnaCena", true));
            this.nabavnaCenaTextBox.Format = null;
            this.nabavnaCenaTextBox.formToOpen = null;
            this.nabavnaCenaTextBox.iscistiGreenNaLeave = false;
            this.nabavnaCenaTextBox.KoristiFilterNaDatasource = false;
            this.nabavnaCenaTextBox.Location = new System.Drawing.Point(184, 581);
            this.nabavnaCenaTextBox.MakedonskiJazik = false;
            this.nabavnaCenaTextBox.MinLength = 0;
            this.nabavnaCenaTextBox.Name = "nabavnaCenaTextBox";
            this.nabavnaCenaTextBox.PopulateOtherFields = false;
            this.nabavnaCenaTextBox.regularExpression = null;
            this.nabavnaCenaTextBox.SelektrijaNaFokus = false;
            this.nabavnaCenaTextBox.Size = new System.Drawing.Size(163, 35);
            this.nabavnaCenaTextBox.TabIndex = 15;
            // 
            // prodaznaCenaTextBox
            // 
            this.prodaznaCenaTextBox.AssemblyStr = null;
            this.prodaznaCenaTextBox.C_FillWithZeros = false;
            this.prodaznaCenaTextBox.C_OnlyNumbers = false;
            this.prodaznaCenaTextBox.C_RegEx = false;
            this.prodaznaCenaTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.prodaznaCenaTextBox.ColumnName1 = null;
            this.prodaznaCenaTextBox.ColumnName2 = null;
            this.prodaznaCenaTextBox.ColumnName3 = null;
            this.prodaznaCenaTextBox.ColumnName4 = null;
            this.prodaznaCenaTextBox.ColumnName5 = null;
            this.prodaznaCenaTextBox.ColumnName6 = null;
            this.prodaznaCenaTextBox.ColumnName7 = null;
            this.prodaznaCenaTextBox.daliCetiri = false;
            this.prodaznaCenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "ProdaznaCena", true));
            this.prodaznaCenaTextBox.Format = null;
            this.prodaznaCenaTextBox.formToOpen = null;
            this.prodaznaCenaTextBox.iscistiGreenNaLeave = false;
            this.prodaznaCenaTextBox.KoristiFilterNaDatasource = false;
            this.prodaznaCenaTextBox.Location = new System.Drawing.Point(931, 581);
            this.prodaznaCenaTextBox.MakedonskiJazik = false;
            this.prodaznaCenaTextBox.MinLength = 0;
            this.prodaznaCenaTextBox.Name = "prodaznaCenaTextBox";
            this.prodaznaCenaTextBox.PopulateOtherFields = false;
            this.prodaznaCenaTextBox.regularExpression = null;
            this.prodaznaCenaTextBox.SelektrijaNaFokus = false;
            this.prodaznaCenaTextBox.Size = new System.Drawing.Size(187, 35);
            this.prodaznaCenaTextBox.TabIndex = 17;
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.C_OnlyNumbers = false;
            this.cmbGrupa.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbGrupa.CurrentText = null;
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.DtTableName = null;
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(220, 413);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(899, 37);
            this.cmbGrupa.TabIndex = 9;
            this.cmbGrupa.value = null;
            this.cmbGrupa.SelectedIndexChanged += new System.EventHandler(this.cmbGrupa_SelectedIndexChanged);
            // 
            // chkNormativ
            // 
            this.chkNormativ.AutoSize = true;
            this.chkNormativ.Location = new System.Drawing.Point(818, 20);
            this.chkNormativ.Name = "chkNormativ";
            this.chkNormativ.Size = new System.Drawing.Size(148, 33);
            this.chkNormativ.TabIndex = 2;
            this.chkNormativ.Text = "Норматив";
            this.chkNormativ.UseVisualStyleBackColor = true;
            // 
            // Zafaktura
            // 
            this.Zafaktura.AutoSize = true;
            this.Zafaktura.Location = new System.Drawing.Point(961, 20);
            this.Zafaktura.Name = "Zafaktura";
            this.Zafaktura.Size = new System.Drawing.Size(159, 33);
            this.Zafaktura.TabIndex = 3;
            this.Zafaktura.Text = "За фактура";
            this.Zafaktura.UseVisualStyleBackColor = true;
            // 
            // cmbProdaznaMerka
            // 
            this.cmbProdaznaMerka.C_OnlyNumbers = false;
            this.cmbProdaznaMerka.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbProdaznaMerka.CurrentText = null;
            this.cmbProdaznaMerka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdaznaMerka.DtTableName = null;
            this.cmbProdaznaMerka.FormattingEnabled = true;
            this.cmbProdaznaMerka.Location = new System.Drawing.Point(220, 369);
            this.cmbProdaznaMerka.Name = "cmbProdaznaMerka";
            this.cmbProdaznaMerka.Size = new System.Drawing.Size(256, 37);
            this.cmbProdaznaMerka.TabIndex = 7;
            this.cmbProdaznaMerka.value = null;
            // 
            // txtKolicina
            // 
            this.txtKolicina.AssemblyStr = null;
            this.txtKolicina.C_FillWithZeros = false;
            this.txtKolicina.C_OnlyNumbers = false;
            this.txtKolicina.C_RegEx = false;
            this.txtKolicina.C_ShowRedOnLeaveIfEmpty = false;
            this.txtKolicina.ColumnName1 = null;
            this.txtKolicina.ColumnName2 = null;
            this.txtKolicina.ColumnName3 = null;
            this.txtKolicina.ColumnName4 = null;
            this.txtKolicina.ColumnName5 = null;
            this.txtKolicina.ColumnName6 = null;
            this.txtKolicina.ColumnName7 = null;
            this.txtKolicina.daliCetiri = false;
            this.txtKolicina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "KolicinaT", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N4"));
            this.txtKolicina.Format = null;
            this.txtKolicina.formToOpen = null;
            this.txtKolicina.iscistiGreenNaLeave = false;
            this.txtKolicina.KoristiFilterNaDatasource = false;
            this.txtKolicina.Location = new System.Drawing.Point(700, 369);
            this.txtKolicina.MakedonskiJazik = false;
            this.txtKolicina.MinLength = 0;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.PopulateOtherFields = false;
            this.txtKolicina.regularExpression = null;
            this.txtKolicina.SelektrijaNaFokus = false;
            this.txtKolicina.Size = new System.Drawing.Size(419, 35);
            this.txtKolicina.TabIndex = 8;
            // 
            // tblArtikalTableAdapter
            // 
            this.tblArtikalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAkcijaNaArtikalTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = this.tblArtikalTableAdapter;
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
            // txtMinKolicinaNaZaliha
            // 
            this.txtMinKolicinaNaZaliha.AssemblyStr = null;
            this.txtMinKolicinaNaZaliha.C_Decimal = true;
            this.txtMinKolicinaNaZaliha.C_FillWithZeros = false;
            this.txtMinKolicinaNaZaliha.C_OnlyNumbers = true;
            this.txtMinKolicinaNaZaliha.C_RegEx = false;
            this.txtMinKolicinaNaZaliha.C_ShowRedOnLeaveIfEmpty = false;
            this.txtMinKolicinaNaZaliha.ColumnName1 = null;
            this.txtMinKolicinaNaZaliha.ColumnName2 = null;
            this.txtMinKolicinaNaZaliha.ColumnName3 = null;
            this.txtMinKolicinaNaZaliha.ColumnName4 = null;
            this.txtMinKolicinaNaZaliha.ColumnName5 = null;
            this.txtMinKolicinaNaZaliha.ColumnName6 = null;
            this.txtMinKolicinaNaZaliha.ColumnName7 = null;
            this.txtMinKolicinaNaZaliha.daliCetiri = false;
            this.txtMinKolicinaNaZaliha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "MinimalnaKolicinaNaZaliha", true));
            this.txtMinKolicinaNaZaliha.Format = null;
            this.txtMinKolicinaNaZaliha.formToOpen = null;
            this.txtMinKolicinaNaZaliha.iscistiGreenNaLeave = false;
            this.txtMinKolicinaNaZaliha.KoristiFilterNaDatasource = false;
            this.txtMinKolicinaNaZaliha.Location = new System.Drawing.Point(988, 57);
            this.txtMinKolicinaNaZaliha.MakedonskiJazik = false;
            this.txtMinKolicinaNaZaliha.MinLength = 0;
            this.txtMinKolicinaNaZaliha.Name = "txtMinKolicinaNaZaliha";
            this.txtMinKolicinaNaZaliha.PopulateOtherFields = false;
            this.txtMinKolicinaNaZaliha.regularExpression = null;
            this.txtMinKolicinaNaZaliha.SelektrijaNaFokus = false;
            this.txtMinKolicinaNaZaliha.Size = new System.Drawing.Size(131, 35);
            this.txtMinKolicinaNaZaliha.TabIndex = 5;
            this.txtMinKolicinaNaZaliha.Text = "0.00";
            // 
            // altNaziv2
            // 
            this.altNaziv2.AssemblyStr = null;
            this.altNaziv2.C_FillWithZeros = false;
            this.altNaziv2.C_OnlyNumbers = false;
            this.altNaziv2.C_RegEx = false;
            this.altNaziv2.C_ShowRedOnLeaveIfEmpty = false;
            this.altNaziv2.ColumnName1 = null;
            this.altNaziv2.ColumnName2 = null;
            this.altNaziv2.ColumnName3 = null;
            this.altNaziv2.ColumnName4 = null;
            this.altNaziv2.ColumnName5 = null;
            this.altNaziv2.ColumnName6 = null;
            this.altNaziv2.ColumnName7 = null;
            this.altNaziv2.daliCetiri = false;
            this.altNaziv2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "AltNaziv2", true));
            this.altNaziv2.Format = null;
            this.altNaziv2.formToOpen = null;
            this.altNaziv2.iscistiGreenNaLeave = false;
            this.altNaziv2.KoristiFilterNaDatasource = false;
            this.altNaziv2.Location = new System.Drawing.Point(163, 221);
            this.altNaziv2.MakedonskiJazik = false;
            this.altNaziv2.MinLength = 0;
            this.altNaziv2.Multiline = true;
            this.altNaziv2.Name = "altNaziv2";
            this.altNaziv2.PopulateOtherFields = false;
            this.altNaziv2.regularExpression = null;
            this.altNaziv2.SelektrijaNaFokus = false;
            this.altNaziv2.Size = new System.Drawing.Size(957, 56);
            this.altNaziv2.TabIndex = 8;
            // 
            // barkod1
            // 
            this.barkod1.AssemblyStr = null;
            this.barkod1.C_FillWithZeros = false;
            this.barkod1.C_OnlyNumbers = false;
            this.barkod1.C_RegEx = false;
            this.barkod1.C_ShowRedOnLeaveIfEmpty = false;
            this.barkod1.ColumnName1 = null;
            this.barkod1.ColumnName2 = null;
            this.barkod1.ColumnName3 = null;
            this.barkod1.ColumnName4 = null;
            this.barkod1.ColumnName5 = null;
            this.barkod1.ColumnName6 = null;
            this.barkod1.ColumnName7 = null;
            this.barkod1.daliCetiri = false;
            this.barkod1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "Barkod1", true));
            this.barkod1.Format = null;
            this.barkod1.formToOpen = null;
            this.barkod1.iscistiGreenNaLeave = false;
            this.barkod1.KoristiFilterNaDatasource = false;
            this.barkod1.Location = new System.Drawing.Point(601, 499);
            this.barkod1.MakedonskiJazik = false;
            this.barkod1.MinLength = 0;
            this.barkod1.Name = "barkod1";
            this.barkod1.PopulateOtherFields = false;
            this.barkod1.regularExpression = null;
            this.barkod1.SelektrijaNaFokus = false;
            this.barkod1.Size = new System.Drawing.Size(517, 35);
            this.barkod1.TabIndex = 12;
            // 
            // barkod2
            // 
            this.barkod2.AssemblyStr = null;
            this.barkod2.C_FillWithZeros = false;
            this.barkod2.C_OnlyNumbers = false;
            this.barkod2.C_RegEx = false;
            this.barkod2.C_ShowRedOnLeaveIfEmpty = false;
            this.barkod2.ColumnName1 = null;
            this.barkod2.ColumnName2 = null;
            this.barkod2.ColumnName3 = null;
            this.barkod2.ColumnName4 = null;
            this.barkod2.ColumnName5 = null;
            this.barkod2.ColumnName6 = null;
            this.barkod2.ColumnName7 = null;
            this.barkod2.daliCetiri = false;
            this.barkod2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "Barkod2", true));
            this.barkod2.Format = null;
            this.barkod2.formToOpen = null;
            this.barkod2.iscistiGreenNaLeave = false;
            this.barkod2.KoristiFilterNaDatasource = false;
            this.barkod2.Location = new System.Drawing.Point(601, 540);
            this.barkod2.MakedonskiJazik = false;
            this.barkod2.MinLength = 0;
            this.barkod2.Name = "barkod2";
            this.barkod2.PopulateOtherFields = false;
            this.barkod2.regularExpression = null;
            this.barkod2.SelektrijaNaFokus = false;
            this.barkod2.Size = new System.Drawing.Size(517, 35);
            this.barkod2.TabIndex = 14;
            // 
            // redenBroj
            // 
            this.redenBroj.AssemblyStr = null;
            this.redenBroj.C_FillWithZeros = false;
            this.redenBroj.C_OnlyNumbers = false;
            this.redenBroj.C_RegEx = false;
            this.redenBroj.C_ShowRedOnLeaveIfEmpty = false;
            this.redenBroj.ColumnName1 = null;
            this.redenBroj.ColumnName2 = null;
            this.redenBroj.ColumnName3 = null;
            this.redenBroj.ColumnName4 = null;
            this.redenBroj.ColumnName5 = null;
            this.redenBroj.ColumnName6 = null;
            this.redenBroj.ColumnName7 = null;
            this.redenBroj.daliCetiri = false;
            this.redenBroj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "RedenBroj", true));
            this.redenBroj.Format = null;
            this.redenBroj.formToOpen = null;
            this.redenBroj.iscistiGreenNaLeave = false;
            this.redenBroj.KoristiFilterNaDatasource = false;
            this.redenBroj.Location = new System.Drawing.Point(162, 57);
            this.redenBroj.MakedonskiJazik = false;
            this.redenBroj.MinLength = 0;
            this.redenBroj.Name = "redenBroj";
            this.redenBroj.PopulateOtherFields = false;
            this.redenBroj.regularExpression = null;
            this.redenBroj.SelektrijaNaFokus = false;
            this.redenBroj.Size = new System.Drawing.Size(227, 35);
            this.redenBroj.TabIndex = 2;
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
            this.btnPrikaci1.Location = new System.Drawing.Point(761, 5);
            this.btnPrikaci1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPrikaci1.Name = "btnPrikaci1";
            this.btnPrikaci1.Size = new System.Drawing.Size(181, 54);
            this.btnPrikaci1.TabIndex = 9;
            this.btnPrikaci1.Text = "Прикачи слика";
            this.btnPrikaci1.UseVisualStyleBackColor = false;
            this.btnPrikaci1.Click += new System.EventHandler(this.btnPrikaci1_Click);
            // 
            // denoviZaGarancijaTextBox
            // 
            this.denoviZaGarancijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "DenoviZaGarancija", true));
            this.denoviZaGarancijaTextBox.Location = new System.Drawing.Point(351, 499);
            this.denoviZaGarancijaTextBox.Name = "denoviZaGarancijaTextBox";
            this.denoviZaGarancijaTextBox.Size = new System.Drawing.Size(125, 35);
            this.denoviZaGarancijaTextBox.TabIndex = 11;
            // 
            // domasenProizvodCheckBox
            // 
            this.domasenProizvodCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblArtikalBindingSource, "DomasenProizvod", true));
            this.domasenProizvodCheckBox.Location = new System.Drawing.Point(290, 546);
            this.domasenProizvodCheckBox.Name = "domasenProizvodCheckBox";
            this.domasenProizvodCheckBox.Size = new System.Drawing.Size(38, 24);
            this.domasenProizvodCheckBox.TabIndex = 13;
            this.domasenProizvodCheckBox.Text = " ";
            this.domasenProizvodCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabAkcija
            // 
            this.tabAkcija.Controls.Add(this.groupBoxBase1);
            this.tabAkcija.Location = new System.Drawing.Point(4, 22);
            this.tabAkcija.Name = "tabAkcija";
            this.tabAkcija.Padding = new System.Windows.Forms.Padding(3);
            this.tabAkcija.Size = new System.Drawing.Size(1127, 630);
            this.tabAkcija.TabIndex = 1;
            this.tabAkcija.Text = "Акција";
            this.tabAkcija.UseVisualStyleBackColor = true;
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBase1.Controls.Add(this.groupBoxBase2);
            this.groupBoxBase1.Controls.Add(this.btnPonisti1);
            this.groupBoxBase1.Controls.Add(this.btnVnesi1);
            this.groupBoxBase1.Controls.Add(this.tblAkcijaNaArtikalGridBig);
            this.groupBoxBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBase1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(1121, 624);
            this.groupBoxBase1.TabIndex = 0;
            this.groupBoxBase1.TabStop = false;
            // 
            // groupBoxBase2
            // 
            this.groupBoxBase2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase2.Controls.Add(this.bsslabel5);
            this.groupBoxBase2.Controls.Add(this.bsslabel4);
            this.groupBoxBase2.Controls.Add(this.txtRabat);
            this.groupBoxBase2.Controls.Add(this.txtAkciskaCena);
            this.groupBoxBase2.Controls.Add(this.bsslabel2);
            this.groupBoxBase2.Controls.Add(this.bsslabel1);
            this.groupBoxBase2.Controls.Add(this.dtPickerBase2);
            this.groupBoxBase2.Controls.Add(this.dtPickerBase1);
            this.groupBoxBase2.Controls.Add(this.btnPotvrdi1);
            this.groupBoxBase2.Location = new System.Drawing.Point(6, 63);
            this.groupBoxBase2.Name = "groupBoxBase2";
            this.groupBoxBase2.Size = new System.Drawing.Size(1109, 66);
            this.groupBoxBase2.TabIndex = 4;
            this.groupBoxBase2.TabStop = false;
            this.groupBoxBase2.Visible = false;
            // 
            // bsslabel5
            // 
            this.bsslabel5.AutoSize = true;
            this.bsslabel5.Location = new System.Drawing.Point(418, 26);
            this.bsslabel5.Name = "bsslabel5";
            this.bsslabel5.Size = new System.Drawing.Size(80, 13);
            this.bsslabel5.TabIndex = 11;
            this.bsslabel5.Text = "Акциска цена:";
            // 
            // bsslabel4
            // 
            this.bsslabel4.AutoSize = true;
            this.bsslabel4.Location = new System.Drawing.Point(649, 26);
            this.bsslabel4.Name = "bsslabel4";
            this.bsslabel4.Size = new System.Drawing.Size(13, 13);
            this.bsslabel4.TabIndex = 10;
            this.bsslabel4.Text = "0";
            // 
            // txtRabat
            // 
            this.txtRabat.AutoSize = true;
            this.txtRabat.Location = new System.Drawing.Point(603, 26);
            this.txtRabat.Name = "txtRabat";
            this.txtRabat.Size = new System.Drawing.Size(40, 13);
            this.txtRabat.TabIndex = 9;
            this.txtRabat.Text = "Рабат:";
            // 
            // txtAkciskaCena
            // 
            this.txtAkciskaCena.AssemblyStr = null;
            this.txtAkciskaCena.C_FillWithZeros = false;
            this.txtAkciskaCena.C_OnlyNumbers = false;
            this.txtAkciskaCena.C_RegEx = false;
            this.txtAkciskaCena.C_ShowRedOnLeaveIfEmpty = false;
            this.txtAkciskaCena.ColumnName1 = null;
            this.txtAkciskaCena.ColumnName2 = null;
            this.txtAkciskaCena.ColumnName3 = null;
            this.txtAkciskaCena.ColumnName4 = null;
            this.txtAkciskaCena.ColumnName5 = null;
            this.txtAkciskaCena.ColumnName6 = null;
            this.txtAkciskaCena.ColumnName7 = null;
            this.txtAkciskaCena.daliCetiri = false;
            this.txtAkciskaCena.Format = null;
            this.txtAkciskaCena.formToOpen = null;
            this.txtAkciskaCena.iscistiGreenNaLeave = false;
            this.txtAkciskaCena.KoristiFilterNaDatasource = false;
            this.txtAkciskaCena.Location = new System.Drawing.Point(504, 23);
            this.txtAkciskaCena.MakedonskiJazik = false;
            this.txtAkciskaCena.MinLength = 0;
            this.txtAkciskaCena.Name = "txtAkciskaCena";
            this.txtAkciskaCena.PopulateOtherFields = false;
            this.txtAkciskaCena.regularExpression = null;
            this.txtAkciskaCena.SelektrijaNaFokus = false;
            this.txtAkciskaCena.Size = new System.Drawing.Size(93, 20);
            this.txtAkciskaCena.TabIndex = 8;
            this.txtAkciskaCena.Leave += new System.EventHandler(this.txtBase1_Leave);
            // 
            // bsslabel2
            // 
            this.bsslabel2.AutoSize = true;
            this.bsslabel2.Location = new System.Drawing.Point(223, 26);
            this.bsslabel2.Name = "bsslabel2";
            this.bsslabel2.Size = new System.Drawing.Size(81, 13);
            this.bsslabel2.TabIndex = 7;
            this.bsslabel2.Text = "Датум на крај:";
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(6, 26);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(101, 13);
            this.bsslabel1.TabIndex = 6;
            this.bsslabel1.Text = "Датум на почеток:";
            // 
            // dtPickerBase2
            // 
            this.dtPickerBase2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerBase2.Location = new System.Drawing.Point(310, 23);
            this.dtPickerBase2.Name = "dtPickerBase2";
            this.dtPickerBase2.Size = new System.Drawing.Size(102, 20);
            this.dtPickerBase2.TabIndex = 5;
            // 
            // dtPickerBase1
            // 
            this.dtPickerBase1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerBase1.Location = new System.Drawing.Point(113, 23);
            this.dtPickerBase1.Name = "dtPickerBase1";
            this.dtPickerBase1.Size = new System.Drawing.Size(104, 20);
            this.dtPickerBase1.TabIndex = 4;
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
            this.btnPotvrdi1.Location = new System.Drawing.Point(762, 19);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.TabIndex = 3;
            this.btnPotvrdi1.Text = "Сочувај";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
            // 
            // btnPonisti1
            // 
            this.btnPonisti1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPonisti1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPonisti1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPonisti1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPonisti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonisti1.Image = ((System.Drawing.Image)(resources.GetObject("btnPonisti1.Image")));
            this.btnPonisti1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonisti1.Location = new System.Drawing.Point(768, 19);
            this.btnPonisti1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPonisti1.Name = "btnPonisti1";
            this.btnPonisti1.Size = new System.Drawing.Size(132, 38);
            this.btnPonisti1.TabIndex = 2;
            this.btnPonisti1.Text = "Бриши акција";
            this.btnPonisti1.UseVisualStyleBackColor = false;
            this.btnPonisti1.Click += new System.EventHandler(this.btnPonisti1_Click);
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
            this.btnVnesi1.Size = new System.Drawing.Size(132, 38);
            this.btnVnesi1.TabIndex = 1;
            this.btnVnesi1.Text = "Нова акција";
            this.btnVnesi1.UseVisualStyleBackColor = false;
            this.btnVnesi1.Click += new System.EventHandler(this.btnVnesi1_Click);
            // 
            // tblAkcijaNaArtikalGridBig
            // 
            this.tblAkcijaNaArtikalGridBig.AllowUserToAddRows = false;
            this.tblAkcijaNaArtikalGridBig.AllowUserToDeleteRows = false;
            this.tblAkcijaNaArtikalGridBig.AllowUserToOrderColumns = true;
            this.tblAkcijaNaArtikalGridBig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAkcijaNaArtikalGridBig.AssemblyToLoad = null;
            this.tblAkcijaNaArtikalGridBig.AutoGenerateColumns = false;
            this.tblAkcijaNaArtikalGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAkcijaNaArtikalGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID12,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tblAkcijaNaArtikalGridBig.DataSource = this.tblAkcijaNaArtikalBindingSource;
            this.tblAkcijaNaArtikalGridBig.EditForm = null;
            this.tblAkcijaNaArtikalGridBig.FilterForm = null;
            this.tblAkcijaNaArtikalGridBig.HidenColumns = null;
            this.tblAkcijaNaArtikalGridBig.KreirajPredefiniraniPolinja = false;
            this.tblAkcijaNaArtikalGridBig.Location = new System.Drawing.Point(3, 135);
            this.tblAkcijaNaArtikalGridBig.MultiSelect = false;
            this.tblAkcijaNaArtikalGridBig.Name = "tblAkcijaNaArtikalGridBig";
            
            this.tblAkcijaNaArtikalGridBig.PrimaryKey = "ID";
            this.tblAkcijaNaArtikalGridBig.ReadOnly = true;
            this.tblAkcijaNaArtikalGridBig.ReadOnlyColumns = null;
            this.tblAkcijaNaArtikalGridBig.reportCenter = false;
            this.tblAkcijaNaArtikalGridBig.ReportName = null;
            this.tblAkcijaNaArtikalGridBig.RowTemplate.Height = 36;
            this.tblAkcijaNaArtikalGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAkcijaNaArtikalGridBig.Size = new System.Drawing.Size(1115, 483);
            this.tblAkcijaNaArtikalGridBig.SQLCommandQuery = null;
            this.tblAkcijaNaArtikalGridBig.TabIndex = 0;
            this.tblAkcijaNaArtikalGridBig.UpdateTable = null;
            // 
            // ID1
            // 
            this.ID12.DataPropertyName = "ID";
            this.ID12.HeaderText = "Реден број";
            this.ID12.Name = "ID1";
            this.ID12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DatumPocetok";
            this.dataGridViewTextBoxColumn2.HeaderText = "Датум на почеток";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DatumKraj";
            this.dataGridViewTextBoxColumn3.HeaderText = "Датум на крај";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tblArtikalID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Реден број на артикал";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AkciskaCena";
            this.dataGridViewTextBoxColumn5.HeaderText = "Акциска цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rabat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Рабат";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tblAkcijaNaArtikalBindingSource
            // 
            this.tblAkcijaNaArtikalBindingSource.DataMember = "tblAkcijaNaArtikal";
            this.tblAkcijaNaArtikalBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblAkcijaNaArtikalTableAdapter
            // 
            this.tblAkcijaNaArtikalTableAdapter.ClearBeforeFill = true;
            // 
            // cenaNaGolemotxtBase
            // 
            this.cenaNaGolemotxtBase.AssemblyStr = null;
            this.cenaNaGolemotxtBase.C_FillWithZeros = false;
            this.cenaNaGolemotxtBase.C_OnlyNumbers = false;
            this.cenaNaGolemotxtBase.C_RegEx = false;
            this.cenaNaGolemotxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.cenaNaGolemotxtBase.ColumnName1 = null;
            this.cenaNaGolemotxtBase.ColumnName2 = null;
            this.cenaNaGolemotxtBase.ColumnName3 = null;
            this.cenaNaGolemotxtBase.ColumnName4 = null;
            this.cenaNaGolemotxtBase.ColumnName5 = null;
            this.cenaNaGolemotxtBase.ColumnName6 = null;
            this.cenaNaGolemotxtBase.ColumnName7 = null;
            this.cenaNaGolemotxtBase.daliCetiri = false;
            this.cenaNaGolemotxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblArtikalBindingSource, "CenaNaGolemo", true));
            this.cenaNaGolemotxtBase.Format = null;
            this.cenaNaGolemotxtBase.formToOpen = null;
            this.cenaNaGolemotxtBase.iscistiGreenNaLeave = false;
            this.cenaNaGolemotxtBase.KoristiFilterNaDatasource = false;
            this.cenaNaGolemotxtBase.Location = new System.Drawing.Point(550, 581);
            this.cenaNaGolemotxtBase.MakedonskiJazik = false;
            this.cenaNaGolemotxtBase.MinLength = 0;
            this.cenaNaGolemotxtBase.Name = "cenaNaGolemotxtBase";
            this.cenaNaGolemotxtBase.PopulateOtherFields = false;
            this.cenaNaGolemotxtBase.regularExpression = null;
            this.cenaNaGolemotxtBase.SelektrijaNaFokus = false;
            this.cenaNaGolemotxtBase.Size = new System.Drawing.Size(175, 35);
            this.cenaNaGolemotxtBase.TabIndex = 16;
            // 
            // frmArtikliEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 724);
            this.Controls.Add(this.tblArtikalBindingNavigator);
            this.Name = "frmArtikliEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblArtikalEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArtikliEdit_KeyDown);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblArtikalBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblArtikalBindingNavigator)).EndInit();
            this.tblArtikalBindingNavigator.ResumeLayout(false);
            this.tblArtikalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtikalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            this.tabAkcija.ResumeLayout(false);
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase2.ResumeLayout(false);
            this.groupBoxBase2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAkcijaNaArtikalGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAkcijaNaArtikalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblArtikalBindingSource;
		private BSSSDatasetTableAdapters.tblArtikalTableAdapter tblArtikalTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblArtikalBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblArtikalBindingNavigatorSaveItem;
		private BssBase.txtBase sifratxtBase;
		private BssBase.txtBase nazivtxtBase;
		private BssBase.cmbBase tblDDVStavkaIDcmbBase;
		private BssBase.cmbBase podgrupaIDcmbBase;
		private BssBase.cmbBase tblEdinecniMerkiIDcmbBase;
		private BssBase.txtBase altNazivtxtBase;
		private BssBase.txtBase altSifratxtBase;
		private BssBase.txtBase klucniZborovitxtBase;
		private BssBase.txtBase nabavnaCenaTextBox;
		private BssBase.txtBase prodaznaCenaTextBox;
		private BssBase.cmbBase cmbGrupa;
		private System.Windows.Forms.CheckBox chkNormativ;
        private System.Windows.Forms.CheckBox Zafaktura;
        private BssBase.txtBase txtKolicina;
        private BssBase.cmbBase cmbProdaznaMerka;
        private BssBase.txtBase txtMinKolicinaNaZaliha;
        private BssBase.txtBase barkod2;
        private BssBase.txtBase barkod1;
        private BssBase.txtBase altNaziv2;
        private BssBase.txtBase redenBroj;
        private BssBase.Elements.btnPrikaci btnPrikaci1;
        private System.Windows.Forms.TextBox denoviZaGarancijaTextBox;
        private System.Windows.Forms.CheckBox domasenProizvodCheckBox;
        private System.Windows.Forms.TabPage tabAkcija;
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.BindingSource tblAkcijaNaArtikalBindingSource;
        private BSSSDatasetTableAdapters.tblAkcijaNaArtikalTableAdapter tblAkcijaNaArtikalTableAdapter;
        private BssBase.GridBig tblAkcijaNaArtikalGridBig;
        private new DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BssBase.groupBoxBase groupBoxBase2;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPonisti btnPonisti1;
        private BssBase.Elements.btnVnesi btnVnesi1;
        private BssBase.Elements.Bsslabel bsslabel2;
        private BssBase.Elements.Bsslabel bsslabel1;
        private BssBase.Elements.dtPickerBase dtPickerBase2;
        private BssBase.Elements.dtPickerBase dtPickerBase1;
        private BssBase.Elements.Bsslabel bsslabel5;
        private BssBase.Elements.Bsslabel bsslabel4;
        private BssBase.Elements.Bsslabel txtRabat;
        private BssBase.txtBase txtAkciskaCena;
        private BssBase.txtBase cenaNaGolemotxtBase;

        public DataGridViewTextBoxColumn ID11
        {
            get
            {
                return ID12;
            }

            set
            {
                ID12 = value;
            }
        }

        public DataGridViewTextBoxColumn ID12
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

        public DataGridViewTextBoxColumn ID13
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
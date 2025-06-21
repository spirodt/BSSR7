namespace MMaterijalno.Forms
{
    partial class frmDogovoriEdit
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label zabeleskaLabel;
            System.Windows.Forms.Label datumOdLabel;
            System.Windows.Forms.Label datumDoLabel;
            System.Windows.Forms.Label brojNaDogovorLabel;
            System.Windows.Forms.Label brojNaTenderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDogovoriEdit));
            this.tblDogovoriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblDogovoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
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
            this.tblDogovoriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivtxtBase = new BssBase.txtBase();
            this.zabeleskatxtBase = new BssBase.txtBase();
            this.datumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brojNaDogovortxtBase = new BssBase.txtBase();
            this.brojNaTendertxtBase = new BssBase.txtBase();
            this.tabStavki = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPreostanata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreostanata = new BssBase.txtBase();
            this.txtSumDadena = new BssBase.txtBase();
            this.txtSumKolicina = new BssBase.txtBase();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKolicina = new BssBase.txtBase();
            this.txtCena = new BssBase.txtBase();
            this.txtNaziv = new BssBase.txtBase();
            this.zbxBase1 = new BssBase.zbxBase();
            this.tblDogovoriInfoGridBig = new BssBase.GridBig();
            this.tblDogovorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblArtikalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DadenaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preostanato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDogovoriInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPartner = new BssBase.txtBase();
            this.zbxPartner = new BssBase.zbxBase();
            this.tblDogovoriTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDogovoriTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.tblDogovoriInfoTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDogovoriInfoTableAdapter();
            nazivLabel = new System.Windows.Forms.Label();
            zabeleskaLabel = new System.Windows.Forms.Label();
            datumOdLabel = new System.Windows.Forms.Label();
            datumDoLabel = new System.Windows.Forms.Label();
            brojNaDogovorLabel = new System.Windows.Forms.Label();
            brojNaTenderLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriBindingNavigator)).BeginInit();
            this.tblDogovoriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            this.tabStavki.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriInfoGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabStavki);
            this.MainTab.Size = new System.Drawing.Size(1109, 675);
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            this.MainTab.Controls.SetChildIndex(this.tabStavki, 0);
            this.MainTab.Controls.SetChildIndex(this.tabVnes, 0);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(1101, 649);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.txtPartner);
            this.groupVnes.Controls.Add(this.zbxPartner);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(zabeleskaLabel);
            this.groupVnes.Controls.Add(this.zabeleskatxtBase);
            this.groupVnes.Controls.Add(datumOdLabel);
            this.groupVnes.Controls.Add(this.datumOdDateTimePicker);
            this.groupVnes.Controls.Add(datumDoLabel);
            this.groupVnes.Controls.Add(this.datumDoDateTimePicker);
            this.groupVnes.Controls.Add(brojNaDogovorLabel);
            this.groupVnes.Controls.Add(this.brojNaDogovortxtBase);
            this.groupVnes.Controls.Add(brojNaTenderLabel);
            this.groupVnes.Controls.Add(this.brojNaTendertxtBase);
            this.groupVnes.Size = new System.Drawing.Size(1098, 646);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 674);
            this.PanelFooter.Size = new System.Drawing.Size(1113, 69);
            this.PanelFooter.TabIndex = 0;
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
            this.btnOk.Location = new System.Drawing.Point(912, 2);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(9, 179);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Назив:";
            // 
            // zabeleskaLabel
            // 
            zabeleskaLabel.AutoSize = true;
            zabeleskaLabel.Location = new System.Drawing.Point(9, 220);
            zabeleskaLabel.Name = "zabeleskaLabel";
            zabeleskaLabel.Size = new System.Drawing.Size(149, 29);
            zabeleskaLabel.TabIndex = 2;
            zabeleskaLabel.Text = "Забелешка:";
            // 
            // datumOdLabel
            // 
            datumOdLabel.AutoSize = true;
            datumOdLabel.Location = new System.Drawing.Point(9, 262);
            datumOdLabel.Name = "datumOdLabel";
            datumOdLabel.Size = new System.Drawing.Size(123, 29);
            datumOdLabel.TabIndex = 4;
            datumOdLabel.Text = "Датум од;";
            // 
            // datumDoLabel
            // 
            datumDoLabel.AutoSize = true;
            datumDoLabel.Location = new System.Drawing.Point(9, 303);
            datumDoLabel.Name = "datumDoLabel";
            datumDoLabel.Size = new System.Drawing.Size(123, 29);
            datumDoLabel.TabIndex = 6;
            datumDoLabel.Text = "Датум до:";
            // 
            // brojNaDogovorLabel
            // 
            brojNaDogovorLabel.AutoSize = true;
            brojNaDogovorLabel.Location = new System.Drawing.Point(9, 343);
            brojNaDogovorLabel.Name = "brojNaDogovorLabel";
            brojNaDogovorLabel.Size = new System.Drawing.Size(202, 29);
            brojNaDogovorLabel.TabIndex = 8;
            brojNaDogovorLabel.Text = "Број на договор:";
            // 
            // brojNaTenderLabel
            // 
            brojNaTenderLabel.AutoSize = true;
            brojNaTenderLabel.Location = new System.Drawing.Point(9, 384);
            brojNaTenderLabel.Name = "brojNaTenderLabel";
            brojNaTenderLabel.Size = new System.Drawing.Size(191, 29);
            brojNaTenderLabel.TabIndex = 10;
            brojNaTenderLabel.Text = "Број на тендер:";
            // 
            // tblDogovoriBindingNavigator
            // 
            this.tblDogovoriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDogovoriBindingNavigator.BindingSource = this.tblDogovoriBindingSource;
            this.tblDogovoriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDogovoriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDogovoriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDogovoriBindingNavigatorSaveItem});
            this.tblDogovoriBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDogovoriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDogovoriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDogovoriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDogovoriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDogovoriBindingNavigator.Name = "tblDogovoriBindingNavigator";
            this.tblDogovoriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDogovoriBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblDogovoriBindingNavigator.TabIndex = 6;
            this.tblDogovoriBindingNavigator.Text = "bindingNavigator1";
            this.tblDogovoriBindingNavigator.Visible = false;
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
            // tblDogovoriBindingSource
            // 
            this.tblDogovoriBindingSource.DataMember = "tblDogovori";
            this.tblDogovoriBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblDogovoriBindingNavigatorSaveItem
            // 
            this.tblDogovoriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDogovoriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDogovoriBindingNavigatorSaveItem.Image")));
            this.tblDogovoriBindingNavigatorSaveItem.Name = "tblDogovoriBindingNavigatorSaveItem";
            this.tblDogovoriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblDogovoriBindingNavigatorSaveItem.Text = "Save Data";
            this.tblDogovoriBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblDogovoriBindingNavigatorSaveItem_Click);
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDogovoriBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.iscistiGreenNaLeave = false;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(221, 176);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(455, 35);
            this.nazivtxtBase.TabIndex = 0;
            // 
            // zabeleskatxtBase
            // 
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
            this.zabeleskatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDogovoriBindingSource, "Zabeleska", true));
            this.zabeleskatxtBase.Format = null;
            this.zabeleskatxtBase.formToOpen = null;
            this.zabeleskatxtBase.iscistiGreenNaLeave = false;
            this.zabeleskatxtBase.KoristiFilterNaDatasource = false;
            this.zabeleskatxtBase.Location = new System.Drawing.Point(221, 217);
            this.zabeleskatxtBase.MakedonskiJazik = false;
            this.zabeleskatxtBase.MinLength = 0;
            this.zabeleskatxtBase.Name = "zabeleskatxtBase";
            this.zabeleskatxtBase.PopulateOtherFields = false;
            this.zabeleskatxtBase.regularExpression = null;
            this.zabeleskatxtBase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.zabeleskatxtBase.SelektrijaNaFokus = false;
            this.zabeleskatxtBase.Size = new System.Drawing.Size(455, 35);
            this.zabeleskatxtBase.TabIndex = 1;
            // 
            // datumOdDateTimePicker
            // 
            this.datumOdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDogovoriBindingSource, "DatumOd", true));
            this.datumOdDateTimePicker.Location = new System.Drawing.Point(221, 258);
            this.datumOdDateTimePicker.Name = "datumOdDateTimePicker";
            this.datumOdDateTimePicker.Size = new System.Drawing.Size(455, 35);
            this.datumOdDateTimePicker.TabIndex = 2;
            // 
            // datumDoDateTimePicker
            // 
            this.datumDoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDogovoriBindingSource, "DatumDo", true));
            this.datumDoDateTimePicker.Location = new System.Drawing.Point(221, 299);
            this.datumDoDateTimePicker.Name = "datumDoDateTimePicker";
            this.datumDoDateTimePicker.Size = new System.Drawing.Size(455, 35);
            this.datumDoDateTimePicker.TabIndex = 3;
            // 
            // brojNaDogovortxtBase
            // 
            this.brojNaDogovortxtBase.AssemblyStr = null;
            this.brojNaDogovortxtBase.C_FillWithZeros = false;
            this.brojNaDogovortxtBase.C_OnlyNumbers = false;
            this.brojNaDogovortxtBase.C_RegEx = false;
            this.brojNaDogovortxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.brojNaDogovortxtBase.ColumnName1 = null;
            this.brojNaDogovortxtBase.ColumnName2 = null;
            this.brojNaDogovortxtBase.ColumnName3 = null;
            this.brojNaDogovortxtBase.ColumnName4 = null;
            this.brojNaDogovortxtBase.ColumnName5 = null;
            this.brojNaDogovortxtBase.ColumnName6 = null;
            this.brojNaDogovortxtBase.ColumnName7 = null;
            this.brojNaDogovortxtBase.daliCetiri = false;
            this.brojNaDogovortxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDogovoriBindingSource, "BrojNaDogovor", true));
            this.brojNaDogovortxtBase.Format = null;
            this.brojNaDogovortxtBase.formToOpen = null;
            this.brojNaDogovortxtBase.iscistiGreenNaLeave = false;
            this.brojNaDogovortxtBase.KoristiFilterNaDatasource = false;
            this.brojNaDogovortxtBase.Location = new System.Drawing.Point(221, 340);
            this.brojNaDogovortxtBase.MakedonskiJazik = false;
            this.brojNaDogovortxtBase.MinLength = 0;
            this.brojNaDogovortxtBase.Name = "brojNaDogovortxtBase";
            this.brojNaDogovortxtBase.PopulateOtherFields = false;
            this.brojNaDogovortxtBase.regularExpression = null;
            this.brojNaDogovortxtBase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.brojNaDogovortxtBase.SelektrijaNaFokus = false;
            this.brojNaDogovortxtBase.Size = new System.Drawing.Size(455, 35);
            this.brojNaDogovortxtBase.TabIndex = 4;
            // 
            // brojNaTendertxtBase
            // 
            this.brojNaTendertxtBase.AssemblyStr = null;
            this.brojNaTendertxtBase.C_FillWithZeros = false;
            this.brojNaTendertxtBase.C_OnlyNumbers = false;
            this.brojNaTendertxtBase.C_RegEx = false;
            this.brojNaTendertxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.brojNaTendertxtBase.ColumnName1 = null;
            this.brojNaTendertxtBase.ColumnName2 = null;
            this.brojNaTendertxtBase.ColumnName3 = null;
            this.brojNaTendertxtBase.ColumnName4 = null;
            this.brojNaTendertxtBase.ColumnName5 = null;
            this.brojNaTendertxtBase.ColumnName6 = null;
            this.brojNaTendertxtBase.ColumnName7 = null;
            this.brojNaTendertxtBase.daliCetiri = false;
            this.brojNaTendertxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDogovoriBindingSource, "BrojNaTender", true));
            this.brojNaTendertxtBase.Format = null;
            this.brojNaTendertxtBase.formToOpen = null;
            this.brojNaTendertxtBase.iscistiGreenNaLeave = false;
            this.brojNaTendertxtBase.KoristiFilterNaDatasource = false;
            this.brojNaTendertxtBase.Location = new System.Drawing.Point(221, 381);
            this.brojNaTendertxtBase.MakedonskiJazik = false;
            this.brojNaTendertxtBase.MinLength = 0;
            this.brojNaTendertxtBase.Name = "brojNaTendertxtBase";
            this.brojNaTendertxtBase.PopulateOtherFields = false;
            this.brojNaTendertxtBase.regularExpression = null;
            this.brojNaTendertxtBase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.brojNaTendertxtBase.SelektrijaNaFokus = false;
            this.brojNaTendertxtBase.Size = new System.Drawing.Size(455, 35);
            this.brojNaTendertxtBase.TabIndex = 5;
            // 
            // tabStavki
            // 
            this.tabStavki.Controls.Add(this.groupBox1);
            this.tabStavki.Location = new System.Drawing.Point(4, 22);
            this.tabStavki.Name = "tabStavki";
            this.tabStavki.Padding = new System.Windows.Forms.Padding(3);
            this.tabStavki.Size = new System.Drawing.Size(1101, 649);
            this.tabStavki.TabIndex = 1;
            this.tabStavki.Text = "Ставки во договорот";
            this.tabStavki.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPreostanata);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPreostanata);
            this.groupBox1.Controls.Add(this.txtSumDadena);
            this.groupBox1.Controls.Add(this.txtSumKolicina);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.zbxBase1);
            this.groupBox1.Controls.Add(this.tblDogovoriInfoGridBig);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 643);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ставки";
            // 
            // lblPreostanata
            // 
            this.lblPreostanata.AutoSize = true;
            this.lblPreostanata.Location = new System.Drawing.Point(801, 98);
            this.lblPreostanata.Name = "lblPreostanata";
            this.lblPreostanata.Size = new System.Drawing.Size(162, 13);
            this.lblPreostanata.TabIndex = 14;
            this.lblPreostanata.Text = "Вкупна Преостаната количина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Вкупна дадена количина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вкупна количина по договор:";
            // 
            // txtPreostanata
            // 
            this.txtPreostanata.AssemblyStr = null;
            this.txtPreostanata.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPreostanata.C_FillWithZeros = false;
            this.txtPreostanata.C_OnlyNumbers = true;
            this.txtPreostanata.C_RegEx = false;
            this.txtPreostanata.C_ShowRedOnLeaveIfEmpty = false;
            this.txtPreostanata.ColumnName1 = null;
            this.txtPreostanata.ColumnName2 = null;
            this.txtPreostanata.ColumnName3 = null;
            this.txtPreostanata.ColumnName4 = null;
            this.txtPreostanata.ColumnName5 = null;
            this.txtPreostanata.ColumnName6 = null;
            this.txtPreostanata.ColumnName7 = null;
            this.txtPreostanata.daliCetiri = false;
            this.txtPreostanata.ForeColor = System.Drawing.Color.Blue;
            this.txtPreostanata.Format = null;
            this.txtPreostanata.formToOpen = null;
            this.txtPreostanata.iscistiGreenNaLeave = false;
            this.txtPreostanata.KoristiFilterNaDatasource = false;
            this.txtPreostanata.Location = new System.Drawing.Point(969, 94);
            this.txtPreostanata.MakedonskiJazik = false;
            this.txtPreostanata.MinLength = 0;
            this.txtPreostanata.Name = "txtPreostanata";
            this.txtPreostanata.PopulateOtherFields = false;
            this.txtPreostanata.ReadOnly = true;
            this.txtPreostanata.regularExpression = null;
            this.txtPreostanata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreostanata.SelektrijaNaFokus = false;
            this.txtPreostanata.Size = new System.Drawing.Size(118, 20);
            this.txtPreostanata.TabIndex = 10;
            this.txtPreostanata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumDadena
            // 
            this.txtSumDadena.AssemblyStr = null;
            this.txtSumDadena.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSumDadena.C_FillWithZeros = false;
            this.txtSumDadena.C_OnlyNumbers = true;
            this.txtSumDadena.C_RegEx = false;
            this.txtSumDadena.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSumDadena.ColumnName1 = null;
            this.txtSumDadena.ColumnName2 = null;
            this.txtSumDadena.ColumnName3 = null;
            this.txtSumDadena.ColumnName4 = null;
            this.txtSumDadena.ColumnName5 = null;
            this.txtSumDadena.ColumnName6 = null;
            this.txtSumDadena.ColumnName7 = null;
            this.txtSumDadena.daliCetiri = false;
            this.txtSumDadena.ForeColor = System.Drawing.Color.Blue;
            this.txtSumDadena.Format = null;
            this.txtSumDadena.formToOpen = null;
            this.txtSumDadena.iscistiGreenNaLeave = false;
            this.txtSumDadena.KoristiFilterNaDatasource = false;
            this.txtSumDadena.Location = new System.Drawing.Point(969, 70);
            this.txtSumDadena.MakedonskiJazik = false;
            this.txtSumDadena.MinLength = 0;
            this.txtSumDadena.Name = "txtSumDadena";
            this.txtSumDadena.PopulateOtherFields = false;
            this.txtSumDadena.ReadOnly = true;
            this.txtSumDadena.regularExpression = null;
            this.txtSumDadena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSumDadena.SelektrijaNaFokus = false;
            this.txtSumDadena.Size = new System.Drawing.Size(118, 20);
            this.txtSumDadena.TabIndex = 9;
            this.txtSumDadena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumKolicina
            // 
            this.txtSumKolicina.AssemblyStr = null;
            this.txtSumKolicina.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSumKolicina.C_FillWithZeros = false;
            this.txtSumKolicina.C_OnlyNumbers = true;
            this.txtSumKolicina.C_RegEx = false;
            this.txtSumKolicina.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSumKolicina.ColumnName1 = null;
            this.txtSumKolicina.ColumnName2 = null;
            this.txtSumKolicina.ColumnName3 = null;
            this.txtSumKolicina.ColumnName4 = null;
            this.txtSumKolicina.ColumnName5 = null;
            this.txtSumKolicina.ColumnName6 = null;
            this.txtSumKolicina.ColumnName7 = null;
            this.txtSumKolicina.daliCetiri = false;
            this.txtSumKolicina.ForeColor = System.Drawing.Color.Blue;
            this.txtSumKolicina.Format = null;
            this.txtSumKolicina.formToOpen = null;
            this.txtSumKolicina.iscistiGreenNaLeave = false;
            this.txtSumKolicina.KoristiFilterNaDatasource = false;
            this.txtSumKolicina.Location = new System.Drawing.Point(969, 46);
            this.txtSumKolicina.MakedonskiJazik = false;
            this.txtSumKolicina.MinLength = 0;
            this.txtSumKolicina.Name = "txtSumKolicina";
            this.txtSumKolicina.PopulateOtherFields = false;
            this.txtSumKolicina.ReadOnly = true;
            this.txtSumKolicina.regularExpression = null;
            this.txtSumKolicina.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSumKolicina.SelektrijaNaFokus = false;
            this.txtSumKolicina.Size = new System.Drawing.Size(118, 20);
            this.txtSumKolicina.TabIndex = 8;
            this.txtSumKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Image = global::MMaterijalno.Properties.Resources.add_1_icon__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(493, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 82);
            this.button1.TabIndex = 7;
            this.button1.Text = "Внеси";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVnesi1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количина:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.AssemblyStr = null;
            this.txtKolicina.C_Decimal = true;
            this.txtKolicina.C_FillWithZeros = false;
            this.txtKolicina.C_OnlyNumbers = true;
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
            this.txtKolicina.Format = null;
            this.txtKolicina.formToOpen = null;
            this.txtKolicina.iscistiGreenNaLeave = false;
            this.txtKolicina.KoristiFilterNaDatasource = false;
            this.txtKolicina.Location = new System.Drawing.Point(208, 16);
            this.txtKolicina.MakedonskiJazik = false;
            this.txtKolicina.MinLength = 0;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.PopulateOtherFields = false;
            this.txtKolicina.regularExpression = null;
            this.txtKolicina.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKolicina.SelektrijaNaFokus = false;
            this.txtKolicina.Size = new System.Drawing.Size(107, 20);
            this.txtKolicina.TabIndex = 1;
            this.txtKolicina.Text = "0,00";
            // 
            // txtCena
            // 
            this.txtCena.AssemblyStr = null;
            this.txtCena.C_Decimal = true;
            this.txtCena.C_FillWithZeros = false;
            this.txtCena.C_OnlyNumbers = true;
            this.txtCena.C_RegEx = false;
            this.txtCena.C_ShowRedOnLeaveIfEmpty = false;
            this.txtCena.ColumnName1 = null;
            this.txtCena.ColumnName2 = null;
            this.txtCena.ColumnName3 = null;
            this.txtCena.ColumnName4 = null;
            this.txtCena.ColumnName5 = null;
            this.txtCena.ColumnName6 = null;
            this.txtCena.ColumnName7 = null;
            this.txtCena.daliCetiri = false;
            this.txtCena.Format = null;
            this.txtCena.formToOpen = null;
            this.txtCena.iscistiGreenNaLeave = false;
            this.txtCena.KoristiFilterNaDatasource = false;
            this.txtCena.Location = new System.Drawing.Point(383, 15);
            this.txtCena.MakedonskiJazik = false;
            this.txtCena.MinLength = 0;
            this.txtCena.Name = "txtCena";
            this.txtCena.PopulateOtherFields = false;
            this.txtCena.regularExpression = null;
            this.txtCena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCena.SelektrijaNaFokus = false;
            this.txtCena.Size = new System.Drawing.Size(99, 20);
            this.txtCena.TabIndex = 2;
            this.txtCena.Text = "0,00";
            // 
            // txtNaziv
            // 
            this.txtNaziv.AssemblyStr = null;
            this.txtNaziv.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNaziv.C_FillWithZeros = false;
            this.txtNaziv.C_OnlyNumbers = false;
            this.txtNaziv.C_RegEx = false;
            this.txtNaziv.C_ShowRedOnLeaveIfEmpty = false;
            this.txtNaziv.ColumnName1 = null;
            this.txtNaziv.ColumnName2 = null;
            this.txtNaziv.ColumnName3 = null;
            this.txtNaziv.ColumnName4 = null;
            this.txtNaziv.ColumnName5 = null;
            this.txtNaziv.ColumnName6 = null;
            this.txtNaziv.ColumnName7 = null;
            this.txtNaziv.daliCetiri = false;
            this.txtNaziv.ForeColor = System.Drawing.Color.Blue;
            this.txtNaziv.Format = null;
            this.txtNaziv.formToOpen = null;
            this.txtNaziv.iscistiGreenNaLeave = false;
            this.txtNaziv.KoristiFilterNaDatasource = false;
            this.txtNaziv.Location = new System.Drawing.Point(8, 46);
            this.txtNaziv.MakedonskiJazik = false;
            this.txtNaziv.MinLength = 0;
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PopulateOtherFields = false;
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.regularExpression = null;
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.SelektrijaNaFokus = false;
            this.txtNaziv.Size = new System.Drawing.Size(474, 74);
            this.txtNaziv.TabIndex = 2;
            // 
            // zbxBase1
            // 
            this.zbxBase1.AssemblyStr = "BSSR";
            this.zbxBase1.AutoSize = true;
            this.zbxBase1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zbxBase1.ColumnName1 = "ID";
            this.zbxBase1.ColumnName2 = "Sifra";
            this.zbxBase1.ColumnName3 = "Naziv";
            this.zbxBase1.ColumnName4 = null;
            this.zbxBase1.ColumnName5 = null;
            this.zbxBase1.ColumnName6 = null;
            this.zbxBase1.ColumnName7 = null;
            this.zbxBase1.filterDataSource = null;
            this.zbxBase1.formToOpen = "BSSR.Forms.frmArtikli";
            this.zbxBase1.GridFromForm = null;
            this.zbxBase1.KoristiFilterNaDatasource = false;
            this.zbxBase1.Location = new System.Drawing.Point(6, 15);
            this.zbxBase1.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxBase1.Name = "zbxBase1";
            this.zbxBase1.ovozmoziIzmena = false;
            this.zbxBase1.showRedIfEmpty = false;
            this.zbxBase1.Size = new System.Drawing.Size(134, 25);
            this.zbxBase1.TabIndex = 0;
            this.zbxBase1.DataRead += new BssBase.zbxBase.doneLoading(this.zbxBase1_DataRead);
            this.zbxBase1.Validated += new System.EventHandler(this.zbxBase1_Validated);
            // 
            // tblDogovoriInfoGridBig
            // 
            this.tblDogovoriInfoGridBig.AllowUserToAddRows = false;
            this.tblDogovoriInfoGridBig.AllowUserToDeleteRows = false;
            this.tblDogovoriInfoGridBig.AllowUserToOrderColumns = true;
            this.tblDogovoriInfoGridBig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDogovoriInfoGridBig.AssemblyToLoad = null;
            this.tblDogovoriInfoGridBig.AutoGenerateColumns = false;
            this.tblDogovoriInfoGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDogovoriInfoGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblDogovorId,
            this.tblArtikalID,
            this.Sifra,
            this.Naziv,
            this.Cena,
            this.Kolicina,
            this.DadenaKolicina,
            this.Preostanato});
            this.tblDogovoriInfoGridBig.DataSource = this.tblDogovoriInfoBindingSource;
            this.tblDogovoriInfoGridBig.EditForm = null;
            this.tblDogovoriInfoGridBig.FilterForm = null;
            this.tblDogovoriInfoGridBig.HidenColumns = null;
            this.tblDogovoriInfoGridBig.KreirajPredefiniraniPolinja = false;
            this.tblDogovoriInfoGridBig.Location = new System.Drawing.Point(6, 134);
            this.tblDogovoriInfoGridBig.MultiSelect = false;
            this.tblDogovoriInfoGridBig.Name = "tblDogovoriInfoGridBig";
            this.tblDogovoriInfoGridBig.PrimaryKey = "ID";
            this.tblDogovoriInfoGridBig.ReadOnly = true;
            this.tblDogovoriInfoGridBig.ReadOnlyColumns = null;
            this.tblDogovoriInfoGridBig.reportCenter = false;
            this.tblDogovoriInfoGridBig.ReportName = null;
            this.tblDogovoriInfoGridBig.RowTemplate.Height = 36;
            this.tblDogovoriInfoGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDogovoriInfoGridBig.Size = new System.Drawing.Size(1086, 503);
            this.tblDogovoriInfoGridBig.SQLCommandQuery = null;
            this.tblDogovoriInfoGridBig.TabIndex = 0;
            this.tblDogovoriInfoGridBig.UpdateTable = null;
            // 
            // tblDogovorId
            // 
            this.tblDogovorId.DataPropertyName = "tblDogovorId";
            this.tblDogovorId.HeaderText = "ДоговорИД";
            this.tblDogovorId.Name = "tblDogovorId";
            this.tblDogovorId.ReadOnly = true;
            this.tblDogovorId.Visible = false;
            // 
            // tblArtikalID
            // 
            this.tblArtikalID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblArtikalID.DataPropertyName = "tblArtikalID";
            this.tblArtikalID.HeaderText = "Артикал";
            this.tblArtikalID.Name = "tblArtikalID";
            this.tblArtikalID.ReadOnly = true;
            this.tblArtikalID.Visible = false;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Шифра";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Назив";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            this.Cena.HeaderText = "Цена";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Количина";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // DadenaKolicina
            // 
            this.DadenaKolicina.DataPropertyName = "DadenaKolicina";
            this.DadenaKolicina.HeaderText = "Дадена количина";
            this.DadenaKolicina.Name = "DadenaKolicina";
            this.DadenaKolicina.ReadOnly = true;
            // 
            // Preostanato
            // 
            this.Preostanato.DataPropertyName = "Preostanato";
            this.Preostanato.HeaderText = "Преостанато";
            this.Preostanato.Name = "Preostanato";
            this.Preostanato.ReadOnly = true;
            // 
            // tblDogovoriInfoBindingSource
            // 
            this.tblDogovoriInfoBindingSource.DataMember = "tblDogovoriInfo";
            this.tblDogovoriInfoBindingSource.DataSource = this.materijalnoDataSet;
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
            this.txtPartner.Location = new System.Drawing.Point(164, 23);
            this.txtPartner.MakedonskiJazik = false;
            this.txtPartner.MinLength = 0;
            this.txtPartner.Multiline = true;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PopulateOtherFields = false;
            this.txtPartner.ReadOnly = true;
            this.txtPartner.regularExpression = null;
            this.txtPartner.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPartner.SelektrijaNaFokus = false;
            this.txtPartner.Size = new System.Drawing.Size(606, 130);
            this.txtPartner.TabIndex = 39;
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
            this.zbxPartner.Location = new System.Drawing.Point(12, 19);
            this.zbxPartner.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxPartner.Name = "zbxPartner";
            this.zbxPartner.ovozmoziIzmena = false;
            this.zbxPartner.showRedIfEmpty = false;
            this.zbxPartner.Size = new System.Drawing.Size(146, 55);
            this.zbxPartner.TabIndex = 38;
            this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading(this.zbxPartner_DataRead);
            this.zbxPartner.Validated += new System.EventHandler(this.zbxPartner_Validated);
            // 
            // tblDogovoriTableAdapter
            // 
            this.tblDogovoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.General_data_mesecTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDogovoriTableAdapter = this.tblDogovoriTableAdapter;
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
            // tblDogovoriInfoTableAdapter
            // 
            this.tblDogovoriInfoTableAdapter.ClearBeforeFill = true;
            // 
            // frmDogovoriEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 743);
            this.Controls.Add(this.tblDogovoriBindingNavigator);
            this.Name = "frmDogovoriEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDogovoriEdit";
            this.Load += new System.EventHandler(this.frmDogovoriEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblDogovoriBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriBindingNavigator)).EndInit();
            this.tblDogovoriBindingNavigator.ResumeLayout(false);
            this.tblDogovoriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            this.tabStavki.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriInfoGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource tblDogovoriBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDogovoriTableAdapter tblDogovoriTableAdapter;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblDogovoriBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblDogovoriBindingNavigatorSaveItem;
        private BssBase.txtBase nazivtxtBase;
        private BssBase.txtBase zabeleskatxtBase;
        private System.Windows.Forms.DateTimePicker datumOdDateTimePicker;
        private System.Windows.Forms.DateTimePicker datumDoDateTimePicker;
        private BssBase.txtBase brojNaDogovortxtBase;
        private BssBase.txtBase brojNaTendertxtBase;
        private System.Windows.Forms.TabPage tabStavki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tblDogovoriInfoBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDogovoriInfoTableAdapter tblDogovoriInfoTableAdapter;
        private BssBase.GridBig tblDogovoriInfoGridBig;
        private BssBase.txtBase txtNaziv;
        private BssBase.zbxBase zbxBase1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BssBase.txtBase txtKolicina;
        private BssBase.txtBase txtCena;
        private BssBase.txtBase txtPartner;
        private BssBase.zbxBase zbxPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zabeleska;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblDogovorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblArtikalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn DadenaKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preostanato;
        private System.Windows.Forms.Label label3;
        private BssBase.txtBase txtPreostanata;
        private BssBase.txtBase txtSumDadena;
        private BssBase.txtBase txtSumKolicina;
        private System.Windows.Forms.Label lblPreostanata;
        private System.Windows.Forms.Label label4;
    }
}
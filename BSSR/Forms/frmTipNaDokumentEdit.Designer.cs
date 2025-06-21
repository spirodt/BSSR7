namespace BSSR.Forms
{
    partial class frmTipNaDokumentEdit
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label seKniziLabel;
            System.Windows.Forms.Label reportFileNameLabel;
            System.Windows.Forms.Label tipNaKnizenjeLabel;
            System.Windows.Forms.Label naslovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipNaDokumentEdit));
            System.Windows.Forms.Label interenLabel;
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblTipNaDokumentBindingSource = new System.Windows.Forms.BindingSource();
            this.tblTipNaDokumentTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblTipNaDokumentTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblTipNaDokumentBindingNavigator = new System.Windows.Forms.BindingNavigator();
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
            this.tblTipNaDokumentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivtxtBase = new BssBase.txtBase();
            this.seKniziCheckBox = new System.Windows.Forms.CheckBox();
            this.reportFileNametxtBase = new BssBase.txtBase();
            this.tipNaKnizenjeTextBox = new System.Windows.Forms.TextBox();
            this.naslovtxtBase = new BssBase.txtBase();
            this.interenTextBox = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            seKniziLabel = new System.Windows.Forms.Label();
            reportFileNameLabel = new System.Windows.Forms.Label();
            tipNaKnizenjeLabel = new System.Windows.Forms.Label();
            naslovLabel = new System.Windows.Forms.Label();
            interenLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentBindingNavigator)).BeginInit();
            this.tblTipNaDokumentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(605, 394);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(597, 368);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(interenLabel);
            this.groupVnes.Controls.Add(this.interenTextBox);
            this.groupVnes.Controls.Add(naslovLabel);
            this.groupVnes.Controls.Add(this.naslovtxtBase);
            this.groupVnes.Controls.Add(tipNaKnizenjeLabel);
            this.groupVnes.Controls.Add(this.tipNaKnizenjeTextBox);
            this.groupVnes.Controls.Add(reportFileNameLabel);
            this.groupVnes.Controls.Add(this.reportFileNametxtBase);
            this.groupVnes.Controls.Add(seKniziLabel);
            this.groupVnes.Controls.Add(this.seKniziCheckBox);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Size = new System.Drawing.Size(594, 365);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 393);
            this.PanelFooter.Size = new System.Drawing.Size(609, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 4);
            this.btnZatvori.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(410, 4);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(6, 31);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Назив:";
            // 
            // seKniziLabel
            // 
            seKniziLabel.AutoSize = true;
            seKniziLabel.Location = new System.Drawing.Point(6, 122);
            seKniziLabel.Name = "seKniziLabel";
            seKniziLabel.Size = new System.Drawing.Size(131, 29);
            seKniziLabel.TabIndex = 2;
            seKniziLabel.Text = "Се книжи:";
            // 
            // reportFileNameLabel
            // 
            reportFileNameLabel.AutoSize = true;
            reportFileNameLabel.Location = new System.Drawing.Point(5, 166);
            reportFileNameLabel.Name = "reportFileNameLabel";
            reportFileNameLabel.Size = new System.Drawing.Size(192, 29);
            reportFileNameLabel.TabIndex = 4;
            reportFileNameLabel.Text = "Име на репорт:";
            // 
            // tipNaKnizenjeLabel
            // 
            tipNaKnizenjeLabel.AutoSize = true;
            tipNaKnizenjeLabel.Location = new System.Drawing.Point(185, 125);
            tipNaKnizenjeLabel.Name = "tipNaKnizenjeLabel";
            tipNaKnizenjeLabel.Size = new System.Drawing.Size(213, 29);
            tipNaKnizenjeLabel.TabIndex = 6;
            tipNaKnizenjeLabel.Text = "Тип на книжење:";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new System.Drawing.Point(6, 214);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new System.Drawing.Size(226, 29);
            naslovLabel.TabIndex = 8;
            naslovLabel.Text = "Наслов на репорт:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTipNaDokumentBindingSource
            // 
            this.tblTipNaDokumentBindingSource.DataMember = "tblTipNaDokument";
            this.tblTipNaDokumentBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblTipNaDokumentTableAdapter
            // 
            this.tblTipNaDokumentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
            this.tableAdapterManager.tblFormiTableAdapter = null;
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
            this.tableAdapterManager.tblKursnaListaTableAdapter = null;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = null;
            this.tableAdapterManager.tblNormativiSodriznaIznosTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblTipNaDokumentTableAdapter = this.tblTipNaDokumentTableAdapter;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblTipNaDokumentBindingNavigator
            // 
            this.tblTipNaDokumentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblTipNaDokumentBindingNavigator.BindingSource = this.tblTipNaDokumentBindingSource;
            this.tblTipNaDokumentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblTipNaDokumentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblTipNaDokumentBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblTipNaDokumentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblTipNaDokumentBindingNavigatorSaveItem});
            this.tblTipNaDokumentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblTipNaDokumentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblTipNaDokumentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblTipNaDokumentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblTipNaDokumentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblTipNaDokumentBindingNavigator.Name = "tblTipNaDokumentBindingNavigator";
            this.tblTipNaDokumentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblTipNaDokumentBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblTipNaDokumentBindingNavigator.TabIndex = 6;
            this.tblTipNaDokumentBindingNavigator.Text = "bindingNavigator1";
            this.tblTipNaDokumentBindingNavigator.Visible = false;
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
            // tblTipNaDokumentBindingNavigatorSaveItem
            // 
            this.tblTipNaDokumentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblTipNaDokumentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblTipNaDokumentBindingNavigatorSaveItem.Image")));
            this.tblTipNaDokumentBindingNavigatorSaveItem.Name = "tblTipNaDokumentBindingNavigatorSaveItem";
            this.tblTipNaDokumentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblTipNaDokumentBindingNavigatorSaveItem.Text = "Save Data";
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTipNaDokumentBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.iscistiGreenNaLeave = false;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(102, 31);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Multiline = true;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(477, 88);
            this.nazivtxtBase.TabIndex = 0;
            // 
            // seKniziCheckBox
            // 
            this.seKniziCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTipNaDokumentBindingSource, "SeKnizi", true));
            this.seKniziCheckBox.Location = new System.Drawing.Point(145, 127);
            this.seKniziCheckBox.Name = "seKniziCheckBox";
            this.seKniziCheckBox.Size = new System.Drawing.Size(104, 24);
            this.seKniziCheckBox.TabIndex = 1;
            this.seKniziCheckBox.UseVisualStyleBackColor = true;
            // 
            // reportFileNametxtBase
            // 
            this.reportFileNametxtBase.AssemblyStr = null;
            this.reportFileNametxtBase.C_FillWithZeros = false;
            this.reportFileNametxtBase.C_OnlyNumbers = false;
            this.reportFileNametxtBase.C_RegEx = false;
            this.reportFileNametxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.reportFileNametxtBase.ColumnName1 = null;
            this.reportFileNametxtBase.ColumnName2 = null;
            this.reportFileNametxtBase.ColumnName3 = null;
            this.reportFileNametxtBase.ColumnName4 = null;
            this.reportFileNametxtBase.ColumnName5 = null;
            this.reportFileNametxtBase.ColumnName6 = null;
            this.reportFileNametxtBase.ColumnName7 = null;
            this.reportFileNametxtBase.daliCetiri = false;
            this.reportFileNametxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTipNaDokumentBindingSource, "ReportFileName", true));
            this.reportFileNametxtBase.Format = null;
            this.reportFileNametxtBase.formToOpen = null;
            this.reportFileNametxtBase.iscistiGreenNaLeave = false;
            this.reportFileNametxtBase.KoristiFilterNaDatasource = false;
            this.reportFileNametxtBase.Location = new System.Drawing.Point(203, 167);
            this.reportFileNametxtBase.MakedonskiJazik = false;
            this.reportFileNametxtBase.MinLength = 0;
            this.reportFileNametxtBase.Name = "reportFileNametxtBase";
            this.reportFileNametxtBase.PopulateOtherFields = false;
            this.reportFileNametxtBase.regularExpression = null;
            this.reportFileNametxtBase.SelektrijaNaFokus = false;
            this.reportFileNametxtBase.Size = new System.Drawing.Size(376, 35);
            this.reportFileNametxtBase.TabIndex = 3;
            // 
            // tipNaKnizenjeTextBox
            // 
            this.tipNaKnizenjeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTipNaDokumentBindingSource, "TipNaKnizenje", true));
            this.tipNaKnizenjeTextBox.Location = new System.Drawing.Point(404, 124);
            this.tipNaKnizenjeTextBox.Name = "tipNaKnizenjeTextBox";
            this.tipNaKnizenjeTextBox.Size = new System.Drawing.Size(175, 35);
            this.tipNaKnizenjeTextBox.TabIndex = 2;
            // 
            // naslovtxtBase
            // 
            this.naslovtxtBase.AssemblyStr = null;
            this.naslovtxtBase.C_FillWithZeros = false;
            this.naslovtxtBase.C_OnlyNumbers = false;
            this.naslovtxtBase.C_RegEx = false;
            this.naslovtxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.naslovtxtBase.ColumnName1 = null;
            this.naslovtxtBase.ColumnName2 = null;
            this.naslovtxtBase.ColumnName3 = null;
            this.naslovtxtBase.ColumnName4 = null;
            this.naslovtxtBase.ColumnName5 = null;
            this.naslovtxtBase.ColumnName6 = null;
            this.naslovtxtBase.ColumnName7 = null;
            this.naslovtxtBase.daliCetiri = false;
            this.naslovtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTipNaDokumentBindingSource, "Naslov", true));
            this.naslovtxtBase.Format = null;
            this.naslovtxtBase.formToOpen = null;
            this.naslovtxtBase.iscistiGreenNaLeave = false;
            this.naslovtxtBase.KoristiFilterNaDatasource = false;
            this.naslovtxtBase.Location = new System.Drawing.Point(102, 248);
            this.naslovtxtBase.MakedonskiJazik = false;
            this.naslovtxtBase.MinLength = 0;
            this.naslovtxtBase.Multiline = true;
            this.naslovtxtBase.Name = "naslovtxtBase";
            this.naslovtxtBase.PopulateOtherFields = false;
            this.naslovtxtBase.regularExpression = null;
            this.naslovtxtBase.SelektrijaNaFokus = false;
            this.naslovtxtBase.Size = new System.Drawing.Size(477, 100);
            this.naslovtxtBase.TabIndex = 5;
            // 
            // interenLabel
            // 
            interenLabel.AutoSize = true;
            interenLabel.Location = new System.Drawing.Point(352, 210);
            interenLabel.Name = "interenLabel";
            interenLabel.Size = new System.Drawing.Size(121, 29);
            interenLabel.TabIndex = 10;
            interenLabel.Text = "Интерен:";
            // 
            // interenTextBox
            // 
            this.interenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTipNaDokumentBindingSource, "Interen", true));
            this.interenTextBox.Location = new System.Drawing.Point(479, 207);
            this.interenTextBox.Name = "interenTextBox";
            this.interenTextBox.Size = new System.Drawing.Size(100, 35);
            this.interenTextBox.TabIndex = 4;
            // 
            // frmTipNaDokumentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 462);
            this.Controls.Add(this.tblTipNaDokumentBindingNavigator);
            this.Name = "frmTipNaDokumentEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmTipNaDokumentEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblTipNaDokumentBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentBindingNavigator)).EndInit();
            this.tblTipNaDokumentBindingNavigator.ResumeLayout(false);
            this.tblTipNaDokumentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblTipNaDokumentBindingSource;
        private BSSSDatasetTableAdapters.tblTipNaDokumentTableAdapter tblTipNaDokumentTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblTipNaDokumentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblTipNaDokumentBindingNavigatorSaveItem;
        private BssBase.txtBase nazivtxtBase;
        private System.Windows.Forms.CheckBox seKniziCheckBox;
        private BssBase.txtBase naslovtxtBase;
        private System.Windows.Forms.TextBox tipNaKnizenjeTextBox;
        private BssBase.txtBase reportFileNametxtBase;
        private System.Windows.Forms.TextBox interenTextBox;
    }
}
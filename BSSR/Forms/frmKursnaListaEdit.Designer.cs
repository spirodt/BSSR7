namespace BSSR.Forms
{
    partial class frmKursnaListaEdit
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
            System.Windows.Forms.Label kursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKursnaListaEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblKursnaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKursnaListaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblKursnaListaTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblKursnaListaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblKursnaListaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kurstxtBase = new BssBase.txtBase();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbValuta = new BssBase.cmbBase();
            this.tblValutiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblValutiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblValutiTableAdapter();
            kursLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaBindingNavigator)).BeginInit();
            this.tblKursnaListaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.TabIndex = 0;
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.label1);
            this.groupVnes.Controls.Add(this.cmbValuta);
            this.groupVnes.Controls.Add(kursLabel);
            this.groupVnes.Controls.Add(this.kurstxtBase);
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
            this.btnOk.Location = new System.Drawing.Point(424, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Location = new System.Drawing.Point(224, 81);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(72, 29);
            kursLabel.TabIndex = 0;
            kursLabel.Text = "Курс:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKursnaListaBindingSource
            // 
            this.tblKursnaListaBindingSource.DataMember = "tblKursnaLista";
            this.tblKursnaListaBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblKursnaListaTableAdapter
            // 
            this.tblKursnaListaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblKursnaListaTableAdapter = this.tblKursnaListaTableAdapter;
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
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblKursnaListaBindingNavigator
            // 
            this.tblKursnaListaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblKursnaListaBindingNavigator.BindingSource = this.tblKursnaListaBindingSource;
            this.tblKursnaListaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblKursnaListaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblKursnaListaBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblKursnaListaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblKursnaListaBindingNavigatorSaveItem});
            this.tblKursnaListaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblKursnaListaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblKursnaListaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblKursnaListaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblKursnaListaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblKursnaListaBindingNavigator.Name = "tblKursnaListaBindingNavigator";
            this.tblKursnaListaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblKursnaListaBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblKursnaListaBindingNavigator.TabIndex = 6;
            this.tblKursnaListaBindingNavigator.Text = "bindingNavigator1";
            this.tblKursnaListaBindingNavigator.Visible = false;
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
            // tblKursnaListaBindingNavigatorSaveItem
            // 
            this.tblKursnaListaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblKursnaListaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblKursnaListaBindingNavigatorSaveItem.Image")));
            this.tblKursnaListaBindingNavigatorSaveItem.Name = "tblKursnaListaBindingNavigatorSaveItem";
            this.tblKursnaListaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblKursnaListaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // kurstxtBase
            // 
            this.kurstxtBase.AssemblyStr = null;
            this.kurstxtBase.C_FillWithZeros = false;
            this.kurstxtBase.C_OnlyNumbers = false;
            this.kurstxtBase.C_RegEx = false;
            this.kurstxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.kurstxtBase.ColumnName1 = null;
            this.kurstxtBase.ColumnName2 = null;
            this.kurstxtBase.ColumnName3 = null;
            this.kurstxtBase.ColumnName4 = null;
            this.kurstxtBase.ColumnName5 = null;
            this.kurstxtBase.ColumnName6 = null;
            this.kurstxtBase.ColumnName7 = null;
            this.kurstxtBase.daliCetiri = false;
            this.kurstxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKursnaListaBindingSource, "Kurs", true));
            this.kurstxtBase.Format = null;
            this.kurstxtBase.formToOpen = null;
            this.kurstxtBase.KoristiFilterNaDatasource = false;
            this.kurstxtBase.Location = new System.Drawing.Point(302, 75);
            this.kurstxtBase.MakedonskiJazik = false;
            this.kurstxtBase.MinLength = 0;
            this.kurstxtBase.Name = "kurstxtBase";
            this.kurstxtBase.PopulateOtherFields = false;
            this.kurstxtBase.prikaziKeyBoard = false;
            this.kurstxtBase.regularExpression = null;
            this.kurstxtBase.SelektrijaNaFokus = false;
            this.kurstxtBase.Size = new System.Drawing.Size(293, 35);
            this.kurstxtBase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Валута:";
            // 
            // cmbValuta
            // 
            this.cmbValuta.C_OnlyNumbers = false;
            this.cmbValuta.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbValuta.CurrentText = null;
            this.cmbValuta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblKursnaListaBindingSource, "tblValutaID", true));
            this.cmbValuta.DataSource = this.tblValutiBindingSource;
            this.cmbValuta.DisplayMember = "Opis";
            this.cmbValuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValuta.DtTableName = null;
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Location = new System.Drawing.Point(112, 32);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(483, 37);
            this.cmbValuta.TabIndex = 0;
            this.cmbValuta.value = null;
            this.cmbValuta.ValueMember = "ID";
            // 
            // tblValutiBindingSource
            // 
            this.tblValutiBindingSource.DataMember = "tblValuti";
            this.tblValutiBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblValutiTableAdapter
            // 
            this.tblValutiTableAdapter.ClearBeforeFill = true;
            // 
            // frmKursnaListaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 241);
            this.Controls.Add(this.tblKursnaListaBindingNavigator);
            this.Name = "frmKursnaListaEdit";
            this.Text = "Курсна листа";
            this.Load += new System.EventHandler(this.frmtblKursnaListaIDEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblKursnaListaBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaBindingNavigator)).EndInit();
            this.tblKursnaListaBindingNavigator.ResumeLayout(false);
            this.tblKursnaListaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblKursnaListaBindingSource;
        private BSSSDatasetTableAdapters.tblKursnaListaTableAdapter tblKursnaListaTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblKursnaListaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblKursnaListaBindingNavigatorSaveItem;
        private BssBase.txtBase kurstxtBase;
        private System.Windows.Forms.Label label1;
        private BssBase.cmbBase cmbValuta;
        private System.Windows.Forms.BindingSource tblValutiBindingSource;
        private BSSSDatasetTableAdapters.tblValutiTableAdapter tblValutiTableAdapter;
    }
}
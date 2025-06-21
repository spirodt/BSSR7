namespace BSSR.Forms
{
    partial class frmValutiEdit
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
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label kratenkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValutiEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblValutiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblValutiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblValutiTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblValutiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblValutiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.opistxtBase = new BssBase.txtBase();
            this.kratenkatxtBase = new BssBase.txtBase();
            opisLabel = new System.Windows.Forms.Label();
            kratenkaLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingNavigator)).BeginInit();
            this.tblValutiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(kratenkaLabel);
            this.groupVnes.Controls.Add(this.kratenkatxtBase);
            this.groupVnes.Controls.Add(opisLabel);
            this.groupVnes.Controls.Add(this.opistxtBase);
            this.groupVnes.Size = new System.Drawing.Size(604, 144);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 7);
            this.btnZatvori.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(424, 7);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(63, 36);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(80, 29);
            opisLabel.TabIndex = 0;
            opisLabel.Text = "Опис:";
            // 
            // kratenkaLabel
            // 
            kratenkaLabel.AutoSize = true;
            kratenkaLabel.Location = new System.Drawing.Point(19, 77);
            kratenkaLabel.Name = "kratenkaLabel";
            kratenkaLabel.Size = new System.Drawing.Size(128, 29);
            kratenkaLabel.TabIndex = 2;
            kratenkaLabel.Text = "Кратенка:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.tblValutiTableAdapter = this.tblValutiTableAdapter;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblValutiBindingNavigator
            // 
            this.tblValutiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblValutiBindingNavigator.BindingSource = this.tblValutiBindingSource;
            this.tblValutiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblValutiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblValutiBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblValutiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblValutiBindingNavigatorSaveItem});
            this.tblValutiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblValutiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblValutiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblValutiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblValutiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblValutiBindingNavigator.Name = "tblValutiBindingNavigator";
            this.tblValutiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblValutiBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblValutiBindingNavigator.TabIndex = 6;
            this.tblValutiBindingNavigator.Text = "bindingNavigator1";
            this.tblValutiBindingNavigator.Visible = false;
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
            // tblValutiBindingNavigatorSaveItem
            // 
            this.tblValutiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblValutiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblValutiBindingNavigatorSaveItem.Image")));
            this.tblValutiBindingNavigatorSaveItem.Name = "tblValutiBindingNavigatorSaveItem";
            this.tblValutiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblValutiBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // opistxtBase
            // 
            this.opistxtBase.AssemblyStr = null;
            this.opistxtBase.C_FillWithZeros = false;
            this.opistxtBase.C_OnlyNumbers = false;
            this.opistxtBase.C_RegEx = false;
            this.opistxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.opistxtBase.ColumnName1 = null;
            this.opistxtBase.ColumnName2 = null;
            this.opistxtBase.ColumnName3 = null;
            this.opistxtBase.ColumnName4 = null;
            this.opistxtBase.ColumnName5 = null;
            this.opistxtBase.ColumnName6 = null;
            this.opistxtBase.ColumnName7 = null;
            this.opistxtBase.daliCetiri = false;
            this.opistxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblValutiBindingSource, "Opis", true));
            this.opistxtBase.Format = null;
            this.opistxtBase.formToOpen = null;
            this.opistxtBase.KoristiFilterNaDatasource = false;
            this.opistxtBase.Location = new System.Drawing.Point(151, 33);
            this.opistxtBase.MakedonskiJazik = false;
            this.opistxtBase.MinLength = 0;
            this.opistxtBase.Name = "opistxtBase";
            this.opistxtBase.PopulateOtherFields = false;
            this.opistxtBase.prikaziKeyBoard = false;
            this.opistxtBase.regularExpression = null;
            this.opistxtBase.SelektrijaNaFokus = false;
            this.opistxtBase.Size = new System.Drawing.Size(445, 35);
            this.opistxtBase.TabIndex = 0;
            // 
            // kratenkatxtBase
            // 
            this.kratenkatxtBase.AssemblyStr = null;
            this.kratenkatxtBase.C_FillWithZeros = false;
            this.kratenkatxtBase.C_OnlyNumbers = false;
            this.kratenkatxtBase.C_RegEx = false;
            this.kratenkatxtBase.C_ShowRedOnLeaveIfEmpty = false;
            this.kratenkatxtBase.ColumnName1 = null;
            this.kratenkatxtBase.ColumnName2 = null;
            this.kratenkatxtBase.ColumnName3 = null;
            this.kratenkatxtBase.ColumnName4 = null;
            this.kratenkatxtBase.ColumnName5 = null;
            this.kratenkatxtBase.ColumnName6 = null;
            this.kratenkatxtBase.ColumnName7 = null;
            this.kratenkatxtBase.daliCetiri = false;
            this.kratenkatxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblValutiBindingSource, "Kratenka", true));
            this.kratenkatxtBase.Format = null;
            this.kratenkatxtBase.formToOpen = null;
            this.kratenkatxtBase.KoristiFilterNaDatasource = false;
            this.kratenkatxtBase.Location = new System.Drawing.Point(151, 74);
            this.kratenkatxtBase.MakedonskiJazik = false;
            this.kratenkatxtBase.MinLength = 0;
            this.kratenkatxtBase.Name = "kratenkatxtBase";
            this.kratenkatxtBase.PopulateOtherFields = false;
            this.kratenkatxtBase.prikaziKeyBoard = false;
            this.kratenkatxtBase.regularExpression = null;
            this.kratenkatxtBase.SelektrijaNaFokus = false;
            this.kratenkatxtBase.Size = new System.Drawing.Size(445, 35);
            this.kratenkatxtBase.TabIndex = 1;
            // 
            // frmValutiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 241);
            this.Controls.Add(this.tblValutiBindingNavigator);
            this.Name = "frmValutiEdit";
            this.Text = "Валути";
            this.Load += new System.EventHandler(this.frmtblValutiEdit_Load);
            this.Click += new System.EventHandler(this.frmtblValutiEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblValutiBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingNavigator)).EndInit();
            this.tblValutiBindingNavigator.ResumeLayout(false);
            this.tblValutiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblValutiBindingSource;
        private BSSSDatasetTableAdapters.tblValutiTableAdapter tblValutiTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblValutiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblValutiBindingNavigatorSaveItem;
        private BssBase.txtBase opistxtBase;
        private BssBase.txtBase kratenkatxtBase;
    }
}
namespace BSSR.Forms {
	partial class frmObjektiEdit {
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label sifraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjektiEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblObjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblObjektiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblObjektiTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblObjektiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblObjektiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivtxtBase = new BssBase.txtBase();
            this.sifratxtBase = new BssBase.txtBase();
            nazivLabel = new System.Windows.Forms.Label();
            sifraLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjektiBindingNavigator)).BeginInit();
            this.tblObjektiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(615, 200);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(607, 174);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(sifraLabel);
            this.groupVnes.Controls.Add(this.sifratxtBase);
            this.groupVnes.Size = new System.Drawing.Size(604, 171);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(4, 200);
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
            this.btnOk.Location = new System.Drawing.Point(428, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(33, 87);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Назив:";
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.Location = new System.Drawing.Point(24, 41);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(99, 29);
            sifraLabel.TabIndex = 2;
            sifraLabel.Text = "Шифра:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblObjektiBindingSource
            // 
            this.tblObjektiBindingSource.DataMember = "tblObjekti";
            this.tblObjektiBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblObjektiTableAdapter
            // 
            this.tblObjektiTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = this.tblObjektiTableAdapter;
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
            // tblObjektiBindingNavigator
            // 
            this.tblObjektiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblObjektiBindingNavigator.BindingSource = this.tblObjektiBindingSource;
            this.tblObjektiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblObjektiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblObjektiBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblObjektiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblObjektiBindingNavigatorSaveItem});
            this.tblObjektiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblObjektiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblObjektiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblObjektiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblObjektiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblObjektiBindingNavigator.Name = "tblObjektiBindingNavigator";
            this.tblObjektiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblObjektiBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblObjektiBindingNavigator.TabIndex = 6;
            this.tblObjektiBindingNavigator.Text = "bindingNavigator1";
            this.tblObjektiBindingNavigator.Visible = false;
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
            // tblObjektiBindingNavigatorSaveItem
            // 
            this.tblObjektiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblObjektiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblObjektiBindingNavigatorSaveItem.Image")));
            this.tblObjektiBindingNavigatorSaveItem.Name = "tblObjektiBindingNavigatorSaveItem";
            this.tblObjektiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblObjektiBindingNavigatorSaveItem.Text = "Save Data";
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblObjektiBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.Location = new System.Drawing.Point(129, 84);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(456, 35);
            this.nazivtxtBase.TabIndex = 1;
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
            this.sifratxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblObjektiBindingSource, "Sifra", true));
            this.sifratxtBase.Format = null;
            this.sifratxtBase.formToOpen = null;
            this.sifratxtBase.Location = new System.Drawing.Point(129, 38);
            this.sifratxtBase.MakedonskiJazik = false;
            this.sifratxtBase.MinLength = 0;
            this.sifratxtBase.Name = "sifratxtBase";
            this.sifratxtBase.PopulateOtherFields = false;
            this.sifratxtBase.regularExpression = null;
            this.sifratxtBase.SelektrijaNaFokus = false;
            this.sifratxtBase.Size = new System.Drawing.Size(110, 35);
            this.sifratxtBase.TabIndex = 0;
            // 
            // frmObjektiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 264);
            this.Controls.Add(this.tblObjektiBindingNavigator);
            this.Name = "frmObjektiEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblObjektiEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblObjektiBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjektiBindingNavigator)).EndInit();
            this.tblObjektiBindingNavigator.ResumeLayout(false);
            this.tblObjektiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblObjektiBindingSource;
		private BSSSDatasetTableAdapters.tblObjektiTableAdapter tblObjektiTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblObjektiBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblObjektiBindingNavigatorSaveItem;
		private BssBase.txtBase nazivtxtBase;
		private BssBase.txtBase sifratxtBase;
	}
}
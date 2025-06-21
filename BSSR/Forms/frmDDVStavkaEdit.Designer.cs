namespace BSSR.Forms {
	partial class frmDDVStavkaEdit {
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label procentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDDVStavkaEdit));
            System.Windows.Forms.Label grupaLabel;
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblDDVStavkaBindingSource = new System.Windows.Forms.BindingSource();
            this.tblDDVStavkaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblDDVStavkaTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblDDVStavkaBindingNavigator = new System.Windows.Forms.BindingNavigator();
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
            this.tblDDVStavkaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivtxtBase = new BssBase.txtBase();
            this.procentTextBox = new BssBase.txtBase();
            this.grupaTextBox = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            procentLabel = new System.Windows.Forms.Label();
            grupaLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVStavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVStavkaBindingNavigator)).BeginInit();
            this.tblDDVStavkaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(605, 212);
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(597, 186);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(grupaLabel);
            this.groupVnes.Controls.Add(this.grupaTextBox);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(procentLabel);
            this.groupVnes.Controls.Add(this.procentTextBox);
            this.groupVnes.Size = new System.Drawing.Size(594, 183);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 211);
            this.PanelFooter.Size = new System.Drawing.Size(609, 69);
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
            this.btnOk.Location = new System.Drawing.Point(418, 5);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(82, 35);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Назив:";
            // 
            // procentLabel
            // 
            procentLabel.AutoSize = true;
            procentLabel.Location = new System.Drawing.Point(52, 76);
            procentLabel.Name = "procentLabel";
            procentLabel.Size = new System.Drawing.Size(120, 29);
            procentLabel.TabIndex = 2;
            procentLabel.Text = "Процент:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDDVStavkaBindingSource
            // 
            this.tblDDVStavkaBindingSource.DataMember = "tblDDVStavka";
            this.tblDDVStavkaBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblDDVStavkaTableAdapter
            // 
            this.tblDDVStavkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblConfigTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = this.tblDDVStavkaTableAdapter;
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
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblDDVStavkaBindingNavigator
            // 
            this.tblDDVStavkaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDDVStavkaBindingNavigator.BindingSource = this.tblDDVStavkaBindingSource;
            this.tblDDVStavkaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDDVStavkaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDDVStavkaBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblDDVStavkaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDDVStavkaBindingNavigatorSaveItem});
            this.tblDDVStavkaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDDVStavkaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDDVStavkaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDDVStavkaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDDVStavkaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDDVStavkaBindingNavigator.Name = "tblDDVStavkaBindingNavigator";
            this.tblDDVStavkaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDDVStavkaBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblDDVStavkaBindingNavigator.TabIndex = 6;
            this.tblDDVStavkaBindingNavigator.Text = "bindingNavigator1";
            this.tblDDVStavkaBindingNavigator.Visible = false;
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
            // tblDDVStavkaBindingNavigatorSaveItem
            // 
            this.tblDDVStavkaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDDVStavkaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDDVStavkaBindingNavigatorSaveItem.Image")));
            this.tblDDVStavkaBindingNavigatorSaveItem.Name = "tblDDVStavkaBindingNavigatorSaveItem";
            this.tblDDVStavkaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblDDVStavkaBindingNavigatorSaveItem.Text = "Save Data";
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDDVStavkaBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.iscistiGreenNaLeave = false;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(178, 32);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(346, 35);
            this.nazivtxtBase.TabIndex = 1;
            // 
            // procentTextBox
            // 
            this.procentTextBox.AssemblyStr = null;
            this.procentTextBox.C_FillWithZeros = false;
            this.procentTextBox.C_OnlyNumbers = false;
            this.procentTextBox.C_RegEx = false;
            this.procentTextBox.C_ShowRedOnLeaveIfEmpty = false;
            this.procentTextBox.ColumnName1 = null;
            this.procentTextBox.ColumnName2 = null;
            this.procentTextBox.ColumnName3 = null;
            this.procentTextBox.ColumnName4 = null;
            this.procentTextBox.ColumnName5 = null;
            this.procentTextBox.ColumnName6 = null;
            this.procentTextBox.ColumnName7 = null;
            this.procentTextBox.daliCetiri = false;
            this.procentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDDVStavkaBindingSource, "Procent", true));
            this.procentTextBox.Format = null;
            this.procentTextBox.formToOpen = null;
            this.procentTextBox.iscistiGreenNaLeave = false;
            this.procentTextBox.KoristiFilterNaDatasource = false;
            this.procentTextBox.Location = new System.Drawing.Point(178, 73);
            this.procentTextBox.MakedonskiJazik = false;
            this.procentTextBox.MinLength = 0;
            this.procentTextBox.Name = "procentTextBox";
            this.procentTextBox.PopulateOtherFields = false;
            this.procentTextBox.regularExpression = null;
            this.procentTextBox.SelektrijaNaFokus = false;
            this.procentTextBox.Size = new System.Drawing.Size(346, 35);
            this.procentTextBox.TabIndex = 3;
            // 
            // grupaLabel
            // 
            grupaLabel.AutoSize = true;
            grupaLabel.Location = new System.Drawing.Point(32, 117);
            grupaLabel.Name = "grupaLabel";
            grupaLabel.Size = new System.Drawing.Size(140, 29);
            grupaLabel.TabIndex = 4;
            grupaLabel.Text = "ДДВ Група:";
            // 
            // grupaTextBox
            // 
            this.grupaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDDVStavkaBindingSource, "Grupa", true));
            this.grupaTextBox.Location = new System.Drawing.Point(178, 114);
            this.grupaTextBox.Name = "grupaTextBox";
            this.grupaTextBox.Size = new System.Drawing.Size(346, 35);
            this.grupaTextBox.TabIndex = 5;
            // 
            // frmDDVStavkaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 280);
            this.Controls.Add(this.tblDDVStavkaBindingNavigator);
            this.Name = "frmDDVStavkaEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblDDVStavkaEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblDDVStavkaBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVStavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVStavkaBindingNavigator)).EndInit();
            this.tblDDVStavkaBindingNavigator.ResumeLayout(false);
            this.tblDDVStavkaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblDDVStavkaBindingSource;
		private BSSSDatasetTableAdapters.tblDDVStavkaTableAdapter tblDDVStavkaTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblDDVStavkaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblDDVStavkaBindingNavigatorSaveItem;
		private BssBase.txtBase nazivtxtBase;
		private BssBase.txtBase procentTextBox;
        private System.Windows.Forms.TextBox grupaTextBox;
	}
}
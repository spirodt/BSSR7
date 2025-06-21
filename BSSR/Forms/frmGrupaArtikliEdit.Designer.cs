namespace BSSR.Forms {
	partial class frmGrupaArtikliEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupaArtikliEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblGrupaNaArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGrupaNaArtikliTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblGrupaNaArtikliBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblGrupaNaArtikliBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivtxtBase = new BssBase.txtBase();
            this.sifratxtBase = new BssBase.txtBase();
            this.Zafaktura = new System.Windows.Forms.CheckBox();
            this.btnPrikaci1 = new BssBase.Elements.btnPrikaci();
            nazivLabel = new System.Windows.Forms.Label();
            sifraLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupaNaArtikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupaNaArtikliBindingNavigator)).BeginInit();
            this.tblGrupaNaArtikliBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(772, 200);
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.Size = new System.Drawing.Size(764, 174);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.Zafaktura);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(sifraLabel);
            this.groupVnes.Controls.Add(this.sifratxtBase);
            this.groupVnes.Size = new System.Drawing.Size(757, 163);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.btnPrikaci1);
            this.PanelFooter.Location = new System.Drawing.Point(0, 199);
            this.PanelFooter.Size = new System.Drawing.Size(776, 69);
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
            this.btnOk.Location = new System.Drawing.Point(585, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(44, 86);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Назив:";
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.Location = new System.Drawing.Point(35, 45);
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
            // tblGrupaNaArtikliBindingSource
            // 
            this.tblGrupaNaArtikliBindingSource.DataMember = "tblGrupaNaArtikli";
            this.tblGrupaNaArtikliBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblGrupaNaArtikliTableAdapter
            // 
            this.tblGrupaNaArtikliTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = this.tblGrupaNaArtikliTableAdapter;
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
            // tblGrupaNaArtikliBindingNavigator
            // 
            this.tblGrupaNaArtikliBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblGrupaNaArtikliBindingNavigator.BindingSource = this.tblGrupaNaArtikliBindingSource;
            this.tblGrupaNaArtikliBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblGrupaNaArtikliBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblGrupaNaArtikliBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblGrupaNaArtikliBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblGrupaNaArtikliBindingNavigatorSaveItem});
            this.tblGrupaNaArtikliBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblGrupaNaArtikliBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblGrupaNaArtikliBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblGrupaNaArtikliBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblGrupaNaArtikliBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblGrupaNaArtikliBindingNavigator.Name = "tblGrupaNaArtikliBindingNavigator";
            this.tblGrupaNaArtikliBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblGrupaNaArtikliBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblGrupaNaArtikliBindingNavigator.TabIndex = 6;
            this.tblGrupaNaArtikliBindingNavigator.Text = "bindingNavigator1";
            this.tblGrupaNaArtikliBindingNavigator.Visible = false;
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
            // tblGrupaNaArtikliBindingNavigatorSaveItem
            // 
            this.tblGrupaNaArtikliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblGrupaNaArtikliBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblGrupaNaArtikliBindingNavigatorSaveItem.Image")));
            this.tblGrupaNaArtikliBindingNavigatorSaveItem.Name = "tblGrupaNaArtikliBindingNavigatorSaveItem";
            this.tblGrupaNaArtikliBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblGrupaNaArtikliBindingNavigatorSaveItem.Text = "Save Data";
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblGrupaNaArtikliBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(140, 83);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.prikaziKeyBoard = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(611, 35);
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
            this.sifratxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblGrupaNaArtikliBindingSource, "Sifra", true));
            this.sifratxtBase.Format = null;
            this.sifratxtBase.formToOpen = null;
            this.sifratxtBase.KoristiFilterNaDatasource = false;
            this.sifratxtBase.Location = new System.Drawing.Point(140, 42);
            this.sifratxtBase.MakedonskiJazik = false;
            this.sifratxtBase.MinLength = 0;
            this.sifratxtBase.Name = "sifratxtBase";
            this.sifratxtBase.PopulateOtherFields = false;
            this.sifratxtBase.prikaziKeyBoard = false;
            this.sifratxtBase.regularExpression = null;
            this.sifratxtBase.SelektrijaNaFokus = false;
            this.sifratxtBase.Size = new System.Drawing.Size(110, 35);
            this.sifratxtBase.TabIndex = 0;
            // 
            // Zafaktura
            // 
            this.Zafaktura.AutoSize = true;
            this.Zafaktura.Location = new System.Drawing.Point(140, 124);
            this.Zafaktura.Name = "Zafaktura";
            this.Zafaktura.Size = new System.Drawing.Size(159, 33);
            this.Zafaktura.TabIndex = 2;
            this.Zafaktura.Text = "За фактура";
            this.Zafaktura.UseVisualStyleBackColor = true;
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
            this.btnPrikaci1.Location = new System.Drawing.Point(398, 5);
            this.btnPrikaci1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPrikaci1.Name = "btnPrikaci1";
            this.btnPrikaci1.Size = new System.Drawing.Size(181, 54);
            this.btnPrikaci1.TabIndex = 10;
            this.btnPrikaci1.Text = "Прикачи слика";
            this.btnPrikaci1.UseVisualStyleBackColor = false;
            this.btnPrikaci1.Click += new System.EventHandler(this.btnPrikaci1_Click);
            // 
            // frmGrupaArtikliEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 268);
            this.Controls.Add(this.tblGrupaNaArtikliBindingNavigator);
            this.Name = "frmGrupaArtikliEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblGrupaNaArtikliEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblGrupaNaArtikliBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupaNaArtikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupaNaArtikliBindingNavigator)).EndInit();
            this.tblGrupaNaArtikliBindingNavigator.ResumeLayout(false);
            this.tblGrupaNaArtikliBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblGrupaNaArtikliBindingSource;
		private BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter tblGrupaNaArtikliTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblGrupaNaArtikliBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblGrupaNaArtikliBindingNavigatorSaveItem;
		private BssBase.txtBase nazivtxtBase;
		private BssBase.txtBase sifratxtBase;
        private System.Windows.Forms.CheckBox Zafaktura;
        private BssBase.Elements.btnPrikaci btnPrikaci1;
	}
}
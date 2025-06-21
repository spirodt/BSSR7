namespace BSSR.Forms {
	partial class frmPodgrupiEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPodgrupiEdit));
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblPodgrupaIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPodgrupaIDTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblGrupaNaArtikliTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter();
            this.tblPodgrupaIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblPodgrupaIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cmbgrupa = new BssBase.cmbBase();
            this.tblGrupaNaArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nazivtxtBase = new BssBase.txtBase();
            this.Zafaktura = new System.Windows.Forms.CheckBox();
            this.btnPrikaci1 = new BssBase.Elements.btnPrikaci();
            nazivLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodgrupaIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodgrupaIDBindingNavigator)).BeginInit();
            this.tblPodgrupaIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupaNaArtikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(818, 181);
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(810, 155);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.Zafaktura);
            this.groupVnes.Controls.Add(this.nazivtxtBase);
            this.groupVnes.Controls.Add(this.label1);
            this.groupVnes.Controls.Add(this.cmbgrupa);
            this.groupVnes.Controls.Add(nazivLabel);
            this.groupVnes.Size = new System.Drawing.Size(807, 152);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.btnPrikaci1);
            this.PanelFooter.Location = new System.Drawing.Point(0, 180);
            this.PanelFooter.Size = new System.Drawing.Size(822, 69);
            this.PanelFooter.Controls.SetChildIndex(this.btnZatvori, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnOk, 0);
            this.PanelFooter.Controls.SetChildIndex(this.btnPrikaci1, 0);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 5);
            this.btnZatvori.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(631, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(5, 76);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(90, 29);
            nazivLabel.TabIndex = 2;
            nazivLabel.Text = "Назив:";
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = this.tblPodgrupaIDTableAdapter;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblGrupaNaArtikliTableAdapter
            // 
            this.tblGrupaNaArtikliTableAdapter.ClearBeforeFill = true;
            // 
            // tblPodgrupaIDBindingNavigator
            // 
            this.tblPodgrupaIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPodgrupaIDBindingNavigator.BindingSource = this.tblPodgrupaIDBindingSource;
            this.tblPodgrupaIDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPodgrupaIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPodgrupaIDBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPodgrupaIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblPodgrupaIDBindingNavigatorSaveItem});
            this.tblPodgrupaIDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPodgrupaIDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPodgrupaIDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPodgrupaIDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPodgrupaIDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPodgrupaIDBindingNavigator.Name = "tblPodgrupaIDBindingNavigator";
            this.tblPodgrupaIDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPodgrupaIDBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.tblPodgrupaIDBindingNavigator.TabIndex = 6;
            this.tblPodgrupaIDBindingNavigator.Text = "bindingNavigator1";
            this.tblPodgrupaIDBindingNavigator.Visible = false;
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
            // tblPodgrupaIDBindingNavigatorSaveItem
            // 
            this.tblPodgrupaIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPodgrupaIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPodgrupaIDBindingNavigatorSaveItem.Image")));
            this.tblPodgrupaIDBindingNavigatorSaveItem.Name = "tblPodgrupaIDBindingNavigatorSaveItem";
            this.tblPodgrupaIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblPodgrupaIDBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cmbgrupa
            // 
            this.cmbgrupa.C_OnlyNumbers = false;
            this.cmbgrupa.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbgrupa.CurrentText = null;
            this.cmbgrupa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblPodgrupaIDBindingSource, "GrupaID", true));
            this.cmbgrupa.DataSource = this.tblGrupaNaArtikliBindingSource;
            this.cmbgrupa.DisplayMember = "Naziv";
            this.cmbgrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrupa.DtTableName = null;
            this.cmbgrupa.FormattingEnabled = true;
            this.cmbgrupa.Location = new System.Drawing.Point(101, 30);
            this.cmbgrupa.Name = "cmbgrupa";
            this.cmbgrupa.Size = new System.Drawing.Size(700, 37);
            this.cmbgrupa.TabIndex = 0;
            this.cmbgrupa.value = null;
            this.cmbgrupa.ValueMember = "ID";
            // 
            // tblGrupaNaArtikliBindingSource
            // 
            this.tblGrupaNaArtikliBindingSource.DataMember = "tblGrupaNaArtikli";
            this.tblGrupaNaArtikliBindingSource.DataSource = this.bSSSDataset;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Група:";
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
            this.nazivtxtBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPodgrupaIDBindingSource, "Naziv", true));
            this.nazivtxtBase.Format = null;
            this.nazivtxtBase.formToOpen = null;
            this.nazivtxtBase.KoristiFilterNaDatasource = false;
            this.nazivtxtBase.Location = new System.Drawing.Point(101, 73);
            this.nazivtxtBase.MakedonskiJazik = false;
            this.nazivtxtBase.MinLength = 0;
            this.nazivtxtBase.Name = "nazivtxtBase";
            this.nazivtxtBase.PopulateOtherFields = false;
            this.nazivtxtBase.prikaziKeyBoard = false;
            this.nazivtxtBase.regularExpression = null;
            this.nazivtxtBase.SelektrijaNaFokus = false;
            this.nazivtxtBase.Size = new System.Drawing.Size(700, 35);
            this.nazivtxtBase.TabIndex = 1;
            // 
            // Zafaktura
            // 
            this.Zafaktura.AutoSize = true;
            this.Zafaktura.Location = new System.Drawing.Point(101, 114);
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
            this.btnPrikaci1.Location = new System.Drawing.Point(444, 5);
            this.btnPrikaci1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPrikaci1.Name = "btnPrikaci1";
            this.btnPrikaci1.Size = new System.Drawing.Size(181, 54);
            this.btnPrikaci1.TabIndex = 1;
            this.btnPrikaci1.Text = "Прикачи слика";
            this.btnPrikaci1.UseVisualStyleBackColor = false;
            this.btnPrikaci1.Click += new System.EventHandler(this.btnPrikaci1_Click);
            // 
            // frmPodgrupiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 249);
            this.Controls.Add(this.tblPodgrupaIDBindingNavigator);
            this.Name = "frmPodgrupiEdit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtblPodgrupaIDEdit_Load);
            this.Controls.SetChildIndex(this.PanelFooter, 0);
            this.Controls.SetChildIndex(this.MainTab, 0);
            this.Controls.SetChildIndex(this.tblPodgrupaIDBindingNavigator, 0);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodgrupaIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodgrupaIDBindingNavigator)).EndInit();
            this.tblPodgrupaIDBindingNavigator.ResumeLayout(false);
            this.tblPodgrupaIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupaNaArtikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblPodgrupaIDBindingSource;
		private BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter tblPodgrupaIDTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblPodgrupaIDBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblPodgrupaIDBindingNavigatorSaveItem;
		private BssBase.cmbBase cmbgrupa;
		private BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter tblGrupaNaArtikliTableAdapter;
		private System.Windows.Forms.BindingSource tblGrupaNaArtikliBindingSource;
		private System.Windows.Forms.Label label1;
		private BssBase.txtBase nazivtxtBase;
        private System.Windows.Forms.CheckBox Zafaktura;
        private BssBase.Elements.btnPrikaci btnPrikaci1;
	}
}
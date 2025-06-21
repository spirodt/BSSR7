namespace MFakturi.Forms {
	partial class frmZiroSmetkiEdit {
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
			System.Windows.Forms.Label ziroSmetkaLabel;
			System.Windows.Forms.Label tblBankaIDLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmZiroSmetkiEdit ) );
			this.fakturiDataSet = new MFakturi.FakturiDataSet();
			this.tblZiroSmetkiBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblZiroSmetkiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblZiroSmetkiTableAdapter();
			this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
			this.tblZiroSmetkiBindingNavigator = new System.Windows.Forms.BindingNavigator( this.components );
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
			this.tblZiroSmetkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.ziroSmetkatxtBase = new BssBase.txtBase();
			this.tblBankaIDcmbBase = new BssBase.cmbBase();
			this.tblBankiBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblBankiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblBankiTableAdapter();
			this.bsslabel1 = new BssBase.Elements.Bsslabel();
			this.zbxPartner = new BssBase.zbxBase();
			this.txtPartner = new BssBase.txtBase();
			ziroSmetkaLabel = new System.Windows.Forms.Label();
			tblBankaIDLabel = new System.Windows.Forms.Label();
			this.MainTab.SuspendLayout();
			this.tabVnes.SuspendLayout();
			this.groupVnes.SuspendLayout();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblZiroSmetkiBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblZiroSmetkiBindingNavigator ) ).BeginInit();
			this.tblZiroSmetkiBindingNavigator.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingSource ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainTab
			// 
			this.MainTab.Size = new System.Drawing.Size( 628, 259 );
			// 
			// tabVnes
			// 
			this.tabVnes.AutoScroll = true;
			this.tabVnes.Size = new System.Drawing.Size( 620, 233 );
			// 
			// groupVnes
			// 
			this.groupVnes.Controls.Add( this.txtPartner );
			this.groupVnes.Controls.Add( this.bsslabel1 );
			this.groupVnes.Controls.Add( this.zbxPartner );
			this.groupVnes.Controls.Add( tblBankaIDLabel );
			this.groupVnes.Controls.Add( this.tblBankaIDcmbBase );
			this.groupVnes.Controls.Add( ziroSmetkaLabel );
			this.groupVnes.Controls.Add( this.ziroSmetkatxtBase );
			this.groupVnes.Size = new System.Drawing.Size( 617, 230 );
			// 
			// PanelFooter
			// 
			this.PanelFooter.Location = new System.Drawing.Point( 0, 258 );
			this.PanelFooter.Size = new System.Drawing.Size( 632, 69 );
			// 
			// btnZatvori
			// 
			this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			this.btnZatvori.Location = new System.Drawing.Point( 6, 5 );
			this.btnZatvori.TabIndex = 1;
			// 
			// btnOk
			// 
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			this.btnOk.Location = new System.Drawing.Point( 437, 5 );
			this.btnOk.TabIndex = 0;
			this.btnOk.Click += new System.EventHandler( this.btnOk_Click );
			// 
			// ziroSmetkaLabel
			// 
			ziroSmetkaLabel.AutoSize = true;
			ziroSmetkaLabel.Location = new System.Drawing.Point( 6, 181 );
			ziroSmetkaLabel.Name = "ziroSmetkaLabel";
			ziroSmetkaLabel.Size = new System.Drawing.Size( 170, 29 );
			ziroSmetkaLabel.TabIndex = 0;
			ziroSmetkaLabel.Text = "Жиро сметка:";
			// 
			// tblBankaIDLabel
			// 
			tblBankaIDLabel.AutoSize = true;
			tblBankaIDLabel.Location = new System.Drawing.Point( 89, 138 );
			tblBankaIDLabel.Name = "tblBankaIDLabel";
			tblBankaIDLabel.Size = new System.Drawing.Size( 87, 29 );
			tblBankaIDLabel.TabIndex = 2;
			tblBankaIDLabel.Text = "Банка:";
			// 
			// fakturiDataSet
			// 
			this.fakturiDataSet.DataSetName = "FakturiDataSet";
			this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblZiroSmetkiBindingSource
			// 
			this.tblZiroSmetkiBindingSource.DataMember = "tblZiroSmetki";
			this.tblZiroSmetkiBindingSource.DataSource = this.fakturiDataSet;
			// 
			// tblZiroSmetkiTableAdapter
			// 
			this.tblZiroSmetkiTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.tblBankiTableAdapter = null;
			this.tableAdapterManager.tblPartneriTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = null;
			this.tableAdapterManager.tblZiroSmetkiTableAdapter = this.tblZiroSmetkiTableAdapter;
			this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.viewZiroSmetkeTableAdapter = null;
			// 
			// tblZiroSmetkiBindingNavigator
			// 
			this.tblZiroSmetkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tblZiroSmetkiBindingNavigator.BindingSource = this.tblZiroSmetkiBindingSource;
			this.tblZiroSmetkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tblZiroSmetkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tblZiroSmetkiBindingNavigator.Font = new System.Drawing.Font( "Segoe UI", 9F );
			this.tblZiroSmetkiBindingNavigator.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
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
            this.tblZiroSmetkiBindingNavigatorSaveItem} );
			this.tblZiroSmetkiBindingNavigator.Location = new System.Drawing.Point( 0, 0 );
			this.tblZiroSmetkiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tblZiroSmetkiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tblZiroSmetkiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tblZiroSmetkiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tblZiroSmetkiBindingNavigator.Name = "tblZiroSmetkiBindingNavigator";
			this.tblZiroSmetkiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tblZiroSmetkiBindingNavigator.Size = new System.Drawing.Size( 632, 25 );
			this.tblZiroSmetkiBindingNavigator.TabIndex = 6;
			this.tblZiroSmetkiBindingNavigator.Text = "bindingNavigator1";
			this.tblZiroSmetkiBindingNavigator.Visible = false;
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "bindingNavigatorAddNewItem.Image" ) ) );
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size( 23, 22 );
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size( 35, 22 );
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "bindingNavigatorDeleteItem.Image" ) ) );
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size( 23, 22 );
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "bindingNavigatorMoveFirstItem.Image" ) ) );
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size( 23, 22 );
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "bindingNavigatorMovePreviousItem.Image" ) ) );
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size( 23, 22 );
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size( 6, 25 );
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size( 50, 23 );
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size( 6, 25 );
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "bindingNavigatorMoveNextItem.Image" ) ) );
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size( 23, 22 );
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "bindingNavigatorMoveLastItem.Image" ) ) );
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size( 23, 22 );
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size( 6, 25 );
			// 
			// tblZiroSmetkiBindingNavigatorSaveItem
			// 
			this.tblZiroSmetkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tblZiroSmetkiBindingNavigatorSaveItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "tblZiroSmetkiBindingNavigatorSaveItem.Image" ) ) );
			this.tblZiroSmetkiBindingNavigatorSaveItem.Name = "tblZiroSmetkiBindingNavigatorSaveItem";
			this.tblZiroSmetkiBindingNavigatorSaveItem.Size = new System.Drawing.Size( 23, 22 );
			this.tblZiroSmetkiBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// ziroSmetkatxtBase
			// 
			this.ziroSmetkatxtBase.AssemblyStr = null;
			this.ziroSmetkatxtBase.C_FillWithZeros = false;
			this.ziroSmetkatxtBase.C_OnlyNumbers = false;
			this.ziroSmetkatxtBase.C_RegEx = false;
			this.ziroSmetkatxtBase.C_ShowRedOnLeaveIfEmpty = false;
			this.ziroSmetkatxtBase.ColumnName1 = null;
			this.ziroSmetkatxtBase.ColumnName2 = null;
			this.ziroSmetkatxtBase.ColumnName3 = null;
			this.ziroSmetkatxtBase.ColumnName4 = null;
			this.ziroSmetkatxtBase.ColumnName5 = null;
			this.ziroSmetkatxtBase.ColumnName6 = null;
			this.ziroSmetkatxtBase.ColumnName7 = null;
			this.ziroSmetkatxtBase.daliCetiri = false;
			this.ziroSmetkatxtBase.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.tblZiroSmetkiBindingSource, "ZiroSmetka", true ) );
			this.ziroSmetkatxtBase.Format = null;
			this.ziroSmetkatxtBase.formToOpen = null;
			this.ziroSmetkatxtBase.Location = new System.Drawing.Point( 179, 178 );
			this.ziroSmetkatxtBase.MakedonskiJazik = false;
			this.ziroSmetkatxtBase.MinLength = 0;
			this.ziroSmetkatxtBase.Name = "ziroSmetkatxtBase";
			this.ziroSmetkatxtBase.PopulateOtherFields = false;
			this.ziroSmetkatxtBase.prikaziKeyBoard = false;
			this.ziroSmetkatxtBase.regularExpression = null;
			this.ziroSmetkatxtBase.SelektrijaNaFokus = false;
			this.ziroSmetkatxtBase.Size = new System.Drawing.Size( 432, 35 );
			this.ziroSmetkatxtBase.TabIndex = 3;
			// 
			// tblBankaIDcmbBase
			// 
			this.tblBankaIDcmbBase.C_OnlyNumbers = false;
			this.tblBankaIDcmbBase.C_ShowRedOnLeaveIfEmpty = false;
			this.tblBankaIDcmbBase.CurrentText = null;
			this.tblBankaIDcmbBase.DataBindings.Add( new System.Windows.Forms.Binding( "SelectedValue", this.tblZiroSmetkiBindingSource, "tblBankaID", true ) );
			this.tblBankaIDcmbBase.DataSource = this.tblBankiBindingSource;
			this.tblBankaIDcmbBase.DisplayMember = "Naziv";
			this.tblBankaIDcmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tblBankaIDcmbBase.DtTableName = null;
			this.tblBankaIDcmbBase.FormattingEnabled = true;
			this.tblBankaIDcmbBase.Location = new System.Drawing.Point( 179, 135 );
			this.tblBankaIDcmbBase.Name = "tblBankaIDcmbBase";
			this.tblBankaIDcmbBase.Size = new System.Drawing.Size( 432, 37 );
			this.tblBankaIDcmbBase.TabIndex = 2;
			this.tblBankaIDcmbBase.value = null;
			this.tblBankaIDcmbBase.ValueMember = "ID";
			// 
			// tblBankiBindingSource
			// 
			this.tblBankiBindingSource.DataMember = "tblBanki";
			this.tblBankiBindingSource.DataSource = this.fakturiDataSet;
			// 
			// tblBankiTableAdapter
			// 
			this.tblBankiTableAdapter.ClearBeforeFill = true;
			// 
			// bsslabel1
			// 
			this.bsslabel1.AutoSize = true;
			this.bsslabel1.Location = new System.Drawing.Point( 58, 31 );
			this.bsslabel1.Name = "bsslabel1";
			this.bsslabel1.Size = new System.Drawing.Size( 118, 29 );
			this.bsslabel1.TabIndex = 5;
			this.bsslabel1.Text = "Партнер:";
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
			this.zbxPartner.filterDataSource = null;
			this.zbxPartner.formToOpen = "MFakturi.Forms.frmPartner";
			this.zbxPartner.GridFromForm = null;
			this.zbxPartner.KoristiFilterNaDatasource = false;
			this.zbxPartner.Location = new System.Drawing.Point( 179, 17 );
			this.zbxPartner.MinimumSize = new System.Drawing.Size( 123, 20 );
			this.zbxPartner.Name = "zbxPartner";
			this.zbxPartner.ovozmoziIzmena = false;
			this.zbxPartner.showRedIfEmpty = false;
			this.zbxPartner.Size = new System.Drawing.Size( 198, 55 );
			this.zbxPartner.TabIndex = 0;
			this.zbxPartner.DataRead += new BssBase.zbxBase.doneLoading( this.zbxPartner_DataRead );
			this.zbxPartner.Validated += new System.EventHandler( this.zbxPartner_Validated );
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
			this.txtPartner.Location = new System.Drawing.Point( 179, 78 );
			this.txtPartner.MakedonskiJazik = false;
			this.txtPartner.MinLength = 0;
			this.txtPartner.Multiline = true;
			this.txtPartner.Name = "txtPartner";
			this.txtPartner.PopulateOtherFields = false;
			this.txtPartner.prikaziKeyBoard = false;
			this.txtPartner.ReadOnly = true;
			this.txtPartner.regularExpression = null;
			this.txtPartner.SelektrijaNaFokus = false;
			this.txtPartner.Size = new System.Drawing.Size( 433, 51 );
			this.txtPartner.TabIndex = 1;
			// 
			// frmZiroSmetkiEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 632, 327 );
			this.Controls.Add( this.tblZiroSmetkiBindingNavigator );
			this.Name = "frmZiroSmetkiEdit";
			this.Text = " ";
			this.Load += new System.EventHandler( this.frmtblZiroSmetkiEdit_Load );
			this.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.Controls.SetChildIndex( this.MainTab, 0 );
			this.Controls.SetChildIndex( this.tblZiroSmetkiBindingNavigator, 0 );
			this.MainTab.ResumeLayout( false );
			this.tabVnes.ResumeLayout( false );
			this.groupVnes.ResumeLayout( false );
			this.groupVnes.PerformLayout();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblZiroSmetkiBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblZiroSmetkiBindingNavigator ) ).EndInit();
			this.tblZiroSmetkiBindingNavigator.ResumeLayout( false );
			this.tblZiroSmetkiBindingNavigator.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingSource ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource tblZiroSmetkiBindingSource;
		private FakturiDataSetTableAdapters.tblZiroSmetkiTableAdapter tblZiroSmetkiTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblZiroSmetkiBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblZiroSmetkiBindingNavigatorSaveItem;
		private BssBase.cmbBase tblBankaIDcmbBase;
		private BssBase.txtBase ziroSmetkatxtBase;
		private System.Windows.Forms.BindingSource tblBankiBindingSource;
		private FakturiDataSetTableAdapters.tblBankiTableAdapter tblBankiTableAdapter;
		private BssBase.Elements.Bsslabel bsslabel1;
		private BssBase.zbxBase zbxPartner;
		private BssBase.txtBase txtPartner;

	}
}
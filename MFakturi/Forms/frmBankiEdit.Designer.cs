namespace MFakturi.Forms {
	partial class frmBankiEdit {
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
			System.Windows.Forms.Label sifraLabel;
			System.Windows.Forms.Label nazivLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmBankiEdit ) );
			this.fakturiDataSet = new MFakturi.FakturiDataSet();
			this.tblBankiBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblBankiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblBankiTableAdapter();
			this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
			this.tblBankiBindingNavigator = new System.Windows.Forms.BindingNavigator( this.components );
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
			this.tblBankiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.sifratxtBase = new BssBase.txtBase();
			this.nazivtxtBase = new BssBase.txtBase();
			sifraLabel = new System.Windows.Forms.Label();
			nazivLabel = new System.Windows.Forms.Label();
			this.MainTab.SuspendLayout();
			this.tabVnes.SuspendLayout();
			this.groupVnes.SuspendLayout();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingNavigator ) ).BeginInit();
			this.tblBankiBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTab
			// 
			this.MainTab.Size = new System.Drawing.Size( 743, 314 );
			// 
			// tabVnes
			// 
			this.tabVnes.AutoScroll = true;
			this.tabVnes.Size = new System.Drawing.Size( 735, 288 );
			// 
			// groupVnes
			// 
			this.groupVnes.Controls.Add( nazivLabel );
			this.groupVnes.Controls.Add( this.nazivtxtBase );
			this.groupVnes.Controls.Add( sifraLabel );
			this.groupVnes.Controls.Add( this.sifratxtBase );
			this.groupVnes.Size = new System.Drawing.Size( 732, 285 );
			// 
			// PanelFooter
			// 
			this.PanelFooter.Location = new System.Drawing.Point( 0, 313 );
			this.PanelFooter.Size = new System.Drawing.Size( 747, 69 );
			// 
			// btnZatvori
			// 
			this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			this.btnZatvori.Location = new System.Drawing.Point( 6, 1 );
			// 
			// btnOk
			// 
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			this.btnOk.Location = new System.Drawing.Point( 552, 1 );
			this.btnOk.TabIndex = 0;
			this.btnOk.Click += new System.EventHandler( this.btnOk_Click );
			// 
			// sifraLabel
			// 
			sifraLabel.AutoSize = true;
			sifraLabel.Location = new System.Drawing.Point( 5, 37 );
			sifraLabel.Name = "sifraLabel";
			sifraLabel.Size = new System.Drawing.Size( 99, 29 );
			sifraLabel.TabIndex = 0;
			sifraLabel.Text = "Шифра:";
			// 
			// nazivLabel
			// 
			nazivLabel.AutoSize = true;
			nazivLabel.Location = new System.Drawing.Point( 14, 78 );
			nazivLabel.Name = "nazivLabel";
			nazivLabel.Size = new System.Drawing.Size( 90, 29 );
			nazivLabel.TabIndex = 2;
			nazivLabel.Text = "Назив:";
			// 
			// fakturiDataSet
			// 
			this.fakturiDataSet.DataSetName = "FakturiDataSet";
			this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.tblBankiTableAdapter = this.tblBankiTableAdapter;
			this.tableAdapterManager.tblPartneriTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = null;
			this.tableAdapterManager.tblZiroSmetkiTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tblBankiBindingNavigator
			// 
			this.tblBankiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tblBankiBindingNavigator.BindingSource = this.tblBankiBindingSource;
			this.tblBankiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tblBankiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tblBankiBindingNavigator.Font = new System.Drawing.Font( "Segoe UI", 9F );
			this.tblBankiBindingNavigator.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
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
            this.tblBankiBindingNavigatorSaveItem} );
			this.tblBankiBindingNavigator.Location = new System.Drawing.Point( 0, 0 );
			this.tblBankiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tblBankiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tblBankiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tblBankiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tblBankiBindingNavigator.Name = "tblBankiBindingNavigator";
			this.tblBankiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tblBankiBindingNavigator.Size = new System.Drawing.Size( 619, 25 );
			this.tblBankiBindingNavigator.TabIndex = 6;
			this.tblBankiBindingNavigator.Text = "bindingNavigator1";
			this.tblBankiBindingNavigator.Visible = false;
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
			// tblBankiBindingNavigatorSaveItem
			// 
			this.tblBankiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tblBankiBindingNavigatorSaveItem.Image = ( ( System.Drawing.Image )( resources.GetObject( "tblBankiBindingNavigatorSaveItem.Image" ) ) );
			this.tblBankiBindingNavigatorSaveItem.Name = "tblBankiBindingNavigatorSaveItem";
			this.tblBankiBindingNavigatorSaveItem.Size = new System.Drawing.Size( 23, 22 );
			this.tblBankiBindingNavigatorSaveItem.Text = "Save Data";
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
			this.sifratxtBase.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.tblBankiBindingSource, "Sifra", true ) );
			this.sifratxtBase.Format = null;
			this.sifratxtBase.formToOpen = null;
			this.sifratxtBase.Location = new System.Drawing.Point( 109, 34 );
			this.sifratxtBase.MakedonskiJazik = false;
			this.sifratxtBase.MinLength = 0;
			this.sifratxtBase.Name = "sifratxtBase";
			this.sifratxtBase.PopulateOtherFields = false;
			this.sifratxtBase.prikaziKeyBoard = false;
			this.sifratxtBase.regularExpression = null;
			this.sifratxtBase.SelektrijaNaFokus = false;
			this.sifratxtBase.Size = new System.Drawing.Size( 122, 35 );
			this.sifratxtBase.TabIndex = 0;
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
			this.nazivtxtBase.DataBindings.Add( new System.Windows.Forms.Binding( "Text", this.tblBankiBindingSource, "Naziv", true ) );
			this.nazivtxtBase.Format = null;
			this.nazivtxtBase.formToOpen = null;
			this.nazivtxtBase.Location = new System.Drawing.Point( 109, 75 );
			this.nazivtxtBase.MakedonskiJazik = false;
			this.nazivtxtBase.MinLength = 0;
			this.nazivtxtBase.Multiline = true;
			this.nazivtxtBase.Name = "nazivtxtBase";
			this.nazivtxtBase.PopulateOtherFields = false;
			this.nazivtxtBase.prikaziKeyBoard = false;
			this.nazivtxtBase.regularExpression = null;
			this.nazivtxtBase.SelektrijaNaFokus = false;
			this.nazivtxtBase.Size = new System.Drawing.Size( 617, 191 );
			this.nazivtxtBase.TabIndex = 1;
			// 
			// frmBankiEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 747, 382 );
			this.Controls.Add( this.tblBankiBindingNavigator );
			this.Name = "frmBankiEdit";
			this.Text = " ";
			this.Load += new System.EventHandler( this.frmtblBankiEdit_Load );
			this.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.Controls.SetChildIndex( this.MainTab, 0 );
			this.Controls.SetChildIndex( this.tblBankiBindingNavigator, 0 );
			this.MainTab.ResumeLayout( false );
			this.tabVnes.ResumeLayout( false );
			this.groupVnes.ResumeLayout( false );
			this.groupVnes.PerformLayout();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingNavigator ) ).EndInit();
			this.tblBankiBindingNavigator.ResumeLayout( false );
			this.tblBankiBindingNavigator.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource tblBankiBindingSource;
		private FakturiDataSetTableAdapters.tblBankiTableAdapter tblBankiTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tblBankiBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tblBankiBindingNavigatorSaveItem;
		private BssBase.txtBase sifratxtBase;
		private BssBase.txtBase nazivtxtBase;
	}
}
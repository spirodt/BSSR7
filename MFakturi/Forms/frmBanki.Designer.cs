namespace MFakturi.Forms {
	partial class frmBanki {
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
			this.fakturiDataSet = new MFakturi.FakturiDataSet();
			this.tblBankiBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblBankiTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblBankiTableAdapter();
			this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
			this.tblBankiGridBig = new BssBase.GridBig();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblBankiGridBig );
			this.MainPanel.Size = new System.Drawing.Size( 998, 574 );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblBankiGridBig, 0 );
			// 
			// btnPrebaraj
			// 
			this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			// 
			// btnIcistiBaraj
			// 
			this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			// 
			// btnOk
			// 
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			// 
			// btnZatvori
			// 
			this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			// 
			// PanelFooter
			// 
			this.PanelFooter.Location = new System.Drawing.Point( 0, 498 );
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
			// tblBankiGridBig
			// 
			this.tblBankiGridBig.AllowUserToAddRows = false;
			this.tblBankiGridBig.AllowUserToDeleteRows = false;
			this.tblBankiGridBig.AllowUserToOrderColumns = true;
			this.tblBankiGridBig.AssemblyToLoad = "MFakturi";
			this.tblBankiGridBig.AutoGenerateColumns = false;
			this.tblBankiGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblBankiGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sifra,
            this.Naziv,
            this.Status} );
			this.tblBankiGridBig.DataSource = this.tblBankiBindingSource;
			this.tblBankiGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblBankiGridBig.EditForm = "MFakturi.Forms.frmBankiEdit";
			this.tblBankiGridBig.FilterForm = null;
			this.tblBankiGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblBankiGridBig.MultiSelect = false;
			this.tblBankiGridBig.Name = "tblBankiGridBig";
			this.tblBankiGridBig.PrimaryKey = "ID";
			this.tblBankiGridBig.ReadOnly = true;
			this.tblBankiGridBig.reportCenter = false;
			this.tblBankiGridBig.ReportName = null;
			this.tblBankiGridBig.RowTemplate.Height = 36;
			this.tblBankiGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblBankiGridBig.Size = new System.Drawing.Size( 996, 330 );
			this.tblBankiGridBig.SQLCommandQuery = null;
			this.tblBankiGridBig.TabIndex = 2;
			this.tblBankiGridBig.UpdateTable = null;
			this.tblBankiGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblBankigrdBase_DataInsert );
			this.tblBankiGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblBankigrdBase_dataSaveAll );
			
			this.tblBankiGridBig.DoubleClick += new System.EventHandler( this.tblBankigrdBase_DoubleClick );
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден број";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
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
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// frmBanki
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 574 );
			this.Name = "frmBanki";
			this.Text = "Банки";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblBankiGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource tblBankiBindingSource;
		private FakturiDataSetTableAdapters.tblBankiTableAdapter tblBankiTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblBankiGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}
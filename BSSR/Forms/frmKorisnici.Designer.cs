namespace BSSR.Forms {
	partial class frmKorisnici {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bSSSDataset = new BSSR.BSSSDataset();
			this.tblUsersBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblUsersTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblUsersTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblUsersGridBig = new BssBase.GridBig();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NivoNaAdministracija = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblUsersBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblUsersGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblUsersGridBig );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblUsersGridBig, 0 );
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
			// bSSSDataset
			// 
			this.bSSSDataset.DataSetName = "BSSSDataset";
			this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblUsersBindingSource
			// 
			this.tblUsersBindingSource.DataMember = "tblUsers";
			this.tblUsersBindingSource.DataSource = this.bSSSDataset;
			// 
			// tblUsersTableAdapter
			// 
			this.tblUsersTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.tblObjektiTableAdapter = null;
			this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
			this.tableAdapterManager.tblPrevodiTableAdapter = null;
			this.tableAdapterManager.tblRoljiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaTableAdapter = null;
			this.tableAdapterManager.tblUserConfigsTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
			this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.viewArtikliTableAdapter = null;
			// 
			// tblUsersGridBig
			// 
			this.tblUsersGridBig.AllowUserToAddRows = false;
			this.tblUsersGridBig.AllowUserToDeleteRows = false;
			this.tblUsersGridBig.AllowUserToOrderColumns = true;
			this.tblUsersGridBig.AssemblyToLoad = "BSSR";
			this.tblUsersGridBig.AutoGenerateColumns = false;
			this.tblUsersGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblUsersGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.userNameDataGridViewTextBoxColumn,
            this.FullName,
            this.NivoNaAdministracija,
            this.Status} );
			this.tblUsersGridBig.DataSource = this.tblUsersBindingSource;
			this.tblUsersGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblUsersGridBig.EditForm = "BSSR.Forms.frmKorisniciEdit";
			this.tblUsersGridBig.FilterForm = null;
			this.tblUsersGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblUsersGridBig.Name = "tblUsersGridBig";
			this.tblUsersGridBig.PrimaryKey = "ID";
			this.tblUsersGridBig.ReadOnly = true;
			this.tblUsersGridBig.reportCenter = false;
			this.tblUsersGridBig.ReportName = null;
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.tblUsersGridBig.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.tblUsersGridBig.RowTemplate.Height = 36;
			this.tblUsersGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblUsersGridBig.Size = new System.Drawing.Size( 996, 329 );
			this.tblUsersGridBig.SQLCommandQuery = null;
			this.tblUsersGridBig.TabIndex = 2;
			this.tblUsersGridBig.UpdateTable = null;
			this.tblUsersGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblUsersgrdBase_DataInsert );
			this.tblUsersGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblUsersgrdBase_dataSaveAll );
			this.tblUsersGridBig.DoubleClick += new System.EventHandler( this.tblUsersgrdBase_DoubleClick );
			// 
			// UserName
			// 
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "Кориничко име";
			this.UserName.Name = "UserName";
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден број";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			this.userNameDataGridViewTextBoxColumn.HeaderText = "Корисничко име";
			this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// FullName
			// 
			this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FullName.DataPropertyName = "FullName";
			this.FullName.HeaderText = "Целосно име";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			// 
			// NivoNaAdministracija
			// 
			this.NivoNaAdministracija.DataPropertyName = "NivoNaAdministracija";
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			this.NivoNaAdministracija.DefaultCellStyle = dataGridViewCellStyle1;
			this.NivoNaAdministracija.HeaderText = "Ниво на администрација";
			this.NivoNaAdministracija.Name = "NivoNaAdministracija";
			this.NivoNaAdministracija.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// frmKorisnici
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 573 );
			this.Name = "frmKorisnici";
			this.Text = "Корисници";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblUsersBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblUsersGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblUsersBindingSource;
		private BSSSDatasetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblUsersGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn NivoNaAdministracija;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;


	}
}
namespace BSSR.Forms {
	partial class frmEdinicniMerki {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmEdinicniMerki ) );
			this.bSSSDataset = new BSSR.BSSSDataset();
			this.tblEdinecniMerkiBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblEdinecniMerkiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblEdinecniMerkiTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblEdinecniMerkiGridBig = new BssBase.GridBig();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kratenka = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblEdinecniMerkiBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblEdinecniMerkiGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblEdinecniMerkiGridBig );
			this.MainPanel.Size = new System.Drawing.Size( 998, 578 );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblEdinecniMerkiGridBig, 0 );
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
			this.PanelFooter.Location = new System.Drawing.Point( 0, 502 );
			// 
			// bSSSDataset
			// 
			this.bSSSDataset.DataSetName = "BSSSDataset";
			this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblEdinecniMerkiBindingSource
			// 
			this.tblEdinecniMerkiBindingSource.DataMember = "tblEdinecniMerki";
			this.tblEdinecniMerkiBindingSource.DataSource = this.bSSSDataset;
			this.tblEdinecniMerkiBindingSource.Filter = "";
			// 
			// tblEdinecniMerkiTableAdapter
			// 
			this.tblEdinecniMerkiTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager._tblLogTableAdapter = null;
			this.tableAdapterManager._tblSesijaTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.tblArtikalTableAdapter = null;
			this.tableAdapterManager.tblConfigTableAdapter = null;
			this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
			this.tableAdapterManager.tblEdinecniMerkiTableAdapter = this.tblEdinecniMerkiTableAdapter;
			this.tableAdapterManager.tblFirmaTableAdapter = null;
			this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
			this.tableAdapterManager.tblFormiTableAdapter = null;
			this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
			this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
			this.tableAdapterManager.tblNalogTableAdapter = null;
			this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
			this.tableAdapterManager.tblNormativTableAdapter = null;
			this.tableAdapterManager.tblObjektiTableAdapter = null;
			this.tableAdapterManager.tblPrevodiTableAdapter = null;
			this.tableAdapterManager.tblRoljiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaTableAdapter = null;
			this.tableAdapterManager.tblUserConfigsTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tblEdinecniMerkiGridBig
			// 
			this.tblEdinecniMerkiGridBig.AllowUserToAddRows = false;
			this.tblEdinecniMerkiGridBig.AllowUserToDeleteRows = false;
			this.tblEdinecniMerkiGridBig.AllowUserToOrderColumns = true;
			this.tblEdinecniMerkiGridBig.AssemblyToLoad = "BSSR";
			this.tblEdinecniMerkiGridBig.AutoGenerateColumns = false;
			this.tblEdinecniMerkiGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblEdinecniMerkiGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Kratenka,
            this.Status} );
			this.tblEdinecniMerkiGridBig.DataSource = this.tblEdinecniMerkiBindingSource;
			this.tblEdinecniMerkiGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblEdinecniMerkiGridBig.EditForm = "BSSR.Forms.frmEdinicniMerkiEdit";
			this.tblEdinecniMerkiGridBig.FilterForm = null;
			this.tblEdinecniMerkiGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblEdinecniMerkiGridBig.Name = "tblEdinecniMerkiGridBig";
			this.tblEdinecniMerkiGridBig.PrimaryKey = "ID";
			this.tblEdinecniMerkiGridBig.ReadOnly = true;
			this.tblEdinecniMerkiGridBig.reportCenter = false;
			this.tblEdinecniMerkiGridBig.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.tblEdinecniMerkiGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tblEdinecniMerkiGridBig.RowTemplate.Height = 36;
			this.tblEdinecniMerkiGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblEdinecniMerkiGridBig.Size = new System.Drawing.Size( 996, 334 );
			this.tblEdinecniMerkiGridBig.SQLCommandQuery = null;
			this.tblEdinecniMerkiGridBig.TabIndex = 2;
			this.tblEdinecniMerkiGridBig.UpdateTable = "tblEdinecniMerki";
			this.tblEdinecniMerkiGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblEdinecniMerkigrdBase_DataInsert );
			this.tblEdinecniMerkiGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblEdinecniMerkigrdBase_dataSaveAll );
			this.tblEdinecniMerkiGridBig.DoubleClick += new System.EventHandler( this.tblEdinecniMerkigrdBase_DoubleClick );
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден број";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Назив";
			this.Naziv.MinimumWidth = 100;
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// Kratenka
			// 
			this.Kratenka.DataPropertyName = "Kratenka";
			this.Kratenka.HeaderText = "Кратенка";
			this.Kratenka.Name = "Kratenka";
			this.Kratenka.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// frmEdinicniMerki
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 578 );
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.Name = "frmEdinicniMerki";
			this.Text = "Единечни мерки";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblEdinecniMerkiBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblEdinecniMerkiGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblEdinecniMerkiBindingSource;
		private BSSSDatasetTableAdapters.tblEdinecniMerkiTableAdapter tblEdinecniMerkiTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblEdinecniMerkiGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kratenka;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}
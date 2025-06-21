namespace BSSR.Forms {
	partial class frmPodgrupi {
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
			this.bSSSDataset = new BSSR.BSSSDataset();
			this.tblPodgrupaIDBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblPodgrupaIDTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblPodgrupaIDGridBig = new BssBase.GridBig();
			this.tblGrupaNaArtikliBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblGrupaNaArtikliTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GrupaID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblPodgrupaIDBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblPodgrupaIDGridBig ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblGrupaNaArtikliBindingSource ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblPodgrupaIDGridBig );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblPodgrupaIDGridBig, 0 );
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
			this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
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
			// tblPodgrupaIDGridBig
			// 
			this.tblPodgrupaIDGridBig.AllowUserToAddRows = false;
			this.tblPodgrupaIDGridBig.AllowUserToDeleteRows = false;
			this.tblPodgrupaIDGridBig.AllowUserToOrderColumns = true;
			this.tblPodgrupaIDGridBig.AssemblyToLoad = "BSSR";
			this.tblPodgrupaIDGridBig.AutoGenerateColumns = false;
			this.tblPodgrupaIDGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblPodgrupaIDGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.GrupaID,
            this.Status} );
			this.tblPodgrupaIDGridBig.DataSource = this.tblPodgrupaIDBindingSource;
			this.tblPodgrupaIDGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblPodgrupaIDGridBig.EditForm = "BSSR.Forms.frmPodgrupiEdit";
			this.tblPodgrupaIDGridBig.FilterForm = null;
			this.tblPodgrupaIDGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblPodgrupaIDGridBig.Name = "tblPodgrupaIDGridBig";
			this.tblPodgrupaIDGridBig.PrimaryKey = "ID";
			this.tblPodgrupaIDGridBig.ReadOnly = true;
			this.tblPodgrupaIDGridBig.reportCenter = false;
			this.tblPodgrupaIDGridBig.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.tblPodgrupaIDGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tblPodgrupaIDGridBig.RowTemplate.Height = 36;
			this.tblPodgrupaIDGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblPodgrupaIDGridBig.Size = new System.Drawing.Size( 996, 329 );
			this.tblPodgrupaIDGridBig.SQLCommandQuery = null;
			this.tblPodgrupaIDGridBig.TabIndex = 2;
			this.tblPodgrupaIDGridBig.UpdateTable = null;
			this.tblPodgrupaIDGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblPodgrupaIDgrdBase_DataInsert );
			this.tblPodgrupaIDGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblPodgrupaIDgrdBase_dataSaveAll );
			this.tblPodgrupaIDGridBig.DoubleClick += new System.EventHandler( this.tblPodgrupaIDgrdBase_DoubleClick );
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
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// GrupaID
			// 
			this.GrupaID.DataPropertyName = "GrupaID";
			this.GrupaID.DataSource = this.tblGrupaNaArtikliBindingSource;
			this.GrupaID.DisplayMember = "Naziv";
			this.GrupaID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.GrupaID.HeaderText = "Група";
			this.GrupaID.Name = "GrupaID";
			this.GrupaID.ReadOnly = true;
			this.GrupaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.GrupaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GrupaID.ValueMember = "ID";
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// frmPodgrupi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 573 );
			this.Name = "frmPodgrupi";
			this.Text = "Подгрупи";
			
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblPodgrupaIDBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblPodgrupaIDGridBig ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblGrupaNaArtikliBindingSource ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblPodgrupaIDBindingSource;
		private BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter tblPodgrupaIDTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblPodgrupaIDGridBig;
		private System.Windows.Forms.BindingSource tblGrupaNaArtikliBindingSource;
		private BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter tblGrupaNaArtikliTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewComboBoxColumn GrupaID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;

	}
}
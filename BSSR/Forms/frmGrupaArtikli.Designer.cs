namespace BSSR.Forms {
	partial class frmGrupaArtikli {
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
			this.tblGrupaNaArtikliBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblGrupaNaArtikliTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblGrupaNaArtikliGridBig = new BssBase.GridBig();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblGrupaNaArtikliBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblGrupaNaArtikliGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblGrupaNaArtikliGridBig );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblGrupaNaArtikliGridBig, 0 );
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
			// tblGrupaNaArtikliGridBig
			// 
			this.tblGrupaNaArtikliGridBig.AllowUserToAddRows = false;
			this.tblGrupaNaArtikliGridBig.AllowUserToDeleteRows = false;
			this.tblGrupaNaArtikliGridBig.AllowUserToOrderColumns = true;
			this.tblGrupaNaArtikliGridBig.AssemblyToLoad = null;
			this.tblGrupaNaArtikliGridBig.AutoGenerateColumns = false;
			this.tblGrupaNaArtikliGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblGrupaNaArtikliGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Status} );
			this.tblGrupaNaArtikliGridBig.DataSource = this.tblGrupaNaArtikliBindingSource;
			this.tblGrupaNaArtikliGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblGrupaNaArtikliGridBig.EditForm = "BSSR.Forms.frmGrupaArtikliEdit";
			this.tblGrupaNaArtikliGridBig.FilterForm = null;
			this.tblGrupaNaArtikliGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblGrupaNaArtikliGridBig.Name = "tblGrupaNaArtikliGridBig";
			this.tblGrupaNaArtikliGridBig.PrimaryKey = "ID";
			this.tblGrupaNaArtikliGridBig.ReadOnly = true;
			this.tblGrupaNaArtikliGridBig.reportCenter = false;
			this.tblGrupaNaArtikliGridBig.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.tblGrupaNaArtikliGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tblGrupaNaArtikliGridBig.RowTemplate.Height = 36;
			this.tblGrupaNaArtikliGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblGrupaNaArtikliGridBig.Size = new System.Drawing.Size( 996, 329 );
			this.tblGrupaNaArtikliGridBig.SQLCommandQuery = null;
			this.tblGrupaNaArtikliGridBig.TabIndex = 2;
			this.tblGrupaNaArtikliGridBig.UpdateTable = null;
			this.tblGrupaNaArtikliGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblGrupaNaArtikligrdBase_DataInsert );
			this.tblGrupaNaArtikliGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblGrupaNaArtikligrdBase_dataSaveAll );
			this.tblGrupaNaArtikliGridBig.DoubleClick += new System.EventHandler( this.tblGrupaNaArtikligrdBase_DoubleClick );
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден Број";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Sifra";
			this.dataGridViewTextBoxColumn3.HeaderText = "Шифра";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 855;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
			this.dataGridViewTextBoxColumn2.HeaderText = "Назив";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// frmGrupaArtikli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 573 );
			this.Name = "frmGrupaArtikli";
			this.Text = "Група на артикли";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblGrupaNaArtikliBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblGrupaNaArtikliGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblGrupaNaArtikliBindingSource;
		private BSSSDatasetTableAdapters.tblGrupaNaArtikliTableAdapter tblGrupaNaArtikliTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblGrupaNaArtikliGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}
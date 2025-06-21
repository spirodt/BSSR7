namespace BSSR.Forms {
	partial class frmObjekti {
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
			this.tblObjektiBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblObjektiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblObjektiTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblObjektiGridBig = new BssBase.GridBig();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblObjektiBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblObjektiGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblObjektiGridBig );
			this.MainPanel.Size = new System.Drawing.Size( 998, 577 );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblObjektiGridBig, 0 );
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
			this.PanelFooter.Location = new System.Drawing.Point( 0, 501 );
			// 
			// bSSSDataset
			// 
			this.bSSSDataset.DataSetName = "BSSSDataset";
			this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblObjektiBindingSource
			// 
			this.tblObjektiBindingSource.DataMember = "tblObjekti";
			this.tblObjektiBindingSource.DataSource = this.bSSSDataset;
			// 
			// tblObjektiTableAdapter
			// 
			this.tblObjektiTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.tblObjektiTableAdapter = this.tblObjektiTableAdapter;
			this.tableAdapterManager.tblPrevodiTableAdapter = null;
			this.tableAdapterManager.tblRoljiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaTableAdapter = null;
			this.tableAdapterManager.tblUserConfigsTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tblObjektiGridBig
			// 
			this.tblObjektiGridBig.AllowUserToAddRows = false;
			this.tblObjektiGridBig.AllowUserToDeleteRows = false;
			this.tblObjektiGridBig.AllowUserToOrderColumns = true;
			this.tblObjektiGridBig.AssemblyToLoad = "BSSR";
			this.tblObjektiGridBig.AutoGenerateColumns = false;
			this.tblObjektiGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblObjektiGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sifra,
            this.Naziv,
            this.Status} );
			this.tblObjektiGridBig.DataSource = this.tblObjektiBindingSource;
			this.tblObjektiGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblObjektiGridBig.EditForm = "BSSR.Forms.frmObjektiEdit";
			this.tblObjektiGridBig.FilterForm = null;
			this.tblObjektiGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblObjektiGridBig.Name = "tblObjektiGridBig";
			this.tblObjektiGridBig.PrimaryKey = "ID";
			this.tblObjektiGridBig.ReadOnly = true;
			this.tblObjektiGridBig.reportCenter = false;
			this.tblObjektiGridBig.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.tblObjektiGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tblObjektiGridBig.RowTemplate.Height = 36;
			this.tblObjektiGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblObjektiGridBig.Size = new System.Drawing.Size( 996, 333 );
			this.tblObjektiGridBig.SQLCommandQuery = null;
			this.tblObjektiGridBig.TabIndex = 2;
			this.tblObjektiGridBig.UpdateTable = null;
			this.tblObjektiGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblObjektigrdBase_DataInsert );
			this.tblObjektiGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblObjektigrdBase_dataSaveAll );
			this.tblObjektiGridBig.DoubleClick += new System.EventHandler( this.tblObjektigrdBase_DoubleClick );
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден Број";
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
			// 
			// frmObjekti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 577 );
			this.Name = "frmObjekti";
			this.Text = "Објекти";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblObjektiBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblObjektiGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblObjektiBindingSource;
		private BSSSDatasetTableAdapters.tblObjektiTableAdapter tblObjektiTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblObjektiGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}
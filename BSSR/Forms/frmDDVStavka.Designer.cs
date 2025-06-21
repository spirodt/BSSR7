namespace BSSR.Forms {
    partial class frmDDVStavka
    {
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
			this.tblDDVStavkaBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblDDVStavkaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblDDVStavkaTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblDDVStavkaGridBig = new BssBase.GridBig();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblDDVStavkaBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblDDVStavkaGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblDDVStavkaGridBig );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblDDVStavkaGridBig, 0 );
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
			// tblDDVStavkaBindingSource
			// 
			this.tblDDVStavkaBindingSource.DataMember = "tblDDVStavka";
			this.tblDDVStavkaBindingSource.DataSource = this.bSSSDataset;
			// 
			// tblDDVStavkaTableAdapter
			// 
			this.tblDDVStavkaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager._tblLogTableAdapter = null;
			this.tableAdapterManager._tblSesijaTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.tblArtikalTableAdapter = null;
			this.tableAdapterManager.tblConfigTableAdapter = null;
			this.tableAdapterManager.tblDDVStavkaTableAdapter = this.tblDDVStavkaTableAdapter;
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
			this.tableAdapterManager.tblPrevodiTableAdapter = null;
			this.tableAdapterManager.tblRoljiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
			this.tableAdapterManager.tblSmetkaTableAdapter = null;
			this.tableAdapterManager.tblUserConfigsTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tblDDVStavkaGridBig
			// 
			this.tblDDVStavkaGridBig.AllowUserToAddRows = false;
			this.tblDDVStavkaGridBig.AllowUserToDeleteRows = false;
			this.tblDDVStavkaGridBig.AllowUserToOrderColumns = true;
			this.tblDDVStavkaGridBig.AssemblyToLoad = "BSSR";
			this.tblDDVStavkaGridBig.AutoGenerateColumns = false;
			this.tblDDVStavkaGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblDDVStavkaGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Procent} );
			this.tblDDVStavkaGridBig.DataSource = this.tblDDVStavkaBindingSource;
			this.tblDDVStavkaGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblDDVStavkaGridBig.EditForm = "BSSR.Forms.frmDDVStavkaEdit";
			this.tblDDVStavkaGridBig.FilterForm = null;
			this.tblDDVStavkaGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblDDVStavkaGridBig.Name = "tblDDVStavkaGridBig";
			this.tblDDVStavkaGridBig.PrimaryKey = "ID";
			this.tblDDVStavkaGridBig.ReadOnly = true;
			this.tblDDVStavkaGridBig.reportCenter = false;
			this.tblDDVStavkaGridBig.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.tblDDVStavkaGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tblDDVStavkaGridBig.RowTemplate.Height = 36;
			this.tblDDVStavkaGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblDDVStavkaGridBig.Size = new System.Drawing.Size( 996, 329 );
			this.tblDDVStavkaGridBig.SQLCommandQuery = null;
			this.tblDDVStavkaGridBig.TabIndex = 2;
			this.tblDDVStavkaGridBig.UpdateTable = null;
			this.tblDDVStavkaGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblDDVStavkagrdBase_DataInsert );
			this.tblDDVStavkaGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblDDVStavkagrdBase_dataSaveAll );
			this.tblDDVStavkaGridBig.DoubleClick += new System.EventHandler( this.tblDDVStavkagrdBase_DoubleClick );
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден Број";
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
			// Procent
			// 
			this.Procent.DataPropertyName = "Procent";
			this.Procent.HeaderText = "Процент";
			this.Procent.Name = "Procent";
			this.Procent.ReadOnly = true;
			// 
			// frmDDVStavka
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 573 );
			this.Name = "frmDDVStavka";
			this.Text = "ДДВ Ставки";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblDDVStavkaBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblDDVStavkaGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblDDVStavkaBindingSource;
		private BSSSDatasetTableAdapters.tblDDVStavkaTableAdapter tblDDVStavkaTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblDDVStavkaGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
	}
}
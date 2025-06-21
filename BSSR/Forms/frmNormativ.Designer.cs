namespace BSSR.Forms {
	partial class frmNormativ {
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
			this.tblNormativBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblNormativTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblNormativTableAdapter();
			this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
			this.tblNormativGridBig = new BssBase.GridBig();
			this.tblPodgrupaIDBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblPodgrupaIDTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter();
			this.tblDDVStavkaBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.tblDDVStavkaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblDDVStavkaTableAdapter();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PodgrupaID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.tblDDVStavkaID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KlucniZborovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblNormativBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblNormativGridBig ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblPodgrupaIDBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblDDVStavkaBindingSource ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.tblNormativGridBig );
			this.MainPanel.Size = new System.Drawing.Size( 998, 625 );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.tblNormativGridBig, 0 );
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
			this.PanelFooter.Location = new System.Drawing.Point( 0, 549 );
			// 
			// bSSSDataset
			// 
			this.bSSSDataset.DataSetName = "BSSSDataset";
			this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblNormativBindingSource
			// 
			this.tblNormativBindingSource.DataMember = "tblNormativ";
			this.tblNormativBindingSource.DataSource = this.bSSSDataset;
			// 
			// tblNormativTableAdapter
			// 
			this.tblNormativTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.tblNormativTableAdapter = this.tblNormativTableAdapter;
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
			// tblNormativGridBig
			// 
			this.tblNormativGridBig.AllowUserToAddRows = false;
			this.tblNormativGridBig.AllowUserToDeleteRows = false;
			this.tblNormativGridBig.AllowUserToOrderColumns = true;
			this.tblNormativGridBig.AssemblyToLoad = "BSSR";
			this.tblNormativGridBig.AutoGenerateColumns = false;
			this.tblNormativGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblNormativGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Status,
            this.Sifra,
            this.PodgrupaID,
            this.tblDDVStavkaID,
            this.Cena,
            this.KlucniZborovi} );
			this.tblNormativGridBig.DataSource = this.tblNormativBindingSource;
			this.tblNormativGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblNormativGridBig.EditForm = "BSSR.Forms.frmNormativEdit";
			this.tblNormativGridBig.FilterForm = null;
			this.tblNormativGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.tblNormativGridBig.Name = "tblNormativGridBig";
			this.tblNormativGridBig.PrimaryKey = "ID";
			this.tblNormativGridBig.ReadOnly = true;
			this.tblNormativGridBig.reportCenter = false;
			this.tblNormativGridBig.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.tblNormativGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tblNormativGridBig.RowTemplate.Height = 36;
			this.tblNormativGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblNormativGridBig.Size = new System.Drawing.Size( 996, 381 );
			this.tblNormativGridBig.SQLCommandQuery = null;
			this.tblNormativGridBig.TabIndex = 2;
			this.tblNormativGridBig.UpdateTable = null;
			this.tblNormativGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.tblNormativgrdBase_DataInsert );
			this.tblNormativGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.tblNormativgrdBase_dataSaveAll );
			this.tblNormativGridBig.DoubleClick += new System.EventHandler( this.tblNormativgrdBase_DoubleClick );
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
			// tblDDVStavkaBindingSource
			// 
			this.tblDDVStavkaBindingSource.DataMember = "tblDDVStavka";
			this.tblDDVStavkaBindingSource.DataSource = this.bSSSDataset;
			// 
			// tblDDVStavkaTableAdapter
			// 
			this.tblDDVStavkaTableAdapter.ClearBeforeFill = true;
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
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// Sifra
			// 
			this.Sifra.DataPropertyName = "Sifra";
			this.Sifra.HeaderText = "Шифра";
			this.Sifra.Name = "Sifra";
			this.Sifra.ReadOnly = true;
			// 
			// PodgrupaID
			// 
			this.PodgrupaID.DataPropertyName = "PodgrupaID";
			this.PodgrupaID.DataSource = this.tblPodgrupaIDBindingSource;
			this.PodgrupaID.DisplayMember = "Naziv";
			this.PodgrupaID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.PodgrupaID.HeaderText = "Подгрупа";
			this.PodgrupaID.Name = "PodgrupaID";
			this.PodgrupaID.ReadOnly = true;
			this.PodgrupaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.PodgrupaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.PodgrupaID.ValueMember = "ID";
			// 
			// tblDDVStavkaID
			// 
			this.tblDDVStavkaID.DataPropertyName = "tblDDVStavkaID";
			this.tblDDVStavkaID.DataSource = this.tblDDVStavkaBindingSource;
			this.tblDDVStavkaID.DisplayMember = "Naziv";
			this.tblDDVStavkaID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.tblDDVStavkaID.HeaderText = "ДДВ";
			this.tblDDVStavkaID.Name = "tblDDVStavkaID";
			this.tblDDVStavkaID.ReadOnly = true;
			this.tblDDVStavkaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.tblDDVStavkaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.tblDDVStavkaID.ValueMember = "ID";
			// 
			// Cena
			// 
			this.Cena.DataPropertyName = "Cena";
			this.Cena.HeaderText = "Цена";
			this.Cena.Name = "Cena";
			this.Cena.ReadOnly = true;
			// 
			// KlucniZborovi
			// 
			this.KlucniZborovi.DataPropertyName = "KlucniZborovi";
			this.KlucniZborovi.HeaderText = "Клучни зборови";
			this.KlucniZborovi.Name = "KlucniZborovi";
			this.KlucniZborovi.ReadOnly = true;
			this.KlucniZborovi.Visible = false;
			// 
			// frmNormativ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 625 );
			this.Name = "frmNormativ";
			this.Text = " ";
			this.Load += new System.EventHandler( this.frmNormativ_Load );
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.bSSSDataset ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblNormativBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblNormativGridBig ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblPodgrupaIDBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.tblDDVStavkaBindingSource ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblNormativBindingSource;
		private BSSSDatasetTableAdapters.tblNormativTableAdapter tblNormativTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblNormativGridBig;
		private System.Windows.Forms.BindingSource tblPodgrupaIDBindingSource;
		private BSSSDatasetTableAdapters.tblPodgrupaIDTableAdapter tblPodgrupaIDTableAdapter;
		private System.Windows.Forms.BindingSource tblDDVStavkaBindingSource;
		private BSSSDatasetTableAdapters.tblDDVStavkaTableAdapter tblDDVStavkaTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
		private System.Windows.Forms.DataGridViewComboBoxColumn PodgrupaID;
		private System.Windows.Forms.DataGridViewComboBoxColumn tblDDVStavkaID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
		private System.Windows.Forms.DataGridViewTextBoxColumn KlucniZborovi;
	}
}
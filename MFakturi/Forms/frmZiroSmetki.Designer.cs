namespace MFakturi.Forms {
	partial class frmZiroSmetki {
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
			this.viewZiroSmetkeBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.viewZiroSmetkeTableAdapter = new MFakturi.FakturiDataSetTableAdapters.viewZiroSmetkeTableAdapter();
			this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
			this.viewZiroSmetkeGridBig = new BssBase.GridBig();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Banka = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZiroSmetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainPanel.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).BeginInit();
			this.PanelFooter.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.viewZiroSmetkeBindingSource ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.viewZiroSmetkeGridBig ) ).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add( this.viewZiroSmetkeGridBig );
			this.MainPanel.Size = new System.Drawing.Size( 998, 608 );
			this.MainPanel.Controls.SetChildIndex( this.PanelHeader, 0 );
			this.MainPanel.Controls.SetChildIndex( this.PanelFooter, 0 );
			this.MainPanel.Controls.SetChildIndex( this.viewZiroSmetkeGridBig, 0 );
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
			this.PanelFooter.Location = new System.Drawing.Point( 0, 532 );
			// 
			// fakturiDataSet
			// 
			this.fakturiDataSet.DataSetName = "FakturiDataSet";
			this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// viewZiroSmetkeBindingSource
			// 
			this.viewZiroSmetkeBindingSource.DataMember = "viewZiroSmetke";
			this.viewZiroSmetkeBindingSource.DataSource = this.fakturiDataSet;
			// 
			// viewZiroSmetkeTableAdapter
			// 
			this.viewZiroSmetkeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.tblBankiTableAdapter = null;
			this.tableAdapterManager.tblPartneriTableAdapter = null;
			this.tableAdapterManager.tblUsersTableAdapter = null;
			this.tableAdapterManager.tblZiroSmetkiTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.viewZiroSmetkeTableAdapter = null;
			// 
			// viewZiroSmetkeGridBig
			// 
			this.viewZiroSmetkeGridBig.AllowUserToAddRows = false;
			this.viewZiroSmetkeGridBig.AllowUserToDeleteRows = false;
			this.viewZiroSmetkeGridBig.AllowUserToOrderColumns = true;
			this.viewZiroSmetkeGridBig.AssemblyToLoad = "MFakturi";
			this.viewZiroSmetkeGridBig.AutoGenerateColumns = false;
			this.viewZiroSmetkeGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewZiroSmetkeGridBig.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Partner,
            this.Banka,
            this.ZiroSmetka,
            this.Status} );
			this.viewZiroSmetkeGridBig.DataSource = this.viewZiroSmetkeBindingSource;
			this.viewZiroSmetkeGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewZiroSmetkeGridBig.EditForm = "MFakturi.Forms.frmZiroSmetkiEdit";
			this.viewZiroSmetkeGridBig.FilterForm = null;
			this.viewZiroSmetkeGridBig.Location = new System.Drawing.Point( 0, 168 );
			this.viewZiroSmetkeGridBig.MultiSelect = false;
			this.viewZiroSmetkeGridBig.Name = "viewZiroSmetkeGridBig";			
			this.viewZiroSmetkeGridBig.PrimaryKey = "ID";
			this.viewZiroSmetkeGridBig.ReadOnly = true;
			this.viewZiroSmetkeGridBig.reportCenter = false;
			this.viewZiroSmetkeGridBig.ReportName = null;
			this.viewZiroSmetkeGridBig.RowTemplate.Height = 36;
			this.viewZiroSmetkeGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.viewZiroSmetkeGridBig.Size = new System.Drawing.Size( 996, 364 );
			this.viewZiroSmetkeGridBig.SQLCommandQuery = null;
			this.viewZiroSmetkeGridBig.TabIndex = 2;
			this.viewZiroSmetkeGridBig.UpdateTable = null;
			this.viewZiroSmetkeGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd( this.viewZiroSmetkegrdBase_DataInsert );
			this.viewZiroSmetkeGridBig.dataSaveAll += new BssBase.grdBase.dataSave( this.viewZiroSmetkegrdBase_dataSaveAll );
			this.viewZiroSmetkeGridBig.DoubleClick += new System.EventHandler( this.viewZiroSmetkegrdBase_DoubleClick );
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Реден број";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Partner
			// 
			this.Partner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Partner.DataPropertyName = "Partner";
			this.Partner.HeaderText = "Партнер";
			this.Partner.Name = "Partner";
			this.Partner.ReadOnly = true;
			// 
			// Banka
			// 
			this.Banka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Banka.DataPropertyName = "Banka";
			this.Banka.HeaderText = "Банка";
			this.Banka.Name = "Banka";
			this.Banka.ReadOnly = true;
			// 
			// ZiroSmetka
			// 
			this.ZiroSmetka.DataPropertyName = "ZiroSmetka";
			this.ZiroSmetka.HeaderText = "Жиро сметка";
			this.ZiroSmetka.Name = "ZiroSmetka";
			this.ZiroSmetka.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// frmZiroSmetki
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 998, 608 );
			this.Name = "frmZiroSmetki";
			this.Text = "Жиро сметки";
			this.MainPanel.ResumeLayout( false );
			this.PanelHeader.ResumeLayout( false );
			this.PanelHeader.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.Bsource ) ).EndInit();
			this.PanelFooter.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.fakturiDataSet ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.viewZiroSmetkeBindingSource ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.viewZiroSmetkeGridBig ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource viewZiroSmetkeBindingSource;
		private FakturiDataSetTableAdapters.viewZiroSmetkeTableAdapter viewZiroSmetkeTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig viewZiroSmetkeGridBig;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Partner;
		private System.Windows.Forms.DataGridViewTextBoxColumn Banka;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZiroSmetka;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}
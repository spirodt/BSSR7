namespace BSSR.Forms {
	partial class frmFiskalniSmetki {
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
            this.tblFiskalniSmetkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFiskalniSmetkiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblFiskalniSmetkiTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblFiskalniSmetkiGridBig = new BssBase.GridBig();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNaFiskalna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stornirana = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblSmetkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNaSmetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosNaSmetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zabeleska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPickerBase1 = new BssBase.Elements.dtPickerBase();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFiskalniSmetkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFiskalniSmetkiGridBig)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblFiskalniSmetkiGridBig);
            this.MainPanel.Size = new System.Drawing.Size(998, 573);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblFiskalniSmetkiGridBig, 0);
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrebaraj.Location = new System.Drawing.Point(761, 122);
            // 
            // Navigator
            // 
            this.Navigator.Location = new System.Drawing.Point(0, 101);
            this.Navigator.Size = new System.Drawing.Size(994, 25);
            // 
            // txtBaraj
            // 
            this.txtBaraj.Location = new System.Drawing.Point(460, 122);
            this.txtBaraj.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.dtPickerBase1);
            this.PanelHeader.Size = new System.Drawing.Size(996, 168);
            this.PanelHeader.Controls.SetChildIndex(this.Navigator, 0);
            this.PanelHeader.Controls.SetChildIndex(this.btnPrebaraj, 0);
            this.PanelHeader.Controls.SetChildIndex(this.txtBaraj, 0);
            this.PanelHeader.Controls.SetChildIndex(this.btnIcistiBaraj, 0);
            this.PanelHeader.Controls.SetChildIndex(this.dtPickerBase1, 0);
            // 
            // btnIcistiBaraj
            // 
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIcistiBaraj.Location = new System.Drawing.Point(822, 122);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(803, 8);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // PanelFooter
            // 
            this.PanelFooter.Size = new System.Drawing.Size(996, 74);
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.Namespace = "http://tempuri.org/BSSSDataset.xsd";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFiskalniSmetkiBindingSource
            // 
            this.tblFiskalniSmetkiBindingSource.DataMember = "tblFiskalniSmetki";
            this.tblFiskalniSmetkiBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblFiskalniSmetkiTableAdapter
            // 
            this.tblFiskalniSmetkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAkcijaNaArtikalTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblConfigTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = this.tblFiskalniSmetkiTableAdapter;
            this.tableAdapterManager.tblFormiTableAdapter = null;
            this.tableAdapterManager.tblGrupaNaArtikliTableAdapter = null;
            this.tableAdapterManager.tblKursnaListaTableAdapter = null;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = null;
            this.tableAdapterManager.tblNarackiTableAdapter = null;
            this.tableAdapterManager.tblNormativiSodriznaIznosTableAdapter = null;
            this.tableAdapterManager.tblNormativStavkiTableAdapter = null;
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblTipNaDokumentTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.tblZabeleshkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblFiskalniSmetkiGridBig
            // 
            this.tblFiskalniSmetkiGridBig.AllowUserToAddRows = false;
            this.tblFiskalniSmetkiGridBig.AllowUserToDeleteRows = false;
            this.tblFiskalniSmetkiGridBig.AllowUserToOrderColumns = true;
            this.tblFiskalniSmetkiGridBig.AssemblyToLoad = null;
            this.tblFiskalniSmetkiGridBig.AutoGenerateColumns = false;
            this.tblFiskalniSmetkiGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFiskalniSmetkiGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BrojNaFiskalna,
            this.Datum,
            this.Iznos,
            this.Stornirana,
            this.tblSmetkaID,
            this.FirmaID,
            this.BrojNaSmetka,
            this.IznosNaSmetka,
            this.Zabeleska});
            this.tblFiskalniSmetkiGridBig.DataSource = this.tblFiskalniSmetkiBindingSource;
            this.tblFiskalniSmetkiGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFiskalniSmetkiGridBig.EditForm = null;
            this.tblFiskalniSmetkiGridBig.FilterForm = null;
            this.tblFiskalniSmetkiGridBig.HidenColumns = null;
            this.tblFiskalniSmetkiGridBig.KreirajPredefiniraniPolinja = false;
            this.tblFiskalniSmetkiGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblFiskalniSmetkiGridBig.MultiSelect = false;
            this.tblFiskalniSmetkiGridBig.Name = "tblFiskalniSmetkiGridBig";
            this.tblFiskalniSmetkiGridBig.PrimaryKey = "ID";
            this.tblFiskalniSmetkiGridBig.ReadOnly = true;
            this.tblFiskalniSmetkiGridBig.ReadOnlyColumns = null;
            this.tblFiskalniSmetkiGridBig.reportCenter = false;
            this.tblFiskalniSmetkiGridBig.ReportName = null;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFiskalniSmetkiGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblFiskalniSmetkiGridBig.RowTemplate.Height = 36;
            this.tblFiskalniSmetkiGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFiskalniSmetkiGridBig.Size = new System.Drawing.Size(996, 329);
            this.tblFiskalniSmetkiGridBig.SQLCommandQuery = null;
            this.tblFiskalniSmetkiGridBig.TabIndex = 2;
            this.tblFiskalniSmetkiGridBig.UpdateTable = null;
            this.tblFiskalniSmetkiGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblFiskalniSmetkigrdBase_DataInsert);
            this.tblFiskalniSmetkiGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblFiskalniSmetkigrdBase_dataSaveAll);
            this.tblFiskalniSmetkiGridBig.DoubleClick += new System.EventHandler(this.tblFiskalniSmetkigrdBase_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Реден број";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // BrojNaFiskalna
            // 
            this.BrojNaFiskalna.DataPropertyName = "BrojNaFiskalna";
            this.BrojNaFiskalna.HeaderText = "Број на фискална";
            this.BrojNaFiskalna.Name = "BrojNaFiskalna";
            this.BrojNaFiskalna.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Датум";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Износ на фискална";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // Stornirana
            // 
            this.Stornirana.DataPropertyName = "Stornirana";
            this.Stornirana.HeaderText = "Сторнирана";
            this.Stornirana.Name = "Stornirana";
            this.Stornirana.ReadOnly = true;
            // 
            // tblSmetkaID
            // 
            this.tblSmetkaID.DataPropertyName = "tblSmetkaID";
            this.tblSmetkaID.HeaderText = "tblSmetkaID";
            this.tblSmetkaID.Name = "tblSmetkaID";
            this.tblSmetkaID.ReadOnly = true;
            this.tblSmetkaID.Visible = false;
            // 
            // FirmaID
            // 
            this.FirmaID.DataPropertyName = "FirmaID";
            this.FirmaID.HeaderText = "FirmaID";
            this.FirmaID.Name = "FirmaID";
            this.FirmaID.ReadOnly = true;
            this.FirmaID.Visible = false;
            // 
            // BrojNaSmetka
            // 
            this.BrojNaSmetka.DataPropertyName = "BrojNaSmetka";
            this.BrojNaSmetka.HeaderText = "Број на сметка";
            this.BrojNaSmetka.Name = "BrojNaSmetka";
            this.BrojNaSmetka.ReadOnly = true;
            // 
            // IznosNaSmetka
            // 
            this.IznosNaSmetka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IznosNaSmetka.DataPropertyName = "IznosNaSmetka";
            this.IznosNaSmetka.HeaderText = "Износ на сметка";
            this.IznosNaSmetka.Name = "IznosNaSmetka";
            this.IznosNaSmetka.ReadOnly = true;
            // 
            // Zabeleska
            // 
            this.Zabeleska.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zabeleska.DataPropertyName = "Zabeleska";
            this.Zabeleska.HeaderText = "Zabeleska";
            this.Zabeleska.Name = "Zabeleska";
            this.Zabeleska.ReadOnly = true;
            // 
            // dtPickerBase1
            // 
            this.dtPickerBase1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerBase1.Location = new System.Drawing.Point(10, 129);
            this.dtPickerBase1.Name = "dtPickerBase1";
            this.dtPickerBase1.Size = new System.Drawing.Size(206, 35);
            this.dtPickerBase1.TabIndex = 21;
            // 
            // frmFiskalniSmetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmFiskalniSmetki";
            this.Text = "Фискални сметки";
            this.Load += new System.EventHandler(this.frmFiskalniSmetki_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFiskalniSmetkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFiskalniSmetkiGridBig)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblFiskalniSmetkiBindingSource;
		private BSSSDatasetTableAdapters.tblFiskalniSmetkiTableAdapter tblFiskalniSmetkiTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig tblFiskalniSmetkiGridBig;
        private BssBase.Elements.dtPickerBase dtPickerBase1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNaFiskalna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Stornirana;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblSmetkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNaSmetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosNaSmetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zabeleska;


	}
}
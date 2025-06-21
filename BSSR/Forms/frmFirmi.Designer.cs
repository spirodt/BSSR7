namespace BSSR.Forms {
	partial class frmFirmi {
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
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFirmaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblFirmaTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblFirmaGridBig = new BssBase.GridBig();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeNaFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanocenBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaDeponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostenskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaticenBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ZiroSmetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaGridBig)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblFirmaGridBig);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblFirmaGridBig, 0);
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // btnIcistiBaraj
            // 
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "tblFirma";
            this.tblFirmaBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblFirmaTableAdapter
            // 
            this.tblFirmaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblFirmaTableAdapter = this.tblFirmaTableAdapter;
            this.tableAdapterManager.tblFiskalniSmetkiTableAdapter = null;
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
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblTipNaDokumentTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblFirmaGridBig
            // 
            this.tblFirmaGridBig.AllowUserToAddRows = false;
            this.tblFirmaGridBig.AllowUserToDeleteRows = false;
            this.tblFirmaGridBig.AllowUserToOrderColumns = true;
            this.tblFirmaGridBig.AssemblyToLoad = "BSSR";
            this.tblFirmaGridBig.AutoGenerateColumns = false;
            this.tblFirmaGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFirmaGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ImeNaFirma,
            this.DanocenBroj,
            this.BankaDeponent,
            this.Grad,
            this.Adresa,
            this.PostenskiBroj,
            this.Telefon,
            this.Faks,
            this.EMail,
            this.MaticenBroj,
            this.Status,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn3,
            this.ZiroSmetka,
            this.Image1});
            this.tblFirmaGridBig.DataSource = this.tblFirmaBindingSource;
            this.tblFirmaGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFirmaGridBig.EditForm = "BSSR.Forms.frmFirmiEdit";
            this.tblFirmaGridBig.FilterForm = null;
            this.tblFirmaGridBig.HidenColumns = null;
            this.tblFirmaGridBig.KreirajPredefiniraniPolinja = false;
            this.tblFirmaGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblFirmaGridBig.MultiSelect = false;
            this.tblFirmaGridBig.Name = "tblFirmaGridBig";
            this.tblFirmaGridBig.PrimaryKey = "ID";
            this.tblFirmaGridBig.ReadOnly = true;
            this.tblFirmaGridBig.ReadOnlyColumns = null;
            this.tblFirmaGridBig.reportCenter = false;
            this.tblFirmaGridBig.ReportName = null;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFirmaGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblFirmaGridBig.RowTemplate.Height = 36;
            this.tblFirmaGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFirmaGridBig.Size = new System.Drawing.Size(996, 329);
            this.tblFirmaGridBig.SQLCommandQuery = null;
            this.tblFirmaGridBig.TabIndex = 2;
            this.tblFirmaGridBig.UpdateTable = null;
            this.tblFirmaGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblFirmagrdBase_DataInsert);
            this.tblFirmaGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblFirmagrdBase_dataSaveAll);
            this.tblFirmaGridBig.DoubleClick += new System.EventHandler(this.tblFirmagrdBase_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Реден Број";
            this.ID.MinimumWidth = 100;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ImeNaFirma
            // 
            this.ImeNaFirma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeNaFirma.DataPropertyName = "ImeNaFirma";
            this.ImeNaFirma.HeaderText = "Име на Фирма";
            this.ImeNaFirma.MinimumWidth = 100;
            this.ImeNaFirma.Name = "ImeNaFirma";
            this.ImeNaFirma.ReadOnly = true;
            // 
            // DanocenBroj
            // 
            this.DanocenBroj.DataPropertyName = "DanocenBroj";
            this.DanocenBroj.HeaderText = "Даночен Број";
            this.DanocenBroj.Name = "DanocenBroj";
            this.DanocenBroj.ReadOnly = true;
            // 
            // BankaDeponent
            // 
            this.BankaDeponent.DataPropertyName = "BankaDeponent";
            this.BankaDeponent.HeaderText = "Банка Депонент";
            this.BankaDeponent.Name = "BankaDeponent";
            this.BankaDeponent.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Град";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Адреса";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // PostenskiBroj
            // 
            this.PostenskiBroj.DataPropertyName = "PostenskiBroj";
            this.PostenskiBroj.HeaderText = "Поштенски Број";
            this.PostenskiBroj.Name = "PostenskiBroj";
            this.PostenskiBroj.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Телефон";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Faks
            // 
            this.Faks.DataPropertyName = "Faks";
            this.Faks.HeaderText = "Факс";
            this.Faks.Name = "Faks";
            this.Faks.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "ЕМаил";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // MaticenBroj
            // 
            this.MaticenBroj.DataPropertyName = "MaticenBroj";
            this.MaticenBroj.HeaderText = "Матичен Број";
            this.MaticenBroj.Name = "MaticenBroj";
            this.MaticenBroj.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image1";
            this.dataGridViewImageColumn1.HeaderText = "Image1";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Image2";
            this.dataGridViewImageColumn2.HeaderText = "Image2";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Visible = false;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "Image3";
            this.dataGridViewImageColumn3.HeaderText = "Image3";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Visible = false;
            // 
            // ZiroSmetka
            // 
            this.ZiroSmetka.DataPropertyName = "ZiroSmetka";
            this.ZiroSmetka.HeaderText = "Жиро сметка";
            this.ZiroSmetka.Name = "ZiroSmetka";
            this.ZiroSmetka.ReadOnly = true;
            // 
            // Image1
            // 
            this.Image1.DataPropertyName = "Image1";
            this.Image1.HeaderText = "Слика";
            this.Image1.MinimumWidth = 100;
            this.Image1.Name = "Image1";
            this.Image1.ReadOnly = true;
            // 
            // frmFirmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmFirmi";
            this.ShowIcon = true;
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaGridBig)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource tblFirmaBindingSource;
		private BSSSDatasetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig tblFirmaGridBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeNaFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanocenBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaDeponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostenskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faks;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaticenBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZiroSmetka;
        private System.Windows.Forms.DataGridViewImageColumn Image1;
	}
}
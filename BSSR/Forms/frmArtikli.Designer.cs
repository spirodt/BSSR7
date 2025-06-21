namespace BSSR.Forms {
	partial class frmArtikli {
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
            this.viewArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewArtikliTableAdapter = new BSSR.BSSSDatasetTableAdapters.viewArtikliTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.viewArtikliGridBig = new BssBase.GridBig();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivArtikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavnaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdaznaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodGrupaArtikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaArtikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedenBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliGridBig)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.viewArtikliGridBig);
            this.MainPanel.Size = new System.Drawing.Size(998, 573);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.viewArtikliGridBig, 0);
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrebaraj.Location = new System.Drawing.Point(824, 132);
            // 
            // txtBaraj
            // 
            this.txtBaraj.Location = new System.Drawing.Point(523, 132);
            // 
            // PanelHeader
            // 
            this.PanelHeader.Size = new System.Drawing.Size(996, 181);
            // 
            // btnIcistiBaraj
            // 
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIcistiBaraj.Location = new System.Drawing.Point(883, 132);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(749, 8);
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
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewArtikliBindingSource
            // 
            this.viewArtikliBindingSource.DataMember = "viewArtikli";
            this.viewArtikliBindingSource.DataSource = this.bSSSDataset;
            this.viewArtikliBindingSource.Filter = "";
            // 
            // viewArtikliTableAdapter
            // 
            this.viewArtikliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = null;
            this.tableAdapterManager._tblSesijaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblAkcijaNaArtikalTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblConfigTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
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
            // viewArtikliGridBig
            // 
            this.viewArtikliGridBig.AllowUserToAddRows = false;
            this.viewArtikliGridBig.AllowUserToDeleteRows = false;
            this.viewArtikliGridBig.AllowUserToOrderColumns = true;
            this.viewArtikliGridBig.AssemblyToLoad = "BSSR";
            this.viewArtikliGridBig.AutoGenerateColumns = false;
            this.viewArtikliGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewArtikliGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sifra,
            this.AltSifra,
            this.NazivArtikal,
            this.Barkod1,
            this.NabavnaCena,
            this.ProdaznaCena,
            this.PodGrupaArtikal,
            this.GrupaArtikal,
            this.Naziv,
            this.Procent,
            this.Status,
            this.RedenBroj});
            this.viewArtikliGridBig.DataSource = this.viewArtikliBindingSource;
            this.viewArtikliGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewArtikliGridBig.EditForm = "BSSR.Forms.frmArtikliEdit";
            this.viewArtikliGridBig.FilterForm = null;
            this.viewArtikliGridBig.HidenColumns = null;
            this.viewArtikliGridBig.KreirajPredefiniraniPolinja = false;
            this.viewArtikliGridBig.Location = new System.Drawing.Point(0, 181);
            this.viewArtikliGridBig.MultiSelect = false;
            this.viewArtikliGridBig.Name = "viewArtikliGridBig";
            
            this.viewArtikliGridBig.PrimaryKey = "ID";
            this.viewArtikliGridBig.ReadOnly = true;
            this.viewArtikliGridBig.ReadOnlyColumns = null;
            this.viewArtikliGridBig.reportCenter = false;
            this.viewArtikliGridBig.ReportName = null;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.viewArtikliGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewArtikliGridBig.RowTemplate.Height = 36;
            this.viewArtikliGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewArtikliGridBig.Size = new System.Drawing.Size(996, 316);
            this.viewArtikliGridBig.SQLCommandQuery = null;
            this.viewArtikliGridBig.TabIndex = 2;
            this.viewArtikliGridBig.UpdateTable = null;
            this.viewArtikliGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblArtikalgrdBase_DataInsert);
            this.viewArtikliGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblArtikalgrdBase_dataSaveAll);
            this.viewArtikliGridBig.DoubleClick += new System.EventHandler(this.tblArtikalgrdBase_DoubleClick);
            this.viewArtikliGridBig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewArtikliGridBig_KeyDown);
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
            // AltSifra
            // 
            this.AltSifra.DataPropertyName = "AltSifra";
            this.AltSifra.HeaderText = "Алт. Шифра";
            this.AltSifra.Name = "AltSifra";
            this.AltSifra.ReadOnly = true;
            // 
            // NazivArtikal
            // 
            this.NazivArtikal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivArtikal.DataPropertyName = "NazivArtikal";
            this.NazivArtikal.HeaderText = "Назив";
            this.NazivArtikal.Name = "NazivArtikal";
            this.NazivArtikal.ReadOnly = true;
            // 
            // Barkod1
            // 
            this.Barkod1.DataPropertyName = "Barkod1";
            this.Barkod1.HeaderText = "Баркод";
            this.Barkod1.Name = "Barkod1";
            this.Barkod1.ReadOnly = true;
            this.Barkod1.Visible = false;
            // 
            // NabavnaCena
            // 
            this.NabavnaCena.DataPropertyName = "NabavnaCena";
            this.NabavnaCena.HeaderText = "Набавна цена";
            this.NabavnaCena.Name = "NabavnaCena";
            this.NabavnaCena.ReadOnly = true;
            this.NabavnaCena.Visible = false;
            // 
            // ProdaznaCena
            // 
            this.ProdaznaCena.DataPropertyName = "ProdaznaCena";
            this.ProdaznaCena.HeaderText = "Продажна цена";
            this.ProdaznaCena.Name = "ProdaznaCena";
            this.ProdaznaCena.ReadOnly = true;
            // 
            // PodGrupaArtikal
            // 
            this.PodGrupaArtikal.DataPropertyName = "PodGrupaArtikal";
            this.PodGrupaArtikal.HeaderText = "Подгрупа";
            this.PodGrupaArtikal.Name = "PodGrupaArtikal";
            this.PodGrupaArtikal.ReadOnly = true;
            // 
            // GrupaArtikal
            // 
            this.GrupaArtikal.DataPropertyName = "GrupaArtikal";
            this.GrupaArtikal.HeaderText = "Група";
            this.GrupaArtikal.Name = "GrupaArtikal";
            this.GrupaArtikal.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "ДДВ Стапка";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Visible = false;
            // 
            // Procent
            // 
            this.Procent.DataPropertyName = "Procent";
            this.Procent.HeaderText = "ДДВ Процент";
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            this.Procent.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // RedenBroj
            // 
            this.RedenBroj.DataPropertyName = "RedenBroj";
            this.RedenBroj.HeaderText = "Реден број за приказ";
            this.RedenBroj.Name = "RedenBroj";
            this.RedenBroj.ReadOnly = true;
            this.RedenBroj.Visible = false;
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmArtikli";
            this.Text = "Артикли";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArtikliGridBig)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private BSSSDataset bSSSDataset;
		private System.Windows.Forms.BindingSource viewArtikliBindingSource;
		private BSSSDatasetTableAdapters.viewArtikliTableAdapter viewArtikliTableAdapter;
		private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig viewArtikliGridBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivArtikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavnaCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdaznaCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn PodGrupaArtikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaArtikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedenBroj;


	}
}
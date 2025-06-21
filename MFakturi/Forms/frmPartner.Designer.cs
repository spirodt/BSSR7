namespace MFakturi.Forms {
	partial class frmPartner {
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
            this.tblPartneriGridBig = new BssBase.GridBig();
            this.tblPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakturiDataSet = new MFakturi.FakturiDataSet();
            this.tblPartneriTableAdapter = new MFakturi.FakturiDataSetTableAdapters.tblPartneriTableAdapter();
            this.tableAdapterManager = new MFakturi.FakturiDataSetTableAdapters.TableAdapterManager();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefoni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNaStan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblPartneriGridBig);
            this.MainPanel.Size = new System.Drawing.Size(1063, 606);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblPartneriGridBig, 0);
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrebaraj.Location = new System.Drawing.Point(945, 122);
            // 
            // txtBaraj
            // 
            this.txtBaraj.Location = new System.Drawing.Point(644, 122);
            // 
            // PanelHeader
            // 
            this.PanelHeader.Size = new System.Drawing.Size(1061, 168);
            // 
            // btnIcistiBaraj
            // 
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIcistiBaraj.Location = new System.Drawing.Point(1006, 122);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(873, 2);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 530);
            this.PanelFooter.Size = new System.Drawing.Size(1061, 74);
            // 
            // tblPartneriGridBig
            // 
            this.tblPartneriGridBig.AllowUserToAddRows = false;
            this.tblPartneriGridBig.AllowUserToDeleteRows = false;
            this.tblPartneriGridBig.AllowUserToOrderColumns = true;
            this.tblPartneriGridBig.AssemblyToLoad = "MFakturi";
            this.tblPartneriGridBig.AutoGenerateColumns = false;
            this.tblPartneriGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPartneriGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Sifra,
            this.Adresa,
            this.Telefoni,
            this.Email,
            this.BrojNaStan,
            this.DefaultKolicina,
            this.EDB,
            this.Mesto,
            this.Tip,
            this.Status});
            this.tblPartneriGridBig.DataSource = this.tblPartneriBindingSource;
            this.tblPartneriGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPartneriGridBig.EditForm = "MFakturi.Forms.frmPartneriEdit";
            this.tblPartneriGridBig.FilterForm = null;
            this.tblPartneriGridBig.HidenColumns = null;
            this.tblPartneriGridBig.KreirajPredefiniraniPolinja = false;
            this.tblPartneriGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblPartneriGridBig.MultiSelect = false;
            this.tblPartneriGridBig.Name = "tblPartneriGridBig";
            this.tblPartneriGridBig.PrimaryKey = "ID";
            this.tblPartneriGridBig.ReadOnly = true;
            this.tblPartneriGridBig.ReadOnlyColumns = null;
            this.tblPartneriGridBig.reportCenter = false;
            this.tblPartneriGridBig.ReportName = null;
            this.tblPartneriGridBig.RowTemplate.Height = 36;
            this.tblPartneriGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPartneriGridBig.Size = new System.Drawing.Size(1061, 362);
            this.tblPartneriGridBig.SQLCommandQuery = null;
            this.tblPartneriGridBig.TabIndex = 2;
            this.tblPartneriGridBig.UpdateTable = null;
            this.tblPartneriGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblPartnerigrdBase_DataInsert);
            this.tblPartneriGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblPartnerigrdBase_dataSaveAll);
            this.tblPartneriGridBig.DoubleClick += new System.EventHandler(this.tblPartnerigrdBase_DoubleClick);
            // 
            // tblPartneriBindingSource
            // 
            this.tblPartneriBindingSource.DataMember = "tblPartneri";
            this.tblPartneriBindingSource.DataSource = this.fakturiDataSet;
            // 
            // fakturiDataSet
            // 
            this.fakturiDataSet.DataSetName = "FakturiDataSet";
            this.fakturiDataSet.EnforceConstraints = false;
            this.fakturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPartneriTableAdapter
            // 
            this.tblPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblBankiTableAdapter = null;
            this.tableAdapterManager.tblDDVStavkaTableAdapter = null;
            this.tableAdapterManager.tblEdinecniMerkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaStavkiTableAdapter = null;
            this.tableAdapterManager.tblFakturaTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = this.tblPartneriTableAdapter;
            this.tableAdapterManager.tblPresmetkovniEdiniciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblZiroSmetkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MFakturi.FakturiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliVoSmetkaTableAdapter = null;
            this.tableAdapterManager.viewFakturiStavkiTableAdapter = null;
            this.tableAdapterManager.viewFakturiTableAdapter = null;
            this.tableAdapterManager.viewZiroSmetkeTableAdapter = null;
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
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Шифра";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Адреса";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefoni
            // 
            this.Telefoni.DataPropertyName = "Telefoni";
            this.Telefoni.HeaderText = "Телефони";
            this.Telefoni.Name = "Telefoni";
            this.Telefoni.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // BrojNaStan
            // 
            this.BrojNaStan.DataPropertyName = "BrojNaStan";
            this.BrojNaStan.HeaderText = "Број на стан";
            this.BrojNaStan.Name = "BrojNaStan";
            this.BrojNaStan.ReadOnly = true;
            // 
            // DefaultKolicina
            // 
            this.DefaultKolicina.DataPropertyName = "DefaultKolicina";
            this.DefaultKolicina.HeaderText = "Количина/Квадратура";
            this.DefaultKolicina.Name = "DefaultKolicina";
            this.DefaultKolicina.ReadOnly = true;
            // 
            // EDB
            // 
            this.EDB.DataPropertyName = "EDB";
            this.EDB.HeaderText = "ЕДБ";
            this.EDB.Name = "EDB";
            this.EDB.ReadOnly = true;
            // 
            // Mesto
            // 
            this.Mesto.DataPropertyName = "Mesto";
            this.Mesto.HeaderText = "Место";
            this.Mesto.Name = "Mesto";
            this.Mesto.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "Тип на партнер";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // frmPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 606);
            this.Name = "frmPartner";
            this.Text = "Партнер";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiDataSet)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private FakturiDataSet fakturiDataSet;
		private System.Windows.Forms.BindingSource tblPartneriBindingSource;
		private FakturiDataSetTableAdapters.tblPartneriTableAdapter tblPartneriTableAdapter;
		private FakturiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private BssBase.GridBig tblPartneriGridBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefoni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNaStan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
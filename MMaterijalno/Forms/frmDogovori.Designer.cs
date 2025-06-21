namespace MMaterijalno.Forms
{
    partial class frmDogovori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materijalnoDataSet = new MMaterijalno.MaterijalnoDataSet();
            this.tblDogovoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDogovoriTableAdapter = new MMaterijalno.MaterijalnoDataSetTableAdapters.tblDogovoriTableAdapter();
            this.tableAdapterManager = new MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager();
            this.tblDogovoriGridBig = new BssBase.GridBig();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zabeleska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNaDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNaTender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriGridBig)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblDogovoriGridBig);
            this.MainPanel.Size = new System.Drawing.Size(1021, 667);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblDogovoriGridBig, 0);
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrebaraj.Location = new System.Drawing.Point(896, 91);
            // 
            // txtBaraj
            // 
            this.txtBaraj.Location = new System.Drawing.Point(595, 91);
            this.txtBaraj.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Size = new System.Drawing.Size(1019, 137);
            // 
            // btnIcistiBaraj
            // 
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIcistiBaraj.Location = new System.Drawing.Point(957, 91);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(834, 5);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(2, 5);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 591);
            this.PanelFooter.Size = new System.Drawing.Size(1019, 74);
            // 
            // materijalnoDataSet
            // 
            this.materijalnoDataSet.DataSetName = "MaterijalnoDataSet";
            this.materijalnoDataSet.EnforceConstraints = false;
            this.materijalnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDogovoriBindingSource
            // 
            this.tblDogovoriBindingSource.DataMember = "tblDogovori";
            this.tblDogovoriBindingSource.DataSource = this.materijalnoDataSet;
            // 
            // tblDogovoriTableAdapter
            // 
            this.tblDogovoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.General_data_mesecTableAdapter = null;
            this.tableAdapterManager.tblArtikalTableAdapter = null;
            this.tableAdapterManager.tblDogovoriTableAdapter = this.tblDogovoriTableAdapter;
            this.tableAdapterManager.tblDokumentiDetailsInfoHvacTableAdapter = null;
            this.tableAdapterManager.tblDokumentiDetailsInfoTableAdapter = null;
            this.tableAdapterManager.tblDokumentiTableAdapter = null;
            this.tableAdapterManager.tblFirmaTableAdapter = null;
            this.tableAdapterManager.tblIzvodiStavkiTableAdapter = null;
            this.tableAdapterManager.tblIzvodiTableAdapter = null;
            this.tableAdapterManager.tblPartneriTableAdapter = null;
            this.tableAdapterManager.tblPlacanjaOdPartnerTableAdapter = null;
            this.tableAdapterManager.tblPriemStavkiTableAdapter = null;
            this.tableAdapterManager.tblPriemTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MMaterijalno.MaterijalnoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewDokumentiStavkiTableAdapter = null;
            this.tableAdapterManager.viewDokumentiTableAdapter = null;
            this.tableAdapterManager.viewIzvodiTableAdapter = null;
            this.tableAdapterManager.viewPriemiTableAdapter = null;
            this.tableAdapterManager.viewPriemStavkiTableAdapter = null;
            this.tableAdapterManager.vPriemiKnizenjeTableAdapter = null;
            this.tableAdapterManager.vSmetkaKnizenjeTableAdapter = null;
            // 
            // tblDogovoriGridBig
            // 
            this.tblDogovoriGridBig.AllowUserToAddRows = false;
            this.tblDogovoriGridBig.AllowUserToDeleteRows = false;
            this.tblDogovoriGridBig.AllowUserToOrderColumns = true;
            this.tblDogovoriGridBig.AssemblyToLoad = null;
            this.tblDogovoriGridBig.AutoGenerateColumns = false;
            this.tblDogovoriGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDogovoriGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Zabeleska,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.BrojNaDogovor,
            this.BrojNaTender});
            this.tblDogovoriGridBig.DataSource = this.tblDogovoriBindingSource;
            this.tblDogovoriGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDogovoriGridBig.EditForm = "MMaterijalno.Forms.frmDogovoriEdit";
            this.tblDogovoriGridBig.FilterForm = null;
            this.tblDogovoriGridBig.HidenColumns = null;
            this.tblDogovoriGridBig.KreirajPredefiniraniPolinja = false;
            this.tblDogovoriGridBig.Location = new System.Drawing.Point(0, 137);
            this.tblDogovoriGridBig.MultiSelect = false;
            this.tblDogovoriGridBig.Name = "tblDogovoriGridBig";
            this.tblDogovoriGridBig.PrimaryKey = "ID";
            this.tblDogovoriGridBig.ReadOnly = true;
            this.tblDogovoriGridBig.ReadOnlyColumns = null;
            this.tblDogovoriGridBig.reportCenter = false;
            this.tblDogovoriGridBig.ReportName = null;
            this.tblDogovoriGridBig.RowTemplate.Height = 36;
            this.tblDogovoriGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDogovoriGridBig.Size = new System.Drawing.Size(1019, 454);
            this.tblDogovoriGridBig.SQLCommandQuery = null;
            this.tblDogovoriGridBig.TabIndex = 2;
            this.tblDogovoriGridBig.UpdateTable = null;
            this.tblDogovoriGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.ttblDogovoriGridBigBase_DataInsert);
            this.tblDogovoriGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblDogovoriGridBigBase_dataSaveAll);
            this.tblDogovoriGridBig.DoubleClick += new System.EventHandler(this.tblDogovoriGridBigBase_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Реден број";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn3.HeaderText = "Назив";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Zabeleska
            // 
            this.Zabeleska.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zabeleska.DataPropertyName = "Zabeleska";
            this.Zabeleska.HeaderText = "Забелешка";
            this.Zabeleska.Name = "Zabeleska";
            this.Zabeleska.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DatumOd";
            this.dataGridViewTextBoxColumn5.HeaderText = "Датум ОД";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DatumDo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Датум ДО";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // BrojNaDogovor
            // 
            this.BrojNaDogovor.DataPropertyName = "BrojNaDogovor";
            this.BrojNaDogovor.HeaderText = "Број на договор";
            this.BrojNaDogovor.Name = "BrojNaDogovor";
            this.BrojNaDogovor.ReadOnly = true;
            // 
            // BrojNaTender
            // 
            this.BrojNaTender.DataPropertyName = "BrojNaTender";
            this.BrojNaTender.HeaderText = "Број на тендер";
            this.BrojNaTender.Name = "BrojNaTender";
            this.BrojNaTender.ReadOnly = true;
            // 
            // frmDogovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 667);
            this.Name = "frmDogovori";
            this.Text = "frmDogovori";
            this.Load += new System.EventHandler(this.frmDogovori_Load);
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materijalnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogovoriGridBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterijalnoDataSet materijalnoDataSet;
        private System.Windows.Forms.BindingSource tblDogovoriBindingSource;
        private MaterijalnoDataSetTableAdapters.tblDogovoriTableAdapter tblDogovoriTableAdapter;
        private MaterijalnoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig tblDogovoriGridBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zabeleska;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNaDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNaTender;
    }
}
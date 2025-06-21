namespace BSSR.Forms
{
    partial class frmKursnaLista
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
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblKursnaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKursnaListaTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblKursnaListaTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblKursnaListaGridBig = new BssBase.GridBig();
            this.tblValutiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblValutiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblValutiTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblValutaID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblKursnaListaGridBig);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblKursnaListaGridBig, 0);
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
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKursnaListaBindingSource
            // 
            this.tblKursnaListaBindingSource.DataMember = "tblKursnaLista";
            this.tblKursnaListaBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblKursnaListaTableAdapter
            // 
            this.tblKursnaListaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblKursnaListaTableAdapter = this.tblKursnaListaTableAdapter;
            this.tableAdapterManager.tblNalogStavkiTableAdapter = null;
            this.tableAdapterManager.tblNalogTableAdapter = null;
            this.tableAdapterManager.tblNormativiSodriznaIznosTableAdapter = null;
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
            this.tableAdapterManager.tblValutiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblKursnaListaGridBig
            // 
            this.tblKursnaListaGridBig.AllowUserToAddRows = false;
            this.tblKursnaListaGridBig.AllowUserToDeleteRows = false;
            this.tblKursnaListaGridBig.AllowUserToOrderColumns = true;
            this.tblKursnaListaGridBig.AssemblyToLoad = "BSSR";
            this.tblKursnaListaGridBig.AutoGenerateColumns = false;
            this.tblKursnaListaGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKursnaListaGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tblValutaID,
            this.Kurs});
            this.tblKursnaListaGridBig.DataSource = this.tblKursnaListaBindingSource;
            this.tblKursnaListaGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKursnaListaGridBig.EditForm = "BSSR.Forms.frmKursnaListaEdit";
            this.tblKursnaListaGridBig.FilterForm = null;
            this.tblKursnaListaGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblKursnaListaGridBig.MultiSelect = false;
            this.tblKursnaListaGridBig.Name = "tblKursnaListaGridBig";
            this.tblKursnaListaGridBig.PrimaryKey = "ID";
            this.tblKursnaListaGridBig.ReadOnly = true;
            this.tblKursnaListaGridBig.reportCenter = false;
            this.tblKursnaListaGridBig.ReportName = null;
            this.tblKursnaListaGridBig.RowTemplate.Height = 36;
            this.tblKursnaListaGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblKursnaListaGridBig.Size = new System.Drawing.Size(996, 329);
            this.tblKursnaListaGridBig.SQLCommandQuery = null;
            this.tblKursnaListaGridBig.TabIndex = 2;
            this.tblKursnaListaGridBig.UpdateTable = null;
            this.tblKursnaListaGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblKursnaListagrdBase_DataInsert);
            this.tblKursnaListaGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblKursnaListagrdBase_dataSaveAll);
            this.tblKursnaListaGridBig.DoubleClick += new System.EventHandler(this.tblKursnaListagrdBase_DoubleClick);
            // 
            // tblValutiBindingSource
            // 
            this.tblValutiBindingSource.DataMember = "tblValuti";
            this.tblValutiBindingSource.DataSource = this.bSSSDataset;
            // 
            // tblValutiTableAdapter
            // 
            this.tblValutiTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Реден број";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // tblValutaID
            // 
            this.tblValutaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblValutaID.DataPropertyName = "tblValutaID";
            this.tblValutaID.DataSource = this.tblValutiBindingSource;
            this.tblValutaID.DisplayMember = "Opis";
            this.tblValutaID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tblValutaID.HeaderText = "Валута";
            this.tblValutaID.MinimumWidth = 100;
            this.tblValutaID.Name = "tblValutaID";
            this.tblValutaID.ReadOnly = true;
            this.tblValutaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblValutaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tblValutaID.ValueMember = "ID";
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Курс";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // frmKursnaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmKursnaLista";
            this.Text = "Курсна листа";
            this.Load += new System.EventHandler(this.frmKursnaLista_Load);
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKursnaListaGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblKursnaListaBindingSource;
        private BSSSDatasetTableAdapters.tblKursnaListaTableAdapter tblKursnaListaTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig tblKursnaListaGridBig;
        private System.Windows.Forms.BindingSource tblValutiBindingSource;
        private BSSSDatasetTableAdapters.tblValutiTableAdapter tblValutiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn tblValutaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
    }
}
namespace BSSR.Forms
{
    partial class frmValuti
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
            this.tblValutiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblValutiTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblValutiTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this.tblValutiGridBig = new BssBase.GridBig();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kratenka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiGridBig)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblValutiGridBig);
            this.MainPanel.Size = new System.Drawing.Size(998, 583);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblValutiGridBig, 0);
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
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 507);
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.tblValutiTableAdapter = this.tblValutiTableAdapter;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.viewArtikliTableAdapter = null;
            // 
            // tblValutiGridBig
            // 
            this.tblValutiGridBig.AllowUserToAddRows = false;
            this.tblValutiGridBig.AllowUserToDeleteRows = false;
            this.tblValutiGridBig.AllowUserToOrderColumns = true;
            this.tblValutiGridBig.AssemblyToLoad = "BSSR";
            this.tblValutiGridBig.AutoGenerateColumns = false;
            this.tblValutiGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblValutiGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Opis,
            this.Kratenka});
            this.tblValutiGridBig.DataSource = this.tblValutiBindingSource;
            this.tblValutiGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblValutiGridBig.EditForm = "BSSR.Forms.frmValutiEdit";
            this.tblValutiGridBig.FilterForm = null;
            this.tblValutiGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblValutiGridBig.MultiSelect = false;
            this.tblValutiGridBig.Name = "tblValutiGridBig";
            this.tblValutiGridBig.PrimaryKey = "ID";
            this.tblValutiGridBig.ReadOnly = true;
            this.tblValutiGridBig.reportCenter = false;
            this.tblValutiGridBig.ReportName = null;
            this.tblValutiGridBig.RowTemplate.Height = 36;
            this.tblValutiGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblValutiGridBig.Size = new System.Drawing.Size(996, 339);
            this.tblValutiGridBig.SQLCommandQuery = null;
            this.tblValutiGridBig.TabIndex = 2;
            this.tblValutiGridBig.UpdateTable = null;
            this.tblValutiGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblValutigrdBase_DataInsert);
            this.tblValutiGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblValutigrdBase_dataSaveAll);
            this.tblValutiGridBig.DoubleClick += new System.EventHandler(this.tblValutigrdBase_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Реден број";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Опис";
            this.Opis.MinimumWidth = 100;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Kratenka
            // 
            this.Kratenka.DataPropertyName = "Kratenka";
            this.Kratenka.HeaderText = "Кратенка";
            this.Kratenka.Name = "Kratenka";
            this.Kratenka.ReadOnly = true;
            // 
            // frmValuti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 583);
            this.Name = "frmValuti";
            this.Text = "Валути";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblValutiGridBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblValutiBindingSource;
        private BSSSDatasetTableAdapters.tblValutiTableAdapter tblValutiTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig tblValutiGridBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kratenka;
    }
}
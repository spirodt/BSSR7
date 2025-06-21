namespace BSSR.Forms
{
    partial class frmLogovi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bSSSDataset = new BSSR.BSSSDataset();
            this._tblLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._tblLogTableAdapter = new BSSR.BSSSDatasetTableAdapters._tblLogTableAdapter();
            this.tableAdapterManager = new BSSR.BSSSDatasetTableAdapters.TableAdapterManager();
            this._tblLogGridBig = new BssBase.GridBig();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tblLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tblLogGridBig)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this._tblLogGridBig);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this._tblLogGridBig, 0);
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
            // _tblLogBindingSource
            // 
            this._tblLogBindingSource.DataMember = "_tblLog";
            this._tblLogBindingSource.DataSource = this.bSSSDataset;
            // 
            // _tblLogTableAdapter
            // 
            this._tblLogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._tblLogTableAdapter = this._tblLogTableAdapter;
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
            this.tableAdapterManager.tblNormativTableAdapter = null;
            this.tableAdapterManager.tblObjektiTableAdapter = null;
            this.tableAdapterManager.tblPodgrupaIDTableAdapter = null;
            this.tableAdapterManager.tblPrevodiTableAdapter = null;
            this.tableAdapterManager.tblRoljiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaStavkiTableAdapter = null;
            this.tableAdapterManager.tblSmetkaTableAdapter = null;
            this.tableAdapterManager.tblUserConfigsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSSR.BSSSDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _tblLogGridBig
            // 
            this._tblLogGridBig.AllowUserToAddRows = false;
            this._tblLogGridBig.AllowUserToDeleteRows = false;
            this._tblLogGridBig.AllowUserToOrderColumns = true;
            this._tblLogGridBig.AssemblyToLoad = null;
            this._tblLogGridBig.AutoGenerateColumns = false;
            this._tblLogGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tblLogGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this._tblLogGridBig.DataSource = this._tblLogBindingSource;
            this._tblLogGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblLogGridBig.EditForm = null;
            this._tblLogGridBig.FilterForm = null;
            this._tblLogGridBig.Location = new System.Drawing.Point(0, 168);
            this._tblLogGridBig.Name = "_tblLogGridBig";
            this._tblLogGridBig.PrimaryKey = "ID";
            this._tblLogGridBig.ReadOnly = true;
            this._tblLogGridBig.reportCenter = false;
            this._tblLogGridBig.ReportName = null;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this._tblLogGridBig.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this._tblLogGridBig.RowTemplate.Height = 36;
            this._tblLogGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._tblLogGridBig.Size = new System.Drawing.Size(996, 329);
            this._tblLogGridBig.SQLCommandQuery = null;
            this._tblLogGridBig.TabIndex = 2;
            this._tblLogGridBig.UpdateTable = "_tblLog";
           
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Sesija";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сесија";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Akcija";
            this.dataGridViewTextBoxColumn3.HeaderText = "Акција";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DatumIVreme";
            this.dataGridViewTextBoxColumn4.HeaderText = "Датум и Време";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // frmLogovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmLogovi";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tblLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tblLogGridBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource _tblLogBindingSource;
        private BSSSDatasetTableAdapters._tblLogTableAdapter _tblLogTableAdapter;
        private BSSSDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private BssBase.GridBig _tblLogGridBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
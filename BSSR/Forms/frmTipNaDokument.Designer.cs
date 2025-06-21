namespace BSSR.Forms
{
    partial class frmTipNaDokument
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
            this.tblTipNaDokumentGridBig = new BssBase.GridBig();
            this.tblTipNaDokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblTipNaDokumentTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblTipNaDokumentTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipNaKnizenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeKnizi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblTipNaDokumentGridBig);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblTipNaDokumentGridBig, 0);
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrebaraj.Location = new System.Drawing.Point(871, 124);
            // 
            // txtBaraj
            // 
            this.txtBaraj.Location = new System.Drawing.Point(570, 124);
            // 
            // btnIcistiBaraj
            // 
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIcistiBaraj.Location = new System.Drawing.Point(932, 124);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(799, 4);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 497);
            this.PanelFooter.Size = new System.Drawing.Size(996, 74);
            // 
            // tblTipNaDokumentGridBig
            // 
            this.tblTipNaDokumentGridBig.AllowUserToAddRows = false;
            this.tblTipNaDokumentGridBig.AllowUserToDeleteRows = false;
            this.tblTipNaDokumentGridBig.AllowUserToOrderColumns = true;
            this.tblTipNaDokumentGridBig.AssemblyToLoad = "BSSR";
            this.tblTipNaDokumentGridBig.AutoGenerateColumns = false;
            this.tblTipNaDokumentGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTipNaDokumentGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naslov,
            this.Naziv,
            this.ReportFileName,
            this.TipNaKnizenje,
            this.SeKnizi,
            this.Status});
            this.tblTipNaDokumentGridBig.DataSource = this.tblTipNaDokumentBindingSource;
            this.tblTipNaDokumentGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTipNaDokumentGridBig.EditForm = "BSSR.Forms.frmTipNaDokumentEdit";
            this.tblTipNaDokumentGridBig.FilterForm = null;
            this.tblTipNaDokumentGridBig.HidenColumns = null;
            this.tblTipNaDokumentGridBig.KreirajPredefiniraniPolinja = false;
            this.tblTipNaDokumentGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblTipNaDokumentGridBig.MultiSelect = false;
            this.tblTipNaDokumentGridBig.Name = "tblTipNaDokumentGridBig";
            this.tblTipNaDokumentGridBig.PrimaryKey = "ID";
            this.tblTipNaDokumentGridBig.ReadOnly = true;
            this.tblTipNaDokumentGridBig.ReadOnlyColumns = null;
            this.tblTipNaDokumentGridBig.reportCenter = false;
            this.tblTipNaDokumentGridBig.ReportName = null;
            this.tblTipNaDokumentGridBig.RowTemplate.Height = 36;
            this.tblTipNaDokumentGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTipNaDokumentGridBig.Size = new System.Drawing.Size(996, 329);
            this.tblTipNaDokumentGridBig.SQLCommandQuery = null;
            this.tblTipNaDokumentGridBig.TabIndex = 2;
            this.tblTipNaDokumentGridBig.UpdateTable = null;
            this.tblTipNaDokumentGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.tblTipNaDokumentgrdBase_DataInsert);
            this.tblTipNaDokumentGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.tblTipNaDokumentgrdBase_dataSaveAll);
            this.tblTipNaDokumentGridBig.DoubleClick += new System.EventHandler(this.tblTipNaDokumentgrdBase_DoubleClick);
            // 
            // tblTipNaDokumentBindingSource
            // 
            this.tblTipNaDokumentBindingSource.DataMember = "tblTipNaDokument";
            this.tblTipNaDokumentBindingSource.DataSource = this.bSSSDataset;
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTipNaDokumentTableAdapter
            // 
            this.tblTipNaDokumentTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Реден број";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Naslov
            // 
            this.Naslov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Наслов";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Назив";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // ReportFileName
            // 
            this.ReportFileName.DataPropertyName = "ReportFileName";
            this.ReportFileName.HeaderText = "Име на репорт";
            this.ReportFileName.Name = "ReportFileName";
            this.ReportFileName.ReadOnly = true;
            // 
            // TipNaKnizenje
            // 
            this.TipNaKnizenje.DataPropertyName = "TipNaKnizenje";
            this.TipNaKnizenje.HeaderText = "Тип на книжење";
            this.TipNaKnizenje.Name = "TipNaKnizenje";
            this.TipNaKnizenje.ReadOnly = true;
            // 
            // SeKnizi
            // 
            this.SeKnizi.DataPropertyName = "SeKnizi";
            this.SeKnizi.HeaderText = "Се книжи";
            this.SeKnizi.Name = "SeKnizi";
            this.SeKnizi.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // frmTipNaDokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmTipNaDokument";
            this.Text = "Типови на документи";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipNaDokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BssBase.GridBig tblTipNaDokumentGridBig;
        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblTipNaDokumentBindingSource;
        private BSSSDatasetTableAdapters.tblTipNaDokumentTableAdapter tblTipNaDokumentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipNaKnizenje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeKnizi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
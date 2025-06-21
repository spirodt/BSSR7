namespace BSSR.Forms
{
    partial class frmPresmetkovniEdicini
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
            this.tblPresmetkovniEdiniciGridBig = new BssBase.GridBig();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zabeleska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPresmetkovniEdiniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSSSDataset = new BSSR.BSSSDataset();
            this.tblPresmetkovniEdiniciTableAdapter = new BSSR.BSSSDatasetTableAdapters.tblPresmetkovniEdiniciTableAdapter();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPresmetkovniEdiniciGridBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPresmetkovniEdiniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tblPresmetkovniEdiniciGridBig);
            this.MainPanel.Controls.SetChildIndex(this.PanelHeader, 0);
            this.MainPanel.Controls.SetChildIndex(this.PanelFooter, 0);
            this.MainPanel.Controls.SetChildIndex(this.tblPresmetkovniEdiniciGridBig, 0);
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
            // tblPresmetkovniEdiniciGridBig
            // 
            this.tblPresmetkovniEdiniciGridBig.AllowUserToAddRows = false;
            this.tblPresmetkovniEdiniciGridBig.AllowUserToDeleteRows = false;
            this.tblPresmetkovniEdiniciGridBig.AllowUserToOrderColumns = true;
            this.tblPresmetkovniEdiniciGridBig.AssemblyToLoad = "BSSR";
            this.tblPresmetkovniEdiniciGridBig.AutoGenerateColumns = false;
            this.tblPresmetkovniEdiniciGridBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPresmetkovniEdiniciGridBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sifra,
            this.Naziv,
            this.FirmaID,
            this.Zabeleska,
            this.Status});
            this.tblPresmetkovniEdiniciGridBig.DataSource = this.tblPresmetkovniEdiniciBindingSource;
            this.tblPresmetkovniEdiniciGridBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPresmetkovniEdiniciGridBig.EditForm = "BSSR.Forms.frmPresmetkovniEdiciniEdit";
            this.tblPresmetkovniEdiniciGridBig.FilterForm = null;
            this.tblPresmetkovniEdiniciGridBig.HidenColumns = null;
            this.tblPresmetkovniEdiniciGridBig.KreirajPredefiniraniPolinja = false;
            this.tblPresmetkovniEdiniciGridBig.Location = new System.Drawing.Point(0, 168);
            this.tblPresmetkovniEdiniciGridBig.MultiSelect = false;
            this.tblPresmetkovniEdiniciGridBig.Name = "tblPresmetkovniEdiniciGridBig";
            this.tblPresmetkovniEdiniciGridBig.PrimaryKey = "ID";
            this.tblPresmetkovniEdiniciGridBig.ReadOnly = true;
            this.tblPresmetkovniEdiniciGridBig.ReadOnlyColumns = null;
            this.tblPresmetkovniEdiniciGridBig.reportCenter = false;
            this.tblPresmetkovniEdiniciGridBig.ReportName = null;
            this.tblPresmetkovniEdiniciGridBig.RowTemplate.Height = 36;
            this.tblPresmetkovniEdiniciGridBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPresmetkovniEdiniciGridBig.Size = new System.Drawing.Size(996, 329);
            this.tblPresmetkovniEdiniciGridBig.SQLCommandQuery = null;
            this.tblPresmetkovniEdiniciGridBig.TabIndex = 2;
            this.tblPresmetkovniEdiniciGridBig.UpdateTable = null;
            this.tblPresmetkovniEdiniciGridBig.DataInsert += new BssBase.grdBase.dataInsertEnd(this.PresmetkovniEdicinigrdBase_DataInsert);
            this.tblPresmetkovniEdiniciGridBig.dataSaveAll += new BssBase.grdBase.dataSave(this.PresmetkovniEdicinigrdBase_dataSaveAll);
            this.tblPresmetkovniEdiniciGridBig.DoubleClick += new System.EventHandler(this.PresmetkovniEdicinigrdBase_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Реден број";
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
            this.Sifra.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Назив";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // FirmaID
            // 
            this.FirmaID.DataPropertyName = "FirmaID";
            this.FirmaID.HeaderText = "Фирма";
            this.FirmaID.Name = "FirmaID";
            this.FirmaID.ReadOnly = true;
            this.FirmaID.Visible = false;
            // 
            // Zabeleska
            // 
            this.Zabeleska.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zabeleska.DataPropertyName = "Zabeleska";
            this.Zabeleska.HeaderText = "Забелешка";
            this.Zabeleska.Name = "Zabeleska";
            this.Zabeleska.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // tblPresmetkovniEdiniciBindingSource
            // 
            this.tblPresmetkovniEdiniciBindingSource.DataMember = "tblPresmetkovniEdinici";
            this.tblPresmetkovniEdiniciBindingSource.DataSource = this.bSSSDataset;
            // 
            // bSSSDataset
            // 
            this.bSSSDataset.DataSetName = "BSSSDataset";
            this.bSSSDataset.EnforceConstraints = false;
            this.bSSSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPresmetkovniEdiniciTableAdapter
            // 
            this.tblPresmetkovniEdiniciTableAdapter.ClearBeforeFill = true;
            // 
            // frmPresmetkovniEdicini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Name = "frmPresmetkovniEdicini";
            this.Text = "Пресметковни единици";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPresmetkovniEdiniciGridBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPresmetkovniEdiniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSSSDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BssBase.GridBig tblPresmetkovniEdiniciGridBig;
        private BSSSDataset bSSSDataset;
        private System.Windows.Forms.BindingSource tblPresmetkovniEdiniciBindingSource;
        private BSSSDatasetTableAdapters.tblPresmetkovniEdiniciTableAdapter tblPresmetkovniEdiniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zabeleska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
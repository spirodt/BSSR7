namespace BssBase.Elements {
	partial class SelectBox {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBox));
            this.btnPotvrdi = new BssBase.Elements.btnPotvrdi();
            this.btnZatvori = new BssBase.Elements.btnZatvori();
            this.gridBig1 = new BssBase.GridBig();
            this.txtSaldo = new System.Windows.Forms.Label();
            this.txtDolzi = new System.Windows.Forms.Label();
            this.txtPobaruva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBig1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            resources.ApplyResources(this.btnPotvrdi, "btnPotvrdi");
            this.btnPotvrdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPotvrdi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnZatvori
            // 
            resources.ApplyResources(this.btnZatvori, "btnZatvori");
            this.btnZatvori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // gridBig1
            // 
            this.gridBig1.AllowUserToAddRows = false;
            this.gridBig1.AllowUserToDeleteRows = false;
            this.gridBig1.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.gridBig1, "gridBig1");
            this.gridBig1.AssemblyToLoad = null;
            this.gridBig1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBig1.EditForm = null;
            this.gridBig1.FilterForm = null;
            this.gridBig1.HidenColumns = null;
            this.gridBig1.KreirajPredefiniraniPolinja = false;
            this.gridBig1.MultiSelect = false;
            this.gridBig1.Name = "gridBig1";
            this.gridBig1.PrimaryKey = "ID";
            this.gridBig1.ReadOnly = true;
            this.gridBig1.ReadOnlyColumns = null;
            this.gridBig1.reportCenter = false;
            this.gridBig1.ReportName = null;
            this.gridBig1.RowTemplate.Height = 36;
            this.gridBig1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBig1.UpdateTable = null;
            this.gridBig1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBig1_CellClick);
            this.gridBig1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridBig1_CellMouseClick);
            // 
            // txtSaldo
            // 
            resources.ApplyResources(this.txtSaldo, "txtSaldo");
            this.txtSaldo.Name = "txtSaldo";
            // 
            // txtDolzi
            // 
            resources.ApplyResources(this.txtDolzi, "txtDolzi");
            this.txtDolzi.Name = "txtDolzi";
            // 
            // txtPobaruva
            // 
            resources.ApplyResources(this.txtPobaruva, "txtPobaruva");
            this.txtPobaruva.Name = "txtPobaruva";
            // 
            // SelectBox
            // 
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnZatvori;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.txtPobaruva);
            this.Controls.Add(this.txtDolzi);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.gridBig1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPotvrdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "SelectBox";
            this.Load += new System.EventHandler(this.SelectBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBig1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private btnPotvrdi btnPotvrdi;
        private btnZatvori btnZatvori;
        private GridBig gridBig1;
        private System.Windows.Forms.Label txtSaldo;
        private System.Windows.Forms.Label txtDolzi;
        private System.Windows.Forms.Label txtPobaruva;
    }
}

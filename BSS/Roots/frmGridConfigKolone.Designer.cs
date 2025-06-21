namespace BssBase.Forms {
	partial class frmGridConfigKolone {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGridConfigKolone));
            this.btnZatvori = new BssBase.Elements.btnZatvori();
            this.btnPotvrdi = new BssBase.Elements.btnPotvrdi();
            this.ListaChk = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
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
            // ListaChk
            // 
            resources.ApplyResources(this.ListaChk, "ListaChk");
            this.ListaChk.CheckOnClick = true;
            this.ListaChk.FormattingEnabled = true;
            this.ListaChk.Name = "ListaChk";
            // 
            // frmGridConfigKolone
            // 
            this.AcceptButton = this.btnPotvrdi;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.Controls.Add(this.ListaChk);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "frmGridConfigKolone";
            this.Load += new System.EventHandler(this.frmGridConfigKolone_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private Elements.btnZatvori btnZatvori;
		private Elements.btnPotvrdi btnPotvrdi;
		private System.Windows.Forms.CheckedListBox ListaChk;
	}
}
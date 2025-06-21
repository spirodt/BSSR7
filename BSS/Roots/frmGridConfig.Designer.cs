namespace BssBase.Forms {
	partial class frmGridConfig {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGridConfig));
            this.Configs = new BssBase.Classes.GridProperty();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.btnZatvori1 = new BssBase.Elements.btnZatvori();
            this.SuspendLayout();
            // 
            // Configs
            // 
            resources.ApplyResources(this.Configs, "Configs");
            this.Configs.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Configs.Name = "Configs";
            // 
            // btnPotvrdi1
            // 
            resources.ApplyResources(this.btnPotvrdi1, "btnPotvrdi1");
            this.btnPotvrdi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPotvrdi1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
            // 
            // btnZatvori1
            // 
            resources.ApplyResources(this.btnZatvori1, "btnZatvori1");
            this.btnZatvori1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZatvori1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori1.Name = "btnZatvori1";
            this.btnZatvori1.UseVisualStyleBackColor = false;
            this.btnZatvori1.Click += new System.EventHandler(this.btnZatvori1_Click);
            // 
            // frmGridConfig
            // 
            this.AcceptButton = this.btnPotvrdi1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori1;
            this.Controls.Add(this.btnZatvori1);
            this.Controls.Add(this.btnPotvrdi1);
            this.Controls.Add(this.Configs);
            this.Name = "frmGridConfig";
            this.Load += new System.EventHandler(this.frmGridConfig_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private Classes.GridProperty Configs;
		private Elements.btnPotvrdi btnPotvrdi1;
		private Elements.btnZatvori btnZatvori1;
	}
}
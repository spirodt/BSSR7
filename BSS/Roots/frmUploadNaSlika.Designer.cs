namespace BssBase {
	partial class frmUploadNaSlika {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUploadNaSlika));
            this.Pateka = new BssBase.txtBase();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.btnExi = new System.Windows.Forms.Button();
            this.Poleslika = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pateka
            // 
            resources.ApplyResources(this.Pateka, "Pateka");
            this.Pateka.AssemblyStr = null;
            this.Pateka.C_FillWithZeros = false;
            this.Pateka.C_OnlyNumbers = false;
            this.Pateka.C_RegEx = false;
            this.Pateka.C_ShowRedOnLeaveIfEmpty = false;
            this.Pateka.ColumnName1 = null;
            this.Pateka.ColumnName2 = null;
            this.Pateka.ColumnName3 = null;
            this.Pateka.ColumnName4 = null;
            this.Pateka.ColumnName5 = null;
            this.Pateka.ColumnName6 = null;
            this.Pateka.ColumnName7 = null;
            this.Pateka.daliCetiri = false;
            this.Pateka.Format = null;
            this.Pateka.formToOpen = null;
            this.Pateka.iscistiGreenNaLeave = false;
            this.Pateka.KoristiFilterNaDatasource = false;
            this.Pateka.MakedonskiJazik = false;
            this.Pateka.MinLength = 0;
            this.Pateka.Name = "Pateka";
            this.Pateka.PopulateOtherFields = false;
            this.Pateka.regularExpression = null;
            this.Pateka.SelektrijaNaFokus = false;
            // 
            // Progress
            // 
            resources.ApplyResources(this.Progress, "Progress");
            this.Progress.Name = "Progress";
            // 
            // btnExi
            // 
            resources.ApplyResources(this.btnExi, "btnExi");
            this.btnExi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExi.Name = "btnExi";
            this.btnExi.UseVisualStyleBackColor = true;
            this.btnExi.Click += new System.EventHandler(this.btnExi_Click);
            // 
            // Poleslika
            // 
            resources.ApplyResources(this.Poleslika, "Poleslika");
            this.Poleslika.FormattingEnabled = true;
            this.Poleslika.Items.AddRange(new object[] {
            resources.GetString("Poleslika.Items"),
            resources.GetString("Poleslika.Items1"),
            resources.GetString("Poleslika.Items2")});
            this.Poleslika.Name = "Poleslika";
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Image = global::BssBase.Properties.Resources._001_24;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmUploadNaSlika
            // 
            this.AcceptButton = this.btnOpen;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExi;
            this.Controls.Add(this.Poleslika);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Pateka);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnExi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUploadNaSlika";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOpen;
		private BssBase.txtBase Pateka;
		private System.Windows.Forms.Button btnExi;
		public System.Windows.Forms.ProgressBar Progress;
		private System.Windows.Forms.ComboBox Poleslika;
	}
}
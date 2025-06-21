namespace BSS {
	partial class PrintPreview {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( PrintPreview ) );
			this.ReportPreview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			
			
			this.SuspendLayout();
			// 
			// ReportPreview
			// 
			resources.ApplyResources( this.ReportPreview, "ReportPreview" );
			this.ReportPreview.ActiveViewIndex = -1;
			this.ReportPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ReportPreview.Cursor = System.Windows.Forms.Cursors.Default;
			this.ReportPreview.Name = "ReportPreview";
			// 
			// elkompBaseDataSet
			// 
			
			// 
			// PrintPreview
			// 
			resources.ApplyResources( this, "$this" );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.ReportPreview );
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintPreview";
			this.ShowIcon = false;
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			
			this.ResumeLayout( false );

		}

		#endregion

		public CrystalDecisions.Windows.Forms.CrystalReportViewer ReportPreview;
		public System.Windows.Forms.BindingSource PodatociZaFirma;
		

		
		
	}
}
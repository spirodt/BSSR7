namespace BSSR.Forms {
	partial class frmConfig {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.gridConfig = new BssBase.DevGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConfig
            // 
            this.gridConfig.AssemblyToLoad = null;
            this.gridConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConfig.EditForm = null;
            this.gridConfig.FilterForm = null;
            this.gridConfig.Location = new System.Drawing.Point(0, 0);
            this.gridConfig.MainView = this.gridView1;
            this.gridConfig.Name = "gridConfig";
            this.gridConfig.PrimaryKey = null;
            this.gridConfig.reportCenter = false;
            this.gridConfig.ReportName = null;
            this.gridConfig.Size = new System.Drawing.Size(830, 582);
            this.gridConfig.TabIndex = 1;
            this.gridConfig.UpdateTable = null;
            this.gridConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridConfig;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 582);
            this.Controls.Add(this.gridConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конфигурација";
            ((System.ComponentModel.ISupportInitialize)(this.gridConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}



        #endregion

        private BssBase.DevGrid gridConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
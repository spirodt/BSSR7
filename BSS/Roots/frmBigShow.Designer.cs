namespace BssBase
{
	partial class frmBigShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBigShow));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.DisplayError = new System.Windows.Forms.LinkLabel();
            this.btnOk = new BssBase.Elements.btnPotvrdi();
            this.btnZatvori = new BssBase.Elements.btnZatvori();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnIcistiBaraj = new System.Windows.Forms.Button();
            this.txtBaraj = new BssBase.txtBase();
            this.btnPrebaraj = new System.Windows.Forms.Button();
            this.Meni = new System.Windows.Forms.MenuStrip();
            this.btnNovZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditirajZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBlokiraj = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzbrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZatvoriTop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.Navigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Bsource = new System.Windows.Forms.BindingSource();
            this.errorProviderDole = new System.Windows.Forms.ErrorProvider();
            this.MainPanel.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.Meni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.PanelFooter);
            this.MainPanel.Controls.Add(this.PanelHeader);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.Beige;
            this.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFooter.Controls.Add(this.DisplayError);
            this.PanelFooter.Controls.Add(this.btnOk);
            this.PanelFooter.Controls.Add(this.btnZatvori);
            resources.ApplyResources(this.PanelFooter, "PanelFooter");
            this.PanelFooter.Name = "PanelFooter";
            // 
            // DisplayError
            // 
            resources.ApplyResources(this.DisplayError, "DisplayError");
            this.DisplayError.LinkColor = System.Drawing.Color.Red;
            this.DisplayError.Name = "DisplayError";
            this.DisplayError.TabStop = true;
            this.DisplayError.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DisplayError_LinkClicked);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Image = global::BssBase.Properties.Resources.accept_32;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnZatvori
            // 
            resources.ApplyResources(this.btnZatvori, "btnZatvori");
            this.btnZatvori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Image = global::BssBase.Properties.Resources.close_32;
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Beige;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.btnIcistiBaraj);
            this.PanelHeader.Controls.Add(this.txtBaraj);
            this.PanelHeader.Controls.Add(this.btnPrebaraj);
            this.PanelHeader.Controls.Add(this.Meni);
            this.PanelHeader.Controls.Add(this.Navigator);
            resources.ApplyResources(this.PanelHeader, "PanelHeader");
            this.PanelHeader.Name = "PanelHeader";
            // 
            // btnIcistiBaraj
            // 
            resources.ApplyResources(this.btnIcistiBaraj, "btnIcistiBaraj");
            this.btnIcistiBaraj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIcistiBaraj.Image = global::BssBase.Properties.Resources.undoNovo;
            this.btnIcistiBaraj.Name = "btnIcistiBaraj";
            this.btnIcistiBaraj.UseVisualStyleBackColor = false;
            this.btnIcistiBaraj.Click += new System.EventHandler(this.btnIcistiBaraj_Click);
            // 
            // txtBaraj
            // 
            resources.ApplyResources(this.txtBaraj, "txtBaraj");
            this.txtBaraj.AssemblyStr = null;
            this.txtBaraj.C_FillWithZeros = false;
            this.txtBaraj.C_OnlyNumbers = false;
            this.txtBaraj.C_RegEx = false;
            this.txtBaraj.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBaraj.ColumnName1 = null;
            this.txtBaraj.ColumnName2 = null;
            this.txtBaraj.ColumnName3 = null;
            this.txtBaraj.ColumnName4 = null;
            this.txtBaraj.ColumnName5 = null;
            this.txtBaraj.ColumnName6 = null;
            this.txtBaraj.ColumnName7 = null;
            this.txtBaraj.daliCetiri = false;
            this.txtBaraj.Format = null;
            this.txtBaraj.formToOpen = null;
            this.txtBaraj.iscistiGreenNaLeave = false;
            this.txtBaraj.KoristiFilterNaDatasource = false;
            this.txtBaraj.MakedonskiJazik = false;
            this.txtBaraj.MinLength = 0;
            this.txtBaraj.Name = "txtBaraj";
            this.txtBaraj.PopulateOtherFields = false;
            this.txtBaraj.regularExpression = null;
            this.txtBaraj.SelektrijaNaFokus = false;
            this.txtBaraj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBaraj_KeyDown);
            // 
            // btnPrebaraj
            // 
            resources.ApplyResources(this.btnPrebaraj, "btnPrebaraj");
            this.btnPrebaraj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrebaraj.Image = global::BssBase.Properties.Resources.search_32;
            this.btnPrebaraj.Name = "btnPrebaraj";
            this.btnPrebaraj.UseVisualStyleBackColor = false;
            this.btnPrebaraj.Click += new System.EventHandler(this.btnPrebaraj_Click);
            // 
            // Meni
            // 
            this.Meni.AllowMerge = false;
            this.Meni.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.Meni, "Meni");
            this.Meni.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Meni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovZapis,
            this.btnEditirajZapis,
            this.btnBlokiraj,
            this.btnIzbrisi,
            this.btnZatvoriTop,
            this.btnFilter});
            this.Meni.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Meni.Name = "Meni";
            this.Meni.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Meni.ShowItemToolTips = true;
            // 
            // btnNovZapis
            // 
            this.btnNovZapis.Image = global::BssBase.Properties.Resources.add_1_icon__1_;
            resources.ApplyResources(this.btnNovZapis, "btnNovZapis");
            this.btnNovZapis.Name = "btnNovZapis";
            this.btnNovZapis.Click += new System.EventHandler(this.NovZapis);
            // 
            // btnEditirajZapis
            // 
            this.btnEditirajZapis.Image = global::BssBase.Properties.Resources.edit;
            resources.ApplyResources(this.btnEditirajZapis, "btnEditirajZapis");
            this.btnEditirajZapis.Name = "btnEditirajZapis";
            this.btnEditirajZapis.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnEditirajZapis.Click += new System.EventHandler(this.IzmeniZapis);
            // 
            // btnBlokiraj
            // 
            this.btnBlokiraj.Image = global::BssBase.Properties.Resources.block;
            resources.ApplyResources(this.btnBlokiraj, "btnBlokiraj");
            this.btnBlokiraj.Name = "btnBlokiraj";
            this.btnBlokiraj.Click += new System.EventHandler(this.Blokiraj);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Image = global::BssBase.Properties.Resources.delete;
            resources.ApplyResources(this.btnIzbrisi, "btnIzbrisi");
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnZatvoriTop
            // 
            this.btnZatvoriTop.Image = global::BssBase.Properties.Resources.close;
            resources.ApplyResources(this.btnZatvoriTop, "btnZatvoriTop");
            this.btnZatvoriTop.Name = "btnZatvoriTop";
            this.btnZatvoriTop.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::BssBase.Properties.Resources.search_icon;
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Navigator
            // 
            this.Navigator.AddNewItem = null;
            this.Navigator.BackColor = System.Drawing.Color.Beige;
            this.Navigator.CountItem = this.bindingNavigatorCountItem;
            this.Navigator.DeleteItem = null;
            resources.ApplyResources(this.Navigator, "Navigator");
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.Navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.bindingNavigatorPositionItem;
            this.Navigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::BssBase.Properties.Resources._001_27;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::BssBase.Properties.Resources._001_23;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::BssBase.Properties.Resources._001_21;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::BssBase.Properties.Resources._001_25;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // errorProviderDole
            // 
            this.errorProviderDole.ContainerControl = this;
            // 
            // frmBigShow
            // 
            this.AcceptButton = this.btnPrebaraj;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.Controls.Add(this.MainPanel);
            this.Name = "frmBigShow";
            this.Load += new System.EventHandler(this.frmShow_Load);
            this.Shown += new System.EventHandler(this.frmBigShow_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormaSearch_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.Meni.ResumeLayout(false);
            this.Meni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel MainPanel;
		public System.Windows.Forms.Button btnPrebaraj;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		public System.Windows.Forms.BindingNavigator Navigator;
		public System.Windows.Forms.MenuStrip Meni;
		public System.Windows.Forms.ToolStripMenuItem btnNovZapis;
		public System.Windows.Forms.ToolStripMenuItem btnEditirajZapis;
		public System.Windows.Forms.ToolStripMenuItem btnBlokiraj;
		public System.Windows.Forms.ToolStripMenuItem btnFilter;
		public System.Windows.Forms.ToolStripMenuItem btnZatvoriTop;
		public txtBase txtBaraj;
		protected System.Windows.Forms.Panel PanelHeader;
		public System.Windows.Forms.BindingSource Bsource;
		public System.Windows.Forms.Button btnIcistiBaraj;
		public Elements.btnPotvrdi btnOk;
		public Elements.btnZatvori btnZatvori;
		public System.Windows.Forms.ToolStripMenuItem btnIzbrisi;
		public System.Windows.Forms.Panel PanelFooter;
		private System.Windows.Forms.ErrorProvider errorProviderDole;
		private System.Windows.Forms.LinkLabel DisplayError;
	}
}


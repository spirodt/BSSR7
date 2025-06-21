namespace BssBase
{
    partial class frmShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShow));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.DisplayError = new System.Windows.Forms.LinkLabel();
            this.btnOk = new BssBase.Elements.btnPotvrdi();
            this.btnZatvori = new BssBase.Elements.btnZatvori();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.ImageSearch = new System.Windows.Forms.PictureBox();
            this.btnIcistiBaraj = new System.Windows.Forms.Button();
            this.txtBaraj = new BssBase.txtBase();
            this.Meni = new System.Windows.Forms.MenuStrip();
            this.btnNovZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditirajZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBlokiraj = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzbrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrebaraj = new System.Windows.Forms.Button();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Bsource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderDole = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainPanel.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSearch)).BeginInit();
            this.Meni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.PanelFooter);
            this.MainPanel.Controls.Add(this.PanelHeader);
            this.errorProviderDole.SetError(this.MainPanel, resources.GetString("MainPanel.Error"));
            this.errorProviderDole.SetIconAlignment(this.MainPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("MainPanel.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.MainPanel, ((int)(resources.GetObject("MainPanel.IconPadding"))));
            this.MainPanel.Name = "MainPanel";
            // 
            // PanelFooter
            // 
            resources.ApplyResources(this.PanelFooter, "PanelFooter");
            this.PanelFooter.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFooter.Controls.Add(this.DisplayError);
            this.PanelFooter.Controls.Add(this.btnOk);
            this.PanelFooter.Controls.Add(this.btnZatvori);
            this.errorProviderDole.SetError(this.PanelFooter, resources.GetString("PanelFooter.Error"));
            this.errorProviderDole.SetIconAlignment(this.PanelFooter, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PanelFooter.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.PanelFooter, ((int)(resources.GetObject("PanelFooter.IconPadding"))));
            this.PanelFooter.Name = "PanelFooter";
            // 
            // DisplayError
            // 
            resources.ApplyResources(this.DisplayError, "DisplayError");
            this.errorProviderDole.SetError(this.DisplayError, resources.GetString("DisplayError.Error"));
            this.errorProviderDole.SetIconAlignment(this.DisplayError, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DisplayError.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.DisplayError, ((int)(resources.GetObject("DisplayError.IconPadding"))));
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
            this.errorProviderDole.SetError(this.btnOk, resources.GetString("btnOk.Error"));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnOk, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOk.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnOk, ((int)(resources.GetObject("btnOk.IconPadding"))));
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnZatvori
            // 
            resources.ApplyResources(this.btnZatvori, "btnZatvori");
            this.btnZatvori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProviderDole.SetError(this.btnZatvori, resources.GetString("btnZatvori.Error"));
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnZatvori, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnZatvori.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnZatvori, ((int)(resources.GetObject("btnZatvori.IconPadding"))));
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // PanelHeader
            // 
            resources.ApplyResources(this.PanelHeader, "PanelHeader");
            this.PanelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.ImageSearch);
            this.PanelHeader.Controls.Add(this.btnIcistiBaraj);
            this.PanelHeader.Controls.Add(this.txtBaraj);
            this.PanelHeader.Controls.Add(this.Meni);
            this.PanelHeader.Controls.Add(this.btnPrebaraj);
            this.PanelHeader.Controls.Add(this.Navigator);
            this.errorProviderDole.SetError(this.PanelHeader, resources.GetString("PanelHeader.Error"));
            this.errorProviderDole.SetIconAlignment(this.PanelHeader, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PanelHeader.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.PanelHeader, ((int)(resources.GetObject("PanelHeader.IconPadding"))));
            this.PanelHeader.Name = "PanelHeader";
            // 
            // ImageSearch
            // 
            resources.ApplyResources(this.ImageSearch, "ImageSearch");
            this.errorProviderDole.SetError(this.ImageSearch, resources.GetString("ImageSearch.Error"));
            this.errorProviderDole.SetIconAlignment(this.ImageSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ImageSearch.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.ImageSearch, ((int)(resources.GetObject("ImageSearch.IconPadding"))));
            this.ImageSearch.Name = "ImageSearch";
            this.ImageSearch.TabStop = false;
            // 
            // btnIcistiBaraj
            // 
            resources.ApplyResources(this.btnIcistiBaraj, "btnIcistiBaraj");
            this.btnIcistiBaraj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorProviderDole.SetError(this.btnIcistiBaraj, resources.GetString("btnIcistiBaraj.Error"));
            this.btnIcistiBaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIcistiBaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnIcistiBaraj, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnIcistiBaraj.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnIcistiBaraj, ((int)(resources.GetObject("btnIcistiBaraj.IconPadding"))));
            this.btnIcistiBaraj.Image = global::BssBase.Properties.Resources.undo1;
            this.btnIcistiBaraj.Name = "btnIcistiBaraj";
            this.btnIcistiBaraj.UseVisualStyleBackColor = false;
            this.btnIcistiBaraj.Click += new System.EventHandler(this.btnIcistiBaraj_Click);
            // 
            // txtBaraj
            // 
            resources.ApplyResources(this.txtBaraj, "txtBaraj");
            this.txtBaraj.AssemblyStr = "";
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
            this.errorProviderDole.SetError(this.txtBaraj, resources.GetString("txtBaraj.Error"));
            this.txtBaraj.Format = null;
            this.txtBaraj.formToOpen = "";
            this.errorProviderDole.SetIconAlignment(this.txtBaraj, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBaraj.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.txtBaraj, ((int)(resources.GetObject("txtBaraj.IconPadding"))));
            this.txtBaraj.iscistiGreenNaLeave = false;
            this.txtBaraj.KoristiFilterNaDatasource = false;
            this.txtBaraj.MakedonskiJazik = false;
            this.txtBaraj.MinLength = 0;
            this.txtBaraj.Name = "txtBaraj";
            this.txtBaraj.PopulateOtherFields = false;
            this.txtBaraj.regularExpression = null;
            this.txtBaraj.SelektrijaNaFokus = false;
            // 
            // Meni
            // 
            resources.ApplyResources(this.Meni, "Meni");
            this.errorProviderDole.SetError(this.Meni, resources.GetString("Meni.Error"));
            this.Meni.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.errorProviderDole.SetIconAlignment(this.Meni, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Meni.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.Meni, ((int)(resources.GetObject("Meni.IconPadding"))));
            this.Meni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovZapis,
            this.btnEditirajZapis,
            this.btnBlokiraj,
            this.btnIzbrisi,
            this.btnFilter,
            this.toolStripMenuItem2});
            this.Meni.Name = "Meni";
            this.Meni.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Meni.ShowItemToolTips = true;
            // 
            // btnNovZapis
            // 
            resources.ApplyResources(this.btnNovZapis, "btnNovZapis");
            this.btnNovZapis.Image = global::BssBase.Properties.Resources._001_01;
            this.btnNovZapis.Name = "btnNovZapis";
            this.btnNovZapis.Click += new System.EventHandler(this.NovZapis);
            // 
            // btnEditirajZapis
            // 
            resources.ApplyResources(this.btnEditirajZapis, "btnEditirajZapis");
            this.btnEditirajZapis.Image = global::BssBase.Properties.Resources.EditTableHS;
            this.btnEditirajZapis.Name = "btnEditirajZapis";
            this.btnEditirajZapis.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnEditirajZapis.Click += new System.EventHandler(this.IzmeniZapis);
            // 
            // btnBlokiraj
            // 
            resources.ApplyResources(this.btnBlokiraj, "btnBlokiraj");
            this.btnBlokiraj.Image = global::BssBase.Properties.Resources.block_icon;
            this.btnBlokiraj.Name = "btnBlokiraj";
            this.btnBlokiraj.Click += new System.EventHandler(this.Blokiraj);
            // 
            // btnIzbrisi
            // 
            resources.ApplyResources(this.btnIzbrisi, "btnIzbrisi");
            this.btnIzbrisi.Image = global::BssBase.Properties.Resources._001_02;
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Image = global::BssBase.Properties.Resources._001_38;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Image = global::BssBase.Properties.Resources._001_09;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPrebaraj
            // 
            resources.ApplyResources(this.btnPrebaraj, "btnPrebaraj");
            this.btnPrebaraj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorProviderDole.SetError(this.btnPrebaraj, resources.GetString("btnPrebaraj.Error"));
            this.btnPrebaraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrebaraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnPrebaraj, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnPrebaraj.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnPrebaraj, ((int)(resources.GetObject("btnPrebaraj.IconPadding"))));
            this.btnPrebaraj.Image = global::BssBase.Properties.Resources._001_38;
            this.btnPrebaraj.Name = "btnPrebaraj";
            this.btnPrebaraj.UseVisualStyleBackColor = false;
            this.btnPrebaraj.Click += new System.EventHandler(this.btnPrebaraj_Click);
            // 
            // Navigator
            // 
            resources.ApplyResources(this.Navigator, "Navigator");
            this.Navigator.AddNewItem = null;
            this.Navigator.CountItem = this.bindingNavigatorCountItem;
            this.Navigator.DeleteItem = null;
            this.errorProviderDole.SetError(this.Navigator, resources.GetString("Navigator.Error"));
            this.errorProviderDole.SetIconAlignment(this.Navigator, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Navigator.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.Navigator, ((int)(resources.GetObject("Navigator.IconPadding"))));
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
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::BssBase.Properties.Resources._001_27;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::BssBase.Properties.Resources._001_23;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::BssBase.Properties.Resources._001_21;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::BssBase.Properties.Resources._001_25;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // errorProviderDole
            // 
            this.errorProviderDole.ContainerControl = this;
            resources.ApplyResources(this.errorProviderDole, "errorProviderDole");
            // 
            // frmShow
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.Controls.Add(this.MainPanel);
            this.Name = "frmShow";
            this.Load += new System.EventHandler(this.frmShow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormaSearch_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSearch)).EndInit();
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
		public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		public txtBase txtBaraj;
		protected System.Windows.Forms.Panel PanelHeader;
		public System.Windows.Forms.BindingSource Bsource;
		public System.Windows.Forms.Button btnIcistiBaraj;
		public Elements.btnPotvrdi btnOk;
		public Elements.btnZatvori btnZatvori;
		public System.Windows.Forms.ToolStripMenuItem btnIzbrisi;
		public System.Windows.Forms.Panel PanelFooter;
		public System.Windows.Forms.PictureBox ImageSearch;
		private System.Windows.Forms.ErrorProvider errorProviderDole;
		private System.Windows.Forms.LinkLabel DisplayError;
    }
}


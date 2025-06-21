namespace BssBase
{
	partial class frmBigEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBigEdit));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabVnes = new System.Windows.Forms.TabPage();
            this.groupVnes = new System.Windows.Forms.GroupBox();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.btnOk = new BssBase.Elements.btnPotvrdi();
            this.btnZatvori = new BssBase.Elements.btnZatvori();
            this.DisplayError = new System.Windows.Forms.LinkLabel();
            this.errorProviderDole = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            resources.ApplyResources(this.MainTab, "MainTab");
            this.MainTab.Controls.Add(this.tabVnes);
            this.errorProviderDole.SetError(this.MainTab, resources.GetString("MainTab.Error"));
            this.errorProviderDole.SetIconAlignment(this.MainTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("MainTab.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.MainTab, ((int)(resources.GetObject("MainTab.IconPadding"))));
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            // 
            // tabVnes
            // 
            resources.ApplyResources(this.tabVnes, "tabVnes");
            this.tabVnes.Controls.Add(this.groupVnes);
            this.errorProviderDole.SetError(this.tabVnes, resources.GetString("tabVnes.Error"));
            this.errorProviderDole.SetIconAlignment(this.tabVnes, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabVnes.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.tabVnes, ((int)(resources.GetObject("tabVnes.IconPadding"))));
            this.tabVnes.Name = "tabVnes";
            this.tabVnes.UseVisualStyleBackColor = true;
            // 
            // groupVnes
            // 
            resources.ApplyResources(this.groupVnes, "groupVnes");
            this.groupVnes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorProviderDole.SetError(this.groupVnes, resources.GetString("groupVnes.Error"));
            this.errorProviderDole.SetIconAlignment(this.groupVnes, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupVnes.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.groupVnes, ((int)(resources.GetObject("groupVnes.IconPadding"))));
            this.groupVnes.Name = "groupVnes";
            this.groupVnes.TabStop = false;
            // 
            // PanelFooter
            // 
            resources.ApplyResources(this.PanelFooter, "PanelFooter");
            this.PanelFooter.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFooter.Controls.Add(this.btnOk);
            this.PanelFooter.Controls.Add(this.btnZatvori);
            this.PanelFooter.Controls.Add(this.DisplayError);
            this.errorProviderDole.SetError(this.PanelFooter, resources.GetString("PanelFooter.Error"));
            this.errorProviderDole.SetIconAlignment(this.PanelFooter, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PanelFooter.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.PanelFooter, ((int)(resources.GetObject("PanelFooter.IconPadding"))));
            this.PanelFooter.Name = "PanelFooter";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorProviderDole.SetError(this.btnOk, resources.GetString("btnOk.Error"));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnOk, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOk.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnOk, ((int)(resources.GetObject("btnOk.IconPadding"))));
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
            this.errorProviderDole.SetError(this.btnZatvori, resources.GetString("btnZatvori.Error"));
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnZatvori, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnZatvori.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnZatvori, ((int)(resources.GetObject("btnZatvori.IconPadding"))));
            this.btnZatvori.Image = global::BssBase.Properties.Resources.close_32;
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
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
            // errorProviderDole
            // 
            this.errorProviderDole.ContainerControl = this;
            resources.ApplyResources(this.errorProviderDole, "errorProviderDole");
            // 
            // frmBigEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.PanelFooter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBigEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Click += new System.EventHandler(this.frmEdit_Load);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		public System.Windows.Forms.TabControl MainTab;
		public System.Windows.Forms.TabPage tabVnes;
		public System.Windows.Forms.GroupBox groupVnes;
		private System.Windows.Forms.ErrorProvider errorProviderDole;
		private System.Windows.Forms.LinkLabel DisplayError;
		protected System.Windows.Forms.Panel PanelFooter;
		public Elements.btnZatvori btnZatvori;
		public Elements.btnPotvrdi btnOk;



    }
}
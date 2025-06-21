namespace BssBase
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.DisplayError = new System.Windows.Forms.LinkLabel();
            this.btnOk = new BssBase.Elements.btnPotvrdi();
            this.btnZatvori = new BssBase.Elements.btnZatvori();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabVnes = new System.Windows.Forms.TabPage();
            this.groupVnes = new System.Windows.Forms.GroupBox();
            this.errorProviderDole = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelFooter.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFooter
            // 
            resources.ApplyResources(this.PanelFooter, "PanelFooter");
            this.PanelFooter.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFooter.Controls.Add(this.DisplayError);
            this.PanelFooter.Controls.Add(this.btnOk);
            this.PanelFooter.Controls.Add(this.btnZatvori);
            this.PanelFooter.Name = "PanelFooter";
            // 
            // DisplayError
            // 
            this.DisplayError.LinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.DisplayError, "DisplayError");
            this.DisplayError.Name = "DisplayError";
            this.DisplayError.TabStop = true;
            this.DisplayError.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DisplayError_LinkClicked);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // MainTab
            // 
            resources.ApplyResources(this.MainTab, "MainTab");
            this.MainTab.Controls.Add(this.tabVnes);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.Controls.Add(this.groupVnes);
            resources.ApplyResources(this.tabVnes, "tabVnes");
            this.tabVnes.Name = "tabVnes";
            this.tabVnes.UseVisualStyleBackColor = true;
            // 
            // groupVnes
            // 
            this.groupVnes.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.groupVnes, "groupVnes");
            this.groupVnes.Name = "groupVnes";
            this.groupVnes.TabStop = false;
            // 
            // errorProviderDole
            // 
            this.errorProviderDole.ContainerControl = this;
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ControlBox = false;
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.PanelFooter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEdit_KeyDown);
            this.PanelFooter.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		public System.Windows.Forms.TabControl MainTab;
		public System.Windows.Forms.TabPage tabVnes;
        public System.Windows.Forms.GroupBox groupVnes;
		public Elements.btnZatvori btnZatvori;
		private System.Windows.Forms.ErrorProvider errorProviderDole;
		private System.Windows.Forms.LinkLabel DisplayError;
		protected internal Elements.btnPotvrdi btnOk;
		protected System.Windows.Forms.Panel PanelFooter;



    }
}
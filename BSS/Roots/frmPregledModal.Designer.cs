namespace BssBase.Forms
{
    partial class frmPregledModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledModal));
            this.groupDugminja = new BssBase.groupBoxBase();
            this.DisplayError = new System.Windows.Forms.LinkLabel();
            this.btnZatvori1 = new BssBase.Elements.btnZatvori();
            this.errorProviderDole = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupDugminja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDugminja
            // 
            resources.ApplyResources(this.groupDugminja, "groupDugminja");
            this.groupDugminja.BackColor = System.Drawing.Color.Gainsboro;
            this.groupDugminja.Controls.Add(this.DisplayError);
            this.groupDugminja.Controls.Add(this.btnZatvori1);
            this.errorProviderDole.SetError(this.groupDugminja, resources.GetString("groupDugminja.Error"));
            this.errorProviderDole.SetIconAlignment(this.groupDugminja, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupDugminja.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.groupDugminja, ((int)(resources.GetObject("groupDugminja.IconPadding"))));
            this.groupDugminja.Name = "groupDugminja";
            this.groupDugminja.TabStop = false;
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
            // btnZatvori1
            // 
            resources.ApplyResources(this.btnZatvori1, "btnZatvori1");
            this.btnZatvori1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZatvori1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProviderDole.SetError(this.btnZatvori1, resources.GetString("btnZatvori1.Error"));
            this.btnZatvori1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.errorProviderDole.SetIconAlignment(this.btnZatvori1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnZatvori1.IconAlignment"))));
            this.errorProviderDole.SetIconPadding(this.btnZatvori1, ((int)(resources.GetObject("btnZatvori1.IconPadding"))));
            this.btnZatvori1.Name = "btnZatvori1";
            this.btnZatvori1.UseVisualStyleBackColor = false;
            this.btnZatvori1.Click += new System.EventHandler(this.btnZatvori1_Click);
            // 
            // errorProviderDole
            // 
            this.errorProviderDole.ContainerControl = this;
            resources.ApplyResources(this.errorProviderDole, "errorProviderDole");
            // 
            // frmPregledModal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.btnZatvori1;
            this.Controls.Add(this.groupDugminja);
            this.Name = "frmPregledModal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPregledModal_FormClosing);
            this.groupDugminja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		public Elements.btnZatvori btnZatvori1;
		public groupBoxBase groupDugminja;
		private System.Windows.Forms.LinkLabel DisplayError;
		private System.Windows.Forms.ErrorProvider errorProviderDole;

    }
}
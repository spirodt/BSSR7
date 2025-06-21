namespace BssBase.Roots
{
    partial class frmDatumOdDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatumOdDo));
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDatumDO = new System.Windows.Forms.Label();
            this.datumOD = new System.Windows.Forms.DateTimePicker();
            this.DatumDO = new System.Windows.Forms.DateTimePicker();
            this.skraten = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Image = global::BssBase.Properties.Resources._001_06;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelDatumDO
            // 
            resources.ApplyResources(this.labelDatumDO, "labelDatumDO");
            this.labelDatumDO.Name = "labelDatumDO";
            // 
            // datumOD
            // 
            resources.ApplyResources(this.datumOD, "datumOD");
            this.datumOD.Name = "datumOD";
            // 
            // DatumDO
            // 
            resources.ApplyResources(this.DatumDO, "DatumDO");
            this.DatumDO.Name = "DatumDO";
            // 
            // skraten
            // 
            resources.ApplyResources(this.skraten, "skraten");
            this.skraten.Checked = true;
            this.skraten.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skraten.Name = "skraten";
            this.skraten.UseVisualStyleBackColor = true;
            // 
            // frmDatumOdDo
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skraten);
            this.Controls.Add(this.DatumDO);
            this.Controls.Add(this.datumOD);
            this.Controls.Add(this.labelDatumDO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatumOdDo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmDatumOdDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker datumOD;
        public System.Windows.Forms.DateTimePicker DatumDO;
        public System.Windows.Forms.CheckBox skraten;
        public System.Windows.Forms.Label labelDatumDO;

    }
}
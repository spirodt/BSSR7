namespace MReport.Forms
{
    partial class frmGenerirajDokumenti
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerirajDokumenti));
            this.dtPeriod = new System.Windows.Forms.DateTimePicker();
            this.dtValuta = new System.Windows.Forms.DateTimePicker();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPotvrdi1 = new BssBase.Elements.btnPotvrdi();
            this.txtCenaNaStruja = new BssBase.Elements.txtNumeric();
            this.txtBase1 = new BssBase.txtBase();
            this.btnPotvrdi2 = new BssBase.Elements.btnPotvrdi();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtJsonValuta = new System.Windows.Forms.DateTimePicker();
            this.dtJsonDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtJsonPeriod = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label9.Location = new System.Drawing.Point(3, 95);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 24);
            label9.TabIndex = 52;
            label9.Text = "Период:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label8.Location = new System.Drawing.Point(3, 60);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(162, 24);
            label8.TabIndex = 50;
            label8.Text = "Датум на валута:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            datumLabel.Location = new System.Drawing.Point(3, 25);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(71, 24);
            datumLabel.TabIndex = 48;
            datumLabel.Text = "Датум:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label1.Location = new System.Drawing.Point(4, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 24);
            label1.TabIndex = 55;
            label1.Text = "Цена на струја:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label2.Location = new System.Drawing.Point(310, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 24);
            label2.TabIndex = 57;
            label2.Text = "Забелешка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label3.Location = new System.Drawing.Point(11, 21);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 24);
            label3.TabIndex = 60;
            label3.Text = "Датум:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label4.Location = new System.Drawing.Point(11, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 24);
            label4.TabIndex = 62;
            label4.Text = "Датум на валута:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label5.Location = new System.Drawing.Point(11, 91);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 24);
            label5.TabIndex = 64;
            label5.Text = "Период:";
            // 
            // dtPeriod
            // 
            this.dtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriod.Location = new System.Drawing.Point(168, 95);
            this.dtPeriod.Name = "dtPeriod";
            this.dtPeriod.Size = new System.Drawing.Size(136, 29);
            this.dtPeriod.TabIndex = 51;
            // 
            // dtValuta
            // 
            this.dtValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtValuta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtValuta.Location = new System.Drawing.Point(168, 60);
            this.dtValuta.Name = "dtValuta";
            this.dtValuta.Size = new System.Drawing.Size(136, 29);
            this.dtValuta.TabIndex = 49;
            // 
            // dtDatum
            // 
            this.dtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatum.Location = new System.Drawing.Point(168, 25);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(136, 29);
            this.dtDatum.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.btnPotvrdi1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtCenaNaStruja);
            this.groupBox1.Controls.Add(this.txtBase1);
            this.groupBox1.Controls.Add(this.dtValuta);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.dtDatum);
            this.groupBox1.Controls.Add(this.dtPeriod);
            this.groupBox1.Controls.Add(datumLabel);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 192);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерирање на фактури за тековно одржување";
            // 
            // btnPotvrdi1
            // 
            this.btnPotvrdi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi1.Image = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi1.Image")));
            this.btnPotvrdi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi1.Location = new System.Drawing.Point(457, 140);
            this.btnPotvrdi1.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi1.Name = "btnPotvrdi1";
            this.btnPotvrdi1.Size = new System.Drawing.Size(407, 38);
            this.btnPotvrdi1.TabIndex = 56;
            this.btnPotvrdi1.Text = "Генерирај !!";
            this.btnPotvrdi1.UseVisualStyleBackColor = false;
            this.btnPotvrdi1.Click += new System.EventHandler(this.btnPotvrdi1_Click);
            // 
            // txtCenaNaStruja
            // 
            this.txtCenaNaStruja.AssemblyStr = null;
            this.txtCenaNaStruja.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCenaNaStruja.C_Decimal = true;
            this.txtCenaNaStruja.C_FillWithZeros = false;
            this.txtCenaNaStruja.C_OnlyNumbers = true;
            this.txtCenaNaStruja.C_RegEx = false;
            this.txtCenaNaStruja.C_ShowRedOnLeaveIfEmpty = false;
            this.txtCenaNaStruja.ColumnName1 = null;
            this.txtCenaNaStruja.ColumnName2 = null;
            this.txtCenaNaStruja.ColumnName3 = null;
            this.txtCenaNaStruja.ColumnName4 = null;
            this.txtCenaNaStruja.ColumnName5 = null;
            this.txtCenaNaStruja.ColumnName6 = null;
            this.txtCenaNaStruja.ColumnName7 = null;
            this.txtCenaNaStruja.daliCetiri = false;
            this.txtCenaNaStruja.ForeColor = System.Drawing.Color.Blue;
            this.txtCenaNaStruja.formToOpen = null;
            this.txtCenaNaStruja.iscistiGreenNaLeave = false;
            this.txtCenaNaStruja.iskluciFormatiranje = false;
            this.txtCenaNaStruja.KoristiFilterNaDatasource = false;
            this.txtCenaNaStruja.Location = new System.Drawing.Point(168, 140);
            this.txtCenaNaStruja.MakedonskiJazik = false;
            this.txtCenaNaStruja.MinLength = 0;
            this.txtCenaNaStruja.Name = "txtCenaNaStruja";
            this.txtCenaNaStruja.PopulateOtherFields = false;
            this.txtCenaNaStruja.regularExpression = null;
            this.txtCenaNaStruja.SelektrijaNaFokus = false;
            this.txtCenaNaStruja.Size = new System.Drawing.Size(100, 20);
            this.txtCenaNaStruja.TabIndex = 54;
            this.txtCenaNaStruja.Text = "0,00";
            // 
            // txtBase1
            // 
            this.txtBase1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase1.AssemblyStr = null;
            this.txtBase1.C_FillWithZeros = false;
            this.txtBase1.C_OnlyNumbers = false;
            this.txtBase1.C_RegEx = false;
            this.txtBase1.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBase1.ColumnName1 = null;
            this.txtBase1.ColumnName2 = null;
            this.txtBase1.ColumnName3 = null;
            this.txtBase1.ColumnName4 = null;
            this.txtBase1.ColumnName5 = null;
            this.txtBase1.ColumnName6 = null;
            this.txtBase1.ColumnName7 = null;
            this.txtBase1.daliCetiri = false;
            this.txtBase1.Format = null;
            this.txtBase1.formToOpen = null;
            this.txtBase1.iscistiGreenNaLeave = false;
            this.txtBase1.KoristiFilterNaDatasource = false;
            this.txtBase1.Location = new System.Drawing.Point(314, 60);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Multiline = true;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(550, 64);
            this.txtBase1.TabIndex = 53;
            // 
            // btnPotvrdi2
            // 
            this.btnPotvrdi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPotvrdi2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdi2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPotvrdi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi2.Image = ((System.Drawing.Image)(resources.GetObject("btnPotvrdi2.Image")));
            this.btnPotvrdi2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrdi2.Location = new System.Drawing.Point(457, 82);
            this.btnPotvrdi2.MinimumSize = new System.Drawing.Size(132, 38);
            this.btnPotvrdi2.Name = "btnPotvrdi2";
            this.btnPotvrdi2.Size = new System.Drawing.Size(407, 38);
            this.btnPotvrdi2.TabIndex = 57;
            this.btnPotvrdi2.Text = "Внес на податоци од HVAC";
            this.btnPotvrdi2.UseVisualStyleBackColor = false;
            this.btnPotvrdi2.Click += new System.EventHandler(this.btnPotvrdi2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(352, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 38);
            this.progressBar1.TabIndex = 58;
            // 
            // dtJsonValuta
            // 
            this.dtJsonValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtJsonValuta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtJsonValuta.Location = new System.Drawing.Point(176, 56);
            this.dtJsonValuta.Name = "dtJsonValuta";
            this.dtJsonValuta.Size = new System.Drawing.Size(136, 29);
            this.dtJsonValuta.TabIndex = 61;
            // 
            // dtJsonDatum
            // 
            this.dtJsonDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtJsonDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtJsonDatum.Location = new System.Drawing.Point(176, 21);
            this.dtJsonDatum.Name = "dtJsonDatum";
            this.dtJsonDatum.Size = new System.Drawing.Size(136, 29);
            this.dtJsonDatum.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.dtJsonPeriod);
            this.groupBox2.Controls.Add(this.btnPotvrdi2);
            this.groupBox2.Controls.Add(this.dtJsonValuta);
            this.groupBox2.Controls.Add(this.dtJsonDatum);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Location = new System.Drawing.Point(5, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 140);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Генерирање на фактури за HVAC";
            // 
            // dtJsonPeriod
            // 
            this.dtJsonPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtJsonPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtJsonPeriod.Location = new System.Drawing.Point(176, 91);
            this.dtJsonPeriod.Name = "dtJsonPeriod";
            this.dtJsonPeriod.Size = new System.Drawing.Size(136, 29);
            this.dtJsonPeriod.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 66;
            // 
            // frmGenerirajDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenerirajDokumenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерирање на документи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPeriod;
        private System.Windows.Forms.DateTimePicker dtValuta;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private BssBase.txtBase txtBase1;
        private BssBase.Elements.txtNumeric txtCenaNaStruja;
        private BssBase.Elements.btnPotvrdi btnPotvrdi1;
        private BssBase.Elements.btnPotvrdi btnPotvrdi2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dtJsonValuta;
        private System.Windows.Forms.DateTimePicker dtJsonDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtJsonPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
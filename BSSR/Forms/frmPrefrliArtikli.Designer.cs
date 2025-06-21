namespace BSSR.Forms
{
    partial class frmPrefrliArtikli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTabela = new BssBase.cmbBase();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Prenesi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ArtikliOD = new BssBase.GridBig();
            this.txtBaza = new BssBase.cmbBase();
            this.cmbServer = new BssBase.cmbBase();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikliOD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTabela);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Prenesi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(684, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 509);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Ivory;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(7, 460);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(482, 36);
            this.button7.TabIndex = 23;
            this.button7.Text = "Преглед на сите податоци";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Ivory;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(10, 269);
            this.button6.Margin = new System.Windows.Forms.Padding(10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(482, 55);
            this.button6.TabIndex = 22;
            this.button6.Text = "Ажурирај ги сите постоечки податоци да бидат како во главна база ( Штиклираните )" +
    "";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(258, 174);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 52);
            this.button5.TabIndex = 21;
            this.button5.Text = "Бриши ги штиклираните";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(10, 230);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(482, 34);
            this.button4.TabIndex = 20;
            this.button4.Text = "Сите изменети податоци во главна база";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 174);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 52);
            this.button3.TabIndex = 19;
            this.button3.Text = "Најди ги податоците што ги нема во главна база";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "..";
            // 
            // cmbTabela
            // 
            this.cmbTabela.C_OnlyNumbers = false;
            this.cmbTabela.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbTabela.CurrentText = null;
            this.cmbTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabela.DtTableName = null;
            this.cmbTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.Items.AddRange(new object[] {
            "tblArtikal - ID,SIFRA",
            "tblPartneri - ID,SIFRA",
            "tblPrevodi - ID,KlucenZbor",
            "tblObjekti - ID,SIFRA",
            "tblPodgrupaID - ID,Naziv",
            "tblGrupaNaArtikli - ID,SIFRA, Naziv",
            "tblTipNaDokument - ID,Naziv",
            "tblBanki - ID,SIFRA",
            "tblEdinecniMerki - ID,Kratenka"});
            this.cmbTabela.Location = new System.Drawing.Point(3, 16);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(495, 26);
            this.cmbTabela.TabIndex = 17;
            this.cmbTabela.value = null;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(246, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Пренеси ги штиклираните";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::BSSR.Properties.Resources.podatoci_firma;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Најди податоци што ги нема во одбраната база";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prenesi
            // 
            this.Prenesi.BackColor = System.Drawing.Color.LemonChiffon;
            this.Prenesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prenesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prenesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Prenesi.Location = new System.Drawing.Point(258, 122);
            this.Prenesi.Margin = new System.Windows.Forms.Padding(10);
            this.Prenesi.Name = "Prenesi";
            this.Prenesi.Padding = new System.Windows.Forms.Padding(10);
            this.Prenesi.Size = new System.Drawing.Size(237, 49);
            this.Prenesi.TabIndex = 10;
            this.Prenesi.Text = "Пренеси ги сите";
            this.Prenesi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Prenesi.UseVisualStyleBackColor = false;
            this.Prenesi.Click += new System.EventHandler(this.Prenesi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.40741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.59259F));
            this.tableLayoutPanel1.Controls.Add(this.ArtikliOD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBaza, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbServer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1188, 593);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ArtikliOD
            // 
            this.ArtikliOD.AllowUserToAddRows = false;
            this.ArtikliOD.AllowUserToDeleteRows = false;
            this.ArtikliOD.AllowUserToOrderColumns = true;
            this.ArtikliOD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtikliOD.AssemblyToLoad = null;
            this.ArtikliOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArtikliOD.EditForm = null;
            this.ArtikliOD.FilterForm = null;
            this.ArtikliOD.HidenColumns = null;
            this.ArtikliOD.KreirajPredefiniraniPolinja = false;
            this.ArtikliOD.Location = new System.Drawing.Point(3, 3);
            this.ArtikliOD.MultiSelect = false;
            this.ArtikliOD.Name = "ArtikliOD";
            this.ArtikliOD.PrimaryKey = "ID";
            this.ArtikliOD.ReadOnly = true;
            this.ArtikliOD.ReadOnlyColumns = null;
            this.ArtikliOD.reportCenter = false;
            this.ArtikliOD.ReportName = null;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ArtikliOD.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ArtikliOD.RowTemplate.Height = 36;
            this.ArtikliOD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArtikliOD.Size = new System.Drawing.Size(675, 509);
            this.ArtikliOD.SQLCommandQuery = null;
            this.ArtikliOD.TabIndex = 7;
            this.ArtikliOD.UpdateTable = null;
            // 
            // txtBaza
            // 
            this.txtBaza.C_OnlyNumbers = false;
            this.txtBaza.C_ShowRedOnLeaveIfEmpty = false;
            this.txtBaza.CurrentText = null;
            this.txtBaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBaza.DtTableName = null;
            this.txtBaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBaza.FormattingEnabled = true;
            this.txtBaza.Items.AddRange(new object[] {
            "MANH1",
            "MANH2"});
            this.txtBaza.Location = new System.Drawing.Point(3, 552);
            this.txtBaza.Name = "txtBaza";
            this.txtBaza.Size = new System.Drawing.Size(248, 26);
            this.txtBaza.TabIndex = 15;
            this.txtBaza.value = null;
            // 
            // cmbServer
            // 
            this.cmbServer.C_OnlyNumbers = false;
            this.cmbServer.C_ShowRedOnLeaveIfEmpty = false;
            this.cmbServer.CurrentText = null;
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.DtTableName = null;
            this.cmbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "MANHATTAN1\\SQLEXPRESS",
            "MANHATTAN2\\SQLEXPRESS"});
            this.cmbServer.Location = new System.Drawing.Point(3, 518);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(671, 26);
            this.cmbServer.TabIndex = 16;
            this.cmbServer.value = null;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(684, 518);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 28);
            this.progressBar1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // frmPrefrliArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPrefrliArtikli";
            this.Text = "Префрли податоци";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikliOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BssBase.cmbBase txtBaza;
        private BssBase.cmbBase cmbServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Prenesi;
        private BssBase.GridBig ArtikliOD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BssBase.cmbBase cmbTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;

    }
}
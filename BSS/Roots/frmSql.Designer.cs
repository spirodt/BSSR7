namespace BssBase.Forms {
	partial class frmSql {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSql));
			this.btnZatvori1 = new BssBase.Elements.btnZatvori();
			this.btnIzvrsi = new BssBase.Elements.btnPotvrdi();
			this.SQL = new BssBase.txtBase();
			this.Greski = new BssBase.txtBase();
			this.Bsslabel1 = new BssBase.Elements.Bsslabel();
			this.Bsslabel2 = new BssBase.Elements.Bsslabel();
			this.btnOtvori1 = new BssBase.Elements.btnOtvori();
			this.SuspendLayout();
			// 
			// btnZatvori1
			// 
			this.btnZatvori1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnZatvori1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnZatvori1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnZatvori1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnZatvori1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnZatvori1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZatvori1.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori1.Image")));
			this.btnZatvori1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnZatvori1.Location = new System.Drawing.Point(2, 356);
			this.btnZatvori1.MinimumSize = new System.Drawing.Size(132, 38);
			this.btnZatvori1.Name = "btnZatvori1";
			this.btnZatvori1.Size = new System.Drawing.Size(132, 38);
			this.btnZatvori1.TabIndex = 4;
			this.btnZatvori1.Text = "Затвори";
			this.btnZatvori1.UseVisualStyleBackColor = false;
			this.btnZatvori1.Click += new System.EventHandler(this.btnZatvori1_Click);
			// 
			// btnIzvrsi
			// 
			this.btnIzvrsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIzvrsi.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnIzvrsi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnIzvrsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnIzvrsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnIzvrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIzvrsi.Image = ((System.Drawing.Image)(resources.GetObject("btnIzvrsi.Image")));
			this.btnIzvrsi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIzvrsi.Location = new System.Drawing.Point(652, 356);
			this.btnIzvrsi.MinimumSize = new System.Drawing.Size(132, 38);
			this.btnIzvrsi.Name = "btnIzvrsi";
			this.btnIzvrsi.Size = new System.Drawing.Size(132, 38);
			this.btnIzvrsi.TabIndex = 2;
			this.btnIzvrsi.Text = "Изврши";
			this.btnIzvrsi.UseVisualStyleBackColor = false;
			this.btnIzvrsi.Click += new System.EventHandler(this.btnIzvrsi_Click);
			// 
			// SQL
			// 
			this.SQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SQL.AssemblyStr = null;
			this.SQL.C_FillWithZeros = false;
			this.SQL.C_OnlyNumbers = false;
			this.SQL.C_RegEx = false;
			this.SQL.C_ShowRedOnLeaveIfEmpty = false;
			this.SQL.ColumnName1 = null;
			this.SQL.ColumnName2 = null;
			this.SQL.ColumnName3 = null;
			this.SQL.ColumnName4 = null;
			this.SQL.ColumnName5 = null;
			this.SQL.ColumnName6 = null;
			this.SQL.ColumnName7 = null;
			this.SQL.daliCetiri = false;
			this.SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SQL.formToOpen = null;
			this.SQL.Location = new System.Drawing.Point(2, 2);
			this.SQL.MakedonskiJazik = false;
			this.SQL.MinLength = 0;
			this.SQL.Multiline = true;
			this.SQL.Name = "SQL";
			this.SQL.PopulateOtherFields = false;
			this.SQL.regularExpression = null;
			this.SQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.SQL.SelektrijaNaFokus = true;
			this.SQL.Size = new System.Drawing.Size(789, 227);
			this.SQL.TabIndex = 0;
			this.SQL.Text = "Select *  from ";
			this.SQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SQL_KeyDown);
			// 
			// Greski
			// 
			this.Greski.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Greski.AssemblyStr = null;
			this.Greski.BackColor = System.Drawing.Color.LemonChiffon;
			this.Greski.C_FillWithZeros = false;
			this.Greski.C_OnlyNumbers = false;
			this.Greski.C_RegEx = false;
			this.Greski.C_ShowRedOnLeaveIfEmpty = false;
			this.Greski.ColumnName1 = null;
			this.Greski.ColumnName2 = null;
			this.Greski.ColumnName3 = null;
			this.Greski.ColumnName4 = null;
			this.Greski.ColumnName5 = null;
			this.Greski.ColumnName6 = null;
			this.Greski.ColumnName7 = null;
			this.Greski.daliCetiri = false;
			this.Greski.ForeColor = System.Drawing.Color.Blue;
			this.Greski.formToOpen = null;
			this.Greski.Location = new System.Drawing.Point(2, 235);
			this.Greski.MakedonskiJazik = false;
			this.Greski.MinLength = 0;
			this.Greski.Multiline = true;
			this.Greski.Name = "Greski";
			this.Greski.PopulateOtherFields = false;
			this.Greski.ReadOnly = true;
			this.Greski.regularExpression = null;
			this.Greski.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Greski.SelektrijaNaFokus = true;
			this.Greski.Size = new System.Drawing.Size(789, 115);
			this.Greski.TabIndex = 3;
			this.Greski.Text = "Грешки";
			this.Greski.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Greski_KeyDown);
			// 
			// Bsslabel1
			// 
			this.Bsslabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Bsslabel1.AutoSize = true;
			this.Bsslabel1.Location = new System.Drawing.Point(154, 369);
			this.Bsslabel1.Name = "Bsslabel1";
			this.Bsslabel1.Size = new System.Drawing.Size(135, 13);
			this.Bsslabel1.TabIndex = 4;
			this.Bsslabel1.Text = "Сменети редови во база:";
			// 
			// Bsslabel2
			// 
			this.Bsslabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Bsslabel2.AutoSize = true;
			this.Bsslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Bsslabel2.Location = new System.Drawing.Point(295, 367);
			this.Bsslabel2.Name = "Bsslabel2";
			this.Bsslabel2.Size = new System.Drawing.Size(80, 18);
			this.Bsslabel2.TabIndex = 5;
			this.Bsslabel2.Text = "Bsslabel2";
			// 
			// btnOtvori1
			// 
			this.btnOtvori1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOtvori1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnOtvori1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOtvori1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnOtvori1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnOtvori1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOtvori1.Image = ((System.Drawing.Image)(resources.GetObject("btnOtvori1.Image")));
			this.btnOtvori1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOtvori1.Location = new System.Drawing.Point(480, 356);
			this.btnOtvori1.Name = "btnOtvori1";
			this.btnOtvori1.Size = new System.Drawing.Size(166, 38);
			this.btnOtvori1.TabIndex = 1;
			this.btnOtvori1.Text = "Прикажи табела";
			this.btnOtvori1.UseVisualStyleBackColor = false;
			this.btnOtvori1.Click += new System.EventHandler(this.btnOtvori1_Click);
			// 
			// frmSql
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 396);
			this.Controls.Add(this.btnOtvori1);
			this.Controls.Add(this.Bsslabel2);
			this.Controls.Add(this.Bsslabel1);
			this.Controls.Add(this.Greski);
			this.Controls.Add(this.SQL);
			this.Controls.Add(this.btnIzvrsi);
			this.Controls.Add(this.btnZatvori1);
			this.Name = "frmSql";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Elements.btnZatvori btnZatvori1;
		private Elements.btnPotvrdi btnIzvrsi;
		private txtBase SQL;
		private txtBase Greski;
		private Elements.Bsslabel Bsslabel1;
		private Elements.Bsslabel Bsslabel2;
		private Elements.btnOtvori btnOtvori1;
	}
}
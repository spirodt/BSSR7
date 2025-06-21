namespace BSSR.Forms {
	partial class frmNormativEditStavka {
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
            this.zbxBase1 = new BssBase.zbxBase();
            this.bsslabel1 = new BssBase.Elements.Bsslabel();
            this.txtBase1 = new BssBase.txtBase();
            this.Kolicina = new BssBase.txtBase();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(619, 262);
            // 
            // tabVnes
            // 
            this.tabVnes.Size = new System.Drawing.Size(611, 236);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.Kolicina);
            this.groupVnes.Controls.Add(this.txtBase1);
            this.groupVnes.Controls.Add(this.bsslabel1);
            this.groupVnes.Controls.Add(this.zbxBase1);
            this.groupVnes.Size = new System.Drawing.Size(604, 225);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 261);
            this.PanelFooter.Size = new System.Drawing.Size(623, 69);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 5);
            this.btnZatvori.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(432, 5);
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // zbxBase1
            // 
            this.zbxBase1.AssemblyStr = "BSSR";
            this.zbxBase1.AutoSize = true;
            this.zbxBase1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zbxBase1.ColumnName1 = "ID";
            this.zbxBase1.ColumnName2 = "NazivArtikal";
            this.zbxBase1.ColumnName3 = "PRODAZNACENA";
            this.zbxBase1.ColumnName4 = "SIFRA";
            this.zbxBase1.ColumnName5 = "";
            this.zbxBase1.ColumnName6 = null;
            this.zbxBase1.ColumnName7 = null;
            this.zbxBase1.filterDataSource = "Status = 3";
            this.zbxBase1.formToOpen = "BSSR.Forms.frmArtikli";
            this.zbxBase1.GridFromForm = null;
            this.zbxBase1.KoristiFilterNaDatasource = true;
            this.zbxBase1.Location = new System.Drawing.Point(133, 23);
            this.zbxBase1.MinimumSize = new System.Drawing.Size(123, 20);
            this.zbxBase1.Name = "zbxBase1";
            this.zbxBase1.ovozmoziIzmena = false;
            this.zbxBase1.showRedIfEmpty = false;
            this.zbxBase1.Size = new System.Drawing.Size(153, 55);
            this.zbxBase1.TabIndex = 0;
            this.zbxBase1.DataRead += new BssBase.zbxBase.doneLoading(this.zbxBase1_DataRead);
            this.zbxBase1.Validated += new System.EventHandler(this.zbxBase1_Validated);
            // 
            // bsslabel1
            // 
            this.bsslabel1.AutoSize = true;
            this.bsslabel1.Location = new System.Drawing.Point(12, 37);
            this.bsslabel1.Name = "bsslabel1";
            this.bsslabel1.Size = new System.Drawing.Size(115, 29);
            this.bsslabel1.TabIndex = 1;
            this.bsslabel1.Text = "Артикал:";
            // 
            // txtBase1
            // 
            this.txtBase1.AssemblyStr = null;
            this.txtBase1.BackColor = System.Drawing.Color.LemonChiffon;
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
            this.txtBase1.ForeColor = System.Drawing.Color.Blue;
            this.txtBase1.Format = null;
            this.txtBase1.formToOpen = null;
            this.txtBase1.iscistiGreenNaLeave = false;
            this.txtBase1.KoristiFilterNaDatasource = false;
            this.txtBase1.Location = new System.Drawing.Point(133, 84);
            this.txtBase1.MakedonskiJazik = false;
            this.txtBase1.MinLength = 0;
            this.txtBase1.Multiline = true;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.PopulateOtherFields = false;
            this.txtBase1.ReadOnly = true;
            this.txtBase1.regularExpression = null;
            this.txtBase1.SelektrijaNaFokus = false;
            this.txtBase1.Size = new System.Drawing.Size(461, 91);
            this.txtBase1.TabIndex = 2;
            this.txtBase1.TabStop = false;
            // 
            // Kolicina
            // 
            this.Kolicina.AssemblyStr = null;
            this.Kolicina.C_FillWithZeros = false;
            this.Kolicina.C_OnlyNumbers = true;
            this.Kolicina.C_RegEx = false;
            this.Kolicina.C_ShowRedOnLeaveIfEmpty = true;
            this.Kolicina.ColumnName1 = null;
            this.Kolicina.ColumnName2 = null;
            this.Kolicina.ColumnName3 = null;
            this.Kolicina.ColumnName4 = null;
            this.Kolicina.ColumnName5 = null;
            this.Kolicina.ColumnName6 = null;
            this.Kolicina.ColumnName7 = null;
            this.Kolicina.daliCetiri = false;
            this.Kolicina.Format = null;
            this.Kolicina.formToOpen = null;
            this.Kolicina.iscistiGreenNaLeave = false;
            this.Kolicina.KoristiFilterNaDatasource = false;
            this.Kolicina.Location = new System.Drawing.Point(494, 181);
            this.Kolicina.MakedonskiJazik = true;
            this.Kolicina.MinLength = 0;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.PopulateOtherFields = false;
            this.Kolicina.regularExpression = null;
            this.Kolicina.SelektrijaNaFokus = false;
            this.Kolicina.Size = new System.Drawing.Size(100, 35);
            this.Kolicina.TabIndex = 1;
            this.Kolicina.Text = "1,00";
            this.Kolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Kolicina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kolicina_KeyDown);
            this.Kolicina.Leave += new System.EventHandler(this.Kolicina_Leave);
            // 
            // frmNormativEditStavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 330);
            this.Name = "frmNormativEditStavka";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmNormativEditStavka_Load);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private BssBase.zbxBase zbxBase1;
		private BssBase.txtBase Kolicina;
		private BssBase.txtBase txtBase1;
		private BssBase.Elements.Bsslabel bsslabel1;
	}
}
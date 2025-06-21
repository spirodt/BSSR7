namespace MKelner {
	partial class frmMainLogin {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmMainLogin ) );
			this.GroupLogin = new BssBase.groupBoxBase();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOk = new BssBase.Elements.btnPotvrdi();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bsslabel3 = new BssBase.Elements.Bsslabel();
			this.bsslabel2 = new BssBase.Elements.Bsslabel();
			this.bsslabel1 = new BssBase.Elements.Bsslabel();
			this.UserName = new BssBase.txtBase();
			this.Password = new BssBase.txtBase();
			this.GroupLogin.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.pictureBox1 ) ).BeginInit();
			this.SuspendLayout();
			// 
			// GroupLogin
			// 
			this.GroupLogin.BackColor = System.Drawing.Color.Beige;
			this.GroupLogin.Controls.Add( this.btnClose );
			this.GroupLogin.Controls.Add( this.btnOk );
			this.GroupLogin.Controls.Add( this.pictureBox1 );
			this.GroupLogin.Controls.Add( this.bsslabel3 );
			this.GroupLogin.Controls.Add( this.bsslabel2 );
			this.GroupLogin.Controls.Add( this.bsslabel1 );
			this.GroupLogin.Controls.Add( this.UserName );
			this.GroupLogin.Controls.Add( this.Password );
			this.GroupLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupLogin.Font = new System.Drawing.Font( "Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.GroupLogin.Location = new System.Drawing.Point( 0, 0 );
			this.GroupLogin.Name = "GroupLogin";
			this.GroupLogin.Size = new System.Drawing.Size( 722, 220 );
			this.GroupLogin.TabIndex = 0;
			this.GroupLogin.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point( 12, 172 );
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size( 133, 35 );
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Излез";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Image = ( ( System.Drawing.Image )( resources.GetObject( "btnOk.Image" ) ) );
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new System.Drawing.Point( 488, 145 );
			this.btnOk.MinimumSize = new System.Drawing.Size( 132, 38 );
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size( 222, 62 );
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "ОK";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler( this.btnOk_Click );
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ( ( System.Drawing.Image )( resources.GetObject( "pictureBox1.Image" ) ) );
			this.pictureBox1.Location = new System.Drawing.Point( 8, 21 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size( 195, 141 );
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// bsslabel3
			// 
			this.bsslabel3.AutoSize = true;
			this.bsslabel3.Location = new System.Drawing.Point( 242, 127 );
			this.bsslabel3.Name = "bsslabel3";
			this.bsslabel3.Size = new System.Drawing.Size( 0, 29 );
			this.bsslabel3.TabIndex = 6;
			// 
			// bsslabel2
			// 
			this.bsslabel2.AutoSize = true;
			this.bsslabel2.Location = new System.Drawing.Point( 222, 88 );
			this.bsslabel2.Name = "bsslabel2";
			this.bsslabel2.Size = new System.Drawing.Size( 116, 29 );
			this.bsslabel2.TabIndex = 5;
			this.bsslabel2.Text = "Лозинка:";
			// 
			// bsslabel1
			// 
			this.bsslabel1.AutoSize = true;
			this.bsslabel1.Location = new System.Drawing.Point( 206, 48 );
			this.bsslabel1.Name = "bsslabel1";
			this.bsslabel1.Size = new System.Drawing.Size( 132, 29 );
			this.bsslabel1.TabIndex = 4;
			this.bsslabel1.Text = "Корисник:";
			// 
			// UserName
			// 
			this.UserName.AssemblyStr = null;
			this.UserName.C_FillWithZeros = false;
			this.UserName.C_OnlyNumbers = false;
			this.UserName.C_RegEx = false;
			this.UserName.C_ShowRedOnLeaveIfEmpty = false;
			this.UserName.ColumnName1 = null;
			this.UserName.ColumnName2 = null;
			this.UserName.ColumnName3 = null;
			this.UserName.ColumnName4 = null;
			this.UserName.ColumnName5 = null;
			this.UserName.ColumnName6 = null;
			this.UserName.ColumnName7 = null;
			this.UserName.daliCetiri = false;
			this.UserName.Format = null;
			this.UserName.formToOpen = null;
			this.UserName.Location = new System.Drawing.Point( 344, 44 );
			this.UserName.MakedonskiJazik = false;
			this.UserName.MinLength = 0;
			this.UserName.Name = "UserName";
			this.UserName.PopulateOtherFields = false;
			this.UserName.prikaziKeyBoard = true;
			this.UserName.regularExpression = null;
			this.UserName.SelektrijaNaFokus = false;
			this.UserName.Size = new System.Drawing.Size( 366, 35 );
			this.UserName.TabIndex = 0;
			// 
			// Password
			// 
			this.Password.AssemblyStr = null;
			this.Password.C_FillWithZeros = false;
			this.Password.C_OnlyNumbers = false;
			this.Password.C_RegEx = false;
			this.Password.C_ShowRedOnLeaveIfEmpty = false;
			this.Password.ColumnName1 = null;
			this.Password.ColumnName2 = null;
			this.Password.ColumnName3 = null;
			this.Password.ColumnName4 = null;
			this.Password.ColumnName5 = null;
			this.Password.ColumnName6 = null;
			this.Password.ColumnName7 = null;
			this.Password.daliCetiri = false;
			this.Password.Format = null;
			this.Password.formToOpen = null;
			this.Password.Location = new System.Drawing.Point( 344, 85 );
			this.Password.MakedonskiJazik = false;
			this.Password.MinLength = 0;
			this.Password.Name = "Password";
			this.Password.PopulateOtherFields = false;
			this.Password.prikaziKeyBoard = true;
			this.Password.regularExpression = null;
			this.Password.SelektrijaNaFokus = false;
			this.Password.Size = new System.Drawing.Size( 366, 35 );
			this.Password.TabIndex = 1;
			// 
			// frmMainLogin
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size( 722, 220 );
			this.Controls.Add( this.GroupLogin );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.HelpButton = true;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.Name = "frmMainLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Најава";
			this.Load += new System.EventHandler( this.frmMainLogin_Load );
			this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.frmMainLogin_KeyDown );
			this.GroupLogin.ResumeLayout( false );
			this.GroupLogin.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.pictureBox1 ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BssBase.groupBoxBase GroupLogin;
		private BssBase.txtBase UserName;
		private BssBase.txtBase Password;
		private BssBase.Elements.Bsslabel bsslabel3;
		private BssBase.Elements.Bsslabel bsslabel2;
		private BssBase.Elements.Bsslabel bsslabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private BssBase.Elements.btnPotvrdi btnOk;
		private System.Windows.Forms.Button btnClose;
	}
}


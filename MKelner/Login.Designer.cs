namespace MKelner {
	partial class Login {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Login ) );
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem( "" );
			this.GroupLogin = new BssBase.groupBoxBase();
			this.btnOk = new BssBase.Elements.btnPotvrdi();
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bsslabel2 = new BssBase.Elements.Bsslabel();
			this.Password = new BssBase.txtBase();
			this.GroupLogin.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.pictureBox1 ) ).BeginInit();
			this.SuspendLayout();
			// 
			// GroupLogin
			// 
			this.GroupLogin.BackColor = System.Drawing.Color.Beige;
			this.GroupLogin.Controls.Add( this.btnOk );
			this.GroupLogin.Controls.Add( this.listView1 );
			this.GroupLogin.Controls.Add( this.btnClose );
			this.GroupLogin.Controls.Add( this.pictureBox1 );
			this.GroupLogin.Controls.Add( this.bsslabel2 );
			this.GroupLogin.Controls.Add( this.Password );
			this.GroupLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupLogin.Font = new System.Drawing.Font( "Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.GroupLogin.Location = new System.Drawing.Point( 0, 0 );
			this.GroupLogin.Name = "GroupLogin";
			this.GroupLogin.Size = new System.Drawing.Size( 986, 600 );
			this.GroupLogin.TabIndex = 0;
			this.GroupLogin.TabStop = false;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 255 ) ) ) ), ( ( int )( ( ( byte )( 128 ) ) ) ) );
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Image = ( ( System.Drawing.Image )( resources.GetObject( "btnOk.Image" ) ) );
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new System.Drawing.Point( 758, 470 );
			this.btnOk.MinimumSize = new System.Drawing.Size( 132, 38 );
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size( 222, 62 );
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "ОK";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler( this.btnOk_Click );
			// 
			// listView1
			// 
			this.listView1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.listView1.Items.AddRange( new System.Windows.Forms.ListViewItem[] {
            listViewItem1} );
			this.listView1.Location = new System.Drawing.Point( 6, 426 );
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size( 473, 162 );
			this.listView1.TabIndex = 9;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point( 807, 484 );
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size( 133, 35 );
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Излез";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::MKelner.Properties.DResources.logoBakal;
			this.pictureBox1.Location = new System.Drawing.Point( 3, 31 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size( 980, 389 );
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			// 
			// bsslabel2
			// 
			this.bsslabel2.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.bsslabel2.AutoSize = true;
			this.bsslabel2.Location = new System.Drawing.Point( 492, 432 );
			this.bsslabel2.Name = "bsslabel2";
			this.bsslabel2.Size = new System.Drawing.Size( 116, 29 );
			this.bsslabel2.TabIndex = 5;
			this.bsslabel2.Text = "Лозинка:";
			// 
			// Password
			// 
			this.Password.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
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
			this.Password.KoristiFilterNaDatasource = false;
			this.Password.Location = new System.Drawing.Point( 614, 429 );
			this.Password.MakedonskiJazik = false;
			this.Password.MinLength = 0;
			this.Password.Name = "Password";
			this.Password.PopulateOtherFields = false;
			this.Password.prikaziKeyBoard = false;
			this.Password.regularExpression = null;
			this.Password.SelektrijaNaFokus = false;
			this.Password.Size = new System.Drawing.Size( 366, 35 );
			this.Password.TabIndex = 1;
			// 
			// Login
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size( 986, 600 );
			this.Controls.Add( this.GroupLogin );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Најава";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler( this.frmMainLogin_Load );
			this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.frmMainLogin_KeyDown );
			this.GroupLogin.ResumeLayout( false );
			this.GroupLogin.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.pictureBox1 ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private BssBase.groupBoxBase GroupLogin;
		private BssBase.txtBase Password;
		private BssBase.Elements.Bsslabel bsslabel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private BssBase.Elements.btnPotvrdi btnOk;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListView listView1;
	}
}


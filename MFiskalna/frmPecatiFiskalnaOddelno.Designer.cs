namespace MFiskalna {
	partial class frmPecatiFiskalnaOddelno {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmPecatiFiskalnaOddelno ) );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnPrenesiGiSite = new System.Windows.Forms.Button();
			this.btnVratiNazad = new System.Windows.Forms.Button();
			this.Prenesi = new System.Windows.Forms.Button();
			this.ArtikliOD = new BssBase.GridBig();
			this.PecatiArtikli = new BssBase.GridBig();
			this.btnPecatiFiskalnaOdMomentalni = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblArtikliOD = new System.Windows.Forms.Label();
			this.lblPecati = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.ArtikliOD ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.PecatiArtikli ) ).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add( this.btnPrenesiGiSite );
			this.groupBox2.Controls.Add( this.btnVratiNazad );
			this.groupBox2.Controls.Add( this.Prenesi );
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point( 301, 3 );
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size( 223, 464 );
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			// 
			// btnPrenesiGiSite
			// 
			this.btnPrenesiGiSite.BackColor = System.Drawing.Color.Beige;
			this.btnPrenesiGiSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnPrenesiGiSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrenesiGiSite.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btnPrenesiGiSite.Image = ( ( System.Drawing.Image )( resources.GetObject( "btnPrenesiGiSite.Image" ) ) );
			this.btnPrenesiGiSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrenesiGiSite.Location = new System.Drawing.Point( 3, 347 );
			this.btnPrenesiGiSite.Margin = new System.Windows.Forms.Padding( 10 );
			this.btnPrenesiGiSite.Name = "btnPrenesiGiSite";
			this.btnPrenesiGiSite.Size = new System.Drawing.Size( 217, 114 );
			this.btnPrenesiGiSite.TabIndex = 12;
			this.btnPrenesiGiSite.Text = "Пренеси ги сите";
			this.btnPrenesiGiSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrenesiGiSite.UseVisualStyleBackColor = false;
			this.btnPrenesiGiSite.Click += new System.EventHandler( this.btnPrenesiGiSite_Click );
			// 
			// btnVratiNazad
			// 
			this.btnVratiNazad.BackColor = System.Drawing.Color.Beige;
			this.btnVratiNazad.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnVratiNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVratiNazad.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btnVratiNazad.Image = ( ( System.Drawing.Image )( resources.GetObject( "btnVratiNazad.Image" ) ) );
			this.btnVratiNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVratiNazad.Location = new System.Drawing.Point( 3, 130 );
			this.btnVratiNazad.Margin = new System.Windows.Forms.Padding( 10 );
			this.btnVratiNazad.Name = "btnVratiNazad";
			this.btnVratiNazad.Padding = new System.Windows.Forms.Padding( 10 );
			this.btnVratiNazad.Size = new System.Drawing.Size( 217, 114 );
			this.btnVratiNazad.TabIndex = 11;
			this.btnVratiNazad.Text = "Врати ги сите";
			this.btnVratiNazad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVratiNazad.UseVisualStyleBackColor = false;
			this.btnVratiNazad.Click += new System.EventHandler( this.btnVratiNazad_Click );
			// 
			// Prenesi
			// 
			this.Prenesi.BackColor = System.Drawing.Color.Beige;
			this.Prenesi.Dock = System.Windows.Forms.DockStyle.Top;
			this.Prenesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Prenesi.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.Prenesi.Image = ( ( System.Drawing.Image )( resources.GetObject( "Prenesi.Image" ) ) );
			this.Prenesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Prenesi.Location = new System.Drawing.Point( 3, 16 );
			this.Prenesi.Margin = new System.Windows.Forms.Padding( 10 );
			this.Prenesi.Name = "Prenesi";
			this.Prenesi.Padding = new System.Windows.Forms.Padding( 10 );
			this.Prenesi.Size = new System.Drawing.Size( 217, 114 );
			this.Prenesi.TabIndex = 10;
			this.Prenesi.Text = "Пренеси";
			this.Prenesi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Prenesi.UseVisualStyleBackColor = false;
			this.Prenesi.Click += new System.EventHandler( this.Prenesi_Click );
			// 
			// ArtikliOD
			// 
			this.ArtikliOD.AllowUserToAddRows = false;
			this.ArtikliOD.AllowUserToDeleteRows = false;
			this.ArtikliOD.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.ArtikliOD.AssemblyToLoad = null;
			this.ArtikliOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ArtikliOD.EditForm = null;
			this.ArtikliOD.FilterForm = null;
			this.ArtikliOD.Location = new System.Drawing.Point( 3, 3 );
			this.ArtikliOD.Name = "ArtikliOD";
			this.ArtikliOD.PrimaryKey = "ID";
			this.ArtikliOD.ReadOnly = true;
			this.ArtikliOD.reportCenter = false;
			this.ArtikliOD.ReportName = null;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.ArtikliOD.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.ArtikliOD.RowTemplate.Height = 36;
			this.ArtikliOD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ArtikliOD.Size = new System.Drawing.Size( 292, 464 );
			this.ArtikliOD.SQLCommandQuery = null;
			this.ArtikliOD.TabIndex = 7;
			this.ArtikliOD.UpdateTable = null;
			this.ArtikliOD.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler( this.ArtikliOD_DataBindingComplete );
			// 
			// PecatiArtikli
			// 
			this.PecatiArtikli.AllowUserToAddRows = false;
			this.PecatiArtikli.AllowUserToDeleteRows = false;
			this.PecatiArtikli.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.PecatiArtikli.AssemblyToLoad = null;
			this.PecatiArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PecatiArtikli.EditForm = null;
			this.PecatiArtikli.FilterForm = null;
			this.PecatiArtikli.Location = new System.Drawing.Point( 530, 3 );
			this.PecatiArtikli.Name = "PecatiArtikli";
			this.PecatiArtikli.PrimaryKey = "ID";
			this.PecatiArtikli.ReadOnly = true;
			this.PecatiArtikli.reportCenter = false;
			this.PecatiArtikli.ReportName = null;
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding( 2, 0, 0, 0 );
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Beige;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.PecatiArtikli.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.PecatiArtikli.RowTemplate.Height = 36;
			this.PecatiArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.PecatiArtikli.Size = new System.Drawing.Size( 293, 464 );
			this.PecatiArtikli.SQLCommandQuery = null;
			this.PecatiArtikli.TabIndex = 9;
			this.PecatiArtikli.UpdateTable = null;
			this.PecatiArtikli.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler( this.PecatiArtikli_DataBindingComplete );
			// 
			// btnPecatiFiskalnaOdMomentalni
			// 
			this.btnPecatiFiskalnaOdMomentalni.BackColor = System.Drawing.Color.Beige;
			this.btnPecatiFiskalnaOdMomentalni.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnPecatiFiskalnaOdMomentalni.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btnPecatiFiskalnaOdMomentalni.Image = ( ( System.Drawing.Image )( resources.GetObject( "btnPecatiFiskalnaOdMomentalni.Image" ) ) );
			this.btnPecatiFiskalnaOdMomentalni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPecatiFiskalnaOdMomentalni.Location = new System.Drawing.Point( 530, 473 );
			this.btnPecatiFiskalnaOdMomentalni.Name = "btnPecatiFiskalnaOdMomentalni";
			this.btnPecatiFiskalnaOdMomentalni.Size = new System.Drawing.Size( 293, 41 );
			this.btnPecatiFiskalnaOdMomentalni.TabIndex = 0;
			this.btnPecatiFiskalnaOdMomentalni.Text = "Печати Фискална  за одбраните артикли";
			this.btnPecatiFiskalnaOdMomentalni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPecatiFiskalnaOdMomentalni.UseVisualStyleBackColor = false;
			this.btnPecatiFiskalnaOdMomentalni.Click += new System.EventHandler( this.btnPecatiFiskalnaOdMomentalni_Click );
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 36.11111F ) );
			this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 27.77778F ) );
			this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 36.11111F ) );
			this.tableLayoutPanel1.Controls.Add( this.btnPecatiFiskalnaOdMomentalni, 2, 1 );
			this.tableLayoutPanel1.Controls.Add( this.PecatiArtikli, 2, 0 );
			this.tableLayoutPanel1.Controls.Add( this.ArtikliOD, 0, 0 );
			this.tableLayoutPanel1.Controls.Add( this.groupBox2, 1, 0 );
			this.tableLayoutPanel1.Controls.Add( this.lblArtikliOD, 0, 2 );
			this.tableLayoutPanel1.Controls.Add( this.lblPecati, 2, 2 );
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 47F ) );
			this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 31F ) );
			this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 23F ) );
			this.tableLayoutPanel1.Size = new System.Drawing.Size( 826, 571 );
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblArtikliOD
			// 
			this.lblArtikliOD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblArtikliOD.Font = new System.Drawing.Font( "Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.lblArtikliOD.Location = new System.Drawing.Point( 3, 517 );
			this.lblArtikliOD.Name = "lblArtikliOD";
			this.lblArtikliOD.Size = new System.Drawing.Size( 292, 31 );
			this.lblArtikliOD.TabIndex = 15;
			this.lblArtikliOD.Text = "0";
			this.lblArtikliOD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblPecati
			// 
			this.lblPecati.BackColor = System.Drawing.Color.Lavender;
			this.lblPecati.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPecati.Font = new System.Drawing.Font( "Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.lblPecati.Location = new System.Drawing.Point( 530, 517 );
			this.lblPecati.Name = "lblPecati";
			this.lblPecati.Size = new System.Drawing.Size( 293, 31 );
			this.lblPecati.TabIndex = 16;
			this.lblPecati.Text = "0";
			this.lblPecati.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// frmPecatiFiskalnaOddelno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 826, 571 );
			this.Controls.Add( this.tableLayoutPanel1 );
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.Name = "frmPecatiFiskalnaOddelno";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.frmPecatiFiskalnaOddelno_KeyDown );
			this.groupBox2.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.ArtikliOD ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.PecatiArtikli ) ).EndInit();
			this.tableLayoutPanel1.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnPrenesiGiSite;
		private System.Windows.Forms.Button btnVratiNazad;
		private System.Windows.Forms.Button Prenesi;
		private BssBase.GridBig ArtikliOD;
		private BssBase.GridBig PecatiArtikli;
		private System.Windows.Forms.Button btnPecatiFiskalnaOdMomentalni;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblArtikliOD;
		private System.Windows.Forms.Label lblPecati;


	}
}
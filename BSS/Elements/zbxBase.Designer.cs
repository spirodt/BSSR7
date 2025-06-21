namespace BssBase {
	partial class zbxBase {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.open = new System.Windows.Forms.Button();
			this.Value = new BssBase.txtBase();
			this.SuspendLayout();
			// 
			// open
			// 
			this.open.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.open.Location = new System.Drawing.Point(0, 3);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(34, 19);
			this.open.TabIndex = 3;
			this.open.TabStop = false;
			this.open.Text = "...";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.open_Click);
			// 
			// Value
			// 
			this.Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Value.AssemblyStr = null;
			this.Value.C_FillWithZeros = false;
			this.Value.C_OnlyNumbers = true;
			this.Value.C_RegEx = false;
			this.Value.C_ShowRedOnLeaveIfEmpty = false;
			this.Value.ColumnName1 = null;
			this.Value.ColumnName2 = null;
			this.Value.ColumnName3 = null;
			this.Value.ColumnName4 = null;
			this.Value.ColumnName5 = null;
			this.Value.ColumnName6 = null;
			this.Value.ColumnName7 = null;
			this.Value.daliCetiri = false;
			this.Value.formToOpen = null;
			this.Value.Location = new System.Drawing.Point(40, 2);
			this.Value.MakedonskiJazik = false;
			this.Value.MaxLength = 10;
			this.Value.MinLength = 0;
			this.Value.Name = "Value";
			this.Value.PopulateOtherFields = false;
			this.Value.regularExpression = null;
			this.Value.SelektrijaNaFokus = false;
			this.Value.Size = new System.Drawing.Size(80, 20);
			this.Value.TabIndex = 2;
			this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
			this.Value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Value_KeyDown);
			// 
			// zbxBase
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.open);
			this.Controls.Add(this.Value);
			this.MinimumSize = new System.Drawing.Size(123, 20);
			this.Name = "zbxBase";
			this.Size = new System.Drawing.Size(123, 25);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zbxBase_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button open;
		public txtBase Value;
	}
}

namespace BssBase.Forms {
	partial class frmVnesNaEdnaStavka {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVnesNaEdnaStavka));
            this.GVnes = new BssBase.groupBoxBase();
            this.groupStavki = new System.Windows.Forms.GroupBox();
            this.MeniStavki = new System.Windows.Forms.MenuStrip();
            this.btnNovaStavka = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzmeniStavka = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzbrisiStavka = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSocuvajStavka = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReload = new System.Windows.Forms.ToolStripMenuItem();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupDugminja.SuspendLayout();
            this.groupStavki.SuspendLayout();
            this.MeniStavki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori1
            // 
            resources.ApplyResources(this.btnZatvori1, "btnZatvori1");
            this.btnZatvori1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // groupDugminja
            // 
            resources.ApplyResources(this.groupDugminja, "groupDugminja");
            // 
            // GVnes
            // 
            resources.ApplyResources(this.GVnes, "GVnes");
            this.GVnes.Name = "GVnes";
            this.GVnes.TabStop = false;
            // 
            // groupStavki
            // 
            resources.ApplyResources(this.groupStavki, "groupStavki");
            this.groupStavki.Controls.Add(this.MeniStavki);
            this.groupStavki.Controls.Add(this.Navigator);
            this.groupStavki.Name = "groupStavki";
            this.groupStavki.TabStop = false;
            // 
            // MeniStavki
            // 
            resources.ApplyResources(this.MeniStavki, "MeniStavki");
            this.MeniStavki.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MeniStavki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaStavka,
            this.btnIzmeniStavka,
            this.btnIzbrisiStavka,
            this.btnSocuvajStavka,
            this.btnReload});
            this.MeniStavki.Name = "MeniStavki";
            this.MeniStavki.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MeniStavki.ShowItemToolTips = true;
            // 
            // btnNovaStavka
            // 
            resources.ApplyResources(this.btnNovaStavka, "btnNovaStavka");
            this.btnNovaStavka.Image = global::BssBase.Properties.Resources._001_01;
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Click += new System.EventHandler(this.btnNovaStavka_Click);
            // 
            // btnIzmeniStavka
            // 
            resources.ApplyResources(this.btnIzmeniStavka, "btnIzmeniStavka");
            this.btnIzmeniStavka.Image = global::BssBase.Properties.Resources.EditTableHS;
            this.btnIzmeniStavka.Name = "btnIzmeniStavka";
            this.btnIzmeniStavka.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnIzmeniStavka.Click += new System.EventHandler(this.btnIzmeniStavka_Click);
            // 
            // btnIzbrisiStavka
            // 
            resources.ApplyResources(this.btnIzbrisiStavka, "btnIzbrisiStavka");
            this.btnIzbrisiStavka.Image = global::BssBase.Properties.Resources._001_02;
            this.btnIzbrisiStavka.Name = "btnIzbrisiStavka";
            this.btnIzbrisiStavka.Click += new System.EventHandler(this.btnIzbrisiStavka_Click);
            // 
            // btnSocuvajStavka
            // 
            resources.ApplyResources(this.btnSocuvajStavka, "btnSocuvajStavka");
            this.btnSocuvajStavka.Image = global::BssBase.Properties.Resources._001_06;
            this.btnSocuvajStavka.Name = "btnSocuvajStavka";
            this.btnSocuvajStavka.Click += new System.EventHandler(this.btnSocuvajStavka_Click);
            // 
            // btnReload
            // 
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Image = global::BssBase.Properties.Resources.undo1;
            this.btnReload.Name = "btnReload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Navigator
            // 
            resources.ApplyResources(this.Navigator, "Navigator");
            this.Navigator.AddNewItem = null;
            this.Navigator.CountItem = this.bindingNavigatorCountItem;
            this.Navigator.CountItemFormat = "од {0}";
            this.Navigator.DeleteItem = null;
            this.Navigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.Navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.bindingNavigatorPositionItem;
            this.Navigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Navigator.Stretch = true;
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::BssBase.Properties.Resources._001_27;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::BssBase.Properties.Resources._001_23;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::BssBase.Properties.Resources._001_21;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::BssBase.Properties.Resources._001_25;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // frmVnesNaEdnaStavka
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupStavki);
            this.Controls.Add(this.GVnes);
            this.Name = "frmVnesNaEdnaStavka";
            this.Controls.SetChildIndex(this.groupDugminja, 0);
            this.Controls.SetChildIndex(this.GVnes, 0);
            this.Controls.SetChildIndex(this.groupStavki, 0);
            this.groupDugminja.ResumeLayout(false);
            this.groupStavki.ResumeLayout(false);
            this.groupStavki.PerformLayout();
            this.MeniStavki.ResumeLayout(false);
            this.MeniStavki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public groupBoxBase GVnes;
		public System.Windows.Forms.GroupBox groupStavki;
		public System.Windows.Forms.MenuStrip MeniStavki;
		public System.Windows.Forms.ToolStripMenuItem btnNovaStavka;
		public System.Windows.Forms.ToolStripMenuItem btnIzmeniStavka;
		public System.Windows.Forms.ToolStripMenuItem btnIzbrisiStavka;
		public System.Windows.Forms.BindingNavigator Navigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		public System.Windows.Forms.ToolStripMenuItem btnSocuvajStavka;
		public System.Windows.Forms.ToolStripMenuItem btnReload;

	}
}
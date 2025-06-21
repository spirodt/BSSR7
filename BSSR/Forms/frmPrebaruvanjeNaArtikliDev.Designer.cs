using System.Windows.Forms;

namespace BSSR.Forms {
	partial class frmPrebaruvanjeNaArtikliDev
	{
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
            this.txtSearch = new BssBase.txtBase();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBase1 = new BssBase.groupBoxBase();
            this.rPocnuva = new System.Windows.Forms.RadioButton();
            this.rBiloKde = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchGrid = new BssBase.DevGrid();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKlucniZborovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdaznaCena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormativ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPodgrupaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVStapka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSearchString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltSifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupaNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPodGrupaNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMomentalZaliha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MainTab.SuspendLayout();
            this.tabVnes.SuspendLayout();
            this.groupVnes.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.groupBoxBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Size = new System.Drawing.Size(1190, 642);
            this.MainTab.TabIndex = 0;
            // 
            // tabVnes
            // 
            this.tabVnes.AutoScroll = true;
            this.tabVnes.Size = new System.Drawing.Size(1182, 616);
            // 
            // groupVnes
            // 
            this.groupVnes.Controls.Add(this.searchGrid);
            this.groupVnes.Controls.Add(this.button1);
            this.groupVnes.Controls.Add(this.label2);
            this.groupVnes.Controls.Add(this.comboBox1);
            this.groupVnes.Controls.Add(this.groupBoxBase1);
            this.groupVnes.Controls.Add(this.label1);
            this.groupVnes.Controls.Add(this.txtSearch);
            this.groupVnes.Size = new System.Drawing.Size(1179, 633);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Location = new System.Drawing.Point(0, 648);
            this.PanelFooter.Size = new System.Drawing.Size(1194, 53);
            // 
            // btnZatvori
            // 
            this.btnZatvori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZatvori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZatvori.Location = new System.Drawing.Point(6, 7);
            this.btnZatvori.Size = new System.Drawing.Size(181, 38);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(999, 7);
            this.btnOk.Size = new System.Drawing.Size(181, 38);
            this.btnOk.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AssemblyStr = null;
            this.txtSearch.C_FillWithZeros = false;
            this.txtSearch.C_OnlyNumbers = false;
            this.txtSearch.C_RegEx = false;
            this.txtSearch.C_ShowRedOnLeaveIfEmpty = false;
            this.txtSearch.ColumnName1 = null;
            this.txtSearch.ColumnName2 = null;
            this.txtSearch.ColumnName3 = null;
            this.txtSearch.ColumnName4 = null;
            this.txtSearch.ColumnName5 = null;
            this.txtSearch.ColumnName6 = null;
            this.txtSearch.ColumnName7 = null;
            this.txtSearch.daliCetiri = false;
            this.txtSearch.Format = null;
            this.txtSearch.formToOpen = null;
            this.txtSearch.iscistiGreenNaLeave = false;
            this.txtSearch.KoristiFilterNaDatasource = false;
            this.txtSearch.Location = new System.Drawing.Point(135, 20);
            this.txtSearch.MakedonskiJazik = false;
            this.txtSearch.MinLength = 0;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PopulateOtherFields = false;
            this.txtSearch.regularExpression = null;
            this.txtSearch.SelektrijaNaFokus = false;
            this.txtSearch.Size = new System.Drawing.Size(368, 35);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст:";
            // 
            // groupBoxBase1
            // 
            this.groupBoxBase1.Controls.Add(this.rPocnuva);
            this.groupBoxBase1.Controls.Add(this.rBiloKde);
            this.groupBoxBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBoxBase1.Location = new System.Drawing.Point(909, 8);
            this.groupBoxBase1.Name = "groupBoxBase1";
            this.groupBoxBase1.Size = new System.Drawing.Size(269, 47);
            this.groupBoxBase1.TabIndex = 3;
            this.groupBoxBase1.TabStop = false;
            this.groupBoxBase1.Text = "Се содржи во";
            // 
            // rPocnuva
            // 
            this.rPocnuva.AutoSize = true;
            this.rPocnuva.Checked = true;
            this.rPocnuva.Location = new System.Drawing.Point(123, 21);
            this.rPocnuva.Name = "rPocnuva";
            this.rPocnuva.Size = new System.Drawing.Size(135, 19);
            this.rPocnuva.TabIndex = 1;
            this.rPocnuva.TabStop = true;
            this.rPocnuva.Text = "Почекот на зборот";
            this.rPocnuva.UseVisualStyleBackColor = true;
            // 
            // rBiloKde
            // 
            this.rBiloKde.AutoSize = true;
            this.rBiloKde.Location = new System.Drawing.Point(16, 21);
            this.rBiloKde.Name = "rBiloKde";
            this.rBiloKde.Size = new System.Drawing.Size(84, 19);
            this.rBiloKde.TabIndex = 0;
            this.rBiloKde.Text = "Било каде";
            this.rBiloKde.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Клучен збор",
            "Шифра",
            "Алтернативна Шифра",
            "Назив",
            "Група ",
            "Подгрупа",
            "Комбинација",
            "Сите колони",
            "Баркод"});
            this.comboBox1.Location = new System.Drawing.Point(569, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 37);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Во:";
            // 
            // button1
            // 
            this.button1.Image = global::BSSR.Properties.Resources._001_01;
            this.button1.Location = new System.Drawing.Point(1, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchGrid
            // 
            this.searchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGrid.AssemblyToLoad = null;
            this.searchGrid.DataSource = this.dataTableBindingSource;
            this.searchGrid.EditForm = null;
            this.searchGrid.FilterForm = null;
            this.searchGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchGrid.Location = new System.Drawing.Point(5, 65);
            this.searchGrid.MainView = this.searchView;
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.PrimaryKey = null;
            this.searchGrid.reportCenter = false;
            this.searchGrid.ReportName = null;
            this.searchGrid.Size = new System.Drawing.Size(1171, 541);
            this.searchGrid.TabIndex = 7;
            this.searchGrid.TabStop = false;
            this.searchGrid.UpdateTable = null;
            this.searchGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.searchView});
            this.searchGrid.DoubleClick += new System.EventHandler(this.viewSveUEdnoGridBig_DoubleClick);
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // searchView
            // 
            this.searchView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.searchView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Blue;
            this.searchView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.searchView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.searchView.Appearance.FocusedRow.Options.UseFont = true;
            this.searchView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.searchView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.searchView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.searchView.Appearance.HeaderPanel.Options.UseFont = true;
            this.searchView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 16.75F);
            this.searchView.Appearance.Row.Options.UseFont = true;
            this.searchView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSifra,
            this.colStatus,
            this.colNaziv,
            this.colKlucniZborovi,
            this.colProdaznaCena,
            this.colNormativ,
            this.colFirmaID,
            this.colPodgrupaID,
            this.colDDV,
            this.colEDM,
            this.colDDVStapka,
            this.colSearchString,
            this.colAltSifra,
            this.colGrupaNaziv,
            this.colPodGrupaNaziv,
            this.colBarkod,
            this.colMomentalZaliha});
            this.searchView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.searchView.GridControl = this.searchGrid;
            this.searchView.Name = "searchView";
            this.searchView.OptionsBehavior.Editable = false;
            this.searchView.OptionsCustomization.AllowFilter = false;
            this.searchView.OptionsCustomization.AllowGroup = false;
            this.searchView.OptionsPrint.EnableAppearanceOddRow = true;
            this.searchView.OptionsPrint.PrintFilterInfo = true;
            this.searchView.OptionsPrint.PrintFooter = false;
            this.searchView.OptionsPrint.PrintGroupFooter = false;
            this.searchView.OptionsPrint.PrintSelectedRowsOnly = true;
            this.searchView.OptionsView.EnableAppearanceOddRow = true;
            this.searchView.OptionsView.RowAutoHeight = true;
            this.searchView.OptionsView.ShowDetailButtons = false;
            this.searchView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "Реден број";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colSifra
            // 
            this.colSifra.Caption = "Шифра";
            this.colSifra.FieldName = "Sifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Visible = true;
            this.colSifra.VisibleIndex = 0;
            this.colSifra.Width = 105;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Статус";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colNaziv
            // 
            this.colNaziv.Caption = "Назив";
            this.colNaziv.FieldName = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.Visible = true;
            this.colNaziv.VisibleIndex = 2;
            this.colNaziv.Width = 351;
            // 
            // colKlucniZborovi
            // 
            this.colKlucniZborovi.Caption = "Клучни зборови";
            this.colKlucniZborovi.FieldName = "KlucniZborovi";
            this.colKlucniZborovi.Name = "colKlucniZborovi";
            // 
            // colProdaznaCena
            // 
            this.colProdaznaCena.Caption = "Продажна цена";
            this.colProdaznaCena.FieldName = "ProdaznaCena";
            this.colProdaznaCena.Name = "colProdaznaCena";
            this.colProdaznaCena.Visible = true;
            this.colProdaznaCena.VisibleIndex = 5;
            this.colProdaznaCena.Width = 165;
            // 
            // colNormativ
            // 
            this.colNormativ.Caption = "Норматив";
            this.colNormativ.FieldName = "Normativ";
            this.colNormativ.Name = "colNormativ";
            // 
            // colFirmaID
            // 
            this.colFirmaID.Caption = "Фирма";
            this.colFirmaID.FieldName = "FirmaID";
            this.colFirmaID.Name = "colFirmaID";
            // 
            // colPodgrupaID
            // 
            this.colPodgrupaID.Caption = "Подрупа ид";
            this.colPodgrupaID.FieldName = "PodgrupaID";
            this.colPodgrupaID.Name = "colPodgrupaID";
            // 
            // colDDV
            // 
            this.colDDV.Caption = "ДДВ";
            this.colDDV.FieldName = "DDV";
            this.colDDV.Name = "colDDV";
            // 
            // colEDM
            // 
            this.colEDM.Caption = "ЕДМ";
            this.colEDM.FieldName = "EDM";
            this.colEDM.Name = "colEDM";
            this.colEDM.Visible = true;
            this.colEDM.VisibleIndex = 3;
            this.colEDM.Width = 70;
            // 
            // colDDVStapka
            // 
            this.colDDVStapka.Caption = "Стапка ддв";
            this.colDDVStapka.FieldName = "DDVStapka";
            this.colDDVStapka.Name = "colDDVStapka";
            // 
            // colSearchString
            // 
            this.colSearchString.Caption = "Пребарување";
            this.colSearchString.FieldName = "SearchString";
            this.colSearchString.Name = "colSearchString";
            // 
            // colAltSifra
            // 
            this.colAltSifra.Caption = "Алт.Шифра";
            this.colAltSifra.FieldName = "AltSifra";
            this.colAltSifra.Name = "colAltSifra";
            // 
            // colGrupaNaziv
            // 
            this.colGrupaNaziv.FieldName = "GrupaNaziv";
            this.colGrupaNaziv.Name = "colGrupaNaziv";
            // 
            // colPodGrupaNaziv
            // 
            this.colPodGrupaNaziv.Caption = "Група";
            this.colPodGrupaNaziv.FieldName = "PodGrupaNaziv";
            this.colPodGrupaNaziv.Name = "colPodGrupaNaziv";
            this.colPodGrupaNaziv.Visible = true;
            this.colPodGrupaNaziv.VisibleIndex = 6;
            this.colPodGrupaNaziv.Width = 141;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Баркод";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 114;
            // 
            // colMomentalZaliha
            // 
            this.colMomentalZaliha.Caption = "Залиха";
            this.colMomentalZaliha.FieldName = "MomentalZaliha";
            this.colMomentalZaliha.Name = "colMomentalZaliha";
            this.colMomentalZaliha.Visible = true;
            this.colMomentalZaliha.VisibleIndex = 4;
            this.colMomentalZaliha.Width = 95;
            // 
            // frmPrebaruvanjeNaArtikliDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 701);
            this.Name = "frmPrebaruvanjeNaArtikliDev";
            this.ProveriZaValidniPolinjaIDaliImaIzmeni = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пребаување на артикли";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrebaruvanjeNaArtikliDev_FormClosing);
            this.Load += new System.EventHandler(this.frmPrebaruvanjeNaArtikliDev_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewSveUEdnoGridBig_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmPrebaruvanjeNaArtikliDev_MouseDoubleClick);
            this.MainTab.ResumeLayout(false);
            this.tabVnes.ResumeLayout(false);
            this.groupVnes.ResumeLayout(false);
            this.groupVnes.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            this.groupBoxBase1.ResumeLayout(false);
            this.groupBoxBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private BssBase.txtBase txtSearch;
        private BssBase.groupBoxBase groupBoxBase1;
        private System.Windows.Forms.RadioButton rPocnuva;
        private System.Windows.Forms.RadioButton rBiloKde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private BssBase.DevGrid searchGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView searchView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colKlucniZborovi;
        private DevExpress.XtraGrid.Columns.GridColumn colProdaznaCena;
        private DevExpress.XtraGrid.Columns.GridColumn colNormativ;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaID;
        private DevExpress.XtraGrid.Columns.GridColumn colPodgrupaID;
        private DevExpress.XtraGrid.Columns.GridColumn colDDV;
        private DevExpress.XtraGrid.Columns.GridColumn colEDM;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVStapka;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchString;
        private DevExpress.XtraGrid.Columns.GridColumn colAltSifra;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupaNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colPodGrupaNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colMomentalZaliha;
        private BindingSource dataTableBindingSource;
    }
}
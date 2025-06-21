using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using static Tools;

namespace MMaterijalno.Forms
{
    public partial class frmIzvodi : Form
    {
        public frmIzvodi()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            dtShowDataOD.Value = BssBase.settings.DateTimeOd;
            dtShowDataDO.Value = BssBase.settings.DateTimeDo;

            if (BssBase.settings.NeLoadirajPodatociNaStartNaForma == "false")
            viewIzvodiTableAdapter.Fill(materijalnoDataSet.viewIzvodi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void viewDokumentiGridBig_DataInsert()
        {
            viewIzvodiTableAdapter.Fill(materijalnoDataSet.viewIzvodi, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void viewDokumentiGridBig_dataSaveAll()
        {
            viewIzvodiBindingSource.EndEdit();
            viewIzvodiTableAdapter.Update(materijalnoDataSet.viewIzvodi);
        }

        private void viewDokumentiGridBig_DoubleClick(object sender, EventArgs e)
        {
            bтнОтвори.PerformClick();
        }
        private void bтнОтвори_Click_1(object sender, EventArgs e)
        {
            if (!Equals(null, viewIzvodiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewIzvodiBindingSource.Current)["ID"].ToString());
                frmObrabotkaNaIzvodi dokumenti = new frmObrabotkaNaIzvodi(id);
                dokumenti.ShowDialog();
                viewIzvodiTableAdapter.Fill(materijalnoDataSet.viewIzvodi, dtShowDataOD.Value, dtShowDataDO.Value);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            viewDokumentiGridBig.Osvezi();
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            viewDokumentiGridBig.izbrisi();
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            frmObrabotkaNaIzvodi Dokumenti = new frmObrabotkaNaIzvodi();
            Dokumenti.ShowDialog();
            viewIzvodiTableAdapter.Fill(materijalnoDataSet.viewIzvodi, dtShowDataOD.Value, dtShowDataDO.Value);
        }
        private void frmInterniDokumenti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                bindingNavigatorAddNewItem.PerformClick();
            }

            if (e.KeyCode == Keys.F2)
            {
                bтнОтвори.PerformClick();
            }

            

            if (e.KeyCode == Keys.F4)
            {
                toolStripButton2.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                toolStripButton1.PerformClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                bindingNavigatorDeleteItem.PerformClick();
            }
        }

        private void frmIzvodi_Load(object sender, EventArgs e)
        {
            gridView1.ActiveFilter.Clear();
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        }

        private void btnPrikaziSe_Click(object sender, EventArgs e)
        {
            viewIzvodiTableAdapter.FillByAll(materijalnoDataSet.viewIzvodi);
        }

        private void btnPrikaziSporedFiltri_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private string GetCurentValueForColumnName(int rowHandle, string column)
        {
            // Get the value for the given column - convert to the type you're expecting
            var obj = this.gridView1.GetRowCellValue(rowHandle, column);
            if (obj != null)
            {
                var value = obj.ToString();
                return value;

            }
            return string.Empty;
        }

        private void PrintIzvod( int selectedId , string brojNaIzvodtxtBase, DateTime datumNaIzvodDateTimePicker, string smetka)
        {
            GridControl printGrid = new GridControl();
            var gridView = new GridView(printGrid)
            {
                Name = "gridView"
            };

            printGrid.MainView = gridView;
            printGrid.BindingContext = new System.Windows.Forms.BindingContext();
            PrintableComponentLink link = PrintGridSettings(brojNaIzvodtxtBase,datumNaIzvodDateTimePicker,smetka);
            link.Component = printGrid;
            printGrid.DataSource = Tools.GetIzvodStavki(selectedId);
            printGrid.RefreshDataSource();
            gridView.PopulateColumns();

            GridFormatRule gridFormatRule = new GridFormatRule();

            FormatConditionRuleValue formatConditionRuleValue = new FormatConditionRuleValue();
            gridFormatRule.Column = gridView.Columns["Naziv"];
            formatConditionRuleValue.PredefinedName = "Title";
            formatConditionRuleValue.Condition = FormatCondition.Equal;
            formatConditionRuleValue.Value1 = "Документ";
            formatConditionRuleValue.Appearance.BackColor = Color.Gray;
            gridFormatRule.Rule = formatConditionRuleValue;
            gridFormatRule.ApplyToRow = true;
            gridView.FormatRules.Add(gridFormatRule);


            gridView.Columns["Sifra"].Caption = "Кат-Стан / Шифра";
            gridView.Columns["Sifra"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView.Columns["Partner"].MinWidth = 100;
            gridView.Columns["Partner"].MaxWidth = 150;
            gridView.Columns["Partner"].Caption = "Партнер";
            gridView.Columns["Partner"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView.Columns["Partner"].MinWidth = 250;
            gridView.Columns["BrojNaDokument"].Caption = "Број на документ";
            gridView.Columns["BrojNaDokument"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView.Columns["IznosDokument"].Caption = "Износ на документ";
            gridView.Columns["TipNaDokument"].Caption = "Тип на документ";
            gridView.Columns["TipNaDokument"].Visible = false;
            gridView.Columns["Dolzi"].Caption = "Должи";
            gridView.Columns["Pobaruva"].Caption = "Побарува";

            gridView.Columns["Partner"].Caption = "Партнер";


            link.ShowPreview();
        }

        private PrintableComponentLink PrintGridSettings(string brojNaIzvodtxtBase, DateTime datumNaIzvodDateTimePicker, string smetka)
        {
            var link = new PrintableComponentLink(new PrintingSystem())
            {
                Landscape = true
            };
            var phf = link.PageHeaderFooter as PageHeaderFooter;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = $"Извод број {brojNaIzvodtxtBase} Од Датум {datumNaIzvodDateTimePicker:dd.MM.yyyy} {Environment.NewLine} Сметка:{smetka}";
            string rightColumn = "Датум: " + DateTime.Now.ToString("dd.MM.yyyy");

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            phf.Footer.Content.Clear();
            var info = Tools.NajdiInfoZaFirma(1);
            var NazivNaFirma = info.Table.Rows[0]["ImeNaFirma"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Adresa"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Grad"].ToString();
            var FmiddleColumn = NazivNaFirma;
            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;

            return link;
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {

            string brojNaIzvodtxtBase = string.Empty;
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int rowHandle = gridView1.GetSelectedRows()[i];
                DevExpress.XtraGrid.Views.Grid.GridView detail = (DevExpress.XtraGrid.Views.Grid.GridView)gridView1.GetDetailView(rowHandle, 0);
                var selectedId =  Tools.PrazenStringToInt(GetCurentValueForColumnName(rowHandle, "ID"), 0);
                

                if (selectedId != 0 && brojNaIzvodtxtBase != GetCurentValueForColumnName(rowHandle, "BrojNaIzvod"))
                {
                    brojNaIzvodtxtBase = GetCurentValueForColumnName(rowHandle, "BrojNaIzvod");
                    var smetka = GetCurentValueForColumnName(rowHandle, "Smetka");
                    var datumNaIzvodDateTimePicker = Convert.ToDateTime(GetCurentValueForColumnName(rowHandle, "DatumNaIzvod")); ;
                    PrintIzvod(selectedId,brojNaIzvodtxtBase, datumNaIzvodDateTimePicker, smetka);
                }

            }
        }
    }
}

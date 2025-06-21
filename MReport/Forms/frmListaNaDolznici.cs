using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using BssBase;
using BssBase.Roots;

using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

using static Tools;

namespace MReport.Forms
{
    public partial class frmListaNaDolznici : frmIzvestaj
    {
        public string NazivNaFirma = string.Empty;
        public string MailText = string.Empty;
        public frmListaNaDolznici()
        {
            InitializeComponent();
            this.gridView1.FilterEditorCreated += GridView1_FilterEditorCreated;
            this.gridView1.PrintInitialize += GridView1_PrintInitialize;


            //this.gridControl1.zameniMeni(menu);

        }

        private void ShowPartnerMenu_Click(object sender, EventArgs e)
        {
            var sifra = GetCurentValueForColumnName("Sifra");

            var partner = Tools.PrazenStringToInt(Tools.NajdiInfoZaSifraPartner(sifra)["Id"].ToString(), 0);
            if (partner > 0)
            {
                MFakturi.Forms.frmPartneriEdit frm = new MFakturi.Forms.frmPartneriEdit(partner, true);
                frm.ShowDialog();
            }
        }

        private string GetCurentValueForColumnName(string column)
        {
            // Get your currently selected grid row
            var rowHandle = this.gridView1.FocusedRowHandle;

            // Get the value for the given column - convert to the type you're expecting
            var obj = this.gridView1.GetRowCellValue(rowHandle, column);
            if (obj != null)
            {
                var sifra = obj.ToString();
                return sifra;

            }
            return string.Empty;
        }

        private void GridView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.Landscape = true;
            pb.PageMargins.Bottom = 1;
            pb.PageMargins.Top = 1;
            pb.PageMargins.Left = 1;
            pb.PageMargins.Right = 1;



        }

        private void GridView1_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.FilterControl.AppearanceValueColor = Color.Red;
            e.FilterControl.ShowOperandTypeIcon = true;
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.saldoPoDokumentBindingSource.Filter = string.Empty;
            this.saldoPoDokumentTableAdapter.Fill(this.bSSRDataSet.SaldoPoDokument, false, DatumDo.SelectionStart);
            presmetaj();
            Cursor.Current = Cursors.Default;
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            if (this.bSSRDataSet.SaldoPoDokument.Rows.Count > 0)
            {
                PrintableComponentLink link = PrintGridSettings();

                link.ShowPreview();
            }
        }



        private PrintableComponentLink PrintGridSettings(dynamic grdControl = null)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            if (grdControl is null)
            {
                link.Component = gridControl1;
            }
            else
            {
                link.Component = grdControl;
            }
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("Листа на сите документи и плаќања по партнер : {0}  до: {1}", datumOd.DateTime.ToString("dd.MM.yyyy"), DatumDo.DateTime.ToString("dd.MM.yyyy"));
            string rightColumn = "Датум: " + DateTime.Now.ToString("dd.MM.yyyy");

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            phf.Footer.Content.Clear();

            var FmiddleColumn = NazivNaFirma;
            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;

            return link;
        }

        string sumaText;
        public void presmetaj()
        {
            string filter = string.Empty;
            if (!txtSearchText.IsTextEmpty())
            {
                filter = " (TipNaRed = 2 OR Naziv LIKE '*" + txtSearchText.Text + "*')";
                this.bSSRDataSet.SaldoPoDokument.DefaultView.RowFilter = filter;
                this.saldoPoDokumentBindingSource.Filter = filter;
            }


            var items = this.bSSRDataSet.SaldoPoDokument.ToList().Where(c => c.TipNaRed == 3 && c.Naziv.Contains(txtSearchText.Text) && c.SALDO_SVE < 0).ToList().Select(x => new
            {
                VkupnoDolzi = Tools.PrazenStringToDecimal_dec(x.VkupnoDolzi),
                VkupnoPlateno = Tools.PrazenStringToDecimal_dec(x.VkupnoPlateno),
                Saldo = Tools.PrazenStringToDecimal_dec(x.Saldo)
            });

            if (this.bSSRDataSet.SaldoPoDokument.Rows.Count > 0)
            {
                var VkupnoDolzi = items.Sum(x => x.VkupnoDolzi);
                var VkupnoPlateno = items.Sum(x => x.VkupnoPlateno);
                var VkupnoSaldo = items.Sum(x => x.Saldo);

                sumaText = $"Вкупен Износ од документи: {VkupnoDolzi:N2} {Environment.NewLine}Вкупен Износ од Изводи: {VkupnoPlateno:N2} {Environment.NewLine}Не наплатено: {VkupnoSaldo:N2} ";
                txtInfo.Text = sumaText;
            }
        }

        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.saldoPoDokumentBindingSource.Filter = string.Empty;
            this.saldoPoDokumentTableAdapter.Fill(this.bSSRDataSet.SaldoPoDokument, true, DatumDo.SelectionStart);
            if (!txtSearchText.IsTextEmpty())
            {
                this.bSSRDataSet.SaldoPoDokument.Where(x => x.Naziv.Contains(txtSearchText.Text));
            }
            presmetaj();
            Cursor.Current = Cursors.Default;
        }

        private void btnPotvrdi3_Click(object sender, EventArgs e)
        {
            this.saldoPoDokumentBindingSource.Filter = string.Empty;
            var inputBox = InputBox.ShowMailOrPrint("Картичка на партнери", "Одберете начин на испраќање", false);

            var DefaulOptionSelected = inputBox.DefaulOptionSelected;

            var listaSoPartneri = Tools.GetListaSoPartneri().Rows.Cast<DataRow>().ToList().Select(x => new
            {
                ID = x["ID"].ToString(),
                Sifra = x["Sifra"].ToString(),
                Naziv = x["Naziv"].ToString()
            }).ToList();

            if (listaSoPartneri.Any())
            {
                var display = new frmShowTop();
                display.Width = 800;
                display.Height = 600;
                display.Text = "Испрати картичка на партнери по маил ПДФ";
                var txtNacin = string.Empty;

                if (DefaulOptionSelected)
                {
                    txtNacin = "Испрати картичка на селектираните партнери по маил";
                }
                else
                {
                    txtNacin = "Печати картичка на селектираните партнери директно на принтер";
                }

                var ispratiKartickaNaPartneri = new Button { Text = txtNacin, TextAlign = ContentAlignment.MiddleLeft };
                ispratiKartickaNaPartneri.Click += SendPartnerCard_Click;
                ispratiKartickaNaPartneri.Height = 50;
                ispratiKartickaNaPartneri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                ispratiKartickaNaPartneri.Image = global::MReport.Properties.Resources._001_12;
                ispratiKartickaNaPartneri.Dock = DockStyle.Bottom;
                ispratiKartickaNaPartneri.Tag = DefaulOptionSelected.ToString();
                display.AddControl(ispratiKartickaNaPartneri);

                var pecatiKartickaNaPartner = new Button { Text = "Печати картичка за селектираниот (еден) партнер" };
                pecatiKartickaNaPartner.Click += PecatiKartickaNaPartner_Click; ;
                pecatiKartickaNaPartner.Height = 50;
                pecatiKartickaNaPartner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                pecatiKartickaNaPartner.Image = global::MReport.Properties.Resources.pecati;
                pecatiKartickaNaPartner.Dock = DockStyle.Bottom;
                pecatiKartickaNaPartner.Tag = false;
                pecatiKartickaNaPartner.BackColor = Color.Beige;
                display.AddControl(pecatiKartickaNaPartner);

                var grid = new grdBase();
                grid.SetirajStikliranje(0);

                grid.Name = "PratiKartickaNaPartner";
                grid.AllowUserToOrderColumns = false;
                grid.DataSource = listaSoPartneri;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.Dock = DockStyle.Fill;
                grid.ScrollBars = ScrollBars.Both;
                display.Controls.Add(grid);
                grid.BringToFront();
                grid.StiklirajGISite();
                display.ShowDialog();
            }

            //.ForEach(x => PratiKartickaNaPartner(x, DefaulOptionSelected));




        }

        private void PecatiKartickaNaPartner_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mainform = button.Parent as Form;
            var dataGrid = mainform.Controls.OfType<grdBase>().FirstOrDefault() as grdBase;
            dataGrid.Columns["ID"].DataPropertyName = string.Empty;
            dataGrid.Columns["ID"].ValueType = typeof(string);
            dataGrid.Columns["ID"].ReadOnly = false;
            dataGrid.Columns["ID"].Visible = false;
            dataGrid.Columns["ID"].HeaderText = "Uspesno";

            var item = dataGrid.CurrentRow.Cells["Sifra"].Value.ToString();
            try
            {
                PratiKartickaNaPartner(item, false, true);
            }
            catch (Exception ex)
            {

            }

        }

        private void SendPartnerCard_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mainform = button.Parent as Form;
            var dataGrid = mainform.Controls.OfType<grdBase>().FirstOrDefault() as grdBase;
            dataGrid.Columns["ID"].DataPropertyName = string.Empty;
            dataGrid.Columns["ID"].ValueType = typeof(string);
            dataGrid.Columns["ID"].ReadOnly = false;
            dataGrid.Columns["ID"].Visible = false;
            dataGrid.Columns["ID"].HeaderText = "Uspesno";

            foreach (DataGridViewRow item in dataGrid.Rows)
            {

                try
                {
                    item.Cells["ID"].Value = 0;
                    item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    bool stiklirano = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (!stiklirano) continue;
                    PratiKartickaNaPartner(item.Cells["Sifra"].Value.ToString(), button.Tag.ToString().ToLower().Contains("true"));
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void PratiKartickaNaPartner(string partnerInput, bool DefaulOptionSelected = true, bool printOne = false)
        {
            string partner = partnerInput;
            var linkPrint = PrintGridSettings();
            if (!string.IsNullOrEmpty(partner))
            {
                var partherInfo = Tools.NajdiInfoZaSifraPartner(partner);

                if (partherInfo != null)
                {
                    this.saldoPoDokumentTableAdapter.FillBy(this.bSSRDataSet.SaldoPoDokument, partner,
                  DatumDo.SelectionStart);
                    this.gridView1.ActiveFilterString = $"[Sifra] = '{partner}'";


                    string fileName = partnerInput + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString() + "_" + Guid.NewGuid().ToString() + ".pdf";
                    dynamic grid = Controls.Find("gridControl1", true).FirstOrDefault();
                    dynamic datumOdSelected = Controls.Find("datumOd", true).FirstOrDefault();
                    dynamic DatumDoSelected = Controls.Find("DatumDo", true).FirstOrDefault();

                    this.gridView1.Columns["TipNaDostava"].Visible = true;
                    this.gridView1.Columns["Zabeleski"].Visible = true;

                    this.gridView1.Appearance.Row.Font = new System.Drawing.Font(this.gridView1.Appearance.Row.Font.FontFamily, 8);

                    this.gridView1.Columns["TipNaDostava"].Visible = false;
                    this.gridView1.Columns["Zabeleski"].Visible = false;

                    if (!string.IsNullOrEmpty(partherInfo["Email"].ToString()) && !printOne)
                    {

                        var emailList = partherInfo["Email"].ToString().Split(';');
                        if (DefaulOptionSelected)
                        {
                            if (emailList.Any())
                            {
                                linkPrint.ExportToPdf(Tools.setExportPath(fileName, true));
                                string subject = "Картичка на партнер - " + DateTime.Now.ToString();
                                var MailText = $@"
Почитувани,

Во прилог во испраќаме аналитичка картица за Вашиот стан заклучно со ден {DatumDoSelected.DateTime.ToShortDateString()}

Со почит,
{Environment.NewLine + NazivNaFirma}";

                                Tools.SendMailDefault(Tools.setExportPath(fileName), subject, MailText, false, Mailto: string.Join(",", emailList));
                            }
                            else
                            {

                               // linkPrint.Print();
                            }
                        }
                        else
                        {
                            linkPrint.ShowPreview();
                        }

                    }
                    else
                    {
                        linkPrint.ShowPreview();
                    }
                }
            }
            this.gridView1.Columns["Zabeleski"].Visible = true;
            this.gridView1.ClearColumnsFilter();
        }

        private void btnPotvrdi4_Click(object sender, EventArgs e)
        {
            this.saldoPoDokumentBindingSource.Filter = string.Empty;
            this.saldoPoDokumentTableAdapter.Fill(this.bSSRDataSet.SaldoPoDokument, true, DatumDo.SelectionStart);
            var dolznici = this.bSSRDataSet.SaldoPoDokument;

            var partneriDolznici = dolznici.Where(x => !x.Naziv.Contains("Документ") && x.SALDO_SVE < 0).ToList();


            var partneriDolzniciMail = partneriDolznici.Where(c => c.TipNaDostava == "Електронска форма (маил)");

            var partneriDolzniciMailIHartija = partneriDolznici.Where(c => c.TipNaDostava == "Хартиена и Електронска форма");

            var partneriDolzniciHartija = partneriDolznici.Where(c => c.TipNaDostava == "Хартиена форма");

            if (partneriDolznici.Count() > 0)
            {
                var listNaMail = partneriDolzniciMail.ToList().Select(c => new
                {
                    c.Sifra,
                    c.Naziv,
                    c.TipNaDostava,
                    c.Saldo,
                    c.ID,
                }).ToList().OrderBy(c => c.Sifra);

                var listNaMailIhartija = partneriDolzniciMailIHartija.ToList().Select(c => new
                {
                    c.Sifra,
                    c.Naziv,
                    c.TipNaDostava,
                    c.Saldo,
                    c.ID
                }).ToList().OrderBy(c => c.Sifra);

                var listNaHartijaSamo = partneriDolzniciHartija.ToList().Select(c => new
                {
                    c.Sifra,
                    c.Naziv,
                    c.TipNaDostava,
                    c.Saldo,
                    c.ID,
                }).ToList().OrderBy(c => c.Sifra);

                var pecatiAll = listNaMail.Union(listNaMailIhartija).Union(listNaHartijaSamo).OrderBy(x => x.Sifra).ToList();

                if (partneriDolzniciMailIHartija.Any())
                {
                    var display = new frmShowTop();
                    display.Width = 800;
                    display.Height = 600;
                    display.Text = "Известување на должници по маил и принт во ПДФ";

                    var button2 = new Button { Text = "Испрати картичка на партнери" };
                    button2.Click += Button_Click;
                    button2.Height = 50;
                    button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    button2.Image = global::MReport.Properties.Resources._001_12;
                    button2.Dock = DockStyle.Bottom;
                    display.AddControl(button2);

                    var button = new Button { Text = "Опомена пред тужба" };
                    button.Click += PratiPoMail_I_PecatiPDF;
                    button.Height = 50;
                    button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    button.Image = global::MReport.Properties.Resources._001_12;
                    button.Dock = DockStyle.Bottom;
                    display.AddControl(button);
                    display.Name = "partneriDolzniciMailIHartija";
                    var grid = new grdBase();
                    grid.SetirajStikliranje(0);

                    grid.Name = "partneriDolzniciMailIHartija";
                    grid.AllowUserToOrderColumns = false;
                    grid.DataSource = pecatiAll;
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    grid.Dock = DockStyle.Fill;
                    grid.ScrollBars = ScrollBars.Both;
                    display.Controls.Add(grid);
                    grid.BringToFront();
                    grid.StiklirajGISite();
                    display.ShowDialog();
                }

            }


        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mainform = button.Parent as Form;
            var dataGrid = mainform.Controls.OfType<grdBase>().FirstOrDefault() as grdBase;
            dataGrid.Columns["ID"].DataPropertyName = string.Empty;
            dataGrid.Columns["ID"].ValueType = typeof(string);
            dataGrid.Columns["ID"].ReadOnly = false;
            dataGrid.Columns["ID"].HeaderText = "Uspesno";
            PratiMailZaDataGrid(dataGrid, "Izvestuvanje_mail", false);

        }

        private void PecatiPDF(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mainform = button.Parent as Form;
            var dataGrid = mainform.Controls.OfType<grdBase>().FirstOrDefault() as grdBase;
            dataGrid.Columns["ID"].DataPropertyName = string.Empty;
            dataGrid.Columns["ID"].ValueType = typeof(string);
            dataGrid.Columns["ID"].ReadOnly = false;
            dataGrid.Columns["ID"].HeaderText = "Uspesno";
            PecatiZaDataGrid(dataGrid, "Izvestuvanje_Hartija");
            dataGrid.ContextMenuStrip.Items[2].PerformClick();

        }

        private void PratiPoMail(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mainform = button.Parent as Form;
            var dataGrid = mainform.Controls.OfType<grdBase>().FirstOrDefault() as grdBase;
            dataGrid.Columns["ID"].DataPropertyName = string.Empty;
            dataGrid.Columns["ID"].ValueType = typeof(string);
            dataGrid.Columns["ID"].ReadOnly = false;
            dataGrid.Columns["ID"].HeaderText = "Uspesno";

            PratiMailZaDataGrid(dataGrid, "Izvestuvanje_Mail");
            dataGrid.ContextMenuStrip.Items[2].PerformClick();
        }

        private void PratiMailZaDataGrid(grdBase dataGrid, string folder, bool opomena = true)
        {

            foreach (DataGridViewRow item in dataGrid.Rows)
            {

                try
                {
                    bool sendMail = false;
                    item.Cells["ID"].Value = 0;
                    item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    bool stiklirano = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (!stiklirano) continue;

                    var Iznos = Convert.ToDecimal(item.Cells["Saldo"].Value.ToString());
                    string partner = item.Cells["Sifra"].Value.ToString();
                    string fileName = ExportPDF_Partner(partner, DatumDo.SelectionStart, folder);
                    string listaNaItems = $"{Environment.NewLine}";



                    string text = string.Empty;
                    string subjectText = string.Empty;

                    if (opomena)
                    {
                        subjectText = "ОПОМЕНА ПРЕД ПРИСИЛНА НАПЛАТА";
                        text = $@"
                        Почитувани,

                        Согласно нашата последна евиденција од датум {DatumDo.SelectionStart:dd.MM.yyyyy} имате заостанат долг во вкупен износ од: {(Iznos * -1):N2} денари.

                        Подетални информации може да најдете во картичката која ви ја доставуваме во прилог.
                        Ве молиме долгот да го подмирите во рок од осум дена како би се избегнале дополнителни трошоци за присилна наплата.

                    
                        Доколку овој долг го имате подмирено по датумот кој е наведен погоре,се извинуваме за известувањето и Ви благодариме за уплатата.

                        Со почит,
                        {Environment.NewLine + NazivNaFirma}";

                    }

                    else
                    {
                        subjectText = "Аналитичка Картичка";
                        text = $@"
                        Почитувани,

                        Во прилог Ви испраќаме картица со издадени фактури од наша страна и Ваши извршени уплати за Ваш увид и евиденција.
                    
                        Со почит,
                        {Environment.NewLine + NazivNaFirma}";

                    }

                    var parthnerEmail = Tools.NajdiInfoZaSifraPartner(partner);

                    if (parthnerEmail != null && !string.IsNullOrEmpty(parthnerEmail["Email"].ToString()))
                    {
                        sendMail = false;
                        var emailList = parthnerEmail["Email"].ToString().Split(';');


                        sendMail = Tools.SendMailDefault(fileName,
                            subjectText,
                            text, false, Mailto: string.Join(",", emailList));
                    }

                    if (sendMail)
                    {

                        item.Cells["ID"].Value = 1;
                        item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.LightGreen };

                    }
                    else
                    {
                        item.Cells["ID"].Value = 0;
                        item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    }
                }
                catch (Exception ex)
                {
                    item.Cells["ID"].Value = 0;
                    item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    Tools.LogExceptionMessageWithScreenShoot(ex, ex.Message);
                }


            }
        }

        private void PecatiZaDataGrid(grdBase dataGrid, string folder)
        {

            foreach (DataGridViewRow item in dataGrid.Rows)
            {

                try
                {
                    bool pecati = true;
                    item.Cells["ID"].Value = 0;
                    item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    bool stiklirano = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (!stiklirano) continue;
                    string partner = item.Cells["Sifra"].Value.ToString();
                    ExportPDF_Partner(partner, DatumDo.SelectionStart, folder, true);
                    if (pecati)
                    {

                        item.Cells["ID"].Value = 1;
                        item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.LightGreen };
                    }
                    else
                    {
                        item.Cells["ID"].Value = 0;
                        item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    }
                }
                catch (Exception ex)
                {
                    item.Cells["ID"].Value = 0;
                    item.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                    Tools.LogExceptionMessageWithScreenShoot(ex, ex.Message);
                }


            }
        }


        private string ExportPDF_Partner(string partner, DateTime datum, string folder = "tmp", bool writeText = false)
        {
            GridControl printGrid = new GridControl();
            var gridView = new GridView(printGrid)
            {
                Name = "gridView"
            };
            printGrid.MainView = gridView;
            printGrid.BindingContext = new System.Windows.Forms.BindingContext();
            PrintableComponentLink link = PrintGridSettings(printGrid);
            if (writeText)
            {
                link.RtfReportFooter = MailText;
            }
            printGrid.DataSource = Tools.SaldoPoDokumentPoPartner(partner, datum);
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

            gridView.Columns["ID"].Visible = false;
            gridView.Columns["TipNaDostava"].Visible = false;
            gridView.Columns["SALDO_Dolzi"].Visible = false;
            gridView.Columns["SALDO_Plateno"].Visible = false;
            gridView.Columns["TipNaRed"].Visible = false;
            gridView.Columns["Zabeleski"].Visible = false;
            gridView.Columns["SALDO_SVE"].Visible = false;
            gridView.Columns["Sifra"].Caption = "Кат-Стан / Партнер";
            gridView.Columns["Sifra"].MaxWidth = 120;

            gridView.Columns["Sifra"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView.Columns["Naziv"].Caption = "Назив";
            gridView.Columns["Naziv"].MinWidth = 250;
            gridView.Columns["Naziv"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
            gridView.Columns["VkupnoDolzi"].Caption = "Вкупно должи";
            gridView.Columns["VkupnoDolzi"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            gridView.Columns["VkupnoPlateno"].Caption = "Вкупно платено";
            gridView.Columns["VkupnoPlateno"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            gridView.Columns["Saldo"].Caption = "Салдо";
            gridView.Columns["Saldo"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            if (!Directory.Exists($"C:\\PrintFiles\\{folder}\\")) Directory.CreateDirectory($"C:\\PrintFiles\\{folder}\\");
            string fileName = $@"C:\PrintFiles\{folder}\{partner}_{DateTime.Now:dd.MM.yyyy}.pdf";
            if (File.Exists(fileName)) File.Delete(fileName);
            link.ExportToPdf(fileName);
            return fileName;
        }

        private void PratiPoMail_I_PecatiPDF(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mainform = button.Parent as Form;
            var dataGrid = mainform.Controls.OfType<grdBase>().FirstOrDefault() as grdBase;
            dataGrid.Columns["ID"].DataPropertyName = string.Empty;
            dataGrid.Columns["ID"].ValueType = typeof(string);
            dataGrid.Columns["ID"].ReadOnly = false;
            dataGrid.Columns["ID"].HeaderText = "Uspesno";
            PratiMailZaDataGrid(dataGrid, "Izvestuvanje_mail", true);

            PecatiZaDataGrid(dataGrid, "Izvestuvanje_Hartija");
            dataGrid.ContextMenuStrip.Items[2].PerformClick();
        }

        private void frmListaNaDolznici_Load(object sender, EventArgs e)
        {

            var showPartnerMenu = new ToolStripMenuItem(Tools.PrevediPoraka("Отвори партнер инфо"));
            showPartnerMenu.Click += ShowPartnerMenu_Click;

            var otvoriDokument = new ToolStripMenuItem(Tools.PrevediPoraka("Отвори документ"));
            otvoriDokument.Click += OtvoriDokument_Click;

            var setNotesMenuItem = new ToolStripMenuItem(Tools.PrevediPoraka("Запиши забелешки"));
            setNotesMenuItem.Click += setNotesMenuItem_click;

            var openNotes = new ToolStripMenuItem(Tools.PrevediPoraka("Прегледај забелешки"));
            openNotes.Click += OpenNotes_Click; ;

            var delNotesMenuItem = new ToolStripMenuItem(Tools.PrevediPoraka("Избриши забелешки"));
            delNotesMenuItem.Click += DelNotesMenuItem_Click;

            var pratiKartiCka = new ToolStripMenuItem(Tools.PrevediPoraka("Испрати картичка"));
            pratiKartiCka.Click += PratiKartiCka_Click;

            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();

            menuItems.Add(new ToolStripMenuItem("-"));
            menuItems.Add(showPartnerMenu);
            menuItems.Add(otvoriDokument);
            menuItems.Add(new ToolStripMenuItem("-"));
            menuItems.Add(setNotesMenuItem);
            menuItems.Add(openNotes);
            menuItems.Add(delNotesMenuItem);
            menuItems.Add(new ToolStripMenuItem("-"));
            menuItems.Add(pratiKartiCka);

            this.gridControl1.AddItemsToMenu(menuItems);

            DisableEmailButton();
            MailText = $@"
             Почитувани,

             Согласно нашата последна евиденција од датум имате заостанат долг.
             Доколку овој долг го имате подмирено по датумот кој е наведен погоре,се извинуваме за известувањето и Ви благодариме за уплатата, а во спротивно ве замолуваме истиот да биде платен во најкус можен рок по добивање на ова известување.

             Со почит,";

            var info = Tools.NajdiInfoZaFirma(1);
            NazivNaFirma = info.Table.Rows[0]["ImeNaFirma"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Adresa"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Grad"].ToString();


        }

        private void PratiKartiCka_Click(object sender, EventArgs e)
        {
            var sifra = GetCurentValueForColumnName("Sifra");

            PratiKartickaNaPartner(sifra, true);

            MessageBox.Show($"Успешно пратена Картичка на партнер до {sifra}", "Картичка на партнер", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void OpenNotes_Click(object sender, EventArgs e)
        {
            var sifra = GetCurentValueForColumnName("Naziv").Substring(0, 10);

            var doc = Tools.NajdiInfoZaDokumentBrojKod(sifra).Rows[0]["Notes"].ToString();

            MessageBox.Show(doc, "Забелешки ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void OtvoriDokument_Click(object sender, EventArgs e)
        {

            var sifra = GetCurentValueForColumnName("Naziv").Substring(0, 10);

            var doc = Tools.NajdiInfoZaDokumentBrojKod(sifra).Rows[0]["ID"].ToString();

            if (doc != null)
            {
                System.Reflection.Assembly asm = System.Reflection.Assembly.Load("MMaterijalno");
                if (asm != null)
                {
                    var t = asm.GetType("MMaterijalno.Forms.frmObrabotkaNaInterniDokumenti");
                    var frm = (frmBigEdit)Activator.CreateInstance(t, int.Parse(doc));
                    frm.ShowDialog();
                }
            }


        }

        private void DelNotesMenuItem_Click(object sender, EventArgs e)
        {

            var sifra = GetCurentValueForColumnName("Naziv").Substring(0, 10);

            var doc = Tools.NajdiInfoZaDokumentBrojKod(sifra).Rows[0]["ID"].ToString();

            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka($"Дали сте сигурни дека сакате да ги избришете забелешките за : {sifra}"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                UpdateNotesZaDokument(doc, null);
            }

        }

        private void setNotesMenuItem_click(object sender, EventArgs e)
        {

            var sifra = GetCurentValueForColumnName("Naziv").Substring(0, 10);

            var doc = Tools.NajdiInfoZaDokumentBrojKod(sifra).Rows[0]["ID"].ToString();

            var inputresult = InputBox.Show("Забелешки", "Внесете забелешка за документот", "").Text;

            if (!string.IsNullOrEmpty(inputresult))
            {
                UpdateNotesZaDokument(doc, inputresult);
            }
        }

        private void btnPotvrdi5_Click(object sender, EventArgs e)
        {
            presmetajListaNaDolznici();
        }

        public void presmetajListaNaDolznici()
        {
            string filter = string.Empty;
            this.saldoPoDokumentTableAdapter.Fill(this.bSSRDataSet.SaldoPoDokument, true, DatumDo.SelectionStart);
            if (!txtSearchText.IsTextEmpty())
            {
                this.bSSRDataSet.SaldoPoDokument.Where(x => x.Naziv.Contains(txtSearchText.Text));
            }

            if (!txtSearchText.IsTextEmpty())
            {
                filter = " ( Saldo like '-*' AND TipNaRed = 3 AND Naziv LIKE '*" + txtSearchText.Text + "*')";
                this.bSSRDataSet.SaldoPoDokument.DefaultView.RowFilter = filter;
                this.saldoPoDokumentBindingSource.Filter = filter;
            }


            var items = this.bSSRDataSet.SaldoPoDokument.ToList().Where(c => c.TipNaRed == 3 && c.Naziv.Contains(txtSearchText.Text) && Convert.ToDecimal(c.Saldo) < 0).ToList().Select(x => new
            {
                VkupnoDolzi = Tools.PrazenStringToDecimal_dec(x.VkupnoDolzi),
                VkupnoPlateno = Tools.PrazenStringToDecimal_dec(x.VkupnoPlateno),
                Saldo = Tools.PrazenStringToDecimal_dec(x.Saldo)
            });

            if (this.bSSRDataSet.SaldoPoDokument.Rows.Count > 0)
            {
                var VkupnoDolzi = items.Sum(x => x.VkupnoDolzi);
                var VkupnoPlateno = items.Sum(x => x.VkupnoPlateno);
                var VkupnoSaldo = items.Sum(x => x.Saldo);

                sumaText = $"Вкупен Износ од документи: {VkupnoDolzi:N2} {Environment.NewLine}Вкупен Износ од Изводи: {VkupnoPlateno:N2} {Environment.NewLine}Не наплатено: {VkupnoSaldo:N2} ";
                txtInfo.Text = sumaText;
            }
        }

        private void txtInfo_Click(object sender, EventArgs e)
        {
            //var result = string.Empty;
            //object[] parameters = new object[] { "Hello, World!" };
            //dynamic asm = AssemblyHelper.GetAssembly("MMaterijalno").
            //    CreateInstance("MMaterijalno.Forms.KulaB.frmPotpisiIPrati", true, System.Reflection.BindingFlags.CreateInstance,
            //    null, parameters, null,null);

            //asm.ShowDialog();
            //result = asm.MailTextResult;
            //MessageBox.Show(result);

        }
    }
}

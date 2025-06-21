using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using BSS;
using BssBase;
using MMaterijalno.Forms.KulaB;
using MReport.Forms;
using DevExpress.Pdf.Native;
using DevExpress.Pdf;
using DevExpress.DocumentServices.ServiceModel.DataContracts;

namespace MMaterijalno.Forms
{
    public partial class frmInterniDokumenti : Form
    {
        public frmInterniDokumenti()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            dtShowDataOD.Value = settings.DateTimeOd;
            dtShowDataDO.Value = settings.DateTimeDo;

            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                viewDokumentiTableAdapter.Fill(materijalnoDataSet.viewDokumenti, dtShowDataOD.Value, dtShowDataDO.Value);
            if (File.Exists(Application.StartupPath + @"\ElektronskoPracanje\serverNames.cfg"))
            {
                cmbServer.LoadItemsFromFile(Application.StartupPath + @"\ElektronskoPracanje\serverNames.cfg");
            } else
            {
                cmbServer.Visible = false;
                label1.Visible = false;

            }

            if((settings.TipNaPrograma == "10KulaB"))
            {
                btnOtvori2.Visible = true;
            }
        }

        private void bтнОтвори_Click_1(object sender, EventArgs e)
        {
            if (!Equals(null, viewDokumentiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["ID"].ToString());
                frmObrabotkaNaInterniDokumenti dokumenti = new frmObrabotkaNaInterniDokumenti(id);
                int knizeno = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["Knizeno"].ToString());
                if (knizeno == 1)
                {
                    dokumenti.SetFormReadOnly();
                }
                dokumenti.ShowDialog();
                viewDokumentiTableAdapter.Fill(materijalnoDataSet.viewDokumenti, dtShowDataOD.Value, dtShowDataDO.Value);
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
            frmObrabotkaNaInterniDokumenti Dokumenti = new frmObrabotkaNaInterniDokumenti();
            Dokumenti.ShowDialog();
            viewDokumentiTableAdapter.Fill(materijalnoDataSet.viewDokumenti, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        public void PecatiKulaB(int dokumentiID, bool prikaziForma = true, bool print = false, string partnerSifra = "")
        {

            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            viewDokumentiTableAdapter.FillBy(materijalnoDataSet.viewDokumenti, dokumentiID);
            viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentiID);
            

            try
            {
                if (string.IsNullOrEmpty(partnerSifra))
                {
                    partnerSifra = ((DataRowView)viewDokumentiBindingSource.Current)["SifraPartner"].ToString();
                }

                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipNadokument"].ToString();
                string TipNaDokumentID = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();

                if (TipNaDokumentID == "1" && (settings.TipNaPrograma == "10KulaB"))
                {
                    KulaBPrint(partnerSifra, prikaziForma,print, dokumentiID);
                    return;
                }

                if (TipNaDokumentID == "2" && (settings.TipNaPrograma == "10KulaB"))
                {
                    KulaBPrintHvac(partnerSifra, prikaziForma, print, dokumentiID);
                    return;
                }

                if (TipNaDokumentID == "3" || TipNaDokumentID == "9" && (settings.TipNaPrograma == "10KulaB"))
                {
                    PrintDokument(partnerSifra, prikaziForma, print, dokumentiID);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);
            }

        }
        public void Pecati(int dokumentiID, bool prikaziForma = true, string partnerSifra = "")
        {


            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            viewDokumentiTableAdapter.FillBy(materijalnoDataSet.viewDokumenti, dokumentiID);
            viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentiID);
            
            if (string.IsNullOrEmpty(partnerSifra))
            {
                partnerSifra = ((DataRowView)viewDokumentiBindingSource.Current)["SifraPartner"].ToString();
            }

            try
            {
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipNadokument"].ToString();
                string TipNaDokumentID = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();

                if (TipNaDokumentID == "1" && (settings.TipNaPrograma == "10KulaB"))
                {
                    KulaBPrint(partnerSifra, prikaziForma, true, dokumentiID);
                    return;
                }

                if (TipNaDokumentID == "2" && (settings.TipNaPrograma == "10KulaB"))
                {
                    KulaBPrintHvac(partnerSifra, prikaziForma, true, dokumentiID);
                    return;
                }

                if (TipNaDokumentID == "3" || TipNaDokumentID == "9" && (settings.TipNaPrograma == "10KulaB"))
                {
                    PrintDokument(partnerSifra, prikaziForma, true, dokumentiID);
                    return;
                }

                if (TipNaDokument == "Фактура" && (settings.TipNaPrograma == "987"))
                {
                    using (var report = new Reporti.SmetkaFaktura())
                    {
                        var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                        report.SetDataSource(materijalnoDataSet);
                        string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                        string Adresa = info["Adresa"].ToString();
                        string Telefon = info["Telefoni"].ToString();
                        string user = tmpConfigs.LogiranUserFullName;

                        if (string.IsNullOrEmpty(Adresa))
                        {
                            report.SetParameterValue("AdresaPartner", " ");
                        }
                        else
                        {
                            report.SetParameterValue("AdresaPartner", Adresa);
                        }

                        if (string.IsNullOrEmpty(partner))
                        {
                            report.SetParameterValue("PartnerObjekt", " ");
                        }
                        else
                        {
                            report.SetParameterValue("PartnerObjekt", partner);
                        }


                        if (string.IsNullOrEmpty(Telefon))
                        {
                            report.SetParameterValue("Telefon", " ");
                        }
                        else
                        {
                            report.SetParameterValue("Telefon", Telefon);
                        }

                        report.SetParameterValue("User", user);

                        PrintPreview prev = new PrintPreview();
                        prev.ReportPreview.ReportSource = report;

                        prev.ShowDialog();
                        report.Dispose();
                        return;
                    }
                }

                if (TipNaDokument == "Реверс" || TipNaDokument == "Нарачка/Испратница" || TipNaDokument == "Повратница од партнер" || TipNaDokument == "Фактурирани Испратници" && settings.TipNaPrograma == "987")
                {
                    using (var report = new Reporti.Revers())
                    {
                        var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);

                        report.SetDataSource(materijalnoDataSet);
                        string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                        string Adresa = info["Adresa"].ToString();
                        string Telefon = info["Telefoni"].ToString();

                        if (string.IsNullOrEmpty(Adresa))
                        {
                            report.SetParameterValue("AdresaPartner", " ");
                        }
                        else
                        {
                            report.SetParameterValue("AdresaPartner", Adresa);
                        }

                        if (string.IsNullOrEmpty(partner))
                        {
                            report.SetParameterValue("PartnerObjekt", " ");
                        }
                        else
                        {
                            report.SetParameterValue("PartnerObjekt", partner);
                        }


                        if (string.IsNullOrEmpty(Telefon))
                        {
                            report.SetParameterValue("Telefon", " ");
                        }
                        else
                        {
                            report.SetParameterValue("Telefon", Telefon);
                        }



                        PrintPreview prev = new PrintPreview();
                        prev.ReportPreview.ReportSource = report;

                        prev.ShowDialog();
                        report.Dispose();
                    }
                }
                else
                {
                    if (TipNaDokument == "Сметка" && settings.TipNaPrograma == "987")
                    {
                        using (var report = new Reporti.Smetka())
                        {
                            var info = Tools.NajdiInfoZaSifraPartner(partnerSifra);

                            report.SetDataSource(materijalnoDataSet);
                            string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                            string Adresa = info["Adresa"].ToString();
                            string Telefon = info["Telefoni"].ToString();

                            if (string.IsNullOrEmpty(Adresa))
                            {
                                report.SetParameterValue("AdresaPartner", " ");
                            }
                            else
                            {
                                report.SetParameterValue("AdresaPartner", Adresa);
                            }

                            if (string.IsNullOrEmpty(partner))
                            {
                                report.SetParameterValue("PartnerObjekt", " ");
                            }
                            else
                            {
                                report.SetParameterValue("PartnerObjekt", partner);
                            }


                            if (string.IsNullOrEmpty(Telefon))
                            {
                                report.SetParameterValue("Telefon", " ");
                            }
                            else
                            {
                                report.SetParameterValue("Telefon", Telefon);
                            }

                            if (prikaziForma)
                            {
                                PrintPreview prev = new PrintPreview();
                                prev.ReportPreview.ReportSource = report;

                                prev.ShowDialog();
                            }
                            else
                            {
                                report.PrintOptions.PrinterName = settings.PrinterPathDefault;
                                report.PrintToPrinter(1, false, 0, 0);
                            }


                            report.Dispose();
                        }
                    }
                    else
                    {
                        using (var report = new Reporti.DefaultDokument())
                        {
                            report.SetDataSource(materijalnoDataSet);
                            string partner = string.Format("{0} / {1}", ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"], ((DataRowView)viewDokumentiBindingSource.Current)["ObejektDO"]);

                            report.SetParameterValue("PartnerObjekt", partner);
                            PrintPreview prev = new PrintPreview();
                            prev.ReportPreview.ReportSource = report;

                            prev.ShowDialog();
                            report.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);
            }
        }

        private void PrintDokument(string partnerSifra, bool prikaziForma, bool print, int dokumentId)
        {
            using (var report = new Reporti.Dokument())
            {
                var infoZaPartner = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                string tipNaDostava = infoZaPartner["TipNaDostava"].ToString();
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();
                string imeNaFaktura = "ФАКТУРА";
                
                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                DateTime date = Convert.ToDateTime(datum);
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string token = ((DataRowView)viewDokumentiBindingSource.Current)["UniqueIdPlacanje"].ToString();
                string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                string Adresa = infoZaPartner["Adresa"].ToString();
                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }


                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", imeNaFaktura);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("ZaostanatDolg", zaostanatDolg(partnerSifra));
                report.SetParameterValue("TekovenFond", 0);
                report.SetParameterValue("RezervenFond", 0);
                report.SetParameterValue("token", token);
                report.SetParameterValue("DatumNaValuta", datumValuta);
                report.SetParameterValue("UrlToken", $"https://payment.zgrada.sk");

                if (prikaziForma)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}_{GetTipNaDostava(tipNaDostava)}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);

                    if (print)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }


        private void KulaBPrint(string partnerSifra, bool prikaziForma, bool print, int dokumentId)
        {
            using (var report = new Reporti.KulaB())
            {
                var infoZaPartner = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                string tipNaDostava = infoZaPartner["TipNaDostava"].ToString();
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();
                string imeNaFaktura = "ФАКТУРА ЗА ОДРЖУВАЊЕ";
                if (TipNaDokument == "2")
                {
                    imeNaFaktura = "ФАКТУРА ЗА ХВАЦ";
                }
                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                DateTime date = Convert.ToDateTime(datum);
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string token = ((DataRowView)viewDokumentiBindingSource.Current)["UniqueIdPlacanje"].ToString();
                string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                string Adresa = infoZaPartner["Adresa"].ToString();
                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }


                var invoiceDate = Convert.ToDateTime(datumPeriod);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", imeNaFaktura);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("ZaostanatDolg", zaostanatDolg(partnerSifra));
                report.SetParameterValue("TekovenFond", 0);
                string fond = Tools.TekovenFond().Rows[0]["TekovenFond"].ToString();
                report.SetParameterValue("RezervenFond", fond);
                report.SetParameterValue("token", token);
                report.SetParameterValue("DatumNaValuta", datumValuta);
                report.SetParameterValue("UrlToken", $"https://payment.zgrada.sk");
                
                if (prikaziForma)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}_{GetTipNaDostava(tipNaDostava)}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);

                    if (print)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                }
                report.Dispose();
                return;
            }
        }

        private void KulaBPrintHvac(string partnerSifra, bool prikaziForma, bool print, int dokumentiID)
        {
            int godina = Convert.ToDateTime(((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString()).Year;

            general_data_mesecTableAdapter.Fill(materijalnoDataSet.General_data_mesec, godina);
            this.tblDokumentiDetailsInfoHvacTableAdapter.FillBy(this.materijalnoDataSet.tblDokumentiDetailsInfoHvac, dokumentiID);
            this.tblDokumentiDetailsInfoTableAdapter.FillBy(this.materijalnoDataSet.tblDokumentiDetailsInfo, dokumentiID);

            using (var report = new Reporti.KulaBHvac())
            {
                
                var infoZaPartner = Tools.NajdiInfoZaSifraPartner(partnerSifra);
                string tipNaDostava = infoZaPartner["TipNaDostava"].ToString();
                report.SetDataSource(materijalnoDataSet);
                string TipNaDokument = ((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString();
                string imeNaFaktura = "ФАКТУРА ЗА HVAC";
                string datum = ((DataRowView)viewDokumentiBindingSource.Current)["Datum"].ToString();
                DateTime date = Convert.ToDateTime(datum);
                string datumValuta = ((DataRowView)viewDokumentiBindingSource.Current)["DatumNaValuta"].ToString();
                if (string.IsNullOrEmpty(datumValuta)) datumValuta = DateTime.Now.ToString();
                string datumPeriod = ((DataRowView)viewDokumentiBindingSource.Current)["DatumPeriod"].ToString();
                if (string.IsNullOrEmpty(datumPeriod)) datumPeriod = DateTime.Now.ToString();
                string token = ((DataRowView)viewDokumentiBindingSource.Current)["UniqueIdPlacanje"].ToString();
                string partner = ((DataRowView)viewDokumentiBindingSource.Current)["NazivPartner"].ToString();
                string Adresa = infoZaPartner["Adresa"].ToString();
                string brojNaFakturaPrint = ((DataRowView)viewDokumentiBindingSource.Current)["BrojNaDokument"].ToString();
                string user = tmpConfigs.LogiranUserFullName;

                if (string.IsNullOrEmpty(Adresa))
                {
                    report.SetParameterValue("AdresaPartner", " ");
                }
                else
                {
                    report.SetParameterValue("AdresaPartner", Adresa);
                }

                if (string.IsNullOrEmpty(partner))
                {
                    report.SetParameterValue("PartnerObjekt", " ");
                }
                else
                {
                    report.SetParameterValue("PartnerObjekt", partner);
                }

                var invoiceDate = Convert.ToDateTime(datumPeriod);
                general_data_mesecTableAdapter.FillBy(materijalnoDataSet.General_data_mesec,Convert.ToInt32(invoiceDate.Month.ToString()),godina);
                report.SetParameterValue("User", user);
                report.SetParameterValue("mesecInfo", invoiceDate.Month.ToString());
                report.SetParameterValue("Tip", TipNaDokument);
                report.SetParameterValue("ImeNaFaktura", imeNaFaktura);
                report.SetParameterValue("BrojNaFaktura", brojNaFakturaPrint);
                report.SetParameterValue("ZaostanatDolg", zaostanatDolgHVAC(partnerSifra));
                report.SetParameterValue("TekovenFond", 0);
                report.SetParameterValue("RezervenFond", 0);
                report.SetParameterValue("token", token);
                report.SetParameterValue("DatumNaValuta", datumValuta);
                report.SetParameterValue("UrlToken", $"https://payment.zgrada.sk");

                if (prikaziForma)
                {
                    PrintPreview prev = new PrintPreview();
                    prev.ReportPreview.ReportSource = report;

                    prev.ShowDialog();
                }
                else
                {
                    string fileNameForExport = $@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\{partnerSifra}_{brojNaFakturaPrint}_{GetTipNaDostava(tipNaDostava)}.pdf";
                    if (!Directory.Exists($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\"))
                    {
                        Directory.CreateDirectory($@"{BssBase.settings.PrintFolder}\{invoiceDate.Year}\{TipNaDokument}\{invoiceDate.Month}\{partnerSifra.Substring(0, 2)}\");
                    }
                    if (File.Exists(fileNameForExport))
                        File.Delete(fileNameForExport);


                    if (print)
                    {
                        report.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {
                        
                        report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileNameForExport);
                    }
                    // Load a document to sign:
                    
                }
                report.Dispose();
                return;
            }
        }

        private static decimal zaostanatDolg(string sifra)
        {
            var tabelaDolg = Tools.DolgZaPartner(sifra);
            if (tabelaDolg == null) return 0;
            return Convert.ToDecimal(tabelaDolg.Rows[0]["ZaostanatDolg"].ToString());
        }

        private static decimal zaostanatDolgHVAC(string sifra)
        {
            var tabelaDolg = Tools.DolgZaPartnerHvac(sifra);
            if (tabelaDolg == null) return 0;
            return Convert.ToDecimal(tabelaDolg.Rows[0]["ZaostanatDolg"].ToString());
        }

        private string GetTipNaDostava(string tipNaDostava)
        {
            string returnValue = string.Empty;

            switch (tipNaDostava)
            {
                case "0":
                    returnValue = "_PecatenoHartija";
                    break;
                case "1":
                    returnValue = "_SamoMail";
                    break;
                case "2":
                    returnValue = "_PecatenoHartijaIpratenoNaMail";
                    break;

                    default : return "_PecatenoHartija";
            }
            return returnValue;
        }

        private void btnPecati_Click_1(object sender, EventArgs e)
        {
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            if (!Equals(null, viewDokumentiBindingSource.Current))
            {
                int id = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["ID"].ToString());
                string Sifrapartner = ((DataRowView)viewDokumentiBindingSource.Current)["SifraPartner"].ToString();
                Pecati(id, true, Sifrapartner);
            }
            
            viewDokumentiTableAdapter.Fill(materijalnoDataSet.viewDokumenti, dtShowDataOD.Value, dtShowDataDO.Value);
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

            if (e.KeyCode == Keys.F3)
            {
                btnPecati.PerformClick();
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

        private void viewDokumentiGridBig_DataInsert()
        {
            viewDokumentiTableAdapter.Fill(materijalnoDataSet.viewDokumenti, dtShowDataOD.Value, dtShowDataDO.Value);
        }

        private void viewDokumentiGridBig_dataSaveAll()
        {
            viewDokumentiBindingSource.EndEdit();
            viewDokumentiTableAdapter.Update(materijalnoDataSet.viewDokumenti);
        }

        public void PratiDokument()
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniDekaSakateDaGoIspratiteDokumentot"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                if (cmbServer.SelectedIndex == -1) return;



                if (!Equals(null, viewDokumentiBindingSource.Current))
                {

                    int TipNaDokument = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["TipDokumentID"].ToString());
                    string TipNaDokumentStr = ((DataRowView)viewDokumentiBindingSource.Current)["TipNaDokument"].ToString();
                    int id = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["ID"].ToString());
                    string Broj = ((DataRowView)viewDokumentiBindingSource.Current)["Broj"].ToString();

                    tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
                    viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, id);
                    string brojNaPriem = ((DataRowView)viewDokumentiBindingSource.Current)["ID"].ToString();
                    int knizeno = Tools.PrazenStringToInt(((DataRowView)viewDokumentiBindingSource.Current)["Knizeno"].ToString());

                    if (!(materijalnoDataSet.viewDokumenti.Select("ID = " + id.ToString()).Count() > 0))
                    {
                        MessageBox.Show("Документот е празен !!!");
                        return;
                    }

                    if (!(materijalnoDataSet.viewDokumentiStavki.Select("tblDokumentID = " + id.ToString()).Count() > 0))
                    {
                        MessageBox.Show("Документот е празен !!!");
                        return;
                    }


                    if (knizeno == 1)
                    {
                        MessageBox.Show("Документот е веќе книжен !!!");
                        return;
                    }

                    if (TipNaDokument != 3)
                    {
                        MessageBox.Show("Овој тип на документ не се испраќа електронски ");
                        return;
                    }


                    DataSet ds = new DataSet("DokumentiDataset");
                    ds.Tables.Add(materijalnoDataSet.viewDokumenti.Select("ID = " + id.ToString()).CopyToDataTable());
                    ds.Tables[0].TableName = "viewDokumenti";


                    ds.Tables.Add(materijalnoDataSet.viewDokumentiStavki.Select("tblDokumentID = " + id.ToString()).CopyToDataTable());
                    ds.Tables[1].TableName = "viewDokumentiStavki";
                    ds.Relations.Add(new DataRelation("viewDokumenti_viewDokumentiStavki", ds.Tables["viewDokumenti"].Columns["ID"], ds.Tables["viewDokumentiStavki"].Columns["tblDokumentID"]));
                    ds.AcceptChanges();
                    string fileName = @"ElektronskoPracanje\Prateni\" + TipNaDokumentStr + "_" + id.ToString() + " Broj_" + Broj + ".xml";
                    if (File.Exists(fileName))
                        File.Delete(fileName);
                    ds.WriteXml(fileName, XmlWriteMode.WriteSchema);

                    string xml = File.ReadAllText(fileName);
                    Functions.SrvFcuntions s = new Functions.SrvFcuntions();
                    if (s.PratiKomanda(cmbServer.Text, 8100, "docPresnocnica:" + xml, fileName, DateTime.Now))
                    {
                        using (SqlConnection con = new SqlConnection(settings.konekcija))
                        {
                            string sql = "AkcijaVrzDokument";
                            using (SqlCommand com = new SqlCommand(sql, con))
                            {
                                con.Open();
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("@DokumentID", id);
                                com.Parameters.AddWithValue("@PratenOD", settings.ImeNaMojServer);
                                com.Parameters.AddWithValue("@PratenDO", cmbServer.Text);
                                com.Parameters.AddWithValue("@PratenPrimen", 1);
                                com.Parameters.AddWithValue("@TipNaDokumentStr", TipNaDokumentStr);
                                com.Parameters.AddWithValue("@TipNaVnes", 1);
                                com.Parameters.AddWithValue("@DokumentValue", xml);

                                com.CommandType = CommandType.StoredProcedure;
                                com.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        string OldFileName = fileName;
                        fileName = fileName.Replace(@"\Prateni\", @"\Neuspesni\" + @"\" + cmbServer.Text + @"\");
                        FileInfo f = new FileInfo(fileName);
                        if (!f.Directory.Exists)
                        {
                            f.Directory.Create();
                        }

                        if (File.Exists(fileName))
                            File.Delete(fileName);

                        File.Copy(OldFileName, fileName);
                        MessageBox.Show("Документот не е испратен, сочуван за праќање кога конекцијата ќе биде возможна ");
                    }



                }
            }
        }
        private void PratiPoMailPecati()
        {
            frmPotpisiIPrati form = new frmPotpisiIPrati(dtShowDataOD.Value, dtShowDataOD.Value);
            form.ShowDialog();
            
        }
        private void btnOtvori1_Click(object sender, EventArgs e)
        {
            if (settings.TipNaPrograma == "10KulaB") {
                PratiPoMailPecati();
                return;
            }
            PratiDokument();
        }

        private void frmInterniDokumenti_Load(object sender, EventArgs e)
        {
            if (settings.SocketServer == "true")
            {
                btnOtvori1.Visible = true;
            }
            else
            {
                btnOtvori1.Visible = false;
            }

            if (BssBase.settings.EnableWCFSendOfDocuments.ToLower().Contains("true"))
            {
                btnPecati.Visible = true;
                label1.Visible = true;
                cmbServer.Visible = true;
                btnOtvori1.Visible = true;
                buttonPechatiDokumentiDo.Visible = true;
                btnOtvori2.Visible = true;
            }

            if (settings.TipNaPrograma == "987" || settings.TipNaPrograma == "10KulaB")
            {
                btnPecati.Visible = true;
                label1.Visible = false;
                cmbServer.Visible = false;
                btnOtvori1.Visible = true;
                buttonPechatiDokumentiDo.Visible = true;
                btnOtvori2.Visible = true;
            }
            if(settings.TipNaPrograma == "10KulaB")
            {
                btnOtvori1.Visible = true;
                btnOtvori1.Text = "Прати по маил/печати";
            }
            gridView1.ActiveFilter.Clear();

        }

        private void viewDokumentiGridBig_DoubleClick(object sender, EventArgs e)
        {
            bтнОтвори.PerformClick();
        }

        public void PecatiForm(int odDokuement, int doDokument, bool print = true, int dokumentTipZaPrint = 1)
        {
            
            for (int i = odDokuement; i <= doDokument; i++)
            {
                int dokumentID = Tools.NajdiInfoZaDokumentBroj(dokumentTipZaPrint, i);
                if (dokumentID < 0) continue;
                PecatiKulaB(dokumentID, false, print);
            }
            

        }


        private void buttonPechatiDokumentiDo_Click(object sender, EventArgs e)
        {
            viewDokumentiTableAdapter.FillByAll(materijalnoDataSet.viewDokumenti);
            var dokumentTipZaPrintRes = InputBox.ShowPrintFakturaHvac("Внесете тип на фактура 1 - Тековно одржување , 2 HVAC", "").DefaulOptionSelected;
            int dokumentTipZaPrint = 1;
            if (!dokumentTipZaPrintRes)
            {
                dokumentTipZaPrint = 2;
            }
            var rez  = InputBox.ShowPrintExport("Внесете почетен број на документ за принтање", "");
            int odDokuement = Tools.PrazenStringToInt(rez.Text);
            int doDokument = Tools.PrazenStringToInt(InputBox.Show("Внесете последен број на документ за принтање", "").Text);
            
            if (rez.ReturnCode == DialogResult.OK)
            {
                PecatiForm(odDokuement, doDokument, !rez.DefaulOptionSelected, dokumentTipZaPrint);
            }
            toolStripButton1.PerformClick();
        }

        private void btnOtvori2_Click(object sender, EventArgs e)
        {

            if ((settings.TipNaPrograma == "10KulaB"))
            {
                frmGenerirajDokumenti generirajDokumenti = new frmGenerirajDokumenti();
                generirajDokumenti.ShowDialog();
                return;
            }

            int odDokuement = Tools.PrazenStringToInt(InputBox.Show("Внесете почетен број за копирање", "").Text);
            int doDokument = Tools.PrazenStringToInt(InputBox.Show("Внесете последен број за копирање", "").Text);
            string Zabeleska = InputBox.Show("Внесете забелешка за документите ", "").Text;
            BssBase.Roots.frmDatumOdDo frmDatum = new BssBase.Roots.frmDatumOdDo();
            frmDatum.Text = "Одберете датум на документот";
            frmDatum.DatumDO.Visible = false;
            frmDatum.labelDatumDO.Visible = false;
            frmDatum.AcceptButton = null;
            frmDatum.CancelButton = null;
            frmDatum.skraten.Visible = false;
            DateTime datum = DateTime.Now;
            DialogResult rez = frmDatum.ShowDialog();
            if (rez == DialogResult.OK)
            {
                datum = frmDatum.datumOD.Value;
            }

            DialogResult = DialogResult.None;
            rez = DialogResult.None;
            int broj = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + tmpConfigs.SmetkaA4DokumentID);

            for (int i = odDokuement; i <= doDokument; i++)
            {
                int dokumentID = Tools.NajdiInfoZaDokumentBroj(Tools.PrazenStringToInt(tmpConfigs.SmetkaA4DokumentID), i);

                if (dokumentID < 0) continue;
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand("KreirajSmetkiZaNaredenMesec", con))
                    {
                        con.Open();
                        com.Parameters.AddWithValue("@dokumentID", dokumentID);
                        com.Parameters.AddWithValue("@broj", broj);
                        com.Parameters.AddWithValue("@Datum", datum);
                        com.Parameters.AddWithValue("@TipNaDokument", tmpConfigs.SmetkaA4DokumentID);
                        com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                        com.CommandType = CommandType.StoredProcedure;
                        com.ExecuteNonQuery();

                    }


                }

                broj = broj + 1;
            }
            toolStripButton1.PerformClick();
        }

        private void btnPrikaziSporedFiltri_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void btnPrikaziSe_Click(object sender, EventArgs e)
        {
            viewDokumentiTableAdapter.FillByAll(materijalnoDataSet.viewDokumenti);
        }

    }
}
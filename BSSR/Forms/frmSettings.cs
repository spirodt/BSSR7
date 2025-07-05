using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

using BSS;

using BssBase;

using MMaterijalno.Forms;
using MMaterijalno.Forms.KulaB;
using MMaterijalno.Reporti;

using MReport.Forms;
using Newtonsoft.Json;

namespace BSSR.Forms
{


    public partial class frmSettings : frmBaseApp
    {

        public string GlavnaFormConnectionString;
        public int UserId;
        public int UserLevel;
        public string UserFullName;

        private MMaterijalno.frmPriem _priem;
        private frmInterniDokumenti _interni;
        private frmIzvodi _izvodi;
        private MFakturi.frmFaktura _fakturi;

        private MKelner.Forms.frmKelner _kelner;
        private MKelner.Forms.frmKelner _kasa;
        // private MNetCaffe.frmControl _internetKafe;
        private BssBase.Functions.WebApiSync _webApiSync;

        private BackgroundWorker _bw = new BackgroundWorker();
        public BackgroundWorker _bwKnizi = new BackgroundWorker();
        public BackgroundWorker _CheckLicence = new BackgroundWorker();


        public void CreateObjects()
        {
            InitForm();
        }
        public ToolStripItemCollection specialMenu()
        {
            return menuStrip1.Items;
        }

        public void InitForm()
        {
            Application.DoEvents();
            mainProgressBar.Value = 20;
            CreateQuickButtons();

            menuStrip1.Enabled = true;

            if (модулЗаКелнерToolStripMenuItem.Available && tmpConfigs.MainActiveForms.Smetki)
                _kelner = new MKelner.Forms.frmKelner(UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
            mainProgressBar.Value = 40;

            if (касаToolStripMenuItem.Available && tmpConfigs.MainActiveForms.Smetki)
                _kasa = new MKelner.Forms.frmKelner(UserFullName, UserLevel, true) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
            mainProgressBar.Value = 60;

            mainProgressBar.Value = 80;
            Application.DoEvents();
            if (модулЗаМатеријалнаЕвиденцијаToolStripMenuItem.Available && tmpConfigs.MainActiveForms.Priem)
                _priem = new MMaterijalno.frmPriem() { Text = модулЗаМатеријалнаЕвиденцијаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            Application.DoEvents();
            if (интерниДокументиToolStripMenuItem.Available && tmpConfigs.MainActiveForms.Interni)
                _interni = new frmInterniDokumenti() { Text = интерниДокументиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            Application.DoEvents();
            if (модулЗаФактуриToolStripMenuItem.Available && tmpConfigs.MainActiveForms.Fakturi)
                _fakturi = new MFakturi.frmFaktura() { Text = модулЗаФактуриToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            mainProgressBar.Value = 100;
            Application.DoEvents();
            if (наплатаОдПартнерToolStripMenuItem.Available && tmpConfigs.MainActiveForms.Izvodi)
                _izvodi = new frmIzvodi() { Text = наплатаОдПартнерToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };

            Application.DoEvents();

            mainProgressBar.Value = 0;

            if (settings.BackupNaStartUp.ToUpper() == "TRUE")
            {
                DBAccess.BackupDatabaseAsync();
            }
            if (!string.IsNullOrEmpty(settings.BackupNaServerPateka) 
                && !Debugger.IsAttached)
            {
                DBAccess.BackupDatabaseOnServerAsync();
            }
            Application.DoEvents();


            //if (File.Exists(settings.PatekaDoLogo))
            //{

            //    Controls.OfType<MdiClient>().First().BackgroundImage = Image.FromFile(settings.PatekaDoLogo);
            //    pictureBox1.Image = Image.FromFile(settings.PatekaDoLogo);
            //}

            if (settings.EnableServerAPI_Sinhronizacija)
            {
                _webApiSync = new BssBase.Functions.WebApiSync(this.mainProgressBar, alertControl1, this);
            }
            _CheckLicence.DoWork += _CheckLicence_DoWork;   
            _CheckLicence.RunWorkerAsync();
        }

        private void _CheckLicence_DoWork(object sender, DoWorkEventArgs e)
        {
            isLicenceValidAsync().ConfigureAwait(true);
        }

        public frmSettings(string glavnaFormConnectionString, int userId, string userFullName, int userLevel)
        {
            InitializeComponent();
            menuStrip1.Enabled = false;
            GlavnaFormConnectionString = glavnaFormConnectionString;
            UserId = userId;
            UserLevel = userLevel;
            UserFullName = userFullName;
            lblDatum.Text = DateTime.Now.ToShortDateString();
            lblImeNaKorisnik.Text = userFullName;
            if (UserLevel < 9)
            {
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
            }


            if (UserFullName == "Boban Spirovski")
            {
                суперАдминToolStripMenuItem.Visible = true;

            }
            else
            {
                суперАдминToolStripMenuItem.Visible = false;
            }

            if (UserLevel == 6 && settings.TipNaPrograma == "8")
            {
                edinecniMerkiToolStripMenuItem.Visible = false;
            }


            Text += string.Format(" {1} ( BSSR © 2012 - 2025 - Верзија {0} ) ", Application.ProductVersion, BssBase.settings.RegPath.Split('\\').LastOrDefault());
            SetirajPrivilegiiNaPrograma();
            setirajPrivilegieSporedTxtIdFirma();


        }

        private void setirajPrivilegieSporedTxtIdFirma()
        {

            string txtIdFirma = string.Empty;

            txtIdFirma = Tools.GetIDNaFirma();

            if (string.IsNullOrEmpty(txtIdFirma)) return;
            if (!string.IsNullOrEmpty(txtIdFirma) && txtIdFirma == "541285") return;

            if (!txtIdFirma.Contains("SYNC")) return;


            string dbConfig = txtIdFirma.Split('_').LastOrDefault();

            switch (dbConfig)
            {
                case "root":
                    {
                        нормативиToolStripMenuItem.Visible = false;
                        касаToolStripMenuItem.Visible = false;
                        модулЗаКелнерToolStripMenuItem.Visible = false;
                        модулЗаБришењеНаСметкаToolStripMenuItem.Visible = false;
                        нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                        фискалниИзвештаиToolStripMenuItem.Visible = false;
                        групаНаАртиклиToolStripMenuItem.Visible = true;
                        прегледНаСитеНалозиToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                        прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                        прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                        toolStripMenuItem28.Visible = false;
                        прегледНаСитеНалозиToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                        прегледНаСметкиToolStripMenuItem.Visible = false;
                        прегледПоВработенToolStripMenuItem.Visible = false;
                        прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                    }
                    break;
                case "client":
                    {
                        edinecniMerkiToolStripMenuItem.Visible = false;
                        приемToolStripMenuItem.Visible = false;
                        фактурирањеToolStripMenuItem.Visible = false;
                        наплатаОдПартнерToolStripMenuItem.Visible = false;
                        нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                        прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                        прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                        прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                    }
                    break;
                case "server":
                    {
                        korisniciToolStripMenuItem.Visible = false;
                        коминтентиToolStripMenuItem.Visible = false;
                        курснаЛистаToolStripMenuItem.Visible = false;
                        групаНаАртиклиToolStripMenuItem.Visible = true;
                        подгрупиToolStripMenuItem.Visible = true;
                        артиклиToolStripMenuItem.Visible = false;
                        забелешкиToolStripMenuItem.Visible = false;
                        касаToolStripMenuItem.Visible = false;
                        модулЗаКелнерToolStripMenuItem.Visible = false;
                        наплатаОдПартнерToolStripMenuItem.Visible = false;
                        модулЗаКелнерToolStripMenuItem.Visible = false;
                        нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                        фискалниИзвештаиToolStripMenuItem.Visible = false;
                        групаНаАртиклиToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                        прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                        прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                        прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                    }
                    break;
            }

        }



        private void единечниМеркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmEdinicniMerki() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = единечниМеркиToolStripMenuItem.Text };
            glavnaForma.Show();

        }

        private void групаНаАртиклиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmGrupaArtikli() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = групаНаАртиклиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void објектиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmObjekti() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = објектиToolStripMenuItem.Text };
            glavnaForma.Show();

        }

        private void кориснициToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmKorisnici() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = кориснициToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Equals(ActiveMdiChild, null))
            {
                ActiveMdiChild.Close();
            }
            else
            {
                Close();
            }

        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да ја напуштите програмата ?"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {

                if (_priem != null) _priem.Dispose();
                if (_interni != null) _interni.Dispose();
                if (_izvodi != null) _izvodi.Dispose();
                if (_fakturi != null) _fakturi.Dispose();
                if (_kelner != null) _kelner.Dispose();
                if (_kasa != null) _kasa.Dispose();
                //if (settings.TipNaPrograma == "8889")
                //{
                //    if (_internetKafe != null) _internetKafe.Dispose();
                //}

            }
        }

        private void дДВСтапкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmDDVStavka() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = дДВСтапкиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void конфигурацијаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmFirmi() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = конфигурацијаToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void артиклиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var artikli = new frmArtikli() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = артиклиToolStripMenuItem.Text };

            artikli.Show();
        }

        private void нормативиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmNormativ() { MdiParent = ActiveForm, Text = нормативиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void подгрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPodgrupi() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = подгрупиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void модулЗаКелнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            _kelner.ShowDialog();
        }

        private void прегледНаСметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaSmetki() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
            glavnaForma.Show();
        }

        private void прегледНаСитеНалозиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaNalozi() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = прегледНаСитеНалозиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void потрошениМатеријалиЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPotroseniMaterijali() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = потрошениМатеријалиВоКујнаToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void дневеФискаленИзвештајToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(settings.TipNaFiskalna))
            {
                if (settings.TipNaFiskalna == "Razvigorec" || settings.TipNaFiskalna == "David")
                {
                    BssBase.Roots.frmDatumOdDo frmDatum = new BssBase.Roots.frmDatumOdDo();
                    DialogResult rez = frmDatum.ShowDialog();
                    if (rez == DialogResult.OK)
                    {
                        if (Equals(null, frmDatum.DatumDO)) return;
                        if (Equals(null, frmDatum.datumOD)) return;

                        var fiskalna = new FiscalCash(this.Name);
                        fiskalna.InitInterface();

                        if (settings.TipNaFiskalna == "Razvigorec")
                        {
                            fiskalna.IzvestajZaPeriodRazvigorec(frmDatum.datumOD.Value, frmDatum.DatumDO.Value,
                                frmDatum.skraten.Checked);
                        }
                        if (settings.TipNaFiskalna == "David")
                        {
                            fiskalna.IzvestajZaPeriodDavid(frmDatum.datumOD.Value, frmDatum.DatumDO.Value,
                                frmDatum.skraten.Checked);
                        }

                        frmDatum.Dispose();
                    }

                }
                else
                {
                    var process = new Process();
                    process.StartInfo.FileName = "IzvestajFiskalna.exe";
                    process.Start();
                    process.WaitForExit();
                }
            }

        }

        private void датаумНаФискалнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var process = new Process();
            process.StartInfo.FileName = "FiskalnaDatum.exe";
            process.Start();
            process.WaitForExit();
        }

        private void завршиСторниранаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                fiskalna.IssueStorno();
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void завршиСметкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                fiskalna.IssueBill(true);
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void потрошениМатеријалиВоКујнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPotroseniMaterijaliKujna() { MdiParent = ActiveForm, Text = потрошувачкаНаМатеријалиОдНормативиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void внесНаПрометToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var amount = 0;
                settings.OnScreenKeyNaSveDugminjaBoard = true;
                var rez = InputBox.Show("Внесете сума за внес на пари во фискална", false, true);
                settings.OnScreenKeyNaSveDugminjaBoard = false;
                settings.OnScreenKeyBoard = false;
                if (!string.IsNullOrEmpty(rez.Text))
                {
                    amount = Tools.PrazenStringToInt(rez.Text);
                    var fiskalna = new FiscalCash(this.Name);
                    fiskalna.InitInterface();
                    fiskalna.DailyMoneyInput(amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Tools.PrevediPoraka("Настана грешка , сумата не одговара или има проблем со фискалната"));
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void дневенФинансискиИзвештајБезНулирањеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                fiskalna.DailyFiscalWithoutClose();
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void сетирањеНаДатумНаФискалнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var process = new Process();
            process.StartInfo.FileName = "FiskalnaDatum.exe";
            process.Start();
            process.WaitForExit();
        }

        private void модулЗаБришењеНаСметкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmObrabotkaNaSmetki() { MdiParent = ActiveForm, Text = модулЗаБришењеНаСметкаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void отпечатениФискалниСметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaFiskalniSmetki() { MdiParent = ActiveForm, Text = отпечатениФискалниСметкиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        /// <summary>
        ///   TIP NA PROGRAMA : 
        ///   Restorant Garden 888
        ///   AZIR SLATKARA 88
        ///   AZIR KASA 8
        ///   BISKOMERC
        /// </summary>
        public void SetirajPrivilegiiNaPrograma()
        {

            tmpConfigs.MainActiveForms = new tmpConfigs.ActiveForms();
            tmpConfigs.MainActiveForms.Priem = false;
            tmpConfigs.MainActiveForms.Fakturi = false;
            tmpConfigs.MainActiveForms.Interni = false;
            tmpConfigs.MainActiveForms.Smetki = false;

            //Restorant zivot e cirkuz &&         //Garden
            if (settings.TipNaPrograma == "888")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                нормативиToolStripMenuItem.Visible = true;
                нормативиToolStripMenuItem1.Visible = true;
                tmpConfigs.MainActiveForms.Priem = false;
                tmpConfigs.MainActiveForms.Fakturi = false;
                tmpConfigs.MainActiveForms.Interni = false;
                tmpConfigs.MainActiveForms.Smetki = true;
                наплатаОдПартнерToolStripMenuItem.Visible = true;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = true;
                касаToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = true;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = true;
                затворањеНаДенToolStripMenuItem1.Visible = true;
                затворањеНаДенToolStripMenuItem.Visible = true;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = true;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                интерниДокументиToolStripMenuItem.Visible = true;
                типовиНаДокументиToolStripMenuItem.Visible = true;

                пЛТОбраззецToolStripMenuItem.Visible = true;
                еТОбразецToolStripMenuItem.Visible = true;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
            }
            //Azir prodazba kasa
            if (settings.TipNaPrograma == "8")
            {

                PotrosuvackaMeniGrouped.Visible = true;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = true;
                касаToolStripMenuItem.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
                наплатаОдПартнерToolStripMenuItem.Visible = false;
            }
            //Azir slatkara
            if (settings.TipNaPrograma == "88")
            {

                PotrosuvackaMeniGrouped.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = true;
                касаToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
                наплатаОдПартнерToolStripMenuItem.Visible = false;
            }

            //Biskomerc
            if (settings.TipNaPrograma == "55")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = true;
                касаToolStripMenuItem.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                tmpConfigs.MainActiveForms.Priem = false;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = false;
                tmpConfigs.MainActiveForms.Smetki = false;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}

            }

            if (settings.TipNaPrograma == "Kasa")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                подесувањаToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = true;
                приемToolStripMenuItem.Visible = false;
                документиToolStripMenuItem.Visible = false;
                касаToolStripMenuItem.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                tmpConfigs.MainActiveForms.Priem = false;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = false;
                tmpConfigs.MainActiveForms.Smetki = true;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);


            }

            if (settings.TipNaPrograma == "Kasa2")
            {

                PotrosuvackaMeniGrouped.Visible = false;
                нормативиToolStripMenuItem.Visible = true;
                нормативиToolStripMenuItem1.Visible = true;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = true;
                приемToolStripMenuItem.Visible = false;
                документиToolStripMenuItem.Visible = false;
                касаToolStripMenuItem.Visible = false;


                фактурирањеToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = true;
                подесувањаToolStripMenuItem.Visible = false;
                tmpConfigs.MainActiveForms.Priem = false;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = false;
                tmpConfigs.MainActiveForms.Smetki = true;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);

            }
            //Victorian
            if (settings.TipNaPrograma == "250")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                нормативиToolStripMenuItem.Visible = true;
                нормативиToolStripMenuItem1.Visible = true;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                интерниДокументиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = true;
                касаToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                даденРабатПоДенToolStripMenuItem.Visible = false;

                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);

            }

            //Cementara
            if (settings.TipNaPrograma == "988KasaPartner")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = true;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                забелешкиToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = true;
                касаToolStripMenuItem.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = true;
                нарачкиОдКлиентиToolStripMenuItem.Visible = true;

                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                потрошувачкаНаМатеријалиОдНормативиToolStripMenuItem.Visible = false;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
            }

            //Mixhait
            if (settings.TipNaPrograma == "988Kasa")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;

                if (settings.AdminPcName == "1")
                {
                    приемToolStripMenuItem.Visible = false;
                }
                else if (settings.AdminPcName == "BujarKasa")
                {
                    приемToolStripMenuItem.Visible = true;
                }
                објектиToolStripMenuItem.Visible = false;
                типовиНаДокументиToolStripMenuItem.Visible = true;
                presmetkovniEdinici.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                конфигурацијаToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem.Visible = false;
                забелешкиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                состојбаНаАртиклиЗалихаToolStripMenuItem.Visible = true;
                заработкаОдАртикалToolStripMenuItem.Visible = true;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = true;
                потрошувачкаНаМатеријалиОдНормативиToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                toolStripMenuItem16.Visible = false;
                даденРабатПоДенToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;

            }

            /* Bujar ELIPSO  GROUP PC */
            if (settings.TipNaPrograma == "8889")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;

                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = true;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = true;
                касаToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = true;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                затворањеНаДенToolStripMenuItem1.Visible = false;
                затворањеНаДенToolStripMenuItem.Visible = true;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                интерниДокументиToolStripMenuItem.Visible = false;
                типовиНаДокументиToolStripMenuItem.Visible = false;
                пЛТОбраззецToolStripMenuItem.Visible = false;
                еТОбразецToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;

            }
            if (settings.TipNaPrograma == "987")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;

                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                интерниДокументиToolStripMenuItem.Visible = true;
                типовиНаДокументиToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                издадениФискалнисметкиToolStripMenuItem.Visible = false;
                потрошувачкаНаМатеријалиОдНормативиToolStripMenuItem.Visible = false;
                касаToolStripMenuItem.Visible = false;
                кДФИОбразецToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = false;
                mainProgressBar.Visible = false;
                grupaNaArtikliToolStripMenuItem.Visible = false;
                objektiToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                модулЗаБришењеНаСметкаToolStripMenuItem.Visible = false;
                дневенПрометПоДенToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                приемToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;

                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
            }
            if (settings.TipNaPrograma == "10")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;

                toolStripDropDownButton1.Visible = false;
                касаToolStripMenuItem.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = true;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = true;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;

                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
            }

            /* ELIPSO MOTO */
            if (settings.TipNaPrograma == "10M")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = true;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;

                toolStripDropDownButton1.Visible = false;
                касаToolStripMenuItem.Visible = true;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = true;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = true;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = true;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                договориToolStripMenuItem.Visible = false;
                
            }
            //Burimi
            if (settings.TipNaPrograma == "888200")
            {
                PotrosuvackaMeniGrouped.Visible = true;
                фактурирањеToolStripMenuItem.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = false;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = true;
                нормативиToolStripMenuItem.Visible = true;
                нормативиToolStripMenuItem1.Visible = true;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = true;
                касаToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = true;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                затворањеНаДенToolStripMenuItem1.Visible = false;
                затворањеНаДенToolStripMenuItem.Visible = true;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                интерниДокументиToolStripMenuItem.Visible = true;
                типовиНаДокументиToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                пЛТОбраззецToolStripMenuItem.Visible = false;
                еТОбразецToolStripMenuItem.Visible = false;
                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
            }

            if (settings.TipNaPrograma == "10KulaB")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = true;
                tmpConfigs.MainActiveForms.Fakturi = false;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = false;
                tmpConfigs.MainActiveForms.Izvodi = true;
                печатењеИМаилToolStripMenuItem.Visible = true;
                состојбаНаАртиклиToolStripMenuItem.Visible = false;
                
                суперАдминToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = false;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                модулЗаБришењеНаСметкаToolStripMenuItem.Visible = false;
                објектиToolStripMenuItem.Visible = false;
                presmetkovniEdinici.Visible = false;
                типовиНаДокументиToolStripMenuItem.Visible = false;
                конфигурацијаToolStripMenuItem.Visible = false;
                издадениФискалнисметкиToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = false;
                касаToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = false;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = true;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                потрошениМатеријалиВоКујнаToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = true;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                grupaNaArtikliToolStripMenuItem.Visible = false;
                дневенПрометПоДенToolStripMenuItem.Visible = false;
                прегледНаПрометПоДенToolStripMenuItem.Visible = false;
                даденРабатПоДенToolStripMenuItem.Visible = false;
                prodazbaOdSmetki.Visible = false;
                потрошувачкаНаМатеријалиОдНормативиToolStripMenuItem.Visible = false;
                прегледНаМатеријалиЗаНабавкаToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                обрасциToolStripMenuItem.Visible = false;
                прегледПоВработенToolStripMenuItem.Visible = false;
                прегледНаСметкиToolStripMenuItem.Visible = false;
                прегледНаСитеНалозиToolStripMenuItem.Visible = false;
                toolStripMenuItem28.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаМоменталниКоличини.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                состојбаНаАртиклиЗалихаToolStripMenuItem.Visible = false;
                заработкаОдАртикалToolStripMenuItem.Visible = false;
                toolStripMenuItem16.Visible = false;
                салдоНаПартнерToolStripMenuItem.Visible = false;
                деталенПрегледНаЛагерЛистаПОПИСToolStripMenuItem.Visible = false;
                GodiSenPregled.Visible = true;
            }
            //RAUCHE
            if (settings.TipNaPrograma == "Documents789")
            {
                PotrosuvackaMeniGrouped.Visible = false;
                tmpConfigs.MainActiveForms.Priem = false;
                tmpConfigs.MainActiveForms.Fakturi = false;
                tmpConfigs.MainActiveForms.Interni = true;
                tmpConfigs.MainActiveForms.Smetki = false;
                toolStripMenuItem20.Visible = false;
                салдоНаПартнерToolStripMenuItem.Visible = false;
                toolStripMenuItem24.Visible = false;
                еТОбразецToolStripMenuItem.Visible = false;

                прегледНаМатеријалиЗаНабавкаToolStripMenuItem.Visible = false;
                prodazbaOdSmetki.Visible = false;
                фактурирањеToolStripMenuItem.Visible = false;
                grupaNaArtikliToolStripMenuItem.Visible = false;
                печатењеИМаилToolStripMenuItem.Visible = false;
                presmetkovniEdinici.Visible = false;
                типовиНаДокументиToolStripMenuItem.Visible = false;
                фактурирањеToolStripMenuItem.Visible = false;
                наплатаОдПартнерToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem.Visible = false;
                нормативиToolStripMenuItem1.Visible = false;
                курснаЛистаToolStripMenuItem.Visible = false;
                интерниДокументиToolStripMenuItem.Visible = true;
                типовиНаДокументиToolStripMenuItem.Visible = false;
                валутиToolStripMenuItem.Visible = false;
                нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                издадениФискалнисметкиToolStripMenuItem.Visible = false;
                потрошувачкаНаМатеријалиОдНормативиToolStripMenuItem.Visible = false;
                касаToolStripMenuItem.Visible = false;
                кДФИОбразецToolStripMenuItem.Visible = false;
                toolStripDropDownButton1.Visible = false;
                mainProgressBar.Visible = false;
                grupaNaArtikliToolStripMenuItem.Visible = false;
                objektiToolStripMenuItem.Visible = true;
                foreach (ToolStripItem item in objektiToolStripMenuItem.DropDownItems)
                {
                    item.Visible = false;

                }
                прегледПоДоговорToolStripMenuItem.Visible = true;
                електронскиПриемНаДокументиToolStripMenuItem.Visible = false;
                модулЗаБришењеНаСметкаToolStripMenuItem.Visible = false;
                дневенПрометПоДенToolStripMenuItem.Visible = false;
                модулЗаКелнерToolStripMenuItem.Visible = false;
                количинаНаИздадениПорцииНормативиToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;

                приемToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиТретаСменаToolStripMenuItem.Visible = false;
                прегледНаСитеСметкиToolStripMenuItem.Visible = false;
                toolStripMenuItem30.Visible = false;
                прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Visible = false;
                прегледНаСметкиПоПартнерToolStripMenuItem.Visible = false;
                прегледНаНарачкиПоДенToolStripMenuItem.Visible = false;
                прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Visible = false;
                извештајНабавениToolStripMenuItem.Visible = false;

                //this.artikliStoTrebaDaSeNabavaTableAdapter.Fill(this.bSSSDataset.ArtikliStoTrebaDaSeNabava);
                //if (this.bSSSDataset.ArtikliStoTrebaDaSeNabava.Rows.Count > 0)
                //{
                //    DevExpress.XtraBars.Alerter.AlertInfo a = new DevExpress.XtraBars.Alerter.AlertInfo("Надмината минималната количина", "Кликнете тука за да ја видите целосната листа на артикли кои ја надминуваат нивната минимална количина на залиха");
                //    alertControl1.Show(this, a);
                //}
            }


        }


        private void frmSettings_Load(object sender, EventArgs e)
        {
            _bw.WorkerReportsProgress = true;
            _bw.WorkerSupportsCancellation = true;
            _bw.DoWork += bw_DoWork;
            _bw.ProgressChanged += bw_ProgressChanged;
            _bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            _bwKnizi.WorkerReportsProgress = true;
            _bwKnizi.WorkerSupportsCancellation = true;
            _bwKnizi.DoWork += bwKnizi_DoWork;
            _bwKnizi.ProgressChanged += bwKnizi_ProgressChanged;
            _bwKnizi.RunWorkerCompleted += bwKnizi_RunWorkerCompleted;

            mainProgressBar.Maximum = 100;
            try
            {
                if (settings.TipNaPrograma != "8"
                    && settings.TipNaPrograma != "987"
                    && settings.TipNaPrograma != "88"
                    && settings.TipNaPrograma != "55"
                    && settings.TipNaPrograma != "10"
                    && settings.TipNaPrograma != "10M"
                    && settings.TipNaPrograma != "101"
                    && settings.TipNaPrograma != "250"
                    && settings.TipNaPrograma != "888"
                    && settings.TipNaPrograma != "100"
                    && settings.TipNaPrograma != "Kasa"
                    && settings.TipNaPrograma != "8889"
                    && settings.TipNaPrograma != "888200"
                    && settings.TipNaPrograma != "Kasa2"
                    && settings.TipNaPrograma != "988Kasa"
                    && settings.TipNaPrograma != "988KasaPartner"
                    && settings.TipNaPrograma != "10KulaB"
                    && settings.TipNaPrograma != "Documents789")
                {
                    Hide();
                    Close();
                    return;
                }
                Controls.OfType<MdiClient>().First().BackColor = Color.Beige;

                if (settings.TipNaPrograma == "8" || settings.TipNaPrograma == "88" || settings.TipNaPrograma == "888")
                {
                    нарачкиОдКлиентиToolStripMenuItem.Visible = true;
                }
                else
                {
                    нарачкиОдКлиентиToolStripMenuItem.Visible = false;
                }

                if (settings.NivelaCijaNaKrajNaDen.ToUpper() == "TRUE")
                {
                    затворањеНаДенToolStripMenuItem1.Visible = true;
                }
                else
                {
                    затворањеНаДенToolStripMenuItem1.Visible = false;
                }

                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {

                    txtKonekcija.Text = string.Format("Server: {0} Database: {1} ", con.DataSource, con.Database);
                }

                if (settings.EnableServerAPI_Sinhronizacija)
                {
                    синхронизацијаСоСерверToolStripMenuItem.Visible = true;
                    if (!settings.ServerEnableVnes_API.ToLower().Contains("true"))
                    {
                        edinecniMerkiToolStripMenuItem.Visible = false;
                    }

                }

            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        void bwKnizi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mainProgressBar.Value = 0;
            MessageBox.Show("Успешно затворање на ден, сите документи се успешно прокнижени ");
            затворањеНаДенToolStripMenuItem.PerformClick();
            if (settings.TipNaPrograma == "8" || settings.TipNaPrograma == "88")
            {
                //Prati podatoci 
                if (_bw.IsBusy != true)
                {
                    _bw.RunWorkerAsync();
                }
            }

        }

        void bwKnizi_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mainProgressBar.Value = e.ProgressPercentage;
        }

        void bwKnizi_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (MMaterijalno.MaterijalnoDataSet ds = new MMaterijalno.MaterijalnoDataSet())
                {

                    BindingSource bsSmetki = new BindingSource();
                    BindingSource bsPriemi = new BindingSource();
                    BindingSource bsFakturi = new BindingSource();
                    BindingSource bsDokumenti = new BindingSource();


                    bsFakturi.Filter = " Knizeno = 0";

                    bsPriemi.Filter = "Knizeno = 0";

                    bsSmetki.Filter = "Zatvorena = 'true' AND Knizeno = 0";

                    bsDokumenti.Filter = "Knizeno = 0";

                    //Smetki
                    MMaterijalno.MaterijalnoDataSetTableAdapters.vSmetkaKnizenjeTableAdapter smetki = new MMaterijalno.MaterijalnoDataSetTableAdapters.vSmetkaKnizenjeTableAdapter();
                    bsSmetki.DataSource = ds.vSmetkaKnizenje;
                    smetki.Fill(ds.vSmetkaKnizenje);

                    //priemi
                    MMaterijalno.MaterijalnoDataSetTableAdapters.vPriemiKnizenjeTableAdapter priemi = new MMaterijalno.MaterijalnoDataSetTableAdapters.vPriemiKnizenjeTableAdapter();
                    bsPriemi.DataSource = ds.vPriemiKnizenje;
                    priemi.Fill(ds.vPriemiKnizenje);

                    //fakturi
                    MMaterijalno.MaterijalnoDataSetTableAdapters.vFakturiKnzienoTableAdapter fakturi = new MMaterijalno.MaterijalnoDataSetTableAdapters.vFakturiKnzienoTableAdapter();
                    bsFakturi.DataSource = ds.vFakturiKnzieno;
                    fakturi.Fill(ds.vFakturiKnzieno);

                    //dokumenti
                    MMaterijalno.MaterijalnoDataSetTableAdapters.vDokumentiKnizenoTableAdapter dokumenti = new MMaterijalno.MaterijalnoDataSetTableAdapters.vDokumentiKnizenoTableAdapter();
                    bsDokumenti.DataSource = ds.vDokumentiKnizeno;
                    dokumenti.Fill(ds.vDokumentiKnizeno);


                    if (ds.vSmetkaKnizenje != null) foreach (DataRow item in ds.vSmetkaKnizenje.Select("Zatvorena = 'true' AND Knizeno = 0")) Tools.ProkniziSmetka(Tools.PrazenStringToInt(item["ID"].ToString()));
                    _bwKnizi.ReportProgress(25);
                    if (ds.vPriemiKnizenje != null) foreach (DataRow item in ds.vPriemiKnizenje.Select("Knizeno = 0")) Tools.ProkniziPriem(Tools.PrazenStringToInt(item["ID"].ToString()));
                    _bwKnizi.ReportProgress(50);
                    if (ds.vFakturiKnzieno != null) foreach (DataRow item in ds.vFakturiKnzieno.Select("Knizeno = 0")) Tools.ProkniziFaktura(Tools.PrazenStringToInt(item["ID"].ToString()));
                    _bwKnizi.ReportProgress(75);
                    if (ds.vDokumentiKnizeno != null) foreach (DataRow item in ds.vDokumentiKnizeno.Select("Knizeno = 0")) Tools.ProkniziDokument(Tools.PrazenStringToInt(item["ID"].ToString()));
                    _bwKnizi.ReportProgress(100);


                }
            }
            catch (Exception)
            {
                //  tools.PrevediSQLException(ex);
                // return;
            }
        }


        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mainProgressBar.Value = 0;

        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mainProgressBar.Value = e.ProgressPercentage;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
            

                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka(@"Сите документи кои се прокнижени ќе бидат префлени на главниот сервер, сите сметки ќе бидат прокнижени,  дали сте сигурни дека сакате да продолжите ?"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    //Specify the binding to be used for the client.
                    BasicHttpBinding binding = new BasicHttpBinding();
                    //Specify the address to be used for the client.
                    EndpointAddress address = new EndpointAddress(string.Format("http://{0}/BsMainData.asmx", tmpConfigs.BSMainServiceEndPoint));

                    BSDataMain.BsMainDataSoapClient cl = new BSDataMain.BsMainDataSoapClient(binding, address);
                    if (cl.UspesnaKonekcija())
                    {
                        _bw.ReportProgress(10);
                        PrefrliPriemi(cl);
                        _bw.ReportProgress(20);
                        PrefrliFakturi(cl);
                        _bw.ReportProgress(30);
                        PrefrliDokumenti(cl);
                        _bw.ReportProgress(50);
                        PrefrliNaracki(cl);
                        _bw.ReportProgress(60);
                        DataTable smetki = Tools.NeProknizeniSmetki();
                        if (smetki != null)
                        {
                            foreach (DataRow item in smetki.Rows)
                            {
                                Tools.ProkniziSmetka(Tools.PrazenStringToInt(item["ID"].ToString()));
                            }
                        }
                        _bw.ReportProgress(80);
                        PrefrliSmetkiNaloziIFiskalni(cl);
                        _bw.ReportProgress(100);
                        MessageBox.Show("Сите документи се успешно префрлени на главниот сервер", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Неyспешна конекција со VPN  серверот , проверете ја вашата интернет конекција и VPN конекција и обидете се повторно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        private void прегледПоВработенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmIzvestajPoVraboten() { MdiParent = ActiveForm, Text = прегледПоВработенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void конфигурацијаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmConfig { MdiParent = ActiveForm, Text = конфигурацијаToolStripMenuItem1.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void банкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MFakturi.Forms.frmBanki { MdiParent = ActiveForm, Text = банкиToolStripMenuItem1.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void партнериToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MFakturi.Forms.frmPartner { MdiParent = ActiveForm, Text = партнериToolStripMenuItem1.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void жироСметкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MFakturi.Forms.frmZiroSmetki { MdiParent = ActiveForm, Text = жироСметкиToolStripMenuItem1.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void издадениФискалнисметкиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmFiskalniSmetki() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = издадениФискалнисметкиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void затворањеНаДенToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Tools.PrevediPoraka("ЗАТВОРАЊЕ НА ДЕН Е ДОЗВОЛЕНО САМО ЕДНАШ ВО ТЕКОТ НА ДЕНОТ, БИДЕТЕ ВНИМАТЕЛНИ !!!"), Tools.PrevediPoraka("ВНИМАНИЕ !!!"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да го затворите денешниот ден ?"), затворањеНаДенToolStripMenuItem.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opc == DialogResult.Yes)
            {
                try
                {
                    var fiskalna = new FiscalCash(this.Name);
                    fiskalna.InitInterface();
                    fiskalna.DailyFiscalClose();
                    if (settings.MailNaZatvoranjeNaDen == "1")
                    {
                        Tools.PratiMailNaZatvoranjeNaDen();
                    }

                    if (settings.ProkniziSmetki == "1")
                    {
                        foreach (DataRow item in Tools.NeProknizeniSmetki().Rows)
                        {
                            Tools.ProkniziSmetka(Tools.PrazenStringToInt(item["ID"].ToString()));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Tools.PrevediSQLException(ex);
                    return;
                }
            }
        }

        private void модулЗаФактуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }

            _fakturi.ShowDialog();
        }

        private void картичкаНаКупувачДобавувачToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPlacanjaOdPartnerPodDokument() { MdiParent = ActiveForm, Text = картичкаНаКупувачДобавувачToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void извештајЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmIzvestajZaPerdiodFakturi() { MdiParent = ActiveForm, Text = извештајЗаПериодToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }



        private void книжењеНаДокументиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmKnizenje { MdiParent = ActiveForm, Text = книжењеНаДокументиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void извештајНабавениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmIzvestajPriemi { MdiParent = ActiveForm, Text = извештајНабавениToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void состојбаНаАртиклиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmSostojbaNaArtikli { MdiParent = ActiveForm, Text = состојбаНаАртиклиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };

            glavnaForma.Show();
        }

        private void состојбаНаАртиклиЗалихаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmSostojbaCelosnaNaArtikli { MdiParent = ActiveForm, Text = состојбаНаАртиклиЗалихаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void alertControl1_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            BssBase.Roots.frmIzvestaj forma =
                new BssBase.Roots.frmIzvestaj
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Icon = Icon
                };
            DataGridView grd = new DataGridView();
            grd.DataSource = bSSSDataset.Tables["ArtikliStoTrebaDaSeNabava"];
            grd.Dock = DockStyle.Fill;
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.AllowUserToOrderColumns = false;
            forma.MainMenuStrip.Visible = false;
            grd.ColumnHeadersVisible = false;
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            forma.Controls.Add(grd);
            forma.ShowDialog();
        }

        public void Storiniraj(int tip)
        {
            dbFunctions.StornirajKnizenja(tip);
        }

        private void сторнирањеНаСитеКнижењаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Дали сте сигурни дека сакате да ги сторнирате сите сметки во материјалното книжење ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Storiniraj(1);
                opc = DialogResult.No;
            }

            opc = MessageBox.Show("Дали сте сигурни дека сакате да ги сторнирате сите Приеми во материјалното книжење ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Storiniraj(3);
                opc = DialogResult.No;
            }

            opc = MessageBox.Show("Дали сте сигурни дека сакате да ги сторнирате сите Фактури во материјалното книжење ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Storiniraj(2);
                opc = DialogResult.No;
            }
        }

        private void сторнирањеНаКнижењаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmKnizenje(true) { MdiParent = ActiveForm, Text = сторнирањеНаКнижењаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void прегледНаМатеријалиЗаНабавкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            artikliStoTrebaDaSeNabavaTableAdapter.Fill(bSSSDataset.ArtikliStoTrebaDaSeNabava);

            BssBase.Roots.frmIzvestaj forma = new BssBase.Roots.frmIzvestaj();
            forma.Name = "MaterijaliZaNabavka";
            forma.Text = прегледНаМатеријалиЗаНабавкаToolStripMenuItem.Text;
            forma.WindowState = FormWindowState.Maximized;
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.Icon = Icon;
            var grd = new GridBig();
            grd.Name = "MaterijaliZaNabavka.grid";
            grd.DataSource = bSSSDataset.Tables["ArtikliStoTrebaDaSeNabava"];
            grd.Dock = DockStyle.Fill;
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.AllowUserToOrderColumns = false;
            forma.MainMenuStrip.Visible = false;
            grd.ColumnHeadersVisible = false;
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            forma.Controls.Add(grd);
            Cursor = Cursors.Default;
            forma.ShowDialog();

        }

        private void количинаНаИздадениПорцииНормативиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmKolicinaNaPorcii { MdiParent = ActiveForm, Text = количинаНаИздадениПорцииНормативиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void нормативиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmSodrzinaNaNormativi { MdiParent = ActiveForm, Text = нормативиToolStripMenuItem1.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void валутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmValuti() { MdiParent = ActiveForm, Text = валутиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void курснаЛистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmKursnaLista() { MdiParent = ActiveForm, Text = курснаЛистаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void прегледНаИзменетиИзбришаниСметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaIzmenetiSmetki { MdiParent = ActiveForm, Text = прегледНаИзменетиИзбришаниСметкиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void касаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            _kasa.ShowDialog();


        }

        private void бришењеНаКорисничкиПодесувањаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Дали сте сигурни дека сакате да ги избришете сите подесувања ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                dbFunctions.DeleteAllSettings();
                opc = DialogResult.None;
            }
        }

        private void заработкаОдАртикалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmZarabotka { MdiParent = ActiveForm, Text = заработкаОдАртикалToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void sQLMenagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new BssBase.Forms.frmSql { MdiParent = ActiveForm, Text = sQLMenagementToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmZarabotka(true) { MdiParent = ActiveForm, Text = toolStripMenuItem16.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void пЛТОбраззецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPltObrazec() { MdiParent = ActiveForm, Text = пЛТОбраззецToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void еТОбразецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmETObrazec() { MdiParent = ActiveForm, Text = еТОбразецToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void типовиНаДокументиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmTipNaDokument() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = типовиНаДокументиToolStripMenuItem.Text };
            glavnaForma.Show();
        }


        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            var rez = dlg.ShowDialog();
            if (rez == DialogResult.OK)
            {
                string fileName = string.Empty;
                fileName = dlg.SelectedPath;
                DBAccess.BackupDatabaseAsync(fileName);
                MessageBox.Show("Done");

            }
        }

        private void прегледНаПрометПоДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPotrosuvackaPoDen { MdiParent = ActiveForm, Text = прегледНаПрометПоДенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void дневенПрометПоДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmDnevenPrometPoDen { MdiParent = ActiveForm, Text = дневенПрометПоДенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void преносНаПодатоциToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }



        private void getTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                fiskalna.GetTimeDate();
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        private void setTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                string time = DateTime.Now.ToString("dd-MM-yy hh:MM:ss");
                fiskalna.SetTimeDate(time);
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        private void testPrintFiskalnaTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.OnScreenKeyNaSveDugminjaBoard = true;
                var rez = InputBox.Show("Внесете текст за печатење ", false, false);
                settings.OnScreenKeyNaSveDugminjaBoard = false;
                settings.OnScreenKeyBoard = false;
                if (!string.IsNullOrEmpty(rez.Text))
                {
                    var fiskalna = new FiscalCash(this.Name);
                    fiskalna.InitInterface();
                    fiskalna.PrintFreeText(rez.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Настана грешка , има проблем со фискалната");
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        public void PrefrliPriemi(BSDataMain.BsMainDataSoapClient cl)
        {
            try
            {
                var listaNaPriemi = Tools.ListaOdPriemiSoPrazenKod();
                if (listaNaPriemi != null)
                {


                    foreach (DataRow item in listaNaPriemi.Rows)
                    {
                        DataTable tblHeader = new DataTable("tblPriem");
                        tblHeader = listaNaPriemi.Copy();
                        tblHeader.Clear();

                        DataSet db = new DataSet();
                        db.Tables.Add(tblHeader);
                        tblHeader.Clear();
                        db.Tables[0].TableName = "tblPriem";
                        db.Tables[0].ImportRow(item);
                        int priemId = Tools.PrazenStringToInt(item["ID"].ToString());
                        var stavki = Tools.StavkiOdPriem(priemId);
                        if (stavki != null)
                        {
                            db.Tables.Add(stavki.Copy());
                            db.Tables[1].TableName = "tblPriemStavki";
                            string kodNaDokument = tmpConfigs.KodNaPc + "_" + item["PriemBroj"].ToString() + "_" + item["ObjektID"].ToString() + "_" + item["tblUserID"].ToString();
                            kodNaDokument += "_PRI";
                            if (cl.ZapisiPriem(db, kodNaDokument))
                            {


                                using (SqlConnection con = new SqlConnection(settings.konekcija))
                                {
                                    using (SqlCommand com = new SqlCommand(string.Format("Update {0} set KodNaDokument = '{1}' where ID={2}", item.Table.TableName, kodNaDokument, priemId), con))
                                    {
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }
                        }


                        db.Dispose();
                    }
                    MessageBox.Show("Приемите се успешно префрлени");
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        public void PrefrliSmetkiNaloziIFiskalni(BSDataMain.BsMainDataSoapClient cl)
        {
            try
            {
                var listaOdSmetki = Tools.ListaOdSmetkiSoPrazenKod();
                if (listaOdSmetki != null)
                {

                    foreach (DataRow item in listaOdSmetki.Rows)
                    {
                        DataTable tblHeader = new DataTable("tblSmetka");
                        tblHeader = listaOdSmetki.Copy();
                        tblHeader.Clear();

                        DataSet db = new DataSet();
                        db.Tables.Add(tblHeader);
                        tblHeader.Clear();
                        db.Tables[0].TableName = "tblSmetka";
                        db.Tables[0].ImportRow(item);
                        int smetkaId = Tools.PrazenStringToInt(item["ID"].ToString());
                        var stavki = Tools.StavkiOdSmetka(smetkaId);

                        var nalozi = Tools.NaloziOdSmetka(smetkaId);
                        var naloziStavki = Tools.NaloziStavkiOdSmetka(smetkaId);
                        var fiskalna = Tools.FiskalnaOdSmetka(smetkaId);

                        if (stavki != null && nalozi != null && naloziStavki != null)
                        {
                            db.Tables.Add(stavki.Copy());
                            db.Tables[1].TableName = "tblSmetkaStavki";
                            db.Tables.Add(nalozi.Copy());
                            db.Tables[2].TableName = "tblNalog";
                            db.Tables.Add(naloziStavki.Copy());
                            db.Tables[3].TableName = "tblNalogStavki";

                            if (fiskalna != null)
                            {
                                db.Tables.Add(fiskalna.Copy());
                                db.Tables[4].TableName = "tblFiskalniSmetki";
                            }

                            string kodNaDokument = tmpConfigs.KodNaPc + "_" + item["Broj"].ToString() + "_" + "_" + item["tblUserID"].ToString();
                            kodNaDokument += "_SME";
                            if (cl.ZapisiSmetki(db, kodNaDokument))
                            {

                                using (SqlConnection con = new SqlConnection(settings.konekcija))
                                {
                                    using (SqlCommand com = new SqlCommand(string.Format("Update {0} set KodNaDokument = '{1}' where ID={2}", item.Table.TableName, kodNaDokument, smetkaId), con))
                                    {
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                    }

                                    using (SqlCommand com = new SqlCommand(string.Format("Update {0} set KodNaDokument = '{1}' where tblSmetkaID={2}", "tblFiskalniSmetki", kodNaDokument, smetkaId), con))
                                    {
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }
                        }


                        db.Dispose();
                    }
                    MessageBox.Show("Сметките се успешно префрлени");
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        public void PrefrliNaracki(BSDataMain.BsMainDataSoapClient cl)
        {
            try
            {
                var listaSoNaracki = Tools.ListaOdNarackiSoPrazenKodINezavrseni();
                if (listaSoNaracki != null)
                {


                    foreach (DataRow item in listaSoNaracki.Rows)
                    {
                        DataTable tblHeader = new DataTable("tblNaracki");
                        tblHeader = listaSoNaracki.Copy();
                        tblHeader.Clear();

                        DataSet db = new DataSet();
                        db.Tables.Add(tblHeader);
                        tblHeader.Clear();
                        db.Tables[0].TableName = "tblNaracki";
                        db.Tables[0].ImportRow(item);
                        int narackaId = Tools.PrazenStringToInt(item["ID"].ToString());
                        cl.ZapisiNaracki(db, tmpConfigs.KodNaPc);


                        db.Dispose();
                    }
                    MessageBox.Show("Нарачките се успешно префрлени");
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        public void PrefrliDokumenti(BSDataMain.BsMainDataSoapClient cl)
        {
            try
            {
                var listaOdDokumenti = Tools.ListaOdDokumentiSoPrazenKod();
                if (listaOdDokumenti != null)
                {


                    foreach (DataRow item in listaOdDokumenti.Rows)
                    {
                        DataTable tblHeader = new DataTable("tblDokumenti");
                        tblHeader = listaOdDokumenti.Copy();
                        tblHeader.Clear();

                        DataSet db = new DataSet();
                        db.Tables.Add(tblHeader);
                        tblHeader.Clear();
                        db.Tables[0].TableName = "tblDokumenti";
                        db.Tables[0].ImportRow(item);
                        int dokumentId = Tools.PrazenStringToInt(item["ID"].ToString());
                        var stavki = Tools.StavkiOdDokumenti(dokumentId);
                        if (stavki != null)
                        {
                            db.Tables.Add(stavki.Copy());
                            db.Tables[1].TableName = "tblDokumentStavki";

                            string kodNaDokument = tmpConfigs.KodNaPc + "_" + item["Broj"].ToString() + "_" + "_" + item["tblUserID"].ToString();
                            kodNaDokument += "_DOC";
                            if (cl.ZapisiDokumenti(db, kodNaDokument))
                            {


                                using (SqlConnection con = new SqlConnection(settings.konekcija))
                                {
                                    using (SqlCommand com = new SqlCommand(string.Format("Update {0} set KodNaDokument = '{1}' where ID={2}", item.Table.TableName, kodNaDokument, dokumentId), con))
                                    {
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }
                        }


                        db.Dispose();
                    }
                    MessageBox.Show("Документите се успешно префрлени");
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        public void PrefrliFakturi(BSDataMain.BsMainDataSoapClient cl)
        {
            try
            {
                var listaNaFakturi = Tools.ListaOdFakturiSoPrazenKod();
                if (listaNaFakturi != null)
                {

                    foreach (DataRow item in listaNaFakturi.Rows)
                    {
                        DataTable tblHeader = new DataTable("tblFaktura");
                        tblHeader = listaNaFakturi.Copy();
                        tblHeader.Clear();

                        DataSet db = new DataSet();
                        db.Tables.Add(tblHeader);
                        tblHeader.Clear();
                        db.Tables[0].TableName = "tblFaktura";
                        db.Tables[0].ImportRow(item);
                        int fakturaId = Tools.PrazenStringToInt(item["ID"].ToString());
                        var stavki = Tools.StavkiOdFaktura(fakturaId);
                        if (stavki != null)
                        {
                            db.Tables.Add(stavki.Copy());
                            db.Tables[1].TableName = "tblFakturaStavki";
                            string kodNaDokument = tmpConfigs.KodNaPc + "_" + item["Broj"].ToString() + "_" + "_" + item["tblUserID"].ToString();
                            kodNaDokument += "_FAK";
                            if (cl.ZapisiFakturi(db, kodNaDokument))
                            {


                                using (SqlConnection con = new SqlConnection(settings.konekcija))
                                {
                                    using (SqlCommand com = new SqlCommand(string.Format("Update {0} set KodNaDokument = '{1}' where ID={2}", item.Table.TableName, kodNaDokument, fakturaId), con))
                                    {
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }
                        }


                        db.Dispose();
                    }
                    MessageBox.Show("Фактурите се успешно префрлени");
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
        }

        private void затворањеНаДенToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settings.NivelaCijaNaKrajNaDen.ToUpper() == "TRUE")
            {
                DataTable smetki = Tools.NeProknizeniSmetki();
                if (smetki != null)
                {
                    DataTable artikli = new DataTable();
                    foreach (DataRow item in smetki.Rows)
                    {
                        //Za svaka smetka artiktli
                    }

                    var rez = DialogResult.OK;

                    if (artikli.Rows.Count > 0 && smetki.Rows.Count > 0)
                    {
                        Form frmNIvelazijaStart = new Form();
                        rez = frmNIvelazijaStart.ShowDialog();
                        //nivelacija
                        if (rez == DialogResult.OK)
                        {

                        }
                        else
                        {
                            return;
                        }

                    }

                    if (rez == DialogResult.OK)
                    {



                        //ProkniziSmetki
                        smetki = Tools.NeProknizeniSmetki();
                        foreach (DataRow item in smetki.Rows)
                        {
                            Tools.ProkniziSmetka(Tools.PrazenStringToInt(item["ID"].ToString()));
                        }

                        //Zatvori  fiskalna 

                    }
                }

            }




        }

        private void кДФИОбразецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmKDFI() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = кДФИОбразецToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void даденРабатПоДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmDadenRabatPoDen() { MdiParent = ActiveForm, Text = даденРабатПоДенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void салдоНаПартнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPlacanjaOdPartner() { MdiParent = ActiveForm, Text = салдоНаПартнерToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void наплатаОдПартнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }

            _izvodi.ShowDialog();
        }


        private void заПрограматаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            using (var glavnaForma = new AboutBox() { Text = заПрограматаToolStripMenuItem.Text, WindowState = FormWindowState.Normal, StartPosition = FormStartPosition.CenterScreen })
                glavnaForma.ShowDialog();
        }

        private void нарачкиОдКлиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmNarackiVnes() { MdiParent = ActiveForm, Text = нарачкиОдКлиентиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void прегледНаНарачкиПоДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaNarackiZaDen() { MdiParent = ActiveForm, Text = прегледНаНарачкиПоДенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }



        private void сетирајHeaderPf550ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.OnScreenKeyNaSveDugminjaBoard = true;
                string[] linii = new string[4];

                for (int i = 0; i < 4; i++)
                {

                    var rez = InputBox.Show("Внесете текст за header линија " + (1 + i).ToString(), false, false);
                    settings.OnScreenKeyNaSveDugminjaBoard = false;
                    settings.OnScreenKeyBoard = false;

                    if (!string.IsNullOrEmpty(rez.Text))
                    {
                        linii[i] = rez.Text;

                    }
                    else
                    {
                        linii[i] = " ";
                    }


                    // fiskalna.CloseInterface();
                }

                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                fiskalna.SetirajHeaderPf550(linii);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Настана грешка , има проблем со фискалната");
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        private void салдоНаСитеПартнериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmDolziPobaruvaSitePartneri() { MdiParent = ActiveForm, Text = toolStripMenuItem24.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void листаНаДоспеаниФактуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmDospeaniFakturi() { MdiParent = ActiveForm, Text = листаНаДоспеаниФактуриToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void модулЗаМатеријалнаЕвиденцијаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }

            _priem.ShowDialog();
        }

        private void електронскиПриемНаДокументиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi)
                if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                    {
                        ActiveMdiChild.Close();
                    }
            var glavnaForma = new frmElektronskiPriemNaDokumenti() { MdiParent = ActiveForm, Text = електронскиПриемНаДокументиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmIzvestajPriemi { MdiParent = ActiveForm, Text = извештајНабавениToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void интерниДокументиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi)
                if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                    {
                        ActiveMdiChild.Close();
                    }

            _interni.ShowDialog();
        }

        private void прегледПоТипНаДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledPoTipNaDokument { MdiParent = ActiveForm, Text = btnSpecifikacijaNadokumenti.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void интернетКафеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            //if (settings.TipNaPrograma == "8889")
            //{

            //    _internetKafe.ShowDialog();
            //}

        }

        private void frmSettings_Shown(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
           
            
            CreateObjects();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Debug.Write($"Startup Time : {elapsedMs}");
            
        }

        private void ShowTextModalForm(string text)
        {
            var frm = new Form();
            frm.Text = "Информација";
            frm.Size = new Size(640, 480);
            frm.StartPosition = FormStartPosition.CenterScreen;
            var label  = new Label() { Text = text, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            label.Font = new Font("Arial", 15, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            frm.Controls.Add(label);
            frm.ShowDialog();
        }

        private async Task<bool> isLicenceValidAsync()
        {
            try
            {
                var licStringUrl = settings.ServerT.toNormalString()
                                    .Replace("@p1", settings.ImeNaMojServer)
                                    .Replace("@p2", settings.ServerNameToSync_API)
                                    .Replace("@p3", settings.TipNaPrograma);

                var resultsFromWeb = await Tools.GetValueFromWebAsync(licStringUrl).ConfigureAwait(true);

                var clientInfoResult = JsonConvert.DeserializeObject<ClientInfo>(resultsFromWeb.ToString());

                if (clientInfoResult == null)
                {
                    return true;
                }


                if (!string.IsNullOrEmpty(clientInfoResult.SendMessageToClientOnNextLogin))
                {
                    Invoke(new Action(() => ShowTextModalForm(Text = clientInfoResult.SendMessageToClientOnNextLogin)));
                }

                if (!string.IsNullOrEmpty(clientInfoResult.Message))
                {
                    Invoke(new Action(() => ShowTextModalForm(Text = clientInfoResult.Message)));
                }

                if (clientInfoResult.ValidLicence.HasValue && !clientInfoResult.ValidLicence.Value)
                {
                    return false;
                }

                if (!string.IsNullOrEmpty(clientInfoResult.Settings) && clientInfoResult.Settings.Contains("UpdateForce=True"))
                {
                    Tools.UpdateSoftware();
                }
            }
            catch (Exception ex)
            {
                //Tools.LogExceptionMessageWithScreenShoot(ex, "Lic");
                Tools.LogWriteText(ex.Message);
            }

            return true;
        }


        List<ToolStripMenuItem> _myItems;
        public void CreateQuickButtons()
        {
            quickFlow.Controls.Clear();

            _myItems = GetAllMenuStripItems.GetItems(menuStrip1);

            foreach (ToolStripMenuItem item in _myItems)
            {
                if (item.Tag != null)
                    if (item.Tag.ToString() == "Quick" && item.Available && item.OwnerItem.Available)
                    {
                        Button b = new Button();
                        if (!string.IsNullOrEmpty(item.ShortcutKeys.ToString()))
                        {
                            b.Text = item.Text + "( " + item.ShortcutKeys.ToString() + " )";
                        }
                        else
                        {
                            b.Text = item.Text;
                        }
                        b.Name = item.Name;
                        // b.ForeColor = Color.FromArgb(0, 149, 144);
                        b.FlatStyle = FlatStyle.Flat;
                        b.Image = item.Image;
                        b.MinimumSize = new Size(200, 50);
                        b.TextAlign = ContentAlignment.TopLeft;
                        b.ImageAlign = ContentAlignment.BottomRight;
                        b.Click += b_Click;
                        quickFlow.Controls.Add(b);
                    }

                if (item.Tag != null )
                    if (item.Tag.ToString() == "Fiskalna" && item.Available
                        && tmpConfigs.MainActiveForms.Smetki == true)
                    {
                        Button b = new Button();
                        if (!string.IsNullOrEmpty(item.ShortcutKeys.ToString()))
                        {
                            b.Text = item.Text + "( " + item.ShortcutKeys.ToString() + " )";
                        }
                        else
                        {
                            b.Text = item.Text;
                        }
                        b.Name = item.Name;
                        // b.ForeColor = Color.FromArgb(0, 149, 144);
                        b.FlatStyle = FlatStyle.Flat;
                        b.Image = item.Image;
                        b.MinimumSize = new Size(200, 50);
                        b.TextAlign = ContentAlignment.TopRight;
                        b.ImageAlign = ContentAlignment.BottomLeft;
                        b.Click += b_Click;
                        flowLayoutPanel1.Controls.Add(b);
                    }
            }

            Application.DoEvents();
        }

        void b_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            _myItems.Where(c => c.Name == btn.Name).FirstOrDefault().PerformClick();

        }
        private void frmSettings_MdiChildActivate(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();

            if (Equals(ActiveMdiChild, null))
            {
                quickFlow.Visible = true;
                flowLayoutPanel1.Visible = true;

            }
            else
            {
                quickFlow.Visible = false;
                flowLayoutPanel1.Visible = false;
            }
        }

        private void книжењеНаСитеДокументиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да ги прокнижите сите документи ?"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                if (_bwKnizi.IsBusy != true)
                {
                    _bwKnizi.RunWorkerAsync();
                }
            }



        }

        private void пристапДоМодулиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblImeNaKorisnik_Click(object sender, EventArgs e)
        {

        }

        private void забелешкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmZabeleski() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = забелешкиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void prodazbaOdSmetki_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmProdazbaOdSmetki() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = prodazbaOdSmetki.Text };
            glavnaForma.Show();
        }

        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                излезToolStripMenuItem.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void прегледНаМоменталниКоличини_Click(object sender, EventArgs e)
        {
            var glavnaForma = new FrmPregledNaZalihaPoKolicina() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = прегледНаМоменталниКоличини.Text };
            glavnaForma.Show();

        }

        private void прегледНаДокументиЗаПартнер_Click(object sender, EventArgs e)
        {
            var glavnaForma = new FrmPreglednaDokumentiOdPartner() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = прегледНаДокументиЗаПартнер.Text };
            glavnaForma.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            Tools.ProkniziKolicini();
        }

        private void presmetkovniEdinici_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPresmetkovniEdicini() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = presmetkovniEdinici.Text };
            glavnaForma.Show();
        }

        private void прегледНаСметкиПоПартнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledNaSmetkiPoPartner() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = прегледНаСметкиПоПартнерToolStripMenuItem.Text };
            glavnaForma.Show();

        }

        private void прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledNaSmetkiPoPresmetkovnaEdinica() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = прегледНаСметкиПоПресметковнаЕдиницаToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void btnSpecifikacijaNadokumenti_Click(object sender, EventArgs e)
        {

            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledPoTipNaDokument { MdiParent = ActiveForm, Text = btnSpecifikacijaNadokumenti.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void прегледНаСитеСметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledNaSiteSmetki { MdiParent = ActiveForm, Text = прегледНаСитеСметкиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmKartickaNaKupecDobavauvac() { MdiParent = ActiveForm, Text = картичкаНаКупувачДобавувачToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaNaloziPoObjekt() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = прегледНаСитеНалозиToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void ПратиЗатворањеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _webApiSync.SendAllData();
        }

        private void ПревземиОтворањеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _webApiSync.GetAllData();
        }

        private void СинхронизирајToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _webApiSync.SyncAllData();
            _bwKnizi.RunWorkerAsync();
        }

        private void ПрегледНаСитеСметкиТретаСменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaSmetkiTretaSmena { MdiParent = ActiveForm, Text = прегледНаСитеСметкиТретаСменаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }


        private void EnableAllMenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rez = InputBox.Show("Внесете лозинка", true, true);
            if (rez.ReturnCode == DialogResult.OK && rez.Text != null)
            {
                if (rez.Text == "7625")
                {
                    tmpConfigs.MainActiveForms = new tmpConfigs.ActiveForms();
                    tmpConfigs.MainActiveForms.Priem = true;
                    tmpConfigs.MainActiveForms.Fakturi = true;
                    tmpConfigs.MainActiveForms.Interni = true;
                    tmpConfigs.MainActiveForms.Smetki = true;


                    _kelner = new MKelner.Forms.frmKelner(UserFullName, UserLevel) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                    _kasa = new MKelner.Forms.frmKelner(UserFullName, UserLevel, true) { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
                  
                    _priem = new MMaterijalno.frmPriem() { Text = модулЗаМатеријалнаЕвиденцијаToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
                    _interni = new frmInterniDokumenti() { Text = интерниДокументиToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
                    _fakturi = new MFakturi.frmFaktura() { Text = модулЗаФактуриToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
                    _izvodi = new frmIzvodi() { Text = наплатаОдПартнерToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };

                    List<ToolStripMenuItem> myItems = GetAllMenuStripItems.GetItems(this.menuStrip1);
                    foreach (var item in myItems)
                    {
                        item.Enabled = true;
                        item.Visible = true;
                    }
                    CreateQuickButtons();
                    //List<ToolStripMenuItem> downItems = GetAllMenuStripItems.GetItems(this.toolStripDropDownButton1);
                    //foreach (var item in downItems)
                    //{
                    //    item.Enabled = true;
                    //    item.Visible = true;
                    //}
                }
            }
        }

        private void прегледПоТипНаДокументToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledPoTipNaDokumentZbiren { MdiParent = ActiveForm, Text = прегледПоТипНаДокументToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPregledNaSiteSmetkiGrupirani { MdiParent = ActiveForm, Text = toolStripMenuItem10.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void restoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "BSSR Backup files (*.BAK)|*.bak|All files (*.*)|*.*";
            fileDialog.ShowDialog();
            if (File.Exists(fileDialog.FileName))
            {
                DBAccess.RestoreDatabase(fileDialog.FileName);
            }
        }

        private void restoreRegistriConfigFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbFunctions.reWriteConfigsFromDB();
            settings.InitSettings.ReloadAllConfigs();
        }

        private void reloadCurrentRegistiSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.InitSettings.ReloadAllConfigs();
        }

        private void вчитајГиПовторноСетинзитеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.InitSettings.ReloadAllConfigs();
            MessageBox.Show(Tools.PrevediPoraka("VcituvanjeNaSetinziteUspesno"));
        }

        private void сетирањеНаПринтерToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Одберете дефаулт принтер ");
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
            var newPrinter = printDialog.PrinterSettings.PrinterName;
            settings.PrinterPathDefault = newPrinter;
            settings.InitSettings.SaveRegSettings("DefaultPrinter", newPrinter);

            MessageBox.Show("Одберете втор принтер ");

            PrintDialog printDialog2 = new PrintDialog();
            printDialog2.ShowDialog();
            var newPrinter2 = printDialog2.PrinterSettings.PrinterName;
            settings.PrinterPathDefault = newPrinter2;
            settings.InitSettings.SaveRegSettings("PrinterZaKujna", newPrinter2);

            settings.InitSettings.ReloadAllConfigs();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {

            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmListaNaDolznici { MdiParent = ActiveForm, Text = toolStripMenuItem20.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void печатењеИМаилToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPotpisiIPrati form = new frmPotpisiIPrati();
            form.ShowDialog();
        }

        private void деталенПрегледНаЛагерЛистаПОПИСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new frmPopis() { MdiParent = ActiveForm, Text = даденРабатПоДенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized };
            glavnaForma.Show();
        }

        private void PotrosuvackaMeniGrouped_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPotroseniMaterijaliGrupirani() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = PotrosuvackaMeniGrouped.Text };
            glavnaForma.Show();
        }

        private void прегледПлаќањаНаПартнерПоДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MReport.Forms.frmPregledNaPlacanjePoDokument() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = прегледПлаќањаНаПартнерПоДокументToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void печатењеИМаилToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void договориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.IskluciPovekjeFormi) if (!Equals(ActiveMdiChild, null))
                {
                    ActiveMdiChild.Close();
                }
            var glavnaForma = new MMaterijalno.Forms.frmDogovori() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = договориToolStripMenuItem.Text };
            glavnaForma.Show();
        }

        private void прегледПоДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var glavnaForma = new frmPreglednaDokumentiPoDogovor() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = прегледНаДокументиЗаПартнер.Text };
            glavnaForma.Show();
        }

        private void GodiSenPregled_Click(object sender, EventArgs e)
        {
            var glavnaForma = new frmPregledNaGodisnoSaldo() { MdiParent = ActiveForm, WindowState = FormWindowState.Maximized, Text = GodiSenPregled.Text };
            glavnaForma.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BssBase;
using SHANUPADUC;

namespace MKelner.Forms
{
    public partial class frmKelner : frmBaseApp
    {
        public string MasaBrojPrint = string.Empty;
        public int SmetkaID = -1;
        public int GrupaID, PodgrupaID = -1;
        public string Keywords;

        public string UserName;
        private Utility.ModifyRegistry.ModifyRegistry RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
        private bool Kasa = false;

        public frmKelner(string userName, int userLevel, bool kasa)
        {
            RegistryData.SubKey = settings.RegPath;
            Kasa = kasa;
            ShowInTaskbar = false;
            cfg.brojNaArtikliDisplay = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplay"), cfg.brojNaArtikliDisplay);
            cfg.brojNaArtikliDisplayMalku = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplayMalku"), cfg.brojNaArtikliDisplay);
            cfg.sirinaNaBack = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaBack"), cfg.sirinaNaBack);
            cfg.sirinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaDugminjaGore"), cfg.sirinaNaDugminjaGore);
            cfg.VisinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaDugminjaGore"), cfg.VisinaNaDugminjaGore);
            cfg.BrojNaKopcinjaSmetka = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopcinjaSmetka"), cfg.BrojNaKopcinjaSmetka);

            cfg.brojNaDugminjaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("brojNaDugminjaNaArtikal"), cfg.brojNaDugminjaNaArtikal);
            cfg.SirinaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("SirinaNaArtikal"), cfg.SirinaNaArtikal);
            cfg.VisinaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaArtikal"), cfg.VisinaNaArtikal);

            //2.0

            cfg.FontSizeArtikal = Tools.PrazenStringToInt(RegistryData.Read("FontSizeArtikal"), cfg.FontSizeArtikal);
            cfg.TextAligmentArtikal = Tools.PrazenStringToInt(RegistryData.Read("TextAligmentArtikal"), cfg.TextAligmentArtikal);
            cfg.ImageAligmentArtikal = Tools.PrazenStringToInt(RegistryData.Read("ImageAligmentArtikal"), cfg.ImageAligmentArtikal);

            cfg.FontSizeDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("FontSizeDugminjaGore"), cfg.FontSizeDugminjaGore);
            cfg.TextAligmentDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("TextAligmentDugminjaGore"), cfg.TextAligmentDugminjaGore);
            cfg.ImageAligmentDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("ImageAligmentDugminjaGore"), cfg.ImageAligmentDugminjaGore);

            cfg.PatekaDoLogo = RegistryData.Read("PatekaDoLogo", string.Empty);
            cfg.ArtikalTextColor = RegistryData.Read("ArtikalTextColor", string.Empty);

            settings.NeSreduajMeni = true;

            settings.RazlicniBoiNaRedicVoGrid = false;
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            //Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            InitializeComponent();

            UserName = userName;
            TekstZaIzmenetNalog = string.Empty;

            фискалниПодесувањаToolStripMenuItem.Visible = true;


            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            пребарувањеВоАртиклиToolStripMenuItem.Visible = true;
            tmpBrojNaArtikli = cfg.brojNaArtikliDisplay;
        }
        public int _userLevel;
        public DataTable ListaSoArtikliNaAkcija;
        public frmKelner(string userName, int userLevel)
        {
            RegistryData.SubKey = settings.RegPath;
            cfg.brojNaArtikliDisplay = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplay"), cfg.brojNaArtikliDisplay);
            cfg.brojNaArtikliDisplayMalku = Tools.PrazenStringToInt(RegistryData.Read("brojNaArtikliDisplayMalku"), cfg.brojNaArtikliDisplay);
            cfg.sirinaNaBack = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaBack"), cfg.sirinaNaBack);
            cfg.sirinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("sirinaNaDugminjaGore"), cfg.sirinaNaDugminjaGore);
            cfg.VisinaNaDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaDugminjaGore"), cfg.VisinaNaDugminjaGore);
            cfg.BrojNaKopcinjaSmetka = Tools.PrazenStringToInt(RegistryData.Read("BrojNaKopcinjaSmetka"), cfg.BrojNaKopcinjaSmetka);

            cfg.brojNaDugminjaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("brojNaDugminjaNaArtikal"), cfg.brojNaDugminjaNaArtikal);
            cfg.SirinaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("SirinaNaArtikal"), cfg.SirinaNaArtikal);
            cfg.VisinaNaArtikal = Tools.PrazenStringToInt(RegistryData.Read("VisinaNaArtikal"), cfg.VisinaNaArtikal);

            //2.0

            cfg.FontSizeArtikal = Tools.PrazenStringToInt(RegistryData.Read("FontSizeArtikal"), cfg.FontSizeArtikal);
            cfg.TextAligmentArtikal = Tools.PrazenStringToInt(RegistryData.Read("TextAligmentArtikal"), cfg.TextAligmentArtikal);
            cfg.ImageAligmentArtikal = Tools.PrazenStringToInt(RegistryData.Read("ImageAligmentArtikal"), cfg.ImageAligmentArtikal);

            cfg.FontSizeDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("FontSizeDugminjaGore"), cfg.FontSizeDugminjaGore);
            cfg.TextAligmentDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("TextAligmentDugminjaGore"), cfg.TextAligmentDugminjaGore);
            cfg.ImageAligmentDugminjaGore = Tools.PrazenStringToInt(RegistryData.Read("ImageAligmentDugminjaGore"), cfg.ImageAligmentDugminjaGore);

            cfg.PatekaDoLogo = RegistryData.Read("PatekaDoLogo", string.Empty);
            cfg.ArtikalTextColor = RegistryData.Read("ArtikalTextColor", string.Empty);

            settings.NeSreduajMeni = true;

            settings.RazlicniBoiNaRedicVoGrid = false;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            Thread.CurrentThread.CurrentCulture = Tools.GetSystemGlobalizationCulture();
            InitializeComponent();

            splitContainer3.Panel1Collapsed = false;

            Application.DoEvents();
            ArtikliDataSet.Tables.Add(NapolniArtikli());
            ZemiGlavniGrupi();
            ZemiPodgrugiNaArtikli();
            ZemiKeywords();
            Application.DoEvents();

            UserName = userName;
            TekstZaIzmenetNalog = string.Empty;

            фискалниПодесувањаToolStripMenuItem.Visible = true;

            _userLevel = userLevel;
            if (!string.IsNullOrEmpty(settings.eKujna))
            {
                if (settings.eKujna.Contains("1"))
                {
                    btnPecatiNalog.Visible = false;
                }
            }

            if (settings.TipNaPrograma == "888")
            {
                btnPecatiNalog.Visible = false;
            }

            if (!settings.PrikaziBiranjeNaTipNaSmetka)
            {
                GrouptipNaFiskalna.Visible = false;
                if (settings.TipNaPrograma == "88")
                {
                    GrouptipNaFiskalna.Controls.Clear();
                    GrouptipNaFiskalna.Text = string.Empty;

                    Button Dokument = new Button();
                    Dokument.Text = "Расход";
                    Dokument.Dock = DockStyle.Fill;
                    Dokument.TextAlign = ContentAlignment.BottomCenter;
                    Dokument.Image = Properties.DResources.pecati;
                    Dokument.Click += Dokument_Click;
                    GrouptipNaFiskalna.Controls.Add(Dokument);
                    GrouptipNaFiskalna.Visible = true;
                }
            }

            пребарувањеВоАртиклиToolStripMenuItem.Visible = true;
            tmpBrojNaArtikli = cfg.brojNaArtikliDisplay;

            ListaSoArtikliNaAkcija = new DataTable();

            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(" select * from tblAkcijaNaArtikal where CAST(@Datum as DATE) Between DatumPocetok and DatumKraj order by ID  desc", con))
                {
                    con.Open();
                    
                    com.Parameters.AddWithValue("@Datum", DateTime.Now);
                    ListaSoArtikliNaAkcija.Load(com.ExecuteReader());

                }

            }
        }


        void Dokument_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате оваа сметка да ја префрлите во расход ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                    {
                        try
                        {
                            
                            com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                            com.Parameters.AddWithValue("@SoPopust", false);
                            com.Parameters.AddWithValue("@Popust", 0);
                            com.Parameters.AddWithValue("@FirmaID", settings.firmaId);

                            con.Open();
                            com.ExecuteNonQuery();

                            var asm = System.Reflection.Assembly.Load("MMaterijalno");
                            var t = asm.CreateInstance("MMaterijalno.Forms.frmObrabotkaNaInterniDokumenti", true).GetType();
                            var frm = (Form)Activator.CreateInstance(t, new object[] { SmetkaID, true });
                            opc = frm.ShowDialog();

                            prikaziSmetki();
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            return;
                        }
                    }
                }
            }
        }

        private void frmKelner_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ги избришете селектираните ставки ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)

                foreach (DataGridViewRow item in grdArtikli.Rows)
                {
                    bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (value)
                    {
                        using (SqlConnection con = new SqlConnection(settings.konekcija))
                        {
                            using (SqlCommand com = new SqlCommand("Exec brisiArtikal @NalogID, @ArtikalID, @smetka", con))
                            {
                                try
                                {
                                    
                                    com.Parameters.AddWithValue("@NalogID", NalogIDZaInsert);
                                    com.Parameters.AddWithValue("@smetka", SmetkaID);
                                    com.Parameters.AddWithValue("@ArtikalID", item.Cells["Artikal"].Value);
                                    con.Open();
                                    com.ExecuteNonQuery();
                                }
                                catch (SqlException ex)
                                {
                                    Tools.PrevediSQLException(ex);
                                    return;
                                }
                            }
                        }
                    }
                }
            //
            Kolicina = 1;
            ArtikliZaNalog(NalogIDZaInsert);
            NaloziZaSmetka(SmetkaID);

            if (BssBase.settings.TipNaPrograma != "88")
                MessageBox.Show("Ставките се избришани, податоците се освежени");
        }

        private void frmKelner_Load(object sender, EventArgs e)
        {
            refreshSmetkiTimer.Enabled = true;
            if (!Kasa)
            {
                prikaziSmetki();
                Application.DoEvents();
                Task.Run(() =>
                {
                   
                    if (settings.novaSmetkaNaStartNaKelner)
                    {
                        KreirajSmetka();
                        splitContainer4.Panel1.Invoke((MethodInvoker)(() =>
                        {
                            splitContainer4.Panel1.Enabled = true;
                            splitContainer4.Panel1Collapsed = false;
                        }));
                        NapolniOtvorenaSmetka(SmetkaID);
                        KreirajDugminjaZaGrupiNaArtikli();
                    }
                });
            }
            else
            {
                prikaziSmetkiKasa();
                
            }
        }

        public DataTable NapolniArtikli()
        {
            var artikli = new DataTable("Artikli");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"select * from viewArtikaliNormativi where status is null or status <> 1 AND status <> 3 and FirmaID = @FirmaID order by RedenBroj", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        artikli.Load(com.ExecuteReader());
                        var list = artikli.AsEnumerable()
                            .Select(r => r.Field<string>("Naziv")).ToArray();
                        var collection = new AutoCompleteStringCollection();
                        collection.AddRange(list);
                        txtSearch.AutoCompleteCustomSource = collection;
                        txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

                        return artikli;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        public DataTable NapolniGrupiNaArtikli()
        {
            var Grupi = new DataTable("Grupi");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("select * from tblGrupaNaArtikli where FirmaID = @FirmaID and (Status is null OR Status = 0) Order by Sifra", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        Grupi.Load(com.ExecuteReader());
                        return Grupi;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        public DataTable NapolniKeyWords()
        {
            var keywords = new DataTable("KeyWords");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"select Distinct LTRIM(RTRIM(KlucniZborovi)) as KlucniZborovi  , PodgrupaID from tblArtikal
Where  FirmaID = @FirmaID and (Status is null OR Status = 0) and KlucniZborovi is not null and LTRIM(RTRIM(KlucniZborovi)) <> ' '
union all
select Distinct LTRIM(RTRIM(KlucniZborovi)) as KlucniZborovi  , PodgrupaID from tblNormativ
Where  FirmaID = @FirmaID and (Status is null OR Status = 0) and KlucniZborovi is not null and LTRIM(RTRIM(KlucniZborovi)) <> ' '
", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        keywords.Load(com.ExecuteReader());
                        return keywords;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        public DataTable NapolniPodGrupiNaArtikli()
        {
            var PodGrupi = new DataTable("PodGrupi");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("select * from tblPodgrupaID where FirmaID = @FirmaID and (Status is null OR Status = 0) ", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        PodGrupi.Load(com.ExecuteReader());
                        return PodGrupi;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        public int KreirajSmetka(string kodNaDokument = "")
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"INSERT INTO tblSmetka (Broj,tblUserID,Smena_ID,FirmaID,ObjektID,KodNaDokument)
						VALUES ((Select dbo.NaredeBrojNaSmetka()),@tblUserID,@Smena_ID,@FirmaID,@ObjektID,@KodNaDokument) Select @@IDENTITY", con))
                {
                    try
                    {
                       
                        
                        com.Parameters.AddWithValue("@tblUserID", settings.UserId);
                        com.Parameters.AddWithValue("@Smena_ID", settings.UserId);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        com.Parameters.AddWithValue("@ObjektID", settings.MomentalenObjektID);
                        com.Parameters.AddWithValue("@KodNaDokument", kodNaDokument);
                        con.Open();
                        var rez = com.ExecuteScalar().ToString();
                        if (!Equals(rez, null))
                        {
                            SmetkaID = Tools.PrazenStringToInt(rez.ToString());
                            NalogIDZaInsert = KreirajNovNalog(SmetkaID, 0);
                            NapolniOtvorenaSmetka(SmetkaID);
                            return SmetkaID;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return -1;
                    }
                }
            }
            return -1;
        }

        public DataTable PrikazigiSiteArtikliODSiteNalozi(int smetkaID)
        {
            if (ArtikliDataSet.Tables.Contains("ArtikliSite"))
            {
                ArtikliDataSet.Tables.Remove("ArtikliSite");
            }
            var artikli = new DataTable("ArtikliSite");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"exec StavkiVoSmetkaTouch @SmetkaID", con))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@SmetkaID", smetkaID);
                        con.Open();
                        artikli.Load(com.ExecuteReader());
                        grdArtikli.DataSource = artikli;
                        return artikli;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
              
            }
        }

        public DataTable ArtikliZaNalog(int NalogID)
        {
            if (ArtikliDataSet.Tables.Contains("ArtikliNalog"))
            {
                ArtikliDataSet.Tables.Remove("ArtikliNalog");
            }
            var artikli = new DataTable("ArtikliNalog");
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"exec StavkiVoNalog " + NalogID, con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@ID", SmetkaID);
                        ArtikliDataSet.Tables.Add("ArtikliNalog");
                        con.Open();
                        ArtikliDataSet.Tables["ArtikliNalog"].Load(com.ExecuteReader());

                        grdArtikli.DataSource = ArtikliDataSet.Tables["ArtikliNalog"];
                        //grdArtikli.Columns["Artikal"].HeaderText = "Реден број";
                        //grdArtikli.Columns["Artikal"].Visible = false;
                        //grdArtikli.Columns["Zabeleska"].HeaderText = "Забелешка";
                        //grdArtikli.Columns["Zabeleska"].Visible = false;
                        //grdArtikli.Columns["NalogID"].HeaderText = "Реден број Нарачка";
                        //grdArtikli.Columns["NalogID"].Visible = false;
                        //grdArtikli.Columns["Sifra"].HeaderText = "Шифра";
                        //grdArtikli.Columns["Sifra"].Visible = false;
                        //grdArtikli.Columns["Tip"].HeaderText = "Тип";
                        //grdArtikli.Columns["Tip"].Visible = false;
                        //grdArtikli.Columns["ProdaznaCena"].HeaderText = "Цена";
                        //grdArtikli.Columns["ProdaznaCena"].Visible = false;
                        //grdArtikli.Columns["Naziv"].HeaderText = "Артикал";
                        //grdArtikli.Columns["Naziv"].DefaultCellStyle.Font = new System.Drawing.Font(grdArtikli.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Regular);
                        //grdArtikli.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        //grdArtikli.Columns["Kolicina"].HeaderText = "Кол.";
                        //grdArtikli.Columns["Kolicina"].DefaultCellStyle.Format = "N0";
                        //grdArtikli.Columns["Kolicina"].DefaultCellStyle.Font = new System.Drawing.Font(grdArtikli.DefaultCellStyle.Font.FontFamily, 12);
                        //grdArtikli.Columns["Kolicina"].Width = 40;
                        //grdArtikli.Columns["Kolicina"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        //grdArtikli.Columns["Iznos"].DefaultCellStyle.Font = new System.Drawing.Font(grdArtikli.DefaultCellStyle.Font.FontFamily, 12);
                        //grdArtikli.Columns["Iznos"].HeaderText = "Износ";

                        return artikli;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        public DataTable NaloziZaSmetka(int smetkaID, bool kreirajNov = true)
        {
            SmetkaID = smetkaID;
            if (ArtikliDataSet.Tables.Contains("Nalozi"))
            {
                ArtikliDataSet.Tables.Remove("Nalozi");
            }

            var Nalozi = new DataTable("Nalozi");
            ArtikliDataSet.Tables.Add(Nalozi);
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"exec Nalozi @ID", con))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@ID", SmetkaID);
                        con.Open();
                        using (var reader = com.ExecuteReader())
                        {
                            Nalozi.Load(reader);
                        }

                        var bs = new BindingSource(ArtikliDataSet, "Nalozi");
                        grdNalozi.DataSource = bs;

                        bs.MoveLast();
                        if (grdNalozi.CurrentRow != null)
                        {
                            var nalogID = Tools.PrazenStringToInt(grdNalozi.CurrentRow.Cells["ID"].Value.ToString());
                            if (grdNalozi.CurrentRow.Cells["Status"].Value.ToString() == "0")
                            {
                                NalogIDZaInsert = nalogID;
                            }
                            else
                            {
                                NalogIDZaInsert = -1;
                            }
                            ArtikliZaNalog(nalogID);
                        }

                        if (ArtikliDataSet.Tables["Nalozi"].Select("Status = 0").Length == 0 && kreirajNov)
                        {
                            KreirajNovNalog(SmetkaID, 0);
                        }

                        return Nalozi;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        private string MomentalaZabeleska;

        public void setirajZabeleskaZaSmetka(string Zabeleska)
        {
            MomentalaZabeleska = Zabeleska;

        }

        public void SetirajZabeleska(string txt)
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("update tblSmetka set Zabeleska = @txt where ID = @ID", con))
                {
                    con.Open();
                    
                    com.Parameters.AddWithValue("@ID", SmetkaID);
                    com.Parameters.AddWithValue("@txt", txt);
                    com.ExecuteNonQuery();
                    setirajZabeleskaZaSmetka(txt);
                }
            }

        }
        public DataTable NapolniOtvorenaSmetka(int SmetkaID)
        {
            splitContainer2.Panel2Collapsed = false;
            VkupnoNaloziTextGore.Visible = true;
            прегледиИИзвештаиToolStripMenuItem.Visible = true;
            if (settings.TipNaPrograma == "8" || settings.TipNaPrograma == "88" || settings.TipNaPrograma == "888")
            {
                печатењеНаДокументиToolStripMenuItem.Visible = true;
            }
            if (settings.TipNaPrograma == "888")
            {
                интеренДокументToolStripMenuItem.Visible = false;
            }


            smetkTextGore.Visible = true;
            //			ToolKomandi.Visible = false;
            if (ArtikliDataSet.Tables.Contains("Smetki"))
            {
                ArtikliDataSet.Tables.Remove("Smetki");
            }
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"Select ID,Broj,KodNaDokument from tblSmetka where ID = @ID", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@ID", SmetkaID);
                        ArtikliDataSet.Tables.Add("Smetki");
                        con.Open();
                        ArtikliDataSet.Tables["Smetki"].Load(com.ExecuteReader());

                        
                        NaloziZaSmetka(SmetkaID);

                        PrikazigiSiteArtikliODSiteNalozi(SmetkaID);
                        grdNalozi.Columns["ID"].HeaderText = Tools.PrevediPoraka("Реден број");
                        grdNalozi.Columns["ID"].Visible = false;
                        grdNalozi.Columns["Status"].HeaderText = Tools.PrevediPoraka("Статус");
                        grdNalozi.Columns["Status"].Visible = false;
                        grdNalozi.Columns["Broj"].HeaderText = Tools.PrevediPoraka("Број на нарачкa");
                        grdNalozi.Columns["Broj"].DefaultCellStyle.Format = "D4";
                        grdNalozi.Columns["Broj"].ToolTipText = "Десен клик за администраторски измени";
                        grdNalozi.Columns["Zabeleska"].HeaderText = " ";
                        grdNalozi.Columns["Zabeleska"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        grdNalozi.Columns["Zabeleska"].Visible = false;
                        grdNalozi.Columns["Suma"].HeaderText = Tools.PrevediPoraka("Сума");
                        grdNalozi.Columns["Suma"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        grdNalozi.prikaziMeniSoExportiranja = false;
                        grdNalozi.zameniMeni(contextMenuStrip1);
                        //
                        grdArtikli.Columns["Artikal"].HeaderText = Tools.PrevediPoraka("Реден број");
                        grdArtikli.Columns["Artikal"].Visible = false;
                        grdArtikli.Columns["Zabeleska"].HeaderText = Tools.PrevediPoraka("Забелешка");
                        grdArtikli.Columns["Zabeleska"].Visible = false;
                        grdArtikli.Columns["NalogID"].HeaderText = Tools.PrevediPoraka("Реден број нарачка");
                        grdArtikli.Columns["NalogID"].Visible = false;
                        grdArtikli.Columns["Sifra"].HeaderText = Tools.PrevediPoraka("Шифра");
                        grdArtikli.Columns["Sifra"].Visible = false;
                        grdArtikli.Columns["Tip"].HeaderText = Tools.PrevediPoraka("Тип");
                        grdArtikli.Columns["Tip"].Visible = false;
                        grdArtikli.Columns["ProdaznaCena"].HeaderText = Tools.PrevediPoraka("Цена");
                        grdArtikli.Columns["ProdaznaCena"].Visible = false;
                        grdArtikli.Columns["Naziv"].HeaderText = Tools.PrevediPoraka("Артикал");
                        grdArtikli.Columns["Naziv"].DefaultCellStyle.Font = new Font(grdArtikli.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Regular);
                        grdArtikli.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        grdArtikli.Columns["Kolicina"].HeaderText = Tools.PrevediPoraka("Кол.");
                        grdArtikli.Columns["Kolicina"].DefaultCellStyle.Format = "N2";
                        grdArtikli.Columns["Kolicina"].DefaultCellStyle.Font = new Font(grdArtikli.DefaultCellStyle.Font.FontFamily, 12);
                        grdArtikli.Columns["Kolicina"].Width = 50;
                        grdArtikli.Columns["Kolicina"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        grdArtikli.Columns["Iznos"].DefaultCellStyle.Font = new Font(grdArtikli.DefaultCellStyle.Font.FontFamily, 12);
                        grdArtikli.Columns["Iznos"].HeaderText = Tools.PrevediPoraka("Износ");

                        grdArtikli.getMenu().Items.Clear();
                        grdArtikli.prikaziMeniSoExportiranja = false;
                        grdArtikli.SetirajStikliranje();
                        grdArtikli.getMenu().Items["ProkniziSelektirani"].Text = Tools.PrevediPoraka("Избриши ги означените ставки");
                        grdArtikli.ContextMenuStrip.Items["ProkniziSelektirani"].Click += new EventHandler(frmKelner_Click);
                        txtSearch.Clear();
                        txtSearch.Focus();
                        if (ArtikliDataSet.Tables["Smetki"].Rows.Count > 0)
                        {
                            lblBrNaSmetka.Text = ArtikliDataSet.Tables["Smetki"].Rows[0]["Broj"].ToString();
                            if (ArtikliDataSet.Tables["Smetki"].Rows[0]["KodNaDokument"].ToString().Contains("BSS_"))
                            {
                                btnFiskalna.Visible = false;
                                btnPecatiNalog.Visible = true;

                            } else
                            {
                                btnFiskalna.Visible = true;
                                btnPecatiNalog.Visible = true;
                            }
                        }
                        return ArtikliDataSet.Tables["Smetki"];

                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return null;
                    }
                }
            }
        }

        public DataTable NapolniSmetkiZaUser(int userID = -1)
        {
            userID = userID == -1 ? settings.UserId : userID;
            var smetki = new DataTable("Smetki");

            using (var con = new SqlConnection(settings.konekcija))
            using (var com = new SqlCommand("select ID,Broj,DatumPocetok,Zabeleska," +
                "(SELECT isnull(SUM(Iznos),0) iznos FROM dbo.viewArtikliVoSmetkaKASA WHERE SmetkaID = ID) AS IznosNaSmetka from tblSmetka where tblUserID = @ID AND Zatvorena = 'false' AND ObjektID=@ObjektID order by ID asc", con))
            {
                com.Parameters.AddWithValue("@ID", userID);
                com.Parameters.AddWithValue("@ObjektID", settings.MomentalenObjektID);

                con.Open();
                smetki.Load(com.ExecuteReader());
            }

            return smetki;
        }

        public void prikaziSmetkiKasa()
        {
            SmetkiDs.Tables.Clear();
            SmetkiDs.Tables.Add(NapolniSmetkiZaUser());
            SmetkiDs.AcceptChanges();
            splitContainer4.Panel1Collapsed = true;
            splitContainer2.Panel2Collapsed = true;
            VkupnoNaloziTextGore.Visible = false;
            smetkTextGore.Visible = false;
            ToolKomandi.Visible = true;
            TekstZaIzmenetNalog = string.Empty;

            печатењеСо10ПопустToolStripMenuItem.Visible = false;
            печатењеСо5ПопустToolStripMenuItem.Visible = false;
            печатењеСо15ПопустToolStripMenuItem1.Visible = false;
            печатењеСо20ПопустToolStripMenuItem2.Visible = false;

            if (settings.TipNaPrograma == "8" || settings.TipNaPrograma == "88")
            {
                прегледиИИзвештаиToolStripMenuItem.Visible = true;
                печатењеНаДокументиToolStripMenuItem.Visible = false;
            }

            забелешкаЗаМасаToolStripMenuItem.Visible = false;
            забелешкаЗаНарачкаToolStripMenuItem.Visible = false;

            if (ArtikliDataSet.Tables.Contains("ArtikliNalog"))
            {
                ArtikliDataSet.Tables["ArtikliNalog"].Clear();
            }
            if (ArtikliDataSet.Tables.Contains("Nalozi"))
            {
                ArtikliDataSet.Tables["Nalozi"].Clear();
            }

            SmetkaID = -1;
            NalogIDZaInsert = -1;
            GrupaID = -1;
            PodgrupaID = -1;

            Keywords = string.Empty;
            lblSum.Text = string.Empty;
            lblSumaArtikli.Text = string.Empty;
            lblBrNaSmetka.Text = string.Empty;
            lblVkupnoKol.Text = string.Empty;
            GrupaKomande.Controls.Clear();
            var Naslov = new Label() { Text = String.Format("{0} \n\n  Вработен: {1}", settings.FirmaNaziv, UserName), TextAlign = ContentAlignment.MiddleCenter, Font = new Font(Font.FontFamily, 36, FontStyle.Italic), AutoSize = true, Dock = DockStyle.Fill };
            GrupaKomande.Controls.Add(Naslov);
            IscistiGlavniKomande();

            if (SmetkiDs.Tables["Smetki"].Rows.Count > 0)
            {
                splitContainer4.Panel1.Enabled = false;
            }
            GlavniKomande.Visible = false;
            btnSmetkaKasa smetka;
            var masa = 1;
            List<btnSmetkaKasa> smetkiKasa = new List<btnSmetkaKasa>();
            foreach (DataRow item in SmetkiDs.Tables["Smetki"].Rows)
            {
                smetka = new btnSmetkaKasa("Сметка бр: " + item["Broj"].ToString(), item["Broj"].ToString(), item["DatumPocetok"].ToString(), Tools.PrazenStringToInt(item["ID"].ToString()), (GlavniKomande.Size.Width / cfg.BrojNaKopcinjaSmetka) - 10, masa++, item["Zabeleska"].ToString());
                smetkiKasa.Add(smetka);
                
            }
            GlavniKomande.Controls.AddRange(smetkiKasa.ToArray());
            GlavniKomande.Controls.Add(new buttonNovaSmetkaKasa((GlavniKomande.Size.Width / cfg.BrojNaKopcinjaSmetka - 1) - 10, masa));
            GlavniKomande.Visible = true;
        }

        public void prikaziSmetki()
        {


            SmetkiDs.Tables.Clear();
            SmetkiDs.Tables.Add(NapolniSmetkiZaUser());
            SmetkiDs.AcceptChanges();

            splitContainer4.Panel1Collapsed = true;
            splitContainer2.Panel2Collapsed = true;
            VkupnoNaloziTextGore.Visible = false;
            smetkTextGore.Visible = false;
            ToolKomandi.Visible = true;
            TekstZaIzmenetNalog = string.Empty;

            печатењеСо10ПопустToolStripMenuItem.Visible = false;
            печатењеСо5ПопустToolStripMenuItem.Visible = false;
            печатењеСо15ПопустToolStripMenuItem1.Visible = false;
            печатењеСо20ПопустToolStripMenuItem2.Visible = false;

            забелешкаЗаМасаToolStripMenuItem.Visible = false;
            забелешкаЗаНарачкаToolStripMenuItem.Visible = false;

            if (ArtikliDataSet.Tables.Contains("ArtikliNalog"))
            {
                ArtikliDataSet.Tables["ArtikliNalog"].Clear();
            }
            if (ArtikliDataSet.Tables.Contains("Nalozi"))
            {
                ArtikliDataSet.Tables["Nalozi"].Clear();
            }
            SmetkaID = -1;
            NalogIDZaInsert = -1;
            GrupaID = -1;
            PodgrupaID = -1;
            Keywords = string.Empty;
            lblSum.Text = string.Empty;
            lblSumaArtikli.Text = string.Empty;
            lblBrNaSmetka.Text = string.Empty;
            lblVkupnoKol.Text = string.Empty;
            GrupaKomande.Controls.Clear();

            var Naslov = new Label() { Text = String.Format("{0} \n\n  Вработен: {1}", settings.FirmaNaziv, UserName), TextAlign = ContentAlignment.MiddleCenter, Font = new Font(Font.FontFamily, 36, FontStyle.Italic), AutoSize = true, Dock = DockStyle.Fill };
            GrupaKomande.Controls.Add(Naslov);

            IscistiGlavniKomande();

            if (SmetkiDs.Tables["Smetki"].Rows.Count > 0)
            {
                splitContainer4.Panel1.Enabled = false;
            }
            GlavniKomande.Visible = false;
            btnSmetka smetka;
            var masa = 1;


            List<btnSmetka> smetkiKelner = new List<btnSmetka>();
            foreach (DataRow item in SmetkiDs.Tables["Smetki"].Rows)
            {
              
                string formattedSumaNaSmetka = item["IznosNaSmetka"].toInt().ToString("N2");

                smetka = new btnSmetka("Сметка бр: " + item["Broj"].ToString(), item["Broj"].ToString(), item["DatumPocetok"].ToString(), Tools.PrazenStringToInt(item["ID"].ToString()), (GlavniKomande.Size.Width / cfg.BrojNaKopcinjaSmetka) - 10, masa++, item["Zabeleska"].ToString(), formattedSumaNaSmetka);
                smetkiKelner.Add(smetka);
                
            }
            GlavniKomande.Controls.AddRange(smetkiKelner.ToArray());
            if (settings.TipNaPrograma == "8" || settings.TipNaPrograma == "88")
            {
                прегледиИИзвештаиToolStripMenuItem.Visible = true;
                печатењеНаДокументиToolStripMenuItem.Visible = false;
            }

            if (settings.TipNaPrograma == "888")
            {
                прегледиИИзвештаиToolStripMenuItem.Visible = true;
                печатењеНаДокументиToolStripMenuItem.Visible = false;
            }


            GlavniKomande.Controls.Add(new buttonNovaSmetka((GlavniKomande.Size.Width / cfg.BrojNaKopcinjaSmetka - 1) - 10, masa));
            GlavniKomande.Visible = true;

        }

        public void ZemiGlavniGrupi()
        {
            if (ArtikliDataSet.Tables.Contains("Grupi"))
            {
                ArtikliDataSet.Tables.Remove("Grupi");
            }
            ArtikliDataSet.Tables.Add(NapolniGrupiNaArtikli());
        }

        public void ZemiPodgrugiNaArtikli()
        {
            if (ArtikliDataSet.Tables.Contains("PodGrupi"))
            {
                ArtikliDataSet.Tables.Remove("PodGrupi");
            }
            ArtikliDataSet.Tables.Add(NapolniPodGrupiNaArtikli());
        }

        public void ZemiKeywords()
        {
            if (ArtikliDataSet.Tables.Contains("KeyWords"))
            {
                ArtikliDataSet.Tables.Remove("KeyWords");
            }
            ArtikliDataSet.Tables.Add(NapolniKeyWords());
        }

        public void KreirajDugminjaZaGrupiNaArtikli()
        {

            if (ArtikliDataSet.Tables["Grupi"].Rows.Count > 0)
            {
                Application.DoEvents();
                GrupaKomande.Visible = false;
                GrupaKomande.Controls.Clear();

                List<btnGlavnaGrupa> grupa = new List<btnGlavnaGrupa>();

                foreach (DataRow item in ArtikliDataSet.Tables["Grupi"].Rows)
                {
                    var grupabtn = new btnGlavnaGrupa(String.Format("&{0}", item["Naziv"]), Tools.PrazenStringToInt(item["ID"].ToString()), item["Image"].ToString());
                    grupabtn.UseMnemonic = true;
                    grupa.Add(grupabtn);
                    
                }
                GrupaKomande.Controls.AddRange(grupa.ToArray());
                Application.DoEvents();
                GrupaKomande.Visible = true;
                PrikaziArtikliIliSmetki();
            }
            else
            {
                PrikaziArtikliIliSmetki();
            }
        }

        public void KreirajDugminjaZaPodGrupiNaArtikli(int grupaID)
        {
            if (ArtikliDataSet.Tables["PodGrupi"].Rows.Count > 0)
            {
                GrupaKomande.Controls.Clear();
                var back = new butBack();
                GrupaKomande.Controls.Add(back);

                List<btnPodGrupa> grupa = new List<btnPodGrupa>();
                foreach (DataRow item in ArtikliDataSet.Tables["PodGrupi"].Select("GrupaID=" + grupaID.ToString()))
                {
                    var podgrupa = new btnPodGrupa(item["Naziv"].ToString(), Tools.PrazenStringToInt(item["ID"].ToString()), grupaID, item["Image"].ToString());
                    grupa.Add(podgrupa);
                }
                GrupaKomande.Controls.AddRange(grupa.ToArray());
                PrikaziArtikliIliSmetki();
            }
            else
            {
                PrikaziArtikliIliSmetki();
            }
        }

        public void KreirajDugminjaZaPodKeywords(int podgrupaID, int grupaID)
        {
            if (ArtikliDataSet.Tables["KeyWords"].Rows.Count > 0)
            {
                GrupaKomande.Controls.Clear();
                var back = new butKeyBack(grupaID);
                GrupaKomande.Controls.Add(back);

                butKeyWord grupa;

                foreach (DataRow item in ArtikliDataSet.Tables["KeyWords"].Select("PodgrupaID=" + podgrupaID.ToString()))
                {
                    if (!string.IsNullOrEmpty(item["KlucniZborovi"].ToString()))
                    {
                        grupa = new butKeyWord(item["KlucniZborovi"].ToString(), podgrupaID);
                        GrupaKomande.Controls.Add(grupa);
                    }
                }

                PrikaziArtikliIliSmetki();
            }
            else
            {
                PrikaziArtikliIliSmetki();
            }
        }

        public void IscistiGlavniKomande()
        {
            GlavniKomande.Visible = false;
            //foreach (Control ctl in GlavniKomande.Controls)
            //{
            //    ctl.Dispose();
            //}
            GlavniKomande.Controls.Clear();
            GlavniKomande.Visible = true;
        }

        private void frmKelner_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.F4)
            {
                if (Kasa)
                {
                    Close();
                    refreshSmetkiTimer.Enabled = false;
                }
                else
                {
                    if (e.KeyCode == Keys.Escape)
                    {

                        if (btnNovaSmetka.Visible)
                        {
                            btnNovaSmetka.PerformClick();
                        }
                        else
                        {
                            Close();
                            refreshSmetkiTimer.Enabled = false;
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                Kolicina = 1;
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                Kolicina = 2;
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                Kolicina = 3;
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                Kolicina = 4;
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                Kolicina = 5;
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                Kolicina = 6;
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                Kolicina = 7;
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                Kolicina = 8;
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                Kolicina = 9;
            }
            if (GlavniKomande.Controls.OfType<buttonNovaSmetkaKasa>().Count() > 0)
            {
                try
                {
                    if (Visible)
                    {
                        var smetke = GlavniKomande.Controls.OfType<btnSmetkaKasa>();

                        if (e.KeyCode == Keys.F1)
                        {
                            var novasmetkaDugme = GlavniKomande.Controls.OfType<buttonNovaSmetkaKasa>().FirstOrDefault();
                            novasmetkaDugme?.PerformClick();
                        }
                        else
                        {
                            IEnumerable<btnSmetkaKasa> btnSmetkaKasas = smetke as btnSmetkaKasa[] ?? smetke.ToArray();
                            if (btnSmetkaKasas.Any())
                            {
                                var smetka = btnSmetkaKasas.FirstOrDefault(c => c.Text.Contains(e.KeyCode.ToString()));

                                smetka?.PerformClick();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                }
            }

            if (GlavniKomande.Controls.OfType<btnSmetka>().Count() > 0)
            {
                try
                {
                    if (Visible)
                    {
                        var smetke = GlavniKomande.Controls.OfType<btnSmetka>();


                        IEnumerable<btnSmetka> btnSmetkaKasas = smetke as btnSmetka[] ?? smetke.ToArray();
                        if (btnSmetkaKasas.Any())
                        {
                            var smetka = btnSmetkaKasas.OrderBy(a => a.SmetkaID).FirstOrDefault(c => (c.ZabeleskaZaMasa.ToString()).EndsWith(e.KeyCode.ToString().Replace("F", "")));
                            if (!e.Control)
                                smetka?.PerformClick();
                            else
                            {
                                smetka?.btnFiscal.PerformClick();
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                }
            }
        }

        private void btnHideShowNalog_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1Collapsed = !splitContainer3.Panel1Collapsed;
            if (splitContainer3.Panel1Collapsed)
            {
                btnHideShowNalog.Image = BssBase.Properties.Resources.arrow_down;
            }
            else
            {
                btnHideShowNalog.Image = BssBase.Properties.Resources.arrow_up;
            }
        }

        public int KreirajNovNalog(int SmetkaID, int TipNaNalog)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(@"INSERT INTO tblNalog (Broj,Zabeleska,FirmaID,Smena_ID,TipNaNalog,SmetkaID)
                                                         VALUES ((Select dbo.NaredeBrojNaNalog()),@Zabeleska,@FirmaID,@Smena_ID,@TipNaNalog,@SmetkaID) Select @@IDENTITY", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@Zabeleska", string.Empty);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        com.Parameters.AddWithValue("@Smena_ID", settings.UserId);
                        com.Parameters.AddWithValue("@TipNaNalog", TipNaNalog);
                        com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                        con.Open();
                        var rez = com.ExecuteScalar();
                        if (!Equals(null, rez))
                        {
                            NalogIDZaInsert = Tools.PrazenStringToInt(rez.ToString());
                            NapolniOtvorenaSmetka(SmetkaID);
                            return NalogIDZaInsert;
                        }

                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
            return -1;
        }

        private void novNalog()
        {
            ZemiGlavniGrupi();
            KreirajDugminjaZaGrupiNaArtikli();
            if (grdNalozi.Rows.Count > 0)
            {
                if (ArtikliDataSet.Tables["Nalozi"].Select("Status = 0").Count() > 0)
                {
                    MessageBox.Show("Веќе постои отворена нарачка, најпрво треба него да ја затворите ( испечатите ) ", "Грешка !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (SmetkaID != -1)
            {
                KreirajNovNalog(SmetkaID, 0);
            }
            else
            {
                MessageBox.Show("Немате отворена сметка", "Грешка !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPecatiNalog_Click(object sender, EventArgs e)
        {
            PecatiNalog();
        }

        public bool PecatiFiskalna(DataTable artikliZaFiskalna, bool voGotovo)
        {
            if (_userLevel == 250)
            {
                return true;
            }

            if (settings.PecatFiskalna == false)
            {
                return true;
            }

            if (settings.PrasajZaFiskalna == true)
            {

                InputBoxResult opP;
                opP = InputBox.Show("Дали сакате да ја сочувате сметката ? ", "Дали сте сигурни ?", string.Empty, false);
                if (opP.ReturnCode == DialogResult.OK)
                {
                }
                else
                {
                    return true;
                }
            }

            if (Equals(null, artikliZaFiskalna))
            {
                return false;
            }

            if (artikliZaFiskalna.Rows.Count < 0)
            {
                return false;
            }
            var rezultat = false;
            try
            {
                var fiskalna = new FiscalCash(lblBrNaSmetka.Text);
                fiskalna.InitInterface();
                fiskalna.ArtikliZaNaFiskalna(false, artikliZaFiskalna);

                fiskalna.IssueBill(voGotovo);

                rezultat = true;
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return true;
            }
            try
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    decimal Iznos = 0;
                    foreach (DataRow Produkt in artikliZaFiskalna.Rows)
                    {
                        Iznos += Tools.PrazenStringToDecimal_dec(Produkt["Kolicina"].ToString()) * Tools.PrazenStringToDecimal_dec(Produkt["CenaSoRabatIddv"].ToString());
                    }
                    using (var com = new SqlCommand(@"INSERT INTO tblFiskalniSmetki (Broj ,Datum ,Iznos,Stornirana,tblSmetkaID,FirmaID)
						values((Select dbo.NaredenBrojNaFiskalna()) ,getDate() ,@Iznos,'false',@tblSmetkaID,@FirmaID) ", con))
                    {
                        
                        com.Parameters.AddWithValue("@Iznos", Iznos);
                        com.Parameters.AddWithValue("@tblSmetkaID", SmetkaID);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                        con.Open();
                        com.ExecuteNonQuery();
                    }
                }
                rezultat = true;
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return false;
            }
            return rezultat;
        }

        public void PratiNaPrinterSmetka(string brojNaSmetka)
        {
            Task.Factory.StartNew(() =>
            {

                try
                {

                    if (settings.KopiiZaSmetka == 0) return;
                    if (!string.IsNullOrEmpty(settings.PrinterPathDefault))
                    {
                        if (String.IsNullOrEmpty(settings.tipNaHartijaZaPrinter) || settings.tipNaHartijaZaPrinter.Contains("N/A"))
                        {
                            using (var smetka = new Reporti.SmetkaPrint())
                            {
                                smetka.PrintOptions.PrinterName = settings.PrinterPathDefault;
                                smetka.SetDataSource(bSSRDataSet);
                                smetka.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                smetka.SetParameterValue("firma", settings.FirmaNaziv);
                                smetka.SetParameterValue("kelner", UserName);
                                if (string.IsNullOrEmpty(MomentalaZabeleska))
                                    MomentalaZabeleska = " ";
                                smetka.SetParameterValue("Zabeleska", MomentalaZabeleska);
                                if (bSSRDataSet.StavkiVoSmetka.Rows.Count > 0)
                                {
                                    if (settings.KopiiZaSmetka != 0)
                                    {
                                        for (int i = 0; i < settings.KopiiZaSmetka; i++)
                                            smetka.PrintToPrinter(1, false, 0, 0);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (settings.tipNaHartijaZaPrinter == "50")
                            {
                                using (var smetka = new Reporti.SmetkaPrint50())
                                {
                                    smetka.PrintOptions.PrinterName = settings.PrinterPathDefault;
                                    smetka.SetDataSource(bSSRDataSet);
                                    smetka.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                    smetka.SetParameterValue("firma", settings.FirmaNaziv);
                                    smetka.SetParameterValue("kelner", UserName);
                                    if (string.IsNullOrEmpty(MomentalaZabeleska))
                                        MomentalaZabeleska = " ";
                                    smetka.SetParameterValue("Zabeleska", MomentalaZabeleska);
                                    if (bSSRDataSet.StavkiVoSmetka.Rows.Count > 0)
                                    {
                                        if (settings.KopiiZaSmetka != 0)
                                        {
                                            for (int i = 0; i < settings.KopiiZaSmetka; i++)
                                                smetka.PrintToPrinter(1, false, 0, 0);
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проблем со печатарот !!! \n" + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        public void PrintPosebnoKujna(string brojNaNalog, string brojNaSmetka, int tmpNalogID)
        {
            if (!string.IsNullOrEmpty(settings.PrinterSecond))
            {
                if (String.IsNullOrEmpty(settings.tipNaHartijaZaPrinter) || settings.tipNaHartijaZaPrinter.Contains("N/A"))

                {
                    using (var kujnNalog = new Reporti.KujnaPrint())
                    {
                        kujnNalog.PrintOptions.PrinterName = settings.PrinterSecond;
                        if (bSSRDataSet.tblNormativ.Rows.Count > 0)
                        {
                            List<string> grupe = bSSRDataSet.tblNormativ.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("GrupaNaziv")).ToList().Distinct().ToList();
                            foreach (var GrupaNaziv in grupe)
                            {
                                tblNormativTableAdapter.FillByGrupaNaziv(bSSRDataSet.tblNormativ, GrupaNaziv, tmpNalogID);
                                kujnNalog.SetDataSource(bSSRDataSet);
                                kujnNalog.SetParameterValue("BrojNaNalog", brojNaNalog);
                                kujnNalog.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                kujnNalog.SetParameterValue("firma", settings.FirmaNaziv);
                                kujnNalog.SetParameterValue("kelner", UserName);
                                kujnNalog.SetParameterValue("izmena", GrupaNaziv);
                                if (string.IsNullOrEmpty(MasaBrojPrint)) MasaBrojPrint = "N/A";
                                kujnNalog.SetParameterValue("MasaBroj", MasaBrojPrint);
                                kujnNalog.PrintToPrinter(1, false, 0, 0);

                            }


                        }
                        TekstZaIzmenetNalog = string.Empty;
                    }
                }

            }
            else
            {

                if (settings.tipNaHartijaZaPrinter == "50")
                {
                    using (var kujnNalog = new Reporti.KujnaPrint50())
                    {
                        kujnNalog.PrintOptions.PrinterName = settings.PrinterSecond;


                        if (bSSRDataSet.tblNormativ.Rows.Count > 0)
                        {
                            List<string> grupe = bSSRDataSet.tblNormativ.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("GrupaNaziv")).ToList().Distinct().ToList();
                            foreach (var GrupaNaziv in grupe)
                            {
                                tblNormativTableAdapter.FillByGrupaNaziv(bSSRDataSet.tblNormativ, GrupaNaziv, tmpNalogID);
                                kujnNalog.SetDataSource(bSSRDataSet);
                                kujnNalog.SetParameterValue("BrojNaNalog", brojNaNalog);
                                kujnNalog.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                kujnNalog.SetParameterValue("firma", settings.FirmaNaziv);
                                kujnNalog.SetParameterValue("kelner", UserName);
                                kujnNalog.SetParameterValue("izmena", GrupaNaziv);
                                kujnNalog.PrintToPrinter(1, false, 0, 0);
                            }


                        }

                        TekstZaIzmenetNalog = string.Empty;
                    }
                }

            }
        }
        private void PratiNaPrinter(int tmpIDNalog, string brojNaNalog, string brojNaSmetka, bool kujna = false)
        {
            Task.Factory.StartNew(() =>
           {

               try
               {
                   if (!kujna)
                   {

                       if (settings.KopiiSank == 0) return;
                       if (!string.IsNullOrEmpty(settings.PrinterPathDefault))
                       {

                           try
                           {
                               if (String.IsNullOrEmpty(settings.tipNaHartijaZaPrinter) || settings.tipNaHartijaZaPrinter.Contains("N/A"))

                               {
                                   using (var nalog = new Reporti.NalogPrint())
                                   {
                                       try
                                       {
                                           nalog.PrintOptions.PrinterName = settings.PrinterPathDefault;

                                           nalog.SetDataSource(bSSRDataSet);
                                           nalog.SetParameterValue("BrojNaNalog", brojNaNalog);
                                           nalog.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                           nalog.SetParameterValue("firma", settings.FirmaNaziv);
                                           nalog.SetParameterValue("kelner", UserName);
                                           if (string.IsNullOrEmpty(MasaBrojPrint)) MasaBrojPrint = "N/A";
                                           nalog.SetParameterValue("MasaBroj", MasaBrojPrint);

                                           if (bSSRDataSet.StavkiVoNalog.Rows.Count > 0)
                                           {
                                               if (settings.KopiiSank != 0)
                                               {
                                                   for (int i = 0; i < settings.KopiiSank; i++)
                                                       nalog.PrintToPrinter(1, false, 0, 0);
                                               }
                                           }
                                       }
                                       catch (Exception ex)
                                       {
                                           Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                                       }
                                   }
                               }
                               else
                               {
                                   if (settings.tipNaHartijaZaPrinter == "50")
                                   {
                                       using (var nalog = new Reporti.NalogPrint50())
                                       {
                                           try
                                           {
                                               nalog.PrintOptions.PrinterName = settings.PrinterPathDefault;

                                               nalog.SetDataSource(bSSRDataSet);
                                               nalog.SetParameterValue("BrojNaNalog", brojNaNalog);
                                               nalog.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                               nalog.SetParameterValue("firma", settings.FirmaNaziv);
                                               nalog.SetParameterValue("kelner", UserName);

                                               if (bSSRDataSet.StavkiVoNalog.Rows.Count > 0)
                                               {
                                                   if (settings.KopiiSank != 0)
                                                   {
                                                       for (int i = 0; i < settings.KopiiSank; i++)
                                                           nalog.PrintToPrinter(1, false, 0, 0);
                                                   }
                                               }
                                           }
                                           catch (Exception ex)
                                           {
                                               Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                                           }
                                       }
                                   }

                               }
                           }
                           catch (Exception ex)
                           {
                               Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                           }
                       }
                   }
                   else
                   {

                       if (settings.TipNaPrograma == "888200")
                       {
                           PrintPosebnoKujna(brojNaNalog, brojNaSmetka, tmpIDNalog);
                           return;
                       }
                       if (settings.KopiiZakujna == 0) return;
                       if (!string.IsNullOrEmpty(settings.PrinterSecond))
                       {
                           if (String.IsNullOrEmpty(settings.tipNaHartijaZaPrinter) || settings.tipNaHartijaZaPrinter.Contains("N/A"))
                           {
                               using (var kujnNalog = new Reporti.KujnaPrint())
                               {
                                   kujnNalog.PrintOptions.PrinterName = settings.PrinterSecond;

                                   kujnNalog.SetDataSource(bSSRDataSet);
                                   kujnNalog.SetParameterValue("BrojNaNalog", brojNaNalog);
                                   kujnNalog.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                   kujnNalog.SetParameterValue("firma", settings.FirmaNaziv);
                                   kujnNalog.SetParameterValue("kelner", UserName);
                                   kujnNalog.SetParameterValue("izmena", TekstZaIzmenetNalog);
                                   if (string.IsNullOrEmpty(MasaBrojPrint)) MasaBrojPrint = "N/A";
                                   kujnNalog.SetParameterValue("MasaBroj", MasaBrojPrint);

                                   if (bSSRDataSet.tblNormativ.Rows.Count > 0)
                                   {
                                       if (settings.KopiiZakujna != 0)
                                       {
                                           for (int i = 0; i < settings.KopiiZakujna; i++)
                                               kujnNalog.PrintToPrinter(1, false, 0, 0);
                                       }
                                   }
                                   TekstZaIzmenetNalog = string.Empty;
                               }
                           }

                       }
                       else
                       {
                           if (settings.TipNaPrograma == "888200")
                           {
                               PrintPosebnoKujna(brojNaNalog, brojNaSmetka, tmpIDNalog);
                               return;
                           }
                           if (settings.tipNaHartijaZaPrinter == "50")
                           {
                               using (var kujnNalog = new Reporti.KujnaPrint50())
                               {
                                   kujnNalog.PrintOptions.PrinterName = settings.PrinterSecond;

                                   kujnNalog.SetDataSource(bSSRDataSet);
                                   kujnNalog.SetParameterValue("BrojNaNalog", brojNaNalog);
                                   kujnNalog.SetParameterValue("BrojNaSmetka", brojNaSmetka);
                                   kujnNalog.SetParameterValue("firma", settings.FirmaNaziv);
                                   kujnNalog.SetParameterValue("kelner", UserName);
                                   kujnNalog.SetParameterValue("izmena", TekstZaIzmenetNalog);
                                   if (bSSRDataSet.tblNormativ.Rows.Count > 0)
                                   {
                                       if (settings.KopiiZakujna != 0)
                                       {
                                           for (int i = 0; i < settings.KopiiZakujna; i++)
                                               kujnNalog.PrintToPrinter(1, false, 0, 0);
                                       }
                                   }
                                   TekstZaIzmenetNalog = string.Empty;
                               }
                           }

                       }

                   }
               }
               catch (Exception ex)
               {
                   Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                   MessageBox.Show("Проблем со печатарот !!! \n" + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           });
        }

        private void ZatvoriNalog(string brojNaNalog, string brojNaSmetka, bool pecati = true)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("Update tblNalog set zavrsen = 'True',  DatumKraj = getDate() Where ID=" + NalogIDZaInsert.ToString(), con))
                {
                    try
                    {
                        //ovde treba da smenim za da printa sve na sank
                        stavkiVoNalogTableAdapter.FillBySamoSank(bSSRDataSet.StavkiVoNalog, NalogIDZaInsert);
                        PratiNaPrinter(NalogIDZaInsert, brojNaNalog, brojNaSmetka);
                        tblNormativTableAdapter.FillById(bSSRDataSet.tblNormativ, NalogIDZaInsert);
                        if (btnPecatiNalog.Visible == true || BssBase.settings.TipNaPrograma == "888")
                        {
                            if (bSSRDataSet.tblNormativ.Rows.Count > 0)
                            {
                                PratiNaPrinter(NalogIDZaInsert, brojNaNalog, brojNaSmetka, true);
                            }
                        }
                        
                        con.Open();
                        com.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        private void PecatiNalog(bool prikaziPoraka = true, string brojNaNalog = null, string brojNaSmetka = null)
        {
            try
            {
                if (ArtikliDataSet.Tables["Nalozi"].Select("Status = 0").Count() > 0)
                {
                    if (grdNalozi.CurrentRow.Cells["Status"].ToString() != "1" && !NalogIDSumaEnula())
                    {
                        var izvrsi = false;
                        var opc = DialogResult.No;
                        if (prikaziPoraka)
                        {
                            opc = MessageBox.Show(Tools.PrevediPoraka("Нарачката  ќе биде затворена, дали сте сигурни ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (opc == DialogResult.Yes)
                            {
                                izvrsi = true;
                            }
                        }
                        else
                        {
                            izvrsi = true;
                        }

                        if (izvrsi)
                        {
                            if (string.IsNullOrEmpty(brojNaNalog))
                            {
                                brojNaNalog = grdNalozi.CurrentRow.Cells["Broj"].Value.ToString();
                            }
                            if (string.IsNullOrEmpty(brojNaSmetka))
                            {
                                brojNaSmetka = lblBrNaSmetka.Text;
                            }
                            ZatvoriNalog(brojNaNalog, brojNaSmetka);
                            NaloziZaSmetka(SmetkaID, false);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Tools.PrevediPoraka("Нарачкате е празна или нејзината вкупна вредност е 0"), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("Нарачкате е веќе испечатена и затворена "), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Настана грешка немате одбрано нарачка или нарачката има проблем ");
            }
        }

        public bool NalogIDSumaEnula()
        {
            if (Tools.PrazenStringToDecimal(ArtikliDataSet.Tables["Nalozi"].Compute("SUM(Suma)", "ID =" + NalogIDZaInsert).ToString()) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnNovaSmetka_Click(object sender, EventArgs e)
        {
            if (ArtikliDataSet.Tables["Nalozi"].Select("Status = 0").Count() > 0 && !NalogIDSumaEnula())
            {
                DialogResult opc;
                if (btnPecatiNalog.Visible == true)
                {
                    opc = MessageBox.Show(Tools.PrevediPoraka("Нарачката ќе биде затворена, дали сакате да ја печатите "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    opc = DialogResult.Yes;
                }

                if (opc == DialogResult.Yes)
                {
                    if (btnPecatiNalog.Visible == true)
                    {
                        PecatiNalog(false);
                    }
                    else

                    if (BssBase.settings.TipNaPrograma == "888")
                    {
                        PecatiNalog(false);
                    }

                    using (var con = new SqlConnection(settings.konekcija))
                    {
                        using (var com = new SqlCommand("Update tblNalog set zavrsen = 'True',  DatumKraj = getDate() Where ID=" + NalogIDZaInsert.ToString(), con))
                        {
                            try
                            {
                                
                                con.Open();
                                com.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                Tools.PrevediSQLException(ex);
                                return;
                            }
                        }
                    }
                    prikaziSmetki();
                    MomentalaZabeleska = string.Empty;
                }
                else
                {


                    using (var con = new SqlConnection(settings.konekcija))
                    {
                        using (var com = new SqlCommand("Update tblNalog set zavrsen = 'True',  DatumKraj = getDate() Where ID=" + NalogIDZaInsert.ToString(), con))
                        {
                            try
                            {
                                
                                con.Open();
                                com.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                Tools.PrevediSQLException(ex);
                                return;
                            }
                        }
                    }

                    prikaziSmetki();
                    MomentalaZabeleska = string.Empty;
                }
            }
            else
            {
                prikaziSmetki();
            }
        }

        public static Image ByteArrayToImagebyMemoryStream(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte);
            Image image = Image.FromStream(ms, true, false);
            return image;
        }

        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        private DataTable Pages;
        public DataTable PrikaziArtikliIliSmetki()
        {
            Application.DoEvents();
            if (splitContainer4.Panel1.Enabled == false)
            {

                prikaziSmetki();

                return null;
            }

            IscistiGlavniKomande();
            var filter = string.Empty;
            печатењеСо10ПопустToolStripMenuItem.Visible = settings.PecatenjeSoPopust;
            печатењеСо5ПопустToolStripMenuItem.Visible = settings.PecatenjeSoPopust;
            печатењеСо15ПопустToolStripMenuItem1.Visible = settings.PecatenjeSoPopust;
            печатењеСо20ПопустToolStripMenuItem2.Visible = settings.PecatenjeSoPopust;

            забелешкаЗаМасаToolStripMenuItem.Visible = true;
            забелешкаЗаНарачкаToolStripMenuItem.Visible = true;

            if (GrupaID != -1 && GrupaID != 0)
            {
                filter = "GrupaId =" + GrupaID;
            }

            if (string.IsNullOrEmpty(filter))
            {
                if (PodgrupaID != -1)
                {
                    filter = "PodgrupaID =" + PodgrupaID;
                }
            }
            else
            {
                if (PodgrupaID != -1)
                {
                    filter += " AND PodgrupaID =" + PodgrupaID;
                }
            }

            if (string.IsNullOrEmpty(filter))
            {
                if (!String.IsNullOrEmpty(Keywords))
                {
                    filter = String.Format("KlucniZborovi ={0}", Keywords);
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Keywords))
                {
                    filter += String.Format(" AND KlucniZborovi LIKE '*{0}*'", Keywords);
                }
            }

            var page = 0;
            var maxControlsPerPage = cfg.brojNaArtikliDisplay;
            var vkbrojNaArtikli = ArtikliDataSet.Tables["Artikli"].Select(filter, "RedenBroj").Count();

            Pages = GetPages(vkbrojNaArtikli, maxControlsPerPage, page, filter);



            KreirajPage(Pages, 0);
            Application.DoEvents();
            return Pages;
        }

        private DataTable GetPages(int vkbrojNaArtikli, int maxControlsPerPage, int page, string filter)
        {
            var Pages = new DataTable();
            Pages.Columns.Add("ID", typeof(Int32));
            Pages.Columns.Add("Naziv", typeof(String));
            Pages.Columns.Add("Sifra", typeof(String));
            Pages.Columns.Add("Cena", typeof(String));
            Pages.Columns.Add("Sirina", typeof(Int32));
            Pages.Columns.Add("Image", typeof(String));
            Pages.Columns.Add("Normativ", typeof(Boolean));
            Pages.Columns.Add("page", typeof(Int32));
            Pages.Columns.Add("GrupaID", typeof(Int32));
            Pages.Columns.Add("RedenBroj", typeof(Int32));

            for (var i = 0; i < vkbrojNaArtikli; i++)
            {
                while ((maxControlsPerPage * page) < vkbrojNaArtikli)
                {
                    if (page == 0)
                    {
                        var ArtikliSelected = ArtikliDataSet.Tables["Artikli"].Select(filter, "RedenBroj");
                        for (var a = 0; a < maxControlsPerPage && a < vkbrojNaArtikli; a++)
                        {
                            var vnes = Pages.NewRow();
                            vnes["ID"] = ArtikliSelected.ElementAt(a)["ID"].ToString();
                            vnes["Naziv"] = ArtikliSelected.ElementAt(a)["Naziv"].ToString();
                            vnes["RedenBroj"] = ArtikliSelected.ElementAt(a)["RedenBroj"];
                            vnes["Image"] = ArtikliSelected.ElementAt(a)["Image"].ToString();
                            vnes["Sifra"] = ArtikliSelected.ElementAt(a)["Sifra"].ToString();
                            vnes["Cena"] = ArtikliSelected.ElementAt(a)["ProdaznaCena"].ToString();
                            vnes["Sirina"] = cfg.SirinaNaArtikal;
                            vnes["Normativ"] = ArtikliSelected.ElementAt(a)["Normativ"].ToString();
                            vnes["page"] = page;
                            vnes["GrupaID"] = ArtikliSelected.ElementAt(a)["GrupaID"].ToString();
                            Pages.Rows.Add(vnes);
                        }
                    }
                    else
                    {
                        for (var b = maxControlsPerPage * page;
                            b < (maxControlsPerPage * page + maxControlsPerPage) && b < vkbrojNaArtikli;
                            b++)
                        {
                            var ArtikliSelectedb = ArtikliDataSet.Tables["Artikli"].Select(filter, string.Empty);
                            var vnes = Pages.NewRow();
                            vnes["ID"] = ArtikliSelectedb.ElementAt(b)["ID"].ToString();
                            vnes["RedenBroj"] = ArtikliSelectedb.ElementAt(b)["RedenBroj"];
                            vnes["Naziv"] = ArtikliSelectedb.ElementAt(b)["Naziv"].ToString();
                            vnes["Image"] = ArtikliSelectedb.ElementAt(b)["Image"].ToString();
                            vnes["Sifra"] = ArtikliSelectedb.ElementAt(b)["Sifra"].ToString();
                            vnes["Cena"] = ArtikliSelectedb.ElementAt(b)["ProdaznaCena"].ToString();
                            vnes["Sirina"] = GlavniKomande.Width / cfg.brojNaDugminjaNaArtikal;
                            vnes["Normativ"] = ArtikliSelectedb.ElementAt(b)["Normativ"].ToString();
                            vnes["page"] = page;
                            vnes["GrupaID"] = ArtikliSelectedb.ElementAt(b)["GrupaID"].ToString();
                            Pages.Rows.Add(vnes);
                        }
                    }

                    page++;
                }
            }

            return Pages;
        }

        public void KreirajPage(DataTable Page, int page)
        {
            GlavniKomande.Visible = false;
            GlavniKomande.Controls.Clear();

            string orderBy = "RedenBroj ASC";
            if (Page.Rows.Count > 0 && Page.Select("page = " + page.ToString()).Count() > 0)
            {
                if (page != 0)
                {
                    var back = new btnNazad(page, Tools.PrazenStringToInt(Page.Rows[0]["Sirina"].ToString())) { Text = string.Empty };
                    GlavniKomande.Controls.Add(back);
                }


                List<btnArtikal> btn = new List<btnArtikal>();

                foreach (var item in Page.Select("page = " + page.ToString(), orderBy))
                {
                    if (int.TryParse(item["ID"].ToString(), out int id) &&
                        int.TryParse(item["Sirina"].ToString(), out int sirina))
                    {
                        var b = new btnArtikal(id, item["Naziv"].ToString(), item["Cena"].ToString(), sirina, item["Normativ"].ToString(), int.Parse(item["page"].ToString()), item["Image"].ToString());
                        btn.Add(b);
                    }
                    else
                    {
                        Tools.LogExceptionMessageWithScreenShoot(new Exception("Invalid data"), "Invalid data", false);
                        return;
                    }
                }
                GlavniKomande.Controls.AddRange(btn.ToArray());
                if (Page.Rows.Count > cfg.brojNaArtikliDisplay)
                {
                    var next = new btnNapred(page, Tools.PrazenStringToInt(Page.Rows[0]["Sirina"].ToString())) { Text = string.Empty };
                    GlavniKomande.Controls.Add(next);
                }
            }

            GlavniKomande.ResumeLayout();
            GlavniKomande.Visible = true;
            Application.DoEvents();

        }

        public void PresemetajSumaNaNalog()
        {

            if (grdNalozi.Rows.Count > 0)
            {
                if (ArtikliDataSet.Tables.Contains("Nalozi"))
                {
                    lblSum.Text = string.Format(" {0:C}", ArtikliDataSet.Tables["Nalozi"].Compute("SUM(Suma)", string.Empty));

                    lblSumaArtikli.Text = grdNalozi.Rows.Count.ToString();
                }
            }
            else
            {
                lblSum.Text = string.Format(" {0:C}", 0);
                lblSumaArtikli.Text = 0.ToString();
            }
        }

        private void grdNalozi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PresemetajSumaNaNalog();
        }

        private void grdArtikli_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grdArtikli.Rows.Count > 0)
            {
                if (ArtikliDataSet.Tables.Contains("ArtikliNalog"))
                {
                    lblVkupnoKol.Text = ArtikliDataSet.Tables["ArtikliNalog"].Compute("SUM(Kolicina)", string.Empty).ToString();
                    txtBrArtikli.Text = grdArtikli.Rows.Count.ToString();
                }
            }
            else
            {
                lblVkupnoKol.Text = 0.ToString();
                txtBrArtikli.Text = 0.ToString();
            }
        }

        public int NalogIDZaInsert = -1;
        public decimal Kolicina = 1;

        public void dodadiArtikalVoNalog(int artikalID, bool normativ, string cena)
        {
            if (settings.TipNaPrograma == "88")
            {
                PrikaziTastatura(cena);
            }

            if (Task.Factory.StartNew(() =>
            {
                using (var con = new SqlConnection(settings.konekcija))
                {
                    var sqlCom = string.Empty;
                    if (normativ)
                    {
                        sqlCom = "INSERT INTO tblNalogStavki (tblNalogID ,tblNomativID ,Kolicina,Rabat1) Values(@tblNalogID ,@tblArtikalID ,@Kolicina,@Rabat1)";
                    }
                    else
                    {
                        sqlCom = "INSERT INTO tblNalogStavki (tblNalogID ,tblArtikalID ,Kolicina,Rabat1) Values(@tblNalogID ,@tblArtikalID ,@Kolicina,@Rabat1)";
                    }
                    using (var com = new SqlCommand(sqlCom, con))
                    {
                        try
                        {
                            
                            com.Parameters.AddWithValue("@tblNalogID", NalogIDZaInsert);
                            com.Parameters.AddWithValue("@tblArtikalID", artikalID);
                            com.Parameters.AddWithValue("@Kolicina", Kolicina);

                            if (rabat > 0)
                            {
                                com.Parameters.AddWithValue("@Rabat1", rabat);
                            }
                            else
                            {
                                decimal RabatODAkcija = 0;

                                var rowSelected = ListaSoArtikliNaAkcija.Select("tblArtikalID=" + artikalID).FirstOrDefault();
                                if (rowSelected != null)
                                {
                                    string rabatStr = rowSelected["Rabat"].ToString();
                                    RabatODAkcija = Tools.PrazenStringToDecimal_dec(rabatStr);
                                }

                                com.Parameters.AddWithValue("@Rabat1", RabatODAkcija);
                            }

                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();
                            Kolicina = 1;
                            rabat = 0;
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            return;
                        }
                    }
                }
            }).Wait(1000) == true)
            {

                ArtikliZaNalog(NalogIDZaInsert);
                NaloziZaSmetka(SmetkaID);
                PresemetajSumaNaNalog();
            }
            else MessageBox.Show("Настана проблем, можно е сумата да е лошо пресметана");
        }

        private void grdNalozi_Click(object sender, EventArgs e)
        {
            if (!Equals(grdNalozi.CurrentRow, null))
            {
                var nalogID = Tools.PrazenStringToInt(grdNalozi.CurrentRow.Cells["ID"].Value.ToString());

                ArtikliZaNalog(nalogID);

                if (grdNalozi.CurrentRow.Cells["Status"].Value.ToString() == "0")
                {
                    NalogIDZaInsert = nalogID;
                }
                else
                {
                    NalogIDZaInsert = -1;
                }
            }
        }

        public void brisiArtikal()
        {
            if (grdArtikli.Rows.Count > 0)
            {
                if (!Equals(grdArtikli.CurrentRow, null))
                {
                    var idArtikalZaBrisenje = -1;

                    idArtikalZaBrisenje = Tools.PrazenStringToInt(grdArtikli.CurrentRow.Cells["Artikal"].Value.ToString());

                    if (idArtikalZaBrisenje != -1)
                    {
                        using (var con = new SqlConnection(settings.konekcija))
                        {
                            using (var com = new SqlCommand("Exec BrisiNamaliArtikal @NalogID, @ArtikalID", con))
                            {
                                try
                                {
                                    
                                    com.Parameters.AddWithValue("@NalogID", NalogIDZaInsert);
                                    com.Parameters.AddWithValue("@ArtikalID", idArtikalZaBrisenje);
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    Kolicina = 1;
                                    ArtikliZaNalog(NalogIDZaInsert);
                                    NaloziZaSmetka(SmetkaID);
                                    MessageBox.Show("Количината е намалена, податоците се освежени");
                                }
                                catch (SqlException ex)
                                {
                                    Tools.PrevediSQLException(ex);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void IzbrisiCelosnoArtikal(int artikalID)
        {
            if (grdArtikli.Rows.Count > 0)
            {
                if (!Equals(grdArtikli.CurrentRow, null))
                {
                    var idArtikalZaBrisenje = -1;

                    idArtikalZaBrisenje = Tools.PrazenStringToInt(grdArtikli.CurrentRow.Cells["Artikal"].Value.ToString());

                    if (idArtikalZaBrisenje != -1)
                    {
                        using (var con = new SqlConnection(settings.konekcija))
                        {
                            using (var com = new SqlCommand("Exec BrisiArtikalNormativ @NalogID, @ArtikalID", con))
                            {
                                try
                                {
                                    
                                    com.Parameters.AddWithValue("@NalogID", NalogIDZaInsert);
                                    com.Parameters.AddWithValue("@ArtikalID", idArtikalZaBrisenje);
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    Kolicina = 1;
                                    ArtikliZaNalog(NalogIDZaInsert);
                                    NaloziZaSmetka(SmetkaID);
                                    MessageBox.Show("Количината е намалена, податоците се освежени");
                                }
                                catch (SqlException ex)
                                {
                                    Tools.PrevediSQLException(ex);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void grdArtikli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var idArtikalZaBrisenje = -1;
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате да го избришете артиклот од нарачката  ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    idArtikalZaBrisenje = Tools.PrazenStringToInt(grdArtikli.CurrentRow.Cells["Artikal"].Value.ToString());
                    if (idArtikalZaBrisenje != -1 && NalogIDZaInsert != -1)
                    {
                        IzbrisiCelosnoArtikal(idArtikalZaBrisenje);
                    }
                }
                else
                {
                    MessageBox.Show("Нарачката е затворена , не е дозволена измена \n Отверете нова нарачка или одберете постоечка", "Грешка !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public decimal rabat = 0;
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            PrikazigiSiteArtikliODSiteNalozi(SmetkaID);
        }


        public class frmTastatura : Form
        {
            public int Kolicina = 1;
            public decimal Rabat = 0;
            public decimal cena;
        }
        public void PrikaziTastatura(string Cena = "")
        {
            var s = new frmTastatura();
            if (!string.IsNullOrEmpty(Cena))
            {
                s.Load += s_Load;
                s.cena = Tools.PrazenStringToDecimal_dec(Cena);
            }
            var numpad = true;
            if (!string.IsNullOrEmpty(settings.eKujna))
            {
                if (settings.eKujna.Contains("1"))
                {
                    numpad = false;
                }
            }
            var c = new KeyBoard(false);
            s.WindowState = FormWindowState.Normal;
            s.StartPosition = FormStartPosition.CenterScreen;
            if (!numpad)
            {
                s.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            else
            {
                //s.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            c.HIDEPANEL();
            c.AutoSize = true;
            c.Dock = DockStyle.Fill;
            s.KeyPreview = true;
            s.KeyDown += s_KeyDown;
            s.Controls.Add(c);
            s.Size = new Size(245, 490);
            s.ShowDialog();

            rabat = s.Rabat;

            if (!string.IsNullOrEmpty(c.keypaReturnVal.Replace(",", ".")))
            {
                Kolicina = Tools.PrazenStringToDecimal_dec(c.keypaReturnVal.Replace(",", "."));
            }
        }

        decimal PrikaziTastaturaPopust(decimal sumZaNaplataODVnes)
        {
            var s = new frmTastatura();
            s.BackColor = Color.WhiteSmoke;

            var c = new KeyBoard(false);
            s.WindowState = FormWindowState.Normal;
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedDialog;

            c.HIDEPANEL();
            c.AutoSize = true;
            c.Dock = DockStyle.Fill;
            s.KeyPreview = true;
            s.KeyDown += s_KeyDown;
            s.Controls.Add(c);
            s.Size = new Size(245, 470);
            s.ShowDialog();

            if (!string.IsNullOrEmpty(c.keypaReturnVal.Replace(",", ".")))
            {
                if (sumZaNaplataODVnes > 0)
                {
                    decimal vnesenaSuma = Tools.PrazenStringToDecimal_dec(c.keypaReturnVal.Replace(",", "."));
                    s.Rabat = ((100 * (sumZaNaplataODVnes - vnesenaSuma)) / sumZaNaplataODVnes);
                }

            }
            return s.Rabat;
        }




        void s_Load(object sender, EventArgs e)
        {

            StatusStrip s = new StatusStrip();
            ToolStripDropDownButton b = new ToolStripDropDownButton();

            b.Text = "Попуст на цена";
            b.Font = new Font(b.Font.FontFamily, 13);
            b.Click += b_Click;
            s.Items.Add(b);


            s.Dock = DockStyle.Top;
            ((Form)sender).Controls.Add(s);

        }

        void b_Click(object sender, EventArgs e)
        {
            decimal cenaZaRabat = ((frmTastatura)(((ToolStripDropDownButton)sender).GetCurrentParent().FindForm())).cena;
            ((frmTastatura)(((ToolStripDropDownButton)sender).GetCurrentParent().FindForm())).Rabat = PrikaziTastaturaPopust(cenaZaRabat);
        }


        private void s_KeyDown(object sender, KeyEventArgs e)
        {
            ((Form)sender).Controls.OfType<KeyBoard>().FirstOrDefault().KeyBoard_KeyDown(e);
        }

        private void meniPopust_click(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }
        private void btnTastatura_Click(object sender, EventArgs e)
        {
            PrikaziTastatura("");
        }

        public string TekstZaIzmenetNalog;

        private void овозможиИзменаНаНалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(grdNalozi.CurrentRow, null))
            {
                var nalogID = Tools.PrazenStringToInt(grdNalozi.CurrentRow.Cells["ID"].Value.ToString());

                if (nalogID != -1)
                {
                    DialogResult opc;
                    opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да овозможите измена на оваа нарачка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        try
                        {
                            var login = new frmMainLogin();
                            login.ShowDialog();
                            if (!login.LoginOk)
                            {
                                return;
                            }
                            using (var con = new SqlConnection(settings.konekcija))
                            {
                                using (var com = new SqlCommand("Update tblNalog set Zavrsen = 0 where ID=@ID", con))
                                {
                                    con.Open();
                                    
                                    com.Parameters.AddWithValue("@ID", nalogID);
                                    com.ExecuteNonQuery();
                                    NapolniOtvorenaSmetka(SmetkaID);
                                    TekstZaIzmenetNalog = "Нарачката е изменета";
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            return;
                        }
                    }
                }
            }
        }

        private void целосноБришењеНаНарачкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(grdNalozi.CurrentRow, null))
            {
                var nalogID = Tools.PrazenStringToInt(grdNalozi.CurrentRow.Cells["ID"].Value.ToString());

                if (nalogID != -1)
                {
                    DialogResult opc;
                    opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ја избришете оваа нарачка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        try
                        {
                            var login = new frmMainLogin();
                            login.ShowDialog();
                            if (!login.LoginOk)
                            {
                                return;
                            }
                            using (var con = new SqlConnection(settings.konekcija))
                            {
                                using (var com = new SqlCommand("delete from tblNalog where ID=@ID", con))
                                {
                                    con.Open();
                                    
                                    com.Parameters.AddWithValue("@ID", nalogID);
                                    com.ExecuteNonQuery();
                                }
                            }

                            NapolniOtvorenaSmetka(SmetkaID);
                        }
                        catch (SqlException ex)
                        {
                            Tools.PrevediSQLException(ex);
                            return;
                        }
                    }
                }
            }
        }

        private void внесНаПрометToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да внесете промет за денешниот ден ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Настана грешка , сумата не одговара или има проблем со фискалната");
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        private void затворањеНаДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да го затворите денешниот ден ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                    return;
                }

                if (settings.ProkniziSmetki == "1")
                {
                    foreach (DataRow item in Tools.NeProknizeniSmetki().Rows)
                    {
                        Tools.ProkniziSmetka(Tools.PrazenStringToInt(item["ID"].ToString()));
                    }
                }
            }
        }

        private void дневенФинансискиИзвештајToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да испечатите извештај за денешниот ден ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    var fiskalna = new FiscalCash(this.Name);
                    fiskalna.InitInterface();
                    fiskalna.DailyFiscalWithoutClose();
                }
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                return;
            }
        }

        private void извештаиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(settings.TipNaFiskalna))
            {
                if (settings.TipNaFiskalna == "Razvigorec")
                {
                    BssBase.Roots.frmDatumOdDo frmDatum = new BssBase.Roots.frmDatumOdDo();
                    DialogResult rez = frmDatum.ShowDialog();
                    if (rez == DialogResult.OK)
                    {
                        if (Equals(null, frmDatum.DatumDO)) return;
                        if (Equals(null, frmDatum.datumOD)) return;

                        var fiskalna = new FiscalCash(this.Name);
                        fiskalna.InitInterface();
                        fiskalna.IzvestajZaPeriodRazvigorec(frmDatum.datumOD.Value, frmDatum.DatumDO.Value, frmDatum.skraten.Checked);
                        frmDatum.Dispose();
                    }
                    return;
                }
            }

            var process = new Process();
            process.StartInfo.FileName = "IzvestajFiskalna.exe";
            process.Start();
            process.WaitForExit();
        }

        private void btnizlez_Click(object sender, EventArgs e)
        {
            Close();
            refreshSmetkiTimer.Enabled = false;
        }

        private void забелешкаЗаМасаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.OnScreenKeyNaSveDugminjaBoard = true;
                var rez = InputBox.Show("Внесете забелешка ", false, false);
                settings.OnScreenKeyNaSveDugminjaBoard = false;
                settings.OnScreenKeyBoard = false;
                if (!string.IsNullOrEmpty(rez.Text))
                {
                    if (rez.Text.Length > 24)
                    {
                        rez.Text = rez.Text.Substring(0, 24);
                    }

                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand("update tblSmetka set Zabeleska = @txt where ID = @ID", con))
                        {
                            con.Open();
                            
                            com.Parameters.AddWithValue("@ID", SmetkaID);
                            com.Parameters.AddWithValue("@txt", rez.Text);
                            com.ExecuteNonQuery();
                            setirajZabeleskaZaSmetka(rez.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void додадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.OnScreenKeyNaSveDugminjaBoard = true;
                var rez = InputBox.Show("Внесете забелешка ", false, false);
                settings.OnScreenKeyNaSveDugminjaBoard = false;
                settings.OnScreenKeyBoard = false;
                if (!string.IsNullOrEmpty(rez.Text))
                {
                    if (rez.Text.Length > 50)
                    {
                        rez.Text = rez.Text.Substring(0, 49);
                    }

                    using (SqlConnection con = new SqlConnection(settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand("update tblNalog set Zabeleska = @txt where ID = @ID", con))
                        {
                            con.Open();
                            
                            com.Parameters.AddWithValue("@ID", NalogIDZaInsert);
                            com.Parameters.AddWithValue("@txt", rez.Text);
                            com.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void прегледајToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand("select Zabeleska from tblNalog where ID = @ID", con))
                    {
                        con.Open();
                        
                        com.Parameters.AddWithValue("@ID", NalogIDZaInsert);

                        var rez = com.ExecuteScalar();
                        if (!Equals(null, rez))
                        {
                            MessageBox.Show(rez.ToString(), "Забелешка за нарачка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private int tmpBrojNaArtikli;

        private void GrupaKomande_ControlAdded(object sender, ControlEventArgs e)
        {
            GlavniKomande.Padding = new Padding(10, GrupaKomande.Height + 15, 10, 10);
            if (GrupaKomande.Controls.Count > 9)
            {
                cfg.brojNaArtikliDisplay = cfg.brojNaArtikliDisplayMalku;
            }
            else
            {
                cfg.brojNaArtikliDisplay = tmpBrojNaArtikli;
            }
        }

        public StringBuilder ExportToCSV(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            return sb;
        }
        public void IspecatiIZatvoriSmetkaSoSveFiskalna(bool popust, decimal ProcentNaPopust, int SentSmetkaID = -2)
        {
            if(SentSmetkaID != -2) {
                SmetkaID = SentSmetkaID;
            }

            bool voGotovo = true;
            int ImaPopust = 0;
            if (string.IsNullOrEmpty(lblBrNaSmetka.Text))
            {
                lblBrNaSmetka.Text = "nvb";
            }

            DialogResult opc = DialogResult.No;

            if (settings.PrasajZaZatvoranjeNaSmetka)
                opc = MessageBox.Show(Tools.PrevediPoraka("Сметката и нарачката ќе бидат затворени , Дали сакате да ја завршите сметката и да отпечатите фискална сметка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                if (settings.PrikaziFormaZaKusur)
            {
                decimal sumaZaNaplata = Tools.PrazenStringToDecimal_dec(ArtikliDataSet.Tables["Nalozi"].Compute("SUM(Suma)", string.Empty).ToString());
                if (popust)
                {
                    sumaZaNaplata = sumaZaNaplata - Math.Round(sumaZaNaplata * ProcentNaPopust / 100);
                    ImaPopust = 1;
                }

                string iznos = string.Format(" Вкупно за наплата: {0:C}", sumaZaNaplata);

                var box = InputBox.ShowFormaZaKusur(iznos, true, sumaZaNaplata, false, true, 18.25F, true);
                box.Text = string.Empty;
                opc = box.ReturnCode;
                if (opc == DialogResult.OK)
                {
                    opc = DialogResult.Yes;
                    voGotovo = box.DefaulOptionSelected;
                }
                else
                {
                    opc = DialogResult.No;
                }
            }

            

            if (opc == DialogResult.Yes)
            {


                using (var con = new SqlConnection(settings.konekcija))
                {
                    using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                    {
                        try
                        {
                            
                            com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                            com.Parameters.AddWithValue("@SoPopust", ImaPopust);
                            com.Parameters.AddWithValue("@Popust", ProcentNaPopust);
                            com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();

                            if (ArtikliDataSet.Tables["Nalozi"].Select("Status = 0").Count() > 0 && !NalogIDSumaEnula())
                            {
                                if (btnPecatiNalog.Visible == true || BssBase.settings.TipNaPrograma == "888")
                                {
                                    PecatiNalog(false, grdNalozi.CurrentRow.Cells["Broj"].Value.ToString(), lblBrNaSmetka.Text);
                                }
                            }

                            var ArtikliZaFiskalna = new DataTable("ArtikliZaFiskalna");
                            using (var Smetki = new SqlCommand("exec dbo.StavkiZaFiskalNa @SmetkaID,@SoPopust,@Popust", con))
                            {
                                Smetki.Parameters.Clear();
                                Smetki.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                                Smetki.Parameters.AddWithValue("@SoPopust", ImaPopust);
                                Smetki.Parameters.AddWithValue("@Popust", ProcentNaPopust);
                                con.Open();
                                ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                                con.Close();
                            }
                            #region pecatiOddleno
                            if (rbtnPodeleni.Checked)
                            {
                                opc = DialogResult.OK;
                                var OddElnaFiskalna = new MFiskalna.frmPecatiFiskalnaOddelno(ArtikliZaFiskalna, SmetkaID, settings.firmaId, 0)
                                {
                                    WindowState = FormWindowState.Maximized,
                                    FormBorderStyle = FormBorderStyle.None,
                                    StartPosition = FormStartPosition.CenterScreen
                                };
                                var ispecatnoSve = OddElnaFiskalna.ShowDialog();
                                if (ispecatnoSve == DialogResult.OK)
                                {
                                    
                                    com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                                    com.Parameters.AddWithValue("@SoPopust", ImaPopust);
                                    com.Parameters.AddWithValue("@Popust", ProcentNaPopust);
                                    com.Parameters.AddWithValue("@FirmaID", settings.firmaId);
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    stavkiVoSmetkaTableAdapter.Fill(bSSRDataSet.StavkiVoSmetka, SmetkaID);
                                    PratiNaPrinterSmetka(lblBrNaSmetka.Text);
                                    prikaziSmetki();
                                }
                            }
                            #endregion pecatiOddleno

                            if (rbtnVkupna.Checked)
                            {


                                if (PecatiFiskalna(ArtikliZaFiskalna, voGotovo))
                                {
                                    stavkiVoSmetkaTableAdapter.Fill(bSSRDataSet.StavkiVoSmetka, SmetkaID);
                                    PratiNaPrinterSmetka(lblBrNaSmetka.Text);

                                    //
                                    Task.Factory.StartNew(() =>
                                    {

                                        if (settings.EnableMailNaSmetka.ToLower().Contains("true"))
                                        {
                                            if (bSSRDataSet.StavkiVoSmetka.Rows.Count > 0)
                                            {
                                                string fileName = string.Format("{0} - {1}.csv", lblBrNaSmetka.Text, DateTime.Now.Month);
                                                string subject = "Испечатена сметка ресторант број: " + lblBrNaSmetka.Text;
                                                string text = string.Format("{0} \n Датум : {1}\n Вкупен износ : {2}", settings.FirmaNaziv, DateTime.Now, Convert.ToDecimal(bSSRDataSet.StavkiVoSmetka.Compute("SUM(Iznos)", "")).ToString("N2"));
                                                StreamWriter wr = new StreamWriter(Tools.setExportPath(fileName, true));
                                                wr.Write(ExportToCSV(bSSRDataSet.StavkiVoSmetka));
                                                wr.Close();
                                                Tools.SendMailDefault(Tools.setExportPath(fileName), subject, text, false, settings.GMailFrom, settings.GMailToZaSmetki);
                                            }
                                        }
                                    });


                                    prikaziSmetki();
                                    //
                                }
                                else
                                {
                                    opc = MessageBox.Show("Настана проблем со печатењето на фискална сметка, Сметката не е затворена !!!!", "ГРЕШКА !!!!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true, "", "frmKelner.cs", 27892, false);
                            prikaziSmetki();
                            return;
                        }
                    }
                }

                if (opc == DialogResult.Retry)
                {
                    btnFiskalna.PerformClick();
                }
            }
        }

        private void btnFiskalna_Click(object sender, EventArgs e)
        {
            ArtikliZaNalog(NalogIDZaInsert);
            NaloziZaSmetka(SmetkaID);
            PresemetajSumaNaNalog();
            IspecatiIZatvoriSmetkaSoSveFiskalna(false, 0);
        }

        private void печатењеСо5ПопустToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да дадете сметка со попуст ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                setirajZabeleskaZaSmetka("Со Попуст од 5%");
                IspecatiIZatvoriSmetkaSoSveFiskalna(true, 5);
            }
        }

        private void печатењеСо10ПопустToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да дадете сметка со попуст ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                setirajZabeleskaZaSmetka("Со Попуст од 10%");
                IspecatiIZatvoriSmetkaSoSveFiskalna(true, 10);
            }
        }

        private void печатењеСо10ПопустToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да дадете сметка со попуст ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                setirajZabeleskaZaSmetka("Со Попуст од 15%");
                IspecatiIZatvoriSmetkaSoSveFiskalna(true, 15);
            }
        }

        private void печатењеСо10ПопустToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да дадете сметка со попуст ?  "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                setirajZabeleskaZaSmetka("Со Попуст од 20%");
                IspecatiIZatvoriSmetkaSoSveFiskalna(true, 20);
            }
        }

        private void пребарувањеВоАртиклиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asm = System.Reflection.Assembly.Load("BSSR");
            var t = asm.CreateInstance("BSSR.Forms.frmArtikli", true).GetType();
            bool readOnly = true;
            if (settings.TipNaPrograma == "8")
            {
                readOnly = false;
            }
            var frm = (frmBigShow)Activator.CreateInstance(t, new object[] { false, readOnly });
            frm.ShowDialog();
        }

        private void прегледПоВработенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GlavnaForma = new MReport.Forms.frmIzvestajPoVraboten() { Text = прегледПоВработенToolStripMenuItem.Text, WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
            GlavnaForma.ShowDialog();
        }

        private void прегледНаСметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GlavnaForma = new MReport.Forms.frmPregledNaSmetki() { WindowState = FormWindowState.Maximized, ShowInTaskbar = true };
            GlavnaForma.ShowDialog();
        }

        private void прегледНаСитеНалозиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GlavnaForma = new MReport.Forms.frmPregledNaNalozi() { WindowState = FormWindowState.Maximized, ShowInTaskbar = true, Text = прегледНаСитеНалозиToolStripMenuItem.Text };
            GlavnaForma.ShowDialog();
        }

        private void btnIzbrisiArtikal2_Click(object sender, EventArgs e)
        {
            if (grdArtikli.Rows.Count > 0)
                if (NalogIDZaInsert != -1)
                {
                    DialogResult opc;
                    opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ги избришете селектираните ставки ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {

                        int ArtikIDZaBrisenje = Tools.PrazenStringToInt(grdArtikli.CurrentRow.Cells["Artikal"].Value.ToString());
                        IzbrisiCelosnoArtikal(ArtikIDZaBrisenje);
                    }
                }
                else
                {
                    MessageBox.Show("Нарачката е затворен , не е дозволена измена \n Отверете нова нарачка или одберете постоечка ", "Грешка !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void сметкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                {
                    try
                    {
                        MFakturi.Forms.frmPartner partner = new MFakturi.Forms.frmPartner("");
                        partner.ShowDialog();
                        if (!Equals(null, partner.dr))
                        {
                            
                            com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                            com.Parameters.AddWithValue("@SoPopust", false);
                            com.Parameters.AddWithValue("@Popust", 0);
                            com.Parameters.AddWithValue("@FirmaID", settings.firmaId);

                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();

                            int partnerID = Tools.PrazenStringToInt(partner.dr.Cells["ID"].Value.ToString());
                            MFakturi.Forms.frmKasa kasa = new MFakturi.Forms.frmKasa();
                            if (kasa.PratiNaPrinterSmetkaA4(tmpConfigs.LogiranUserFullName, lblBrNaSmetka.Text, SmetkaID, partnerID))
                            {
                                IspecatiIZatvoriSmetkaSoSveFiskalna(false, 0);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Одбравте погрешен партнер !!!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        private void фактураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                        com.Parameters.AddWithValue("@SoPopust", false);
                        com.Parameters.AddWithValue("@Popust", 0);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);

                        con.Open();
                        com.ExecuteNonQuery();
                        int partnerID = -1;
                        MFakturi.Forms.frmKasa kasa = new MFakturi.Forms.frmKasa();
                        kasa.pecatiFakturaA4(SmetkaID, partnerID);

                        prikaziSmetki();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        private void интеренДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
                {
                    try
                    {
                        
                        com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                        com.Parameters.AddWithValue("@SoPopust", false);
                        com.Parameters.AddWithValue("@Popust", 0);
                        com.Parameters.AddWithValue("@FirmaID", settings.firmaId);

                        con.Open();
                        com.ExecuteNonQuery();


                        DialogResult opc = DialogResult.No;
                        var asm = System.Reflection.Assembly.Load("MMaterijalno");
                        var t = asm.CreateInstance("MMaterijalno.Forms.frmObrabotkaNaInterniDokumenti", true)?.GetType();
                        {
                            var frm = (Form)Activator.CreateInstance(t, new object[] { SmetkaID, true });
                            opc = frm.ShowDialog();
                        }

                        prikaziSmetki();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        return;
                    }
                }
            }
        }

        private string barcode = string.Empty;

        private void frmKelner_KeyUp(object sender, KeyEventArgs e)
        {
            //
            if (e.KeyCode.ToString().Contains("D") || e.KeyCode.ToString().Contains("Return"))
            {

                barcode += e.KeyCode.ToString();
                string formatiranbarcode = barcode.Replace("D", "").Replace("Return", "");
                if (e.KeyCode == Keys.Enter && formatiranbarcode.Length >= 7)
                {
                }

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                return;
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                return;
            }
            if (!txtSearch.IsTextEmpty())
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var itemB = ArtikliDataSet.Tables["Artikli"].Select("Naziv LIKE '" + txtSearch.Text + "'", string.Empty).FirstOrDefault();
                    if (itemB != null)
                    {
                        using (var presItem = new btnArtikal(Tools.PrazenStringToInt(itemB["ID"].ToString()), itemB["Naziv"].ToString(), itemB["ProdaznaCena"].ToString(), 100, itemB["Normativ"].ToString(), 0, itemB["Image"].ToString()))
                        {
                            presItem.Parent = this;
                            presItem.PerformClick();
                            txtSearch.Clear();
                            txtSearch.Focus();
                        }
                    }
                    else
                    {
                        txtSearch.Clear();
                        txtSearch.Focus();
                        Kolicina = 1;
                    }

                }
            }
        }

        private void refreshSmetkiTimer_Tick(object sender, EventArgs e)
        {
            if (splitContainer4.Panel1Collapsed == true &&
              splitContainer2.Panel2Collapsed == true &&
              VkupnoNaloziTextGore.Visible == false &&
              smetkTextGore.Visible == false)
            {
                if (!Kasa)
                {
                    prikaziSmetki();
                }
                else
                {
                    prikaziSmetkiKasa();
                }
            }

        }

    }
}
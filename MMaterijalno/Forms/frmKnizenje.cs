using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BssBase;

namespace MMaterijalno.Forms
{
    public partial class frmKnizenje : frmBigEdit
    {

        public frmKnizenje()
        {
            InitializeComponent();
            vSmetkaKnizenjegrdBase.getMenu().Items.Clear();
            vSmetkaKnizenjegrdBase.prikaziMeniSoExportiranja = false;
            vSmetkaKnizenjegrdBase.SetirajStikliranje();
            vSmetkaKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Text = "Прокнижи ги означените ставки";
            vSmetkaKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje_Click);

            vPriemiKnizenjegrdBase.getMenu().Items.Clear();
            vPriemiKnizenjegrdBase.prikaziMeniSoExportiranja = false;
            vPriemiKnizenjegrdBase.SetirajStikliranje();
            vPriemiKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Text = "Прокнижи ги означените ставки";
            vPriemiKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje2_Click);

            vFakturiKnzienogrdBase.getMenu().Items.Clear();
            vFakturiKnzienogrdBase.prikaziMeniSoExportiranja = false;
            vFakturiKnzienogrdBase.SetirajStikliranje();
            vFakturiKnzienogrdBase.getMenu().Items["ProkniziSelektirani"].Text = "Прокнижи ги означените ставки";
            vFakturiKnzienogrdBase.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje3_Click);

            vDokumentiGrd.getMenu().Items.Clear();
            vDokumentiGrd.prikaziMeniSoExportiranja = false;
            vDokumentiGrd.SetirajStikliranje();
            vDokumentiGrd.getMenu().Items["ProkniziSelektirani"].Text = "Прокнижи ги означените ставки";
            vDokumentiGrd.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje4_Click);
        }

        public bool storniraj;

        public frmKnizenje(bool storniraNje)
        {
            InitializeComponent();
            storniraj = storniraNje;
            vSmetkaKnizenjegrdBase.getMenu().Items.Clear();
            vSmetkaKnizenjegrdBase.prikaziMeniSoExportiranja = false;
            vSmetkaKnizenjegrdBase.SetirajStikliranje();
            vSmetkaKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Text = "Сторнирај ги означените ставки";
            vSmetkaKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje_Click);

            vPriemiKnizenjegrdBase.getMenu().Items.Clear();
            vPriemiKnizenjegrdBase.prikaziMeniSoExportiranja = false;
            vPriemiKnizenjegrdBase.SetirajStikliranje();
            vPriemiKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Text = "Сторнирај ги означените ставки";
            vPriemiKnizenjegrdBase.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje2_Click);

            vFakturiKnzienogrdBase.getMenu().Items.Clear();
            vFakturiKnzienogrdBase.prikaziMeniSoExportiranja = false;
            vFakturiKnzienogrdBase.SetirajStikliranje();
            vFakturiKnzienogrdBase.getMenu().Items["ProkniziSelektirani"].Text = "Сторнирај ги означените ставки";
            vFakturiKnzienogrdBase.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje3_Click);

            vDokumentiGrd.getMenu().Items.Clear();
            vDokumentiGrd.prikaziMeniSoExportiranja = false;
            vDokumentiGrd.SetirajStikliranje();
            vDokumentiGrd.getMenu().Items["ProkniziSelektirani"].Text = "Сторинирај ги означените ставки";
            vDokumentiGrd.getMenu().Items["ProkniziSelektirani"].Click += new EventHandler(frmKnizenje4_Click);

            btnProkniziFakturi.Text = "Сторнирај фактури";
            btnProkniziPriemi.Text = "Сторнирај приеми";
            btnProkniziSmetki.Text = "Сторнирај сметки";
            btnProkniziInterni.Text = "Сторнирај интерни";
        }

        private void frmKnizenje3_Click(object sender, EventArgs e)
        {
            btnProkniziFakturi.PerformClick();
        }

        private void frmKnizenje4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void frmKnizenje2_Click(object sender, EventArgs e)
        {
            btnProkniziPriemi.PerformClick();
        }

        private void frmKnizenje_Click(object sender, EventArgs e)
        {
            btnProkniziSmetki.PerformClick();
        }

        private bool loaded = false;
        private void frmKnizenje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materijalnoDataSet.vDokumentiKnizeno' table. You can move, or remove it, as needed.
            datum.Value = DateTime.Now;

            if (!BssBase.tmpConfigs.MainActiveForms.Fakturi) MainTab.TabPages.Remove(tabFakturi);
            if (!BssBase.tmpConfigs.MainActiveForms.Priem) MainTab.TabPages.Remove(tabPriemi);
            if (!BssBase.tmpConfigs.MainActiveForms.Interni) MainTab.TabPages.Remove(tabInterni);
            if (!BssBase.tmpConfigs.MainActiveForms.Smetki) MainTab.TabPages.Remove(tabVnes);

            FillDatasets(datum.Value);

            if (settings.TipNaPrograma == "987" || settings.ProkniziSmetki == "1")
            {
                if (MainTab.TabPages.Contains(tabVnes))
                    MainTab.TabPages.Remove(tabVnes);

            }
            if (settings.TipNaPrograma == "988Kasa")
            {
                if(MainTab.TabPages.Contains(tabPriemi))
                {
                    MainTab.TabPages.Remove(tabPriemi);
                }
                
            }

            loaded = true;

            
        }

        private DateTime dateStart;
        private DateTime dateEnd;
        private void FillDatasets(DateTime starDateTime)
        {
             dateStart = new DateTime(starDateTime.Year,starDateTime.Month,starDateTime.Day, 0,0,0);
             dateEnd = new DateTime(starDateTime.Year, starDateTime.Month, starDateTime.Day, 23, 59, 59);

            if (!storniraj)
            {
                if (BssBase.tmpConfigs.MainActiveForms.Fakturi)
                {
                    vFakturiKnzienoBindingSource.Filter = " Knizeno = 0";
                    vFakturiKnzienoTableAdapter.FillByDatum(materijalnoDataSet.vFakturiKnzieno, dateStart, dateEnd);
                }

                if (BssBase.tmpConfigs.MainActiveForms.Priem)
                {
                    vPriemiKnizenjeBindingSource.Filter = "Knizeno = 0";
                    vPriemiKnizenjeTableAdapter.FillByDatumPriem(materijalnoDataSet.vPriemiKnizenje, dateStart, dateEnd);
                }

                if (settings.ProkniziSmetki != "1")
                {
                    vSmetkaKnizenjeBindingSource.Filter = "Zatvorena = 'true' AND Knizeno = 0";
                    vSmetkaKnizenjeTableAdapter.FillByDatum(materijalnoDataSet.vSmetkaKnizenje, dateStart, dateEnd);
                }
                if (BssBase.tmpConfigs.MainActiveForms.Interni)
                {
                    vDokumentiKnizenoBindingSource.Filter = "Knizeno = 0 AND TipNaKnizenje <> -1";
                    vDokumentiKnizenoTableAdapter.FillByDatum(materijalnoDataSet.vDokumentiKnizeno, dateStart, dateEnd);
                }
            }
            else
            {
                if (BssBase.tmpConfigs.MainActiveForms.Fakturi)
                {
                    vFakturiKnzienoBindingSource.Filter = " Knizeno = 1";
                    vFakturiKnzienoTableAdapter.FillByDatum(materijalnoDataSet.vFakturiKnzieno, dateStart, dateEnd);
                }

                if (BssBase.tmpConfigs.MainActiveForms.Priem)
                {
                    vPriemiKnizenjeBindingSource.Filter = "Knizeno = 1";
                    vPriemiKnizenjeTableAdapter.FillByDatumPriem(materijalnoDataSet.vPriemiKnizenje, dateStart, dateEnd);
                }

                if (settings.ProkniziSmetki != "1")
                {
                    vSmetkaKnizenjeBindingSource.Filter = "Zatvorena = 'true' AND Knizeno = 1";
                    vSmetkaKnizenjeTableAdapter.FillByDatum(materijalnoDataSet.vSmetkaKnizenje, dateStart, dateEnd);
                }
                if (BssBase.tmpConfigs.MainActiveForms.Interni)
                {
                    vDokumentiKnizenoBindingSource.Filter = "Knizeno = 1 AND TipNaKnizenje <> -1";
                    vDokumentiKnizenoTableAdapter.FillByDatum(materijalnoDataSet.vDokumentiKnizeno, dateStart, dateEnd);
                }

                btnProkniziFakturi.BackColor = Color.Red;
                btnProkniziSmetki.BackColor = Color.Red;
                btnProkniziPriemi.BackColor = Color.Red;
                btnProkniziInterni.BackColor = Color.Red;
            }
        }

        private void FillDatasetsWithAllData()
        {
            

            if (!storniraj)
            {
                if(BssBase.tmpConfigs.MainActiveForms.Fakturi) {
                    vFakturiKnzienoBindingSource.Filter = " Knizeno = 0";
                    vFakturiKnzienoTableAdapter.Fill(materijalnoDataSet.vFakturiKnzieno);
                }

                if (BssBase.tmpConfigs.MainActiveForms.Priem)
                {
                    vPriemiKnizenjeBindingSource.Filter = "Knizeno = 0";
                    vPriemiKnizenjeTableAdapter.Fill(materijalnoDataSet.vPriemiKnizenje);
                }

                if (settings.ProkniziSmetki != "1")
                {
                    vSmetkaKnizenjeBindingSource.Filter = "Zatvorena = 'true' AND Knizeno = 0";
                    vSmetkaKnizenjeTableAdapter.Fill(materijalnoDataSet.vSmetkaKnizenje);
                }
                if (BssBase.tmpConfigs.MainActiveForms.Interni)
                {
                    vDokumentiKnizenoBindingSource.Filter = "Knizeno = 0 AND TipNaKnizenje <> -1";
                    vDokumentiKnizenoTableAdapter.Fill(materijalnoDataSet.vDokumentiKnizeno);
                }
            }
            else
            {
                if (BssBase.tmpConfigs.MainActiveForms.Fakturi)
                {
                    vFakturiKnzienoBindingSource.Filter = " Knizeno = 1";
                    vFakturiKnzienoTableAdapter.Fill(materijalnoDataSet.vFakturiKnzieno);
                }

                if (BssBase.tmpConfigs.MainActiveForms.Priem)
                {
                    vPriemiKnizenjeBindingSource.Filter = "Knizeno = 1";
                    vPriemiKnizenjeTableAdapter.Fill(materijalnoDataSet.vPriemiKnizenje);
                }

                if (settings.ProkniziSmetki != "1")
                {
                    vSmetkaKnizenjeBindingSource.Filter = "Zatvorena = 'true' AND Knizeno = 1";
                    vSmetkaKnizenjeTableAdapter.Fill(materijalnoDataSet.vSmetkaKnizenje);
                }
                if (BssBase.tmpConfigs.MainActiveForms.Interni)
                {
                    vDokumentiKnizenoBindingSource.Filter = "Knizeno = 1 AND TipNaKnizenje <> -1";
                    vDokumentiKnizenoTableAdapter.Fill(materijalnoDataSet.vDokumentiKnizeno);
                }

                btnProkniziFakturi.BackColor = Color.Red;
                btnProkniziSmetki.BackColor = Color.Red;
                btnProkniziPriemi.BackColor = Color.Red;
                btnProkniziInterni.BackColor = Color.Red;
            }
        }
        private void btnSiteSmetki_Click(object sender, EventArgs e)
        {
            vSmetkaKnizenjegrdBase.StiklirajGISite();
        }

        private void proknizigiSiteSmetki()
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow item in vSmetkaKnizenjegrdBase.Rows)
            {
                bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                if (value)
                {
                    if (!storniraj)
                    {
                        using (SqlConnection con = new SqlConnection(settings.konekcija))
                        {
                            Tools.ProkniziSmetka(Tools.PrazenStringToInt(item.Cells["ID"].Value.ToString()));
                        }
                    }
                    else
                    {
                        StornirajKniznjaSmetka(Tools.PrazenStringToInt(item.Cells["ID"].Value.ToString()));
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void StornirajKniznjaSmetka(int smetka)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblKnizenjeM where tblSmetkaID = @ID", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ID", smetka);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void StornirajKniznjaPriemi(int priem)
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblKnizenjeM where tblPriemID = @ID", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ID", priem);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
        }

        private void StornirajKniznjaFakturi(int faktura)
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblKnizenjeM where tblFakturaID = @FakturaID", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@FakturaID", faktura);
                        con.Open();
                        com.ExecuteNonQuery();
                        com.CommandText = "select ListaNaIspratnici  from tblFaktura where ID = @FakturaID";
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@FakturaID", faktura);
                        var rez = com.ExecuteScalar().ToString();

                        if (!Equals(rez, DBNull.Value))
                            if (!Equals(rez, null))
                            {
                                string listaSoIspratnici = rez.ToString();
                                con.Close();

                                foreach (string broj in listaSoIspratnici.Split(';'))
                                {
                                    int brojDokument = Tools.PrazenStringToInt(broj, -1);
                                    if (brojDokument != -1)
                                    {
                                        Tools.SmeniTipNaDokumentZaDokumentBroj(brojDokument, tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi, tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceNeSeKnizi);
                                    }
                                }
                            }
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
        }

        private void StornirajKniznjaInterni(int dokumentiID)
        {
            using (SqlConnection con = new SqlConnection(settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblKnizenjeM where tblDokumentID = @ID", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ID", dokumentiID);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                    }
                }
            }
        }

        private void proknizigiPriemi()
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow item in vPriemiKnizenjegrdBase.Rows)
            {
                bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                if (value)
                {
                    if (!storniraj)
                    {
                        Tools.ProkniziPriem(Tools.PrazenStringToInt(item.Cells["IDPriem"].Value.ToString()));
                    }
                    else
                    {
                        StornirajKniznjaPriemi(Tools.PrazenStringToInt(item.Cells["IDPriem"].Value.ToString()));
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void proknizigiFakturi()
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow item in vFakturiKnzienogrdBase.Rows)
            {
                bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                if (value)
                {
                    if (!storniraj)
                    {
                        Tools.ProkniziFaktura(Tools.PrazenStringToInt(item.Cells["IDFaktura"].Value.ToString()));
                    }
                    else
                    {
                        StornirajKniznjaFakturi(Tools.PrazenStringToInt(item.Cells["IDFaktura"].Value.ToString()));
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void proknizigiInterni()
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow item in vDokumentiGrd.Rows)
            {
                bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                if (value)
                {
                    if (!storniraj)
                    {
                        if (!settings.NovNacinNaKnizenjeDokumenti)
                        {
                            Tools.ProkniziDokument(Tools.PrazenStringToInt(item.Cells["IDD"].Value.ToString()));
                        } else
                        {
                            Tools.ProkniziDokument_NOVOKnizenje(Tools.PrazenStringToInt(item.Cells["IDD"].Value.ToString()));
                        }
                    }
                    else
                    {
                        StornirajKniznjaInterni(Tools.PrazenStringToInt(item.Cells["IDD"].Value.ToString()));
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnProkniziSmetki_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ги обработите селектираните ставки ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                proknizigiSiteSmetki();
                if (!storniraj)
                {
                    vSmetkaKnizenjeBindingSource.Filter = "Zatvorena = 'true' AND Knizeno = 0";
                    vSmetkaKnizenjeTableAdapter.FillByDatum(materijalnoDataSet.vSmetkaKnizenje,dateStart,dateEnd);
                }
                else
                {
                    vSmetkaKnizenjeBindingSource.Filter = "Zatvorena = 'true' AND Knizeno = 1";
                    vSmetkaKnizenjeTableAdapter.FillByDatum(materijalnoDataSet.vSmetkaKnizenje, dateStart, dateEnd);
                }
            }
        }

        private void btnProkniziPriemi_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ги обработите селектираните ставки ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                proknizigiPriemi();
                if (!storniraj)
                {
                    vPriemiKnizenjeBindingSource.Filter = " Knizeno = 0";
                    vPriemiKnizenjeTableAdapter.FillByDatumPriem(materijalnoDataSet.vPriemiKnizenje,dateStart,dateEnd);
                }
                else
                {
                    vPriemiKnizenjeBindingSource.Filter = " Knizeno = 1";
                    vPriemiKnizenjeTableAdapter.FillByDatumPriem(materijalnoDataSet.vPriemiKnizenje, dateStart, dateEnd);
                }
            }
        }

        private void btnProkniziFakturi_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ги обработите селектираните ставки ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                proknizigiFakturi();
                if (!storniraj)
                {
                    vFakturiKnzienoBindingSource.Filter = " Knizeno = 0";
                    vFakturiKnzienoTableAdapter.FillByDatum(materijalnoDataSet.vFakturiKnzieno,dateStart, dateEnd);
                }
                else
                {
                    vFakturiKnzienoBindingSource.Filter = " Knizeno = 1";
                    vFakturiKnzienoTableAdapter.FillByDatum(materijalnoDataSet.vFakturiKnzieno, dateStart, dateEnd);
                }
            }
        }

        private void btnSelektirajFakturi_Click(object sender, EventArgs e)
        {
            vFakturiKnzienogrdBase.StiklirajGISite();
        }

        private void btnSelektirajPriemi_Click(object sender, EventArgs e)
        {
            vPriemiKnizenjegrdBase.StiklirajGISite();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сте сигурни дека сакате да ги обработите селектираните ставки ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                proknizigiInterni();
                if (!storniraj)
                {
                    vDokumentiKnizenoBindingSource.Filter = " Knizeno = 0 AND TipNaKnizenje <> -1";
                    vDokumentiKnizenoTableAdapter.FillByDatum(materijalnoDataSet.vDokumentiKnizeno, dateStart, dateEnd);
                }
                else
                {
                    vDokumentiKnizenoBindingSource.Filter = " Knizeno = 1 AND TipNaKnizenje <> -1";
                    vDokumentiKnizenoTableAdapter.FillByDatum(materijalnoDataSet.vDokumentiKnizeno, dateStart, dateEnd);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vDokumentiGrd.StiklirajGISite();
        }

        private void datum_ValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                FillDatasets(datum.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillDatasetsWithAllData();
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmFiskalniSmetki : frmBigShow
    {
        public frmFiskalniSmetki()
        {
            settings.NeSreduajMeni = true;
            InitializeComponent();
            btnOk.Visible = false;
            dtPickerBase1.Value = DateTime.Now;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
            {
                tblFiskalniSmetkiBindingSource.Filter = Tools.vratiFilterCelosenOD_DO_datum(dtPickerBase1.Value, dtPickerBase1.Value, "Datum");
                tblFiskalniSmetkiTableAdapter.Fill(bSSSDataset.tblFiskalniSmetki);
            }
           
            btnBlokiraj.Click += new EventHandler(btnBlokiraj_Click);
        }

        public bool PecatiFiskalna(DataTable artikliZaFiskalna, int SmetkaID)
        {
            if (settings.PrasajZaFiskalna == true)
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka(" Дали сакате да ја сочувате сметката ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
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
                var fiskalna = new FiscalCash(this.Name);
                fiskalna.InitInterface();
                fiskalna.ArtikliZaNaFiskalna(true, artikliZaFiskalna);
                fiskalna.IssueStorno();
                rezultat = true;
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return true;
            }

            return rezultat;
        }

        private void btnBlokiraj_Click(object sender, EventArgs e)
        {
           

            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                if (storniraj())
                {
                    try
                    {
                        var ArtikliZaFiskalna = new DataTable("ArtikliZaFiskalna");

                        var smetkaID = Tools.PrazenStringToInt(((DataRowView)tblFiskalniSmetkiBindingSource.Current)["tblSmetkaID"].ToString());

                        if (!dbFunctions.DaliSmetkataEZatvorena(smetkaID))
                        {
                            MessageBox.Show(@"Сметката е сеуште отворена, сторнирање не е возможно ," + Environment.NewLine + @" \n Сметката мора да биде затворена за да ја користите оваа опција ", "Внимание !!! Оваа сметка е веќе отворена", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        if (dbFunctions.DaliImaImaKnizeno(smetkaID))
                        {
                            MessageBox.Show(@"Oваа сметка е веќе прокнижена во материјална евиденција," + Environment.NewLine + @" Доколку сакате да ја отворите мора прво да ја сторнирате од книжењата во материјална Евиденција", "Внимание !!! Прокнижена сметка ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        //if (dbFunctions.DaliSmetkataZaStorniranjeNaFiskalnaESoDenesenDatum(smetkaID))
                        //{
                        //    MessageBox.Show(@"Сметката не е со денешен датум или веќе е сторнирана ," + Environment.NewLine + @" \n Сметката мора да биде со денешен датум за да ја сторнирате ", "Внимание !!! Оваа сметка не е со денешен датум", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //    return;
                        //}


                    

                        using (var con = new SqlConnection(settings.konekcija))
                        {
                            //treba da se proveri
                            using (var Smetki = new SqlCommand("Select * from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID", con))
                            {
                                Smetki.Parameters.Clear();
                                Smetki.Parameters.AddWithValue("@SmetkaID", smetkaID);
                                con.Open();
                                ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                                con.Close();
                            }
                        }
                        if (ArtikliZaFiskalna.Rows.Count > 0)
                        {
                            if( PecatiFiskalna(ArtikliZaFiskalna, smetkaID)) {
                            using (SqlConnection con = new SqlConnection(settings.konekcija))
                            {
                                using( SqlCommand com = new SqlCommand(@"update tblFiskalniSmetki set Stornirana = 'true' where tblSmetkaID = @SmetkaID ; delete from tblKnizenjeM where tblSmetkaID = @SmetkaID", con)){
                                    con.Open();
                                    com.Parameters.AddWithValue("@SmetkaID", smetkaID);
                                    com.ExecuteNonQuery();
                                }
                                MessageBox.Show(Tools.PrevediPoraka("Сторнирана"));
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
            }
        }

        public bool storniraj()
        {
            return true;
        }

        private void tblFiskalniSmetkigrdBase_DataInsert()
        {
            tblFiskalniSmetkiBindingSource.Filter = Tools.vratiFilterCelosenOD_DO_datum(dtPickerBase1.Value, dtPickerBase1.Value, "Datum");
            tblFiskalniSmetkiTableAdapter.Fill(bSSSDataset.tblFiskalniSmetki);
        }

        private void tblFiskalniSmetkigrdBase_dataSaveAll()
        {
            
        }

        private void tblFiskalniSmetkigrdBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }

        private void frmFiskalniSmetki_Load(object sender, EventArgs e)
        {
            btnBlokiraj.Visible = true;
            btnBlokiraj.Text = " Сторнирај фискална сметка";
            btnFilter.Visible = false;
            btnIzbrisi.Visible = false;
            btnNovZapis.Visible = false;
            btnEditirajZapis.Visible = false;
            dtPickerBase1.Value = DateTime.Now;
        }
    }
}
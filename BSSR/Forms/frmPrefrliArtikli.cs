using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BSSR.Forms
{
    public partial class frmPrefrliArtikli : Form
    {
        private const string strServer = @"\Prenos\{0}server.txt";
        private const string strBazi = @"\Prenos\{0}bazi.txt";
        private const string strTabeli = @"\Prenos\{0}tabeli.txt";

        public frmPrefrliArtikli(string MomentalnaKonekcija)
        {
            InitializeComponent();
            cmbServer.SelectedIndex = 0;
            txtBaza.SelectedIndex = 0;
            ArtikliOD.SetirajStikliranje();
            string tipNaPrograma = BssBase.settings.TipNaPrograma;
            if(BssBase.settings.TipNaPrograma != "888")
            {
                tipNaPrograma = string.Empty;
            }

            if (File.Exists(Application.StartupPath + string.Format(strServer, tipNaPrograma)))
            {
                cmbServer.LoadItemsFromFile(Application.StartupPath + string.Format(strServer, tipNaPrograma));
            }

            if (File.Exists(Application.StartupPath + string.Format(strTabeli, tipNaPrograma)))
            {
                cmbTabela.LoadItemsFromFile(Application.StartupPath + string.Format(strTabeli, tipNaPrograma));
            }

            if (File.Exists(Application.StartupPath + string.Format(strBazi, tipNaPrograma)))
            {
                txtBaza.LoadItemsFromFile(Application.StartupPath + string.Format(strBazi, tipNaPrograma));
            }
            label1.Text = MomentalnaKonekcija;
        }

        public void najdiPodatociStoGiImaVoMainAgiNemaNaDrugiteServeri()
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            string SQL = string.Format(@"select * from {0} where CAST(ID as nvarchar(MAX)) + {3} not in (Select CAST(ID as nvarchar(MAX)) + {3} from [{1}].[{2}].[dbo].{0})", cmbTabela.Text.Split('-').FirstOrDefault(), cmbServer.Text, txtBaza.Text, cmbTabela.Text.Split('-').LastOrDefault().Split(',').LastOrDefault());
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(SQL, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandTimeout = 0;
                        DataTable noviArtikli = new DataTable();
                        noviArtikli.Load(com.ExecuteReader());
                        ArtikliOD.DataSource = noviArtikli;
                        ArtikliOD.SetirajStikliranje();
                    }
                    catch (SqlException ex)
                    {
                        Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                        MessageBox.Show("Настана грешка при конектирање !");
                        return;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            najdiPodatociStoGiImaVoMainAgiNemaNaDrugiteServeri();
        }

        public void PrefrliGoOdbraniot(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQL = string.Format(@" INSERT INTO [{0}].[{1}].[dbo].{2} select * from {2} where CAST(ID as nvarchar(MAX)) + {3} not in (Select CAST(ID as nvarchar(MAX)) + {3} from [{0}].[{1}].[dbo].{2} WHERE ID = {4} )", cmbServer.Text, txtBaza.Text, cmbTabela.Text.Split('-').FirstOrDefault(), cmbTabela.Text.Split('-').LastOrDefault().Split(',').LastOrDefault(), ID);
                using (SqlCommand com = new SqlCommand(SQL, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandTimeout = 0;
                        var resut = com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                        MessageBox.Show("Настана грешка при конектирање !");
                        return;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        public void PrefrligiSiteStoGinema()
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQL = string.Format(@"INSERT INTO [{0}].[{1}].[dbo].{2} select * from {2} where CAST(ID as nvarchar(MAX)) + {3} not in (Select CAST(ID as nvarchar(MAX)) + {3} from [{0}].[{1}].[dbo].{2})", cmbServer.Text, txtBaza.Text, cmbTabela.Text.Split('-').FirstOrDefault(), cmbTabela.Text.Split('-').LastOrDefault().Split(',').LastOrDefault());
                using (SqlCommand com = new SqlCommand(SQL, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandTimeout = 0;
                        var resut = com.ExecuteNonQuery();
                        MessageBox.Show("Префрлено");
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                        MessageBox.Show("Настана грешка при конектирање !");
                        return;
                    }
                }
            }
            button1.PerformClick();
        }

        public DataTable NajdiGiStePodatociVoGlavnaBaza(string konekcija)
        {
            if (cmbServer.SelectedIndex == -1) return null;
            if (txtBaza.SelectedIndex == -1) return null;
            if (cmbTabela.SelectedIndex == -1) return null;
            Cursor.Current = Cursors.WaitCursor;
            string SQL = string.Format(@"select * from {0} ORDER BY ID", cmbTabela.Text.Split('-').FirstOrDefault());
            using (SqlConnection con = new SqlConnection(konekcija))
            {
                using (SqlCommand com = new SqlCommand(SQL, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandTimeout = 0;
                        DataTable noviArtikli = new DataTable();
                        noviArtikli.Load(com.ExecuteReader());
                        Cursor.Current = Cursors.Default;
                        return noviArtikli;
                    }
                    catch (SqlException ex)
                    {
                        Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                        MessageBox.Show("Настана грешка при конектирање !");
                        Cursor.Current = Cursors.Default;
                        return null;
                    }
                }
                
            }
            
        }

        public void NajdiGIPodatociteStoNePostojatVoGlavnaBaza()
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            string SQL = $@"select * from [{cmbServer.Text}].[{txtBaza.Text}].[dbo].{cmbTabela.Text.Split('-').FirstOrDefault()} where ID not in (Select ID from {cmbTabela.Text.Split('-').FirstOrDefault()})";
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(SQL, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandTimeout = 0;
                        DataTable noviArtikli = new DataTable();
                        noviArtikli.Load(com.ExecuteReader());
                        ArtikliOD.DataSource = noviArtikli;
                        ArtikliOD.SetirajStikliranje();
                    }
                    catch (SqlException ex)
                    {
                        Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                        MessageBox.Show("Настана грешка при конектирање !");
                        return;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        public void IzbrisigiPodatociteStoNepostojatVoGlavnataBaza(int brisiID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQL = string.Format(@"delete from [{0}].[{1}].[dbo].{2} Where ID = {3}", cmbServer.Text, txtBaza.Text, cmbTabela.Text.Split('-').FirstOrDefault(), brisiID);
                using (SqlCommand com = new SqlCommand(SQL, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandTimeout = 0;
                        var resut = com.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                        MessageBox.Show("Настана грешка при конектирање !");
                        return;
                    }
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void Prenesi_Click(object sender, EventArgs e)
        {
            DialogResult opc;

            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                PrefrligiSiteStoGinema();
            }
            MessageBox.Show("Префрлено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult opc;

            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach (DataGridViewRow item in ArtikliOD.Rows)
                {
                    bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (value)
                    {
                        int id = Tools.PrazenStringToInt(item.Cells["ID"].Value.ToString());
                        PrefrliGoOdbraniot(id);
                    }
                }
                Cursor.Current = Cursors.Default;
                button1.PerformClick();
                MessageBox.Show("Префрлено ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NajdiGIPodatociteStoNePostojatVoGlavnaBaza();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult opc;

            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach (DataGridViewRow item in ArtikliOD.Rows)
                {
                    bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (value)
                    {
                        int id = Tools.PrazenStringToInt(item.Cells["ID"].Value.ToString());
                        IzbrisigiPodatociteStoNepostojatVoGlavnataBaza(id);
                    }
                }
                Cursor.Current = Cursors.Default;
                button3.PerformClick();
                MessageBox.Show("Избришано");
            }
        }


        public void UpdatetirajTblEdinecniMerki(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblEdinecniMerki
                   SET Naziv = @Naziv
                      ,Kratenka = @Kratenka
                      ,FirmaID = @FirmaID
                      ,Status = @Status
                 WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblEdinecniMerki where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("Kratenka", reader["Kratenka"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);

                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }

        public void UpdatetirajTblBanki(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblBanki
                   SET Sifra = @Sifra
                      ,Naziv = @Naziv
                      ,Status = @Status
                      ,FirmaID = @FirmaID
                 WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblBanki where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Sifra", reader["Sifra"]);
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);

                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }


        public void UpdatetirajTblTipNaDokument(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblTipNaDokument
               SET Naziv = @Naziv
                  ,Status = @Status
                  ,SeKnizi = @SeKnizi
                  ,ReportFileName = @ReportFileName
                  ,TipNaKnizenje = @TipNaKnizenje
                  ,FirmaID = @FirmaID
                  ,Naslov = @Naslov
                  ,Interen = @Interen
             WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblTipNaDokument where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            com.Parameters.AddWithValue("SeKnizi", reader["SeKnizi"]);
                            com.Parameters.AddWithValue("ReportFileName", reader["ReportFileName"]);
                            com.Parameters.AddWithValue("TipNaKnizenje", reader["TipNaKnizenje"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            com.Parameters.AddWithValue("Naslov", reader["Naslov"]);
                            com.Parameters.AddWithValue("Interen", reader["Interen"]);
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }

        public void UpdatetirajTblGrupaNaArtikli(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblGrupaNaArtikli
                   SET Naziv = @Naziv
                      ,Sifra = @Sifra
                      ,Status = @Status
                      ,FirmaID = @FirmaID
                      ,Image = @Image
                 WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblGrupaNaArtikli where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("Sifra", reader["Sifra"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            com.Parameters.AddWithValue("Image", reader["Image"]);
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }
        public void UpdatetirajTblPodgrupa(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblPodgrupaID
                   SET GrupaID = @GrupaID
                      ,Naziv = @Naziv
                      ,FirmaID = @FirmaID
                      ,Status = @Status
                      ,Image = @Image
                 WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblPodgrupaID where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("GrupaID", reader["GrupaID"]);
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            com.Parameters.AddWithValue("Image", reader["Image"]);
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }

        public void UpdatetirajTblObjekti(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblObjekti
                   SET Naziv = @Naziv
                      ,Sifra = @Sifra
                      ,FirmaID = @FirmaID
                      ,Status = @Status
                 WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblObjekti where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("Sifra", reader["Sifra"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }


        public void UpdatetirajTblPrevodi(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblPrevodi
                   SET KlucenZbor = @KlucenZbor
                      ,MK = @MK
                      ,AL = @AL
                      ,EN = @EN
                      ,SR = @SR
                 WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblPrevodi where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;
                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("KlucenZbor", reader["KlucenZbor"]);
                            com.Parameters.AddWithValue("MK", reader["MK"]);
                            com.Parameters.AddWithValue("AL", reader["AL"]);
                            com.Parameters.AddWithValue("EN", reader["EN"]);
                            com.Parameters.AddWithValue("SR", reader["SR"]);
                     
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }


        public void UpdatetirajTblPartner(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblPartneri
               SET Sifra = @Sifra
                  ,Naziv = @Naziv
                  ,Adresa = @Adresa
                  ,Telefoni = @Telefoni
                  ,Email = @Email
                  ,EDB = @EDB
                  ,Mesto = @Mesto
                  ,Tip = @Tip
                  ,Status = @Status
                  ,FirmaID = @FirmaID
             WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblPartneri where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;

                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Sifra", reader["Sifra"]);
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("Adresa", reader["Adresa"]);
                            com.Parameters.AddWithValue("Telefoni", reader["Telefoni"]);
                            com.Parameters.AddWithValue("Email", reader["Email"]);
                            com.Parameters.AddWithValue("Mesto", reader["Mesto"]);
                            com.Parameters.AddWithValue("Tip", reader["Tip"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }

        public void UpdatetirajTblAkcijaArtikal(int ID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string SQLTO = string.Format(@"UPDATE tblAkcijaNaArtikal SET DatumPocetok = @DatumPocetok,
                    DatumKraj = @DatumKraj,tblArtikalID = @tblArtikalID,AkciskaCena = @AkciskaCena,Rabat = @Rabat
                    WHERE ID = {0}", ID);

                string SQLFrom = string.Format(@"Select * from tblAkcijaNaArtikal where ID={0}", ID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;

                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("DatumPocetok", reader["DatumPocetok"]);
                            com.Parameters.AddWithValue("DatumKraj", reader["DatumKraj"]);
                            com.Parameters.AddWithValue("tblArtikalID", reader["tblArtikalID"]);
                            com.Parameters.AddWithValue("AkciskaCena", reader["AkciskaCena"]);
                            com.Parameters.AddWithValue("Rabat", reader["Rabat"]);
                            
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }

        public void UpdatetirajArtikNaDadeniotServer(int artikalID)
        {
            if (cmbServer.SelectedIndex == -1) return;
            if (txtBaza.SelectedIndex == -1) return;
            if (cmbTabela.SelectedIndex == -1) return;
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {//[{0}].[{1}].[dbo].
                string SQLTO = string.Format(@"Update tblArtikal  SET Sifra = @Sifra
                  ,Naziv = @Naziv
                  ,tblDDVStavkaID = @tblDDVStavkaID
                  ,PodgrupaID = @PodgrupaID
                  ,tblEdinecniMerkiID =@tblEdinecniMerkiID
                  ,AltNaziv = @AltNaziv
                  ,AltSifra = @AltSifra
                  ,KlucniZborovi = @KlucniZborovi
                  ,NabavnaCena = @NabavnaCena
                  ,ProdaznaCena = @ProdaznaCena
                  ,FirmaID = @FirmaID
                  ,Status = @Status
                  ,EDMIzlez = @EDMIzlez
                  ,KolicinaT = @KolicinaT
                  ,MinimalnaKolicinaNaZaliha = @MinimalnaKolicinaNaZaliha
                  ,RedenBroj = @RedenBroj
                  ,Barkod1 =@Barkod1
                  ,Barkod2 = @Barkod2
                  ,AltNaziv2 = @AltNaziv2
                  ,Image = @Image
                  ,SePecatiVoKujna = @SePecatiVoKujna
                  ,SePacatiNaSank =@SePacatiNaSank
                  ,DenoviZaGarancija = @DenoviZaGarancija
                  ,DomasenProizvod = @DomasenProizvod
             WHERE ID = {0}", artikalID);

                string SQLFrom = string.Format(@"Select * from tblArtikal where ID={0}", artikalID);

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(SQLFrom, con))
                {
                    con.Open();
                    reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    reader.Read();
                    using (SqlCommand com = new SqlCommand(SQLTO))
                    {
                        try
                        {
                            string conec = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
                            SqlConnection comcon = new SqlConnection(conec);
                            com.Connection = comcon;

                            comcon.Open();
                            com.Parameters.Clear();
                            com.Parameters.AddWithValue("Sifra", reader["Sifra"]);
                            com.Parameters.AddWithValue("Naziv", reader["Naziv"]);
                            com.Parameters.AddWithValue("tblDDVStavkaID", reader["tblDDVStavkaID"]);
                            com.Parameters.AddWithValue("PodgrupaID", reader["PodgrupaID"]);
                            com.Parameters.AddWithValue("tblEdinecniMerkiID", reader["tblEdinecniMerkiID"]);
                            com.Parameters.AddWithValue("AltNaziv", reader["AltNaziv"]);
                            com.Parameters.AddWithValue("AltSifra", reader["AltSifra"]);
                            com.Parameters.AddWithValue("KlucniZborovi", reader["KlucniZborovi"]);
                            com.Parameters.AddWithValue("NabavnaCena", reader["NabavnaCena"]);
                            com.Parameters.AddWithValue("ProdaznaCena", reader["ProdaznaCena"]);
                            com.Parameters.AddWithValue("FirmaID", reader["FirmaID"]);
                            com.Parameters.AddWithValue("Status", reader["Status"]);
                            com.Parameters.AddWithValue("EDMIzlez", reader["EDMIzlez"]);
                            com.Parameters.AddWithValue("KolicinaT", reader["KolicinaT"]);
                            com.Parameters.AddWithValue("MinimalnaKolicinaNaZaliha", reader["MinimalnaKolicinaNaZaliha"]);
                            com.Parameters.AddWithValue("RedenBroj", reader["RedenBroj"]);
                            com.Parameters.AddWithValue("Barkod1", reader["Barkod1"]);
                            com.Parameters.AddWithValue("Barkod2", reader["Barkod2"]);
                            com.Parameters.AddWithValue("AltNaziv2", reader["AltNaziv2"]);
                            com.Parameters.AddWithValue("Image", reader["Image"]);
                            com.Parameters.AddWithValue("SePecatiVoKujna", reader["SePecatiVoKujna"]);
                            com.Parameters.AddWithValue("SePacatiNaSank", reader["SePacatiNaSank"]);
                            com.Parameters.AddWithValue("DenoviZaGarancija", reader["DenoviZaGarancija"]);
                            com.Parameters.AddWithValue("DomasenProizvod", reader["DomasenProizvod"]);
                            reader.Close();
                            var resut = com.ExecuteNonQuery();
                            comcon.Close();
                        }
                        catch (SqlException ex)
                        {
                            Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                            MessageBox.Show("Настана грешка при конектирање !");
                            return;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sporednaKonekcija = String.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}; User={2}; Password={3}", cmbServer.Text, txtBaza.Text, "spiro", "nirvana");
            DataTable PodatociMain = NajdiGiStePodatociVoGlavnaBaza(BssBase.settings.konekcija);
            DataTable PodatociCompare = NajdiGiStePodatociVoGlavnaBaza(sporednaKonekcija);
            DataTable noviArtikli = PodatociMain.Clone();
            noviArtikli.Rows.Clear();

            if (PodatociCompare.Rows.Count != PodatociMain.Rows.Count)
            {
                MessageBox.Show("Базите не се синхронизирани");
                return;
            }
            for (int i = 0; i < PodatociMain.Rows.Count; i++)
            {
                foreach (DataColumn item in PodatociMain.Columns)
                {
                    DataRow comp = PodatociCompare.Select("ID = " + PodatociMain.Rows[i]["ID"].ToString()).FirstOrDefault();
                    if (comp == null)
                    {
                        noviArtikli.ImportRow(PodatociMain.Rows[i]);
                        break;
                    }
                    if (PodatociMain.Rows[i][item.ColumnName].ToString() != comp[item.ColumnName].ToString())
                    {
                        
                            noviArtikli.ImportRow(PodatociMain.Rows[i]);
                            break;
                        
                    }
                }
            }
            MessageBox.Show(noviArtikli.Rows.Count.ToString());
            ArtikliOD.DataSource = noviArtikli;
            ArtikliOD.SetirajStikliranje();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            progressBar1.Value = 0;
            progressBar1.Maximum = ArtikliOD.Rows.Count;

            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach (DataGridViewRow item in ArtikliOD.Rows)
                {
                    bool value = Equals(item.Cells["STIKLIRANO"].Value, null) ? false : (bool)(item.Cells["STIKLIRANO"].Value);

                    if (value)
                    {
                        int id = Tools.PrazenStringToInt(item.Cells["ID"].Value.ToString());
                        label2.Text = id.ToString();
                        string tabela = cmbTabela.Text.Split('-').FirstOrDefault().Trim();

                        if (tabela.ToUpper() == "tblArtikal".ToUpper())
                        {
                            UpdatetirajArtikNaDadeniotServer(id);
                        }

                        if (tabela.ToUpper() == "tblAkcijaNaArtikal".ToUpper())
                        {
                            UpdatetirajTblAkcijaArtikal(id);
                        }

                        if (tabela.ToUpper() == "tblPartneri".ToUpper())
                        {
                            UpdatetirajTblPartner(id);
                        }

                        if (tabela.ToUpper() == "tblPrevodi".ToUpper())
                        {
                            UpdatetirajTblPrevodi(id);
                        }

                        if (tabela.ToUpper() == "tblObjekti".ToUpper())
                        {
                            UpdatetirajTblObjekti(id);
                        }


                        if (tabela.ToUpper() == "tblPodgrupaID".ToUpper())
                        {
                            UpdatetirajTblPodgrupa(id);
                        }


                        if (tabela.ToUpper() == "tblGrupaNaArtikli".ToUpper())
                        {
                            UpdatetirajTblGrupaNaArtikli(id);
                        }

                        if (tabela.ToUpper() == "tblTipNaDokument".ToUpper())
                        {
                            UpdatetirajTblTipNaDokument(id);
                        }

                        if (tabela.ToUpper() == "tblBanki".ToUpper())
                        {
                            UpdatetirajTblBanki(id);
                        }

                        if (tabela.ToUpper() == "tblEdinecniMerki".ToUpper())
                        {
                            UpdatetirajTblEdinecniMerki(id);
                        }

                        progressBar1.Value += 1;
                    }
                }
                Cursor.Current = Cursors.Default;

                MessageBox.Show("Ажурирано");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable podatoci = NajdiGiStePodatociVoGlavnaBaza(BssBase.settings.konekcija);
            ArtikliOD.DataSource = podatoci;
            ArtikliOD.SetirajStikliranje();
        }
    }
}
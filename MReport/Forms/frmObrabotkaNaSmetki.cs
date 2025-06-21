using MFiskalna.Fiskalna;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MReport.Forms
{
    public partial class frmObrabotkaNaSmetki : Form
    {
        public frmObrabotkaNaSmetki()
        {
            InitializeComponent();
        }

        private int SmetkaOdbrana;

        private void tblNalogBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!Equals(tblNalogBindingSource.Current, null))
            {
                int nalogId = Tools.PrazenStringToInt(((DataRowView)tblNalogBindingSource.Current)["ID"].ToString());
                stavkiVoNalogTableAdapter.Fill(bSSRDataSet.StavkiVoNalog, nalogId);
            }
        }

        public void IzbrisiCelosnoArtikal(int artikalID, int NalogIDZaInsert)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"exec brisiArtikal @NalogID, @ArtikalID , @smetka", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@NalogID", NalogIDZaInsert);
                        com.Parameters.AddWithValue("@ArtikalID", artikalID);
                        com.Parameters.AddWithValue("@smetka", SmetkaOdbrana);
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

        public void IzbrisiCelosnoNalog(int NalogID)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblNalog where ID = @NalogID; delete from tblSmetkaStavki where tblSmetkaID = @smetka;update tblSmetka set Zatvorena = 'false', DatumKraj = null where ID = @smetka;", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@NalogID", NalogID);
                        com.Parameters.AddWithValue("@smetka", SmetkaOdbrana);
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

        private void IzbrisiCelosnoSmetka(int smetka)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("delete from tblNalog where SmetkaID=@id;delete from tblSmetka where ID = @smetka; delete from tblSmetkaStavki where tblSmetkaID = @smetka", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@smetka", smetka);
                        com.Parameters.AddWithValue("@id", smetka);

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

        private void StornirajKniznjeaSmetka(int smetka)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
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
        }

        private void бришиАртикалОдНалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(stavkiVoNalogBindingSource.Current, null))
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате да го избришете одбраниот артикал од нарачката ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    int nalogId = Tools.PrazenStringToInt(((DataRowView)tblNalogBindingSource.Current)["ID"].ToString());
                    int artikal = Tools.PrazenStringToInt(((DataRowView)stavkiVoNalogBindingSource.Current)["Artikal"].ToString());
                    IzbrisiCelosnoArtikal(artikal, nalogId);
                    btnPrikazi.PerformClick();
                }
            }
        }

        private void бришиНалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(tblNalogBindingSource.Current, null))
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате да ja избришете одбраната нарачка ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    int nalogId = Tools.PrazenStringToInt(((DataRowView)tblNalogBindingSource.Current)["ID"].ToString());

                    IzbrisiCelosnoNalog(nalogId);
                    btnPrikazi.PerformClick();
                }
            }
        }

        public void OtvoriSmetka(int smetka)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("update tblSmetka set Zatvorena = 'false', DatumKraj = null, Izmeneta = 1 where ID = @smetka; delete from tblSmetkaStavki where tblSmetkaID = @smetka", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@smetka", smetka);

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

        public void SnimiSmetkaPredBrisenje(int smetkaID)
        {
            if (BssBase.settings.TipNaPrograma == "250") return;
            string ZabeleskaZaIzmena = BssBase.InputBox.Show("Наведете причина за бришење на сметката").Text;
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("InsertSmetkaIzmeneta", con))
                {
                    try
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@SmetkaID", smetkaID);
                        com.Parameters.AddWithValue("@Tip", 20);
                        com.Parameters.AddWithValue("@Datum", DateTime.Now);
                        com.Parameters.AddWithValue("@ZabeleskaOdIzmena", ZabeleskaZaIzmena);

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

            if (string.IsNullOrEmpty(ZabeleskaZaIzmena))
            {
                ZabeleskaZaIzmena = "Причината за бришење не беше наведена";
            }

            string MailText = "";
            MailText = " Сметката со број : " + txtBase1.Text + " е избришана на : " + DateTime.Now.ToString() + " \n";
            MailText += "\n Вкупната сума пред бришење изнесува : " + txtSumNalozi.Text;
            MailText += "\n Причината за бришењe на сметката е : " + ZabeleskaZaIzmena;

            Tools.SendMailDefault("", " Бришење на сметка со број : " + txtBase1.Text, MailText, false);
        }

        private void бришиСметкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(tblSmetkaBindingSource.Current, null))
            {
                DialogResult opc;
                int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());

                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате да ја избришете одбраната сметка ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {

                    if (!dbFunctions.DaliSmetkataEZatvorena(smetka))
                    {
                        MessageBox.Show(@"Сметката е сеуште отворена, повторно отворање не е возможно ," + Environment.NewLine + @" \n Сметката мора да биде затворена за да ја користите оваа опција ", "Внимание !!! Оваа сметка е веќе отворена", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (dbFunctions.DaliImaFiskalnaIspecateno(smetka))
                    {
                        MessageBox.Show(@"За оваа сметка има испечатено фискална," + Environment.NewLine + @" Доколку продолжите фискалната ќе биде избришана само од програмата, и нема да биде сторнирана, ве молиме прво сторнирајте ја фискалната сметка  ", "Внимание !!! Постои Фискална Сметка ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (dbFunctions.DaliImaImaKnizeno(smetka))
                    {
                        MessageBox.Show(@"Oваа сметка е веќе прокнижена во материјална евиденција," + Environment.NewLine + @" Доколку сакате да ја отворите мора прво да ја сторнирате од книжењата во материјална Евиденција", "Внимание !!! Прокнижена сметка ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    SnimiSmetkaPredBrisenje(smetka);
                    IzbrisiCelosnoSmetka(smetka);
                    tblNalogTableAdapter.Fill(bSSRDataSet.tblNalog);
                    tblSmetkaTableAdapter.Fill(bSSRDataSet.tblSmetka);
                    txtBase1.Text = string.Empty;
                    btnPrikazi.PerformClick();
                }

            }
        }

        public void SnimiSmetkaPredOtvoreanje(int smetkaID)
        {
            if (BssBase.settings.TipNaPrograma == "250") return;
            string ZabeleskaZaIzmena = BssBase.InputBox.Show("Наведете причина за отворање на сметката").Text;

            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("InsertSmetkaIzmeneta", con))
                {
                    try
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@SmetkaID", smetkaID);
                        com.Parameters.AddWithValue("@Tip", 10);
                        com.Parameters.AddWithValue("@Datum", DateTime.Now);
                        com.Parameters.AddWithValue("@ZabeleskaOdIzmena", ZabeleskaZaIzmena);

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

            if (string.IsNullOrEmpty(ZabeleskaZaIzmena))
            {
                ZabeleskaZaIzmena = "Причината за измена не беше наведена";
            }

            string MailText = "";
            MailText = " Сметка со број : " + txtBase1.Text + " беше отворена за измена на :" + DateTime.Now.ToString() + " \n";
            MailText += "\n Вкупната сума пред измената изнесува : " + txtSumNalozi.Text;
            MailText += "\n Причината за измена на сметката е : " + ZabeleskaZaIzmena;

            Tools.SendMailDefault("", " Измена во сметка број : " + txtBase1.Text, MailText, false);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Equals(tblSmetkaBindingSource.Current, null))
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате да ја отворите одбраната сметка ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());

                    if (!dbFunctions.DaliSmetkataEZatvorena(smetka))
                    {
                        MessageBox.Show(@"Сметката е сеуште отворена, повторно отворање не е возможно ," + Environment.NewLine + @" \n Сметката мора да биде затворена за да ја користите оваа опција ", "Внимание !!! Оваа сметка е веќе отворена", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (dbFunctions.DaliImaFiskalnaIspecateno(smetka))
                    {
                        MessageBox.Show(@"За оваа сметка има испечатено фискална," + Environment.NewLine + @" Доколку продолжите фискалната ќе биде избришана само од програмата, и нема да биде сторнирана, ве молиме прво сторнирајте ја фискалната сметка  ", "Внимание !!! Постои Фискална Сметка ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (dbFunctions.DaliImaImaKnizeno(smetka))
                    {
                        MessageBox.Show(@"Oваа сметка е веќе прокнижена во материјална евиденција," + Environment.NewLine + @" Доколку сакате да ја отворите мора прво да ја сторнирате од книжењата во материјална Евиденција", "Внимание !!! Прокнижена сметка ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    SnimiSmetkaPredOtvoreanje(smetka);
                    OtvoriSmetka(smetka);
                    tblNalogTableAdapter.Fill(bSSRDataSet.tblNalog);
                    tblSmetkaTableAdapter.Fill(bSSRDataSet.tblSmetka);
                    stavkiVoNalogTableAdapter.Fill(bSSRDataSet.StavkiVoNalog, 0);
                    бришиНалогToolStripMenuItem.Enabled = true;
                    бришиАртикалОдНалогToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void tblSmetkaStavkiBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!Equals(tblSmetkaBindingSource.Current, null))
            {
                int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());
                tblNalogTableAdapter.FillBy(bSSRDataSet.tblNalog, smetka);
            }
        }

        public string sumaODsmetke(int smetkaID)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("select isnull(SUM(cena),0) as Iznos from tblSmetkaStavki where tblSmetkaID=@Smetka", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Smetka", smetkaID);
                    con.Open();
                    var rez = com.ExecuteScalar();
                    if (!Equals(null, rez))
                    {
                        return rez.ToString();
                    }
                    con.Close();
                }
            }
            return string.Empty;
        }

        public string sumaODFiskalniSmetke(int smetkaID)
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("Select isnull(SUM(Iznos),0) as IznosFiskalna from tblFiskalniSmetki where tblSmetkaID=@Smetka", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Smetka", smetkaID);
                    con.Open();
                    var rez = com.ExecuteScalar();
                    if (!Equals(null, rez))
                    {
                        return rez.ToString();
                    }
                    con.Close();
                }
            }
            return string.Empty;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtBase1.IsTextEmpty())
                {
                    bSSRDataSet.tblSmetka.Clear();
                    bSSRDataSet.tblNalog.Clear();
                    bSSRDataSet.StavkiVoNalog.Clear();

                    tblSmetkaTableAdapter.FillBy(bSSRDataSet.tblSmetka, Tools.PrazenStringToInt(txtBase1.Text));
                    if (bSSRDataSet.tblSmetka.Count > 0)
                    {
                        int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());
                        decimal smetkaPopust = Tools.PrazenStringToDecimal_dec(((DataRowView)tblSmetkaBindingSource.Current)["ProcentNaPopust"].ToString());
                        SmetkaOdbrana = smetka;
                        tblNalogTableAdapter.FillBy(bSSRDataSet.tblNalog, smetka);
                        int imaPopust = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ImaPopust"].ToString(), 0); ;
                        stavkiZaFiskalNaTableAdapter.Fill(bSSRDataSet.StavkiZaFiskalNa, smetka, imaPopust, smetkaPopust);

                        txtSumNalozi.Text = string.Format(" {0:C}", bSSRDataSet.StavkiZaFiskalNa.Compute("SUM(Iznos)", ""));
                        txtSumSmetki.Text = string.Format(" {0:C}", Tools.PrazenStringToDecimal(sumaODsmetke(smetka)));
                        txtSumFiskalni.Text = string.Format(" {0:C}", Tools.PrazenStringToDecimal(sumaODFiskalniSmetke(smetka)));
                    }
                    else
                    {
                        MessageBox.Show(Tools.PrevediPoraka("Внесената сметка не постои"));
                    }
                }
                else
                {
                    bSSRDataSet.tblSmetka.Clear();
                    bSSRDataSet.tblNalog.Clear();
                    bSSRDataSet.StavkiVoNalog.Clear();
                }
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
            }
        }

        private void frmObrabotkaNaSmetki_Load(object sender, EventArgs e)
        {
            txtBase1.Select();
            btnPrikazi.DialogResult = DialogResult.OK;
            AcceptButton = btnPrikazi;
        }

        private void направиФактураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asm = System.Reflection.Assembly.Load("MFakturi");
            var t = asm.CreateInstance("MFakturi.Forms.frmObrabotkaNaFaktura", true).GetType();
            var frm = (Form)Activator.CreateInstance(t, new object[] { SmetkaOdbrana, true });
            frm.ShowDialog();
        }

        private void сторнирајСметкаВоМатеријалнаЕвиденцијаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(tblSmetkaBindingSource.Current, null))
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате дa ги сторнирате книжењата за оваа сметка ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());

                    StornirajKniznjeaSmetka(smetka);
                    tblNalogTableAdapter.Fill(bSSRDataSet.tblNalog);
                    tblSmetkaTableAdapter.Fill(bSSRDataSet.tblSmetka);
                    txtBase1.Text = string.Empty;
                    btnPrikazi.PerformClick();
                }
            }
        }

        private void пратиНаДругКорисникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("Дали сакате дa измените корисникот кој ја креирал оваа сметка ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                var asm = System.Reflection.Assembly.Load("BSSR");
                var t = asm.CreateInstance("BSSR.Forms.frmKorisnici", true).GetType();
                var frm = (BssBase.frmBigShow)Activator.CreateInstance(t, new object[] { "", true });
                frm.ShowDialog();
                int newUserID = Tools.PrazenStringToInt(frm.dr.Cells["ID"].Value.ToString(), -1);
                frm.Dispose();

                if (newUserID != -1)
                {
                    int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());
                    using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                    {
                        try
                        {
                            using (SqlCommand com = new SqlCommand("update tblSmetka set tblUserID = @UserID where ID = @SmetkaID", con))
                            {
                                con.Open();
                                com.Parameters.Clear();
                                com.Parameters.AddWithValue("@SmetkaID", smetka);
                                com.Parameters.AddWithValue("@UserID", newUserID);
                                com.ExecuteNonQuery();
                                con.Close();
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

        public void IspecatiSmetkaNaFiskalNa(bool storno, DataTable artikliZaFiskalna)
        {

            var fiskalna = new FiscalCash(txtBase1.Text);
            fiskalna.InitInterface();
            fiskalna.ArtikliZaNaFiskalna(storno, artikliZaFiskalna);

            if (!storno)
            {
                fiskalna.IssueBill(false);
            }
            else
            {
                fiskalna.IssueStorno();
            }
        }

       

        private void ПечатиНоваФискалнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(tblSmetkaBindingSource.Current, null))
            {

                int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());
                DataTable ArtikliZaFiskalna = artikliZaFiskalnaSmetka(smetka);
                if (dbFunctions.DaliImaFiskalnaIspecateno(smetka))
                {
                    MessageBox.Show(@"За оваа сметка има испечатено фискална," + Environment.NewLine + @" Доколку продолжите фискалната ќе биде избришана само од програмата, и нема да биде сторнирана, ве молиме прво сторнирајте ја фискалната сметка  ", "Внимание !!! Постои Фискална Сметка ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    var result = BssBase.InputBox.Show("Дали сакате да испечатите нова фискална ");
                    if (result.ReturnCode == DialogResult.OK)
                    {
                        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                        {
                            using (var Smetki = new SqlCommand("DELETE FROM dbo.tblFiskalniSmetki WHERE tblSmetkaID = @SmetkaID", con))
                            {
                                Smetki.Parameters.Clear();
                                Smetki.Parameters.AddWithValue("@SmetkaID", smetka);
                                con.Open();
                                ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                                con.Close();
                            }
                        }
                        IspecatiSmetkaNaFiskalNa(false, ArtikliZaFiskalna);
                    }
                }
                else
                {
                    IspecatiSmetkaNaFiskalNa(false, ArtikliZaFiskalna);
                }

            }

        }

        private static DataTable artikliZaFiskalnaSmetka(int smetka)
        {
            var ArtikliZaFiskalna = new DataTable("ArtikliZaFiskalna");
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (var Smetki = new SqlCommand("select * from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID", con))
                {
                    Smetki.Parameters.Clear();
                    Smetki.Parameters.AddWithValue("@SmetkaID", smetka);
                    con.Open();
                    ArtikliZaFiskalna.Load(Smetki.ExecuteReader());
                    con.Close();
                }
            }

            return ArtikliZaFiskalna;
        }

        private void СторнирајФискалнаЗаСметкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Equals(tblSmetkaBindingSource.Current, null))
            {

                int smetka = Tools.PrazenStringToInt(((DataRowView)tblSmetkaBindingSource.Current)["ID"].ToString());
                if (dbFunctions.DaliImaFiskalnaIspecateno(smetka))
                {
                    var result = BssBase.InputBox.Show("Дали сакате да испечатите нова фискална ");
                    if (result.ReturnCode == DialogResult.OK)
                    {
                        DataTable ArtikliZaFiskalna = artikliZaFiskalnaSmetka(smetka);
                        IspecatiSmetkaNaFiskalNa(true, ArtikliZaFiskalna);
                    }
                }
            }

        }
    }
}
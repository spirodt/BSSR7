using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MReport.Forms
{
    public partial class frmGenerirajDokumenti : Form
    {
        //exec[dbo].[GenerirajDokumenti] '2023-04-13 09:09:24.150','2023-04-30 09:09:24.150','2023-04-01 09:09:24.150',1,'',18.51
        public frmGenerirajDokumenti()
        {
            InitializeComponent();
        }

        public void GenerirajDokumentiZaOdrzuvanje(
            DateTime datumNaDokument,
            DateTime datumNaValuta,
            DateTime datumPeriod,
            string Zabeleska,
            decimal CenaZaStruja
            )
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                {
                    using (SqlCommand command = new SqlCommand("GenerirajDokumenti", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@datum", datumNaDokument);
                        command.Parameters.AddWithValue("@datumNaValuta", datumNaValuta);
                        command.Parameters.AddWithValue("@datumPeriod", datumPeriod);
                        command.Parameters.AddWithValue("@UserId", BssBase.settings.UserId);
                        command.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                        command.Parameters.AddWithValue("@CenaZaStruja", CenaZaStruja);
                        command.Parameters.AddWithValue("@PatientIdOd", 3);
                        command.Parameters.AddWithValue("@PatientIdDO", 400);
                        con.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }catch ( Exception ex )
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message,true);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            
            DialogResult opc;
            opc = MessageBox.Show("Дали сте сигурни дека сакате Генерирате фактури", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                GenerirajDokumentiZaOdrzuvanje(dtDatum.Value, dtValuta.Value, dtPeriod.Value, txtBase1.Text, txtCenaNaStruja.PrazenStringToDecimal_dec());
                int rez = Tools.UpdateDokumentBroj();
                Tools.WriteLog("Update dokument - ", rez);
                MessageBox.Show("Успешно генерирано");
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Json files (*.json)|*.json";

            dlg.ShowDialog();
            string path = dlg.FileName;
            FileInfo fileInfo = new FileInfo(path);
            string mesec = dtJsonPeriod.Value.Month.ToString().PadLeft(2, '0');
            string godina = dtJsonPeriod.Value.Year.ToString().Substring(2, 2);
            
            var result = Tools.getImportFromHvac(fileInfo.FullName);
           
            progressBar1.Maximum = result.Partners.Count;
            label6.Text = "Број на станови : " + result.Partners.Count.ToString();
            var infoArtikal = Tools.GetListaSoArtikli().AsEnumerable();
            var korisnikDb = Tools.GetListaSoPartneri().AsEnumerable();
            DialogResult opc;
            opc = MessageBox.Show("Дали сте сигурни дека сакате Генерирате фактури", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                var db = Tools.InsertirajGeneralDokumentInfo(dtJsonPeriod.Value.Month.ToString(), dtJsonPeriod.Value.Year.ToString(), result.GeneralData);
                int broj = 1;
               
                foreach (var hvacKorisniciImport in result.Partners)
                {
                    string unitsText = GenerateUnitsTextZabeleska(hvacKorisniciImport);

                    var korisnikHvac = korisnikDb.FirstOrDefault(x => x["Sifra"].ToString() == hvacKorisniciImport.Name);

                    if (korisnikHvac != null)
                    {
                        var kodNaDokument = $"{2}-{mesec}{godina}-{korisnikHvac["Sifra"].ToString().Substring(3, 3)}";
                        var dokumentId = Tools.KreirajDokument(broj, dtJsonDatum.Value, 2, BssBase.settings.AktivenObjektDoNaStartZaDokumenti, BssBase.settings.AktivenObjektDoNaStartZaDokumenti,
                            unitsText, korisnikHvac["Id"], kodNaDokument, dtJsonValuta.Value, dtJsonPeriod.Value, korisnikHvac["Sifra"].ToString());

                        var dbHvacVoda = Tools.InsertirajDetailsHvacVoda(dokumentId, hvacKorisniciImport);

                        foreach (var unitItem in hvacKorisniciImport.Units)
                        {
                            var dbHvacUnits = Tools.InsertirajDetailsHvac(dokumentId, unitItem, string.Empty);
                        }

                        foreach (var stavka in hvacKorisniciImport.Articles)
                        {
                            var artikal = infoArtikal.FirstOrDefault(x => x["Sifra"].ToString() == stavka.ArticleItem);
                            if (artikal != null)
                            {
                                Tools.InsertirajStavkaVoDokumenti(dokumentId, Convert.ToInt32(artikal["Id"].ToString()), stavka.Qty, stavka.Price,
                                    (stavka.Price * stavka.Qty), false, 0);
                            }
                        }
                        label7.Text = kodNaDokument;
                        Application.DoEvents();
                    }
                    progressBar1.Value += 1;
                    broj++;
                    
                }

                int rez = Tools.UpdateDokumentBroj();
                Tools.WriteLog("Update dokument - ", rez);
                MessageBox.Show("Успешно генерирано");
            }

        }

        private static string GenerateUnitsTextZabeleska(Tools.Partner hvacKorisnici)
        {
            var unitsText = $"";

            foreach (var unitItem in hvacKorisnici.Units)
            {
                if (unitItem.Name == hvacKorisnici.Units[0].Name)
                {
                    unitsText += $"Water : {hvacKorisnici.WaterMeter}       |       {hvacKorisnici.WaterMeterOld}       |       {hvacKorisnici.WaterMeterNew} {Environment.NewLine}";
                }
                unitsText += $"{unitItem.Name}       |       {unitItem.Capacity}       |       {unitItem.LowRun}       |       {unitItem.LowRunTotal}       |       {unitItem.HighRun}       |       {unitItem.HighRunTotal}{Environment.NewLine}";
            }

            return unitsText;
        }
    }
}

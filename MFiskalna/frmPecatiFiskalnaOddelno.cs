using MFiskalna.Fiskalna;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MFiskalna
{
    public partial class frmPecatiFiskalnaOddelno : Form
    {
        private DataTable ArtikliZaFiskalna;
        private DataTable ArtikliZaPecatenje;
        private DataTable PocetniArtikli;
        private bool zatvori = false;
        private bool optecatenaEdnaSmetka;
        private int SmetkaID;
        private int FirmaID;
        private int BrojNaPodeleniSmekti;

        public frmPecatiFiskalnaOddelno(DataTable _ArtikliZaFiskalna, int _SmetkaID, int _FirmaID, int _BrojNaPodeleniSmekti)
        {
            InitializeComponent();
            SmetkaID = _SmetkaID;
            _ArtikliZaFiskalna.Columns["Kolicina"].ReadOnly = false;
            _ArtikliZaFiskalna.Columns["Iznos"].ReadOnly = false;
            _ArtikliZaFiskalna.PrimaryKey = new DataColumn[] { _ArtikliZaFiskalna.Columns["ID"] };
            ArtikliZaFiskalna = _ArtikliZaFiskalna;
            FirmaID = _FirmaID;
            DialogResult = DialogResult.Cancel;
            BrojNaPodeleniSmekti = _BrojNaPodeleniSmekti;
            ArtikliZaPecatenje = _ArtikliZaFiskalna.Copy();
            PocetniArtikli = _ArtikliZaFiskalna.Copy();
            ArtikliZaPecatenje.Clear();
            optecatenaEdnaSmetka = false;
            ArtikliOD.DataSource = _ArtikliZaFiskalna;
            ArtikliOD.Columns["ID"].HeaderText = "Реден број";
            ArtikliOD.Columns["ID"].Visible = false;

            ArtikliOD.Columns["Naziv"].HeaderText = "Артикал";
            ArtikliOD.Columns["Naziv"].Visible = true;
            ArtikliOD.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ArtikliOD.Columns["Kolicina"].HeaderText = "Количина";
            ArtikliOD.Columns["Kolicina"].Visible = true;
            ArtikliOD.Columns["Kolicina"].ReadOnly = false;
            ArtikliOD.Columns["Kolicina"].DefaultCellStyle.Format = "N0";
            ArtikliOD.Columns["Iznos"].HeaderText = "Износ";
            ArtikliOD.Columns["Iznos"].Visible = true;
            ArtikliOD.Columns["Danok"].HeaderText = "Данок";
            ArtikliOD.Columns["Danok"].Visible = false;
            ArtikliOD.Columns["Sifra"].HeaderText = "Шифра";
            ArtikliOD.Columns["Sifra"].Visible = false;
            ArtikliOD.Columns["NalogID"].HeaderText = "Реден број на налог";
            ArtikliOD.Columns["NalogID"].Visible = false;
            ArtikliOD.Columns["Artikal"].HeaderText = "Реден број на Артикал";
            ArtikliOD.Columns["Artikal"].Visible = false;
            ArtikliOD.Columns["Tip"].HeaderText = "Тип на артикал";
            ArtikliOD.Columns["Tip"].Visible = false;
            ArtikliOD.Columns["Cena"].HeaderText = "Цена";
            ArtikliOD.Columns["Cena"].Visible = false;

            PecatiArtikli.DataSource = ArtikliZaPecatenje;
            PecatiArtikli.Columns["ID"].HeaderText = "Реден број";
            PecatiArtikli.Columns["ID"].Visible = false;

            PecatiArtikli.Columns["Naziv"].HeaderText = "Артикал";
            PecatiArtikli.Columns["Naziv"].Visible = true;
            PecatiArtikli.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PecatiArtikli.Columns["Kolicina"].HeaderText = "Количина";
            PecatiArtikli.Columns["Kolicina"].Visible = true;
            PecatiArtikli.Columns["Kolicina"].ReadOnly = false;
            PecatiArtikli.Columns["Kolicina"].DefaultCellStyle.Format = "N0";
            PecatiArtikli.Columns["Iznos"].HeaderText = "Износ";
            PecatiArtikli.Columns["Iznos"].Visible = true;
            PecatiArtikli.Columns["Iznos"].ReadOnly = false;
            PecatiArtikli.Columns["Danok"].HeaderText = "Данок";
            PecatiArtikli.Columns["Danok"].Visible = false;
            PecatiArtikli.Columns["Sifra"].HeaderText = "Шифра";
            PecatiArtikli.Columns["Sifra"].Visible = false;
            PecatiArtikli.Columns["NalogID"].HeaderText = "Реден број на налог";
            PecatiArtikli.Columns["NalogID"].Visible = false;
            PecatiArtikli.Columns["Artikal"].HeaderText = "Реден број на Артикал";
            PecatiArtikli.Columns["Artikal"].Visible = false;
            PecatiArtikli.Columns["Tip"].HeaderText = "Тип на артикал";
            PecatiArtikli.Columns["Tip"].Visible = false;
            PecatiArtikli.Columns["Cena"].HeaderText = "Цена";
            PecatiArtikli.Columns["Cena"].Visible = false;
        }

        private void frmPecatiFiskalnaOddelno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                Close();
            }
        }

        private void btnPrenesiGiSite_Click(object sender, EventArgs e)
        {
            if (PecatiArtikli.RowCount == 0 && !optecatenaEdnaSmetka)
            {
                ArtikliZaPecatenje = ArtikliZaFiskalna.Select(string.Empty, string.Empty).CopyToDataTable();
                ArtikliZaFiskalna.Clear();
                PecatiArtikli.DataSource = ArtikliZaPecatenje;
            }
            else
            {
                MessageBox.Show(Tools.PrevediPoraka("Пренесувањето не е возможно доколку имате префрлено артикли рачно"));
            }
        }

        private void btnVratiNazad_Click(object sender, EventArgs e)
        {
            if (!optecatenaEdnaSmetka)
            {
                ArtikliZaFiskalna = PocetniArtikli.Select(string.Empty, string.Empty).CopyToDataTable();
                ArtikliZaPecatenje.Clear();
                ArtikliOD.DataSource = ArtikliZaFiskalna;
                PecatiArtikli.DataSource = ArtikliZaPecatenje;
            }
            else
            {
                MessageBox.Show(Tools.PrevediPoraka("Пренесувањето не е возможно доколку имате префрлено артикли рачно или е отпечатена барем една сметка"));
            }
        }

        private void btnPecatiFiskalnaOdMomentalni_Click(object sender, EventArgs e)
        {
            if (zatvori != true)
            {
                if (PecatiFiskalna(ArtikliZaPecatenje))
                {
                    optecatenaEdnaSmetka = true;
                    ArtikliZaPecatenje.Clear();
                    if (ArtikliOD.RowCount < 1 && PecatiArtikli.RowCount < 1)
                    {
                        btnPecatiFiskalnaOdMomentalni.Text = "Излез";
                        zatvori = true;
                    }
                }
            }
            else
            {
                btnPecatiFiskalnaOdMomentalni.DialogResult = DialogResult.OK;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public bool PecatiFiskalna(DataTable artikliZaFiskalna)
        {
            if (BssBase.settings.PrasajZaFiskalna == true)
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
                var fiskalna = new FiscalCash("_oddelno");
                fiskalna.InitInterface();
                foreach (DataRow Produkt in artikliZaFiskalna.Rows)
                {
                    fiskalna.AddProduct(Produkt.ConvertDataRowToFiscalProduct());
                }
                fiskalna.IssueBill(true);
                rezultat = true;
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
                return true;
            }
            try
            {
                using (var con = new SqlConnection(BssBase.settings.konekcija))
                {
                    decimal Iznos = 0;
                    foreach (DataRow Produkt in artikliZaFiskalna.Rows)
                    {
                        Iznos += Tools.PrazenStringToDecimal_dec(Produkt["Cena"].ToString()) + Tools.PrazenStringToDecimal_dec(Produkt["Cena"].ToString());
                    }
                    using (var com = new SqlCommand(@"INSERT INTO tblFiskalniSmetki (Broj ,Datum ,Iznos,Stornirana,tblSmetkaID,FirmaID)
						values((Select dbo.NaredenBrojNaFiskalna()) ,getDate() ,@Iznos,'false',@tblSmetkaID,@FirmaID) ", con))
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@Iznos", Iznos);
                        com.Parameters.AddWithValue("@tblSmetkaID", SmetkaID);
                        com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
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

        private void Prenesi_Click(object sender, EventArgs e)
        {
            if (!Equals(ArtikliOD.CurrentRow, null))
            {
                var prenes = ArtikliZaPecatenje.NewRow();

                if (Convert.ToInt32(ArtikliOD.CurrentRow.Cells["Kolicina"].FormattedValue) == 1)
                {
                    var Momentalen = ArtikliZaFiskalna.Rows[ArtikliOD.CurrentRow.Index];
                    prenes["Naziv"] = Momentalen["Naziv"];
                    prenes["ID"] = Momentalen["ID"];
                    prenes["Kolicina"] = 1;
                    prenes["Danok"] = Momentalen["Danok"];

                    prenes["Cena"] = Momentalen["Cena"];
                    prenes["Sifra"] = Momentalen["Sifra"];
                    prenes["NalogID"] = Momentalen["NalogID"];
                    prenes["Artikal"] = Momentalen["Artikal"];
                    prenes["Tip"] = Momentalen["Tip"];
                    var kolicinaPecati = 1;
                    if (ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).Count() > 0)
                    {
                        kolicinaPecati = Convert.ToInt32(ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Kolicina"]);
                    }
                    prenes["Iznos"] = kolicinaPecati * Tools.PrazenStringToDecimal_dec(prenes["Cena"].ToString());
                    ArtikliZaFiskalna.Rows.Remove(ArtikliZaFiskalna.Rows[ArtikliOD.CurrentRow.Index]);
                    if (ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).Count() > 0)
                    {
                        Tools.PrazenStringToInt(ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["ID"].ToString());
                        kolicinaPecati = kolicinaPecati + 1;
                        ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Kolicina"] = kolicinaPecati;
                        ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Iznos"] = kolicinaPecati * Tools.PrazenStringToDecimal_dec(ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Cena"].ToString());
                        ArtikliZaPecatenje.AcceptChanges();
                    }
                    else
                    {
                        ArtikliZaPecatenje.Rows.Add(prenes);
                    }
                    ArtikliOD.Refresh();
                }
                else
                {
                    var MomentalenZaUPdate = ArtikliZaFiskalna.Rows[ArtikliOD.CurrentRow.Index];
                    prenes["ID"] = MomentalenZaUPdate["ID"];
                    prenes["Naziv"] = MomentalenZaUPdate["Naziv"];
                    prenes["Kolicina"] = 1;
                    prenes["Danok"] = MomentalenZaUPdate["Danok"];

                    prenes["Cena"] = MomentalenZaUPdate["Cena"];
                    prenes["Sifra"] = MomentalenZaUPdate["Sifra"];
                    prenes["NalogID"] = MomentalenZaUPdate["NalogID"];
                    prenes["Artikal"] = MomentalenZaUPdate["Artikal"];
                    prenes["Tip"] = MomentalenZaUPdate["Tip"];

                    var kolicina = Convert.ToInt32(ArtikliZaFiskalna.Rows[ArtikliOD.CurrentRow.Index]["Kolicina"]) - 1;
                    var kolicinaPecati = 1;
                    prenes["Iznos"] = kolicinaPecati * Tools.PrazenStringToDecimal_dec(prenes["Cena"].ToString());
                    ArtikliZaFiskalna.Rows[ArtikliOD.CurrentRow.Index]["Kolicina"] = kolicina;
                    ArtikliZaFiskalna.AcceptChanges();
                    if (ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).Count() > 0)
                    {
                        kolicinaPecati = Convert.ToInt32(ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Kolicina"]);
                        kolicinaPecati = kolicinaPecati + 1;
                        ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Kolicina"] = kolicinaPecati;
                        ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Iznos"] = kolicinaPecati * Tools.PrazenStringToDecimal_dec(ArtikliZaPecatenje.Select("ID=" + prenes["ID"].ToString()).First()["Cena"].ToString());
                        ArtikliZaPecatenje.AcceptChanges();
                    }
                    else
                    {
                        ArtikliZaPecatenje.Rows.Add(prenes);
                    }
                    ArtikliOD.Refresh();
                }
            }
        }

        private void ArtikliOD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblArtikliOD.Text = string.Format(" Вкупно: {0:C}", ArtikliZaFiskalna.Compute("SUM(Iznos)", string.Empty));
        }

        private void PecatiArtikli_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblPecati.Text = string.Format(" Вкупно: {0:C}", ArtikliZaPecatenje.Compute("SUM(Iznos)", string.Empty));
        }
    }
}
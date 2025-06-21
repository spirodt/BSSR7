using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmNormativEditStavka : frmBigEdit
    {
        public int NormativID;

        public frmNormativEditStavka(int _NormativID)
        {
            InitializeComponent();
            NormativID = _NormativID;
            Kolicina.MakedonskiJazik = true;
            zbxBase1.Value.KeyDown += new KeyEventHandler(Value_KeyDown);
        }

        public void validateZbxArtikal()
        {
            var info = Tools.NajdiInfoZaSifraArtikal_artikli(zbxBase1.Value.Text);
            if (zbxBase1.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    zbxBase1.zoomClear();
                    txtBase1.Clear();
                    zbxBase1.ret1 = info["ID"].ToString();
                    zbxBase1.Value.Text = info["Sifra"].ToString();
                    txtBase1.Text = info["Naziv"].ToString();
                    zbxBase1.ret5 = info["KolicinaT"].ToString();
                    Kolicina.Focus();
                    Kolicina.Select();
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("ArtiklotNePostoi"));
                    zbxBase1.zoomClear();
                    txtBase1.Text = string.Empty;
                }
            }
        }

        private void Value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                validateZbxArtikal();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand("INSERT INTO dbo.tblNormativStavki (tblNormativID,tblArtikalID,Kolicina) Values(@tblNormativID,@tblArtikalID,@Kolicina)", con))
                {
                    try
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@tblNormativID", NormativID);
                        com.Parameters.AddWithValue("@tblArtikalID", zbxBase1.ret1);
                        com.Parameters.AddWithValue("@Kolicina", Kolicina.Text.Replace(',', '.'));
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        NeZatvoraj = false;
                        Close();
                    }
                    catch (Exception ex)
                    {
                        if (ex is SqlException)
                        {
                            Tools.PrevediSQLException((SqlException)ex);
                        }
                        else
                        {
                            Tools.PrevediSQLException(ex);
                        }
                        NeZatvoraj = true;
                        return;
                    }
                }
            }
        }

        private void zbxBase1_DataRead()
        {
            zbxBase1.Value.Text = zbxBase1.ret4;
            validateZbxArtikal();
        }

        private void zbxBase1_Validated(object sender, EventArgs e)
        {
            validateZbxArtikal();
        }

        private void Kolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
            }
        }

        private void frmNormativEditStavka_Load(object sender, EventArgs e)
        {
            zbxBase1.Focus();
            zbxBase1.open.Focus();
            zbxBase1.open.PerformClick();
        }

        private void Kolicina_Leave(object sender, EventArgs e)
        {
            decimal kolcinaVnesena = Kolicina.PrazenStringToDecimal_dec();
            decimal kolcinaizdavanje = Tools.PrazenStringToDecimal_dec(zbxBase1.ret5);

            if (kolcinaizdavanje < 1)
            {
                decimal doza = kolcinaVnesena / kolcinaizdavanje;
                Kolicina.Text = doza.ToString("N4");
            }

        }
    }
}
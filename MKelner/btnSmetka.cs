using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnSmetka : Button
    {
        public int SmetkaID;
        public string brojNaSmetka;
        public int MasaBroj;
        public string ZabeleskaZaMasa;
        public Button btnFiscal;
        public string printMasa;
        public btnSmetka(string TextBUtton, string _brojNaSmetka, string PocnataNa, int _IDSmetka, int sirina, int masa, string zabeleska = "", string sumaNaSmetka = "")
        {
            
            
            //Image = BssBase.Properties.Resources.smetka;
            Size = new Size(cfg.sirinaNaDugminjaGore + 35, cfg.VisinaNaDugminjaGore + 120);
            Name = TextBUtton;
            if (zabeleska == "")
            {
                Text = String.Format("{0}\n Маса бр: {1}\n{2}", TextBUtton, masa, PocnataNa);
                ZabeleskaZaMasa = string.Format("Маса бр: {0}", masa);
            }
            else
            {
                ZabeleskaZaMasa = zabeleska;
                Text = String.Format("{0}\n {1}\n{2}", TextBUtton, ZabeleskaZaMasa, PocnataNa);
                
            }

            printMasa = zabeleska;
            Tag = PocnataNa;
            SmetkaID = _IDSmetka;
            brojNaSmetka = _brojNaSmetka;
            MasaBroj = masa;
            if (BssBase.settings.ZatvoranjeNaSmetkaOdButton && !ZabeleskaZaMasa.Contains("BSS_"))
            {
                ContextMenuStrip meni = new ContextMenuStrip();
                meni.Items.Add("Затвори сметка");
                meni.Items.Add("Затвори Сочувана");

                meni.Items[0].Name = SmetkaID.ToString();
                meni.Items[0].Image = BssBase.Properties.Resources.close_32;
                meni.Items[0].Click += btnSmetkaKasaZatvori_Click;
                meni.Items[1].Name = SmetkaID.ToString() + "_f";
                meni.Items[1].Image = BssBase.Properties.Resources.close_32;
                meni.Items[1].Click += btnSmetkaKasaFiskaln_Click;
                ContextMenuStrip = meni;
            }

            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.TopCenter;
            Font = new Font(Font.FontFamily, 13, FontStyle.Regular);
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Beige;
            Margin = new Padding(5);
           
            btnFiscal = new Button()
            {
                Text = "Фискална" + Environment.NewLine + sumaNaSmetka,
                Dock = DockStyle.Bottom,
                Size = new Size(this.Width, this.Height - (120)),
                BackColor = Color.DeepSkyBlue,
                Name = _IDSmetka.ToString(),
            };
            this.Controls.Add(btnFiscal);
            if (!ZabeleskaZaMasa.Contains("BSS_"))
            {
                btnFiscal.Click += BtnSmetkaPrintFiscal_Click;
            } else
            {
                btnFiscal.Click += AdminClick;
                BackColor = Color.IndianRed;
                btnFiscal.Text = "Интерна сметка" + Environment.NewLine + sumaNaSmetka;
            }
            
            Click += new EventHandler(btnSmetka_Click);
        }

        private void AdminClick(object sender, EventArgs e)
        {
            var login = new frmMainLogin();
            login.ShowDialog();
            if (!login.LoginOk)
            {
                return;
            }
            var parentForm = (frmKelner)Parent.FindForm();
            parentForm.SmetkaID = SmetkaID;
            parentForm.lblBrNaSmetka.Text = printMasa;

            if (login.SelectedUserLevel == 9)
            {
                ((frmKelner)Parent.FindForm()).PresemetajSumaNaNalog();
                ((frmKelner)Parent.FindForm()).IspecatiIZatvoriSmetkaSoSveFiskalna(false, 0, SmetkaID);
            }
            else
            {
                DialogResult opc;
                opc = MessageBox.Show(Tools.PrevediPoraka("Заврши сметка и прати ја до Админ корисник ? "), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        int smetka = SmetkaID;
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
            login.Dispose();
        }

        private void BtnSmetkaPrintFiscal_Click(object sender, EventArgs e)
        {

            var parentForm = (frmKelner)Parent.FindForm();
            parentForm.SmetkaID = SmetkaID;
            parentForm.lblBrNaSmetka.Text = printMasa;
            ((frmKelner)Parent.FindForm()).NaloziZaSmetka(Tools.PrazenStringToInt( ((Button)sender).Name));
            ((frmKelner)Parent.FindForm()).PresemetajSumaNaNalog();
            ((frmKelner)Parent.FindForm()).IspecatiIZatvoriSmetkaSoSveFiskalna(false, 0, SmetkaID);
            
        }

        private void btnSmetkaKasaFiskaln_Click(object sender, EventArgs e)
        {

            MFakturi.Forms.frmKasa.zatvoriSmetka(Tools.PrazenStringToInt(((ToolStripMenuItem)sender).Name.Split('_').FirstOrDefault()));
            MFakturi.Forms.frmKasa.ZatvoriSocuvanaFiskalna(Tools.PrazenStringToInt(((ToolStripMenuItem)sender).Name.Split('_').FirstOrDefault()));
            ((frmKelner)Parent.FindForm()).prikaziSmetki();
        }

        private void btnSmetkaKasaZatvori_Click(object sender, EventArgs e)
        {
            MFakturi.Forms.frmKasa.zatvoriSmetka(Tools.PrazenStringToInt(((ToolStripMenuItem)sender).Name));
            ((frmKelner)Parent.FindForm()).prikaziSmetki();
        }

        private void btnSmetka_Click(object sender, EventArgs e)
        {
            
            var parentForm = (frmKelner)Parent.FindForm();
            parentForm.SmetkaID = ((btnSmetka)sender).SmetkaID;
            parentForm.lblBrNaSmetka.Text = ((btnSmetka)sender).brojNaSmetka;
            parentForm.setirajZabeleskaZaSmetka(((btnSmetka)sender).ZabeleskaZaMasa);
            parentForm.NapolniOtvorenaSmetka(((btnSmetka)sender).SmetkaID);
            parentForm.MasaBrojPrint = ((btnSmetka)sender).printMasa;
            parentForm.splitContainer4.Panel1.Enabled = true;
            parentForm.splitContainer4.Panel1Collapsed = false;
            parentForm.KreirajDugminjaZaGrupiNaArtikli();
            Application.DoEvents();
        }
    }
}
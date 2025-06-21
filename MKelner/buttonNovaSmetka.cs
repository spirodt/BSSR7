using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class buttonNovaSmetka : Button
    {
        public string ZabeleskaZaMasa;

        public buttonNovaSmetka(int sirina, int masa)
        {


            if (BssBase.settings.TipNaPrograma == "888")
            {
                string masaStr = Tools.PrevediPoraka("Маса");
                ZabeleskaZaMasa = string.Format(masaStr + " {0}", masa);
            }
            else
            {
                ZabeleskaZaMasa = string.Format(Tools.PrevediPoraka("Маса бр: {0}"), masa);
            }

            Image = BssBase.Properties.Resources.nova_smetka;

            if (BssBase.settings.TipNaPrograma == "888")
                Size = new Size(235, cfg.VisinaNaDugminjaGore + 30);
            else
                Size = new Size(cfg.sirinaNaDugminjaGore + 35, cfg.VisinaNaDugminjaGore + 30);

            Text = Tools.PrevediPoraka("Нова сметка");
            Name = "NovaSmektaDugme";
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;

            Font = new Font(Font.FontFamily, 15, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(btnNovaSmetka_Click);
        }

        private void btnNovaSmetka_Click(object sender, EventArgs e)
        {

            if (BssBase.settings.TipNaPrograma == "250" || BssBase.settings.TipNaPrograma == "888" || BssBase.settings.TipNaPrograma == "888200")
            {
                BssBase.InputBoxResult inputNaNovaSmetka;
                string zbMasaTextCheck = ((buttonNovaSmetka)sender).ZabeleskaZaMasa;
                inputNaNovaSmetka = BssBase.InputBox.Show(Tools.PrevediPoraka("Нова сметка ? "), Tools.PrevediPoraka("Дали сте сигурни ?"), zbMasaTextCheck);


                if (inputNaNovaSmetka.ReturnCode == DialogResult.OK)
                {
                    ((buttonNovaSmetka)sender).ZabeleskaZaMasa = inputNaNovaSmetka.Text;


                    string kodNaDokument = Guid.NewGuid().ToString();
                    if (!string.IsNullOrEmpty(inputNaNovaSmetka.Text) && inputNaNovaSmetka.Text.ToUpper() == "BSS")
                    {
                        kodNaDokument = $"BSS_{kodNaDokument}";
                    }

                        ((frmKelner)Parent.FindForm()).KreirajSmetka(kodNaDokument);

                    if (!string.IsNullOrEmpty(inputNaNovaSmetka.Text))
                    {
                        if (inputNaNovaSmetka.Text.ToUpper() == "BSS")
                        {
                            inputNaNovaSmetka.Text = "BSS_";
                        }

                        ((frmKelner)Parent.FindForm()).setirajZabeleskaZaSmetka(inputNaNovaSmetka.Text);
                        ((frmKelner)Parent.FindForm()).SetirajZabeleska(inputNaNovaSmetka.Text);
                        ((frmKelner)Parent.FindForm()).MasaBrojPrint = inputNaNovaSmetka.Text;

                    }
                    
                    ((frmKelner)Parent.FindForm()).splitContainer4.Panel1.Enabled = true;
                    ((frmKelner)Parent.FindForm()).splitContainer4.Panel1Collapsed = false;
                    ((frmKelner)Parent.FindForm()).KreirajDugminjaZaGrupiNaArtikli();

                }
                return;
            }

            DialogResult opc = DialogResult.Yes;
            if (BssBase.settings.TipNaPrograma != "88")
            {
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да отворите нова сметка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (DialogResult.Yes == opc)
            {
                ((frmKelner)Parent.FindForm()).splitContainer4.Panel1.Enabled = true;
                ((frmKelner)Parent.FindForm()).splitContainer4.Panel1Collapsed = false;
                //((frmKelner)Parent.FindForm()).setirajZabeleskaZaSmetka(((buttonNovaSmetka)sender).ZabeleskaZaMasa);
                ((frmKelner)Parent.FindForm()).KreirajSmetka();
                ((frmKelner)Parent.FindForm()).KreirajDugminjaZaGrupiNaArtikli();
            }
        }
    }
}
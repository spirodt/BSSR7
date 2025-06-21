using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class buttonNovaSmetkaKasa : Button
    {
        public string ZabeleskaZaMasa;

        public buttonNovaSmetkaKasa(int sirina, int masa)
        {
            ZabeleskaZaMasa = string.Format("Купувач бр: {0}", masa);
            Image = BssBase.Properties.Resources.nova_smetka;
            Size = new Size(cfg.sirinaNaDugminjaGore + 45, cfg.VisinaNaDugminjaGore + 30);
            Text = "Нова сметка ( F1 )";
            Name = "NovaSmektaDugme";
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
            Font = new Font(Font.FontFamily, 15, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(buttonNovaSmetkaKasa_Click);
        }

        private void buttonNovaSmetkaKasa_Click(object sender, EventArgs e)
        {
            DialogResult opc = DialogResult.Yes;

            if (BssBase.settings.TipNaPrograma != "8" && !BssBase.settings.TipNaPrograma.Contains("988Kasa"))
            {
                opc = MessageBox.Show(Tools.PrevediPoraka("Дали сте сигурни дека сакате да отворите нова сметка ? "), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (DialogResult.Yes == opc)
            {
                ((frmKelner)Parent.FindForm()).splitContainer4.Panel1.Enabled = true;
                ((frmKelner)Parent.FindForm()).splitContainer4.Panel1Collapsed = false;
                ((frmKelner)Parent.FindForm()).Visible = false;
                ((frmKelner)Parent.FindForm()).Hide();

                using ( MFakturi.Forms.frmKasa kasa = new MFakturi.Forms.frmKasa()) { 
                    kasa.StartReader();
                    kasa.ShowDialog();
                    kasa.CloseRader();

                }
                ((frmKelner)Parent.FindForm()).Visible = true;
                ((frmKelner)Parent.FindForm()).Show();
                ((frmKelner)Parent.FindForm()).prikaziSmetkiKasa();
            }
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class butKeyBack : Button
    {
        public int Grupa;

        public butKeyBack(int _Grupa)
        {
            Image = BssBase.Properties.Resources.previous;
            Size = new Size(cfg.sirinaNaBack, cfg.VisinaNaDugminjaGore);
            Text = string.Empty;
            Name = "BackDugme";
            ImageAlign = ContentAlignment.BottomLeft;
            TextAlign = ContentAlignment.MiddleRight;
            Font = new Font(Font.FontFamily, 11, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(butKeyBack_Click);
            Grupa = _Grupa;
        }

        private void butKeyBack_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).Keywords = string.Empty;
            ((frmKelner)Parent.FindForm()).KreirajDugminjaZaPodGrupiNaArtikli(((butKeyBack)sender).Grupa);
        }
    }
}
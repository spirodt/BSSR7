using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnNazad : Button
    {
        public int Page;

        public btnNazad(int page, int sirina)
        {
            Click += new EventHandler(btnNazad_Click);
            Image = BssBase.Properties.Resources.previous;
            Size = new Size(cfg.SirinaNaArtikal, cfg.VisinaNaArtikal);
            ImageAlign = ContentAlignment.MiddleCenter;
            TextAlign = ContentAlignment.TopRight;
            Font = new Font(Font.FontFamily, 13, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Page = page;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).KreirajPage(((frmKelner)Parent.FindForm()).PrikaziArtikliIliSmetki(), --((btnNazad)sender).Page);
        }
    }
}
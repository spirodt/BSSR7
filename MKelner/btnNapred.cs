using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnNapred : Button
    {
        public int Page;

        public btnNapred(int page, int sirina)
        {
            Click += new EventHandler(btnNapred_Click);
            Image = BssBase.Properties.Resources.next;
            Size = new Size(cfg.SirinaNaArtikal, cfg.VisinaNaArtikal);
            ImageAlign = ContentAlignment.MiddleCenter;
            TextAlign = ContentAlignment.TopLeft;
            Font = new Font(Font.FontFamily, 13, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Page = page;
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).KreirajPage(((frmKelner)Parent.FindForm()).PrikaziArtikliIliSmetki(), ++((btnNapred)sender).Page);
        }
    }
}
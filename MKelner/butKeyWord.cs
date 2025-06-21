using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class butKeyWord : Button
    {
        public int PodGrupaID;

        public butKeyWord(string TextKeyword, int podgrupa)
        {
            Image = BssBase.Properties.Resources.arrow_downGolema;
            Size = new Size(cfg.sirinaNaDugminjaGore, cfg.VisinaNaDugminjaGore);
            Text = TextKeyword;
            Name = "butKeyWord";
            ImageAlign = ContentAlignment.BottomLeft;
            TextAlign = ContentAlignment.TopRight;
            Font = new Font(Font.FontFamily, 11, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(butKeyWord_Click);
            PodGrupaID = podgrupa;
        }

        private void butKeyWord_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).Keywords = ((butKeyWord)sender).Text;
            ((frmKelner)Parent.FindForm()).PrikaziArtikliIliSmetki();
        }
    }
}
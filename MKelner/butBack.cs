using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class butBack : Button
    {
        public butBack()
        {
            Image = BssBase.Properties.Resources.previous;
            Size = new Size(cfg.sirinaNaBack, cfg.VisinaNaDugminjaGore);
            Text = string.Empty;
            Name = "BackDugme";
            ImageAlign = ContentAlignment.MiddleCenter;
            TextAlign = ContentAlignment.MiddleRight;
            Font = new Font(Font.FontFamily, 13, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(butBack_Click);
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).GrupaID = -1;
            ((frmKelner)Parent.FindForm()).PodgrupaID = -1;
            ((frmKelner)Parent.FindForm()).Keywords = string.Empty;
            ((frmKelner)Parent.FindForm()).KreirajDugminjaZaGrupiNaArtikli();
        }
    }
}
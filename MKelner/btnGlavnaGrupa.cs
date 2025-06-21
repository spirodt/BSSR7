using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnGlavnaGrupa : Button
    {
        public int GrupaID;

        public btnGlavnaGrupa(string ImenNAGrupa, int idNaGrupa, string PictureFileName)
        {
            
            ImageAlign = cfg.ContentAlignmentFromInt(cfg.ImageAligmentDugminjaGore);
            TextAlign = cfg.ContentAlignmentFromInt(cfg.TextAligmentDugminjaGore);

            Font = new Font(Font.FontFamily, cfg.FontSizeDugminjaGore, FontStyle.Regular);
            Size = new Size(cfg.sirinaNaDugminjaGore, cfg.VisinaNaDugminjaGore);

            Name = ImenNAGrupa;
            Text = ImenNAGrupa;
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);

            GrupaID = idNaGrupa;
            Click += new EventHandler(btnGlavnaGrupa_Click);
            
            if (PictureFileName.Contains("\\"))
            {
                PictureFileName = PictureFileName.Split('\\').LastOrDefault();
            }
            
            BackgroundImage = cfg.Slike.getImage(PictureFileName);
            BackgroundImageLayout = ImageLayout.Center;
            if (cfg.Slike.imageExists(PictureFileName))
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                if (!String.IsNullOrEmpty(cfg.ArtikalTextColor) && !cfg.ArtikalTextColor.Contains("N/A"))
                {
                    ForeColor = Color.FromName(cfg.ArtikalTextColor);
                }
            }
        }

        private void btnGlavnaGrupa_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).GrupaID = ((btnGlavnaGrupa)sender).GrupaID;
            ((frmKelner)Parent.FindForm()).KreirajDugminjaZaPodGrupiNaArtikli(((btnGlavnaGrupa)sender).GrupaID);
        }
    }
}
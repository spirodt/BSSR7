using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnPodGrupa : Button
    {
        public int PodGrupaID;
        public int GrupaID;

        public btnPodGrupa(string ImenNAGrupa, int PodGrupa, int _GrupaID, string PictureFileName)
        {
            if (PictureFileName.Contains("\\"))
            {
                PictureFileName = PictureFileName.Split('\\').LastOrDefault();
            }
            BackgroundImageLayout = ImageLayout.Center;
            
            BackgroundImage = cfg.Slike.getImage(PictureFileName);
            if (cfg.Slike.imageExists(PictureFileName))
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                if (!String.IsNullOrEmpty(cfg.ArtikalTextColor) && !cfg.ArtikalTextColor.Contains("N/A"))
                {
                    ForeColor = Color.FromName(cfg.ArtikalTextColor);
                }
            }

            //ImageAlign = ContentAlignment.BottomRight; 3
            //TextAlign = ContentAlignment.TopLeft; 12

            ImageAlign = cfg.ContentAlignmentFromInt(cfg.ImageAligmentDugminjaGore);
            TextAlign = cfg.ContentAlignmentFromInt(cfg.TextAligmentDugminjaGore);

            Font = new Font(Font.FontFamily, cfg.FontSizeDugminjaGore, FontStyle.Regular);
            Size = new Size(cfg.sirinaNaDugminjaGore, cfg.VisinaNaDugminjaGore);

            Name = ImenNAGrupa;
            Text = ImenNAGrupa;
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            PodGrupaID = PodGrupa;
            Click += new EventHandler(btnPodGrupa_Click);
            GrupaID = _GrupaID;
        }

        private void btnPodGrupa_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).GrupaID = ((btnPodGrupa)sender).GrupaID;
            ((frmKelner)Parent.FindForm()).PodgrupaID = ((btnPodGrupa)sender).PodGrupaID;
            ((frmKelner)Parent.FindForm()).KreirajDugminjaZaPodKeywords(((btnPodGrupa)sender).PodGrupaID, ((btnPodGrupa)sender).GrupaID);
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnArtikal : Button
    {
        public int IdArtikal;
        public bool isNormativ;
        public int page;

        public Color OutlineForeColor { get; set; }
        public float OutlineWidth { get; set; }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
        //    using (GraphicsPath gp = new GraphicsPath())
        //    using (Pen outline = new Pen(OutlineForeColor, OutlineWidth) { LineJoin = LineJoin.Round })
        //    using (StringFormat sf = new StringFormat())
        //    using (Brush foreBrush = new SolidBrush(ForeColor))
        //    {
        //        gp.AddString(Text, Font.FontFamily, (int)Font.Style,
        //            Font.Size, ClientRectangle, sf);
        //        e.Graphics.ScaleTransform(1.3f, 1.35f);
        //        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        //        e.Graphics.DrawPath(outline, gp);
        //        e.Graphics.FillPath(foreBrush, gp);
        //    }
        //}
        public btnArtikal(int _page)
        {
            OutlineForeColor = Color.Green;
            OutlineWidth = 5;

            page = _page;
        }

        public System.Collections.Generic.Dictionary<string, Image> MainImages;

       

        public btnArtikal(int ID, string Naziv, string cena, int sirina, string NormativStr, int _page, String PictureFileName)
        {
            Size = new Size(cfg.SirinaNaArtikal, cfg.VisinaNaArtikal);
            ImageAlign = cfg.ContentAlignmentFromInt(cfg.ImageAligmentArtikal);
            TextAlign = cfg.ContentAlignmentFromInt(cfg.TextAligmentArtikal);
            Font = new Font(Font.FontFamily, cfg.FontSizeArtikal, FontStyle.Regular);

            Name = Naziv + page.ToString() + ID.ToString();
            Text = Naziv;

            Label nazivDole = new Label();
            nazivDole.Text = "Цена: " + cena;
            nazivDole.TextAlign = ContentAlignment.TopRight;
            nazivDole.BorderStyle = BorderStyle.FixedSingle;
            nazivDole.Dock = DockStyle.Bottom;
            nazivDole.BackColor = Color.White;
            nazivDole.ForeColor = Color.Black;
            nazivDole.FlatStyle = FlatStyle.Flat;
            nazivDole.Paint += nazivDole_Paint;
            Controls.Add(nazivDole);

            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += btnArtikal_Click;
            Tag = cena;
            IdArtikal = ID;
            isNormativ = NormativStr.ToUpper().Contains("TRUE");

            if (PictureFileName.Contains("\\"))
            {
                PictureFileName = PictureFileName.Split('\\').LastOrDefault();
            }

            BackgroundImageLayout = ImageLayout.Center;
            BackgroundImage = cfg.Slike.getImage(PictureFileName);
            if (cfg.Slike.imageExists(PictureFileName) && !string.IsNullOrEmpty(cfg.ArtikalTextColor) && !cfg.ArtikalTextColor.Contains("N/A"))
            {
                ForeColor = Color.FromName(cfg.ArtikalTextColor);
            }

            page = _page;
        }

        void nazivDole_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, ((Label)(sender)).DisplayRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void btnArtikal_Click(object sender, EventArgs e)
        {
            frmKelner parentForm = (frmKelner)Parent.FindForm();
            int nalogIDZaInsert = parentForm.NalogIDZaInsert;

            if (nalogIDZaInsert != -1)
            {
                btnArtikal clickedButton = (btnArtikal)sender;
                parentForm.dodadiArtikalVoNalog(clickedButton.IdArtikal, clickedButton.isNormativ, clickedButton.Tag.ToString());
            }
            else
            {
                DataTable naloziTable = parentForm.ArtikliDataSet.Tables["Nalozi"];
                DataRow[] selectedRows = naloziTable.Select("Status = 0");

                if (selectedRows.Length == 0)
                {
                    parentForm.KreirajNovNalog(parentForm.SmetkaID, 0);
                }
                else
                {
                    int nalogID = Tools.PrazenStringToInt(selectedRows[0]["ID"].ToString());
                    parentForm.NalogIDZaInsert = nalogID;
                }

                btnArtikal clickedButton = (btnArtikal)sender;
                parentForm.dodadiArtikalVoNalog(clickedButton.IdArtikal, clickedButton.isNormativ, clickedButton.Tag.ToString());
            }
        }
    }
}
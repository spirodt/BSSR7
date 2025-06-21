using System.Drawing;
using System.Drawing.Imaging;

namespace MKelner.Forms
{
    public static class cfg
    {
        public static ImageHelper Slike;

        public static int VisinaNaDugminjaGore = 60;
        public static int sirinaNaDugminjaGore = 180;

        public static int sirinaNaBack = 180;
        public static int brojNaArtikliDisplay = 10;
        public static int brojNaArtikliDisplayMalku = 10;
        public static int BrojNaKopcinjaSmetka = 4;
        public static int SirinaNaArtikal = 180;
        public static int VisinaNaArtikal = 60;
        public static int brojNaDugminjaNaArtikal = 5;

        public static int FontSizeArtikal = 11;
        public static int TextAligmentArtikal = 0;
        public static int ImageAligmentArtikal = 0;

        public static int FontSizeDugminjaGore = 11;
        public static int TextAligmentDugminjaGore = 0;
        public static int ImageAligmentDugminjaGore = 0;
        public static string ArtikalTextColor = string.Empty;
        public static string PatekaDoLogo = string.Empty;

        public static Bitmap ChangeOpacity(Image img, int opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics
            return bmp;
        }

        public static ContentAlignment ContentAlignmentFromInt(int Align)
        {
            switch (Align)
            {
                case 1: return ContentAlignment.BottomCenter;
                case 2: return ContentAlignment.BottomLeft;
                case 3: return ContentAlignment.BottomRight;

                case 4: return ContentAlignment.MiddleCenter;
                case 5: return ContentAlignment.MiddleLeft;
                case 6: return ContentAlignment.MiddleRight;

                case 7: return ContentAlignment.TopCenter;
                case 8: return ContentAlignment.TopLeft;
                case 9: return ContentAlignment.TopRight;
            }
            return ContentAlignment.MiddleCenter;
        }
    }
}
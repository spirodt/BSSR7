using System.Drawing;
using System.Windows.Forms;

namespace BssBase.Elements
{
    public sealed partial class btnPonisti : btnZatvori
    {
        public btnPonisti()
        {
            BackColor = Color.WhiteSmoke;
            DialogResult = DialogResult.Cancel;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Image = Properties.Resources._001_05;
            UseVisualStyleBackColor = false;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleCenter;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            MinimumSize = new Size(132, 38);
        }
    }

    public  class btnZatvori : Button
    {
        public btnZatvori()
        {
            BackColor = Color.WhiteSmoke;
            DialogResult = DialogResult.Cancel;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Image = Properties.Resources._001_09;
            UseVisualStyleBackColor = false;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleCenter;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            MinimumSize = new Size(132, 38);
        }
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace BssBase.Elements
{
    public partial class btnPrikaci : Button
    {
        public btnPrikaci()
        {
            BackColor = Color.WhiteSmoke;

            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Image = Properties.Resources._001_24;
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
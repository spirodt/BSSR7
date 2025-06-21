using System.Windows.Forms;

namespace BssBase.Elements
{
    public class btnOtvori : Button
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            BackColor = System.Drawing.Color.WhiteSmoke;
            DialogResult = DialogResult.Cancel;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Image = Properties.Resources._001_03;
            UseVisualStyleBackColor = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }
    }
}
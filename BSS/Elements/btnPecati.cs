using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BssBase.Elements
{
    public class btnPecati : Button
    {
        [DefaultValue("s"),
        EditorBrowsable(EditorBrowsableState.Always),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Bindable(true)]
        protected override void OnCreateControl()
        {
            BackColor = Color.WhiteSmoke;
            DialogResult = DialogResult.Cancel;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Image = Properties.Resources.printer;
            UseVisualStyleBackColor = false;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleCenter;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            MinimumSize = new Size(132, 38);
            MaximumSize = new Size(132, 38);
            base.OnCreateControl();
        }
    }
}
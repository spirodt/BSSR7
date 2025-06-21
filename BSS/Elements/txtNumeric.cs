using System;
using System.ComponentModel;
using System.Drawing;

namespace BssBase.Elements
{
    public class txtNumeric : txtBase
    {
        protected override void OnCreateControl()
        {
            Format = "{0:0.00}";
            BackColor = Color.LemonChiffon;
            ForeColor = Color.Blue;
            C_OnlyNumbers = true;
            base.OnCreateControl();
        }

        [EditorBrowsable(EditorBrowsableState.Always),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Bindable(true)]
        public new string Format { set; get; }

        public bool iskluciFormatiranje { set; get; }

        protected override void OnValidated(EventArgs e)
        {
            if (!string.IsNullOrEmpty(Format) && !iskluciFormatiranje)
            {
                Text = Tools.PrazenStringToDecimal(Text).ToString("N2");
            }
            base.OnValidated(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!string.IsNullOrEmpty(Format) && !iskluciFormatiranje)
            {
                Text = Tools.PrazenStringToDecimal(Text).ToString("N2");
            }
            base.OnTextChanged(e);
        }
    }
}
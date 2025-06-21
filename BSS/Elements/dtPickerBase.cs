using System.Drawing;
using System.Windows.Forms;

namespace BssBase.Elements
{
    public partial class dtPickerBase : DateTimePicker
    {
        public dtPickerBase()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                Format = DateTimePickerFormat.Custom;
                var culture = Tools.GetSystemGlobalizationCulture();
                if (string.IsNullOrEmpty(culture.DateTimeFormat.ShortDatePattern))
                {
                    CustomFormat = culture.DateTimeFormat.ShortDatePattern;
                }
            }

            Size = new Size(97, 20);
        }

        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            if (Text.Length != 2)
            {
                base.OnValidating(e);
            }
        }

       
    }
}
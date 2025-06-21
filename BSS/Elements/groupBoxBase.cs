using System;
using System.Linq;
using System.Windows.Forms;

namespace BssBase
{
    public class groupBoxBase : GroupBox
    {
        public delegate void base_Click(object sender, EventArgs e);

        

        public void SetRadioButtonValue(string value)
        {
            if (Controls.OfType<RadioButton>().Count() != 2)
            {
                throw new NotImplementedException("Mora da ima dva radioButoni");
            }

            if (value.ToUpper() == "true".ToUpper())
            {
                foreach (RadioButton item in Controls.OfType<RadioButton>())
                {
                    if (item.Name.Contains("_1"))
                    {
                        item.Checked = true;
                    }
                }
            }
            else
            {
                foreach (RadioButton item in Controls.OfType<RadioButton>())
                {
                    if (!item.Name.Contains("_1"))
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        public bool GetRadioButtonValue()
        {
            if (Controls.Count != 2)
            {
                throw new NotImplementedException("Mora da ima dva radioButoni");
            }
            var rez = false;
            foreach (RadioButton item in Controls.OfType<RadioButton>())
            {
                if (item.Name.Contains("_1") && item.Checked)
                {
                    rez = true;
                }
            }
            return rez;
        }

        protected override void OnClick(EventArgs e)
        {
        }
    }
}
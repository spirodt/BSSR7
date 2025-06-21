using System.Windows.Forms;

namespace BssBase
{
    /// <summary>
    /// Class used to store the result of an InputBox.Show message.
    /// </summary>
    public class InputBoxResult
    {
        public DialogResult ReturnCode;
        public string Text;
        public decimal RabatOut;
        public decimal MinutiOut;
        public bool DefaulOptionSelected = true;
    }
}
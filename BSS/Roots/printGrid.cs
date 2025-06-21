using System.Windows.Forms;

namespace BssBase.Forms
{
    public partial class printGrid : PrintPreviewDialog
    {
        public printGrid(System.Drawing.Printing.PrintDocument doc)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Document = doc;
        }
    }
}
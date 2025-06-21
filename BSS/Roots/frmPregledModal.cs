using System;
using System.Windows.Forms;

namespace BssBase.Forms
{
    public partial class frmPregledModal : frmEditTop
    {
        public bool NeZatvoraj = false;

        public frmPregledModal()
        {
            InitializeComponent();
        }

        private void btnZatvori1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPregledModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = NeZatvoraj;
        }

        public void IzbrisiGreskaDole()
        {
            errorProviderDole.SetError(DisplayError, string.Empty);
            DisplayError.Text = string.Empty;
            DisplayError.Visible = false;
        }

        public void PrikaziGreskaDole(string Text)
        {
            errorProviderDole.SetIconAlignment(DisplayError, ErrorIconAlignment.TopLeft);
            errorProviderDole.SetError(DisplayError, Text);
            DisplayError.Visible = true;
            DisplayError.Text = Text;
        }

        private void DisplayError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IzbrisiGreskaDole();
            NeZatvoraj = false;
        }
    }
}
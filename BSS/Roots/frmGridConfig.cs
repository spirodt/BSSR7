using System;

namespace BssBase.Forms
{
    public partial class frmGridConfig : frmEditTop
    {
        public frmGridConfig(object ctrl)
        {
            InitializeComponent();
            Configs.SelectedObject = ctrl;
            Text = Text + " " + ctrl.ToString();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
        }

        private void btnZatvori1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGridConfig_Load(object sender, EventArgs e)
        {
            btnPotvrdi1.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
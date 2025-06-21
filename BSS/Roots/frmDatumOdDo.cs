using System;
using System.Windows.Forms;

namespace BssBase.Roots
{
    public partial class frmDatumOdDo : Form
    {
        private bool oneDate = false;
        public frmDatumOdDo()
        {
            InitializeComponent();
            DialogResult = DialogResult.OK;
        }

        public frmDatumOdDo(string text)
        {
            InitializeComponent();
            DialogResult = DialogResult.OK;
            oneDate = true;
            label1.Text = text;
            datumOD.Value =DateTime.Now;
            DatumDO.Value = DateTime.Now;
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        private void frmDatumOdDo_Load(object sender, EventArgs e)
        {
            datumOD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DatumDO.Value = DateTime.Now;
            if (oneDate)
            {
                DatumDO.Visible = false;
                skraten.Visible = false;
                labelDatumDO.Visible = false;

            }

            
        }
    }
}
using System.Windows.Forms;

namespace BssBase
{
    public partial class frmEditTop : Form
    {
        public frmEditTop()
        {
            InitializeComponent();
        }

        public bool SkokniPrivilegii { set; get; }

        public bool proveriPrivilegii(string ImeNaForma)
        {
            if (SkokniPrivilegii)
            {
                return true;
            }
            if (!Tools.proveriPrivilegii(ImeNaForma))
            {
                MessageBox.Show(Tools.PrevediPoraka("NematePrivilegii"), Tools.PrevediPoraka("Greska!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void OnCreateControl()
        {
            SkokniPrivilegii = false;
            base.OnCreateControl();
        }
    }
}
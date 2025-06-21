namespace BssBase.Forms
{
    public partial class frmVnesNaEdnaStavka : frmPregledModal
    {
        public frmVnesNaEdnaStavka()
        {
            InitializeComponent();
        }

        public virtual void NovaStavka()
        {
        }

        public virtual void IzmeniStavka()
        {
        }

        public virtual void IzbrisiStavka()
        {
        }

        public virtual void Socuvaj()
        {
        }

        public virtual void Osvezi()
        {
        }

        private void btnNovaStavka_Click(object sender, System.EventArgs e)
        {
            NovaStavka();
        }

        private void btnIzmeniStavka_Click(object sender, System.EventArgs e)
        {
            IzmeniStavka();
        }

        private void btnIzbrisiStavka_Click(object sender, System.EventArgs e)
        {
            IzbrisiStavka();
        }

        private void btnSocuvajStavka_Click(object sender, System.EventArgs e)
        {
            Socuvaj();
        }

        private void btnReload_Click(object sender, System.EventArgs e)
        {
            Osvezi();
        }
    }
}
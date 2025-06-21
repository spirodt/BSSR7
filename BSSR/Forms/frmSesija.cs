using System.Data;
using System.Windows.Forms;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmSesija : frmBigShow
    {
        public frmSesija()
        {
            InitializeComponent();
            btnOk.Visible = false;
            if (settings.NeLoadirajPodatociNaStartNaForma == "false")
                _tblSesijaTableAdapter.Fill(bSSSDataset._tblSesija);
        }

        public frmSesija(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            _tblSesijaTableAdapter.Fill(bSSSDataset._tblSesija);
            AcceptButton = btnOk;
            _tblSesijaGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = _tblSesijaBindingSource.Find("Naziv", filter);
                _tblSesijaBindingSource.Position = row;
            }
            SrediIminjaNaGrid();
        }

        private void _tblSesijaGridBig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idsesije = string.Empty;

            if (_tblSesijaGridBig.RowCount > 0)
            {
                if (!Equals(null, _tblSesijaBindingSource.Current))
                {
                    idsesije = (((DataRowView)_tblSesijaBindingSource.Current)["Sesija"].ToString());
                    var logovi = new frmLogovi(idsesije);
                    logovi.MdiParent = ActiveForm;
                    logovi.Text = "Логови за сесија : " + idsesije;
                    logovi.WindowState = FormWindowState.Maximized;
                    logovi.Show();
                }
            }
        }
    }
}
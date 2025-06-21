using System;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmLogovi : frmBigShow
    {
        public frmLogovi(string sesija)
        {
            InitializeComponent();
            btnOk.Visible = false;
            _tblLogTableAdapter.Fill(bSSSDataset._tblLog, new Guid(sesija));
            SrediIminjaNaGrid();
        }
    }
}
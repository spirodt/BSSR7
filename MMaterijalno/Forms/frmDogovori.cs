using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BssBase;
using DevExpress.Xpo.DB;

namespace MMaterijalno.Forms
{
    public partial class frmDogovori : frmBigShow
    {
        public frmDogovori()
        {
            InitializeComponent();
        }

        public frmDogovori(string filter)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            this.tblDogovoriTableAdapter.Fill(this.materijalnoDataSet.tblDogovori);
            AcceptButton = btnOk;
            tblDogovoriGridBig.Select();
            if (!string.IsNullOrEmpty(filter))
            {
                var row = tblDogovoriBindingSource.Find("Naziv", filter);
                tblDogovoriBindingSource.Position = row;
            }

            SrediIminjaNaGrid();
        }

        public int? tblPartnerID { get; set; }
        public frmDogovori(int? tblPartnerID)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
            
            AcceptButton = btnOk;
           
            tblDogovoriGridBig.Select();
          
            SrediIminjaNaGrid();
            tblDogovoriGridBig.ID2 = tblPartnerID.Value;
            tblPartnerID = tblPartnerID.Value;
            if (tblPartnerID.HasValue)
            {
                this.tblDogovoriTableAdapter.FillByPartnerId(this.materijalnoDataSet.tblDogovori, tblPartnerID.Value);

            }

        }

        private void frmDogovori_Load(object sender, EventArgs e)
        {

            if (!zoom) 
            {
                this.tblDogovoriTableAdapter.Fill(this.materijalnoDataSet.tblDogovori);
            }else
            {
                this.tblDogovoriTableAdapter.FillByPartnerId(this.materijalnoDataSet.tblDogovori, tblDogovoriGridBig.ID2);
            }


        }

        private void ttblDogovoriGridBigBase_DataInsert()
        {
            if (!zoom)
            {
                this.tblDogovoriTableAdapter.Fill(this.materijalnoDataSet.tblDogovori);
            } else
            {
                this.tblDogovoriTableAdapter.FillByPartnerId(this.materijalnoDataSet.tblDogovori, tblDogovoriGridBig.ID2);
            }
            

        }

        private void tblDogovoriGridBigBase_dataSaveAll()
        {
            try
            {
                tblDogovoriBindingSource.EndEdit();
                tblDogovoriTableAdapter.Update(this.materijalnoDataSet.tblDogovori);
            }
            catch (SqlException ex)
            {
                Tools.PrevediSQLException(ex);
                return;
            }
        }

        private void tblDogovoriGridBigBase_DoubleClick(object sender, EventArgs e)
        {
            if (zoom)
            {
                btnOk.PerformClick();
            }
        }
    }
}

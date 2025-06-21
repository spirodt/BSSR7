using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BssBase;
using BssBase.Roots;
using DevExpress.XtraPrinting;

namespace MMaterijalno.Reporti
{
    public partial class frmPregledNaSiteSmetkiGrupirani : frmIzvestaj
    {
        private void ChangeTimeout(Component component, int timeout)
        {
            if (!component.GetType().Name.Contains("TableAdapter"))
            {
                return;
            }

            PropertyInfo adapterProp = component.GetType().GetProperty("CommandCollection", BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.Instance);
            if (adapterProp == null)
            {
                return;
            }

            SqlCommand[] command = adapterProp.GetValue(component, null) as SqlCommand[];

            if (command == null)
            {
                return;
            }

            command[0].CommandTimeout = timeout;
        }

        public frmPregledNaSiteSmetkiGrupirani()
        {
            InitializeComponent();
            ChangeTimeout(pregledNaSiteSmetkiBindingSource, 0);
            var db = Tools.najdiMinMaxOdPregledNaSmetki();
            if (db != null)
            {
                txtPresMin.Text = db["MinPresmetkovna"].ToString();
                txtPresMax.Text = db["MaxPresmetkovna"].ToString();
                txtMaticenMin.Text = db["MinPartner"].ToString();
                txtMaticenMax.Text = db["MaxPartner"].ToString();
            }
        }

        private void btnPecati1_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = gridControl1;
            link.Landscape = true;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = String.Format("за период од : {0}  до: {1}", datumOd.DateTime.ToShortDateString(), DatumDo.DateTime.ToShortDateString());
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();


            var FmiddleColumn = string.Empty;


            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;
            link.ShowPreview();
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pregledNaSiteSmetkiTableAdapter.FillByGrupirana(materijalnoDataSet.PregledNaSiteSmetki, txtPresMin.Text, txtPresMax.Text, txtMaticenMin.Text, txtMaticenMax.Text, new DateTime(datumOd.DateTime.Year,
                        datumOd.DateTime.Month,
                        datumOd.DateTime.Day,
                        0,
                        0,
                        00,
                        DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                        DatumDo.DateTime.Month,
                        DatumDo.DateTime.Day,
                        23,
                        59,
                        59,
                        DateTimeKind.Local), BssBase.settings.MomentalenObjektID);
            }
            catch (Exception ex)
            {
                Tools.LogException(ex.Message, ex);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void frmPregledNaSmetkiPoPartner_Load(object sender, EventArgs e)
        {

            datumOd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DatumDo.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        }

        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            try{
            Cursor.Current = Cursors.WaitCursor;
            pregledNaSiteSmetkiTableAdapter.FillByGrupirana(materijalnoDataSet.PregledNaSiteSmetki, txtPresMin.Text,
                txtPresMax.Text, txtMaticenMin.Text, txtMaticenMax.Text, new DateTime(datumOd.DateTime.Year,
                    datumOd.DateTime.Month,
                    datumOd.DateTime.Day,
                    0,
                    0,
                    00,
                    DateTimeKind.Local), new DateTime(DatumDo.DateTime.Year,
                    DatumDo.DateTime.Month,
                    DatumDo.DateTime.Day,
                    23,
                    59,
                    59,
                    DateTimeKind.Local), BssBase.settings.AktivenObjektDoNaStartZaDokumenti);
                //shit happens :D 
            }catch (Exception ex)
            {
                Tools.LogException(ex.Message, ex);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
        }

    }
}

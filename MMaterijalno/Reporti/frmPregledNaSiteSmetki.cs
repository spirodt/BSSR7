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
using MMaterijalno.MaterijalnoDataSetTableAdapters;

namespace MMaterijalno.Reporti
{
    public partial class frmPregledNaSiteSmetki : frmIzvestaj
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

        public frmPregledNaSiteSmetki()
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
                pregledNaSiteSmetkiTableAdapter.Fill(materijalnoDataSet.PregledNaSiteSmetki, txtPresMin.Text, txtPresMax.Text, txtMaticenMin.Text, txtMaticenMax.Text, new DateTime(datumOd.DateTime.Year,
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

        public StringBuilder Createreport(bool detalen)
        {
            var sb = new StringBuilder();

            if (detalen)
            {
                foreach (var row in materijalnoDataSet.PregledNaSiteSmetki)
                {
                    sb.AppendLine(row.Rezultat);
                }

            }
            else
            {

                var result = materijalnoDataSet.PregledNaSiteSmetki.AsEnumerable()
                    .GroupBy(g => g.EDB.Split('-').FirstOrDefault()).Select(x => new { EDB = x.Key, Iznos = x.Sum(r => r.Iznos) });

                foreach (var rowIem in result)
                {
                    sb.AppendLine(rowIem.EDB + ";" + Convert.ToInt32(rowIem.Iznos));
                }
            }

            return sb;

        }
        private void PratiMail(int rowCount, bool detalen = false)
        {
            if (!string.IsNullOrEmpty(settings.GMailToZaSmetki) && settings.EnableMail == "1")
            {
                if (rowCount > 0)
                {
                    string exportName = Tools.setExportPath(DateTime.Today.Month + "_Izvestaj.txt");
                    if (detalen)
                    {
                        exportName = Tools.setExportPath(DateTime.Today.Month + "_Detalen_Izvestaj.txt");
                    }

                    using (StreamWriter wr = new StreamWriter(exportName, false))
                    {
                        wr.Write(Createreport(detalen));
                        wr.Close();
                    }
                    if (File.Exists(exportName))
                    {
                        Tools.SendMailCementara(exportName, "Извештај ", "Во прилог се наоѓа фајлот", true, settings.GMailFrom,
                            settings.GMailToZaSmetki);
                    }
                    else
                    {
                        MessageBox.Show("Не успешно генерирање ");
                    }
                }

            }
        }


        public (int, string )  getArtikal()
        {
            var asm = System.Reflection.Assembly.Load("BSSR");
            var t = asm.GetType("BSSR.Forms.frmPrebaruvanjeNaArtikliDev"); // CreateInstance( , true ).GetType();
            var frm = (frmBigEdit)Activator.CreateInstance(t, new object[] { "" });

            if (frm.ShowDialog() == DialogResult.OK)
            {

                DataRow dtr = frm.DtRow;
                var artikal = dtr["ID"];
                var Naziv = dtr["Naziv"];
                if (artikal !=null)
                {

                    pregledNaSiteSmetkiTableAdapter.FillByTblArtikalID(materijalnoDataSet.PregledNaSiteSmetki, txtPresMin.Text, txtPresMax.Text, txtMaticenMin.Text, txtMaticenMax.Text, new DateTime(datumOd.DateTime.Year,
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
                        DateTimeKind.Local), BssBase.settings.MomentalenObjektID,artikal.toInt());

                    return (artikal.toInt(), Naziv.ToString());
                }
                
            }
            return (0,string.Empty);
        }

        private void PratiMailIzvestajZaArtikal(int rowCount)
        {
            if (!string.IsNullOrEmpty(settings.GMailToZaSmetki) && settings.EnableMail == "1")
            {
                Cursor.Current = Cursors.WaitCursor;
                var result = getArtikal();

                if (result.Item1 != 0)
                {
                    string exportName = $"{Guid.NewGuid()}_IzvestajSporedArtikal.xls";

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

                    this.gridView1.Columns["KolicinaArtikal"].Visible = true;
                    this.gridView1.Columns["KolicinaArtikal"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    phf.Footer.Content.Clear();


                    var FmiddleColumn = $"Количина на артикал го прикажува следниот артикал : {result.Item2} {Environment.NewLine}";


                    phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
                    phf.Footer.LineAlignment = BrickAlignment.None;
                    link.ShowPreviewDialog();
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show("Дали сакате да го испратите извештајот?", "Испрати извештај", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        link.ExportToXls(exportName);

                        if (File.Exists(exportName))
                        {
                            Tools.SendMailCementara(exportName, "Извештај ", "Во прилог се наоѓа фајлот", true, settings.GMailFrom,
                                settings.GMailToZaSmetki);
                        }
                        else
                        {
                            MessageBox.Show("Не успешно генерирање ");
                        }
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }
        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            try{
            Cursor.Current = Cursors.WaitCursor;
            pregledNaSiteSmetkiTableAdapter.Fill(materijalnoDataSet.PregledNaSiteSmetki, txtPresMin.Text,
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

        private void btnPrikaci1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PratiMail(materijalnoDataSet.PregledNaSiteSmetki.Count);
            Cursor.Current = Cursors.Default;
        }

        private void btnPrikaci2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PratiMail(materijalnoDataSet.PregledNaSiteSmetki.Count, true);
            Cursor.Current = Cursors.Default;
        }
        private void btnPrikaci3_Click(object sender, EventArgs e)
        {
            PratiMailIzvestajZaArtikal(materijalnoDataSet.PregledNaSiteSmetki.Count);
        }
    }
}

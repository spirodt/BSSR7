using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using BssBase.Forms;

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

using Microsoft.Office.Interop.Excel;

using static Tools;

using Excel = Microsoft.Office.Interop.Excel;

namespace BssBase.Classes
{
    public class ExportToExcelBase
    {
        private Excel.Application xlApp;
        private Workbook xlWorkBook;
        private Worksheet current = null;

        public Worksheet GetCurrent()
        {
            return current;
        }

        public ExportToExcelBase(string workSheet, string FileName = null)
        {
            OpenWorkSheet(FileName, workSheet);
        }

        private readonly object misValue = System.Reflection.Missing.Value;
       
        public Worksheet WriteToWorkShit(int row, string col1, string value, string col2 = null, string value2 = null, Worksheet workshit = null)
        {
            if (Equals(null, workshit))
            {
                workshit = current;
            }

            workshit.Cells[row, col1] = value;

            if (!(Equals(null, col2) && Equals(null, value2)))
            {
                workshit.Cells[row, col2] = value2;
            }

            current = workshit;
            return current;
        }

        public static void ExportGridToExcel(grdBase grid, DataSet db = null, string FilePath = null)
        {
            if (Equals(FilePath, null))
            {
                var fileDlg = new SaveFileDialog
                {
                    Filter = "Excel Files | *.xls",
                    DefaultExt = "xls"
                };
                var result = fileDlg.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    FilePath = fileDlg.FileName;
                }
                else
                {
                    return;
                }
            }

            System.Data.DataTable dt = null;

            if (!Equals(null, db))
            {
                dt = db.Tables[0];
            }
            else
            {
                db = new DataSet();
                db.Tables.Add();

                DataRow dr1;
                for (var i = 0; i < grid.Columns.Count; i++)
                {
                    db.Tables[0].Columns.Add(grid.Columns[i].HeaderText + " ( " + grid.Columns[i].DataPropertyName + " ) ");
                }

                for (var i = 0; i < grid.Rows.Count; i++)
                {
                    dr1 = db.Tables[0].NewRow();
                    for (var j = 0; j < grid.Columns.Count; j++)
                    {
                        dr1[j] = grid.Rows[i].Cells[j].Value.ToString();
                    }
                    db.Tables[0].Rows.Add(dr1);
                }
            }

            dt = db.Tables[0];

            GridControl printGrid = new GridControl();
            var gridView = new GridView(printGrid)
            {
                Name = "gridView"
            };
            printGrid.MainView = gridView;
            PrintableComponentLink link = PrintGridSettings(printGrid);
            printGrid.BindingContext = new System.Windows.Forms.BindingContext();
          
            printGrid.DataSource = db.Tables[0];
            printGrid.RefreshDataSource();
            gridView.PopulateColumns();

            gridView.ExportToXls(FilePath);
           // MessageBox.Show(Tools.PrevediPoraka("UspesnoZapisnoExcel"));
        }

        private static PrintableComponentLink PrintGridSettings(dynamic grdControl = null)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = grdControl;
            link.Landscape = true;

            
            return link;
        }


        public Worksheet ZapisiAOPBU(string AOP, string value, string value2, Worksheet workshit )
        {
            if (Equals(null, workshit))
            {
                workshit = current;
            }

            var range = workshit.get_Range("C1", "C113");
            var myvalues = (Array)range.Cells.Value2;
            for (var i = 1; i < myvalues.Length; i++)
            {
                if (!Equals(null, myvalues.GetValue(i, 1)))
                {
                    var pole = myvalues.GetValue(i, 1).ToString();
                    if (pole == AOP)
                    {
                        WriteToWorkShit(i, "E", value, "F", value2,null);
                    }
                }
            }

            current = workshit;
            return current;
        }

        public Worksheet ZapisiAOPBS(string AOP, string value, string value2, Worksheet workshit)
        {
            if (Equals(null, workshit))
            {
                workshit = current;
            }

            var range = workshit.get_Range("B1", "B128");
            var myvalues = (Array)range.Cells.Value2;
            for (var i = 1; i < myvalues.Length; i++)
            {
                if (!Equals(null, myvalues.GetValue(i, 1)))
                {
                    var pole = myvalues.GetValue(i, 1).ToString();
                    if (pole == AOP)
                    {
                        WriteToWorkShit(i, "D", value, "E", value2,null);
                    }
                }
            }

            current = workshit;
            return current;
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(Tools.PrevediPoraka("Unable to release the Object " + ex.ToString()));
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool CloseWWorkSheet()
        {
            if (!Equals(current, null))
            {
                xlWorkBook.Save();
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                ReleaseObject(current);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlApp);
                return true;
            }
            return false;
        }

        public bool OpenWorkSheet(string FileName, string workSheetName)
        {
            xlApp = new Excel.Application();
            if (string.IsNullOrEmpty(FileName))
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.ShowDialog();
                    FileName = dlg.FileName;
                }
            }

            if (!File.Exists(FileName))
            {
                return false;
            }
            try
            {
                xlWorkBook = xlApp.Workbooks.Open(FileName, 0, false, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
                xlApp.EnableEvents = true;

                foreach (Worksheet item in xlWorkBook.Worksheets)
                {
                    item.Activate();
                    if (item.Name.Contains(workSheetName))
                    {
                        current = item;
                        return true;
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show(Tools.PrevediPoraka("Грешка при отворање на фајлот, проверете дали некој го користи"));
                current = null;
                return false;
            }

            return false;
        }
    }
}
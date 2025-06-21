using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BssBase.Classes
{
    public class DataGridViewPrinter
    {
        private DataGridView TheDataGridView;
        private PrintDocument ThePrintDocument;
        private bool IsCenterOnPage;
        private bool IsWithTitle;
        private string TheTitleText;
        private Font TheTitleFont;
        private Color TheTitleColor;
        private bool IsWithPaging;

        private static int CurrentRow;

        private static int PageNumber;

        private int PageWidth;
        private int PageHeight;
        private int LeftMargin;
        private int TopMargin;
        private int RightMargin;
        private int BottomMargin;

        private float CurrentY;

        private float RowHeaderHeight;
        private List<float> RowsHeight;
        private List<float> ColumnsWidth;
        private float TheDataGridViewWidth;

        private List<int[]> mColumnPoints;
        private List<float> mColumnPointsWidth;
        private int mColumnPoint;

        public DataGridViewPrinter(DataGridView aDataGridView, PrintDocument aPrintDocument, bool CenterOnPage, bool WithTitle, string aTitleText, Font aTitleFont, Color aTitleColor, bool WithPaging)
        {
            TheDataGridView = aDataGridView;
            ThePrintDocument = aPrintDocument;
            IsCenterOnPage = CenterOnPage;
            IsWithTitle = WithTitle;
            TheTitleText = aTitleText;
            TheTitleFont = aTitleFont;
            TheTitleColor = aTitleColor;
            IsWithPaging = WithPaging;
            PageNumber = 0;

            RowsHeight = new List<float>();
            ColumnsWidth = new List<float>();

            mColumnPoints = new List<int[]>();
            mColumnPointsWidth = new List<float>();

            if (!ThePrintDocument.DefaultPageSettings.Landscape)
            {
                PageWidth = ThePrintDocument.DefaultPageSettings.PaperSize.Width;
                PageHeight = ThePrintDocument.DefaultPageSettings.PaperSize.Height;
            }
            else
            {
                PageHeight = ThePrintDocument.DefaultPageSettings.PaperSize.Width;
                PageWidth = ThePrintDocument.DefaultPageSettings.PaperSize.Height;
            }

            LeftMargin = ThePrintDocument.DefaultPageSettings.Margins.Left;
            TopMargin = ThePrintDocument.DefaultPageSettings.Margins.Top;
            RightMargin = ThePrintDocument.DefaultPageSettings.Margins.Right;
            BottomMargin = ThePrintDocument.DefaultPageSettings.Margins.Bottom;

            CurrentRow = 0;
        }

        private void Calculate(Graphics g)
        {
            if (PageNumber == 0)
            {
                var tmpSize = new SizeF();
                Font tmpFont;
                float tmpWidth;

                TheDataGridViewWidth = 0;
                for (var i = 0; i < TheDataGridView.Columns.Count; i++)
                {
                    tmpFont = TheDataGridView.ColumnHeadersDefaultCellStyle.Font;
                    if (tmpFont == null)
                    {
                        tmpFont = TheDataGridView.DefaultCellStyle.Font;
                    }
                    tmpSize = g.MeasureString(TheDataGridView.Columns[i].HeaderText, tmpFont);
                    tmpWidth = tmpSize.Width;
                    RowHeaderHeight = tmpSize.Height;

                    for (var j = 0; j < TheDataGridView.Rows.Count; j++)
                    {
                        tmpFont = TheDataGridView.Rows[j].DefaultCellStyle.Font;
                        if (tmpFont == null)
                        {
                            tmpFont = TheDataGridView.DefaultCellStyle.Font;
                        }
                        tmpSize = g.MeasureString("Anything", tmpFont);
                        RowsHeight.Add(tmpSize.Height);

                        tmpSize = g.MeasureString(TheDataGridView.Rows[j].Cells[i].EditedFormattedValue.ToString(), tmpFont);
                        if (tmpSize.Width > tmpWidth)
                        {
                            tmpWidth = tmpSize.Width;
                        }
                    }
                    if (TheDataGridView.Columns[i].Visible)
                    {
                        TheDataGridViewWidth += tmpWidth;
                    }
                    ColumnsWidth.Add(tmpWidth);
                }

                int k;

                var mStartPoint = 0;
                for (k = 0; k < TheDataGridView.Columns.Count; k++)
                {
                    if (TheDataGridView.Columns[k].Visible)
                    {
                        mStartPoint = k;
                        break;
                    }
                }
                var mEndPoint = TheDataGridView.Columns.Count;
                for (k = TheDataGridView.Columns.Count - 1; k >= 0; k--)
                {
                    if (TheDataGridView.Columns[k].Visible)
                    {
                        mEndPoint = k + 1;
                        break;
                    }
                }
                var mTempWidth = TheDataGridViewWidth;
                var mTempPrintArea = (float)PageWidth - (float)LeftMargin - (float)RightMargin;

                if (TheDataGridViewWidth > mTempPrintArea)
                {
                    mTempWidth = 0.0F;
                    for (k = 0; k < TheDataGridView.Columns.Count; k++)
                    {
                        if (TheDataGridView.Columns[k].Visible)
                        {
                            mTempWidth += ColumnsWidth[k];
                            if (mTempWidth > mTempPrintArea)
                            {
                                mTempWidth -= ColumnsWidth[k];
                                mColumnPoints.Add(new int[] { mStartPoint, mEndPoint });
                                mColumnPointsWidth.Add(mTempWidth);
                                mStartPoint = k;
                                mTempWidth = ColumnsWidth[k];
                            }
                        }
                        mEndPoint = k + 1;
                    }
                }
                mColumnPoints.Add(new int[] { mStartPoint, mEndPoint });
                mColumnPointsWidth.Add(mTempWidth);
                mColumnPoint = 0;
            }
        }

        private void DrawHeader(Graphics g)
        {
            CurrentY = (float)TopMargin;

            if (IsWithPaging)
            {
                PageNumber++;
                var PageString = PageNumber.ToString();

                var PageStringFormat = new StringFormat();
                PageStringFormat.Trimming = StringTrimming.Word;
                PageStringFormat.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                PageStringFormat.Alignment = StringAlignment.Far;

                var PageStringFont = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);

                var PageStringRectangle = new RectangleF((float)LeftMargin, CurrentY, (float)PageWidth - (float)RightMargin - (float)LeftMargin, g.MeasureString(PageString, PageStringFont).Height);

                g.DrawString(PageString, PageStringFont, new SolidBrush(Color.Black), PageStringRectangle, PageStringFormat);

                CurrentY += g.MeasureString(PageString, PageStringFont).Height;
            }

            if (IsWithTitle)
            {
                var TitleFormat = new StringFormat();
                TitleFormat.Trimming = StringTrimming.Word;
                TitleFormat.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                if (IsCenterOnPage)
                {
                    TitleFormat.Alignment = StringAlignment.Center;
                }
                else
                {
                    TitleFormat.Alignment = StringAlignment.Near;
                }
                var TitleRectangle = new RectangleF((float)LeftMargin, CurrentY, (float)PageWidth - (float)RightMargin - (float)LeftMargin, g.MeasureString(TheTitleText, TheTitleFont).Height);

                g.DrawString(TheTitleText, TheTitleFont, new SolidBrush(TheTitleColor), TitleRectangle, TitleFormat);

                CurrentY += g.MeasureString(TheTitleText, TheTitleFont).Height;
            }

            var CurrentX = (float)LeftMargin;
            if (IsCenterOnPage)
            {
                CurrentX += (((float)PageWidth - (float)RightMargin - (float)LeftMargin) - mColumnPointsWidth[mColumnPoint]) / 2.0F;
            }
            var HeaderForeColor = TheDataGridView.ColumnHeadersDefaultCellStyle.ForeColor;
            if (HeaderForeColor.IsEmpty)
            {
                HeaderForeColor = TheDataGridView.DefaultCellStyle.ForeColor;
            }
            var HeaderForeBrush = new SolidBrush(HeaderForeColor);

            var HeaderBackColor = TheDataGridView.ColumnHeadersDefaultCellStyle.BackColor;
            if (HeaderBackColor.IsEmpty)
            {
                HeaderBackColor = TheDataGridView.DefaultCellStyle.BackColor;
            }
            var HeaderBackBrush = new SolidBrush(HeaderBackColor);

            var TheLinePen = new Pen(TheDataGridView.GridColor, 1);

            var HeaderFont = TheDataGridView.ColumnHeadersDefaultCellStyle.Font;
            if (HeaderFont == null)
            {
                HeaderFont = TheDataGridView.DefaultCellStyle.Font;
            }
            var HeaderBounds = new RectangleF(CurrentX, CurrentY, mColumnPointsWidth[mColumnPoint], RowHeaderHeight);
            g.FillRectangle(HeaderBackBrush, HeaderBounds);

            var CellFormat = new StringFormat();
            CellFormat.Trimming = StringTrimming.Word;
            CellFormat.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            RectangleF CellBounds;
            float ColumnWidth;
            for (var i = (int)mColumnPoints[mColumnPoint].GetValue(0); i < (int)mColumnPoints[mColumnPoint].GetValue(1); i++)
            {
                if (!TheDataGridView.Columns[i].Visible)
                {
                    continue;
                }
                ColumnWidth = ColumnsWidth[i];

                if (TheDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Right"))
                {
                    CellFormat.Alignment = StringAlignment.Far;
                }
                else
                {
                    if (TheDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Center"))
                    {
                        CellFormat.Alignment = StringAlignment.Center;
                    }
                    else
                    {
                        CellFormat.Alignment = StringAlignment.Near;
                    }
                }
                CellBounds = new RectangleF(CurrentX, CurrentY, ColumnWidth, RowHeaderHeight);

                g.DrawString(TheDataGridView.Columns[i].HeaderText, HeaderFont, HeaderForeBrush, CellBounds, CellFormat);

                if (TheDataGridView.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                {
                    g.DrawRectangle(TheLinePen, CurrentX, CurrentY, ColumnWidth, RowHeaderHeight);
                }
                CurrentX += ColumnWidth;
            }

            CurrentY += RowHeaderHeight;
        }

        private bool DrawRows(Graphics g)
        {
            var TheLinePen = new Pen(TheDataGridView.GridColor, 1);

            Font RowFont;
            Color RowForeColor;
            Color RowBackColor;
            SolidBrush RowForeBrush;
            SolidBrush RowBackBrush;
            SolidBrush RowAlternatingBackBrush;

            var CellFormat = new StringFormat();
            CellFormat.Trimming = StringTrimming.Word;
            CellFormat.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit;

            RectangleF RowBounds;
            float CurrentX;
            float ColumnWidth;
            while (CurrentRow < TheDataGridView.Rows.Count)
            {
                if (TheDataGridView.Rows[CurrentRow].Visible)
                {
                    RowFont = TheDataGridView.Rows[CurrentRow].DefaultCellStyle.Font;
                    if (RowFont == null)
                    {
                        RowFont = TheDataGridView.DefaultCellStyle.Font;
                    }
                    RowForeColor = TheDataGridView.Rows[CurrentRow].DefaultCellStyle.ForeColor;
                    if (RowForeColor.IsEmpty)
                    {
                        RowForeColor = TheDataGridView.DefaultCellStyle.ForeColor;
                    }
                    RowForeBrush = new SolidBrush(RowForeColor);

                    RowBackColor = TheDataGridView.Rows[CurrentRow].DefaultCellStyle.BackColor;
                    if (RowBackColor.IsEmpty)
                    {
                        RowBackBrush = new SolidBrush(TheDataGridView.DefaultCellStyle.BackColor);
                        RowAlternatingBackBrush = new SolidBrush(TheDataGridView.AlternatingRowsDefaultCellStyle.BackColor);
                    }
                    else
                    {
                        RowBackBrush = new SolidBrush(RowBackColor);
                        RowAlternatingBackBrush = new SolidBrush(RowBackColor);
                    }

                    CurrentX = (float)LeftMargin;
                    if (IsCenterOnPage)
                    {
                        CurrentX += (((float)PageWidth - (float)RightMargin - (float)LeftMargin) - mColumnPointsWidth[mColumnPoint]) / 2.0F;
                    }
                    RowBounds = new RectangleF(CurrentX, CurrentY, mColumnPointsWidth[mColumnPoint], RowsHeight[CurrentRow]);

                    if (CurrentRow % 2 == 0)
                    {
                        g.FillRectangle(RowBackBrush, RowBounds);
                    }
                    else
                    {
                        g.FillRectangle(RowAlternatingBackBrush, RowBounds);
                    }
                    for (var CurrentCell = (int)mColumnPoints[mColumnPoint].GetValue(0); CurrentCell < (int)mColumnPoints[mColumnPoint].GetValue(1); CurrentCell++)
                    {
                        if (!TheDataGridView.Columns[CurrentCell].Visible)
                        {
                            continue;
                        }
                        if (TheDataGridView.Columns[CurrentCell].DefaultCellStyle.Alignment.ToString().Contains("Right"))
                        {
                            CellFormat.Alignment = StringAlignment.Far;
                        }
                        else
                        {
                            if (TheDataGridView.Columns[CurrentCell].DefaultCellStyle.Alignment.ToString().Contains("Center"))
                            {
                                CellFormat.Alignment = StringAlignment.Center;
                            }
                            else
                            {
                                CellFormat.Alignment = StringAlignment.Near;
                            }
                        }
                        ColumnWidth = ColumnsWidth[CurrentCell];
                        var CellBounds = new RectangleF(CurrentX, CurrentY, ColumnWidth, RowsHeight[CurrentRow]);

                        g.DrawString(TheDataGridView.Rows[CurrentRow].Cells[CurrentCell].EditedFormattedValue.ToString(), RowFont, RowForeBrush, CellBounds, CellFormat);

                        if (TheDataGridView.CellBorderStyle != DataGridViewCellBorderStyle.None)
                        {
                            g.DrawRectangle(TheLinePen, CurrentX, CurrentY, ColumnWidth, RowsHeight[CurrentRow]);
                        }
                        CurrentX += ColumnWidth;
                    }
                    CurrentY += RowsHeight[CurrentRow];

                    if ((int)CurrentY > (PageHeight - TopMargin - BottomMargin))
                    {
                        CurrentRow++;
                        return true;
                    }
                }
                CurrentRow++;
            }

            CurrentRow = 0;
            mColumnPoint++;

            if (mColumnPoint == mColumnPoints.Count)
            {
                mColumnPoint = 0;
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DrawDataGridView(Graphics g)
        {
            try
            {
                Calculate(g);
                DrawHeader(g);
                var bContinue = DrawRows(g);
                return bContinue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Tools.PrevediPoraka("Operation failed: " + ex.Message.ToString()), Application.ProductName + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
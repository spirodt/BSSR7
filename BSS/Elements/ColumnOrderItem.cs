using System;
using System.Drawing;

namespace BssBase
{
    [Serializable]
    public sealed class ColumnOrderItem
    {
        public int DisplayIndex { get; set; }

        public int Width { get; set; }

        public bool Visible { get; set; }

        public int ColumnIndex { get; set; }

        public Color BackColor { get; set; }

        public Color ForeColor { get; set; }

        public Color SelectionBakcColor { get; set; }

        public Color SelectionForeColor { get; set; }
    }
}
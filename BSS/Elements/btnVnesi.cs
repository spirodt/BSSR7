﻿using System.Drawing;
using System.Windows.Forms;

namespace BssBase.Elements
{
    public partial class btnVnesi : Button
    {
        public btnVnesi()
        {
            InitializeComponent();
            BackColor = Color.WhiteSmoke;
            DialogResult = DialogResult.Cancel;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Image = Properties.Resources._001_01;
            Name = "btnVnesi";
            UseVisualStyleBackColor = false;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleCenter;
            Text = "Внеси";
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseDownBackColor = Color.Silver;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            MinimumSize = new Size(132, 38);
        }
    }
}
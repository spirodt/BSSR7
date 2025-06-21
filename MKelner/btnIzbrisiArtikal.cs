using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnIzbrisiArtikal : Button
    {
        public btnIzbrisiArtikal(int sirina)
        {
            Image = BssBase.Properties.Resources._001_02;
            Size = new Size(sirina, 60);
            Text = "Избриши артикал";
            Name = "IzbrisiArtikal";
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
            Dock = DockStyle.Bottom;
            Font = new Font(Font.FontFamily, 15, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(btnIzbrisiArtikal_Click);
        }

        public btnIzbrisiArtikal()
        {
            Image = BssBase.Properties.Resources._001_02;

            Text = "Избриши артикал";
            Name = "IzbrisiArtikal";
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
            Dock = DockStyle.Bottom;
            Font = new Font(Font.FontFamily, 15, FontStyle.Regular);
            FlatStyle = FlatStyle.Standard;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(btnIzbrisiArtikal_Click);
        }

        private void btnIzbrisiArtikal_Click(object sender, EventArgs e)
        {
            if (((frmKelner)Parent.FindForm()).NalogIDZaInsert != -1)
            {
                ((frmKelner)Parent.FindForm()).brisiArtikal();
            }
            else
            {
                MessageBox.Show(Tools.PrevediPoraka("Нарачката е затворен , не е дозволена измена \n Отверете нова нарачка или одберете постоечка "), "Грешка !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
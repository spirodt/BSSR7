using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MKelner.Forms
{
    public class btnSmetkaKasa : Button
    {
        public int SmetkaID;
        public string brojNaSmetka;
        public int MasaBroj;
        public string ZabeleskaZaSmetka;
        public string DatumNaSmetka;

        public ContextMenuStrip meni;

        public btnSmetkaKasa(string TextBUtton, string _brojNaSmetka, string PocnataNa, int _IDSmetka, int sirina, int masa, string zabeleska = "")
        {
            Image = BssBase.Properties.Resources.smetka;
            Size = new Size(cfg.sirinaNaDugminjaGore + 35, cfg.VisinaNaDugminjaGore + 30);
            Name = TextBUtton;
            if (zabeleska == "")
            {
                Text = String.Format(Tools.PrevediPoraka("{0}\n Купувач: F{1}\n{2}"), TextBUtton, masa + 1, PocnataNa);
                ZabeleskaZaSmetka = string.Format(Tools.PrevediPoraka("Купувач бр: {0}"), masa);
            }
            else
            {
                Text = String.Format("{0}\n {1}\n{2}", TextBUtton, zabeleska, PocnataNa);
                ZabeleskaZaSmetka = zabeleska;
            }
            Tag = PocnataNa;
            SmetkaID = _IDSmetka;
            brojNaSmetka = _brojNaSmetka;
            MasaBroj = masa;
            if (BssBase.settings.ZatvoranjeNaSmetkaOdButton)
            {
                meni = new ContextMenuStrip();
                meni.Items.Add("Затвори сметка");
                meni.Items.Add("Затвори Сочувана");

                meni.Items[0].Name = SmetkaID.ToString();
                meni.Items[0].Image = BssBase.Properties.Resources.close_32;
                meni.Items[0].Click += btnSmetkaKasaZatvori_Click;
                meni.Items[1].Name = SmetkaID.ToString() + "_f";
                meni.Items[1].Image = BssBase.Properties.Resources.close_32;
                meni.Items[1].Click += btnSmetkaKasaFiskaln_Click;
                ContextMenuStrip = meni;
            }
            DatumNaSmetka = PocnataNa;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
            Font = new Font(Font.FontFamily, 13, FontStyle.Regular);
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Beige;
            Margin = new Padding(5);
            Click += new EventHandler(btnSmetkaKasa_Click);
            
        }

        private void btnSmetkaKasaFiskaln_Click(object sender, EventArgs e)
        {
            MFakturi.Forms.frmKasa.zatvoriSmetka(Tools.PrazenStringToInt(((ToolStripMenuItem)sender).Name.Split('_').FirstOrDefault()));
            MFakturi.Forms.frmKasa.ZatvoriSocuvanaFiskalna(Tools.PrazenStringToInt(((ToolStripMenuItem)sender).Name.Split('_').FirstOrDefault()));
            ((frmKelner)Parent.FindForm()).prikaziSmetkiKasa();
        }

        private void btnSmetkaKasaZatvori_Click(object sender, EventArgs e)
        {
            MFakturi.Forms.frmKasa.zatvoriSmetka(Tools.PrazenStringToInt(((ToolStripMenuItem)sender).Name));
            ((frmKelner)Parent.FindForm()).prikaziSmetkiKasa();
        }

        private void btnSmetkaKasa_Click(object sender, EventArgs e)
        {
            ((frmKelner)Parent.FindForm()).SmetkaID = ((btnSmetkaKasa)sender).SmetkaID;
            ((frmKelner)Parent.FindForm()).lblBrNaSmetka.Text = ((btnSmetkaKasa)sender).brojNaSmetka;
            using (MFakturi.Forms.frmKasa kasa = new MFakturi.Forms.frmKasa(((btnSmetkaKasa)sender).SmetkaID, ((btnSmetkaKasa)sender).brojNaSmetka, BssBase.tmpConfigs.LogiranUserFullName, DatumNaSmetka, ZabeleskaZaSmetka))
            {
                kasa.StartReader();
                kasa.ShowDialog();
                kasa.CloseRader();
            }
            if(Parent != null)
            {
                var frm = (frmKelner)Parent.FindForm();
                frm?.prikaziSmetkiKasa();
            
            }
        }
    }
}
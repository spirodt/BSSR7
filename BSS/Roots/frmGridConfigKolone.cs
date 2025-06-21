using System;
using System.Collections.Generic;

namespace BssBase.Forms
{
    public partial class frmGridConfigKolone : frmEditTop
    {
        public Dictionary<String, bool> ListaVrati;

        public frmGridConfigKolone(Dictionary<String, bool> Lista)
        {
            InitializeComponent();
            ListaVrati = new Dictionary<string, bool>();
            foreach (var item in Lista)
            {
                ListaChk.Items.Add(item.Key, item.Value);
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < ListaChk.Items.Count; i++)
            {
                if (ListaChk.GetItemChecked(i))
                {
                    ListaVrati.Add(ListaChk.Items[i].ToString(), true);
                }
                else
                {
                    ListaVrati.Add(ListaChk.Items[i].ToString(), false);
                }
            }
        }

        private void frmGridConfigKolone_Load(object sender, EventArgs e)
        {
            btnPotvrdi.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
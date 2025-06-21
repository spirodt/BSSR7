using System;
using System.Data;
using System.Windows.Forms;
using BssBase;

namespace BSSR.Forms
{
    public partial class frmNarackiVnes : frmBigEdit
    {
        public frmNarackiVnes()
        {
            InitializeComponent();
            datumNaNarackaDateTimePicker.Value = DateTime.Now;
            btnOk.Visible = false;
            odObjekttxtBase.Text = tmpConfigs.NazivNaObjket;
            narackaBrojtxtBase.Text = Tools.NajdiNaredenBrojUTabela("NarackaBroj", "tblNaracki").ToString();
        }

        private void frmNarackiVnes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bSSSDataset.tblNaracki' table. You can move, or remove it, as needed.

            tblNarackiTableAdapter.Fill(bSSSDataset.tblNaracki, new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                    datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                    datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                    00,
                                                                                                                    00,
                                                                                                                    00,
                                                                                                                    DateTimeKind.Local), new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                    datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                    datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                    23,
                                                                                                                    59,
                                                                                                                    59,
                                                                                                                    DateTimeKind.Local));
        }

        private void btnPonisti1_Click(object sender, EventArgs e)
        {
            if (Equals(tblNarackiBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)tblNarackiBindingSource.Current)["ID"].ToString());
                Tools.IzbrisiNaracka(stavkaID);

                tblNarackiTableAdapter.Fill(bSSSDataset.tblNaracki, new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local), new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                        23,
                                                                                                                        59,
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local));
            }
        }

        private void btnPotvrdi2_Click(object sender, EventArgs e)
        {
            if (Equals(tblNarackiBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)tblNarackiBindingSource.Current)["ID"].ToString());
                Tools.OznaciZavrsena(stavkaID);

                tblNarackiTableAdapter.Fill(bSSSDataset.tblNaracki, new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local), new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                        23,
                                                                                                                        59,
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local));
            }
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (!narackaBrojtxtBase.IsTextEmpty() && !opistxtBase.IsTextEmpty() && !imetxtBase.IsTextEmpty())
            {
                Tools.insertirajNarackaVoTabela(narackaBrojtxtBase.PrazenStringToInt(), opistxtBase.Text, datumNaNarackaDateTimePicker.Value, imetxtBase.Text, kontakttxtBase.Text, odObjekttxtBase.Text, false);
                narackaBrojtxtBase.Clear();
                opistxtBase.Clear();
                kontakttxtBase.Clear();
                imetxtBase.Clear();
                datumNaNarackaDateTimePicker.Value = DateTime.Now;
                odObjekttxtBase.Text = tmpConfigs.NazivNaObjket;

                tblNarackiTableAdapter.Fill(bSSSDataset.tblNaracki, new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        00,
                                                                                                                        DateTimeKind.Local), new DateTime(datumNaNarackaDateTimePicker.Value.Year,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Month,
                                                                                                                        datumNaNarackaDateTimePicker.Value.Day,
                                                                                                                        23,
                                                                                                                        59,
                                                                                                                        59,
                                                                                                                        DateTimeKind.Local));
                MessageBox.Show("Внесено !!!");
                narackaBrojtxtBase.Text = Tools.NajdiNaredenBrojUTabela("NarackaBroj", "tblNaracki").ToString();
            }
            else
            {
                MessageBox.Show("Пополнете ги сите полиња");
            }
        }

        private void btnPecati2_Click(object sender, EventArgs e)
        {
        }
    }
}
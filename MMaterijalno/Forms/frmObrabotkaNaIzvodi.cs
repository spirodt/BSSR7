using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using BssBase;

using DevExpress.XtraPrinting;

namespace MMaterijalno.Forms
{
    public partial class frmObrabotkaNaIzvodi : frmBigEdit
    {
        public frmObrabotkaNaIzvodi()
        {
            InitializeComponent();

            if (BssBase.settings.TipNaPrograma == "10KulaB")
            {
                var aAutoCompleteCustomSource = new AutoCompleteStringCollection()
                {
                    "300-0000049563-48 (ТЕКОВНО)",
                    "300-0000049575-12 (ВРВ)"
                };

                smetkatxtBase.AutoCompleteCustomSource = aAutoCompleteCustomSource;
                smetkatxtBase.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                smetkatxtBase.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else
            {
                var firmaINfo = Tools.NajdiInfoZaFirma(BssBase.settings.firmaId);
                if (firmaINfo != null)
                    smetkatxtBase.Text = firmaINfo["ZiroSmetka"].ToString();
            }

        }

        public frmObrabotkaNaIzvodi(int id)
        {
            InitializeComponent();


            IzvodID = id;
            FormIsEdit = true;
            var IzvodInfo = Tools.NajdiInfoZaIzvod(IzvodID);
            brojNaIzvodtxtBase.Text = IzvodInfo["BrojNaIzvod"].ToString();
            zabeleskatxtBase.Text = IzvodInfo["Zabeleska"].ToString();
            smetkatxtBase.Text = IzvodInfo["Smetka"].ToString();
            datumNaIzvodDateTimePicker.Value = Convert.ToDateTime(IzvodInfo["DatumNaIzvod"]);
            viewIzvodiStavkiTableAdapter.FillBy(materijalnoDataSet.viewIzvodiStavki, IzvodID);
        }

        private void frmObrabotkaNaIzvodi_Load(object sender, EventArgs e)
        {
            gridView1.ActiveFilter.Clear();
            txtDolzi.Leave += txtDolzi_Leave;
            txtPobaruva.Leave += txtPobaruva_Leave;

            //   this.viewIzvodiTableAdapter.Fill(this.materijalnoDataSet.viewIzvodi);


        }
        private void zbxPartner_DataRead()
        {
            zbxPartner.Value.Text = zbxPartner.ret3;
            validatePartner();
        }

        public bool validatePartner()
        {
            var info = Tools.NajdiInfoZaSifraPartner(zbxPartner.Value.Text);
            if (zbxPartner.Value.TextLength > 0)
            {
                if (!Equals(info, null))
                {
                    zbxPartner.zoomClear();
                    txtPartner.Clear();
                    zbxPartner.ret1 = info["ID"].ToString();
                    zbxPartner.Value.Text = info["Sifra"].ToString();
                    zbxPartner.Text = info["Naziv"].ToString();
                    txtPartner.Text = info["Naziv"].ToString();
                    txtDolzi.Focus();
                    return true;
                }
                else
                {
                    MessageBox.Show(Tools.PrevediPoraka("PartnerotNePostoi"));
                    zbxPartner.zoomClear();
                    txtPartner.Text = string.Empty;
                    return false;
                }
            }
            return false;
        }

        private void zbxPartner_Validated(object sender, EventArgs e)
        {
            validatePartner();
        }

        public bool prikaziDokumenti()
        {
            DataTable db = new DataTable();


            decimal dolzi = 0;
            decimal Pobaruva = 0;
            Pobaruva = txtPobaruva.PrazenStringToDecimal_dec();
            dolzi = txtDolzi.PrazenStringToDecimal_dec();

            if (Pobaruva != 0)
            {
                db.Clear();
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand($"select * from viewDokumentiZaPlakjanje where TipNaDokument <10 and  tblPartnerID = {zbxPartner.ret1} order by Datum", con))
                    {
                        con.Open();
                        db.Load(com.ExecuteReader());
                        con.Close();
                    }
                }

                BssBase.Elements.SelectBox box = new BssBase.Elements.SelectBox(db, "DOKUMENTI",dolzi, Pobaruva,false);
                box.Text = "Побарува";
                
                DialogResult rez = box.ShowDialog();

                if (rez == DialogResult.OK)
                {
                    var result = box.DbREsult;
                    if (result.Rows.Count > 0)
                    {
                        int partnerID = Tools.PrazenStringToInt(zbxPartner.ret1);
                        foreach (DataRow item in result.Rows)
                        {
                            Tools.InsertirajStavkaVoIzvod(IzvodID, partnerID, 0, Tools.PrazenStringToDecimal_dec(item["Iznos"].ToString()), Tools.PrazenStringToInt(item["TipNaDokument"].ToString()), Tools.PrazenStringToInt(item["DokumentID"].ToString()), item["BrojNaDokument"].ToString());
                        }
                    }
                    return true;

                }

                box.Dispose();
            }

            if (dolzi != 0)
            {
                db.Clear();
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand($"select * from viewDokumentiZaPlakjanje where TipNaDokument > 10 and tblPartnerID ={zbxPartner.ret1} order by Datum", con))
                    {
                        con.Open();
                        db.Load(com.ExecuteReader());
                        con.Close();
                    }
                }

                BssBase.Elements.SelectBox box = new BssBase.Elements.SelectBox(db, "DOKUMENTI", dolzi, Pobaruva,true);
                box.Text = "Побарува";
                DialogResult rez = box.ShowDialog();

                if (rez == DialogResult.OK)
                {
                    var result = box.DbREsult;
                    if (result.Rows.Count > 0)
                    {
                        int partnerID = Tools.PrazenStringToInt(zbxPartner.ret1);
                        foreach (DataRow item in result.Rows)
                        {
                            Tools.InsertirajStavkaVoIzvod(IzvodID, partnerID, Tools.PrazenStringToDecimal_dec(item["Iznos"].ToString()), 0, Tools.PrazenStringToInt(item["TipNaDokument"].ToString()), Tools.PrazenStringToInt(item["DokumentID"].ToString()), item["BrojNaDokument"].ToString());
                        }
                    }
                    return true;
                }
                box.Dispose();
            }

            return false;

        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (IzvodID == -1)
            {
                e.Cancel = true;
                MessageBox.Show(Tools.PrevediPoraka("Заглавјето не е правилно пополнето "), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool validacijaStavka()
        {
            if (string.IsNullOrEmpty(zbxPartner.ret1))
            {
                zbxPartner.Focus();
                return false;
            }

            if (txtDolzi.PrazenStringToDecimal_dec() == 0 && txtPobaruva.PrazenStringToDecimal_dec() == 0)
            {
                zbxPartner.Focus();
                return false;
            }

            return true;
        }

        private void btnSocuvajStavka_Click(object sender, EventArgs e)
        {
            if (validacijaStavka())
            {

                var result = prikaziDokumenti();
                if (result)
                {
                    viewIzvodiStavkiTableAdapter.FillBy(materijalnoDataSet.viewIzvodiStavki, IzvodID);
                    txtPobaruva.Text = 0.ToString("N2");
                    txtDolzi.Text = 0.ToString("N2");
                    zbxPartner.Text = string.Empty;
                    zbxPartner.ret1 = string.Empty;
                    txtPartner.Text = string.Empty;
                    zbxPartner.Value.Text = string.Empty;
                }
            }

        }

        public bool validacija_izvod()
        {
            if (string.IsNullOrEmpty(brojNaIzvodtxtBase.Text))
            {
                return false;
            }


            if (brojNaIzvodtxtBase.Text == 0.ToString())
            {
                return false;
            }

            return true;
        }
        public int IzvodID = -1;
        private void btnSocuvajZaglavje_Click(object sender, EventArgs e)
        {
            if (validacija_izvod())
            {
                if (IzvodID == -1 || FormIsEdit)
                {
                    if (!FormIsEdit)
                        IzvodID = Tools.KreirajIzvod(brojNaIzvodtxtBase.PrazenStringToInt(), datumNaIzvodDateTimePicker.Value, smetkatxtBase.Text, zabeleskatxtBase.Text);
                    else
                    {
                        Tools.UpdateIzvod(IzvodID, brojNaIzvodtxtBase.PrazenStringToInt(), datumNaIzvodDateTimePicker.Value, smetkatxtBase.Text, zabeleskatxtBase.Text);
                    }
                    if (IzvodID != -1)
                    {
                        xtraTabControl1.SelectedTabPage = xtraTabPage2;
                    }
                    else
                    {
                        xtraTabControl1.SelectedTabPage = xtraTabPage1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пополнете ги сите податоци во заглавјето !!!");
                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }
        }

        private void btnIzbrisiStavka_Click(object sender, EventArgs e)
        {
            if (Equals(viewIzvodiStavkiBindingSource.Current, null))
                return;
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurni"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int stavkaID = Tools.PrazenStringToInt(((DataRowView)viewIzvodiStavkiBindingSource.Current)["ID"].ToString());
                Tools.IzbrisiStavkaOdIzvod(IzvodID, stavkaID);
                viewIzvodiStavkiTableAdapter.FillBy(materijalnoDataSet.viewIzvodiStavki, IzvodID);
            }
        }

        private void txtDolzi_Leave(object sender, EventArgs e)
        {
            txtPobaruva.Focus();
        }

        private void txtPobaruva_Leave(object sender, EventArgs e)
        {
            btnSocuvajStavka.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private PrintableComponentLink PrintGridSettings()
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            link.Landscape = true;
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = this.viewDokumentiStavkigrd;

            phf.Header.Content.Clear();
            const string leftColumn = "Страни: [Page # of Pages #]";
            var middleColumn = $"Извод број {brojNaIzvodtxtBase.Text} Од Датум {datumNaIzvodDateTimePicker.Value:dd.MM.yyyy} {Environment.NewLine} Сметка:{smetkatxtBase.Text}";
            string rightColumn = "Датум: " + DateTime.Now.ToString("dd.MM.yyyy");

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;
            phf.Footer.Content.Clear();
            var info = Tools.NajdiInfoZaFirma(1);
            var NazivNaFirma = info.Table.Rows[0]["ImeNaFirma"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Adresa"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Grad"].ToString();
            var FmiddleColumn = NazivNaFirma;
            phf.Footer.Content.AddRange(new string[] { FmiddleColumn });
            phf.Footer.LineAlignment = BrickAlignment.None;

            return link;
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            
            if (this.materijalnoDataSet.viewIzvodiStavki.Rows.Count > 0)
            {
                this.gridView1.Columns["IznosDokument"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                PrintableComponentLink link = PrintGridSettings();

                link.ShowPreview();
            }
        }
    }
}

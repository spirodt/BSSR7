using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BssBase.Elements
{
    public partial class SelectBox : Form
    {
        public List<string> output;
        public string result;

        public DataTable DbREsult;

        public string TipNaForma;

        private Dictionary<string, int> OutLista;
        public DataSet DB;
        public Dictionary<String, int> _ListaIn;

        public SelectBox(Dictionary<string, int> ListaIn = null)
        {
            InitializeComponent();

            DB = new DataSet();
            DB.Tables.Add("Vrednosti");
            DB.Tables["Vrednosti"].Columns.Add("Key");
            DB.Tables["Vrednosti"].Columns.Add("Val");

            if (!Equals(null, ListaIn))
            {
                foreach (KeyValuePair<string, int> Vrednost in ListaIn)
                {
                    var dr = DB.Tables["Vrednosti"].NewRow();
                    dr["Key"] = Vrednost.Key;
                    if (Vrednost.Value == 1)
                    {
                        dr["Val"] = (true);
                    }
                    if (Vrednost.Value == 0)
                    {
                        dr["Val"] = (false);
                    }
                    DB.Tables["Vrednosti"].Rows.Add(dr);
                }
            }
            gridBig1.DataSource = DB.Tables["Vrednosti"];
        }

        private decimal saldoODIzvod;
        public SelectBox(DataTable dbSelctItems ,string tipNaforma, decimal SaldoODIzvod)
        {
            settings.NeSortirajKoloni = true;
            InitializeComponent();
            dbSelctItems.Columns["PlatenoZaDokument"].ReadOnly = false;
            dbSelctItems.Columns["PreostanatoZaPlacanje"].ReadOnly = false;
            gridBig1.DataSource = dbSelctItems;
            TipNaForma = tipNaforma;
            if (SaldoODIzvod == -1)
            {
                txtSaldo.Text = SaldoODIzvod.ToString("N2");
                txtSaldo.Visible = false;
            }

            saldoODIzvod = SaldoODIzvod;

            DbREsult = new DataTable();
            DbREsult.Columns.Add("Iznos");
            DbREsult.Columns.Add("TipNaDokument");
            DbREsult.Columns.Add("DokumentID");
            DbREsult.Columns.Add("BrojNaDokument");
        }

        public SelectBox(DataTable dbSelctItems, string tipNaforma, decimal dolguva, decimal pobaruva , bool TipNaKnizenjeDolzi)
        {
            settings.NeSortirajKoloni = true;
            InitializeComponent();
            dbSelctItems.Columns["PlatenoZaDokument"].ReadOnly = false;
            dbSelctItems.Columns["PreostanatoZaPlacanje"].ReadOnly = false;
            gridBig1.DataSource = dbSelctItems;
            TipNaForma = tipNaforma;
            decimal SaldoODIzvod = 0;
            if (TipNaKnizenjeDolzi)
            {
                SaldoODIzvod = dolguva - pobaruva;
            }else
            {
                SaldoODIzvod = pobaruva - dolguva;
            }
            
            txtDolzi.Text = dolguva.ToString();
            txtPobaruva.Text = pobaruva.ToString();
            txtSaldo.Text = saldoODIzvod.ToString();
            saldoODIzvod = SaldoODIzvod;

            DbREsult = new DataTable();
            DbREsult.Columns.Add("Iznos");
            DbREsult.Columns.Add("TipNaDokument");
            DbREsult.Columns.Add("DokumentID");
            DbREsult.Columns.Add("BrojNaDokument");
        }

        public decimal GetSaldo()
        {
            return saldoODIzvod;
        }

        public decimal GetPobaruva()
        {
            return Tools.PrazenStringToDecimal_dec(txtPobaruva.Text);
        }
        public decimal GetDolzi()
        {
            return Tools.PrazenStringToDecimal_dec(txtDolzi.Text);
        }
        public SelectBox(DataTable dbSelctItems, Dictionary<String, int> ListaIn)
        {
            settings.NeSortirajKoloni = true;
            InitializeComponent();
            gridBig1.DataSource = dbSelctItems;

            _ListaIn = ListaIn;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            settings.NeSortirajKoloni = false;
            Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            OutLista = new Dictionary<string, int>();
            foreach (DataGridViewRow row in gridBig1.Rows)
            {
                if (row.Cells["STIKLIRANO"].Value.ToString().ToUpper() == "TRUE")
                {
                    OutLista.Add(row.Cells["Broj"].Value.ToString(), 1);
                }
                else
                {
                    OutLista.Add(row.Cells["Broj"].Value.ToString(), 0);
                }
            }

            if (TipNaForma == "DOKUMENTI")
            {
                foreach (DataGridViewRow row in gridBig1.Rows)
                {
                    if (row.Cells["STIKLIRANO"].Value.ToString().ToUpper() == "TRUE")
                    {
                        DataRow nINsertRow = DbREsult.NewRow();
                        nINsertRow["Iznos"] = row.Cells["PlatenoZaDokument"].Value;
                        nINsertRow["TipNaDokument"] = row.Cells["TipNaDokument"].Value;
                        nINsertRow["DokumentID"] = row.Cells["ID"].Value;
                        nINsertRow["BrojNaDokument"] = row.Cells["Broj"].Value;
                        DbREsult.Rows.Add(nINsertRow);

                    }
                }
            }

            if (TipNaForma != "DOKUMENTI") 
            if (!Equals(null, OutLista))
            {
                foreach (KeyValuePair<string, int> Vrednost in OutLista)
                {
                    if (Vrednost.Value == 1)
                    {
                        result += Vrednost.Key + ";";
                    }
                }
                if (!Equals(result, null))
                {
                    result = result.Remove(result.Length - 1, 1);
                }
            }

            
            settings.NeSortirajKoloni = false;
            Close();

        }

        private void SelectBox_Load(object sender, EventArgs e)
        {
            if (TipNaForma != "DOKUMENTI")
            {
                gridBig1.ColumnHeadersVisible = false;
                gridBig1.RowHeadersVisible = false;

                gridBig1.Columns["ID"].Visible = false;
                gridBig1.Columns["NazivPartner"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridBig1.AutoResizeColumns();

                gridBig1.SetirajStikliranje(0);

                if (!Equals(null, _ListaIn))
                {
                    if (_ListaIn.Count > 0)
                        foreach (DataGridViewRow item in gridBig1.Rows)
                        {
                            if (_ListaIn.ContainsKey(item.Cells["Broj"].Value.ToString()))
                            {
                                if (_ListaIn[item.Cells["Broj"].Value.ToString()] == 1)
                                {
                                    item.Cells["STIKLIRANO"].Value = true;
                                }
                                else
                                {
                                    item.Cells["STIKLIRANO"].Value = false;
                                }
                            }
                        }
                }
            }
            else
            {

                gridBig1.ColumnHeadersVisible = true;
                gridBig1.RowHeadersVisible = true;

                gridBig1.Columns["ID"].Visible = false;
                gridBig1.Columns["TipNaDokument"].Visible = false;
                gridBig1.Columns["Broj"].Visible = true;
                gridBig1.Columns["tblPartnerID"].Visible = false;
                gridBig1.Columns["Datum"].Visible = true;
                gridBig1.Columns["IznosNaDokument"].Visible = true;
                gridBig1.Columns["PlatenoZaDokument"].Visible = true;
                gridBig1.Columns["PlatenoZaDokument"].ReadOnly = false;
                gridBig1.Columns["PreostanatoZaPlacanje"].ReadOnly = false;
                gridBig1.Columns["DocNaziv"].Visible = true;
                gridBig1.Columns["PreostanatoZaPlacanje"].Visible = true;
                gridBig1.Columns["SifraPartner"].Visible = true;
                
                gridBig1.Columns["DocNaziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                gridBig1.Columns["ID"].HeaderText = "Реден број";
                gridBig1.Columns["SifraPartner"].HeaderText = "Шифра партнер";
                gridBig1.Columns["TipNaDokument"].HeaderText = "Тип на документ";
                gridBig1.Columns["Broj"].HeaderText = "Број на документ";
                gridBig1.Columns["tblPartnerID"].HeaderText = "Реден број на партнер";
                gridBig1.Columns["Datum"].HeaderText = "Датум на документ";
                gridBig1.Columns["IznosNaDokument"].HeaderText = "Износ на документ";
                gridBig1.Columns["PlatenoZaDokument"].HeaderText = "Платено";
                gridBig1.Columns["PreostanatoZaPlacanje"].HeaderText = "Преостанато";
                gridBig1.Columns["DocNaziv"].HeaderText = "Документ";
                
                gridBig1.SetirajStikliranje(0);
                gridBig1.AutoResizeColumns();

                

            }
        }

        private void gridBig1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridBig1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridBig1.CurrentRow != null)
                {
                    if (gridBig1.CurrentCell.OwningColumn.Name == "STIKLIRANO")
                    {
                        bool stiklirana = gridBig1.CurrentCell.Value.ToString().ToUpper() == "TRUE";

                        if (saldoODIzvod > 0 || !txtSaldo.Visible)
                        {
                            decimal Soi = saldoODIzvod;
                            decimal PZD = Tools.PrazenStringToDecimal_dec(gridBig1["PlatenoZaDokument", e.RowIndex].Value.ToString());
                            decimal PZP = Tools.PrazenStringToDecimal_dec(gridBig1["PreostanatoZaPlacanje", e.RowIndex].Value.ToString());
                            

                            if (stiklirana)
                            {
                                DataGridViewCell celPlatenoZaDokument = gridBig1["PlatenoZaDokument", e.RowIndex];
                                

                                if (PZP < Soi)
                                {
                                    PZD = PZP;
                                    Soi = Soi - PZD;
                                    
                                } else {

                                    PZD = Soi;
                                    Soi = 0;
                                }

                                celPlatenoZaDokument.Value = PZD;
                                saldoODIzvod = Soi;
                                txtSaldo.Text = saldoODIzvod.ToString("N2");
                            }
                            else
                            {
                                DataGridViewCell celPlatenoZaDokument = gridBig1["PreostanatoZaPlacanje", e.RowIndex];

                                Soi = Soi + PZD;
                                PZD = 0;
                                gridBig1["PlatenoZaDokument", e.RowIndex].Value = 0;
                                saldoODIzvod = Soi;
                                txtSaldo.Text = saldoODIzvod.ToString("N2");

                            }
                            

                        }
                        else
                        {
                            decimal Soi = saldoODIzvod;
                            decimal PZD = Tools.PrazenStringToDecimal_dec(gridBig1["PlatenoZaDokument", e.RowIndex].Value.ToString());
                            decimal PZP = Tools.PrazenStringToDecimal_dec(gridBig1["PreostanatoZaPlacanje", e.RowIndex].Value.ToString());
                            
                                
                            Soi = Soi + PZD;
                            PZD = 0;
                            gridBig1["PlatenoZaDokument", e.RowIndex].Value = 0;
                            
                            saldoODIzvod = Soi;
                            
                            txtSaldo.Text = saldoODIzvod.ToString("N2");
                            gridBig1.CurrentCell.Value = false;
                        }
                    }
                }
            }
        }
    }
}
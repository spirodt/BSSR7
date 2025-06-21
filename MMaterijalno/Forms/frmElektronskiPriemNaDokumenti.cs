using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using BSS;

namespace MMaterijalno.Forms
{
    public partial class frmElektronskiPriemNaDokumenti : Form
    {
        public DataSet ds;
        private string fileName;
        private string FileContents;

        public frmElektronskiPriemNaDokumenti()
        {
            InitializeComponent();
            listView1.DoubleClick += listView1_DoubleClick;
            if (Directory.Exists(Application.StartupPath + @"\ElektronskoPracanje\Primeni\"))
            {
                var files = Directory.GetFiles(Application.StartupPath + @"\ElektronskoPracanje\Primeni\");
                foreach (var item in files)
                {
                    FileInfo f = new FileInfo(item);
                    listView1.Items.Add(f.Name);
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + @"\ElektronskoPracanje\Primeni\"))
            {
                ds = new DataSet("MaterijalnoDataSet");
                fileName = Application.StartupPath + @"\ElektronskoPracanje\Primeni\" + listView1.SelectedItems[0].Text;

                if (File.Exists(fileName))
                {
                    ds.ReadXml(fileName);
                    FileContents = File.ReadAllText(fileName);
                    ds.Tables["viewDokumenti"].TableName = "viewDokumenti";
                    ds.Tables["viewDokumentiStavki"].TableName = "viewDokumentiStavki";
                    ds.AcceptChanges();
                    viewDokumentiStavkigrd.DataSource = ds.Tables["viewDokumentiStavki"];
                    foreach (DataRow Header in ds.Tables["viewDokumenti"].Rows)
                    {
                        txBroj.Text = Header["Broj"].ToString();
                        txtDatum.Text = Header["Datum"].ToString();
                        txtTip.Text = Header["TipNaDokument"].ToString();
                        txtIznos.Text = Tools.PrazenStringToDecimal_dec(Header["IznosSoDDV"].ToString()).ToString("N2");
                        txtDoObjekt.Text = Header["ObejektDO"].ToString();
                        txtObjekt.Text = Header["ObjektOD"].ToString();
                    }
                    btnPecati.Enabled = false;
                    btnPLT.Enabled = false;
                }
            }
        }
        int dokumentID;
        private void btnЗапиши_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show(Tools.PrevediPoraka("DaliSteSigurniDekaSakateDaGoZapiseteOvojDokument"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                int ID = -1;
                string tipNaDokument = string.Empty;
                foreach (DataRow Header in ds.Tables["viewDokumenti"].Rows)
                {
                    tipNaDokument = Header["TipNaDokument"].ToString();
                    int BrojNaDokumentNareden = Tools.NajdiNaredenBrojUTabela("Broj", "tblDokumenti", "TipNaDokument=" + BssBase.tmpConfigs.TipNaDokumentIdPriem.ToString());
                    string zabeleskaDodatok = @"\" + "Број од преносница: " + Header["TipNaDokument"].ToString() + " Од објект: " + Header["ObjektOD"].ToString();
                    ID = Tools.KreirajDokument(BrojNaDokumentNareden, (DateTime)Header["Datum"], BssBase.tmpConfigs.TipNaDokumentIdPriem, Tools.PrazenStringToInt(Header["DoObjektID"].ToString()), Tools.PrazenStringToInt(Header["OdObjektID"].ToString()), Header["Zabeleska"].ToString() + zabeleskaDodatok, string.Empty, string.Empty, (DateTime)Header["Datum"], (DateTime)Header["Datum"]);
                }

                if (ID != -1)
                {
                    foreach (DataRow Details in ds.Tables["viewDokumentiStavki"].Rows)
                    {
                        Tools.InsertirajStavkaVoDokumenti(ID, Tools.PrazenStringToInt(Details["ArtikalID"].ToString()), Tools.PrazenStringToDecimal_dec(Details["Kolicina"].ToString()), Tools.PrazenStringToDecimal_dec(Details["Cena"].ToString()), Tools.PrazenStringToDecimal_dec(Details["Iznos"].ToString()), false, Tools.PrazenStringToDecimal_dec(Details["Rabat1"].ToString()));
                    }
                }

                using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                {
                    string sql = "AkcijaVrzDokument";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        con.Open();
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@DokumentID", ID);
                        com.Parameters.AddWithValue("@PratenOD", "primeno od");
                        com.Parameters.AddWithValue("@PratenDO", BssBase.settings.ImeNaMojServer);
                        com.Parameters.AddWithValue("@PratenPrimen", 0);
                        com.Parameters.AddWithValue("@TipNaDokumentStr", tipNaDokument);
                        com.Parameters.AddWithValue("@TipNaVnes", 1);
                        com.Parameters.AddWithValue("@DokumentValue", FileContents);

                        com.CommandType = CommandType.StoredProcedure;
                        com.ExecuteNonQuery();
                    }
                }
                dokumentID = ID;
                Tools.ProkniziDokument(ID);
                btnPecati.Enabled = true;
                btnPLT.Enabled = true;
                

                File.Delete(fileName);
                listView1.Items.Clear();
                if (Directory.Exists(Application.StartupPath + @"\ElektronskoPracanje\Primeni\"))
                {
                    var files = Directory.GetFiles(Application.StartupPath + @"\ElektronskoPracanje\Primeni\");
                    foreach (var item in files)
                    {
                        FileInfo f = new FileInfo(item);
                        listView1.Items.Add(f.Name);
                    }
                }
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    DialogResult opc;
                    opc = MessageBox.Show(Tools.PrevediPoraka("DaliSakateDagoIzbristeSelektiraniotDokument"), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opc == DialogResult.Yes)
                    {
                        File.Delete(fileName);
                        listView1.Items.Clear();
                        var files = Directory.GetFiles(Application.StartupPath + @"\ElektronskoPracanje\Primeni\");
                        foreach (var item in files)
                        {
                            FileInfo f = new FileInfo(item);
                            listView1.Items.Add(f.Name);
                        }
                    }
                }
            }
        }

        private void frmElektronskiPriemNaDokumenti_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\ElektronskoPracanje\serverNames.cfg"))
                cmbServer.LoadItemsFromFile(Application.StartupPath + @"\ElektronskoPracanje\serverNames.cfg");
        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1)
            {
                Functions.SrvFcuntions s = new Functions.SrvFcuntions();
                if (s.PratiKomanda(cmbServer.Text, 8100, "PobarajDokument:" + BssBase.tmpConfigs.VPNNameServer, "", DateTime.Now))
                {

                    if (Directory.Exists(Application.StartupPath + @"\ElektronskoPracanje\Primeni\"))
                    {

                        var files = Directory.GetFiles(Application.StartupPath + @"\ElektronskoPracanje\Primeni\");
                        foreach (var item in files)
                        {
                            FileInfo f = new FileInfo(item);
                            listView1.Items.Add(f.Name);
                        }
                    }
                }
            }
        }

        private void btnPLT_Click(object sender, EventArgs e)
        {
            using (MaterijalnoDataSet materijalnoDataSet = new MaterijalnoDataSet())
            {
            
            MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter = new MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter();
            MaterijalnoDataSetTableAdapters.PLTobrazecTableAdapter pLTobrazecTableAdapter = new MaterijalnoDataSetTableAdapters.PLTobrazecTableAdapter();


            pLTobrazecTableAdapter.FillByDokumentID(materijalnoDataSet.PLTobrazec, dokumentID);
            tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
            string partner = txtObjekt.Text;

            try
            {
                using (var smetka = new Reporti.PLTZaPriem())
                {
                    smetka.SetDataSource(materijalnoDataSet);
                    PrintPreview prev = new PrintPreview();
                    smetka.SetParameterValue("Partner", partner);
                    prev.ReportPreview.ReportSource = smetka;
                    prev.ShowDialog();
                    smetka.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }

        }
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            using (MaterijalnoDataSet materijalnoDataSet = new MaterijalnoDataSet())
            {


                
                MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter tblFirmaTableAdapter = new MaterijalnoDataSetTableAdapters.tblFirmaTableAdapter();
                MaterijalnoDataSetTableAdapters.viewDokumentiTableAdapter viewDokumentiTableAdapter = new MaterijalnoDataSetTableAdapters.viewDokumentiTableAdapter();
                MaterijalnoDataSetTableAdapters.viewDokumentiStavkiTableAdapter viewDokumentiStavkiTableAdapter = new MaterijalnoDataSetTableAdapters.viewDokumentiStavkiTableAdapter();


                tblFirmaTableAdapter.Fill(materijalnoDataSet.tblFirma);
                viewDokumentiTableAdapter.FillBy(materijalnoDataSet.viewDokumenti, dokumentID);
                viewDokumentiStavkiTableAdapter.FillBy(materijalnoDataSet.viewDokumentiStavki, dokumentID);


                try
                {
                    using (var report = new Reporti.Predatnica())
                    {

                        report.SetDataSource(materijalnoDataSet);

                        PrintPreview prev = new PrintPreview();
                        prev.ReportPreview.ReportSource = report;

                        prev.ShowDialog();
                        report.Dispose();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проблем со печатарот !!!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                }
            }
        }
    }
}
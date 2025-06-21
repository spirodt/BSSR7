using System;
using System.ComponentModel;
using System.Windows.Forms;
using BssBase;
using System.Data.SqlClient;
using System.Data;

namespace BSSR.Forms
{
    public partial class frmPrebaruvanjeNaArtikliDev : frmBigEdit
    {

        
        public frmPrebaruvanjeNaArtikliDev()
        {
            
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            
            
        }
        
        string normativ = string.Empty;
        string filterNormativ = string.Empty;
        public frmPrebaruvanjeNaArtikliDev(string filter)
        {
            
            InitializeComponent();
            btnOk.Visible = true;
            CancelButton = btnZatvori;
            AcceptButton = btnOk;
            
            comboBox1.SelectedIndex = Tools.PrazenStringToInt(settings.SearchIndex, 0);
            int a = Tools.PrazenStringToInt(settings.SearchWhereGroupIndex, 0);
            if(a == 1)
            {
                rBiloKde.Checked = true;
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (txtSearch.Text.Length > 1)
                {
                    string sqlCommand = "SELECT * FROM dbo.viewSveUEdno ";
                    string wherePart = string.Empty;
                    string searctxt = txtSearch.Text.Replace("*", "").Replace("'","''");

                    string strVoNapred = string.Empty;
                    string strVoNazad = string.Empty;
                    if (rPocnuva.Checked)
                    {
                        strVoNapred = "";
                        strVoNazad = "%";
                    }
                    if (rBiloKde.Checked)
                    {
                        strVoNapred = "%";
                        strVoNazad = "%";
                    }
                    //Сите колони
                    //Шифра
                    //Алтернативна Шифра
                    //Назив
                    //Група
                    //Подгрупа
                    //Комбинација

                    // viewSveUEdnoBindingSource.Filter = string.Empty;



                    switch (comboBox1.SelectedIndex)
                    {


                        case 0:
                            wherePart = String.Format(" KlucniZborovi LIKE N'{0}{1}{2}' OR KlucniZborovi LIKE N'{0}{3}{2}'", strVoNapred,  searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 1:
                            wherePart = String.Format(" Sifra LIKE N'{0}{1}{2}' OR Sifra LIKE N'{0}{3}{2}'", strVoNapred, searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 2:
                            wherePart = String.Format(" AltSifra LIKE N'{0}{1}{2}' OR AltSifra LIKE N'{0}{3}{2}'", strVoNapred, searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 3:
                            wherePart = String.Format(" Naziv LIKE N'{0}{1}{2}' OR  Naziv LIKE N'{0}{3}{2}'", strVoNapred, searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 4:
                            wherePart = String.Format(" GrupaNaziv LIKE N'{0}{1}{2}'  GrupaNaziv LIKE N'{0}{3}{2}'", strVoNapred, searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 5:
                            wherePart = String.Format(" PodGrupaNaziv LIKE N'{0}{1}{2}' OR  PodGrupaNaziv LIKE N'{0}{3}{2}'", strVoNapred, searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 6:
                            wherePart = String.Format(" SearchString LIKE N'{0}{1}{2}' OR  SearchString LIKE N'{0}{3}{2}'", strVoNapred, searctxt, strVoNazad, Tools.ConvertToKirilica(searctxt)) + normativ;
                            break;

                        case 7:
                            wherePart = String.Format(" SearchString LIKE N'%{0}%' OR  SearchString LIKE N'%{1}%'", searctxt, Tools.ConvertToKirilica(searctxt));
                            break;

                        case 8:
                            wherePart = String.Format(" Barkod LIKE '%{0}'", searctxt);
                            break;
                    }

                   ReloadData(sqlCommand, wherePart);
                }
                


                
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
            }
            
            txtSearch.ImaNestoSmeneto = false;
        }

        private void frmPrebaruvanjeNaArtikliDev_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnOk.PerformClick();
        }

        private void viewSveUEdnoGridBig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnOk.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (searchGrid.IsFirstRowSelected() && e.KeyCode == Keys.Up)
                {
                    txtSearch.Focus();
                    return;
                }
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.ImaNestoSmeneto = false;
                btnZatvori.PerformClick();
                return;
            }
            if (e.KeyCode == Keys.Back)
            {
                txtSearch.Focus();
                if (txtSearch.TextLength > 0)
                {
                    txtSearch.Text = string.Empty;
                }

            } else {
                
                    txtSearch.Focus();
               
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DtRow = searchView.GetFocusedDataRow();
            base.OnClosing(e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
               
                searchGrid.Focus();
                return;
            } 

            
        }

        public void ReloadData(string strSql, string wherePart = "")
        {
            
            using (var dbData = new DataTable()) {


                if (!string.IsNullOrEmpty(wherePart))
                    strSql = strSql + " Where " + wherePart;
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand(strSql, con))
                    {
                        con.Open();
                        dbData.Load(com.ExecuteReader());
                    }
                }
                searchGrid.DataSource = dbData;

            }
        }
        private void frmPrebaruvanjeNaArtikliDev_Load(object sender, EventArgs e)
        {
            ReloadData("SELECT TOP " + settings.TOPONARTIKLISEARCH + " * FROM dbo.viewSveUEdnoBeZalihaISamoArtikli order by 1", "");
        }

        private void btnZatvori_Click_1(object sender, EventArgs e)
        {
            txtSearch.ImaNestoSmeneto = false;
        }

        private void frmPrebaruvanjeNaArtikliDev_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtSearch.ImaNestoSmeneto = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Equals(ActiveMdiChild, null))
            {
                ActiveMdiChild.Close();
            }
            var GlavnaForma = new frmArtikli() { WindowState = FormWindowState.Normal };
            GlavnaForma.ShowDialog();
            ReloadData("SELECT * FROM dbo.viewSveUEdno", "");
        }

        private void viewSveUEdnoGridBig_DoubleClick(object sender, EventArgs e)
        {

            btnOk.PerformClick();
        }
    }
}
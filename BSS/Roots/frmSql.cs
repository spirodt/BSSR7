using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BssBase.Forms
{
    public partial class frmSql : frmEditTop
    {
        public frmSql()
        {
            InitializeComponent();
        }

        private void btnZatvori1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzvrsi_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(SQL.Text, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandType = CommandType.Text;
                        Bsslabel2.Text = com.ExecuteNonQuery().ToString();
                        con.Close();
                        MessageBox.Show(Tools.PrevediPoraka("UspesnoZavrseno"));
                        DialogResult = DialogResult.None;
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        Greski.Text = ex.Message + Environment.NewLine;
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.Message + Environment.NewLine);
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.Data + Environment.NewLine);
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.ErrorCode + Environment.NewLine);
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.Source + Environment.NewLine);
                        Greski.AppendText(ex.StackTrace + Environment.NewLine);
                    }
                }
            }
        }

        private void btnOtvori1_Click(object sender, EventArgs e)
        {
            settings.NeSortirajKoloni = true;
            using (var con = new SqlConnection(settings.konekcija))
            {
                using (var com = new SqlCommand(SQL.Text, con))
                {
                    try
                    {
                        con.Open();
                        com.CommandType = CommandType.Text;
                        var reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            Bsslabel2.Text = dt.Columns.Count + " \\ " + dt.Rows.Count.ToString();
                            var display = new frmShowTop();
                            var grid = new grdBase();
                            grid.AllowUserToOrderColumns = false;
                            grid.DataSource = dt;
                            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            grid.Dock = DockStyle.Fill;
                            display.Controls.Add(grid);
                            display.ShowDialog();
                            settings.NeSortirajKoloni = false;
                        }

                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Tools.PrevediSQLException(ex);
                        Greski.Text = ex.Message + Environment.NewLine;
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.Message + Environment.NewLine);
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.Data + Environment.NewLine);
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.ErrorCode + Environment.NewLine);
                        Greski.AppendText(Environment.NewLine);
                        Greski.AppendText(ex.Source + Environment.NewLine);
                        Greski.AppendText(ex.StackTrace + Environment.NewLine);
                    }
                }
            }
        }

        private void Greski_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Greski.Copy();
            }
        }

        private void SQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                SQL.Copy();
            }

            if (e.KeyCode == Keys.F6)
            {
                btnIzvrsi.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                btnOtvori1.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnZatvori1.PerformClick();
            }
        }
    }
}
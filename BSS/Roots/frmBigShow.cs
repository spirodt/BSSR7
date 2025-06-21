using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BssBase
{
    public partial class frmBigShow : frmShowTop
    {
        public int currentRow, currentColumn = -1;
        public bool PrifatiKlik = false;
        public bool zoom = false;

       
        public String GlavenFilter { set; get; }

        public string MainConnection { set; get; }

        public DataGridViewRow dr;

        public string SelectSql { set; get; }

        [DefaultValue("t")]
        public string Transakcija { set; get; }

        public string UpdateTable { set; get; }

        public frmBigShow()
        {
            InitializeComponent();
        }

        public void IzbrisiGreskaDole()
        {
            errorProviderDole.SetError(DisplayError, string.Empty);
            DisplayError.Text = string.Empty;
            DisplayError.Visible = false;
        }

        public void PrikaziGreskaDole(string Text)
        {
            errorProviderDole.SetIconAlignment(DisplayError, ErrorIconAlignment.TopLeft);
            errorProviderDole.SetError(DisplayError, Text);
            DisplayError.Visible = true;
            DisplayError.Text = Text;
        }

        public void SrediIminjaNaGrid()
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                if (grid.Rows.Count > 0)
                {
                    foreach (DataGridViewCell cell in grid.Rows[0].Cells)
                    {
                        var ColumnName = cell.OwningColumn.DataPropertyName.ToUpper();
                        cell.OwningColumn.Name = ColumnName;
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                grid.Select();
                grid.Focus();
            }
        }

        public frmBigShow(bool zoom)
        {
            InitializeComponent();
            btnOk.Visible = true;
            zoom = true;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void NovZapis(object sender, EventArgs e)
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                grid.Insert();
            }
        }

        public virtual void IzmeniZapis(object sender, EventArgs e)
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                grid.Edit();
            }
        }

        public virtual void Blokiraj(object sender, EventArgs e)
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                if (string.IsNullOrEmpty(grid.SQLCommandQuery))
                {
                    grid.blokiraj();
                }
                else
                {
                    using (var con = new SqlConnection(settings.konekcija))
                    {
                        using (var com = new SqlCommand("Update " + grid.UpdateTable + " set Status=1 WHERE ID=" + grid.SelectedIdFromTable(), con))
                        {
                            try
                            {
                                con.Open();
                                com.ExecuteNonQuery();
                                con.Close();
                                grid.NapolniGrid();
                            }
                            catch (SqlException Ex)
                            {
                                Tools.PrevediSQLException(Ex);
                                return;
                            }
                        }
                    }
                }
            }
        }

        public bool proveriPrivilegija(String Transakcija)
        {
            if (Transakcija.Contains("t"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FormaSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNovZapis.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnEditirajZapis.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                if (btnBlokiraj.Visible)
                {
                    btnBlokiraj.PerformClick();
                }
            }

            if (e.KeyCode == Keys.F6)
            {
                if (btnIzbrisi.Visible)
                {
                    btnIzbrisi.PerformClick();
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                btnFilter.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnZatvori.PerformClick();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PrifatiKlik = true;
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                if (grid.CurrentRow != null)
                {
                    dr = grid.CurrentRow;
                    if (zoom == true)
                    {
                        Close();
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            search();
            //foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            //{
            //    ((BindingSource)grid.BindingSource()).Filter = grid.Filter();
            //}
        }

        public virtual void search(string filterOdPovik = "")
        {
            var filter = filterOdPovik;
            
            

            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                ((BindingSource)grid.BindingSource()).Filter = string.Empty;
                grid.Osvezi();
                if (grid.Rows.Count > 0)
                {
                    foreach (DataGridViewCell cell in grid.Rows[0].Cells)
                    {
                        var ColumnName = cell.OwningColumn.DataPropertyName.ToUpper();
                        if (cell.Visible == true && !ColumnName.Contains("Id".ToUpper()) && !ColumnName.Contains("Status".ToUpper()) && cell.OwningColumn.CellType.Name == "DataGridViewTextBoxCell")
                        {
                            if (cell.ValueType.ToString() == "System.String")
                            {
                                filter += ColumnName + " LIKE '*" + txtBaraj.Text + "*' OR " + ColumnName + " LIKE '*" + Tools.ConvertToKirilica(txtBaraj.Text) + "*' OR ";
                            }
                            else
                            {
                                if (cell.ValueType.ToString() == "System.Int32")
                                {
                                    var number = txtBaraj.Text.Replace("*", string.Empty);
                                    int broj;
                                    var res = int.TryParse(number, out broj);
                                    if (res == true)
                                    {
                                        filter += ColumnName + " = '" + broj.ToString() + "' OR ";
                                    }
                                }
                            }
                        }
                    }
                }
                if (filter.Length > 3)
                {
                    filter = filter.Remove(filter.Length - 3, 3);
                }
                if (txtBaraj.Text.Length > 0 && filter != string.Empty)
                {
                    try
                    {
                        ((BindingSource)grid.BindingSource()).Filter = filter;
                    }
                    catch (Exception ex)
                    {
                        
                        Tools.LogWriteText("FUNCKCIJA search_mdbrowse()");
                        Tools.LogWriteText(ex.Message);
                        MessageBox.Show(Tools.PrevediPoraka("nepralvilenFilter"), Tools.PrevediPoraka("Greska!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPrebaraj_Click(object sender, EventArgs e)
        {
            search();
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                Navigator.BindingSource = ((BindingSource)grid.BindingSource());
                grid.TabStop = false;
            }
        }

        private void btnIcistiBaraj_Click(object sender, EventArgs e)
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                if (!Equals(grid.BindingSource(), null))
                {
                    ((BindingSource)grid.BindingSource()).Filter = string.Empty;
                    txtBaraj.Text = string.Empty;
                    grid.Osvezi();
                }
                if (!string.IsNullOrEmpty(grid.SQLCommandQuery))
                {
                    grid.NapolniGrid();
                }
            }
            txtBaraj.Focus();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
            {
                try
                {
                    grid.izbrisi();
                }
                catch (SqlException ex)
                {
                    Tools.PrevediSQLException(ex);
                }
            }
        }

        private void DisplayError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IzbrisiGreskaDole();
        }

        private void frmBigShow_Shown(object sender, EventArgs e)
        {
            txtBaraj.Focus();
        }

        private void txtBaraj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrebaraj.PerformClick();
                e.Handled = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                foreach (grdBase grid in MainPanel.Controls.OfType<grdBase>())
                {
                    grid.Focus();
                }
            }
        }
    }
}
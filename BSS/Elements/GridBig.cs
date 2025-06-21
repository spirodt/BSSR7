using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BssBase
{
    public class GridBig : grdBase
    {
        protected override void OnCreateControl()
        {
            BssBase.settings.ExportToExcell = true;
            base.MultiSelect = false;
            base.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            base.RowTemplate.Height = 36;
            PrimaryKey = "ID";
            base.OnCreateControl();
        }

        public delegate void SaveInsertData(DataTable db);

        public delegate Panel onInsertDataFromGridShown(FlowLayoutPanel DataPanel);

        public event SaveInsertData SaveInsertDataFromGrid;

        public event onInsertDataFromGridShown OnInsertDataShown;

        [EditorBrowsable(EditorBrowsableState.Always),
        Localizable(true),
        DefaultValue(false)]
        public bool PrikaziKoloniZaVnes { set; get; }

        private FlowLayoutPanel p;

        public StringBuilder ExportToCSV()
        {
            var sb = new StringBuilder();

            var headers = this.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + Tools.ConvertToLatinica(column.HeaderText) + "\"").ToArray()));

            foreach (DataGridViewRow row in this.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            return sb;
        }

        public void PonistiVnes()
        {
            if (this.Parent.Controls.OfType<FlowLayoutPanel>().Contains(p))
            {
                this.Size = new System.Drawing.Size(this.Width, this.Height + p.Height);
                //p.Visible = false;
                p.Hide();
            }
        }

        private int MaxColona;

        public String[] ReadOnlyColumns { set; get; }

        public String[] HidenColumns { set; get; }

        public bool KreirajPredefiniraniPolinja { set; get; }

        public void NovVnes()
        {
            if (Equals(null, p))
            {
                p = new FlowLayoutPanel();
                p.Font = new Font(Font.FontFamily, Tools.PrazenStringToInt(BssBase.settings.fontZaVnesKasa, 13));
                p.FlowDirection = FlowDirection.LeftToRight;
                p.WrapContents = true;
                p.Name = "PnAme";
                p.BackColor = Color.DarkBlue;
                p.Size = new System.Drawing.Size(this.Width, base.RowTemplate.Height + 50);
                this.Size = new System.Drawing.Size(this.Width, this.Height - p.Height);
                p.Dock = DockStyle.Bottom;
                p.Leave += p_Leave;
                if (KreirajPredefiniraniPolinja)
                {
                    for (int i = 0; i < this.Columns.Count; i++)
                    {
                        txtBase KolonaEdit = new txtBase();
                        KolonaEdit.Name = this.Columns[i].DataPropertyName;
                        KolonaEdit.Tag = i.ToString();
                        KolonaEdit.iscistiGreenNaLeave = true;

                        if (this.Columns[i].Displayed == true)
                        {
                            if (!Equals(null, HidenColumns))
                            {
                                if (HidenColumns.Contains(KolonaEdit.Name))
                                {
                                    KolonaEdit.Visible = false;
                                }
                            }

                            if (!Equals(null, ReadOnlyColumns))
                            {
                                if (ReadOnlyColumns.Contains(KolonaEdit.Name))
                                {
                                    KolonaEdit.Enabled = true;
                                    KolonaEdit.ReadOnly = true;
                                }
                            }
                            p.AutoSize = true;
                            if (i == 0)
                            {
                                KolonaEdit.Size = new Size(this.Columns[i].Width + 10, base.RowTemplate.Height + 50);
                            }
                            else
                                KolonaEdit.Size = new Size(this.Columns[i].Width, base.RowTemplate.Height + 50);

                            bool isNumeric = ((this.Columns[i].ValueType == typeof(System.Int32)) || (this.Columns[i].ValueType == typeof(System.Decimal)));
                            KolonaEdit.C_OnlyNumbers = isNumeric;
                            KolonaEdit.C_Decimal = isNumeric;
                            if (isNumeric)
                            {
                                KolonaEdit.TextAlign = HorizontalAlignment.Right;
                                KolonaEdit.Text = 0.ToString("N2");
                                KolonaEdit.Format = "N2";
                                KolonaEdit.Leave += KolonaEdit_Leave;
                            }
                            KolonaEdit.Font = new Font(Font.FontFamily, Tools.PrazenStringToInt(BssBase.settings.fontZaVnesKasa, 13));
                            KolonaEdit.KeyDown += KolonaEdit_KeyDown;
                            p.Controls.Add(KolonaEdit);
                            p.Visible = true;
                            MaxColona = i;
                        }
                    }
                }

                if (!Equals(null, OnInsertDataShown))
                {
                    var PanelFromEvent = this.OnInsertDataShown.Invoke(p);
                    this.Parent.Controls.Add(PanelFromEvent);
                }
            }
            else
            {
                //p.Visible = true;
                p.Show();
                foreach (var item in p.Controls.OfType<txtBase>())
                {
                    item.Text = string.Empty;
                }
            }
            p.VisibleChanged += p_VisibleChanged;
            p.Controls.OfType<txtBase>().FirstOrDefault().Focus();
        }

        private void KolonaEdit_Leave(object sender, EventArgs e)
        {
            var kolona = sender as txtBase;
            kolona.Text = kolona.formatTextDecimal();
        }

        private void p_VisibleChanged(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel.Visible)
            {
                foreach (txtBase item in panel.Controls.OfType<txtBase>())
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void p_Leave(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel.Visible == true)
            {
                bool cancel = false;
                foreach (txtBase item in panel.Controls.OfType<txtBase>())
                {
                    if (item.IsTextEmpty())
                    {
                        cancel = true;
                    }
                }
                if (cancel == true)
                {
                    panel.Focus();
                }
                else
                {
                    SocuvajStavka();
                }
            }
        }

        private DataTable data;

        public void SocuvajStavka()
        {
            if (!this.Parent.Controls.ContainsKey("PnAme"))
            {
                return;
            }

            if (this.Parent.Controls.OfType<FlowLayoutPanel>().First().Visible == false)
            {
                return;
            }
            data = new DataTable();
            foreach (txtBase item in this.Parent.Controls.OfType<FlowLayoutPanel>().First().Controls.OfType<txtBase>())
            {
                data.Columns.Add(item.Name);
            }

            DataRow d = data.NewRow();
            foreach (txtBase item in this.Parent.Controls.OfType<FlowLayoutPanel>().First().Controls.OfType<txtBase>())
            {
                d[item.Name] = item.Text;
            }

            data.Rows.Add(d);
            if (!Equals(null, SaveInsertDataFromGrid))
            {
                try
                {
                    SaveInsertDataFromGrid.Invoke(data);
                    //this.gotoLastRow();
                }
                catch (Exception ex)
                {
                    Tools.PrevediSQLException(ex);
                }
            }
        }

        private void KolonaEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (Tools.PrazenStringToInt(((txtBase)sender).Tag.ToString().Trim(), -1) != Tools.PrazenStringToInt(MaxColona.ToString().Trim(), -1))
                {
                    ((txtBase)sender).BackColor = Color.Empty;
                    this.Parent.Focus();
                }
            }
            if (e.KeyCode == Keys.Tab)
            {
                this.Parent.Controls.OfType<FlowLayoutPanel>().First().SelectNextControl(((txtBase)sender), true, true, false, true);
            }
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BssBase
{
    public  class cmbBase : ComboBox
    {
        public bool IsTextEmpty()
        {
            return string.IsNullOrEmpty(Text);
        }

        public bool C_OnlyNumbers { get; set; }

        public bool C_ShowRedOnLeaveIfEmpty { get; set; }

        public string value { set; get; }

        public string CurrentText { set; get; }

        private DataTable ItemsValues;

        public string DtTableName { set; get; }

        public void SelectirajItem(int ID)
        {
            if (ItemsValues?.Select("ID = " + ID).Length > 0)
            {
                var item = ItemsValues.Select("ID = " + ID).CopyToDataTable().Rows[0]["Vrednost"];
                if (!Equals(item, null))
                {
                    SelectedIndex = FindStringExact(item.ToString());
                }
            }
        }

        public void LoadItems(DataTable dtItems)
        {
            foreach (DataRow item in dtItems.Rows)
            {
                Items.Insert(Convert.ToInt32(item[0].ToString()), item[1].ToString());
            }
            DtTableName = dtItems.TableName;
            ItemsValues = dtItems;
        }

        public void LoadItemsFromFile(string fileName)
        {
            Items.Clear();
            string[] lineOfContents = File.ReadAllLines(fileName, System.Text.Encoding.ASCII);
            foreach (var line in lineOfContents)
            {
                Items.Add(line);
            }
            if (Items.Count > 0)
                SelectedIndex = 0;
        }

        public void LoadItems(string SelectStatment)
        {
            var dtItems = new DataTable();
            DataSource = null;
            Items.Clear();
           
            try
            {
                using (SqlConnection con = new SqlConnection(settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand(SelectStatment, con))
                    {
                        con.Open();
                        dtItems.Load(com.ExecuteReader());
                        con.Close();
                        dtItems.Columns[0].ColumnName = "ID";
                        dtItems.Columns[1].ColumnName = "Vrednost";

                        DataSource = dtItems;
                        DisplayMember = "Vrednost";
                        ValueMember = "ID";
                        ItemsValues = dtItems;
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.PrevediSQLException(ex);
            }
        }
        
    }
}
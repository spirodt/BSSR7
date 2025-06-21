using System;
using System.Windows.Forms;
using BssBase;
using System.Data;
using System.IO;

namespace BSSR.Forms
{
    public partial class frmConfig : Form
    {
        Utility.ModifyRegistry.ModifyRegistry RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
        DataSet dataSet = new DataSet();
        public frmConfig()
        {
           
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            RegistryData.SubKey = settings.RegPath;
            dataSet.Tables.Add(dbFunctions.ConfigsToDatabase());
            gridConfig.DataSource = dataSet.Tables[0];

            BssBase.Elements.btnPotvrdi socuvaj = new BssBase.Elements.btnPotvrdi();
            socuvaj.Text = "Сочувај";
            socuvaj.Click += new EventHandler(socuvaj_Click);
            socuvaj.Dock = DockStyle.Bottom;
            Controls.Add(socuvaj);
        }
        
      

        private void socuvaj_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                RegistryData.Write(row["Setting"].ToString(), row["Value"].ToString());
            }
            
            dbFunctions.DropAndRecreateConfigs(dataSet.Tables[0]);
            settings.InitSettings.ReloadAllConfigs();
            this.Close();
          
        }
    }
}
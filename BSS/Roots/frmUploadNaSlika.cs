using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BssBase
{
    public partial class frmUploadNaSlika : Form
    {
        public string Id;

        [EditorBrowsable(EditorBrowsableState.Always),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Bindable(true)]
        public string PrimaryKey { set; get; }

        [EditorBrowsable(EditorBrowsableState.Always),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Bindable(true)]
        public string UpdateTable { set; get; }

        public frmUploadNaSlika()
        {
            InitializeComponent();
            Poleslika.SelectedIndex = 0;
        }

        public frmUploadNaSlika(List<string> Lista)
        {
            InitializeComponent();
            Poleslika.SelectedIndex = -1;
            Poleslika.Text = string.Empty;
            Poleslika.Items.Clear();

            foreach (string item in Lista)
            {
                Poleslika.Items.Add(item);
            }
            Poleslika.SelectedIndex = 0;
        }

        public bool samoSoPateka = false;
        public string patekaDo = string.Empty;

        public frmUploadNaSlika(List<string> Lista, bool SoPateka)
        {
            InitializeComponent();
            Poleslika.SelectedIndex = -1;
            Poleslika.Text = string.Empty;
            Poleslika.Items.Clear();
            samoSoPateka = SoPateka;
            foreach (string item in Lista)
            {
                Poleslika.Items.Add(item);
            }
            Poleslika.SelectedIndex = 0;
        }

        private void btnExi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uploadFileToDatabase(byte[] picture, string fileName, string commandText)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlParameter pic = null;

            try
            {
                conn = new SqlConnection(settings.konekcija);
                cmd = new SqlCommand(commandText, conn);

                cmd.CommandType = CommandType.Text;
                pic = new SqlParameter("@Image", SqlDbType.Image);
                pic.Value = picture;

                cmd.Parameters.Add(pic);

                conn.Open();
                MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                conn.Close();

                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(Tools.PrevediPoraka(e.Message));
            }
        }

        public void UploadFile(string FileName)
        {
            if (!File.Exists(FileName))
            {
                MessageBox.Show(Tools.PrevediPoraka("FajlotNePostoi"), Tools.PrevediPoraka("Greska!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileStream fs = null;
            try
            {
                fs = new FileStream(FileName, FileMode.Open);

                var fi = new FileInfo(FileName);
                var temp = fi.Length;
                var lung = Convert.ToInt32(temp);
                Progress.Maximum = lung;
                var picture = new byte[lung];
                fs.Read(picture, 0, lung);
                fs.Close();

                var UploadCommand = "Update " + UpdateTable + " Set [" + Poleslika.Text + "] = @Image WHERE " + PrimaryKey + "=" + Id;
                uploadFileToDatabase(picture, Pateka.Text, UploadCommand);

                Progress.Value = 0;
                for (var i = 0; i < lung; i++)
                {
                    Progress.Value += 1;
                }
            }
            catch (Exception e)
            {
                Tools.LogWriteText(e.Message + " - " + e.StackTrace);
                MessageBox.Show(e.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (Poleslika.SelectedIndex != -1)
            {
                var dlgOpen = new OpenFileDialog();
                dlgOpen.Title = "Отвори слика";
                dlgOpen.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                dlgOpen.InitialDirectory = BssBase.settings.ImagesPath.Split(';').FirstOrDefault();
                dlgOpen.ShowDialog();
                if (dlgOpen.FileName != string.Empty)
                {
                    Pateka.Text = dlgOpen.FileName;
                    if (!Pateka.IsTextEmpty())
                    {
                        if (samoSoPateka)
                        {
                            patekaDo = Pateka.Text;
                            Close();
                        }
                        else
                        {
                            UploadFile(dlgOpen.FileName);
                        }

                        while (Progress.Value != Progress.Maximum)
                        {
                            Progress.Value += 1;
                        }
                    }
                }
            }
        }
    }
}
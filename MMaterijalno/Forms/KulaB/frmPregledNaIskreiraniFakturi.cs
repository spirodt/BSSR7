using DevExpress.Office.DigitalSignatures;
using DevExpress.Pdf;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit.Model;

using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MMaterijalno.Forms.KulaB
{
    public partial class frmPotpisiIPrati : Form
    {
        public string MailTextResult;
        private DateTime datumOd;
        private DateTime datumDo;

        public frmPotpisiIPrati()
        {
            InitializeComponent();
            tabControlBase1.TabPages.Remove(tabPage1);
            tabControlBase1.TabPages.Remove(tabPage3);
        }

        public frmPotpisiIPrati(string textEditor)
        {
            InitializeComponent();
            tabControlBase1.TabPages.Remove(tabPage1);
            tabControlBase1.TabPages.Remove(tabPage2);
            MailTextResult = textEditor;
            richEditControl1.Text = MailTextResult;
        }

        public string MailText;
        public string NazivNaFirma;
        public frmPotpisiIPrati(DateTime value1, DateTime value2)
        {
            InitializeComponent();
            tabControlBase1.TabPages.Remove(tabPage2);
            btnProcesiraj.BackColor = Color.AliceBlue;
            itemsToProcess.BackColor = Color.AliceBlue;
            progressBar1.BackColor = Color.AliceBlue;

            lblSelektirano.Text = "Тековно одржување";
            var info = Tools.NajdiInfoZaFirma(1);
            NazivNaFirma = info.Table.Rows[0]["ImeNaFirma"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Adresa"].ToString()
                + Environment.NewLine + info.Table.Rows[0]["Grad"].ToString();

            this.datumOd = value1;
            this.datumDo = value2;

            for (int i = 0; i < sprat.Items.Count; i++)
            {
                sprat.SetItemChecked(i, true);
            }

            MailText = $@"
                    Почитувани, 

                    Во прилог ви ја испраќаме фактурата за  тековно одржување.
                   
                    Со почит,{Environment.NewLine} {NazivNaFirma}";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            itemsToProcess.Items.Clear();
            if (mail.Checked)
            {
                NapolniMail();
            }
            else
            {
                NapolniPecati();
            }
        }

        private void NapolniPecatiSe()
        {
            string selektiranMesec = mesec.SelectionStart.Month.ToString();

            foreach (var selektiranItem in sprat.CheckedItems)
            {
                String path = string.Empty;
                if (btnTekovno.Checked)
                {
                    path = $@"{BssBase.settings.PrintFolder}\{mesec.SelectionStart.Year}\1\{selektiranMesec}\{selektiranItem.ToString().Substring(0, 2)}";
                }
                else
                {
                    path = $@"{BssBase.settings.PrintFolder}\{mesec.SelectionStart.Year}\2\{selektiranMesec}\{selektiranItem.ToString().Substring(0, 2)}";
                }
                if (Directory.Exists(path))
                {
                    var files = Directory.GetFiles(path, "*.pdf");
                    foreach (var file in files)
                    {
                        itemsToProcess.Items.Add(file);
                    }

                }
            }
        }


        private void NapolniPecati()
        {
            string selektiranMesec = mesec.SelectionStart.Month.ToString();

            foreach (var selektiranItem in sprat.CheckedItems)
            {
                String path = string.Empty;
                if (btnTekovno.Checked)
                {
                    path = $@"{BssBase.settings.PrintFolder}\{mesec.SelectionStart.Year}\1\{selektiranMesec}\{selektiranItem.ToString().Substring(0, 2)}";
                }
                else
                {
                    path = $@"{BssBase.settings.PrintFolder}\{mesec.SelectionStart.Year}\2\{selektiranMesec}\{selektiranItem.ToString().Substring(0, 2)}";
                }
                if (Directory.Exists(path))
                {
                    var files = Directory.GetFiles(path, "*.pdf").Where(
                        x => x.ToString().Contains("_Pecateno"));
                    foreach (var file in files)
                    {
                        itemsToProcess.Items.Add(file);
                    }

                }
            }
        }

        private void NapolniMail()
        {
            string selektiranMesec = mesec.SelectionStart.Month.ToString();

            foreach (var selektiranItem in sprat.CheckedItems)
            {
                string path = string.Empty;
                if (btnTekovno.Checked)
                {
                    path = $@"{BssBase.settings.PrintFolder}\{mesec.SelectionStart.Year}\1\{selektiranMesec}\{selektiranItem.ToString().Substring(0, 2)}";
                }
                else
                {
                    path = $@"{BssBase.settings.PrintFolder}\{mesec.SelectionStart.Year}\2\{selektiranMesec}\{selektiranItem.ToString().Substring(0, 2)}";
                }
                if (Directory.Exists(path))
                {
                    var files = Directory.GetFiles(path, "*.pdf").Where(x => x.ToString().Contains("Mail"));
                    foreach (var file in files)
                    {
                        itemsToProcess.Items.Add(file);
                    }

                }
            }
        }

        private void btnprocesiraj(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = itemsToProcess.CheckedItems.Count;

            if (btnTekovno.Checked)
            {
                MailText = $@"
                    Почитувани, 

                    Во прилог ви ја испраќаме фактурата за  тековно одржување.
                   
                    Со почит,{Environment.NewLine} {NazivNaFirma}";
            }
            else
            {
                MailText = $@"
                    Почитувани, 

                    Во прилог ви ја испраќаме фактурата за  HVAC.
                   
                    Со почит,{Environment.NewLine} {NazivNaFirma}";
            }
            int delay = BssBase.settings.testDelay.toInt();
            for (int i = 0; i < itemsToProcess.CheckedItems.Count; i++)
            {
                if (mail.Checked)
                {
                    string file = itemsToProcess.CheckedItems[i].ToString();
                    Tools.WriteLog($"Email Sent:{file}");
                    FileInfo f = new FileInfo(file);
                    if (File.Exists(file))
                    {
                        string partner = f.Name.Substring(0, 6);
                        var partnerInfo = Tools.NajdiInfoZaSifraPartner(partner);
                        if (!string.IsNullOrEmpty(partnerInfo["Email"].ToString()))
                        {
                            string subject;
                            if (btnTekovno.Checked)
                            {
                                subject = $"Фактура за одржување - {f.Name.Replace(partner + "_", "").Replace("__PecatenoHartijaIpratenoNaMail", "").Replace("__SamoMail", "").Replace(".pdf", "")}";
                            }
                            else
                            {
                                subject = $"Фактура за Hvac - {f.Name.Replace(partner + "_", "").Replace("__PecatenoHartijaIpratenoNaMail", "").Replace("__SamoMail", "").Replace(".pdf", "")}";
                            }
                            var emailList = string.Join(",", partnerInfo["Email"].ToString().Split(';'));
                            bool result = Tools.SendMailDefault(file, subject, MailText, false, Mailto: emailList);

                            Tools.LogWriteText($"{result} isprateno {partner} {file} {emailList} ");

                        }
                    }
                    else
                    {
                        Tools.LogWriteText($"Ne uspesno prakjanje na mail , ne postoi fajlot {file}");
                    }
                }
                else
                {
                    string file = itemsToProcess.CheckedItems[i].ToString();
                    Tools.WriteLog($"print Sent:{file}");
                    Thread.Sleep(delay);
                    Process proc = new Process();
                    proc.StartInfo = new ProcessStartInfo()
                    {
                        CreateNoWindow = true,
                        Verb = "print",
                        FileName = file
                    };
                    proc.Start();
                }
                progressBar1.Value += 1;
            }
            itemsToProcess.Items.Clear();
            MessageBox.Show("Операцијата заврши");
            progressBar1.Value = 0;
        }


        private void btnSelektirajSe(object sender, EventArgs e)
        {

            for (int i = 0; i < itemsToProcess.Items.Count; i++)
            {
                itemsToProcess.SetItemChecked(i, true);
            }
            BrojnaSelektirani.Text = itemsToProcess.CheckedItems.Count.ToString();
        }

        private void btnIzbrisiSe_Click(object sender, EventArgs e)
        {
            itemsToProcess.Items.Clear();
            BrojnaSelektirani.Text = itemsToProcess.CheckedItems.Count.ToString();
        }

        private void itemsToProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrojnaSelektirani.Text = itemsToProcess.CheckedItems.Count.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < sprat.Items.Count; i++)
            {
                sprat.SetItemChecked(i, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sprat.Items.Count; i++)
            {
                sprat.SetItemChecked(i, false);
            }
        }

        private void mail_Click(object sender, EventArgs e)
        {
            btnProcesiraj.BackColor = Color.AliceBlue;
            progressBar1.BackColor = Color.AliceBlue;
            itemsToProcess.BackColor = Color.AliceBlue;
            itemsToProcess.Items.Clear();
        }

        private void print_Click(object sender, EventArgs e)
        {
            btnProcesiraj.BackColor = Color.Yellow;
            progressBar1.BackColor = Color.Yellow;
            itemsToProcess.BackColor = Color.Yellow;
            itemsToProcess.Items.Clear();
        }

        private void btnTekovno_Click(object sender, EventArgs e)
        {
            lblSelektirano.Text = "Тековно одржување";
            itemsToProcess.Items.Clear();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            lblSelektirano.Text = "HVAC";
            itemsToProcess.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemsToProcess.Items.Clear();
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            if (dlg.SelectedPath != null)
            {
                BssBase.settings.PrintFolder = dlg.SelectedPath;
                toolStripStatusLabel1.Text = BssBase.settings.PrintFolder;
                toolStripStatusLabel1.BackColor = Color.Red;
                btnPrikaziSe.PerformClick();
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            itemsToProcess.Items.Clear();
            btnProcesiraj.BackColor = Color.PaleVioletRed;
            progressBar1.BackColor = Color.PaleVioletRed;
            itemsToProcess.BackColor = Color.PaleVioletRed;
            NapolniPecatiSe();
        }

        private void frmPregledNaIskreiraniFakturi_Load(object sender, EventArgs e)
        {
           
            toolStripStatusLabel1.Text = BssBase.settings.PrintFolder;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            progressBar1.Value = 0;
            progressBar1.Maximum = itemsToProcess.CheckedItems.Count;
            int delay = BssBase.settings.testDelay.toInt();
            
            for (int i = 0; i < itemsToProcess.CheckedItems.Count; i++)
            {
                string file = itemsToProcess.CheckedItems[i].ToString();
                string fileToSave = file.Replace(".pdf", "_signed.pdf");
                bool signSucces =  SignDocument(file, fileToSave);
                if (signSucces)
                {
                    File.Delete(file);
                }
                progressBar1.Value += 1;
            }
            Cursor.Current = Cursors.Default;
        }

        private void itemsToProcess_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string file = itemsToProcess.SelectedItem.ToString();
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = file
            };
            proc.Start();
        }

        private static bool SignDocument(string file, string fileToSave)
        {
            try
            {
                // Create a signature field on the first page:
                var signatureFieldInfo = new PdfSignatureFieldInfo(1);

                // Specify the field's name, location and rotation angle:
                signatureFieldInfo.Name = "SignatureField";

                signatureFieldInfo.SignatureBounds = new PdfRectangle(400, 260, 550, 300);

                // Load a document to sign:
                using (var signer = new PdfDocumentSigner(file))
                {
                    // Create a PKCS#7 signature:
                    Pkcs7Signer pkcs7Signature = new Pkcs7Signer($@"{BssBase.settings.PrintFolder}\Cert.pfx", BssBase.settings.BSSMailPass.toNormalString(),
                        DevExpress.Office.DigitalSignatures.HashAlgorithmType.SHA256);

                    // Retrieve all signed form fields:


                    // Apply a new signature to this form field:
                    var santuzzaSignature = new PdfSignatureBuilder(pkcs7Signature, signatureFieldInfo);

                    // Specify image and signer information:
                    //santuzzaSignature.SetImageData(File.ReadAllBytes(@"C:\BSSR_LOGS\SantuzzaValentina.jpg"));
                    // santuzzaSignature.Name = "ZS na stanbena zgrada na ul. Mateja Matevski br.22 - Skopje";
                    santuzzaSignature.SigningTime = DateTime.Now;

                    santuzzaSignature.CertificationLevel = PdfCertificationLevel.NoChangesAllowed;
                    // Specify signature appearance parameters:
                    PdfSignatureAppearance signatureAppearance = new PdfSignatureAppearance();

                    // Add a signature image:
                    //signatureAppearance.SetImageData("Signing Documents/logo.png");

                    // Specify what information to display:
                    signatureAppearance.ShowDate = true;
                    // Set display format for date and time:
                    signatureAppearance.DateTimeFormat = "dd.MM.yyyy";


                    // Change font settings for signature details:
                    signatureAppearance.SignatureDetailsFont.Size = 8;
                    signatureAppearance.SignatureNameFont.Size = 8;
                    signatureAppearance.SignatureDetailsFont.Italic = false;

                    // Apply changes:
                    santuzzaSignature.SetSignatureAppearance(signatureAppearance);

                    // Sign and save the document:
                    signer.SaveDocument(fileToSave, santuzzaSignature);
                    Tools.WriteLog("Potpisan: " + file, 1);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void tabControlBase1_Enter(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BSSR_2_0DataSet.tblPartneri' table. You can move, or remove it, as needed.
            this.tblPartneriTableAdapter.FillByTowerB(this._BSSR_2_0DataSet.tblPartneri);
            
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            this.btnSendMailDoPartneri.DialogResult = DialogResult.None;
            btnZatvori1.DialogResult = DialogResult.None;
            gridView1.ResetAutoFilterConditions();
            gridView1.ClearColumnsFilter();



        }

        private string GetCurentValueForColumnName(int rowHandle , string column)
        {
            // Get the value for the given column - convert to the type you're expecting
            var obj = this.gridView1.GetRowCellValue(rowHandle, column);
            if (obj != null)
            {
                var value = obj.ToString();
                return value;

            }
            return string.Empty;
        }


        private void btnSendMailDoPartneri_Click(object sender, EventArgs e)
        {
            this.btnSendMailDoPartneri.DialogResult = DialogResult.None;
            btnZatvori1.DialogResult = DialogResult.None;
            string subject = txtSubjet.Text;
            string text = mailRtf.HtmlText;
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int rowHandle = gridView1.GetSelectedRows()[i];
                var row = gridView1.GetDataRow(rowHandle);
                var emailList = GetCurentValueForColumnName(rowHandle, "Email").Split(';');
                
                var  result = Tools.SendMailDefaultHtml(true, string.Empty, subject, text, false,Mailfrom: BssBase.settings.BSSMailFrom.toNormalString(), Mailto: string.Join(",", emailList));
                if(result)
                {
                    row["Status"] = 5;
                    gridView1.SetRowCellValue(rowHandle, "Status", 5);

                } else
                {
                    row["Status"] = 6;
                    gridView1.SetRowCellValue(rowHandle, "Status", 6);
                }
            }
            
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = devGrid1;
            link.Landscape = true;
            gridView1.ActiveFilterString = "Status = 5 OR Status = 6";
            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format(" Листа со испратени е-маил пораки  ");
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();

   
            link.ShowPreview();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            var phf = link.PageHeaderFooter as PageHeaderFooter;
            link.Component = devGrid1;
            link.Landscape = true;
            phf.Header.Content.Clear();
            const string leftColumn = "Pages: [Page # of Pages #]";
            var middleColumn = String.Format(" Листа со Партнери  ");
            const string rightColumn = "Датум: [Date Printed]";

            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Header.LineAlignment = BrickAlignment.Near;

            phf.Footer.Content.Clear();


            link.ShowPreview();
        }

        private void btnZatvori1_Click(object sender, EventArgs e)
        {
            this.tblPartneriTableAdapter.Fill(this._BSSR_2_0DataSet.tblPartneri);
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            btnSendMailDoPartneri.DialogResult = DialogResult.None;
            gridView1.ResetAutoFilterConditions();
            gridView1.ClearColumnsFilter();
            gridView1.ClearSorting();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi1_Click(object sender, EventArgs e)
        {
            MailTextResult = richEditControl1.HtmlText;
            this.Close();
        }
    }
}

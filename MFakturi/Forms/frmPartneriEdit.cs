using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using BssBase;
using MFakturi.Forms.Reporti;
using uFR;

namespace MFakturi.Forms
{
    public partial class frmPartneriEdit : frmBigEdit
    {
        public frmPartneriEdit()
            : base()
        {
            InitializeComponent();

            if (settings.UserLevel == 6 && settings.TipNaPrograma == "8")
            {
                SetFormReadOnly();
            }
        }

        private string notesAddTExt;

        public frmPartneriEdit(string notesAdd)
            : base()
        {
            InitializeComponent();

            if (settings.UserLevel == 6 && settings.TipNaPrograma == "8")
            {
                SetFormReadOnly();
            }
            notesAddTExt = notesAdd;
            btnVnesiKarticka.Visible = true;
        }


        //  private int ID;

        public frmPartneriEdit(int selectedId)
            : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            ID = selectedId;
        }

        public frmPartneriEdit(int selectedId, bool readOnly = false)
        : base()
        {
            InitializeComponent();

            FormIsEdit = true;
            Text = "Инфо";
            ID = selectedId;
            this.SetFormReadOnly();
            this.CenterToScreen();
        }

        private void frmtblPartneriEdit_Load(object sender, EventArgs e)
        {
            btnVnesiKarticka.DialogResult = System.Windows.Forms.DialogResult.None;
            // TODO: This line of code loads data into the 'fakturiDataSet.tblPresmetkovniEdinici' table. You can move, or remove it, as needed.
            tblPresmetkovniEdiniciTableAdapter.Fill(fakturiDataSet.tblPresmetkovniEdinici);
            tblPartneriTableAdapter.Fill(fakturiDataSet.tblPartneri);

            if (FormIsEdit)
            {
                tblPartneriBindingSource.Filter = String.Format(" {0} ={1}", PrimaryKey, ID);
                string tip = ((DataRowView)tblPartneriBindingSource.Current)["Tip"].ToString();
                if (!string.IsNullOrEmpty(tip))
                {
                    tipcmbBase.SelectedIndex = Tools.PrazenStringToInt(tip);
                }

                string TipNaDostava = ((DataRowView)tblPartneriBindingSource.Current)["TipNaDostava"].ToString();
                if (!string.IsNullOrEmpty(tip))
                {
                    this.TipNaDostava.SelectedIndex = Tools.PrazenStringToInt(TipNaDostava);
                }
            }
            else
            {
                bindingNavigatorAddNewItem.PerformClick();
                if (!string.IsNullOrEmpty(notesAddTExt))
                {
                    ((DataRowView)tblPartneriBindingSource.Current)["Notes"] = notesAddTExt;
                }

            }

            tblPartneriBindingNavigator.Visible = false;

            sredi_Dolzina(fakturiDataSet.tblPartneri.Columns, fakturiDataSet.tblPartneri.TableName, settings.konekcija, false);
            Oznaci_Zadolzitelni();
            if (settings.TipNaPrograma.Contains("988KasaPartner") && settings.StartCardReaderd.Contains("true"))
            {
                btnVnesiKarticka.Visible = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Oznaci_Zadolzitelni();

            if (validacija())
            {
                try
                {
                    Validate();
                    ((DataRowView)tblPartneriBindingSource.Current)["Tip"] = tipcmbBase.SelectedIndex;
                    ((DataRowView)tblPartneriBindingSource.Current)["TipNaDostava"] = TipNaDostava.SelectedIndex;
                    ((DataRowView)tblPartneriBindingSource.Current)["FirmaID"] = settings.firmaId;
                    tblPartneriBindingSource.EndEdit();
                    tblPartneriTableAdapter.Update(fakturiDataSet.tblPartneri);
                    NeZatvoraj = false;
                    Close();
                }
                catch (Exception ex)
                {
                    if (ex is SqlException)
                    {
                        Tools.PrevediSQLException((SqlException)ex);
                    }
                    else
                    {
                        Tools.PrevediSQLException(ex);
                    }
                    NeZatvoraj = true;
                }
            }
        }

        private void StartNfcReader()
        {
            DL_STATUS status = 0;

            status = uFCoder.ReaderOpen();

            if (status > 0)
            {
                notesTextBox.Text = "Нема NFC Читач - Грешка со конекција";
             
                uFCoder.ReaderUISignal(2, 5);
                
            }
         
        }

        private void btnVnesiKarticka_Click(object sender, EventArgs e)
        {
            try
            {
                StartNfcReader();
                byte sak = 0, uid_size = 0;
                byte[] uid = new byte[6];

                DL_STATUS status = 0;

                status = uFCoder.GetCardIdEx(out sak, uid, out uid_size);

                string cardUidString = BitConverter.ToString(uid).Replace("-", "").Replace(":", "").Replace("0x", "");
                notesTextBox.Text = !string.IsNullOrEmpty(cardUidString) ? cardUidString : notesTextBox.Text;

            }
            catch (Exception ex)
            {
                Tools.RaiseException(ex, true, string.Empty);
            }
        }
    }
}

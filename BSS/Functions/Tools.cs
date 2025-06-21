using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraRichEdit.Import.Html;

using httpHelpers;

using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Management.Smo;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

using static Tools;

public static partial class Tools
{

    public partial class ImportHvac
    {
        [JsonProperty("general_data", NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData GeneralData { get; set; }

        [JsonProperty("partners", NullValueHandling = NullValueHandling.Ignore)]
        public List<Partner> Partners { get; set; }
    }

    public partial class GeneralData
    {
        [JsonProperty("supplier_total_bill", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SupplierTotalBill { get; set; }

        [JsonProperty("supplier_low_tariff_kwh", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SupplierLowTariffKwh { get; set; }

        [JsonProperty("supplier_high_tariff_kwh", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SupplierHighTariffKwh { get; set; }

        [JsonProperty("lost_electricity_low_tariff", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LostElectricityLowTariff { get; set; }

        [JsonProperty("lost_electricity_high_tariff", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LostElectricityHighTariff { get; set; }

        [JsonProperty("warm_water_maintaining_fee", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WarmWaterMaintainingFee { get; set; }

        [JsonProperty("warm_water_total_cost", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WarmWaterTotalCost { get; set; }

        [JsonProperty("warm_water_heating_total_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WarmWaterHeatingTotalPrice { get; set; }

        [JsonProperty("warm_water_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal WarmWaterPrice { get; set; }

        [JsonProperty("hidrokit_users", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? HidrokitUsers { get; set; }

        [JsonProperty("hidrokit_low_tariff_kwh", NullValueHandling = NullValueHandling.Ignore)]
        public decimal HidrokitLowTariffKwh { get; set; }

        [JsonProperty("hidrokit_high_tariff_kwh", NullValueHandling = NullValueHandling.Ignore)]
        public decimal HidrokitHighTariffKwh { get; set; }

        [JsonProperty("total_warm_water_consumed", NullValueHandling = NullValueHandling.Ignore)]
        public decimal TotalWarmWaterConsumed { get; set; }

        [JsonProperty("indoors_total_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? IndoorsTotalPrice { get; set; }

        [JsonProperty("indoors_low_tariff_min", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? IndoorsLowTariffMin { get; set; }

        [JsonProperty("indoors_low_tariff_total_min", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? IndoorsLowTariffTotalMin { get; set; }

        [JsonProperty("indoors_high_tariff_min", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? IndoorsHighTariffMin { get; set; }

        [JsonProperty("indoors_high_tariff_total_min", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? IndoorsHighTariffTotalMin { get; set; }

        [JsonProperty("invoice_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InvoiceDate { get; set; }

        [JsonProperty("invoice_due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InvoiceDueDate { get; set; }

        [JsonProperty("invoice_for", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InvoiceFor { get; set; }
    }

    public partial class Partner
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("water_meter", NullValueHandling = NullValueHandling.Ignore)]
        public string WaterMeter { get; set; }

        [JsonProperty("water_meter_old", NullValueHandling = NullValueHandling.Ignore)]
        public decimal WaterMeterOld { get; set; }

        [JsonProperty("water_meter_new", NullValueHandling = NullValueHandling.Ignore)]
        public decimal WaterMeterNew { get; set; }

        [JsonProperty("articles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Article> Articles { get; set; }

        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public List<Unit> Units { get; set; }
    }

    public partial class Article
    {
        [JsonProperty("article", NullValueHandling = NullValueHandling.Ignore)]
        public string ArticleItem { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Qty { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Price { get; set; }
    }

    public partial class Unit
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Capacity { get; set; }

        [JsonProperty("low_run", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LowRun { get; set; }

        [JsonProperty("low_run_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LowRunTotal { get; set; }

        [JsonProperty("high_run", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? HighRun { get; set; }

        [JsonProperty("high_run_total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? HighRunTotal { get; set; }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }


    private static DataTable _tblPrevodi;
    private static Dictionary<String, String> _tblPrevodiTekst;

    static void RemoveLeaveEvent(Control ctrl)
    {
        var keyDownInfo = (typeof(Control)).GetField("EventLeave",
            BindingFlags.Static | BindingFlags.NonPublic);

        var eventsInfo = (typeof(Component)).GetField("events",
            BindingFlags.Instance | BindingFlags.NonPublic);

        var keyDown = keyDownInfo.GetValue(ctrl);

        var events = eventsInfo.GetValue(ctrl) as EventHandlerList;

        if (events == null)
        {
            return;
        }

        var d = events[keyDown];

        if (d != null)
        {
            events.RemoveHandler(keyDown, d);
        }
    }

    public static String NumWords(double n) //converts double to words
    {
        string[] numbersArr = new string[] { "еден", "двe", "три", "четири", "пет", "шест", "седум", "осум", "девет", "десет", "единаесет", "дванаесет", "трианесет", "четиринаесет", "петнаесет", "шестнаесет", "седумнаесет", "осумнаесет", "деветнаесет" };

        string[] tensArr = new string[] { "дваесет", "триесет", "четириесет", "педесет", "шеесет", "седумдесет", "осумдесет", "деведесет" };
        string[] suffixesArr = new string[] { "илјади", "милиони", "билиони", "трилиони", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };
        string words = "";

        bool tens = false;

        if (n < 0)
        {
            words += "negative ";
            n *= -1;
        }

        int power = (suffixesArr.Length + 1) * 3;

        while (power > 3)
        {
            double pow = Math.Pow(10, power);
            if (n >= pow)
            {
                if (n % pow > 0)
                {
                    words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                }
                else if (n % pow == 0)
                {
                    words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1];
                }
                n %= pow;
            }
            power -= 3;
        }
        if (n >= 1000)
        {
            if (n % 1000 > 0) words += NumWords(Math.Floor(n / 1000)) + " илјади, ";
            else words += NumWords(Math.Floor(n / 1000)) + " илјада";
            n %= 1000;
        }
        if (0 <= n && n <= 999)
        {

            if ((int)n / 100 > 0)
            {
                if (n.ToString().StartsWith("1"))
                {
                    words += NumWords(Math.Floor(n / 100)) + "сто";
                }
                else
                {
                    words += NumWords(Math.Floor(n / 100)) + "стотини";
                }
                n %= 100;
            }


            if ((int)n / 10 > 1)
            {
                if (words != "")
                    words += " ";
                words += tensArr[(int)n / 10 - 2];
                tens = true;
                n %= 10;
            }

            if (n < 20 && n > 0)
            {
                if (words != "" && tens == false)
                    words += " ";

                words += (tens ? " и " + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);

                n -= Math.Floor(n);
            }
        }

        return words;

    }

    public static string NumberToWords(int number)
    {
        if (number == 0)
            return "нула";

        if (number < 0)
            return "- " + NumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            if ((number / 1000000).ToString().StartsWith("1"))
                words += " милион ";
            else
                words += NumberToWords(number / 1000000) + " милиони ";

            number %= 1000000;
        }

        if ((number / 10000) > 0)
        {
            if ((number / 10000).ToString().EndsWith("1"))
                words += " илјада ";
            else
                words += NumberToWords(number / 10000) + " илјади ";

            number %= 10000;
        }

        if ((number / 1000) > 0)
        {
            if ((number / 1000).ToString().StartsWith("1"))
                words += " илјада ";
            else
                words += NumberToWords(number / 1000) + " илјади ";

            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            if ((number / 100).ToString().StartsWith("1"))
                words += " сто ";
            else
                words += NumberToWords(number / 100) + " стотини ";

            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += " ";

            var unitsMap = new[] { "нула", "еден", "двe", "три", "четири", "пет", "шест", "седум", "осум", "девет", "десет", "единаесет", "дванаесет", "трианесет", "четиринаесет", "петнаесет", "шестнаесет", "седумнаесет", "осумнаесет", "деветнаесет" };
            var tensMap = new[] { "нула", "десет", "дваесет", "триесет", "четириесет", "педесет", "шеесет", "седумдесет", "осумдесет", "деведесет" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " и " + unitsMap[number % 10];
            }
        }

        return words;
    }


    public static String NumWordsWrapper(double n)
    {
        string words = "";
        double intPart;
        double decPart = 0;
        if (n == 0)
            return "нула";
        try
        {
            string[] splitter = n.ToString().Split('.');
            intPart = double.Parse(splitter[0]);
            decPart = double.Parse(splitter[1]);
        }
        catch
        {
            intPart = n;
        }

        words = NumWords(intPart);

        if (decPart > 0)
        {
            if (words != "")
                words += " and ";
            int counter = decPart.ToString().Length;
            switch (counter)
            {
                case 1: words += NumWords(decPart) + " десетки"; break;
                case 2: words += NumWords(decPart) + " стотки"; break;
                case 3: words += NumWords(decPart) + " илјади"; break;
                case 4: words += NumWords(decPart) + " десет илјади"; break;
                case 5: words += NumWords(decPart) + " сто илјади"; break;
                case 6: words += NumWords(decPart) + " милиони"; break;
                case 7: words += NumWords(decPart) + " десет милиони"; break;
            }
        }
        return words;
    }


    public static object NullToDB(object obj)
    {
        if (Equals(null, obj))
        {
            return DBNull.Value;
        }
        else
        {
            return obj;
        }
    }

    public static void RemoveClick(Control ctrl)
    {
        var keyDownInfo = (typeof(Control)).GetField("Click",
            BindingFlags.Static | BindingFlags.NonPublic);

        var eventsInfo = (typeof(Component)).GetField("events",
            BindingFlags.Instance | BindingFlags.NonPublic);

        var keyDown = keyDownInfo.GetValue(ctrl);

        var events = eventsInfo.GetValue(ctrl) as EventHandlerList;

        if (events == null)
        {
            return;
        }

        var d = events[keyDown];

        if (d != null)
        {
            events.RemoveHandler(keyDown, d);
        }
    }

    public static void RemoveKeyDownEvent(Control ctrl)
    {
        var keyDownInfo = (typeof(Control)).GetField("EventKeyDown",
            BindingFlags.Static | BindingFlags.NonPublic);

        var eventsInfo = (typeof(Component)).GetField("events",
            BindingFlags.Instance | BindingFlags.NonPublic);

        var keyDown = keyDownInfo.GetValue(ctrl);

        var events = eventsInfo.GetValue(ctrl) as EventHandlerList;

        if (events == null)
        {
            return;
        }

        var d = events[keyDown];

        if (d != null)
        {
            events.RemoveHandler(keyDown, d);
        }
    }

    public static int VratiGrupaDDV(string id)
    {
        var grupa = 192;
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("select Grupa from tblDDVStavka where ID = @ID", con))
            {
                try
                {
                    con.Open();
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", id);
                    var rez = com.ExecuteScalar();
                    if (!Equals(rez, null))
                    {
                        grupa = PrazenStringToInt(rez.ToString(), -1);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    return 192;
                }
            }
        }
        return grupa;
    }

    public static void removeUserConfig(string objectName)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("delete from tblUserConfigs  WHERE ltrim(Rtrim(ObjectName)) LIKE ltrim(Rtrim(@Ime)) AND UserID=@User", con);
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@User", BssBase.settings.UserId);
            com.Parameters.AddWithValue("@Ime", objectName);
            com.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
        }
    }

    public static CultureInfo GetSystemGlobalizationCulture()
    {
        if (string.IsNullOrEmpty(BssBase.settings.CultureInfoString)) BssBase.settings.CultureInfoString = "mk-MK";

        Thread.CurrentThread.CurrentCulture = new CultureInfo(BssBase.settings.CultureInfoString);
        var CUlDateInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(BssBase.settings.CultureInfoString);

        CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";

        customCulture.NumberFormat.NumberGroupSeparator = string.Empty;
        customCulture.NumberFormat.NumberGroupSizes = new int[0];
        customCulture.NumberFormat.CurrencyDecimalDigits = 2;
        customCulture.NumberFormat.CurrencySymbol = "Ден";
        customCulture.NumberFormat.CurrencyGroupSizes = new int[0];
        customCulture.NumberFormat.CurrencyGroupSeparator = string.Empty;
        customCulture.NumberFormat.NumberDecimalDigits = 2;
        CUlDateInfo.ShortDatePattern = "yyyy-MM-dd";
        CUlDateInfo.LongDatePattern = "dddd, dd MMMM yyyy";
        CUlDateInfo.ShortTimePattern = "HH:mm";
        CUlDateInfo.LongDatePattern = "HH:mm:ss";

        customCulture.DateTimeFormat = CUlDateInfo;

        Thread.CurrentThread.CurrentCulture = customCulture;
        return Thread.CurrentThread.CurrentCulture;

    }
    public static string getUserConfig(string objectName)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("Select ConfigData from tblUserConfigs  WHERE ltrim(Rtrim(ObjectName)) LIKE ltrim(Rtrim(@Ime)) AND UserID=@User", con);
        com.Parameters.Clear();
        com.Parameters.AddWithValue("@User", BssBase.settings.UserId);
        com.Parameters.AddWithValue("@Ime", objectName);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (!Equals(null, reader["ConfigData"]))
                {
                    return reader["ConfigData"].ToString();
                }
                con.Close();
            }
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA getUserConfig()");
            LogWriteText(ex.Message);
            MessageBox.Show(ex.ToString());
            return null;
        }

        return null;
    }

    public static void WriteLog(string Akcija, int Status = 1)
    {
        Sessions.LogAction(BssBase.settings.Sesija, Akcija, Status, BssBase.settings.konekcija);
    }

    public static void WriteUserConfig(string objectName, string obj)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        var commandText = string.Empty;

        if (Equals(getUserConfig(objectName), null))
        {
            commandText = @"INSERT INTO [tblUserConfigs]
						   ([UserID]
						   ,[ObjectName]
						   ,[ConfigData])
							VALUES (@User, @Ime, @Data)";
        }
        else
        {
            commandText = @"UPDATE [tblUserConfigs] SET [ConfigData] = @Data
					WHERE [UserID] = @User AND [ObjectName] = @Ime";
        }
        var com = new SqlCommand(commandText, con);

        com.Parameters.Clear();
        com.Parameters.AddWithValue("@User", BssBase.settings.UserId);
        com.Parameters.AddWithValue("@Ime", objectName);
        com.Parameters.AddWithValue("@Data", obj);

        try
        {
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogWriteText("sssssssssssssssssssssssssssssssssssssssssssss");
            LogWriteText(ex.ToString());
        }
    }

    public static string ObjectToString(object obj)
    {
        var ms = new MemoryStream();
        new BinaryFormatter().Serialize(ms, obj);
        return Convert.ToBase64String(ms.ToArray());
    }

    public static object StringToObject(string base64String)
    {
        var bytes = Convert.FromBase64String(base64String);
        var ms = new MemoryStream(bytes, 0, bytes.Length);
        ms.Write(bytes, 0, bytes.Length);
        ms.Position = 0;
        return new BinaryFormatter().Deserialize(ms);
    }

    public static string userPrivegie()
    {
        var result = string.Empty;
        foreach (string sifra in BssBase.settings.UserRole.Split(';'))
        {
            var con = new SqlConnection(BssBase.settings.konekcija);
            var com = new SqlCommand("Select SpisokNaFormi from tblRolji  WHERE ltrim(Rtrim(Sifra)) LIKE ltrim(Rtrim(@sifra)) AND FirmaID =" + BssBase.settings.firmaId, con);
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@sifra", sifra);
            try
            {
                con.Open();
                var res = com.ExecuteScalar();
                if (!Equals(null, res))
                {
                    result += ";" + res.ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                LogWriteText("FUNCKCIJA ");
                LogWriteText(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
        return result;
    }

    public static string VratiImeNaFormaOdKod(string kod)
    {
        var ImeNaforma = string.Empty;
        if (string.IsNullOrEmpty(kod))
        {
            return ImeNaforma;
        }
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("Select frmIme from tblFormi  WHERE ltrim(Rtrim(frmKod)) LIKE ltrim(Rtrim(@param1)) ", con);
        com.Parameters.Clear();
        com.Parameters.AddWithValue("@param1", kod);
        try
        {
            con.Open();
            var res = com.ExecuteScalar();
            if (!Equals(null, res))
            {
                ImeNaforma = res.ToString();
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            MessageBox.Show(ex.ToString());
        }
        return ImeNaforma;
    }

    public static string VratiImeNaTransakcijaOdKod(string kod)
    {
        var ImeNaforma = string.Empty;
        if (string.IsNullOrEmpty(kod))
        {
            return ImeNaforma;
        }
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("Select frmKod from tblFormi  WHERE ltrim(Rtrim(frmIme)) LIKE ltrim(Rtrim(@param1)) ", con);
        com.Parameters.Clear();
        com.Parameters.AddWithValue("@param1", kod);
        try
        {
            con.Open();
            var res = com.ExecuteScalar();
            if (!Equals(null, res))
            {
                ImeNaforma = res.ToString();
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            MessageBox.Show(ex.ToString());
        }
        return ImeNaforma;
    }

    public static string VratiFilterNaFormaOdKod(string kod)
    {
        var filter = string.Empty;
        if (string.IsNullOrEmpty(kod))
        {
            return string.Empty;
        }
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("Select frmFilter from tblFormi  WHERE ltrim(Rtrim(frmKod)) LIKE ltrim(Rtrim(@param1)) ", con);
        com.Parameters.Clear();
        com.Parameters.AddWithValue("@param1", kod);
        try
        {
            con.Open();
            var res = com.ExecuteScalar();
            if (!Equals(null, res))
            {
                filter = res.ToString();
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            MessageBox.Show(ex.ToString());
        }
        return filter;
    }

    public static bool proveriPrivilegii(string ImeNaForma)
    {
        if (string.IsNullOrEmpty(ImeNaForma))
        {
            return false;
        }
        if (BssBase.settings.UserRole.Contains("ADMIN"))
        {
            return true;
        }
        var con = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("Select frmKod from tblFormi  WHERE ltrim(Rtrim(frmIme)) LIKE ltrim(Rtrim('" + ImeNaForma + "')) ", con);
        string kod = null;
        try
        {
            con.Open();
            var res = com.ExecuteScalar();
            if (!Equals(null, res))
            {
                kod = res.ToString();
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            MessageBox.Show(ex.ToString());
        }

        if (Equals(null, kod))
        {
            return false;
        }

        if (userPrivegie().Contains(kod))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void CreateResourceFile(string resxFileName, Control.ControlCollection col)
    {
        ResXResourceWriter resxWriter;
        try
        {
            resxWriter = new ResXResourceWriter(resxFileName);
            foreach (Control item in col)
            {
                resxWriter.AddResource(item.Name, item.Text);
            }

            resxWriter.Close();
        }
        catch (FileNotFoundException caught)
        {
            MessageBox.Show("Source: " + caught.Source + " Message: " + caught.Message);
        }
    }

    private static bool _isValied = true;

    public static string EmptyString(object str)
    {
        if (Equals(null, str))
        {
            return string.Empty;
        }
        return str.ToString();
    }

    public static void KonvertirajFajlVoLatinca(string filepath = "")
    {
        var openfIle = new OpenFileDialog();
        openfIle.ShowDialog();

        var dlg = new SaveFileDialog();
        dlg.ShowDialog();

        if (openfIle.FileName != string.Empty && dlg.FileName != string.Empty)
        {
            using (var fsO = new FileStream(dlg.FileName, FileMode.OpenOrCreate))
            {
                using (var fs = new FileStream(openfIle.FileName, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        using (var F_trezor = new StreamWriter(fsO, Encoding.ASCII))
                        {
                            String input;
                            while ((input = sr.ReadLine()) != null)
                            {
                                F_trezor.WriteLine(ConvertToLatinica(input));
                            }

                            F_trezor.Close();
                        }
                    }
                }
            }
        }
    }

    public static void KonvertirajFajlVoKirilica()
    {
        var openfIle = new OpenFileDialog();
        openfIle.ShowDialog();

        var dlg = new SaveFileDialog();
        dlg.ShowDialog();

        if (openfIle.FileName != string.Empty && dlg.FileName != string.Empty)
        {
            using (var fsO = new FileStream(dlg.FileName, FileMode.OpenOrCreate))
            {
                using (var fs = new FileStream(openfIle.FileName, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        using (var F_trezor = new StreamWriter(fsO, Encoding.Unicode))
                        {
                            String input;
                            while ((input = sr.ReadLine()) != null)
                            {
                                F_trezor.WriteLine(ConvertToKirilica(input));
                            }
                            F_trezor.Close();
                        }
                    }
                }
            }
        }
    }

    public static decimal PrazenStringToDecimal_dec(string VrednostDecimalStr)
    {
        try
        {
            if (string.IsNullOrEmpty(VrednostDecimalStr) || string.IsNullOrWhiteSpace(VrednostDecimalStr))
            {
                return 0;
            }
            else
            {
                return decimal.Parse(VrednostDecimalStr);
            }
        }
        catch (Exception)
        {
            return decimal.Parse("0");
        }
    }

    public static void ProkniziDokument_NOVOKnizenje(int DokumentID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("Exec ProkniziMaterijaliOdInterni_Dokumenti_Novo @dokumentID, @FirmaID, @ObjektiID,@UserID", con))
            {
                try
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ObjektiID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@UserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@dokumentID", DokumentID);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    return;
                }
            }
        }
    }

    public static void ProkniziDokument(int DokumentID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("Exec ProkniziMaterijaliOdInterni @dokumentID, @FirmaID, @ObjektiID,@UserID", con))
            {
                try
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ObjektiID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@UserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@dokumentID", DokumentID);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    return;
                }
            }
        }
    }

    public static void ProkniziFaktura(int FakturaID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("Exec ProkniziMaterijaliODFaktura @faktura, @FirmaID, @ObjektiID,@UserID", con))
            {
                try
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ObjektiID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@UserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@faktura", FakturaID);
                    con.Open();
                    com.ExecuteNonQuery();
                    com.CommandText = "select ListaNaIspratnici  from tblFaktura where ID = @FakturaID";
                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@FakturaID", FakturaID);
                    var rez = com.ExecuteScalar().ToString();

                    if (!Equals(rez, DBNull.Value))
                        if (!Equals(rez, null))
                        {
                            string listaSoIspratnici = rez.ToString();
                            con.Close();

                            foreach (string broj in listaSoIspratnici.Split(';'))
                            {
                                int brojDokument = PrazenStringToInt(broj, -1);
                                if (brojDokument != -1)
                                {
                                    SmeniTipNaDokumentZaDokumentBroj(brojDokument, BssBase.tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceNeSeKnizi, BssBase.tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi);
                                }
                            }
                        }

                    con.Close();
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    return;
                }
            }
        }
    }

    public static void ProkniziPriem(int PriemID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("Exec ProkniziMaterijaliODPriem @PriemID, @FirmaID, @ObjektiID,@UserID", con))
            {
                try
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ObjektiID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@UserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@PriemID", PriemID);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    return;
                }
            }
        }
    }


    public static void ProkniziKolicini()
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("Exec ProkniziZalihaZaArtikli", con))
            {
                try
                {
                    com.Parameters.Clear();
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно прокнижено");
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    //return;
                }
            }
        }
    }

    public static bool checkIfSmetkaExistsWithSameZabeleska(string broj)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("SELECT TOP 1 1 FROM dbo.tblSmetka WHERE Zabeleska LIKE '%' + CAST(@Broj AS NVARCHAR(max)) AND DatumKraj IS NULL ", con))
            {
                try
                {
                    con.Open();
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", broj);
                    var result = com.ExecuteScalar();
                    if (result == null)
                    {
                        return false;
                    }
                    return Tools.PrazenStringToInt(result.ToString()) == 1;

                }
                catch (Exception e)
                {
                    Tools.PrevediSQLException(e);
                    return false;
                }
            }
        }
    }
    public static void ProkniziSmetka(int SmetkaID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("Exec ProkniziMaterijaliZaSmetka @SmetkaID, @FirmaID, @ObjektiID", con))
            {
                try
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ObjektiID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    //return;
                }
            }
        }
    }

    public static void PratiMailNaZatvoranjeNaDen()
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("select * from dbo.ZatvoranjeNaDen( @DatumPocetok )", con))
            {
                con.Open();
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@DatumPocetok", DateTime.Now);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //if (!(Equals(DBNull.Value, reader["IznosOdSmetki"]))) return;
                        //if (!(Equals(DBNull.Value, reader["IznosFiskalna"]))) return;

                        //if (!(Equals(null, reader["IznosOdSmetki"]))) return;
                        //if (!(Equals(null, reader["IznosFiskalna"]))) return;

                        decimal IznosFiskalna = PrazenStringToDecimal_dec(reader["IznosFiskalna"].ToString());
                        decimal IznosPrometVkupno = PrazenStringToDecimal_dec(reader["IznosOdSmetki"].ToString());
                        string text = "Вкупен износ од фискална : " + IznosFiskalna.ToString("N2") + "\n" + "Вкупен износ од сметки: " + IznosPrometVkupno.ToString("N2");
                        SendMailDefault(string.Empty, "Затворање на ден: " + DateTime.Now.ToShortDateString(), text, false, BssBase.settings.GMailToZaSmetki);
                    }
                }
            }
        }
    }

    public static int PrazenStringToInt(string VrednostDecimalStr, int defaultValue = -1)
    {
        try
        {
            if (string.IsNullOrEmpty(VrednostDecimalStr) || string.IsNullOrWhiteSpace(VrednostDecimalStr))
            {
                if (defaultValue == -1)
                {
                    return -1;
                }
                else
                {
                    return defaultValue;
                }
            }
            else
            {
                return int.Parse(VrednostDecimalStr);
            }
        }
        catch (Exception)
        {
            if (defaultValue == -1)
            {
                return int.Parse("0");
            }
            else
            {
                return defaultValue;
            }
        }
    }

    public static double PrazenStringToDecimal(string Vrednost)
    {
        try
        {
            if (string.IsNullOrEmpty(Vrednost) || string.IsNullOrWhiteSpace(Vrednost))
            {
                return 0;
            }
            else
            {
                return double.Parse(Vrednost);
            }
        }
        catch (Exception)
        {
            return double.Parse("0");
        }
    }

    public static string NaslovNaReportOdTipNaDokument(int TipNaDokument)
    {
        string sql = "select Naslov from tblTipNaDokument where ID = " + TipNaDokument.ToString();
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                con.Open();
                var result = com.ExecuteScalar().ToString();
                return result;
            }
        }

    }

    public static string ReportFileNameNaReportOdTipNaDokument(int TipNaDokument)
    {
        string sql = "select ReportFileName from tblTipNaDokument where ID = " + TipNaDokument.ToString();
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                con.Open();
                var result = com.ExecuteScalar().ToString();
                return result;
            }
        }

    }

    public static void prefrLiPorakiOdResourceToDB()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        var conI = new SqlConnection(BssBase.settings.konekcija);
        var com = new SqlCommand("select KlucenZbor from tblPrevodi", con);
        var comI = new SqlCommand(string.Empty, conI);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                while (reader.Read())
                {
                    conI.Open();
                    comI.CommandText = "Update tblPrevodi SET AL = @al, SR = @sr, EN = @en  Where KlucenZbor LIKE '" + reader["KlucenZbor"].ToString() + "'";
                    comI.Parameters.Clear();
                    comI.Parameters.AddWithValue("@al", PrevediPorakaOdResource(reader["KlucenZbor"].ToString(), "sq"));
                    comI.Parameters.AddWithValue("@en", PrevediPorakaOdResource(reader["KlucenZbor"].ToString(), "en"));
                    comI.Parameters.AddWithValue("@sr", PrevediPorakaOdResource(reader["KlucenZbor"].ToString(), "sr"));
                    comI.ExecuteNonQuery();
                    conI.Close();
                }
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
        }
    }


    public static bool PrevediSQLException(Exception ex)
    {
        var ImeNaException = ex.Message;

        if (ImeNaException.ToUpper().Contains("out of range".ToUpper()))
        {
            MessageBox.Show(PrevediPoraka("VrednostNedozvolena"), PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
        MessageBox.Show(ex.Message, PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        return true;
    }

    public static bool Execute_Sp_For_Merge(string tableName, DataTable data)
    {
        if (data.Rows.Count < 1) return true;
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("merge_" + tableName, con))
                {
                    com.Parameters.AddWithValue(tableName, data);
                    com.CommandType = CommandType.StoredProcedure;
                    var rez = com.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            Tools.LogException(ex.Message, ex);
            return false;
        }
    }

    public static string PrevediPoraka(string KlucenZbor)
    {
        try
        {
            if (String.IsNullOrEmpty(BssBase.settings.konekcija))
            {
                return KlucenZbor;
            }
            var rez = KlucenZbor;

            if (_tblPrevodi == null)
            {
                using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                {
                    using (SqlCommand com = new SqlCommand("Select * from tblPrevodi", con))
                    {
                        con.Open();
                        _tblPrevodi = new DataTable("tblPrevodi");
                        _tblPrevodi.Load(com.ExecuteReader());
                        _tblPrevodiTekst = new Dictionary<string, string>();
                        foreach (DataRow item in _tblPrevodi.Rows)
                        {
                            if (!_tblPrevodiTekst.ContainsKey(item["KlucenZbor"].ToString().ToLower()))
                                _tblPrevodiTekst.Add(item["KlucenZbor"].ToString().ToLower(), item[BssBase.settings.jazik].ToString());
                        }
                    }
                }
            }
            else
            {
                if (_tblPrevodiTekst != null && _tblPrevodiTekst.Any())
                {
                    rez = _tblPrevodiTekst.FirstOrDefault(x => x.Key.ToLower() == KlucenZbor.ToLower()).Value;
                }
                if (rez == null)
                {
                    using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
                    {
                        using (SqlCommand com = new SqlCommand(@"INSERT [dbo].[tblPrevodi] ([KlucenZbor], [MK], [AL], [EN], [SR]) VALUES (N'" + KlucenZbor + "', N'" + KlucenZbor + "', N'prevod_" + KlucenZbor + "', N'prevod_" + KlucenZbor + "', N'prevod_" + KlucenZbor + "')", con))
                        {
                            con.Open();
                            com.ExecuteNonQuery();
                            if (!_tblPrevodiTekst.ContainsKey(KlucenZbor.ToLower()))
                            {
                                _tblPrevodiTekst.Add(KlucenZbor.ToLower(), KlucenZbor);
                            }
                        }
                    }
                }
            }

            if (rez == null) rez = KlucenZbor;

            return rez;
        }
        catch (Exception ex)
        {
            Tools.LogException("Prevod", ex);

        }

        return KlucenZbor;
    }

    public static string PrevediPorakaOdResource(string poraka, string jazikf = null)
    {
        var jazik = BssBase.settings.jazik;
        if (string.IsNullOrEmpty(jazik))
        {
            jazik = "mk";
        }
        try
        {
            if (!Equals(jazikf, null))
            {
                jazik = jazikf;
            }

            var Prevedi = new ResourceManager(typeof(BssBase.Resources.PrevedeniPoraki_MK));
            if (jazik.ToUpper() == "mk".ToUpper())
            {
                //Prevedi = new System.Resources.ResourceManager( typeof( BssBase.Resources.PrevedeniPoraki_MK) );
            }
            else
            {
                Prevedi = new ResourceManager(typeof(BssBase.Resources.PrevedeniPoraki_EN));
            }

            if (string.IsNullOrEmpty(Prevedi.GetString(poraka)))
            {
                return string.Empty;
            }
            else
            {
                return Prevedi.GetString(poraka);
            }
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            return poraka;
        }
    }

    public static string DatumNaRaganjeOdMaticen(string Maticen)
    {
        if (Maticen != string.Empty)
        {
            Maticen.Trim().ToString();
            string den, mesec, godina, godina1, godina2 = string.Empty;

            godina1 = "1";
            godina2 = "2";

            den = Maticen.Substring(0, 2);
            mesec = Maticen.Substring(2, 2);
            godina = Maticen.Substring(4, 3);

            if (godina.Substring(0, 1) == "0")
            {
                godina = godina2 + godina;
            }
            else
            {
                godina = godina1 + godina;
            }
            return godina + mesec + den;
        }
        else
        {
            return string.Empty;
        }
    }

    public static decimal PoslednaCenaZaArtikalODPartner(int id, int partner)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;

        com = new SqlCommand(string.Format("SELECT [dbo].[PoslednaCenaZaArtikalODPartner] ({0},{1})", id, partner), con);

        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return PrazenStringToDecimal_dec(dt.Rows[0][0].ToString());
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return 0;
        }

        return 0;
    }

    public static DataTable TekovenFond()
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("TekovenFond", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = com.ExecuteReader(CommandBehavior.Default);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }
        return null;
    }

    public static DataTable DolgZaPartnerHvac(string sifra)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("ZaostanatDolgPoPartnerHVAC", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@SifraPartner", sifra);
                    reader = com.ExecuteReader(CommandBehavior.Default);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }
        return null;
    }

    public static DataTable DolgZaPartner(string sifra)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("ZaostanatDolgPoPartner", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@SifraPartner", sifra);
                    reader = com.ExecuteReader(CommandBehavior.Default);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }
        return null;
    }
    public static decimal ProdaznaCenaNaGolemo(int id)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {


            using (SqlCommand com = new SqlCommand(string.Format("select ISNULL(CenaNaGolemo,ProdaznaCena) as CenaNaGolemo from tblArtikal where ID = {0}", id), con))
            {

                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return PrazenStringToDecimal_dec(dt.Rows[0][0].ToString());
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return 0;
                }
            }

        }
        return 0;
    }

    public static decimal NajdiProsecnaNabavnaCenaZaArtikalID(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;

        com = new SqlCommand("select ProsecnaNabavnaCena from viewZarabotkaPoArtikal where ArtikalID=" + id.ToString(), con);

        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return PrazenStringToDecimal_dec(dt.Rows[0][0].ToString());
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return 0;
        }

        return 0;
    }

    public static decimal NajdiPoslednaNabavnaCenaZaArtikalID(string id)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("select top 1 isnull(NabavnaCenaSoDDV, 0) from tblPriemStavki where tblArtikalID = @ID ORDER BY ID DESC;", con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@ID", id);
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return PrazenStringToDecimal_dec(dt.Rows[0][0].ToString());
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return 0;
                }
            }
        }
        return 0;
    }

    public static decimal NajdiPoslednaNabavnaCenaOdDokumentiZaArtikalID(string id, int tipNaDokumentID)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("select top 1 isnull(Cena, 0) from viewDokumentiStavki WHERE TipNaDokumentID = @TipNaDokumentID AND ArtikalID = @ID ORDER BY ID DESC;", con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@ID", id);
                    com.Parameters.AddWithValue("@TipNaDokumentID", tipNaDokumentID);
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return PrazenStringToDecimal_dec(dt.Rows[0][0].ToString());
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return 0;
                }
            }
        }
        return 0;
    }
    public static decimal NajdiZalihaZaArtikalID(string id)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("select isnull(Saldo,0) from dbo.KoliciniNaArtikli WHERE ID = @ID", con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@ID", id);
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return PrazenStringToDecimal_dec(dt.Rows[0][0].ToString());
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return 0;
                }
            }
        }
        return 0;
    }

    public static DataRow NajdiInfoZaIDArtikal(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        string command = string.Empty;

        command = string.Format("Select * from viewSveUEdno Where ID ={0} AND FirmaID={1}", id, BssBase.settings.firmaId);

        com = new SqlCommand(command, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt.Rows[0];
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static string CaptureScreenOnException(string FileName)
    {
        FileName = Tools.setExportPath(FileName, true);
        FileInfo f = new FileInfo(FileName);

        if (!Directory.Exists(f.Directory.FullName))
        {
            Directory.CreateDirectory(f.Directory.FullName);
        };

        Rectangle bounds = Screen.GetBounds(Point.Empty);
        using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }
            if (File.Exists(FileName)) File.Delete(FileName);
            bitmap.Save(FileName, ImageFormat.Jpeg);
        }

        return FileName;
    }
    public static DataRow NajdiInfoZaSifraArtikal(string sifra)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {

            string command = string.Empty;
            if (string.IsNullOrEmpty(sifra)) return null;

            sifra = sifra.PadLeft(15, '0').Replace("'","''");
            if (sifra.StartsWith("00022"))
            {
                sifra = sifra.Substring(5, 5);
                sifra = sifra.PadLeft(15, '0');
            }

            command = "Select * from viewSveUEdno Where " +
                      " RIGHT('000000000000000'+CAST(" + BssBase.settings.poleZaSifra + " AS NVARCHAR(15)),15) LIKE '%" + sifra +
                      "' OR RIGHT('000000000000000'+CAST(" + BssBase.settings.poleZaBarkod + " AS NVARCHAR(15)),15) LIKE '%" + sifra + "' AND FirmaID=" + BssBase.settings.firmaId;


            using (SqlCommand com = new SqlCommand(command, con))
            {
                SqlDataReader reader;
                try
                {
                    var dt = new DataTable();
                    con.Open();
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {

                        dt.Load(reader);
                        return dt.Rows[0];
                    }
                    else
                    {
                        if (!sifra.StartsWith("00022") && BssBase.settings.TipNaPrograma == "988Kasa")
                        {
                            reader.Close();
                            com.Parameters.Clear();
                            com.CommandText = "InsertArtikalAkoGoNema";//procedure
                            com.CommandType = CommandType.StoredProcedure;
                            com.Parameters.AddWithValue("@sifra", sifra);
                            com.ExecuteScalar();
                            com.CommandType = CommandType.Text;
                            com.Parameters.Clear();
                            com.CommandText = command;
                            dt.Clear();
                            con.Close();
                            con.Open();
                            reader = com.ExecuteReader(CommandBehavior.SingleResult);
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                return dt.Rows[0];
                            }
                        }

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }

                return null;
            }
        }
    }
    public static DataTable NeProknizeniSmetki()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(@"select  A.* From ( select s.*,(case  WHEN isnull((select  distinct tblSmetkaID from tblKnizenjeM where tblSmetkaID = s.ID) ,0) = 0 AND isnull((Select COUNT(ID) as ID from tblSmetkaStavki where tblSmetkaID = s.ID),0) <> 0 THEN 0 ELSE 1 END) as Knizeno
            ,isnull((Select SUM(Cena) from tblSmetkaStavki where tblSmetkaID = s.ID),0) as Iznos
            from tblSmetka s
            where isnull((Select SUM(Cena) from tblSmetkaStavki where tblSmetkaID = s.ID),0) > 0)
            as A
            where A.Knizeno <> 1", con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return new DataTable();
    }
    public static DataTable GetListaSoArtikli()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblArtikal", con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.Default);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataRow NajdiInfoZaSifraArtikal_artikli(string sifra)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblArtikal Where Sifra LIKE '" + sifra + "' AND FirmaID=" + BssBase.settings.firmaId, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt.Rows[0];
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataRow NajdiInfoZaIDPartner(int ID)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblPartneri Where ID = " + ID.ToString() + " AND FirmaID=" + BssBase.settings.firmaId, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt.Rows[0];
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataRow NajdiInfoZaSmetka(int ID)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblSmetka Where ID = " + ID.ToString() + " AND FirmaID=" + BssBase.settings.firmaId, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt.Rows[0];
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataRow NajdiInfoZaIzvod(int izvodID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("select * from tblIzvodi where ID = " + izvodID.ToString(), con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows[0];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }

        return null;
    }

    public static DataRow najdiMinMaxOdPregledNaSmetki()
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand(@"SELECT * FROM NajdiMinMaxOdPregledNaSmetki()", con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows[0];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }

        return null;
    }
    public static DataRow NajdiInfoZaDokumentTipNaKnizenje(int dokumentID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("select * from tblTipNaDokument where ID = (select TipNaDokument from tblDokumenti where ID = @ID)", con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@ID", dokumentID);
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows[0];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }

        return null;
    }

    public static DataRow NajdiInfoZaDokument(int dokumentID)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand("select * from tblDokumenti where ID = " + dokumentID.ToString(), con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows[0];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
        }

        return null;
    }

    public static DataTable NajdiInfoZaDokumentBrojKod(string BrojNaDokument)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("select * from tblDokumenti where BrojNaDokument LIKE '" + BrojNaDokument + "' ", con))
                {
                    SqlDataReader reader;
                    try
                    {
                        con.Open();
                        reader = com.ExecuteReader(CommandBehavior.SingleResult);
                        if (reader.HasRows)
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        LogWriteText("FUNCKCIJA ");
                        LogWriteText(ex.Message);
                        LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                        return null;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
        }
        return null;
    }

    public static int NajdiInfoZaDokumentBroj(int TipNaDokument, int BrojNaDokument)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand("select ID from tblDokumenti where Broj=@Broj AND TipNaDokument=@BrojNaDokument", con))
                {
                    con.Open();
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", BrojNaDokument);
                    com.Parameters.AddWithValue("@BrojNaDokument", TipNaDokument);
                    using (SqlDataReader sqlr = com.ExecuteReader())
                    {
                        sqlr.Read();
                        if (sqlr.HasRows)
                            return PrazenStringToInt(sqlr["ID"].ToString());
                    }
                }
            }
        }
        catch (Exception ex)
        {
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
        }
        return -1;
    }

    public static DataRow NajdiInfoZaSifraPresmetkovnaEdinica(string sifra)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            try
            {

                using (SqlCommand com = new SqlCommand("Select * from tblPresmetkovniEdinici Where Sifra LIKE '" + sifra + "' AND FirmaID=" + BssBase.settings.firmaId, con))
                {
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows[0];
                    }
                }

            }
            catch (Exception ex)
            {
                LogWriteText("FUNCKCIJA ");
                LogWriteText(ex.Message);
                LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                return null;
            }
        }


        return null;
    }

    public static System.Data.DataTable SaldoPoDokumentPoPartner(string sifra, DateTime doDatum)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand("SaldoPoDokumentPoPartner", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@tblPartnerSifra", sifra);
                com.Parameters.AddWithValue("@DoDatum", doDatum);
                System.Data.DataTable db = new System.Data.DataTable("SaldoPoDokumentPoPartner");
                db.Load(com.ExecuteReader());
                return db;
            }
        }

    }

    public static System.Data.DataTable GetIzvodStavki(int selectedId)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand("select SifraPartner as Sifra, NazivPartner as Partner ,BrojNaDokument ,IznosDokument,TipNaDokument, Dolzi,Pobaruva from viewIzvodiStavki where tblIzvodiID=@ID", con))
            {
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@ID", selectedId);

                System.Data.DataTable db = new System.Data.DataTable("GetIzvodStavki");
                db.Load(com.ExecuteReader());
                return db;
            }
        }

    }

    public static DataTable GetListaSoPartneri()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblPartneri", con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.Default);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }
    public static DataRow NajdiInfoZaSifraPartner(string sifra)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblPartneri Where Sifra LIKE '" + sifra + "' AND FirmaID=" + BssBase.settings.firmaId, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt.Rows[0];
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataRow NajdiInfoZaFirma(int Id = 1)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand("Select * from tblFirma Where ID = " + BssBase.settings.firmaId, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader(CommandBehavior.SingleResult);
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt.Rows[0];
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static bool ValidateXml(string xmlPath, string XsdPath)
    {
        try
        {
            XmlReader xsd = new XmlTextReader(XsdPath);
            var schema = new XmlSchemaSet();
            schema.Add(null, xsd);

            var xmlReadeSettings = new XmlReaderSettings();
            xmlReadeSettings.ValidationType = ValidationType.Schema;
            xmlReadeSettings.Schemas.Add(schema);
            xmlReadeSettings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            var xmlTextReader = new XmlTextReader(xmlPath);
            var xmlReader = XmlReader.Create(xmlTextReader, xmlReadeSettings);

            while (xmlReader.Read())
            {
                ;
            }
            xmlReader.Close();

            var LogForm = new Form();
            var items = new ListView();
            items.Dock = DockStyle.Fill;
            items.Scrollable = true;
            //items.View = View.List;
            LogForm.ShowIcon = false;
            items.ForeColor = Color.Red;
            LogForm.Text = "Грешки во генерираниот xml Фајл";
            var Lista = new List<string>();
            Lista = Log.Split('\t').ToList();
            items.Items.Clear();
            if (Lista.Count > 1)
            {
                foreach (string item in Lista)
                {
                    items.Items.Add(item);
                }

                if (items.Items.Count > 0)
                {
                    _isValied = false;
                }

                LogForm.ShowInTaskbar = false;
                LogForm.StartPosition = FormStartPosition.CenterScreen;
                LogForm.Size = new Size(740, 480);
                LogForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                LogForm.Controls.Add(items);
                LogForm.ShowDialog();
                LogForm.Dispose();

                Log = string.Empty;
                items.Clear();
            }
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            _isValied = false;
        }

        return _isValied;
    }

    private static string Log = string.Empty;

    private static void ValidationCallBack(object sender, ValidationEventArgs args)
    {
        if (args.Severity == XmlSeverityType.Warning)
        {
            Log += "\tПредупредување:" + args.Message;
        }
        else
        {
            Log += "\tГрешка: " + args.Message;
        }
    }

    public static String ConvertToLatinica(String input)
    {
        try
        {
            var map = new Dictionary<char, char> { { 'А', 'A' }, { 'а', 'a' }, { 'Б', 'B' }, { 'б', 'b' }, { 'В', 'V' }, { 'в', 'v' }, { 'Г', 'G' }, { 'г', 'g' }, { 'Д', 'D' }, { 'д', 'd' }, { 'Ѓ', '\\' }, { 'ѓ', '|' }, { 'Е', 'E' }, { 'е', 'e' }, { 'Ж', '@' }, { 'ж', '`' }, { 'З', 'Z' }, { 'з', 'z' }, { 'Ѕ', 'Y' }, { 'ѕ', 'y' }, { 'И', 'I' }, { 'и', 'i' }, { 'Ј', 'J' }, { 'ј', 'j' }, { 'К', 'K' }, { 'к', 'k' }, { 'Л', 'L' }, { 'л', 'l' }, { 'Љ', 'Q' }, { 'љ', 'q' }, { 'М', 'M' }, { 'м', 'm' }, { 'Н', 'N' }, { 'н', 'n' }, { 'Њ', 'W' }, { 'њ', 'w' }, { 'О', 'O' }, { 'о', 'o' }, { 'П', 'P' }, { 'п', 'p' }, { 'Р', 'R' }, { 'р', 'r' }, { 'С', 'S' }, { 'с', 's' }, { 'Т', 'T' }, { 'т', 't' }, { 'Ќ', '}' }, { 'ќ', ']' }, { 'У', 'U' }, { 'у', 'u' }, { 'Ф', 'F' }, { 'ф', 'f' }, { 'Х', 'H' }, { 'х', 'h' }, { 'Ц', 'C' }, { 'ц', 'c' }, { 'Ч', '^' }, { 'ч', '~' }, { 'Џ', 'x' }, { 'џ', 'x' }, { 'Ш', '{' }, { 'ш', '[' } };
            return String.Concat(input.Select(c => (map.ContainsKey(c) ? map[c] : c)));
        }
        catch (Exception)
        {
            return input;
        }
    }

    public static string textToBase64(string sAscii)
    {
        var encoding = new ASCIIEncoding();
        var bytes = encoding.GetBytes(sAscii);
        return Convert.ToBase64String(bytes, 0, bytes.Length);
    }

    public static string DataTableToJSONWithJSONNet(DataTable table)
    {
        string JSONString = string.Empty;
        JSONString = JsonConvert.SerializeObject(table);
        return JSONString;
    }

    public static DataTable DataTableFromJSONWithJSONNet(string jsonText)
    {
        return JsonConvert.DeserializeObject<DataTable>(jsonText);
    }
    public static string DataRowToJSON(DataRow Item)
    {
        string JSONString = string.Empty;

        JSONString = JsonConvert.SerializeObject(Item);
        return JSONString;
    }

    public static string DictionaryToJSON(Dictionary<string, object> Item)
    {
        string JSONString = string.Empty;

        JSONString = JsonConvert.SerializeObject(Item);
        return "[" + JSONString + "]";
    }

    public static DataTable ListaSoArtikliNaAkcija;

    public static string GetIDNaFirma()
    {
        string txtIdFirma;
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand("SELECT TOP 1 txIDFirma FROM dbo.tblFirma", con))
            {
                txtIdFirma = com.ExecuteScalar().ToString();
            }
        }

        return txtIdFirma;
    }

    public static ImportHvac getImportFromHvac(string path)
    {//@"C:\PrintFiles\0323.json"
        var json = File.ReadAllText(path);

        var myDeserializedClass = JsonConvert.DeserializeObject<ImportHvac>(json);
        return myDeserializedClass;
    }
    public static void GenerirajHvacODJson(string path)
    {

        FileInfo fileInfo = new FileInfo(path);
        string mesec = fileInfo.Name.Substring(0, 2);
        string godina = fileInfo.Name.Substring(2, 2);

        var result = Tools.getImportFromHvac(fileInfo.FullName);

        int broj = 1;
        foreach (var hvacKorisnici in result.Partners)
        {

            var korisnik = Tools.NajdiInfoZaSifraPartner(hvacKorisnici.Name);
            var dokumentId = Tools.KreirajDokument(broj, DateTime.Now, 2, 1, 1,
                string.Empty, korisnik["Id"], $"{2}-{mesec}{godina}-{hvacKorisnici.Name.Substring(3, 3)}",
                DateTime.Now.AddDays(10), DateTime.Now.AddDays(-30));
            foreach (var stavka in hvacKorisnici.Articles)
            {
                var infoArtikal = Tools.NajdiInfoZaSifraArtikal(stavka.ArticleItem);
                Tools.InsertirajStavkaVoDokumenti(dokumentId, Convert.ToInt32(infoArtikal["Id"]), stavka.Qty, stavka.Price,
                    (stavka.Price * stavka.Qty), false, 0);
            }

            broj++;
        }
    }
    public static string base64ToText(string sbase64)
    {
        var bytes = Convert.FromBase64String(sbase64);
        var encoding = new ASCIIEncoding();
        return encoding.GetString(bytes, 0, bytes.Length);
    }

    public static void Compress(FileInfo fileToCompress)
    {
        using (FileStream originalFileStream = fileToCompress.OpenRead())
        {
            if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".Zip")
            {
                using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".Zip"))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                        LogWriteText(string.Format("Compressed {0} from {1} to {2} bytes.",
                            fileToCompress.Name, fileToCompress.Length.ToString(), compressedFileStream.Length.ToString()));
                    }
                }
            }
        }
    }
    public static string toNormalString(this string input)
    {
        return Tools.base64ToText(input);
    }

    public static int toInt(this string input)
    {
        return Convert.ToInt32(input);
    }
    public static int toInt(this object input)
    {
        return Convert.ToInt32(input);
    }
    public static decimal toDecimal(this string input)
    {
        return Tools.PrazenStringToDecimal_dec(input);
    }
    public static string setExportPath(string filName, bool BrisiAkoPostoi = false)
    {
        try
        {
            if (String.IsNullOrEmpty(BssBase.settings.ExprotPath))
                return filName;
            else
            {
                if (!Directory.Exists(BssBase.settings.ExprotPath))
                    Directory.CreateDirectory(BssBase.settings.ExprotPath);

                if (File.Exists(BssBase.settings.ExprotPath + @"\" + filName) && BrisiAkoPostoi)
                {
                    return BssBase.settings.ExprotPath + @"\" + filName;
                }

                if (File.Exists(BssBase.settings.ExprotPath + @"\" + filName))
                {
                    FileInfo f = new FileInfo(BssBase.settings.ExprotPath + @"\" + filName);

                    if (f.Length > 90000000)
                    {
                        MessageBox.Show("Фајлот е премногу голем ќе биде компресиран");
                        Compress(f);
                        return BssBase.settings.ExprotPath + @"\" + filName + ".zip";
                    }
                }

                return BssBase.settings.ExprotPath + @"\" + filName;
            }
        }
        catch (Exception ex)
        {
            LogException(ex.Message, ex);
            BssBase.settings.ExprotPath = "C:\\BSSR_LOGS\\";
            BssBase.settings.InitSettings.SaveRegSettings("ExprotPath", BssBase.settings.ExprotPath);
            return BssBase.settings.ReportPath + filName;
        }
    }
    public static SmtpClient mySmtpClient()
    {
        if (BssBase.settings.BSSMailAllowInvalidCert.toNormalString().ToLower().Contains("true"))
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateCertificate);
        }

        var securityProtocol = (int)System.Net.ServicePointManager.SecurityProtocol;

        // 0 = SystemDefault in .NET 4.7+
        if (securityProtocol != 0)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
        }

        var client = new SmtpClient(BssBase.settings.BSSMailServer.toNormalString())
        {
            Port = Convert.ToInt32(BssBase.settings.BSSMailPort.toNormalString()),
            EnableSsl = BssBase.settings.BSSMailEnableSSL.toNormalString().ToLower().Contains("true"),
            Timeout = Convert.ToInt32(BssBase.settings.BSSMailTimeOut.toNormalString()),
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(BssBase.settings.BSSMailUserName.toNormalString(), BssBase.settings.BSSMailPass.toNormalString())
        };
        return client;
    }

    private static bool ValidateCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        return true;
    }

    public static void SendMailCementara(string attachment, string subject, string text, bool prikaziPoraka = false, string Mailfrom = "spirodt@bssr.mk", string Mailto = "spirodt@bssr.mk")
    {

        if (Debugger.IsAttached || BssBase.settings.AdminPcName == "TestSpiro")
        {
            Mailto = "spirodt@bssr.mk";
            subject = "[TEST - IGNORE] " + subject;
            text = "[TEST - IGNORE] " + Environment.NewLine + text;
        }

        Cursor.Current = Cursors.WaitCursor;

        try
        {

            MailMessage msg = new MailMessage();
            msg.To.Add(Mailto);
            msg.From = new MailAddress(Mailfrom);
            msg.Subject = subject;
            msg.Body = text;
            if (attachment != "")
            {
                if (!attachment.Contains(";"))
                {
                    Attachment data = new Attachment(attachment);
                    msg.Attachments.Add(data);
                }
                else
                {
                    foreach (var item in attachment.Split(';'))
                    {
                        Attachment data = new Attachment(item);
                        msg.Attachments.Add(data);
                    }
                }
            }
            mySmtpClient().Send(msg);
            if (prikaziPoraka)
            {
                MessageBox.Show("Успешно испратено");
                Tools.LogWriteText("Email praten - SendMailCementara");
            }

        }
        catch (Exception exception)
        {
            LogExceptionMessageWithScreenShoot(exception, exception.Message, prikaziPoraka);

            return;
        }
        Cursor.Current = Cursors.Default;
    }

    public static bool SendMailWithBssrMK(string attachment,
                                          string subject,
                                          string text,
                                          bool prikaziPoraka = false,
                                          string Mailfrom = "bssrapp@bssr.mk",
                                          string Mailto = "bssrapp@bssr.mk",
                                          bool sendCCtoBssr = false)
    {
        if (Debugger.IsAttached || BssBase.settings.AdminPcName == "TestSpiro")
        {
            Mailto = "spirodt@bssr.mk";
            subject = "[TEST - IGNORE] " + subject;
            text = "[TEST - IGNORE] " + Environment.NewLine + text;
        }

        Cursor.Current = Cursors.WaitCursor;

        try
        {
            MailMessage emailMessage = new MailMessage();
            emailMessage.To.Add(Mailto);
            emailMessage.From = new MailAddress(Mailfrom);
            emailMessage.Subject = subject;
            emailMessage.Body = text;
            if (sendCCtoBssr)
            {
               // MailAddress bccSpiro = new MailAddress("spirodt@bssr.mk");
                MailAddress bssBssr = new MailAddress("bssrapp@bssr.mk");
               // emailMessage.Bcc.Add(bccSpiro);
                emailMessage.Bcc.Add(bssBssr);
            }

            if (attachment != "")
            {
                if (!attachment.Contains(";"))
                {
                    Attachment data = new Attachment(attachment);
                    emailMessage.Attachments.Add(data);
                }
                else
                {
                    foreach (var item in attachment.Split(';'))
                    {
                        Attachment data = new Attachment(item);
                        emailMessage.Attachments.Add(data);
                    }
                }
            }
            mySmtpClient().Send(emailMessage);
            if (prikaziPoraka)
            {
                MessageBox.Show("Успешно испратено");
                Tools.LogWriteText("Email praten - SendMailWithBssrMK");
                return false;
            }

            return true;

        }
        catch (Exception exception)
        {

            LogExceptionMessageWithScreenShoot(exception, exception.Message, prikaziPoraka, LogToMail: false);

            return false;
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }

    }

    public static bool SendMailDefaultHtml(bool html, string attachment, string subject, string text, bool prikaziPoraka = true, string Mailfrom = "", string Mailto = "")
    {
        bool UspesnoPrateno = false;
        if (PrazenStringToInt(BssBase.settings.EnableMail, 0) != 1)
        {
            UspesnoPrateno = true;
            return UspesnoPrateno;
        }

        if (Debugger.IsAttached || BssBase.settings.AdminPcName == "TestSpiro")
        {
            Mailto = "spirodt@bssr.mk";
            subject = "[TEST - IGNORE] " + subject;
            text = "[TEST - IGNORE] " + Environment.NewLine + text;
        }

        Cursor.Current = Cursors.WaitCursor;

        try
        {


            if (Mailto == "")
            {
                return false;
            }


            MailMessage msg = new MailMessage();
            msg.To.Add(Mailto);
            msg.IsBodyHtml = html;
            msg.From = new MailAddress(Mailfrom);
            msg.Subject = subject;
            msg.Body = text;
            if (attachment != "")
            {
                if (!attachment.Contains(";"))
                {
                    Attachment data = new Attachment(attachment);
                    msg.Attachments.Add(data);
                }
                else
                {
                    foreach (var item in attachment.Split(';'))
                    {
                        Attachment data = new Attachment(item);
                        msg.Attachments.Add(data);
                    }
                }
            }
            mySmtpClient().Send(msg);
            if (prikaziPoraka && PrazenStringToInt(BssBase.settings.GMailPrikaziPoraka, -1) == 1)
            {
                MessageBox.Show("Успешно испратено", "Е-маил пораката беше успешно испратена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UspesnoPrateno = true;
            Tools.LogWriteText($"Email praten - SendMailDefault - {Mailto}");
            return UspesnoPrateno;
        }
        catch (Exception ex)
        {
            UspesnoPrateno = false;
            Tools.LogWriteText($"Email neuspesen - SendMailDefault - {Mailto}");
            Tools.RaiseException(ex, false);
        }
        UspesnoPrateno = true;
        Cursor.Current = Cursors.Default;
        return UspesnoPrateno;
    }


    public static bool SendMailDefault(string attachment, string subject, string text, bool prikaziPoraka = true, string Mailfrom = "", string Mailto = "")
    {
        bool UspesnoPrateno = false;
        if (PrazenStringToInt(BssBase.settings.EnableMail, 0) != 1)
        {
            UspesnoPrateno = true;
            return UspesnoPrateno;
        }

        if (Debugger.IsAttached || BssBase.settings.AdminPcName == "TestSpiro")
        {
            Mailto = "spirodt@bssr.mk";
            subject = "[TEST - IGNORE] " + subject;
            text = "[TEST - IGNORE] " + Environment.NewLine + text;
        }

        Cursor.Current = Cursors.WaitCursor;

        try
        {
            if (Mailfrom == "")
            {
                Mailfrom = BssBase.settings.GMailFrom;
            }

            if (Mailto == "")
            {
                Mailto = BssBase.settings.GMailTo;
            }


            MailMessage msg = new MailMessage();
            msg.To.Add(Mailto);
            msg.From = new MailAddress(Mailfrom);
            msg.Subject = subject;
            msg.Body = text;
            if (attachment != "")
            {
                if (!attachment.Contains(";"))
                {
                    Attachment data = new Attachment(attachment);
                    msg.Attachments.Add(data);
                }
                else
                {
                    foreach (var item in attachment.Split(';'))
                    {
                        Attachment data = new Attachment(item);
                        msg.Attachments.Add(data);
                    }
                }
            }
            mySmtpClient().Send(msg);
            if (prikaziPoraka && PrazenStringToInt(BssBase.settings.GMailPrikaziPoraka, -1) == 1)
            {
                MessageBox.Show("Успешно испратено", "Е-маил пораката беше успешно испратена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UspesnoPrateno = true;
            Tools.LogWriteText($"Email praten - SendMailDefault - {Mailto}");
            return UspesnoPrateno;
        }
        catch (Exception ex)
        {
            UspesnoPrateno = false;
            Tools.LogWriteText($"Email neuspesen - SendMailDefault - {Mailto}");
            Tools.RaiseException(ex, false);
            MessageBox.Show("Не успешно испратено", "Е-маил пораката не е испратена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        UspesnoPrateno = true;
        Cursor.Current = Cursors.Default;
        return UspesnoPrateno;
    }

    public static string RemoveCharactersThatAreNotvalid(this string input)
    {
        Regex reg = new Regex("[*'\",_&#^@]");
        input = reg.Replace(input, string.Empty)
            .Replace(".", string.Empty)
            .Replace("w", "v")
            .Replace("y", "i")
            .Replace("ch", "c")
            .Replace("W", "V")
            .Replace("Y", "I")
            .Replace("CH", "C")
            .Replace("(", string.Empty)
            .Replace(")", string.Empty)
            .Replace(",", string.Empty).Trim();

        return input;
    }

    public static String ConvertToKirilica(String input)
    {
        try
        {
            var map = new Dictionary<char, char> { { 'A', 'А' }, { 'a', 'а' }, { 'B', 'Б' }, { 'b', 'б' }, { 'V', 'В' }, { 'v', 'в' }, { 'G', 'Г' }, { 'g', 'г' }, { 'D', 'Д' }, { 'd', 'д' }, { '\\', 'Ѓ' }, { '|', 'ѓ' }, { 'E', 'Е' }, { 'e', 'е' }, { '@', 'Ж' }, { '`', 'ж' }, { 'Z', 'З' }, { 'z', 'з' }, { 'Y', 'Ѕ' }, { 'y', 'ѕ' }, { 'I', 'И' }, { 'i', 'и' }, { 'J', 'Ј' }, { 'j', 'ј' }, { 'K', 'К' }, { 'k', 'к' }, { 'L', 'Л' }, { 'l', 'л' }, { 'Q', 'Љ' }, { 'q', 'љ' }, { 'M', 'М' }, { 'm', 'м' }, { 'N', 'Н' }, { 'n', 'н' }, { 'W', 'Њ' }, { 'w', 'њ' }, { 'O', 'О' }, { 'o', 'о' }, { 'P', 'П' }, { 'p', 'п' }, { 'R', 'Р' }, { 'r', 'р' }, { 'S', 'С' }, { 's', 'с' }, { 'T', 'Т' }, { 't', 'т' }, { '}', 'Ќ' }, { ']', 'ќ' }, { 'U', 'У' }, { 'u', 'у' }, { 'F', 'Ф' }, { 'f', 'ф' }, { 'H', 'Х' }, { 'h', 'х' }, { 'C', 'Ц' }, { 'c', 'ц' }, { '^', 'Ч' }, { '~', 'ч' }, { 'X', 'Џ' }, { 'x', 'џ' }, { '{', 'Ш' }, { '[', 'ш' } };
            return String.Concat(input.Select(c => (map.ContainsKey(c) ? map[c] : c)));
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
        }
        return input;
    }

    public static bool ValidacijaZaPrazni(GroupBox groupBox)
    {
        var imaCrveni = false;
        foreach (Control control in groupBox.Controls)
        {
            if (control is TextBox)
            {
                if (control.BackColor == Color.Tomato || control.BackColor == Color.Red)
                {
                    control.Select();
                    control.Focus();
                    imaCrveni = true;
                }
            }
        }

        return !imaCrveni;
    }

    public static bool ValidiRajGroupBox(GroupBox groupBox)
    {
        foreach (BssBase.txtBase control in groupBox.Controls.OfType<BssBase.txtBase>())
        {
            if (control.BackColor == Color.Tomato || control.BackColor == Color.Red)
            {
                control.Focus();
                return false;
            }
        }

        return true;
    }

    public static string Translate(String strIn, Control col)
    {
        var res = new ResourceManager(Application.ProductName + "Res.Resx", typeof(Control).Assembly);
        return res.GetString(strIn, Application.CurrentCulture);
    }

    public static string vratiFilterCelosenOD_DO_datum(DateTime OD, DateTime DO)
    {
        return String.Format("DatumDokument >= '{0:yyyy-MM-dd} 00:00:00' AND DatumDokument <= '{1:yyyy-MM-dd} 23:59:59'", konvertirajData(OD, true), konvertirajData(DO, false));
    }

    public static string vratiFilterCelosenOD_DO_datum(DateTime OD, DateTime DO, string poleDatum)
    {
        return String.Format(poleDatum + " >= '{0:yyyy-MM-dd} 00:00:00' AND " + poleDatum + "<= '{1:yyyy-MM-dd} 23:59:59'", konvertirajData(OD, true), konvertirajData(DO, false));
    }

    public static DateTime konvertirajData(DateTime data, bool pocetok = true)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("mk-MK");

        DateTime rezultat;
        if (pocetok == true)
        {
            rezultat = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
        }
        else
        {
            rezultat = new DateTime(data.Year, data.Month, data.Day, 23, 59, 59);
        }
        return rezultat;
    }

    public static int NajdiBankaZaZiroSmetkaID(int id)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(String.Format("select tblBankaID from tblZiroSmetki where ID = {0} ", id), con))
                {
                    con.Open();
                    var rezult = com.ExecuteReader(CommandBehavior.SingleResult);
                    rezult.Read();
                    if (rezult.HasRows)
                        if (!Equals(null, rezult))
                            return PrazenStringToInt(rezult["tblBankaID"].ToString(), -1);
                        else
                        {
                            return 0;
                        }
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
        }
        return 0;
    }

    public static int NajdiPartnerIDZaSmetka(int SmetkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(String.Format("select tblPartnerID from tblSmetka where ID = {0} ", SmetkaID), con))
                {
                    con.Open();
                    var rezult = com.ExecuteReader(CommandBehavior.SingleResult);
                    rezult.Read();
                    if (rezult.HasRows)
                        if (!Equals(null, rezult))
                            return PrazenStringToInt(rezult["tblPartnerID"].ToString(), -1);
                        else
                        {
                            return -1;
                        }
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
        }
        return 0;
    }


    public static int UpdateFaktura(int id, int broj, DateTime Datum, int partner, int ziroSmetka, int banka, DateTime valuta, string ispratnici, string zabeleska)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"UPDATE tblFaktura SET Broj = @Broj,Datum = @Datum,tblPartnerID = @tblPartnerID,tblZiroSmetkaID = @tblZiroSmetkaID,tblBankaID = @tblBankaID,tblUserID = @tblUserID,Valuta = @Valuta,Zabeleska=@Zabeleska,ListaNaIspratnici=@ListaNaIspratnici WHERE ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", id);
                    com.Parameters.AddWithValue("@Broj", broj);
                    com.Parameters.AddWithValue("@Datum", Datum);
                    com.Parameters.AddWithValue("@tblPartnerID", partner);
                    com.Parameters.AddWithValue("@Zabeleska", zabeleska);
                    com.Parameters.AddWithValue("@ListaNaIspratnici", ispratnici);
                    if (ziroSmetka != -1)
                        com.Parameters.AddWithValue("@tblZiroSmetkaID", ziroSmetka);
                    else
                        com.Parameters.AddWithValue("@tblZiroSmetkaID", DBNull.Value);
                    if (banka != -1)
                        com.Parameters.AddWithValue("@tblBankaID", banka);
                    else
                        com.Parameters.AddWithValue("@tblBankaID", DBNull.Value);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@Valuta", valuta);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int UpdatePriem(int PriemID, int Priembroj, DateTime PriemDatum, int partner, DateTime DatumIspratnicaFaktura, string IspratnicafakturaBroj, int valutaDenovi, int kalkulacijaBroj, string Zabeleska, DateTime DatumNaDospeanost, DateTime DatumNaKreiranje, decimal VkupenIznos)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@" UPDATE tblPriem SET PriemBroj = @PriemBroj,PriemDatum = @PriemDatum,
			tblPartnerID = @tblPartnerID,tblUserID = @tblUserID,ObjektID = @ObjektID,IspratnicaFakturaBroj = @IspratnicaFakturaBroj
			,IspratnicaFakturaDatum = @IspratnicaFakturaDatum,ValutaDenovi = @ValutaDenovi,KalkulacijaBroj = @KalkulacijaBroj,Zabeleska = @Zabeleska,
             VkupenIznos = @VkupenIznos, DatumNaDospeanost = @DatumNaDospeanost, DatumNaKreiranjeNaPriem = @DatumNaKreiranjeNaPriem
			 WHERE ID = @ID ", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", PriemID);
                    com.Parameters.AddWithValue("@PriemBroj", Priembroj);
                    com.Parameters.AddWithValue("@PriemDatum", PriemDatum);
                    com.Parameters.AddWithValue("@tblPartnerID", partner);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@ObjektID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@IspratnicaFakturaBroj", IspratnicafakturaBroj);
                    com.Parameters.AddWithValue("@IspratnicaFakturaDatum", DatumIspratnicaFaktura);
                    com.Parameters.AddWithValue("@ValutaDenovi", valutaDenovi);
                    com.Parameters.AddWithValue("@KalkulacijaBroj", kalkulacijaBroj);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@VkupenIznos", VkupenIznos);
                    com.Parameters.AddWithValue("@DatumNaDospeanost", DatumNaDospeanost);
                    com.Parameters.AddWithValue("@DatumNaKreiranjeNaPriem", DatumNaKreiranje);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int OznaciZavrsena(int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"update tblNaracki set Zavrsena = CASE WHEN Zavrsena = 'TRUE' THEN 'false' ELSE 'TRUE' END where ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int UpdateNotesZaDokument(string docId, string notes = null)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"update tblDokumenti set Notes=@Notes where ID = @ID", con))
                {

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", docId);
                    if (string.IsNullOrEmpty(notes))
                    {
                        com.Parameters.AddWithValue("@Notes", DBNull.Value);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@Notes", notes);
                    }

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }
    public static int DeleteStavkaOdDogovor(int StavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"Delete from tblDogovoriInfo where tblArtikalID = @tblArtikalID", con))
                {
                    com.Parameters.AddWithValue("@tblArtikalID", StavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int InsertirajStavkiVoDogovor(int dogovorID, int tblArtikalID,  decimal kolicina, decimal cena)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[tblDogovoriInfo]
                   ([tblDogovorId]
                   ,[tblArtikalID]
                   ,[Cena]
                   ,[Kolicina])
             VALUES
                  (@tblDogovorId, @tblArtikalID, @Cena,@Kolicina)", con))
                {

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblDogovorId", dogovorID);
                    com.Parameters.AddWithValue("@tblArtikalID", tblArtikalID);
                    com.Parameters.AddWithValue("@Cena", cena);
                    com.Parameters.AddWithValue("@Kolicina", kolicina);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int UpdateDogovorIdZaDokument(int docId,int tblDogovorID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"update tblDokumenti set tblDogovoriID=@tblDogovoriID where ID = @ID", con))
                {

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", docId);
                    com.Parameters.AddWithValue("@tblDogovoriID", tblDogovorID);
                    
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int IzbrisiStavkaPlacanje(int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"delete from tblPlacanjaOdPartner where ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int IzbrisiNaracka(int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"delete from tblNaracki where ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int IzbrisiStavkaOdPriem(int priem, int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"delete from tblPriemStavki where tblPriemID = @tblPriemID and ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblPriemID", priem);
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int SmeniTipNaDokumentZaDokumentBroj(int Broj, int tipNaDokumentSeKnizi, int tipNaDokumentNeSeKnizi)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(string.Format(@" DELETE from tblKnizenjeM where tblDokumentID = (Select ID from tblDokumenti where TipNaDokument = {1} AND Broj = @Broj)
                    update tblDokumenti set TipNaDokument = {0} where Broj = @Broj AND TipNaDokument = {1}", tipNaDokumentSeKnizi, tipNaDokumentNeSeKnizi), con))
                {
                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@Broj", Broj);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static DataTable StavkiOdFaktura(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblFakturaStavki where tblFakturaID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable NaloziStavkiOdSmetka(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select s.* from tblNalogStavki s left outer join tblNalog n on n.ID  = s.tblNalogID where n.SmetkaID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblNalogStavki");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static void UpdateSoftware(Utility.ModifyRegistry.ModifyRegistry RegistryData = null)
    {
        Tools.DownloadFile($"http://bssr.mk/bss/Installer/Setup%20Files/{Tools.base64ToText(BssBase.UpdateSettings.UpdateCode)}/BSS.exe",
            BssBase.UpdateSettings.UpdateDIR + "\\BSS.exe", false, true).ContinueWith((c) =>
            {
                if (RegistryData == null)
                {
                    RegistryData = new Utility.ModifyRegistry.ModifyRegistry();
                    RegistryData.SubKey = BssBase.settings.RegPath;
                }
                RegistryData.Write("VersionBeforeUpdate", Application.ProductVersion, false);
                RegistryData.Write("Version", "NOVA", false);
                Application.Exit();
            });
    }

    public static async Task DownloadFile(string fileLocation, string fileSaveLocation, bool showMessage, bool executeFile)
    {

        using (var client = new System.Net.Http.HttpClient()) // WebClient
        {
            var fileName = fileSaveLocation;
            var uri = new Uri(fileLocation);

            await client.DownloadFileTaskAsync(uri, fileName, showMessage, executeFile);
        }
    }


    public static DataTable FiskalnaOdSmetka(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblFiskalniSmetki where tblSmetkaID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblFiskalniSmetki");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable NaloziOdSmetka(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblNalog where SmetkaID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblNalog");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable StavkiOdSmetkaPrint(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@SmetkaID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("StavkiVoSmetka");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }


    public static DataTable StavkiOdSmetka(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblSmetkaStavki where tblSmetkaID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblSmetkaStavki");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable GetUpdatesForTableFromServer(string idsIn, string tableName)
    {
        try
        {

            using (var con = new SqlConnection(BssBase.settings.konekcija))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("GetUpdatesForTableFromServer", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@tablename", tableName);
                    com.Parameters.AddWithValue("@idsIn", idsIn);
                    DataTable db = new DataTable(tableName);
                    db.Load(com.ExecuteReader());
                    return db;
                }
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public static DataSet GetChangesFromTables(DateTime startDateTime, DateTime endDateTim)
    {
        try
        {

            using (var con = new SqlConnection(BssBase.settings.konekcija))
            {
                con.Open();

                using (SqlDataAdapter com = new SqlDataAdapter("GetAllDataForSmetkiFrom", con))
                {
                    com.SelectCommand.CommandType = CommandType.StoredProcedure;
                    com.SelectCommand.Parameters.AddWithValue("@Start", startDateTime);
                    com.SelectCommand.Parameters.AddWithValue("@End", endDateTim);
                    DataSet result = new DataSet();
                    com.Fill(result);
                    return result;
                }
            }


        }
        catch (Exception)
        {
            return null;
        }
    }
    public static DataTable GetDataversionFromDb(string tableName)
    {
        try
        {

            using (var con = new SqlConnection(BssBase.settings.konekcija))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(string.Format(@"getDataversionChanges"), con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@tableName", tableName);
                    DataTable db = new DataTable(tableName);
                    db.Load(com.ExecuteReader());
                    return db;
                }
            }

        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }
    }


    public static DataTable StavkiOdDokumenti(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblDokumentStavki where tblDokumentID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable StavkiOdPriem(int id)
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblPriemStavki where tblPriemID = @ID"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@ID", id);
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable ListaOdPriemiSoPrazenKod()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblPriem where KodNaDokument is null and ID in ( select tblPriemId from tblKnizenjeM where tipNaKnizenje = 3 )"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblPriem");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable ListaOdSmetkiSoPrazenKod()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblSmetka where KodNaDokument is null and ID in ( select tblSmetkaID from tblKnizenjeM)"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblSmetka");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable ListaOdNarackiSoPrazenKodINezavrseni()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblNaracki where KodNaDokument is null and Zavrsena = 'false'"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblNaracki");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable ListaOdDokumentiSoPrazenKod()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblDokumenti where KodNaDokument is null and ID in (select tblDokumentID from tblKnizenjeM )"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblDokumenti");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable ListaOdFakturiSoPrazenKod()
    {
        var con = new SqlConnection(BssBase.settings.konekcija);
        SqlCommand com;
        com = new SqlCommand(string.Format(@"select * from tblFaktura where KodNaDokument is null and ID in (select tblFakturaID from tblKnizenjeM where tipNaKnizenje = 2)"), con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                var dt = new DataTable("tblFaktura");
                dt.Load(reader);
                return dt;
            }
            con.Close();
        }
        catch (Exception ex)
        {
            LogWriteText("FUNCKCIJA ");
            LogWriteText(ex.Message);
            LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
            return null;
        }

        return null;
    }

    public static DataTable StavkiOdListaNaDokumenti(string BrojNaDokument)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {

            using (SqlCommand com = new SqlCommand(string.Format(@"select ArtikalID,SUM(Kolicina) as Kolicina, SUM(Iznos) as Iznos, isNormativ, SUM(Rabat1) as Rabat1, 0 as Rabat2, 0 as Rabat3 from viewDokumentiStavki
        where BrojNaDokument in ( {0} ) and TipNaDokumentID = {1}
        Group BY ArtikalID,isNormativ
        Having SUM(Kolicina) > 0 and SUM(Iznos) > 0", BrojNaDokument, BssBase.tmpConfigs.TipNaDokumentIdZaGeneriranjeNaIspratniceSeKnizi), con))
            {
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogWriteText("FUNCKCIJA ");
                    LogWriteText(ex.Message);
                    LogExceptionMessageWithScreenShoot(ex, ex.Message, false);
                    return null;
                }
            }
            return null;
        }
    }

    public static int IzbrisiStavkaOdDokument(int dokumentID, int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"delete from tblDokumentStavki where tblDokumentID = @tblDokumentID and ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblDokumentID", dokumentID);
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }
    public static int IzbrisiStavkaOdIzvod(int izvodID, int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"delete from tblIzvodiStavki where tblIzvodiID = @tblIzvodiID and ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblIzvodiID", izvodID);
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int IzbrisiStavkaOdFaktura(int fakturaID, int stavkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"delete from tblFakturaStavki where tblFakturaID = @tblFakturaID and ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblFakturaID", fakturaID);
                    com.Parameters.AddWithValue("@ID", stavkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }


    }

    public static int NajdiIDPartnerODFaktura(int fakturaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"select tblPartnerID from tblFaktura  where ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("ID", fakturaID);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int InsertirajStavkaVoFaktura(int fakturaID, int ArtikalID, decimal kolicina, decimal iznos, bool normativ, decimal rabat1 = 0, decimal rabat2 = 0, decimal rabat3 = 0)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblFakturaStavki (tblFakturaID ,tblArtikalID,Kolicina ,Iznos,Normativ,Rabat1,Rabat2,Rabat3) values (@tblFakturaID ,@tblArtikalID,@Kolicina ,@Iznos,@Normativ,@Rabat1,@Rabat2,@Rabat3); select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblFakturaID", fakturaID);
                    com.Parameters.AddWithValue("@tblArtikalID", ArtikalID);
                    com.Parameters.AddWithValue("@Kolicina", kolicina);
                    com.Parameters.AddWithValue("@Iznos", iznos);
                    com.Parameters.AddWithValue("@Normativ", normativ);
                    com.Parameters.AddWithValue("@Rabat1", rabat1);
                    com.Parameters.AddWithValue("@Rabat2", rabat2);
                    com.Parameters.AddWithValue("@Rabat3", rabat3);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static void zatvoriSmetka(int SmetkaID)
    {
        using (var con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (var com = new SqlCommand("Exec dbo.ZatvoriSmetka @SmetkID, @FirmaID, @SoPopust ,@Popust", con))
            {
                try
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@SmetkID", SmetkaID);
                    com.Parameters.AddWithValue("@SoPopust", 0);
                    com.Parameters.AddWithValue("@Popust", 0);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    PrevediSQLException(ex);
                    return;
                }
            }
        }
    }

    public static int InsertirajFiskalnaVoBaza(int Broj, DateTime Datum, decimal Iznos, bool Stornirana, int tblSmetkaID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (var com = new SqlCommand(@"INSERT INTO tblFiskalniSmetki (Broj ,Datum ,Iznos,Stornirana,tblSmetkaID,FirmaID)
						values((Select dbo.NaredenBrojNaFiskalna()) ,getDate() ,@Iznos,'false',@tblSmetkaID,@FirmaID) select SCOPE_IDENTITY() ", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", Broj);
                    com.Parameters.AddWithValue("@Datum", Datum);
                    com.Parameters.AddWithValue("@Iznos", Iznos);
                    com.Parameters.AddWithValue("@Stornirana", Stornirana);
                    com.Parameters.AddWithValue("@tblSmetkaID", tblSmetkaID);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int InsertirajStavkaNalog(int tblNalogID, int tblNomativID, int tblArtikalID, decimal Kolicina, decimal Rabat1, bool normativ)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = string.Empty;
                if (normativ)
                    sql = @"INSERT INTO tblNalogStavki (tblNalogID ,tblNomativID,Kolicina,Rabat1)
					values(@tblNalogID,@tblNomativID,@Kolicina,@Rabat1); select SCOPE_IDENTITY()";
                else
                    sql = @"INSERT INTO tblNalogStavki (tblNalogID ,tblArtikalID,Kolicina,Rabat1)
					values(@tblNalogID,@tblArtikalID,@Kolicina,@Rabat1); select SCOPE_IDENTITY()";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();

                    if (normativ)
                        com.Parameters.AddWithValue("@tblNomativID", tblNomativID);
                    else
                        com.Parameters.AddWithValue("@tblArtikalID", tblArtikalID);

                    com.Parameters.AddWithValue("@tblNalogID", tblNalogID);
                    com.Parameters.AddWithValue("@Kolicina", Kolicina);
                    com.Parameters.AddWithValue("@Rabat1", Rabat1);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int InsertirajStavkaVoIzvod(int tblIzvodiID, int PartnerID, decimal Dolzi, decimal Pobaruva, int TipNaDokument, int DokumentID, string BrojNaDokument)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = @"INSERT INTO tblIzvodiStavki (tblIzvodiID ,PartnerID ,Dolzi ,Pobaruva,DokumentID,FakturaID,PriemID,TipNaDokument,BrojNaDokument)
                            values (@tblIzvodiID ,@PartnerID ,@Dolzi ,@Pobaruva,@DokumentID,@FakturaID,@PriemID,@TipNaDokument,@BrojNaDokument); select SCOPE_IDENTITY()";


                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();

                    if (TipNaDokument == 9)
                    {

                        com.Parameters.AddWithValue("@DokumentID", DBNull.Value);
                        com.Parameters.AddWithValue("@PriemID", DBNull.Value);
                        com.Parameters.AddWithValue("@FakturaID", DokumentID);

                    }

                    if (TipNaDokument >= 10)
                    {

                        com.Parameters.AddWithValue("@DokumentID", DBNull.Value);
                        com.Parameters.AddWithValue("@PriemID", DokumentID);
                        com.Parameters.AddWithValue("@FakturaID", DBNull.Value);

                    }

                    if (TipNaDokument < 9)
                    {

                        com.Parameters.AddWithValue("@DokumentID", DokumentID);
                        com.Parameters.AddWithValue("@FakturaID", DBNull.Value);
                        com.Parameters.AddWithValue("@PriemID", DBNull.Value);
                    }

                    com.Parameters.AddWithValue("@tblIzvodiID", tblIzvodiID);
                    com.Parameters.AddWithValue("@PartnerID", PartnerID);
                    com.Parameters.AddWithValue("@Dolzi", Dolzi);
                    com.Parameters.AddWithValue("@Pobaruva", Pobaruva);
                    com.Parameters.AddWithValue("@TipNaDokument", TipNaDokument);
                    com.Parameters.AddWithValue("@BrojNaDokument", BrojNaDokument);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            MessageBox.Show(PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }

    public static int InsertirajDetailsHvac(int dokumentId, Unit unit, string note)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = @"INSERT INTO dbo.tblDokumentiDetailsInfoHvac
                           (tblDokumentId
                           ,Name
                           ,Capacity
                           ,LowRun
                           ,LowRunTotal
                           ,HighRun
                           ,HighRunTotal
                           ,Note
                           ,DateTimeCreated)
                     VALUES
                           (@tblDokumentId
                           ,@Name
                           ,@Capacity
                           ,@LowRun
                           ,@LowRunTotal
                           ,@HighRun
                           ,@HighRunTotal
                           ,@Note
                           ,@DateTimeCreated); ";



                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@tblDokumentId", dokumentId);
                    com.Parameters.AddWithValue("@Name", unit.Name);
                    com.Parameters.AddWithValue("@Capacity", unit.Capacity);
                    com.Parameters.AddWithValue("@LowRun", unit.LowRun);
                    com.Parameters.AddWithValue("@LowRunTotal", unit.LowRunTotal);
                    com.Parameters.AddWithValue("@HighRun", unit.HighRun);
                    com.Parameters.AddWithValue("@HighRunTotal", unit.HighRunTotal);
                    com.Parameters.AddWithValue("@Note", note);

                    com.Parameters.AddWithValue("@DateTimeCreated", DateTime.Now);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            MessageBox.Show(PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }

    public static int InsertirajtblDokumentiStavkiDetailsInfo(
        int dokumentId,
        int StavkaID,
        string NotesText,
        string NotesNumber,
        int NotesID = 0,
        int NotesRef = 0
        )
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = @"INSERT INTO [dbo].[tblDokumentStavkiDetailsInfo]
                   ([tblDokumentId]
                   ,[tblDokumentStavkiId]
                   ,[NotesText]
                   ,[NotesBroj]
                   ,[NotesID]
                   ,[NotesREF])
             VALUES
                   (@tblDokumentId
                   ,@tblDokumentStavkiId
                   ,@NotesText
                   ,@NotesBroj
                   ,@NotesID
                   ,@NotesREF); select SCOPE_IDENTITY() ";



                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@tblDokumentId", dokumentId);
                    com.Parameters.AddWithValue("@tblDokumentStavkiId", StavkaID);
                    com.Parameters.AddWithValue("@NotesText", NotesText);
                    com.Parameters.AddWithValue("@NotesBroj", NotesNumber);
                    com.Parameters.AddWithValue("@NotesID", NotesID);
                    com.Parameters.AddWithValue("@NotesREF", NotesRef);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            MessageBox.Show(PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }


    public static int InsertirajDetailsHvacVoda(int dokumentId, Tools.Partner partner)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = @"INSERT INTO [dbo].[tblDokumentiDetailsInfo]
                               ([tblDokumentId]
                               ,[WaterMeter]
                               ,[WaterMeterOld]
                               ,[WaterMeterNew]
                               ,[DateTimeCreated]) 
                         VALUES (@tblDokumentId
                                ,@WaterMeter
                                ,@WaterMeterOld
                                ,@WaterMeterNew
                                ,@DateTimeCreated); ";



                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@tblDokumentId", dokumentId);
                    com.Parameters.AddWithValue("@WaterMeter", partner.WaterMeter);
                    com.Parameters.AddWithValue("@WaterMeterOld", partner.WaterMeterOld);
                    com.Parameters.AddWithValue("@WaterMeterNew", partner.WaterMeterNew);
                    com.Parameters.AddWithValue("@DateTimeCreated", DateTime.Now);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            MessageBox.Show(PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }

    public static int InsertirajGeneralDokumentInfo(string mesec, string godina, GeneralData import)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = "DELETE FROM General_data_mesec where mesec=@mesec and Godina=@Godina;" +
                    "INSERT INTO General_data_mesec(mesec,supplier_total_bill,supplier_low_tariff_kwh,supplier_high_tariff_kwh," +
                    "lost_electricity_low_tariff,lost_electricity_high_tariff,warm_water_maintaining_fee,hidrokit_users,hidrokit_low_tariff_kwh," +
                    "hidrokit_high_tariff_kwh,total_warm_water_consumed,indoors_low_tariff_min,indoors_low_tariff_total_min,indoors_high_tariff_min," +
                    "indoors_high_tariff_total_min,warm_water_total_cost,warm_water_price,warm_water_heating_total_price,indoors_total_price,Godina) " +
                    "VALUES (@mesec,@supplier_total_bill,@supplier_low_tariff_kwh,@supplier_high_tariff_kwh,@lost_electricity_low_tariff,@lost_electricity_high_tariff," +
                    "@warm_water_maintaining_fee,@hidrokit_users,@hidrokit_low_tariff_kwh,@hidrokit_high_tariff_kwh,@total_warm_water_consumed,@indoors_low_tariff_min," +
                    "@indoors_low_tariff_total_min,@indoors_high_tariff_min,@indoors_high_tariff_total_min,@warm_water_total_cost,@warm_water_price,@warm_water_heating_total_price,@indoors_total_price,@Godina);";



                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@mesec", mesec);
                    com.Parameters.AddWithValue("@Godina", godina);
                    com.Parameters.AddWithValue("@supplier_total_bill", import.SupplierTotalBill);
                    com.Parameters.AddWithValue("@supplier_low_tariff_kwh", import.SupplierLowTariffKwh);
                    com.Parameters.AddWithValue("@supplier_high_tariff_kwh", import.SupplierHighTariffKwh);
                    com.Parameters.AddWithValue("@lost_electricity_low_tariff", import.LostElectricityLowTariff);
                    com.Parameters.AddWithValue("@lost_electricity_high_tariff", import.LostElectricityHighTariff);
                    com.Parameters.AddWithValue("@warm_water_maintaining_fee", import.WarmWaterMaintainingFee);
                    com.Parameters.AddWithValue("@hidrokit_users", import.HidrokitUsers);
                    com.Parameters.AddWithValue("@hidrokit_low_tariff_kwh", import.HidrokitLowTariffKwh);
                    com.Parameters.AddWithValue("@hidrokit_high_tariff_kwh", import.HidrokitHighTariffKwh);
                    com.Parameters.AddWithValue("@total_warm_water_consumed", import.TotalWarmWaterConsumed);
                    com.Parameters.AddWithValue("@indoors_low_tariff_min", import.IndoorsLowTariffMin);
                    com.Parameters.AddWithValue("@indoors_low_tariff_total_min", import.IndoorsLowTariffTotalMin);
                    com.Parameters.AddWithValue("@indoors_high_tariff_min", import.IndoorsHighTariffMin);
                    com.Parameters.AddWithValue("@indoors_high_tariff_total_min", import.IndoorsHighTariffTotalMin);
                    com.Parameters.AddWithValue("@warm_water_total_cost", import.WarmWaterTotalCost);
                    com.Parameters.AddWithValue("@warm_water_price", import.WarmWaterPrice);
                    com.Parameters.AddWithValue("@warm_water_heating_total_price", import.WarmWaterHeatingTotalPrice);
                    com.Parameters.AddWithValue("@indoors_total_price", import.IndoorsTotalPrice);



                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            MessageBox.Show(PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }
    public static int InsertirajStavkaVoDokumenti(int dokumentID, int ArtikalID, decimal kolicina, decimal NabavnaCenaSoDDV, decimal Iznos, bool normativ, decimal rabat1 = 0)
    {
        try
        {
            if ((BssBase.settings.TipNaPrograma != "10KulaB"))
            {
                if (kolicina == 0 || NabavnaCenaSoDDV == 0 | Iznos == 0)
                {
                    MessageBox.Show("Количината, износот и цената мора да бидат поголеми од 0 ");
                    return -1;
                }
            }
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                string sql = string.Empty;
                if (normativ)
                    sql = @"INSERT INTO tblDokumentStavki (tblDokumentID,tblNormativID,Cena,Kolicina,Iznos,Rabat1) values(@tblDokumentID,@tblNormativID,@Cena,@Kolicina,@Iznos,@Rabat1); select SCOPE_IDENTITY()";
                else
                    sql = @"INSERT INTO tblDokumentStavki (tblDokumentID,tblArtikalID,Cena,Kolicina,Iznos,Rabat1) values(@tblDokumentID,@tblArtikalID,@Cena,@Kolicina,@Iznos,@Rabat1); select SCOPE_IDENTITY()";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblDokumentID", dokumentID);
                    if (normativ)
                        com.Parameters.AddWithValue("@tblNormativID", ArtikalID);
                    else
                        com.Parameters.AddWithValue("@tblArtikalID", ArtikalID);

                    com.Parameters.AddWithValue("@Kolicina", kolicina);
                    com.Parameters.AddWithValue("@Cena", NabavnaCenaSoDDV);
                    com.Parameters.AddWithValue("@Rabat1", rabat1);
                    com.Parameters.AddWithValue("@Iznos", Iznos);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            MessageBox.Show(PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }

    public static int insertirajNarackaVoTabela(int NarackaBroj, string Opis, DateTime DatumNaNaracka, string Ime, string Kontakt, string OdObjekt, bool Zavrsena)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblNaracki(NarackaBroj,Opis,DatumNaNaracka,Ime,Kontakt,OdObjekt,Zavrsena)
			    values(@NarackaBroj,@Opis,@DatumNaNaracka,@Ime,@Kontakt,@OdObjekt,@Zavrsena);select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@NarackaBroj", NarackaBroj);
                    com.Parameters.AddWithValue("@Opis", Opis);
                    com.Parameters.AddWithValue("@DatumNaNaracka", DatumNaNaracka);
                    com.Parameters.AddWithValue("@Ime", Ime);
                    com.Parameters.AddWithValue("@Kontakt", Kontakt);
                    com.Parameters.AddWithValue("@OdObjekt", OdObjekt);
                    com.Parameters.AddWithValue("@Zavrsena", Zavrsena);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int insertirajPlacanjeVoTabela(int tblPartnerID, decimal Iznos, DateTime DatumNaUplata, string DokumentBroj, string IzvodBroj, string Zabeleska, bool naplataIsplata)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblPlacanjaOdPartner (tblPartnerID,Iznos,DatumNaUplata,DokumentBroj,IzvodBroj,Zabeleska,UplataIsplata)
                                                    values(@tblPartnerID,@Iznos,@DatumNaUplata,@DokumentBroj,@IzvodBroj,@Zabeleska,@UplataIsplata);select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblPartnerID", tblPartnerID);
                    com.Parameters.AddWithValue("@Iznos", Iznos);
                    com.Parameters.AddWithValue("@DatumNaUplata", DatumNaUplata);
                    com.Parameters.AddWithValue("@DokumentBroj", DokumentBroj);
                    com.Parameters.AddWithValue("@IzvodBroj", IzvodBroj);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@UplataIsplata", naplataIsplata);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int InsertirajStavkaVoPriem(int fakturaID, int ArtikalID, decimal kolicina, decimal NabavnaCenaBezDDV, decimal NabavnaCenaSoDDV, decimal rabat1 = 0, decimal rabat2 = 0, decimal rabat3 = 0)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblPriemStavki (tblPriemID ,tblArtikalID,Kolicina ,NabavnaCenaBezDDV,NabavnaCenaSoDDV,Rabat1,Rabat2,Rabat3) values (@tblPriemID ,@tblArtikalID, @Kolicina ,@NabavnaCenaBezDDV,@NabavnaCenaSoDDV,@Rabat1,@Rabat2,@Rabat3); select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@tblPriemID", fakturaID);
                    com.Parameters.AddWithValue("@tblArtikalID", ArtikalID);
                    com.Parameters.AddWithValue("@Kolicina", kolicina);
                    com.Parameters.AddWithValue("@NabavnaCenaBezDDV", NabavnaCenaBezDDV);
                    com.Parameters.AddWithValue("@NabavnaCenaSoDDV", NabavnaCenaSoDDV);
                    com.Parameters.AddWithValue("@Rabat1", rabat1);
                    com.Parameters.AddWithValue("@Rabat2", rabat2);
                    com.Parameters.AddWithValue("@Rabat3", rabat3);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int KreirajSmetkaMNet(int Broj, DateTime DatumPocetok, int tblUserID, int Smena_ID, bool Zatvorena, int ObjektID, string Zabeleska, int ImaPopust, decimal ProcentNaPopust, int Izmeneta, int tblPartnerID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(
                        @"INSERT INTO tblSmetka (Broj,DatumPocetok,tblUserID,Smena_ID,Zatvorena,FirmaID,ObjektID,Zabeleska,ImaPopust,ProcentNaPopust,Izmeneta,tblPartnerID)
                                          values(@Broj,@DatumPocetok,@tblUserID,@Smena_ID,@Zatvorena,@FirmaID,@ObjektID,@Zabeleska,@ImaPopust,@ProcentNaPopust,@Izmeneta,@tblPartnerID); select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", Broj);
                    com.Parameters.AddWithValue("@DatumPocetok", DatumPocetok);
                    com.Parameters.AddWithValue("@Smena_ID", Smena_ID);
                    com.Parameters.AddWithValue("@Zatvorena", Zatvorena);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@ObjektID", ObjektID);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@ImaPopust", ImaPopust);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@ProcentNaPopust", ProcentNaPopust);
                    com.Parameters.AddWithValue("@Izmeneta", Izmeneta);
                    com.Parameters.AddWithValue("@tblPartnerID", tblPartnerID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }


    public static int KreirajDokumentOdSmetka(int SmetkaId, int tipNaDokumentId)
    {
        using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
        {
            using (SqlCommand com = new SqlCommand(@"KreirajDokumentZaSmetkaID", con))
            {
                com.Parameters.Clear();
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SmetkaId", SmetkaId);
                com.Parameters.AddWithValue("@tipNaDokumentId", tipNaDokumentId);
                return com.ExecuteNonQuery();
            }
        }
    }
    public static int KreirajSmetka(int Broj, DateTime DatumPocetok, DateTime DatumKraj, int tblUserID, int Smena_ID, bool Zatvorena, int ObjektID, string Zabeleska, int ImaPopust, decimal ProcentNaPopust, int Izmeneta, int tblPartnerID)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblSmetka (Broj,DatumPocetok,DatumKraj,tblUserID,Smena_ID,Zatvorena,FirmaID,ObjektID,Zabeleska,ImaPopust,ProcentNaPopust,Izmeneta,tblPartnerID)
                                                                values(@Broj,@DatumPocetok,@DatumKraj,@tblUserID,@Smena_ID,@Zatvorena,@FirmaID,@ObjektID,@Zabeleska,@ImaPopust,@ProcentNaPopust,@Izmeneta,@tblPartnerID); select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", Broj);
                    com.Parameters.AddWithValue("@DatumPocetok", DatumPocetok);
                    com.Parameters.AddWithValue("@DatumKraj", DatumKraj);
                    com.Parameters.AddWithValue("@Smena_ID", Smena_ID);
                    com.Parameters.AddWithValue("@Zatvorena", Zatvorena);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@ObjektID", ObjektID);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@ImaPopust", ImaPopust);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@ProcentNaPopust", ProcentNaPopust);
                    com.Parameters.AddWithValue("@Izmeneta", Izmeneta);
                    com.Parameters.AddWithValue("@tblPartnerID", tblPartnerID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int KreirajNalog(int Broj, string Zabeleska, DateTime DatumPocetok, DateTime DatumKraj, int Smena_ID, int TipNaNalog, int SmetkaID, bool Zavrsen)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblNalog (Broj,Zabeleska,DatumPocetok,DatumKraj,FirmaID,Smena_ID,Zavrsen,TipNaNalog,SmetkaID)
                                               values (@Broj,@Zabeleska,@DatumPocetok,@DatumKraj,@FirmaID,@Smena_ID,@Zavrsen,@TipNaNalog,@SmetkaID); select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", Broj);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@DatumPocetok", DatumPocetok);
                    com.Parameters.AddWithValue("@DatumKraj", DatumKraj);
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    com.Parameters.AddWithValue("@Smena_ID", Smena_ID);
                    com.Parameters.AddWithValue("@Zavrsen", Zavrsen);
                    com.Parameters.AddWithValue("@TipNaNalog", TipNaNalog);
                    com.Parameters.AddWithValue("@SmetkaID", SmetkaID);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    //UpdateIzvod

    public static int UpdateIzvod(int IzvodID, int BrojNaIzvod, DateTime DatumNaIzvod, string Smetka, string Zabeleska)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"UPDATE tblIzvodi SET BrojNaIzvod = @BrojNaIzvod ,Zabeleska = @Zabeleska,Smetka = @Smetka,DatumNaIzvod = @DatumNaIzvod WHERE ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@BrojNaIzvod", BrojNaIzvod);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@Smetka", Smetka);
                    com.Parameters.AddWithValue("@DatumNaIzvod", DatumNaIzvod);
                    com.Parameters.AddWithValue("@ID", IzvodID);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето");
            return -1;
        }
    }

    public static int KreirajIzvod(int BrojNaIzvod, DateTime DatumNaIzvod, string Smetka, string Zabeleska)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblIzvodi (BrojNaIzvod,Zabeleska,Smetka,DatumNaIzvod) VALUES (@BrojNaIzvod,@Zabeleska,@Smetka,@DatumNaIzvod) select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@BrojNaIzvod", BrojNaIzvod);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@Smetka", Smetka);
                    com.Parameters.AddWithValue("@DatumNaIzvod", DatumNaIzvod);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }


    public static int KreirajDokument(int DokumentBroj, DateTime DokumentDatum, int TipNaDokument, int OdObjekt, object doObjekt, string Zabeleska, object partnerID, string BrojNaDokument, DateTime DatumValuta, DateTime DatumPeriod, string partner = null)
    {
        try
        {
            string KodNaDokument = Guid.NewGuid().ToString();
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                if (String.IsNullOrEmpty(BrojNaDokument)) BrojNaDokument = DokumentBroj.ToString();
                if (String.IsNullOrEmpty(partner)) partner = BrojNaDokument;

                var BrojNaDokumentPartner = (TipNaDokument + "-" + DatumPeriod.ToString("MMyy").ToString() + "-" + partner.Split('-').Last());

                string uniqueKod = KodNaDokument.Substring(0, 4);
                if (BssBase.settings.TipNaPrograma == "10KulaB")
                {
                    uniqueKod = KodNaDokument.ToUpper().Substring(0, 4) + ((BrojNaDokumentPartner.Length >= 7) ? BrojNaDokumentPartner.Substring(7, 3) : string.Empty);
                }
                if (BrojNaDokument.Length < 1)
                {
                    BrojNaDokument = BrojNaDokumentPartner;
                }

                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblDokumenti (UniqueIdPlacanje,Broj,TipNaDokument,Datum,OdObjektID,DoObjektID,tblUserID,Zabeleska,tblPartnerID,FirmaID,BrojNaDokument,KodNaDokument,DatumNaValuta,DatumPeriod)
				   values(@UniqueIdPlacanje,@Broj,@TipNaDokument,@Datum,@OdObjektID,@DoObjektID,@tblUserID,@Zabeleska,@tblPartnerID,@FirmaID,@BrojNaDokument, @KodNaDokument,@DatumValuta,@DatumPeriod) select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@Broj", DokumentBroj);
                    com.Parameters.AddWithValue("@TipNaDokument", TipNaDokument);
                    com.Parameters.AddWithValue("@Datum", DokumentDatum);
                    com.Parameters.AddWithValue("@OdObjektID", OdObjekt);
                    com.Parameters.AddWithValue("@DoObjektID", doObjekt);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@BrojNaDokument", BrojNaDokument);
                    com.Parameters.AddWithValue("@KodNaDokument", KodNaDokument);
                    com.Parameters.AddWithValue("@DatumValuta", DatumValuta);
                    com.Parameters.AddWithValue("@DatumPeriod", DatumPeriod);
                    com.Parameters.AddWithValue("@UniqueIdPlacanje", uniqueKod.ToUpper());
                    if (string.IsNullOrEmpty(partnerID.ToString()))
                        com.Parameters.AddWithValue("@tblPartnerID", DBNull.Value);
                    else
                        com.Parameters.AddWithValue("@tblPartnerID", PrazenStringToInt(partnerID.ToString()));
                    com.Parameters.AddWithValue("@FirmaID", BssBase.settings.firmaId);
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int UpateDokument(int dokumentID, int DokumentBroj, DateTime DokumentDatum, int TipNaDokument, int OdObjekt, object doObjekt, string Zabeleska, object partnerID, string BrojNaDokument, DateTime DatumValuta, DateTime DatumPeriod)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"UPDATE tblDokumenti SET Broj = @Broj ,
TipNaDokument = @TipNaDokument,Datum = @Datum,OdObjektID = @OdObjektID,DoObjektID = @DoObjektID,tblUserID = @tblUserID,Zabeleska = @Zabeleska, tblPartnerID=@tblPartnerID,
BrojNaDokument=@BrojNaDokument,DatumNaValuta=@DatumValuta,DatumPeriod=@DatumPeriod
 WHERE ID = @ID", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ID", dokumentID);
                    com.Parameters.AddWithValue("@Broj", DokumentBroj);
                    com.Parameters.AddWithValue("@TipNaDokument", TipNaDokument);
                    com.Parameters.AddWithValue("@Datum", DokumentDatum);
                    com.Parameters.AddWithValue("@OdObjektID", OdObjekt);
                    com.Parameters.AddWithValue("@DoObjektID", doObjekt);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@BrojNaDokument", BrojNaDokument);
                    com.Parameters.AddWithValue("@DatumValuta", DatumValuta);
                    com.Parameters.AddWithValue("@DatumPeriod", DatumPeriod);

                    if (string.IsNullOrEmpty(partnerID.ToString()))
                        com.Parameters.AddWithValue("@tblPartnerID", DBNull.Value);
                    else
                        com.Parameters.AddWithValue("@tblPartnerID", PrazenStringToInt(partnerID.ToString()));

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            PrevediPoraka("Внесот не беше успешен, артиклот или заглавјето не е правилно пополнето");
            return -1;
        }
    }

    public static int KreirajPriem(int Priembroj, DateTime PriemDatum, int partner, DateTime DatumIspratnicaFaktura, string IspratnicafakturaBroj, int valutaDenovi, int kalkulacijaBroj, string Zabeleska, DateTime DatumNaDospeanost, DateTime DatumNaKreiranje, decimal VkupenIznos = 0)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblPriem(PriemBroj,PriemDatum,tblPartnerID,tblUserID,ObjektID,IspratnicaFakturaBroj,IspratnicaFakturaDatum,ValutaDenovi,KalkulacijaBroj,Zabeleska,VkupenIznos,DatumNaDospeanost,DatumNaKreiranjeNaPriem)
             Values(@PriemBroj,@PriemDatum,@tblPartnerID,@tblUserID,@ObjektID,@IspratnicaFakturaBroj,@IspratnicaFakturaDatum,@ValutaDenovi,@KalkulacijaBroj,@Zabeleska,@VkupenIznos,@DatumNaDospeanost,@DatumNaKreiranjeNaPriem) select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@PriemBroj", Priembroj);
                    com.Parameters.AddWithValue("@PriemDatum", PriemDatum);
                    com.Parameters.AddWithValue("@tblPartnerID", partner);
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@ObjektID", BssBase.settings.MomentalenObjektID);
                    com.Parameters.AddWithValue("@IspratnicaFakturaBroj", IspratnicafakturaBroj);
                    com.Parameters.AddWithValue("@IspratnicaFakturaDatum", DatumIspratnicaFaktura);
                    com.Parameters.AddWithValue("@ValutaDenovi", valutaDenovi);
                    com.Parameters.AddWithValue("@KalkulacijaBroj", kalkulacijaBroj);
                    com.Parameters.AddWithValue("@Zabeleska", Zabeleska);
                    com.Parameters.AddWithValue("@VkupenIznos", VkupenIznos);
                    com.Parameters.AddWithValue("@DatumNaDospeanost", DatumNaDospeanost);
                    com.Parameters.AddWithValue("@DatumNaKreiranjeNaPriem", DatumNaKreiranje);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static int KreirajFaktura(int broj, DateTime Datum, int partner, int ziroSmetka, int banka, DateTime valuta, string ispratnici, string zabeleska)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"INSERT INTO tblFaktura (Broj,Datum,tblPartnerID,tblZiroSmetkaID,tblBankaID,tblUserID,Valuta,Zabeleska,ListaNaIspratnici)
					VALUES (@Broj,@Datum,@tblPartnerID,@tblZiroSmetkaID,@tblBankaID,@tblUserID,@Valuta,@Zabeleska,@ListaNaIspratnici); select SCOPE_IDENTITY()", con))
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Broj", broj);
                    com.Parameters.AddWithValue("@Datum", Datum);
                    com.Parameters.AddWithValue("@tblPartnerID", partner);
                    com.Parameters.AddWithValue("@Zabeleska", zabeleska);
                    com.Parameters.AddWithValue("@ListaNaIspratnici", ispratnici);
                    if (ziroSmetka != -1)
                    {
                        com.Parameters.AddWithValue("@tblZiroSmetkaID", ziroSmetka);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@tblZiroSmetkaID", DBNull.Value);
                    }
                    if (banka != -1)
                    {
                        com.Parameters.AddWithValue("@tblBankaID", banka);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@tblBankaID", DBNull.Value);
                    }
                    com.Parameters.AddWithValue("@tblUserID", BssBase.settings.UserId);
                    com.Parameters.AddWithValue("@Valuta", valuta);

                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteScalar().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }
    }

    public static object NajdiPrvRekordUtabela(string pole, string tabela)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(String.Format("Select TOP 1 * from {1} Order by 1 asc", pole, tabela), con))
                {
                    con.Open();
                    var rezult = com.ExecuteReader(CommandBehavior.SingleResult);
                    rezult.Read();
                    if (rezult.HasRows)
                    {
                        if (!Equals(null, rezult))
                        {
                            return rezult[pole];
                        }
                        return null;
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
        }
        return null;
    }

    public static int NajdiNaredenBrojUTabela(string pole, string tabela)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(String.Format("Select TOP 1{0} from {1} Order by 1 desc", pole, tabela), con))
                {
                    con.Open();
                    var rezult = com.ExecuteReader(CommandBehavior.SingleResult);
                    rezult.Read();
                    if (rezult.HasRows)
                        if (!Equals(null, rezult))
                        {
                            int rez = 0;
                            rez = PrazenStringToInt(rezult[pole].ToString(), 0) + 1;
                            if (rez == 0) rez = 1;
                            return rez;
                        }
                        else
                        {
                            return 1;
                        }
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
        }
        return 1;
    }

    public static int NajdiNaredenBrojUTabela(string pole, string tabela, string filter)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(String.Format("Select TOP 1{0} from {1} where {2} Order by 1 desc", pole, tabela, filter), con))
                {
                    con.Open();
                    var rezult = com.ExecuteReader(CommandBehavior.SingleResult);
                    rezult.Read();
                    if (rezult.HasRows)
                        if (!Equals(null, rezult))
                            return PrazenStringToInt(rezult[pole].ToString(), -1) + 1;
                        else
                        {
                            return 0;
                        }
                }
            }
        }
        catch (SqlException)
        {
            //tools.PrevediSQLException(ex);
            return 0;
        }
        return 0;
    }

    public static bool DaliPostoiZapis(string tabela, string pole, string vrednost, bool imaFirmaID = true)
    {
        var kon = new SqlConnection(BssBase.settings.konekcija);
        var sql = "SELECT * FROM " + tabela + " WHERE " + pole + " = '" + vrednost + "'";
        if (imaFirmaID)
        {
            sql = sql + " AND FirmaID = " + BssBase.settings.firmaId;
        }
        var komanda = new SqlCommand(sql, kon);
        kon.Open();
        var citac = komanda.ExecuteReader();
        return citac.HasRows;
    }

    public static bool DaliEBlokiran(string tabela, string pole, string vrednost, int status, bool imaFirmaID = true)
    {
        var kon = new SqlConnection(BssBase.settings.konekcija);
        var sql = "SELECT * FROM " + tabela + " WHERE Status  = " + status + " AND " + pole + "=" + vrednost + " ";
        if (imaFirmaID)
        {
            sql = sql + " AND FirmaID = " + BssBase.settings.firmaId;
        }
        var komanda = new SqlCommand(sql, kon);
        kon.Open();
        var citac = komanda.ExecuteReader();
        return citac.HasRows;
    }

    public static int UpdateDokumentBroj()
    {
        try
        {
            using (SqlConnection con = new SqlConnection(BssBase.settings.konekcija))
            {
                using (SqlCommand com = new SqlCommand(@"DECLARE @counterF int
                    SET @counterF = 0
                UPDATE tblDokumenti
                SET @counterF = Broj = @counterF + 1", con))
                {
                    con.Open();
                    int rez = PrazenStringToInt(com.ExecuteNonQuery().ToString(), -1);
                    con.Close();
                    return rez;
                }
            }
        }
        catch (SqlException ex)
        {
            PrevediSQLException(ex);
            return -1;
        }

    }

    public static async Task<string> GetValueFromWebAsync(string requestUrl)
    {
        using (var client = new System.Net.Http.HttpClient()) // WebClient
        {
            return await client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync();
        }
    }

    public static object GetValueFromWeb(string requestUrl)
    {
        using (var client = new System.Net.Http.HttpClient()) // WebClient
        {
            return client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync().Result;
        }
    }
}

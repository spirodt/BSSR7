using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static Tools;
using DunaComputers.Fiscal.Razvigorec.DunaComputers.Fiscal.Razvigorec;
using System.Text.RegularExpressions;
using BssBase.Functions.Helpers;
using MFiskalna.Fiskalna;
using System.Data;
using System.Threading;

public class FiscalCash
{
    #region Variables
    clsRazvigorec FiskalenAparat;
    bool sy55 = false;
    public bool simulate = false;
    bool david = false;
    bool initialized = false;
    private readonly string ComPort;
    private readonly int IntComport;


    int broj = 33;





    IList<byte> opcodes = new List<byte>();
    StringBuilder FileIn = new StringBuilder(255);
    StringBuilder FileOut = new StringBuilder(255);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    private static extern int GetShortPathName(
             [MarshalAs(UnmanagedType.LPTStr)]
                   string path,
             [MarshalAs(UnmanagedType.LPTStr)]
                   StringBuilder shortPath,
             int shortPathLength
    );

    #endregion Variables

    #region Private Functions

    private bool _simulateUnitTest = false;

    private byte[] InitRawCommand(string command)
    {
        if (FiskalnaRazvigorec)
        {
            return null;
        }

        if (!FiskalnaSeverec)
        {
            CheckInterfaceInit();

            AppendStringToOpcodes(command);
        }

        byte[] returnVal = null;
        if (FiskalnaSeverec)
        {

            var strImeNaFajl = command;
            returnVal = StartProcessAndWait(_simulateUnitTest, strImeNaFajl);
        }
        else
            returnVal = StartProcessAndWait(_simulateUnitTest);

        try
        {
            CloseInterface();
        }
        catch (Exception ex)
        {
            Tools.LogException(ex.Message, ex);
        }

        return returnVal;
    }

    private byte[] StartProcessAndWait(bool simulacijaZaTest = false, string ImeNaFajl = "")
    {
        if (FiskalnaRazvigorec)
        {
            return null;
        }
        if (!Directory.Exists(@"C:\FISKAL\")) Directory.CreateDirectory(@"C:\FISKAL");
        var datetimeTicks = DateTime.Now.Ticks.ToString("N0");
        var guid = Guid.NewGuid();

        File.Delete(@"C:\FISKAL\in.log");

        using (StreamWriter wr = new StreamWriter(FileIn.ToString(), false, Encoding.Default))
        {
            var str = Encoding.Default.GetString(opcodes.ToArray());
            wr.WriteLine(str);
        }

        if (BssBase.settings.DebugFiskalna)
        {
            if (!Directory.Exists(@"C:\FISKAL\SMLIN")) Directory.CreateDirectory(@"C:\FISKAL\SMLIN");
            if (!Directory.Exists(@"C:\FISKAL\SMLOUT")) Directory.CreateDirectory(@"C:\FISKAL\SMLOUT");

           
            
            File.Copy(FileIn.ToString(), string.Format(@"C:\FISKAL\SMLIN\{1}_in_{0}_{2}.log", guid, datetimeTicks, smetkaKomandaNaziv));
        }

        File.Copy(FileIn.ToString(), @"C:\FISKAL\in.log");

        try
        {
            Process process = new Process();

            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            if (FiskalnaSeverec)
            {
                process.StartInfo.FileName = @"C:\Program Files (x86)\Viking Smetka POS\\Viking Smetka.exe";
                if (File.Exists($"C:\\Program Files (x86)\\Viking Smetka POS\\{ImeNaFajl}")) { File.Delete($"C:\\Program Files (x86)\\Viking Smetka POS\\{ImeNaFajl}"); }
                File.Copy(FileIn.ToString(), $"C:\\Program Files (x86)\\Viking Smetka POS\\{ImeNaFajl}");

            }

            if (sy55)
            {
                process.StartInfo.FileName = "ecrprint.exe";
                process.StartInfo.Arguments = String.Format("{0}", FileIn);
            }

            if (david)
            {

                process.StartInfo.FileName = "DAVID32.EXE";
                process.StartInfo.Arguments = String.Format("{0}", FileIn);
                if (!File.Exists("DAVID32.EXE"))
                {
                    process.StartInfo.FileName = "DAVID32Novo.EXE";
                }
            }

            if (!sy55 && !david && !FiskalnaSeverec)
            {
                process.StartInfo.FileName = "Fiscal32.exe";
                process.StartInfo.Arguments = String.Format("{0}", FileIn);
            }

            if (simulate)
            {
                process.StartInfo.FileName = "Fiscal32_SM.exe";
                process.StartInfo.Arguments = String.Format("{0}", FileIn);
            }

            if (!simulacijaZaTest)
            {
                process.Start();
                process.WaitForExit();
            }
            if (BssBase.settings.DebugFiskalna)
            {
                if (!Directory.Exists(@"C:\FISKAL\SMLOUT")) Directory.CreateDirectory(@"C:\FISKAL\SMLOUT");
                File.Copy(FileOut.ToString(), string.Format(@"C:\FISKAL\SMLOUT\{1}_in_{0}_{2}.log", guid, datetimeTicks, smetkaKomandaNaziv));
            }

            File.Delete(@"C:\FISKAL\OUT.log");
            File.Copy(FileOut.ToString(), @"C:\FISKAL\OUT.log");
            return File.ReadAllBytes(FileOut.ToString());
        }
        catch (Exception ex)
        {
            File.Copy(FileOut.ToString(), string.Format(@"C:\FISKAL\SMLOUT\{1}_in_{0}EE{2}.log", guid, datetimeTicks, smetkaKomandaNaziv));
            Tools.LogException("Problem So fiskalna", ex);
            Tools.LogExceptionMessageWithScreenShoot(ex, "Problem so fiskalna", true);
            return null;
        }
    }
    decimal iZnosNaFiskalnata = 0;
    private void CheckInterfaceInit()
    {
        if (FiskalnaRazvigorec)
        {
            return;
        }

        if (FiskalnaSeverec)
        {
            return;
        }

    }



    private void AppendStringToOpcodes(string opcode)
    {
        byte[] tmp = Encoding.Default.GetBytes(opcode);
        //byte[] tmp = Encoding.ASCII.GetBytes(opcode);
        for (int i = 0; i < opcode.Length; i++)
            opcodes.Add(tmp[i]);
    }

    #endregion Private Functions

    #region Public Functions

    ~FiscalCash()
    {
        try
        {

            CloseInterface();
        }
        catch (Exception ex)
        {
            Tools.LogException(ex.Message, ex);
        }
    }

    public List<Stavka> Smetka;
    private bool FiskalnaRazvigorec = false;
    private bool FiskalnaSeverec = false;

    public FiscalCash(int comport)
    {
        broj = 33;
        IntComport = Tools.PrazenStringToInt(BssBase.settings.COMPortZaFiskalna, 1);
        ComPort = "COM" + comport.ToString();
        simulate = true;
        david = false;
        sy55 = false;
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
        Thread.CurrentThread.CurrentCulture = new CultureInfo("mk-MK");

    }

    private string smetkaKomandaNaziv;

    public FiscalCash(string brojNaSmetka = "SM_C", bool SimulateUnitTest = false)
    {
        _simulateUnitTest = SimulateUnitTest;
        smetkaKomandaNaziv = brojNaSmetka;
        broj = 33;
        IntComport = Tools.PrazenStringToInt(BssBase.settings.COMPortZaFiskalna, 1);
        ComPort = "COM" + Tools.PrazenStringToInt(BssBase.settings.COMPortZaFiskalna, 1);
        if (!string.IsNullOrEmpty(BssBase.settings.TipNaFiskalna))
        {
            if (BssBase.settings.TipNaFiskalna == "Razvigorec")
            {
                FiskalnaRazvigorec = true;

            }
            if (BssBase.settings.TipNaFiskalna == "Severec")
            {
                FiskalnaSeverec = true;

            }
            if (BssBase.settings.TipNaFiskalna == "SY55")
            {
                sy55 = true;

            }

            if (BssBase.settings.TipNaFiskalna == "David")
            {
                david = true;
            }

            if (BssBase.settings.TipNaFiskalna == "Simulate")
            {
                david = false;
                sy55 = false;
                simulate = true;
                FiskalnaRazvigorec = false;
                FiskalnaSeverec = false;
            }
        }
    }

    public void SetirajHeaderPf550(string[] liniI)
    {
        if (!sy55 && !david && !FiskalnaSeverec)
        {

            for (int i = 0; i < 4; i++)
            {
                AppendStringToOpcodes(string.Format(" +{0}{1} \r\n", i, liniI[i]));
            }
            StartProcessAndWait();

        }
    }

    public void PrintFreeText(string text)
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.PrintNonFiscalText(text);
        }
    }

    public void InitInterface()
    {

        Smetka = new List<Stavka>();
        initialized = true;
        if (FiskalnaRazvigorec && !_simulateUnitTest)
        {
            FiskalenAparat = new clsRazvigorec(int.Parse(BssBase.settings.COMPortZaFiskalna));


        }
        else
        {

            GetShortPathName(@Path.GetTempFileName(), FileIn, FileIn.Capacity);
            GetShortPathName(@Path.GetTempFileName(), FileOut, FileOut.Capacity);
        }
    }

    public void CloseInterface()
    {
        if (FiskalnaSeverec) return;

        if (FiskalnaRazvigorec)
        {
            Smetka.Clear();
            FiskalenAparat = null;
            return;
        }

        initialized = false;
        opcodes.Clear();


        File.Delete(FileOut.ToString());
        File.Delete(FileIn.ToString());
        iZnosNaFiskalnata = 0;
    }

    public byte[] IssueBill(bool voGotovo)
    {
        if (FiskalnaSeverec) return InitRawCommand("smetka.txt");


        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.FiskalnaSmetka(Smetka.ToArray(), clsRazvigorec.PaymentType.VoGotovo, false);
            return null;
        }

        if (voGotovo)
        {
            if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(" 5\t\r\n%8");
            if (david) return InitRawCommand("&5\t\r\n'8");
            if (sy55) return InitRawCommand("&50\t\t\r\n%8");
        }
        else
        {
            if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(" 5\tD" + iZnosNaFiskalnata.ToString("N2") + "\r\n%8");
            if (david) return InitRawCommand("&5\tD\r\n'8");
            if (sy55) return InitRawCommand("&50\tD\t\r\n%8");
        }

        return null;
    }

    public byte[] IssueStorno()
    {
        if (FiskalnaSeverec) return InitRawCommand("storno.txt");

        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.StornaSmetka(Smetka.ToArray(), clsRazvigorec.PaymentType.VoGotovo);

            return null;
        }
        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(" 5\t\r\n%8");
        if (david) return InitRawCommand("&5\t\r\n'8");
        if (sy55) return InitRawCommand("&5\t\t\r\n%8");

        return null;
    }

    public byte[] DailyFiscalClose()
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.ZatvoriDen();
            return null;
        }

        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(" E\r\n");
        if (david) return InitRawCommand("-E1");
        if (sy55) return InitRawCommand("*EZ\t");

        return null;
    }

    public byte[] DailyMoneyOutput(int amount)
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.CacheOut(Tools.PrazenStringToDecimal_dec(amount.ToString()), clsRazvigorec.PaymentType.VoGotovo);
            return null;
        }


        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(string.Format(" F{0}\r\n", amount));
        if (david) return InitRawCommand(string.Format(" F{0}\r\n", amount));
        if (sy55) return InitRawCommand(string.Format(")F1\t{0}\r\n", amount));


        return null;

    }

    public byte[] DailyMoneyInput(int amount)
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.CacheIn(Tools.PrazenStringToDecimal_dec(amount.ToString()), clsRazvigorec.PaymentType.VoGotovo);
            return null;
        }


        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(string.Format("(F{0}", amount.ToString("N2")));
        if (david) return InitRawCommand(string.Format(" F{0}\r\n", amount));
        if (sy55) return InitRawCommand(string.Format("(F0\t{0}\t", amount.ToString("N2")));


        return null;

    }

    public byte[] DailyFiscalWithoutClose()
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.Izvestaj_X();
            return null;
        }
        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(" E2\r\n");
        if (david) return InitRawCommand(".E3");
        if (sy55) return InitRawCommand("'EX\t");

        return null;

    }

    public byte[] GetTimeDate()
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.GetDeviceDateTime();
            return null;
        }
        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(" >\r\n");
        if (david) return InitRawCommand(" >\r\n");
        if (sy55) return InitRawCommand(" >\r\n");
        return null;

    }

    public byte[] SetTimeDate(string time)
    {
        if (FiskalnaRazvigorec)
        {
            FiskalenAparat.GetDeviceDateTime();
            return null;
        }
        if (!sy55 && !david && !FiskalnaSeverec) return InitRawCommand(String.Format(" ={0}\r\n", time));
        if (david) return InitRawCommand(String.Format(" ={0}\r\n", time));
        if (sy55) return InitRawCommand(String.Format(" ={0}\r\n", time));
        return null;


    }

    public void IzvestajZaPeriodRazvigorec(DateTime timeStart, DateTime timeEnd, bool skraten)
    {
        timeStart = new DateTime(timeStart.Year, timeStart.Month, timeStart.Day, 0, 0, 0);
        timeEnd = new DateTime(timeEnd.Year, timeEnd.Month, timeEnd.Day, 23, 59, 59);
        if (FiskalnaRazvigorec)
        {
            if (skraten)
            {
                FiskalenAparat.Izvestaj_Periodicen(timeStart, timeEnd);
            }
            else
            {
                FiskalenAparat.Izvestaj_PeriodicenDetalen(timeStart, timeEnd);
            }

        }

    }

    public void IzvestajZaPeriodDavid(DateTime timeStart, DateTime timeEnd, bool skraten)
    {
        var mtimeStart = new DateTime(timeStart.Year, timeStart.Month, timeStart.Day, 0, 0, 0).ToString("ddMMyy", CultureInfo.InvariantCulture);
        var mtimeEnd = new DateTime(timeEnd.Year, timeEnd.Month, timeEnd.Day, 23, 59, 59).ToString("ddMMyy", CultureInfo.InvariantCulture);

        if (david)
        {
            if (skraten)
            {
                InitRawCommand(".O\t" + mtimeStart + "," + mtimeEnd);
            }
            else
            {
                InitRawCommand(".^\t" + mtimeStart + "," + mtimeEnd);
            }

        }


    }

    public byte[] DetailedReport(string timeStart, string timeEnd)
    {
        return InitRawCommand(String.Format(" ^{0},{1}\r\n", timeStart, timeEnd));
    }

    public byte[] ShortReport(string timeStart, string timeEnd)
    {
        return InitRawCommand(String.Format(" O{0},{1}\r\n", timeStart, timeEnd));
    }

    public void ArtikliZaNaFiskalna(bool storno, DataTable artikliZaFiskalna)
    {
        foreach (DataRow Produkt in artikliZaFiskalna.Rows)
        {
            if (!storno)
                AddProduct(Produkt.ConvertDataRowToFiscalProduct());
            else
                AddProductStorno(Produkt.ConvertDataRowToFiscalProduct());
        }
    }
    public void AddProduct(FiscalProduct itemProduct)
    {

        broj = broj + 1;
        if (FiskalnaSeverec)
        {
            AppendStringToOpcodes(itemProduct.ConvertLineToSeverec());
            return;
        }
        string RedenKarakter = Convert.ToChar(broj).ToString();
        if (FiskalnaRazvigorec)
        {
            Stavka artikal = new Stavka
            {
                Artikal = itemProduct.Artikal,
                Kolicina = itemProduct.Kolicina,
                Cena = itemProduct.Cena
            };
            if (itemProduct.DDVGrupa == 192)
                artikal.DDV = clsRazvigorec.VATgroup.A;
            if (itemProduct.DDVGrupa == 193)
                artikal.DDV = clsRazvigorec.VATgroup.B;
            if (itemProduct.DDVGrupa == 194)
                artikal.DDV = clsRazvigorec.VATgroup.C;

            if (itemProduct.MkProizvod == true)
                artikal.MakedonskiProizvod = clsRazvigorec.MacedonianProduct.Yes;
            else
                artikal.MakedonskiProizvod = clsRazvigorec.MacedonianProduct.No;

            artikal.MineralnoMaslo = clsRazvigorec.MineralOil.No;

            Smetka.Add(artikal);

            return;
        }

        CheckInterfaceInit();
        if (opcodes.Count == 0)
        {
            if (!sy55 && !david && !FiskalnaSeverec)
            {
                AppendStringToOpcodes(" 01,0000,1\r\n");
            }

            if (david)
            {
                AppendStringToOpcodes("'8\r\n 01,0001,1\r\n");
            }

            if (sy55)
            {
                AppendStringToOpcodes(" 01\t1\t\t0\t\r\n");
            }
        }
        if (!sy55 && !david && !FiskalnaSeverec)
        {
            if (itemProduct.MkProizvod == true)
                AppendStringToOpcodes(String.Format("{1}1{0}\t@", itemProduct.Artikal, RedenKarakter));
            else
                AppendStringToOpcodes(String.Format("{1}1{0}\t", itemProduct.Artikal, RedenKarakter));
            opcodes.Add(itemProduct.DDVGrupa);

            AppendStringToOpcodes(String.Format("{0}*{1}\r\n", itemProduct.Cena.ToString("N2"), itemProduct.Kolicina.ToString("N3")).Replace(",", "."));
        }

        if (david)
        {
            string ddv = "А";
            if (itemProduct.MkProizvod == true)
            {
                if (itemProduct.DDVGrupa == 192) ddv = "А";
                if (itemProduct.DDVGrupa == 193) ddv = "Б";
                if (itemProduct.DDVGrupa == 194) ddv = "В";
                if (itemProduct.DDVGrupa == 195) ddv = "Г";
            }
            if (itemProduct.MkProizvod == false)
            {
                if (itemProduct.DDVGrupa == 192) ddv = "A";
                if (itemProduct.DDVGrupa == 193) ddv = "B";
                if (itemProduct.DDVGrupa == 194) ddv = "C";
                if (itemProduct.DDVGrupa == 195) ddv = "D";
            }

            AppendStringToOpcodes(String.Format("{1}1{0}\n\t" + ddv, itemProduct.Artikal, RedenKarakter));

            AppendStringToOpcodes(String.Format("{0}*{1}\r\n", itemProduct.Cena.ToString("F", CultureInfo.InvariantCulture), itemProduct.Kolicina.ToString("F3", CultureInfo.InvariantCulture)));
        }

        if (sy55)
        {
            string ddv = "1";

            if (itemProduct.DDVGrupa == 192) ddv = "1";
            if (itemProduct.DDVGrupa == 193) ddv = "2";
            if (itemProduct.DDVGrupa == 194) ddv = "3";
            if (itemProduct.DDVGrupa == 195) ddv = "4";

            AppendStringToOpcodes(String.Format("{1}1{0}\t" + ddv + "\t", Tools.ConvertToKirilica(itemProduct.Artikal.ToUpper()), RedenKarakter));

            int mkProi = 0;
            if (itemProduct.MkProizvod) mkProi = 1;

            AppendStringToOpcodes(String.Format("{0}\t{1}\t{2}\t\t\t\r\n", ((int)itemProduct.Cena).ToString("N2"), itemProduct.Kolicina.ToString("N3"), mkProi).Replace(",", "."));
        }
        iZnosNaFiskalnata += (itemProduct.Cena * itemProduct.Kolicina);
    }


    public void AddProductStorno(FiscalProduct itemProduct)
    {
        broj = broj + 1;

        if (FiskalnaSeverec)
        {
            AppendStringToOpcodes(itemProduct.ConvertLineToSeverec());
            return;
        }
        string RedenKarakter = Convert.ToChar(broj).ToString();

        if (FiskalnaRazvigorec)
        {
            Stavka artikal = new Stavka
            {
                Artikal = itemProduct.Artikal,
                Kolicina = itemProduct.Kolicina,
                Cena = itemProduct.Cena
            };
            if (itemProduct.DDVGrupa == 192)
                artikal.DDV = clsRazvigorec.VATgroup.A;
            if (itemProduct.DDVGrupa == 193)
                artikal.DDV = clsRazvigorec.VATgroup.B;
            if (itemProduct.DDVGrupa == 194)
                artikal.DDV = clsRazvigorec.VATgroup.C;

            if (itemProduct.MkProizvod)
                artikal.MakedonskiProizvod = clsRazvigorec.MacedonianProduct.Yes;
            else
                artikal.MakedonskiProizvod = clsRazvigorec.MacedonianProduct.No;

            artikal.MineralnoMaslo = clsRazvigorec.MineralOil.No;

            Smetka.Add(artikal);

            return;
        }

        CheckInterfaceInit();

        if (opcodes.Count == 0)
        {
            if (!sy55 && !david && !FiskalnaSeverec)
            {
                AppendStringToOpcodes(" U1,0000,1\r\n");
            }

            if (david)
            {
                AppendStringToOpcodes("'8\r\n 01,'0001,1,R'\r\n");
            }

            if (sy55)
            {
                AppendStringToOpcodes(" 01\t1\t\t0\t\r\n");
            }
        }

        if (!sy55 && !david && !FiskalnaSeverec)
        {
            if (itemProduct.MkProizvod == true)
                AppendStringToOpcodes(String.Format("{1}1{0}\t@", itemProduct.Artikal, RedenKarakter));
            else
                AppendStringToOpcodes(String.Format("{1}1{0}\t", itemProduct.Artikal, RedenKarakter));
            opcodes.Add(itemProduct.DDVGrupa);

            AppendStringToOpcodes(String.Format("{0}*{1}\r\n", ((int)itemProduct.Cena).ToString(), itemProduct.Kolicina.ToString("N3")).Replace(",", "."));
        }

        if (david)
        {
            string ddv = "А";
            if (itemProduct.MkProizvod)
            {
                if (itemProduct.DDVGrupa == 192) ddv = "А";
                if (itemProduct.DDVGrupa == 193) ddv = "Б";
                if (itemProduct.DDVGrupa == 194) ddv = "В";
                if (itemProduct.DDVGrupa == 195) ddv = "Г";

            }
            if (!itemProduct.MkProizvod)
            {
                if (itemProduct.DDVGrupa == 192) ddv = "A";
                if (itemProduct.DDVGrupa == 193) ddv = "B";
                if (itemProduct.DDVGrupa == 194) ddv = "C";
                if (itemProduct.DDVGrupa == 195) ddv = "D";
            }

            AppendStringToOpcodes(String.Format("{1}1{0}\n\t" + ddv, itemProduct.Artikal, RedenKarakter));

            AppendStringToOpcodes(String.Format("{0}*{1}\r\n", itemProduct.Cena.ToString("F", CultureInfo.InvariantCulture), itemProduct.Kolicina.ToString("F3", CultureInfo.InvariantCulture)));
        }

        if (sy55)
        {
            string ddv = "1";

            if (itemProduct.DDVGrupa == 192) ddv = "1";
            if (itemProduct.DDVGrupa == 193) ddv = "2";
            if (itemProduct.DDVGrupa == 194) ddv = "3";
            if (itemProduct.DDVGrupa == 195) ddv = "4";

            AppendStringToOpcodes(String.Format("{1}1{0}\t" + ddv + "\t", itemProduct.Artikal.ToUpper().Replace("И", "N").Replace("Ј", "!"), RedenKarakter));

            int mkProi = 0;
            if (itemProduct.MkProizvod) mkProi = 1;

            AppendStringToOpcodes(String.Format("{0}\t{1}\t{2}\t\r\n", ((int)itemProduct.Cena).ToString(), itemProduct.Kolicina.ToString("N3"), mkProi).Replace(",", "."));
        }

        iZnosNaFiskalnata += (itemProduct.Cena * itemProduct.Kolicina);
    }



    #endregion Public Functions
}
using Newtonsoft.Json;

using NLog;

using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

public static partial class Tools
{
    private static Logger _toolslogger = LogManager.GetCurrentClassLogger();
    
    public static string ToJson(this object value)
    {
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        return JsonConvert.SerializeObject(value, Formatting.Indented, settings);
    }

    public static void LogDebug(string message)
    {
        _toolslogger.Debug(message);
    }
    public static void LogObjectInfo(string messagge, object objToWrite ,[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
    {
        var objParametars = new
        {
            Message = messagge,
            MemberName = memberName,
            SourceFilePath = sourceFilePath,
            SourceLineNumber = sourceLineNumber,
            objectToDisplay = objToWrite.ToJson()
        };
        _toolslogger.Debug(messagge + " : " + objParametars.objectToDisplay);
    }
    public static void RaiseException(Exception ex, bool showMessage = false, string customErrorMEssage = "", [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0,bool logException = true)
    {
        var objParametars = new
        {
            Exception = ex,
            InnerException = ex.InnerException,
            Message = string.IsNullOrEmpty(customErrorMEssage) ? ex.Message : customErrorMEssage,
            MemberName = memberName,
            SourceFilePath = sourceFilePath,
            SourceLineNumber = sourceLineNumber
        };
        if (showMessage)
        {
            MessageBox.Show(customErrorMEssage, PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
        if (logException)
        {
            LogExceptionWithParameters("EXCEPTION : " + memberName, ex, objParametars);
        }

    }
    public static bool PrevediSQLException(SqlException ex, string CustromMessage = "", [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
    {
        var objParametars = new
        {
            Exception = ex,
            InnerException = ex.InnerException,
            Message = string.IsNullOrEmpty(CustromMessage) ? ex.Message : CustromMessage,
            MemberName = memberName,
            SourceFilePath = sourceFilePath,
            SourceLineNumber = sourceLineNumber
        };

        LogExceptionWithParameters("EXCEPTION : " + memberName, ex, objParametars);
        var ImeNaException = ex.Message;

        if (ImeNaException.ToUpper().Contains("duplicate key".ToUpper()))
        {
            MessageBox.Show(PrevediPoraka("duplicate key"), PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return true;
        }

        if (ImeNaException.ToUpper().Contains("out of range".ToUpper()))
        {
            MessageBox.Show(PrevediPoraka("VrednostNedozvolena"), PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return true;
        }

        if (ImeNaException.ToUpper().Contains("DELETE") && ImeNaException.ToUpper().Contains("REFERENCE"))
        {
            MessageBox.Show(PrevediPoraka("deleteReference"), PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return true;
        }

        if (ImeNaException.ToUpper().Contains("K#G"))
        {
            var pozicija = ImeNaException.IndexOf("K#G") + 3;
            var text = ex.Message.Substring(pozicija, pozicija + 3).Trim();
            MessageBox.Show(PrevediPoraka(text.ToUpper().Substring(0, 3) + "EXCEPTION"), PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return true;
        }

        if (ImeNaException.Contains("K#"))
        {
            var pos1 = ImeNaException.IndexOf("K#") + 2;
            var pos2 = ImeNaException.IndexOf("K#", pos1) + 3;
            var myCapturedText = ex.Message.Substring(pos1, pos2 - pos1).Trim();
            MessageBox.Show(PrevediPoraka("K#" + myCapturedText), PrevediPoraka("Greska!!!"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
        else
        {
            MessageBox.Show(PrevediPoraka(ImeNaException), "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
        return true;
    }
    public static void LogException(string message, Exception ex, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
      [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
      [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
    {
        var objParametars = new
        {
            Exception = ex,
            ex.InnerException,
            ex.Message,
            MemberName = memberName,
            SourceFilePath = sourceFilePath,
            SourceLineNumber = sourceLineNumber
        };

        LogExceptionWithParameters("EXCEPTION : " + memberName, ex, objParametars);
        _toolslogger.Fatal(ex, ex.Message, null);
    }

    public static void LogExceptionMessageWithScreenShoot(Exception ex, string message, bool showMessagebox = false, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
      [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
      [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0, bool LogToMail = true)
    {
        var information = new
        {
            Message = message,
            MemberName = memberName,
            SourceFilePath = sourceFilePath,
            SourceLineNumber = sourceLineNumber
        };

        var info = $"{Application.ProductVersion} : Exception was thrown from -> Line Number {information.SourceLineNumber} in {information.SourceFilePath} " + Environment.NewLine;

        var date = DateTime.Now.ToUniversalTime().ToString();
        var er = $"{date}  = EXCEPTION_GRESKA : {message} {Environment.NewLine} {ex.StackTrace} {Environment.NewLine} {ex.Source} {Environment.NewLine} {ex.InnerException} ".ToString();
        er += Environment.NewLine;
        er += info;

        _toolslogger.Error(er);
        _toolslogger.Info(info);

        _toolslogger.Error( date + " START ERROR " + DateTime.Now.ToUniversalTime().ToString());
        _toolslogger.Error(er);
        _toolslogger.Error(date + " END ERROR");
        WriteLog(er);
        bool emailResult = false;
        if (BssBase.settings.ExceptionToMail.ToUpper() == "TRUE" && LogToMail)
        {
            String Message = string.Format(" Exception : {0} ", er);
            string attachment = Tools.CaptureScreenOnException(string.Format("Exceptions\\{0}_Exception.jpg", DateTime.Now.ToBinary()));
            string Naziv = string.Format("{0} {1} {2}", BssBase.settings.FirmaNaziv, BssBase.settings.TipNaPrograma, BssBase.tmpConfigs.LogiranUserFullName);
            emailResult =  Tools.SendMailWithBssrMK(attachment, Naziv, Message, sendCCtoBssr:true);
            _toolslogger.Info($"{Application.ProductVersion} : Mail was sent to the app server");
            //if (emailResult) System.IO.File.Delete(attachment);
        }
        
        if (showMessagebox) MessageBox.Show(message);
        
    }

    public static void LogExceptionWithParameters(string message, Exception ex, dynamic information)
    {
        _toolslogger.Error(message, ex, information);
        _toolslogger.Info($"{Application.ProductVersion} : Exception was thrown from -> Line Number {information.SourceLineNumber} in {information.SourceFilePath} " + Environment.NewLine);
        _toolslogger.Debug(ex);
    }

    public static void LogWriteText(string message)
    {
        _toolslogger.Info(message);
    }

    public static void SetLogger(Logger logger)
    {
        _toolslogger = logger;
    }
}
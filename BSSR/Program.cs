using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using NLog;
using BssBase;

namespace BSSR
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                if (File.Exists("lock"))
            {
                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)

                {
                    MessageBox.Show("Апликацијата е веќе активна");
                    return;
                }
            }

                BssBase.settings.CultureInfoString = "mk-MK";
                Application.CurrentCulture = Tools.GetSystemGlobalizationCulture();

                // Add the event handler for handling UI thread exceptions to the event.
                Application.ThreadException += Application_ThreadException;

                // Set the unhandled exception mode to force all Windows Forms errors
                // to go through our handler.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

                // Add the event handler for handling non-UI thread exceptions to the event. 
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;


                //LoadAllBinDirectoryAssemblies();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();


                var firmaID = 1;

                string registri = string.Empty;
                if (args.Any())
                {
                    registri = args.FirstOrDefault();
                }
                
               

                if(Debugger.IsAttached && string.IsNullOrEmpty(registri))
                {
                    registri = "BSSR4";
                }
                
                BssBase.settings.RegPath = registri;

                if (string.IsNullOrEmpty(registri))
                {
                    Tools.RaiseException(new Exception("Wrong config"),true,"Nepravilno instalirana applikacija");
                    Tools.LogWriteText("Application faild to started at wrong config: " + DateTime.Now);
                    var inputBox = InputBox.Show("Vnesete lozinka za setup", true);
                    if (inputBox.Text == "7625")
                    {
                        Tools.LogWriteText("Application started at : " + DateTime.Now);
                        Application.Run(new frmMainLogin("NewSetup", firmaID));
                        Tools.LogWriteText("Application Ended at : " + DateTime.Now);

                    } else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Tools.LogWriteText("Application started at : " + DateTime.Now);
                    Application.Run(new frmMainLogin(registri, firmaID));
                    Tools.LogWriteText("Application Ended at : " + DateTime.Now);
                }
                
            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, true);

            }
        }

      
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (!AppDomain.CurrentDomain.FriendlyName.EndsWith("vshost.exe"))
            {
                String Message = string.Format(string.Format(" Exception : {{0}} {0} InnerException : {{1}}{0} Source : {{2}} {0} Stack trace: {{3}}", Environment.NewLine), e.Exception.Message, e.Exception.InnerException, e.Exception.Source, e.Exception.StackTrace);
                string attachment = Tools.CaptureScreenOnException(string.Format("{0}_Exception.jpg", DateTime.Now.ToBinary()));
                if (BssBase.settings.ExceptionToMail.ToUpper() == "TRUE")
                {
                    string Naziv = string.Format("{0} {1} {2}", BssBase.settings.FirmaNaziv, BssBase.settings.TipNaPrograma, BssBase.tmpConfigs.LogiranUserFullName);
                    Tools.SendMailWithBssrMK(attachment, Naziv, Message, sendCCtoBssr:true);
                }
                Tools.LogException(e.ToString(), e.Exception);
                Tools.LogWriteText("Application faild  at wrong exception (closing app): " + DateTime.Now);
                //Application.Exit();
            }
            
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs ex)
        {
             if (!AppDomain.CurrentDomain.FriendlyName.EndsWith("vshost.exe")) {
                if (BssBase.settings.ExceptionToMail.ToUpper() == "TRUE")
                {
                    Exception e = ex.ExceptionObject as Exception;
                    
                    String Message = string.Format(string.Format(" Exception : {{0}} {0} InnerException : {{1}}{0} Source : {{2}} {0} Stack trace: {{3}}", Environment.NewLine), e.Message, e.InnerException, e.Source, e.StackTrace);

                    string attachment = Tools.CaptureScreenOnException(string.Format("{0}_Exception.jpg", DateTime.Now.ToBinary()));
                    MessageBox.Show(((Exception)ex.ExceptionObject).Message);
                
                     string Naziv = string.Format("{0} {1} {2}", BssBase.settings.FirmaNaziv, BssBase.settings.TipNaPrograma, BssBase.tmpConfigs.LogiranUserFullName);
                    Tools.LogWriteText("Application faild  at wrong exception (closing app): " + DateTime.Now);
                    Tools.SendMailWithBssrMK(attachment, Naziv, Message, sendCCtoBssr: true);
                    Application.Exit();
                }
                Tools.LogException(ex.ToString(), (Exception)ex.ExceptionObject);
             }
            
        }
    }
}
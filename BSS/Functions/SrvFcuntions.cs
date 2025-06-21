using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using AsyncClientServerLib.Client;
using AsyncClientServerLib.Message;

namespace Functions
{
    public  class SrvFcuntions 
    {
        private BasicSocketClient client = null;
        private Guid clientGuid = Guid.Empty;
        public bool simulation;
        public SrvFcuntions(bool simulate = false)
        {
            simulation = simulate;
        }

        public bool PratiKomanda(string hostName, int port, string command, string ImeNaFile, DateTime datumNaPracanje , bool showMessage = true)
        {
            if (simulation) return true;
            try
            {
                clientGuid = Guid.NewGuid();
                client = new BasicSocketClient();
                client.ReceiveMessageEvent += new SocketServerLib.SocketHandler.ReceiveMessageDelegate(client_ReceiveMessageEvent);
                client.ConnectionEvent += new SocketServerLib.SocketHandler.SocketConnectionDelegate(client_ConnectionEvent);
                client.CloseConnectionEvent += new SocketServerLib.SocketHandler.SocketConnectionDelegate(client_CloseConnectionEvent);
                IPHostEntry h = new IPHostEntry();
                h = Dns.GetHostEntry(hostName);

                IPEndPoint endpoint = new IPEndPoint(h.AddressList.Last(), port);
                
                client.Connect(endpoint);

                byte[] buffer = System.Text.Encoding.Unicode.GetBytes(command);
                BasicMessage message = new BasicMessage(clientGuid, buffer);

                client.SendAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                if(showMessage)
                    MessageBox.Show(string.Format("Client failed to connect remote server.\n{0}", ex.Message), "Socket Client", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void client_CloseConnectionEvent(SocketServerLib.SocketHandler.AbstractTcpSocketClientHandler handler)
        {
           //  MessageBox.Show(string.Format("Client disconnected from remote server."), "Socket Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void client_ConnectionEvent(SocketServerLib.SocketHandler.AbstractTcpSocketClientHandler handler)
        {
           // MessageBox.Show(string.Format("Client connected to remote server."), "Socket Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void client_ReceiveMessageEvent(SocketServerLib.SocketHandler.AbstractTcpSocketClientHandler handler, SocketServerLib.Message.AbstractMessage message)
        {
            BasicMessage receivedMessage = (BasicMessage)message;
            byte[] buffer = receivedMessage.GetBuffer();
            string s = System.Text.Encoding.Unicode.GetString(buffer);
            MessageBox.Show(s);
        }

        public static void ObrabotiKomanda(string command)
        {
            string fileName = @"ElektronskoPracanje\Primeni\" + DateTime.Now.ToShortDateString().Replace(",","_").Replace(".","_") + ".xml";
            if (File.Exists(fileName))
                File.Delete(fileName);

            File.WriteAllText("tmp.xml", command);
            MessageBox.Show("FaljotEPrimen");
        }

        public static void PrepratiNeprateni(string command, string cmbServer)
        {
            string server = string.Empty;

            if (string.IsNullOrEmpty(cmbServer))
                server = cmbServer.Split('\\').FirstOrDefault();
            else
                server = cmbServer;

            var files = Directory.GetFiles(Application.StartupPath + @"\ElektronskoPracanje\Neuspesni\"+ server  );
            foreach (var item in files)
            {
                FileInfo f = new FileInfo(item);

                 SrvFcuntions s = new SrvFcuntions();
                 string xml = File.ReadAllText(f.FullName);
                 if (s.PratiKomanda(command.Split(':').LastOrDefault(), 8100, "docPresnocnica:" + xml, f.Name, DateTime.Now))
                 {
                     if(File.Exists(f.FullName))
                     File.Delete(f.FullName);
                 }
                   
            }

            
        }

        public static void ObrabotiKomanda(string command, string TipNaDokument )
        {
            
            string fileName = @"ElektronskoPracanje\Primeni\" + TipNaDokument + "_" + DateTime.Now.ToShortDateString().Replace(",", "_").Replace(".", "_") + ".xml";
            if (File.Exists(fileName))
                File.Delete(fileName);

            File.WriteAllText(fileName, command);
        }
    }
}
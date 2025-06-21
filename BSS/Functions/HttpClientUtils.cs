using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpHelpers
{

    public static class HttpClientUtils
    {
        public static async Task DownloadFileTaskAsync(this HttpClient client, Uri uri, string FileName, bool showMessage, bool executeFile)
        {
            if(File.Exists(FileName)) File.Delete(FileName);

            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs).ContinueWith((C) => {
                        if (showMessage)
                        {
                            MessageBox.Show("Done downloading");
                        }
                    }); ;
                }
            }
            if (executeFile)
            {
                Process.Start(FileName);
            }
        }
    }
}

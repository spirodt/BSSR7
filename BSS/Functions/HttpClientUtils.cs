using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpHelpers
{

    public static class HttpClientUtils
    {
        public static List<string> ListAllFilesInWebDirectory(this HttpClient client, string url, string localPath)
        {
            List<string> results = new List<string>();
            var html = client.GetStringAsync(url).Result;

            // Simple regex to find hrefs in HTML pointing to files
            var matches = Regex.Matches(html, @"<a\s+(?:[^>]*?\s+)?href\s*=\s*[""']([^""'#>]+)[""']", RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                string href = match.Groups[1].Value;

                // Filter out parent links and folders
                if (href == "../" || href.EndsWith("/"))
                    continue;

                string fullUrl = url.EndsWith("/") ? url + href : url + "/" + href;
                Console.WriteLine($"Found file: {fullUrl}");
                results.Add(fullUrl);
                
            }

            return results;
        }

        public static async Task DownloadFileTaskAsync(this HttpClient client, Uri uri, string FileName, bool showMessage, bool executeFile)
        {
            if (File.Exists(FileName)) File.Delete(FileName);

            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs).ContinueWith((C) =>
                    {
                        if (showMessage)
                        {
                            MessageBox.Show("Done downloading");
                        }
                    });
                }
            }
            if (executeFile)
            {
                Process.Start(FileName);
            }
        }
    }
}

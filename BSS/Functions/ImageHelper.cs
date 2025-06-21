using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MKelner.Forms
{

    public class ImageHelper
    {
        private readonly System.Collections.Generic.Dictionary<string, string> ImagesFromDisk;
        public ImageHelper()
        {
            string picture = "";
            try
            {
               
                    ImagesFromDisk = new System.Collections.Generic.Dictionary<string, string>();
                    foreach (var path in BssBase.settings.ImagesPath.Split(';'))
                    {
                        if (Directory.Exists(path))
                        {

                            foreach (string item in Directory.GetFiles(path))
                            {
                                picture = item;
                                if (item.ToLower().Contains(".jpg") || item.ToLower().Contains(".bmp") ||
                                    item.ToLower().Contains(".png") || item.ToLower().Contains(".ico") ||
                                    item.ToLower().Contains(".jpeg"))
                                {
                                    if (!ImagesFromDisk.ContainsKey(Path.GetFileName(item)))
                                    {
                                        ImagesFromDisk.Add(Path.GetFileName(item), item);
                                    }
                                }
                            }
                        }
                    }
                

            }
            catch (Exception ex)
            {
                Tools.LogExceptionMessageWithScreenShoot(ex,ex.Message, false);
                MessageBox.Show(picture);
            }
        }

        public bool imageExists(string Name)
        {
            return ImagesFromDisk.ContainsKey(Name);
        }

        public Image getImage(string Name)
        {
            if (ImagesFromDisk.ContainsKey(Name))
            {
                return Image.FromFile(ImagesFromDisk[Name]);
            }
            else
            {
                return null; //BssBase.Properties.Resources.add_to2;

            }
        }
    }
}
using System;
using System.IO;
using System.Windows.Forms;

using Microsoft.Win32;

namespace Utility.ModifyRegistry
{
    /// <summary>
    /// An useful class to read/write/delete/count registry keys
    /// </summary>
    public class ModifyRegistry
    {
        private bool showError = true;

        /// <summary>
        /// A property to show or hide error messages
        /// (default = false)
        /// </summary>
        public bool ShowError
        {
            get => showError;
            set => showError = value;
        }

        private string subKey = "SOFTWARE\\" + BssBase.settings.RegPath;

        /// <summary>
        /// A property to set the SubKey value
        /// (default = "SOFTWARE\\" + Application.ProductName.ToUpper())
        /// </summary>
        public string SubKey
        {
            get => subKey;
            set => subKey = value;
        }

        private RegistryKey baseRegistryKey = Registry.CurrentUser;

        /// <summary>
        /// A property to set the BaseRegistryKey value.
        /// (default = Registry.LocalMachine)
        /// </summary>
        public RegistryKey BaseRegistryKey
        {
            get => baseRegistryKey;
            set => baseRegistryKey = value;
        }

        /// <summary>
        /// To read a registry key.
        /// input: KeyName (string)
        /// output: value (string)
        /// </summary>
        public string Read(string KeyName, string defaultValuesIFNotExists = "N/A")
        {
            var rk = baseRegistryKey;
            var sk1 = rk.OpenSubKey(subKey);
            if (sk1 == null)
            {
                return string.Empty;
            }
            else
            {
                try
                {
                    if (!string.IsNullOrEmpty((string)sk1.GetValue(KeyName.ToUpper())))
                        return (string)sk1.GetValue(KeyName.ToUpper());
                    else
                    {
                        Write(KeyName, defaultValuesIFNotExists);
                        return (string)sk1.GetValue(KeyName.ToUpper());
                    }
                }
                catch (Exception e)
                {
                    ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }
        }

        /// <summary>
        /// To write into a registry key.
        /// input: KeyName (string) , Value (object)
        /// output: true or false
        /// </summary>
        public bool Write(string KeyName, object Value, bool showMEssage = true)
        {
            try
            {
                var rk = baseRegistryKey;
                var sk1 = rk.CreateSubKey(subKey);
                sk1.SetValue(KeyName.ToUpper(), Value);

                return true;
            }
            catch (Exception e)
            {
                if (showMEssage)
                {
                    ShowErrorMessage(e, "Writing registry " + KeyName.ToUpper());
                }
                return false;
            }
        }

        /// <summary>
        /// To delete a registry key.
        /// input: KeyName (string)
        /// output: true or false
        /// </summary>
        public bool DeleteKey(string KeyName)
        {
            try
            {
                var rk = baseRegistryKey;
                var sk1 = rk.CreateSubKey(subKey);
                if (sk1 == null)
                {
                    return true;
                }
                else
                {
                    sk1.DeleteValue(KeyName);
                }
                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }

        /// <summary>
        /// To delete a sub key and any child.
        /// input: void
        /// output: true or false
        /// </summary>
        public bool DeleteSubKeyTree()
        {
            try
            {
                var rk = baseRegistryKey;
                var sk1 = rk.OpenSubKey(subKey);
                if (sk1 != null)
                {
                    rk.DeleteSubKeyTree(subKey);
                }
                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }

        /// <summary>
        /// Retrive the count of subkeys at the current key.
        /// input: void
        /// output: number of subkeys
        /// </summary>
        public int SubKeyCount()
        {
            try
            {
                var rk = baseRegistryKey;
                var sk1 = rk.OpenSubKey(subKey);
                if (sk1 != null)
                {
                    return sk1.SubKeyCount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving subkeys of " + subKey);
                return 0;
            }
        }

        /// <summary>
        /// Retrive the count of values in the key.
        /// input: void
        /// output: number of keys
        /// </summary>
        public int ValueCount()
        {
            try
            {
                var rk = baseRegistryKey;
                var sk1 = rk.OpenSubKey(subKey);
                if (sk1 != null)
                {
                    return sk1.ValueCount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving keys of " + subKey);
                return 0;
            }
        }

        private void ShowErrorMessage(Exception e, string Title)
        {
            if (showError == true)
            {
                MessageBox.Show(Tools.PrevediPoraka(e.Message),
                                Title
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error);
            }
        }
        // Existing code...

        /// <summary>
        /// To export the registry key to a file.
        /// input: filePath (string)
        /// output: true or false
        /// </summary>
        public bool ExportRegistry(string filePath)
        {
            try
            {
                var rk = baseRegistryKey;
                var sk1 = rk.OpenSubKey(subKey);
                if (sk1 == null)
                {
                    return false;
                }
                if(!Directory.Exists(Path.GetDirectoryName(filePath)) == false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    ExportKey(sk1, writer);
                }

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Exporting registry " + subKey);
                return false;
            }
        }

        private void ExportKey(RegistryKey key, StreamWriter writer)
        {
            writer.WriteLine("[" + key.Name + "]");
            foreach (string valueName in key.GetValueNames())
            {
                object value = key.GetValue(valueName);
                writer.WriteLine("\"" + valueName + "\"=\"" + value.ToString() + "\"");
            }

            foreach (string subKeyName in key.GetSubKeyNames())
            {
                using (RegistryKey subKey = key.OpenSubKey(subKeyName))
                {
                    ExportKey(subKey, writer);
                }
            }
        }
    }
}
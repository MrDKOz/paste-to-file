using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace PasteToFile.Helpers
{
    public class ContextEntry
    {
        private readonly RegistryKey _rootKey;
        private const string RegPath = @"HKEY_CURRENT_USER\Software\Classes\Directory\Background\shell\Paste to File\command";

        public ContextEntry()
        {
            _rootKey = Registry.CurrentUser.CreateSubKey(@"Software\Classes\Directory");
        }

        /// <summary>
        /// Checks if the registry entries for the context menu already exist.
        /// </summary>
        /// <returns>True/False as to whether the keys already exist.</returns>
        public bool CheckIfRegistered()
        {
            return Registry.GetValue(RegPath, "", null) != null;
        }

        /// <summary>
        /// Either Creates or Removes the context entry, depending on its current existence.
        /// </summary>
        /// <returns>True/False as to whether the operation was a success</returns>
        public void Toggle()
        {
            try
            {
                if (CheckIfRegistered())
                    Remove();
                else
                    Create();
            }
            catch (Exception)
            {
                MessageBox.Show("Paste to File does not have access to the registry. Run as Admin in order to add/remove the context entry");
            }
        }

        /// <summary>
        /// Creates the registry entries that adds the context entry
        /// </summary>
        /// <returns>True/False as to whether the operation was a success</returns>
        private void Create()
        {
            var regKey = _rootKey.CreateSubKey(@"Background\shell").CreateSubKey("Paste to File");
            regKey.SetValue("Icon", $@"""{Application.ExecutablePath}"",0");
            regKey = regKey.CreateSubKey("command");
            regKey.SetValue("", $@"""{Application.ExecutablePath}"" ""%V""");

            regKey = _rootKey.CreateSubKey("shell").CreateSubKey("Paste to File");
            regKey.SetValue("Icon", $@"""{Application.ExecutablePath}"",0");
            regKey = regKey.CreateSubKey("command");
            regKey.SetValue("", $@"""{Application.ExecutablePath}"" ""%1""");
        }

        /// <summary>
        /// Removes the registry entry, which in turn removes the context entry
        /// </summary>
        /// <returns>True/False as to whether the operation was a success</returns>
        private void Remove()
        {
            var regKey = _rootKey.OpenSubKey(@"Background\shell", true);
            regKey.DeleteSubKeyTree("Paste to File");

            regKey = _rootKey.OpenSubKey("shell", true);
            regKey.DeleteSubKeyTree("Paste to File");
        }
    }
}

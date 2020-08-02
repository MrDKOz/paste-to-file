using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PasteToFile.DataTypes;

namespace PasteToFile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Any())
            {
                // Check if the directory exists
                if (!Directory.Exists(args[0])) return;

                // If the directory does exist, then let's continue
                if (Clipboard.ContainsText()) Text.Handle(args[0]);
                if (Clipboard.ContainsImage()) Image.Handle(args[0]);
            }
            else
                Application.Run(new Config());
        }
    }
}

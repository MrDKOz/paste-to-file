using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasteToFile.Handlers;

namespace PasteToFile
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Any())
            {
                var handler = new Handler(args[0]);
                handler.HandleRequest();
            }
            else
                Application.Run(new frmConfig());
        }
    }
}

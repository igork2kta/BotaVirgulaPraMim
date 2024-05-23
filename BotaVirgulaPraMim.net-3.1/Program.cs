using System;
using System.Reflection;
using System.Windows.Forms;

[assembly: AssemblyVersion("1.1.1")]
[assembly: AssemblyMetadata("BuildDate", "2024-04-10")]
namespace BotaVirgulaPraMim.net_3._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

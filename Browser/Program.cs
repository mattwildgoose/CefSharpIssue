using CefSharp;
using CefSharp.WinForms;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Browser
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var cefSettings = new CefSettings
            {
                CachePath = Path.Combine(Application.LocalUserAppDataPath, @"CefSharp\Cache"),
                Locale = CultureInfo.CurrentUICulture.Name
            };

            Cef.Initialize(cefSettings);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BrowserForm());
        }
    }
}

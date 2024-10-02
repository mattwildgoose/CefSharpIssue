using System.Windows.Forms;
using CefSharp.WinForms;

namespace Browser
{
    internal class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser _browser;

        public BrowserForm()
        {
            WindowState = FormWindowState.Maximized;

            _browser = new ChromiumWebBrowser
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(_browser);

            _browser.Load("http://localhost:5096/Profile.html");
        }
    }
}

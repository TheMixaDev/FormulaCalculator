using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private ChromiumWebBrowser browser;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("file:///" + Directory.GetCurrentDirectory() + "/data/index.html");
            browser.ActivateBrowserOnCreation = false;
            browser.Dock = DockStyle.Fill;
            browser.Location = new Point(0, 0);
            browser.Name = "browser";
            browser.Size = new Size(800, 450);
            browser.TabIndex = 0;
            browser.Text = "browser";
            Controls.Add(browser);
            MinimumSize = new Size(800, 450);
        }
    }
}

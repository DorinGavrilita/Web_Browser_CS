using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace ChromiumCsharp
{
   public partial class Form1: Form
   {
      public Form1()
      {
         InitializeComponent();
      }
            
      ChromiumWebBrowser chrome;

      private void Form1_Load(object sender, EventArgs e)
      {
        /// CefSettings settings = new CefSettings();

         // Initialize
        /// Cef.Initialize(settings);
         txtUrl.Text = "https://google.com";
         chrome = new ChromiumWebBrowser(txtUrl.Text);
         chrome.Dock = DockStyle.Fill;
         this.pContainer.Controls.Add(chrome);
         chrome.AddressChanged += Chrome_AddressChanged;
      }

      protected TitleBarTabs ParentTabs
      {
         get { return (ParentForm as TitleBarTabs); }
      }

      private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
      {
         this.Invoke(new MethodInvoker(() =>
            {
               txtUrl.Text = e.Address;
            }));
      }

      private void btnGo_Click(object sender, EventArgs e)
      {
         chrome.Load(txtUrl.Text);
      }

      private void btnRefresh_Click(object sender, EventArgs e)
      {
         chrome.Reload();
      }

      private void btnForward_Click(object sender, EventArgs e)
      {
         if (chrome.CanGoForward)
            chrome.Forward();
      }

      private void btnBack_Click(object sender, EventArgs e)
      {
        if(chrome.CanGoBack)
            chrome.Back();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         Cef.Shutdown();
      }

      private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == (char)13)
            chrome.Load(txtUrl.Text);
      }
   }
}

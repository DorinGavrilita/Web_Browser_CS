using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GavrilitaBrowser
{
   public partial class frmBrowser: Form
   {
      public frmBrowser()
      {
         InitializeComponent();

         // Upgrade the default web browser
         var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
         using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true)) 
            ;
         Key.SetValue(appName, 99999, RegistryValueKind.DWord);
      }

      // open Google.com
      webBrowser1.Navigate("https://www.google.com/");



      // 2. Important: Declare ParentTabs
      protected TitleBarTabs ParentTabs
      {
         get {
            return (ParentForm as TitleBarTabs);
         }
      }

      private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
      {

      }
   }
}

using CefSharp.WinForms;
using CefSharp;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using System.Web.UI.WebControls;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChromiumCsharp
{
   public partial class Form1: Form
   {
      public Form1()
      {
         InitializeComponent();

         richTextBox1.Text = File.ReadAllText("history.t$");
         listBox2.Items.AddRange(File.ReadAllLines("save-pages.txt"));
      }

      ChromiumWebBrowser chrome;

      private void Form1_Load(object sender, EventArgs e)
      {
         CefSettings settings = new CefSettings();

         // Initialize
         /// Cef.IsInitialized(settings);
         txtUrl.Text = "";
         chrome = new ChromiumWebBrowser(txtUrl.Text);
         chrome.Dock = DockStyle.Fill;
         pContainer.Controls.Add(chrome);
         chrome.AddressChanged += Chrome_AddressChanged;
      }

      protected TitleBarTabs ParentTabs
      {
         get { return ParentForm as TitleBarTabs; }
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
         // chrome.Load(txtUrl.Text);

         if (txtUrl.Text.Contains("https://") || txtUrl.Text.Contains("http://"))
         {
            int index = listBox1.SelectedIndex;
            string namesite = txtUrl.Text;
            try
            {
               chrome.Load(namesite);
               listBox1.Items[listBox1.SelectedIndex] = namesite;
               AppContainer.ActiveForm.Text = namesite;
            }
            catch (Exception)
            {
               chrome.Load("https://google.com");
               MessageBox.Show("Wrong Site name!");
            }
            File.AppendAllText("history.t$", txtUrl.Text + "\n");
            richTextBox1.Text = File.ReadAllText("history.t$");

         } else
         {
            chrome.Load("https://www.google.com/search?q=" + txtUrl.Text);
            File.AppendAllText("history.t$", "Google: " + txtUrl.Text + "\n");
            richTextBox1.Text = File.ReadAllText("history.t$");
         }
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
         if (chrome.CanGoBack)
            chrome.Back();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         Cef.Shutdown();
      }

      private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == (char)13)
            //  chrome.Load(txtUrl.Text);
            btnGo_Click(sender, e);
      }

      private void button3_Click(object sender, EventArgs e)
      {
         listBox1.Items.Add("New Tab");
      }

      private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         int index = listBox1.SelectedIndex;
         try
         {
            if (listBox1.Items[listBox1.SelectedIndex].ToString() != "New Tab")
               chrome.Load(listBox1.Items[index].ToString());
            else
            {
               chrome.Load("https://google.com");
            }
         }
         catch (Exception)
         {
            chrome.Load("https://google.com");
         }
      }

      private void btnControl_Click(object sender, EventArgs e)
      {
         if (panel2.Visible == false)
            panel2.Visible = true;
         else
            panel2.Visible = false;
      }

      private void добавитьСтраницуВЗакладкиToolStripMenuItem_Click(object sender, EventArgs e)
      {
         File.AppendAllText("save-pages.txt", listBox1.Items[listBox1.SelectedIndex].ToString());
         listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex].ToString());
      }

      private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
      {
         listBox1.Items.RemoveAt(listBox1.SelectedIndex);
      }

      private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         listBox2.Items.RemoveAt(listBox1.SelectedIndex);

      }

      private void txtUrl_TextChanged(object sender, EventArgs e)
      {
         try
         {
            string[] history_search = File.ReadAllLines("history.t$");
            AutoCompleteStringCollection st = new AutoCompleteStringCollection();
            foreach (string ste in history_search)
            {
               string ste2 = ste.Replace("Google: ", "").Trim();
               st.Add(ste2);
            }
            txtUrl.AutoCompleteCustomSource = st;
         }
         catch(Exception)
         {

         }
      }

      private void btnControl_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.Control && e.KeyCode == Keys.H)
         {
            добавитьСтраницуВЗакладкиToolStripMenuItem_Click(sender, e);
         }
      }

      private void btnClearHistory_Click(object sender, EventArgs e)
      {
         File.WriteAllText("history.t$", "");
         richTextBox1.Text = File.ReadAllText("history.t$");
      }
   }
}

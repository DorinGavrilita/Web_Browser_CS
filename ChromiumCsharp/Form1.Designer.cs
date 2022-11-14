namespace ChromiumCsharp
{
   partial class Form1
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.btnBack = new System.Windows.Forms.Button();
         this.btnForward = new System.Windows.Forms.Button();
         this.btnRefresh = new System.Windows.Forms.Button();
         this.txtUrl = new System.Windows.Forms.TextBox();
         this.btnGo = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnControl = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.listBox2 = new System.Windows.Forms.ListBox();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.pContainer = new CefSharp.WinForms.ChromiumWebBrowser();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage3.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnBack
         // 
         this.btnBack.BackColor = System.Drawing.SystemColors.Control;
         this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnBack.Location = new System.Drawing.Point(13, 13);
         this.btnBack.Margin = new System.Windows.Forms.Padding(4);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(33, 30);
         this.btnBack.TabIndex = 0;
         this.btnBack.Text = "<";
         this.btnBack.UseVisualStyleBackColor = false;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
         // 
         // btnForward
         // 
         this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnForward.Location = new System.Drawing.Point(56, 13);
         this.btnForward.Margin = new System.Windows.Forms.Padding(4);
         this.btnForward.Name = "btnForward";
         this.btnForward.Size = new System.Drawing.Size(33, 30);
         this.btnForward.TabIndex = 0;
         this.btnForward.Text = ">";
         this.btnForward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnForward.UseVisualStyleBackColor = true;
         this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
         // 
         // btnRefresh
         // 
         this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
         this.btnRefresh.Location = new System.Drawing.Point(99, 11);
         this.btnRefresh.Margin = new System.Windows.Forms.Padding(8);
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.Size = new System.Drawing.Size(34, 35);
         this.btnRefresh.TabIndex = 0;
         this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnRefresh.UseVisualStyleBackColor = true;
         this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // txtUrl
         // 
         this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtUrl.Location = new System.Drawing.Point(188, 17);
         this.txtUrl.Name = "txtUrl";
         this.txtUrl.Size = new System.Drawing.Size(652, 22);
         this.txtUrl.TabIndex = 1;
         this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
         // 
         // btnGo
         // 
         this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGo.BackgroundImage")));
         this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnGo.Location = new System.Drawing.Point(847, 13);
         this.btnGo.Margin = new System.Windows.Forms.Padding(4);
         this.btnGo.Name = "btnGo";
         this.btnGo.Size = new System.Drawing.Size(30, 30);
         this.btnGo.TabIndex = 0;
         this.btnGo.UseVisualStyleBackColor = true;
         this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnControl);
         this.panel1.Controls.Add(this.button3);
         this.panel1.Controls.Add(this.btnGo);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(928, 52);
         this.panel1.TabIndex = 2;
         // 
         // btnControl
         // 
         this.btnControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControl.BackgroundImage")));
         this.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnControl.Location = new System.Drawing.Point(885, 13);
         this.btnControl.Margin = new System.Windows.Forms.Padding(4);
         this.btnControl.Name = "btnControl";
         this.btnControl.Size = new System.Drawing.Size(30, 30);
         this.btnControl.TabIndex = 1;
         this.btnControl.UseVisualStyleBackColor = true;
         this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
         // 
         // button3
         // 
         this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button3.Location = new System.Drawing.Point(145, 13);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(30, 30);
         this.button3.TabIndex = 0;
         this.button3.Text = "+";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.tabControl1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel2.Location = new System.Drawing.Point(0, 52);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(273, 502);
         this.panel2.TabIndex = 4;
         this.panel2.Visible = false;
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(273, 502);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.listBox2);
         this.tabPage1.Location = new System.Drawing.Point(4, 25);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(265, 473);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Закладки";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // listBox2
         // 
         this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBox2.FormattingEnabled = true;
         this.listBox2.ItemHeight = 16;
         this.listBox2.Location = new System.Drawing.Point(3, 3);
         this.listBox2.Name = "listBox2";
         this.listBox2.Size = new System.Drawing.Size(259, 467);
         this.listBox2.TabIndex = 0;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 25);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(265, 473);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "История";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.listBox1);
         this.tabPage3.Location = new System.Drawing.Point(4, 25);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(265, 473);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Тек вкладки";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // listBox1
         // 
         this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBox1.FormattingEnabled = true;
         this.listBox1.ItemHeight = 16;
         this.listBox1.Location = new System.Drawing.Point(0, 0);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(265, 473);
         this.listBox1.TabIndex = 1;
         this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
         // 
         // pContainer
         // 
         this.pContainer.ActivateBrowserOnCreation = false;
         this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pContainer.Location = new System.Drawing.Point(0, 52);
         this.pContainer.Name = "pContainer";
         this.pContainer.Size = new System.Drawing.Size(928, 502);
         this.pContainer.TabIndex = 6;
         this.pContainer.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.pContainer_AddressChanged);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(928, 554);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.txtUrl);
         this.Controls.Add(this.btnRefresh);
         this.Controls.Add(this.btnForward);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.pContainer);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Chromium";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage3.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.ListBox listBox2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.ListBox listBox1;
        private CefSharp.WinForms.ChromiumWebBrowser pContainer;
      private System.Windows.Forms.Button btnControl;
   }
}


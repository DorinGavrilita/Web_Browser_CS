﻿namespace ChromiumCsharp
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
         this.imgRefresh = new System.Windows.Forms.Button();
         this.btnStop = new System.Windows.Forms.Button();
         this.pContainer = new System.Windows.Forms.Panel();
         this.pContainer.SuspendLayout();
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
         this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
         this.btnRefresh.Location = new System.Drawing.Point(99, 13);
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
         this.txtUrl.Location = new System.Drawing.Point(145, 21);
         this.txtUrl.Name = "txtUrl";
         this.txtUrl.Size = new System.Drawing.Size(559, 22);
         this.txtUrl.TabIndex = 1;
         this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
         // 
         // btnGo
         // 
         this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnGo.Location = new System.Drawing.Point(711, 13);
         this.btnGo.Margin = new System.Windows.Forms.Padding(4);
         this.btnGo.Name = "btnGo";
         this.btnGo.Size = new System.Drawing.Size(36, 30);
         this.btnGo.TabIndex = 0;
         this.btnGo.Text = "GO";
         this.btnGo.UseVisualStyleBackColor = true;
         this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
         // 
         // panel1
         // 
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(759, 52);
         this.panel1.TabIndex = 2;
         // 
         // imgRefresh
         // 
         this.imgRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
         this.imgRefresh.Location = new System.Drawing.Point(56, 401);
         this.imgRefresh.Margin = new System.Windows.Forms.Padding(8);
         this.imgRefresh.Name = "imgRefresh";
         this.imgRefresh.Size = new System.Drawing.Size(34, 35);
         this.imgRefresh.TabIndex = 0;
         this.imgRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.imgRefresh.UseVisualStyleBackColor = true;
         this.imgRefresh.Visible = false;
         this.imgRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // btnStop
         // 
         this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
         this.btnStop.Location = new System.Drawing.Point(145, 401);
         this.btnStop.Margin = new System.Windows.Forms.Padding(8);
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(32, 32);
         this.btnStop.TabIndex = 0;
         this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnStop.UseVisualStyleBackColor = true;
         this.btnStop.Visible = false;
         this.btnStop.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // pContainer
         // 
         this.pContainer.Controls.Add(this.btnStop);
         this.pContainer.Controls.Add(this.imgRefresh);
         this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pContainer.Location = new System.Drawing.Point(0, 52);
         this.pContainer.Name = "pContainer";
         this.pContainer.Size = new System.Drawing.Size(759, 502);
         this.pContainer.TabIndex = 3;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(759, 554);
         this.Controls.Add(this.pContainer);
         this.Controls.Add(this.txtUrl);
         this.Controls.Add(this.btnRefresh);
         this.Controls.Add(this.btnGo);
         this.Controls.Add(this.btnForward);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Chromium";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.pContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Button imgRefresh;
        private System.Windows.Forms.Button btnStop;
      private System.Windows.Forms.Panel pContainer;
   }
}

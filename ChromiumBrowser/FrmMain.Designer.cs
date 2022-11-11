namespace ChromiumBrowser
{
   partial class FrmMain
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
         this.SuspendLayout();
         // 
         // FrmMain
         // 
         this.ClientSize = new System.Drawing.Size(932, 551);
         this.Name = "FrmMain";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel pnlBody;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtURL;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLoader loader;
    }
}


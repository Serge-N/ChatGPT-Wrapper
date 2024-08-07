namespace ChatGPT
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
      ((System.ComponentModel.ISupportInitialize)this.webView21).BeginInit();
      this.SuspendLayout();
      // 
      // webView21
      // 
      this.webView21.AllowExternalDrop = true;
      this.webView21.CreationProperties = null;
      this.webView21.DefaultBackgroundColor = Color.White;
      this.webView21.Location = new Point(-1, -2);
      this.webView21.Name = "webView21";
      this.webView21.Size = new Size(801, 456);
      this.webView21.Source = new Uri("https://chatgpt.com", UriKind.Absolute);
      this.webView21.TabIndex = 0;
      this.webView21.ZoomFactor = 1D;
      this.webView21.Click += this.webView21_Click;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new SizeF(10F, 25F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(800, 450);
      this.Controls.Add(this.webView21);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += this.Form1_Load;
      ((System.ComponentModel.ISupportInitialize)this.webView21).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
  }
}

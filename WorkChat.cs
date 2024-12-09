namespace ChatGPT
{
  public partial class WorkChat : Form
  {
    public WorkChat()
    {
      InitializeComponent();

      this.Resize += MainForm_Resize; // Handle the resize event

    }

    private void Work_Load(object sender, EventArgs e)
    {

    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
      // Adjust the size of the WebView2 control to match the size of the parent form
      webView21.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
    }

    private void webView21_Click(object sender, EventArgs e)
    {

    }
  }
}

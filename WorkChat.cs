using System.Diagnostics;

namespace ChatGPT;

public partial class WorkChat : Form
{
  public WorkChat()
  {
    InitializeComponent();

    this.Resize += MainForm_Resize; // Handle the resize event
    Test_Click();
  }

 

  private void Work_Load(object sender, EventArgs e)
  {
    try
    {
      // Load the saved URL into WebView2
      var savedUrl = Properties.Settings.Default["SelectedModelUrl"]?.ToString();

      Console.WriteLine("URL : " + savedUrl);
      webView21.Source = !string.IsNullOrEmpty(savedUrl) ? new Uri(savedUrl) : new Uri("https://chatgpt.com");
    }
    catch
    {
      webView21.Source = new Uri("https://chatgpt.com");
    }
  }

  private void MainForm_Resize(object sender, EventArgs e)
  {
    // Adjust the size of the WebView2 control to match the size of the parent form
    webView21.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
  }

  private void Test_Click()
  {
    try
    {
      // Open the ModelSelectionForm
      var modelSelectionForm = new SettingsPage();
      modelSelectionForm.ShowDialog();

      // Reload the WebView2 with the updated URL
      var updatedUrl = Properties.Settings.Default["SelectedModelUrl"].ToString();
      if (!string.IsNullOrEmpty(updatedUrl))
      {
        webView21.Source = new Uri(updatedUrl);
      }
    }
    catch
    {
      Console.WriteLine("Well no url was selected");
    }
  }

  private void webView21_Click(object sender, EventArgs e)
  {
    try
    {
      // Open the ModelSelectionForm
      var modelSelectionForm = new SettingsPage();
      modelSelectionForm.ShowDialog();

      // Reload the WebView2 with the updated URL
      var updatedUrl = Properties.Settings.Default["SelectedModelUrl"].ToString();
      if (!string.IsNullOrEmpty(updatedUrl))
      {
        webView21.Source = new Uri(updatedUrl);
      }
    }
    catch
    {
      Console.WriteLine("Well no url was selected");
    }
  }
}

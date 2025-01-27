using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPT
{
  public partial class SettingsPage : Form
  {
    public SettingsPage()
    {
      InitializeComponent();
      comboBoxModels.SelectedIndex = 0; // Set default selection
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        // Get the selected model
        var selectedModel = comboBoxModels.SelectedItem.ToString();

        // Save the corresponding URL to application settings
        if (selectedModel == "ChatGPT")
        {
          Properties.Settings.Default["SelectedModelUrl"] = ChatGPTUrl;
        }
        else if (selectedModel == "DeepSeek")
        {
          Properties.Settings.Default["SelectedModelUrl"] = DeepSeekUrl;
        }

        Properties.Settings.Default.Save(); // Save settings
        MessageBox.Show("Model URL saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.Close(); // Close the form after saving
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }
    }
  }
}

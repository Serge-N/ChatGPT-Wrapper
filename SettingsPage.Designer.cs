namespace ChatGPT
{
  partial class SettingsPage
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    // Define the URLs for the models
    private const string ChatGPTUrl = "https://chatgpt.com";
    private const string DeepSeekUrl = "https://chat.deepseek.com";

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.comboBoxModels = new ComboBox();
      this.btnSave = new Button();
      this.SuspendLayout();
      // 
      // comboBoxModels
      // 
      this.comboBoxModels.FormattingEnabled = true;
      this.comboBoxModels.Items.AddRange(new object[] { "ChatGPT", "DeepSeek" });
      this.comboBoxModels.Location = new Point(315, 139);
      this.comboBoxModels.Name = "comboBoxModels";
      this.comboBoxModels.Size = new Size(182, 33);
      this.comboBoxModels.TabIndex = 0;
      this.comboBoxModels.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
      // 
      // btnSave
      // 
      this.btnSave.Location = new Point(352, 216);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(112, 34);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += this.btnSave_Click;
      // 
      // SettingsPage
      // 
      this.AutoScaleDimensions = new SizeF(10F, 25F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(800, 450);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.comboBoxModels);
      this.Name = "SettingsPage";
      this.Text = "SettingsPage";
      this.ResumeLayout(false);
    }

    #endregion

    private ComboBox comboBoxModels;
    private Button btnSave;
  }
}
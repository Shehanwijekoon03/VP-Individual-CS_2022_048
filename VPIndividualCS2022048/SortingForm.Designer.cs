namespace VPIndividualCS2022048;

partial class SortingForm
{
    private System.ComponentModel.IContainer components = null;
    private Label headingLabel;
    private Label descriptionLabel;
    private GroupBox settingsGroupBox;
    private Label settingsValueLabel;
    private Button openSettingsButton;
    private Button backButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        headingLabel = new Label();
        descriptionLabel = new Label();
        settingsGroupBox = new GroupBox();
        settingsValueLabel = new Label();
        openSettingsButton = new Button();
        backButton = new Button();
        settingsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // headingLabel
        // 
        headingLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        headingLabel.Location = new Point(31, 29);
        headingLabel.Name = "headingLabel";
        headingLabel.Size = new Size(349, 42);
        headingLabel.TabIndex = 0;
        headingLabel.Text = "SortingForm";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(35, 81);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(590, 47);
        descriptionLabel.TabIndex = 1;
        descriptionLabel.Text = "This page will host the sorting visualizer on Day 2. For Day 1, it proves navigation and modal settings handoff.";
        // 
        // settingsGroupBox
        // 
        settingsGroupBox.Controls.Add(settingsValueLabel);
        settingsGroupBox.Location = new Point(35, 150);
        settingsGroupBox.Name = "settingsGroupBox";
        settingsGroupBox.Size = new Size(357, 131);
        settingsGroupBox.TabIndex = 2;
        settingsGroupBox.TabStop = false;
        settingsGroupBox.Text = "Current Settings";
        // 
        // settingsValueLabel
        // 
        settingsValueLabel.Location = new Point(17, 32);
        settingsValueLabel.Name = "settingsValueLabel";
        settingsValueLabel.Size = new Size(318, 76);
        settingsValueLabel.TabIndex = 0;
        // 
        // openSettingsButton
        // 
        openSettingsButton.BackColor = Color.FromArgb(241, 196, 15);
        openSettingsButton.FlatStyle = FlatStyle.Flat;
        openSettingsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        openSettingsButton.Location = new Point(440, 170);
        openSettingsButton.Name = "openSettingsButton";
        openSettingsButton.Size = new Size(164, 48);
        openSettingsButton.TabIndex = 3;
        openSettingsButton.Text = "Open Settings";
        openSettingsButton.UseVisualStyleBackColor = false;
        openSettingsButton.Click += OpenSettingsButton_Click;
        // 
        // backButton
        // 
        backButton.Location = new Point(440, 233);
        backButton.Name = "backButton";
        backButton.Size = new Size(164, 48);
        backButton.TabIndex = 4;
        backButton.Text = "Back to Main";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += BackButton_Click;
        // 
        // SortingForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(664, 351);
        Controls.Add(backButton);
        Controls.Add(openSettingsButton);
        Controls.Add(settingsGroupBox);
        Controls.Add(descriptionLabel);
        Controls.Add(headingLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "SortingForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SortingForm";
        FormClosed += SortingForm_FormClosed;
        settingsGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
}

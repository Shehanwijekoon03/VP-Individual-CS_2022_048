namespace VPIndividualCS2022048;

partial class SortingForm
{
    private System.ComponentModel.IContainer components = null;
    private Label headingLabel;
    private Label descriptionLabel;
    private Panel visualizerPanel;
    private ComboBox algorithmComboBox;
    private Label algorithmLabel;
    private Button generateButton;
    private Button startButton;
    private GroupBox settingsGroupBox;
    private Label settingsValueLabel;
    private Label statusLabel;
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
        visualizerPanel = new Panel();
        algorithmComboBox = new ComboBox();
        algorithmLabel = new Label();
        generateButton = new Button();
        startButton = new Button();
        settingsGroupBox = new GroupBox();
        settingsValueLabel = new Label();
        statusLabel = new Label();
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
        headingLabel.Text = "Sorting Visualizer";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(35, 81);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(872, 27);
        descriptionLabel.TabIndex = 1;
        descriptionLabel.Text = "Generate a random array, choose an algorithm, and watch the bars animate step by step using a WinForms Timer.";
        // 
        // visualizerPanel
        // 
        visualizerPanel.BackColor = Color.White;
        visualizerPanel.BorderStyle = BorderStyle.FixedSingle;
        visualizerPanel.Location = new Point(35, 161);
        visualizerPanel.Name = "visualizerPanel";
        visualizerPanel.Size = new Size(872, 315);
        visualizerPanel.TabIndex = 2;
        visualizerPanel.Paint += VisualizerPanel_Paint;
        // 
        // algorithmComboBox
        // 
        algorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        algorithmComboBox.FormattingEnabled = true;
        algorithmComboBox.Location = new Point(147, 125);
        algorithmComboBox.Name = "algorithmComboBox";
        algorithmComboBox.Size = new Size(184, 23);
        algorithmComboBox.TabIndex = 3;
        // 
        // algorithmLabel
        // 
        algorithmLabel.Location = new Point(35, 127);
        algorithmLabel.Name = "algorithmLabel";
        algorithmLabel.Size = new Size(106, 23);
        algorithmLabel.TabIndex = 4;
        algorithmLabel.Text = "Algorithm";
        // 
        // generateButton
        // 
        generateButton.BackColor = Color.FromArgb(52, 152, 219);
        generateButton.FlatStyle = FlatStyle.Flat;
        generateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        generateButton.ForeColor = Color.White;
        generateButton.Location = new Point(359, 119);
        generateButton.Name = "generateButton";
        generateButton.Size = new Size(148, 35);
        generateButton.TabIndex = 5;
        generateButton.Text = "Generate Array";
        generateButton.UseVisualStyleBackColor = false;
        generateButton.Click += GenerateButton_Click;
        // 
        // startButton
        // 
        startButton.BackColor = Color.FromArgb(46, 204, 113);
        startButton.FlatStyle = FlatStyle.Flat;
        startButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        startButton.ForeColor = Color.White;
        startButton.Location = new Point(524, 119);
        startButton.Name = "startButton";
        startButton.Size = new Size(148, 35);
        startButton.TabIndex = 6;
        startButton.Text = "Start Sorting";
        startButton.UseVisualStyleBackColor = false;
        startButton.Click += StartButton_Click;
        // 
        // settingsGroupBox
        // 
        settingsGroupBox.Controls.Add(settingsValueLabel);
        settingsGroupBox.Location = new Point(928, 161);
        settingsGroupBox.Name = "settingsGroupBox";
        settingsGroupBox.Size = new Size(260, 131);
        settingsGroupBox.TabIndex = 7;
        settingsGroupBox.TabStop = false;
        settingsGroupBox.Text = "Current Settings";
        // 
        // settingsValueLabel
        // 
        settingsValueLabel.Location = new Point(17, 32);
        settingsValueLabel.Name = "settingsValueLabel";
        settingsValueLabel.Size = new Size(222, 76);
        settingsValueLabel.TabIndex = 0;
        // 
        // statusLabel
        // 
        statusLabel.BorderStyle = BorderStyle.FixedSingle;
        statusLabel.Location = new Point(35, 489);
        statusLabel.Name = "statusLabel";
        statusLabel.Padding = new Padding(8, 6, 8, 6);
        statusLabel.Size = new Size(872, 52);
        statusLabel.TabIndex = 8;
        statusLabel.Text = "Ready.";
        // 
        // openSettingsButton
        // 
        openSettingsButton.BackColor = Color.FromArgb(241, 196, 15);
        openSettingsButton.FlatStyle = FlatStyle.Flat;
        openSettingsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        openSettingsButton.Location = new Point(928, 311);
        openSettingsButton.Name = "openSettingsButton";
        openSettingsButton.Size = new Size(260, 48);
        openSettingsButton.TabIndex = 9;
        openSettingsButton.Text = "Open Settings";
        openSettingsButton.UseVisualStyleBackColor = false;
        openSettingsButton.Click += OpenSettingsButton_Click;
        // 
        // backButton
        // 
        backButton.Location = new Point(928, 374);
        backButton.Name = "backButton";
        backButton.Size = new Size(260, 48);
        backButton.TabIndex = 10;
        backButton.Text = "Back to Main";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += BackButton_Click;
        // 
        // SortingForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1225, 566);
        Controls.Add(backButton);
        Controls.Add(openSettingsButton);
        Controls.Add(statusLabel);
        Controls.Add(settingsGroupBox);
        Controls.Add(startButton);
        Controls.Add(generateButton);
        Controls.Add(algorithmLabel);
        Controls.Add(algorithmComboBox);
        Controls.Add(visualizerPanel);
        Controls.Add(descriptionLabel);
        Controls.Add(headingLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "SortingForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sorting Visualizer";
        FormClosed += SortingForm_FormClosed;
        settingsGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
}

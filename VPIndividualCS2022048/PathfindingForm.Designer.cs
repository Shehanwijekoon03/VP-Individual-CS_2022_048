namespace VPIndividualCS2022048;

partial class PathfindingForm
{
    private System.ComponentModel.IContainer components = null;
    private Label headingLabel;
    private Label descriptionLabel;
    private Panel gridPanel;
    private Button startButton;
    private Button resetGridButton;
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
        gridPanel = new Panel();
        startButton = new Button();
        resetGridButton = new Button();
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
        headingLabel.Text = "Pathfinding Visualizer";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(35, 81);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(872, 27);
        descriptionLabel.TabIndex = 1;
        descriptionLabel.Text = "Click cells to toggle walls, then animate Dijkstra's algorithm to explore the grid and reveal the shortest path.";
        // 
        // gridPanel
        // 
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Location = new Point(35, 150);
        gridPanel.Name = "gridPanel";
        gridPanel.Size = new Size(560, 560);
        gridPanel.TabIndex = 2;
        gridPanel.Paint += GridPanel_Paint;
        gridPanel.MouseClick += GridPanel_MouseClick;
        // 
        // startButton
        // 
        startButton.BackColor = Color.FromArgb(46, 204, 113);
        startButton.FlatStyle = FlatStyle.Flat;
        startButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        startButton.ForeColor = Color.White;
        startButton.Location = new Point(632, 150);
        startButton.Name = "startButton";
        startButton.Size = new Size(244, 44);
        startButton.TabIndex = 3;
        startButton.Text = "Start Dijkstra";
        startButton.UseVisualStyleBackColor = false;
        startButton.Click += StartButton_Click;
        // 
        // resetGridButton
        // 
        resetGridButton.Location = new Point(632, 206);
        resetGridButton.Name = "resetGridButton";
        resetGridButton.Size = new Size(244, 44);
        resetGridButton.TabIndex = 4;
        resetGridButton.Text = "Reset Grid";
        resetGridButton.UseVisualStyleBackColor = true;
        resetGridButton.Click += ResetGridButton_Click;
        // 
        // settingsGroupBox
        // 
        settingsGroupBox.Controls.Add(settingsValueLabel);
        settingsGroupBox.Location = new Point(632, 286);
        settingsGroupBox.Name = "settingsGroupBox";
        settingsGroupBox.Size = new Size(244, 120);
        settingsGroupBox.TabIndex = 5;
        settingsGroupBox.TabStop = false;
        settingsGroupBox.Text = "Current Settings";
        // 
        // settingsValueLabel
        // 
        settingsValueLabel.Location = new Point(17, 32);
        settingsValueLabel.Name = "settingsValueLabel";
        settingsValueLabel.Size = new Size(206, 67);
        settingsValueLabel.TabIndex = 0;
        // 
        // statusLabel
        // 
        statusLabel.BorderStyle = BorderStyle.FixedSingle;
        statusLabel.Location = new Point(632, 426);
        statusLabel.Name = "statusLabel";
        statusLabel.Padding = new Padding(8, 6, 8, 6);
        statusLabel.Size = new Size(557, 153);
        statusLabel.TabIndex = 6;
        statusLabel.Text = "Ready.";
        // 
        // openSettingsButton
        // 
        openSettingsButton.BackColor = Color.FromArgb(155, 89, 182);
        openSettingsButton.FlatStyle = FlatStyle.Flat;
        openSettingsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        openSettingsButton.ForeColor = Color.White;
        openSettingsButton.Location = new Point(632, 600);
        openSettingsButton.Name = "openSettingsButton";
        openSettingsButton.Size = new Size(244, 48);
        openSettingsButton.TabIndex = 7;
        openSettingsButton.Text = "Open Settings";
        openSettingsButton.UseVisualStyleBackColor = false;
        openSettingsButton.Click += OpenSettingsButton_Click;
        // 
        // backButton
        // 
        backButton.Location = new Point(906, 600);
        backButton.Name = "backButton";
        backButton.Size = new Size(283, 48);
        backButton.TabIndex = 8;
        backButton.Text = "Back to Main";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += BackButton_Click;
        // 
        // PathfindingForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1225, 740);
        Controls.Add(backButton);
        Controls.Add(openSettingsButton);
        Controls.Add(statusLabel);
        Controls.Add(settingsGroupBox);
        Controls.Add(resetGridButton);
        Controls.Add(startButton);
        Controls.Add(gridPanel);
        Controls.Add(descriptionLabel);
        Controls.Add(headingLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "PathfindingForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pathfinding Visualizer";
        FormClosed += PathfindingForm_FormClosed;
        settingsGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
}

namespace VPIndividualCS2022048;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Button openSortingFormButton;
    private Button openPathfindingFormButton;
    private Button exitButton;

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
        titleLabel = new Label();
        openSortingFormButton = new Button();
        openPathfindingFormButton = new Button();
        exitButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Underline);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(35, 34);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(488, 52);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Algorithm Visualizer";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // openSortingFormButton
        // 
        openSortingFormButton.BackColor = Color.FromArgb(56, 56, 56);
        openSortingFormButton.FlatAppearance.BorderColor = Color.Silver;
        openSortingFormButton.FlatAppearance.BorderSize = 1;
        openSortingFormButton.FlatStyle = FlatStyle.Flat;
        openSortingFormButton.Font = new Font("Segoe UI", 11F);
        openSortingFormButton.ForeColor = Color.White;
        openSortingFormButton.Location = new Point(150, 128);
        openSortingFormButton.Name = "openSortingFormButton";
        openSortingFormButton.Size = new Size(258, 42);
        openSortingFormButton.TabIndex = 2;
        openSortingFormButton.Text = "Sorting Visualizer";
        openSortingFormButton.UseVisualStyleBackColor = false;
        openSortingFormButton.Click += OpenSortingFormButton_Click;
        // 
        // openPathfindingFormButton
        // 
        openPathfindingFormButton.BackColor = Color.FromArgb(56, 56, 56);
        openPathfindingFormButton.FlatAppearance.BorderColor = Color.Silver;
        openPathfindingFormButton.FlatAppearance.BorderSize = 1;
        openPathfindingFormButton.FlatStyle = FlatStyle.Flat;
        openPathfindingFormButton.Font = new Font("Segoe UI", 11F);
        openPathfindingFormButton.ForeColor = Color.White;
        openPathfindingFormButton.Location = new Point(150, 184);
        openPathfindingFormButton.Name = "openPathfindingFormButton";
        openPathfindingFormButton.Size = new Size(258, 42);
        openPathfindingFormButton.TabIndex = 3;
        openPathfindingFormButton.Text = "Pathfinding Visualizer";
        openPathfindingFormButton.UseVisualStyleBackColor = false;
        openPathfindingFormButton.Click += OpenPathfindingFormButton_Click;
        // 
        // exitButton
        // 
        exitButton.BackColor = Color.FromArgb(140, 140, 140);
        exitButton.FlatAppearance.BorderColor = Color.Silver;
        exitButton.FlatAppearance.BorderSize = 1;
        exitButton.FlatStyle = FlatStyle.Flat;
        exitButton.Font = new Font("Segoe UI", 11F);
        exitButton.ForeColor = Color.White;
        exitButton.Location = new Point(194, 256);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(170, 42);
        exitButton.TabIndex = 4;
        exitButton.Text = "Exit";
        exitButton.UseVisualStyleBackColor = false;
        exitButton.Click += ExitButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(34, 34, 34);
        ClientSize = new Size(560, 350);
        Controls.Add(exitButton);
        Controls.Add(openPathfindingFormButton);
        Controls.Add(openSortingFormButton);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Algorithm Visualizer";
        ResumeLayout(false);
    }

    #endregion
}

namespace VPIndividualCS2022048;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label subtitleLabel;
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
        subtitleLabel = new Label();
        openSortingFormButton = new Button();
        openPathfindingFormButton = new Button();
        exitButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        titleLabel.Location = new Point(47, 34);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(689, 46);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Algorithm Visualizer";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // subtitleLabel
        // 
        subtitleLabel.Font = new Font("Segoe UI", 10F);
        subtitleLabel.Location = new Point(123, 93);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.Size = new Size(538, 49);
        subtitleLabel.TabIndex = 1;
        subtitleLabel.Text = "Choose a visualizer to begin.";
        subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // openSortingFormButton
        // 
        openSortingFormButton.BackColor = Color.FromArgb(52, 152, 219);
        openSortingFormButton.FlatStyle = FlatStyle.Flat;
        openSortingFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        openSortingFormButton.ForeColor = Color.White;
        openSortingFormButton.Location = new Point(247, 177);
        openSortingFormButton.Name = "openSortingFormButton";
        openSortingFormButton.Size = new Size(289, 55);
        openSortingFormButton.TabIndex = 2;
        openSortingFormButton.Text = "Open Sorting Visualizer";
        openSortingFormButton.UseVisualStyleBackColor = false;
        openSortingFormButton.Click += OpenSortingFormButton_Click;
        // 
        // openPathfindingFormButton
        // 
        openPathfindingFormButton.BackColor = Color.FromArgb(46, 204, 113);
        openPathfindingFormButton.FlatStyle = FlatStyle.Flat;
        openPathfindingFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        openPathfindingFormButton.ForeColor = Color.White;
        openPathfindingFormButton.Location = new Point(247, 252);
        openPathfindingFormButton.Name = "openPathfindingFormButton";
        openPathfindingFormButton.Size = new Size(289, 55);
        openPathfindingFormButton.TabIndex = 3;
        openPathfindingFormButton.Text = "Open Pathfinding Visualizer";
        openPathfindingFormButton.UseVisualStyleBackColor = false;
        openPathfindingFormButton.Click += OpenPathfindingFormButton_Click;
        // 
        // exitButton
        // 
        exitButton.Location = new Point(340, 336);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(103, 39);
        exitButton.TabIndex = 4;
        exitButton.Text = "Exit";
        exitButton.UseVisualStyleBackColor = true;
        exitButton.Click += ExitButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(784, 421);
        Controls.Add(exitButton);
        Controls.Add(openPathfindingFormButton);
        Controls.Add(openSortingFormButton);
        Controls.Add(subtitleLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainForm";
        ResumeLayout(false);
    }

    #endregion
}

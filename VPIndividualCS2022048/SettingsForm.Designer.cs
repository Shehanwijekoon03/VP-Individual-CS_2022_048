namespace VPIndividualCS2022048;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;
    private Label headingLabel;
    private Label animationSpeedLabel;
    private NumericUpDown animationSpeedNumericUpDown;
    private Label numberOfItemsLabel;
    private NumericUpDown numberOfItemsNumericUpDown;
    private Label gridSizeLabel;
    private NumericUpDown gridSizeNumericUpDown;
    private CheckBox showStepDetailsCheckBox;
    private Button saveButton;
    private Button cancelButton;

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
        animationSpeedLabel = new Label();
        animationSpeedNumericUpDown = new NumericUpDown();
        numberOfItemsLabel = new Label();
        numberOfItemsNumericUpDown = new NumericUpDown();
        gridSizeLabel = new Label();
        gridSizeNumericUpDown = new NumericUpDown();
        showStepDetailsCheckBox = new CheckBox();
        saveButton = new Button();
        cancelButton = new Button();
        ((System.ComponentModel.ISupportInitialize)animationSpeedNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numberOfItemsNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridSizeNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // headingLabel
        // 
        headingLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        headingLabel.Location = new Point(27, 19);
        headingLabel.Name = "headingLabel";
        headingLabel.Size = new Size(305, 37);
        headingLabel.TabIndex = 0;
        headingLabel.Text = "SettingsForm";
        // 
        // animationSpeedLabel
        // 
        animationSpeedLabel.Location = new Point(31, 80);
        animationSpeedLabel.Name = "animationSpeedLabel";
        animationSpeedLabel.Size = new Size(137, 23);
        animationSpeedLabel.TabIndex = 1;
        animationSpeedLabel.Text = "Animation Speed (ms)";
        // 
        // animationSpeedNumericUpDown
        // 
        animationSpeedNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
        animationSpeedNumericUpDown.Location = new Point(201, 78);
        animationSpeedNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        animationSpeedNumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        animationSpeedNumericUpDown.Name = "animationSpeedNumericUpDown";
        animationSpeedNumericUpDown.Size = new Size(120, 23);
        animationSpeedNumericUpDown.TabIndex = 2;
        animationSpeedNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // numberOfItemsLabel
        // 
        numberOfItemsLabel.Location = new Point(31, 126);
        numberOfItemsLabel.Name = "numberOfItemsLabel";
        numberOfItemsLabel.Size = new Size(137, 23);
        numberOfItemsLabel.TabIndex = 3;
        numberOfItemsLabel.Text = "Number of Items";
        // 
        // numberOfItemsNumericUpDown
        // 
        numberOfItemsNumericUpDown.Location = new Point(201, 124);
        numberOfItemsNumericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numberOfItemsNumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        numberOfItemsNumericUpDown.Name = "numberOfItemsNumericUpDown";
        numberOfItemsNumericUpDown.Size = new Size(120, 23);
        numberOfItemsNumericUpDown.TabIndex = 4;
        numberOfItemsNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // gridSizeLabel
        // 
        gridSizeLabel.Location = new Point(31, 172);
        gridSizeLabel.Name = "gridSizeLabel";
        gridSizeLabel.Size = new Size(137, 23);
        gridSizeLabel.TabIndex = 5;
        gridSizeLabel.Text = "Grid Size";
        // 
        // gridSizeNumericUpDown
        // 
        gridSizeNumericUpDown.Location = new Point(201, 170);
        gridSizeNumericUpDown.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
        gridSizeNumericUpDown.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        gridSizeNumericUpDown.Name = "gridSizeNumericUpDown";
        gridSizeNumericUpDown.Size = new Size(120, 23);
        gridSizeNumericUpDown.TabIndex = 6;
        gridSizeNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // showStepDetailsCheckBox
        // 
        showStepDetailsCheckBox.AutoSize = true;
        showStepDetailsCheckBox.Location = new Point(31, 215);
        showStepDetailsCheckBox.Name = "showStepDetailsCheckBox";
        showStepDetailsCheckBox.Size = new Size(117, 19);
        showStepDetailsCheckBox.TabIndex = 7;
        showStepDetailsCheckBox.Text = "Show Step Details";
        showStepDetailsCheckBox.UseVisualStyleBackColor = true;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.FromArgb(46, 204, 113);
        saveButton.FlatStyle = FlatStyle.Flat;
        saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        saveButton.ForeColor = Color.White;
        saveButton.Location = new Point(56, 260);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(110, 40);
        saveButton.TabIndex = 8;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Click += SaveButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(187, 260);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(110, 40);
        cancelButton.TabIndex = 9;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += CancelButton_Click;
        // 
        // SettingsForm
        // 
        AcceptButton = saveButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(356, 324);
        Controls.Add(cancelButton);
        Controls.Add(saveButton);
        Controls.Add(showStepDetailsCheckBox);
        Controls.Add(gridSizeNumericUpDown);
        Controls.Add(gridSizeLabel);
        Controls.Add(numberOfItemsNumericUpDown);
        Controls.Add(numberOfItemsLabel);
        Controls.Add(animationSpeedNumericUpDown);
        Controls.Add(animationSpeedLabel);
        Controls.Add(headingLabel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SettingsForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "SettingsForm";
        ((System.ComponentModel.ISupportInitialize)animationSpeedNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)numberOfItemsNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridSizeNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}

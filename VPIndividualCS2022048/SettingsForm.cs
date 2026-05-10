namespace VPIndividualCS2022048;

public partial class SettingsForm : Form
{
    private readonly bool _isPathfindingMode;

    public VisualizerSettings SelectedSettings { get; private set; }

    public SettingsForm(VisualizerSettings currentSettings, bool isPathfindingMode = false)
    {
        _isPathfindingMode = isPathfindingMode;
        SelectedSettings = currentSettings.Clone();
        InitializeComponent();
        ApplyModeLayout();
        LoadCurrentSettings();
    }

    private void LoadCurrentSettings()
    {
        animationSpeedNumericUpDown.Value = SelectedSettings.AnimationSpeed;
        numberOfItemsNumericUpDown.Value = SelectedSettings.NumberOfItems;
        gridSizeNumericUpDown.Value = SelectedSettings.GridSize;
        showStepDetailsCheckBox.Checked = SelectedSettings.ShowStepDetails;
    }

    private void ApplyModeLayout()
    {
        if (_isPathfindingMode)
        {
            headingLabel.Text = "Pathfinding Settings";
            numberOfItemsLabel.Visible = false;
            numberOfItemsNumericUpDown.Visible = false;
        }
        else
        {
            headingLabel.Text = "Sorting Settings";
            gridSizeLabel.Visible = false;
            gridSizeNumericUpDown.Visible = false;
        }
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        SelectedSettings = new VisualizerSettings
        {
            AnimationSpeed = (int)animationSpeedNumericUpDown.Value,
            NumberOfItems = (int)numberOfItemsNumericUpDown.Value,
            GridSize = (int)gridSizeNumericUpDown.Value,
            ShowStepDetails = showStepDetailsCheckBox.Checked
        };

        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}

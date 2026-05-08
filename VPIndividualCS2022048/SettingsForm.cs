namespace VPIndividualCS2022048;

public partial class SettingsForm : Form
{
    public VisualizerSettings SelectedSettings { get; private set; }

    public SettingsForm(VisualizerSettings currentSettings)
    {
        SelectedSettings = currentSettings.Clone();
        InitializeComponent();
        LoadCurrentSettings();
    }

    private void LoadCurrentSettings()
    {
        animationSpeedNumericUpDown.Value = SelectedSettings.AnimationSpeed;
        numberOfItemsNumericUpDown.Value = SelectedSettings.NumberOfItems;
        showStepDetailsCheckBox.Checked = SelectedSettings.ShowStepDetails;
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        SelectedSettings = new VisualizerSettings
        {
            AnimationSpeed = (int)animationSpeedNumericUpDown.Value,
            NumberOfItems = (int)numberOfItemsNumericUpDown.Value,
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

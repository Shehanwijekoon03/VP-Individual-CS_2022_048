namespace VPIndividualCS2022048;

public partial class PathfindingForm : Form
{
    private readonly MainForm _mainForm;
    private VisualizerSettings _settings = new();

    public PathfindingForm(MainForm mainForm)
    {
        _mainForm = mainForm;
        InitializeComponent();
        UpdateSettingsSummary();
    }

    private void OpenSettingsButton_Click(object? sender, EventArgs e)
    {
        using SettingsForm settingsForm = new(_settings);

        if (settingsForm.ShowDialog(this) == DialogResult.OK)
        {
            _settings = settingsForm.SelectedSettings.Clone();
            UpdateSettingsSummary();
        }
    }

    private void BackButton_Click(object? sender, EventArgs e)
    {
        ReturnToMainForm();
    }

    private void PathfindingForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _mainForm.Show();
    }

    private void UpdateSettingsSummary()
    {
        settingsValueLabel.Text =
            $"Animation Speed: {_settings.AnimationSpeed} ms{Environment.NewLine}" +
            $"Number of Items: {_settings.NumberOfItems}{Environment.NewLine}" +
            $"Show Step Details: {(_settings.ShowStepDetails ? "Yes" : "No")}";
    }

    private void ReturnToMainForm()
    {
        _mainForm.Show();
        Close();
    }
}

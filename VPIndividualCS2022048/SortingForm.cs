using VPIndividualCS2022048.Sorting;

namespace VPIndividualCS2022048;

public partial class SortingForm : Form
{
    private readonly MainForm _mainForm;
    private readonly List<ISortingAlgorithm> _algorithms =
    [
        new QuickSortAlgorithm(),
        new MergeSortAlgorithm()
    ];
    private readonly Random _random = new();
    private readonly System.Windows.Forms.Timer _animationTimer = new();
    private VisualizerSettings _settings = new();
    private List<SortStep> _steps = new();
    private int[] _values = [];
    private int _currentStepIndex;
    private bool _isSorting;

    public SortingForm(MainForm mainForm)
    {
        _mainForm = mainForm;
        InitializeComponent();
        algorithmComboBox.DataSource = _algorithms;
        algorithmComboBox.DisplayMember = nameof(ISortingAlgorithm.Name);
        _animationTimer.Tick += AnimationTimer_Tick;
        ApplySettings();
        GenerateNewArray();
        UpdateSettingsSummary();
    }

    private void OpenSettingsButton_Click(object? sender, EventArgs e)
    {
        bool wasRunning = _isSorting;
        StopAnimation();

        using SettingsForm settingsForm = new(_settings);

        if (settingsForm.ShowDialog(this) == DialogResult.OK)
        {
            _settings = settingsForm.SelectedSettings.Clone();
            ApplySettings();
            GenerateNewArray();
            UpdateSettingsSummary();
        }

        if (wasRunning)
        {
            statusLabel.Text = "Settings updated. Generate a new array before sorting again.";
        }
    }

    private void BackButton_Click(object? sender, EventArgs e)
    {
        ReturnToMainForm();
    }

    private void SortingForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _animationTimer.Stop();
        _mainForm.Show();
    }

    private void GenerateButton_Click(object? sender, EventArgs e)
    {
        StopAnimation();
        GenerateNewArray();
    }

    private void StartButton_Click(object? sender, EventArgs e)
    {
        if (_values.Length == 0)
        {
            GenerateNewArray();
        }

        if (_isSorting)
        {
            StopAnimation();
            statusLabel.Text = "Sorting paused.";
            return;
        }

        ISortingAlgorithm selectedAlgorithm = (ISortingAlgorithm)algorithmComboBox.SelectedItem!;
        _steps = selectedAlgorithm.CreateSteps(_values);
        _currentStepIndex = 0;
        _isSorting = true;
        _animationTimer.Start();
        startButton.Text = "Pause";
        SetControlsForSorting(true);
        statusLabel.Text = $"Running {selectedAlgorithm.Name}...";
    }

    private void VisualizerPanel_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.Clear(Color.FromArgb(250, 251, 252));

        if (_values.Length == 0)
        {
            return;
        }

        int[] activeIndices = [];
        int[] sortedIndices = [];

        if (_steps.Count > 0 && _currentStepIndex >= 0)
        {
            int stepIndex = Math.Min(_currentStepIndex, _steps.Count - 1);
            activeIndices = _steps[stepIndex].ActiveIndices;
            sortedIndices = _steps[stepIndex].SortedIndices;
        }

        DrawBars(e.Graphics, visualizerPanel.ClientRectangle, _values, activeIndices, sortedIndices);
    }

    private void AnimationTimer_Tick(object? sender, EventArgs e)
    {
        if (_currentStepIndex >= _steps.Count)
        {
            StopAnimation();
            statusLabel.Text = "Sorting complete.";
            return;
        }

        SortStep step = _steps[_currentStepIndex];
        _values = (int[])step.Snapshot.Clone();
        statusLabel.Text = _settings.ShowStepDetails
            ? step.Description
            : $"Step {_currentStepIndex + 1} of {_steps.Count}";

        visualizerPanel.Invalidate();
        _currentStepIndex++;
    }

    private void UpdateSettingsSummary()
    {
        settingsValueLabel.Text =
            $"Animation Speed: {_settings.AnimationSpeed} ms{Environment.NewLine}" +
            $"Number of Items: {_settings.NumberOfItems}{Environment.NewLine}" +
            $"Show Step Details: {(_settings.ShowStepDetails ? "Yes" : "No")}";
    }

    private void ApplySettings()
    {
        _animationTimer.Interval = Math.Max(10, _settings.AnimationSpeed);
    }

    private void GenerateNewArray()
    {
        _values = Enumerable.Range(0, _settings.NumberOfItems)
            .Select(_ => _random.Next(15, 220))
            .ToArray();
        _steps.Clear();
        _currentStepIndex = 0;
        statusLabel.Text = "New random array generated.";
        visualizerPanel.Invalidate();
        startButton.Text = "Start Sorting";
        SetControlsForSorting(false);
    }

    private void StopAnimation()
    {
        _animationTimer.Stop();
        _isSorting = false;
        startButton.Text = "Start Sorting";
        SetControlsForSorting(false);
    }

    private void SetControlsForSorting(bool isSorting)
    {
        _isSorting = isSorting;
        algorithmComboBox.Enabled = !isSorting;
        generateButton.Enabled = !isSorting;
        openSettingsButton.Enabled = !isSorting;
    }

    private static void DrawBars(
        Graphics graphics,
        Rectangle bounds,
        IReadOnlyList<int> values,
        IReadOnlyCollection<int> activeIndices,
        IReadOnlyCollection<int> sortedIndices)
    {
        if (values.Count == 0)
        {
            return;
        }

        int margin = 12;
        int chartHeight = Math.Max(1, bounds.Height - (margin * 2));
        int chartWidth = Math.Max(1, bounds.Width - (margin * 2));
        int barWidth = Math.Max(4, chartWidth / values.Count);
        int maxValue = values.Max();

        using SolidBrush defaultBrush = new(Color.FromArgb(52, 152, 219));
        using SolidBrush activeBrush = new(Color.FromArgb(231, 76, 60));
        using SolidBrush sortedBrush = new(Color.FromArgb(46, 204, 113));
        using Pen borderPen = new(Color.FromArgb(33, 47, 61));

        HashSet<int> activeSet = activeIndices.ToHashSet();
        HashSet<int> sortedSet = sortedIndices.ToHashSet();

        for (int index = 0; index < values.Count; index++)
        {
            int barHeight = (int)Math.Round((double)values[index] / maxValue * chartHeight);
            int x = bounds.Left + margin + (index * barWidth);
            int y = bounds.Bottom - margin - barHeight;
            int width = Math.Max(2, barWidth - 2);
            Rectangle barRectangle = new(x, y, width, barHeight);

            SolidBrush brush = defaultBrush;
            if (sortedSet.Contains(index))
            {
                brush = sortedBrush;
            }
            else if (activeSet.Contains(index))
            {
                brush = activeBrush;
            }

            graphics.FillRectangle(brush, barRectangle);
            graphics.DrawRectangle(borderPen, barRectangle);
        }
    }

    private void ReturnToMainForm()
    {
        _mainForm.Show();
        Close();
    }
}

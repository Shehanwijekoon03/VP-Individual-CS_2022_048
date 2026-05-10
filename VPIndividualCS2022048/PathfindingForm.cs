using VPIndividualCS2022048.Pathfinding;

namespace VPIndividualCS2022048;

public partial class PathfindingForm : Form
{
    private const int GridSize = 20;
    private readonly MainForm _mainForm;
    private readonly DijkstraPathfinder _pathfinder = new();
    private readonly System.Windows.Forms.Timer _animationTimer = new();
    private VisualizerSettings _settings = new();
    private GridCellState[,] _grid = new GridCellState[GridSize, GridSize];
    private readonly Point _startPoint = new(1, 1);
    private readonly Point _endPoint = new(GridSize - 2, GridSize - 2);
    private List<PathfindingStep> _steps = new();
    private int _currentStepIndex;
    private bool _isAnimating;

    public PathfindingForm(MainForm mainForm)
    {
        _mainForm = mainForm;
        InitializeComponent();
        _animationTimer.Tick += AnimationTimer_Tick;
        ApplySettings();
        ResetGrid();
        UpdateSettingsSummary();
    }

    private void OpenSettingsButton_Click(object? sender, EventArgs e)
    {
        StopAnimation();

        using SettingsForm settingsForm = new(_settings);

        if (settingsForm.ShowDialog(this) == DialogResult.OK)
        {
            _settings = settingsForm.SelectedSettings.Clone();
            ApplySettings();
            UpdateSettingsSummary();
        }
    }

    private void BackButton_Click(object? sender, EventArgs e)
    {
        ReturnToMainForm();
    }

    private void PathfindingForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _animationTimer.Stop();
        _mainForm.Show();
    }

    private void StartButton_Click(object? sender, EventArgs e)
    {
        if (_isAnimating)
        {
            StopAnimation();
            statusLabel.Text = "Pathfinding paused.";
            return;
        }

        RestoreEditableGridState();
        _steps = _pathfinder.CreateSteps(_grid, _startPoint, _endPoint);
        _currentStepIndex = 0;
        _isAnimating = true;
        _animationTimer.Start();
        startButton.Text = "Pause";
        SetEditingEnabled(false);
        statusLabel.Text = "Running Dijkstra search...";
    }

    private void ClearWallsButton_Click(object? sender, EventArgs e)
    {
        StopAnimation();

        for (int row = 0; row < GridSize; row++)
        {
            for (int column = 0; column < GridSize; column++)
            {
                if (_grid[row, column] == GridCellState.Wall)
                {
                    _grid[row, column] = GridCellState.Empty;
                }
            }
        }

        ReapplyAnchors();
        statusLabel.Text = "Walls cleared.";
        gridPanel.Invalidate();
    }

    private void ResetGridButton_Click(object? sender, EventArgs e)
    {
        StopAnimation();
        ResetGrid();
        statusLabel.Text = "Grid reset.";
    }

    private void GridPanel_Paint(object? sender, PaintEventArgs e)
    {
        DrawGrid(e.Graphics, gridPanel.ClientRectangle);
    }

    private void GridPanel_MouseClick(object? sender, MouseEventArgs e)
    {
        if (_isAnimating)
        {
            return;
        }

        if (!TryGetCellFromMouse(e.Location, out Point cell))
        {
            return;
        }

        if (cell == _startPoint || cell == _endPoint)
        {
            statusLabel.Text = "Start and end cells are fixed for this version.";
            return;
        }

        _grid[cell.Y, cell.X] = _grid[cell.Y, cell.X] == GridCellState.Wall
            ? GridCellState.Empty
            : GridCellState.Wall;

        statusLabel.Text = _grid[cell.Y, cell.X] == GridCellState.Wall
            ? $"Wall added at ({cell.X}, {cell.Y})."
            : $"Wall removed at ({cell.X}, {cell.Y}).";

        gridPanel.Invalidate();
    }

    private void AnimationTimer_Tick(object? sender, EventArgs e)
    {
        if (_currentStepIndex >= _steps.Count)
        {
            StopAnimation();
            statusLabel.Text = "Pathfinding complete.";
            return;
        }

        PathfindingStep step = _steps[_currentStepIndex];
        _grid = (GridCellState[,])step.Snapshot.Clone();
        ReapplyAnchors();
        statusLabel.Text = _settings.ShowStepDetails
            ? step.Description
            : $"Step {_currentStepIndex + 1} of {_steps.Count}";
        gridPanel.Invalidate();
        _currentStepIndex++;
    }

    private void UpdateSettingsSummary()
    {
        settingsValueLabel.Text =
            $"Animation Speed: {_settings.AnimationSpeed} ms{Environment.NewLine}" +
            $"Grid Size: {GridSize} x {GridSize}{Environment.NewLine}" +
            $"Show Step Details: {(_settings.ShowStepDetails ? "Yes" : "No")}";
    }

    private void ApplySettings()
    {
        _animationTimer.Interval = Math.Max(10, _settings.AnimationSpeed);
    }

    private void ResetGrid()
    {
        _grid = new GridCellState[GridSize, GridSize];
        _steps.Clear();
        _currentStepIndex = 0;
        ReapplyAnchors();
        SetEditingEnabled(true);
        startButton.Text = "Start Dijkstra";
        gridPanel.Invalidate();
    }

    private void StopAnimation()
    {
        _animationTimer.Stop();
        _isAnimating = false;
        startButton.Text = "Start Dijkstra";
        SetEditingEnabled(true);
    }

    private void SetEditingEnabled(bool enabled)
    {
        _isAnimating = !enabled && _animationTimer.Enabled;
        clearWallsButton.Enabled = enabled;
        resetGridButton.Enabled = enabled;
        openSettingsButton.Enabled = enabled;
    }

    private void RestoreEditableGridState()
    {
        for (int row = 0; row < GridSize; row++)
        {
            for (int column = 0; column < GridSize; column++)
            {
                if (_grid[row, column] is GridCellState.Visited or GridCellState.Path)
                {
                    _grid[row, column] = GridCellState.Empty;
                }
            }
        }

        ReapplyAnchors();
    }

    private void ReapplyAnchors()
    {
        _grid[_startPoint.Y, _startPoint.X] = GridCellState.Start;
        _grid[_endPoint.Y, _endPoint.X] = GridCellState.End;
    }

    private bool TryGetCellFromMouse(Point location, out Point cell)
    {
        int cellWidth = Math.Max(1, gridPanel.ClientSize.Width / GridSize);
        int cellHeight = Math.Max(1, gridPanel.ClientSize.Height / GridSize);
        int column = location.X / cellWidth;
        int row = location.Y / cellHeight;

        if (column < 0 || column >= GridSize || row < 0 || row >= GridSize)
        {
            cell = Point.Empty;
            return false;
        }

        cell = new Point(column, row);
        return true;
    }

    private void DrawGrid(Graphics graphics, Rectangle bounds)
    {
        graphics.Clear(Color.White);

        int cellWidth = Math.Max(1, bounds.Width / GridSize);
        int cellHeight = Math.Max(1, bounds.Height / GridSize);

        using Pen gridPen = new(Color.FromArgb(189, 195, 199));
        using SolidBrush emptyBrush = new(Color.White);
        using SolidBrush wallBrush = new(Color.FromArgb(44, 62, 80));
        using SolidBrush startBrush = new(Color.FromArgb(46, 204, 113));
        using SolidBrush endBrush = new(Color.FromArgb(231, 76, 60));
        using SolidBrush visitedBrush = new(Color.FromArgb(52, 152, 219));
        using SolidBrush pathBrush = new(Color.FromArgb(241, 196, 15));

        for (int row = 0; row < GridSize; row++)
        {
            for (int column = 0; column < GridSize; column++)
            {
                Rectangle cellBounds = new(
                    bounds.Left + (column * cellWidth),
                    bounds.Top + (row * cellHeight),
                    cellWidth,
                    cellHeight);

                SolidBrush brush = _grid[row, column] switch
                {
                    GridCellState.Wall => wallBrush,
                    GridCellState.Start => startBrush,
                    GridCellState.End => endBrush,
                    GridCellState.Visited => visitedBrush,
                    GridCellState.Path => pathBrush,
                    _ => emptyBrush
                };

                graphics.FillRectangle(brush, cellBounds);
                graphics.DrawRectangle(gridPen, cellBounds);
            }
        }
    }

    private void ReturnToMainForm()
    {
        _mainForm.Show();
        Close();
    }
}

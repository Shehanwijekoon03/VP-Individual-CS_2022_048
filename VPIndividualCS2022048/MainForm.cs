namespace VPIndividualCS2022048;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void OpenSortingFormButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new SortingForm(this));
    }

    private void OpenPathfindingFormButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new PathfindingForm(this));
    }

    private void ExitButton_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void OpenChildForm(Form childForm)
    {
        Hide();
        childForm.Show();
    }
}

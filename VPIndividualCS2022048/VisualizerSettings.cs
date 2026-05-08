namespace VPIndividualCS2022048;

public class VisualizerSettings
{
    public int AnimationSpeed { get; set; } = 100;

    public int NumberOfItems { get; set; } = 20;

    public bool ShowStepDetails { get; set; } = true;

    public VisualizerSettings Clone()
    {
        return new VisualizerSettings
        {
            AnimationSpeed = AnimationSpeed,
            NumberOfItems = NumberOfItems,
            ShowStepDetails = ShowStepDetails
        };
    }
}

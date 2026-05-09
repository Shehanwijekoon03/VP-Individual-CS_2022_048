namespace VPIndividualCS2022048.Sorting;

public abstract class SortingAlgorithmBase : ISortingAlgorithm
{
    public abstract string Name { get; }

    public abstract List<SortStep> CreateSteps(int[] values);

    protected static void AddStep(
        List<SortStep> steps,
        int[] values,
        IEnumerable<int> activeIndices,
        IEnumerable<int> sortedIndices,
        string description)
    {
        steps.Add(new SortStep
        {
            Snapshot = (int[])values.Clone(),
            ActiveIndices = activeIndices.Distinct().ToArray(),
            SortedIndices = sortedIndices.Distinct().ToArray(),
            Description = description
        });
    }
}

namespace VPIndividualCS2022048.Sorting;

public interface ISortingAlgorithm
{
    string Name { get; }

    List<SortStep> CreateSteps(int[] values);
}

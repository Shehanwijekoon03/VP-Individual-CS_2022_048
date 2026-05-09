namespace VPIndividualCS2022048.Sorting;

public class SortStep
{
    public required int[] Snapshot { get; init; }

    public required int[] ActiveIndices { get; init; }

    public required int[] SortedIndices { get; init; }

    public required string Description { get; init; }
}

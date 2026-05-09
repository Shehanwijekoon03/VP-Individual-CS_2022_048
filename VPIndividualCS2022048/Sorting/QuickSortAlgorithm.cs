namespace VPIndividualCS2022048.Sorting;

public class QuickSortAlgorithm : SortingAlgorithmBase
{
    public override string Name => "Quick Sort";

    public override List<SortStep> CreateSteps(int[] values)
    {
        int[] workingValues = (int[])values.Clone();
        List<SortStep> steps = new();
        HashSet<int> sortedIndices = new();

        AddStep(steps, workingValues, Array.Empty<int>(), Array.Empty<int>(), "Unsorted array generated.");

        QuickSort(workingValues, 0, workingValues.Length - 1, steps, sortedIndices);

        sortedIndices = Enumerable.Range(0, workingValues.Length).ToHashSet();
        AddStep(steps, workingValues, Array.Empty<int>(), sortedIndices, "Quick Sort completed.");
        return steps;
    }

    private static void QuickSort(
        int[] values,
        int low,
        int high,
        List<SortStep> steps,
        HashSet<int> sortedIndices)
    {
        if (low > high)
        {
            return;
        }

        if (low == high)
        {
            sortedIndices.Add(low);
            AddStep(steps, values, new[] { low }, sortedIndices, $"Element at index {low} is in its final position.");
            return;
        }

        int pivotIndex = Partition(values, low, high, steps, sortedIndices);
        sortedIndices.Add(pivotIndex);
        AddStep(steps, values, new[] { pivotIndex }, sortedIndices, $"Pivot locked at index {pivotIndex}.");

        QuickSort(values, low, pivotIndex - 1, steps, sortedIndices);
        QuickSort(values, pivotIndex + 1, high, steps, sortedIndices);
    }

    private static int Partition(
        int[] values,
        int low,
        int high,
        List<SortStep> steps,
        HashSet<int> sortedIndices)
    {
        int pivot = values[high];
        int smallerIndex = low - 1;

        AddStep(
            steps,
            values,
            new[] { high },
            sortedIndices,
            $"Choosing value {pivot} at index {high} as the pivot.");

        for (int current = low; current < high; current++)
        {
            AddStep(
                steps,
                values,
                new[] { current, high },
                sortedIndices,
                $"Comparing value {values[current]} with pivot {pivot}.");

            if (values[current] <= pivot)
            {
                smallerIndex++;
                (values[smallerIndex], values[current]) = (values[current], values[smallerIndex]);

                AddStep(
                    steps,
                    values,
                    new[] { smallerIndex, current, high },
                    sortedIndices,
                    $"Moved {values[smallerIndex]} into the low partition.");
            }
        }

        int pivotTarget = smallerIndex + 1;
        (values[pivotTarget], values[high]) = (values[high], values[pivotTarget]);

        AddStep(
            steps,
            values,
            new[] { pivotTarget, high },
            sortedIndices,
            $"Placed pivot {pivot} at index {pivotTarget}.");

        return pivotTarget;
    }
}

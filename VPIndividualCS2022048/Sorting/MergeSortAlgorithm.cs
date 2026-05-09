namespace VPIndividualCS2022048.Sorting;

public class MergeSortAlgorithm : SortingAlgorithmBase
{
    public override string Name => "Merge Sort";

    public override List<SortStep> CreateSteps(int[] values)
    {
        int[] workingValues = (int[])values.Clone();
        List<SortStep> steps = new();

        AddStep(steps, workingValues, Array.Empty<int>(), Array.Empty<int>(), "Unsorted array generated.");
        MergeSort(workingValues, 0, workingValues.Length - 1, steps);

        int[] sortedIndices = Enumerable.Range(0, workingValues.Length).ToArray();
        AddStep(steps, workingValues, Array.Empty<int>(), sortedIndices, "Merge Sort completed.");
        return steps;
    }

    private static void MergeSort(int[] values, int left, int right, List<SortStep> steps)
    {
        if (left >= right)
        {
            return;
        }

        int middle = left + (right - left) / 2;
        MergeSort(values, left, middle, steps);
        MergeSort(values, middle + 1, right, steps);
        Merge(values, left, middle, right, steps);
    }

    private static void Merge(int[] values, int left, int middle, int right, List<SortStep> steps)
    {
        int[] leftArray = values[left..(middle + 1)];
        int[] rightArray = values[(middle + 1)..(right + 1)];
        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = left;

        AddStep(
            steps,
            values,
            Enumerable.Range(left, right - left + 1),
            Array.Empty<int>(),
            $"Merging ranges {left}-{middle} and {middle + 1}-{right}.");

        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            int currentLeftValue = leftArray[leftIndex];
            int currentRightValue = rightArray[rightIndex];
            AddStep(
                steps,
                values,
                new[] { left + leftIndex, middle + 1 + rightIndex, mergedIndex },
                Array.Empty<int>(),
                $"Comparing {currentLeftValue} and {currentRightValue}.");

            if (currentLeftValue <= currentRightValue)
            {
                values[mergedIndex] = currentLeftValue;
                leftIndex++;
            }
            else
            {
                values[mergedIndex] = currentRightValue;
                rightIndex++;
            }

            AddStep(
                steps,
                values,
                new[] { mergedIndex },
                Array.Empty<int>(),
                $"Wrote value {values[mergedIndex]} at index {mergedIndex}.");

            mergedIndex++;
        }

        while (leftIndex < leftArray.Length)
        {
            values[mergedIndex] = leftArray[leftIndex];
            AddStep(
                steps,
                values,
                new[] { mergedIndex },
                Array.Empty<int>(),
                $"Copied remaining left value {values[mergedIndex]} to index {mergedIndex}.");

            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < rightArray.Length)
        {
            values[mergedIndex] = rightArray[rightIndex];
            AddStep(
                steps,
                values,
                new[] { mergedIndex },
                Array.Empty<int>(),
                $"Copied remaining right value {values[mergedIndex]} to index {mergedIndex}.");

            rightIndex++;
            mergedIndex++;
        }

        int[] mergedRange = Enumerable.Range(left, right - left + 1).ToArray();
        AddStep(
            steps,
            values,
            mergedRange,
            mergedRange,
            $"Merged section {left}-{right} is now sorted.");
    }
}

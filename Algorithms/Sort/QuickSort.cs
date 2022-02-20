using System.Collections.Generic;

namespace Algorithms.Sort;

/// <summary>
/// Like Merge Sort, Quick Sort is a divide and conquer algorithm. It picks an
/// element as pivot and partitions the given array around the picked pivot.
///
/// </summary>
public static class QuickSort
{
    /// <summary>
    /// This function takes last element as pivot, places the pivot element
    /// at its correct position in sorted array, and places all smaller
    /// (smaller than pivot) to left of pivot and all greater elements to
    /// right of pivot
    /// </summary>
    /// <param name="arr">The array to be sorted</param>
    /// <param name="low">lowest index</param>
    /// <param name="high">highest index</param>
    /// <returns>position of the current pivot in the array</returns>
    private static int Partition(List<int> arr, int low, int high)
    {
        var pivot = arr[high];

        var i = low - 1;

        for (var j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    private static void Quick(List<int> arr, int low, int high)
    {
        if (low < high)
        {
            var pi = Partition(arr, low, high);

            Quick(arr, low, pi - 1);
            Quick(arr, pi + 1, high);
        }
    }

    public static List<int> Sort(List<int> arr)
    {
        var n = arr.Count;
        Quick(arr, 0, n - 1);
        return arr;
    }
}

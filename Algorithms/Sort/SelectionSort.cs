using System.Collections.Generic;

namespace Algorithms.Sort;

/// <summary>
/// The selection sort algorithm sorts an array by repeatedly finding the
/// minimum element (considering as ascending order) from unsorted part and
/// putting it at the beginning. The algorithm maintains two subarrays in a
/// given array.
///
/// 1) The Subarray which is already sorted.
/// 2) Remaining subarray which is unsorted.
///
/// In every iteration of selection sort, the minimum element (considering
/// ascending order) from the unsorted subarray is picked and moved to the
/// sorted subarray.
/// </summary>
public static class SelectionSort
{
    public static List<int> Sort(List<int> arr)
    {
        var length = arr.Count;
        if (length <= 0)
        {
            return arr;
        }

        for (var i = 0; i < length; i++)
        {
            var min = i;
            for (var j = i + 1; j < length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            (arr[i], arr[min]) = (arr[min], arr[i]);
        }

        return arr;
    }
}

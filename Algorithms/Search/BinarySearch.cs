using System.Collections.Generic;

namespace Algorithms.Search;

public static class BinarySearch
{
    private static int Search(List<int> arr, int left, int right, int num)
    {
        if (left > right)
        {
            return -1;
        }

        var middle = right - left / 2;
        if (arr[middle] == num)
        {
            return middle;
        }

        return arr[middle] > num ? Search(arr, left, middle - 1, num) : Search(arr, middle + 1, right, num);
    }

    public static int Search(List<int> arr, int num)
    {
        return Search(arr, 0, arr.Count - 1, num);
    }
}

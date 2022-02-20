using System.Collections.Generic;

namespace Algorithms.Search;

public static class LinearSearch
{
    public static int Search(List<int> arr, int num)
    {
        for (var i = 0; i < arr.Count; i++)
        {
            if (arr[i] == num)
            {
                return i;
            }
        }

        return 0;
    }
}

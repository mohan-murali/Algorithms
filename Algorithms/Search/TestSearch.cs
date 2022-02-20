using System;
using System.Collections.Generic;

namespace Algorithms.Search;

public static class TestSearch
{
    public static void Test(Func<List<int>, int, int> search, string type)
    {
        var array1 = new List<int>() { 1, 4, 8, 10, 12 };
        var index = search(array1, 8);
        Console.WriteLine($"the result of the first search of ${type} is -->{index}");

        var array2 = new List<int>() { 1, 4, 8, 10, 12, 25, 36, 37, 38, 39, 40, 45, 51, 53, 55, 56, 57, 58, 59, 62, 63, 64, 65, 67, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82 };
        var index2 = search(array2, 80);
        Console.WriteLine($"the result of the second search of ${type} is -->{index2}");
    }
}

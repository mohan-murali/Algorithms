using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    /// <summary>
    /// Bubble Sort is an algorithm to sort an array. It
    /// compares adjacent elements and swaps their position
    /// The big O on bubble sort is O(n^2).
    /// Not efficient.
    ///
    /// In bubble sort, we keep iterating while something was swapped in
    /// the previous inner-loop iteration. By swapped I mean, in the
    /// inner loop iteration, we check each number if the number proceeding
    /// it is greater then itself, if so we swap them.
    ///
    /// Wikipedia: https://en.wikipedia.org/wiki/Bubble_sort
    ///  Animated Visual: https://www.toptal.com/developers/sorting-algorithms/bubble-sort
    /// </summary>
    public static class BubbleSort
    {
        public static List<int> Sort(List<int> array)
        {
            var length = array.Count;

            for (var i = 0; i < length; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }

            return array;
        }
    }
}
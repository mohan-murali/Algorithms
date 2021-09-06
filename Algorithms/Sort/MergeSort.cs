using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    /// <summary>
    /// Merge Sort is a divide and conquer algorithm where the main list is divided
    /// down into two half sized lists, which then have merge sort called on these
    /// two smaller lists recursively until there is only a sorted list of one.
    ///
    /// On thw way up the recursive calls, the lists will be merged together inserting
    /// the smaller value first, creating a larger sorted list.
    /// </summary>
    public static class MergeSort
    {
        private static List<int> Merge (List<int> left, List<int> right)
        {
            var result = new List<int>();

            var i = 0;
            var j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (right[j] < left[i])
                {
                    result.Add(right[j++]);
                }
                else
                {
                    result.Add(left[i++]);
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i++]);
            }

            while (j < right.Count)
            {
                result.Add(right[j++]);
            }

            return result;
        }

        public static List<int> Sort(List<int> arr)
        {
            if (arr.Count < 2)
            {
                return arr;
            }
            var mid = arr.Count / 2;
            
            var left = new List<int>();
            for (var i = 0; i < mid; i++)
            {
                left.Add(arr[i]);
            }

            var right = new List<int>();

            for (var i = mid; i < arr.Count; i++)
            {
                right.Add(arr[i]);
            }

            var newLeft = Sort(left);
            var newRight = Sort(right);

            return Merge(newLeft, newRight);
        }
    }
}
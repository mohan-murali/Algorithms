using System;
using Algorithms.Search;
using Algorithms.Sort;

namespace Algorithms
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Sort function tests
            // TestSort.Test(BubbleSort.Sort, "Bubble Sort");
            // TestSort.Test(SelectionSort.Sort, "Selection Sort");
            // TestSort.Test(MergeSort.Sort, "Merge Sort");
            // TestSort.Test(QuickSort.Sort, "Quick Sort");
            
            //Search function tests
            TestSearch.Test(LinearSearch.Search, "Linear Search");
            TestSearch.Test(BinarySearch.Search, "Binary Search");
        }
    }
}
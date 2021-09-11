using System;
using Algorithms.Sort;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSort.Test(BubbleSort.Sort, "Bubble Sort");
            TestSort.Test(SelectionSort.Sort, "Selection Sort");
            TestSort.Test(MergeSort.Sort, "Merge Sort");
            TestSort.Test(QuickSort.Sort, "Quick Sort");
        }
    }
}
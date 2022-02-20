﻿using Algorithms.Datastructures;

namespace Algorithms;

static class Program
{
    static void Main(string[] args)
    {
        //Sort function tests
        // TestSort.Test(BubbleSort.Sort, "Bubble Sort");
        // TestSort.Test(SelectionSort.Sort, "Selection Sort");
        // TestSort.Test(MergeSort.Sort, "Merge Sort");
        // TestSort.Test(QuickSort.Sort, "Quick Sort");

        // //Search function tests
        // TestSearch.Test(LinearSearch.Search, "Linear Search");
        // TestSearch.Test(BinarySearch.Search, "Binary Search");

        var list = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        list.head = node1;

        list.PrintElements();

        var list2 = new LinkedList();
        list2.AddFirst(10);
        list2.AddLast(5);
        list2.AddLast(6);
        list2.AddLast(7);
        list2.AddLast(8);

        list2.PrintElements();

        list2.AddFirst(1);
        list2.AddFirst(2);
        list2.AddFirst(3);
        list2.AddFirst(4);

        list2.PrintElements();
    }
}

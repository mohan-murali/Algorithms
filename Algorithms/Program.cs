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

        // var list = new LinkedList();

        // var node1 = new Node(1);
        // var node2 = new Node(2);
        // var node3 = new Node(3);
        // var node4 = new Node(4);
        // node1.next = node2;
        // node2.next = node3;
        // node3.next = node4;
        // list.head = node1;

        // System.Console.WriteLine("list one is as follows");
        // list.PrintElements();

        // var list2 = new LinkedList();
        // list2.AddFirst(10);
        // list2.AddLast(5);
        // list2.AddLast(6);
        // list2.AddLast(7);
        // list2.AddLast(8);

        // System.Console.WriteLine("list 2 add last till here");
        // list2.PrintElements();

        // list2.AddFirst(1);
        // list2.AddFirst(2);
        // list2.AddFirst(3);
        // list2.AddFirst(4);

        // System.Console.WriteLine("whole list add here");
        // list2.PrintElements();

        // System.Console.WriteLine("with the deleted value");
        // list2.DeleteValue(5);
        // list2.DeleteFirst();

        // list2.PrintElements();
        // System.Console.WriteLine("deleting first few values");
        // list2.DeleteFirst();
        // list2.DeleteFirst();
        // list2.DeleteValue(10);
        // list2.PrintElements();

        // var list = new DoublyLinkedList();
        // list.AddLast(1);
        // list.AddLast(2);
        // list.AddLast(3);
        // list.AddLast(4);
        // list.PrintElementInReverse();

        var queue = new Queue<int>(10);
        System.Console.WriteLine(queue.GetLength());
        queue.Enqueue(20);
        queue.Enqueue(9);
        queue.Enqueue(6);
        queue.Enqueue(15);

        queue.PrintElements();

        System.Console.WriteLine(queue.Dequeue());

        queue.PrintElements();

        System.Console.WriteLine(queue.GetLength());

        System.Console.WriteLine(queue.Peek());

    }
}

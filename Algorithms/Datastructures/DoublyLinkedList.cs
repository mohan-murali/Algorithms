using System;
namespace Algorithms.Datastructures;

public class DoublyLinkedList
{
    public DNode head;

    public void AddLast(int value)
    {
        if (head == null)
        {
            head = new DNode(value);

        }
        else
        {
            var curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = new DNode(value);
            curr.next.previous = curr;
        }
    }

    public void PrintElementInReverse()
    {
        if (head == null) return;
        var curr = head;
        while (curr.next != null)
        {
            curr = curr.next;
        }

        while (curr.previous != null)
        {
            Console.WriteLine(curr.Data);
            curr = curr.previous;
        }

        Console.WriteLine(curr.Data);
    }

}

public class DNode
{
    public int Data;
    public DNode next;
    public DNode previous;

    public DNode(int val)
    {
        Data = val;
    }
}
namespace Algorithms.Datastructures;

public class LinkedList
{
    public Node head { get; set; }

    public void AddLast(int data)
    {
        if (head == null)
        {
            head = new Node(data);
        }
        else
        {
            var current = head;

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
        }
    }

    public void AddFirst(int data)
    {
        if (head == null)
        {
            head = new Node(data);
        }
        else
        {
            var temp = head;
            head = new Node(data);
            head.next = temp;
        }
    }

    public void PrintElements()
    {
        var node = head;

        while (node != null)
        {
            System.Console.WriteLine(node.data);
            node = node.next;
        }
    }
}

public class Node
{
    public int data { get; set; }
    public Node next { get; set; }

    public Node(int _data)
    {
        data = _data;
        next = null;
    }
}
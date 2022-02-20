namespace Algorithms.Datastructures;

public class LinkedList
{
    public Node head { get; set; }
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
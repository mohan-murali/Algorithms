namespace Algorithms.Datastructures;
public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
}
public class Queue<T>
{
    private int length = 0;
    private Node<T> Tail;
    private Node<T> Head;
    public Queue(T value)
    {
        Tail = new Node<T> { Value = value };
        Head = Tail;
        length++;
    }

    public int GetLength()
    {
        return length;
    }

    public void Enqueue(T value)
    {
        var temp = new Node<T> { Value = value };
        Tail.Next = temp;
        Tail = Tail.Next;
        length++;
    }

    public T Dequeue()
    {
        var value = Head.Value;
        Head = Head.Next;
        length--;
        return value;
    }

    public T Peek()
    {
        return Tail.Value;
    }

    public void PrintElements()
    {
        var curr = Head;
        while (curr != null)
        {
            System.Console.WriteLine(curr.Value);
            curr = curr.Next;
        }
    }
}
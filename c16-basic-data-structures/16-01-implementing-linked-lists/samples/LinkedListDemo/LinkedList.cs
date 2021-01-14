using System;

public class LinkedList
{
    private Node first;

    public LinkedList()
    {
        first = null;
    }

    public object GetFirst()
    {
        if (first == null) { throw new InvalidOperationException(); }
        return first.data;
    }

    public void AddFirst(object element)
    {
        Node newNode = new Node();
        newNode.data = element;
        newNode.next = first;
        first = newNode;
    }

    public object RemoveFirst()
    {
        if (first == null) { throw new InvalidOperationException(); }
        object element = first.data;
        first = first.next;
        return element;
    }

    private class Node
    {
        public object data;
        public Node next;
    }
}
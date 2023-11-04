using System;
using System.Collections;
using System.Collections.Generic;

public class List<T> : ICollection<T>
{
    public ListNode<T> First { get; private set; }
    public ListNode<T> Last { get; private set; }

    public List(){}

    public List(IEnumerable<T> collection)
    {
        foreach (T item in collection)
            Add(item);
    }

    public int Count {get; private set; }

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        var node = new ListNode<T>(item);
        Count++;

        if(First is null)
        {
            First = node;
            Last = node;
            return;
        }

        Last.Next = node;
        Last = node;
    }

    public void Clear()
    {
        First = null;
        Last = null;
        Count = 0;
    }

    public void ClearAll()
    {
        if(First == null)
            return;

        Clear(First);
        Clear();
    }

    private void Clear(ListNode<T> node)
    {
        if(node.Next == null)
            return;

        Clear(node.Next);
        node.Invalidate();
    }

    public bool Contains(T item)
    {
        return Find(item) != null;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array == null)
            throw new ArgumentNullException();

        if (arrayIndex < 0)
            throw new ArgumentOutOfRangeException();

        if (arrayIndex > array.Length)
            throw new ArgumentOutOfRangeException();

        if (array.Length - arrayIndex < Count)
            throw new ArgumentException();

        for (var node = First; node != null; node = node.Next)
        {
            array[arrayIndex++] = node.Value;
        }
    }

    public bool Remove(T item)
    {
        var node = Find(item, out var previous);

        if(node == null)
            return false;

        Count--;

        if(node == First && First == Last)
        {
            First = null;
            Last = null;
            return true;
        }

        if(node == Last)
            Last = previous;

        if (node == First)
            First = First.Next;
        else
            previous.Next = node.Next;

        node.Invalidate();
        return true;
    }

    public ListNode<T> Find(T value)
    {
        return Find(value, out var previous);
    }

    public ListNode<T> Find(T value, out ListNode<T> previous)
    {
        previous = null;

        for (var node = First; node != null; node = node.Next)
        {
            if (node.Value.Equals(value))
                return node;

            previous = node;
        }

        previous = null;
        return null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return GetListValues(Count).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<T> GetListValues(int count)
    {
        var current = First;

        for (int i = 0; i < count; i++)
        {
            if (i == Count)
                yield break;

            yield return current.Value;
            current = current.Next;
        }
    }

    public void ForEach(Action<T> action)
    {
        foreach (var item in this)
        {
            action?.Invoke(item);
        }
    }
}


public sealed class ListNode<T>
{
    public T Value { get; set; }

    public ListNode<T> Next { get; internal set; }

    public ListNode(T value) => Value = value; 
    
    internal void Invalidate() => Next = null;
}

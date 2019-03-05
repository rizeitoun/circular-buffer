using System;
using System.Collections.Generic;

// Creates a first-in first-out generic buffer with a defined maximum size.  If buffer is full, error for writing a new element.  Reading buffer removes first item from it.
public class CircularBuffer<T>
{
    private Queue<T> queue = new Queue<T>();
    private int capacity;

    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;
    }

    public T Read()
    {
        if (queue.Count > 0)
        {
            return queue.Dequeue();
        }
        throw new InvalidOperationException();
    }

    public void Write(T value)
    {
        if (queue.Count < capacity)
        {
            queue.Enqueue(value);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void Overwrite(T value)
    {
        if (queue.Count == capacity)
        {
            queue.Dequeue();
        }
        queue.Enqueue(value);
    }

    public void Clear()
    {
        queue.Clear();
    }
}
using System;
using System.Collections.Generic;

public class Fila<T> : IFila<T>
{
    private List<T> elementos = new List<T>();

    public void Enqueue(T item)
    {
        elementos.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        var item = elementos[0];
        elementos.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return elementos[0];
    }

    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }
}

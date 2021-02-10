using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        List<T> elements;

        public BoxOfT()
        {
            elements = new List<T>();
        }

        public void Add(T element)
        {
            elements.Insert(0, element);
        }

        public T Remove()
        {
            T removeElements = elements[0];
            elements.RemoveAt(0);
            return removeElements;
        }

        public int Count { get { return elements.Count; } }
    }
}

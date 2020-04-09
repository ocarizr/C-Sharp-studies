using System;
using System.Collections.Generic;

namespace AmazonStudies.DataStructures
{
    public class Queue<T>
    {
        private LinkedList<T> _data;

        public int Length { get; private set; }

        public bool IsEmpty => Length == 0;

        public void Enqueue(T value)
        {
            _data.AddLast(value);
        }

        public T Peek()
        {
            if (IsEmpty) throw new Exception("Queue is Empty.");

            return _data.First.Value;
        }

        public bool TryDequeue(out T value)
        {
            value = default(T);
            if (IsEmpty) return false;
            
            value = _data.First.Value;
            _data.RemoveFirst();
            return true;
        }
    }
}

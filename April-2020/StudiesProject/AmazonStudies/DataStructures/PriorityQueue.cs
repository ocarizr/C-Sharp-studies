using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStudies.DataStructures
{
    public class PriorityQueue<T> where T : IComparable
    {
        private Heap<T> _data;

        public int Length => _data.Length;

        public bool IsEmpty => _data.IsEmpty;

        public T Poll() => _data.Poll();

        public T Peek => _data.Peek();

        public void Add(T value) => _data.Insert(value);

        public T PollAll()
        {
            while(Length > 1)
            {
                _data.Poll();
            }

            return _data.Poll();
        }

        public void Clear() => _data.Clear();
    }
}

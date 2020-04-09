using System;
using System.Collections.Generic;

namespace AmazonStudies.DataStructures
{
    public class Stack<T>
    {
        private LinkedList<T> _stack;

        public int Lenght => _stack.Count;

        public bool IsEmpty => Lenght == 0;

        public T Pop()
        {
            if (IsEmpty) throw new Exception("Stack is Empty.");

            var temp = _stack.First;
            _stack.RemoveFirst();
            return temp.Value;
        }

        public T Peek() => _stack.First.Value;

        public void Push(T value)
        {
            _stack.AddFirst(value);
        }

        public bool Contains(T value) => _stack.Contains(value);

        public void Clear()
        {
            if (Lenght > 0) _stack.Clear();
        }
    }
}

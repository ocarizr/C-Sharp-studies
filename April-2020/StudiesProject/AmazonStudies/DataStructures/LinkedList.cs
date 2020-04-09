using System;

namespace AmazonStudies.DataStructures
{
    public class Node<T> : IDisposable
    {
        public T Data;
        public Node<T> Next;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    public class LinkedList : IDisposable
    {
        private Node<int> _head;
        private Node<int> _tail;

        public LinkedList() 
        { 
            Lenght = 0;
            _head = null;
            _tail = null;
        }

        ~LinkedList() { Dispose(); }

        public int Lenght { get; private set; }

        public bool IsEmpty => Lenght == 0;

        public int PeekFirst => _head.Data;

        public int PeekLast => _tail.Data;

        public void AddFirst(int value)
        {
            var node = new Node<int>();
            node.Data = value;
            node.Next = _head;

            _head = node;

            ++Lenght;

            if(Lenght == 1)
            {
                _tail = _head;
            }
        }

        public void AddLast(int value)
        {
            if(Lenght == 0)
            {
                AddFirst(value);
                return;
            }

            var node = new Node<int>();
            node.Data = value;
            node.Next = null;

            _tail.Next = node;
            _tail = node;

            ++Lenght;
        }

        public void Remove(int value)
        {
            if(Contains(value))
            {
                Node<int> prev = null;
                var curr = _head;
                while(curr.Data != value)
                {
                    prev = curr;
                    curr = curr.Next;
                }

                prev.Next = curr.Next;
                curr.Dispose();

                --Lenght;
            }            
        }

        public bool Contains(int value)
        {
            if(_head.Data == value)
            {
                return true;
            }
            else
            {
                var curr = _head.Next;

                while(curr != null)
                {
                    if (curr.Data == value) return true;
                    else curr = curr.Next;
                }
            }

            return false;
        }

        public int At(int index)
        {
            if (index >= Lenght) throw new IndexOutOfRangeException();
            else if (index == 0) return _head.Data;
            else if (index == Lenght - 1) return _tail.Data;

            var curr = _head;

            for(var i = 1; i <= index; ++i)
            {
                curr = curr.Next;
            }

            return curr.Data;
        }

        public void Dispose()
        {
            if(Lenght > 0)
            {
                var curr = _head;

                while(curr != null)
                {
                    var temp = curr.Next;
                    curr.Dispose();
                    curr = temp;
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}

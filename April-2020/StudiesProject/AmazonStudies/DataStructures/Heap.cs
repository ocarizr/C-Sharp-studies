using System;
using System.Collections.Generic;

namespace AmazonStudies.DataStructures
{
    public class HeapNode<T> : IDisposable where T : IComparable
    {
        public T Value;
        public HeapNode<T> Left;
        public HeapNode<T> Right;
        public HeapNode<T> Parent;

        public HeapNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
            Parent = null;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is HeapNode<T>)) throw new InvalidCastException();
            var temp = obj as HeapNode<T>;
            return Value.Equals(temp.Value);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    public class Heap<T> where T : IComparable
    {
        private HeapNode<T> _root;
        private HeapNode<T> _currentAdding;

        private List<HeapNode<T>> _nodes;
        private int _currentNodeIndex;

        public int Length { get; private set; }

        public bool IsEmpty => Length == 0;

        public void Insert(T value)
        {
            ++Length;

            if (_root == null)
            {
                _root = new HeapNode<T>(value);
                _nodes.Add(_root);
                _currentAdding = _root;
                _currentNodeIndex = 0;

                return;
            }

            var temp = new HeapNode<T>(value);
            temp.Parent = _currentAdding;
            _nodes.Add(temp);

            if (_currentAdding.Left == null)
            {
                _currentAdding.Left = temp;
                BalanceNodeBranch(_currentAdding.Left);
            }
            else
            {
                _currentAdding.Right = temp;
                BalanceNodeBranch(_currentAdding.Right);

                ++_currentNodeIndex;
                _currentAdding = _nodes[_currentNodeIndex];
            }
        }

        public T Peek()
        {
            if (IsEmpty) throw new Exception("HeapTree is Empty.");

            return _root.Value;
        }

        public T Poll()
        {
            if (IsEmpty) throw new Exception("HeapTree is Empty.");
            
            var res = _root.Value;

            RemoveAndBalance(_root);

            return res;
        }

        public void Remove(T value)
        {
            var node = _nodes.Find(c => c.Value.Equals(value));
            RemoveAndBalance(node);
        }

        public void Clear() => _nodes.ForEach(c => Remove(c.Value));

        private void RemoveAndBalance(HeapNode<T> node)
        {
            var last = _nodes[_nodes.Count - 1];

            (node.Value, last.Value) = (last.Value, node.Value);

            var temp = last.Parent;

            if (temp.Right.Equals(temp)) temp.Right = null;
            else temp.Left = null;

            _nodes.RemoveAt(_nodes.Count - 1);

            last.Dispose();

            --Length;

            BalanceNodeBranch(node);
        }

        private void BalanceNodeBranch(HeapNode<T> node)
        {
            if (node.Parent != null)
            {
                if (node.Value.CompareTo(node.Parent.Value) < 0)
                {
                    (node.Value, node.Parent.Value) = (node.Parent.Value, node.Value);

                    BalanceNodeBranch(node.Parent);
                }
            }

            if (node.Left != null && node.Value.CompareTo(node.Left) > 0)
            {
                (node.Value, node.Left.Value) = (node.Left.Value, node.Value);
                BalanceNodeBranch(node.Left);
            }

            if (node.Right != null && node.Value.CompareTo(node.Right) > 0)
            {
                (node.Value, node.Right.Value) = (node.Right.Value, node.Value);
                BalanceNodeBranch(node.Right);
            }
        }
    }
}

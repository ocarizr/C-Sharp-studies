﻿using System;
using System.Collections.Generic;

namespace AmazonStudies.DataStructures
{
    public class BSTNode<T> : IDisposable, IComparable where T : IComparable
    {
        public T Value { get; set; }
        public BSTNode<T> Parent { get; set; }
        public BSTNode<T> Lower { get; set; }
        public BSTNode<T> Greater { get; set; }

        public BSTNode() : this(default(T)) { }

        public BSTNode(T value)
        {
            Value = value;
            Parent = null;
            Lower = null;
            Greater = null;
        }

        public bool IsNodeBalaced()
        {
            var lowerCheck = Lower != null ? Value.CompareTo(Lower.Value) >= 0 : true;
            var greaterCheck = Greater != null ? Value.CompareTo(Greater.Value) <= 0 : true;
            var childCheck = true;

            if (Parent != null)
            {
                var isLowerThanParent = Value.CompareTo(Parent.Value) <= 0;

                childCheck = isLowerThanParent
                    ? (Lower != null ? Lower.Value.CompareTo(Parent.Value) <= 0 : true) && (Greater != null ? Greater.Value.CompareTo(Parent.Value) <= 0 : true)
                    : (Lower != null ? Lower.Value.CompareTo(Parent.Value) >= 0 : true) && (Greater != null ? Greater.Value.CompareTo(Parent.Value) >= 0 : true);
            }

            return childCheck && lowerCheck && greaterCheck;
        }

        public bool IsGreater(T value) => value.CompareTo(Value) <= 0;

        public void Swap(BSTNode<T> other)
        {
            (other.Value, Value) = (Value, other.Value);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BSTNode<T>)) throw new InvalidCastException();

            var comparable = obj as BSTNode<T>;

            var isValueEqual = comparable.Value.Equals(Value);
            var isLowerEqual = comparable.Lower.Equals(Lower);
            var isGreaterEqual = comparable.Greater.Equals(Greater);

            return isValueEqual && isLowerEqual && isGreaterEqual;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is BSTNode<T>)) throw new InvalidCastException();

            var comparable = obj as BSTNode<T>;

            return Value.CompareTo(comparable.Value);
        }
    }

    public class BinarySearchTree<T> where T : IComparable
    {
        private BSTNode<T> _root;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public BinarySearchTree()
        {
            _root = null;
            Count = 0;
        }

        public BinarySearchTree(T value)
        {
            _root = new BSTNode<T>(value);
            Count = 1;
        }

        public void Insert(T value)
        {
            if(_root == null)
            {
                _root = new BSTNode<T>(value);
                ++Count;
                return;
            }

            if (Contains(value)) return;

            var node = _root;
            var target = node.IsGreater(value) ? node.Lower : node.Greater;

            while(target != null)
            {
                node = node.IsGreater(value) ? node.Lower : node.Greater;
                target = node.IsGreater(value) ? node.Lower : node.Greater;
            }

            if (node.IsGreater(value)) node.Lower = new BSTNode<T>(value);
            else node.Greater = new BSTNode<T>(value);

            ++Count;
        }

        public void InsertBalanced(List<T> values)
        {
            switch (values.Count)
            {
                case 0:
                    return;
                case 1:
                    Insert(values[0]);
                    return;
                default:
                    var rootIndex = values.Count / 2;
                    var rootValue = values[rootIndex];
                    Insert(rootValue);

                    var left = new List<T>();
                    var right = new List<T>();

                    for (var i = 0; i < rootIndex; ++i)
                    {
                        left.Add(values[i]);
                    }

                    for (var i = rootIndex + 1; i < values.Count; ++i)
                    {
                        right.Add(values[i]);
                    }

                    InsertBalanced(left);
                    InsertBalanced(right);
                    break;
            }
        }

        public bool Contains(T value)
        {
            var node = Find(value);
            return node != null;
        }

        public BSTNode<T> Find(T value)
        {
            var node = _root;
            while (node != null && !node.Value.Equals(value))
            {
                node = value.CompareTo(node.Value) <= 0 ? node.Lower : node.Greater;
            }

            return node;
        }

        public void Remove(T value)
        {
            var node = Find(value);
            if (node == null) throw new ArgumentException();

            if (node.Lower != null)
            {
                while (node.Lower != null)
                {
                    var temp = FindGreaterLower(node);
                    node.Swap(temp);
                    node = temp;
                }
                node.Parent.Lower = null;
            }
            else
            {
                var temp = node.Greater;
                temp.Parent = node.Parent;
                if (temp.Parent != null) temp.Parent.Greater = temp;
            }

            node.Dispose();
            --Count;
        }

        /// <summary>
        /// Get ordered elements from the tree.
        /// If is an external call, just provide de List.
        /// </summary>
        /// <param name="elements">The list who will receive the data.</param>
        /// <param name="node">If is an external call, don't give any data to this.</param>
        /// <param name="start">If is an external call, don't give any data to this.</param>
        public void GetElementsOrdered(ref List<T> elements, BSTNode<T> node = null, bool start = true)
        {
            if (node == null)
            {
                if (start) node = _root;
                else return;
            }

            GetElementsOrdered(ref elements, node.Lower, false);
            elements.Add(node.Value);
            GetElementsOrdered(ref elements, node.Greater, false);
        }

        public void Clear()
        {
            var itens = new List<T>();
            GetElementsOrdered(ref itens);

            itens.ForEach(item => Remove(item));
        }

        public void BalanceTree()
        {
            var itens = new List<T>();
            GetElementsOrdered(ref itens);
            Clear();
            InsertBalanced(itens);
        }

        private BSTNode<T> FindGreaterLower(BSTNode<T> node)
        {
            node = node.Lower;

            while(node.Greater != null)
            {
                node = node.Greater;
            }

            return node;
        }
    }
}

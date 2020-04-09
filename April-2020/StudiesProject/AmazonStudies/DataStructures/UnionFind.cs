using System;
using System.Collections.Generic;

namespace AmazonStudies.DataStructures
{
    public class UFNode<T>
    {
        public T Value { get; set; }
        public UFNode<T> Root { get; set; }

        public UFNode(T value)
        {
            Root = null;
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if(obj is UFNode<T>)
            {
                var temp = obj as UFNode<T>;

                return Value.Equals(temp.Value);
            }

            throw new InvalidCastException();
        }
    }

    public class UnionFind<T>
    {
        private Dictionary<T, UFNode<T>> _nodes;

        public void InsertNodes(T value) => _nodes.Add(value, new UFNode<T>(value));

        public void Union(T first, T second)
        {
            if (!Find(first, second))
                Union(_nodes[first], _nodes[second]);
        }

        private void Union(UFNode<T> first, UFNode<T> second)
        {
            if (first.Root == null && second.Root == null)
                second.Root = first;
            else if (first.Root == null && second.Root != null)
                first.Root = second.Root;
            else if (first.Root != null && second.Root == null)
                second.Root = first.Root;
            else
                Union(first.Root, second.Root);
        }

        public bool Find(T first, T second)
        {
            var rootA = GetGroupRoot(_nodes[first].Root);
            var rootB = GetGroupRoot(_nodes[second].Root);

            return rootA.Equals(rootB);
        }

        private UFNode<T> GetGroupRoot(UFNode<T> node)
        {
            while (node.Root != null)
            {
                node = node.Root;
            }

            return node;
        }
    }
}

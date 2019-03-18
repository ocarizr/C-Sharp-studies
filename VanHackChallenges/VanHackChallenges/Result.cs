using System;
using System.Collections.Generic;
using System.Linq;

namespace VanHackChallenges
{
    internal class Node
    {
        public List<Node> EdgesForward;
        public List<Node> EdgesBackward;
        public int Value;

        public Node(int value)
        {
            EdgesForward = new List<Node>();
            EdgesBackward = new List<Node>();
            Value = value;
        }
    }

    internal class Result
    {

        /*
     * Complete the 'maximumDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts UNWEIGHTED_INTEGER_GRAPH g as parameter.
     */

        /*
     * For the unweighted graph, <name>:
     *
     * 1. The number of nodes is <name>Node.
     * 2. The number of edges is <name>Edges.
     * 3. An edge exists between <name>From[i] and <name>To[i].
     *
     */
        #region ChallengeOne

        public static int MaximumDifference(int gNodes, List<int> gFrom, List<int> gTo)
        {
            int maxDifference = 0;

            List<int> elementsConnections = new List<int>();

            for (int i = 0; i < gNodes; i++)
            {
                elementsConnections.Insert(i, 0);
            }

            for (int i = 0; i < gFrom.Count; i++)
            {
                elementsConnections[gFrom[i] - 1]++;
                elementsConnections[gTo[i] - 1]++;
            }

            List<List<int>> groupsOfElements = GetNodeGroups(elementsConnections);

            foreach (List<int> groupOfElements in groupsOfElements)
            {
                foreach (int element in groupOfElements)
                {
                    Console.WriteLine(element);
                }

                Console.WriteLine();
            }

            int[] difference = Difference(groupsOfElements);

            foreach (int value in difference)
            {
                if (value > maxDifference) maxDifference = value;
            }

            return maxDifference;
        }

        private static List<List<int>> GetNodeGroups(List<int> elementsConnectionCount)
        {
            List<List<int>> groups = new List<List<int>>();
            List<int> group = new List<int>();
            bool first = false;

            for (var i = 0; i < elementsConnectionCount.Count; i++)
            {
                if (i == 0 || i == elementsConnectionCount.Count - 1)
                {
                    if (elementsConnectionCount[i] == 0)
                    {
                        group.Add(i + 1);
                        CloseGroup(group, groups);
                    }
                    else if (i == 0)
                    {
                        group.Add(i + 1);
                    }
                    else if (i == elementsConnectionCount.Count - 1)
                    {
                        if (group.Count == 0)
                        {
                            groups.Last().Add(i + 1);
                        }
                        else
                        {
                            group.Add(i + 1);
                            CloseGroup(group, groups);
                        }
                    }
                }
                else
                {
                    if (elementsConnectionCount[i] == 1)
                    {
                        if (first)
                        {
                            group.Add(i + 1);
                            first = false;
                        }
                        else
                        {
                            if (elementsConnectionCount[i + 1] > 1 || ((i + 1) == elementsConnectionCount.Count - 1 && elementsConnectionCount[i + 1] == 1))
                            {
                                group.Add(i + 1);
                            }
                            else
                            {
                                group.Add(i + 1);
                                CloseGroup(group, groups);
                                first = true;
                            }
                        }
                    }
                    else if (elementsConnectionCount[i] == 0)
                    {
                        group.Add(i + 1);
                        CloseGroup(group, groups);
                    }
                    else
                    {
                        group.Add(i + 1);
                    }
                }
            }

            return groups;
        }

        private static void CloseGroup(List<int> group, List<List<int>> groups)
        {
            var groupToAdd = new List<int>(group);
            groups.Add(groupToAdd);
            group.Clear();
        }

        private static int[] Difference(List<List<int>> groupsOfElements)
        {
            int[] difference = new int[groupsOfElements.Count];

            for (var i = 0; i < groupsOfElements.Count; i++)
            {
                difference[i] = groupsOfElements[i].Last() - groupsOfElements[i].First();
            }

            return difference;
        }

        #endregion

        #region ChallengeTwo

        public static int bestSumAnyTreePath(List<int> parent, List<int> values)
        {
            List<Node> nodes = new List<Node>();
            List<int> allSums = new List<int>();

            for (var i = 0; i < values.Count; i++)
            {
                nodes.Add(new Node(values[i]));
            }

            for (var i = 0; i < parent.Count; i++)
            {
                if (parent[i] >= 0)
                {
                    nodes[parent[i]].EdgesForward.Add(nodes[i]);
                    nodes[i].EdgesBackward.Add(nodes[parent[i]]);
                }
            }

            allSums = GetAllPathSums(nodes);
            allSums.Sort();
            return allSums.Last();
        }

        public static List<int> GetAllPathSums(List<Node> nodes)
        {
            List<int> sums = new List<int>();
            foreach (Node node in nodes)
            {
                GetSumFromPath(node, sums);
            }

            return sums;
        }

        public static void GetSumFromPath(Node node, List<int> sums, int lastSum = 0)
        {
            int sum;
            if (lastSum > 0) sum = lastSum;
            else sum = node.Value;

            sums.Add(node.Value);

            if (node.EdgesForward.Count > 0)
            {
                foreach (Node nextNode in node.EdgesForward)
                {
                    sums.Add(sum + nextNode.Value);
                    GetSumFromPath(nextNode, sums, sum + nextNode.Value);
                }
            }
            else if (node.EdgesForward.Count == 0 && lastSum == 0)
            {
                foreach (Node lastNode in node.EdgesBackward)
                {
                    sums.Add(sum + lastNode.Value);
                    if (lastNode.EdgesForward.Count > 1)
                    {
                        foreach (Node vNode in lastNode.EdgesForward)
                        {
                            if (vNode != node)
                            {
                                sums.Add(sum + lastNode.Value + vNode.Value);
                                GetSumFromPath(vNode, sums, sum + lastNode.Value + vNode.Value);
                            }
                        }
                    }
                    else
                    {
                        sums.Add(sum + lastNode.Value);
                        GetSumBackwards(lastNode, node, sums, sum + lastNode.Value);
                    }
                }
            }
        }

        public static void GetSumBackwards(Node node, Node lastNode, List<int> sums, int lastSum)
        {
            sums.Add(node.Value);
            if (node.EdgesForward.Count > 1)
            {
                foreach (Node fNode in node.EdgesForward)
                {
                    if (fNode != lastNode)
                    {
                        sums.Add(lastSum + fNode.Value);
                        GetSumFromPath(fNode, sums, lastSum + fNode.Value);
                    }
                }
            }
            else
            {
                if (node.EdgesBackward.Count > 0)
                {
                    foreach (Node bNode in node.EdgesBackward)
                    {
                        sums.Add(lastSum + bNode.Value);
                        GetSumBackwards(bNode, node, sums, lastSum + bNode.Value);
                    }
                }
            }
        }

        #endregion
    }
}
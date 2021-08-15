using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Tree
{
    using System;
    using System.Collections.Generic;

    public class Tree<T> : IAbstractTree<T>
    {
        private readonly List<Tree<T>> _children;

        public Tree(T key, params Tree<T>[] children)
        {
            this.Key = key;
            this._children = new List<Tree<T>>();

            foreach (var child in children)
            {
                this.AddChild(child);
                child.AddParent(this);
            }
        }

        public T Key { get; private set; }

        public Tree<T> Parent { get; private set; }


        public IReadOnlyCollection<Tree<T>> Children => this._children.AsReadOnly();

        public void AddChild(Tree<T> child)
        {
            this._children.Add(child);
        }

        public void AddParent(Tree<T> parent)
        {
            this.Parent = parent;
        }

        public string GetAsString()
        {
            return this.GetAsString(0).Trim();
        }

        private string GetAsString(int indentation = 0)
        {
            var result = new string(' ', indentation) + this.Key + "\r\n";

            foreach (var child in Children)
            {
                result += child.GetAsString(indentation + 2);
            }

            return result;
        }

        public Tree<T> GetDeepestLeftomostNode()
        {
            throw new NotImplementedException();
        }

        public List<T> GetLeafKeys()
        {
            var leafNodes = this.GetLeafNodes();

            return leafNodes.Select(x => x.Key).ToList();
        }

        private List<Tree<T>> GetLeafNodes()
        {
            var leafNode = new List<Tree<T>>();

            var queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node.Children.Count == 0)
                {
                    leafNode.Add(node);
                }
                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return leafNode;
        }

        public List<T> GetMiddleKeys()
        {
            throw new NotImplementedException();
        }

        public List<T> GetLongestPath()
        {
            throw new NotImplementedException();
        }

        public List<List<T>> PathsWithGivenSum(int sum)
        {
            var leafNodes = this.GetLeafNodes();
            var result = new List<List<T>>();

            foreach (var leaf in leafNodes)
            {
                var node = leaf;
                var currentSum = 0;
                var currentNodes = new List<T>();

                while (node != null)
                {
                    currentNodes.Add(node.Key);
                    currentSum += int.Parse(node.Key.ToString());
                    node = node.Parent;
                }

                if (currentSum == sum)
                {
                    currentNodes.Reverse();
                    result.Add(currentNodes);
                }
            }

            return result;
        }

        public List<Tree<T>> SubTreesWithGivenSum(int sum)
        {
            throw new NotImplementedException();
        }
    }
}

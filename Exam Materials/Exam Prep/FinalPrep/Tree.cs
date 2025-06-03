using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
        public Tree(TreeNode<T> node)
        {
            Root = node;
        }
        public Tree(T value)
        {
            Root = new TreeNode<T>(value);
        }

        public Tree(T value, params TreeNode<T>[] nodes) : this(value)
        {
            foreach (var node in nodes)
            {
                Root.AddNode(node);
            }
        }

        public void DFS()
        {
            Stack<TreeNode<T>> nodes = new Stack<TreeNode<T>>();

            nodes.Push(Root);

            while (nodes.Count > 0) 
            {
                TreeNode<T> current = nodes.Pop();
                Console.Write(current.Value + " ");

                for (int i = current.Nodes.Count - 1; i >= 0; i--)
                {
                    nodes.Push(current.GetChild(i));
                }
            }
        }

        public void BFS()
        {
            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();

            nodes.Enqueue(Root);

            while (nodes.Count > 0)
            {
                TreeNode<T> current = nodes.Dequeue();
                Console.Write(current.Value + " ");

                for (int i = 0; i < current.Nodes.Count; i++)
                {
                    nodes.Enqueue(current.GetChild(i));
                }
            }
        }
    }
}

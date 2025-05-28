using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree(T value)
        {
            Root = new TreeNode<T>(value);
        }

        public Tree(T value, params TreeNode<T>[] subTrees) : this(value)
        {
            foreach (var subTree in subTrees)
            {
                Root.AddChild(subTree);
            }
        }

        public void DFS()
        {
            Stack<TreeNode<T>> nodes = new Stack<TreeNode<T>>();
            
            nodes.Push(Root);
            while (nodes.Count > 0)
            {
                TreeNode<T> current = nodes.Pop();
                Console.Write($"{current.Value} ");

                for (int i = current.ChildrenCount - 1; i >= 0; i--)
                {
                    nodes.Push(current.GetChild(i));
                }
            }
        }

        public void DFS_PostOrder(TreeNode<T> node)
        {
            for (int i = 0; i < node.ChildrenCount; i++)
            {
                DFS_PostOrder(node.GetChild(i));
            }

            Console.Write($"{node.Value} ");
        }

        public void BFS()
        {
            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(Root);

            while (nodes.Count > 0)
            {
                TreeNode<T> current = nodes.Dequeue();
                Console.Write($"{current.Value} ");
                for (int i = 0; i < current.ChildrenCount; i++)
                {
                    nodes.Enqueue(current.GetChild(i));
                }
            }
        }
    }
}

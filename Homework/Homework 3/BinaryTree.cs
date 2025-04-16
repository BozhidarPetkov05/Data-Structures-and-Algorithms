using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
    public class BinaryTree
    {
        public TreeNode Root { get; private set; }

        public BinaryTree(string input)
        {
            Root = Tree(input);
        }

        private TreeNode Tree(string input)
        {
            if (input == null || input.Length == 0)
            {
                return null;
            }
            
            string[] values = input.Split(',');
            if (values.Length == 0 || values[0] == "null")
            {
                return null;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode(int.Parse(values[0]));
            queue.Enqueue(root);
            int i = 1;

            while (queue.Count > 0 && i < values.Length)
            {
                TreeNode current = queue.Dequeue();

                for (int j = 0; j < 2 && i < values.Length; j++, i++)
                {
                    if (values[i] != "null")
                    {
                        TreeNode child = new TreeNode(int.Parse(values[i]));
                        queue.Enqueue(child);
                        
                        if (j == 0)
                        {
                            current.Left = child;
                        }
                        else
                        {
                            current.Right = child;
                        }
                    }
                }
            }


            return root;
        }

        public bool IsValid(TreeNode node, int? min, int? max)
        {
            if (node == null)
            {
                return true;
            }

            if ((min.HasValue && node.Value <= min.Value) || (max.HasValue && node.Value >= max.Value))
            {
                return false;
            }

            return IsValid(node.Left, min, node.Value) && IsValid(node.Right, node.Value, max);
        }
    }
}

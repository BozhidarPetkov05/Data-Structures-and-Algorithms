using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Nodes { get; set; }
        public TreeNode(T value)
        {
            Value = value;
            Nodes = new List<TreeNode<T>>();
        }

        public void AddNode(TreeNode<T> node)
        {
            if (node == null)
            {
                throw new InvalidOperationException();
            }
            Nodes.Add(node);
        }

        public TreeNode<T> GetChild(int index)
        {
            if (index < 0 || index >= Nodes.Count)
            {
                throw new InvalidOperationException();
            }
            return Nodes[index];
        }
    }
}

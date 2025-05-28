using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        List<TreeNode<T>> Children { get; set; }

        public bool HasParent { get; set; }

        public int ChildrenCount
        {
            get
            {
                return Children.Count;
            }
        }

        public TreeNode(T value)
        {
            if (value == null) throw new ArgumentNullException();

            Value = value;
            Children = new List<TreeNode<T>>();
            HasParent = false;
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException();
            }
            Children.Add(child);
            child.HasParent = true;
        }

        public TreeNode<T> GetChild(int index)
        {
            if (index < ChildrenCount)
            {
                return Children[index];
            }

            throw new ArgumentOutOfRangeException();
        }

        public void RemoveChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException();
            }

            if (!Children.Contains(child))
            {
                throw new InvalidOperationException();
            }

            Children.Remove(child);
        }
    }
}

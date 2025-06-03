namespace FinalPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode<int> zero = new TreeNode<int>(0);
            TreeNode<int> one = new TreeNode<int>(1);
            TreeNode<int> two = new TreeNode<int>(2);
            TreeNode<int> three = new TreeNode<int>(3);
            TreeNode<int> four = new TreeNode<int>(4);
            TreeNode<int> five = new TreeNode<int>(5);
            TreeNode<int> six = new TreeNode<int>(6);
            TreeNode<int> seven = new TreeNode<int>(7);

            zero.AddNode(one);
            zero.AddNode(two);

            one.AddNode(three);
            one.AddNode(four);

            three.AddNode(five);

            two.AddNode(six);
            two.AddNode(seven);

            Tree<int> tree = new Tree<int>(zero);
            tree.DFS();
            Console.WriteLine();
            tree.BFS();
        }

    }
}
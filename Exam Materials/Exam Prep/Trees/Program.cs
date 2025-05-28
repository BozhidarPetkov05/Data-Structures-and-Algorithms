namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<string> tree = new Tree<string>("A");

            TreeNode<string> b = new TreeNode<string>("B");
            TreeNode<string> c = new TreeNode<string>("C");
            TreeNode<string> d = new TreeNode<string>("D");
            TreeNode<string> e = new TreeNode<string>("E");
            TreeNode<string> f = new TreeNode<string>("F");

            tree.Root.AddChild(b);
            tree.Root.AddChild(c);

            b.AddChild(d);
            b.AddChild(e);

            c.AddChild(f);

            tree.DFS();
            Console.WriteLine();
            tree.DFS_PostOrder(tree.Root);

            Console.WriteLine();
            tree.BFS();
        }
    }
}
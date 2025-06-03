namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INF = int.MaxValue;
            int[,] matrix =
            {
                { 0, 5, 2, 0, 0, 0 },
                { 0, 0, 1, 4, 2, 0 },
                { 0, 0, 0, 0, 7, 0 },
                { 0, 0, 0, 0, 6, 3},
                { 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0 },
            };

            Graph graph = new Graph(matrix);
            //graph.BFS(0);
            //Console.WriteLine();
            //graph.DFS(0);
            //Console.WriteLine();
            //graph.PrintMatrix();
            graph.Dijkstra(0);
        }   
    }
}
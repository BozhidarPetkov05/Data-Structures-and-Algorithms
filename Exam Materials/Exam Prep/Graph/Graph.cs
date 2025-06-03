using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private int[,] Matrix { get; set; }
        private int Size { get; set; }
        public Graph(int[,] matrix)
        {
            Matrix = matrix;
            Size = matrix.GetLength(0);
        }

        public void AddEdge(int i, int j, int weigth)
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
            {
                Console.WriteLine("Invalid indicies!");
                return;
            }
            Matrix[i, j] = weigth;
        }

        public void RemoveEdge(int i, int j)
        {
            AddEdge(i, j, 0);
        }

        public bool HasEdge(int i, int j)
        {
            return Matrix[i, j] != 0;
        }

        public List<int> GetEdges(int i)
        {
            List<int> edges = new List<int>();

            for (int j = 0; j < Size; j++)
            {
                if (HasEdge(i, j))
                {
                    edges.Add(j);
                }
            }

            return edges;
        }

        public void DFS(int start)
        {
            if (start < 0 || start >= Size)
            {
                Console.WriteLine("Invalid start node.");
                return;
            }

            Stack<int> stack = new Stack<int>();
            bool[] visited = new bool[Size];

            stack.Push(start);
            visited[start] = true;

            Console.Write("DFS Traversal: ");

            while (stack.Count > 0)
            {
                int current = stack.Pop();
                Console.Write(current + " ");

                List<int> children = GetEdges(current);

                for (int i = children.Count - 1; i >= 0; i--)
                {
                    int child = children[i];
                    if (!visited[child])
                    {
                        visited[child] = true;
                        stack.Push(child);
                    }
                }
            }
        }

            public void BFS(int start)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[Size];

            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                List<int> children = GetEdges(current);
                foreach (var child in children)
                {
                    if (visited[child] == false)
                    {
                        visited[child] = true;
                        queue.Enqueue(child);
                    }
                }
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine("Adjacency Matrix:");

            // Print header
            Console.Write("    ");
            for (int i = 0; i < Size; i++)
                Console.Write($"{i,3} ");
            Console.WriteLine();

            Console.WriteLine("   " + new string('-', Size * 4));

            // Print matrix rows
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"{i,2} |");
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{Matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        public void Dijkstra(int start)
        {
            int[] distances = new int[Size];
            bool[] visited = new bool[Size];
            int[] previous = new int[Size]; // To reconstruct path (optional)

            // Initialize distances and previous
            for (int i = 0; i < Size; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
                previous[i] = -1;
            }
            distances[start] = 0;

            for (int count = 0; count < Size - 1; count++)
            {
                int u = FindMinDistanceNode(distances, visited);
                if (u == -1) break; // No reachable remaining nodes
                visited[u] = true;

                for (int v = 0; v < Size; v++)
                {
                    if (!visited[v] && Matrix[u, v] != 0 && distances[u] != int.MaxValue)
                    {
                        int newDist = distances[u] + Matrix[u, v];
                        if (newDist < distances[v])
                        {
                            distances[v] = newDist;
                            previous[v] = u;  // Store previous node for path reconstruction
                        }
                    }
                }
            }

            PrintDijkstraSolution(distances);

            // Optional: print paths from start to each node
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"Path to {i}: ");
                PrintPath(previous, i);
                Console.WriteLine();
            }
        }

        void PrintPath(int[] previous, int current)
        {
            if (current == -1)
                return;
            PrintPath(previous, previous[current]);
            Console.Write(current + " ");
        }

        private int FindMinDistanceNode(int[] distances, bool[] visited)
        {
            int minIndex = 0;
            int min = int.MaxValue;


            for (int i = 0; i < distances.Length; i++)
            {
                if (visited[i] == false && distances[i] <= min)
                {
                    min = distances[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        void PrintDijkstraSolution(int[] dist)
        {
            Console.Write("Vertex \t\t Distance "
                          + "from Source\n");
            for (int i = 0; i < Matrix.GetLength(0); i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }
    }
}

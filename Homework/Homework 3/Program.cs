using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. Задача тест
            List<int> list1 = new List<int>() { 1, 2, 4, 1, 5 };
            List<int> list2 = new List<int>() { 1, 45, 5, 6, 7, 89, 25 };

            List<int> unionList = ListUnion(list1, list2);
            Console.WriteLine("Union: " + string.Join(", ", unionList));

            List<int> intersectList = ListIntersect(list1, list2);
            Console.WriteLine("Intersection: " + string.Join(", ", intersectList));

            //2. Задача тест
            List<int> rowList = new List<int> { 1, 2, 2, 5, 2 };
            List<int> longestStreakList = LongestStreak(rowList);
            Console.WriteLine("Longest streak: " + string.Join(", ", longestStreakList));

            //3. Задача тест
            List<int> negativesList = new List<int>() { 1, 2, 3, -4, 4, -5, 5, -9, 6, -4};
            negativesList = RemoveNegatives(negativesList);
            Console.WriteLine("Removed negatives: " + string.Join(", ", negativesList));
            */

            //4. Задача тест
            /*DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
            dll.Add(1);
            dll.Add(2);
            dll.Add(3);
            dll.InsertAtIndex(0, 2);
            dll.Remove(3);
            dll.Print();*/

            //5. Задача тест
            //int[] arr = { 1, 2, 4, 11, 12, 8 };
            //int num = 2;
            //Console.WriteLine($"Max: {FindMax(arr, num)}");

            //6. Задача тест
            //char[,] cells = {
            //    { 'a', 'a', 'b', 'b', 'a' },
            //    { 'a', 'a', 'b', 'b', 'a' },
            //    { 'a', 'a', 'a', 'c', 'b' }
            //};

            //Console.WriteLine(CountRegions(cells));

            //7. Задача тест
            //string input = Console.ReadLine();
            //BinaryTree tree = new BinaryTree(input);
            //Console.WriteLine(tree.IsValid(tree.Root, null, null));
        }

        //1. Задача
        public static List<int> ListUnion(List<int> list1, List<int> list2)
        {
            List<int> resultList = new List<int>();

            foreach (int item in list1)
            {
                if (!resultList.Contains(item))
                {
                    resultList.Add(item);
                }
            }

            foreach (int item in list2)
            {
                if (!resultList.Contains(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }

        public static List<int> ListIntersect(List<int> list1, List<int> list2)
        {
            List<int> resultList = new List<int>();

            foreach (int item in list1)
            {
                if (list2.Contains(item) && !resultList.Contains(item))
                {
                    resultList.Add(item);
                }
            }

            return resultList;
        }

        //2. Задача
        public static List<int> LongestStreak(List<int> list)
        {
            List<int> resultList = new List<int>();
            int longestNum = 0;
            int longestStreak = 0;
            int currentStreak = 0;

            longestNum = list[0];

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    currentStreak++;
                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                        longestNum = list[i];
                    }
                }
                else
                {
                    currentStreak = 0;
                }
            }

            for (int i = 0; i <= longestStreak; i++)
            {
                resultList.Add(longestNum);
            }

            return resultList;
        }

        //3. Задача
        public static List<int> RemoveNegatives(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }

        //5. Задача
        public static int FindMax(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    num *= 2;
                }
            }
            return num;
        }

        //6. Задача
        public static int CountRegions(char[,] cells)
        {
            int rows = cells.GetLength(0);
            int cols = cells.GetLength(1);
            
            bool[,] visited = new bool[rows, cols];
            
            int regionCount = 0;

            int[] dRow = { -1, 1, 0, 0 };
            int[] dCol = { 0, 0, -1, 1 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!visited[i, j])
                    {
                        Queue<(int, int)> queue = new Queue<(int, int)>();
                        queue.Enqueue((i, j));
                        visited[i, j] = true;
                        char symbol = cells[i, j];

                        while (queue.Count > 0)
                        {
                            var (r, c) = queue.Dequeue();

                            for (int d = 0; d < 4; d++)
                            {
                                int newRow = r + dRow[d];
                                int newCol = c + dCol[d];

                                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols &&
                                    !visited[newRow, newCol] && cells[newRow, newCol] == symbol)
                                {
                                    queue.Enqueue((newRow, newCol));
                                    visited[newRow, newCol] = true;
                                }
                            }
                        }

                        regionCount++;
                    }
                }
            }

            return regionCount;
        }
    }
}

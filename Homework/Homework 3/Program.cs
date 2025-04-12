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

            DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
            dll.Add(1);
            dll.Add(2);
            dll.Add(3);
            dll.Print();
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
    }
}

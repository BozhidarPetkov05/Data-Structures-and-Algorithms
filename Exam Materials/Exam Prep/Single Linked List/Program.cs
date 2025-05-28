namespace Single_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.Add(1);
            //linkedList.Add(2);
            //linkedList.Add(3);
            //linkedList.Add(4);
            //linkedList.Add(5);
            //linkedList.Add(6);
            //linkedList.Add(7);
            //linkedList.PrintList();

            //linkedList.RemoveAtBeginning();
            //linkedList.RemoveAtEnd();
            //linkedList.PrintList();


            //linkedList.RemoveAt(0);
            //linkedList.PrintList();
            //linkedList.RemoveAt(3);
            //linkedList.PrintList();

            //linkedList.RemoveByValue(4);
            //linkedList.PrintList();

            //CustomArrStack<int> customArrStack = new CustomArrStack<int>();
            //customArrStack.Push(1);
            //customArrStack.Push(2);
            //customArrStack.Push(3);
            //customArrStack.Push(4);
            //customArrStack.Push(5);
            
            //customArrStack.PrintStack();
            //customArrStack.Pop();

            //customArrStack.PrintStack();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.PrintQueue();

            queue.Dequeue();
            queue.PrintQueue();

            
        }
    }
}
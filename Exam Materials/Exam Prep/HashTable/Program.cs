namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable<string, int> ht = new HashTable<string, int>();
            ht.Find("Hasan", 20);
            
            ht.Add("Pesho", 2000);
            ht.Add("Pesho", 1000);
            ht.Add("Ivan", 1000);

            ht.Print();

            ht.Remove("Pesho");
            ht.Print();
        }
    }
}
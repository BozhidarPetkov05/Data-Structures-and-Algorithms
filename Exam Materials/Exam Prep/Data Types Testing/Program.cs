namespace Data_Types_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ByteTest();
            ShortTest();
            IntTest();
            LongTest();
            FloatTest();
            DoubleTest();
            DecimalTest();
            CharTest();
            BoolTest();
            StringTest();
        }

        public static void ByteTest()
        {
            Console.WriteLine("Byte:");
            Console.WriteLine("Min value: " + byte.MinValue);
            Console.WriteLine("Max value: " + byte.MaxValue);
            Console.WriteLine("Size: " + sizeof(byte) * 8);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sbyte:");
            Console.WriteLine("Min value: " + sbyte.MinValue);
            Console.WriteLine("Max value: " + sbyte.MaxValue);
            Console.WriteLine("Size: " + sizeof(sbyte) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void ShortTest()
        {
            Console.WriteLine("Short:");
            Console.WriteLine("Min value: " + short.MinValue);
            Console.WriteLine("Max value: " + short.MaxValue);
            Console.WriteLine("Size: " + sizeof(short) * 8);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ushort:");
            Console.WriteLine("Min value: " + ushort.MinValue);
            Console.WriteLine("Max value: " + ushort.MaxValue);
            Console.WriteLine("Size: " + sizeof(ushort) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void IntTest()
        {
            Console.WriteLine("Int:");
            Console.WriteLine("Min value: " + int.MinValue);
            Console.WriteLine("Max value: " + int.MaxValue);
            Console.WriteLine("Size: " + sizeof(int) * 8);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Uint:");
            Console.WriteLine("Min value: " + uint.MinValue);
            Console.WriteLine("Max value: " + uint.MaxValue);
            Console.WriteLine("Size: " + sizeof(uint) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void LongTest()
        {
            Console.WriteLine("Long:");
            Console.WriteLine("Min value: " + long.MinValue);
            Console.WriteLine("Max value: " + long.MaxValue);
            Console.WriteLine("Size: " + sizeof(long) * 8);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ulong:");
            Console.WriteLine("Min value: " + ulong.MinValue);
            Console.WriteLine("Max value: " + ulong.MaxValue);
            Console.WriteLine("Size: " + sizeof(ulong) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void FloatTest()
        {
            Console.WriteLine("Float:");
            Console.WriteLine("Min value: " + float.MinValue);
            Console.WriteLine("Max value: " + float.MaxValue);
            Console.WriteLine("Size: " + sizeof(float) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void DoubleTest()
        {
            Console.WriteLine("Double:");
            Console.WriteLine("Min value: " + double.MinValue);
            Console.WriteLine("Max value: " + double.MaxValue);
            Console.WriteLine("Size: " + sizeof(double) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void DecimalTest()
        {
            Console.WriteLine("Decimal:");
            Console.WriteLine("Min value: " + decimal.MinValue);
            Console.WriteLine("Max value: " + decimal.MaxValue);
            Console.WriteLine("Size: " + sizeof(decimal) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void CharTest()
        {
            Console.WriteLine("Char:");
            Console.WriteLine(@"Min value: \0");
            Console.WriteLine(@"Max value: \uffff");
            Console.WriteLine("Size: " + sizeof(char) * 8);
            Console.WriteLine("---------------------------");
        }

        public static void BoolTest()
        {
            Console.WriteLine("Bool:");
            Console.WriteLine("False: " + bool.FalseString);
            Console.WriteLine("True: " + bool.TrueString);
            Console.WriteLine("Size: " + sizeof(bool) * 8);
            Console.WriteLine("---------------------------");
        } 
    }
}
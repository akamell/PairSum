using System;

namespace FirstPairSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 0, 0, 0, 3, 2, 1, 3, 6 };
            int[] result = Pair.Get(6, numbers);
            Console.WriteLine($"Result: {result[0]},{result[1]}");
        }
    }
}

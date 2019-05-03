using System;

namespace _2章理解度1
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 10;

            var name = "yamada"
            Console.WriteLine($"こんにちは、{name}さん！");

            int? i = null;

            int[,] data = int[5, 4];

            int[][] data1 = new int[3][];
            data1[0] = new[] { 2, 3, 5 };
            data1[1] = new[] { 1, 2 };
            data1[2] = new[] { 10, 11, 12, 13 };

        }
    }
}

using System;

namespace 練習問題4._2
{
    class Program
    {
        static void Main(string[] args) 
        {
            int i;
            int j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    Console.Write(i * j);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}

using System;

namespace 練習問題4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var score = int.Parse(Console.ReadLine());
            var score = Console.Read();

            if (score >= 90)
            {
                Console.WriteLine("優");
            }
            else if (score >= 70)
            {
                Console.WriteLine("良");
            }
            else if (score >= 50)
            {
                Console.WriteLine("可");
            }
            else
            {
                Console.WriteLine("不可");
            }
        }
    }
}

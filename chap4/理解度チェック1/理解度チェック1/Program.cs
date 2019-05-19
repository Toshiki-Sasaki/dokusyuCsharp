using System;

namespace 理解度チェック1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            var sum = 0;
            for (i=100; i<=200; i++)
            {
                if (i%2 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.Write($"合計値は{sum}です。");
        }
    }
}

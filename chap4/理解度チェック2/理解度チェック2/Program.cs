using System;

namespace 理解度チェック2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while(i<=100)
            {
                i++;
                sum += i;
                if (sum>1000)
                {
                    break;
                }
            }
            Console.WriteLine($"1~{i}で脱出。");
        }
    }
}

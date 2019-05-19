using System;

namespace 理解度チェック3
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var tmp in args)
            {
                int i = Int32.Parse(tmp);
                Console.WriteLine(i*1.5);
            }

        }
    }
}

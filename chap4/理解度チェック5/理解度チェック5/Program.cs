using System;

namespace 理解度チェック5
{
    class Program
    {
        static void Main(string[] args)
        {
            var language = "Visual Basic";

            if (language=="C#" || language=="Visual Basic" || language=="F#")
            {
                Console.WriteLine(".NET対応言語");
            }
            else if (language=="Python" || language=="Ruby")
            {
                Console.WriteLine("スクリプト言語");
            }
            else
            {
                Console.WriteLine("不明");
            }
        }
    }
}

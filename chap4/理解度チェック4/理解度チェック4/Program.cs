using System;

namespace 理解度チェック4
{
    class Program
    {
        static void Main(string[] args)
        {
            var language = "Go";

            switch (language)
            {
                case "C#":
                case "Visual Basic":
                case "F#":
                    Console.WriteLine(".NET対応言語");
                    break;

                case "Python":
                case "Ruby":
                    Console.WriteLine("スクリプト言語");
                    break;

                default:
                    Console.WriteLine("不明");
                    break;
            }
        }
    }
}

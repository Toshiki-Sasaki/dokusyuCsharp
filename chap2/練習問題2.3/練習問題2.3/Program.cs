using System;

namespace 練習問題2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 16指数リテラル
            var literal16 = 0xf10;
            Console.WriteLine(literal16);

            // 数値セパレータ
            var splitNumber = 123_456_789;
            Console.WriteLine(splitNumber);

            // 改行区切りの文字列
            var TextSplitByN = @"ほげ
            ふが
            ピヨ";
            Console.WriteLine(TextSplitByN);

            // 指数表現
            var expRep = 0.12345e5;
            Console.WriteLine(expRep);

            // 文字リテラル
            var charLiteral = 'A';
            Console.WriteLine(charLiteral);

        }
    }
}

using System;

namespace _2._4._3_文字列と数値の変換
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列から数値への変換
            Console.WriteLine(Int32.Parse("108")); // 結果 108 (int)
            Console.WriteLine(Single.Parse("0.1413")); // 結果 0.1413 (float)
            // "0xFF" ではなく "FF" で無ければならない
            Console.WriteLine(Int32.Parse("FF", System.Globalization.NumberStyles.HexNumber)); // 結果 255 (int) 
            Console.WriteLine(Double.Parse("0.653e2")); // 結果 65.3 (double)
            // 1010 を 2 進数に変換する
            Console.WriteLine(Convert.ToInt32("1010", 2)); // 結果 10 (int)


            // 数値型から文字列への変換
            int i = 12;
            double d = 1.23;
            Console.WriteLine(i.ToString()); // 結果 12
            Console.WriteLine(d.ToString()); // 1.23
            Console.WriteLine(Convert.ToString(i, 16)); // 結果 c
            Console.WriteLine(Convert.ToString(i, 2)); // 結果 1100
        }
    }
}

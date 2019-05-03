using System;

namespace _2._4._1_暗黙的な変換
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 16777216;
            float f = i;
            Console.WriteLine(f);
            // 結果: 1.677722E+07

            // int i2 = 13;
            // byte b = i2;
            // Console.WriteLine(b);
            // これはエラー

            int i3 = 13;
            byte b2 = (byte)i3;
            Console.WriteLine(b2);
            // これは大丈夫
        }
    }
}

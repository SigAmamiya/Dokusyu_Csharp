using System;


namespace CastDemo
{
    class CastDemo
    {
        static void Main()
        {
            double x, y;
            byte b;
            int i;
            char ch;

            x = 10.0;
            y = 3.0;

            i = (int)(x / y); //double型からint型にキャスト
            Console.WriteLine("Integer outcome of x / y: " + i);

            i = 100;
            b = (byte)i;//byte型は100を保持できるため、データが失われることはない
            Console.WriteLine("Value of b: " + b);

            i = 257;
            b = (byte)i;//byte型で257は保持できないため、データは失われる
            Console.WriteLine("Value of b: " + b);

            b = 88;   //文字XのASSCIIコード
            ch = (char)b;
            Console.WriteLine("ch: " + ch);

            Console.ReadKey();
        }
    }
}

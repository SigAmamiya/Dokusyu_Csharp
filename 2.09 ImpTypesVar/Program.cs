using System;


namespace ImpTypesVar
{
    class Program
    {
        static void Main()
        {

            var pi = 3.1416;
            var radius = 10;

            var msg = "Radius:";
            var msg2 = "Arias:";

            double area;

            Console.WriteLine(msg + radius);
            area = pi * radius * radius;
            Console.WriteLine(msg2 + area);

            Console.WriteLine();

            radius = radius + 2;

            Console.WriteLine(msg + radius);
            area = pi * radius * radius;
            Console.WriteLine(msg2 + area);

            Console.ReadKey();

            //次の文はコンパイルエラー
            //radius = 12.2;

            //var count = 10, max = 20;
            //varは複数の変数を同時に宣言することはできないので上記もエラー
        }
    }
}

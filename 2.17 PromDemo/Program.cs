using System;

namespace PromDemo
{
    class PromDemo
    {
        static void Main()
        {
            byte b;
            int i;

            b = 10;
            i = b * b;

            b = 10;
            b =(byte)(b * b);

            Console.WriteLine("i and b: " + i + " " + b);

            Console.ReadKey();


        }
    }
}

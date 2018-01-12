using System;


namespace DynInit
{
    class Program
    {
        static void Main()
        {
            double radius = 4, hight = 5;

            //動的な初期化
            double volume = 3.1416 * radius * radius * hight;

            Console.WriteLine("Volume is " + volume + ".");
            Console.ReadKey();


        }
    }
}
using System;


namespace IFdemo //if文
{
    class IfDemo
    {
        static void Main()
        {
            int a, b, c;

            a = 2;
            b = 3;

            if (a < b) Console.WriteLine("a is less than b");
            if (a == b) Console.WriteLine("you won't see this");
            if (a == 2) Console.WriteLine("a contains the value 2");
            if (a == 10) Console.WriteLine("you won't see this");
            if (a == b - 1) Console.WriteLine("a value b - 1");
            Console.WriteLine();


            c = a - b;

            Console.WriteLine("c contains -1");
            if (c >= 0) Console.WriteLine("c is non-negative");
            if (c < 0) Console.WriteLine("c is negative");
            Console.WriteLine();

            c = b - a;

            Console.WriteLine("c contains 1");
            if (c >= 0) Console.WriteLine("c is non-negative");
            if (c < 0) Console.WriteLine("c is negative");

            Console.WriteLine();
            Console.ReadKey();



        }
    }
}

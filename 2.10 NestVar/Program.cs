using System;

namespace NestVar
{
    class Program
    {
        static void Main()
        {
            int count;

            for (count = 0; count < 10; count = count + 1) {
                Console.WriteLine("Count is :" + count);

                int count;  //countはすでにMain()で宣言されているためここでは宣言できない。
                for (count = 0; count < 2; count++) {
                    Console.WriteLine("This Program is in error!");
                }
            }
            Console.ReadKey();
        }
    }
}

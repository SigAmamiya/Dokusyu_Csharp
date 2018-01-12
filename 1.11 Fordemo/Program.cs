using System;

namespace Practice_005 //forループ
{
    class ForDemo
    {
        static void Main()
        {
            int count;
            Console.WriteLine("Counting from 0 to 10");
            for (count = 0; count < 11; count++) {
                Console.WriteLine("count is " + count);
            }

            Console.WriteLine();
            Console.WriteLine("Done!");
            Console.ReadKey();

        }
    }
}
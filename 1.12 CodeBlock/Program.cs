using System;

namespace Practice_006//コードブロック
{
    class BlockDemo
    {
        static void Main()
        {
            double i, j, d;

            i = 5.0;
            j = 10.0;

            //if文の対象はブロック

            if (i != 0)
            {
                Console.WriteLine("i does't equal zero");
                d = j / i;
                Console.WriteLine("j / i is " + d);
                Console.ReadLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCast
{
    class UseCast
    {
        static void Main()
        {
            int i;

            for(i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " / 3:" + i / 3);
                Console.WriteLine(i + " / 3 with fanctions: {0:#.##} ", (double)i / 3);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

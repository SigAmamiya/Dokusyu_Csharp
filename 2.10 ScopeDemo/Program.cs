using System;


namespace ScopeDemo
{
    class Program
    {
        static void Main()
        {
            int x;

            x = 10;

            if (x == 10) {
                int y = 20; //yはifの中のブロックでのみ有効
                Console.WriteLine("x and y:" + x + " " + y);
                x = y * 2; //ここではまだ有効

            }

           // y = 100; //コンパイルエラー　ここからはyにアクセスできない

            Console.WriteLine("x is " + x );//xはifの中のブロックではないのでここでは有効
            Console.ReadKey();

        }
    }
}

using System;


namespace VarInitDemo
{
    class Program
    {
        static void Main()
        {
            int x;

            for (x = 0; x < 3; x++) {
                int y = -1;
                Console.WriteLine("y is :" + y);//ループされるたびにyが初期化されるため-1と表示される

                y = 100;
                Console.WriteLine("y is now :" + y);

            }
            Console.ReadKey();
        }
    }
}

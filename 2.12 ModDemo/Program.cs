using System;


namespace ModDemo
{
    class Program
    {
        static void Main()
        {
            int iresult, irem;
            double dresult, drem;

            iresult = 10 / 3;
            irem = 10 % 3;

            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;
            //%では剰余が計算できるため、int型でもdouble型でも1が算出される。

            Console.WriteLine("Result and remainder of 10 / 3: " + iresult + " " + irem);
            Console.WriteLine("Result and remainder of 10.0 / 3.0: " + dresult + " " + drem);

            Console.ReadKey();

        }
    }
}

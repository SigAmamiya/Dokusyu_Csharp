using System;

namespace LtoD
{
    class LtoD
    {
        static void Main()
        {
            long L;
            double D;

            L = 100123285L;
            D = L; //long型からdouble型に暗黙的な自動変換が行われる

            Console.WriteLine("L and D:" + L + " " + D);
            Console.ReadKey();

        }
    }
}

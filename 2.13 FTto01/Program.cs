using System;


namespace FTto01
{
    class FTto01
    {
        static void Main()
        {
            int p, q;

            //AND 両方true  ならtrue
            //OR　片方true  ならtrue
            //XOR 片方だけtrue ならtrue
            //NOT 逆の結果

            Console.WriteLine("P\tQ\tAND\tOR\tXOR\tNOT");

            p = 1; q = 1;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (~p - ~1));    //~p - ~1で符号付き整数型bitを反転、

            p = 1; q = 0;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (~p - ~1));

            p = 0; q = 1;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (~p - ~1));

            p = 0; q = 0;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (~p - ~1));

            Console.ReadKey();

        }
    }
}

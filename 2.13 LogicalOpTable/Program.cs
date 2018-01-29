using System;


namespace LogicalOpTable
{
    class LogicalOpTable
    {
        static void Main()
        {
            bool p, q;
            

            //AND 両方true  ならtrue
            //OR　片方true  ならtrue
            //XOR 片方だけtrue ならtrue
            //NOT 逆の結果

            Console.WriteLine("P\tQ\tAND\tOR\tXOR\tNOT");

            p = true; q = true;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            p = true; q = false;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            p = false; q = true;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            p = false; q = false;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            Console.ReadKey();

        }
    }
}

using System;


namespace SCops
{
    class Program
    {
        static void Main()
        {
            int n, d;

            n = 10;
            d =  2;

            if(d != 0 && (n % d) == 0)// dが0でないので１番目のオペランドはtrueのため、２番目のオペランドが評価される。
            Console.WriteLine(d +" is a factor of " + n);

            d = 0;

            if (d != 0 && (n % d) == 0)// dが0ということが１番目のオペランドで決まっているためfalse確定。そのため剰余演算がスキップされる。
            Console.WriteLine(d + " is a factor of " + n);

            if (d != 0 & (n % d) == 0)//ショートサーキット評価を行ってないため２番目のオペランドも評価され、0での剰余演算が行われエラーが表示される
                Console.WriteLine(d + " is a factor of " + n);

        }
    }
}

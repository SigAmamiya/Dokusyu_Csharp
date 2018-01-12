using System;


class IntVsDouble
{
    static void Main()
    {
        int ivar;
        double dvar;

        ivar = 10;
        dvar = 10.0;

        Console.WriteLine("Original value of ivar" + ivar);
        Console.WriteLine("Original value of dvar" + dvar);

        Console.WriteLine();//空白の行を出力する

        ivar = ivar / 4;
        dvar = dvar / 4.0;

        Console.WriteLine("ivar after division" + ivar);
        Console.WriteLine("dvar after division" + dvar);
        Console.ReadKey();
    }
}
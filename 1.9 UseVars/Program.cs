//変数を使用する

using System;


class UseVars
{
    static void Main()
    {
        //3つの変数を宣言
        int length;
        int width;
        int area;


        length = 9;

        Console.WriteLine(" length contains " + length);

        width = 7;

        Console.WriteLine(" width contains" + width);

        area = length * width;

        Console.WriteLine(" area contains length * width: " + area);

        Console.ReadKey();
    }


}
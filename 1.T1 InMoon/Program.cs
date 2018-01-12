using System;

namespace Test1_1 //月面での自分の体重を求めるプログラム
{
    class MoonWeight
    {
        static void Main()
        {
            double moon_wheight;
            double pound;

            Console.WriteLine("あなたの体重を入力してください。");
            double earth_wheight = double.Parse(Console.ReadLine());

            pound = earth_wheight * 2.20462262;
            moon_wheight = pound * 0.17;

            Console.WriteLine("あなたの月での体重は" + moon_wheight + "です。");
            Console.ReadKey();

        }
    }
}

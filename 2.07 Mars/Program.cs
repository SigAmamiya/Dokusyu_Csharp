/*
 火星の人と会話するときのタイムラグの計算
 出力オプションの練習
 */

using System;

namespace Practice_008
{
    class Mars
    {
        static void Main()
        {
            double distance;
            double lightspeed;
            double delay;
            double delay_in_min;

            distance = 34000000; //34,0000,000マイル
            lightspeed = 186000; //186,000マイル/秒

            delay = distance / lightspeed;

            Console.WriteLine("Time delay when talking to Mars: {0:###.###} seconds.", delay); //出力オプションで小数点第3位まで出力　引数0(delay)を出力している

            delay_in_min = delay / 60;

            Console.WriteLine("This is is : {0:###.###} minutes.", delay_in_min);

            Console.ReadKey();

        }
    }
}
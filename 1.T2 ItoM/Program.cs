using System;

namespace ItoM //インチをメートルに変換するプログラム　forループの結果に対しifをコードブロックして空白を挟む
{
    class ItoMtable
    {
        static void Main()
        {
            double i, m;
            int counter;

            counter = 0;
            for (i = 1.0; i < 145.0; i++)
            {

                m = i / 39.37;// メートルに変換
                Console.WriteLine(i + " inch is " +
                                  m + " meter.");

                counter++;

                // 12行ごとに空白行を出力する
                if (counter == 12)
                {
                    Console.WriteLine();
                    counter = 0; // 行カウンタのリセット
                }

            }
            Console.ReadKey();
        }
    }
}

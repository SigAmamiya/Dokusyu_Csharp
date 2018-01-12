using System;
  
 namespace Practice_007 //華氏を摂氏に変換するプログラム　forループの結果に対しifをコードブロックして空白を挟む
{
     class FtoC
    {
        static void Main()
        {
            double f, c;
            int counter;
            
            counter = 0;
            for (f = 0.0; f < 100.0; f++)
            {
                c = 5.0 / 9.0 * (f - 32.0); // 摂氏に変換
                Console.WriteLine(f + " degrees Fahrenheit is " +
                c + " degrees Celsius.");

                counter++;

                // 10行ごとに空白行を出力する
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0; // 行カウンタのリセット
                }
            }
            Console.ReadKey();
        }
    }
}
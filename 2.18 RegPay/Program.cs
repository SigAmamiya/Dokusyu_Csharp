using System;


namespace RegPay
{
    class RegPay
    {
        static void Main()
        {
            decimal Principal; // 元金
            decimal IntRate;   // decimal型の金利、例えば0.075等
            decimal PayPerYear;//年間の支払い回数
            decimal NumYear;   //返済期間の年数
            decimal Payment;   //1回あたりの返済額
            decimal numer, denom; //一時的な作業変数
            double b, e; //Pow()メソッド用の基数と変数

            Principal = 1000000.0m;
            IntRate = 0.075m;
            PayPerYear = 12.0m;
            NumYear = 5.0m;

            numer = IntRate * Principal / PayPerYear;
            e = (double) - (PayPerYear * NumYear);    //Pow()メソッドで使用する引数なのでdouble型で明示的にキャストする
            b = (double) (IntRate / PayPerYear) + 1;

            denom = 1 - (decimal)Math.Pow(b, e);   //戻り値はdecimal型にするために明示的にキャストする

            Payment = numer / denom;

            Console.WriteLine("Payment is {0:C} ", Payment);
            Console.ReadKey();

        }
    }
}

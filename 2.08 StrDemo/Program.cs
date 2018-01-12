// 文字列リテラルでのエスケープシーケンス

using System;

class StrDemo
{
    static void Main()
    {
        Console.WriteLine("First line\nSecond line"); //\nによって改行する
        Console.WriteLine("A\tB\tC"); //\tを使ってタブを出力する
        Console.WriteLine("D\tE\tF"); //\tを使ってタブを出力する

        //ここから自由にエスケープシーケンスを触る

        Console.WriteLine("\a 警告\n\b バックスペース\n\f ページ送り\n\r　復帰\n\t　水平タブ\n\v　垂直タブ\n\0　ヌル文字\n\'　シングルクオーテーション\n\"　ダブルクオーテーション\n\\　円マーク");
        Console.ReadKey();
    }
}
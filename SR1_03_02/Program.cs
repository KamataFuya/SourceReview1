using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog pochi = new Dog();

            // コンストラクタが働いているかチェック
            // 最初の 空腹状態を表示してみる
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            // pochiにエサを食べさせる
            pochi.Eat();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            // pochiを走らせる
            pochi.Run();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            //一時停止
            Console.ReadLine();
        }
    }
}

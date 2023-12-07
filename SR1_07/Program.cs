using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listコレクション numbers を作成する
            List<int> numbers = new List<int>();
            // 乱数発生器の生成
            Random random = new Random(Environment.TickCount);

            for (int i = 0; i < 10; i++)
            {
                // 最小-5,最大5の範囲で乱数を生成
                int r = random.Next(-5, 5 + 1);
                // nmbers に 乱数r を追加して、中身を表示する
                numbers.Add(r);
            }

            // 中身を確認する
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}

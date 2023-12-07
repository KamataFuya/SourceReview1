using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_09_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.AddItem(new Item("つるはし"));
            player.AddItem(new Item("巻き物"));
            player.AddItem(new Item("ポーション"));

            player.UseItem();

            Console.ReadLine();
        }
    }
}

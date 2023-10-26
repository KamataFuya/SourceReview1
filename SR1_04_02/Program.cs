﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("ロト", 1);

            Console.WriteLine("名前 : {0}", player.GetName());
            Console.WriteLine("レベル : {0}", player.GetLevel());

            player.Attack();
            player.Defence();

            player.LevelUp();
            Console.WriteLine("レベル : {0}", player.GetLevel());

            //一時停止
            Console.ReadLine();
        }
    }
}

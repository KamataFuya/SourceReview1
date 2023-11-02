using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 空飛ぶロボをテストする
            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");

            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            Console.WriteLine("電源:{0}", flyingRobot.GetPowerStatus());

            flyingRobot.DropBomb();

            flyingRobot.PowerOn();
            flyingRobot.DropBomb();

            flyingRobot.PowerOff();

            Console.WriteLine("----------");

            // タンクロボをテストする
            TankRobot tankRobot = new TankRobot("タンクロボ");

            Console.WriteLine("名前:{0}", tankRobot.GetName());
            Console.WriteLine("電源:{0}", tankRobot.GetPowerStatus());

            tankRobot.ShootCannon();

            tankRobot.PowerOn();
            tankRobot.ShootCannon();

            tankRobot.PowerOff();

            Console.WriteLine("----------");

            // TankRobotクラスの実態を大量発生
            TankRobot[] tanks = new TankRobot[5]; // 配列を作っただけ

            // TankRobot 5体分の実体を作る
            for(int i = 0; i < tanks.Length; i++)
            {
                tanks[i] = new TankRobot("タンクNo." + i);
            }

            for(int i = 0; i < tanks.Length; i++)
            {
                tanks[i].PowerOn();
            }

            foreach(TankRobot tank in tanks)
            {
                tank.ShootCannon();
            }

            // 一時停止
            Console.ReadLine();

        }
    }
}

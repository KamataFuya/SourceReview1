using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// タンクロボを生成し、Attack()メソッドを実行
            //TankRobot tankRobot = new TankRobot("タンクロボ");
            //tankRobot.Attack();

            //// 空飛ぶロボを生成し、Attack()メソッドを実行
            //FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");
            //flyingRobot.Attack();

            //// 基底クラス Robot の変数に、派生クラスの実体を格納して、
            //// Attack()メソッドを実行してみる
            //Robot robot1 = new TankRobot("陸上ロボ");
            //robot1.Attack();

            //Robot robot2 = new FlyingRobot("空中ロボ");
            //robot2.Attack();

            //Console.WriteLine("---");

            //// 大量生産
            //List<Robot> robots = new List<Robot>();

            //robots.Add(new TankRobot("タンク1号"));
            //robots.Add(new TankRobot("タンク2号"));
            //robots.Add(new FlyingRobot("爆撃機1号"));
            //robots.Add(new TankRobot("タンク3号"));
            //robots.Add(new FlyingRobot("爆撃機2号"));



            //// 攻撃しまくる
            //foreach (Robot robot in robots)
            //{
            //    robot.Attack();
            //}

            //リストの生成
            List<Robot> robots = new List<Robot>();
            // 乱数発生器の生成
            Random random = new Random(Environment.TickCount);

            // robots に15体の実体を格納する
            for (int i = 0; i < 15; i++)
            {
                // FlyingRobot,TankRobotはそれぞれ50%の確率で格納される
                // FlyingRobot(0~5),TankRobot(6~10)
                int r = random.Next(0, 10 + 1);

                if(r <= 5)
                {
                    robots.Add(new FlyingRobot("フライングロボット"));
                }
                else
                {
                    robots.Add(new TankRobot("タンクロボット"));
                }
            }

            // robots 内の全ての実体についてAttack()メソッドを実行する
            foreach (Robot robot in robots)
            {
                robot.Attack();
            }

            // 一時停止
            Console.ReadLine();
        }
    }
}

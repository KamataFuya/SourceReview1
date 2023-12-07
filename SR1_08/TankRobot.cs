using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_08
{
    internal class TankRobot : Robot
    {
        // メソッド
        // コンストラクタ
        public TankRobot(string name) : base(name)
        {

        }

        // キャノン砲を撃つ
        public override void Attack()
        {
            Console.WriteLine("{0}は、キャノン砲を撃った!", name);
        }

    }
}

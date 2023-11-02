using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_05_02
{
    internal class TankRobot : Robot
    {
        // フィールド

        // メソッド
        // コンストラクタ
        public TankRobot(string name)
        {
            this.name = name;
        }

        // キャノン砲を撃つ
        public void ShootCannon()
        {
            if (powerStatus) // if (powerStatus == true) と同じ意味
            {
                Console.WriteLine("{0}は、キャノン砲を撃った!", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源Offなのでキャノン砲は使えません..", name);
            }
        }

    }
}

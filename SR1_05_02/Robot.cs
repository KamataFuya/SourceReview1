using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_05_02
{
    internal class Robot
    {
        // フィールド
        protected string name = ""; // 初期値は ""
        protected bool powerStatus = false; // 初期値は false

        // メソッド
        // 電源を On にする
        public void PowerOn()
        {
            powerStatus = true;
            Console.WriteLine("{0}は、起動した!!", name);
        }

        // 電源を Off にする
        public void PowerOff()
        {
            powerStatus = false;
            Console.WriteLine("{0}は、停止した..", name);
        }

        // 名前を取得する
        public string GetName()
        {
            return name;
        }


        // 電源On状態を取得する
        public bool GetPowerStatus()
        {
            return powerStatus;
        }
    }
}

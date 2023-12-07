using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_08
{
    internal class Robot
    {
        // フィールド
        protected string name;

        // メソッド
        // コンストラクタ
        public Robot(string name)
        {
            this.name = name;
        }

        // name の値を返す
        public string GetName()
        {
            return name;
        }

        // 攻撃する
        public virtual void Attack()
        {
            Console.WriteLine("{0}は、攻撃した!", name);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SR1_03_02
{
    internal class Dog
    {
        // 状態や属性 「 データ 」 … フィールド
        private bool hungryState;

        // 振る舞い 「操作」 … メソッド
        public Dog()
        {
            hungryState = true;
        }

        // 食べる → 満腹になる
        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false; // おなかはすいていない
        }

        // 走る!! → ハラペコ状態にする
        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState = true; //おなかがすいた
        }

        // おなかがすいている状態か調べる
        public bool IsHungry()
        {
            return hungryState;
        }
    }
}

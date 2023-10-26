using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_04_02
{
    internal class Player
    {
        //フィールド
        private string name;
        private int level;

        //メソッド
        //コンストラクタ
        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;       
        }

        //攻撃する
        public void Attack()
        {
            Console.WriteLine("攻撃!!");
        }

        //防御する
        public void Defence()
        {
            Console.WriteLine("防御した");
        }

        //レベルアップする
        public void LevelUp()
        {
            level++;
        }

        //名前を聞く
        public string GetName()
        {
            return name;
        }

        //レベルを聞く
        public int GetLevel()
        {
            return level;
        }
    }
}

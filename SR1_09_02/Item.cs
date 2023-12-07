using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_09_02
{
    internal class Item
    {
        // フィールド
        private string name = "";

        // メソッド
        public Item(string name)
        {
            this.name = name;
        }

        public void Use()
        {
            Console.WriteLine("{0}を使用した", name);
        }
    }
}

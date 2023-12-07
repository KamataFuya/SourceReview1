using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_09_02
{
    internal class Player
    {
        // フィールド
        private Item item;

        // メソッド
        public Player(Item item)
        {
            this.item = item;
        }

        public void UseItem()
        {
            item.Use();
        }
    }
}

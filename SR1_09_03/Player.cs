using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_09_03
{
    internal class Player
    {
        // フィールド
        private List<Item> items;

        // メソッド
        public Player()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void UseItem()
        {
            foreach(Item item in items)
            {
                item.Use();
            }
        }
    }
}

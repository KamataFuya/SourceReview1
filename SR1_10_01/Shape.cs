using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_10_01
{
    internal class Shape
    {
        // フィールド
        protected float area;

        // メソッド
        public float Area()
        {
            return area;
        }

        public virtual void Draw()
        {
            // 図形の描画
            Console.WriteLine("図形...");
        }
    }
}

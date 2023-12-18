using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_10_01
{
    internal class Circle : Shape
    {
        // フィールド
        private float radius;

        // メソッド
        public Circle(float radius)
        {
            // フィールドのradiusに格納
            this.radius = radius;
            //円の面積を求め、areaに格納する
            area = (float)(Math.PI * Math.Pow(radius, 2));
        }

        public override void Draw() 
        {
            // 図形の描画
            Console.WriteLine("〇");
        }

    }
}

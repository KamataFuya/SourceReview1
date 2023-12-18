using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_10_01
{
    internal class Triangle : Shape
    {
        // フィールド
        private float width;
        private float height;

        // メソッド
        public Triangle(float width, float height)
        {
            // width,heightをそれぞれ格納する
            this.width = width;
            this.height = height;
            // 三角形の面積を求め、areaに格納する
            area = width * height * 0.5f;
        }

        public override void Draw()
        {
            // 図形の描画
            Console.WriteLine("△");
        }

    }
}

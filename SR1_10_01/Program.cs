using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(10));
            shapes.Add(new Rectangle(5, 7));
            shapes.Add(new Triangle(5, 7));

            // 多態性のテスト
            foreach(Shape shape in shapes)
            {
                // Drawメソッドのテスト
                shape.Draw();

                // Areaメソッドのテスト
                Console.WriteLine("面積:{0}", shape.Area());
            }

            // 一時停止
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryMarch24
{
    // Класс для четырёхугольника, наследующий базовый класс геометрической фигуры

    public class Quadrilateral : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;

        public Quadrilateral(double a, double b, double c, double d)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            sideD = d;
        }

        public override double Area()
        {
            double s1 = (sideA + sideB + sideC) / 2;
            double s2 = (sideC + sideD + sideA) / 2;
            double area1 = Math.Sqrt(s1 * (s1 - sideA) * (s1 - sideB) * (s1 - sideC));
            double area2 = Math.Sqrt(s2 * (s2 - sideC) * (s2 - sideD) * (s2 - sideA));
            return area1 + area2;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем четырехугольник:");

            // Отрисовка четырехугольника в консоли
            DrawQuadrilateral((int)sideA, (int)sideB, (int)sideC, (int)sideD, '*');
        }

        // Метод для отрисовки четырёхугольника в консоли
        private static void DrawQuadrilateral(int sideA, int sideB, int sideC, int sideD, char drawChar)
        {
            // Предполагается, что это прямоугольник, поэтому просто рисуем прямоугольник
            for (int i = 0; i < sideB; i++)
            {
                for (int j = 0; j < sideA; j++)
                {
                    Console.Write(drawChar);
                }
                Console.WriteLine();
            }
        }
    }
}

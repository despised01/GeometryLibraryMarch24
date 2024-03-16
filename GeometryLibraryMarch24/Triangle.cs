using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryMarch24
{
    // Класс для треугольника, наследующий базовый класс геометрической фигуры

    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public override double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем треугольник:");

            // Отрисовка треугольника в консоли
            DrawTriangle((int)sideA, (int)sideB, (int)sideC, '*');
        }

        // Метод для отрисовки треугольника в консоли

        private static void DrawTriangle(int sideA, int sideB, int sideC, char drawChar)
        {            
            for (int i = 0; i <= sideC; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(drawChar);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryMarch24
{
    // Класс для эллипса, наследующий базовый класс геометрической фигуры

    public class Ellipse : Figure
    {
        private double semiLongAxis;
        private double semiShortAxis;

        public Ellipse(double a, double b)
        {
            semiLongAxis = a;
            semiShortAxis = b;
        }

        public override double Area()
        {
            return Math.PI * semiLongAxis * semiShortAxis;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем эллипс:");

            // Отрисовка эллипса в консоли
            DrawEllipse((int)semiLongAxis, (int)semiShortAxis, '*');
        }

        // Метод для отрисовки эллипса в консоли

        private static void DrawEllipse(int semiLongAxis, int semiShortAxis, char drawChar)
        {
            for (int y = -semiShortAxis; y <= semiShortAxis; y++)
            {
                for (int x = -semiLongAxis; x <= semiLongAxis; x++)
                {
                    double value = (x * x) / (double)(semiLongAxis * semiLongAxis) + (y * y) / (double)(semiShortAxis * semiShortAxis);
                    if (value <= 1.0)
                    {
                        Console.Write(drawChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

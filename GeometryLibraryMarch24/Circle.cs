using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryMarch24
{
    // Класс для круга, наследующий базовый класс геометрической фигуры

    public class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем круг:");
            
            // Отрисовка круга в консоли
            DrawCircle((int)radius, '*');
        }

        // Метод для отрисовки круга в консоли

        private static void DrawCircle(int radius, char drawChar)
        {
            int centerX = radius;
            int centerY = radius;
            int minX = centerX - radius;
            int maxX = centerX + radius;
            int minY = centerY - radius;
            int maxY = centerY + radius;

            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    double distanceToCenter = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
                    if (distanceToCenter <= radius)
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

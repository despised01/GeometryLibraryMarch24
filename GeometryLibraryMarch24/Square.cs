using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryMarch24
{
    // Класс для квадрата, наследующий базовый класс геометрической фигуры

    public class Square : Figure
    {
        private double side;

        public Square(double s)
        {
            side = s;
        }

        public override double Area()
        {
            return side * side;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем квадрат:");

            // Отрисовка квадрата в консоли
            DrawSquare((int)side, '*');
        }

        // Метод для отрисовки квадрата в консоли

        private static void DrawSquare(int side, char drawChar)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(drawChar);
                }
                Console.WriteLine();
            }
        }
    }
}


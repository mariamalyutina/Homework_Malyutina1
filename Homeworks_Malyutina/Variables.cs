using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina
{
    public static class Variables
    {
        public static double Task1(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль решение 5*A+B^2/B-A
            if (b == a)
            {
                throw new ArgumentException("Invalid input");
            }
            return (5.0 * a + b * b) / (b - a);
        }

        public static void Task2(ref int a, ref int b)
        {
            //Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
            int temp = a;
            a = b;
            b = temp;
        }

        public static double[] Task3(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            double division = (double) a / b;
            double remainder = a % b;
            return new double[] { division, remainder};
        }

        public static double Task4(int a, int b, int c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения 
            //стандартного вида, где A*X+B=C.
            if (a == 0)
            {
                throw new ArgumentException("Invalid input");
            }
            return (double) (c - b) / a;
        }

        public static string Task5(double x1, double y1, double x2, double y2)
        {
            //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. 
            //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
            if (x2 == x1)
            {
                if (y2 == y1)
                {
                    throw new ArgumentException("Points with same coordinates");
                } else
                {
                    throw new ArgumentException("Invalid input");
                }
            }
            double a = (y2 - y1) / (x2 - x1); //почему-то возвращает -0 (если 0 делится на отриц число)
            double b = y1 - ((y2 - y1) / (x2 - x1)) * x1;
            if (b < 0)
            {
                return $"Уравнение прямой: У = {a}*X - {Math.Abs(b)}";
            }
            else 
            {
                return $"Уравнение прямой: У = {a}*X + {b}";
            } 
        }
    }
}

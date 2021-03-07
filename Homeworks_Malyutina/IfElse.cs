using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina
{
    public static class IfElse

    {
        public static int Task1(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            if (a > b)
            {
                return a + b;
            }
            else if (a < b)
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
        }

        public static string Task2(int X, int Y)
        {
            //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            if (X > 0)
            {
                if (Y > 0)
                {
                    return "I четверть";
                }
                else
                {
                    return "IV четверть";
                }
            }
            else
            {
                if (Y > 0)
                {
                    return "II четверть";
                }
                else
                {
                    return "III четверть";
                }
            }
        }

        public static int [] Task3(int a, int b, int c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
            if (a <= b && a <= c)
            {
                if (b <= c)
                {
                    return new int[] { a, b, c };
                }
                else
                {
                    return new int[] { a, c, b };
                }
            }
            else if (b <= a && b <= c)
            {
                if (a <= c)
                {
                    return new int[] { b, a, c };
                }
                else
                {

                    return new int[] { b, c, a };
                }
            }
            else
            {
                if (b <= a)
                {

                    return new int[] { c, b, a };
                }
                else
                {
                    return new int[] { c, a, b };
                }
            }
        }

        public static double [] Task4(double a, double b, double c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного 
            //вида, где AX2+BX+C=0.
            if (a == 0)
            {
                throw new Exception("a == 0");
            }
            double d = b * b - 4 * a * c;
            double x1;
            double x2;
            if (d < 0)
            {
                return new double[0];
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                return new double[] { x1 };
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }

        public static string Task5(int a)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” 
            //в консоль будет выведено “двадцать пять”.

            int b = a / 10;
            int c = a % 10;

            string literal = "";
            switch (b)
            {
                case 1:
                    switch (c)
                    {
                        case 0:
                            literal = "десять";
                            break;
                        case 1:
                            literal = "одиннадцать";
                            break;
                        case 2:
                            literal = "двенадцать";
                            break;
                        case 3:
                            literal = "тринадцать";
                            break;
                        case 4:
                            literal = "четырнадцать";
                            break;
                        case 5:
                            literal = "пятнадцать";
                            break;
                        case 6:
                            literal = "шестнадцать";
                            break;
                        case 7:
                            literal = "семнадцать";
                            break;
                        case 8:
                            literal = "восемнадцать";
                            break;
                        case 9:
                            literal = "девятнадцать";
                            break;
                    }
                    break;
                case 2:
                    literal = "двадцать";
                    break;
                case 3:
                    literal = "тридцать";
                    break;
                case 4:
                    literal = "сорок";
                    break;
                case 5:
                    literal = "пятьдесят";
                    break;
                case 6:
                    literal = "шестьдесят";
                    break;
                case 7:
                    literal = "семьдесят";
                    break;
                case 8:
                    literal = "восемдесят";
                    break;
                case 9:
                    literal = "девяносто";
                    break;
            }
            if (a >= 10 && a <= 19)
            {
                return literal;
            }
            else
            {
                switch (c)
                {
                    case 0:
                        break;
                    case 1:
                        literal += " один";
                        break;
                    case 2:
                        literal += " два";
                        break;
                    case 3:
                        literal += " три";
                        break;
                    case 4:
                        literal += " четыре";
                        break;
                    case 5:
                        literal += " пять";
                        break;
                    case 6:
                        literal += " шесть";
                        break;
                    case 7:
                        literal += " семь";
                        break;
                    case 8:
                        literal += " восемь";
                        break;
                    case 9:
                        literal += " девять";
                        break;
                }
                return literal;
            }
        }
    }
}

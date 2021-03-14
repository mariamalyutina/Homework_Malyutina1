using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina
{
    public static class ForWhileLoops
    {
        public static double Task1(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            double result = 1;
            for (int i = 0; i < Math.Abs(b); i++)
            {
                result *= a;
            } 
            if (b < 0)
            {
                result = 1 / result;
            }

            return result;
        }

        public static int[] Task2(int a)
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            if (a == 0)
            {
                throw new ArgumentException("Invalid input");
            }
            a = Math.Abs(a); //если введено отрицательное число
            int [] result = new int[1000 / a];
            int indexCount = 0;
            for (int i = a; i <= 1000; i += a)
            {
                result[indexCount] = i;
                indexCount++; 
            }
            return result;
        }

        public static int Task3(int a)
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            if (a <= 0)
            {
                throw new ArgumentException("Invalid input");
            }

            int count = 0;
            for (int i = 1; i * i < a; i++)
            {
                count++;
            }
            return count;
        }

        public static int Task4(int a)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            if (a == 0 || a == 1)
            {
                throw new ArgumentException("Invalid input");
            }
            a = Math.Abs(a); //если введено отрицательное число
            int result = 1;
            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static int Task5(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без 
            //остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
            int sum = 0;
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        public static int Task6(int a)
        {

            //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число 
            //является суммой двух предыдущих. Первое и второе считаются равными 1.
            if (a <= 0)
            {
                throw new ArgumentException("Invalid input");
            }
            int fibonacci = 1;
            int prev1 = 1;
            for (int i = 3; i <= a; i++)
            {
                fibonacci += prev1;
                prev1 = fibonacci - prev1;
            }
            return fibonacci;
        }

        public static int Task7(int a, int b)
        {
            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("Invalid input");
            }

            a = Math.Abs(a); //если введено отрицательное число
            b = Math.Abs(b); //если введено отрицательное число

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public static int Task8(int a)
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. 
            //Найдите число N методом половинного деления.

            //BINARY SEARCH
            //1) Отсортировать исходный массив / колекцию чисел
            //2) Ищем середину
            //3) Если она больше искомого => рассматриваем левый подмассив
            //4) Если она меньше искомого => рассматриваем правый подмассив
            //5) Если она равняется искомому => мы нашли число
            //6) Повторяем пока подмассив не пустой

            if (a < 0)
            {
                throw new ArgumentException("Invalid input");
            }

            int left = 0;
            int right = a;
            int n = a / 2;

            while (n * n * n != a) 
            {
                if (n * n * n > a)
                {
                    right = n;
                }
                else
                {
                    left = n;
                }
                n = (left + right) / 2;
            }
            return n;
        }

        public static double Task8WithDelta(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Invalid input");
            }
            double left = 0;
            double right = a;
            double n = a / 2;
            double delta = 0.01;

            while (!(a <= (n + delta) * (n + delta) * (n + delta) &&
                a >= (n - delta) * (n - delta) * (n - delta)))
            {
                if (n * n * n > a)
                {
                    right = n;
                }
                else
                {
                    left = n;
                }
                n = (left + right) / 2;
            }
            return n;
        }

        public static int Task9(int a)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            if (a == 0)
            {
                throw new ArgumentException("Invalid input");
            }
            a = Math.Abs(a); //для отрицательных чисел
            int count = 0;
            while (a != 0)
            {
                int c = a % 10;
                if (c % 2 != 0)
                {
                    count++;
                }
                a = a / 10;
            }
            return count;
        }

        public static string Task10(int a)
        {
            //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр 
            //заданного числа, например, задано число 123, вывести 321.
            //Возвращается string для случаев с 0 в конце, например 100 -> 001
            if (a == 0)
            {
                throw new ArgumentException("Invalid input");
            }
            string reversed = "";
            while (a != 0)
            {
                reversed += a % 10;
                a = a / 10;
            }
            return reversed;
        }

        public static int[] Task11(int a)
        {
            //Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, 
            //сумма четных цифр которых больше суммы нечетных. 
            if (a <= 0)
            {
                throw new ArgumentException("Invalid input");
            }
            if (a == 1)
            {
                return new int[0];
            }

            string result = "";
            for (int j = 1; j <= a && j < 10; j++)
            {
                if (j % 2 == 0)
                {
                    result += j;
                    result += " ";
                }
            }
            for (int i = 10; i <= a; i++)
            {
                int odd = 0;
                int even = 0;
                int temp = i;
                while (temp != 0)
                {
                    if ((temp % 10) % 2 == 0)
                    {
                        even += temp % 10;
                    }
                    else
                    {
                        odd += temp % 10;
                    }
                    temp = temp / 10;
                }
                if (even > odd)
                {
                    result += i;
                    result += " ";
                }
            }

            int[] resultInts = Array.ConvertAll(result.Remove(result.Length - 1, 1).Split(" "), int.Parse);

            return resultInts;
        }

        public static string Task12(int a, int b)
        {
            //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            int temp = b;
            bool isMatching = false;
            if (a == b)
            {
                isMatching = true;
            }
            else if (a == 0)
            {
                while (b != 0)
                {
                    if (b % 10 == 0)
                    {
                        isMatching = true;
                        break;
                    }
                    b = b / 10;
                }
            } else if (b == 0)
            {
                while (a != 0)
                {
                    if (a % 10 == 0)
                    {
                        isMatching = true;
                        break;
                    }
                    a = a / 10;
                }
            } 
            else
            {
                while (a != 0)
                {
                    b = temp;
                    while (b != 0)
                    {
                        if (a % 10 == b % 10)
                        {
                            isMatching = true;
                            break;
                        }
                        b = b / 10;
                    }
                    a = a / 10;
                }
            }
            if (isMatching)
            {
                return "ДА";
            }
            else
            {
                return "НЕТ";
            }
        }
    }
}

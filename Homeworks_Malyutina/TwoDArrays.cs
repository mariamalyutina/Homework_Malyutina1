using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina
{
    class TwoDArrays
    {
        public static int Task1()
        {
            //Найти минимальный элемент массива
            int[,] array = Create2DArray();
            int min = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] < min)
                    {
                        min = array[i,j];
                    }
                }

            }
            return min;
        }

        public static int Task2()
        {
            //Найти максимальный элемент массива
            int[,] array = Create2DArray();
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

            }
            return max;
        }

        public static int[] Task3()
        {
            //Найти индекс минимального элемента массива
            int[,] array = Create2DArray();
            int min = array[0, 0];
            int[] minIndex = new int[] { 0, 0 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }

            }
            return minIndex;
        }

        public static int[] Task4()
        {
            //Найти индекс максимального элемента массива
            int[,] array = Create2DArray();
            int max = array[0, 0];
            int[] maxIndex = new int[] { 0, 0 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }

            }
            return maxIndex;
        }

        public static int Task5()
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно

            int[,] array = Create2DArray();
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool isBigger = true;
                    for (int a = i - 1; a <= i + 1; a++)
                    {
                        for (int b = j - 1; b <= j + 1; b++)
                        {
                            if (isValidCell(array, a, b))
                            {
                                if (array[i, j] < array[a, b])
                                {
                                    isBigger = false;
                                    continue;
                                }
                            }
                        }
                    }
                    if (isBigger)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static bool isValidCell(int[,] array, int a, int b)
        {
            if (a >= 0 && b >= 0)
            {
                if (a < array.GetLength(0) && b < array.GetLength(1))
                    return true;
            }
            return false;
        }

        public static int[,] Task6()
        {
            //Отразите массив относительно его главной диагонали
            int[,] array = Create2DArray();
            int[,] reversedArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    reversedArray[j, i] = array[i, j];
                }
            return reversedArray;
        }

        private static int[,] Create2DArray()
        {
            int[,] array = new int[2,4];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10,99);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina
{
    class Arrays
    {
        
        public static int Task1()
        {
            //Найти минимальный элемент массива
            int[] array = CreateArray();
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int Task2()
        {
            //Найти максимальный элемент массива
            int[] array = CreateArray();
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int Task3()
        {
            //Найти индекс минимального элемента массива
            int[] array = CreateArray();
            int min = array[0];
            int minIndex = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int Task4()
        {
            //Найти индекс максимального элемента массива
            int[] array = CreateArray();
            int max = array[0];
            int maxIndex = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int Task5()
        {
            //Посчитать сумму элементов массива с нечетными индексами
            int[] array = CreateArray();

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int[] Task6()
        {
            //Сделать реверс массива (массив в обратном направлении)
            int[] array = CreateArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            return array;
        }

        public static int Task7()
        {
            //Посчитать количество нечетных элементов массива
            int[] array = CreateArray();
            int oddCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }

        public static int[] Task8()
        {
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, 
            //результат 3 4 1 2,  или для 12345 - 45312.

            int[] array = CreateArray();
            int step = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i + step];
                array[i + step] = array[i];
                array[i] = temp;
            }

            return array;
        }

        public static int[] Task9()
        {
            //Отсортировать массив по возрастанию выбором(Select) 
            //Идея: сначала перебрать все элементы и найти индекс наименьшего, затем поместить его в самое начало.
            //На след итерации искать индекс наименьшего без учета первого элемента. Поместить его на второе место и т.д.
            //На каждой итерации индекс минимального элемента - это первый элемент из оставшихся неотсортированных

            int[] array = CreateArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndx = i;
                for (int j = i + 1; j < array.Length; j++) 
                {
                    if (array[j] < array[minIndx])
                    {
                        minIndx = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndx];
                array[minIndx] = temp;
            }
            return array;
        }

        public static int[] Task10()
        {
            //Отсортировать массив по убыванию вставками(Insert) 
            //Идея: отсортировать первый и второй элементы. Сравнить третий с каждым из первых двух последовательно, 
            //вставить его на нужное место. Сравнить четвертый последовательно с тремя предыдущими и вставить на место и т.д.
            

            int[] array = CreateArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j] > array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
                
            }
            return array;

        }

        private static int[] CreateArray()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 31);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            return array;
        }
    }
}

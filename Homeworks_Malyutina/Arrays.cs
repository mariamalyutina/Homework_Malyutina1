using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina
{
    public static class Arrays
    {
        
        public static int Task1(int[] array)
        {
            //Найти минимальный элемент массива
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
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

        public static int Task2(int[] array)
        {
            //Найти максимальный элемент массива
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
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

        public static int Task3(int[] array)
        {
            //Найти индекс минимального элемента массива
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            int min = array[0];
            int minIndex = 0;
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

        public static int Task4(int[] array)
        {
            //Найти индекс максимального элемента массива
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            int max = array[0];
            int maxIndex = 0;
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

        public static int Task5(int[] array)
        {
            //Посчитать сумму элементов массива с нечетными индексами
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

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

        public static int[] Task6(int[] array)
        {
            //Сделать реверс массива (массив в обратном направлении)
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            return array;
        }

        public static int Task7(int[] array)
        {
            //Посчитать количество нечетных элементов массива
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
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

        public static int[] Task8(int[] array)
        {
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, 
            //результат 3 4 1 2,  или для 12345 - 45312.

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int step = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i + step];
                array[i + step] = array[i];
                array[i] = temp;
            }

            return array;
        }

        public static int[] Task9(int[] array)
        {
            //Отсортировать массив по возрастанию выбором(Select) 
            //Идея: сначала перебрать все элементы и найти индекс наименьшего, затем поместить его в самое начало.
            //На след итерации искать индекс наименьшего без учета первого элемента. Поместить его на второе место и т.д.
            //На каждой итерации индекс минимального элемента - это первый элемент из оставшихся неотсортированных

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

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

        public static int[] Task10(int[] array)
        {
            //Отсортировать массив по убыванию вставками(Insert) 
            //Идея: отсортировать первый и второй элементы. Сравнить третий с каждым из первых двух последовательно, 
            //вставить его на нужное место. Сравнить четвертый последовательно с тремя предыдущими и вставить на место и т.д.

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

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

        
    }
}

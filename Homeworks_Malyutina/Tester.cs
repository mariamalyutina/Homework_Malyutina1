using System;

namespace Homeworks_Malyutina
{
    class Tester
    {
        static void Main(string[] args) 
        {
            //int[] array = CreateArray();
            //Console.WriteLine(Arrays.Task1(array));
            PrintOut2DArray(TwoDArrays.Task6(new int[,] { { 1 },
            { 5},
            { 0} }));



        }
        public static int[] CreateArray()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 31);
            }
            PrintOutArray(array);
            return array;
        }

        public static void PrintOutArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[,] Create2DArray()
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 99);
                }
            }
            PrintOut2DArray(array);
            return array;
        }
        

        public static void PrintOut2DArray<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

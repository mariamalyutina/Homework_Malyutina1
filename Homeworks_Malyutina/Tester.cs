using System;

namespace Homeworks_Malyutina
{
    class Tester
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(ForWhileLoops.Task12(-202, 101));


        }



        public static void PrintOutArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
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

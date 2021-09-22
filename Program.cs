using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число с индексом {l} \t");
                array[l] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Ваш массив выглядит следующим образом: ");
            for (int i = 0; i < ArrNumber; i++)
            {
                Console.WriteLine("\n"+ array[i]);
            }
            Console.ReadLine();
        }
    }
}

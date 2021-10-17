using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = N, j = N, Sum0 = 0, Sum = 0;
            int[,] array = new int[i, j];
            bool isMagical = true;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"Введите ({i}, {j}) элемент массива: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }                
            }
            for (i = 0; i < N; i++)
            {
                Sum0 += array[i, i];
                Sum += array[i, N - i - 1];
            }
            if (Sum != Sum0)
            {
                isMagical = false;
            }
            for (i = 0; i < N; i++)
            {
                Sum = 0;
                for (j = 0; j < N; j++)
                {
                    Sum += array[i, j];
                }
                if (Sum != Sum0)
                {
                    isMagical = false;
                    break;
                }
                Sum = 0;
                for (j = 0; j < N; j++)
                {
                    Sum += array[j, i];
                }
                if (Sum != Sum0)
                {
                    isMagical = false;
                    break;
                }
            }
            Console.WriteLine("Полученный массив:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0,4} ", array[i, j]);
                }
                Console.WriteLine();
            }
            if (!isMagical)
                Console.WriteLine("Не является магическим квадратом");
            else
                Console.WriteLine("Является магическим квадратом");
            Console.ReadKey();
        }
    }
}

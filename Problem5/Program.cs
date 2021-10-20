using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            /*for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j % 2 == 0)                        
                            array[i, j] = 1;                        
                        Console.Write("{0,2} ", array[i, j]);
                    }
                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j % 2 != 0)
                            array[i, j] = 1;
                        Console.Write("{0,2} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }*/
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                        array[i, j] = 1;
                    else
                        array[i, j] = 0;
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

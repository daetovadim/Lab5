using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 7;
            int[] array = new int[n];
            float Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            Console.Write("Для элементов массива: ");
            foreach (int a in array)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine("\nсреднее арифметическое составляет: {0:f2}", Sum / n);
            Console.ReadKey();
        }
    }
}
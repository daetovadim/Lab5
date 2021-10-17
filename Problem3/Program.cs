using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 10;
            sbyte[] array = new sbyte[n];
            Random random = new Random();
            Console.Write("Изначальный массив:\t");
            for (byte i = 0; i < n; i++)
            {
                array[i] = (sbyte)random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            Console.Write("\nОтсортированный массив: ");
            for (byte i = 0; i < 5; i++)
            {
                for (byte j = (byte)(i + 1); j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        sbyte t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (byte i = 5; i >= 5 && i < n; i++)
            {
                for (byte j = (byte)(i + 1); j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        sbyte t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            foreach (byte i in array)
            {
                Console.Write("{0,4} ", i);
            }
            Console.ReadKey();
        }
    }
}

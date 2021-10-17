using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 15;
            byte[] array = new byte[n];
            Random random = new Random();
            Console.Write("Полученный массив: ");
            for (byte i = 0; i < n; i++)
            {
                array[i] = (byte)random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            byte max = array[0];
            byte min = array[0];
            foreach (byte a in array)
            {
                if (a > max)
                    max = a;
                else if (a < min)
                    min = a;
            }
            Console.WriteLine($"\nСумма максимального элемента массива ({max}) и минимального ({min}) составила: {max + min}");
            Console.ReadKey();
        }
    }
}

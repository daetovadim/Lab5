using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);
            }
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("\n" + max);
            Console.ReadKey();
        }
    }
}

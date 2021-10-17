using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 20;
            sbyte[] array = new sbyte[n];
            Random random = new Random();
            Console.WriteLine("Получившийся массив:");
            for (byte i = 0; i < n; i++)
            {
                array[i] = (sbyte)random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            byte amount = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0 && array[i] > 0 && i % 2 == 0)
                    amount++;
            }
            Console.WriteLine("\nКоличество элементов, удовлетворяющих условию задачи: " + amount);
            Console.ReadKey();
        }
    }
}

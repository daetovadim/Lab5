using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMagic(int[][] a, int m)
            {
                int sum = 0, temp_sum = 0;
                for (int i = 0; i < m; i++)
                    sum += a[i][i];
                for (int i = 0; i < m; i++)
                    temp_sum += a[i][m - i - 1];
                if (sum != temp_sum)
                    return false;
                for (int i = 0; i < m; i++)
                {
                    temp_sum = 0;
                    for (int j = 0; j < m; j++)
                        temp_sum += a[i][j]
                    if (sum != temp_sum)
                        return false;
                    temp_sum = 0;
                    for (int j = 0; j < m; j++)
                        temp_sum += a[j][i]
                    if (sum != temp_sum)
                        return false;
                }
                return true;
            }
        }
    }
}

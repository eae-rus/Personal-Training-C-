using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Мат_проба
{
    class Program
    {
        static void Main(string[] args)
        {
            byte m = 1;
            byte n = 1;
            Console.WriteLine("Введите m");
            m = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите n");
            n = Convert.ToByte(Console.ReadLine());
            float[,] A = new float[m, n];

            for (byte i = 1; i < m + 1; i++)
            {
                for (byte j = 1; i < n + 1; i++)
                {
                    Console.WriteLine("Введите A ",i,",",j," Член");
                    A[i, j] = (float)Convert.ToDouble(Console.ReadLine());
                }

                float Определитель;
                if (m == 2)
                {
                    Определитель = A[1, 1] * A[2, 2] - A[2, 1] - A[1, 2];
                    Console.WriteLine("Определител равен = ", Определитель);
                    Console.ReadKey();
                }
            }
        }
    }
}

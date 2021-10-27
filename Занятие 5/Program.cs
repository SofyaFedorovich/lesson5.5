using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_5
{
    class Program
    {
        static void Main(string[] args)
        {// создание двумерного массива 
            Console.WriteLine("Ввести целое значение N для создания массива:");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Random random = new Random();
            Console.WriteLine("Массив NxN:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write("{0}", array[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}

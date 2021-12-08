using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сравнение чисел
            int N, polojitelnye, otricatelnye;
            polojitelnye = 0;
            otricatelnye = 0;

            do
            {
                Console.WriteLine("Введите целое число. В случае отказа введите 0");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    polojitelnye++;
                }
                else
                {
                    if (N < 0)
                    {
                        otricatelnye++;
                    }
                }
            }
            while (N != 0);

            if (polojitelnye > otricatelnye)
            {
                Console.WriteLine("Положительных чисел больше чем отрицательных");
            }
            else
            {
                if (polojitelnye < otricatelnye)
                {
                    Console.WriteLine("Положительных чисел меньше чем отрицательных");
                }
                else
                {
                    if (polojitelnye == otricatelnye && polojitelnye == 0)
                    {
                        Console.WriteLine("Числа не заданы");
                    }
                    else
                    {
                        Console.WriteLine("Положительных чисел равно количеству отрицательных");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

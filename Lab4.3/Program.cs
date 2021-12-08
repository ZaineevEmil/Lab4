using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наложение квадратов
            double A, B, C, NA, NB, N;
            NA = 0;
            NB = 0;
            N = 0;
            Console.WriteLine("Введите сторону квадрата А");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата C");
            C = Convert.ToDouble(Console.ReadLine());
            if (C>A||C>B)
            {
                Console.WriteLine("В прямоугольник АхВ невозможно вписать хотябы 1 квадрат С");
            }
            else
            {
            while (A >= C)
                {
                    A = A - C;
                    NA++;
                }
                while (B >= C)
                {
                    B = B - C;
                    NB++;
                }
                while (NB > 0)
                {
                    N=N+NA;
                    NB--;
                }
                Console.WriteLine("В прямоугольник АхВ можно вписать {0} квадратов С", N);
            }
            Console.ReadKey();






        }
    }
}

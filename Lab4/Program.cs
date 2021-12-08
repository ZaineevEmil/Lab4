using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Квадрат чисел
            int N, KvadratN, i;
            i = 0;
            KvadratN = 0;
            Console.WriteLine("Введине целое число больше 0");
            N = Convert.ToInt32(Console.ReadLine());
            for ( ; i <N; )
            {
                i = i + 1;
                KvadratN = KvadratN + 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, KvadratN);
            }
            Console.ReadKey();
        }
    }
}

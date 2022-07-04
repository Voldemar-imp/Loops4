using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicsOfProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            int total = 0;

            Console.WriteLine("Сгенерированное число - " + number);

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0)
                    total += i;

                if (i % 5 == 0)
                    total += i;
            }

            Console.WriteLine("Сумма всех положительных чисел меньше " +
                "сгенерированного, которые кратны 3 или 5 = " + total);
        }
    }
}

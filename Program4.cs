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
            int maxNumber = 100;
            int minNumber = 0;
            int number = random.Next(minNumber, maxNumber);
            int multiplicity1 = 3;
            int multiplicity2 = 5;
            int total = 0;

            Console.WriteLine("Сгенерированное число - " + number);

            for (int i = 0; i <= number; i++)
            {
                if (i % multiplicity1 == 0 || i % multiplicity2 == 0)
                    total += i;
            }

            Console.WriteLine("Сумма всех положительных чисел меньше " +
                "сгенерированного, которые кратны " + multiplicity1 + " или " + multiplicity2 + " = "  + total);
        }
    }
}

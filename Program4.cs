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
            int multiplicity3 = 3;
            int multiplicity5 = 5;
            int total = 0;

            Console.WriteLine("Сгенерированное число - " + number);
            
            for (int i = 0; i <= number; i++)
            {
                if (i % multiplicity3 == 0 || i % multiplicity5 == 0) 
                    total += i;
            }

            Console.WriteLine("Сумма всех положительных чисел меньше " +
                "сгенерированного, которые кратны 3 или 5 = " + total);
        }
    }
}

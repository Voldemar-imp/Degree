using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber1 = 1;
            int maxNumber1 = 100;
            int number1 = random.Next(minNumber1, (maxNumber1 + 1));
            int number2 = 2;
            int total = number2;
            int degree = 1;

            Console.WriteLine("Выпало число: " + number1);

            while (total < number1)
            {
                degree++;
                total *= number2;
                Console.WriteLine("число {0} в степени {1}, равнo: {2}", number2, degree, total);
                Console.ReadKey();
            }
            
            Console.WriteLine(total + " > " + number1);
            Console.WriteLine("минимальная степень числа {0}, превосходящая число {1}, " +
                "равна: {2}", number2, number1, degree);
        }
    }
}

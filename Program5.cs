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
            int minRandomNumber = 1;
            int maxRandomNumber = 100;
            int randomNumber = random.Next(minRandomNumber, (maxRandomNumber + 1));
            int basisOfDegree = 2;
            int totalCalculation = basisOfDegree;
            int degree = 1;

            Console.WriteLine("Выпало число: " + randomNumber);

            while (totalCalculation <= randomNumber)
            {
                degree++;
                totalCalculation *= basisOfDegree;
                Console.WriteLine("число {0} в степени {1}, равнo: {2}", basisOfDegree, degree, totalCalculation);
            }

            Console.WriteLine(totalCalculation + " > " + randomNumber);
            Console.WriteLine("минимальная степень числа {0}, превосходящая число {1}, " +
                "равна: {2}", basisOfDegree, randomNumber, degree);
        }
    }
}

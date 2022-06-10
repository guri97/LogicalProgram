using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumbers
    {
        public void primenumber()

        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i % 1 == 0 || i % i == 0)
                {
                    Console.WriteLine("This is Prime Number {i}:");
                }
                else
                {
                    Console.WriteLine("This is not A Prime NUmber:");
                }
            }

        }
    }
}

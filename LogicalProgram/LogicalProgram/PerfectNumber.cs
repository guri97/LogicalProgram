using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public bool Factors(int Number, int Potential_factor)
        {
            if (Number % Potential_factor == 0)
            {
                return true;
            }


            else
            {
                return false;
            }
        }
        public void perfectnum()
        {

            int check = 0;
            Console.Write("Enter the number that you want to check");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= Number / 2; i++)
            {
                if (Factors(Number, i))
                {
                    check += i;
                }

                if (check == Number)
                {
                    Console.WriteLine(" this is the perfect number");

                }
                else
                {
                    Console.WriteLine("Tthis is not the perfect number");
                }
            }

        }
    }
}

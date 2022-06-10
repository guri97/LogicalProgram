using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public static void ReverseNum()
        {
            Console.Write("Enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int Reversed_Number = 0;

            string Digits = Convert.ToString(Number);

            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                Reversed_Number += (Number % 10) + (int)Math.Pow(10, 1);
                Number = Number / 10;
            }
            Console.WriteLine("The reverse of given number is: " + Reversed_Number);
        }
    }
}

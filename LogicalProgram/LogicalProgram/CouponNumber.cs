using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CouponNumber
    {
        public void CoupoNum()
        {
            int randonnum, totalCount = 0;
            Console.WriteLine("Enter how many coupon number you want to generate");
            int N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            int count = N;

            List<int> Number = new List<int>();


            for (int i = 0; i < count; i++)

            {

                Number.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(Number[i]);
            }

            while (Number.Count > 0)
            {
                randonnum = random.Next(100, 1000);
                totalCount++;
                foreach (int number in Number)
                {
                    if (randonnum == number)
                    {
                        Number.Remove(number);
                        break;
                    }
                }
            }
            Console.WriteLine($"Number of random numbers generated {totalCount}");
        }

    }
}

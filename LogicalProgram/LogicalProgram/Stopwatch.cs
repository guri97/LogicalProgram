using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Stopwatch
    {
        public static void Stopwatchprg()
        {
            Console.WriteLine("Press Enter to Start.");
            Console.WriteLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter to Stop.");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.Write("Elapsed Time = " + (Stop - Start));
        }
    }
}

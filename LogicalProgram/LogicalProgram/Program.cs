namespace LogicalProgram
{
    class logicalProgram
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number to Choose Respective Problem, \n");
            Console.WriteLine("Enter 1 for Stopwatch");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    Stopwatch stopwatch = new Stopwatch();
                    Stopwatch.Stopwatchprg();
                    break;

            }
        }
    }
}


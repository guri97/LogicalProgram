namespace LogicalProgram
{
    class logicalProgram
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number to Choose Respective Problem, \n");
            Console.WriteLine("Enter 1 for Stopwatch");
            Console.WriteLine("Enter 2 for ReverseNumber");
            Console.WriteLine("Enter 4 for PrimeNumbers");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    Stopwatch stopwatch = new Stopwatch();
                    Stopwatch.Stopwatchprg();
                    break;

                case 2:
                    ReverseNumber ReverseNum = new ReverseNumber();
                    ReverseNumber.ReverseNum();
                    break;

                case 4:
                    PrimeNumbers primenumber = new PrimeNumbers();
                    primenumber.primenumber();
                    break;



            }
        }
    }
}


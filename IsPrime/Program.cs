using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
         try
            {
                IsPrime();
            }         
         catch (System.FormatException)
            {
                Console.WriteLine("Please enter an integer next time bub.");
            }
            
        }
        
        static void IsPrime()
        {
            Console.WriteLine("Enter an integer.");

            var EnteredString = Console.ReadLine();
            var TestNumber = 2;
            var EnteredNumber = Convert.ToInt32(EnteredString);
            var NotPrime = true;
            while (TestNumber <= EnteredNumber / 2)
            {
                if (EnteredNumber % TestNumber == 0)
                {
                    NotPrime = false;
                    break;
                }

                TestNumber += 1;

            }
            if (NotPrime == true)
            {
                Console.WriteLine($"{EnteredNumber} is prime!");
            }
            else
            {
                Console.WriteLine($"{EnteredNumber} is not prime.");
            }
        }
    }
}

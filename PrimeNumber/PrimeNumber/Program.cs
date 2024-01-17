using System.Runtime.CompilerServices;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lets check the number if it is Prime Number");
            //imagine that user is not tester and will use numbers

            bool isPrimeNumber = IsPrimeNumber(SaftyNumberCheck());

            Console.WriteLine($"Is it prime number? {isPrimeNumber}");

        }


        static int SaftyNumberCheck()
        {
            int safeNumber = 0;
            bool isSafe = false;

            do
            {
                Console.Write("Write your Number: ");
                isSafe = int.TryParse(Console.ReadLine(), out safeNumber);
            } while (!isSafe);

            return safeNumber;
        }

        static bool IsPrimeNumber(int number)
        {
            //create variable to calc the amount of deviders of number
            byte divider = 0;

            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    divider++;
            }
            
            return divider < 3 ? true : false;
        }
    }
}
using System;

namespace BranchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express");

            Console.WriteLine("What is your package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            

            Console.WriteLine("What is your package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            if (packageHeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.");
                return;
            }

            Console.WriteLine("What is your package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
 
            if (packageLength > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.");
                return;
            }

            double quote = packageHeight * packageWeight * packageLength / 100d;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
        }
    }
}

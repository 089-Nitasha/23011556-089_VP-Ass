
using System;

namespace Visual_Assignment_089
{
    class Q6_Factorial_Calculator
    {
        public void factcalculator()
        {
            Console.Write("Enter a number to calculate factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1, i = 1;
            while (i <= n)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("The Factorial of " + n + " is = " + factorial);
        }

    }
}

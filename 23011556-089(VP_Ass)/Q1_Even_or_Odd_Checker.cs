using System;
namespace Visual_Assignment_089
{
    class Q1_Even_or_Odd_Checker
    {
        public void EvenOdd()
        {
            Console.Write("Enter a number which you want to check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The entered number is Even.");
            }
            else
            {
                Console.WriteLine("The entered number is Odd.");
            }
        }
    }
}

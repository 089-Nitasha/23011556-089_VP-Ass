using System;
namespace Visual_Assignment_089
{
    class Q4_Sum_of_Natural_Numbers
    {
        public void naturalsum()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The Sum of numbers from 1 to " + n + " = " + sum);
        }

    }
}

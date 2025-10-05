using System;

namespace Visual_Assignment_089
{
    class Q7_Reverse_a_Number
    {
        public void numreverse()
        {
            Console.Write("Enter a number whose reverse you want: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num;
            int reverse = 0;
            while (num != 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }
            Console.WriteLine("The Reversed number of " + n + " is = " + reverse);
        }

    }
}

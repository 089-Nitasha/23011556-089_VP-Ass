using System;

namespace Visual_Assignment_089
{
    class Q9_Count_Even_and_Odd_Numbers
    {
        public void countevenodd()
        {
            int[] arr = new int[10];
            int even = 0, odd = 0;

            Console.WriteLine("Enter 10 integers of array:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0) even++;
                else odd++;
            }

            Console.WriteLine("The no of even numbers in array is: " + even);
            Console.WriteLine("The no of odd numbers in array is: " + odd);
        }

    }
}

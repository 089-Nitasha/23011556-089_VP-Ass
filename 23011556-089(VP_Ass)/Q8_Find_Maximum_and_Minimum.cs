using System;

namespace Visual_Assignment_089
{
    class Q8_Find_Maximum_and_Minimum
    {
        public void findmaxmin()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers of array to find maximun and minimum:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine("The maximum number of array is :" + max);
            Console.WriteLine("The minimum number of array is :" + min);
        }

    }
}

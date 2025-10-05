using System;

namespace Visual_Assignment_089
{
    class Q10_Search_Element
    {
        public void searchnum()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers of array:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number to search if this exist in array or not : ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            foreach (int num in arr)
            {
                if (num == search)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found ? "The Number is found!" : "The Number is not found!");
        }

    }
}

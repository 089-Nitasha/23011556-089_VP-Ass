using System;

namespace Visual_Assignment_089
{
    class Q5_Multiplication_Table
    {
        public void mulTable()
        {
            Console.Write("Enter a number from 0-10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The table of " + num + " is given below:");
            for (int i = 1; i <= 10; i++)
            {
                int j = num * i;
                Console.WriteLine(num + " x " + i + " = " + j);
                //Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

    }
}

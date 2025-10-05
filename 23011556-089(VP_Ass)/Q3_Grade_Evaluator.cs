using System;

namespace Visual_Assignment_089
{
    class Q3_Grade_Evaluator
    {
        public void evaluator()
        {
            Console.Write("Enter your marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85)
                Console.WriteLine("Your Grade is: A");
            else if (marks >= 70 && marks <= 84)
                Console.WriteLine("Your Grade is: B");
            else if (marks >= 55 && marks <= 69)
                Console.WriteLine("Your Grade is: C");
            else if (marks >= 40 && marks <= 54)
                Console.WriteLine("Your Grade is: D");
            else
                Console.WriteLine("Your Grade is: F");
        }

    }
}

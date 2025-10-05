using System;
namespace Visual_Assignment_089
{
    class Q2_Simple_Calculator
    {
        public void calculator()
        {
            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("The Result is: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("The Result is: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("The Result is: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine("The Result is: " + (num1 / num2));
                    else
                        Console.WriteLine("Error: Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }
}


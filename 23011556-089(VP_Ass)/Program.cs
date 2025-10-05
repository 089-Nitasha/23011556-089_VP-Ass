using System;
namespace Visual_Assignment_089
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1_Even_or_Odd_Checker checker = new Q1_Even_or_Odd_Checker();
            checker.EvenOdd();

            Q2_Simple_Calculator cal = new Q2_Simple_Calculator();
            cal.calculator();

            Q3_Grade_Evaluator eval = new Q3_Grade_Evaluator();
            eval.evaluator();

            Q4_Sum_of_Natural_Numbers sum = new Q4_Sum_of_Natural_Numbers();
            sum.naturalsum();

            Q5_Multiplication_Table table = new Q5_Multiplication_Table();
            table.mulTable();

            Q6_Factorial_Calculator factcal = new Q6_Factorial_Calculator();
            factcal.factcalculator();

            Q7_Reverse_a_Number reverse = new Q7_Reverse_a_Number();
            reverse.numreverse();

            Q8_Find_Maximum_and_Minimum maxmin = new Q8_Find_Maximum_and_Minimum();
            maxmin.findmaxmin();

            Q9_Count_Even_and_Odd_Numbers count = new Q9_Count_Even_and_Odd_Numbers();
            count.countevenodd();

            Q10_Search_Element search = new Q10_Search_Element();
            search.searchnum();
        }

    }
}

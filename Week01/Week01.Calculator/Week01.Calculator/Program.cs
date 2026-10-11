using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.Calculator
{
    internal class Program
    {
        static double Calculator(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operation (+, -, *, /): ");
            string operation = Console.ReadLine();
            try
            {
                double result = Calculator(firstNum, secondNum, operation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Method
{
    internal class Program
    {
        static void Max()
        {
            Console.Write("Enter First Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number :");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            Console.WriteLine("The Maximum Number is : " + max);
        }
        static int loop()
        {
            Console.Write("Entre a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("--------------");
            return number;
        }
        static void OddEven()
        {
            int number = loop();
            int[] OddArr = new int[number];
            int[] EvenArr = new int[number];
            int oddIndex = 0;
            int evenIndex = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    EvenArr[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    OddArr[oddIndex] = i;
                    oddIndex++;
                }
            }
            Console.WriteLine("Sum of Odd Numbers: " + string.Join(", ", OddArr.Where(n => n != 0)));
            Console.WriteLine("Sum of Even Numbers: " + string.Join(", ", EvenArr.Where(n => n != 0)));

        }
        static void Factorial()
        {
            int number = loop();
            int Fac = 1;
            for (int i = 1; i <= number; i++)
            {
                Fac *= i;
            }
            Console.WriteLine("The Factorial of " + number + " is : " + Fac);

        }
        static void sumloop()
        {
            Console.Write("Entre number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = num;
            while (num != -99)
            {
                Console.WriteLine("The sum is : " + sum);
                Console.Write("Entre a another number :");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
        }
        static double DaysAndWeeks()
        {
            Console.Write("Enter the number of Hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            double days = hours / 24.0;
            double weeks = days / 7.0;
            Console.WriteLine($"Days: {days}");
            Console.WriteLine($"Weeks: {weeks}");
            return weeks;
        }
        static int letters()
        {
            int count = 64;
            for (int i = 1; i <= 26; i++)
            {
                count++;
                Console.WriteLine((char)count);
            }
            return count;
        }
        static void PiggyBank()
        {
            int Penny = 1;
            int Nickel = 5;
            int Dime = 10;
            int Quarter = 25;
            int HalfDollar = 50;
            int Dollar = 100;
            Console.Write("Enter Number of Pennies :");
            int numPennies = Convert.ToInt32(Console.ReadLine());
            Penny *= numPennies;
            Console.Write("Enter Number of Nickels :");
            int numNickels = Convert.ToInt32(Console.ReadLine());
            Nickel *= numNickels;
            Console.Write("Enter Number of Dimes :");
            int numDimes = Convert.ToInt32(Console.ReadLine());
            Dime *= numDimes;
            Console.Write("Enter Number of Quarters :");
            int numQuarters = Convert.ToInt32(Console.ReadLine());
            Quarter *= numQuarters;
            Console.Write("Enter Number of Half Dollars :");
            int numHalfDollars = Convert.ToInt32(Console.ReadLine());
            HalfDollar *= numHalfDollars;
            Console.Write("Enter Number of Dollars :");
            int numDollars = Convert.ToInt32(Console.ReadLine());
            Dollar *= numDollars;
            Console.WriteLine($"Total Amount in Piggy Bank: {Penny + Nickel + Dime + Quarter + HalfDollar + Dollar} cents");
            Console.WriteLine($"Total Amount in Piggy Bank: {(Penny + Nickel + Dime + Quarter + HalfDollar + Dollar) / 100.0} dollars");
        }
        static void ReverseWords()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            string reversedSentence = string.Join(" ", words);
            Console.WriteLine("Reversed sentence: " + reversedSentence);
        }
        static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        static void PrimeNumbers()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime numbers up to {number}:");
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            // Max();
            // loop();
            // OddEven();
            // Factorial();
            // sumloop();
            // DaysAndWeeks();
            // letters();
            // PiggyBank();
            // ReverseWords();
            // MultiplicationTable();
            PrimeNumbers();
            Console.ReadKey(true);
        }
    }
}

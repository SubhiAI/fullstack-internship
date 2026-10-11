using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students you will enter?");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            double totalAverageSum = 0.0;

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter Student Name {i + 1}: ");
                string studentName = Console.ReadLine();

                Console.Write("Enter First Mark: ");
                int mark1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Mark: ");
                int mark2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Third Mark: ");
                int mark3 = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (mark1 < 0 || mark1 > 100 || mark2 < 0 || mark2 > 100 || mark3 < 0 || mark3 > 100)
                    {
                        throw new ArgumentOutOfRangeException("Marks should be between 0 and 100.");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                    continue;
                }

                double studentAverage = (mark1 + mark2 + mark3) / 3.0; 
                Console.WriteLine("The average for " + studentName + " is: " + studentAverage);
                Console.WriteLine("------------------------------");
                totalAverageSum += studentAverage;
            }

            if (numStudents > 0)
            {
                double totalAverage = totalAverageSum / numStudents;
                Console.WriteLine("The total average is: " + totalAverage);
            }
            else
            {
                Console.WriteLine("No students entered.");
            }
            Console.ReadKey(true);
        }
    }
}

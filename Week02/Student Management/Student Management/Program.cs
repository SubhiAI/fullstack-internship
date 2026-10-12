using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services service = new Services();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nStudent Management System :)");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Calculate Average");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudentPrompt(service);
                        break;
                    case "2":
                        service.ViewStudents();
                        break;
                    case "3":
                        SearchStudentPrompt(service);
                        break;
                    case "4":
                        UpdateStudentPrompt(service);
                        break;
                    case "5":
                        DeleteStudentPrompt(service);
                        break;
                    case "6":
                        service.CalculateAverage();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }

        static void AddStudentPrompt(Services service)
        {
            try
            {
                Console.Write("Enter Student ID: ");
                int id = int.Parse(Console.ReadLine());
                id = Math.Abs(id);
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Student Grade: ");
                double grade = double.Parse(Console.ReadLine());
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Warning: Grade should be between 0 and 100.");
                    return;
                }
                if (service.SearchStudent(id) != null)
                {
                    Console.WriteLine("Warning: This ID is already in use. Please enter a unique ID.");
                    return;
                }
                Student newStudent = new Student(id, name, grade);
                service.AddStudent(newStudent);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter appropriate values for ID (number) and Grade (number).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void SearchStudentPrompt(Services service)
        {
            try
            {
                Console.Write("Enter Student ID to search: ");
                int id = int.Parse(Console.ReadLine());

                var student = service.SearchStudent(id);
                if (student != null)
                {
                    Console.WriteLine($"Found ->  ID: {student.Id} , Name: {student.Name} , Grade: {student.Grade}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. ID must be a number.");
            }
        }

        static void UpdateStudentPrompt(Services service)
        {
            try
            {
                Console.Write("Enter Student ID to update: ");
                int id = int.Parse(Console.ReadLine());

                var student = service.SearchStudent(id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.Write($"Enter new Name (current: {student.Name}): ");
                string name = Console.ReadLine();

                Console.Write($"Enter new Grade (current: {student.Grade}): ");
                double grade = double.Parse(Console.ReadLine());

                service.UpdateStudent(id, name, grade);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter appropriate value for Grade (number).");
            }
        }

        static void DeleteStudentPrompt(Services service)
        {
            try
            {
                Console.Write("Enter Student ID to delete: ");
                int id = int.Parse(Console.ReadLine());
                service.DeleteStudent(id);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. ID must be a number.");
            }
        }
    }  
}


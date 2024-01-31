using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_01_Q6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the student's name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter the student's exam marks:");
            if (int.TryParse(Console.ReadLine(), out int examMarks))
            {
                if (examMarks >= 0 && examMarks <= 100)
                {
                    string grade = DetermineGrade(examMarks);

                    Console.WriteLine($"Student Name: {studentName}");
                    Console.WriteLine($"Grade: {grade}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid exam marks. Marks should be between 0 and 100 inclusive.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input.");
            }

            Console.ReadLine();
        }

        static string DetermineGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                return "Grade A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                return "Grade B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                return "Grade C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                return "Grade D";
            }
            else
            {
                return "Fail";
            }
        }
    }
}


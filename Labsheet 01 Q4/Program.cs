using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_01_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number to display its multiplication table:");

                
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine($"Multiplication table for {number}:");

                    
                    for (int i = 1; i <= 10; i++)
                    {
                        int result = number * i;
                        Console.WriteLine($"{number} * {i} = {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.ReadLine();
            }

        }
    }
}
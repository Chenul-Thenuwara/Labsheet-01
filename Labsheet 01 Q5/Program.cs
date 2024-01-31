using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_01_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");

            
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
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
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            
            Console.ReadLine();
        }
    
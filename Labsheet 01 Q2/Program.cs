using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labsheet_01_Q2
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter 10 integers:");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Enter an integer: ");
                    int number;

                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (IsEven(number))
                        {
                            Console.WriteLine(number + " is even.");
                        }
                        else
                        {
                            Console.WriteLine(number + " is odd.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        i--;
                }

                Console.ReadLine();
            }

            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        }
    }

}
    }1
}

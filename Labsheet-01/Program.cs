using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c__tute_1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height:");
            int height = int.Parse(Console.ReadLine());

            int rectangleArea = CalculateArea(width, height);

            Console.WriteLine("The area is: " + rectangleArea);
            Console.ReadLine();
        }

        static int CalculateArea(int w, int h)
        {
            return w * h;
        }
    }
}



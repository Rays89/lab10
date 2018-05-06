using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static int Numofcircle = 0;
        static void Main(string[] args)
        {

            bool repeat = true;


            Circle pie = new Circle();//instatiating 

            Console.WriteLine("Welcome to the Circle Tester ");

            while (repeat)
            {
            Console.WriteLine("Enter radius:");

            pie.Radius = double.Parse(Console.ReadLine());//coz its a string so you have to parse it

            Console.WriteLine($"The Area is {pie.CalculateArea()}");
            Console.WriteLine($"The Circumference is {pie.CalculateCircumference()}");
            Console.WriteLine($"The FormattedCircumference is {pie.calculateFormattedCircumference()}");
                Numofcircle++;

            while(true)
                {
                    Console.WriteLine("(n) do you want to quit or (y) to add another circle?");
                    string input = Console.ReadLine();

                    if(input == "n")

                    {

                        Console.WriteLine($"you added {Numofcircle} circle, goodbye");
                        repeat = false;
                        break;
                    }

                    else if(input == "y")
                    {
                        break;
                    }

                    else
                    {

                        Console.WriteLine("Invalid input, please try again later");
                    }

                }

                                                 
            }
        }
    }
}
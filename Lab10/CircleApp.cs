using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class CircleApp
    {
        public List<Circle> Circles = new List<Circle>();
        private string[] Naming = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "nineth", "tenth" };

        public void PrintCircles()
        {
            for (int i = 0; i < Circles.Count; i++)
            {
                Console.WriteLine($"Here is the info for the {Naming[i]} circle:\n");
                Circles[i].PrintInfo();
            }
        }

        //Validator committed a hostile takeover!
        //public bool YayOrNay(string YN)
        //{
        //    if (YN == "Y")
        //    {
        //        return true;
        //    }
        //    else if (YN == "N")
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter Y or N");
        //        YayOrNay(Console.ReadLine().ToUpper());
        //    }
        //    return false;
        //}

        public void Run()
        {
            bool run = true;
            Console.WriteLine("Welcome to the Circle Radius and Circumference and Other Stuff Thing!\n");
            while (run)
            {
                if (Circles.Count != Naming.Length)
                {
                    Console.WriteLine("What is the radius of the circle you'd like to add?");
                    double dRadius;

                    Validator.DoubleInput(Console.ReadLine(), out dRadius);

                    //code before creating the validator
                    //try
                    //{
                    //    dRadius = Convert.ToDouble(sRadius);
                    //}
                    //catch (Exception)
                    //{
                    //    Console.WriteLine("Please enter a number.\n");
                    //    continue;
                    //}

                    Circle circle = new Circle(dRadius);
                    Circles.Add(circle);

                    Console.WriteLine("Would you like to add another? (Y/N)");
                    if (Validator.YayOrNay(Console.ReadLine().ToUpper()))
                    {
                        continue;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Sorry bud, I can only remember ten circles. How many circles do you really need to know about anyway? " +
                        "\nAny key to continue...");
                    Console.ReadKey();
                }

                PrintCircles();

                Console.WriteLine("That's all I got PEACE!");
                Console.ReadKey();

                run = false;
            }
        }
    }
}

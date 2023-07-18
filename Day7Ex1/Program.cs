using System;
using ShapeAreaLib;

namespace Day7Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Rectangle r = new Rectangle();
                Square s = new Square();    
                Circle c = new Circle();
                Triangle t = new Triangle();
                Console.WriteLine("Find area of:\n1.Rectangle\n2.Square\n3.Circle\n4.Triangle");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                { 
                    case 1:
                        {
                            Console.WriteLine("Enter length:");
                            double l =double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter breadth:");
                            double b = double.Parse(Console.ReadLine());
                            double result = r.Area(l,b);
                            Console.WriteLine($"Area of rectangle : {result}");
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Enter side:");
                            double side = double.Parse(Console.ReadLine());
                            double sresult = s.Area(side);
                            Console.WriteLine($"Area of Square : {sresult}");
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter radius:");
                            double radius = double.Parse(Console.ReadLine());
                            double cresult = c.Area(radius);
                            Console.WriteLine($"Area of circle : {cresult}");
                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("Enter base:");
                            double ba = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter height:");
                            double height = double.Parse(Console.ReadLine());
                            double tresult = t.Area(ba, height);
                            Console.WriteLine($"Area of triangle : {tresult}");
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice!");
                            return;

                        }
                        
                }
                Console.WriteLine("Press y to continue ");
                 choice = Console.ReadLine().ToLower();

            }
            while (choice == "y");

        }
    }
}

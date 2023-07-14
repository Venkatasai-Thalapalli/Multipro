using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            Console.WriteLine($" Area of the rectangle : {r.area(20,40)}");
            Console.WriteLine($" Length of the rectangle : {r.l(20, 40)}");
            Console.WriteLine($" Breadth of the rectangle : {r.b(20, 40)}");
            Console.ReadKey();
        }
    }
}

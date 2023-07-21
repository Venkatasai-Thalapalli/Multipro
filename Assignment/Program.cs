using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LargeDataCollection data =new LargeDataCollection();
            Console.WriteLine("Initial List:");
            data.Display();
            Console.WriteLine("Enter the name of fruit to add");
            string element = Console.ReadLine();
            data.AddElement(element);
            Console.WriteLine("Enter the name of fruit to remove");
            string element1 = Console.ReadLine();
            data.RemoveElement(element1);
            Console.WriteLine("Enter the name of fruit to accesss:");
            string element2 = Console.ReadLine();
            data.AccessElement(element2);
            Console.WriteLine("Updated List:");
            data.Display();
            data.Dispose();
            Console.ReadKey();

        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex1
{
    public class Product
    {
        int pid;
        string pname;
        double pprice;

        public virtual void Details()
        {
            Console.WriteLine( "Enter Product ID: ");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product name: ");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Product price: ");
            pprice = double.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine( $"Product Details:\nID: {pid}\nName: {pname}\nPrice: {pprice}");
        }
    }
}

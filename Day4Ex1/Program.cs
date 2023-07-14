using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Details();
            p.Display();

            HerbalProduct hp= new HerbalProduct();
            hp.Details();
            hp.Display();
            Console.ReadKey();
        }
    }
}

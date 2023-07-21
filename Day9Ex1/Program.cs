using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string path = "C:\\Genpact\\";
            string foldername = "Employee";
            string fpath = path + foldername;
            DirectoryInfo dir = new DirectoryInfo(fpath);


            Console.WriteLine("Enter employee name:");
            string ename= Console.ReadLine();
            Console.WriteLine("Enter employee date of birth");
          
        }
    }
}

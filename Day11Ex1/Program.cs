using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Day11Ex1
{
    internal class Program
    {
        static string fpath;
        static void Main(string[] args)
        {
            
                string path = "C:\\Genpact\\Projects\\";
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter DOB");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                fpath = path + name + "_" + dob.ToShortDateString() + ".txt";
                File.Create(fpath).Close();
                Console.WriteLine("File Created");

            WriteMethod();
            ReadMethod();
            Console.ReadKey();
          
        }
    }
}

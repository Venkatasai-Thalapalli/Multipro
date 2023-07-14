using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            Console.WriteLine("Enter ID:");
            Emp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            Emp.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Employee details are as follows:");
            Console.WriteLine($"ID:{Emp.Id}\nName: {Emp.Name}\nSalary: {Emp.Salary}");
 
            Console.ReadKey();
        }
    }
}

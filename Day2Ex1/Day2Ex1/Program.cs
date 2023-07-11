using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Ex1
{
    public class Emp
    {
        public int Salary(int hours, int days, int project = 1, int extras = 0)
        {
            int calc = (hours * days * 100) + (project * 3000) + (extras * 2000);
            return calc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string emptype;
            Emp emp = new Emp();
            Console.WriteLine("Enter employee type:");
            emptype = Console.ReadLine();
            switch (emptype)
            {
                case "HR":
                    {
                        Console.WriteLine("Enter Working Hours and Days:");
                        int h = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Salary of {emptype} is : {emp.Salary(h, d)}");
                        break;
                    }
                case "Admin":
                    {
                        Console.WriteLine("Enter Working Hours,Days and Project Handles:");
                        int h = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Salary of {emptype} is :{emp.Salary(h, d, p)} ");
                        break;

                    }
                case "SDE":
                    {
                        Console.WriteLine("Enter Working Hours,Days and Project Handles and extras:");
                        int h = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        int p = int.Parse(Console.ReadLine());
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Salary of {emptype} is :{emp.Salary(h, d, p, e)}");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}

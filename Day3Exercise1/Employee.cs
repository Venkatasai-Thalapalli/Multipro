using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise1
{
    public class Employee
    {
        int id;
        string name;
        double salary;

        public int Id { get; set; }
        public string Name
        { 
            get 
            {
                if (name.Length >= 6)
                {
                    return name;
                }
                return "Invalid Name";
               
            }
            set
            {
                name = value;
            }

        }
        public double Salary { get; set; }

    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day6Ex1
{
    internal class Program
    {
       static SortedList<int, Customer> customerList = new SortedList<int, Customer>()
                {
                { 1, new Customer() { CName = "A",CCity = "Hyderabad", ODLimit = 1000.10}},
                 { 2, new Customer() { CName = "B", CCity = "Banglore", ODLimit = 2000.50 }},
                 { 3, new Customer() { CName = "C", CCity = "Chennai", ODLimit = 1000.50 }},
                 { 4, new Customer() { CName = "D", CCity = "Mumbai", ODLimit = 2000.10 }},
                 { 5, new Customer() { CName = "E", CCity = "Delhi", ODLimit = 3000.10 }}

            };
        static void Main(string[] args)
        {
            Console.WriteLine("Initial list:");
            foreach(KeyValuePair<int, Customer> k in customerList)
            {
                Console.WriteLine($"{k.Key}:-> {k.Value.CName} {k.Value.CCity} {k.Value.ODLimit}");
            }
            Console.WriteLine("Enter the Customer number you want to remove:");
            int x = int.Parse(Console.ReadLine());
            RemoveList(x);
            Console.ReadKey();

        }
        public static void RemoveList(int y)
        {
            if(customerList.ContainsKey(y))
            {
                customerList.Remove(y);
                Console.WriteLine($"List after removing {y}");
                foreach(KeyValuePair<int, Customer> cmr in customerList)
                {
                    Console.WriteLine($"{cmr.Key} :-> {cmr.Value.CName} {cmr.Value.CCity} {cmr.Value.ODLimit}");
                }  
            }
            else { Console.WriteLine("Not found"); }
        }
    }
}

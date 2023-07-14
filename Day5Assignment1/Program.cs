using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment1
{
    public class MyClass
    {
       static ArrayList fruits;
        public static void Main(string[] args)
        {
            fruits = new ArrayList { "apple", "banana", "cherry", "date", "elderberry" };
            Console.WriteLine($"Total number of elements in the ArrayList: {fruits.Count}");
            Display();
            Console.WriteLine("Enter an element to search");
            string e = Console.ReadLine();
            Search(e);
            Display();
            Console.WriteLine("Enter an element to remove:");
            string r = Console.ReadLine();
            Remove(r);
            Display();
            Console.ReadKey();



        }
           public static void Display()
            {
            Console.WriteLine("Elements in the Arraylist are:");
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            
            }

             public static void Search(string val)
        {
            Console.WriteLine("Enter fruit to search:");
            foreach (string item in fruits)
            {
                if(item == val)
                {
                    Console.WriteLine($"{val} found");
                }
                else
                {
                    Console.WriteLine($"{val} not found");
                }
            }
            
        }

        public static void Remove(string x)
        {
            
          

                fruits.Remove(x);
            
            

        }

        
     






            

        
    }
}

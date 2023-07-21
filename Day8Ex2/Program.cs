using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Ex2
{
    internal class Program
    {
        public delegate void Sort(int[] arr);
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of array:");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Element {i+1}:");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr, delegate (int x, int y)
            {
                return x.CompareTo(y);
            });


           Console.WriteLine("Sorted Array:");
            foreach(var ele in arr)
            {
                Console.WriteLine($"{ele}\t");
            }
            Console.ReadKey();
       
            
        }
    }
}

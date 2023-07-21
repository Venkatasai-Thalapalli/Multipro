using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<string> fruits = new List<string>() ;
        int count;
        bool disposedValue;

        public LargeDataCollection()
        {
            Console.WriteLine("Enter the number of fruits:");
            count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the fruit to add");
                fruits.Add(Console.ReadLine());
            }
            
        }
        public void Display()
        {
          
            foreach(var f in fruits)
            {
                Console.WriteLine(f);
            }
        }
        public void AddElement (string element)
        {
            fruits.Add(element);
            count++;
        }
        public void RemoveElement (string element)
        {
            int index = fruits.IndexOf(element);
            if(index == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                fruits.Remove(element);
            }
            

        }
        public void AccessElement(string element)
        {
            int index = fruits.IndexOf(element);
            if (index == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"Index:{index}"); 
            }
        }


        public virtual void Dispose(bool disposing) {
            if (!disposedValue)
            {
                if (disposing)
                {
                    count = 0;
                }
                Console.WriteLine("Fruits list has been disposed. ");
                fruits = null;
                disposedValue = true;
            }
         

        }

        public void Dispose()
        {
           Dispose(true);
            GC.SuppressFinalize(this);
        }

      

    }
}

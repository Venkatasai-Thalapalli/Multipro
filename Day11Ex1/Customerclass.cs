using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Day11Ex1
{
    [Serializable]
    internal class Customer
    {
        public int ID { get; set; }
      
        public string name { get; set; }
        public string city { get; set; }
        public string address { get; set; }


        public static void WriteMethod()
        {
            Customer cus = new Customer();
            Console.WriteLine("Enter Customer name:");
            cus.name = Console.ReadLine();
            Console.WriteLine("Enter Customer ID:");
            cus.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer City:");
            cus.city = Console.ReadLine();
            Console.WriteLine("Enter Customer Address:");
            cus.address = Console.ReadLine();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fpath, FileMode.Open, FileAccess.Write);
            formatter.Serialize(stream, cus);
            stream.Close();
        }

        public static void ReadMethod()
        {
            Stream stream = new FileStream(fpath, FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            Customer cus = (Customer)formatter.Deserialize(stream);
            Console.WriteLine($"Customer Details:\n{cus.ID}\n{cus.name}\n{cus.city}\n{cus.address}\n");


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex1
{
    public class HerbalProduct : Product
    {
        string herbsused;
        DateTime mfDate;
        DateTime expDate;
        public override void Details()
        {
            base.Details();
            Console.WriteLine( "Enter the herbs used:");
            herbsused=Console.ReadLine();
            Console.WriteLine("Enter the Mfdate:");
            mfDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ExpDate:");
            expDate=DateTime.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"HerbalProduct details: \nHerbs used: {herbsused}\nMfDate: {mfDate}\nExpDate: {expDate}");
        }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day6Ex2
{
   public class ValidationException: Exception {
        public ValidationException(string msg):base (msg)
        {
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserReg();
                Console.WriteLine("Registration Successful");

            }
            catch (ValidationException e)
            {
                Console.WriteLine($"Registration failed! {e.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error!{ex.Message}");
            }
            finally { Console.ReadLine(); }
            





        }

        public static void UserReg()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email)  || string.IsNullOrEmpty(password) ){
                throw new ValidationException("Missing values. Please provide info");

            }
            if(name.Length <= 6)
            {
                throw new ValidationException("Error! Please enter valid name. ");

            }

        }
    }
}

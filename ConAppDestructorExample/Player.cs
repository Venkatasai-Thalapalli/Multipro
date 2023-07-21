using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDestructorExample
{
    public class Player
    {
        int id;
        string name;
        static int count;

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine($"Player Constructor Call ID: {id} {name}");
            count++;
        }
        public static int Count { get { return count; } }

        ~Player()
        {
            Console.WriteLine($"Destructor Called ID {id} {name}");
        }
    }
}

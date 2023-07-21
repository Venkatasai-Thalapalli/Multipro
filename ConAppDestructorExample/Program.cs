using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDestructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(12, "MSD");
            Console.WriteLine($"number of players are: {Player.Count}");

            Player player2 = new Player(12, "MSD");
            Console.WriteLine($"number of players are: {Player.Count}");

            player1 = null;
            player2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadKey();

        }
    }
}

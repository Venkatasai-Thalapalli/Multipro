using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Day8Ex1
{
    public delegate void SpinGame();
    public class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            SpinGame spingame = new SpinGame(g.FirstSpin);
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your lucky number between 1 to 10");
                int Luckynumber = int.Parse(Console.ReadLine());
                switch (Luckynumber)
                {
                    case 1:
                        {
                            spingame += g.FirstSpin;
                            break;
                        }
                    case 2:
                        {
                            spingame += g.SecondSpin;
                            break;
                        }
                    case 3:
                        {
                            spingame += g.ThirdSpin;
                            break;
                        }
                    case 4:
                        {
                            spingame += g.FourthSpin;
                            break;
                        }
                    case 5:
                        {
                            spingame += g.FifthSpin;
                            break;
                        }
                    case 6:
                        {
                            spingame += g.SixthSpin;
                            break;
                        }
                    case 7:
                        {
                            spingame += g.SeventhSpin;
                            break;
                        }
                    case 8:
                        {
                            spingame += g.EighthSpin;
                            break;
                        }
                    case 9:
                        {
                            spingame += g.NinthSpin;
                            break;
                        }
                    case 10:
                        {
                            spingame += g.TenthSpin;
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("invalid number");
                            return;
                        }
                }

            }
            Console.WriteLine("Result:");
            spingame();
            if(g.EL >= 4 && g.WP > 60)
            {
                Console.WriteLine("winner");
            }
            else if (g.EL>= 1 && g.WP > 50)
            {
                Console.WriteLine("runner up");
            }
            else
            {
                Console.WriteLine("loser");
            }
            Console.ReadKey();
        }
    }
}

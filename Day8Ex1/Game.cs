using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Day8Ex1
{
    public class Game
    {
        int el;
        int wp;
        int s;

        public int EL { get { return el; }  }
        public int WP { get { return wp; } }
        public void InitialSpin()
        {
            el = 1;
            wp = 100;
            s = 5;   
        }
        public void FirstSpin()
        {
            el += 1;
            wp += 10;    
        }
        public void SecondSpin()
        {
            el += 2;
            wp += 20;
        }
        public void ThirdSpin()
        {
            el -= 3;
            wp -= 30;
        }
        public void FourthSpin()
        {
            el += 4;
            wp += 40;
        }
        public void FifthSpin()
        {
            el -= 5;
            wp -= 50;
        }
        public void SixthSpin()
        {
            el -= 1;
            wp -= 60;
        }
        public void SeventhSpin()
        {
            el += 1;
            wp += 70;
        }
        public void EighthSpin()
        {
            el -= 2;
            wp -= 20;
        }
        public void NinthSpin()
        {
            el -= 3;
            wp -= 30;
        }
        public void TenthSpin()
        {
            el += 10;
            wp += 100;
        }
    }
}

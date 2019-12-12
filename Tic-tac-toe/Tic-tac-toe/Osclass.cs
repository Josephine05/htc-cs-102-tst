using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    class Osclass : Players
    
    {
        public Osclass(int Oswins, string Osnames)
        {
            this.wins = Oswins;
            this.names = Osnames;
        }
    }
}

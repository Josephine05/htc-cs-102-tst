using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    class Xsclass : Players
    {
        public Xsclass(int Xswins, string Xsnames)
        {
            this.wins = Xswins;
            this.names = Xsnames;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tic_tac_toe
{
    class Players
    {
        public int wins;

        public string names;

        public void Iwin()
        {
            ++wins;
            MessageBox.Show(names + " wins!" + names + " has " + wins + " wins");
        }
        public void Names()
        {
            
        }
    }

 
}

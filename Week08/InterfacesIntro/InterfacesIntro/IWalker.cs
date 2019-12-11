using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    interface IWalker
    {

        double NumLegs { get; set; }
        double strideLength { get; set; }

        void walk();
    }
}

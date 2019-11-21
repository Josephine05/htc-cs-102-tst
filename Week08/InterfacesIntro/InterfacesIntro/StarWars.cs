using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class StarWars : Robot
    {
        public StarWars(int height, string name, double numlegs, double stridelength)
        {
            this.Height = height;
            this.Name = name;
            this.NumLegs = numlegs;
            this.strideLength = stridelength;
        }
    }
}

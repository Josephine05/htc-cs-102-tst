using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    class Robot : IWalker
    {
        public double NumLegs { get; set; }
        public double strideLength { get; set; }
        public string Name { get; set;  }
        public int Height { get; set; }
        
        public void walk()
        {
            MessageBox.Show("Beep Boop " + NumLegs + "legs");
        }
    }
}

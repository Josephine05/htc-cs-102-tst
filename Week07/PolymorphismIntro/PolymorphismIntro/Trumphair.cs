using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    class Trumphair:Animal
    {
        public override void Speak()
        {
            MessageBox.Show("Taco Tuesday");
        }

        public Trumphair() { }

        public Trumphair(int height, string name, string type, int weight)
        {
            this.Height = height;
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
        }
    }

}

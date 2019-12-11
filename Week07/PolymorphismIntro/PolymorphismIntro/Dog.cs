using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Dog : Animal, Ianimal
    {
        public string Breed;
        public string HairColor { get; set; }

        public override void Speak()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name, string type, int weight)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
        }
    }
}
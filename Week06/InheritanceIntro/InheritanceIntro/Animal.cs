using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Animal
    {
        public int Height;
        public string Name;

        public void sayName()
        {
            MessageBox.Show("My name is " + Name);
        }
    }
}

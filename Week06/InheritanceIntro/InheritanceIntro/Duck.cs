﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Duck : Animal
    {

        // public string Name;
        //public int Height;

        public void Quack()
        {
            MessageBox.Show("Quack");
        }
        // public void SayName()
        // {
        //     MessageBox.Show($"My name is {Name} and I am a duck");
        //  }

        public Duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;

        }
    }
}

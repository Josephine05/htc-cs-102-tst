using System;

public class Class1
{
    public class Duck : Animal
    {
        public string Name;
        public int Height;

        public void Quack()
        {
            MessageBox.Show("Quack");
        }
        public void SayName()
        {
            MessageBox.Show($"My name is {Name} and I am a duck");
        }

        public Duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }
    

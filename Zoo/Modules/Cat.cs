using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Cat : Animal
    {
        public Cat(string Name, int Age, int Height, string Class, string Order, string Color) : base(Name, Age, Height, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Class = Class;
            this.Order = Order;
            this.Color = Color;
        }
        public string Color;
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Fetch()
        {
            Console.WriteLine("The cat does not want to fetch");
        }

        public override void Roll()
        {
            Console.WriteLine("The cat does not want to roll");
        }

        public override void Sit()
        {
            Console.WriteLine("The cat does not want tot sit");
        }

        public void Purr()
        {
            Console.WriteLine("Purrrr");
        }
    }
}

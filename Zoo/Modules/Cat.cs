using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Cat : Animal
    {
        public Cat(string Name, int Age, decimal Weigth, string Class = "Mammal", string Order = "Carnivore", string Color = "Unkown") : base(Name, Age, Weigth, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
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

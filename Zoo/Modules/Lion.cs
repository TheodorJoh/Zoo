using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Lion : Animal
    {
        public Lion(string Name, int Age, decimal Weigth, string Class = "Mammal", string Order = "Carnivore", string Mane = "Unknown") : base(Name, Age, Weigth, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = Class;
            this.Order = Order;
            this.Mane = Mane;
        }
        public string Mane { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Rooooooarrr");
        }

        public override void Fetch()
        {
            Console.WriteLine("The lion does not want to play fetch");
        }

        public override void Roll()
        {
            Console.WriteLine("The lion does not want to roll");
        }

        public override void Sit()
        {
            Console.WriteLine("The lion does not want to sit");
        }

        public void Intimidate()
        {
            Console.WriteLine("The lion roars intimidatingly");
        }
    }
}

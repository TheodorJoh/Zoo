using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Ragdoll : Cat
    {
        public Ragdoll(string Name, int Age, decimal Weigth, string Class = "Mammal", string Order = "Carnivore", string Color = "Unknown", string Fur = "Unknown") : base(Name, Age, Weigth, Class, Order, Color)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = Class;
            this.Order = Order;
            this.Color = Color;
            this.Fur = Fur;
        }
        public string Fur {  get; set; }
        public void Cuddle()
        {
            Console.WriteLine("The cat cuddles you");
        }
    }
}

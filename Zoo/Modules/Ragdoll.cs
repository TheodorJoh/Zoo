using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Ragdoll : Cat
    {
        public Ragdoll(string Name, int Age, int Height, string Class, string Order) : base(Name, Age, Height, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Class = Class;
            this.Order = Order;
        }
        public string Fur {  get; set; }
        public void Cuddle()
        {
            Console.WriteLine("The cat cuddles you");
        }
    }
}

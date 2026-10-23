using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class BritishLongHair : Cat
    {
        public BritishLongHair(string Name, int Age, decimal Weigth, string Class, string Order, string Color, string Temprement = "Unknown") : base(Name, Age, Weigth, Class, Order, Color)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = Class;
            this.Order = Order;
            this.Temprement = Temprement;
        }
        public string Temprement;
        public void RunLikeCrazy()
        {
            Console.WriteLine("Cat runs around like crazy");
        }
    }
}

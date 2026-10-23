using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class BritishLongHair : Cat
    {
        public BritishLongHair(string Name, int Age, int Height, string Class, string Order, string Color, string Temprement) : base(Name, Age, Height, Class, Order, Color)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Fox : Animal
    {
        public Fox(string Name, int Age, decimal Weigth, string Class = "Mammal", string Order = "Carnivore", string Sound = "Ringinging") : base(Name, Age, Weigth, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = Class;
            this.Order = Order;
            this.Sound = Sound;
        }
        public string Sound {  get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Ringigingnging");
        }
        public override void Fetch()
        {
            Console.WriteLine("The fox runs for the stick");
        }

        public override void Roll()
        {
            Console.WriteLine("The fox rolls");
        }

        public override void Sit()
        {
            Console.WriteLine("The fox sits");
        }

        public void WhatDoesTheFoxSay()
        {
            Console.WriteLine($"The fox says {Sound}");
        }
    }
}

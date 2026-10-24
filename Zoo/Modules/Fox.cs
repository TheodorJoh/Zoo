using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Zoo.Modules
{
    public class Fox : Animal
    {
        public Fox(string Name = "Unknown", int Age = -1, decimal Weight = -1, string Sound = "Ringinging") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Diet = "Carnivore";
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
        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($" Sound: {Sound}");
        }
    }
}

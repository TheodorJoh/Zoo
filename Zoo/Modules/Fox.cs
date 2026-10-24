using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Fox : Animal
    {
        public Fox(string Name, int Age, decimal Weight, string Sound = "Ringinging") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Order = "Carnivore";
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
            Console.WriteLine("Fox:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Order: {Order}\n Sound:{Sound}\n");
        }
    }
}

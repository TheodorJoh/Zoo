using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //Fox
    //Child class to Animal
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // Sound : String that stands for the sound of the fox
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

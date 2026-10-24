using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //Cat
    //Child class to Animal
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // Color : String that stands for the color of the cat
    public class Cat : Animal
    {
        public Cat(string Name = "Unknown", int Age = -1, decimal Weight = -1, string Color = "Unknown") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Diet = "Carnivore";
            this.Color = Color;
        }
        public string Color {  get; set; }
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
            Console.WriteLine("The cat does not want to sit");
        }

        public void Purr()
        {
            Console.WriteLine("Purrrr");
        }

        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($" Color: {Color}");
        }
    }
}

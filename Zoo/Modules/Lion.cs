using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //Lion
    //Child class to Animal
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // Mane : String that stands for the mane of the Lion
    public class Lion : Animal
    {
        public Lion(string Name = "Unknown", int Age = -1, decimal Weight = -1, string Mane = "Unknown") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Diet = "Carnivore";
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
        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($" Mane: {Mane}");
        }
    }
}

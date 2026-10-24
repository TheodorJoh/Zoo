using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Cat : Animal
    {
        public Cat(string Name, int Age, decimal Weight, string Color = "Unknown") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Diet = "Carnivore";
            this.Color = Color;
        }
        public string Color;
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
            Console.WriteLine("The cat does not want tot sit");
        }

        public void Purr()
        {
            Console.WriteLine("Purrrr");
        }

        public override void PrintAnimalInfo()
        {
            Console.WriteLine("Cat:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Diet: {Diet}\n Color: {Color}\n");
        }
    }
}

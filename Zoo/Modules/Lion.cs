using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Lion : Animal
    {
        public Lion(string Name, int Age, decimal Weigth, string Mane = "Unknown") : base(Name, Age, Weigth)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = "Mammal";
            this.Order = "Carnivore";
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
            Console.WriteLine("Lion:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weigth: {Weigth}\n Class: {Class}\n Order: {Order}\n Mane: {Mane}\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Dog : Animal
    {
        public Dog(string Name, int Age, decimal Weight, string Size = "Unknown") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Order = "Carnivore";
            this.Size = Size;
        }
        public string Size {  get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Wooof");
        }
        public override void Fetch()
        {
            Console.WriteLine("The dog runs for the stick");
        }

        public override void Roll()
        {
            Console.WriteLine("The dog rolls");
        }

        public override void Sit()
        {
            Console.WriteLine("The dog sits");
        }

        public void Guard()
        {
            Console.WriteLine("The dog guards valiantly");
        }
        public override void PrintAnimalInfo()
        {
            Console.WriteLine("Dog:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Order: {Order}\n Size: {Size}\n");
        }
    }
}

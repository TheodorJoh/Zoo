using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //Dog
    //Child class to Animal
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // Size : String that stands for the size of the dog
    public class Dog : Animal
    {
        public Dog(string Name = "Unknown", int Age = -1, decimal Weight = -1, string Size = "Unknown") : base(Name, Age, Weight)
        {
            this.Class = "Mammal";
            this.Diet = "Carnivore";
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
            base.PrintAnimalInfo();
            Console.WriteLine($" Size: {Size}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //Parrot
    //Child class to Animal
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // TalonSize : String that stands for the TalonSize of the Parrot
    public class Parrot : Animal
    {
        public Parrot(string Name = "Unknown", int Age = -1, decimal Weight = -1, string TalonSize = "Unknown") : base(Name, Age, Weight)
        {
            this.Class = "Bird";
            this.Diet = "Omnivore";
            this.TalonSize = TalonSize;
        }
        public string TalonSize {  get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Cawwww");
        }

        public override void Fetch()
        {
            Console.WriteLine("The parrot tries to catch the stick but it is too heavy");
        }

        public override void Roll()
        {
            Console.WriteLine("The parrot does a barrel roll");
        }

        public override void Sit()
        {
            Console.WriteLine("The parrot sits on a little stick");
        }

        public void Imitate(string Input)
        {
            Console.WriteLine($"{Input} cawwwwww");
        }
        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($" TalonSize: {TalonSize}");
        }
    }
}

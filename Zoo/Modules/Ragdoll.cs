using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //Ragdoll
    //Child class to Cat
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // Color : String that stands for the color of the cat
    // Fur : String that stands for the fur of the cat
    public class Ragdoll : Cat
    {
        public Ragdoll(string Name = "Unknown", int Age = -1, decimal Weight = -1, string Color = "Unknown", string Fur = "Unknown") : base(Name, Age, Weight, Color)
        {
            this.Fur = Fur;
        }
        public string Fur {  get; set; }
        public void Cuddle()
        {
            Console.WriteLine("The cat cuddles you");
        }
        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($" Fur: {Fur}");
        }
    }
}

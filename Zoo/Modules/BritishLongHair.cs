using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    //BritishLongHair
    //Child class to Cat
    // Name : String that stands for the name of an animal
    // Age : String that stands for the age of an animal
    // Weight : Integer that stands for the weight of an animal
    // Class : String that stands for the class of an animal (For example cats are Mammals)
    // Diet : String that stands for the diet of an animal
    // Color : String that stands for the color of the cat
    // Temperament : String that stands for the temperament of the BritishLongHair
    public class BritishLongHair : Cat
    {
        public BritishLongHair(string Name = "Unknown", int Age = -1, decimal Weight = -1, string Color = "Unknown", string Temperament = "Unknown") : base(Name, Age, Weight, Color)
        {
            this.Temperament = Temperament;
        }
        public string Temperament { get; set; }
        public void RunLikeCrazy()
        {
            Console.WriteLine("Cat runs around like crazy");
        }
        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($" Temperament: {Temperament}");
        }

    }
}

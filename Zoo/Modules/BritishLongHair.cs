using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class BritishLongHair : Cat
    {
        public BritishLongHair(string Name, int Age, decimal Weight, string Color, string Temprement = "Unknown") : base(Name, Age, Weight, Color)
        {
            this.Temprement = Temprement;
        }
        public string Temprement;
        public void RunLikeCrazy()
        {
            Console.WriteLine("Cat runs around like crazy");
        }
        public override void PrintAnimalInfo()
        {
            Console.WriteLine("BritishLongHair:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Diet: {Diet}\n Color: {Color}\n Temprement: {Temprement}\n");
        }

    }
}

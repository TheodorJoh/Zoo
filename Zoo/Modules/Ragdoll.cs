using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Ragdoll : Cat
    {
        public Ragdoll(string Name, int Age, decimal Weight, string Color = "Unknown", string Fur = "Unknown") : base(Name, Age, Weight, Color)
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
            Console.WriteLine("Ragdoll:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Diet: {Diet}\n Color: {Color}\n Fur: {Fur}\n");
        }
    }
}

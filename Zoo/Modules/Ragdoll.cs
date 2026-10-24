using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Ragdoll : Cat
    {
        public Ragdoll(string Name, int Age, decimal Weigth, string Color = "Unknown", string Fur = "Unknown") : base(Name, Age, Weigth, Color)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = "Mammal";
            this.Order = "Carnivore";
            this.Color = Color;
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
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weigth: {Weigth}\n Class: {Class}\n Order: {Order}\n Color: {Color}\n Fur: {Fur}\n");
        }
    }
}

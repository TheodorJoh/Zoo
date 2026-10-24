using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
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

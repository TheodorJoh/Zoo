using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
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

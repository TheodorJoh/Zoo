using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Zoo.Modules
{
    public class Parrot : Animal
    {
        public Parrot(string Name, int Age, decimal Weight, string TalonSize = "Unknown") : base(Name, Age, Weight)
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
            Console.WriteLine("The parrot sits on its litte stick");
        }

        public void Imitate(string Input)
        {
            Console.WriteLine($"{Input} cawwwwww");
        }
        public override void PrintAnimalInfo()
        {
            Console.WriteLine("Parrot:");
            Console.WriteLine($"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Diet: {Diet}\n TalonSize: {TalonSize}\n");
        }
    }
}

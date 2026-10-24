using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Zoo.Modules
{
    public abstract class Animal
    {
        protected Animal(string Name = "Unknown", int Age = -1, decimal Weight = -1)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Class = "Unknown";
            this.Diet = "Unknown";
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }

        public string Class { get; set; }


        public string Diet { get; set; }


        public abstract void MakeSound();

        public abstract void Fetch();

        public abstract void Roll();

        public abstract void Sit();

        public virtual void PrintAnimalInfo()
        {
            Console.WriteLine($"{GetType().Name}:");
            Console.WriteLine($" Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Diet: {Diet}");
        }


    }
}

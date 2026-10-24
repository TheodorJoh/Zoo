using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Zoo.Modules
{
    public abstract class Animal
    {
        protected Animal(string Name = "Unknown", int Age = 0, decimal Weight = 0m)
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

        public abstract void PrintAnimalInfo();


    }
}

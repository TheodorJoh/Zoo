using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Zoo.Modules
{
    public abstract class Animal
    {
        protected Animal(string Name = "Unknown", int Age = 0, decimal Weigth = 0m)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = "Unknown";
            this.Order = "Unknown";
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Weigth { get; set; }

        public string Class { get; set; }


        public string Order { get; set; }


        public abstract void MakeSound();

        public abstract void Fetch();

        public abstract void Roll();

        public abstract void Sit();

        public abstract void PrintAnimalInfo();


    }
}

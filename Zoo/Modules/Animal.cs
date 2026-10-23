using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public abstract class Animal
    {
        protected Animal(string Name, int Age, int Height, string Class, string Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Class = Class;
            this.Order = Order;

        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public string Class { get; set; }

        public string Order { get; set; }


        public abstract void MakeSound();

        public abstract void Fetch();

        public abstract void Roll();

        public abstract void Sit();


    }
}

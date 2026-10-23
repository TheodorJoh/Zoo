using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Parrot : Animal
    {
        public Parrot(string Name, int Age, int Height, string Class, string Order) : base(Name, Age, Height, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Class = Class;
            this.Order = Order;
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
    }
}

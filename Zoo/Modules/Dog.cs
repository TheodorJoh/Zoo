using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Dog : Animal
    {
        public Dog(string Name, int Age, decimal Weigth, string Class ="Mammal", string Order = "Carnivore", string Size = "Unknown") : base(Name, Age, Weigth, Class, Order)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
            this.Class = Class;
            this.Order = Order;
            this.Size = Size;
        }
        public string Size {  get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Wooof");
        }
        public override void Fetch()
        {
            Console.WriteLine("The dog runs for the stick");
        }

        public override void Roll()
        {
            Console.WriteLine("The dog rolls");
        }

        public override void Sit()
        {
            Console.WriteLine("The dog sits");
        }

        public void Guard()
        {
            Console.WriteLine("The dog guards valiantly");
        }
    }
}

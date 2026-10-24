using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
//Animal
//Parent class
// Name : String that stands for the name of an animal
// Age : String that stands for the age of an animal
// Weight : Integer that stands for the weight of an animal
// Class : String that stands for the class of an animal (For example cats are Mammals)
// Diet : String that stands for the diet of an animal
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

        //Method that prints the sound an animal makes and is different for each animal
        public abstract void MakeSound();

        //Method that prints what happens if you try to play fetch with the animal
        public abstract void Fetch();

        //Method that prints what happens if you try to play roll with the animal
        public abstract void Roll();

        //Method that prints what happens if you try to make the animal sit
        public abstract void Sit();

        //Method that prints out all the information about the animal
        public virtual void PrintAnimalInfo()
        {
            Console.WriteLine($"{GetType().Name}:");
            Console.WriteLine($" Name: {Name}\n Age: {Age}\n Weight: {Weight}\n Class: {Class}\n Diet: {Diet}");
        }


    }
}

using Zoo.Modules;

namespace Zoo
{
    public abstract class Program
    {

        //Main
        //Initilized all the different classes and called their shared methods.
        static void Main(string[] args)
        {
            Console.WriteLine("-------");
            Ragdoll Miso = new Ragdoll("Mizo", 4, 4.4m, "Brown-Point", "Fluffy");
            Miso.MakeSound();
            Miso.Cuddle();
            Miso.PrintAnimalInfo();
            Console.WriteLine("-------");
            Cat Muffin = new Cat("Muffin", 14, 3.3m, "Grey");
            Muffin.MakeSound();
            Muffin.Purr();
            Muffin.PrintAnimalInfo();
            Console.WriteLine("-------");
            BritishLongHair Grace = new BritishLongHair("Grace", 1, 4m, "Golden-Brown");
            Grace.MakeSound();
            Grace.RunLikeCrazy();
            Grace.PrintAnimalInfo();
            Console.WriteLine("-------");
            Dog Ronja = new Dog("Ronja", 10, 10m, "Medium");
            Ronja.MakeSound();
            Ronja.Guard();
            Ronja.PrintAnimalInfo();
            Console.WriteLine("-------");
            Fox Kalle = new Fox("Kalle", 4, 5m, "Ringdigigng");
            Kalle.MakeSound();
            Kalle.WhatDoesTheFoxSay();
            Kalle.PrintAnimalInfo();
            Console.WriteLine("-------");
            Lion Liam = new Lion("Liam", 23, 85, "Beautiful");
            Liam.MakeSound();
            Liam.Intimidate();
            Liam.PrintAnimalInfo();
            Console.WriteLine("-------");
            Parrot Patrick = new Parrot("Patrick", 2, 1m, "Large");
            Patrick.MakeSound();
            Patrick.Imitate("Abstract is nice");
            Patrick.PrintAnimalInfo();
            Console.WriteLine("-------");
            Console.ReadKey();
        }
    }
}

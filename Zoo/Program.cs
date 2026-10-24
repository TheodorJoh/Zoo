using Zoo.Modules;

namespace Zoo
{
    public abstract class Program
    {


        static void Main(string[] args)
        {
            Ragdoll Miso = new Ragdoll("Mizo", 4, 4.4m, "Brown-Point", "Fluffy");
            Miso.MakeSound();
            Miso.PrintAnimalInfo();

            Cat Muffin = new Cat("Muffin", 14, 3.3m, "Grey");
            Muffin.MakeSound();
            Muffin.PrintAnimalInfo();

            BritishLongHair Grace = new BritishLongHair("Grace", 1, 4m, "Golden-Brown");
            Grace.MakeSound();
            Grace.PrintAnimalInfo();

            Dog Ronja = new Dog("Ronja", 10, 10m, "Medium");
            Ronja.MakeSound();
            Ronja.PrintAnimalInfo();

            Fox Kalle = new Fox("Kalle", 4, 5m, "Ringdigigng");
            Kalle.MakeSound();
            Kalle.PrintAnimalInfo();

            Lion Liam = new Lion("Liam", 23, 85, "Beautiful");
            Liam.MakeSound();
            Liam.PrintAnimalInfo();

            Parrot Patrick = new Parrot("Patrick", 2, 1m, "Large");
            Patrick.MakeSound();
            Patrick.PrintAnimalInfo();
        }
    }
}

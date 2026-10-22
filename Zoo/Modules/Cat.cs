using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Fetch()
        {
            Console.WriteLine("The cat does not want to fetch");
        }

        public override void Roll()
        {
            Console.WriteLine("The cat does not want to roll");
        }

        public override void Sit()
        {
            Console.WriteLine("The cat does not want tot sit");
        }

        public void Cuddly()
        {
            Console.WriteLine("The cats lets you cuddle");
        }
    }
}

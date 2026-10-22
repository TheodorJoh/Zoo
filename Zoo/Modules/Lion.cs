using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Rooooooarrr");
        }

        public override void Fetch()
        {
            Console.WriteLine("The lion does not want to play fetch");
        }

        public override void Roll()
        {
            Console.WriteLine("The lion does not want to roll");
        }

        public override void Sit()
        {
            Console.WriteLine("The lion does not want to sit");
        }
    }
}

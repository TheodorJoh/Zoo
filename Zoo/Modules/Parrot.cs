using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Parrot : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Kaaaaa");
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
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Modules
{
    public class Fox : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ringigingnging");
        }
        public override void Fetch()
        {
            Console.WriteLine("The fox runs for the stick");
        }

        public override void Roll()
        {
            Console.WriteLine("The fox rolls");
        }

        public override void Sit()
        {
            Console.WriteLine("The fox sits");
        }

        public void WhatDoesTheFoxSay()
        {
            Random rand = new Random();
            int Numb = rand.Next(1, 5);
            if(Numb == 1)
            {
                Console.WriteLine("The fox says bribrinbrinrbin");
            }
            else if(Numb == 2)
            {
                Console.WriteLine("The fox says kakakakak");
            }
            else if(Numb == 3)
            {
                Console.WriteLine("The fox says popopopo");
            }
            else if(Numb == 4)
            {
                Console.WriteLine("The fox says dakdakdakdakdak");
            }
            else if(Numb == 5)
            {
                Console.WriteLine("The fox says apapapapap");
            }
            else
            {
                MakeSound();
            }
        }
    }
}

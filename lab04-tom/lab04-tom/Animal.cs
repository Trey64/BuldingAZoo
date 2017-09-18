using System;
using System.Collections.Generic;
using System.Text;

namespace lab04tom
{
    abstract class Animal
    {
        public string Sound { get; set; }
        public string Reproduction { get; set; }
        public int Legs { get; set; }

        public string AnimalNoise()
        {
            string sound = Sound;
            Console.WriteLine(sound);
            return sound;
        }

        public int NumberOfLegs()
        {
            int legs = Legs;
            Console.WriteLine($"This animal has {legs} legs");
            return legs;
        }

        //abstract method
        public abstract void Eat();

    }




}

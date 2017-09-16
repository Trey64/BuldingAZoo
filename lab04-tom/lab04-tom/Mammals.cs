using System;
using System.Collections.Generic;
using System.Text;

namespace lab04tom
{
    abstract class Mammals : Animal
    {
       public bool Viviparous()
        {
            Console.WriteLine("Mammals give live birth");
            return true;
        }

        //abstract method
        public abstract bool Hibernate();

        public bool HaveLungs()
        {
            Console.WriteLine("Mammals breathe air!");
            return true;
        }
    }
}

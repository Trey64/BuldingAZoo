using System;
using System.Collections.Generic;
using System.Text;

namespace lab04tom
{
    abstract class Reptiles : Animal
    {
        //abstract method
        public abstract bool HasColdBlood();

       public bool Oviparous()
        {
            Console.WriteLine("Reptiles lay eggs");
            return true;
        }

        //abstract method
        public abstract bool SleepWithEyesOpen();

    }
}

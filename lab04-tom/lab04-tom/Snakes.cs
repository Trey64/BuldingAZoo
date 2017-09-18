using System;
using System.Collections.Generic;
using System.Text;

namespace lab04tom
{
    class Snakes : Reptiles
    {
        //overriding abstract method from base class
        public override void Eat()
        {
            Console.WriteLine("Snakes eat insects, birds, rodents, small mammals");
        }

        //overriding abstract method from parent class
        public override bool SleepWithEyesOpen()
        {
            Console.WriteLine("Snakes sleep with their eyes open");
            return true;
        }

        public bool ShedSkin()
        {
            Console.WriteLine("Snakes shed their skin");
            return true;
        }

        public override bool HasColdBlood()
        {
            Console.WriteLine("Snakes are cold blooded");
            return true;
        }
    }
}

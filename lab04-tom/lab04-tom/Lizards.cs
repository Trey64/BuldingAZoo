using System;
using System.Collections.Generic;
using System.Text;

namespace lab04tom
{
    class Lizards : Reptiles
    {
        public bool ChangesColor { get; set; }

        //overriding abstract method from base class
        public override void Eat() 
        {
            Console.WriteLine("Lizards eat insects, fruits, and plants");
        }

        //overriding abstract method from parent class
        public override bool HasColdBlood()
        {
            Console.WriteLine("Lizards are cold blooded");
            return true;
        }

        //overriding abstract method from parent class
        public override bool SleepWithEyesOpen()
        {
            Console.WriteLine("Some lizards don't have eyelids, but the lizards at this zoo close their eyes when sleeping");
            return false;
        }

        public bool HasCamo()
        {
            bool changesColor = ChangesColor;
            if (changesColor == true)
            {
                Console.WriteLine("Chameleons can change their color");
                return true;
            }
            else
            {
                Console.WriteLine("Only certain species of gecko can change their color");
                return false;
            }
        }

        }
}

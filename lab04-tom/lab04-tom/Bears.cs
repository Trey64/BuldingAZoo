using System;
using System.Collections.Generic;
using System.Text;

namespace lab04tom
{
    class Bears : Mammals
    {
        public string Color { get; set; }
        public string FaveFood { get; set; }
        public bool Hibernation { get; set; }

        public Bears(string color, string faveFood, bool hibernation)
        {
            Color = color;
            FaveFood = faveFood;
            Hibernation = hibernation;
        }

        public string BearMunchies()
        {
            string faveFood = FaveFood;
            Console.WriteLine($"This bear's favorite food is {faveFood} "); ;
            return faveFood;
        }

        //overriding abstract method from base class
        public override void Eat()
        {
            Console.WriteLine("Bears eat meat, fruits, and plants!");
        }

        //overriding abstract method from parent class
        public override bool Hibernate()
        {
            bool hibernation = Hibernation; 
            if (hibernation == true)
            {
                Console.WriteLine("This bear hibernates");
                return true;
            }
            else
            {
                Console.WriteLine("This bear migrates");
                return false;
            }
        }
    }
}
